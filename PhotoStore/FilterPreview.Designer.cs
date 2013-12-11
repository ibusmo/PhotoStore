namespace PhotoStore
{
    partial class FilterPreview
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FilterPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "FilterPreview";
            this.Size = new System.Drawing.Size(120, 90);
            this.Click += new System.EventHandler(this.FilterPreview_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FilterPreview_Paint);
            this.Enter += new System.EventHandler(this.FilterPreview_Enter);
            this.Leave += new System.EventHandler(this.FilterPreview_Leave);
            this.MouseEnter += new System.EventHandler(this.FilterPreview_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.FilterPreview_MouseLeave);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
