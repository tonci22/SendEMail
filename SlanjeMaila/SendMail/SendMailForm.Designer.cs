namespace SlanjeMaila
{
    partial class SendMailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendMailForm));
            this.unosPosiljatelja = new System.Windows.Forms.TextBox();
            this.unosPrimatelja = new System.Windows.Forms.TextBox();
            this.lblsendto = new System.Windows.Forms.Label();
            this.lbltvojemail = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.unosSubject = new System.Windows.Forms.TextBox();
            this.lblPoruka = new System.Windows.Forms.Label();
            this.unosPoruke = new System.Windows.Forms.RichTextBox();
            this.btnPosalji = new System.Windows.Forms.Button();
            this.lblSifra = new System.Windows.Forms.Label();
            this.unosSifra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MainToolBox = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.newMailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DefaultMail = new System.Windows.Forms.ToolStripMenuItem();
            this.HotmailCom = new System.Windows.Forms.ToolStripMenuItem();
            this.AnteMilinaHotmailComMail = new System.Windows.Forms.ToolStripMenuItem();
            this.gmailcomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jebemuboga123gmailcomMail = new System.Windows.Forms.ToolStripMenuItem();
            this.temp2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.antmilinafoihrSendTo = new System.Windows.Forms.ToolStripMenuItem();
            this.antemilinahotmailcomSendTo = new System.Windows.Forms.ToolStripMenuItem();
            this.jebemuboga123gmailcomSendTo = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultSubIPorukaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bzvzTempDefault = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.tempToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tempicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temperinoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temperinoicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temperinoerinoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temperinoerinoerinoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dialogAttachment = new System.Windows.Forms.OpenFileDialog();
            this.btnAttachment = new System.Windows.Forms.Button();
            this.dialogFont = new System.Windows.Forms.FontDialog();
            this.btnPromjenaFontaPoruke = new System.Windows.Forms.Button();
            this.lblImeAttachmenta = new System.Windows.Forms.Label();
            this.lblStanjeSlanja = new System.Windows.Forms.Label();
            this.statusPoruke = new System.Windows.Forms.StatusStrip();
            this.progBarPoruka = new System.Windows.Forms.ToolStripProgressBar();
            this.lblStatusPoruke = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainToolBox.SuspendLayout();
            this.statusPoruke.SuspendLayout();
            this.SuspendLayout();
            // 
            // unosPosiljatelja
            // 
            this.unosPosiljatelja.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unosPosiljatelja.Location = new System.Drawing.Point(85, 54);
            this.unosPosiljatelja.MaximumSize = new System.Drawing.Size(500, 20);
            this.unosPosiljatelja.MinimumSize = new System.Drawing.Size(173, 20);
            this.unosPosiljatelja.Name = "unosPosiljatelja";
            this.unosPosiljatelja.Size = new System.Drawing.Size(500, 20);
            this.unosPosiljatelja.TabIndex = 0;
            // 
            // unosPrimatelja
            // 
            this.unosPrimatelja.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unosPrimatelja.Location = new System.Drawing.Point(85, 122);
            this.unosPrimatelja.MaximumSize = new System.Drawing.Size(500, 20);
            this.unosPrimatelja.MinimumSize = new System.Drawing.Size(173, 20);
            this.unosPrimatelja.Name = "unosPrimatelja";
            this.unosPrimatelja.Size = new System.Drawing.Size(500, 20);
            this.unosPrimatelja.TabIndex = 2;
            // 
            // lblsendto
            // 
            this.lblsendto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblsendto.AutoSize = true;
            this.lblsendto.Location = new System.Drawing.Point(18, 125);
            this.lblsendto.Name = "lblsendto";
            this.lblsendto.Size = new System.Drawing.Size(51, 13);
            this.lblsendto.TabIndex = 2;
            this.lblsendto.Text = "Send To:";
            // 
            // lbltvojemail
            // 
            this.lbltvojemail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltvojemail.AutoSize = true;
            this.lbltvojemail.Location = new System.Drawing.Point(18, 57);
            this.lbltvojemail.Name = "lbltvojemail";
            this.lbltvojemail.Size = new System.Drawing.Size(61, 13);
            this.lbltvojemail.TabIndex = 3;
            this.lbltvojemail.Text = "Tvoj e-mail:";
            // 
            // lblSubject
            // 
            this.lblSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(18, 157);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(46, 13);
            this.lblSubject.TabIndex = 4;
            this.lblSubject.Text = "Subject:";
            // 
            // unosSubject
            // 
            this.unosSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unosSubject.Location = new System.Drawing.Point(85, 154);
            this.unosSubject.MaximumSize = new System.Drawing.Size(500, 20);
            this.unosSubject.MinimumSize = new System.Drawing.Size(173, 20);
            this.unosSubject.Name = "unosSubject";
            this.unosSubject.Size = new System.Drawing.Size(500, 20);
            this.unosSubject.TabIndex = 3;
            // 
            // lblPoruka
            // 
            this.lblPoruka.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPoruka.AutoSize = true;
            this.lblPoruka.Location = new System.Drawing.Point(18, 185);
            this.lblPoruka.Name = "lblPoruka";
            this.lblPoruka.Size = new System.Drawing.Size(41, 13);
            this.lblPoruka.TabIndex = 7;
            this.lblPoruka.Text = "Poruka";
            // 
            // unosPoruke
            // 
            this.unosPoruke.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unosPoruke.Location = new System.Drawing.Point(21, 201);
            this.unosPoruke.Name = "unosPoruke";
            this.unosPoruke.Size = new System.Drawing.Size(704, 153);
            this.unosPoruke.TabIndex = 4;
            this.unosPoruke.Text = "";
            // 
            // btnPosalji
            // 
            this.btnPosalji.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPosalji.Location = new System.Drawing.Point(101, 365);
            this.btnPosalji.MinimumSize = new System.Drawing.Size(75, 33);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(544, 33);
            this.btnPosalji.TabIndex = 9;
            this.btnPosalji.Text = "Posalji";
            this.btnPosalji.UseVisualStyleBackColor = true;
            this.btnPosalji.Click += new System.EventHandler(this.btnPosalji_Click);
            // 
            // lblSifra
            // 
            this.lblSifra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSifra.AutoSize = true;
            this.lblSifra.Location = new System.Drawing.Point(18, 83);
            this.lblSifra.Name = "lblSifra";
            this.lblSifra.Size = new System.Drawing.Size(67, 13);
            this.lblSifra.TabIndex = 11;
            this.lblSifra.Text = "Sifra e-maila:";
            // 
            // unosSifra
            // 
            this.unosSifra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unosSifra.Location = new System.Drawing.Point(85, 80);
            this.unosSifra.MaximumSize = new System.Drawing.Size(500, 20);
            this.unosSifra.MinimumSize = new System.Drawing.Size(173, 20);
            this.unosSifra.Name = "unosSifra";
            this.unosSifra.Size = new System.Drawing.Size(500, 20);
            this.unosSifra.TabIndex = 1;
            this.unosSifra.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.MaximumSize = new System.Drawing.Size(585, 63);
            this.label1.MinimumSize = new System.Drawing.Size(255, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(585, 63);
            this.label1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Korisnicki podatci";
            // 
            // MainToolBox
            // 
            this.MainToolBox.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.MainToolBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2});
            this.MainToolBox.Location = new System.Drawing.Point(0, 0);
            this.MainToolBox.Name = "MainToolBox";
            this.MainToolBox.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MainToolBox.Size = new System.Drawing.Size(747, 25);
            this.MainToolBox.TabIndex = 14;
            this.MainToolBox.Text = "Toolbox";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMailToolStripMenuItem,
            this.DefaultMail,
            this.temp2ToolStripMenuItem,
            this.defaultSubIPorukaToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(38, 22);
            this.toolStripDropDownButton1.Text = "File";
            // 
            // newMailToolStripMenuItem
            // 
            this.newMailToolStripMenuItem.Name = "newMailToolStripMenuItem";
            this.newMailToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.newMailToolStripMenuItem.Text = "New Mail";
            this.newMailToolStripMenuItem.Click += new System.EventHandler(this.newMailToolStripMenuItem_Click);
            // 
            // DefaultMail
            // 
            this.DefaultMail.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HotmailCom,
            this.gmailcomToolStripMenuItem});
            this.DefaultMail.Name = "DefaultMail";
            this.DefaultMail.Size = new System.Drawing.Size(181, 22);
            this.DefaultMail.Text = "Default Mail";
            // 
            // HotmailCom
            // 
            this.HotmailCom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AnteMilinaHotmailComMail});
            this.HotmailCom.Name = "HotmailCom";
            this.HotmailCom.Size = new System.Drawing.Size(142, 22);
            this.HotmailCom.Text = "hotmail.com";
            // 
            // AnteMilinaHotmailComMail
            // 
            this.AnteMilinaHotmailComMail.Name = "AnteMilinaHotmailComMail";
            this.AnteMilinaHotmailComMail.Size = new System.Drawing.Size(212, 22);
            this.AnteMilinaHotmailComMail.Text = "ante.milina@hotmail.com";
            this.AnteMilinaHotmailComMail.Click += new System.EventHandler(this.AnteMilinaHotmailCom_Click);
            // 
            // gmailcomToolStripMenuItem
            // 
            this.gmailcomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jebemuboga123gmailcomMail});
            this.gmailcomToolStripMenuItem.Name = "gmailcomToolStripMenuItem";
            this.gmailcomToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.gmailcomToolStripMenuItem.Text = "gmail.com";
            // 
            // jebemuboga123gmailcomMail
            // 
            this.jebemuboga123gmailcomMail.Name = "jebemuboga123gmailcomMail";
            this.jebemuboga123gmailcomMail.Size = new System.Drawing.Size(227, 22);
            this.jebemuboga123gmailcomMail.Text = "jebemuboga123@gmail.com";
            this.jebemuboga123gmailcomMail.Click += new System.EventHandler(this.jebemuboga123GmailCom_Click);
            // 
            // temp2ToolStripMenuItem
            // 
            this.temp2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.antmilinafoihrSendTo,
            this.antemilinahotmailcomSendTo,
            this.jebemuboga123gmailcomSendTo});
            this.temp2ToolStripMenuItem.Name = "temp2ToolStripMenuItem";
            this.temp2ToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.temp2ToolStripMenuItem.Text = "Default Send To";
            // 
            // antmilinafoihrSendTo
            // 
            this.antmilinafoihrSendTo.Name = "antmilinafoihrSendTo";
            this.antmilinafoihrSendTo.Size = new System.Drawing.Size(227, 22);
            this.antmilinafoihrSendTo.Text = "antmilina@foi.hr";
            this.antmilinafoihrSendTo.Click += new System.EventHandler(this.antmilinafoihrSendTo_Click);
            // 
            // antemilinahotmailcomSendTo
            // 
            this.antemilinahotmailcomSendTo.Name = "antemilinahotmailcomSendTo";
            this.antemilinahotmailcomSendTo.Size = new System.Drawing.Size(227, 22);
            this.antemilinahotmailcomSendTo.Text = "ante.milina@hotmail.com";
            this.antemilinahotmailcomSendTo.Click += new System.EventHandler(this.antemilinahotmailcomSendTo_Click);
            // 
            // jebemuboga123gmailcomSendTo
            // 
            this.jebemuboga123gmailcomSendTo.Name = "jebemuboga123gmailcomSendTo";
            this.jebemuboga123gmailcomSendTo.Size = new System.Drawing.Size(227, 22);
            this.jebemuboga123gmailcomSendTo.Text = "jebemuboga123@gmail.com";
            this.jebemuboga123gmailcomSendTo.Click += new System.EventHandler(this.jebemuboga123gmailcomSendTo_Click);
            // 
            // defaultSubIPorukaToolStripMenuItem
            // 
            this.defaultSubIPorukaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bzvzTempDefault});
            this.defaultSubIPorukaToolStripMenuItem.Name = "defaultSubIPorukaToolStripMenuItem";
            this.defaultSubIPorukaToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.defaultSubIPorukaToolStripMenuItem.Text = "Default Sub i Poruka";
            // 
            // bzvzTempDefault
            // 
            this.bzvzTempDefault.Name = "bzvzTempDefault";
            this.bzvzTempDefault.Size = new System.Drawing.Size(128, 22);
            this.bzvzTempDefault.Text = "bzvz temp";
            this.bzvzTempDefault.Click += new System.EventHandler(this.bzvzTempDefault_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tempToolStripMenuItem1,
            this.temperinoToolStripMenuItem,
            this.temperinoerinoToolStripMenuItem,
            this.temperinoerinoerinoToolStripMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(62, 22);
            this.toolStripDropDownButton2.Text = "Options";
            // 
            // tempToolStripMenuItem1
            // 
            this.tempToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tempicToolStripMenuItem});
            this.tempToolStripMenuItem1.Name = "tempToolStripMenuItem1";
            this.tempToolStripMenuItem1.Size = new System.Drawing.Size(183, 22);
            this.tempToolStripMenuItem1.Text = "temp";
            // 
            // tempicToolStripMenuItem
            // 
            this.tempicToolStripMenuItem.Name = "tempicToolStripMenuItem";
            this.tempicToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.tempicToolStripMenuItem.Text = "tempic";
            // 
            // temperinoToolStripMenuItem
            // 
            this.temperinoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.temperinoicToolStripMenuItem});
            this.temperinoToolStripMenuItem.Name = "temperinoToolStripMenuItem";
            this.temperinoToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.temperinoToolStripMenuItem.Text = "temperino";
            // 
            // temperinoicToolStripMenuItem
            // 
            this.temperinoicToolStripMenuItem.Name = "temperinoicToolStripMenuItem";
            this.temperinoicToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.temperinoicToolStripMenuItem.Text = "temperinoic";
            // 
            // temperinoerinoToolStripMenuItem
            // 
            this.temperinoerinoToolStripMenuItem.Name = "temperinoerinoToolStripMenuItem";
            this.temperinoerinoToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.temperinoerinoToolStripMenuItem.Text = "temperinoerino";
            // 
            // temperinoerinoerinoToolStripMenuItem
            // 
            this.temperinoerinoerinoToolStripMenuItem.Name = "temperinoerinoerinoToolStripMenuItem";
            this.temperinoerinoerinoToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.temperinoerinoerinoToolStripMenuItem.Text = "temperinoerinoerino";
            // 
            // btnAttachment
            // 
            this.btnAttachment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAttachment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttachment.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAttachment.Location = new System.Drawing.Point(581, 176);
            this.btnAttachment.MaximumSize = new System.Drawing.Size(64, 21);
            this.btnAttachment.MinimumSize = new System.Drawing.Size(64, 21);
            this.btnAttachment.Name = "btnAttachment";
            this.btnAttachment.Size = new System.Drawing.Size(64, 21);
            this.btnAttachment.TabIndex = 15;
            this.btnAttachment.Tag = "";
            this.btnAttachment.Text = "Attachment";
            this.btnAttachment.UseVisualStyleBackColor = true;
            this.btnAttachment.Click += new System.EventHandler(this.btnAttachment_Click);
            // 
            // dialogFont
            // 
            this.dialogFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            // 
            // btnPromjenaFontaPoruke
            // 
            this.btnPromjenaFontaPoruke.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPromjenaFontaPoruke.Location = new System.Drawing.Point(653, 176);
            this.btnPromjenaFontaPoruke.Name = "btnPromjenaFontaPoruke";
            this.btnPromjenaFontaPoruke.Size = new System.Drawing.Size(72, 22);
            this.btnPromjenaFontaPoruke.TabIndex = 16;
            this.btnPromjenaFontaPoruke.Text = "Font";
            this.btnPromjenaFontaPoruke.UseVisualStyleBackColor = true;
            this.btnPromjenaFontaPoruke.Click += new System.EventHandler(this.btnPromjenaFontaPoruke_Click);
            // 
            // lblImeAttachmenta
            // 
            this.lblImeAttachmenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblImeAttachmenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblImeAttachmenta.Location = new System.Drawing.Point(523, 181);
            this.lblImeAttachmenta.MinimumSize = new System.Drawing.Size(35, 13);
            this.lblImeAttachmenta.Name = "lblImeAttachmenta";
            this.lblImeAttachmenta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblImeAttachmenta.Size = new System.Drawing.Size(52, 13);
            this.lblImeAttachmenta.TabIndex = 17;
            this.lblImeAttachmenta.Text = "No Att.";
            this.lblImeAttachmenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStanjeSlanja
            // 
            this.lblStanjeSlanja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStanjeSlanja.AutoSize = true;
            this.lblStanjeSlanja.Location = new System.Drawing.Point(651, 412);
            this.lblStanjeSlanja.Name = "lblStanjeSlanja";
            this.lblStanjeSlanja.Size = new System.Drawing.Size(0, 13);
            this.lblStanjeSlanja.TabIndex = 18;
            // 
            // statusPoruke
            // 
            this.statusPoruke.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progBarPoruka,
            this.lblStatusPoruke});
            this.statusPoruke.Location = new System.Drawing.Point(0, 406);
            this.statusPoruke.MaximumSize = new System.Drawing.Size(0, 28);
            this.statusPoruke.Name = "statusPoruke";
            this.statusPoruke.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusPoruke.Size = new System.Drawing.Size(747, 28);
            this.statusPoruke.TabIndex = 19;
            this.statusPoruke.Text = "Status poruke";
            // 
            // progBarPoruka
            // 
            this.progBarPoruka.AutoSize = false;
            this.progBarPoruka.Maximum = 400;
            this.progBarPoruka.Name = "progBarPoruka";
            this.progBarPoruka.Size = new System.Drawing.Size(100, 18);
            this.progBarPoruka.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // lblStatusPoruke
            // 
            this.lblStatusPoruke.BackColor = System.Drawing.Color.Transparent;
            this.lblStatusPoruke.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lblStatusPoruke.Name = "lblStatusPoruke";
            this.lblStatusPoruke.Size = new System.Drawing.Size(79, 19);
            this.lblStatusPoruke.Text = "Status Poruke";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(747, 434);
            this.Controls.Add(this.statusPoruke);
            this.Controls.Add(this.lblStanjeSlanja);
            this.Controls.Add(this.lblImeAttachmenta);
            this.Controls.Add(this.btnPromjenaFontaPoruke);
            this.Controls.Add(this.btnAttachment);
            this.Controls.Add(this.MainToolBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSifra);
            this.Controls.Add(this.unosSifra);
            this.Controls.Add(this.btnPosalji);
            this.Controls.Add(this.unosPoruke);
            this.Controls.Add(this.lblPoruka);
            this.Controls.Add(this.unosSubject);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lbltvojemail);
            this.Controls.Add(this.lblsendto);
            this.Controls.Add(this.unosPrimatelja);
            this.Controls.Add(this.unosPosiljatelja);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(294, 432);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E-mail";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainToolBox.ResumeLayout(false);
            this.MainToolBox.PerformLayout();
            this.statusPoruke.ResumeLayout(false);
            this.statusPoruke.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox unosPosiljatelja;
        private System.Windows.Forms.TextBox unosPrimatelja;
        private System.Windows.Forms.Label lblsendto;
        private System.Windows.Forms.Label lbltvojemail;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.TextBox unosSubject;
        private System.Windows.Forms.Label lblPoruka;
        private System.Windows.Forms.RichTextBox unosPoruke;
        private System.Windows.Forms.Button btnPosalji;
        private System.Windows.Forms.Label lblSifra;
        private System.Windows.Forms.TextBox unosSifra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip MainToolBox;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem DefaultMail;
        private System.Windows.Forms.ToolStripMenuItem temp2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem tempToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tempicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temperinoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temperinoicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temperinoerinoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temperinoerinoerinoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HotmailCom;
        private System.Windows.Forms.ToolStripMenuItem AnteMilinaHotmailComMail;
        private System.Windows.Forms.ToolStripMenuItem gmailcomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jebemuboga123gmailcomMail;
        private System.Windows.Forms.ToolStripMenuItem antmilinafoihrSendTo;
        private System.Windows.Forms.ToolStripMenuItem antemilinahotmailcomSendTo;
        private System.Windows.Forms.ToolStripMenuItem jebemuboga123gmailcomSendTo;
        private System.Windows.Forms.ToolStripMenuItem defaultSubIPorukaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bzvzTempDefault;
        private System.Windows.Forms.OpenFileDialog dialogAttachment;
        private System.Windows.Forms.Button btnAttachment;
        private System.Windows.Forms.FontDialog dialogFont;
        private System.Windows.Forms.Button btnPromjenaFontaPoruke;
        private System.Windows.Forms.Label lblImeAttachmenta;
        private System.Windows.Forms.ToolStripMenuItem newMailToolStripMenuItem;
        private System.Windows.Forms.Label lblStanjeSlanja;
        private System.Windows.Forms.StatusStrip statusPoruke;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusPoruke;
        private System.Windows.Forms.ToolStripProgressBar progBarPoruka;
    }
}

