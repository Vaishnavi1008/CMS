
namespace CMS
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblhead = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnlogin = new System.Windows.Forms.Button();
            this.txtUN = new System.Windows.Forms.TextBox();
            this.lblPss = new System.Windows.Forms.Label();
            this.txtpss = new System.Windows.Forms.TextBox();
            this.lblUN = new System.Windows.Forms.Label();
            this.lbllogin = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aDMISSIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newAdmission = new System.Windows.Forms.ToolStripMenuItem();
            this.upgradeSemesterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fEESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sTUDENTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.individualDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tEACHERSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTeachersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEMOVESTUDENTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITSYSTEMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblhead
            // 
            this.lblhead.AutoSize = true;
            this.lblhead.BackColor = System.Drawing.Color.LightGray;
            this.lblhead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblhead.Font = new System.Drawing.Font("Goudy Old Style", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhead.ForeColor = System.Drawing.Color.DarkRed;
            this.lblhead.Location = new System.Drawing.Point(631, 173);
            this.lblhead.Name = "lblhead";
            this.lblhead.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblhead.Size = new System.Drawing.Size(788, 56);
            this.lblhead.TabIndex = 0;
            this.lblhead.Text = "COLLEGE MANAGEMENT SYSTEM";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnlogin);
            this.panel1.Controls.Add(this.txtUN);
            this.panel1.Controls.Add(this.lblPss);
            this.panel1.Controls.Add(this.txtpss);
            this.panel1.Controls.Add(this.lblUN);
            this.panel1.Controls.Add(this.lbllogin);
            this.panel1.Location = new System.Drawing.Point(701, 324);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(697, 376);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.Validating += new System.ComponentModel.CancelEventHandler(this.panel1_Validating);
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.White;
            this.btnlogin.Font = new System.Drawing.Font("Lucida Console", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.Maroon;
            this.btnlogin.Location = new System.Drawing.Point(310, 261);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(5);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Padding = new System.Windows.Forms.Padding(5);
            this.btnlogin.Size = new System.Drawing.Size(169, 58);
            this.btnlogin.TabIndex = 5;
            this.btnlogin.Text = "LOGIN";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // txtUN
            // 
            this.txtUN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtUN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUN.Location = new System.Drawing.Point(297, 129);
            this.txtUN.Name = "txtUN";
            this.txtUN.Size = new System.Drawing.Size(217, 34);
            this.txtUN.TabIndex = 4;
            this.txtUN.TextChanged += new System.EventHandler(this.tztUN_TextChanged);
            // 
            // lblPss
            // 
            this.lblPss.AutoSize = true;
            this.lblPss.Font = new System.Drawing.Font("Lucida Sans Typewriter", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPss.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPss.Location = new System.Drawing.Point(84, 186);
            this.lblPss.Name = "lblPss";
            this.lblPss.Size = new System.Drawing.Size(152, 27);
            this.lblPss.TabIndex = 3;
            this.lblPss.Text = "PASSWORD :";
            this.lblPss.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPss.Click += new System.EventHandler(this.lblPss_Click);
            // 
            // txtpss
            // 
            this.txtpss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtpss.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpss.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpss.Location = new System.Drawing.Point(297, 186);
            this.txtpss.Name = "txtpss";
            this.txtpss.Size = new System.Drawing.Size(217, 34);
            this.txtpss.TabIndex = 2;
            this.txtpss.UseSystemPasswordChar = true;
            // 
            // lblUN
            // 
            this.lblUN.AutoSize = true;
            this.lblUN.Font = new System.Drawing.Font("Lucida Sans Typewriter", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUN.ForeColor = System.Drawing.Color.DarkRed;
            this.lblUN.Location = new System.Drawing.Point(84, 129);
            this.lblUN.Name = "lblUN";
            this.lblUN.Size = new System.Drawing.Size(152, 27);
            this.lblUN.TabIndex = 1;
            this.lblUN.Text = "USERNAME :";
            this.lblUN.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbllogin
            // 
            this.lbllogin.AutoSize = true;
            this.lbllogin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbllogin.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogin.ForeColor = System.Drawing.Color.Maroon;
            this.lbllogin.Location = new System.Drawing.Point(356, 30);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(108, 32);
            this.lbllogin.TabIndex = 0;
            this.lbllogin.Text = "LOGIN";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDMISSIONToolStripMenuItem,
            this.fEESToolStripMenuItem,
            this.sTUDENTToolStripMenuItem,
            this.tEACHERSToolStripMenuItem,
            this.rEMOVESTUDENTToolStripMenuItem,
            this.eXITSYSTEMToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1410, 91);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aDMISSIONToolStripMenuItem
            // 
            this.aDMISSIONToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newAdmission,
            this.upgradeSemesterToolStripMenuItem});
            this.aDMISSIONToolStripMenuItem.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aDMISSIONToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.aDMISSIONToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aDMISSIONToolStripMenuItem.Image")));
            this.aDMISSIONToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.aDMISSIONToolStripMenuItem.Name = "aDMISSIONToolStripMenuItem";
            this.aDMISSIONToolStripMenuItem.Size = new System.Drawing.Size(132, 87);
            this.aDMISSIONToolStripMenuItem.Text = "ADMISSION";
            this.aDMISSIONToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // newAdmission
            // 
            this.newAdmission.Name = "newAdmission";
            this.newAdmission.Size = new System.Drawing.Size(286, 28);
            this.newAdmission.Text = "New Admission";
            this.newAdmission.Click += new System.EventHandler(this.newAdmission_Click_1);
            // 
            // upgradeSemesterToolStripMenuItem
            // 
            this.upgradeSemesterToolStripMenuItem.Name = "upgradeSemesterToolStripMenuItem";
            this.upgradeSemesterToolStripMenuItem.Size = new System.Drawing.Size(286, 28);
            this.upgradeSemesterToolStripMenuItem.Text = "Upgrade Semester";
            this.upgradeSemesterToolStripMenuItem.Click += new System.EventHandler(this.upgradeSemesterToolStripMenuItem_Click);
            // 
            // fEESToolStripMenuItem
            // 
            this.fEESToolStripMenuItem.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fEESToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.fEESToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fEESToolStripMenuItem.Image")));
            this.fEESToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.fEESToolStripMenuItem.Name = "fEESToolStripMenuItem";
            this.fEESToolStripMenuItem.Size = new System.Drawing.Size(74, 87);
            this.fEESToolStripMenuItem.Text = "FEES";
            this.fEESToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.fEESToolStripMenuItem.Click += new System.EventHandler(this.fEESToolStripMenuItem_Click);
            // 
            // sTUDENTToolStripMenuItem
            // 
            this.sTUDENTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchStudentToolStripMenuItem,
            this.individualDetailsToolStripMenuItem});
            this.sTUDENTToolStripMenuItem.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sTUDENTToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.sTUDENTToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sTUDENTToolStripMenuItem.Image")));
            this.sTUDENTToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sTUDENTToolStripMenuItem.Name = "sTUDENTToolStripMenuItem";
            this.sTUDENTToolStripMenuItem.Size = new System.Drawing.Size(108, 87);
            this.sTUDENTToolStripMenuItem.Text = "STUDENT";
            this.sTUDENTToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // searchStudentToolStripMenuItem
            // 
            this.searchStudentToolStripMenuItem.Name = "searchStudentToolStripMenuItem";
            this.searchStudentToolStripMenuItem.Size = new System.Drawing.Size(310, 28);
            this.searchStudentToolStripMenuItem.Text = "Search Student";
            this.searchStudentToolStripMenuItem.Click += new System.EventHandler(this.searchStudentToolStripMenuItem_Click);
            // 
            // individualDetailsToolStripMenuItem
            // 
            this.individualDetailsToolStripMenuItem.Name = "individualDetailsToolStripMenuItem";
            this.individualDetailsToolStripMenuItem.Size = new System.Drawing.Size(310, 28);
            this.individualDetailsToolStripMenuItem.Text = "Individual Details";
            this.individualDetailsToolStripMenuItem.Click += new System.EventHandler(this.individualDetailsToolStripMenuItem_Click);
            // 
            // tEACHERSToolStripMenuItem
            // 
            this.tEACHERSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTeachersToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.tEACHERSToolStripMenuItem.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tEACHERSToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tEACHERSToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tEACHERSToolStripMenuItem.Image")));
            this.tEACHERSToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tEACHERSToolStripMenuItem.Name = "tEACHERSToolStripMenuItem";
            this.tEACHERSToolStripMenuItem.Size = new System.Drawing.Size(120, 87);
            this.tEACHERSToolStripMenuItem.Text = "TEACHERS";
            this.tEACHERSToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // addTeachersToolStripMenuItem
            // 
            this.addTeachersToolStripMenuItem.Name = "addTeachersToolStripMenuItem";
            this.addTeachersToolStripMenuItem.Size = new System.Drawing.Size(382, 28);
            this.addTeachersToolStripMenuItem.Text = "Add Teachers Information";
            this.addTeachersToolStripMenuItem.Click += new System.EventHandler(this.addTeachersToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(382, 28);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // rEMOVESTUDENTToolStripMenuItem
            // 
            this.rEMOVESTUDENTToolStripMenuItem.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rEMOVESTUDENTToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.rEMOVESTUDENTToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("rEMOVESTUDENTToolStripMenuItem.Image")));
            this.rEMOVESTUDENTToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.rEMOVESTUDENTToolStripMenuItem.Name = "rEMOVESTUDENTToolStripMenuItem";
            this.rEMOVESTUDENTToolStripMenuItem.Size = new System.Drawing.Size(192, 87);
            this.rEMOVESTUDENTToolStripMenuItem.Text = "REMOVE STUDENT";
            this.rEMOVESTUDENTToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.rEMOVESTUDENTToolStripMenuItem.Click += new System.EventHandler(this.rEMOVESTUDENTToolStripMenuItem_Click);
            // 
            // eXITSYSTEMToolStripMenuItem
            // 
            this.eXITSYSTEMToolStripMenuItem.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eXITSYSTEMToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.eXITSYSTEMToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eXITSYSTEMToolStripMenuItem.Image")));
            this.eXITSYSTEMToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.eXITSYSTEMToolStripMenuItem.Name = "eXITSYSTEMToolStripMenuItem";
            this.eXITSYSTEMToolStripMenuItem.Size = new System.Drawing.Size(156, 87);
            this.eXITSYSTEMToolStripMenuItem.Text = "EXIT SYSTEM";
            this.eXITSYSTEMToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.eXITSYSTEMToolStripMenuItem.Click += new System.EventHandler(this.eXITSYSTEMToolStripMenuItem_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1410, 712);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblhead);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblhead;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtpss;
        private System.Windows.Forms.Label lblUN;
        private System.Windows.Forms.Label lbllogin;
        private System.Windows.Forms.Label lblPss;
        private System.Windows.Forms.TextBox txtUN;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aDMISSIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newAdmission;
        private System.Windows.Forms.ToolStripMenuItem upgradeSemesterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fEESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sTUDENTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem individualDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tEACHERSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTeachersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEMOVESTUDENTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITSYSTEMToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}

