namespace YoutubeLoader
{
    partial class FindForm
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
            this.FindButton = new System.Windows.Forms.Button();
            this.FindText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FindButton
            // 
            this.FindButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.FindButton.Location = new System.Drawing.Point(194, 15);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(97, 27);
            this.FindButton.TabIndex = 1;
            this.FindButton.Text = "Найти";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // FindText
            // 
            this.FindText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.FindText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.FindText.Dock = System.Windows.Forms.DockStyle.Left;
            this.FindText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindText.Location = new System.Drawing.Point(15, 15);
            this.FindText.Name = "FindText";
            this.FindText.Size = new System.Drawing.Size(168, 26);
            this.FindText.TabIndex = 0;
            this.FindText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FindText_KeyDown);
            // 
            // FindForm
            // 
            this.AcceptButton = this.FindButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 57);
            this.Controls.Add(this.FindText);
            this.Controls.Add(this.FindButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FindForm";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FindForm";
            this.Load += new System.EventHandler(this.FindForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FindForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.TextBox FindText;
    }
}