namespace Lab_And_Tutor_Finder_System
{
    partial class ModuleListItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.moduleCodeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // moduleCodeLabel
            // 
            this.moduleCodeLabel.AutoSize = true;
            this.moduleCodeLabel.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moduleCodeLabel.Location = new System.Drawing.Point(14, 5);
            this.moduleCodeLabel.Name = "moduleCodeLabel";
            this.moduleCodeLabel.Size = new System.Drawing.Size(105, 32);
            this.moduleCodeLabel.TabIndex = 0;
            this.moduleCodeLabel.Text = "module";
            // 
            // ModuleListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.moduleCodeLabel);
            this.Name = "ModuleListItem";
            this.Size = new System.Drawing.Size(131, 43);
            this.Load += new System.EventHandler(this.ModuleListItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label moduleCodeLabel;
    }
}
