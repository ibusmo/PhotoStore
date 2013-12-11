namespace PhotoStore
{
    partial class PhotoStore
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhotoStore));
            this.statusPanel = new System.Windows.Forms.Panel();
            this.statusTxt = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.imageProcessor = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filterPanel = new System.Windows.Forms.Panel();
            this.toolbarPanel = new System.Windows.Forms.Panel();
            this.amountBar = new System.Windows.Forms.TrackBar();
            this.amountTxt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.circleSelection = new System.Windows.Forms.RadioButton();
            this.rectSelection = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.statusPanel.SuspendLayout();
            this.toolbarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountBar)).BeginInit();
            this.SuspendLayout();
            // 
            // statusPanel
            // 
            this.statusPanel.BackColor = System.Drawing.Color.Black;
            this.statusPanel.Controls.Add(this.statusTxt);
            this.statusPanel.Controls.Add(this.progressBar);
            this.statusPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusPanel.ForeColor = System.Drawing.Color.White;
            this.statusPanel.Location = new System.Drawing.Point(0, 544);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(784, 17);
            this.statusPanel.TabIndex = 1;
            this.statusPanel.Visible = false;
            // 
            // statusTxt
            // 
            this.statusTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.statusTxt.Location = new System.Drawing.Point(664, 3);
            this.statusTxt.Name = "statusTxt";
            this.statusTxt.Size = new System.Drawing.Size(120, 14);
            this.statusTxt.TabIndex = 1;
            this.statusTxt.Text = "Preparing...";
            this.statusTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(3, 3);
            this.progressBar.MarqueeAnimationSpeed = 50;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(655, 14);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 0;
            // 
            // imageProcessor
            // 
            this.imageProcessor.WorkerReportsProgress = true;
            this.imageProcessor.DoWork += new System.ComponentModel.DoWorkEventHandler(this.imageProcessor_DoWork);
            this.imageProcessor.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.imageProcessor_ProgressChanged);
            this.imageProcessor.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.imageProcessor_RunWorkerCompleted);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filterPanel
            // 
            this.filterPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.filterPanel.AutoScroll = true;
            this.filterPanel.Enabled = false;
            this.filterPanel.Location = new System.Drawing.Point(3, 27);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Size = new System.Drawing.Size(150, 531);
            this.filterPanel.TabIndex = 0;
            this.filterPanel.MouseEnter += new System.EventHandler(this.filterPanel_MouseEnter);
            // 
            // toolbarPanel
            // 
            this.toolbarPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolbarPanel.Controls.Add(this.amountBar);
            this.toolbarPanel.Controls.Add(this.amountTxt);
            this.toolbarPanel.Controls.Add(this.label2);
            this.toolbarPanel.Controls.Add(this.circleSelection);
            this.toolbarPanel.Controls.Add(this.rectSelection);
            this.toolbarPanel.Controls.Add(this.label1);
            this.toolbarPanel.Location = new System.Drawing.Point(159, 27);
            this.toolbarPanel.Name = "toolbarPanel";
            this.toolbarPanel.Size = new System.Drawing.Size(625, 21);
            this.toolbarPanel.TabIndex = 3;
            this.toolbarPanel.Visible = false;
            // 
            // amountBar
            // 
            this.amountBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.amountBar.Location = new System.Drawing.Point(412, 0);
            this.amountBar.Name = "amountBar";
            this.amountBar.Size = new System.Drawing.Size(167, 45);
            this.amountBar.TabIndex = 7;
            this.amountBar.Scroll += new System.EventHandler(this.amountBar_Scroll);
            // 
            // amountTxt
            // 
            this.amountTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.amountTxt.AutoSize = true;
            this.amountTxt.Location = new System.Drawing.Point(585, 5);
            this.amountTxt.Name = "amountTxt";
            this.amountTxt.Size = new System.Drawing.Size(13, 13);
            this.amountTxt.TabIndex = 6;
            this.amountTxt.Text = "0";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Amount:";
            // 
            // circleSelection
            // 
            this.circleSelection.AutoSize = true;
            this.circleSelection.Checked = true;
            this.circleSelection.Location = new System.Drawing.Point(143, 3);
            this.circleSelection.Name = "circleSelection";
            this.circleSelection.Size = new System.Drawing.Size(51, 17);
            this.circleSelection.TabIndex = 2;
            this.circleSelection.TabStop = true;
            this.circleSelection.Text = "Circle";
            this.circleSelection.UseVisualStyleBackColor = true;
            this.circleSelection.CheckedChanged += new System.EventHandler(this.circleSelection_CheckedChanged);
            // 
            // rectSelection
            // 
            this.rectSelection.AutoSize = true;
            this.rectSelection.Location = new System.Drawing.Point(63, 3);
            this.rectSelection.Name = "rectSelection";
            this.rectSelection.Size = new System.Drawing.Size(74, 17);
            this.rectSelection.TabIndex = 1;
            this.rectSelection.Text = "Rectangle";
            this.rectSelection.UseVisualStyleBackColor = true;
            this.rectSelection.CheckedChanged += new System.EventHandler(this.rectSelection_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selection:";
            // 
            // PhotoStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.toolbarPanel);
            this.Controls.Add(this.statusPanel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.filterPanel);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "PhotoStore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhotoStore";
            this.Load += new System.EventHandler(this.PhotoStore_Load);
            this.statusPanel.ResumeLayout(false);
            this.toolbarPanel.ResumeLayout(false);
            this.toolbarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel statusPanel;
        private System.Windows.Forms.Label statusTxt;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.ComponentModel.BackgroundWorker imageProcessor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel filterPanel;
        private System.Windows.Forms.Panel toolbarPanel;
        private System.Windows.Forms.RadioButton rectSelection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label amountTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton circleSelection;
        private System.Windows.Forms.TrackBar amountBar;
    }
}

