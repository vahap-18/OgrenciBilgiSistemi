namespace OgrenciBilgiSistemi.Forms
{
    partial class TeacherForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBranch = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.btnTeachers = new System.Windows.Forms.Button();
            this.btnStudentWork = new System.Windows.Forms.Button();
            this.benExam = new System.Windows.Forms.Button();
            this.btnClup = new System.Windows.Forms.Button();
            this.btnLesson = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblBranch);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.btnTeachers);
            this.panel1.Controls.Add(this.btnStudentWork);
            this.panel1.Controls.Add(this.benExam);
            this.panel1.Controls.Add(this.btnClup);
            this.panel1.Controls.Add(this.btnLesson);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 580);
            this.panel1.TabIndex = 0;
            // 
            // lblBranch
            // 
            this.lblBranch.AutoSize = true;
            this.lblBranch.BackColor = System.Drawing.Color.Transparent;
            this.lblBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBranch.Location = new System.Drawing.Point(51, 149);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(57, 22);
            this.lblBranch.TabIndex = 2;
            this.lblBranch.Text = "Branş";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(47, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Location = new System.Drawing.Point(13, 483);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(187, 47);
            this.button6.TabIndex = 5;
            this.button6.Text = "Çıkış";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnTeachers
            // 
            this.btnTeachers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTeachers.Location = new System.Drawing.Point(13, 371);
            this.btnTeachers.Name = "btnTeachers";
            this.btnTeachers.Size = new System.Drawing.Size(187, 47);
            this.btnTeachers.TabIndex = 3;
            this.btnTeachers.Text = "Öğretmenler";
            this.btnTeachers.UseVisualStyleBackColor = true;
            // 
            // btnStudentWork
            // 
            this.btnStudentWork.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudentWork.Location = new System.Drawing.Point(13, 427);
            this.btnStudentWork.Name = "btnStudentWork";
            this.btnStudentWork.Size = new System.Drawing.Size(187, 47);
            this.btnStudentWork.TabIndex = 4;
            this.btnStudentWork.Text = "Öğrenci İşlemleri";
            this.btnStudentWork.UseVisualStyleBackColor = true;
            // 
            // benExam
            // 
            this.benExam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.benExam.Location = new System.Drawing.Point(13, 315);
            this.benExam.Name = "benExam";
            this.benExam.Size = new System.Drawing.Size(187, 47);
            this.benExam.TabIndex = 2;
            this.benExam.Text = "Sınav işlemleri";
            this.benExam.UseVisualStyleBackColor = true;
            // 
            // btnClup
            // 
            this.btnClup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClup.Location = new System.Drawing.Point(13, 259);
            this.btnClup.Name = "btnClup";
            this.btnClup.Size = new System.Drawing.Size(187, 47);
            this.btnClup.TabIndex = 1;
            this.btnClup.Text = "Kulüp işlemleri";
            this.btnClup.UseVisualStyleBackColor = true;
            this.btnClup.Click += new System.EventHandler(this.btnClup_Click);
            // 
            // btnLesson
            // 
            this.btnLesson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLesson.Location = new System.Drawing.Point(13, 203);
            this.btnLesson.Name = "btnLesson";
            this.btnLesson.Size = new System.Drawing.Size(187, 47);
            this.btnLesson.TabIndex = 0;
            this.btnLesson.Text = "Ders işlemleri";
            this.btnLesson.UseVisualStyleBackColor = true;
            this.btnLesson.Click += new System.EventHandler(this.btnLesson_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.Location = new System.Drawing.Point(56, 116);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(96, 22);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Ad Soyad";
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(963, 580);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TeacherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğretmen ";
            this.Load += new System.EventHandler(this.TeacherForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnTeachers;
        private System.Windows.Forms.Button benExam;
        private System.Windows.Forms.Button btnClup;
        private System.Windows.Forms.Button btnLesson;
        private System.Windows.Forms.Label lblBranch;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnStudentWork;
    }
}