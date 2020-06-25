namespace ChangeEthernetStatus
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.backupComboBox = new MetroFramework.Controls.MetroTextBox();
            this.offEthernetDownButton = new MetroFramework.Controls.MetroButton();
            this.onEthernetDownButton = new MetroFramework.Controls.MetroButton();
            this.offEthernetDownTextBox = new MetroFramework.Controls.MetroTextBox();
            this.onEthernetDownTextBox = new MetroFramework.Controls.MetroTextBox();
            this.exitButton = new MetroFramework.Controls.MetroButton();
            this.UpdateList = new MetroFramework.Controls.MetroButton();
            this.ethernetNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.countLabel = new MetroFramework.Controls.MetroLabel();
            this.disableButton = new MetroFramework.Controls.MetroButton();
            this.enableButton = new MetroFramework.Controls.MetroButton();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.Location = new System.Drawing.Point(437, 40);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(132, 17);
            this.metroCheckBox1.TabIndex = 29;
            this.metroCheckBox1.Text = "Поверх всех окон";
            this.metroCheckBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBox1.UseVisualStyleBackColor = true;
            this.metroCheckBox1.CheckedChanged += new System.EventHandler(this.metroCheckBox1_CheckedChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(294, 179);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(242, 20);
            this.metroLabel1.TabIndex = 28;
            this.metroLabel1.Text = "При первом сканировании найдено";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // backupComboBox
            // 
            this.backupComboBox.Enabled = false;
            this.backupComboBox.Location = new System.Drawing.Point(294, 202);
            this.backupComboBox.Multiline = true;
            this.backupComboBox.Name = "backupComboBox";
            this.backupComboBox.ReadOnly = true;
            this.backupComboBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.backupComboBox.Size = new System.Drawing.Size(277, 140);
            this.backupComboBox.TabIndex = 27;
            this.backupComboBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // offEthernetDownButton
            // 
            this.offEthernetDownButton.Location = new System.Drawing.Point(294, 121);
            this.offEthernetDownButton.Name = "offEthernetDownButton";
            this.offEthernetDownButton.Size = new System.Drawing.Size(277, 23);
            this.offEthernetDownButton.TabIndex = 26;
            this.offEthernetDownButton.Text = "Отключить подключение, указанное ниже";
            this.offEthernetDownButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.offEthernetDownButton.Click += new System.EventHandler(this.offEthernetDownButton_Click);
            // 
            // onEthernetDownButton
            // 
            this.onEthernetDownButton.Location = new System.Drawing.Point(294, 63);
            this.onEthernetDownButton.Name = "onEthernetDownButton";
            this.onEthernetDownButton.Size = new System.Drawing.Size(277, 23);
            this.onEthernetDownButton.TabIndex = 25;
            this.onEthernetDownButton.Text = "Восстановить подключение, указанное ниже";
            this.onEthernetDownButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.onEthernetDownButton.Click += new System.EventHandler(this.onEthernetDownButton_Click);
            // 
            // offEthernetDownTextBox
            // 
            this.offEthernetDownTextBox.Location = new System.Drawing.Point(294, 150);
            this.offEthernetDownTextBox.Name = "offEthernetDownTextBox";
            this.offEthernetDownTextBox.Size = new System.Drawing.Size(277, 23);
            this.offEthernetDownTextBox.TabIndex = 24;
            this.offEthernetDownTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // onEthernetDownTextBox
            // 
            this.onEthernetDownTextBox.Location = new System.Drawing.Point(294, 92);
            this.onEthernetDownTextBox.Name = "onEthernetDownTextBox";
            this.onEthernetDownTextBox.Size = new System.Drawing.Size(277, 23);
            this.onEthernetDownTextBox.TabIndex = 23;
            this.onEthernetDownTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(294, 348);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(277, 23);
            this.exitButton.TabIndex = 22;
            this.exitButton.Text = "Выйти из программы";
            this.exitButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // UpdateList
            // 
            this.UpdateList.Location = new System.Drawing.Point(23, 348);
            this.UpdateList.Name = "UpdateList";
            this.UpdateList.Size = new System.Drawing.Size(265, 23);
            this.UpdateList.TabIndex = 21;
            this.UpdateList.Text = "Обновить список";
            this.UpdateList.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.UpdateList.Click += new System.EventHandler(this.UpdateList_Click);
            // 
            // ethernetNameTextBox
            // 
            this.ethernetNameTextBox.Enabled = false;
            this.ethernetNameTextBox.Location = new System.Drawing.Point(23, 135);
            this.ethernetNameTextBox.Multiline = true;
            this.ethernetNameTextBox.Name = "ethernetNameTextBox";
            this.ethernetNameTextBox.ReadOnly = true;
            this.ethernetNameTextBox.Size = new System.Drawing.Size(265, 207);
            this.ethernetNameTextBox.TabIndex = 20;
            this.ethernetNameTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(23, 112);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(229, 20);
            this.countLabel.TabIndex = 19;
            this.countLabel.Text = "Найдено 0 сетевых подключений";
            this.countLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.countLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // disableButton
            // 
            this.disableButton.Location = new System.Drawing.Point(23, 86);
            this.disableButton.Name = "disableButton";
            this.disableButton.Size = new System.Drawing.Size(265, 23);
            this.disableButton.TabIndex = 18;
            this.disableButton.Text = "Отключить все сетевые подключения";
            this.disableButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.disableButton.Click += new System.EventHandler(this.disableButton_Click);
            // 
            // enableButton
            // 
            this.enableButton.Location = new System.Drawing.Point(23, 63);
            this.enableButton.Name = "enableButton";
            this.enableButton.Size = new System.Drawing.Size(265, 23);
            this.enableButton.TabIndex = 17;
            this.enableButton.Text = "Включить все сетевые подключения";
            this.enableButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.enableButton.Click += new System.EventHandler(this.enableButton_Click);
            // 
            // MainTimer
            // 
            this.MainTimer.Interval = 5000;
            this.MainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(592, 394);
            this.ControlBox = false;
            this.Controls.Add(this.metroCheckBox1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.backupComboBox);
            this.Controls.Add(this.offEthernetDownButton);
            this.Controls.Add(this.onEthernetDownButton);
            this.Controls.Add(this.offEthernetDownTextBox);
            this.Controls.Add(this.onEthernetDownTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.UpdateList);
            this.Controls.Add(this.ethernetNameTextBox);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.disableButton);
            this.Controls.Add(this.enableButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Ethernet changer";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        public MetroFramework.Controls.MetroLabel metroLabel1;
        public MetroFramework.Controls.MetroTextBox backupComboBox;
        private MetroFramework.Controls.MetroButton offEthernetDownButton;
        private MetroFramework.Controls.MetroButton onEthernetDownButton;
        private MetroFramework.Controls.MetroTextBox offEthernetDownTextBox;
        private MetroFramework.Controls.MetroTextBox onEthernetDownTextBox;
        private MetroFramework.Controls.MetroButton exitButton;
        private MetroFramework.Controls.MetroButton UpdateList;
        public MetroFramework.Controls.MetroTextBox ethernetNameTextBox;
        public MetroFramework.Controls.MetroLabel countLabel;
        private MetroFramework.Controls.MetroButton disableButton;
        private MetroFramework.Controls.MetroButton enableButton;
        private System.Windows.Forms.Timer MainTimer;
    }
}

