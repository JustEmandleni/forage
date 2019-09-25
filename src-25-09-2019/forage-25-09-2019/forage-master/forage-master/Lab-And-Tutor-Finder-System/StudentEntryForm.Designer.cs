namespace Lab_And_Tutor_Finder_System
{
    partial class StudentEntryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentEntryForm));
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.forageLabel = new System.Windows.Forms.Label();
            this.findMachineButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.forageGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.forageGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = global::Lab_And_Tutor_Finder_System.Properties.Resources.Application_Logo;
            this.logoPictureBox.Location = new System.Drawing.Point(257, 74);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(100, 102);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logoPictureBox.TabIndex = 3;
            this.logoPictureBox.TabStop = false;
            // 
            // forageLabel
            // 
            this.forageLabel.AutoSize = true;
            this.forageLabel.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forageLabel.Location = new System.Drawing.Point(211, 12);
            this.forageLabel.Margin = new System.Windows.Forms.Padding(0);
            this.forageLabel.Name = "forageLabel";
            this.forageLabel.Padding = new System.Windows.Forms.Padding(5);
            this.forageLabel.Size = new System.Drawing.Size(190, 66);
            this.forageLabel.TabIndex = 2;
            this.forageLabel.Text = "FORAGE";
            // 
            // findMachineButton
            // 
            this.findMachineButton.BackColor = System.Drawing.Color.DarkBlue;
            this.findMachineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findMachineButton.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findMachineButton.ForeColor = System.Drawing.Color.White;
            this.findMachineButton.Location = new System.Drawing.Point(29, 236);
            this.findMachineButton.Name = "findMachineButton";
            this.findMachineButton.Size = new System.Drawing.Size(219, 39);
            this.findMachineButton.TabIndex = 4;
            this.findMachineButton.Text = "Find a Machine";
            this.findMachineButton.UseVisualStyleBackColor = false;
            this.findMachineButton.Click += new System.EventHandler(this.findMachineButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(381, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "Find a Tutor";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // forageGroupBox
            // 
            this.forageGroupBox.Controls.Add(this.logoPictureBox);
            this.forageGroupBox.Controls.Add(this.forageLabel);
            this.forageGroupBox.Location = new System.Drawing.Point(8, 7);
            this.forageGroupBox.Name = "forageGroupBox";
            this.forageGroupBox.Size = new System.Drawing.Size(607, 316);
            this.forageGroupBox.TabIndex = 6;
            this.forageGroupBox.TabStop = false;
            // 
            // StudentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(628, 330);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.findMachineButton);
            this.Controls.Add(this.forageGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.StudentDashboardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.forageGroupBox.ResumeLayout(false);
            this.forageGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label forageLabel;
        private System.Windows.Forms.Button findMachineButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox forageGroupBox;
    }
}