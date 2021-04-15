
namespace ProjetoPessoal
{
    partial class TelaPesquisa
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
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.grdPesquisa = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descição = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdPesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(23, 27);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(384, 27);
            this.txtPesquisa.TabIndex = 0;
            this.txtPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPesquisa_KeyDown);
            // 
            // grdPesquisa
            // 
            this.grdPesquisa.AllowUserToAddRows = false;
            this.grdPesquisa.AllowUserToDeleteRows = false;
            this.grdPesquisa.AllowUserToOrderColumns = true;
            this.grdPesquisa.BackgroundColor = System.Drawing.SystemColors.Window;
            this.grdPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPesquisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descição});
            this.grdPesquisa.Location = new System.Drawing.Point(24, 74);
            this.grdPesquisa.Name = "grdPesquisa";
            this.grdPesquisa.ReadOnly = true;
            this.grdPesquisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdPesquisa.Size = new System.Drawing.Size(382, 339);
            this.grdPesquisa.TabIndex = 1;
            this.grdPesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.grdPesquisa_KeyPress);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Descição
            // 
            this.Descição.HeaderText = "Descrição";
            this.Descição.Name = "Descição";
            this.Descição.ReadOnly = true;
            this.Descição.Width = 300;
            // 
            // TelaPesquisa
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(424, 431);
            this.ControlBox = false;
            this.Controls.Add(this.grdPesquisa);
            this.Controls.Add(this.txtPesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "TelaPesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaPesquisa";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TelaPesquisa_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.grdPesquisa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.DataGridView grdPesquisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descição;
    }
}