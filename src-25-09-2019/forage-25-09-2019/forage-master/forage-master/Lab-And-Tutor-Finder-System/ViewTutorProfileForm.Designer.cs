namespace Lab_And_Tutor_Finder_System
{
    partial class ViewTutorProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewTutorProfileForm));
            this.labelHeader = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AboutLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.rateLabel = new System.Windows.Forms.Label();
            this.qualificationLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.ForeColor = System.Drawing.Color.Black;
            this.labelHeader.Location = new System.Drawing.Point(190, 2);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(206, 56);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "Profile";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.labelHeader);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(577, 61);
            this.panel1.TabIndex = 2;
            // 
            // AboutLabel
            // 
            this.AboutLabel.AutoSize = true;
            this.AboutLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutLabel.Location = new System.Drawing.Point(243, 254);
            this.AboutLabel.Name = "AboutLabel";
            this.AboutLabel.Padding = new System.Windows.Forms.Padding(5);
            this.AboutLabel.Size = new System.Drawing.Size(50, 32);
            this.AboutLabel.TabIndex = 28;
            this.AboutLabel.Text = "Bio";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLabel.Location = new System.Drawing.Point(243, 220);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Padding = new System.Windows.Forms.Padding(5);
            this.yearLabel.Size = new System.Drawing.Size(100, 32);
            this.yearLabel.TabIndex = 27;
            this.yearLabel.Text = "Modules:";
            // 
            // rateLabel
            // 
            this.rateLabel.AutoSize = true;
            this.rateLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rateLabel.Location = new System.Drawing.Point(242, 186);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Padding = new System.Windows.Forms.Padding(5);
            this.rateLabel.Size = new System.Drawing.Size(160, 32);
            this.rateLabel.TabIndex = 26;
            this.rateLabel.Text = "Rate per hour:";
            // 
            // qualificationLabel
            // 
            this.qualificationLabel.AutoSize = true;
            this.qualificationLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qualificationLabel.Location = new System.Drawing.Point(242, 153);
            this.qualificationLabel.Name = "qualificationLabel";
            this.qualificationLabel.Padding = new System.Windows.Forms.Padding(5);
            this.qualificationLabel.Size = new System.Drawing.Size(70, 32);
            this.qualificationLabel.TabIndex = 25;
            this.qualificationLabel.Text = "Year:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(241, 117);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Padding = new System.Windows.Forms.Padding(5);
            this.lastNameLabel.Size = new System.Drawing.Size(110, 32);
            this.lastNameLabel.TabIndex = 24;
            this.lastNameLabel.Text = "Studying:";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(240, 80);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Padding = new System.Windows.Forms.Padding(5);
            this.firstNameLabel.Size = new System.Drawing.Size(248, 34);
            this.firstNameLabel.TabIndex = 23;
            this.firstNameLabel.Text = "Full name goes here";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lab_And_Tutor_Finder_System.Properties.Resources.Tutor_explains_math_problem_icon_math_tutor_png_512_512_preview1;
            this.pictureBox1.Location = new System.Drawing.Point(6, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(289, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 39);
            this.button1.TabIndex = 35;
            this.button1.Text = "Request";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkOrange;
            this.button2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(434, 330);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 39);
            this.button2.TabIndex = 36;
            this.button2.Text = "Rate";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // ViewTutorProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(581, 380);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AboutLabel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.rateLabel);
            this.Controls.Add(this.qualificationLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewTutorProfileForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label AboutLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label rateLabel;
        private System.Windows.Forms.Label qualificationLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}