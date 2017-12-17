using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenPop.Mime;
using OpenPop.Mime.Header;
using OpenPop.Mime.Traverse;
using OpenPop.Pop3;
using OpenPop.Pop3.Exceptions;
using OpenPop.Common.Logging;
using Message = OpenPop.Mime.Message;
using System.IO;
using System.Security.Cryptography;
using System.Net.Mail;

namespace MailClient
{
    public partial class GUI_Main : Form
    {
        private readonly Pop3Client pop3Client;
        // Объявляю CspParmeters и RsaCryptoServiceProvider
        // объекты с глобальной областью класса Form.
        private static CspParameters cspp = new CspParameters();
        private static RSACryptoServiceProvider rsa;

        private static AesCryptoServiceProvider aes;

        const string keyName = "Key";
        private readonly Dictionary<int, Message> messages = new Dictionary<int, Message>();
        private static Dictionary<string, string> keys = new Dictionary<string, string>();

        List<string> seenUids = new List<string>();

        public GUI_Main()
        {
            InitializeComponent();
            pop3Client = new Pop3Client();
            cspp.KeyContainerName = keyName;
            rsa = new RSACryptoServiceProvider(cspp);
            rsa.PersistKeyInCsp = true;

            // Создание экземпляра Rijndael 
            // для симмертричного шифрования.
            aes = new AesCryptoServiceProvider();
            aes.BlockSize = 128;
            aes.KeySize = 128;
            aes.Mode = CipherMode.CBC;
            if (File.Exists("ids")) seenUids.AddRange(File.ReadAllLines("ids"));
            if (File.Exists("contacts"))
                foreach (string s in File.ReadAllLines("contacts"))
                {
                    keys.Add(s.Split(' ').First(),s.Split(' ').Last());
                }
        }

        /// <summary>
        /// Кнопка перекинет на форму создания смс (Через меню).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_MailCreate MailForm = new GUI_MailCreate();
            MailForm.Show();
        }

