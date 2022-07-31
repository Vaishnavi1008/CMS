
namespace CMS
{
    partial class UpgradeSemester
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpgradeSemester));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblfrom = new System.Windows.Forms.Label();
            this.lblto = new System.Windows.Forms.Label();
            this.cbfrom = new System.Windows.Forms.ComboBox();
            this.cbto = new System.Windows.Forms.ComboBox();
            this.btnUpgrade = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Location = new System.Drawing.Point(131, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(327, 169);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(559, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Standard for Old Students";
            // 
            // lblfrom
            // 
            this.lblfrom.AutoSize = true;
            this.lblfrom.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfrom.Location = new System.Drawing.Point(90, 315);
            this.lblfrom.Name = "lblfrom";
            this.lblfrom.Size = new System.Drawing.Size(70, 23);
            this.lblfrom.TabIndex = 2;
            this.lblfrom.Text = "From ";
            // 
            // lblto
            // 
            this.lblto.AutoSize = true;
            this.lblto.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblto.Location = new System.Drawing.Point(90, 380);
            this.lblto.Name = "lblto";
            this.lblto.Size = new System.Drawing.Size(34, 23);
            this.lblto.TabIndex = 3;
            this.lblto.Text = "To";
            // 
            // cbfrom
            // 
            this.cbfrom.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbfrom.FormattingEnabled = true;
            this.cbfrom.Items.AddRange(new object[] {
            "1st Sem",
            "2nd Sem",
            "3rd Sem",
            "4th Sem",
            "5th Sem",
            "6th Sem",
            "7th Sem",
            "8th Sem"});
            this.cbfrom.Location = new System.Drawing.Point(266, 314);
            this.cbfrom.Name = "cbfrom";
            this.cbfrom.Size = new System.Drawing.Size(155, 31);
            this.cbfrom.TabIndex = 4;
            this.cbfrom.Text = "--Select--";
            // 
            // cbto
            // 
            this.cbto.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbto.FormattingEnabled = true;
            this.cbto.Items.AddRange(new object[] {
            "1st Sem",
            "2nd Sem",
            "3rd Sem",
            "4th Sem",
            "5th Sem",
            "6th Sem",
            "7th Sem",
            "8th Sem"});
            this.cbto.Location = new System.Drawing.Point(266, 383);
            this.cbto.Name = "cbto";
            this.cbto.Size = new System.Drawing.Size(155, 31);
            this.cbto.TabIndex = 5;
            this.cbto.Text = "--Select--";
            // 
            // btnUpgrade
            // 
            this.btnUpgrade.Font = new System.Drawing.Font("Lucida Sans Typewriter", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpgrade.Location = new System.Drawing.Point(266, 461);
            this.btnUpgrade.Name = "btnUpgrade";
            this.btnUpgrade.Size = new System.Drawing.Size(136, 47);
            this.btnUpgrade.TabIndex = 6;
            this.btnUpgrade.Text = "Upgrade";
            this.btnUpgrade.UseVisualStyleBackColor = true;
            this.btnUpgrade.Click += new System.EventHandler(this.btnUpgrade_Click);
            // 
            // UpgradeSemester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(586, 551);
            this.Controls.Add(this.btnUpgrade);
            this.Controls.Add(this.cbto);
            this.Controls.Add(this.cbfrom);
            this.Controls.Add(this.lblto);
            this.Controls.Add(this.lblfrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UpgradeSemester";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpgradeSemester";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblfrom;
        private System.Windows.Forms.Label lblto;
        private System.Windows.Forms.ComboBox cbfrom;
        private System.Windows.Forms.ComboBox cbto;
        private System.Windows.Forms.Button btnUpgrade;
    }
}