namespace WindowsFormsApplication1
{
    partial class Sastavljanje
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
            this.label6 = new System.Windows.Forms.Label();
            this.sastavi = new System.Windows.Forms.Button();
            this.kraj_rada = new System.Windows.Forms.Button();
            this.tbBrojSastavljanja = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Broj sastavljanja";
            // 
            // sastavi
            // 
            this.sastavi.Location = new System.Drawing.Point(9, 82);
            this.sastavi.Name = "sastavi";
            this.sastavi.Size = new System.Drawing.Size(188, 23);
            this.sastavi.TabIndex = 2;
            this.sastavi.Text = "Sastavi";
            this.sastavi.UseVisualStyleBackColor = true;
            this.sastavi.Click += new System.EventHandler(this.sastavi_Click);
            // 
            // kraj_rada
            // 
            this.kraj_rada.Location = new System.Drawing.Point(9, 111);
            this.kraj_rada.Name = "kraj_rada";
            this.kraj_rada.Size = new System.Drawing.Size(188, 23);
            this.kraj_rada.TabIndex = 3;
            this.kraj_rada.Text = "Kraj rada";
            this.kraj_rada.UseVisualStyleBackColor = true;
            this.kraj_rada.Click += new System.EventHandler(this.kraj_rada_Click);
            // 
            // tbBrojSastavljanja
            // 
            this.tbBrojSastavljanja.Location = new System.Drawing.Point(145, 46);
            this.tbBrojSastavljanja.Name = "tbBrojSastavljanja";
            this.tbBrojSastavljanja.Size = new System.Drawing.Size(52, 20);
            this.tbBrojSastavljanja.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Model racunara";
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(145, 6);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(52, 20);
            this.tbModel.TabIndex = 0;
            // 
            // Sastavljanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 142);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.kraj_rada);
            this.Controls.Add(this.sastavi);
            this.Controls.Add(this.tbBrojSastavljanja);
            this.Controls.Add(this.label6);
            this.Name = "Sastavljanje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sastavljanje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button sastavi;
        private System.Windows.Forms.Button kraj_rada;
        private System.Windows.Forms.TextBox tbBrojSastavljanja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbModel;
    }
}