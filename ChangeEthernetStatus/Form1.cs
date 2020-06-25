using System;
using System.Net.NetworkInformation;
using MetroFramework.Forms;
using System.Windows.Forms;
using System.Security.Principal;

namespace ChangeEthernetStatus
{
    public partial class Form1 : MetroForm
    {
        public static int count = 99; //счётчик количества сетевых адаптеров
        public static string[] nameEthernetMASS = new string[count]; //массив сетевых адаптеров
        public static string[] nameEthernetLabel = new string[count]; //массив для label
        public static int backup_count = 99;
        public static string[] backup = new string[count]; //создание backup list

        #region FormInitialize
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        #region Получение списка сетевых адаптеров при запуске формы и проверка на запуск от админа
        private void Form1_Load(object sender, EventArgs e)
        {
            //проверка админа
            bool isElevated;
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            isElevated = principal.IsInRole(WindowsBuiltInRole.Administrator);
            if (isElevated == false)
            {
                MessageBox.Show("Запустите данную программу от имени администратора", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            };

            //обновление листа
            UpdateNetwork();
            countLabel.Text = "Найдено " + count + " сетевых подключений";
            //вывод списка сетевых адаптеров
            for (int i = 0; i < count; i++)
            {
                ethernetNameTextBox.Text += nameEthernetLabel[i].ToString() + "\r\n";
            }

            //создание backup
            foreach (NetworkInterface net in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (net.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 || net.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                {
                    backupComboBox.Text += net.Name.ToString() + "\r\n";
                }
            }
        }
        #endregion

        #region Обновление списка сетевых адаптеров
        public static void UpdateNetwork()
        {
            count = 0;
            foreach (NetworkInterface net in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (net.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 || net.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                {
                    nameEthernetMASS[count] = net.Name.ToString();
                    nameEthernetLabel[count] = net.Name.ToString();
                    //если выключен
                    if (net.OperationalStatus.ToString() == "Up")
                    {
                        nameEthernetLabel[count] += " (ON)";
                    }
                    //если выключен
                    if (net.OperationalStatus.ToString() == "Down")
                    {
                        nameEthernetLabel[count] += " (OFF)";
                    }
                    count++;
                }
            }
        }
        #endregion

        #region Enable
        private void enableButton_Click(object sender, EventArgs e)
        {
            MainTimer.Enabled = true;
            MainTimer.Start();
            enableButton.Enabled = false;
            disableButton.Enabled = false;
            UpdateList.Enabled = false;
            exitButton.Enabled = false;
            onEthernetDownButton.Enabled = false;
            onEthernetDownTextBox.Enabled = false;
            offEthernetDownButton.Enabled = false;
            offEthernetDownTextBox.Enabled = false;

            for (int i = 0; i < count; i++)
            {
                Enable(nameEthernetMASS[i].ToString());
            }
        }

        static void Enable(string interfaceName)
        {
            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo("netsh", "interface set interface name=" + interfaceName + " admin=ENABLE");
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo = psi;
            p.Start();
        }
        #endregion

        #region Disable
        private void disableButton_Click(object sender, EventArgs e)
        {
            MainTimer.Enabled = true;
            MainTimer.Start();
            enableButton.Enabled = false;
            disableButton.Enabled = false;
            UpdateList.Enabled = false;
            exitButton.Enabled = false;
            onEthernetDownButton.Enabled = false;
            onEthernetDownTextBox.Enabled = false;
            offEthernetDownButton.Enabled = false;
            offEthernetDownTextBox.Enabled = false;

            for (int i = 0; i < count; i++)
            {
                Disable(nameEthernetMASS[i].ToString());
            }
        }

        static void Disable(string interfaceName)
        {
            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo("netsh", "interface set interface name=" + interfaceName + " admin=DISABLE");
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo = psi;
            p.Start();
        }
        #endregion

        #region UpdateList
        private void UpdateList_Click(object sender, EventArgs e)
        {
            ethernetNameTextBox.Clear();
            UpdateNetwork();
            countLabel.Text = "Найдено " + count + " сетевых подключений";
            //вывод списка сетевых адаптеров
            for (int i = 0; i < count; i++)
            {
                ethernetNameTextBox.Text += nameEthernetLabel[i].ToString() + "\r\n";
            }
        }
        #endregion

        #region ExitButton
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region После 5 секунд таймера включение кнопок
        private void MainTimer_Tick(object sender, EventArgs e)
        {
            enableButton.Enabled = true;
            disableButton.Enabled = true;
            UpdateList.Enabled = true;
            exitButton.Enabled = true;
            onEthernetDownButton.Enabled = true;
            onEthernetDownTextBox.Enabled = true;
            offEthernetDownButton.Enabled = true;
            offEthernetDownTextBox.Enabled = true;

            onEthernetDownTextBox.Clear();
            offEthernetDownTextBox.Clear();

            UpdateList.PerformClick();

            MainTimer.Stop();
        }
        #endregion

        #region Кнопка "Включить интернет, указанный ниже"
        private void onEthernetDownButton_Click(object sender, EventArgs e)
        {
            if (onEthernetDownTextBox.Text.Length == 0)
            {
                MessageBox.Show("Вы ничего не ввели в поле", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MainTimer.Enabled = true;
                MainTimer.Start();
                enableButton.Enabled = false;
                disableButton.Enabled = false;
                UpdateList.Enabled = false;
                exitButton.Enabled = false;
                onEthernetDownButton.Enabled = false;
                onEthernetDownTextBox.Enabled = false;
                offEthernetDownButton.Enabled = false;
                offEthernetDownTextBox.Enabled = false;

                for (int i = 0; i < count; i++)
                {
                    Enable(onEthernetDownTextBox.Text);
                }
            }
        }
        #endregion

        #region Кнопка "Выключить интернет, указанный ниже"
        private void offEthernetDownButton_Click(object sender, EventArgs e)
        {
            if (offEthernetDownButton.Text.Length == 0)
            {
                MessageBox.Show("Вы ничего не ввели в поле", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MainTimer.Enabled = true;
                MainTimer.Start();
                enableButton.Enabled = false;
                disableButton.Enabled = false;
                UpdateList.Enabled = false;
                exitButton.Enabled = false;
                onEthernetDownButton.Enabled = false;
                onEthernetDownTextBox.Enabled = false;
                offEthernetDownButton.Enabled = false;
                offEthernetDownTextBox.Enabled = false;

                for (int i = 0; i < count; i++)
                {
                    Disable(offEthernetDownTextBox.Text);
                }
            }
        }
        #endregion

        #region Всегда поверх других окон
        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox1.Checked == true)
                TopMost = true;
            else
                TopMost = false;
        }
        #endregion
    }
}
