namespace LabelControl
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonStartWorker = new System.Windows.Forms.Button();
            this.buttonStopWorker = new System.Windows.Forms.Button();
            this.richtextLog = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // buttonStartWorker
            // 
            this.buttonStartWorker.Location = new System.Drawing.Point(37, 25);
            this.buttonStartWorker.Name = "buttonStartWorker";
            this.buttonStartWorker.Size = new System.Drawing.Size(169, 54);
            this.buttonStartWorker.TabIndex = 0;
            this.buttonStartWorker.Text = "START WORKER";
            this.buttonStartWorker.UseVisualStyleBackColor = true;
            this.buttonStartWorker.Click += new System.EventHandler(this.buttonStartWorker_Click);
            // 
            // buttonStopWorker
            // 
            this.buttonStopWorker.Location = new System.Drawing.Point(37, 113);
            this.buttonStopWorker.Name = "buttonStopWorker";
            this.buttonStopWorker.Size = new System.Drawing.Size(169, 54);
            this.buttonStopWorker.TabIndex = 1;
            this.buttonStopWorker.Text = "STOP WORKER";
            this.buttonStopWorker.UseVisualStyleBackColor = true;
            this.buttonStopWorker.Click += new System.EventHandler(this.buttonStopWorker_Click);
            // 
            // richtextLog
            // 
            this.richtextLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richtextLog.Location = new System.Drawing.Point(260, 25);
            this.richtextLog.Name = "richtextLog";
            this.richtextLog.Size = new System.Drawing.Size(432, 164);
            this.richtextLog.TabIndex = 2;
            this.richtextLog.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(716, 201);
            this.Controls.Add(this.richtextLog);
            this.Controls.Add(this.buttonStopWorker);
            this.Controls.Add(this.buttonStartWorker);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Label Sample Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonStartWorker;
        private System.Windows.Forms.Button buttonStopWorker;
        private System.Windows.Forms.RichTextBox richtextLog;
    }
}

