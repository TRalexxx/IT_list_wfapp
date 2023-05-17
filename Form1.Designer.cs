namespace IT_list_wfapp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.nameCityL = new System.Windows.Forms.Label();
            this.emplCountFL = new System.Windows.Forms.Label();
            this.enBtn = new System.Windows.Forms.Button();
            this.geBtn = new System.Windows.Forms.Button();
            this.ruBtn = new System.Windows.Forms.Button();
            this.ukrBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameCityL
            // 
            resources.ApplyResources(this.nameCityL, "nameCityL");
            this.nameCityL.Name = "nameCityL";
            // 
            // emplCountFL
            // 
            resources.ApplyResources(this.emplCountFL, "emplCountFL");
            this.emplCountFL.Name = "emplCountFL";
            // 
            // enBtn
            // 
            resources.ApplyResources(this.enBtn, "enBtn");
            this.enBtn.Name = "enBtn";
            this.enBtn.UseVisualStyleBackColor = true;
            this.enBtn.Click += new System.EventHandler(this.enBtn_Click);
            // 
            // geBtn
            // 
            resources.ApplyResources(this.geBtn, "geBtn");
            this.geBtn.Name = "geBtn";
            this.geBtn.UseVisualStyleBackColor = true;
            this.geBtn.Click += new System.EventHandler(this.geBtn_Click);
            // 
            // ruBtn
            // 
            resources.ApplyResources(this.ruBtn, "ruBtn");
            this.ruBtn.Name = "ruBtn";
            this.ruBtn.UseVisualStyleBackColor = true;
            this.ruBtn.Click += new System.EventHandler(this.ruBtn_Click);
            // 
            // ukrBtn
            // 
            resources.ApplyResources(this.ukrBtn, "ukrBtn");
            this.ukrBtn.Name = "ukrBtn";
            this.ukrBtn.UseVisualStyleBackColor = true;
            this.ukrBtn.Click += new System.EventHandler(this.ukrBtn_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ukrBtn);
            this.Controls.Add(this.ruBtn);
            this.Controls.Add(this.geBtn);
            this.Controls.Add(this.enBtn);
            this.Controls.Add(this.emplCountFL);
            this.Controls.Add(this.nameCityL);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameCityL;
        private System.Windows.Forms.Label emplCountFL;
        private System.Windows.Forms.Button enBtn;
        private System.Windows.Forms.Button geBtn;
        private System.Windows.Forms.Button ruBtn;
        private System.Windows.Forms.Button ukrBtn;
    }
}

