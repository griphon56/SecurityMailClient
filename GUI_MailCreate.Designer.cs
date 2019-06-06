namespace MailClient
{
    partial class GUI_MailCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_MailCreate));
            this.rtBody = new System.Windows.Forms.RichTextBox();
            this.btSend = new System.Windows.Forms.Button();
            this.tbRecipient = new System.Windows.Forms.TextBox();
            this.tbCc = new System.Windows.Forms.TextBox();
            this.lbSublect = new System.Windows.Forms.Label();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbTo = new System.Windows.Forms.Label();
            this.lbCopy = new System.Windows.Forms.Label();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbAttachments = new System.Windows.Forms.ComboBox();
            this.lbAttachments = new System.Windows.Forms.Label();
            this.btAddAttachment = new System.Windows.Forms.Button();
            this.btDeleteAttachment = new System.Windows.Forms.Button();
            this.lbAttachmentsCount = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.безопасностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отправитьКлючToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btEncrypt = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtBody
            // 
            this.rtBody.Location = new System.Drawing.Point(16, 136);
            this.rtBody.Name = "rtBody";
            this.rtBody.Size = new System.Drawing.Size(655, 254);
            this.rtBody.TabIndex = 3;
            this.rtBody.Text = "";
            // 
            // btSend
            // 
            this.btSend.BackColor = System.Drawing.Color.LightGreen;
            this.btSend.Location = new System.Drawing.Point(567, 403);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(104, 26);
            this.btSend.TabIndex = 5;
            this.btSend.Text = "Отправить";
            this.btSend.UseVisualStyleBackColor = false;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // tbRecipient
            // 
            this.tbRecipient.Location = new System.Drawing.Point(122, 27);
            this.tbRecipient.Name = "tbRecipient";
            this.tbRecipient.Size = new System.Drawing.Size(549, 20);
            this.tbRecipient.TabIndex = 0;
            this.tbRecipient.Text = "dima.star90@mail.ru";
            this.tbRecipient.Validated += new System.EventHandler(this.tbRecipient_Validated);
            // 
            // tbCc
            // 
            this.tbCc.Location = new System.Drawing.Point(122, 54);
            this.tbCc.Name = "tbCc";
            this.tbCc.Size = new System.Drawing.Size(549, 20);
            this.tbCc.TabIndex = 1;
            this.tbCc.Validated += new System.EventHandler(this.tbCc_Validated);
            // 
            // lbSublect
            // 
            this.lbSublect.AutoSize = true;
            this.lbSublect.Location = new System.Drawing.Point(67, 83);
            this.lbSublect.Name = "lbSublect";
            this.lbSublect.Size = new System.Drawing.Size(37, 13);
            this.lbSublect.TabIndex = 7;
            this.lbSublect.Text = "Тема:";
            // 
            // tbSubject
            // 
            this.tbSubject.Location = new System.Drawing.Point(122, 80);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(549, 20);
            this.tbSubject.TabIndex = 2;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lbTo
            // 
            this.lbTo.AutoSize = true;
            this.lbTo.Location = new System.Drawing.Point(39, 30);
            this.lbTo.Name = "lbTo";
            this.lbTo.Size = new System.Drawing.Size(69, 13);
            this.lbTo.TabIndex = 8;
            this.lbTo.Text = "Получатель:";
            this.lbTo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbCopy
            // 
            this.lbCopy.AutoSize = true;
            this.lbCopy.Location = new System.Drawing.Point(63, 57);
            this.lbCopy.Name = "lbCopy";
            this.lbCopy.Size = new System.Drawing.Size(41, 13);
            this.lbCopy.TabIndex = 9;
            this.lbCopy.Text = "Копия:";
            this.lbCopy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // cbAttachments
            // 
            this.cbAttachments.FormattingEnabled = true;
            this.cbAttachments.Location = new System.Drawing.Point(122, 106);
            this.cbAttachments.Name = "cbAttachments";
            this.cbAttachments.Size = new System.Drawing.Size(387, 21);
            this.cbAttachments.TabIndex = 10;
            // 
            // lbAttachments
            // 
            this.lbAttachments.AutoSize = true;
            this.lbAttachments.Location = new System.Drawing.Point(13, 107);
            this.lbAttachments.Name = "lbAttachments";
            this.lbAttachments.Size = new System.Drawing.Size(91, 13);
            this.lbAttachments.TabIndex = 11;
            this.lbAttachments.Text = "Прикрепленных:";
            // 
            // btAddAttachment
            // 
            this.btAddAttachment.BackColor = System.Drawing.SystemColors.Control;
            this.btAddAttachment.Location = new System.Drawing.Point(515, 107);
            this.btAddAttachment.Name = "btAddAttachment";
            this.btAddAttachment.Size = new System.Drawing.Size(75, 23);
            this.btAddAttachment.TabIndex = 12;
            this.btAddAttachment.Text = "Добавить";
            this.btAddAttachment.UseVisualStyleBackColor = false;
            this.btAddAttachment.Click += new System.EventHandler(this.btAddAttachment_Click);
            // 
            // btDeleteAttachment
            // 
            this.btDeleteAttachment.BackColor = System.Drawing.SystemColors.Control;
            this.btDeleteAttachment.Location = new System.Drawing.Point(596, 107);
            this.btDeleteAttachment.Name = "btDeleteAttachment";
            this.btDeleteAttachment.Size = new System.Drawing.Size(75, 23);
            this.btDeleteAttachment.TabIndex = 13;
            this.btDeleteAttachment.Text = "Удалить";
            this.btDeleteAttachment.UseVisualStyleBackColor = false;
            this.btDeleteAttachment.Click += new System.EventHandler(this.btDeleteAttachment_Click);
            // 
            // lbAttachmentsCount
            // 
            this.lbAttachmentsCount.AutoSize = true;
            this.lbAttachmentsCount.Location = new System.Drawing.Point(103, 109);
            this.lbAttachmentsCount.Name = "lbAttachmentsCount";
            this.lbAttachmentsCount.Size = new System.Drawing.Size(13, 13);
            this.lbAttachmentsCount.TabIndex = 14;
            this.lbAttachmentsCount.Text = "0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.безопасностьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // безопасностьToolStripMenuItem
            // 
            this.безопасностьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отправитьКлючToolStripMenuItem,
            this.btEncrypt});
            this.безопасностьToolStripMenuItem.Name = "безопасностьToolStripMenuItem";
            this.безопасностьToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.безопасностьToolStripMenuItem.Text = "Безопасность";
            // 
            // отправитьКлючToolStripMenuItem
            // 
            this.отправитьКлючToolStripMenuItem.Name = "отправитьКлючToolStripMenuItem";
            this.отправитьКлючToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.отправитьКлючToolStripMenuItem.Text = "Отправить ключ";
            this.отправитьКлючToolStripMenuItem.Click += new System.EventHandler(this.btSendKey_Click);
            // 
            // btEncrypt
            // 
            this.btEncrypt.Name = "btEncrypt";
            this.btEncrypt.Size = new System.Drawing.Size(165, 22);
            this.btEncrypt.Text = "Шифровать";
            this.btEncrypt.Click += new System.EventHandler(this.btEncrypt_Click);
            // 
            // GUI_MailCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(684, 441);
            this.Controls.Add(this.lbAttachmentsCount);
            this.Controls.Add(this.btDeleteAttachment);
            this.Controls.Add(this.btAddAttachment);
            this.Controls.Add(this.lbAttachments);
            this.Controls.Add(this.cbAttachments);
            this.Controls.Add(this.lbCopy);
            this.Controls.Add(this.lbTo);
            this.Controls.Add(this.tbSubject);
            this.Controls.Add(this.lbSublect);
            this.Controls.Add(this.tbCc);
            this.Controls.Add(this.tbRecipient);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.rtBody);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GUI_MailCreate";
            this.Text = "Новое сообщение";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtBody;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.TextBox tbRecipient;
        private System.Windows.Forms.TextBox tbCc;
        private System.Windows.Forms.Label lbSublect;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lbCopy;
        private System.Windows.Forms.Label lbTo;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Label lbAttachments;
        private System.Windows.Forms.ComboBox cbAttachments;
        private System.Windows.Forms.Button btAddAttachment;
        private System.Windows.Forms.Button btDeleteAttachment;
        private System.Windows.Forms.Label lbAttachmentsCount;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem безопасностьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отправитьКлючToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btEncrypt;
    }
}