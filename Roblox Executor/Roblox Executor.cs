using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreDevs_API;

namespace Roblox_Executor
{
    public partial class Form1 : Form
    {
        ExploitAPI module = new ExploitAPI();
        public Form1()
        {
            InitializeComponent();
        }
        Point lastPoint;
        private void button3_Click(object sender, EventArgs e)
        {
            module.SendLuaScript(fastColoredTextBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            module.LaunchExploit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
