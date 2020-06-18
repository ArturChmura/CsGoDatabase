namespace CsGoDatabase
{
    partial class FormAddTeam
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
            this.textBoxTeamName = new System.Windows.Forms.TextBox();
            this.labelTeamName = new System.Windows.Forms.Label();
            this.labelTeamNation = new System.Windows.Forms.Label();
            this.textBoxTeamNation = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxTeamName
            // 
            this.textBoxTeamName.Location = new System.Drawing.Point(39, 60);
            this.textBoxTeamName.MaxLength = 50;
            this.textBoxTeamName.Name = "textBoxTeamName";
            this.textBoxTeamName.Size = new System.Drawing.Size(227, 20);
            this.textBoxTeamName.TabIndex = 0;
            // 
            // labelTeamName
            // 
            this.labelTeamName.AutoSize = true;
            this.labelTeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTeamName.Location = new System.Drawing.Point(107, 37);
            this.labelTeamName.Name = "labelTeamName";
            this.labelTeamName.Size = new System.Drawing.Size(95, 20);
            this.labelTeamName.TabIndex = 1;
            this.labelTeamName.Text = "Team Name";
            // 
            // labelTeamNation
            // 
            this.labelTeamNation.AutoSize = true;
            this.labelTeamNation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTeamNation.Location = new System.Drawing.Point(348, 37);
            this.labelTeamNation.Name = "labelTeamNation";
            this.labelTeamNation.Size = new System.Drawing.Size(99, 20);
            this.labelTeamNation.TabIndex = 3;
            this.labelTeamNation.Text = "Team Nation";
            // 
            // textBoxTeamNation
            // 
            this.textBoxTeamNation.Location = new System.Drawing.Point(285, 60);
            this.textBoxTeamNation.MaxLength = 50;
            this.textBoxTeamNation.Name = "textBoxTeamNation";
            this.textBoxTeamNation.Size = new System.Drawing.Size(227, 20);
            this.textBoxTeamNation.TabIndex = 2;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAdd.Location = new System.Drawing.Point(147, 99);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(251, 78);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // FormAddTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 220);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelTeamNation);
            this.Controls.Add(this.textBoxTeamNation);
            this.Controls.Add(this.labelTeamName);
            this.Controls.Add(this.textBoxTeamName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormAddTeam";
            this.Text = "FormAddTeam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTeamName;
        private System.Windows.Forms.Label labelTeamName;
        private System.Windows.Forms.Label labelTeamNation;
        private System.Windows.Forms.TextBox textBoxTeamNation;
        private System.Windows.Forms.Button buttonAdd;
    }
}