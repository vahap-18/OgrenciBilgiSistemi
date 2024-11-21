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
using OgrenciBilgiSistemi.Contact;

namespace OgrenciBilgiSistemi.Forms
{
    public partial class StudentNotesForm : Form
    {
        public StudentNotesForm()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=VahapDogan;Initial Catalog=OgrenciBilgiSistemi;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        public string numara, name;

        private void StudentNotesForm_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT TblStudent.Name AS Ad, TblStudent.Surname AS Soyad, TblClub.Name AS Kulüp, TblStudent.Number AS Numara, TblStudent.Gender AS Cinsiyet " +
                    "FROM TblNotes " +
                    "INNER JOIN TblLesson ON TblNotes.LessonId = TblLesson.Id " +
                    "INNER JOIN TblStudent ON TblNotes.StudentId = TblStudent.Id " +
                    "INNER JOIN TblClub ON TblStudent.ClubId = TblClub.Id " +
                    "WHERE TblStudent.Number = @Number", connection);


            cmd.Parameters.AddWithValue("@Number", numara);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            lblName.Text = name;
            lblNumber.Text = numara;
        }
    }
}
