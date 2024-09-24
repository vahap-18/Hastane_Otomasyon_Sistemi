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
    public partial class DoctorLoginForm : Form
    {
        public DoctorLoginForm()
        {
            InitializeComponent();
        }

        private void linkRegisterSicks_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SickRegisterForm frm = new SickRegisterForm();
            frm.ShowDialog();
            this.Close();
        }
    }
}
