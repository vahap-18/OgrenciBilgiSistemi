using System;
using System.CodeDom;
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
    public partial class ClubForm : Form
    {
        public ClubForm()
        {
            InitializeComponent();
        }


        SqlConnection connection = new SqlConnection("Data Source=VahapDogan;Initial Catalog=OgrenciBilgiSistemi;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");


        void List()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TblClub", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataClub.DataSource = dt;

            dataClub.Columns["Name"].HeaderText = "Kulüp Adı";
            dataClub.Columns["President"].HeaderText = "Kulüp Başkanı";
            dataClub.Columns["Advisor"].HeaderText = "Kulüp Danışmanı";
        }

        void Clean()
        {
            tbClubName.Text = String.Empty;
            tbPresident.Text = String.Empty;
            tbAdvisor.Text = String.Empty;
        }
        private void ClubForm_Load(object sender, EventArgs e)
        {
            List();
        }


        private void dataClub_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataClub.SelectedCells[0].RowIndex;
            lblId.Text = dataClub.Rows[secilen].Cells[0].Value.ToString();
            tbClubName.Text = dataClub.Rows[secilen].Cells[1].Value.ToString();
            tbPresident.Text = dataClub.Rows[secilen].Cells[2].Value.ToString();
            tbAdvisor.Text = dataClub.Rows[secilen].Cells[3].Value.ToString();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmdAdd = new SqlCommand("insert into TblClub (Name, President, Advisor) values (@p1, @p2, @p3)", connection);
            cmdAdd.Parameters.AddWithValue("@p1", tbClubName.Text);
            cmdAdd.Parameters.AddWithValue("@p2", tbPresident.Text);
            cmdAdd.Parameters.AddWithValue("@p3", tbAdvisor.Text);
            cmdAdd.ExecuteNonQuery();
            connection.Close();
            List();
            Clean();
            MessageBox.Show("Kulüp eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"{tbClubName.Text} kulübü silinecektir!", "Dikkat", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            
            if (dialogResult == DialogResult.OK)
            {
                connection.Open();
                SqlCommand cmdDelete = new SqlCommand("delete from TblClub where Id = @p1", connection);
                cmdDelete.Parameters.AddWithValue("@p1", lblId.Text);
                cmdDelete.ExecuteNonQuery();
                connection.Close();
                List();
                Clean();
                MessageBox.Show("Kulüp silindi.", "Sil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Silme iptal edildi.", "İptal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmdUpdate = new SqlCommand("update TblClub set Name = @Name, President = @President, Advisor = @Advisor where Id = @Id", connection);
            cmdUpdate.Parameters.AddWithValue("@Id", lblId.Text);
            cmdUpdate.Parameters.AddWithValue("@Name", tbClubName.Text);
            cmdUpdate.Parameters.AddWithValue("@President", tbPresident.Text);
            cmdUpdate.Parameters.AddWithValue("@Advisor", tbAdvisor.Text);
            cmdUpdate.ExecuteNonQuery();
            connection.Close();
            List();
            Clean();

            MessageBox.Show("Kulüp güncellendi.", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);   
        }
    }
}