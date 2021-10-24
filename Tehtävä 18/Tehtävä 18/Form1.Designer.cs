
namespace Tehtävä_18
{
    partial class AvainhenkilotForm
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
            this.VastuuhenkiloCB = new System.Windows.Forms.ComboBox();
            this.OppilaitosCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OsoiteLB = new System.Windows.Forms.Label();
            this.PostinumeroLB = new System.Windows.Forms.Label();
            this.PostitoimipaikkaLB = new System.Windows.Forms.Label();
            this.PuhelinLB = new System.Windows.Forms.Label();
            this.TitteliLB = new System.Windows.Forms.Label();
            this.OsastoLB = new System.Windows.Forms.Label();
            this.SahkopostiLB = new System.Windows.Forms.Label();
            this.PuhLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valitse vastuuhenkilö:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(606, 65);
            this.label2.TabIndex = 1;
            this.label2.Text = "Oppilaitosten avainhenkilöt";
            // 
            // VastuuhenkiloCB
            // 
            this.VastuuhenkiloCB.FormattingEnabled = true;
            this.VastuuhenkiloCB.Location = new System.Drawing.Point(316, 139);
            this.VastuuhenkiloCB.Name = "VastuuhenkiloCB";
            this.VastuuhenkiloCB.Size = new System.Drawing.Size(303, 33);
            this.VastuuhenkiloCB.TabIndex = 2;
            this.VastuuhenkiloCB.SelectedIndexChanged += new System.EventHandler(this.VastuuhenkiloCB_SelectedIndexChanged);
            // 
            // OppilaitosCB
            // 
            this.OppilaitosCB.FormattingEnabled = true;
            this.OppilaitosCB.Location = new System.Drawing.Point(24, 139);
            this.OppilaitosCB.Name = "OppilaitosCB";
            this.OppilaitosCB.Size = new System.Drawing.Size(226, 33);
            this.OppilaitosCB.TabIndex = 2;
            this.OppilaitosCB.SelectedIndexChanged += new System.EventHandler(this.OppilaitosCB_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Valitse oppilaitos:";
            // 
            // OsoiteLB
            // 
            this.OsoiteLB.AutoSize = true;
            this.OsoiteLB.Location = new System.Drawing.Point(19, 199);
            this.OsoiteLB.Name = "OsoiteLB";
            this.OsoiteLB.Size = new System.Drawing.Size(66, 25);
            this.OsoiteLB.TabIndex = 0;
            this.OsoiteLB.Text = "Osoite";
            // 
            // PostinumeroLB
            // 
            this.PostinumeroLB.AutoSize = true;
            this.PostinumeroLB.Location = new System.Drawing.Point(19, 239);
            this.PostinumeroLB.Name = "PostinumeroLB";
            this.PostinumeroLB.Size = new System.Drawing.Size(118, 25);
            this.PostinumeroLB.TabIndex = 0;
            this.PostinumeroLB.Text = "Postinumero";
            // 
            // PostitoimipaikkaLB
            // 
            this.PostitoimipaikkaLB.AutoSize = true;
            this.PostitoimipaikkaLB.Location = new System.Drawing.Point(19, 279);
            this.PostitoimipaikkaLB.Name = "PostitoimipaikkaLB";
            this.PostitoimipaikkaLB.Size = new System.Drawing.Size(149, 25);
            this.PostitoimipaikkaLB.TabIndex = 0;
            this.PostitoimipaikkaLB.Text = "Postitoimipaikka";
            // 
            // PuhelinLB
            // 
            this.PuhelinLB.AutoSize = true;
            this.PuhelinLB.Location = new System.Drawing.Point(19, 319);
            this.PuhelinLB.Name = "PuhelinLB";
            this.PuhelinLB.Size = new System.Drawing.Size(76, 25);
            this.PuhelinLB.TabIndex = 0;
            this.PuhelinLB.Text = "Puhelin";
            // 
            // TitteliLB
            // 
            this.TitteliLB.AutoSize = true;
            this.TitteliLB.Location = new System.Drawing.Point(370, 199);
            this.TitteliLB.Name = "TitteliLB";
            this.TitteliLB.Size = new System.Drawing.Size(59, 25);
            this.TitteliLB.TabIndex = 0;
            this.TitteliLB.Text = "Titteli";
            // 
            // OsastoLB
            // 
            this.OsastoLB.AutoSize = true;
            this.OsastoLB.Location = new System.Drawing.Point(370, 243);
            this.OsastoLB.Name = "OsastoLB";
            this.OsastoLB.Size = new System.Drawing.Size(69, 25);
            this.OsastoLB.TabIndex = 0;
            this.OsastoLB.Text = "Osasto";
            // 
            // SahkopostiLB
            // 
            this.SahkopostiLB.AutoSize = true;
            this.SahkopostiLB.Location = new System.Drawing.Point(370, 282);
            this.SahkopostiLB.Name = "SahkopostiLB";
            this.SahkopostiLB.Size = new System.Drawing.Size(104, 25);
            this.SahkopostiLB.TabIndex = 0;
            this.SahkopostiLB.Text = "Sähköposti";
            // 
            // PuhLB
            // 
            this.PuhLB.AutoSize = true;
            this.PuhLB.Location = new System.Drawing.Point(370, 321);
            this.PuhLB.Name = "PuhLB";
            this.PuhLB.Size = new System.Drawing.Size(76, 25);
            this.PuhLB.TabIndex = 0;
            this.PuhLB.Text = "Puhelin";
            // 
            // AvainhenkilotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 386);
            this.Controls.Add(this.OppilaitosCB);
            this.Controls.Add(this.VastuuhenkiloCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PuhLB);
            this.Controls.Add(this.PuhelinLB);
            this.Controls.Add(this.SahkopostiLB);
            this.Controls.Add(this.PostitoimipaikkaLB);
            this.Controls.Add(this.OsastoLB);
            this.Controls.Add(this.PostinumeroLB);
            this.Controls.Add(this.TitteliLB);
            this.Controls.Add(this.OsoiteLB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AvainhenkilotForm";
            this.Text = "Oppilaitosten avainhenkilöt";
            this.Load += new System.EventHandler(this.AvainhenkilotForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox VastuuhenkiloCB;
        private System.Windows.Forms.ComboBox OppilaitosCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label OsoiteLB;
        private System.Windows.Forms.Label PostinumeroLB;
        private System.Windows.Forms.Label PostitoimipaikkaLB;
        private System.Windows.Forms.Label PuhelinLB;
        private System.Windows.Forms.Label TitteliLB;
        private System.Windows.Forms.Label OsastoLB;
        private System.Windows.Forms.Label SahkopostiLB;
        private System.Windows.Forms.Label PuhLB;
    }
}

