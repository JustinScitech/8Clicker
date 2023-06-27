using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clicker
{

    public partial class Form1 : Form
    {
        //local vars 
        int min;
        int max;
        int randVal;
        Random rand = new Random();

        //DLLs required for click access

        [DllImport("User32.Dll", EntryPoint = "PostMessageA")]
        private static extern bool PostMessage(IntPtr hWnd, uint msg, int wParam, int lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("User32.dll")]

        //Main code

        private static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);

        public Form1()
        {
            InitializeComponent();
        }

        private void siticoneTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void siticoneTrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            CPSVAL.Text = TrackerBar.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PowerButton.Text.Contains("ON"))
            {
                PowerButton.Text = "OFF";
                Autoclicker.Start();
            }
            else if (PowerButton.Text.Contains("OFF"))
            {
                PowerButton.Text = "ON";
                Autoclicker.Stop();
            }
        }

        private void Random_Tick(object sender, EventArgs e)
        {
            if (PowerButton.Text.Contains("OFF"))
            {
                min = Math.Max(1, TrackerBar.Value - 6); // Enforces min greater than one
                max = TrackerBar.Value + 6; // Enforces max greater than one
                randVal = rand.Next(min, max);
            }
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (randVal > 0) // Added this to avoid division by zero errors
                {
                    Autoclicker.Interval = 1000 / randVal;
                    CPSVAL.Text = randVal.ToString();
                }
            }
            catch
            {
                Console.WriteLine(e);
            }

            if (PowerButton.Text.Contains("OFF") && MouseButtons == MouseButtons.Left)
            {
                IntPtr hWnd = GetForegroundWindow(); // Gets current window, but can be replaced with specific control or window
                const int WM_LBUTTONDOWN = 0x0201;
                const int WM_LBUTTONUP = 0x0202;
                PostMessage(hWnd, WM_LBUTTONDOWN, 0, 0);
                await Task.Delay(30);
                PostMessage(hWnd, WM_LBUTTONUP, 0, 0); // This is the message for mouse left button up    
            }
        }

        private void CPSVAL_Click(object sender, EventArgs e)
        {

        }
    }
}