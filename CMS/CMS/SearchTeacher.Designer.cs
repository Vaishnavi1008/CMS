
namespace CMS
{
    partial class SearchTeacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchTeacher));
            this.displayInfo = new System.Windows.Forms.DataGridView();
            this.btnsearch = new System.Windows.Forms.Button();
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
            this.displayInfo.Location = new System.Drawing.Point(42, 264);
            this.displayInfo.Name = "displayInfo";
            this.displayInfo.RowHeadersWidth = 51;
            this.displayInfo.RowTemplate.Height = 24;
            this.displayInfo.Size = new System.Drawing.Size(575, 371);
            this.displayInfo.TabIndex = 11;
            // 
            // btnsearch
            // 
            this.btnsearch.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(428, 204);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(93, 33);
            this.btnsearch.TabIndex = 10;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtreg
            // 
            this.txtreg.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtreg.Location = new System.Drawing.Point(416, 143);
            this.txtreg.Name = "txtreg";
            this.txtreg.Size = new System.Drawing.Size(141, 31);
            this.txtreg.TabIndex = 9;
            // 
            // lblreg
            // 
            this.lblreg.AutoSize = true;
            this.lblreg.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreg.Location = new System.Drawing.Point(200, 143);
            this.lblreg.Name = "lblreg";
            this.lblreg.Size = new System.Drawing.Size(238, 23);
            this.lblreg.TabIndex = 8;
            this.lblreg.Text = "Registration  Id : ";
            // 
            // lblstudent
            // 
            this.lblstudent.AutoSize = true;
            this.lblstudent.Font = new System.Drawing.Font("Lucida Sans Typewriter", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudent.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblstudent.Location = new System.Drawing.Point(243, 58);
            this.lblstudent.Name = "lblstudent";
            this.lblstudent.Size = new System.Drawing.Size(267, 34);
            this.lblstudent.TabIndex = 7;
            this.lblstudent.Text = "Search Teacher";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(42, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // SearchTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 642);
            this.Controls.Add(this.displayInfo);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtreg);
            this.Controls.Add(this.lblreg);
            this.Controls.Add(this.lblstudent);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SearchTeacher";
            this.Text = "SearchTeacher";
            this.Load += new System.EventHandler(this.SearchTeacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.displayInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView displayInfo;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtreg;
        private System.Windows.Forms.Label lblreg;
        private System.Windows.Forms.Label lblstudent;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}