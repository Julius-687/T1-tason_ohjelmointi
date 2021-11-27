namespace Pudotusvalikko
{
    partial class avainhenkilot
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
            this.oppilaitosCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.VastuuHenkiloCB = new System.Windows.Forms.ComboBox();
            this.osoiteLB = new System.Windows.Forms.Label();
            this.postinumeroLB = new System.Windows.Forms.Label();
            this.postitoimipaikkaLB = new System.Windows.Forms.Label();
            this.puhelinLB = new System.Windows.Forms.Label();
            this.puhLB = new System.Windows.Forms.Label();
            this.emailLB = new System.Windows.Forms.Label();
            this.osastoLB = new System.Windows.Forms.Label();
            this.titteliLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oppilaitosten avainhenkilöt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valitse oppilaitos:";
            // 
            // oppilaitosCB
            // 
            this.oppilaitosCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oppilaitosCB.FormattingEnabled = true;
            this.oppilaitosCB.Location = new System.Drawing.Point(18, 103);
            this.oppilaitosCB.Name = "oppilaitosCB";
            this.oppilaitosCB.Size = new System.Drawing.Size(213, 32);
            this.oppilaitosCB.TabIndex = 2;
            this.oppilaitosCB.SelectedIndexChanged += new System.EventHandler(this.oppilaitosCB_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(342, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Valitse vastuuhenkilö:";
            // 
            // VastuuHenkiloCB
            // 
            this.VastuuHenkiloCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VastuuHenkiloCB.FormattingEnabled = true;
            this.VastuuHenkiloCB.Location = new System.Drawing.Point(346, 103);
            this.VastuuHenkiloCB.Name = "VastuuHenkiloCB";
            this.VastuuHenkiloCB.Size = new System.Drawing.Size(234, 32);
            this.VastuuHenkiloCB.TabIndex = 4;
            this.VastuuHenkiloCB.TextChanged += new System.EventHandler(this.VastuuHenkiloCB_TextChanged);
            // 
            // osoiteLB
            // 
            this.osoiteLB.AutoSize = true;
            this.osoiteLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.osoiteLB.Location = new System.Drawing.Point(15, 152);
            this.osoiteLB.Name = "osoiteLB";
            this.osoiteLB.Size = new System.Drawing.Size(64, 24);
            this.osoiteLB.TabIndex = 5;
            this.osoiteLB.Text = "Osoite";
            // 
            // postinumeroLB
            // 
            this.postinumeroLB.AutoSize = true;
            this.postinumeroLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postinumeroLB.Location = new System.Drawing.Point(15, 205);
            this.postinumeroLB.Name = "postinumeroLB";
            this.postinumeroLB.Size = new System.Drawing.Size(116, 24);
            this.postinumeroLB.TabIndex = 6;
            this.postinumeroLB.Text = "Postinumero";
            // 
            // postitoimipaikkaLB
            // 
            this.postitoimipaikkaLB.AutoSize = true;
            this.postitoimipaikkaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postitoimipaikkaLB.Location = new System.Drawing.Point(15, 258);
            this.postitoimipaikkaLB.Name = "postitoimipaikkaLB";
            this.postitoimipaikkaLB.Size = new System.Drawing.Size(142, 24);
            this.postitoimipaikkaLB.TabIndex = 7;
            this.postitoimipaikkaLB.Text = "Postitoimipaikka";
            // 
            // puhelinLB
            // 
            this.puhelinLB.AutoSize = true;
            this.puhelinLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puhelinLB.Location = new System.Drawing.Point(15, 311);
            this.puhelinLB.Name = "puhelinLB";
            this.puhelinLB.Size = new System.Drawing.Size(74, 24);
            this.puhelinLB.TabIndex = 8;
            this.puhelinLB.Text = "Puhelin";
            // 
            // puhLB
            // 
            this.puhLB.AutoSize = true;
            this.puhLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puhLB.Location = new System.Drawing.Point(342, 311);
            this.puhLB.Name = "puhLB";
            this.puhLB.Size = new System.Drawing.Size(74, 24);
            this.puhLB.TabIndex = 12;
            this.puhLB.Text = "Puhelin";
            // 
            // emailLB
            // 
            this.emailLB.AutoSize = true;
            this.emailLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLB.Location = new System.Drawing.Point(342, 258);
            this.emailLB.Name = "emailLB";
            this.emailLB.Size = new System.Drawing.Size(102, 24);
            this.emailLB.TabIndex = 11;
            this.emailLB.Text = "Sähköposti";
            // 
            // osastoLB
            // 
            this.osastoLB.AutoSize = true;
            this.osastoLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.osastoLB.Location = new System.Drawing.Point(342, 205);
            this.osastoLB.Name = "osastoLB";
            this.osastoLB.Size = new System.Drawing.Size(68, 24);
            this.osastoLB.TabIndex = 10;
            this.osastoLB.Text = "Osasto";
            // 
            // titteliLB
            // 
            this.titteliLB.AutoSize = true;
            this.titteliLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titteliLB.Location = new System.Drawing.Point(342, 152);
            this.titteliLB.Name = "titteliLB";
            this.titteliLB.Size = new System.Drawing.Size(53, 24);
            this.titteliLB.TabIndex = 9;
            this.titteliLB.Text = "Titteli";
            // 
            // avainhenkilot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 394);
            this.Controls.Add(this.puhLB);
            this.Controls.Add(this.emailLB);
            this.Controls.Add(this.osastoLB);
            this.Controls.Add(this.titteliLB);
            this.Controls.Add(this.puhelinLB);
            this.Controls.Add(this.postitoimipaikkaLB);
            this.Controls.Add(this.postinumeroLB);
            this.Controls.Add(this.osoiteLB);
            this.Controls.Add(this.VastuuHenkiloCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.oppilaitosCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "avainhenkilot";
            this.Text = "oppilaitosten avainhenkilöt";
            this.Load += new System.EventHandler(this.avainhenkilot_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox oppilaitosCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox VastuuHenkiloCB;
        private System.Windows.Forms.Label osoiteLB;
        private System.Windows.Forms.Label postinumeroLB;
        private System.Windows.Forms.Label postitoimipaikkaLB;
        private System.Windows.Forms.Label puhelinLB;
        private System.Windows.Forms.Label puhLB;
        private System.Windows.Forms.Label emailLB;
        private System.Windows.Forms.Label osastoLB;
        private System.Windows.Forms.Label titteliLB;
    }
}

