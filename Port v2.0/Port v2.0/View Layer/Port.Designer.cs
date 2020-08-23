namespace Port_v2._0
{
    partial class Port
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Port));
            this.Show = new System.Windows.Forms.Label();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            this.SelectTable = new System.Windows.Forms.ComboBox();
            this.AboutBox = new System.Windows.Forms.Button();
            this.comboBoxLoad = new System.Windows.Forms.ComboBox();
            this.comboBoxShip = new System.Windows.Forms.ComboBox();
            this.label2Query1 = new System.Windows.Forms.Label();
            this.label1Query1 = new System.Windows.Forms.Label();
            this.comboBoxTypeLoad = new System.Windows.Forms.ComboBox();
            this.label1Query2 = new System.Windows.Forms.Label();
            this.comboBoxRecipient = new System.Windows.Forms.ComboBox();
            this.label1Query3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonQuery5 = new System.Windows.Forms.RadioButton();
            this.radioButtonQuery4 = new System.Windows.Forms.RadioButton();
            this.radioButtonQuery3 = new System.Windows.Forms.RadioButton();
            this.radioButtonQuery2 = new System.Windows.Forms.RadioButton();
            this.radioButtonQuery1 = new System.Windows.Forms.RadioButton();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.button1Reset = new System.Windows.Forms.Button();
            this.comboBox1T = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1Transaction = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5Load = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4Load = new System.Windows.Forms.TextBox();
            this.comboBox2Load = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3Load = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1Load = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2Load = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.comboBox1Ship = new System.Windows.Forms.ComboBox();
            this.comboBox2Ship = new System.Windows.Forms.ComboBox();
            this.textBox1Find = new System.Windows.Forms.TextBox();
            this.label4Ship = new System.Windows.Forms.Label();
            this.label3Ship = new System.Windows.Forms.Label();
            this.textBox3Ship = new System.Windows.Forms.TextBox();
            this.label2Ship = new System.Windows.Forms.Label();
            this.textBox1Ship = new System.Windows.Forms.TextBox();
            this.label1Ship = new System.Windows.Forms.Label();
            this.textBox2Ship = new System.Windows.Forms.TextBox();
            this.textBox1Load = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // Show
            // 
            this.Show.AutoSize = true;
            this.Show.Location = new System.Drawing.Point(18, 12);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(37, 13);
            this.Show.TabIndex = 5;
            this.Show.Text = "Show:";
            // 
            // dataGridViewResult
            // 
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult.Location = new System.Drawing.Point(12, 448);
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.Size = new System.Drawing.Size(562, 164);
            this.dataGridViewResult.TabIndex = 4;
            // 
            // SelectTable
            // 
            this.SelectTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectTable.FormattingEnabled = true;
            this.SelectTable.Items.AddRange(new object[] {
            "Cancel",
            "Info about Ships",
            "Info about Load",
            "History of Ship"});
            this.SelectTable.Location = new System.Drawing.Point(61, 10);
            this.SelectTable.Name = "SelectTable";
            this.SelectTable.Size = new System.Drawing.Size(121, 21);
            this.SelectTable.TabIndex = 3;
            this.SelectTable.SelectedIndexChanged += new System.EventHandler(this.SelectTable_SelectedIndexChanged);
            // 
            // AboutBox
            // 
            this.AboutBox.Location = new System.Drawing.Point(499, 7);
            this.AboutBox.Name = "AboutBox";
            this.AboutBox.Size = new System.Drawing.Size(75, 23);
            this.AboutBox.TabIndex = 6;
            this.AboutBox.Text = "About";
            this.AboutBox.UseVisualStyleBackColor = true;
            this.AboutBox.Click += new System.EventHandler(this.AboutBox_Click);
            // 
            // comboBoxLoad
            // 
            this.comboBoxLoad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLoad.FormattingEnabled = true;
            this.comboBoxLoad.Location = new System.Drawing.Point(69, 14);
            this.comboBoxLoad.Name = "comboBoxLoad";
            this.comboBoxLoad.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLoad.TabIndex = 12;
            this.comboBoxLoad.SelectedIndexChanged += new System.EventHandler(this.comboBoxLoad_SelectedIndexChanged);
            // 
            // comboBoxShip
            // 
            this.comboBoxShip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShip.FormattingEnabled = true;
            this.comboBoxShip.Location = new System.Drawing.Point(69, 41);
            this.comboBoxShip.Name = "comboBoxShip";
            this.comboBoxShip.Size = new System.Drawing.Size(121, 21);
            this.comboBoxShip.TabIndex = 11;
            this.comboBoxShip.SelectedIndexChanged += new System.EventHandler(this.comboBoxShip_SelectedIndexChanged);
            // 
            // label2Query1
            // 
            this.label2Query1.AutoSize = true;
            this.label2Query1.Location = new System.Drawing.Point(5, 44);
            this.label2Query1.Name = "label2Query1";
            this.label2Query1.Size = new System.Drawing.Size(31, 13);
            this.label2Query1.TabIndex = 10;
            this.label2Query1.Text = "Ship:";
            // 
            // label1Query1
            // 
            this.label1Query1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1Query1.AutoSize = true;
            this.label1Query1.Location = new System.Drawing.Point(5, 19);
            this.label1Query1.Name = "label1Query1";
            this.label1Query1.Size = new System.Drawing.Size(34, 13);
            this.label1Query1.TabIndex = 9;
            this.label1Query1.Text = "Load:";
            // 
            // comboBoxTypeLoad
            // 
            this.comboBoxTypeLoad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypeLoad.FormattingEnabled = true;
            this.comboBoxTypeLoad.Location = new System.Drawing.Point(69, 68);
            this.comboBoxTypeLoad.Name = "comboBoxTypeLoad";
            this.comboBoxTypeLoad.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTypeLoad.TabIndex = 14;
            this.comboBoxTypeLoad.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypeLoad_SelectedIndexChanged);
            // 
            // label1Query2
            // 
            this.label1Query2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1Query2.AutoSize = true;
            this.label1Query2.Location = new System.Drawing.Point(5, 71);
            this.label1Query2.Name = "label1Query2";
            this.label1Query2.Size = new System.Drawing.Size(61, 13);
            this.label1Query2.TabIndex = 13;
            this.label1Query2.Text = "Type Load:";
            // 
            // comboBoxRecipient
            // 
            this.comboBoxRecipient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRecipient.FormattingEnabled = true;
            this.comboBoxRecipient.Location = new System.Drawing.Point(69, 95);
            this.comboBoxRecipient.Name = "comboBoxRecipient";
            this.comboBoxRecipient.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRecipient.TabIndex = 16;
            this.comboBoxRecipient.SelectedIndexChanged += new System.EventHandler(this.comboBoxRecipient_SelectedIndexChanged);
            // 
            // label1Query3
            // 
            this.label1Query3.AutoSize = true;
            this.label1Query3.Location = new System.Drawing.Point(5, 98);
            this.label1Query3.Name = "label1Query3";
            this.label1Query3.Size = new System.Drawing.Size(55, 13);
            this.label1Query3.TabIndex = 15;
            this.label1Query3.Text = "Recipient:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonDone);
            this.groupBox1.Controls.Add(this.buttonInfo);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 166);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Query";
            // 
            // buttonDone
            // 
            this.buttonDone.Location = new System.Drawing.Point(303, 87);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(75, 48);
            this.buttonDone.TabIndex = 29;
            this.buttonDone.Text = "Done";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.Location = new System.Drawing.Point(303, 31);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(75, 23);
            this.buttonInfo.TabIndex = 28;
            this.buttonInfo.Text = "Info";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1Query1);
            this.groupBox3.Controls.Add(this.label2Query1);
            this.groupBox3.Controls.Add(this.comboBoxShip);
            this.groupBox3.Controls.Add(this.comboBoxLoad);
            this.groupBox3.Controls.Add(this.comboBoxRecipient);
            this.groupBox3.Controls.Add(this.label1Query2);
            this.groupBox3.Controls.Add(this.label1Query3);
            this.groupBox3.Controls.Add(this.comboBoxTypeLoad);
            this.groupBox3.Location = new System.Drawing.Point(97, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 138);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.radioButtonQuery5);
            this.groupBox2.Controls.Add(this.radioButtonQuery4);
            this.groupBox2.Controls.Add(this.radioButtonQuery3);
            this.groupBox2.Controls.Add(this.radioButtonQuery2);
            this.groupBox2.Controls.Add(this.radioButtonQuery1);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(85, 138);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            // 
            // radioButtonQuery5
            // 
            this.radioButtonQuery5.AutoSize = true;
            this.radioButtonQuery5.Location = new System.Drawing.Point(12, 108);
            this.radioButtonQuery5.Name = "radioButtonQuery5";
            this.radioButtonQuery5.Size = new System.Drawing.Size(62, 17);
            this.radioButtonQuery5.TabIndex = 25;
            this.radioButtonQuery5.TabStop = true;
            this.radioButtonQuery5.Text = "Query 5";
            this.radioButtonQuery5.UseVisualStyleBackColor = true;
            this.radioButtonQuery5.CheckedChanged += new System.EventHandler(this.radioButtonQuery5_CheckedChanged);
            // 
            // radioButtonQuery4
            // 
            this.radioButtonQuery4.AutoSize = true;
            this.radioButtonQuery4.Location = new System.Drawing.Point(12, 85);
            this.radioButtonQuery4.Name = "radioButtonQuery4";
            this.radioButtonQuery4.Size = new System.Drawing.Size(62, 17);
            this.radioButtonQuery4.TabIndex = 24;
            this.radioButtonQuery4.TabStop = true;
            this.radioButtonQuery4.Text = "Query 4";
            this.radioButtonQuery4.UseVisualStyleBackColor = true;
            this.radioButtonQuery4.CheckedChanged += new System.EventHandler(this.radioButtonQuery4_CheckedChanged);
            // 
            // radioButtonQuery3
            // 
            this.radioButtonQuery3.AutoSize = true;
            this.radioButtonQuery3.Location = new System.Drawing.Point(12, 62);
            this.radioButtonQuery3.Name = "radioButtonQuery3";
            this.radioButtonQuery3.Size = new System.Drawing.Size(62, 17);
            this.radioButtonQuery3.TabIndex = 23;
            this.radioButtonQuery3.TabStop = true;
            this.radioButtonQuery3.Text = "Query 3";
            this.radioButtonQuery3.UseVisualStyleBackColor = true;
            this.radioButtonQuery3.CheckedChanged += new System.EventHandler(this.radioButtonQuery3_CheckedChanged);
            // 
            // radioButtonQuery2
            // 
            this.radioButtonQuery2.AutoSize = true;
            this.radioButtonQuery2.Location = new System.Drawing.Point(12, 38);
            this.radioButtonQuery2.Name = "radioButtonQuery2";
            this.radioButtonQuery2.Size = new System.Drawing.Size(62, 17);
            this.radioButtonQuery2.TabIndex = 22;
            this.radioButtonQuery2.TabStop = true;
            this.radioButtonQuery2.Text = "Query 2";
            this.radioButtonQuery2.UseVisualStyleBackColor = true;
            this.radioButtonQuery2.CheckedChanged += new System.EventHandler(this.radioButtonQuery2_CheckedChanged);
            // 
            // radioButtonQuery1
            // 
            this.radioButtonQuery1.AutoSize = true;
            this.radioButtonQuery1.Location = new System.Drawing.Point(12, 15);
            this.radioButtonQuery1.Name = "radioButtonQuery1";
            this.radioButtonQuery1.Size = new System.Drawing.Size(62, 17);
            this.radioButtonQuery1.TabIndex = 21;
            this.radioButtonQuery1.TabStop = true;
            this.radioButtonQuery1.Text = "Query 1";
            this.radioButtonQuery1.UseVisualStyleBackColor = true;
            this.radioButtonQuery1.CheckedChanged += new System.EventHandler(this.radioButtonQuery1_CheckedChanged);
            // 
            // textBoxFind
            // 
            this.textBoxFind.Location = new System.Drawing.Point(450, 6);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(43, 20);
            this.textBoxFind.TabIndex = 30;
            this.textBoxFind.Visible = false;
            // 
            // button1Reset
            // 
            this.button1Reset.Location = new System.Drawing.Point(303, 198);
            this.button1Reset.Name = "button1Reset";
            this.button1Reset.Size = new System.Drawing.Size(75, 23);
            this.button1Reset.TabIndex = 29;
            this.button1Reset.Text = "Reset";
            this.button1Reset.UseVisualStyleBackColor = true;
            this.button1Reset.Click += new System.EventHandler(this.button1Reset_Click);
            // 
            // comboBox1T
            // 
            this.comboBox1T.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1T.FormattingEnabled = true;
            this.comboBox1T.Items.AddRange(new object[] {
            "Прибытие",
            "Убытие"});
            this.comboBox1T.Location = new System.Drawing.Point(117, 21);
            this.comboBox1T.Name = "comboBox1T";
            this.comboBox1T.Size = new System.Drawing.Size(135, 21);
            this.comboBox1T.TabIndex = 28;
            this.comboBox1T.SelectedIndexChanged += new System.EventHandler(this.comboBox1T_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Type transaction:";
            // 
            // button1Transaction
            // 
            this.button1Transaction.Location = new System.Drawing.Point(414, 198);
            this.button1Transaction.Name = "button1Transaction";
            this.button1Transaction.Size = new System.Drawing.Size(100, 23);
            this.button1Transaction.TabIndex = 26;
            this.button1Transaction.Text = "Done";
            this.button1Transaction.UseVisualStyleBackColor = true;
            this.button1Transaction.Click += new System.EventHandler(this.button1Transaction_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(410, 38);
            this.monthCalendar1.MinDate = new System.DateTime(2013, 11, 13, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 25;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.textBox5Load);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.textBox4Load);
            this.groupBox4.Controls.Add(this.comboBox2Load);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.textBox3Load);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.comboBox1Load);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.textBox2Load);
            this.groupBox4.Location = new System.Drawing.Point(7, 48);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(256, 173);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Load";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Country of origin:";
            // 
            // textBox5Load
            // 
            this.textBox5Load.Location = new System.Drawing.Point(110, 141);
            this.textBox5Load.MaxLength = 18;
            this.textBox5Load.Name = "textBox5Load";
            this.textBox5Load.Size = new System.Drawing.Size(135, 20);
            this.textBox5Load.TabIndex = 12;
            this.textBox5Load.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5Load_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Recipient:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Units:";
            // 
            // textBox4Load
            // 
            this.textBox4Load.Location = new System.Drawing.Point(111, 115);
            this.textBox4Load.MaxLength = 18;
            this.textBox4Load.Name = "textBox4Load";
            this.textBox4Load.Size = new System.Drawing.Size(135, 20);
            this.textBox4Load.TabIndex = 11;
            this.textBox4Load.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4Load_KeyPress);
            // 
            // comboBox2Load
            // 
            this.comboBox2Load.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2Load.FormattingEnabled = true;
            this.comboBox2Load.Items.AddRange(new object[] {
            "Тон.",
            "Гал.",
            "Шт."});
            this.comboBox2Load.Location = new System.Drawing.Point(110, 88);
            this.comboBox2Load.Name = "comboBox2Load";
            this.comboBox2Load.Size = new System.Drawing.Size(135, 21);
            this.comboBox2Load.TabIndex = 10;
            this.comboBox2Load.SelectedIndexChanged += new System.EventHandler(this.comboBox2Load_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Amount:";
            // 
            // textBox3Load
            // 
            this.textBox3Load.Location = new System.Drawing.Point(110, 62);
            this.textBox3Load.MaxLength = 18;
            this.textBox3Load.Name = "textBox3Load";
            this.textBox3Load.Size = new System.Drawing.Size(135, 20);
            this.textBox3Load.TabIndex = 9;
            this.textBox3Load.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3Load_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Type Load:";
            // 
            // comboBox1Load
            // 
            this.comboBox1Load.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1Load.FormattingEnabled = true;
            this.comboBox1Load.Items.AddRange(new object[] {
            "Контейнеровоз",
            "Сухогруз",
            "Танкер"});
            this.comboBox1Load.Location = new System.Drawing.Point(110, 35);
            this.comboBox1Load.Name = "comboBox1Load";
            this.comboBox1Load.Size = new System.Drawing.Size(135, 21);
            this.comboBox1Load.TabIndex = 8;
            this.comboBox1Load.SelectedIndexChanged += new System.EventHandler(this.comboBox1Load_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Load:";
            // 
            // textBox2Load
            // 
            this.textBox2Load.Location = new System.Drawing.Point(110, 9);
            this.textBox2Load.MaxLength = 18;
            this.textBox2Load.Name = "textBox2Load";
            this.textBox2Load.Size = new System.Drawing.Size(135, 20);
            this.textBox2Load.TabIndex = 1;
            this.textBox2Load.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2Load_KeyPress);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.comboBox1Ship);
            this.groupBox5.Controls.Add(this.comboBox2Ship);
            this.groupBox5.Controls.Add(this.textBox1Find);
            this.groupBox5.Controls.Add(this.label4Ship);
            this.groupBox5.Controls.Add(this.label3Ship);
            this.groupBox5.Controls.Add(this.textBox3Ship);
            this.groupBox5.Controls.Add(this.label2Ship);
            this.groupBox5.Controls.Add(this.textBox1Ship);
            this.groupBox5.Controls.Add(this.label1Ship);
            this.groupBox5.Controls.Add(this.textBox2Ship);
            this.groupBox5.Location = new System.Drawing.Point(269, 48);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(256, 131);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ship";
            // 
            // comboBox1Ship
            // 
            this.comboBox1Ship.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1Ship.FormattingEnabled = true;
            this.comboBox1Ship.Items.AddRange(new object[] {
            "Контейнеровоз",
            "Сухогруз",
            "Танкер"});
            this.comboBox1Ship.Location = new System.Drawing.Point(110, 43);
            this.comboBox1Ship.Name = "comboBox1Ship";
            this.comboBox1Ship.Size = new System.Drawing.Size(135, 21);
            this.comboBox1Ship.TabIndex = 0;
            this.comboBox1Ship.SelectedIndexChanged += new System.EventHandler(this.comboBox1Ship_SelectedIndexChanged);
            this.comboBox1Ship.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox1Ship_MouseClick);
            // 
            // comboBox2Ship
            // 
            this.comboBox2Ship.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2Ship.FormattingEnabled = true;
            this.comboBox2Ship.Location = new System.Drawing.Point(110, 13);
            this.comboBox2Ship.Name = "comboBox2Ship";
            this.comboBox2Ship.Size = new System.Drawing.Size(135, 21);
            this.comboBox2Ship.TabIndex = 6;
            this.comboBox2Ship.SelectedIndexChanged += new System.EventHandler(this.comboBox2Ship_SelectedIndexChanged);
            // 
            // textBox1Find
            // 
            this.textBox1Find.Location = new System.Drawing.Point(110, 44);
            this.textBox1Find.Name = "textBox1Find";
            this.textBox1Find.ReadOnly = true;
            this.textBox1Find.Size = new System.Drawing.Size(135, 20);
            this.textBox1Find.TabIndex = 8;
            this.textBox1Find.MouseEnter += new System.EventHandler(this.textBox1Find_MouseEnter);
            // 
            // label4Ship
            // 
            this.label4Ship.AutoSize = true;
            this.label4Ship.Location = new System.Drawing.Point(6, 76);
            this.label4Ship.Name = "label4Ship";
            this.label4Ship.Size = new System.Drawing.Size(46, 13);
            this.label4Ship.TabIndex = 7;
            this.label4Ship.Text = "Capitan:";
            // 
            // label3Ship
            // 
            this.label3Ship.AutoSize = true;
            this.label3Ship.Location = new System.Drawing.Point(6, 102);
            this.label3Ship.Name = "label3Ship";
            this.label3Ship.Size = new System.Drawing.Size(46, 13);
            this.label3Ship.TabIndex = 6;
            this.label3Ship.Text = "Country:";
            // 
            // textBox3Ship
            // 
            this.textBox3Ship.Location = new System.Drawing.Point(110, 99);
            this.textBox3Ship.MaxLength = 18;
            this.textBox3Ship.Name = "textBox3Ship";
            this.textBox3Ship.Size = new System.Drawing.Size(135, 20);
            this.textBox3Ship.TabIndex = 3;
            this.textBox3Ship.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3Ship_KeyPress);
            // 
            // label2Ship
            // 
            this.label2Ship.AutoSize = true;
            this.label2Ship.Location = new System.Drawing.Point(6, 16);
            this.label2Ship.Name = "label2Ship";
            this.label2Ship.Size = new System.Drawing.Size(31, 13);
            this.label2Ship.TabIndex = 5;
            this.label2Ship.Text = "Ship:";
            // 
            // textBox1Ship
            // 
            this.textBox1Ship.Location = new System.Drawing.Point(110, 14);
            this.textBox1Ship.Name = "textBox1Ship";
            this.textBox1Ship.Size = new System.Drawing.Size(135, 20);
            this.textBox1Ship.TabIndex = 1;
            this.textBox1Ship.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1Ship_KeyPress);
            // 
            // label1Ship
            // 
            this.label1Ship.AutoSize = true;
            this.label1Ship.Location = new System.Drawing.Point(8, 47);
            this.label1Ship.Name = "label1Ship";
            this.label1Ship.Size = new System.Drawing.Size(55, 13);
            this.label1Ship.TabIndex = 4;
            this.label1Ship.Text = "Type Ship";
            // 
            // textBox2Ship
            // 
            this.textBox2Ship.Location = new System.Drawing.Point(110, 73);
            this.textBox2Ship.MaxLength = 18;
            this.textBox2Ship.Name = "textBox2Ship";
            this.textBox2Ship.Size = new System.Drawing.Size(135, 20);
            this.textBox2Ship.TabIndex = 2;
            this.textBox2Ship.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2Ship_KeyPress);
            // 
            // textBox1Load
            // 
            this.textBox1Load.Location = new System.Drawing.Point(401, 5);
            this.textBox1Load.Name = "textBox1Load";
            this.textBox1Load.Size = new System.Drawing.Size(43, 20);
            this.textBox1Load.TabIndex = 23;
            this.textBox1Load.Visible = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.comboBox1T);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.button1Transaction);
            this.groupBox6.Controls.Add(this.button1Reset);
            this.groupBox6.Controls.Add(this.groupBox4);
            this.groupBox6.Controls.Add(this.groupBox5);
            this.groupBox6.Location = new System.Drawing.Point(12, 206);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(535, 234);
            this.groupBox6.TabIndex = 31;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Transaction";
            // 
            // Port
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(584, 624);
            this.Controls.Add(this.textBox1Load);
            this.Controls.Add(this.textBoxFind);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AboutBox);
            this.Controls.Add(this.Show);
            this.Controls.Add(this.dataGridViewResult);
            this.Controls.Add(this.SelectTable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Port";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Program to work with DataBases";
           // this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Port_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Port_FormClosed);
            this.Load += new System.EventHandler(this.Port_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Show;
        private System.Windows.Forms.DataGridView dataGridViewResult;
        private System.Windows.Forms.ComboBox SelectTable;
        private System.Windows.Forms.Button AboutBox;
        private System.Windows.Forms.ComboBox comboBoxLoad;
        private System.Windows.Forms.ComboBox comboBoxShip;
        private System.Windows.Forms.Label label2Query1;
        private System.Windows.Forms.Label label1Query1;
        private System.Windows.Forms.ComboBox comboBoxTypeLoad;
        private System.Windows.Forms.Label label1Query2;
        private System.Windows.Forms.ComboBox comboBoxRecipient;
        private System.Windows.Forms.Label label1Query3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonQuery5;
        private System.Windows.Forms.RadioButton radioButtonQuery4;
        private System.Windows.Forms.RadioButton radioButtonQuery3;
        private System.Windows.Forms.RadioButton radioButtonQuery2;
        private System.Windows.Forms.RadioButton radioButtonQuery1;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.Button button1Reset;
        private System.Windows.Forms.ComboBox comboBox1T;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1Transaction;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5Load;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4Load;
        private System.Windows.Forms.ComboBox comboBox2Load;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3Load;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1Load;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2Load;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox comboBox1Ship;
        private System.Windows.Forms.ComboBox comboBox2Ship;
        private System.Windows.Forms.TextBox textBox1Find;
        private System.Windows.Forms.Label label4Ship;
        private System.Windows.Forms.Label label3Ship;
        private System.Windows.Forms.TextBox textBox3Ship;
        private System.Windows.Forms.Label label2Ship;
        private System.Windows.Forms.TextBox textBox1Ship;
        private System.Windows.Forms.Label label1Ship;
        private System.Windows.Forms.TextBox textBox2Ship;
        private System.Windows.Forms.TextBox textBox1Load;
        private System.Windows.Forms.GroupBox groupBox6;

    }
}

