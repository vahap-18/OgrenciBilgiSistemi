using OgrenciBilgiSistemi.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciBilgiSistemi
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            TeacherLoginForm form = new TeacherLoginForm();
            form.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            StudentLoginForm form = new StudentLoginForm();
            form.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            StudentNotesForm fr = new StudentNotesForm();
            fr.numara = tbNoStudent.Text;
            fr.name = tbNoStudent.Text;
            fr.Show();
            this.Hide();
        }

        private void tbNoStudent_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
