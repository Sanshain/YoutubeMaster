namespace YoutubeFine
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.sourcePath = new System.Windows.Forms.TextBox();
            this.sourceTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.statusView = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.sourceText = new System.Windows.Forms.RichTextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.openDir = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.сервисToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingButton = new System.Windows.Forms.ToolStripMenuItem();
            this.logsBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteLogFile = new System.Windows.Forms.ToolStripMenuItem();
            this.showLogFile = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.progressState = new System.Windows.Forms.ProgressBar();
            this.sourceTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sourcePath
            // 
            this.sourcePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sourcePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sourcePath.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.sourcePath.Location = new System.Drawing.Point(0, 27);
            this.sourcePath.Name = "sourcePath";
            this.sourcePath.Size = new System.Drawing.Size(944, 30);
            this.sourcePath.TabIndex = 0;
            this.sourcePath.Text = "Enter source path here...";
            // 
            // sourceTab
            // 
            this.sourceTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sourceTab.Controls.Add(this.tabPage1);
            this.sourceTab.Controls.Add(this.tabPage2);
            this.sourceTab.Location = new System.Drawing.Point(0, 63);
            this.sourceTab.Name = "sourceTab";
            this.sourceTab.SelectedIndex = 0;
            this.sourceTab.Size = new System.Drawing.Size(943, 344);
            this.sourceTab.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.statusView);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(935, 315);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Статус выполнения";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // statusView
            // 
            this.statusView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusView.Location = new System.Drawing.Point(3, 3);
            this.statusView.Name = "statusView";
            this.statusView.Size = new System.Drawing.Size(929, 309);
            this.statusView.TabIndex = 2;
            this.statusView.Text = "";
            this.statusView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.statusView_MouseDown);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.sourceText);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(935, 315);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Исходные данные";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // sourceText
            // 
            this.sourceText.AcceptsTab = true;
            this.sourceText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceText.ForeColor = System.Drawing.SystemColors.GrayText;
            this.sourceText.Location = new System.Drawing.Point(3, 3);
            this.sourceText.Name = "sourceText";
            this.sourceText.Size = new System.Drawing.Size(929, 309);
            this.sourceText.TabIndex = 0;
            this.sourceText.Text = resources.GetString("sourceText.Text");
            this.sourceText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sourceText_KeyDown);
            this.sourceText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sourceText_MouseDown);
            // 
            // startButton
            // 
            this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.startButton.Location = new System.Drawing.Point(757, 413);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(175, 49);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Вперед";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.stopButton.Location = new System.Drawing.Point(12, 417);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(147, 41);
            this.stopButton.TabIndex = 3;
            this.stopButton.Text = "Остановить";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Visible = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // openDir
            // 
            this.openDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.openDir.Location = new System.Drawing.Point(178, 418);
            this.openDir.Name = "openDir";
            this.openDir.Size = new System.Drawing.Size(147, 41);
            this.openDir.TabIndex = 4;
            this.openDir.Text = "Открыть";
            this.openDir.UseVisualStyleBackColor = true;
            this.openDir.Visible = false;
            this.openDir.Click += new System.EventHandler(this.openDir_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сервисToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(944, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // сервисToolStripMenuItem
            // 
            this.сервисToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingButton,
            this.logsBtn});
            this.сервисToolStripMenuItem.Name = "сервисToolStripMenuItem";
            this.сервисToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.сервисToolStripMenuItem.Text = "Сервис";
            // 
            // settingButton
            // 
            this.settingButton.Name = "settingButton";
            this.settingButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.settingButton.Size = new System.Drawing.Size(205, 26);
            this.settingButton.Text = "Настройки";
            this.settingButton.Click += new System.EventHandler(this.settingButton_Click);
            // 
            // logsBtn
            // 
            this.logsBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteLogFile,
            this.showLogFile});
            this.logsBtn.Name = "logsBtn";
            this.logsBtn.Size = new System.Drawing.Size(205, 26);
            this.logsBtn.Text = "Логи";
            // 
            // deleteLogFile
            // 
            this.deleteLogFile.Name = "deleteLogFile";
            this.deleteLogFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.deleteLogFile.Size = new System.Drawing.Size(189, 26);
            this.deleteLogFile.Text = "Удалить";
            this.deleteLogFile.Click += new System.EventHandler(this.deleteLogFile_Click);
            // 
            // showLogFile
            // 
            this.showLogFile.Name = "showLogFile";
            this.showLogFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.L)));
            this.showLogFile.Size = new System.Drawing.Size(189, 26);
            this.showLogFile.Text = "Открыть";
            this.showLogFile.Click += new System.EventHandler(this.showLogFile_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdAbout});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // cmdAbout
            // 
            this.cmdAbout.Name = "cmdAbout";
            this.cmdAbout.Size = new System.Drawing.Size(179, 26);
            this.cmdAbout.Text = "О программе";
            this.cmdAbout.Click += new System.EventHandler(this.cmdAbout_Click);
            // 
            // progressState
            // 
            this.progressState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressState.Location = new System.Drawing.Point(346, 417);
            this.progressState.Name = "progressState";
            this.progressState.Size = new System.Drawing.Size(388, 41);
            this.progressState.TabIndex = 7;
            this.progressState.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 471);
            this.Controls.Add(this.progressState);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.openDir);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.sourceTab);
            this.Controls.Add(this.sourcePath);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Youtube Downloader";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.sourceTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sourcePath;
        private System.Windows.Forms.TabControl sourceTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox statusView;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button openDir;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem сервисToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingButton;
        private System.Windows.Forms.ToolStripMenuItem logsBtn;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmdAbout;
        private System.Windows.Forms.ToolStripMenuItem deleteLogFile;
        private System.Windows.Forms.ToolStripMenuItem showLogFile;
        private System.Windows.Forms.ProgressBar progressState;
        internal System.Windows.Forms.RichTextBox sourceText;
    }
}

