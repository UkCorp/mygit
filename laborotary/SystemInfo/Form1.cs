using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemInfo
{
    public partial class SystemInfo : Form
    {
        public SystemInfo()
        {
            InitializeComponent();
        }

        private void pictureBox_Minimazed_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            string BitOperating;
            string OSVersion;
            OSVersion = Environment.OSVersion.ToString();
            if (OSVersion == "Microsoft Windows NT 6.2.9200.0")
            {
                textBox1.Text = "Microsoft Windows 10 Pro";
            }
            else if (OSVersion == "Microsoft Windows NT 6.1.7600.0")
            {
                textBox1.Text = "Microsoft Windows 7 Enterprise";
            }
            else if (OSVersion == "Microsoft Windows NT 6.1.7601 Service Pack 1")
            {
                textBox1.Text = "Microsoft Windows 7 Professional ";
            }
            else if (OSVersion == "Microsoft Windows NT 5.1.2600 Service Pack 3")
            {
                textBox1.Text = "Microsoft Windows XP Professional ";
            }
            BitOperating = Environment.Is64BitOperatingSystem.ToString();
            if (BitOperating == "True")
            {
                textBox_Is64or32.Text = "System is 64 bit opreating";
            }
            else
            {
                textBox_Is64or32.Text = "System is 32 bit opreating";
            }

            label_UserName.Text = Environment.UserName.ToString();

            textBox2.Text = Environment.ProcessorCount.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox_Is64or32_TextChanged(object sender, EventArgs e)
        {
            textBox_Is64or32.ReadOnly = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.ReadOnly = true;
        }

      

        private void label3_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.ForeColor = Color.DarkGray;
        }
    }
}
