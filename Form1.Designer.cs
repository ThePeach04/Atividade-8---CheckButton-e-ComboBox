namespace Atividade_8___CheckButton_e_ComboBox
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpTamnho = new GroupBox();
            rbGrande = new RadioButton();
            rbMedia = new RadioButton();
            rbPequena = new RadioButton();
            cmbSabor = new ComboBox();
            grpPagamento = new GroupBox();
            rbCartao = new RadioButton();
            rbDinheiro = new RadioButton();
            grpAdicionais = new GroupBox();
            chkBacon = new CheckBox();
            chkBorda = new CheckBox();
            chkQueijo = new CheckBox();
            btnConfirmar = new Button();
            label1 = new Label();
            grpTamnho.SuspendLayout();
            grpPagamento.SuspendLayout();
            grpAdicionais.SuspendLayout();
            SuspendLayout();
            // 
            // grpTamnho
            // 
            grpTamnho.Controls.Add(rbGrande);
            grpTamnho.Controls.Add(rbMedia);
            grpTamnho.Controls.Add(rbPequena);
            grpTamnho.Location = new Point(22, 102);
            grpTamnho.Name = "grpTamnho";
            grpTamnho.Size = new Size(200, 100);
            grpTamnho.TabIndex = 0;
            grpTamnho.TabStop = false;
            grpTamnho.Text = "Tamanho";
            // 
            // rbGrande
            // 
            rbGrande.AutoSize = true;
            rbGrande.Location = new Point(8, 72);
            rbGrande.Name = "rbGrande";
            rbGrande.Size = new Size(63, 19);
            rbGrande.TabIndex = 2;
            rbGrande.TabStop = true;
            rbGrande.Text = "Grande";
            rbGrande.UseVisualStyleBackColor = true;
            // 
            // rbMedia
            // 
            rbMedia.AutoSize = true;
            rbMedia.Location = new Point(8, 47);
            rbMedia.Name = "rbMedia";
            rbMedia.Size = new Size(58, 19);
            rbMedia.TabIndex = 1;
            rbMedia.TabStop = true;
            rbMedia.Text = "Media";
            rbMedia.UseVisualStyleBackColor = true;
            // 
            // rbPequena
            // 
            rbPequena.AutoSize = true;
            rbPequena.Location = new Point(8, 27);
            rbPequena.Name = "rbPequena";
            rbPequena.Size = new Size(71, 19);
            rbPequena.TabIndex = 0;
            rbPequena.TabStop = true;
            rbPequena.Text = "Pequena";
            rbPequena.UseVisualStyleBackColor = true;
            // 
            // cmbSabor
            // 
            cmbSabor.AutoCompleteCustomSource.AddRange(new string[] { "Calabresa", "Frango", "OVO" });
            cmbSabor.FormattingEnabled = true;
            cmbSabor.Items.AddRange(new object[] { "Calabresa", "Mussarela", "Marguerita", "Portuguesa", "Frango com catupiry", "Pepperoni" });
            cmbSabor.Location = new Point(286, 49);
            cmbSabor.Name = "cmbSabor";
            cmbSabor.Size = new Size(121, 23);
            cmbSabor.TabIndex = 1;
            // 
            // grpPagamento
            // 
            grpPagamento.Controls.Add(rbCartao);
            grpPagamento.Controls.Add(rbDinheiro);
            grpPagamento.Location = new Point(459, 102);
            grpPagamento.Name = "grpPagamento";
            grpPagamento.Size = new Size(200, 100);
            grpPagamento.TabIndex = 2;
            grpPagamento.TabStop = false;
            grpPagamento.Text = "Forma de Pagamento";
            // 
            // rbCartao
            // 
            rbCartao.AutoSize = true;
            rbCartao.Location = new Point(16, 57);
            rbCartao.Name = "rbCartao";
            rbCartao.Size = new Size(60, 19);
            rbCartao.TabIndex = 1;
            rbCartao.TabStop = true;
            rbCartao.Text = "Cartao";
            rbCartao.UseVisualStyleBackColor = true;
            // 
            // rbDinheiro
            // 
            rbDinheiro.AutoSize = true;
            rbDinheiro.Location = new Point(16, 27);
            rbDinheiro.Name = "rbDinheiro";
            rbDinheiro.Size = new Size(70, 19);
            rbDinheiro.TabIndex = 0;
            rbDinheiro.TabStop = true;
            rbDinheiro.Text = "Dinheiro";
            rbDinheiro.UseVisualStyleBackColor = true;
            // 
            // grpAdicionais
            // 
            grpAdicionais.Controls.Add(chkBacon);
            grpAdicionais.Controls.Add(chkBorda);
            grpAdicionais.Controls.Add(chkQueijo);
            grpAdicionais.Location = new Point(241, 102);
            grpAdicionais.Name = "grpAdicionais";
            grpAdicionais.Size = new Size(200, 100);
            grpAdicionais.TabIndex = 3;
            grpAdicionais.TabStop = false;
            grpAdicionais.Text = "Adicionais";
            // 
            // chkBacon
            // 
            chkBacon.AutoSize = true;
            chkBacon.Location = new Point(14, 48);
            chkBacon.Name = "chkBacon";
            chkBacon.Size = new Size(59, 19);
            chkBacon.TabIndex = 2;
            chkBacon.Text = "Bacon";
            chkBacon.UseVisualStyleBackColor = true;
            // 
            // chkBorda
            // 
            chkBorda.AutoSize = true;
            chkBorda.Location = new Point(14, 72);
            chkBorda.Name = "chkBorda";
            chkBorda.Size = new Size(57, 19);
            chkBorda.TabIndex = 1;
            chkBorda.Text = "Borda";
            chkBorda.UseVisualStyleBackColor = true;
            // 
            // chkQueijo
            // 
            chkQueijo.AutoSize = true;
            chkQueijo.Location = new Point(14, 27);
            chkQueijo.Name = "chkQueijo";
            chkQueijo.Size = new Size(61, 19);
            chkQueijo.TabIndex = 0;
            chkQueijo.Text = "Queijo";
            chkQueijo.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfirmar.Location = new Point(286, 228);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(105, 33);
            btnConfirmar.TabIndex = 4;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(88, 49);
            label1.Name = "label1";
            label1.Size = new Size(192, 17);
            label1.TabIndex = 5;
            label1.Text = "Selecione o sabor da sua Pizza:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 273);
            Controls.Add(label1);
            Controls.Add(btnConfirmar);
            Controls.Add(grpAdicionais);
            Controls.Add(grpPagamento);
            Controls.Add(cmbSabor);
            Controls.Add(grpTamnho);
            Name = "Form1";
            Text = "Pizzas";
            grpTamnho.ResumeLayout(false);
            grpTamnho.PerformLayout();
            grpPagamento.ResumeLayout(false);
            grpPagamento.PerformLayout();
            grpAdicionais.ResumeLayout(false);
            grpAdicionais.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpTamnho;
        private RadioButton rbGrande;
        private RadioButton rbMedia;
        private RadioButton rbPequena;
        private ComboBox cmbSabor;
        private GroupBox grpPagamento;
        private RadioButton radioButton6;
        private RadioButton rbCartao;
        private RadioButton rbDinheiro;
        private GroupBox grpAdicionais;
        private RadioButton radioButton8;
        private RadioButton radioButton7;
        private Button btnConfirmar;
        private CheckBox chkBacon;
        private CheckBox chkBorda;
        private CheckBox chkQueijo;
        private Label label1;
    }
}
