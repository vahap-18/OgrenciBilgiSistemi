using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciBilgiSistemi.Forms
{
    public partial class TeacherLoginForm : Form
    {
        public TeacherLoginForm()
        {
            InitializeComponent();
        }

        private void TeacherLoginForm_Load(object sender, EventArgs e)
        {

        }

        SqlConnection connection = new SqlConnection("Data Source=VahapDogan;Initial Catalog=OgrenciBilgiSistemi;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picHome_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmdLogin = new SqlCommand("select * from TblEducator where Name = @Name and Password = @Password", connection);
            cmdLogin.Parameters.AddWithValue("@Name", tbUserName.Text);
            cmdLogin.Parameters.AddWithValue("@Password", tbPassword.Text);
            SqlDataReader reader = cmdLogin.ExecuteReader();
            if (reader.Read())
            {
                TeacherForm form = new TeacherForm();
                form.Name = tbUserName.Text;
                // form.Branch = 
                form.Show();
                this.Hide();
            }
            else
            {
                lblInfo.Text = "Kullanıcı adı veya parola hatalı!";
            }
            connection.Close();
        }
    }
}
