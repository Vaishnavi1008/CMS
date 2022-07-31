
namespace CMS
{
    partial class RemoveStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveStudent));
            this.displayInfo = new System.Windows.Forms.DataGridView();
            this.btnremove = new System.Windows.Forms.Button();
            this.txtreg = new System.Windows.Forms.TextBox();
            this.lblreg = new System.Windows.Forms.Label();
            this.lblstudent = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.displayInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // displayInfo
            // 
            this.displayInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayInfo.Location = new System.Drawing.Point(134, 246);
            this.displayInfo.Name = "displayInfo";
            this.displayInfo.RowHeadersWidth = 51;
            this.displayInfo.RowTemplate.Height = 24;
            this.displayInfo.Size = new System.Drawing.Size(575, 371);
            this.displayInfo.TabIndex = 11;
            this.displayInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.displayInfo_CellContentClick);
            // 
            // btnremove
            // 
            this.btnremove.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremove.Location = new System.Drawing.Point(520, 186);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(93, 33);
            this.btnremove.TabIndex = 10;
            this.btnremove.Text = "Delete";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // txtreg
            // 
            this.txtreg.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtreg.Location = new System.Drawing.Point(508, 125);
            this.txtreg.Name = "txtreg";
            this.txtreg.Size = new System.Drawing.Size(141, 31);
            this.txtreg.TabIndex = 9;
            // 
            // lblreg
            // 
            this.lblreg.AutoSize = true;
            this.lblreg.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreg.Location = new System.Drawing.Point(292, 125);
            this.lblreg.Name = "lblreg";
            this.lblreg.Size = new System.Drawing.Size(226, 23);
            this.lblreg.TabIndex = 8;
            this.lblreg.Text = "Registration Id : ";
            // 
            // lblstudent
            // 
            this.lblstudent.AutoSize = true;
            this.lblstudent.Font = new System.Drawing.Font("Lucida Sans Typewriter", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudent.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblstudent.Location = new System.Drawing.Point(335, 40);
            this.lblstudent.Name = "lblstudent";
            this.lblstudent.Size = new System.Drawing.Size(267, 34);
            this.lblstudent.TabIndex = 7;
            this.lblstudent.Text = "Remove Student";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(134, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // RemoveStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 642);
            this.Controls.Add(this.displayInfo);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.txtreg);
            this.Controls.Add(this.lblreg);
            this.Controls.Add(this.lblstudent);
            this.Controls.Add(this.pictureBox1);
            this.Name = "RemoveStudent";
            this.Text = "RemoveStudent";
            this.Load += new System.EventHandler(this.RemoveStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.displayInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView displayInfo;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.TextBox txtreg;
        private System.Windows.Forms.Label lblreg;
        private System.Windows.Forms.Label lblstudent;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}