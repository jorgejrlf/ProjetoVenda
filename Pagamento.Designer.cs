
namespace ProjetoPessoal
{
    partial class Pagamento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdCondicaoPagamento = new System.Windows.Forms.DataGridView();
            this.DescricaoPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblValorTotal = new System.Windows.Forms.Label();
            this.txtValorPagamento = new System.Windows.Forms.TextBox();
            this.lblValorRestante = new System.Windows.Forms.Label();
            this.txtValorRestante = new System.Windows.Forms.TextBox();
            this.txtValorFinalizadora = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdCondicaoPagamento)).BeginInit();
            this.SuspendLayout();
            // 
            // grdCondicaoPagamento
            // 
            this.grdCondicaoPagamento.AllowUserToAddRows = false;
            this.grdCondicaoPagamento.AllowUserToDeleteRows = false;
            this.grdCondicaoPagamento.AllowUserToResizeColumns = false;
            this.grdCondicaoPagamento.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdCondicaoPagamento.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdCondicaoPagamento.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.grdCondicaoPagamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdCondicaoPagamento.ColumnHeadersVisible = false;
            this.grdCondicaoPagamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DescricaoPagamento});
            this.grdCondicaoPagamento.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.grdCondicaoPagamento.ImeMode = System.Windows.Forms.ImeMode.On;
            this.grdCondicaoPagamento.Location = new System.Drawing.Point(33, 121);
            this.grdCondicaoPagamento.MultiSelect = false;
            this.grdCondicaoPagamento.Name = "grdCondicaoPagamento";
            this.grdCondicaoPagamento.ReadOnly = true;
            this.grdCondicaoPagamento.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdCondicaoPagamento.RowHeadersVisible = false;
            this.grdCondicaoPagamento.RowTemplate.Height = 50;
            this.grdCondicaoPagamento.RowTemplate.ReadOnly = true;
            this.grdCondicaoPagamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grdCondicaoPagamento.ShowRowErrors = false;
            this.grdCondicaoPagamento.Size = new System.Drawing.Size(489, 205);
            this.grdCondicaoPagamento.TabIndex = 0;
            this.grdCondicaoPagamento.UseWaitCursor = true;
            this.grdCondicaoPagamento.Enter += new System.EventHandler(this.grdCondicaoPagamento_Enter);
            this.grdCondicaoPagamento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdCondicaoPagamento_KeyDown);
            // 
            // DescricaoPagamento
            // 
            this.DescricaoPagamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            this.DescricaoPagamento.DefaultCellStyle = dataGridViewCellStyle2;
            this.DescricaoPagamento.HeaderText = "";
            this.DescricaoPagamento.Name = "DescricaoPagamento";
            this.DescricaoPagamento.ReadOnly = true;
            this.DescricaoPagamento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DescricaoPagamento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DescricaoPagamento.Width = 500;
            // 
            // LblValorTotal
            // 
            this.LblValorTotal.AutoSize = true;
            this.LblValorTotal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValorTotal.Location = new System.Drawing.Point(20, 27);
            this.LblValorTotal.Name = "LblValorTotal";
            this.LblValorTotal.Size = new System.Drawing.Size(102, 18);
            this.LblValorTotal.TabIndex = 1;
            this.LblValorTotal.Text = "Valor Total:";
            // 
            // txtValorPagamento
            // 
            this.txtValorPagamento.BackColor = System.Drawing.Color.Azure;
            this.txtValorPagamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValorPagamento.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorPagamento.Location = new System.Drawing.Point(128, 19);
            this.txtValorPagamento.Name = "txtValorPagamento";
            this.txtValorPagamento.Size = new System.Drawing.Size(143, 26);
            this.txtValorPagamento.TabIndex = 2;
            // 
            // lblValorRestante
            // 
            this.lblValorRestante.AutoSize = true;
            this.lblValorRestante.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorRestante.Location = new System.Drawing.Point(282, 27);
            this.lblValorRestante.Name = "lblValorRestante";
            this.lblValorRestante.Size = new System.Drawing.Size(136, 18);
            this.lblValorRestante.TabIndex = 3;
            this.lblValorRestante.Text = "Valor Restante:";
            // 
            // txtValorRestante
            // 
            this.txtValorRestante.BackColor = System.Drawing.Color.Azure;
            this.txtValorRestante.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValorRestante.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorRestante.Location = new System.Drawing.Point(424, 19);
            this.txtValorRestante.Name = "txtValorRestante";
            this.txtValorRestante.Size = new System.Drawing.Size(124, 26);
            this.txtValorRestante.TabIndex = 4;
            // 
            // txtValorFinalizadora
            // 
            this.txtValorFinalizadora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValorFinalizadora.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorFinalizadora.Location = new System.Drawing.Point(180, 77);
            this.txtValorFinalizadora.Name = "txtValorFinalizadora";
            this.txtValorFinalizadora.Size = new System.Drawing.Size(150, 26);
            this.txtValorFinalizadora.TabIndex = 5;
            this.txtValorFinalizadora.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValorFinalizadora_KeyDown);
            this.txtValorFinalizadora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorFinalizadora_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Valor Pagamento:";
            // 
            // Pagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(566, 342);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValorFinalizadora);
            this.Controls.Add(this.txtValorRestante);
            this.Controls.Add(this.lblValorRestante);
            this.Controls.Add(this.txtValorPagamento);
            this.Controls.Add(this.LblValorTotal);
            this.Controls.Add(this.grdCondicaoPagamento);
            this.Name = "Pagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagamento";
            this.Shown += new System.EventHandler(this.Pagamento_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.grdCondicaoPagamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblValorTotal;
        private System.Windows.Forms.TextBox txtValorPagamento;
        private System.Windows.Forms.Label lblValorRestante;
        private System.Windows.Forms.TextBox txtValorRestante;
        public System.Windows.Forms.DataGridView grdCondicaoPagamento;
        private System.Windows.Forms.TextBox txtValorFinalizadora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescricaoPagamento;
    }
}