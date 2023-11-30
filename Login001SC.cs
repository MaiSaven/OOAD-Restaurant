using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RESTAURANT
{
    public partial class Login001SC : Form
    {
        public Login001SC()
        {
            InitializeComponent();
            txtAlt.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user,password;
           

            user = txtUser.Text;
            password = txtPassword.Text;

            if (user.Equals("admin") && password.Equals("1234")) {

                MessageBox.Show("Okay bro");

                txtAlt.Text = string.Empty;

                this.Hide();

                Home002SC formHome = new Home002SC();
                formHome.ShowDialog();

                this.Close();
            }
            else
            {
                txtAlt.Text = "Incorrect User or Password!";
            }
        }
    }
}
