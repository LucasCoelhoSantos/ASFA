namespace ASFA
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            groupBoxAcoes = new GroupBox();
            buttonFicha = new Button();
            buttonRelatorio = new Button();
            buttonEditar = new Button();
            buttonAdicionar = new Button();
            dataGridPessoaIdosa = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            DataCadastro = new DataGridViewTextBoxColumn();
            DataNascimento = new DataGridViewTextBoxColumn();
            EstadoCivil = new DataGridViewTextBoxColumn();
            Cpf = new DataGridViewTextBoxColumn();
            Rg = new DataGridViewTextBoxColumn();
            OrgaoEmissor = new DataGridViewTextBoxColumn();
            Religiao = new DataGridViewTextBoxColumn();
            Naturalidade = new DataGridViewTextBoxColumn();
            Cep = new DataGridViewTextBoxColumn();
            Logradouro = new DataGridViewTextBoxColumn();
            Numero = new DataGridViewTextBoxColumn();
            Cidade = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Bairro = new DataGridViewTextBoxColumn();
            Moradia = new DataGridViewTextBoxColumn();
            Telefone = new DataGridViewTextBoxColumn();
            Ativo = new DataGridViewCheckBoxColumn();
            Endereco = new DataGridViewTextBoxColumn();
            groupBoxBuscar = new GroupBox();
            comboBoxSituacao = new ComboBox();
            comboBoxEstadoCivil = new ComboBox();
            labelEnderecosGerais = new Label();
            textEndereco = new TextBox();
            textCPFouRG = new TextBox();
            textNome = new TextBox();
            labelEstadoCivil = new Label();
            labelSituacao = new Label();
            labelCPFouRG = new Label();
            labelNome = new Label();
            buttonRecarregar = new Button();
            labelTotalEncontrado = new Label();
            labelTotalAtivo = new Label();
            labelTotalCancelado = new Label();
            labelNadaEncontrado = new Label();
            reportViewerRelatorio = new Microsoft.Reporting.WinForms.ReportViewer();
            buttonProcurar = new Button();
            pictureBoxCarregando = new PictureBox();
            groupBoxAcoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridPessoaIdosa).BeginInit();
            groupBoxBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCarregando).BeginInit();
            SuspendLayout();
            // 
            // groupBoxAcoes
            // 
            groupBoxAcoes.BackColor = Color.Transparent;
            groupBoxAcoes.Controls.Add(buttonFicha);
            groupBoxAcoes.Controls.Add(buttonRelatorio);
            groupBoxAcoes.Controls.Add(buttonEditar);
            groupBoxAcoes.Controls.Add(buttonAdicionar);
            groupBoxAcoes.ForeColor = Color.Silver;
            groupBoxAcoes.Location = new Point(12, 12);
            groupBoxAcoes.Name = "groupBoxAcoes";
            groupBoxAcoes.Size = new Size(222, 83);
            groupBoxAcoes.TabIndex = 0;
            groupBoxAcoes.TabStop = false;
            groupBoxAcoes.Text = "Ações";
            // 
            // buttonFicha
            // 
            buttonFicha.Cursor = Cursors.Hand;
            buttonFicha.Enabled = false;
            buttonFicha.FlatAppearance.BorderSize = 0;
            buttonFicha.FlatStyle = FlatStyle.Flat;
            buttonFicha.Image = Properties.Resources.icon_ficha;
            buttonFicha.Location = new Point(168, 24);
            buttonFicha.Name = "buttonFicha";
            buttonFicha.Size = new Size(48, 48);
            buttonFicha.TabIndex = 0;
            buttonFicha.TabStop = false;
            buttonFicha.UseVisualStyleBackColor = true;
            buttonFicha.Click += ButtonFichaCadastral_Click;
            // 
            // buttonRelatorio
            // 
            buttonRelatorio.Cursor = Cursors.Hand;
            buttonRelatorio.FlatAppearance.BorderSize = 0;
            buttonRelatorio.FlatStyle = FlatStyle.Flat;
            buttonRelatorio.Image = (Image)resources.GetObject("buttonRelatorio.Image");
            buttonRelatorio.Location = new Point(114, 24);
            buttonRelatorio.Name = "buttonRelatorio";
            buttonRelatorio.Size = new Size(48, 48);
            buttonRelatorio.TabIndex = 0;
            buttonRelatorio.TabStop = false;
            buttonRelatorio.UseVisualStyleBackColor = true;
            buttonRelatorio.Click += ButtonRelatorio_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.Cursor = Cursors.Hand;
            buttonEditar.Enabled = false;
            buttonEditar.FlatAppearance.BorderSize = 0;
            buttonEditar.FlatStyle = FlatStyle.Flat;
            buttonEditar.Image = Properties.Resources.icon_editar;
            buttonEditar.Location = new Point(60, 24);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(48, 48);
            buttonEditar.TabIndex = 0;
            buttonEditar.TabStop = false;
            buttonEditar.UseVisualStyleBackColor = true;
            buttonEditar.Click += ButtonEditar_Click;
            // 
            // buttonAdicionar
            // 
            buttonAdicionar.Cursor = Cursors.Hand;
            buttonAdicionar.FlatAppearance.BorderSize = 0;
            buttonAdicionar.FlatStyle = FlatStyle.Flat;
            buttonAdicionar.Image = Properties.Resources.icon_criar;
            buttonAdicionar.Location = new Point(6, 24);
            buttonAdicionar.Name = "buttonAdicionar";
            buttonAdicionar.Size = new Size(48, 48);
            buttonAdicionar.TabIndex = 0;
            buttonAdicionar.TabStop = false;
            buttonAdicionar.UseVisualStyleBackColor = true;
            buttonAdicionar.Click += ButtonAdicionar_Click;
            // 
            // dataGridPessoaIdosa
            // 
            dataGridPessoaIdosa.AllowUserToAddRows = false;
            dataGridPessoaIdosa.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.AliceBlue;
            dataGridPessoaIdosa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridPessoaIdosa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridPessoaIdosa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridPessoaIdosa.BackgroundColor = Color.White;
            dataGridPessoaIdosa.BorderStyle = BorderStyle.None;
            dataGridPessoaIdosa.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridPessoaIdosa.ColumnHeadersHeight = 30;
            dataGridPessoaIdosa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridPessoaIdosa.Columns.AddRange(new DataGridViewColumn[] { Id, Nome, DataCadastro, DataNascimento, EstadoCivil, Cpf, Rg, OrgaoEmissor, Religiao, Naturalidade, Cep, Logradouro, Numero, Cidade, Estado, Bairro, Moradia, Telefone, Ativo, Endereco });
            dataGridPessoaIdosa.Location = new Point(12, 112);
            dataGridPessoaIdosa.Name = "dataGridPessoaIdosa";
            dataGridPessoaIdosa.ReadOnly = true;
            dataGridPessoaIdosa.RowHeadersWidth = 4;
            dataGridPessoaIdosa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridPessoaIdosa.Size = new Size(1240, 514);
            dataGridPessoaIdosa.TabIndex = 0;
            dataGridPessoaIdosa.TabStop = false;
            dataGridPessoaIdosa.CellClick += DatagridLista_CellClick;
            dataGridPessoaIdosa.Sorted += DatagridLista_Sorted;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.Frozen = true;
            Id.HeaderText = "ID";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            Id.Width = 49;
            // 
            // Nome
            // 
            Nome.DataPropertyName = "Nome";
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            Nome.Width = 65;
            // 
            // DataCadastro
            // 
            DataCadastro.DataPropertyName = "DataCadastro";
            DataCadastro.HeaderText = "Data de Cadastro";
            DataCadastro.Name = "DataCadastro";
            DataCadastro.ReadOnly = true;
            DataCadastro.Width = 161;
            // 
            // DataNascimento
            // 
            DataNascimento.DataPropertyName = "DataNascimento";
            DataNascimento.HeaderText = "Data de Nascimento";
            DataNascimento.Name = "DataNascimento";
            DataNascimento.ReadOnly = true;
            DataNascimento.Width = 177;
            // 
            // EstadoCivil
            // 
            EstadoCivil.DataPropertyName = "EstadoCivil";
            EstadoCivil.HeaderText = "Estado Cívil";
            EstadoCivil.Name = "EstadoCivil";
            EstadoCivil.ReadOnly = true;
            EstadoCivil.Width = 129;
            // 
            // Cpf
            // 
            Cpf.DataPropertyName = "Cpf";
            Cpf.HeaderText = "CPF";
            Cpf.Name = "Cpf";
            Cpf.ReadOnly = true;
            Cpf.Width = 57;
            // 
            // Rg
            // 
            Rg.DataPropertyName = "Rg";
            Rg.HeaderText = "RG";
            Rg.Name = "Rg";
            Rg.ReadOnly = true;
            Rg.Width = 49;
            // 
            // OrgaoEmissor
            // 
            OrgaoEmissor.DataPropertyName = "OrgaoEmissor";
            OrgaoEmissor.HeaderText = "Órgão Emissor";
            OrgaoEmissor.Name = "OrgaoEmissor";
            OrgaoEmissor.ReadOnly = true;
            OrgaoEmissor.Width = 137;
            // 
            // Religiao
            // 
            Religiao.DataPropertyName = "Religiao";
            Religiao.HeaderText = "Religião";
            Religiao.Name = "Religiao";
            Religiao.ReadOnly = true;
            Religiao.Width = 97;
            // 
            // Naturalidade
            // 
            Naturalidade.DataPropertyName = "Naturalidade";
            Naturalidade.HeaderText = "Naturalidade";
            Naturalidade.Name = "Naturalidade";
            Naturalidade.ReadOnly = true;
            Naturalidade.Width = 129;
            // 
            // Cep
            // 
            Cep.DataPropertyName = "Cep";
            Cep.HeaderText = "CEP";
            Cep.Name = "Cep";
            Cep.ReadOnly = true;
            Cep.Width = 57;
            // 
            // Logradouro
            // 
            Logradouro.DataPropertyName = "Logradouro";
            Logradouro.HeaderText = "Logradouro";
            Logradouro.Name = "Logradouro";
            Logradouro.ReadOnly = true;
            Logradouro.Width = 113;
            // 
            // Numero
            // 
            Numero.DataPropertyName = "Numero";
            Numero.HeaderText = "Nº";
            Numero.Name = "Numero";
            Numero.ReadOnly = true;
            Numero.Width = 49;
            // 
            // Cidade
            // 
            Cidade.DataPropertyName = "Cidade";
            Cidade.HeaderText = "Cidade";
            Cidade.Name = "Cidade";
            Cidade.ReadOnly = true;
            Cidade.Width = 81;
            // 
            // Estado
            // 
            Estado.DataPropertyName = "Estado";
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            Estado.Width = 81;
            // 
            // Bairro
            // 
            Bairro.DataPropertyName = "Bairro";
            Bairro.HeaderText = "Bairro";
            Bairro.Name = "Bairro";
            Bairro.ReadOnly = true;
            Bairro.Width = 81;
            // 
            // Moradia
            // 
            Moradia.DataPropertyName = "Moradia";
            Moradia.HeaderText = "Moradia";
            Moradia.Name = "Moradia";
            Moradia.ReadOnly = true;
            Moradia.Width = 89;
            // 
            // Telefone
            // 
            Telefone.DataPropertyName = "Telefone";
            Telefone.HeaderText = "Telefone";
            Telefone.Name = "Telefone";
            Telefone.ReadOnly = true;
            Telefone.Width = 97;
            // 
            // Ativo
            // 
            Ativo.DataPropertyName = "Ativo";
            Ativo.HeaderText = "Ativo";
            Ativo.Name = "Ativo";
            Ativo.ReadOnly = true;
            Ativo.Resizable = DataGridViewTriState.True;
            Ativo.SortMode = DataGridViewColumnSortMode.Automatic;
            Ativo.Width = 73;
            // 
            // Endereco
            // 
            Endereco.DataPropertyName = "Endereco";
            Endereco.HeaderText = "Endereco";
            Endereco.Name = "Endereco";
            Endereco.ReadOnly = true;
            Endereco.Visible = false;
            Endereco.Width = 97;
            // 
            // groupBoxBuscar
            // 
            groupBoxBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxBuscar.BackColor = Color.Transparent;
            groupBoxBuscar.Controls.Add(comboBoxSituacao);
            groupBoxBuscar.Controls.Add(comboBoxEstadoCivil);
            groupBoxBuscar.Controls.Add(labelEnderecosGerais);
            groupBoxBuscar.Controls.Add(textEndereco);
            groupBoxBuscar.Controls.Add(textCPFouRG);
            groupBoxBuscar.Controls.Add(textNome);
            groupBoxBuscar.Controls.Add(labelEstadoCivil);
            groupBoxBuscar.Controls.Add(labelSituacao);
            groupBoxBuscar.Controls.Add(labelCPFouRG);
            groupBoxBuscar.Controls.Add(labelNome);
            groupBoxBuscar.ForeColor = Color.Silver;
            groupBoxBuscar.Location = new Point(257, 12);
            groupBoxBuscar.Name = "groupBoxBuscar";
            groupBoxBuscar.Size = new Size(851, 83);
            groupBoxBuscar.TabIndex = 0;
            groupBoxBuscar.TabStop = false;
            groupBoxBuscar.Text = "Buscar";
            // 
            // comboBoxSituacao
            // 
            comboBoxSituacao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxSituacao.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxSituacao.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxSituacao.DropDownHeight = 100;
            comboBoxSituacao.FormattingEnabled = true;
            comboBoxSituacao.IntegralHeight = false;
            comboBoxSituacao.Items.AddRange(new object[] { "Todos", "Ativo", "Inativo" });
            comboBoxSituacao.Location = new Point(766, 44);
            comboBoxSituacao.Margin = new Padding(4, 3, 4, 3);
            comboBoxSituacao.Name = "comboBoxSituacao";
            comboBoxSituacao.Size = new Size(72, 26);
            comboBoxSituacao.TabIndex = 10;
            comboBoxSituacao.Text = "Ativo";
            // 
            // comboBoxEstadoCivil
            // 
            comboBoxEstadoCivil.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxEstadoCivil.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxEstadoCivil.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxEstadoCivil.DropDownHeight = 100;
            comboBoxEstadoCivil.FormattingEnabled = true;
            comboBoxEstadoCivil.IntegralHeight = false;
            comboBoxEstadoCivil.Items.AddRange(new object[] { "Solteiro(a)", "Casado(a)", "Divorciado(a)", "Viúvo(a)" });
            comboBoxEstadoCivil.Location = new Point(329, 44);
            comboBoxEstadoCivil.Margin = new Padding(4, 3, 4, 3);
            comboBoxEstadoCivil.Name = "comboBoxEstadoCivil";
            comboBoxEstadoCivil.Size = new Size(116, 26);
            comboBoxEstadoCivil.TabIndex = 3;
            // 
            // labelEnderecosGerais
            // 
            labelEnderecosGerais.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelEnderecosGerais.AutoSize = true;
            labelEnderecosGerais.ForeColor = Color.Black;
            labelEnderecosGerais.Location = new Point(467, 24);
            labelEnderecosGerais.Name = "labelEnderecosGerais";
            labelEnderecosGerais.Size = new Size(136, 18);
            labelEnderecosGerais.TabIndex = 9;
            labelEnderecosGerais.Text = "Endereços Gerais";
            // 
            // textEndereco
            // 
            textEndereco.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textEndereco.Location = new Point(467, 45);
            textEndereco.Name = "textEndereco";
            textEndereco.Size = new Size(276, 25);
            textEndereco.TabIndex = 4;
            // 
            // textCPFouRG
            // 
            textCPFouRG.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textCPFouRG.Location = new Point(206, 45);
            textCPFouRG.Name = "textCPFouRG";
            textCPFouRG.Size = new Size(102, 25);
            textCPFouRG.TabIndex = 1;
            // 
            // textNome
            // 
            textNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textNome.Location = new Point(6, 45);
            textNome.Name = "textNome";
            textNome.Size = new Size(180, 25);
            textNome.TabIndex = 0;
            // 
            // labelEstadoCivil
            // 
            labelEstadoCivil.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelEstadoCivil.AutoSize = true;
            labelEstadoCivil.ForeColor = Color.Black;
            labelEstadoCivil.Location = new Point(329, 23);
            labelEstadoCivil.Name = "labelEstadoCivil";
            labelEstadoCivil.Size = new Size(104, 18);
            labelEstadoCivil.TabIndex = 3;
            labelEstadoCivil.Text = "Estado Cívil";
            // 
            // labelSituacao
            // 
            labelSituacao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelSituacao.AutoSize = true;
            labelSituacao.ForeColor = Color.Black;
            labelSituacao.Location = new Point(766, 24);
            labelSituacao.Name = "labelSituacao";
            labelSituacao.Size = new Size(72, 18);
            labelSituacao.TabIndex = 2;
            labelSituacao.Text = "Situação";
            // 
            // labelCPFouRG
            // 
            labelCPFouRG.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelCPFouRG.AutoSize = true;
            labelCPFouRG.ForeColor = Color.Black;
            labelCPFouRG.Location = new Point(206, 24);
            labelCPFouRG.Name = "labelCPFouRG";
            labelCPFouRG.Size = new Size(80, 18);
            labelCPFouRG.TabIndex = 1;
            labelCPFouRG.Text = "CPF ou RG";
            // 
            // labelNome
            // 
            labelNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelNome.AutoSize = true;
            labelNome.ForeColor = Color.Black;
            labelNome.Location = new Point(6, 24);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(40, 18);
            labelNome.TabIndex = 0;
            labelNome.Text = "Nome";
            // 
            // buttonRecarregar
            // 
            buttonRecarregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonRecarregar.BackColor = Color.Transparent;
            buttonRecarregar.Cursor = Cursors.Hand;
            buttonRecarregar.FlatAppearance.BorderSize = 0;
            buttonRecarregar.FlatStyle = FlatStyle.Flat;
            buttonRecarregar.Image = Properties.Resources.icon_refresh;
            buttonRecarregar.Location = new Point(1204, 36);
            buttonRecarregar.Name = "buttonRecarregar";
            buttonRecarregar.Size = new Size(48, 48);
            buttonRecarregar.TabIndex = 1;
            buttonRecarregar.TabStop = false;
            buttonRecarregar.UseVisualStyleBackColor = false;
            buttonRecarregar.Click += ButtonRecarregar_Click;
            // 
            // labelTotalEncontrado
            // 
            labelTotalEncontrado.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelTotalEncontrado.AutoSize = true;
            labelTotalEncontrado.BackColor = Color.Transparent;
            labelTotalEncontrado.ForeColor = Color.Black;
            labelTotalEncontrado.Location = new Point(12, 654);
            labelTotalEncontrado.Name = "labelTotalEncontrado";
            labelTotalEncontrado.Size = new Size(0, 18);
            labelTotalEncontrado.TabIndex = 10;
            // 
            // labelTotalAtivo
            // 
            labelTotalAtivo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelTotalAtivo.AutoSize = true;
            labelTotalAtivo.BackColor = Color.Transparent;
            labelTotalAtivo.ForeColor = Color.SteelBlue;
            labelTotalAtivo.Location = new Point(819, 654);
            labelTotalAtivo.Name = "labelTotalAtivo";
            labelTotalAtivo.Size = new Size(0, 18);
            labelTotalAtivo.TabIndex = 11;
            // 
            // labelTotalCancelado
            // 
            labelTotalCancelado.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelTotalCancelado.AutoSize = true;
            labelTotalCancelado.BackColor = Color.Transparent;
            labelTotalCancelado.ForeColor = Color.Red;
            labelTotalCancelado.Location = new Point(1013, 654);
            labelTotalCancelado.Name = "labelTotalCancelado";
            labelTotalCancelado.Size = new Size(0, 18);
            labelTotalCancelado.TabIndex = 12;
            // 
            // labelNadaEncontrado
            // 
            labelNadaEncontrado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelNadaEncontrado.BackColor = Color.White;
            labelNadaEncontrado.Font = new Font("Consolas", 11F, FontStyle.Bold);
            labelNadaEncontrado.Location = new Point(12, 142);
            labelNadaEncontrado.Name = "labelNadaEncontrado";
            labelNadaEncontrado.Size = new Size(1240, 484);
            labelNadaEncontrado.TabIndex = 13;
            labelNadaEncontrado.Text = "Nada encontrado...";
            labelNadaEncontrado.TextAlign = ContentAlignment.MiddleCenter;
            labelNadaEncontrado.Visible = false;
            // 
            // reportViewerRelatorio
            // 
            reportViewerRelatorio.Location = new Point(0, 0);
            reportViewerRelatorio.Name = "ReportViewer";
            reportViewerRelatorio.ServerReport.BearerToken = null;
            reportViewerRelatorio.Size = new Size(250, 250);
            reportViewerRelatorio.TabIndex = 0;
            reportViewerRelatorio.Visible = false;
            // 
            // buttonProcurar
            // 
            buttonProcurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonProcurar.BackColor = Color.Transparent;
            buttonProcurar.Cursor = Cursors.Hand;
            buttonProcurar.FlatAppearance.BorderSize = 0;
            buttonProcurar.FlatStyle = FlatStyle.Flat;
            buttonProcurar.Image = Properties.Resources.icon_buscar;
            buttonProcurar.Location = new Point(1132, 34);
            buttonProcurar.Name = "buttonProcurar";
            buttonProcurar.Size = new Size(48, 48);
            buttonProcurar.TabIndex = 14;
            buttonProcurar.TabStop = false;
            buttonProcurar.UseVisualStyleBackColor = false;
            buttonProcurar.Click += ButtonProcurar_Click;
            // 
            // pictureBoxCarregando
            // 
            pictureBoxCarregando.BackColor = Color.White;
            pictureBoxCarregando.Image = Properties.Resources.animation_carregando;
            pictureBoxCarregando.Location = new Point(552, 314);
            pictureBoxCarregando.Name = "pictureBoxCarregando";
            pictureBoxCarregando.Size = new Size(150, 150);
            pictureBoxCarregando.TabIndex = 16;
            pictureBoxCarregando.TabStop = false;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background_gradiente;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1264, 681);
            Controls.Add(pictureBoxCarregando);
            Controls.Add(buttonProcurar);
            Controls.Add(reportViewerRelatorio);
            Controls.Add(labelNadaEncontrado);
            Controls.Add(labelTotalCancelado);
            Controls.Add(labelTotalAtivo);
            Controls.Add(labelTotalEncontrado);
            Controls.Add(buttonRecarregar);
            Controls.Add(dataGridPessoaIdosa);
            Controls.Add(groupBoxBuscar);
            Controls.Add(groupBoxAcoes);
            DoubleBuffered = true;
            Font = new Font("Consolas", 11F);
            ForeColor = Color.SteelBlue;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ASFA - Associação Sagrada Família";
            WindowState = FormWindowState.Maximized;
            Load += FormMenuUsuarios_Load;
            groupBoxAcoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridPessoaIdosa).EndInit();
            groupBoxBuscar.ResumeLayout(false);
            groupBoxBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCarregando).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAcoes;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Button buttonRelatorio;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonFicha;
        private System.Windows.Forms.DataGridView dataGridPessoaIdosa;
        private System.Windows.Forms.GroupBox groupBoxBuscar;
        private Button buttonProcurar;
        private Button buttonRecarregar;
        private Label labelEstadoCivil;
        private Label labelSituacao;
        private Label labelCPFouRG;
        private Label labelNome;
        private Label labelEnderecosGerais;
        private TextBox textEndereco;
        private TextBox textCPFouRG;
        private TextBox textNome;
        private ComboBox comboBoxEstadoCivil;
        private ComboBox comboBoxSituacao;
        private Label labelTotalEncontrado;
        private Label labelTotalAtivo;
        private Label labelTotalCancelado;
        private Label labelNadaEncontrado;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerRelatorio;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn DataCadastro;
        private DataGridViewTextBoxColumn DataNascimento;
        private DataGridViewTextBoxColumn EstadoCivil;
        private DataGridViewTextBoxColumn Cpf;
        private DataGridViewTextBoxColumn Rg;
        private DataGridViewTextBoxColumn OrgaoEmissor;
        private DataGridViewTextBoxColumn Religiao;
        private DataGridViewTextBoxColumn Naturalidade;
        private DataGridViewTextBoxColumn Cep;
        private DataGridViewTextBoxColumn Logradouro;
        private DataGridViewTextBoxColumn Numero;
        private DataGridViewTextBoxColumn Cidade;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Bairro;
        private DataGridViewTextBoxColumn Moradia;
        private DataGridViewTextBoxColumn Telefone;
        private DataGridViewTextBoxColumn Endereco;
        private DataGridViewCheckBoxColumn Ativo;
        private PictureBox pictureBoxCarregando;
    }
}