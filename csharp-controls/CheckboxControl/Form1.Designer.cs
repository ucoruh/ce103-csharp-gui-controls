namespace CheckboxControl
{
    partial class Form1
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
            this.checkboxMovieTypeDrama = new System.Windows.Forms.CheckBox();
            this.checkboxMovieTypeScienceFiction = new System.Windows.Forms.CheckBox();
            this.checkboxMovieTypeAction = new System.Windows.Forms.CheckBox();
            this.groupboxMovieTypes = new System.Windows.Forms.GroupBox();
            this.labelSelectedMovies = new System.Windows.Forms.Label();
            this.labelYourSelectionMsg = new System.Windows.Forms.Label();
            this.groupboxMovieTypes.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkboxMovieTypeDrama
            // 
            this.checkboxMovieTypeDrama.AutoSize = true;
            this.checkboxMovieTypeDrama.Location = new System.Drawing.Point(28, 32);
            this.checkboxMovieTypeDrama.Name = "checkboxMovieTypeDrama";
            this.checkboxMovieTypeDrama.Size = new System.Drawing.Size(94, 29);
            this.checkboxMovieTypeDrama.TabIndex = 0;
            this.checkboxMovieTypeDrama.Text = "Drama";
            this.checkboxMovieTypeDrama.UseVisualStyleBackColor = true;
            
            // 
            // checkboxMovieTypeScienceFiction
            // 
            this.checkboxMovieTypeScienceFiction.AutoSize = true;
            this.checkboxMovieTypeScienceFiction.Location = new System.Drawing.Point(28, 79);
            this.checkboxMovieTypeScienceFiction.Name = "checkboxMovieTypeScienceFiction";
            this.checkboxMovieTypeScienceFiction.Size = new System.Drawing.Size(174, 29);
            this.checkboxMovieTypeScienceFiction.TabIndex = 1;
            this.checkboxMovieTypeScienceFiction.Text = "Science Fiction";
            this.checkboxMovieTypeScienceFiction.UseVisualStyleBackColor = true;
            
            // 
            // checkboxMovieTypeAction
            // 
            this.checkboxMovieTypeAction.AutoSize = true;
            this.checkboxMovieTypeAction.Location = new System.Drawing.Point(28, 123);
            this.checkboxMovieTypeAction.Name = "checkboxMovieTypeAction";
            this.checkboxMovieTypeAction.Size = new System.Drawing.Size(91, 29);
            this.checkboxMovieTypeAction.TabIndex = 2;
            this.checkboxMovieTypeAction.Text = "Action";
            this.checkboxMovieTypeAction.UseVisualStyleBackColor = true;
            
            // 
            // groupboxMovieTypes
            // 
            this.groupboxMovieTypes.Controls.Add(this.checkboxMovieTypeDrama);
            this.groupboxMovieTypes.Controls.Add(this.checkboxMovieTypeAction);
            this.groupboxMovieTypes.Controls.Add(this.checkboxMovieTypeScienceFiction);
            this.groupboxMovieTypes.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupboxMovieTypes.Location = new System.Drawing.Point(74, 50);
            this.groupboxMovieTypes.Name = "groupboxMovieTypes";
            this.groupboxMovieTypes.Size = new System.Drawing.Size(227, 172);
            this.groupboxMovieTypes.TabIndex = 3;
            this.groupboxMovieTypes.TabStop = false;
            this.groupboxMovieTypes.Text = "Select Movie";
            // 
            // labelSelectedMovies
            // 
            this.labelSelectedMovies.AutoSize = true;
            this.labelSelectedMovies.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSelectedMovies.Location = new System.Drawing.Point(322, 70);
            this.labelSelectedMovies.Name = "labelSelectedMovies";
            this.labelSelectedMovies.Size = new System.Drawing.Size(131, 25);
            this.labelSelectedMovies.TabIndex = 4;
            this.labelSelectedMovies.Text = "No Selection";
            // 
            // labelYourSelectionMsg
            // 
            this.labelYourSelectionMsg.AutoSize = true;
            this.labelYourSelectionMsg.Font = new System.Drawing.Font("Roboto Bk", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelYourSelectionMsg.Location = new System.Drawing.Point(319, 28);
            this.labelYourSelectionMsg.Name = "labelYourSelectionMsg";
            this.labelYourSelectionMsg.Size = new System.Drawing.Size(192, 33);
            this.labelYourSelectionMsg.TabIndex = 5;
            this.labelYourSelectionMsg.Text = "Your Selection";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 293);
            this.Controls.Add(this.labelYourSelectionMsg);
            this.Controls.Add(this.labelSelectedMovies);
            this.Controls.Add(this.groupboxMovieTypes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupboxMovieTypes.ResumeLayout(false);
            this.groupboxMovieTypes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkboxMovieTypeDrama;
        private System.Windows.Forms.CheckBox checkboxMovieTypeScienceFiction;
        private System.Windows.Forms.CheckBox checkboxMovieTypeAction;
        private System.Windows.Forms.GroupBox groupboxMovieTypes;
        private System.Windows.Forms.Label labelSelectedMovies;
        private System.Windows.Forms.Label labelYourSelectionMsg;
    }
}

