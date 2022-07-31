
namespace CMS
{
    partial class AddTeacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTeacher));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richAddress = new System.Windows.Forms.RichTextBox();
            this.CBDuration = new System.Windows.Forms.ComboBox();
            this.CBProgram = new System.Windows.Forms.ComboBox();
            this.CbSem = new System.Windows.Forms.ComboBox();
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.txtSchool = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMob = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAdmssion = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblSchoolN = new System.Windows.Forms.Label();
            this.lblProgram = new System.Windows.Forms.Label();
            this.lblSem = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblMob = new System.Windows.Forms.Label();
            this.lblDob = new System.Windows.Forms.Label();
            this.lblGen = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(239, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(355, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Basic Information";
            // 
            // richAddress
            // 
            this.richAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richAddress.Location = new System.Drawing.Point(680, 445);
            this.richAddress.Name = "richAddress";
            this.richAddress.Size = new System.Drawing.Size(121, 76);
            this.richAddress.TabIndex = 47;
            this.richAddress.Text = "";
            // 
            // CBDuration
            // 
            this.CBDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBDuration.FormattingEnabled = true;
            this.CBDuration.Items.AddRange(new object[] {
            "2020-2024",
            "2024-2028"});
            this.CBDuration.Location = new System.Drawing.Point(680, 391);
            this.CBDuration.Name = "CBDuration";
            this.CBDuration.Size = new System.Drawing.Size(121, 28);
            this.CBDuration.TabIndex = 46;
            this.CBDuration.Text = "--Select--";
            this.CBDuration.SelectedIndexChanged += new System.EventHandler(this.CBDuration_SelectedIndexChanged);
            // 
            // CBProgram
            // 
            this.CBProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBProgram.FormattingEnabled = true;
            this.CBProgram.Items.AddRange(new object[] {
            "C Programming ",
            "C++",
            "Java",
            "JSP",
            "C# ",
            "Python",
            "PHP"});
            this.CBProgram.Location = new System.Drawing.Point(680, 272);
            this.CBProgram.Name = "CBProgram";
            this.CBProgram.Size = new System.Drawing.Size(121, 28);
            this.CBProgram.TabIndex = 45;
            this.CBProgram.Text = "--Select";
            this.CBProgram.SelectedIndexChanged += new System.EventHandler(this.CBProgram_SelectedIndexChanged);
            // 
            // CbSem
            // 
            this.CbSem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbSem.FormattingEnabled = true;
            this.CbSem.Items.AddRange(new object[] {
            "1st Sem",
            "2nd Sem",
            "3rd Sem",
            "4th Sem",
            "5th Sem",
            "6th Sem",
            "7th Sem",
            "8th Sem"});
            this.CbSem.Location = new System.Drawing.Point(680, 211);
            this.CbSem.Name = "CbSem";
            this.CbSem.Size = new System.Drawing.Size(121, 28);
            this.CbSem.TabIndex = 44;
            this.CbSem.Text = "--Select--";
            // 
            // dtPicker
            // 
            this.dtPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPicker.Location = new System.Drawing.Point(228, 334);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(110, 26);
            this.dtPicker.TabIndex = 43;
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMale.Location = new System.Drawing.Point(359, 282);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(66, 24);
            this.rdMale.TabIndex = 42;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "Male";
            this.rdMale.UseVisualStyleBackColor = true;
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdFemale.Location = new System.Drawing.Point(250, 282);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(85, 24);
            this.rdFemale.TabIndex = 41;
            this.rdFemale.TabStop = true;
            this.rdFemale.Text = "Female";
            this.rdFemale.UseVisualStyleBackColor = true;
            // 
            // txtSchool
            // 
            this.txtSchool.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchool.Location = new System.Drawing.Point(680, 327);
            this.txtSchool.Name = "txtSchool";
            this.txtSchool.Size = new System.Drawing.Size(121, 26);
            this.txtSchool.TabIndex = 40;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(228, 445);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 26);
            this.txtEmail.TabIndex = 39;
            // 
            // txtMob
            // 
            this.txtMob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMob.Location = new System.Drawing.Point(228, 393);
            this.txtMob.Name = "txtMob";
            this.txtMob.Size = new System.Drawing.Size(100, 26);
            this.txtMob.TabIndex = 38;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(228, 213);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 26);
            this.txtName.TabIndex = 36;
            // 
            // lblAdmssion
            // 
            this.lblAdmssion.AutoSize = true;
            this.lblAdmssion.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmssion.Location = new System.Drawing.Point(519, 445);
            this.lblAdmssion.Name = "lblAdmssion";
            this.lblAdmssion.Size = new System.Drawing.Size(99, 19);
            this.lblAdmssion.TabIndex = 35;
            this.lblAdmssion.Text = "Admission";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.Location = new System.Drawing.Point(519, 391);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(89, 19);
            this.lblDuration.TabIndex = 34;
            this.lblDuration.Text = "Duration";
            this.lblDuration.Click += new System.EventHandler(this.lblDuration_Click);
            // 
            // lblSchoolN
            // 
            this.lblSchoolN.AutoSize = true;
            this.lblSchoolN.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchoolN.Location = new System.Drawing.Point(519, 334);
            this.lblSchoolN.Name = "lblSchoolN";
            this.lblSchoolN.Size = new System.Drawing.Size(119, 19);
            this.lblSchoolN.TabIndex = 33;
            this.lblSchoolN.Text = "School Name";
            // 
            // lblProgram
            // 
            this.lblProgram.AutoSize = true;
            this.lblProgram.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgram.Location = new System.Drawing.Point(519, 272);
            this.lblProgram.Name = "lblProgram";
            this.lblProgram.Size = new System.Drawing.Size(119, 19);
            this.lblProgram.TabIndex = 32;
            this.lblProgram.Text = "Programming";
            // 
            // lblSem
            // 
            this.lblSem.AutoSize = true;
            this.lblSem.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSem.Location = new System.Drawing.Point(519, 213);
            this.lblSem.Name = "lblSem";
            this.lblSem.Size = new System.Drawing.Size(89, 19);
            this.lblSem.TabIndex = 31;
            this.lblSem.Text = "Semester";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(73, 445);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(109, 19);
            this.lblEmail.TabIndex = 30;
            this.lblEmail.Text = "Email Id :";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // lblMob
            // 
            this.lblMob.AutoSize = true;
            this.lblMob.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMob.Location = new System.Drawing.Point(83, 393);
            this.lblMob.Name = "lblMob";
            this.lblMob.Size = new System.Drawing.Size(99, 19);
            this.lblMob.TabIndex = 29;
            this.lblMob.Text = "Mobile No";
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDob.Location = new System.Drawing.Point(63, 334);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(139, 19);
            this.lblDob.TabIndex = 28;
            this.lblDob.Text = "Date of Birth";
            // 
            // lblGen
            // 
            this.lblGen.AutoSize = true;
            this.lblGen.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGen.Location = new System.Drawing.Point(105, 281);
            this.lblGen.Name = "lblGen";
            this.lblGen.Size = new System.Drawing.Size(99, 19);
            this.lblGen.TabIndex = 27;
            this.lblGen.Text = "Gender : ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(83, 213);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(119, 19);
            this.lblName.TabIndex = 25;
            this.lblName.Text = "Full Name :";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(349, 516);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(125, 45);
            this.btnSubmit.TabIndex = 48;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // AddTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(896, 573);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.richAddress);
            this.Controls.Add(this.CBDuration);
            this.Controls.Add(this.CBProgram);
            this.Controls.Add(this.CbSem);
            this.Controls.Add(this.dtPicker);
            this.Controls.Add(this.rdMale);
            this.Controls.Add(this.rdFemale);
            this.Controls.Add(this.txtSchool);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtMob);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblAdmssion);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblSchoolN);
            this.Controls.Add(this.lblProgram);
            this.Controls.Add(this.lblSem);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblMob);
            this.Controls.Add(this.lblDob);
            this.Controls.Add(this.lblGen);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AddTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddTeacher";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richAddress;
        private System.Windows.Forms.ComboBox CBDuration;
        private System.Windows.Forms.ComboBox CBProgram;
        private System.Windows.Forms.ComboBox CbSem;
        private System.Windows.Forms.DateTimePicker dtPicker;
        private System.Windows.Forms.RadioButton rdMale;
        private System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.TextBox txtSchool;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMob;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAdmssion;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblSchoolN;
        private System.Windows.Forms.Label lblProgram;
        private System.Windows.Forms.Label lblSem;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblMob;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.Label lblGen;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnSubmit;
    }
}