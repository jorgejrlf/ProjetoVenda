
namespace ProjetoPessoal
{
    partial class TelaVenda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaVenda));
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtTotalProduto = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtPrecoUnitario = new System.Windows.Forms.TextBox();
            this.txtTotalCupom = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblPrecoUnitario = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblTotalProduto = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodigoProduto = new System.Windows.Forms.TextBox();
            this.GridCupom = new System.Windows.Forms.DataGridView();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prunit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.IconPagamento = new System.Windows.Forms.ToolStripButton();
            this.IconCancelamento = new System.Windows.Forms.ToolStripButton();
            this.IconSair = new System.Windows.Forms.ToolStripButton();
            this.grdPesquisa = new System.Windows.Forms.DataGridView();
            this.Codbarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescricaoPesquisa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrVendaPesquisa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrupoPesquisa = new System.Windows.Forms.GroupBox();
            this.txtDescricaoPesquisa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridCupom)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPesquisa)).BeginInit();
            this.GrupoPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDescricao
            // 
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Enabled = false;
            this.txtDescricao.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtDescricao.Location = new System.Drawing.Point(22, 24);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(1326, 52);
            this.txtDescricao.TabIndex = 0;
            this.txtDescricao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalProduto
            // 
            this.txtTotalProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotalProduto.Enabled = false;
            this.txtTotalProduto.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalProduto.Location = new System.Drawing.Point(923, 412);
            this.txtTotalProduto.Name = "txtTotalProduto";
            this.txtTotalProduto.Size = new System.Drawing.Size(319, 46);
            this.txtTotalProduto.TabIndex = 0;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQuantidade.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(923, 320);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(319, 46);
            this.txtQuantidade.TabIndex = 0;
            this.txtQuantidade.Enter += new System.EventHandler(this.txtQuantidade_Enter);
            this.txtQuantidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantidade_KeyDown);
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidade_KeyPress);
            // 
            // txtPrecoUnitario
            // 
            this.txtPrecoUnitario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrecoUnitario.Enabled = false;
            this.txtPrecoUnitario.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoUnitario.Location = new System.Drawing.Point(923, 227);
            this.txtPrecoUnitario.Name = "txtPrecoUnitario";
            this.txtPrecoUnitario.Size = new System.Drawing.Size(319, 46);
            this.txtPrecoUnitario.TabIndex = 0;
            // 
            // txtTotalCupom
            // 
            this.txtTotalCupom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTotalCupom.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtTotalCupom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotalCupom.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCupom.ForeColor = System.Drawing.SystemColors.Window;
            this.txtTotalCupom.Location = new System.Drawing.Point(903, 40);
            this.txtTotalCupom.Name = "txtTotalCupom";
            this.txtTotalCupom.Size = new System.Drawing.Size(319, 66);
            this.txtTotalCupom.TabIndex = 0;
            this.txtTotalCupom.Text = "R$ 0,00";
            this.txtTotalCupom.Enter += new System.EventHandler(this.txtTotalCupom_Enter);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCodigo.Location = new System.Drawing.Point(927, 104);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(137, 28);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código Produto";
            // 
            // lblPrecoUnitario
            // 
            this.lblPrecoUnitario.AutoSize = true;
            this.lblPrecoUnitario.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoUnitario.ForeColor = System.Drawing.SystemColors.Window;
            this.lblPrecoUnitario.Location = new System.Drawing.Point(927, 197);
            this.lblPrecoUnitario.Name = "lblPrecoUnitario";
            this.lblPrecoUnitario.Size = new System.Drawing.Size(128, 28);
            this.lblPrecoUnitario.TabIndex = 1;
            this.lblPrecoUnitario.Text = "Preço Unitário";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.ForeColor = System.Drawing.SystemColors.Window;
            this.lblQuantidade.Location = new System.Drawing.Point(927, 291);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(177, 28);
            this.lblQuantidade.TabIndex = 1;
            this.lblQuantidade.Text = "Quantidade Produto";
            // 
            // lblTotalProduto
            // 
            this.lblTotalProduto.AutoSize = true;
            this.lblTotalProduto.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProduto.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTotalProduto.Location = new System.Drawing.Point(927, 384);
            this.lblTotalProduto.Name = "lblTotalProduto";
            this.lblTotalProduto.Size = new System.Drawing.Size(124, 28);
            this.lblTotalProduto.TabIndex = 1;
            this.lblTotalProduto.Text = "Total Produto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(922, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 28);
            this.label6.TabIndex = 1;
            this.label6.Text = "Total Cupom";
            // 
            // txtCodigoProduto
            // 
            this.txtCodigoProduto.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoProduto.Location = new System.Drawing.Point(923, 133);
            this.txtCodigoProduto.Name = "txtCodigoProduto";
            this.txtCodigoProduto.Size = new System.Drawing.Size(319, 46);
            this.txtCodigoProduto.TabIndex = 5;
            this.txtCodigoProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigoProduto_KeyDown_1);
            this.txtCodigoProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoProduto_KeyPress);
            // 
            // GridCupom
            // 
            this.GridCupom.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.GridCupom.AllowUserToAddRows = false;
            this.GridCupom.AllowUserToDeleteRows = false;
            this.GridCupom.AllowUserToResizeColumns = false;
            this.GridCupom.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.GridCupom.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridCupom.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.GridCupom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridCupom.CausesValidation = false;
            this.GridCupom.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.GridCupom.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.GridCupom.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridCupom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridCupom.ColumnHeadersHeight = 25;
            this.GridCupom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.cod,
            this.desc,
            this.prunit,
            this.qtd,
            this.total});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridCupom.DefaultCellStyle = dataGridViewCellStyle3;
            this.GridCupom.Enabled = false;
            this.GridCupom.EnableHeadersVisualStyles = false;
            this.GridCupom.GridColor = System.Drawing.Color.LemonChiffon;
            this.GridCupom.Location = new System.Drawing.Point(22, 107);
            this.GridCupom.MultiSelect = false;
            this.GridCupom.Name = "GridCupom";
            this.GridCupom.ReadOnly = true;
            this.GridCupom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GridCupom.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridCupom.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GridCupom.RowHeadersVisible = false;
            this.GridCupom.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridCupom.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.GridCupom.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.GridCupom.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LemonChiffon;
            this.GridCupom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.GridCupom.Size = new System.Drawing.Size(766, 473);
            this.GridCupom.TabIndex = 6;
            this.GridCupom.TabStop = false;
            // 
            // Num
            // 
            this.Num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Num.HeaderText = "N°";
            this.Num.MaxInputLength = 3;
            this.Num.Name = "Num";
            this.Num.ReadOnly = true;
            this.Num.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Num.Width = 35;
            // 
            // cod
            // 
            this.cod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cod.FillWeight = 156.7111F;
            this.cod.HeaderText = "Código";
            this.cod.MaxInputLength = 13;
            this.cod.Name = "cod";
            this.cod.ReadOnly = true;
            this.cod.Width = 150;
            // 
            // desc
            // 
            this.desc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.desc.FillWeight = 165.7495F;
            this.desc.HeaderText = "Descrição";
            this.desc.MaxInputLength = 70;
            this.desc.Name = "desc";
            this.desc.ReadOnly = true;
            this.desc.Width = 380;
            // 
            // prunit
            // 
            this.prunit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.prunit.FillWeight = 90.45117F;
            this.prunit.HeaderText = "Pr. Unit";
            this.prunit.Name = "prunit";
            this.prunit.ReadOnly = true;
            this.prunit.Width = 70;
            // 
            // qtd
            // 
            this.qtd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.qtd.FillWeight = 70.67556F;
            this.qtd.HeaderText = "Qtd.";
            this.qtd.Name = "qtd";
            this.qtd.ReadOnly = true;
            this.qtd.Width = 60;
            // 
            // total
            // 
            this.total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.total.FillWeight = 55.49892F;
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(20, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Descrição Produto";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.txtTotalCupom);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(20, 616);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1325, 134);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IconPagamento,
            this.IconCancelamento,
            this.IconSair});
            this.toolStrip1.Location = new System.Drawing.Point(923, 508);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(310, 72);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // IconPagamento
            // 
            this.IconPagamento.Image = ((System.Drawing.Image)(resources.GetObject("IconPagamento.Image")));
            this.IconPagamento.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.IconPagamento.Name = "IconPagamento";
            this.IconPagamento.Size = new System.Drawing.Size(95, 69);
            this.IconPagamento.Text = "Pagamento (F1)";
            this.IconPagamento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.IconPagamento.ToolTipText = "Pagamento";
            // 
            // IconCancelamento
            // 
            this.IconCancelamento.Image = ((System.Drawing.Image)(resources.GetObject("IconCancelamento.Image")));
            this.IconCancelamento.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.IconCancelamento.Name = "IconCancelamento";
            this.IconCancelamento.Size = new System.Drawing.Size(107, 69);
            this.IconCancelamento.Text = "Cancelamento (C)";
            this.IconCancelamento.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.IconCancelamento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.IconCancelamento.ToolTipText = "Cancelamento";
            // 
            // IconSair
            // 
            this.IconSair.Image = ((System.Drawing.Image)(resources.GetObject("IconSair.Image")));
            this.IconSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.IconSair.Name = "IconSair";
            this.IconSair.Size = new System.Drawing.Size(105, 69);
            this.IconSair.Text = "Sair Sistema (ESC)";
            this.IconSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.IconSair.ToolTipText = "Sair Sistema";
            this.IconSair.Click += new System.EventHandler(this.IconSair_Click);
            // 
            // grdPesquisa
            // 
            this.grdPesquisa.AllowUserToAddRows = false;
            this.grdPesquisa.AllowUserToDeleteRows = false;
            this.grdPesquisa.AllowUserToResizeColumns = false;
            this.grdPesquisa.AllowUserToResizeRows = false;
            this.grdPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdPesquisa.BackgroundColor = System.Drawing.Color.DarkGray;
            this.grdPesquisa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grdPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdPesquisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codbarras,
            this.DescricaoPesquisa,
            this.PrVendaPesquisa});
            this.grdPesquisa.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.grdPesquisa.EnableHeadersVisualStyles = false;
            this.grdPesquisa.ImeMode = System.Windows.Forms.ImeMode.On;
            this.grdPesquisa.Location = new System.Drawing.Point(0, 34);
            this.grdPesquisa.MultiSelect = false;
            this.grdPesquisa.Name = "grdPesquisa";
            this.grdPesquisa.ReadOnly = true;
            this.grdPesquisa.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdPesquisa.RowHeadersVisible = false;
            this.grdPesquisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdPesquisa.Size = new System.Drawing.Size(633, 248);
            this.grdPesquisa.TabIndex = 9;
            this.grdPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdPesquisa_KeyDown);
            // 
            // Codbarras
            // 
            this.Codbarras.FillWeight = 30F;
            this.Codbarras.HeaderText = "Codigo";
            this.Codbarras.Name = "Codbarras";
            this.Codbarras.ReadOnly = true;
            this.Codbarras.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Codbarras.Width = 160;
            // 
            // DescricaoPesquisa
            // 
            this.DescricaoPesquisa.HeaderText = "Descrição";
            this.DescricaoPesquisa.Name = "DescricaoPesquisa";
            this.DescricaoPesquisa.ReadOnly = true;
            this.DescricaoPesquisa.Width = 380;
            // 
            // PrVendaPesquisa
            // 
            this.PrVendaPesquisa.HeaderText = "Preço Venda";
            this.PrVendaPesquisa.Name = "PrVendaPesquisa";
            this.PrVendaPesquisa.ReadOnly = true;
            this.PrVendaPesquisa.Width = 90;
            // 
            // GrupoPesquisa
            // 
            this.GrupoPesquisa.BackColor = System.Drawing.Color.Transparent;
            this.GrupoPesquisa.Controls.Add(this.txtDescricaoPesquisa);
            this.GrupoPesquisa.Controls.Add(this.grdPesquisa);
            this.GrupoPesquisa.Location = new System.Drawing.Point(341, 216);
            this.GrupoPesquisa.Name = "GrupoPesquisa";
            this.GrupoPesquisa.Size = new System.Drawing.Size(633, 282);
            this.GrupoPesquisa.TabIndex = 10;
            this.GrupoPesquisa.TabStop = false;
            this.GrupoPesquisa.Visible = false;
            this.GrupoPesquisa.Validated += new System.EventHandler(this.GrupoPesquisa_Validated);
            // 
            // txtDescricaoPesquisa
            // 
            this.txtDescricaoPesquisa.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoPesquisa.Location = new System.Drawing.Point(0, 2);
            this.txtDescricaoPesquisa.Name = "txtDescricaoPesquisa";
            this.txtDescricaoPesquisa.Size = new System.Drawing.Size(633, 33);
            this.txtDescricaoPesquisa.TabIndex = 10;
            this.txtDescricaoPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescricaoPesquisa_KeyDown);
            // 
            // TelaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1373, 749);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.GrupoPesquisa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigoProduto);
            this.Controls.Add(this.GridCupom);
            this.Controls.Add(this.lblTotalProduto);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblPrecoUnitario);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtTotalProduto);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.txtPrecoUnitario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "TelaVenda";
            this.Text = "TelaVenda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TelaVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridCupom)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPesquisa)).EndInit();
            this.GrupoPesquisa.ResumeLayout(false);
            this.GrupoPesquisa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtTotalProduto;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtPrecoUnitario;
        private System.Windows.Forms.TextBox txtTotalCupom;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblPrecoUnitario;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblTotalProduto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodigoProduto;
        public System.Windows.Forms.DataGridView GridCupom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn prunit;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grdPesquisa;
        private System.Windows.Forms.GroupBox GrupoPesquisa;
        private System.Windows.Forms.TextBox txtDescricaoPesquisa;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton IconPagamento;
        private System.Windows.Forms.ToolStripButton IconCancelamento;
        private System.Windows.Forms.ToolStripButton IconSair;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codbarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescricaoPesquisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrVendaPesquisa;
    }
}