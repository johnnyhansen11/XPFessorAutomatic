using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FessorAutomatic
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        int i = 1;
        int totalxp = 0;
        int retries = 0;
        int questions = 0;
        int speedone = 500;
        int speedtwo = 450;
        int speedthr = 200;

        public Form1()
        {
            InitializeComponent();
        }
            
        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.matematikfessor.dk/ext/unilogin/login/?r=https%3A%2F%2Fwww.matematikfessor.dk");
            MessageBox.Show("1.Open the program." + "\n" + "2.Login" + "\n" + "3.Click Test dig selv »." + "\n" + "4.Choose 5 questions." + "\n" + "5.Choose 7th grade." + "\n" + "6.Search for gange med 0, and click on the first result." + "\n" + "7.Click Start(ON THE WEBSITE)." + "\n" + "8.Click Start(INSIDE THE PROGRAM)" + "\n" + "\n" + "DONT MOVE THE PROGRAM " + "\n" + "TO ANOTHER LOCATION ON THE SCREEN!" + "\n" + "DOING SO WILL BREAK THE PROGRAM." + "\n" + "(IF YOU ALREADY DID, CLOSE AND OPEN THE PROGRAM AGAIN)." + "\n" + "\n" + "TO STOP / CLOSE THE PROGRAM, USE ALT + F4." + "\n" + "YOU WILL NOT BE ABLE TO USE THE MOUSE" + "\n" + "WHILE USING THIS PROGRAM.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (i)
            {
                case 1:
                    Cursor.Position = new Point(272, 327);
                    mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                    timer1.Interval = speedthr;
                    break;
                case 2:
                    SendKeys.Send("0{ENTER}");
                    questions++;
                    label3.Text = "Questions answered: " + questions.ToString();
                    break;
                case 3:
                    SendKeys.Send("0{ENTER}");
                    questions++;
                    label3.Text = "Questions answered: " + questions.ToString();
                    break;
                case 4:
                    SendKeys.Send("0{ENTER}");
                    questions++;
                    label3.Text = "Questions answered: " + questions.ToString();
                    break;
                case 5:
                    SendKeys.Send("0{ENTER}");
                    questions++;
                    label3.Text = "Questions answered: " + questions.ToString();
                    break;
                case 6:
                    SendKeys.Send("0{ENTER}");
                    questions++;
                    label3.Text = "Questions answered: " + questions.ToString();
                    break;
                case 7:
                    SendKeys.Send("{PGUP}");
                    Cursor.Position = new Point(875, 167);
                    mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                    timer1.Interval = speedone;
                    break;
                case 8:
                    Cursor.Position = new Point(535, 375);
                    mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                    Cursor.Position = new Point(535, 395);
                    mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                    timer1.Interval = speedtwo;
                    totalxp += 15;
                    retries += 1;
                    label1.Text = "Xp earned: " + totalxp.ToString();
                    label2.Text = "Tests made: " + retries.ToString();
                    break;
                case 9:
                    if (retries % 10 == 0)
                    {
                        webBrowser1.Refresh();
                        timer1.Interval = 2500;
                    }
                    break;
                case 10:
                    SendKeys.Send("{PGDN}{PGDN}{PGDN}");
                    timer1.Interval = speedtwo;
                    break;
                case 11:
                    Cursor.Position = new Point(343, 502);
                    mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                    timer1.Interval = speedone;
                    break;
                case 12:
                    Cursor.Position = new Point(616, 360);
                    mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                    timer1.Interval = speedone;
                    i = 0;
                    break;
                default:
                    break;
            }
            i++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                speedone = Convert.ToInt32(textBox1.Text);
                speedtwo = Convert.ToInt32(textBox2.Text);
                speedthr = Convert.ToInt32(textBox3.Text);
            }
            catch
            {
                MessageBox.Show("Only number allowed");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1.Open the program." + "\n" + "2.Login" + "\n" + "3.Click Test dig selv »." + "\n" + "4.Choose 5 questions." + "\n" + "5.Choose 7th grade." + "\n" + "6.Search for gange med 0, and click on the first result." + "\n" + "7.Click Start(ON THE WEBSITE)." + "\n" + "8.Click Start(INSIDE THE PROGRAM)" + "\n" + "\n" + "DONT MOVE THE PROGRAM " + "\n" + "TO ANOTHER LOCATION ON THE SCREEN!" + "\n" + "DOING SO WILL BREAK THE PROGRAM." + "\n" + "(IF YOU ALREADY DID, CLOSE AND OPEN THE PROGRAM AGAIN)." + "\n" + "\n" + "TO STOP / CLOSE THE PROGRAM, USE ALT + F4." + "\n" + "YOU WILL NOT BE ABLE TO USE THE MOUSE" + "\n" + "WHILE USING THIS PROGRAM.");
        }
    }
}
