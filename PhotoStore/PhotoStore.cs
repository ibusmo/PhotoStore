using PhotoStore.Filters;
using PhotoStore.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PhotoStore
{
    public partial class PhotoStore : Form
    {
        int loadedFilters = 0;
        int totalFilters = 0;
        List<Filter> filters = new List<Filter>();
        List<FilterPreview> filterControls = new List<FilterPreview>();

        public PhotoStore()
        {
            InitializeComponent();
        }

        private void PhotoStore_Load(object sender, EventArgs e)
        {
            filters.Add(new Filter());
            filters.Add(new ExampleFilter());
            filters.Add(new Filter());
            filters.Add(new ExampleFilter());
            filters.Add(new Filter());
            filters.Add(new ExampleFilter());
            filters.Add(new Filter());
            filters.Add(new ExampleFilter());
            filters.Add(new Filter());
            filters.Add(new ExampleFilter());

            totalFilters = filters.Count;
            loadFilters();
        }

        private void loadFilters()
        {
            if (filters.Count <= 0)
            {
                statusPanel.Visible = false;
                filterPanel.Enabled = true;
                return;
            }
            FilterInfo info = new FilterInfo();
            info.Callback = loadFilters;
            info.Filter = filters[0];
            info.Value = filters[0].GetMinimumValue() + ((filters[0].GetMaximumValue() - filters[0].GetMinimumValue()) / 2);
            info.Position = new Position(60, 45);
            info.Selection = new Selection(60);
            info.Selection.Width = 120;
            info.Selection.Height = 90;
            info.Image = Resources.Preview;
            processFilter(info);
        }

        private void loadFilters(FilterInfo info)
        {
            FilterPreview preview = new FilterPreview();
            if (info.Image != null)
            {
                preview.Image = info.Image;
            }
            else
            {
                preview.Image = Resources.Preview;
            }
            preview.Location = new Point(0, loadedFilters * 92);
            preview.Size = new Size(120, 90);
            preview.Filter = info.Filter;
            preview.onClick = filterTab_Click;
            filterControls.Add(preview);
            filterPanel.Controls.Add(preview);
            loadedFilters++;
            if (filters.Count > 0)
            {
                filters.RemoveAt(0);
                loadFilters();
            }
        }

        private void filterTab_Click(FilterPreview filterControl)
        {
            foreach(FilterPreview control in filterControls){
                if (control.Selected)
                {
                    control.Selected = false;
                    control.Invalidate();
                }
            }
            filterControl.Selected = true;
        }

        private void processFilter(FilterInfo info)
        {
            if (filters.Count <= 0)
            {
                progressBar.Value = 0;
                progressBar.Style = ProgressBarStyle.Marquee;
                statusTxt.Text = "Processing...";
            }
            statusPanel.Visible = true;
            imageProcessor.RunWorkerAsync(info);
        }

        private void imageProcessor_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = e.Argument;
            FilterInfo filterInfo = (FilterInfo)e.Argument;
            filterInfo.Image = filterInfo.Filter.RunFilter(imageProcessor, filterInfo.Value, filterInfo.Position, filterInfo.Selection, filterInfo.Image);
            e.Result = e.Argument;
        }

        private void imageProcessor_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Style = ProgressBarStyle.Continuous;
            if (filters.Count > 0)
            {
                int percent = (loadedFilters * 10) + (e.ProgressPercentage * 10 / 100) * 100 / (totalFilters * 10);
                statusTxt.Text = "Loading filters... " + percent + "%";
                progressBar.Value = percent;
            }
            else
            {
                if (e.ProgressPercentage < 0)
                {
                    progressBar.Value = 0;
                }
                else if (e.ProgressPercentage > 100)
                {
                    progressBar.Value = 100;
                }
                else
                {
                    progressBar.Value = e.ProgressPercentage;
                }
            }
        }

        private void imageProcessor_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            FilterInfo filterInfo = (FilterInfo)e.Result;
            if (filters.Count <= 0)
            {
                statusPanel.Visible = false;
            }
            if (filterInfo.Callback != null)
            {
                filterInfo.Callback(filterInfo);
            }
        }

        private void amountBar_Scroll(object sender, EventArgs e)
        {
            amountTxt.Text = amountBar.Value.ToString();
        }

        private void rectSelection_CheckedChanged(object sender, EventArgs e)
        {
            circleSelection.Checked = !rectSelection.Checked;
        }

        private void circleSelection_CheckedChanged(object sender, EventArgs e)
        {
            rectSelection.Checked = !circleSelection.Checked;
        }

        private void filterPanel_MouseEnter(object sender, EventArgs e)
        {
            filterPanel.Focus();
        }
    }
}
