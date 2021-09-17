using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Diagnostics;
using System.Xml;
using System.Linq;
using System.Globalization;
using System.Drawing;
using IWshRuntimeLibrary;

namespace date_changer
{
    public partial class Form1 : Form
    {
        #region Title Panel Move
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        #region Public Strings
        public string filePath
        {
            get { return fileLocTxt.Text; }
            set { fileLocTxt.Text = value; }
        }

        public string onlyFileName
        {
            get { return Path.GetFileName(filePath); }
            set { onlyFileName = value; }
        }
        #endregion

        #region System Time Related
        [DllImport("kernel32.dll")]
        private extern static void GetSystemTime(ref SYSTEMTIME lpSystemTime);

        [DllImport("kernel32.dll")]
        private extern static uint SetSystemTime(ref SYSTEMTIME lpSystemTime);
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct SYSTEMTIME
        {
            public short wYear;
            public short wMonth;
            public short wDayOfWeek;
            public short wDay;
            public short wHour;
            public short wMinute;
            public short wSecond;
            public short wMilliseconds;

            public SYSTEMTIME(DateTime value)
            {
                wYear = (short)value.Year;
                wMonth = (short)value.Month;
                wDayOfWeek = (short)value.DayOfWeek;
                wDay = (short)value.Day;
                wHour = (short)value.Hour;
                wMinute = (short)value.Minute;
                wSecond = (short)value.Second;
                wMilliseconds = (short)value.Millisecond;
            }
        }
        #endregion

        public Form1()
        {
            InitializeComponent();

            //Apply shadow to borderless form
            (new Core.DropShadow()).ApplyShadows(this);
        }

        #region Single Instance
        protected override void WndProc(ref Message message)
        {
            if (message.Msg == SingleInstance.WM_SHOWFIRSTINSTANCE)
            {
                ShowWindow();
            }
            base.WndProc(ref message);
        }
        public void ShowWindow()
        {
            // Insert code here to make your form show itself.
            WinApi.ShowToFront(this.Handle);
        }
        #endregion

        #region Form Load Handle
        private void Form1_Load(object sender, EventArgs e)
        {
            if (filePath != "")
            {
                if (System.IO.File.Exists(filePath))
                {
                    consoleLog.AppendText("Opened file " + "'" + onlyFileName + "'");
                    consoleLog.AppendText(Environment.NewLine);
                    startBtn.Enabled = true;
                    startBtn.BackColor = Color.SeaGreen;
                }
            }
            else
            {
                consoleLog.AppendText("Open a file to excecute");
                consoleLog.AppendText(Environment.NewLine);
                startBtn.Enabled = false;
                startBtn.BackColor = Color.FromArgb(60, 60, 60);
            }

            if (Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "*.xml").Length != 0)
            {
                string currentPath = AppDomain.CurrentDomain.BaseDirectory;
                string[] textFiles = Directory.GetFiles(currentPath, "*.xml");
                foreach (string file in textFiles)
                {
                    // Remove the directory from the string
                    string filename = Path.GetFileName(file);
                    // Remove the extension from the filename
                    string name = filename.Substring(0, filename.LastIndexOf(@"."));
                    // Add the name to the combo box
                    savesBox.Items.Add(name.Replace("date-changer-settings-", ""));
                }
            }

            string[] files = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory)
                              .Where(p => p.EndsWith(".xml"))
                              .ToArray();
            foreach (var path in files)
            {
                XmlDocument settXML = new XmlDocument();
                settXML.Load(path);
                string xSett = "date-changer/setting[@default='{0}']";
                string settAttr = "true";

                xSett = String.Format(xSett, settAttr);
                XmlNode settNode = settXML.SelectSingleNode(xSett);

                if (settNode != null)
                {
                    string foundDefault = Path.GetFileName(settXML.BaseURI);
                    foundDefault = foundDefault.Substring(0, foundDefault.LastIndexOf(@"."));
                    savesBox.SelectedItem = foundDefault.Replace("date-changer-settings-", "");
                }
            }

