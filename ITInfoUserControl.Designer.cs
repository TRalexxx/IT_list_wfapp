namespace IT_list_wfapp
{
    partial class ITInfoUserControl
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
            this.comapanyNameL = new System.Windows.Forms.Label();
            this.emplCountL = new System.Windows.Forms.Label();
            this.citiesL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comapanyNameL
            // 
            this.comapanyNameL.AutoSize = true;
            this.comapanyNameL.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comapanyNameL.Location = new System.Drawing.Point(4, 4);
            this.comapanyNameL.Name = "comapanyNameL";
            this.comapanyNameL.Size = new System.Drawing.Size(54, 21);
            this.comapanyNameL.TabIndex = 0;
            this.comapanyNameL.Text = "label1";
            // 
            // emplCountL
            // 
            this.emplCountL.AutoSize = true;
            this.emplCountL.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emplCountL.Location = new System.Drawing.Point(405, 9);
            this.emplCountL.Name = "emplCountL";
            this.emplCountL.Size = new System.Drawing.Size(45, 16);
            this.emplCountL.TabIndex = 1;
            this.emplCountL.Text = "label2";
            // 
            // citiesL
            // 
            this.citiesL.Location = new System.Drawing.Point(8, 29);
            this.citiesL.Name = "citiesL";
            this.citiesL.Size = new System.Drawing.Size(323, 35);
            this.citiesL.TabIndex = 2;
            this.citiesL.Text = "label1";
            // 
            // ITInfoUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.citiesL);
            this.Controls.Add(this.emplCountL);
            this.Controls.Add(this.comapanyNameL);
            this.Name = "ITInfoUserControl";
            this.Size = new System.Drawing.Size(628, 64);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label comapanyNameL;
        private System.Windows.Forms.Label emplCountL;
        private System.Windows.Forms.Label citiesL;
    }
}
