namespace Bankomats
{
    partial class MainForm
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
            this.MainWindow = new System.Windows.Forms.ListBox();
            this.status = new System.Windows.Forms.Label();
            this.MyPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // MainWindow
            // 
            this.MainWindow.FormattingEnabled = true;
            this.MainWindow.Location = new System.Drawing.Point(23, 0);
            this.MainWindow.Name = "MainWindow";
            this.MainWindow.Size = new System.Drawing.Size(160, 186);
            this.MainWindow.TabIndex = 0;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(1, 272);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(46, 15);
            this.status.TabIndex = 1;
            this.status.Text = "Culture";
            // 
            // MyPanel
            // 
            this.MyPanel.Location = new System.Drawing.Point(67, 195);
            this.MyPanel.Name = "MyPanel";
            this.MyPanel.Size = new System.Drawing.Size(69, 92);
            this.MyPanel.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 300);
            this.Controls.Add(this.MyPanel);
            this.Controls.Add(this.status);
            this.Controls.Add(this.MainWindow);
            this.Name = "MainForm";
            this.Text = "Bankomats";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox MainWindow;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Panel MyPanel;
    }
}

