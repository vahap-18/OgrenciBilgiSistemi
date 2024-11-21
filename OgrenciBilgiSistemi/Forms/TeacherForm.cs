using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciBilgiSistemi.Forms
{
    public partial class TeacherForm : Form
    {
        public TeacherForm()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClup_Click(object sender, EventArgs e)
        {
            ClubForm clubForm = new ClubForm();
            clubForm.Show();
        }

        private void btnLesson_Click(object sender, EventArgs e)
        {
            LessonForm lessonForm = new LessonForm();
            lessonForm.Show();
        }

        public string Name, Branch;
        private void TeacherForm_Load(object sender, EventArgs e)
        {
            lblName.Text = Name;
            lblBranch.Text = Branch;
        }
    }
}
