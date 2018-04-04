namespace AlterarData
{
    partial class MainForm
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
            this.txtDia = new System.Windows.Forms.TextBox();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.cbOperacao = new System.Windows.Forms.ComboBox();
            this.txtMinutosAlterar = new System.Windows.Forms.TextBox();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.lblOperacao = new System.Windows.Forms.Label();
            this.lblMinutosAlterar = new System.Windows.Forms.Label();
            this.lblCalculo = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.txtMinutos = new System.Windows.Forms.TextBox();
            this.lblMinutos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(203, 95);
            this.txtDia.MaxLength = 2;
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(100, 20);
            this.txtDia.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtDia, "Escolha um número entre 1 e 31");
            this.txtDia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDia_KeyPress);
            this.txtDia.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtDia_KeyUp);
            this.txtDia.Leave += new System.EventHandler(this.txtDia_Leave);
            // 
            // txtMes
            // 
            this.txtMes.Enabled = false;
            this.txtMes.Location = new System.Drawing.Point(203, 122);
            this.txtMes.MaxLength = 2;
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(100, 20);
            this.txtMes.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtMes, "Escolha um número entre 1 e 12");
            this.txtMes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMes_KeyPress);
            this.txtMes.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMes_KeyUp);
            // 
            // txtAno
            // 
            this.txtAno.Enabled = false;
            this.txtAno.Location = new System.Drawing.Point(203, 149);
            this.txtAno.MaxLength = 4;
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(100, 20);
            this.txtAno.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtAno, "Escolha o Ano com 4 números dígitos");
            this.txtAno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAno_KeyPress);
            this.txtAno.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAno_KeyUp);
            // 
            // cbOperacao
            // 
            this.cbOperacao.Enabled = false;
            this.cbOperacao.FormattingEnabled = true;
            this.cbOperacao.Items.AddRange(new object[] {
            "+",
            "-"});
            this.cbOperacao.Location = new System.Drawing.Point(203, 225);
            this.cbOperacao.Name = "cbOperacao";
            this.cbOperacao.Size = new System.Drawing.Size(100, 21);
            this.cbOperacao.TabIndex = 3;
            this.toolTip1.SetToolTip(this.cbOperacao, "Selecione + para aumentar e - para dimuir a data. ");
            this.cbOperacao.SelectedIndexChanged += new System.EventHandler(this.cbOperacao_SelectedIndexChanged);
            // 
            // txtMinutosAlterar
            // 
            this.txtMinutosAlterar.Enabled = false;
            this.txtMinutosAlterar.Location = new System.Drawing.Point(203, 253);
            this.txtMinutosAlterar.MaxLength = 4;
            this.txtMinutosAlterar.Name = "txtMinutosAlterar";
            this.txtMinutosAlterar.Size = new System.Drawing.Size(100, 20);
            this.txtMinutosAlterar.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtMinutosAlterar, "Forneça a quantidade de minutos com 4 números dígitos. ");
            this.txtMinutosAlterar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinutosAlterar_KeyPress);
            this.txtMinutosAlterar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMinutosAlterar_KeyUp);
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Location = new System.Drawing.Point(162, 98);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(26, 13);
            this.lblDia.TabIndex = 5;
            this.lblDia.Text = "Dia:";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(162, 125);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(30, 13);
            this.lblMes.TabIndex = 6;
            this.lblMes.Text = "Mês:";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(162, 152);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(29, 13);
            this.lblAno.TabIndex = 7;
            this.lblAno.Text = "Ano:";
            // 
            // lblOperacao
            // 
            this.lblOperacao.AutoSize = true;
            this.lblOperacao.Location = new System.Drawing.Point(135, 228);
            this.lblOperacao.Name = "lblOperacao";
            this.lblOperacao.Size = new System.Drawing.Size(57, 13);
            this.lblOperacao.TabIndex = 8;
            this.lblOperacao.Text = "Operação:";
            // 
            // lblMinutosAlterar
            // 
            this.lblMinutosAlterar.AutoSize = true;
            this.lblMinutosAlterar.Location = new System.Drawing.Point(103, 256);
            this.lblMinutosAlterar.Name = "lblMinutosAlterar";
            this.lblMinutosAlterar.Size = new System.Drawing.Size(88, 13);
            this.lblMinutosAlterar.TabIndex = 9;
            this.lblMinutosAlterar.Text = "Minutos à alterar:";
            // 
            // lblCalculo
            // 
            this.lblCalculo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCalculo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblCalculo.Location = new System.Drawing.Point(200, 333);
            this.lblCalculo.Name = "lblCalculo";
            this.lblCalculo.Size = new System.Drawing.Size(193, 153);
            this.lblCalculo.TabIndex = 10;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(133, 333);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(58, 13);
            this.lblResultado.TabIndex = 11;
            this.lblResultado.Text = "Resultado:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(162, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(531, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Escolha abaixo e na ordem  o dia, mês, ano, operação e os minutos  para alteração" +
    " da data a partir de minutos.\r\n";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Enabled = false;
            this.btnCalcular.Location = new System.Drawing.Point(203, 284);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 23);
            this.btnCalcular.TabIndex = 13;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtHora
            // 
            this.txtHora.Enabled = false;
            this.txtHora.Location = new System.Drawing.Point(203, 175);
            this.txtHora.MaxLength = 2;
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(100, 20);
            this.txtHora.TabIndex = 2;
            this.txtHora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHora_KeyPress);
            this.txtHora.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtHora_KeyUp);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(158, 178);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(33, 13);
            this.lblHora.TabIndex = 7;
            this.lblHora.Text = "Hora:";
            // 
            // txtMinutos
            // 
            this.txtMinutos.Enabled = false;
            this.txtMinutos.Location = new System.Drawing.Point(203, 199);
            this.txtMinutos.MaxLength = 2;
            this.txtMinutos.Name = "txtMinutos";
            this.txtMinutos.Size = new System.Drawing.Size(100, 20);
            this.txtMinutos.TabIndex = 2;
            this.txtMinutos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinutos_KeyPress);
            this.txtMinutos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMinutos_KeyUp);
            // 
            // lblMinutos
            // 
            this.lblMinutos.AutoSize = true;
            this.lblMinutos.Location = new System.Drawing.Point(145, 202);
            this.lblMinutos.Name = "lblMinutos";
            this.lblMinutos.Size = new System.Drawing.Size(47, 13);
            this.lblMinutos.TabIndex = 7;
            this.lblMinutos.Text = "Minutos:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(772, 491);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblCalculo);
            this.Controls.Add(this.lblMinutosAlterar);
            this.Controls.Add(this.lblOperacao);
            this.Controls.Add(this.lblMinutos);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.txtMinutosAlterar);
            this.Controls.Add(this.cbOperacao);
            this.Controls.Add(this.txtMinutos);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.txtDia);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar data pelos Minutos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.ComboBox cbOperacao;
        private System.Windows.Forms.TextBox txtMinutosAlterar;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label lblOperacao;
        private System.Windows.Forms.Label lblMinutosAlterar;
        private System.Windows.Forms.Label lblCalculo;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.TextBox txtMinutos;
        private System.Windows.Forms.Label lblMinutos;
    }
}

