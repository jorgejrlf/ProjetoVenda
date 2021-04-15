
namespace ProjetoPessoal
{
    partial class SenhaLiberacaoSistema
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
            this.lblnumeroSerie = new System.Windows.Forms.Label();
            this.lbllicenca = new System.Windows.Forms.Label();
            this.txtnumeroSerie = new System.Windows.Forms.TextBox();
            this.txtlicenca = new System.Windows.Forms.TextBox();
            this.btnok = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnumeroSerie
            // 
            this.lblnumeroSerie.AutoSize = true;
            this.lblnumeroSerie.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumeroSerie.Location = new System.Drawing.Point(12, 25);
            this.lblnumeroSerie.Name = "lblnumeroSerie";
            this.lblnumeroSerie.Size = new System.Drawing.Size(140, 21);
            this.lblnumeroSerie.TabIndex = 0;
            this.lblnumeroSerie.Text = "Numero de serie:";
            // 
            // lbllicenca
            // 
            this.lbllicenca.AutoSize = true;
            this.lbllicenca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllicenca.Location = new System.Drawing.Point(12, 85);
            this.lbllicenca.Name = "lbllicenca";
            this.lbllicenca.Size = new System.Drawing.Size(71, 21);
            this.lbllicenca.TabIndex = 1;
            this.lbllicenca.Text = "Licença:";
            // 
            // txtnumeroSerie
            // 
            this.txtnumeroSerie.Enabled = false;
            this.txtnumeroSerie.Location = new System.Drawing.Point(158, 25);
            this.txtnumeroSerie.Name = "txtnumeroSerie";
            this.txtnumeroSerie.Size = new System.Drawing.Size(289, 20);
            this.txtnumeroSerie.TabIndex = 2;
            // 
            // txtlicenca
            // 
            this.txtlicenca.Location = new System.Drawing.Point(89, 86);
            this.txtlicenca.Name = "txtlicenca";
            this.txtlicenca.Size = new System.Drawing.Size(358, 20);
            this.txtlicenca.TabIndex = 3;
            this.txtlicenca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtlicenca_KeyDown);
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(134, 133);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(75, 23);
            this.btnok.TabIndex = 4;
            this.btnok.Text = "Ok";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(272, 133);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 5;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // SenhaLiberacaoSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 179);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.txtlicenca);
            this.Controls.Add(this.txtnumeroSerie);
            this.Controls.Add(this.lbllicenca);
            this.Controls.Add(this.lblnumeroSerie);
            this.Name = "SenhaLiberacaoSistema";
            this.Text = "SenhaLiberacaoSistema";
            this.Load += new System.EventHandler(this.SenhaLiberacaoSistema_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnumeroSerie;
        private System.Windows.Forms.Label lbllicenca;
        private System.Windows.Forms.TextBox txtnumeroSerie;
        private System.Windows.Forms.TextBox txtlicenca;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Button btncancelar;
    }
}