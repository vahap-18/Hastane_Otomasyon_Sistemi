using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Otomasyon_Sistemi
{
    public partial class SickRegisterForm : Form
    {
        public SickRegisterForm()
        {
            InitializeComponent();
        }

        private void linkLoginSick_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SickLoginForm loginForm = new SickLoginForm();
            loginForm.ShowDialog();
            this.Close();
        }
    }
}
