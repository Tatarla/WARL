using NLog;
using System;
using System.Configuration;
using System.Diagnostics;
using System.Net.Http;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Launcher
{
    public partial class ApocLauncher : Form
    {
        public bool LaunchLocalServer { get; }
        public bool AllowMYPPatch { get; }
        public bool AllowServerPatch { get; }
        public bool AllowWarClientLaunch { get; }
        public static ApocLauncher Acc;

        public static string LocalServerIP = "147.45.146.150";
        public static string TestServerIP = "147.45.146.150";
        public static int LocalServerPort = 8000;
        public static int TestServerPort = 8000;
        private static HttpClient client = new HttpClient();
        private Patcher patcher;

        private static Logger _logger = LogManager.GetCurrentClassLogger();

        public ApocLauncher()
        {
            // Read optional app settings (they may not exist in the app.config file)
            AllowWarClientLaunch = SafeReadAppSettings("AutoLaunch", true);
            AllowMYPPatch = SafeReadAppSettings("PatchMYP", true);
            AllowServerPatch = SafeReadAppSettings("PatchExe", true);
            LaunchLocalServer = SafeReadAppSettings("LaunchLocal", false);

            InitializeComponent();
            Acc = this;
        }

        private bool SafeReadAppSettings(string keyName, bool defaultValue)
        {
            var s = System.Configuration.ConfigurationManager.AppSettings[keyName];
            if (!String.IsNullOrEmpty(s))
            {
                // Key exists
                if (s == "false")
                    return false;
                if (s == "true")
                    return true;
            }
            else
            {
                // Key doesn't exist
                return defaultValue;
            }
            return defaultValue;
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            var attrs = assembly.GetCustomAttributes<AssemblyMetadataAttribute>();
            this.lblVersion.Text = fvi.FileVersion;
            //this.lblVersion.Text = $"{fvi.FileVersion} ({attrs.Single(x => x.Key == "GitHash").Value})";

            this.lblDownloading.Visible = false;
            if (this.AllowMYPPatch)
            {
                _logger.Debug($"Calling Patcher Server on { System.Configuration.ConfigurationManager.AppSettings["ServerPatchIPAddress"]}:{ System.Configuration.ConfigurationManager.AppSettings["ServerPatchPort"]}");
                patcher = new Patcher(_logger,
                    $"{System.Configuration.ConfigurationManager.AppSettings["ServerPatchIPAddress"]}:{System.Configuration.ConfigurationManager.AppSettings["ServerPatchPort"]}");

                this.lblDownloading.Visible = true;

                var patchDirectory = System.Configuration.ConfigurationManager.AppSettings["PatchDirectory"];

                Thread thread = new Thread(() => patcher.Patch(patchDirectory).Wait()) { IsBackground = true };
                thread.Start();
            }

            this.T_username.Text = System.Configuration.ConfigurationManager.AppSettings["LastUserCode"];
        }

        private void Disconnect(object sender, FormClosedEventArgs e)
        {
            Client.Close();
        }

        //private void B_start_Click(object sender, EventArgs e)
        //{
        //    Client.Connect(LocalServerIP, LocalServerPort);

        //    lblConnection.Text = $@"Connecting to : {LocalServerIP}:{LocalServerPort}";

        //    string userCode = T_username.Text.ToLower();
        //    string userPassword = T_password.Text.ToLower();

        //    Client.User = userCode;

        //    string encryptedPassword = ConvertSHA256(userCode + ":" + userPassword);

        //    _logger.Info($@"Connecting to : {LocalServerIP}:{LocalServerPort} as {userCode} [{encryptedPassword}]");
        //    _logger.Info($"Sending CL_START to {LocalServerIP}:{LocalServerPort}");

        //    PacketOut Out = new PacketOut((byte)Opcodes.CL_START);
        //    Out.WriteString(userCode);
        //    Out.WriteString(encryptedPassword);

        //    Client.SendTCP(Out);
        //    //B_start.Enabled = false;
        //}

        public static string ConvertSHA256(string value)
        {
            SHA256 sha = SHA256.Create();
            byte[] data = sha.ComputeHash(Encoding.Default.GetBytes(value));
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sb.Append(data[i].ToString("x2"));
            }
            return sb.ToString();
        }

        public void ReceiveStart()
        {
            //B_start.Enabled = true;
        }

        public void Print(string Message)
        {
        }

        private void bnConnectToServer_Click(object sender, EventArgs e)
        {
            Client.Connect(TestServerIP, TestServerPort);
            lblConnection.Text = $@"Подключаюсь к: {TestServerIP}:{TestServerPort}";

            string userCode = T_username.Text.ToLower();
            string userPassword = T_password.Text.ToLower();

            Client.User = userCode;

            string encryptedPassword = ConvertSHA256(userCode + ":" + userPassword);

            _logger.Info($@"Подключаюсь к: {TestServerIP}:{TestServerPort} as {userCode} [{encryptedPassword}]");

            _logger.Info($"Стартуем в {TestServerIP}:{TestServerPort}");
            PacketOut Out = new PacketOut((byte)Opcodes.CL_START);
            Out.WriteString(userCode);
            Out.WriteString(encryptedPassword);

            Client.SendTCP(Out);

            Configuration configuration = System.Configuration.ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            if (configuration.AppSettings.Settings["LastUSerCode"] == null)
            {
                configuration.AppSettings.Settings.Add("LastUserCode", T_username.Text);
            }
            else
            {
                configuration.AppSettings.Settings["LastUserCode"].Value = T_username.Text;
            }
            configuration.Save();

            System.Configuration.ConfigurationManager.RefreshSection("appSettings");
        }

        private void bnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Create new user account.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        public void sendUI(string msg)
        {
            if (lblConnection.InvokeRequired)
            {
                lblConnection.BeginInvoke(new Action(() =>
                {
                    sendUI(msg);
                }));
                return;
            }

            lblConnection.Text = msg;
        }

        private void bnConnectToLocal_Click(object sender, EventArgs e)
        {
            Client.Connect(LocalServerIP, LocalServerPort);
            lblConnection.Text = $@"Подключаюсь к: {LocalServerIP}:{LocalServerPort}";

            string userCode = T_username.Text.ToLower();
            string userPassword = T_password.Text.ToLower();

            Client.User = userCode;

            string encryptedPassword = ConvertSHA256(userCode + ":" + userPassword);

            _logger.Info($@"Подключаюсь к: {LocalServerIP}:{LocalServerPort} as {userCode} [{encryptedPassword}]");

            _logger.Info($"Стартуем в {LocalServerIP}:{LocalServerPort}");
            PacketOut Out = new PacketOut((byte)Opcodes.CL_START);
            Out.WriteString(userCode);
            Out.WriteString(encryptedPassword);

            Client.SendTCP(Out);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.AllowMYPPatch)
            {
                if (patcher.CurrentState == Patcher.State.Downloading)
                {
                    bnConnectToServer.Enabled = false;

                    long percent = 0;
                    if (patcher.TotalDownloadSize > 0)
                        percent = (patcher.Downloaded * 100) / patcher.TotalDownloadSize;

                    lblDownloading.Text = $"Качаем {patcher.CurrentFile} ({percent}%)";
                }
                else if (patcher.CurrentState == Patcher.State.RequestManifest)
                {
                    bnConnectToServer.Enabled = false;
                    lblDownloading.Text = $"Проверяем наличие обновлений...";
                }
                else if (patcher.CurrentState == Patcher.State.ProcessManifest)
                {
                    bnConnectToServer.Enabled = false;
                    lblDownloading.Text = $"Обновляем...";
                }
                else if (patcher.CurrentState == Patcher.State.Done || patcher.CurrentState == Patcher.State.Error)
                {
                    bnConnectToServer.Enabled = true;
                    lblDownloading.Text = "";
                }
            }
        }

        private void T_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.bnConnectToServer_Click(this, new EventArgs());
            }
        }

        private void T_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.bnConnectToServer_Click(this, new EventArgs());
            }
        }

        private void bnMinimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/qyC7HanaUd");
        }
    }
}