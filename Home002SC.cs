using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace RESTAURANT
{
    public partial class Home002SC : Form
    {
        private System.Windows.Forms.Timer timer;

        public Home002SC()
        {
            InitializeComponent();

            // Initialize and start the timer
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1000 milliseconds = 1 second
            timer.Tick += timer1_Tick; 
            timer.Start();

            // Set up the label properties
            txtTime.Text = DateTime.Now.ToString("HH:mm:ss");
            txtTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtTime.TextAlign = ContentAlignment.MiddleCenter;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {



        }

        private void Home002SC_Load(object sender, EventArgs e)
        {

            // Open child form on panel
            Cover003SC coverForm = new Cover003SC();

            coverForm.TopLevel = false;
            panelPage.Controls.Add(coverForm);
            coverForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            coverForm.Dock = DockStyle.Fill;
            coverForm.Show();
        }

        private void dailyPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelPage.Controls.Clear();

            // Open child form on panel

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelPage.Controls.Clear();

            // Open child form on panel
            Menu004SC menuForm = new Menu004SC();

            menuForm.TopLevel = false;
            panelPage.Controls.Add(menuForm);
            menuForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            menuForm.Dock = DockStyle.Fill;
            menuForm.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelPage.Controls.Clear();

            // Open child form on panel
            Cover003SC coverForm = new Cover003SC();

            coverForm.TopLevel = false;
            panelPage.Controls.Add(coverForm);
            coverForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            coverForm.Dock = DockStyle.Fill;
            coverForm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
