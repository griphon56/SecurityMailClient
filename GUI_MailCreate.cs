using System;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net.Mime;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MailClient
{
    public partial class GUI_MailCreate : Form
    {
        MailMessage message;
        
        // Объявляю CspParmeters и RsaCryptoServiceProvider
        // объекты с глобальной областью класса Form.
        private static CspParameters cspp = new CspParameters();
        private static RSACryptoServiceProvider rsa;

        private static RijndaelManaged rijndael;

        const string keyName = "Key";
        private static Dictionary<string, string> keys = new Dictionary<string, string>();

        /// <summary>
        /// Инициализаци нового смс.
        /// </summary>
        public GUI_MailCreate()
        {
            InitializeComponent();
            message = new MailMessage();
            cspp.KeyContainerName = keyName;

            rsa = new RSACryptoServiceProvider(cspp);
            rsa.PersistKeyInCsp = true;

            // Создание экземпляра Rijndael 
            // для симмертричного шифрования.
            rijndael = new RijndaelManaged();
            rijndael.BlockSize = 128;
            rijndael.KeySize = 128;
            rijndael.Mode = CipherMode.CBC;

            if (File.Exists("contacts"))
                foreach (string s in File.ReadAllLines("contacts"))
                {
                    if(!keys.ContainsKey(s.Split(' ').First()))
                        keys.Add(s.Split(' ').First(), s.Split(' ').Last());
                }
        }

        /// <summary>
        /// Кнопка отправки сообщения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSend_Click(object sender, EventArgs e)
        {
            string errorMsg;
            if (!ValidEmailAddress(tbRecipient.Text, out errorMsg))
            {
                tbRecipient.Select(0, tbRecipient.Text.Length);

                // Устанавливает ошибку ErrorProvider с отображаемым текстом.
                this.errorProvider1.SetError(tbRecipient, errorMsg);
            }
            else if (tbCc.TextLength>0&&!ValidEmailAddress(tbCc.Text, out errorMsg))
            {
                tbRecipient.Select(0, tbCc.Text.Length);

                // Устанавливает ошибку ErrorProvider с отображаемым текстом.
                this.errorProvider2.SetError(tbCc, errorMsg);
            }
            else
            {
                // Создание SMTP клиента.
                SmtpClient smtpClient = new SmtpClient(Properties.Settings.Default.smtpHost,
                    Properties.Settings.Default.smtpPort);
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new System.Net.NetworkCredential(Properties.Settings.Default.smtpUsername,
                    Properties.Settings.Default.smtpPassword);

                // Создание Mail Adresses и построение смс.
                MailAddress to = new MailAddress(tbRecipient.Text);
                MailAddress from = new MailAddress(Properties.Settings.Default.smtpUsername);

                //message = new MailMessage(from, to);
                message.From = from;
                message.To.Add(to);
                message.IsBodyHtml = false;
                message.Body = rtBody.Text;
                message.Subject = tbSubject.Text;

                // Add cc address only if input
                if (tbCc.TextLength != 0)
                {
                    MailAddress cc = new MailAddress(tbCc.Text);
                    message.CC.Add(cc);
                }

                try
                {
                    smtpClient.Send(message);
                    MessageBox.Show("Сообщение отправлено!", "Успешно");
                    this.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при отправке сообщения. "+ ex.Message,
                          "Ошибка!");
                }    
            }
        }

        /// <summary>
        /// Метод проверки валидности получателя.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbRecipient_Validated(object sender, System.EventArgs e)
        {
            //Если все условия выполнены, очистит ErrorProvider от ошибок.
            errorProvider1.SetError(tbRecipient, "");
        }

        /// <summary>
        /// Метод проверки валидности получателя копии смс.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbCc_Validated(object sender, System.EventArgs e)
        {
            //Если все условия выполнены, очистит ErrorProvider от ошибок.
            errorProvider1.SetError(tbCc, "");
        }

        /// <summary>
        /// Метод проверка валидности почтового адреса.
        /// </summary>
        /// <param name="emailAddress">Почтовый адрес.</param>
        /// <param name="errorMessage">Сообщение об ошибке.</param>
        /// <returns>
        /// <th>true</th>Сообшение об ошибке.
        /// <th>false</th>Пустая строка.
        /// </returns>
        public bool ValidEmailAddress(string emailAddress, out string errorMessage)
        {
            // Confirm that there is an "@" and a "." in the e-mail address, and in the correct order.
            if (emailAddress.IndexOf("@") > -1)
            {
                if (emailAddress.IndexOf(".", emailAddress.IndexOf("@")) > emailAddress.IndexOf("@"))
                {
                    errorMessage = "";
                    return true;
                }
            }

            errorMessage = "Некорректный формат получателя письма.\n" +
               "Пример адреса - 'someone@example.com' ";
            return false;
        }


        /// <summary>
        /// Метод добавления цифровой подписи к сообщению.
        /// </summary>
        /// <param name="body_msg">Тело сообщения</param>
        public void addEDS(string msg_name)
        {
            // ДОБАВЛЕНИЕ ЦИФРОВОЙ ПОДПИСИ К СМС 
            // Файл переводим в байтовый массив. 
            byte[] msg = File.ReadAllBytes(msg_name);
            // Получаем зашифрованную сигнатуру(зашифрованный хеш  смс) в байтовый массив
            byte[] signature = rsa.SignData(msg, new SHA1CryptoServiceProvider());
            // Получить длинну хеша.
            int lSign = signature.Length;
            // Перевести длинну  хеша в байтовый массив.
            byte[] LenSign = BitConverter.GetBytes(lSign);

            //Прикрепляю цифровую подписть в начало смс.
            using (FileStream outF = new FileStream(msg_name, FileMode.Create))
            {
                outF.Write(LenSign, 0, 4);
                outF.Write(signature, 0, lSign);
                outF.Write(msg, 0, msg.Length);
                outF.Close();
            }
        }

        /// <summary>
        /// Метод шифрования.
        /// </summary>
        /// <param name="msg_name">Тело смс</param>
        /// <param name="tmp_name">Времменное тело</param>
        public void encrypt(string msg_name, string tmp_name)
        {
            // Создаем объект для симметричного шифрования.
            ICryptoTransform transform = rijndael.CreateEncryptor();

            // Используется RijndaelManaged для шифрования ключа. 
            // предварительно создается rsa :
            // rsa = new RSACryptoServiceProvider (cspp);
            byte[] keyEncrypted = rsa.Encrypt(rijndael.Key, false);

            // Создание байт-массивов для хранения
            // значения длины ключа и IV.
            int lKey = keyEncrypted.Length;
            byte[] LenK = BitConverter.GetBytes(lKey);
            int lIV = rijndael.IV.Length;
            byte[] LenIV = BitConverter.GetBytes(lIV);

            // Записываю информацию о векторе и ключе.
            FileStream outFs = new FileStream(tmp_name, FileMode.Create);
            outFs.Write(LenK, 0, 4);
            outFs.Write(LenIV, 0, 4);
            outFs.Write(keyEncrypted, 0, lKey);
            outFs.Write(rijndael.IV, 0, lIV);

            // Записываем шифрованный текст используя CryptoStream.
            CryptoStream outStreamEncrypted = new CryptoStream(outFs, transform, CryptoStreamMode.Write);
            int count = 0;
            int offset = 0;

            // blockSizeBytes can be any arbitrary size.
            int blockSize = rijndael.BlockSize / 8;
            byte[] data = new byte[blockSize];
            int bytesRead = 0;


            FileStream inFs = new FileStream(msg_name, FileMode.Open);
            do
            {
                count = inFs.Read(data, 0, blockSize);
                offset += count;
                outStreamEncrypted.Write(data, 0, count);
                bytesRead += blockSize;
            }
            while (count > 0);
            inFs.Close();
            outStreamEncrypted.FlushFinalBlock();
            outStreamEncrypted.Close();
            rtBody.Text = ByteArrToString(File.ReadAllBytes(tmp_name));
        }

        /// <summary>
        /// Кнопка шифрования смс.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btEncrypt_Click(object sender, EventArgs e)
        {
            File.Delete("msg");
            File.Delete("tmp");
            File.Delete("msg_send");
            // У Клиента не ключа для шифрования смс.
            if (!keys.Keys.Contains(tbRecipient.Text))
            {
                MessageBox.Show("Отсутствует ключ для данного получателя!", "Ошибка");
            }
            // Зашифровка смс.
            else if(tbRecipient.Text.Length != 0 && rtBody.Text.Length !=0)
            {
                // Тело сообщения записываем в файл
                File.WriteAllText("msg", rtBody.Text);

                // Добавляю подпись.
                addEDS("msg");

                // Получаю (из XML) ключ отправленный получателю.
                rsa.FromXmlString(keys[tbRecipient.Text]);

                // Шифрую подпись смс.
                encrypt("msg", "tmp");
                
                // Шифрую смс.
                encrypt("tmp", "msg_send");
            }
            btEncrypt.Enabled = false;
            File.Delete("msg");
            File.Delete("tmp");
            File.Delete("msg_send");
        }

        /// <summary>
        /// Метод прикрепления вложения в сообщению.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAddAttachment_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Выберите файл для прикрепления.";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                Attachment attach = new Attachment(openFile.FileName,MediaTypeNames.Application.Octet);

                // Добавляем информацию для файла
                ContentDisposition disposition = attach.ContentDisposition;
                disposition.CreationDate = System.IO.File.GetCreationTime(openFile.FileName);
                disposition.ModificationDate = System.IO.File.GetLastWriteTime(openFile.FileName);
                disposition.ReadDate = System.IO.File.GetLastAccessTime(openFile.FileName);

                message.Attachments.Add(attach);
                cbAttachments.Items.Add(openFile.FileName);
                cbAttachments.SelectedIndex = cbAttachments.Items.Count-1;
                lbAttachmentsCount.Text = message.Attachments.Count.ToString();
            }

        }

        /// <summary>
        /// Удалить прикрепленное вложение.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btDeleteAttachment_Click(object sender, EventArgs e)
        {
            if(cbAttachments.SelectedIndex > -1)
            {      
                message.Attachments.RemoveAt(cbAttachments.SelectedIndex);
                cbAttachments.Items.RemoveAt(cbAttachments.SelectedIndex);
                cbAttachments.SelectedIndex = cbAttachments.Items.Count-1;
                lbAttachmentsCount.Text = message.Attachments.Count.ToString();
            }
        }

        /// <summary>
        /// Метод отправки ключа.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSendKey_Click(object sender, EventArgs e)
        {
            string errorMsg;
            if (!ValidEmailAddress(tbRecipient.Text, out errorMsg))
            {
                tbRecipient.Select(0, tbRecipient.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.errorProvider1.SetError(tbRecipient, errorMsg);
            }
            else
            {
                // Создаю SMTP клиент.
                SmtpClient smtpClient = new SmtpClient(Properties.Settings.Default.smtpHost,
                    Properties.Settings.Default.smtpPort);
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new System.Net.NetworkCredential(Properties.Settings.Default.smtpUsername,
                    Properties.Settings.Default.smtpPassword);

                // Создаю Mail Adresses и структуру смс
                // Получатель.
                MailAddress to = new MailAddress(tbRecipient.Text);
                // Отправитель.
                MailAddress from = new MailAddress(Properties.Settings.Default.smtpUsername);

                //message = new MailMessage(from, to);
                message.From = from;
                message.To.Add(to);
                message.IsBodyHtml = false;
                message.Body = rsa.ToXmlString(true);
                message.Subject = "KEYMAIL";

                try
                {
                    smtpClient.Send(message);
                    MessageBox.Show("Сообщение отправлено!", "Успешно");
                    this.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при отправке сообщения. " + ex.Message,
                          "Ошибка!");
                }
            }

        }

        /// <summary>
        /// Метод переводе из строки в байтовый массив.
        /// </summary>
        /// <param name="str">Строка для перевода.</param>
        /// <returns></returns>
        static public byte[] StrToByteArray(string str)
        {
            if (str.Length == 0)
                throw new Exception("Invalid string value in StrToByteArray");

            byte val;
            byte[] byteArr = new byte[str.Length / 3];
            int i = 0;
            int j = 0;
            do
            {
                val = byte.Parse(str.Substring(i, 3));
                byteArr[j++] = val;
                i += 3;
            }
            while (i < str.Length);
            return byteArr;
        }

        /// <summary>
        /// Метод переводе из байтового массива в строку.
        /// </summary>
        /// <param name="byteArr">Байтовый массив для перевода.</param>
        /// <returns></returns>
        public string ByteArrToString(byte[] byteArr)
        {
            byte val;
            string tempStr = "";
            for (int i = 0; i <= byteArr.GetUpperBound(0); i++)
            {
                val = byteArr[i];
                if (val < (byte)10)
                    tempStr += "00" + val.ToString();
                else if (val < (byte)100)
                    tempStr += "0" + val.ToString();
                else
                    tempStr += val.ToString();
            }
            return tempStr;
        }
    }
}