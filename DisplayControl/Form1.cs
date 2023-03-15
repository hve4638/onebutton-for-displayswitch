using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Diagnostics;


namespace DisplayControl
{
    public partial class DisplayControlButton : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public int WM_SYSCOMMAND = 0x0112;
        public int SC_MONITORPOWER = 0xF170;

        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;

        bool buttonEnabled = false;

        public DisplayControlButton()
        {
            InitializeComponent();
        }

        private void SetFormPosition()
        {
            var screens = Screen.AllScreens;

            if (screens.Length > 1)
            {
                var secondScreen = screens[1];


                this.StartPosition = FormStartPosition.Manual;
                this.Left = secondScreen.WorkingArea.Right - this.Width;
                this.Top = secondScreen.WorkingArea.Bottom - this.Height;
            }
        }

        private void ToggleButton_Click(object sender, EventArgs e)
        {
            var me = (e as MouseEventArgs)!;

            if (me.Button == MouseButtons.Left)
            {
                buttonEnabled = !buttonEnabled;
                ToggleButton.Image = buttonEnabled ? Properties.Resources.on : Properties.Resources.off;

                if (buttonEnabled) OnToggleEvent.Enable();
                else OnToggleEvent.Disable();

                SetFormPosition();
            }
            else if (me.Button == MouseButtons.Middle)
            {
                Close();
            }
        }

        private void DragButton_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void DisplayControlButton_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            BackColor = Color.Blue;
            TransparencyKey = Color.Blue;

            TopMost = true;
            //Visible = false;
            ShowInTaskbar = false;

            SetFormPosition();
        }

        private void ToggleButton_MouseMove(object sender, MouseEventArgs e)
        {
        }
    }
}