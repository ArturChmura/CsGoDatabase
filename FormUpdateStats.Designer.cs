namespace CsGoDatabase
{
    partial class FormUpdateStats
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelKills = new System.Windows.Forms.Label();
            this.numericKills = new System.Windows.Forms.NumericUpDown();
            this.numericDeaths = new System.Windows.Forms.NumericUpDown();
            this.labelDeaths = new System.Windows.Forms.Label();
            this.numericPoints = new System.Windows.Forms.NumericUpDown();
            this.labelPoints = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericKills)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDeaths)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAdd.Location = new System.Drawing.Point(265, 153);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(251, 78);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Update";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelKills
            // 
            this.labelKills.AutoSize = true;
            this.labelKills.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKills.Location = new System.Drawing.Point(183, 88);
            this.labelKills.Name = "labelKills";
            this.labelKills.Size = new System.Drawing.Size(36, 20);
            this.labelKills.TabIndex = 6;
            this.labelKills.Text = "Kills";
            // 
            // numericKills
            // 
            this.numericKills.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.numericKills.Location = new System.Drawing.Point(187, 112);
            this.numericKills.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numericKills.Name = "numericKills";
            this.numericKills.Size = new System.Drawing.Size(120, 20);
            this.numericKills.TabIndex = 1;
            // 
            // numericDeaths
            // 
            this.numericDeaths.Location = new System.Drawing.Point(337, 112);
            this.numericDeaths.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericDeaths.Name = "numericDeaths";
            this.numericDeaths.Size = new System.Drawing.Size(120, 20);
            this.numericDeaths.TabIndex = 2;
            // 
            // labelDeaths
            // 
            this.labelDeaths.AutoSize = true;
            this.labelDeaths.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDeaths.Location = new System.Drawing.Point(333, 88);
            this.labelDeaths.Name = "labelDeaths";
            this.labelDeaths.Size = new System.Drawing.Size(61, 20);
            this.labelDeaths.TabIndex = 11;
            this.labelDeaths.Text = "Deaths";
            // 
            // numericPoints
            // 
            this.numericPoints.Location = new System.Drawing.Point(479, 112);
            this.numericPoints.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericPoints.Name = "numericPoints";
            this.numericPoints.Size = new System.Drawing.Size(120, 20);
            this.numericPoints.TabIndex = 3;
            // 
            // labelPoints
            // 
            this.labelPoints.AutoSize = true;
            this.labelPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPoints.Location = new System.Drawing.Point(475, 88);
            this.labelPoints.Name = "labelPoints";
            this.labelPoints.Size = new System.Drawing.Size(53, 20);
            this.labelPoints.TabIndex = 13;
            this.labelPoints.Text = "Points";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(34, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 26);
            this.label1.TabIndex = 21;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(771, 26);
            this.label2.TabIndex = 22;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormUpdateStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 281);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericPoints);
            this.Controls.Add(this.labelPoints);
            this.Controls.Add(this.numericDeaths);
            this.Controls.Add(this.labelDeaths);
            this.Controls.Add(this.numericKills);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelKills);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormUpdateStats";
            this.Text = "FormAddStats";
            ((System.ComponentModel.ISupportInitialize)(this.numericKills)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDeaths)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPoints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelKills;
        private System.Windows.Forms.NumericUpDown numericKills;
        private System.Windows.Forms.NumericUpDown numericDeaths;
        private System.Windows.Forms.Label labelDeaths;
        private System.Windows.Forms.NumericUpDown numericPoints;
        private System.Windows.Forms.Label labelPoints;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}