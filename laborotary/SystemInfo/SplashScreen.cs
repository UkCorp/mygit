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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        Timer s;

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            s = new Timer();
            s.Interval = 3000;
            s.Start();
            s.Tick += new EventHandler(s_Tick);

        }

        void s_Tick(Object sender, EventArgs e)
        {
            s.Stop();
            Form frm = new Form();
            frm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
