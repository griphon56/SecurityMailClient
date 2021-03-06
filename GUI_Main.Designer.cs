﻿namespace MailClient
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
            this.tbstDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbstSave = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьСохраненноеСмсToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.безопасностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbstCrypto = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.totalMessages1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.totalMessagesCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.tbFrom = new System.Windows.Forms.TextBox();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.lbTo = new System.Windows.Forms.Label();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.cbAttachments = new System.Windows.Forms.ComboBox();
            this.lbAttachments = new System.Windows.Forms.Label();
            this.lbAttachmentsCount = new System.Windows.Forms.Label();
            this.btDownload = new System.Windows.Forms.Button();
            this.mailViewer = new System.Windows.Forms.WebBrowser();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.messageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pAuth = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPopPassword = new System.Windows.Forms.TextBox();
            this.tbPopUsername = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.messageBindingSource)).BeginInit();
            this.pAuth.SuspendLayout();
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
            this.listMessages.Location = new System.Drawing.Point(11, 27);
            this.listMessages.Name = "listMessages";
            this.listMessages.ShowPlusMinus = false;
            this.listMessages.ShowRootLines = false;
            this.listMessages.Size = new System.Drawing.Size(296, 486);
            this.listMessages.TabIndex = 5;
            this.listMessages.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ListMessagesMessageSelected);
            this.listMessages.Enter += new System.EventHandler(this.listMessages_Enter);
            this.listMessages.Leave += new System.EventHandler(this.listMessages_Leave);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.settingsToolStripMenuItem,
            this.безопасностьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(869, 24);
            this.menuStrip1.TabIndex = 6;
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMailToolStripMenuItem,
            this.tbstDelete,
            this.toolStripMenuItem2,
            this.tbstSave,
            this.открытьСохраненноеСмсToolStripMenuItem,
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
            this.newMailToolStripMenuItem.Text = "Новое сообщение";
            this.newMailToolStripMenuItem.Click += new System.EventHandler(this.newMailToolStripMenuItem_Click);
            // 
            // tbstDelete
            // 
            this.tbstDelete.Name = "tbstDelete";
            this.tbstDelete.Size = new System.Drawing.Size(263, 22);
            this.tbstDelete.Text = "Удалить сообщение";
            this.tbstDelete.Click += new System.EventHandler(this.tbstDelete_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(260, 6);
            // 
            // tbstSave
            // 
            this.tbstSave.Name = "tbstSave";
            this.tbstSave.Size = new System.Drawing.Size(263, 22);
            this.tbstSave.Text = "Сохранить на диск смс";
            this.tbstSave.Click += new System.EventHandler(this.tbstSave_Click);
            // 
            // открытьСохраненноеСмсToolStripMenuItem
            // 
            this.открытьСохраненноеСмсToolStripMenuItem.Name = "открытьСохраненноеСмсToolStripMenuItem";
            this.открытьСохраненноеСмсToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.открытьСохраненноеСмсToolStripMenuItem.Text = "Открыть сохраненное смс";
            this.открытьСохраненноеСмсToolStripMenuItem.Click += new System.EventHandler(this.tbstOpen_Click);
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
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.settingsToolStripMenuItem.Text = "Настройки";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // безопасностьToolStripMenuItem
            // 
            this.безопасностьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbstCrypto});
            this.безопасностьToolStripMenuItem.Name = "безопасностьToolStripMenuItem";
            this.безопасностьToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.безопасностьToolStripMenuItem.Text = "Безопасность";
            // 
            // tbstCrypto
            // 
            this.tbstCrypto.Name = "tbstCrypto";
            this.tbstCrypto.Size = new System.Drawing.Size(157, 22);
            this.tbstCrypto.Text = "Расшифровать";
            this.tbstCrypto.Click += new System.EventHandler(this.tbstCrypto_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar,
            this.totalMessages1,
            this.totalMessagesCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 523);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(869, 22);
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
            this.tbFrom.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbFrom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFrom.Enabled = false;
            this.tbFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFrom.Location = new System.Drawing.Point(328, 123);
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.ReadOnly = true;
            this.tbFrom.Size = new System.Drawing.Size(530, 15);
            this.tbFrom.TabIndex = 9;
            // 
            // tbTo
            // 
            this.tbTo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbTo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTo.Enabled = false;
            this.tbTo.Location = new System.Drawing.Point(367, 154);
            this.tbTo.Name = "tbTo";
            this.tbTo.ReadOnly = true;
            this.tbTo.Size = new System.Drawing.Size(491, 13);
            this.tbTo.TabIndex = 10;
            // 
            // lbTo
            // 
            this.lbTo.AutoSize = true;
            this.lbTo.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbTo.Location = new System.Drawing.Point(325, 154);
            this.lbTo.Name = "lbTo";
            this.lbTo.Size = new System.Drawing.Size(36, 13);
            this.lbTo.TabIndex = 12;
            this.lbTo.Text = "Кому:";
            this.lbTo.Visible = false;
            // 
            // tbSubject
            // 
            this.tbSubject.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbSubject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSubject.Enabled = false;
            this.tbSubject.Font = new System.Drawing.Font("Microsoft JhengHei UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSubject.Location = new System.Drawing.Point(328, 63);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.ReadOnly = true;
            this.tbSubject.Size = new System.Drawing.Size(530, 38);
            this.tbSubject.TabIndex = 13;
            // 
            // cbAttachments
            // 
            this.cbAttachments.FormattingEnabled = true;
            this.cbAttachments.Location = new System.Drawing.Point(421, 492);
            this.cbAttachments.Name = "cbAttachments";
            this.cbAttachments.Size = new System.Drawing.Size(355, 21);
            this.cbAttachments.TabIndex = 15;
            // 
            // lbAttachments
            // 
            this.lbAttachments.AutoSize = true;
            this.lbAttachments.Location = new System.Drawing.Point(318, 495);
            this.lbAttachments.Name = "lbAttachments";
            this.lbAttachments.Size = new System.Drawing.Size(61, 13);
            this.lbAttachments.TabIndex = 16;
            this.lbAttachments.Text = "Вложения:";
            // 
            // lbAttachmentsCount
            // 
            this.lbAttachmentsCount.AutoSize = true;
            this.lbAttachmentsCount.Location = new System.Drawing.Point(385, 495);
            this.lbAttachmentsCount.Name = "lbAttachmentsCount";
            this.lbAttachmentsCount.Size = new System.Drawing.Size(13, 13);
            this.lbAttachmentsCount.TabIndex = 17;
            this.lbAttachmentsCount.Text = "0";
            // 
            // btDownload
            // 
            this.btDownload.BackColor = System.Drawing.Color.LightGreen;
            this.btDownload.Enabled = false;
            this.btDownload.ForeColor = System.Drawing.Color.Black;
            this.btDownload.Location = new System.Drawing.Point(782, 492);
            this.btDownload.Name = "btDownload";
            this.btDownload.Size = new System.Drawing.Size(76, 23);
            this.btDownload.TabIndex = 18;
            this.btDownload.Text = "СКАЧАТЬ";
            this.btDownload.UseVisualStyleBackColor = false;
            this.btDownload.Click += new System.EventHandler(this.btDownload_Click);
            // 
            // mailViewer
            // 
            this.mailViewer.Location = new System.Drawing.Point(325, 227);
            this.mailViewer.MinimumSize = new System.Drawing.Size(20, 20);
            this.mailViewer.Name = "mailViewer";
            this.mailViewer.Size = new System.Drawing.Size(533, 259);
            this.mailViewer.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(320, 222);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 265);
            this.panel1.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Salmon;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(412, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 30);
            this.button1.TabIndex = 22;
            this.button1.Text = "НАПИСАТЬ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.newMailToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(320, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 30);
            this.button2.TabIndex = 23;
            this.button2.Text = "ОБНОВИТЬ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.tbstGet_Click);
            // 
            // pAuth
            // 
            this.pAuth.Controls.Add(this.label1);
            this.pAuth.Controls.Add(this.btnSave);
            this.pAuth.Controls.Add(this.label4);
            this.pAuth.Controls.Add(this.label5);
            this.pAuth.Controls.Add(this.tbPopPassword);
            this.pAuth.Controls.Add(this.tbPopUsername);
            this.pAuth.Location = new System.Drawing.Point(0, 0);
            this.pAuth.Name = "pAuth";
            this.pAuth.Size = new System.Drawing.Size(869, 559);
            this.pAuth.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(290, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 39);
            this.label1.TabIndex = 26;
            this.label1.Text = "АВТОРИЗАЦИЯ";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(328, 304);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(200, 30);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Вход";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(325, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 24;
            this.label4.Text = "Пароль";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(325, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 18);
            this.label5.TabIndex = 23;
            this.label5.Text = "Логин";
            // 
            // tbPopPassword
            // 
            this.tbPopPassword.Location = new System.Drawing.Point(328, 260);
            this.tbPopPassword.Name = "tbPopPassword";
            this.tbPopPassword.PasswordChar = '*';
            this.tbPopPassword.Size = new System.Drawing.Size(200, 20);
            this.tbPopPassword.TabIndex = 22;
            // 
            // tbPopUsername
            // 
            this.tbPopUsername.Location = new System.Drawing.Point(328, 205);
            this.tbPopUsername.Name = "tbPopUsername";
            this.tbPopUsername.Size = new System.Drawing.Size(200, 20);
            this.tbPopUsername.TabIndex = 21;
            // 
            // GUI_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(869, 545);
            this.Controls.Add(this.pAuth);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mailViewer);
            this.Controls.Add(this.btDownload);
            this.Controls.Add(this.lbAttachmentsCount);
            this.Controls.Add(this.lbAttachments);
            this.Controls.Add(this.cbAttachments);
            this.Controls.Add(this.tbSubject);
            this.Controls.Add(this.lbTo);
            this.Controls.Add(this.tbTo);
            this.Controls.Add(this.tbFrom);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.listMessages);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(885, 584);
            this.MinimumSize = new System.Drawing.Size(885, 584);
            this.Name = "GUI_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SecurityMailClient";
            this.Load += new System.EventHandler(this.GUI_Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.messageBindingSource)).EndInit();
            this.pAuth.ResumeLayout(false);
            this.pAuth.PerformLayout();
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
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newMailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.ToolStripStatusLabel totalMessages1;
        private System.Windows.Forms.TextBox tbFrom;
        private System.Windows.Forms.TextBox tbTo;
        private System.Windows.Forms.Label lbTo;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbAttachments;
        private System.Windows.Forms.Label lbAttachments;
        private System.Windows.Forms.Label lbAttachmentsCount;
        private System.Windows.Forms.Button btDownload;
        private System.Windows.Forms.WebBrowser mailViewer;
        private System.Windows.Forms.ToolStripStatusLabel totalMessagesCount;
        private System.Windows.Forms.ToolStripMenuItem tbstDelete;
        private System.Windows.Forms.ToolStripMenuItem tbstSave;
        private System.Windows.Forms.ToolStripMenuItem открытьСохраненноеСмсToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem безопасностьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tbstCrypto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pAuth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPopPassword;
        private System.Windows.Forms.TextBox tbPopUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
    }
}