        /// <summary>
        /// Кнопка перекинет на форму настроек.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void optionsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GUI_Option OptionForm = new GUI_Option();
            OptionForm.Show();
        }

        /// <summary>
        /// Кнопка закроет приложение.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Кнопка перекинет на форму создания смс.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbstNew_Click(object sender, EventArgs e)
        {
            GUI_MailCreate MailForm = new GUI_MailCreate();
            MailForm.Show();
        }

        /// <summary>
        /// Кнопка получения писем.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbstGet_Click(object sender, EventArgs e)
        {
            ReceiveMails();
        }

        /// <summary>
        /// Метод получение писем.
        /// </summary>
        private void ReceiveMails()
        {
            tsbtNew.Enabled = false;
            tsbtGet.Enabled = false;
            this.progressBar.Value = 0;

            messages.Clear();

            try
            {
                if (pop3Client.Connected)
                    pop3Client.Disconnect();

                // Подключаюсь к почте.
                pop3Client.Connect(Properties.Settings.Default.popHost, Properties.Settings.Default.popPort, Properties.Settings.Default.popUseSSL);
                pop3Client.Authenticate(Properties.Settings.Default.popUsername, Properties.Settings.Default.popPassword);
                int count = pop3Client.GetMessageCount();
                totalMessagesCount.Text = count.ToString();
                mailViewer.DocumentText = "";
                listMessages.Nodes.Clear();

                int success = 0;
                int fail = 0;
                Font bold = new Font(listMessages.Font, FontStyle.Bold);
                for (int i = count; i >= 1; i--)
                {
                    if (IsDisposed)
                        return;

                    Application.DoEvents();

                    try
                    {
                        Message message = pop3Client.GetMessage(i);

                        messages.Add(i, message);
                        TreeNode node = new TreeNodeBuilder().VisitMessage(message);
                        node.Tag = i;

                        node.Text = (message.Headers.Subject != null) ?
                            message.Headers.From.ToString() + " " + message.Headers.Subject.ToString() :
                            message.Headers.From.ToString() + " Без темы";

                        if (!seenUids.Contains(message.Headers.MessageId))
                            node.NodeFont = bold;

                        listMessages.Nodes.Add(node);

                        if(message.Headers.Subject == "KEYMAIL")
                        {
                            if (!keys.ContainsKey(message.Headers.From.Address))
                                {
                                DialogResult dialogResult = MessageBox.Show("Импортировать ключ для " + message.Headers.From.Address, "Импорт", MessageBoxButtons.YesNo);
                                if(dialogResult == DialogResult.Yes)
                                {
                                    keys.Add(message.Headers.From.Address,message.FindFirstPlainTextVersion().GetBodyAsText());
                                    File.AppendAllText("contacts", message.Headers.From.Address + " " + message.FindFirstPlainTextVersion().GetBodyAsText());
                                }
                            }
                            

                        }
                        success++;
                    }
                    catch (Exception e)
                    {
                        DefaultLogger.Log.LogError(
                            "Ошибка загрузки писем: " + e.Message + "\r\n" +
                            "Stack trace:\r\n" +
                            e.StackTrace);
                        fail++;
                    }

                    this.progressBar.Value = (int)(((double)(count - i) / count) * 100);
                }

                MessageBox.Show(this, "Письма получены!\nУспешно: " + success + "\nОшибок: " + fail, "Загрузка писем завершена");

                if (fail > 0)
                {
                    MessageBox.Show(this,
                                    "Since some of the emails were not parsed correctly (exceptions were thrown)\r\n" +
                                    "please consider sending your log file to the developer for fixing.\r\n" +
                                    "If you are able to include any extra information, please do so.",
                                    "Help improve OpenPop!");
                }
            }
            catch (InvalidLoginException)
            {
                MessageBox.Show(this, "Проверьте правильность учетных данных!", "Ошибка авторизации POP3");
            }
            catch (PopServerNotFoundException)
            {
                MessageBox.Show(this, "Проверьте корректность сервера и порта POP3!", "POP3 сервер не найден");
            }
            catch (PopServerLockedException)
            {
                MessageBox.Show(this, "Доступ к почтовому ящику заблокирован.", "POP3 заблокирован");
            }
            catch (LoginDelayException)
            {
                MessageBox.Show(this, "Слишком скорая попытка повторной авторизации", "POP3 задержка");
            }
            catch (Exception e)
            {
                MessageBox.Show(this, "Что-то пошло не так. " + e.Message, "POP3 Ошибка");
            }
            finally
            {
                tsbtNew.Enabled = true;
                tsbtGet.Enabled = true;
                if (pop3Client.Connected) pop3Client.Disconnect();
                this.progressBar.Value = 100;
            }
        }

        /// <summary>
        /// Список сообщений.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListMessagesMessageSelected(object sender, TreeViewEventArgs e)
        {             
            Message message = messages[GetMessageNumberFromSelectedNode(listMessages.SelectedNode)];
            List<MessagePart> att = message.FindAllAttachments();
            cbAttachments.Items.Clear();
            if (message.FindAllAttachments().Count > 0)
            {               
                foreach (MessagePart at in att)
                    cbAttachments.Items.Add(at.FileName);
                btDownload.Enabled = true;
                lbAttachmentsCount.Text = cbAttachments.Items.Count.ToString();
            }
            else
            {
                lbAttachmentsCount.Text = "0";
                btDownload.Enabled = false;
            }

            StringBuilder tmp = new StringBuilder();
            foreach (RfcMailAddress a in message.Headers.To)
            {
                tmp.Append(a.ToString() + " ");
            }
            tbFrom.Text = message.Headers.From.ToString();
            tbTo.Text = tmp.ToString();
            if (message.Headers.Subject != null)
                tbSubject.Text = message.Headers.Subject.ToString();
            else tbSubject.Text = "Без темы";
            changeButtonsState();
            if (seenUids.Contains(message.Headers.MessageId))
            {
                listMessages.SelectedNode.NodeFont = listMessages.Font;                
            }
            else
            {
                listMessages.SelectedNode.NodeFont = listMessages.Font;
                seenUids.Add(message.Headers.MessageId);
                File.AppendAllText("ids", message.Headers.MessageId+"\n");                
            }
            
            if (listMessages.SelectedNode.Tag is MessagePart)
            {
                MessagePart selectedMessagePart = (MessagePart)listMessages.SelectedNode.Tag;
                mailViewer.DocumentText = selectedMessagePart.GetBodyAsText();
            }
            else
            {
                MessagePart plainTextPart = message.FindFirstHtmlVersion();
                if (plainTextPart != null)
                {
                    mailViewer.DocumentText = plainTextPart.GetBodyAsText();
                }
                else
                {
                    List<MessagePart> textVersions = message.FindAllTextVersions();
                    if (textVersions.Count >= 1) {
                        mailViewer.DocumentText = textVersions[0].GetBodyAsText();
                    }
                    else
                        mailViewer.DocumentText = "<<OpenPop>> Cannot find a text version body in this message to show <<OpenPop>>";
                }
            }
            listMessages.Refresh();
        }

        /// <summary>
        /// Метод для получения номера смс в выбранной ноде дерева
        /// </summary>
        /// <param name="node">Нода дерева</param>
        /// <returns></returns>
        private static int GetMessageNumberFromSelectedNode(TreeNode node)
        {
            if (node == null)
                throw new ArgumentNullException("node");

            // Check if we are at the root, by seeing if it has the Tag property set to an int
            if (node.Tag is int)
            {
                return (int)node.Tag;
            }

            // Otherwise we are not at the root, move up the tree
            return GetMessageNumberFromSelectedNode(node.Parent);
        }

        /// <summary>
        /// Метод расшифровки смс.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbstCrypto_Click(object sender, EventArgs e)
        {
            File.Delete("msg");
            File.Delete("tmp");
            
            if (mailViewer.DocumentText.Length != 0)
            {
                try
                {
                    rsa = new RSACryptoServiceProvider(cspp);
                    rsa.PersistKeyInCsp = true;
                    // Записываем тело смс в байтовый массив. 
                    File.WriteAllBytes("tmp", StrToByteArray(mailViewer.DocumentText.TrimEnd("\r\n".ToCharArray())));
                   
                    // Используем объект FileStream для чтения зашифрованного
                    // файла (inFs) и сохранить дешифрованный файл (outFs)
                    FileStream inFs = new FileStream("tmp", FileMode.Open);
                    
                    // Создаем массивы байтов, чтобы получить длину
                    // зашифрованный ключ и IV.
                    // Эти значения сохранялись как 4 байта каждый
                    // в начале зашифрованного пакета
                    byte[] LenK = new byte[4];
                    inFs.Read(LenK, 0, 4);
                    byte[] LenIV = new byte[4];
                    inFs.Read(LenIV, 0, 4);

                    int lenK = BitConverter.ToInt32(LenK, 0);
                    int lenIV = BitConverter.ToInt32(LenIV, 0);

                    // Определяем начальную позицию 
                    // зашифрованного текста (startS) и его длины (lenC).
                    int startC = lenK + lenIV + 8;
                    int lenC = (int)inFs.Length - startC;

                    // Создаем байтовые массивы для
                    // зашифрованный ключ , IV и шифрованный текст.
                    byte[] KeyEncrypted = new byte[lenK];
                    byte[] IV = new byte[lenIV];

                    // Извлечение ключа и IV
                    // начиная с 8-го индекса
                    // после значений длины.
                    inFs.Seek(8, SeekOrigin.Begin);
                    inFs.Read(KeyEncrypted, 0, lenK);
                    inFs.Seek(8 + lenK, SeekOrigin.Begin);
                    inFs.Read(IV, 0, lenIV);

                    // Используется RSACryptoServiceProvider для расшифровки ключа.
                    byte[] KeyDecrypted = rsa.Decrypt(KeyEncrypted, false);

                    ICryptoTransform transform = aes.CreateDecryptor(KeyDecrypted, IV);

                    // Расшифровка шифрованного текст с помощью FileSteam
                    // зашифрованного файла (inFs) в FileStream
                    // для дешифрованного файла (outFs).
                    FileStream outFs = new FileStream("msg", FileMode.Create);
                    int count = 0;
                    int offset = 0;

                    int blockSizeBytes = aes.BlockSize / 8;
                    byte[] data = new byte[blockSizeBytes];


                    inFs.Seek(startC, SeekOrigin.Begin);
                    CryptoStream outStreamDecrypted = new CryptoStream(outFs, transform, CryptoStreamMode.Write);
                    do
                    {
                        count = inFs.Read(data, 0, blockSizeBytes);
                        offset += count;
                        outStreamDecrypted.Write(data, 0, count);
                    }
                    while (count > 0);

                    outStreamDecrypted.FlushFinalBlock();
                    outStreamDecrypted.Close();
                    outFs.Close();
                    inFs.Close();
                    if (!keys.Keys.Contains(new MailAddress(tbFrom.Text).Address))
                    {
                        MessageBox.Show("Отсутствует ключ для данного отправителя!", "Ошибка");
                    }
                    else
                    {
                        // Проверка цифровой подписи.
                        rsa.FromXmlString(keys[new MailAddress(tbFrom.Text).Address]);
                        using (FileStream inF = new FileStream("msg", FileMode.Open))
                        {
                            byte[] LenSign = new byte[4];
                            inF.Read(LenSign, 0, 4);

                            int lenSign = BitConverter.ToInt32(LenSign, 0);

                            int startData = lenSign + 4;
                            int lenData = (int)inF.Length - startData;

                            byte[] sign = new byte[lenSign];
                            byte[] msg = new byte[lenData];

                            inF.Read(sign, 0, lenSign);
                            inF.Read(msg, 0, lenData);

                            if (rsa.VerifyData(msg, new MD5CryptoServiceProvider(), sign))
                            {
                                mailViewer.DocumentText = Encoding.UTF8.GetString(msg);
                            }
                            else MessageBox.Show("Ошибка проверки подписи письма!", "Ошибка");
                            inF.Close();
                        }
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка расшифровки: " + ex.Message);
                }
            }
            File.Delete("msg");
            File.Delete("tmp");
        }

        /// <summary>
        /// Кнопка настройка - перенесет на форму настройки протокола (SMTP POP3)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtSettings_Click(object sender, EventArgs e)
        {
            GUI_Option OptionForm = new GUI_Option();
            OptionForm.Show();
        }

        /// <summary>
        /// Сохранение смс и добавление к нему цифровой подписи.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbstSave_Click(object sender, EventArgs e)
        {
            cspp.KeyContainerName = keyName;
            rsa = new RSACryptoServiceProvider(cspp);
            rsa.PersistKeyInCsp = true;
            Message message = messages[GetMessageNumberFromSelectedNode(listMessages.SelectedNode)];
            string name = "Messages/" + message.Headers.MessageId + ".mmsg";
            FileInfo f = new FileInfo(name);            

            // Добавление цифровой подписи.
            byte[] data = message.RawMessage;

            byte[] signature = rsa.SignData(data, new MD5CryptoServiceProvider());

            int lSign = signature.Length;

            byte[] LenSign = BitConverter.GetBytes(lSign);

            using (FileStream outFs = new FileStream(name, FileMode.Create))
            {
                outFs.Write(LenSign, 0, 4);
                outFs.Write(signature, 0, lSign);
                outFs.Write(data, 0, data.Length);
                outFs.Close();
            }
        }

        /// <summary>
        /// Метод открытия сохраненного смс и проверка цифровой подписи.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbstOpen_Click(object sender, EventArgs e)
        {
            cspp.KeyContainerName = keyName;
            rsa = new RSACryptoServiceProvider(cspp);
            rsa.PersistKeyInCsp = true;
            // Выбираю смс для просмотра.
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.RestoreDirectory = true;
            openFile.InitialDirectory = "Messages";
            openFile.Title = "Выберите письмо для просмотра.";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                tbstSave.Visible = false;
                tbstDelete.Visible = false;
                listMessages.SendToBack();
                string fileName = openFile.FileName;

                // Проверка цифровой подписи.
                using (FileStream inFs = new FileStream(fileName, FileMode.Open))
                {
                    byte[] LenSign = new byte[4];
                    inFs.Read(LenSign, 0, 4);

                    int lenSign = BitConverter.ToInt32(LenSign, 0);

                    int startData = lenSign + 4;
                    int lenData = (int)inFs.Length - startData;

                    byte[] sign = new byte[lenSign];
                    byte[] data = new byte[lenData];

                    inFs.Read(sign, 0, lenSign);
                    inFs.Read(data, 0, lenData);

                    if (rsa.VerifyData(data, new MD5CryptoServiceProvider(), sign)) {
                        Message message = new Message(data);
                        StringBuilder tmp = new StringBuilder();
                        foreach (RfcMailAddress a in message.Headers.To)
                        {
                            tmp.Append(a.ToString() + " ");
                        }
                        tbFrom.Text = message.Headers.From.ToString();
                        tbTo.Text = tmp.ToString();
                        tbSubject.Text = message.Headers.Subject.ToString();
                        MessagePart plainTextPart = message.FindFirstPlainTextVersion();
                        if (plainTextPart != null)
                        {
                            mailViewer.DocumentText = plainTextPart.GetBodyAsText().TrimEnd('\r', '\n');
                        }
                        else
                        {
                            List<MessagePart> textVersions = message.FindAllTextVersions();
                            if (textVersions.Count >= 1)
                            {
                                mailViewer.DocumentText = textVersions[0].GetBodyAsText().TrimEnd('\r', '\n');
                            }
                            else
                                mailViewer.DocumentText = "<<OpenPop>> Cannot find a text version body in this message to show <<OpenPop>>";
                        }


                    }
                    else MessageBox.Show("Ошибка проверки подписи файла письма!","Ошибка");
                }
            }
        }


        private void listMessages_Enter(object sender, EventArgs e)
        {
            changeButtonsState();
        }

        private void listMessages_Leave(object sender, EventArgs e)
        {
            changeButtonsState();
        }

        /// <summary>
        /// Скрыть\Показать кнопки (Расшифровать, сохранить, удалить)
        /// </summary>
        private void changeButtonsState()
        {
            if (tbFrom.Text.Length == 0)
            {
                tbstCrypto.Visible = false;
                tbstSave.Visible = false;
                tbstDelete.Visible = false;
            }
            else
            {
                tbstCrypto.Visible = true;
                tbstSave.Visible = true;
                tbstDelete.Visible = true;
            }
        }

        /// <summary>
        /// Метод удаления сообщения из почты.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbstDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить письмо?", "Удаление", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (pop3Client.Connected)
                    pop3Client.Disconnect();
                pop3Client.Connect(Properties.Settings.Default.popHost, Properties.Settings.Default.popPort, Properties.Settings.Default.popUseSSL);
                pop3Client.Authenticate(Properties.Settings.Default.popUsername, Properties.Settings.Default.popPassword);

                pop3Client.DeleteMessage(GetMessageNumberFromSelectedNode(listMessages.SelectedNode));
                listMessages.Nodes.Remove(listMessages.SelectedNode);
                if (pop3Client.Connected) pop3Client.Disconnect();
                totalMessagesCount.Text = Convert.ToString(Convert.ToInt32(totalMessagesCount.Text) - 1);
            }
        }

        /// <summary>
        /// Метод обновления списка сообщений.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists("ids")) File.Delete("ids");
            seenUids.Clear();
            listMessages.Refresh();
        }

        /// <summary>
        /// Метод скачивания вложения из сообщения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btDownload_Click(object sender, EventArgs e)
        {
            if (cbAttachments.SelectedIndex >= 0)
            {
                Message message = messages[GetMessageNumberFromSelectedNode(listMessages.SelectedNode)];
                MessagePart at = message.FindAllAttachments().ElementAt(cbAttachments.SelectedIndex);
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.FileName = cbAttachments.SelectedText;
                saveFile.Title = "Выберите, куда сохранить файл.";
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    at.Save(new FileInfo(saveFile.FileName));
                }
            }
            
        }

        /// <summary>
        /// Метод переводе из строки в байтовый массив.
        /// </summary>
        /// <param name="str"></param>
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
        /// <param name="byteArr"></param>
        /// <returns></returns>
        static public string ByteArrToString(byte[] byteArr)
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

    internal class TreeNodeBuilder : IAnswerMessageTraverser<TreeNode>
    {
        /// <summary>
        /// Просмотреть сообщение.
        /// </summary>
        /// <param name="message">Объект сообщения</param>
        /// <returns></returns>
        public TreeNode VisitMessage(Message message)
        {
            if (message == null)
                throw new ArgumentNullException("message");

            TreeNode child = VisitMessagePart(message.MessagePart);

            TreeNode topNode = new TreeNode(message.Headers.Subject, new[] { child });

            return topNode;
        }

        /// <summary>
        /// Просмотреть часть сообщения.
        /// </summary>
        /// <param name="messagePart"></param>
        /// <returns>Текущую ноду</returns>
        public TreeNode VisitMessagePart(MessagePart messagePart)
        {
            if (messagePart == null)
                throw new ArgumentNullException("messagePart");

            TreeNode[] children = new TreeNode[0];

            if (messagePart.IsMultiPart)
            {
                children = new TreeNode[messagePart.MessageParts.Count];

                for (int i = 0; i < messagePart.MessageParts.Count; i++)
                {
                    children[i] = VisitMessagePart(messagePart.MessageParts[i]);
                }
            }

            TreeNode currentNode = new TreeNode(messagePart.ContentType.MediaType, children);

            currentNode.Tag = messagePart;

            return currentNode;
        }
    }

}
