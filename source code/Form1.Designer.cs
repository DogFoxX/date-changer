
using System.Windows.Forms;

namespace date_changer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.titlePnl = new System.Windows.Forms.Panel();
            this.titleLbl = new System.Windows.Forms.Label();
            this.helpBtn = new System.Windows.Forms.Button();
            this.minBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.browseLbl = new System.Windows.Forms.Label();
            this.fileLocTxt = new System.Windows.Forms.TextBox();
            this.browseBtn = new System.Windows.Forms.Button();
            this.programPnl = new System.Windows.Forms.Panel();
            this.resetDate = new System.Windows.Forms.CheckBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.savesLbl = new System.Windows.Forms.Label();
            this.savesBox = new System.Windows.Forms.ComboBox();
            this.defaultBtn = new System.Windows.Forms.Button();
            this.dateLbl = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.nameLbl = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.dskShrt = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.clearLogBtn = new System.Windows.Forms.Button();
            this.consolePnl = new System.Windows.Forms.Panel();
            this.copyLog = new System.Windows.Forms.Button();
            this.dotsBar = new Telerik.WinControls.UI.RadWaitingBar();
            this.dotsBarElement = new Telerik.WinControls.UI.DotsLineWaitingBarIndicatorElement();
            this.consoleLog = new System.Windows.Forms.RichTextBox();
            this.consoleLbl = new System.Windows.Forms.Label();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.object_16797f3c_8ded_4565_9427_d28a4f92c858 = new Telerik.WinControls.UI.WaitingBarSeparatorElement();
            this.startProc = new System.Diagnostics.Process();
            this.object_2b55040f_5dad_4e97_b00f_34fd81391452 = new Telerik.WinControls.UI.RadWaitingBarElement();
            this.titlePnl.SuspendLayout();
            this.programPnl.SuspendLayout();
            this.consolePnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dotsBar)).BeginInit();
            this.SuspendLayout();
            // 
            // titlePnl
            // 
            this.titlePnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.titlePnl.Controls.Add(this.titleLbl);
            this.titlePnl.Controls.Add(this.helpBtn);
            this.titlePnl.Controls.Add(this.minBtn);
            this.titlePnl.Controls.Add(this.closeBtn);
            this.titlePnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePnl.Location = new System.Drawing.Point(0, 0);
            this.titlePnl.Name = "titlePnl";
            this.titlePnl.Size = new System.Drawing.Size(449, 28);
            this.titlePnl.TabIndex = 0;
            this.titlePnl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titlePnl_MouseDown);
            this.titlePnl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titlePnl_MouseMove);
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.Color.White;
            this.titleLbl.Location = new System.Drawing.Point(0, 6);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(83, 15);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Date Changer";
            this.titleLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleLbl_MouseDown);
            this.titleLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titleLbl_MouseMove);
            // 
            // helpBtn
            // 
            this.helpBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.helpBtn.FlatAppearance.BorderSize = 0;
            this.helpBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.helpBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.helpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpBtn.ForeColor = System.Drawing.Color.White;
            this.helpBtn.Location = new System.Drawing.Point(344, 0);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(35, 28);
            this.helpBtn.TabIndex = 1;
            this.helpBtn.Text = "?";
            this.helpBtn.UseVisualStyleBackColor = true;
            this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
            // 
            // minBtn
            // 
            this.minBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.minBtn.FlatAppearance.BorderSize = 0;
            this.minBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.minBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.minBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minBtn.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minBtn.ForeColor = System.Drawing.Color.White;
            this.minBtn.Location = new System.Drawing.Point(379, 0);
            this.minBtn.Name = "minBtn";
            this.minBtn.Size = new System.Drawing.Size(35, 28);
            this.minBtn.TabIndex = 0;
            this.minBtn.TabStop = false;
            this.minBtn.Text = "➖";
            this.minBtn.UseVisualStyleBackColor = true;
            this.minBtn.Click += new System.EventHandler(this.minBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(106)))), ((int)(((byte)(117)))));
            this.closeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(414, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(35, 28);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.TabStop = false;
            this.closeBtn.Text = "✕";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // browseLbl
            // 
            this.browseLbl.AutoSize = true;
            this.browseLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseLbl.ForeColor = System.Drawing.Color.White;
            this.browseLbl.Location = new System.Drawing.Point(9, 57);
            this.browseLbl.Name = "browseLbl";
            this.browseLbl.Size = new System.Drawing.Size(84, 16);
            this.browseLbl.TabIndex = 0;
            this.browseLbl.Text = "File Location";
            // 
            // fileLocTxt
            // 
            this.fileLocTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileLocTxt.BackColor = System.Drawing.Color.White;
            this.fileLocTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileLocTxt.Location = new System.Drawing.Point(12, 76);
            this.fileLocTxt.MaxLength = 0;
            this.fileLocTxt.Name = "fileLocTxt";
            this.fileLocTxt.Size = new System.Drawing.Size(425, 22);
            this.fileLocTxt.TabIndex = 5;
            this.fileLocTxt.TextChanged += new System.EventHandler(this.fileLocTxt_TextChanged);
            // 
            // browseBtn
            // 
            this.browseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.browseBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.browseBtn.FlatAppearance.BorderSize = 0;
            this.browseBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.browseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.browseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseBtn.Font = new System.Drawing.Font("Calibri", 10F);
            this.browseBtn.ForeColor = System.Drawing.Color.White;
            this.browseBtn.Location = new System.Drawing.Point(352, 106);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(85, 25);
            this.browseBtn.TabIndex = 6;
            this.browseBtn.Text = "Browse";
            this.browseBtn.UseVisualStyleBackColor = false;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // programPnl
            // 
            this.programPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.programPnl.Controls.Add(this.resetDate);
            this.programPnl.Controls.Add(this.deleteBtn);
            this.programPnl.Controls.Add(this.savesLbl);
            this.programPnl.Controls.Add(this.savesBox);
            this.programPnl.Controls.Add(this.defaultBtn);
            this.programPnl.Controls.Add(this.browseLbl);
            this.programPnl.Controls.Add(this.fileLocTxt);
            this.programPnl.Controls.Add(this.browseBtn);
            this.programPnl.Controls.Add(this.dateLbl);
            this.programPnl.Controls.Add(this.dateTimePicker1);
            this.programPnl.Controls.Add(this.nameLbl);
            this.programPnl.Controls.Add(this.nameTxt);
            this.programPnl.Controls.Add(this.saveBtn);
            this.programPnl.Controls.Add(this.dskShrt);
            this.programPnl.Controls.Add(this.startBtn);
            this.programPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.programPnl.Location = new System.Drawing.Point(0, 28);
            this.programPnl.Name = "programPnl";
            this.programPnl.Size = new System.Drawing.Size(449, 281);
            this.programPnl.TabIndex = 0;
            this.programPnl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.programPnl_MouseDown);
            // 
            // resetDate
            // 
            this.resetDate.AutoSize = true;
            this.resetDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.resetDate.ForeColor = System.Drawing.Color.White;
            this.resetDate.Location = new System.Drawing.Point(158, 157);
            this.resetDate.Name = "resetDate";
            this.resetDate.Size = new System.Drawing.Size(87, 20);
            this.resetDate.TabIndex = 8;
            this.resetDate.Text = "Auto reset";
            this.resetDate.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.deleteBtn.Enabled = false;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.deleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Calibri", 10F);
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(372, 27);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(65, 25);
            this.deleteBtn.TabIndex = 4;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // savesLbl
            // 
            this.savesLbl.AutoSize = true;
            this.savesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savesLbl.ForeColor = System.Drawing.Color.White;
            this.savesLbl.Location = new System.Drawing.Point(9, 8);
            this.savesLbl.Name = "savesLbl";
            this.savesLbl.Size = new System.Drawing.Size(90, 16);
            this.savesLbl.TabIndex = 11;
            this.savesLbl.Text = "Select a save";
            // 
            // savesBox
            // 
            this.savesBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.savesBox.BackColor = System.Drawing.Color.White;
            this.savesBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.savesBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.savesBox.FormattingEnabled = true;
            this.savesBox.Location = new System.Drawing.Point(12, 27);
            this.savesBox.Name = "savesBox";
            this.savesBox.Size = new System.Drawing.Size(283, 24);
            this.savesBox.TabIndex = 2;
            this.savesBox.SelectedIndexChanged += new System.EventHandler(this.savesBox_SelectedIndexChanged);
            // 
            // defaultBtn
            // 
            this.defaultBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.defaultBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.defaultBtn.Enabled = false;
            this.defaultBtn.FlatAppearance.BorderSize = 0;
            this.defaultBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.defaultBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.defaultBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.defaultBtn.Font = new System.Drawing.Font("Calibri", 10F);
            this.defaultBtn.ForeColor = System.Drawing.Color.White;
            this.defaultBtn.Location = new System.Drawing.Point(301, 27);
            this.defaultBtn.Name = "defaultBtn";
            this.defaultBtn.Size = new System.Drawing.Size(65, 25);
            this.defaultBtn.TabIndex = 3;
            this.defaultBtn.Text = "Default";
            this.defaultBtn.UseVisualStyleBackColor = false;
            this.defaultBtn.Click += new System.EventHandler(this.defaultBtn_Click);
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLbl.ForeColor = System.Drawing.Color.White;
            this.dateLbl.Location = new System.Drawing.Point(9, 137);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(213, 16);
            this.dateLbl.TabIndex = 0;
            this.dateLbl.Text = "Set preferred date (mm - dd - yyyy)";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.White;
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.CustomFormat = "MM - dd - yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 156);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(126, 22);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            this.dateTimePicker1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTimePicker1_KeyDown);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.ForeColor = System.Drawing.Color.White;
            this.nameLbl.Location = new System.Drawing.Point(9, 187);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(93, 16);
            this.nameLbl.TabIndex = 0;
            this.nameLbl.Text = "Friendly name";
            // 
            // nameTxt
            // 
            this.nameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTxt.BackColor = System.Drawing.Color.White;
            this.nameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxt.ForeColor = System.Drawing.Color.Black;
            this.nameTxt.Location = new System.Drawing.Point(12, 206);
            this.nameTxt.MaximumSize = new System.Drawing.Size(334, 22);
            this.nameTxt.MaxLength = 0;
            this.nameTxt.MinimumSize = new System.Drawing.Size(334, 22);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(334, 22);
            this.nameTxt.TabIndex = 9;
            this.nameTxt.TextChanged += new System.EventHandler(this.nameTxt_TextChanged);
            this.nameTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameTxt_KeyPress);
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.saveBtn.Enabled = false;
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.saveBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Calibri", 10F);
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(352, 205);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(85, 25);
            this.saveBtn.TabIndex = 10;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // dskShrt
            // 
            this.dskShrt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dskShrt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dskShrt.Enabled = false;
            this.dskShrt.FlatAppearance.BorderSize = 0;
            this.dskShrt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.dskShrt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.dskShrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dskShrt.Font = new System.Drawing.Font("Calibri", 10F);
            this.dskShrt.ForeColor = System.Drawing.Color.White;
            this.dskShrt.Location = new System.Drawing.Point(12, 245);
            this.dskShrt.Name = "dskShrt";
            this.dskShrt.Size = new System.Drawing.Size(120, 30);
            this.dskShrt.TabIndex = 11;
            this.dskShrt.Text = "Desktop Shortcut";
            this.dskShrt.UseVisualStyleBackColor = false;
            this.dskShrt.Click += new System.EventHandler(this.dskShrt_Click);
            // 
            // startBtn
            // 
            this.startBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.startBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.startBtn.FlatAppearance.BorderSize = 0;
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBtn.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.ForeColor = System.Drawing.Color.White;
            this.startBtn.Location = new System.Drawing.Point(138, 245);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(299, 30);
            this.startBtn.TabIndex = 12;
            this.startBtn.Text = "▶ Start";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // clearLogBtn
            // 
            this.clearLogBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearLogBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.clearLogBtn.FlatAppearance.BorderSize = 0;
            this.clearLogBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.clearLogBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.clearLogBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearLogBtn.Font = new System.Drawing.Font("Calibri", 10F);
            this.clearLogBtn.ForeColor = System.Drawing.Color.White;
            this.clearLogBtn.Location = new System.Drawing.Point(352, 324);
            this.clearLogBtn.Name = "clearLogBtn";
            this.clearLogBtn.Size = new System.Drawing.Size(85, 25);
            this.clearLogBtn.TabIndex = 14;
            this.clearLogBtn.Text = "Clear Log";
            this.clearLogBtn.UseVisualStyleBackColor = false;
            this.clearLogBtn.Click += new System.EventHandler(this.clearLogBtn_Click);
            // 
            // consolePnl
            // 
            this.consolePnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.consolePnl.Controls.Add(this.copyLog);
            this.consolePnl.Controls.Add(this.dotsBar);
            this.consolePnl.Controls.Add(this.consoleLog);
            this.consolePnl.Controls.Add(this.consoleLbl);
            this.consolePnl.Controls.Add(this.clearLogBtn);
            this.consolePnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consolePnl.Location = new System.Drawing.Point(0, 309);
            this.consolePnl.Name = "consolePnl";
            this.consolePnl.Size = new System.Drawing.Size(449, 355);
            this.consolePnl.TabIndex = 0;
            this.consolePnl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.consolePnl_MouseDown);
            // 
            // copyLog
            // 
            this.copyLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.copyLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.copyLog.FlatAppearance.BorderSize = 0;
            this.copyLog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.copyLog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.copyLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyLog.Font = new System.Drawing.Font("Calibri", 10F);
            this.copyLog.ForeColor = System.Drawing.Color.White;
            this.copyLog.Location = new System.Drawing.Point(261, 324);
            this.copyLog.Name = "copyLog";
            this.copyLog.Size = new System.Drawing.Size(85, 25);
            this.copyLog.TabIndex = 13;
            this.copyLog.Text = "Copy Log";
            this.copyLog.UseVisualStyleBackColor = false;
            this.copyLog.Click += new System.EventHandler(this.copyLog_Click);
            // 
            // dotsBar
            // 
            this.dotsBar.Location = new System.Drawing.Point(0, 325);
            this.dotsBar.Name = "dotsBar";
            this.dotsBar.Size = new System.Drawing.Size(205, 24);
            this.dotsBar.TabIndex = 0;
            this.dotsBar.TabStop = false;
            this.dotsBar.Text = "radWaitingBar1";
            this.dotsBar.WaitingIndicators.Add(this.dotsBarElement);
            this.dotsBar.WaitingSpeed = 100;
            this.dotsBar.WaitingStyle = Telerik.WinControls.Enumerations.WaitingBarStyles.DotsLine;
            // 
            // dotsBarElement
            // 
            this.dotsBarElement.AccelerationSpeed = 5D;
            this.dotsBarElement.ElementColor = System.Drawing.Color.White;
            this.dotsBarElement.Name = "dotsBarElement";
            // 
            // consoleLog
            // 
            this.consoleLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.consoleLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.consoleLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.consoleLog.ForeColor = System.Drawing.Color.White;
            this.consoleLog.Location = new System.Drawing.Point(3, 20);
            this.consoleLog.Name = "consoleLog";
            this.consoleLog.ReadOnly = true;
            this.consoleLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.consoleLog.Size = new System.Drawing.Size(443, 298);
            this.consoleLog.TabIndex = 0;
            this.consoleLog.TabStop = false;
            this.consoleLog.Text = "";
            // 
            // consoleLbl
            // 
            this.consoleLbl.AutoSize = true;
            this.consoleLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.consoleLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.consoleLbl.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consoleLbl.ForeColor = System.Drawing.Color.Gray;
            this.consoleLbl.Location = new System.Drawing.Point(0, 0);
            this.consoleLbl.MaximumSize = new System.Drawing.Size(72, 20);
            this.consoleLbl.MinimumSize = new System.Drawing.Size(72, 20);
            this.consoleLbl.Name = "consoleLbl";
            this.consoleLbl.Size = new System.Drawing.Size(72, 20);
            this.consoleLbl.TabIndex = 0;
            this.consoleLbl.Text = "Console Log";
            this.consoleLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.consoleLbl_MouseDown);
            // 
            // object_16797f3c_8ded_4565_9427_d28a4f92c858
            // 
            this.object_16797f3c_8ded_4565_9427_d28a4f92c858.Dash = false;
            this.object_16797f3c_8ded_4565_9427_d28a4f92c858.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.object_16797f3c_8ded_4565_9427_d28a4f92c858.Name = "object_16797f3c_8ded_4565_9427_d28a4f92c858";
            this.object_16797f3c_8ded_4565_9427_d28a4f92c858.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // startProc
            // 
            this.startProc.EnableRaisingEvents = true;
            this.startProc.StartInfo.Domain = "";
            this.startProc.StartInfo.LoadUserProfile = false;
            this.startProc.StartInfo.Password = null;
            this.startProc.StartInfo.StandardErrorEncoding = null;
            this.startProc.StartInfo.StandardOutputEncoding = null;
            this.startProc.StartInfo.UserName = "";
            this.startProc.SynchronizingObject = this;
            this.startProc.Exited += new System.EventHandler(this.startProc_Exited);
            // 
            // object_2b55040f_5dad_4e97_b00f_34fd81391452
            // 
            this.object_2b55040f_5dad_4e97_b00f_34fd81391452.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.object_2b55040f_5dad_4e97_b00f_34fd81391452.Name = "object_2b55040f_5dad_4e97_b00f_34fd81391452";
            this.object_2b55040f_5dad_4e97_b00f_34fd81391452.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.object_2b55040f_5dad_4e97_b00f_34fd81391452.WaitingSpeed = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(449, 664);
            this.Controls.Add(this.consolePnl);
            this.Controls.Add(this.programPnl);
            this.Controls.Add(this.titlePnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Date Changer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.titlePnl.ResumeLayout(false);
            this.titlePnl.PerformLayout();
            this.programPnl.ResumeLayout(false);
            this.programPnl.PerformLayout();
            this.consolePnl.ResumeLayout(false);
            this.consolePnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dotsBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titlePnl;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.TextBox fileLocTxt;
        private System.Windows.Forms.Label browseLbl;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Panel programPnl;
        private System.Windows.Forms.Button minBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Panel consolePnl;
        private System.Windows.Forms.Label consoleLbl;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.Button dskShrt;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button helpBtn;
        private Button clearLogBtn;
        private OpenFileDialog openFile;
        private Button defaultBtn;
        private Label nameLbl;
        private TextBox nameTxt;
        private ComboBox savesBox;
        private Telerik.WinControls.UI.WaitingBarSeparatorElement object_16797f3c_8ded_4565_9427_d28a4f92c858;
        private System.Diagnostics.Process startProc;
        private Label savesLbl;
        private Button deleteBtn;
        private CheckBox resetDate;
        private Telerik.WinControls.UI.RadWaitingBarElement object_2b55040f_5dad_4e97_b00f_34fd81391452;
        private RichTextBox consoleLog;
        private Telerik.WinControls.UI.RadWaitingBar dotsBar;
        private Telerik.WinControls.UI.DotsLineWaitingBarIndicatorElement dotsBarElement;
        private Button copyLog;
    }
}

