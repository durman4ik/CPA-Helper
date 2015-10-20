namespace SPA_Helper
{
    partial class SpaHelper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpaHelper));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.openFileButton = new System.Windows.Forms.Button();
            this.phoneStripingPanel = new System.Windows.Forms.GroupBox();
            this.startStripButton = new System.Windows.Forms.Button();
            this.savedNumbersLabel = new System.Windows.Forms.Label();
            this.deletedNumbersLabel = new System.Windows.Forms.Label();
            this.totalNumbersLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.numberRepeatsLabel = new System.Windows.Forms.Label();
            this.numberLengthLabel = new System.Windows.Forms.Label();
            this.numberRepeatsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.numberLengthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.authGroupBox = new System.Windows.Forms.GroupBox();
            this.succesLabelVK = new System.Windows.Forms.Label();
            this.failLabelVK = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.VKAuthButton = new System.Windows.Forms.Button();
            this.vkParamsGroupBox = new System.Windows.Forms.GroupBox();
            this.kazahstanCheckBox = new System.Windows.Forms.CheckBox();
            this.belarusCheckBox = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.russiaCheckBox = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ukraineCheckBox = new System.Windows.Forms.CheckBox();
            this.groupIdTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maxAgeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.minAgeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.femaleGenderCheckBox = new System.Windows.Forms.CheckBox();
            this.maleGenderCheckBox = new System.Windows.Forms.CheckBox();
            this.stripPhonesRadioButton = new System.Windows.Forms.RadioButton();
            this.parseRadioButton = new System.Windows.Forms.RadioButton();
            this.socialPanel = new System.Windows.Forms.Panel();
            this.cancelParseButton = new System.Windows.Forms.Button();
            this.membersCountLabel = new System.Windows.Forms.Label();
            this.membersLabel = new System.Windows.Forms.Label();
            this.groupNameTextBox = new System.Windows.Forms.TextBox();
            this.groupImageBox = new System.Windows.Forms.PictureBox();
            this.StartParseButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.phoneStripingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberRepeatsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberLengthNumericUpDown)).BeginInit();
            this.authGroupBox.SuspendLayout();
            this.vkParamsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxAgeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minAgeNumericUpDown)).BeginInit();
            this.socialPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel,
            this.progressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 266);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(631, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = false;
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(525, 17);
            this.statusLabel.Text = "...";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progressBar1
            // 
            this.progressBar1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.progressBar1.AutoSize = false;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(6, 44);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(168, 25);
            this.openFileButton.TabIndex = 3;
            this.openFileButton.Text = "Открыть";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // phoneStripingPanel
            // 
            this.phoneStripingPanel.Controls.Add(this.label9);
            this.phoneStripingPanel.Controls.Add(this.comboBox1);
            this.phoneStripingPanel.Controls.Add(this.startStripButton);
            this.phoneStripingPanel.Controls.Add(this.savedNumbersLabel);
            this.phoneStripingPanel.Controls.Add(this.deletedNumbersLabel);
            this.phoneStripingPanel.Controls.Add(this.totalNumbersLabel);
            this.phoneStripingPanel.Controls.Add(this.label3);
            this.phoneStripingPanel.Controls.Add(this.label2);
            this.phoneStripingPanel.Controls.Add(this.label1);
            this.phoneStripingPanel.Controls.Add(this.fileNameLabel);
            this.phoneStripingPanel.Controls.Add(this.numberRepeatsLabel);
            this.phoneStripingPanel.Controls.Add(this.numberLengthLabel);
            this.phoneStripingPanel.Controls.Add(this.numberRepeatsNumericUpDown);
            this.phoneStripingPanel.Controls.Add(this.numberLengthNumericUpDown);
            this.phoneStripingPanel.Controls.Add(this.openFileButton);
            this.phoneStripingPanel.Location = new System.Drawing.Point(11, 28);
            this.phoneStripingPanel.Name = "phoneStripingPanel";
            this.phoneStripingPanel.Size = new System.Drawing.Size(180, 236);
            this.phoneStripingPanel.TabIndex = 4;
            this.phoneStripingPanel.TabStop = false;
            // 
            // startStripButton
            // 
            this.startStripButton.Enabled = false;
            this.startStripButton.Location = new System.Drawing.Point(6, 149);
            this.startStripButton.Name = "startStripButton";
            this.startStripButton.Size = new System.Drawing.Size(168, 32);
            this.startStripButton.TabIndex = 16;
            this.startStripButton.Text = "Старт";
            this.startStripButton.UseVisualStyleBackColor = true;
            this.startStripButton.Click += new System.EventHandler(this.startStripButton_Click);
            // 
            // savedNumbersLabel
            // 
            this.savedNumbersLabel.AutoSize = true;
            this.savedNumbersLabel.Location = new System.Drawing.Point(121, 216);
            this.savedNumbersLabel.MaximumSize = new System.Drawing.Size(45, 13);
            this.savedNumbersLabel.Name = "savedNumbersLabel";
            this.savedNumbersLabel.Size = new System.Drawing.Size(13, 13);
            this.savedNumbersLabel.TabIndex = 15;
            this.savedNumbersLabel.Text = "?";
            this.savedNumbersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // deletedNumbersLabel
            // 
            this.deletedNumbersLabel.Location = new System.Drawing.Point(121, 202);
            this.deletedNumbersLabel.MaximumSize = new System.Drawing.Size(45, 13);
            this.deletedNumbersLabel.Name = "deletedNumbersLabel";
            this.deletedNumbersLabel.Size = new System.Drawing.Size(13, 13);
            this.deletedNumbersLabel.TabIndex = 14;
            this.deletedNumbersLabel.Text = "?";
            this.deletedNumbersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalNumbersLabel
            // 
            this.totalNumbersLabel.AutoSize = true;
            this.totalNumbersLabel.Location = new System.Drawing.Point(121, 189);
            this.totalNumbersLabel.MaximumSize = new System.Drawing.Size(45, 13);
            this.totalNumbersLabel.Name = "totalNumbersLabel";
            this.totalNumbersLabel.Size = new System.Drawing.Size(13, 13);
            this.totalNumbersLabel.TabIndex = 13;
            this.totalNumbersLabel.Text = "?";
            this.totalNumbersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Сохранено номеров:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Удалено номеров:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Всего номеров:";
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.Location = new System.Drawing.Point(6, 16);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(168, 21);
            this.fileNameLabel.TabIndex = 9;
            // 
            // numberRepeatsLabel
            // 
            this.numberRepeatsLabel.Location = new System.Drawing.Point(6, 100);
            this.numberRepeatsLabel.Name = "numberRepeatsLabel";
            this.numberRepeatsLabel.Size = new System.Drawing.Size(93, 15);
            this.numberRepeatsLabel.TabIndex = 8;
            this.numberRepeatsLabel.Text = "Повторов";
            // 
            // numberLengthLabel
            // 
            this.numberLengthLabel.AutoSize = true;
            this.numberLengthLabel.Location = new System.Drawing.Point(5, 77);
            this.numberLengthLabel.Name = "numberLengthLabel";
            this.numberLengthLabel.Size = new System.Drawing.Size(81, 13);
            this.numberLengthLabel.TabIndex = 7;
            this.numberLengthLabel.Text = "Длина номера";
            // 
            // numberRepeatsNumericUpDown
            // 
            this.numberRepeatsNumericUpDown.Location = new System.Drawing.Point(142, 98);
            this.numberRepeatsNumericUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numberRepeatsNumericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numberRepeatsNumericUpDown.Name = "numberRepeatsNumericUpDown";
            this.numberRepeatsNumericUpDown.Size = new System.Drawing.Size(32, 20);
            this.numberRepeatsNumericUpDown.TabIndex = 6;
            this.numberRepeatsNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numberLengthNumericUpDown
            // 
            this.numberLengthNumericUpDown.Location = new System.Drawing.Point(142, 75);
            this.numberLengthNumericUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numberLengthNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberLengthNumericUpDown.Name = "numberLengthNumericUpDown";
            this.numberLengthNumericUpDown.Size = new System.Drawing.Size(32, 20);
            this.numberLengthNumericUpDown.TabIndex = 5;
            this.numberLengthNumericUpDown.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // authGroupBox
            // 
            this.authGroupBox.Controls.Add(this.succesLabelVK);
            this.authGroupBox.Controls.Add(this.failLabelVK);
            this.authGroupBox.Controls.Add(this.logoutButton);
            this.authGroupBox.Controls.Add(this.VKAuthButton);
            this.authGroupBox.Location = new System.Drawing.Point(3, 0);
            this.authGroupBox.Name = "authGroupBox";
            this.authGroupBox.Size = new System.Drawing.Size(200, 90);
            this.authGroupBox.TabIndex = 5;
            this.authGroupBox.TabStop = false;
            this.authGroupBox.Text = "Авторизация";
            // 
            // succesLabelVK
            // 
            this.succesLabelVK.Image = ((System.Drawing.Image)(resources.GetObject("succesLabelVK.Image")));
            this.succesLabelVK.Location = new System.Drawing.Point(165, 19);
            this.succesLabelVK.Name = "succesLabelVK";
            this.succesLabelVK.Size = new System.Drawing.Size(29, 32);
            this.succesLabelVK.TabIndex = 7;
            // 
            // failLabelVK
            // 
            this.failLabelVK.Image = ((System.Drawing.Image)(resources.GetObject("failLabelVK.Image")));
            this.failLabelVK.Location = new System.Drawing.Point(165, 19);
            this.failLabelVK.Name = "failLabelVK";
            this.failLabelVK.Size = new System.Drawing.Size(29, 32);
            this.failLabelVK.TabIndex = 4;
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(6, 57);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(153, 20);
            this.logoutButton.TabIndex = 2;
            this.logoutButton.Text = "Выход";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // VKAuthButton
            // 
            this.VKAuthButton.Location = new System.Drawing.Point(6, 19);
            this.VKAuthButton.Name = "VKAuthButton";
            this.VKAuthButton.Size = new System.Drawing.Size(153, 32);
            this.VKAuthButton.TabIndex = 0;
            this.VKAuthButton.Text = "VK";
            this.VKAuthButton.UseVisualStyleBackColor = true;
            this.VKAuthButton.Click += new System.EventHandler(this.VKAuthButton_Click);
            // 
            // vkParamsGroupBox
            // 
            this.vkParamsGroupBox.Controls.Add(this.kazahstanCheckBox);
            this.vkParamsGroupBox.Controls.Add(this.belarusCheckBox);
            this.vkParamsGroupBox.Controls.Add(this.label8);
            this.vkParamsGroupBox.Controls.Add(this.russiaCheckBox);
            this.vkParamsGroupBox.Controls.Add(this.label7);
            this.vkParamsGroupBox.Controls.Add(this.ukraineCheckBox);
            this.vkParamsGroupBox.Controls.Add(this.groupIdTextBox);
            this.vkParamsGroupBox.Controls.Add(this.label6);
            this.vkParamsGroupBox.Controls.Add(this.label5);
            this.vkParamsGroupBox.Controls.Add(this.label4);
            this.vkParamsGroupBox.Controls.Add(this.maxAgeNumericUpDown);
            this.vkParamsGroupBox.Controls.Add(this.minAgeNumericUpDown);
            this.vkParamsGroupBox.Controls.Add(this.femaleGenderCheckBox);
            this.vkParamsGroupBox.Controls.Add(this.maleGenderCheckBox);
            this.vkParamsGroupBox.Location = new System.Drawing.Point(3, 96);
            this.vkParamsGroupBox.Name = "vkParamsGroupBox";
            this.vkParamsGroupBox.Size = new System.Drawing.Size(200, 140);
            this.vkParamsGroupBox.TabIndex = 6;
            this.vkParamsGroupBox.TabStop = false;
            this.vkParamsGroupBox.Text = "Параметры для VK";
            // 
            // kazahstanCheckBox
            // 
            this.kazahstanCheckBox.AutoSize = true;
            this.kazahstanCheckBox.Location = new System.Drawing.Point(6, 116);
            this.kazahstanCheckBox.Name = "kazahstanCheckBox";
            this.kazahstanCheckBox.Size = new System.Drawing.Size(79, 17);
            this.kazahstanCheckBox.TabIndex = 14;
            this.kazahstanCheckBox.Text = "Казахстан";
            this.kazahstanCheckBox.UseVisualStyleBackColor = true;
            // 
            // belarusCheckBox
            // 
            this.belarusCheckBox.AutoSize = true;
            this.belarusCheckBox.Location = new System.Drawing.Point(6, 99);
            this.belarusCheckBox.Name = "belarusCheckBox";
            this.belarusCheckBox.Size = new System.Drawing.Size(74, 17);
            this.belarusCheckBox.TabIndex = 13;
            this.belarusCheckBox.Text = "Беларусь";
            this.belarusCheckBox.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(124, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "от";
            // 
            // russiaCheckBox
            // 
            this.russiaCheckBox.AutoSize = true;
            this.russiaCheckBox.Location = new System.Drawing.Point(6, 66);
            this.russiaCheckBox.Name = "russiaCheckBox";
            this.russiaCheckBox.Size = new System.Drawing.Size(63, 17);
            this.russiaCheckBox.TabIndex = 11;
            this.russiaCheckBox.Text = "Россия";
            this.russiaCheckBox.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "ID:";
            // 
            // ukraineCheckBox
            // 
            this.ukraineCheckBox.AutoSize = true;
            this.ukraineCheckBox.Location = new System.Drawing.Point(6, 82);
            this.ukraineCheckBox.Name = "ukraineCheckBox";
            this.ukraineCheckBox.Size = new System.Drawing.Size(70, 17);
            this.ukraineCheckBox.TabIndex = 12;
            this.ukraineCheckBox.Text = "Украина";
            this.ukraineCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupIdTextBox
            // 
            this.groupIdTextBox.Location = new System.Drawing.Point(30, 19);
            this.groupIdTextBox.MaxLength = 100;
            this.groupIdTextBox.Name = "groupIdTextBox";
            this.groupIdTextBox.Size = new System.Drawing.Size(163, 20);
            this.groupIdTextBox.TabIndex = 7;
            this.groupIdTextBox.TextChanged += new System.EventHandler(this.groupIdTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Пол:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "до";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Возраст";
            // 
            // maxAgeNumericUpDown
            // 
            this.maxAgeNumericUpDown.Location = new System.Drawing.Point(148, 111);
            this.maxAgeNumericUpDown.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.maxAgeNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxAgeNumericUpDown.Name = "maxAgeNumericUpDown";
            this.maxAgeNumericUpDown.Size = new System.Drawing.Size(45, 20);
            this.maxAgeNumericUpDown.TabIndex = 3;
            this.maxAgeNumericUpDown.Value = new decimal(new int[] {
            99,
            0,
            0,
            0});
            // 
            // minAgeNumericUpDown
            // 
            this.minAgeNumericUpDown.Location = new System.Drawing.Point(148, 90);
            this.minAgeNumericUpDown.Maximum = new decimal(new int[] {
            98,
            0,
            0,
            0});
            this.minAgeNumericUpDown.Name = "minAgeNumericUpDown";
            this.minAgeNumericUpDown.Size = new System.Drawing.Size(45, 20);
            this.minAgeNumericUpDown.TabIndex = 2;
            // 
            // femaleGenderCheckBox
            // 
            this.femaleGenderCheckBox.AutoSize = true;
            this.femaleGenderCheckBox.Location = new System.Drawing.Point(75, 43);
            this.femaleGenderCheckBox.Name = "femaleGenderCheckBox";
            this.femaleGenderCheckBox.Size = new System.Drawing.Size(37, 17);
            this.femaleGenderCheckBox.TabIndex = 1;
            this.femaleGenderCheckBox.Text = "Ж";
            this.femaleGenderCheckBox.UseVisualStyleBackColor = true;
            // 
            // maleGenderCheckBox
            // 
            this.maleGenderCheckBox.AutoSize = true;
            this.maleGenderCheckBox.Location = new System.Drawing.Point(34, 43);
            this.maleGenderCheckBox.Name = "maleGenderCheckBox";
            this.maleGenderCheckBox.Size = new System.Drawing.Size(35, 17);
            this.maleGenderCheckBox.TabIndex = 0;
            this.maleGenderCheckBox.Text = "М";
            this.maleGenderCheckBox.UseVisualStyleBackColor = true;
            // 
            // stripPhonesRadioButton
            // 
            this.stripPhonesRadioButton.AutoSize = true;
            this.stripPhonesRadioButton.Checked = true;
            this.stripPhonesRadioButton.Location = new System.Drawing.Point(11, 12);
            this.stripPhonesRadioButton.Name = "stripPhonesRadioButton";
            this.stripPhonesRadioButton.Size = new System.Drawing.Size(130, 17);
            this.stripPhonesRadioButton.TabIndex = 8;
            this.stripPhonesRadioButton.TabStop = true;
            this.stripPhonesRadioButton.Text = "Стрипинг телефонов";
            this.stripPhonesRadioButton.UseVisualStyleBackColor = true;
            this.stripPhonesRadioButton.CheckedChanged += new System.EventHandler(this.stripPhonesRadioButton_CheckedChanged);
            // 
            // parseRadioButton
            // 
            this.parseRadioButton.AutoSize = true;
            this.parseRadioButton.Location = new System.Drawing.Point(194, 12);
            this.parseRadioButton.Name = "parseRadioButton";
            this.parseRadioButton.Size = new System.Drawing.Size(133, 17);
            this.parseRadioButton.TabIndex = 9;
            this.parseRadioButton.Text = "Парсинг из соцсетей";
            this.parseRadioButton.UseVisualStyleBackColor = true;
            this.parseRadioButton.CheckedChanged += new System.EventHandler(this.parseRadioButton_CheckedChanged);
            // 
            // socialPanel
            // 
            this.socialPanel.Controls.Add(this.cancelParseButton);
            this.socialPanel.Controls.Add(this.membersCountLabel);
            this.socialPanel.Controls.Add(this.membersLabel);
            this.socialPanel.Controls.Add(this.groupNameTextBox);
            this.socialPanel.Controls.Add(this.groupImageBox);
            this.socialPanel.Controls.Add(this.StartParseButton);
            this.socialPanel.Controls.Add(this.authGroupBox);
            this.socialPanel.Controls.Add(this.vkParamsGroupBox);
            this.socialPanel.Enabled = false;
            this.socialPanel.Location = new System.Drawing.Point(191, 28);
            this.socialPanel.Name = "socialPanel";
            this.socialPanel.Size = new System.Drawing.Size(428, 236);
            this.socialPanel.TabIndex = 2;
            // 
            // cancelParseButton
            // 
            this.cancelParseButton.Location = new System.Drawing.Point(210, 44);
            this.cancelParseButton.Name = "cancelParseButton";
            this.cancelParseButton.Size = new System.Drawing.Size(215, 21);
            this.cancelParseButton.TabIndex = 13;
            this.cancelParseButton.Text = "Отмена";
            this.cancelParseButton.UseVisualStyleBackColor = true;
            this.cancelParseButton.Click += new System.EventHandler(this.cancelParseButton_Click);
            // 
            // membersCountLabel
            // 
            this.membersCountLabel.Location = new System.Drawing.Point(343, 107);
            this.membersCountLabel.Name = "membersCountLabel";
            this.membersCountLabel.Size = new System.Drawing.Size(82, 14);
            this.membersCountLabel.TabIndex = 12;
            // 
            // membersLabel
            // 
            this.membersLabel.AutoSize = true;
            this.membersLabel.Location = new System.Drawing.Point(266, 107);
            this.membersLabel.Name = "membersLabel";
            this.membersLabel.Size = new System.Drawing.Size(70, 13);
            this.membersLabel.TabIndex = 11;
            this.membersLabel.Text = "Участников:";
            this.membersLabel.Visible = false;
            // 
            // groupNameTextBox
            // 
            this.groupNameTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.groupNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.groupNameTextBox.Location = new System.Drawing.Point(266, 71);
            this.groupNameTextBox.Multiline = true;
            this.groupNameTextBox.Name = "groupNameTextBox";
            this.groupNameTextBox.ReadOnly = true;
            this.groupNameTextBox.Size = new System.Drawing.Size(159, 24);
            this.groupNameTextBox.TabIndex = 10;
            // 
            // groupImageBox
            // 
            this.groupImageBox.Location = new System.Drawing.Point(209, 71);
            this.groupImageBox.Name = "groupImageBox";
            this.groupImageBox.Size = new System.Drawing.Size(50, 50);
            this.groupImageBox.TabIndex = 9;
            this.groupImageBox.TabStop = false;
            // 
            // StartParseButton
            // 
            this.StartParseButton.Location = new System.Drawing.Point(209, 4);
            this.StartParseButton.Name = "StartParseButton";
            this.StartParseButton.Size = new System.Drawing.Size(216, 36);
            this.StartParseButton.TabIndex = 7;
            this.StartParseButton.Text = "Старт";
            this.StartParseButton.UseVisualStyleBackColor = true;
            this.StartParseButton.Click += new System.EventHandler(this.StartParseButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "(none)";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Items.AddRange(new object[] {
            "Россия",
            "Украина",
            "Беларусь",
            "Казахстан"});
            this.comboBox1.Location = new System.Drawing.Point(53, 122);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Гео";
            // 
            // SpaHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(631, 288);
            this.Controls.Add(this.socialPanel);
            this.Controls.Add(this.parseRadioButton);
            this.Controls.Add(this.stripPhonesRadioButton);
            this.Controls.Add(this.phoneStripingPanel);
            this.Controls.Add(this.statusStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SpaHelper";
            this.Text = "CPA Helper";
            this.Load += new System.EventHandler(this.SPAHelper_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.phoneStripingPanel.ResumeLayout(false);
            this.phoneStripingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberRepeatsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberLengthNumericUpDown)).EndInit();
            this.authGroupBox.ResumeLayout(false);
            this.vkParamsGroupBox.ResumeLayout(false);
            this.vkParamsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxAgeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minAgeNumericUpDown)).EndInit();
            this.socialPanel.ResumeLayout(false);
            this.socialPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.GroupBox phoneStripingPanel;
        private System.Windows.Forms.Label numberRepeatsLabel;
        private System.Windows.Forms.Label numberLengthLabel;
        private System.Windows.Forms.NumericUpDown numberRepeatsNumericUpDown;
        private System.Windows.Forms.NumericUpDown numberLengthNumericUpDown;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Label savedNumbersLabel;
        private System.Windows.Forms.Label deletedNumbersLabel;
        private System.Windows.Forms.Label totalNumbersLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox authGroupBox;
        private System.Windows.Forms.Button VKAuthButton;
        private System.Windows.Forms.GroupBox vkParamsGroupBox;
        private System.Windows.Forms.Button startStripButton;
        private System.Windows.Forms.RadioButton stripPhonesRadioButton;
        private System.Windows.Forms.RadioButton parseRadioButton;
        private System.Windows.Forms.Panel socialPanel;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label failLabelVK;
        private System.Windows.Forms.Label succesLabelVK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown maxAgeNumericUpDown;
        private System.Windows.Forms.NumericUpDown minAgeNumericUpDown;
        private System.Windows.Forms.CheckBox femaleGenderCheckBox;
        private System.Windows.Forms.CheckBox maleGenderCheckBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox groupIdTextBox;
        private System.Windows.Forms.Button StartParseButton;
        private System.Windows.Forms.TextBox groupNameTextBox;
        private System.Windows.Forms.PictureBox groupImageBox;
        private System.Windows.Forms.Label membersCountLabel;
        private System.Windows.Forms.Label membersLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox kazahstanCheckBox;
        private System.Windows.Forms.CheckBox belarusCheckBox;
        private System.Windows.Forms.CheckBox ukraineCheckBox;
        private System.Windows.Forms.CheckBox russiaCheckBox;
        private System.Windows.Forms.ToolStripProgressBar progressBar1;
        private System.Windows.Forms.Button cancelParseButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

