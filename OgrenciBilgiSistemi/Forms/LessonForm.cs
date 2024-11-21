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
    public partial class LessonForm : Form
    {
        public LessonForm()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=VahapDogan;Initial Catalog=OgrenciBilgiSistemi;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");


        void List()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TblLesson", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataLesson.DataSource = dt;

            dataLesson.Columns["Name"].HeaderText = "Ders Adı";
        }

        void Clean()
        {
            tbName.Text = string.Empty;
        }
            private void LessonForm_Load(object sender, EventArgs e)
        {
            List();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmdEdit = new SqlCommand("update TblLesson set Name = @Name where Id = @Id", connection);
            cmdEdit.Parameters.AddWithValue("@Id", lblId.Text);
            cmdEdit.Parameters.AddWithValue("@Name", tbName.Text);
            cmdEdit.ExecuteNonQuery();
            connection.Close();
            List();
            Clean();
            MessageBox.Show("Ders güncellendi.", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataLesson_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataLesson.SelectedCells[0].RowIndex;
            lblId.Text = dataLesson.Rows[secilen].Cells[0].Value.ToString();
            tbName.Text = dataLesson.Rows[secilen].Cells[1].Value.ToString();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmdAdd = new SqlCommand("insert into TblLesson (Name) values(@Name)", connection);
            cmdAdd.Parameters.AddWithValue("@Name", tbName.Text);
            cmdAdd.ExecuteNonQuery();
            connection.Close();
            List();
            Clean();
            MessageBox.Show("Ders eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($" {tbName.Text} dersi silinecektir!", "Dikkat", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                connection.Open();
                SqlCommand cmdDelete = new SqlCommand("delete from TblLesson where Id = @Id", connection);
                cmdDelete.Parameters.AddWithValue("@Id", lblId.Text);
                cmdDelete.ExecuteNonQuery();
                connection.Close();
                List();
                Clean();
                MessageBox.Show("Ders silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ders silinmedi.");
            }
        }
    }
}
