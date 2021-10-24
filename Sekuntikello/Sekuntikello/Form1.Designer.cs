
namespace Sekuntikello
{
    partial class SekkariForm
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
            this.components = new System.ComponentModel.Container();
            this.AikaLB = new System.Windows.Forms.Label();
            this.KaynnistaBT = new System.Windows.Forms.Button();
            this.LopetaBT = new System.Windows.Forms.Button();
            this.TyhjennaBT = new System.Windows.Forms.Button();
            this.Ajastin = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // AikaLB
            // 
            this.AikaLB.AutoSize = true;
            this.AikaLB.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AikaLB.Location = new System.Drawing.Point(13, 13);
            this.AikaLB.Name = "AikaLB";
            this.AikaLB.Size = new System.Drawing.Size(586, 128);
            this.AikaLB.TabIndex = 0;
            this.AikaLB.Text = "00:00:00:000";
            // 
            // KaynnistaBT
            // 
            this.KaynnistaBT.Location = new System.Drawing.Point(35, 204);
            this.KaynnistaBT.Name = "KaynnistaBT";
            this.KaynnistaBT.Size = new System.Drawing.Size(130, 94);
            this.KaynnistaBT.TabIndex = 1;
            this.KaynnistaBT.Text = "Käynnistä";
            this.KaynnistaBT.UseVisualStyleBackColor = true;
            this.KaynnistaBT.Click += new System.EventHandler(this.KaynnistaBT_Click);
            // 
            // LopetaBT
            // 
            this.LopetaBT.Location = new System.Drawing.Point(225, 204);
            this.LopetaBT.Name = "LopetaBT";
            this.LopetaBT.Size = new System.Drawing.Size(130, 94);
            this.LopetaBT.TabIndex = 2;
            this.LopetaBT.Text = "Lopeta";
            this.LopetaBT.UseVisualStyleBackColor = true;
            this.LopetaBT.Click += new System.EventHandler(this.LopetaBT_Click);
            // 
            // TyhjennaBT
            // 
            this.TyhjennaBT.Location = new System.Drawing.Point(411, 204);
            this.TyhjennaBT.Name = "TyhjennaBT";
            this.TyhjennaBT.Size = new System.Drawing.Size(130, 94);
            this.TyhjennaBT.TabIndex = 3;
            this.TyhjennaBT.Text = "Tyhjennä";
            this.TyhjennaBT.UseVisualStyleBackColor = true;
            this.TyhjennaBT.Click += new System.EventHandler(this.TyhjennaBT_Click);
            // 
            // Ajastin
            // 
            this.Ajastin.Enabled = true;
            this.Ajastin.Tick += new System.EventHandler(this.Ajastin_Tick);
            // 
            // SekkariForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 339);
            this.Controls.Add(this.TyhjennaBT);
            this.Controls.Add(this.LopetaBT);
            this.Controls.Add(this.KaynnistaBT);
            this.Controls.Add(this.AikaLB);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "SekkariForm";
            this.Text = "Sekuntikello";
            this.Load += new System.EventHandler(this.SekkariForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AikaLB;
        private System.Windows.Forms.Button KaynnistaBT;
        private System.Windows.Forms.Button LopetaBT;
        private System.Windows.Forms.Button TyhjennaBT;
        private System.Windows.Forms.Timer Ajastin;
    }
}

