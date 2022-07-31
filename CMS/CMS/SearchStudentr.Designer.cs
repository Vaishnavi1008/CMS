
namespace CMS
{
    partial class SearchStudentr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchStudentr));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblstudent = new System.Windows.Forms.Label();
            this.lblreg = new System.Windows.Forms.Label();
            this.txtreg = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.displayInfo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblstudent
            // 
            this.lblstudent.AutoSize = true;
            this.lblstudent.Font = new System.Drawing.Font("Lucida Sans Typewriter", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudent.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblstudent.Location = new System.Drawing.Point(226, 53);
            this.lblstudent.Name = "lblstudent";
            this.lblstudent.Size = new System.Drawing.Size(267, 34);
            this.lblstudent.TabIndex = 1;
            this.lblstudent.Text = "Search Student";
            // 
            // lblreg
            // 
            this.lblreg.AutoSize = true;
            this.lblreg.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreg.Location = new System.Drawing.Point(183, 138);
            this.lblreg.Name = "lblreg";
            this.lblreg.Size = new System.Drawing.Size(226, 23);
            this.lblreg.TabIndex = 2;
            this.lblreg.Text = "Registration Id : ";
            // 
            // txtreg
            // 
            this.txtreg.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtreg.Location = new System.Drawing.Point(399, 138);
            this.txtreg.Name = "txtreg";
            this.txtreg.Size = new System.Drawing.Size(141, 31);
            this.txtreg.TabIndex = 3;
            // 
            // btnsearch
            // 
            this.btnsearch.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(411, 199);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(93, 33);
            this.btnsearch.TabIndex = 4;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // displayInfo
            // 
            this.displayInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayInfo.Location = new System.Drawing.Point(25, 259);
            this.displayInfo.Name = "displayInfo";
            this.displayInfo.RowHeadersWidth = 51;
            this.displayInfo.RowTemplate.Height = 24;
            this.displayInfo.Size = new System.Drawing.Size(575, 371);
            this.displayInfo.TabIndex = 5;
            // 
            // SearchStudentr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(652, 642);
            this.Controls.Add(this.displayInfo);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtreg);
            this.Controls.Add(this.lblreg);
            this.Controls.Add(this.lblstudent);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SearchStudentr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchStudent";
            this.Load += new System.EventHandler(this.SearchStudentr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblstudent;
        private System.Windows.Forms.Label lblreg;
        private System.Windows.Forms.TextBox txtreg;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.DataGridView displayInfo;
    }
}