namespace MessageServiceClientApp
{
    partial class ClientGui
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSend = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSend = new System.Windows.Forms.Button();
            this.gbxSndMessage = new System.Windows.Forms.GroupBox();
            this.txtSndMessage = new System.Windows.Forms.TextBox();
            this.gbxSndRecipients = new System.Windows.Forms.GroupBox();
            this.clbSndRecipients = new System.Windows.Forms.CheckedListBox();
            this.gbxInfo = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSndDateText = new System.Windows.Forms.Label();
            this.lblSndDate = new System.Windows.Forms.Label();
            this.txtSndEmail = new System.Windows.Forms.TextBox();
            this.lblSndEmail = new System.Windows.Forms.Label();
            this.lblSndPhone = new System.Windows.Forms.Label();
            this.txtSndPhone = new System.Windows.Forms.TextBox();
            this.txtSndAddress = new System.Windows.Forms.TextBox();
            this.lblSndAddress = new System.Windows.Forms.Label();
            this.lblSndName = new System.Windows.Forms.Label();
            this.txtSndName = new System.Windows.Forms.TextBox();
            this.tabReceive = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbShowSelect = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.chkRead = new System.Windows.Forms.CheckBox();
            this.gbxRecMessage = new System.Windows.Forms.GroupBox();
            this.txtRecMessage = new System.Windows.Forms.TextBox();
            this.gbxRecRecipients = new System.Windows.Forms.GroupBox();
            this.clbRecRecipients = new System.Windows.Forms.CheckedListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblRecDateText = new System.Windows.Forms.Label();
            this.lblRecDate = new System.Windows.Forms.Label();
            this.lblRecName = new System.Windows.Forms.Label();
            this.txtRecEmail = new System.Windows.Forms.TextBox();
            this.txtRecName = new System.Windows.Forms.TextBox();
            this.lblRecEmail = new System.Windows.Forms.Label();
            this.txtRecPhone = new System.Windows.Forms.TextBox();
            this.lblRecAddress = new System.Windows.Forms.Label();
            this.txtRecAddress = new System.Windows.Forms.TextBox();
            this.lblRecPhone = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGetNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGetAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGetDeleted = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1.SuspendLayout();
            this.tabSend.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbxSndMessage.SuspendLayout();
            this.gbxSndRecipients.SuspendLayout();
            this.gbxInfo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabReceive.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbxRecMessage.SuspendLayout();
            this.gbxRecRecipients.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSend);
            this.tabControl1.Controls.Add(this.tabReceive);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(631, 532);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabSend
            // 
            this.tabSend.Controls.Add(this.panel1);
            this.tabSend.Controls.Add(this.gbxSndMessage);
            this.tabSend.Controls.Add(this.gbxSndRecipients);
            this.tabSend.Controls.Add(this.gbxInfo);
            this.tabSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSend.Location = new System.Drawing.Point(4, 25);
            this.tabSend.Name = "tabSend";
            this.tabSend.Padding = new System.Windows.Forms.Padding(3);
            this.tabSend.Size = new System.Drawing.Size(623, 503);
            this.tabSend.TabIndex = 0;
            this.tabSend.Text = "Send";
            this.tabSend.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.btnSend);
            this.panel1.Location = new System.Drawing.Point(9, 453);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 45);
            this.panel1.TabIndex = 5;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(17, 7);
            this.btnSend.Margin = new System.Windows.Forms.Padding(0);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 32);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // gbxSndMessage
            // 
            this.gbxSndMessage.Controls.Add(this.txtSndMessage);
            this.gbxSndMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSndMessage.Location = new System.Drawing.Point(6, 219);
            this.gbxSndMessage.Name = "gbxSndMessage";
            this.gbxSndMessage.Size = new System.Drawing.Size(400, 231);
            this.gbxSndMessage.TabIndex = 4;
            this.gbxSndMessage.TabStop = false;
            this.gbxSndMessage.Text = "Message";
            // 
            // txtSndMessage
            // 
            this.txtSndMessage.BackColor = System.Drawing.SystemColors.Window;
            this.txtSndMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSndMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSndMessage.Location = new System.Drawing.Point(3, 16);
            this.txtSndMessage.Multiline = true;
            this.txtSndMessage.Name = "txtSndMessage";
            this.txtSndMessage.Size = new System.Drawing.Size(394, 212);
            this.txtSndMessage.TabIndex = 0;
            // 
            // gbxSndRecipients
            // 
            this.gbxSndRecipients.Controls.Add(this.clbSndRecipients);
            this.gbxSndRecipients.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSndRecipients.Location = new System.Drawing.Point(411, 3);
            this.gbxSndRecipients.Name = "gbxSndRecipients";
            this.gbxSndRecipients.Size = new System.Drawing.Size(209, 447);
            this.gbxSndRecipients.TabIndex = 3;
            this.gbxSndRecipients.TabStop = false;
            this.gbxSndRecipients.Text = "Recipient(s)";
            // 
            // clbSndRecipients
            // 
            this.clbSndRecipients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbSndRecipients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbSndRecipients.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbSndRecipients.FormattingEnabled = true;
            this.clbSndRecipients.Location = new System.Drawing.Point(3, 16);
            this.clbSndRecipients.Name = "clbSndRecipients";
            this.clbSndRecipients.Size = new System.Drawing.Size(203, 428);
            this.clbSndRecipients.TabIndex = 0;
            // 
            // gbxInfo
            // 
            this.gbxInfo.Controls.Add(this.tableLayoutPanel1);
            this.gbxInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxInfo.Location = new System.Drawing.Point(6, 3);
            this.gbxInfo.Margin = new System.Windows.Forms.Padding(0);
            this.gbxInfo.Name = "gbxInfo";
            this.gbxInfo.Padding = new System.Windows.Forms.Padding(0);
            this.gbxInfo.Size = new System.Drawing.Size(400, 210);
            this.gbxInfo.TabIndex = 1;
            this.gbxInfo.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblSndDateText, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSndDate, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtSndEmail, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblSndEmail, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblSndPhone, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtSndPhone, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtSndAddress, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblSndAddress, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblSndName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtSndName, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 14);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(400, 196);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // lblSndDateText
            // 
            this.lblSndDateText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSndDateText.AutoSize = true;
            this.lblSndDateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSndDateText.Location = new System.Drawing.Point(71, 11);
            this.lblSndDateText.Name = "lblSndDateText";
            this.lblSndDateText.Size = new System.Drawing.Size(326, 17);
            this.lblSndDateText.TabIndex = 5;
            this.lblSndDateText.Text = "Date:";
            // 
            // lblSndDate
            // 
            this.lblSndDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSndDate.AutoSize = true;
            this.lblSndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSndDate.Location = new System.Drawing.Point(25, 11);
            this.lblSndDate.Name = "lblSndDate";
            this.lblSndDate.Size = new System.Drawing.Size(40, 16);
            this.lblSndDate.TabIndex = 4;
            this.lblSndDate.Text = "Date:";
            // 
            // txtSndEmail
            // 
            this.txtSndEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSndEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSndEmail.Location = new System.Drawing.Point(71, 164);
            this.txtSndEmail.Name = "txtSndEmail";
            this.txtSndEmail.Size = new System.Drawing.Size(326, 23);
            this.txtSndEmail.TabIndex = 3;
            // 
            // lblSndEmail
            // 
            this.lblSndEmail.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSndEmail.AutoSize = true;
            this.lblSndEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSndEmail.Location = new System.Drawing.Point(20, 168);
            this.lblSndEmail.Name = "lblSndEmail";
            this.lblSndEmail.Size = new System.Drawing.Size(45, 16);
            this.lblSndEmail.TabIndex = 3;
            this.lblSndEmail.Text = "Email:";
            // 
            // lblSndPhone
            // 
            this.lblSndPhone.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSndPhone.AutoSize = true;
            this.lblSndPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSndPhone.Location = new System.Drawing.Point(15, 128);
            this.lblSndPhone.Name = "lblSndPhone";
            this.lblSndPhone.Size = new System.Drawing.Size(50, 16);
            this.lblSndPhone.TabIndex = 2;
            this.lblSndPhone.Text = "Phone:";
            // 
            // txtSndPhone
            // 
            this.txtSndPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSndPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSndPhone.Location = new System.Drawing.Point(71, 125);
            this.txtSndPhone.Name = "txtSndPhone";
            this.txtSndPhone.Size = new System.Drawing.Size(326, 23);
            this.txtSndPhone.TabIndex = 2;
            // 
            // txtSndAddress
            // 
            this.txtSndAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSndAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSndAddress.Location = new System.Drawing.Point(71, 86);
            this.txtSndAddress.Name = "txtSndAddress";
            this.txtSndAddress.Size = new System.Drawing.Size(326, 23);
            this.txtSndAddress.TabIndex = 1;
            // 
            // lblSndAddress
            // 
            this.lblSndAddress.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSndAddress.AutoSize = true;
            this.lblSndAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSndAddress.Location = new System.Drawing.Point(3, 89);
            this.lblSndAddress.Name = "lblSndAddress";
            this.lblSndAddress.Size = new System.Drawing.Size(62, 16);
            this.lblSndAddress.TabIndex = 1;
            this.lblSndAddress.Text = "Address:";
            // 
            // lblSndName
            // 
            this.lblSndName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSndName.AutoSize = true;
            this.lblSndName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSndName.Location = new System.Drawing.Point(17, 50);
            this.lblSndName.Name = "lblSndName";
            this.lblSndName.Size = new System.Drawing.Size(48, 16);
            this.lblSndName.TabIndex = 0;
            this.lblSndName.Text = "Name:";
            // 
            // txtSndName
            // 
            this.txtSndName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSndName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSndName.Location = new System.Drawing.Point(71, 47);
            this.txtSndName.Name = "txtSndName";
            this.txtSndName.Size = new System.Drawing.Size(326, 23);
            this.txtSndName.TabIndex = 0;
            // 
            // tabReceive
            // 
            this.tabReceive.Controls.Add(this.panel2);
            this.tabReceive.Controls.Add(this.gbxRecMessage);
            this.tabReceive.Controls.Add(this.gbxRecRecipients);
            this.tabReceive.Controls.Add(this.groupBox3);
            this.tabReceive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabReceive.Location = new System.Drawing.Point(4, 25);
            this.tabReceive.Name = "tabReceive";
            this.tabReceive.Padding = new System.Windows.Forms.Padding(3);
            this.tabReceive.Size = new System.Drawing.Size(623, 503);
            this.tabReceive.TabIndex = 1;
            this.tabReceive.Text = "Receive (0)";
            this.tabReceive.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cmbShowSelect);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnNext);
            this.panel2.Controls.Add(this.btnPrev);
            this.panel2.Controls.Add(this.chkRead);
            this.panel2.Location = new System.Drawing.Point(9, 453);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(611, 45);
            this.panel2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(393, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Show: ";
            // 
            // cmbShowSelect
            // 
            this.cmbShowSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbShowSelect.FormattingEnabled = true;
            this.cmbShowSelect.Items.AddRange(new object[] {
            "All",
            "Deleted",
            "New",
            "Read",
            "Unread"});
            this.cmbShowSelect.Location = new System.Drawing.Point(453, 9);
            this.cmbShowSelect.Name = "cmbShowSelect";
            this.cmbShowSelect.Size = new System.Drawing.Size(121, 28);
            this.cmbShowSelect.Sorted = true;
            this.cmbShowSelect.TabIndex = 8;
            this.cmbShowSelect.SelectedIndexChanged += new System.EventHandler(this.cmbShowSelect_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(14, 9);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 28);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(171, 9);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(70, 28);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.Location = new System.Drawing.Point(95, 9);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(70, 28);
            this.btnPrev.TabIndex = 0;
            this.btnPrev.Text = "Prev";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // chkRead
            // 
            this.chkRead.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkRead.AutoSize = true;
            this.chkRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRead.Location = new System.Drawing.Point(268, 12);
            this.chkRead.Name = "chkRead";
            this.chkRead.Size = new System.Drawing.Size(62, 22);
            this.chkRead.TabIndex = 6;
            this.chkRead.Text = "Read";
            this.chkRead.UseVisualStyleBackColor = true;
            this.chkRead.Click += new System.EventHandler(this.chkRead_Click);
            // 
            // gbxRecMessage
            // 
            this.gbxRecMessage.Controls.Add(this.txtRecMessage);
            this.gbxRecMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxRecMessage.Location = new System.Drawing.Point(6, 219);
            this.gbxRecMessage.Name = "gbxRecMessage";
            this.gbxRecMessage.Size = new System.Drawing.Size(400, 231);
            this.gbxRecMessage.TabIndex = 8;
            this.gbxRecMessage.TabStop = false;
            this.gbxRecMessage.Text = "Message";
            // 
            // txtRecMessage
            // 
            this.txtRecMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRecMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecMessage.Location = new System.Drawing.Point(3, 16);
            this.txtRecMessage.Multiline = true;
            this.txtRecMessage.Name = "txtRecMessage";
            this.txtRecMessage.Size = new System.Drawing.Size(394, 212);
            this.txtRecMessage.TabIndex = 0;
            // 
            // gbxRecRecipients
            // 
            this.gbxRecRecipients.Controls.Add(this.clbRecRecipients);
            this.gbxRecRecipients.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxRecRecipients.Location = new System.Drawing.Point(411, 3);
            this.gbxRecRecipients.Name = "gbxRecRecipients";
            this.gbxRecRecipients.Size = new System.Drawing.Size(209, 447);
            this.gbxRecRecipients.TabIndex = 7;
            this.gbxRecRecipients.TabStop = false;
            this.gbxRecRecipients.Text = "Recipient(s)";
            // 
            // clbRecRecipients
            // 
            this.clbRecRecipients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbRecRecipients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbRecRecipients.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbRecRecipients.FormattingEnabled = true;
            this.clbRecRecipients.Location = new System.Drawing.Point(3, 16);
            this.clbRecRecipients.Name = "clbRecRecipients";
            this.clbRecRecipients.Size = new System.Drawing.Size(203, 428);
            this.clbRecRecipients.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(6, 3);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox3.Size = new System.Drawing.Size(400, 210);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.lblRecDateText, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblRecDate, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblRecName, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtRecEmail, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.txtRecName, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblRecEmail, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.txtRecPhone, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblRecAddress, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtRecAddress, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblRecPhone, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 14);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(400, 196);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // lblRecDateText
            // 
            this.lblRecDateText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRecDateText.AutoSize = true;
            this.lblRecDateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecDateText.Location = new System.Drawing.Point(71, 11);
            this.lblRecDateText.Name = "lblRecDateText";
            this.lblRecDateText.Size = new System.Drawing.Size(38, 17);
            this.lblRecDateText.TabIndex = 5;
            this.lblRecDateText.Text = "Date";
            // 
            // lblRecDate
            // 
            this.lblRecDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblRecDate.AutoSize = true;
            this.lblRecDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecDate.Location = new System.Drawing.Point(25, 11);
            this.lblRecDate.Name = "lblRecDate";
            this.lblRecDate.Size = new System.Drawing.Size(40, 16);
            this.lblRecDate.TabIndex = 4;
            this.lblRecDate.Text = "Date:";
            // 
            // lblRecName
            // 
            this.lblRecName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblRecName.AutoSize = true;
            this.lblRecName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecName.Location = new System.Drawing.Point(17, 50);
            this.lblRecName.Name = "lblRecName";
            this.lblRecName.Size = new System.Drawing.Size(48, 16);
            this.lblRecName.TabIndex = 0;
            this.lblRecName.Text = "Name:";
            // 
            // txtRecEmail
            // 
            this.txtRecEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.txtRecEmail, 2);
            this.txtRecEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecEmail.Location = new System.Drawing.Point(71, 164);
            this.txtRecEmail.Name = "txtRecEmail";
            this.txtRecEmail.Size = new System.Drawing.Size(326, 23);
            this.txtRecEmail.TabIndex = 3;
            // 
            // txtRecName
            // 
            this.txtRecName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.txtRecName, 2);
            this.txtRecName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecName.Location = new System.Drawing.Point(71, 47);
            this.txtRecName.Name = "txtRecName";
            this.txtRecName.Size = new System.Drawing.Size(326, 23);
            this.txtRecName.TabIndex = 0;
            // 
            // lblRecEmail
            // 
            this.lblRecEmail.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblRecEmail.AutoSize = true;
            this.lblRecEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecEmail.Location = new System.Drawing.Point(20, 168);
            this.lblRecEmail.Name = "lblRecEmail";
            this.lblRecEmail.Size = new System.Drawing.Size(45, 16);
            this.lblRecEmail.TabIndex = 3;
            this.lblRecEmail.Text = "Email:";
            // 
            // txtRecPhone
            // 
            this.txtRecPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.txtRecPhone, 2);
            this.txtRecPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecPhone.Location = new System.Drawing.Point(71, 125);
            this.txtRecPhone.Name = "txtRecPhone";
            this.txtRecPhone.Size = new System.Drawing.Size(326, 23);
            this.txtRecPhone.TabIndex = 2;
            // 
            // lblRecAddress
            // 
            this.lblRecAddress.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblRecAddress.AutoSize = true;
            this.lblRecAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecAddress.Location = new System.Drawing.Point(3, 89);
            this.lblRecAddress.Name = "lblRecAddress";
            this.lblRecAddress.Size = new System.Drawing.Size(62, 16);
            this.lblRecAddress.TabIndex = 1;
            this.lblRecAddress.Text = "Address:";
            // 
            // txtRecAddress
            // 
            this.txtRecAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.txtRecAddress, 2);
            this.txtRecAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecAddress.Location = new System.Drawing.Point(71, 86);
            this.txtRecAddress.Name = "txtRecAddress";
            this.txtRecAddress.Size = new System.Drawing.Size(326, 23);
            this.txtRecAddress.TabIndex = 1;
            // 
            // lblRecPhone
            // 
            this.lblRecPhone.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblRecPhone.AutoSize = true;
            this.lblRecPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecPhone.Location = new System.Drawing.Point(15, 128);
            this.lblRecPhone.Name = "lblRecPhone";
            this.lblRecPhone.Size = new System.Drawing.Size(50, 16);
            this.lblRecPhone.TabIndex = 2;
            this.lblRecPhone.Text = "Phone:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.messagesToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(631, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuConnect,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mnuConnect
            // 
            this.mnuConnect.Name = "mnuConnect";
            this.mnuConnect.Size = new System.Drawing.Size(119, 22);
            this.mnuConnect.Text = "Connect";
            this.mnuConnect.Click += new System.EventHandler(this.mnuConnect_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // messagesToolStripMenuItem
            // 
            this.messagesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGetNew,
            this.mnuGetAll,
            this.mnuGetDeleted});
            this.messagesToolStripMenuItem.Name = "messagesToolStripMenuItem";
            this.messagesToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.messagesToolStripMenuItem.Text = "Messages";
            // 
            // mnuGetNew
            // 
            this.mnuGetNew.Name = "mnuGetNew";
            this.mnuGetNew.Size = new System.Drawing.Size(135, 22);
            this.mnuGetNew.Text = "Get New";
            this.mnuGetNew.Click += new System.EventHandler(this.mnuGetNew_Click);
            // 
            // mnuGetAll
            // 
            this.mnuGetAll.Name = "mnuGetAll";
            this.mnuGetAll.Size = new System.Drawing.Size(135, 22);
            this.mnuGetAll.Text = "Get All";
            this.mnuGetAll.Click += new System.EventHandler(this.mnuGetAll_Click);
            // 
            // mnuGetDeleted
            // 
            this.mnuGetDeleted.Name = "mnuGetDeleted";
            this.mnuGetDeleted.Size = new System.Drawing.Size(135, 22);
            this.mnuGetDeleted.Text = "Get Deleted";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(631, 561);
            this.splitContainer1.SplitterDistance = 25;
            this.splitContainer1.TabIndex = 5;
            // 
            // ClientGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 561);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ClientGui";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Message Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientGui_FormClosing);
            this.Load += new System.EventHandler(this.ClientGui_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabSend.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.gbxSndMessage.ResumeLayout(false);
            this.gbxSndMessage.PerformLayout();
            this.gbxSndRecipients.ResumeLayout(false);
            this.gbxInfo.ResumeLayout(false);
            this.gbxInfo.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabReceive.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gbxRecMessage.ResumeLayout(false);
            this.gbxRecMessage.PerformLayout();
            this.gbxRecRecipients.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSend;
        private System.Windows.Forms.GroupBox gbxSndMessage;
        private System.Windows.Forms.TextBox txtSndMessage;
        private System.Windows.Forms.GroupBox gbxSndRecipients;
        private System.Windows.Forms.CheckedListBox clbSndRecipients;
        private System.Windows.Forms.GroupBox gbxInfo;
        private System.Windows.Forms.TextBox txtSndEmail;
        private System.Windows.Forms.TextBox txtSndPhone;
        private System.Windows.Forms.TextBox txtSndAddress;
        private System.Windows.Forms.TextBox txtSndName;
        private System.Windows.Forms.Label lblSndEmail;
        private System.Windows.Forms.Label lblSndPhone;
        private System.Windows.Forms.Label lblSndAddress;
        private System.Windows.Forms.Label lblSndName;
        private System.Windows.Forms.TabPage tabReceive;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.GroupBox gbxRecMessage;
        private System.Windows.Forms.TextBox txtRecMessage;
        private System.Windows.Forms.GroupBox gbxRecRecipients;
        private System.Windows.Forms.CheckedListBox clbRecRecipients;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtRecEmail;
        private System.Windows.Forms.TextBox txtRecPhone;
        private System.Windows.Forms.TextBox txtRecAddress;
        private System.Windows.Forms.TextBox txtRecName;
        private System.Windows.Forms.Label lblRecEmail;
        private System.Windows.Forms.Label lblRecPhone;
        private System.Windows.Forms.Label lblRecAddress;
        private System.Windows.Forms.Label lblRecName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblSndDateText;
        private System.Windows.Forms.Label lblSndDate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblRecDateText;
        private System.Windows.Forms.Label lblRecDate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuConnect;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem messagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuGetNew;
        private System.Windows.Forms.ToolStripMenuItem mnuGetAll;
        private System.Windows.Forms.ToolStripMenuItem mnuGetDeleted;
        private System.Windows.Forms.ComboBox cmbShowSelect;
        private System.Windows.Forms.CheckBox chkRead;
        private System.Windows.Forms.Label label1;
    }
}

