namespace CadastroFuncionarios
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
            toolStrip1 = new ToolStrip();
            tsbNovo = new ToolStripButton();
            tsbCancelar = new ToolStripButton();
            tsbSalvar = new ToolStripButton();
            tsbAlterar = new ToolStripButton();
            tsbExcluir = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripLabel1 = new ToolStripLabel();
            tstIdBuscar = new ToolStripTextBox();
            tsbBuscar = new ToolStripButton();
            label1 = new Label();
            txtId = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNome = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txtEndereco = new TextBox();
            mskCEP = new MaskedTextBox();
            txtBairro = new TextBox();
            txtCidade = new TextBox();
            txtUF = new TextBox();
            mskTelefone = new MaskedTextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.Transparent;
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbNovo, tsbCancelar, tsbSalvar, tsbAlterar, tsbExcluir, toolStripSeparator1, toolStripLabel1, tstIdBuscar, tsbBuscar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(543, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbNovo
            // 
            tsbNovo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbNovo.Image = Properties.Resources.associese_azul;
            tsbNovo.ImageTransparentColor = Color.Magenta;
            tsbNovo.Name = "tsbNovo";
            tsbNovo.Size = new Size(23, 22);
            tsbNovo.Text = "Novo";
            tsbNovo.Click += tsbNovo_Click;
            // 
            // tsbCancelar
            // 
            tsbCancelar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbCancelar.Image = Properties.Resources.new_cancel;
            tsbCancelar.ImageTransparentColor = Color.Magenta;
            tsbCancelar.Name = "tsbCancelar";
            tsbCancelar.Size = new Size(23, 22);
            tsbCancelar.Text = "Cancelar";
            tsbCancelar.Click += tsbCancelar_Click;
            // 
            // tsbSalvar
            // 
            tsbSalvar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbSalvar.Image = Properties.Resources.btn_salvar;
            tsbSalvar.ImageTransparentColor = Color.Magenta;
            tsbSalvar.Name = "tsbSalvar";
            tsbSalvar.Size = new Size(23, 22);
            tsbSalvar.Text = "Salvar";
            tsbSalvar.Click += tsbSalvar_Click;
            // 
            // tsbAlterar
            // 
            tsbAlterar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbAlterar.Image = Properties.Resources.alterar;
            tsbAlterar.ImageTransparentColor = Color.Magenta;
            tsbAlterar.Name = "tsbAlterar";
            tsbAlterar.Size = new Size(23, 22);
            tsbAlterar.Text = "Alterar";
            tsbAlterar.Click += tsbAlterar_Click;
            // 
            // tsbExcluir
            // 
            tsbExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbExcluir.Image = Properties.Resources.Delete_Button_PNG_Image;
            tsbExcluir.ImageTransparentColor = Color.Magenta;
            tsbExcluir.Name = "tsbExcluir";
            tsbExcluir.Size = new Size(23, 22);
            tsbExcluir.Text = "Excluir";
            tsbExcluir.Click += tsbExcluir_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(79, 22);
            toolStripLabel1.Text = "Buscar por Id:";
            // 
            // tstIdBuscar
            // 
            tstIdBuscar.Name = "tstIdBuscar";
            tstIdBuscar.Size = new Size(100, 25);
            // 
            // tsbBuscar
            // 
            tsbBuscar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbBuscar.Image = Properties.Resources.pesquisa;
            tsbBuscar.ImageTransparentColor = Color.Magenta;
            tsbBuscar.Name = "tsbBuscar";
            tsbBuscar.Size = new Size(23, 22);
            tsbBuscar.Text = "Buscar";
            tsbBuscar.Click += tsbBuscar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 39);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 1;
            label1.Text = "Id";
            label1.Click += label1_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(31, 57);
            txtId.Name = "txtId";
            txtId.Size = new Size(132, 23);
            txtId.TabIndex = 2;
            txtId.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(169, 39);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 3;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 109);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 4;
            label3.Text = "Endereço";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 177);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 5;
            label4.Text = "CEP";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(139, 177);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 6;
            label5.Text = "Bairro";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(294, 177);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 7;
            label6.Text = "Cidade";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(169, 57);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(351, 23);
            txtNome.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(461, 177);
            label7.Name = "label7";
            label7.Size = new Size(21, 15);
            label7.TabIndex = 9;
            label7.Text = "UF";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(31, 240);
            label8.Name = "label8";
            label8.Size = new Size(51, 15);
            label8.TabIndex = 10;
            label8.Text = "Telefone";
            label8.Click += label8_Click;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(31, 127);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(489, 23);
            txtEndereco.TabIndex = 11;
            // 
            // mskCEP
            // 
            mskCEP.Location = new Point(31, 195);
            mskCEP.Mask = "00000-000";
            mskCEP.Name = "mskCEP";
            mskCEP.Size = new Size(100, 23);
            mskCEP.TabIndex = 12;
            mskCEP.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(137, 195);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(154, 23);
            txtBairro.TabIndex = 13;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(297, 195);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(158, 23);
            txtCidade.TabIndex = 14;
            txtCidade.TextChanged += txtCidade_TextChanged;
            // 
            // txtUF
            // 
            txtUF.Location = new Point(461, 195);
            txtUF.Name = "txtUF";
            txtUF.Size = new Size(59, 23);
            txtUF.TabIndex = 15;
            // 
            // mskTelefone
            // 
            mskTelefone.Location = new Point(31, 258);
            mskTelefone.Mask = "(00)00000-0000";
            mskTelefone.Name = "mskTelefone";
            mskTelefone.Size = new Size(178, 23);
            mskTelefone.TabIndex = 16;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.mulher;
            pictureBox1.Location = new Point(390, 240);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 156);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.Homem3;
            pictureBox2.Location = new Point(230, 240);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(154, 156);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(543, 389);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(mskTelefone);
            Controls.Add(txtUF);
            Controls.Add(txtCidade);
            Controls.Add(txtBairro);
            Controls.Add(mskCEP);
            Controls.Add(txtEndereco);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtNome);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(toolStrip1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton tsbNovo;
        private ToolStripButton tsbCancelar;
        private ToolStripButton tsbSalvar;
        private ToolStripButton tsbAlterar;
        private ToolStripButton tsbExcluir;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox tstIdBuscar;
        private ToolStripButton tsbBuscar;
        private Label label1;
        private TextBox txtId;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtNome;
        private Label label7;
        private Label label8;
        private TextBox txtEndereco;
        private MaskedTextBox mskCEP;
        private TextBox txtBairro;
        private TextBox txtCidade;
        private TextBox txtUF;
        private MaskedTextBox mskTelefone;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}