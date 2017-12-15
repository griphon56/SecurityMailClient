namespace MailClient
{
    partial class GUI_Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_Main));
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.totalMessages = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsbtNew = new System.Windows.Forms.ToolStripButton();
            this.tsbtGet = new System.Windows.Forms.ToolStripButton();
            this.listMessages = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newMailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbstNew = new System.Windows.Forms.ToolStripButton();
            this.tbstGet = new System.Windows.Forms.ToolStripButton();
            this.tbstOpen = new System.Windows.Forms.ToolStripButton();
            this.tbstSettings = new System.Windows.Forms.ToolStripButton();
            this.tbstCrypto = new System.Windows.Forms.ToolStripButton();
            this.tbstSave = new System.Windows.Forms.ToolStripButton();
            this.tbstDelete = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.totalMessages1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.totalMessagesCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.tbFrom = new System.Windows.Forms.TextBox();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.lbFrom = new System.Windows.Forms.Label();
            this.lbTo = new System.Windows.Forms.Label();
            this.lbSubject = new System.Windows.Forms.Label();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.messageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbAttachments = new System.Windows.Forms.ComboBox();
            this.lbAttachments = new System.Windows.Forms.Label();
            this.lbAttachmentsCount = new System.Windows.Forms.Label();
            this.btDownload = new System.Windows.Forms.Button();
            this.mailViewer = new System.Windows.Forms.WebBrowser();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.messageBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // emailToolStripMenuItem
            // 
            this.emailToolStripMenuItem.Name = "emailToolStripMenuItem";
            this.emailToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // totalMessages
            // 
            this.totalMessages.Name = "totalMessages";
            this.totalMessages.Size = new System.Drawing.Size(94, 17);
            this.totalMessages.Text = "0";
            // 
            // tsbtNew
            // 
            this.tsbtNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtNew.Name = "tsbtNew";
            this.tsbtNew.Size = new System.Drawing.Size(61, 22);
            this.tsbtNew.Text = "Новое письмо";
            // 
            // tsbtGet
            // 
            this.tsbtGet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtGet.Name = "tsbtGet";
            this.tsbtGet.Size = new System.Drawing.Size(55, 22);
            this.tsbtGet.Text = "Обновить почту";
            // 
            // listMessages
            // 
            this.listMessages.Location = new System.Drawing.Point(12, 53);
            this.listMessages.Name = "listMessages";
            this.listMessages.ShowPlusMinus = false;
            this.listMessages.ShowRootLines = false;
            this.listMessages.Size = new System.Drawing.Size(247, 523);
            this.listMessages.TabIndex = 5;
            this.listMessages.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ListMessagesMessageSelected);
            this.listMessages.Enter += new System.EventHandler(this.listMessages_Enter);
            this.listMessages.Leave += new System.EventHandler(this.listMessages_Leave);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(946, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMailToolStripMenuItem,
            this.optionsToolStripMenuItem1,
            this.clearToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem1.Text = "Файл";
            // 
            // newMailToolStripMenuItem
            // 
            this.newMailToolStripMenuItem.Name = "newMailToolStripMenuItem";
            this.newMailToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.newMailToolStripMenuItem.Text = "Новое письмо";
            this.newMailToolStripMenuItem.Click += new System.EventHandler(this.newMailToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem1
            // 
            this.optionsToolStripMenuItem1.Name = "optionsToolStripMenuItem1";
            this.optionsToolStripMenuItem1.Size = new System.Drawing.Size(263, 22);
            this.optionsToolStripMenuItem1.Text = "Настройки";
            this.optionsToolStripMenuItem1.Click += new System.EventHandler(this.optionsToolStripMenuItem1_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.clearToolStripMenuItem.Text = "Очистить просмотренные письма";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(263, 22);
            this.exitToolStripMenuItem1.Text = "Выход";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbstNew,
            this.tbstGet,
            this.tbstOpen,
            this.tbstSettings,
            this.tbstCrypto,
            this.tbstSave,
            this.tbstDelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(946, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbstNew
            // 
            this.tbstNew.Image = global::MailClient.Properties.Resources.NewMessage;
            this.tbstNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbstNew.Name = "tbstNew";
            this.tbstNew.Size = new System.Drawing.Size(107, 22);
            this.tbstNew.Text = "Новое письмо";
            this.tbstNew.Click += new System.EventHandler(this.tbstNew_Click);
            // 
            // tbstGet
            // 
            this.tbstGet.Image = global::MailClient.Properties.Resources.RefreshDocView;
            this.tbstGet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbstGet.Name = "tbstGet";
            this.tbstGet.Size = new System.Drawing.Size(116, 22);
            this.tbstGet.Text = "Обновить почту";
            this.tbstGet.Click += new System.EventHandler(this.tbstGet_Click);
            // 
            // tbstOpen
            // 
            this.tbstOpen.Image = global::MailClient.Properties.Resources.OpenMessage;
            this.tbstOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbstOpen.Name = "tbstOpen";
            this.tbstOpen.Size = new System.Drawing.Size(119, 22);
            this.tbstOpen.Text = "Открыть письмо";
            this.tbstOpen.Click += new System.EventHandler(this.tbstOpen_Click);
            // 
            // tbstSettings
            // 
            this.tbstSettings.Image = global::MailClient.Properties.Resources.Settings;
            this.tbstSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbstSettings.Name = "tbstSettings";
            this.tbstSettings.Size = new System.Drawing.Size(87, 22);
            this.tbstSettings.Text = "Настройки";
            this.tbstSettings.Click += new System.EventHandler(this.tsbtSettings_Click);
            // 
            // tbstCrypto
            // 
            this.tbstCrypto.Image = ((System.Drawing.Image)(resources.GetObject("tbstCrypto.Image")));
            this.tbstCrypto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbstCrypto.Name = "tbstCrypto";
            this.tbstCrypto.Size = new System.Drawing.Size(155, 22);
            this.tbstCrypto.Text = "Расшифровать письмо";
            this.tbstCrypto.Visible = false;
            this.tbstCrypto.Click += new System.EventHandler(this.tbstCrypto_Click);
            // 
            // tbstSave
            // 
            this.tbstSave.Image = global::MailClient.Properties.Resources.SaveMessage;
            this.tbstSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbstSave.Name = "tbstSave";
            this.tbstSave.Size = new System.Drawing.Size(130, 22);
            this.tbstSave.Text = "Сохранить письмо";
            this.tbstSave.Visible = false;
            this.tbstSave.Click += new System.EventHandler(this.tbstSave_Click);
            // 
            // tbstDelete
            // 
            this.tbstDelete.Image = global::MailClient.Properties.Resources.DeleteMessage;
            this.tbstDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbstDelete.Name = "tbstDelete";
            this.tbstDelete.Size = new System.Drawing.Size(116, 22);
            this.tbstDelete.Text = "Удалить письмо";
            this.tbstDelete.Visible = false;
            this.tbstDelete.Click += new System.EventHandler(this.tbstDelete_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar,
            this.totalMessages1,
            this.totalMessagesCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 582);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(946, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // totalMessages1
            // 
            this.totalMessages1.Name = "totalMessages1";
            this.totalMessages1.Size = new System.Drawing.Size(82, 17);
            this.totalMessages1.Text = "Всего писем: ";
            // 
            // totalMessagesCount
            // 
            this.totalMessagesCount.Name = "totalMessagesCount";
            this.totalMessagesCount.Size = new System.Drawing.Size(0, 17);
            // 
            // tbFrom
            // 
            this.tbFrom.Enabled = false;
            this.tbFrom.Location = new System.Drawing.Point(348, 56);
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.ReadOnly = true;
            this.tbFrom.Size = new System.Drawing.Size(586, 20);
            this.tbFrom.TabIndex = 9;
            // 
            // tbTo
            // 
            this.tbTo.Enabled = false;
            this.tbTo.Location = new System.Drawing.Point(348, 82);
            this.tbTo.Name = "tbTo";
            this.tbTo.ReadOnly = true;
            this.tbTo.Size = new System.Drawing.Size(586, 20);
            this.tbTo.TabIndex = 10;
            // 
            // lbFrom
            // 
            this.lbFrom.AutoSize = true;
            this.lbFrom.Location = new System.Drawing.Point(266, 59);
            this.lbFrom.Name = "lbFrom";
            this.lbFrom.Size = new System.Drawing.Size(76, 13);
            this.lbFrom.TabIndex = 11;
            this.lbFrom.Text = "Отправитель:";
            // 
            // lbTo
            // 
            this.lbTo.AutoSize = true;
            this.lbTo.Location = new System.Drawing.Point(306, 85);
            this.lbTo.Name = "lbTo";
            this.lbTo.Size = new System.Drawing.Size(36, 13);
            this.lbTo.TabIndex = 12;
            this.lbTo.Text = "Кому:";
            // 
            // lbSubject
            // 
            this.lbSubject.AutoSize = true;
            this.lbSubject.Location = new System.Drawing.Point(306, 112);
            this.lbSubject.Name = "lbSubject";
            this.lbSubject.Size = new System.Drawing.Size(37, 13);
            this.lbSubject.TabIndex = 14;
            this.lbSubject.Text = "Тема:";
            // 
            // tbSubject
            // 
            this.tbSubject.Enabled = false;
            this.tbSubject.Location = new System.Drawing.Point(348, 109);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.ReadOnly = true;
            this.tbSubject.Size = new System.Drawing.Size(586, 20);
            this.tbSubject.TabIndex = 13;
            // 
            // cbAttachments
            // 
            this.cbAttachments.FormattingEnabled = true;
            this.cbAttachments.Location = new System.Drawing.Point(372, 136);
            this.cbAttachments.Name = "cbAttachments";
            this.cbAttachments.Size = new System.Drawing.Size(481, 21);
            this.cbAttachments.TabIndex = 15;
            // 
            // lbAttachments
            // 
            this.lbAttachments.AutoSize = true;
            this.lbAttachments.Location = new System.Drawing.Point(269, 139);
            this.lbAttachments.Name = "lbAttachments";
            this.lbAttachments.Size = new System.Drawing.Size(74, 13);
            this.lbAttachments.TabIndex = 16;
            this.lbAttachments.Text = "Приложения:";
            // 
            // lbAttachmentsCount
            // 
            this.lbAttachmentsCount.AutoSize = true;
            this.lbAttachmentsCount.Location = new System.Drawing.Point(353, 139);
            this.lbAttachmentsCount.Name = "lbAttachmentsCount";
            this.lbAttachmentsCount.Size = new System.Drawing.Size(13, 13);
            this.lbAttachmentsCount.TabIndex = 17;
            this.lbAttachmentsCount.Text = "0";
            // 
            // btDownload
            // 
            this.btDownload.Enabled = false;
            this.btDownload.Location = new System.Drawing.Point(859, 135);
            this.btDownload.Name = "btDownload";
            this.btDownload.Size = new System.Drawing.Size(75, 23);
            this.btDownload.TabIndex = 18;
            this.btDownload.Text = "Сохранить";
            this.btDownload.UseVisualStyleBackColor = true;
            this.btDownload.Click += new System.EventHandler(this.btDownload_Click);
            // 
            // mailViewer
            // 
            this.mailViewer.Location = new System.Drawing.Point(272, 163);
            this.mailViewer.MinimumSize = new System.Drawing.Size(20, 20);
            this.mailViewer.Name = "mailViewer";
            this.mailViewer.Size = new System.Drawing.Size(662, 413);
            this.mailViewer.TabIndex = 19;
            // 
            // GUI_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(946, 604);
            this.Controls.Add(this.mailViewer);
            this.Controls.Add(this.btDownload);
            this.Controls.Add(this.lbAttachmentsCount);
            this.Controls.Add(this.lbAttachments);
            this.Controls.Add(this.cbAttachments);
            this.Controls.Add(this.lbSubject);
            this.Controls.Add(this.tbSubject);
            this.Controls.Add(this.lbTo);
            this.Controls.Add(this.lbFrom);
            this.Controls.Add(this.tbTo);
            this.Controls.Add(this.tbFrom);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.listMessages);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GUI_Main";
            this.Text = "MailClient";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.messageBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsbtNew;
        private System.Windows.Forms.ToolStripButton tsbtGet;
        private System.Windows.Forms.BindingSource messageBindingSource;
        private System.Windows.Forms.ToolStripStatusLabel totalMessages;
        private System.Windows.Forms.TreeView listMessages;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newMailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripButton tbstNew;
        private System.Windows.Forms.ToolStripButton tbstGet;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.ToolStripStatusLabel totalMessages1;
        private System.Windows.Forms.ToolStripButton tbstCrypto;
        private System.Windows.Forms.ToolStripButton tbstSettings;
        private System.Windows.Forms.TextBox tbFrom;
        private System.Windows.Forms.TextBox tbTo;
        private System.Windows.Forms.Label lbFrom;
        private System.Windows.Forms.Label lbTo;
        private System.Windows.Forms.Label lbSubject;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.ToolStripButton tbstSave;
        private System.Windows.Forms.ToolStripButton tbstOpen;
        private System.Windows.Forms.ToolStripButton tbstDelete;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbAttachments;
        private System.Windows.Forms.Label lbAttachments;
        private System.Windows.Forms.Label lbAttachmentsCount;
        private System.Windows.Forms.Button btDownload;
        private System.Windows.Forms.WebBrowser mailViewer;
        private System.Windows.Forms.ToolStripStatusLabel totalMessagesCount;
    }
}

