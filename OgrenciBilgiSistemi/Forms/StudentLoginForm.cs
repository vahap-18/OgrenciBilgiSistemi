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
    public partial class StudentLoginForm : Form
    {
        public StudentLoginForm()
        {
            InitializeComponent();
        }

        private void picHome_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        SqlConnection connection = new SqlConnection("Data Source=VahapDogan;Initial Catalog=OgrenciBilgiSistemi;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        private void btnLogin_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmdLogin = new SqlCommand("select TblStudent.Name as Ad, TblStudent.Surname as Soyad, TblClub.Name as Kulüp, TblStudent.Number as TblStudent.Numara, TblStudent.Gender as Cinsiyet from TblStudent inner join TblClub on TblStudent.ClubId = TblClub.Id  where Number = @Number and Password = @Password", connection);

            cmdLogin.Parameters.AddWithValue("@Number", tbNumber.Text);
            cmdLogin.Parameters.AddWithValue("@Password", tbPassword.Text);

            SqlDataReader reader = cmdLogin.ExecuteReader();
            if (reader.Read())
            {
                StudentNotesForm studentNotesForm = new StudentNotesForm();
                studentNotesForm.numara = tbNumber.Text;
                studentNotesForm.name = reader["Ad"].ToString();

                studentNotesForm.Show();
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
