namespace Youtube
{
    partial class SettingsForm
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
            this.settContainer = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.VideoSettings = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.setOK = new System.Windows.Forms.Button();
            this.setCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textLast = new System.Windows.Forms.TextBox();
            this.settContainer.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // settContainer
            // 
            this.settContainer.Controls.Add(this.tabPage1);
            this.settContainer.Controls.Add(this.tabPage2);
            this.settContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.settContainer.Location = new System.Drawing.Point(0, 0);
            this.settContainer.Name = "settContainer";
            this.settContainer.SelectedIndex = 0;
            this.settContainer.Size = new System.Drawing.Size(571, 266);
            this.settContainer.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(563, 237);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Настройки парсинга";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(557, 231);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.54475F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.45525F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.VideoSettings, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textLast, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 21);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.54545F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.45454F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(514, 189);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 5, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Качество видео";
            // 
            // VideoSettings
            // 
            this.VideoSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VideoSettings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VideoSettings.FormattingEnabled = true;
            this.VideoSettings.Items.AddRange(new object[] {
            "Автоматическое",
            "Максимальное",
            "Вручную"});
            this.VideoSettings.Location = new System.Drawing.Point(160, 3);
            this.VideoSettings.Name = "VideoSettings";
            this.VideoSettings.Size = new System.Drawing.Size(351, 24);
            this.VideoSettings.TabIndex = 1;
            this.VideoSettings.SelectedIndexChanged += new System.EventHandler(this.VideoSettings_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(563, 237);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Обновления";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 231);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.checkBox1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 18);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(285, 210);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(13, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(222, 21);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Автоматическое обновление";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // setOK
            // 
            this.setOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.setOK.Location = new System.Drawing.Point(420, 276);
            this.setOK.Name = "setOK";
            this.setOK.Size = new System.Drawing.Size(147, 42);
            this.setOK.TabIndex = 1;
            this.setOK.Text = "Ладно";
            this.setOK.UseVisualStyleBackColor = true;
            this.setOK.Click += new System.EventHandler(this.setOK_Click);
            // 
            // setCancel
            // 
            this.setCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.setCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.setCancel.Location = new System.Drawing.Point(4, 276);
            this.setCancel.Name = "setCancel";
            this.setCancel.Size = new System.Drawing.Size(147, 42);
            this.setCancel.TabIndex = 2;
            this.setCancel.Text = "Отмена";
            this.setCancel.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(0, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 5, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 157);
            this.label2.TabIndex = 2;
            this.label2.Text = "Последнее видео";
            // 
            // textLast
            // 
            this.textLast.Location = new System.Drawing.Point(160, 32);
            this.textLast.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.textLast.Name = "textLast";
            this.textLast.Size = new System.Drawing.Size(351, 22);
            this.textLast.TabIndex = 3;
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.setOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.setCancel;
            this.ClientSize = new System.Drawing.Size(571, 325);
            this.Controls.Add(this.setCancel);
            this.Controls.Add(this.setOK);
            this.Controls.Add(this.settContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.settContainer.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl settContainer;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button setOK;
        private System.Windows.Forms.Button setCancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox VideoSettings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textLast;
    }
}