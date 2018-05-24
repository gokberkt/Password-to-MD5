using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Şifre_Oluştur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string password = "";
        public string hashedPass = "";

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            password = txtPassEntry.Text;
            hashedPass = Helpers.PasswordToMD5(password);
            txtPassOutput.Text = hashedPass;
        }
    }
}