            if (dateTimePicker1.Value.Date == DateTime.Today)
            {
                resetDate.Enabled = false;
            }
            else
            {
                resetDate.Enabled = true;
            }

        }
        #endregion

        #region Form Closing Handle
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dateTimePicker1.Value.Date != DateTime.Now)
            {
                Process proc = new Process();
                proc.StartInfo.FileName = "w32tm";
                proc.StartInfo.Arguments = "/resync";
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.RedirectStandardOutput = true;
                proc.StartInfo.CreateNoWindow = true;
                proc.Start();
            }
        }
        #endregion

        #region Title Stuff
        private void titlePnl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void titlePnl_MouseDown(object sender, MouseEventArgs e)
        {
            this.ActiveControl = null;
        }

        private void titleLbl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void titleLbl_MouseDown(object sender, MouseEventArgs e)
        {
            this.ActiveControl = null;
        }
        #endregion

        #region Buttons
        private void helpBtn_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.ShowDialog();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void minBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void defaultBtn_Click(object sender, EventArgs e)
        {
            XmlDocument settXML = new XmlDocument();
            string[] files = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory)
                              .Where(p => p.EndsWith(".xml"))
                              .ToArray();
            foreach (var path in files)
            {
                settXML.Load(path);
                string xSett = "date-changer/setting[@default='{0}']";
                string settAttr = "true";

                xSett = String.Format(xSett, settAttr);
                XmlNode settNodes = settXML.SelectSingleNode(xSett);

                if (settNodes != null)
                {
                    settNodes.Attributes["default"].Value = "";
                    settXML.Save(path);
                }
            }

            string selectedItem = savesBox.SelectedItem.ToString();
            string settPath = "date-changer-settings-" + selectedItem + ".xml";
            settXML.Load(settPath);
            
            XmlNode settNode = settXML.SelectSingleNode("date-changer/setting");

            if (settNode.Attributes["default"].Value == "")
            {
                settNode.Attributes["default"].Value = "true";
                settXML.Save("date-changer-settings-" + selectedItem + ".xml");
                defaultBtn.Enabled = false;
            }


        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string selectedItem = savesBox.SelectedItem.ToString();
            if (System.IO.File.Exists("date-changer-settings-" + selectedItem + ".xml"))
            {
                System.IO.File.Delete("date-changer-settings-" + selectedItem + ".xml");
                consoleLog.AppendText("Removed '" + selectedItem + "'");
                consoleLog.AppendText(Environment.NewLine);
                savesBox.Items.Remove(selectedItem);
                deleteBtn.Enabled = false;
                defaultBtn.Enabled = false;
                
                if (System.IO.File.Exists("date-changer-settings-" + nameTxt.Text + ".xml"))
                {
                    XmlDocument settXML = new XmlDocument();
                    settXML.Load("date-changer-settings-" + nameTxt.Text + ".xml");

                    string xPath = "date-changer/setting/path[@content='{0}']";
                    string pathAttr = fileLocTxt.Text;

                    xPath = String.Format(xPath, pathAttr);
                    XmlNode pathNode = settXML.SelectSingleNode(xPath);

                    string xDate = "date-changer/setting/date[@content='{0}']";
                    string dateAttr = dateTimePicker1.Value.Date.ToString("MM - dd - yyyy");

                    xDate = String.Format(xDate, dateAttr);
                    XmlNode dateNode = settXML.SelectSingleNode(xDate);

                    if (pathNode != null && dateNode != null)
                    {
                        saveBtn.Enabled = false;
                    }
                    else
                    {
                        saveBtn.Enabled = true;
                    }
                }
                else
                {
                    saveBtn.Enabled = true;
                }
            }
            else
            {
                savesBox.Items.Remove(selectedItem);
            }
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            openFile.Filter = "(*.exe)|*.exe";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                fileLocTxt.Text = openFile.FileName;
                consoleLog.Clear();
                consoleLog.AppendText("Opened file " + "'" + onlyFileName + "'");
                consoleLog.AppendText(Environment.NewLine);
            }
        }

        private void dskShrt_Click(object sender, EventArgs e)
        {
            object shDesktop = (object)"Desktop";
            WshShell shell = new WshShell();
            string shortcutAddress = (string)shell.SpecialFolders.Item(ref shDesktop) + @"\" + nameTxt.Text +".lnk";
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
            shortcut.Description = "Run Date Changer with parameters";
            shortcut.IconLocation = fileLocTxt.Text;
            shortcut.TargetPath = Application.ExecutablePath;
            shortcut.Arguments = " -\"" + fileLocTxt.Text + "\"" + " -" + dateTimePicker1.Value.Date.ToString("MM-dd-yyyy");
            shortcut.Save();

            consoleLog.AppendText("Desktop shortcut '" + nameTxt.Text + "' created");
            consoleLog.AppendText(Environment.NewLine);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            XmlDocument settXML = new XmlDocument();
            if (!System.IO.File.Exists("date-changer-settings-" + nameTxt.Text + ".xml"))
            {
                XmlDeclaration XMLdec = settXML.CreateXmlDeclaration("1.0", null, null);
                XmlComment XMLcommAuth = settXML.CreateComment("Author: DogFoxX");
                XmlComment XMLcommWarn = settXML.CreateComment("Editing this file may result in appliction failure. Use at own risk.");
                settXML.AppendChild(XMLdec);
                settXML.AppendChild(XMLcommAuth);
                settXML.AppendChild(XMLcommWarn);
                XmlElement XMLRoot = settXML.CreateElement("date-changer");
                settXML.AppendChild(XMLRoot);

                XmlElement setting = settXML.CreateElement("setting");
                XMLRoot.AppendChild(setting);                
                setting.SetAttribute("default", "");

                XmlElement name = settXML.CreateElement("name");
                setting.AppendChild(name);
                name.SetAttribute("content", nameTxt.Text);

                XmlElement path = settXML.CreateElement("path");
                setting.AppendChild(path);
                path.SetAttribute("content", fileLocTxt.Text);

                XmlElement date = settXML.CreateElement("date");
                setting.AppendChild(date);
                date.SetAttribute("content", dateTimePicker1.Value.Date.ToString("MM - dd - yyyy"));

                settXML.Save("date-changer-settings-" + nameTxt.Text + ".xml");
                consoleLog.AppendText("Saved " + "'" + nameTxt.Text + "'");
                consoleLog.AppendText(Environment.NewLine);

                savesBox.Items.Add(nameTxt.Text);
                saveBtn.Enabled = false;
                deleteBtn.Enabled = true;
                savesBox.SelectedItem = nameTxt.Text;
            }
            else
            {
                settXML.Load("date-changer-settings-" + nameTxt.Text + ".xml");

                string xPath = "date-changer/setting/path[@content='{0}']";
                string pathAttr = fileLocTxt.Text;

                string xDate = "date-changer/setting/date[@content='{0}']";
                string dateAttr = dateTimePicker1.Value.Date.ToString("MM - dd - yyyy");

                xPath = String.Format(xPath, pathAttr);
                XmlNode pathNode = settXML.SelectSingleNode(xPath);

                xDate = String.Format(xDate, dateAttr);
                XmlNode dateNode = settXML.SelectSingleNode(xDate);

                if (pathNode == null)
                {
                    OverWriteForm overWriteForm = new OverWriteForm();
                    if (overWriteForm.ShowDialog() == DialogResult.Yes)
                    {
                        XmlNode newPath = settXML.SelectSingleNode("date-changer/setting/path");
                        newPath.Attributes["content"].Value = fileLocTxt.Text;
                        settXML.Save("date-changer-settings-" + nameTxt.Text + ".xml");
                        consoleLog.AppendText("Saved " + "'" + nameTxt.Text + "'");
                        consoleLog.AppendText(Environment.NewLine);
                        saveBtn.Enabled = false;
                        savesBox.SelectedItem = nameTxt.Text;
                    }
                    else
                    {
                        saveBtn.Enabled = true;
                    }
                }
                else if (dateNode == null)
                {
                    OverWriteForm overWriteForm = new OverWriteForm();
                    if (overWriteForm.ShowDialog() == DialogResult.Yes)
                    {
                        XmlNode newDate = settXML.SelectSingleNode("date-changer/setting/date");
                        newDate.Attributes["content"].Value = dateTimePicker1.Value.Date.ToString("MM - dd - yyyy");
                        settXML.Save("date-changer-settings-" + nameTxt.Text + ".xml");
                        consoleLog.AppendText("Saved " + "'" + nameTxt.Text + "'");
                        consoleLog.AppendText(Environment.NewLine);
                        saveBtn.Enabled = false;
                        savesBox.SelectedItem = nameTxt.Text;
                    }
                    else
                    {
                        saveBtn.Enabled = true;
                    }
                }
            }
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (filePath != "" && onlyFileName != "")
            {
                string dateChange = dateTimePicker1.Value.ToString("MMMM dd yyyy");
                if (System.IO.File.Exists(filePath))
                {
                    if (dateTimePicker1.Value.Date != DateTime.Today)
                    {
                        TimeSpan currentSystemTime = DateTime.Now.TimeOfDay;
                        DateTime newDate = dateTimePicker1.Value.Date;
                        DateTime newDateTime = newDate.Add(currentSystemTime);

                        SYSTEMTIME newSystemTime = new SYSTEMTIME(newDateTime);
                        SetSystemTime(ref newSystemTime);

                        consoleLog.AppendText("Date changed to: " + dateChange);
                        consoleLog.AppendText(Environment.NewLine);

                    }
                    else
                    {
                        consoleLog.AppendText("Date was not changed");
                        consoleLog.AppendText(Environment.NewLine);
                    }
                    consoleLog.AppendText("Launching '" + onlyFileName + "'");
                    consoleLog.AppendText(Environment.NewLine);
                    dotsBar.StartWaiting();

                    startProc.StartInfo.FileName = filePath;
                    startProc.Start();
                }
            }
        }

        private void clearLogBtn_Click(object sender, EventArgs e)
        {
            if (filePath != "")
            {
                if (System.IO.File.Exists(filePath))
                {
                    consoleLog.Clear();
                    consoleLog.AppendText("Opened file " + "'" + onlyFileName + "'");
                    consoleLog.AppendText(Environment.NewLine);
                }
            }
            else
            {
                consoleLog.Clear();
                consoleLog.AppendText("Open a file to excecute");
                consoleLog.AppendText(Environment.NewLine);
            }
        }

        private void copyLog_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();    //Clear if any old value is there in Clipboard        
            Clipboard.SetText(consoleLog.Text); //Copy text to Clipboard
        }
        #endregion

        #region Started Process Exit Handle
        private void startProc_Exited(object sender, EventArgs e)
        {
            dotsBar.StopWaiting();
            dotsBar.ResetWaiting();

            consoleLog.AppendText("'" + onlyFileName +"' exited");
            consoleLog.AppendText(Environment.NewLine);

            if (resetDate.Checked)
            {
                if (dateTimePicker1.Value.Date != DateTime.Now)
                {
                    Process proc = new Process();
                    proc.StartInfo.FileName = "w32tm";
                    proc.StartInfo.Arguments = "/resync";
                    proc.StartInfo.UseShellExecute = false;
                    proc.StartInfo.RedirectStandardOutput = true;
                    proc.StartInfo.CreateNoWindow = true;
                    proc.OutputDataReceived += proc_OutputDataReceived;
                    proc.Start();
                    proc.BeginOutputReadLine();
                }
            }
        }
        #endregion

        #region CMD Output Handle
        void proc_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            Trace.WriteLine(e.Data);
            BeginInvoke(new MethodInvoker(() =>
            {
                consoleLog.AppendText(e.Data + "\r\n" ?? string.Empty);
            }));

            dateTimePicker1.BeginInvoke((MethodInvoker)delegate () { dateTimePicker1.Value = DateTime.Today; });
            

        }
        #endregion

        #region Mouse and Keyboard Down Handles
        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = null;
            }
        }

        private void programPnl_MouseDown(object sender, MouseEventArgs e)
        {
            this.ActiveControl = null;
        }

        private void consolePnl_MouseDown(object sender, MouseEventArgs e)
        {
            this.ActiveControl = null;
        }

        private void consoleLbl_MouseDown(object sender, MouseEventArgs e)
        {
            this.ActiveControl = null;
        }

        private void nameTxt_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[^?:\\/:*?\""<>|]"))
            {
                e.Handled = true;
                ToolTip tt = new ToolTip();
                tt.Show("A file name can't cotain any of the following characters:" + Environment.NewLine + "\\/:*?\"<>|", nameTxt, 0, 24, 5000);
            }
        }
        #endregion

        #region Text Changed Handles
        private void nameTxt_TextChanged(object sender, EventArgs e)
        {
            if (System.IO.File.Exists("date-changer-settings-" + nameTxt.Text + ".xml"))
            {
                XmlDocument settXML = new XmlDocument();
                settXML.Load("date-changer-settings-" + nameTxt.Text + ".xml");

                string xPath = "date-changer/setting/path[@content='{0}']";
                string pathAttr = fileLocTxt.Text;

                xPath = String.Format(xPath, pathAttr);
                XmlNode pathNode = settXML.SelectSingleNode(xPath);

                string xDate = "date-changer/setting/date[@content='{0}']";
                string dateAttr = dateTimePicker1.Value.Date.ToString("MM - dd - yyyy");

                xDate = String.Format(xDate, dateAttr);
                XmlNode dateNode = settXML.SelectSingleNode(xDate);

                if (pathNode != null && dateNode != null)
                {
                    saveBtn.Enabled = false;
                }
                else
                {
                    saveBtn.Enabled = true;
                }
            }
            else
            {
                if (System.IO.File.Exists(filePath) && nameTxt.Text != "")
                {
                    saveBtn.Enabled = true;
                    dskShrt.Enabled = true;
                }
                else
                {
                    saveBtn.Enabled = false;
                    dskShrt.Enabled = false;
                }
            }
        }

        private void fileLocTxt_TextChanged(object sender, EventArgs e)
        {
            if (filePath != "" && fileLocTxt.Text != "")
            {
                if (System.IO.File.Exists(filePath))
                {
                    consoleLog.Clear();
                    consoleLog.AppendText("Opened file " + "'" + onlyFileName + "'");
                    consoleLog.AppendText(Environment.NewLine);
                    startBtn.Enabled = true;
                    startBtn.BackColor = Color.SeaGreen;
                    if (nameTxt.Text != "")
                    {
                        saveBtn.Enabled = true;
                        dskShrt.Enabled = true;
                    }
                    else
                    {
                        saveBtn.Enabled = false;
                        dskShrt.Enabled = false;
                    }
                }
                else
                {
                    consoleLog.Clear();
                    consoleLog.AppendText("Open a file to excecute");
                    consoleLog.AppendText(Environment.NewLine);
                    startBtn.Enabled = false;
                    startBtn.BackColor = Color.FromArgb(60, 60, 60);
                    saveBtn.Enabled = false;
                    dskShrt.Enabled = false;
                }
            }
            else
            {
                consoleLog.Clear();
                consoleLog.AppendText("Open a file to excecute");
                consoleLog.AppendText(Environment.NewLine);
                startBtn.Enabled = false;
                startBtn.BackColor = Color.FromArgb(60, 60, 60);
                saveBtn.Enabled = false;
                dskShrt.Enabled = false;
            }

            if (System.IO.File.Exists("date-changer-settings-" + nameTxt.Text + ".xml"))
            {
                XmlDocument settXML = new XmlDocument();
                settXML.Load("date-changer-settings-" + nameTxt.Text + ".xml");

                string xPath = "date-changer/setting/path[@content='{0}']";
                string pathAttr = fileLocTxt.Text;

                xPath = String.Format(xPath, pathAttr);
                XmlNode pathNode = settXML.SelectSingleNode(xPath);

                string xDate = "date-changer/setting/date[@content='{0}']";
                string dateAttr = dateTimePicker1.Value.Date.ToString("MM - dd - yyyy");

                xDate = String.Format(xDate, dateAttr);
                XmlNode dateNode = settXML.SelectSingleNode(xDate);

                if (pathNode != null && dateNode != null)
                {
                    saveBtn.Enabled = false;
                }
                else
                {
                    if (System.IO.File.Exists(filePath))
                    {
                        saveBtn.Enabled = true;
                    }
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value.Date == DateTime.Today)
            {
                resetDate.Enabled = false;
            }
            else
            {
                resetDate.Enabled = true;
            }
            if (System.IO.File.Exists("date-changer-settings-" + nameTxt.Text + ".xml"))
            {
                XmlDocument settXML = new XmlDocument();
                settXML.Load("date-changer-settings-" + nameTxt.Text + ".xml");

                string xPath = "date-changer/setting/path[@content='{0}']";
                string pathAttr = fileLocTxt.Text;

                xPath = String.Format(xPath, pathAttr);
                XmlNode pathNode = settXML.SelectSingleNode(xPath);

                string xDate = "date-changer/setting/date[@content='{0}']";
                string dateAttr = dateTimePicker1.Value.Date.ToString("MM - dd - yyyy");

                xDate = String.Format(xDate, dateAttr);
                XmlNode dateNode = settXML.SelectSingleNode(xDate);

                if (dateNode != null && pathNode != null)
                {
                    saveBtn.Enabled = false;
                }
                else
                {
                    saveBtn.Enabled = true;
                }
            }
        }

        private void savesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = savesBox.SelectedItem.ToString();

            if (System.IO.File.Exists("date-changer-settings-" + selectedItem + ".xml"))
            {
                deleteBtn.Enabled = true;
                defaultBtn.Enabled = true;

                XmlDocument settXML = new XmlDocument();
                settXML.Load("date-changer-settings-" + selectedItem + ".xml");

                string xSett = "date-changer/setting[@default='{0}']";
                string settAttr = "true";

                xSett = String.Format(xSett, settAttr);
                XmlNode settNode = settXML.SelectSingleNode(xSett);

                XmlNode nameNode = settXML.SelectSingleNode("date-changer/setting/name");

                XmlNode pathNode = settXML.SelectSingleNode("date-changer/setting/path");

                XmlNode dateNode = settXML.SelectSingleNode("date-changer/setting/date");

                if (nameNode != null)
                {
                    if (settNode != null)
                    {
                        defaultBtn.Enabled = false;
                    }
                    else
                    {
                        defaultBtn.Enabled = true;
                    }
                    nameTxt.Text = nameNode.Attributes["content"].Value;
                    fileLocTxt.Text = pathNode.Attributes["content"].Value;
                    dateTimePicker1.Value = DateTime.ParseExact(dateNode.Attributes["content"].Value, "MM - dd - yyyy", CultureInfo.InvariantCulture);
                }
            }
            else
            {
                consoleLog.AppendText("Save file not found");
                consoleLog.AppendText(Environment.NewLine);
            }
        }
        #endregion
    }
}
