
namespace BMI_laskuri
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.VastausLB = new System.Windows.Forms.Label();
            this.KuvausLB = new System.Windows.Forms.Label();
            this.PainoTB = new System.Windows.Forms.TextBox();
            this.PituusTB = new System.Windows.Forms.TextBox();
            this.LaskeBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anna paino:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Anna pituus:";
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Location = new System.Drawing.Point(12, 177);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(76, 25);
            this.VastausLB.TabIndex = 2;
            this.VastausLB.Text = "Vastaus";
            this.VastausLB.Visible = false;
            // 
            // KuvausLB
            // 
            this.KuvausLB.AutoSize = true;
            this.KuvausLB.Location = new System.Drawing.Point(12, 226);
            this.KuvausLB.Name = "KuvausLB";
            this.KuvausLB.Size = new System.Drawing.Size(72, 25);
            this.KuvausLB.TabIndex = 3;
            this.KuvausLB.Text = "Kuvaus";
            this.KuvausLB.Visible = false;
            // 
            // PainoTB
            // 
            this.PainoTB.Location = new System.Drawing.Point(153, 13);
            this.PainoTB.Name = "PainoTB";
            this.PainoTB.Size = new System.Drawing.Size(100, 33);
            this.PainoTB.TabIndex = 4;
            // 
            // PituusTB
            // 
            this.PituusTB.Location = new System.Drawing.Point(153, 61);
            this.PituusTB.Name = "PituusTB";
            this.PituusTB.Size = new System.Drawing.Size(100, 33);
            this.PituusTB.TabIndex = 4;
            // 
            // LaskeBT
            // 
            this.LaskeBT.Location = new System.Drawing.Point(17, 109);
            this.LaskeBT.Name = "LaskeBT";
            this.LaskeBT.Size = new System.Drawing.Size(236, 45);
            this.LaskeBT.TabIndex = 5;
            this.LaskeBT.Text = "Laske painoindeksi";
            this.LaskeBT.UseVisualStyleBackColor = true;
            this.LaskeBT.Click += new System.EventHandler(this.LaskeBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 291);
            this.Controls.Add(this.LaskeBT);
            this.Controls.Add(this.PituusTB);
            this.Controls.Add(this.PainoTB);
            this.Controls.Add(this.KuvausLB);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label VastausLB;
        private System.Windows.Forms.Label KuvausLB;
        private System.Windows.Forms.TextBox PainoTB;
        private System.Windows.Forms.TextBox PituusTB;
        private System.Windows.Forms.Button LaskeBT;
    }
}

