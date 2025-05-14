namespace ASFA
{
    partial class FormCadastroDependente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroDependente));
            textDataNascimento = new DateTimePicker();
            labelDataNascimento = new Label();
            textNome = new TextBox();
            labelNome = new Label();
            comboBoxParentesco = new ComboBox();
            labelParentesco = new Label();
            labelEstaNoCeinf = new Label();
            textBoxCeinf = new TextBox();
            labelCeinf = new Label();
            labelCeinfBairro = new Label();
            textBoxCeinfBairro = new TextBox();
            labelProgramaPastoralLocal = new Label();
            textBoxProgramaPastoralLocal = new TextBox();
            labelProgramaPastoralQual = new Label();
            textBoxProgramaPastoral = new TextBox();
            labelProgramaPastoral = new Label();
            labelNivelSerieAtualConcluido = new Label();
            labelAlfabetizado = new Label();
            labelSituacaoOcupacional = new Label();
            comboBoxSituacaoOcupacional = new ComboBox();
            labelEstudaAtualmente = new Label();
            comboBoxNivelSerie = new ComboBox();
            comboBoxCursoFormacao = new ComboBox();
            labelCursoTecnicoFormacaoProfissional = new Label();
            labelAposentado = new Label();
            comboBoxAposentadoMotivo = new ComboBox();
            labelDeficiencia = new Label();
            labelDeficienciaQual = new Label();
            comboBoxDeficiencia = new ComboBox();
            comboBoxBeneficio = new ComboBox();
            labelBeneficio = new Label();
            labelRenda = new Label();
            comboBoxRenda = new ComboBox();
            labelProblemaSaudeQual = new Label();
            comboBoxSaude = new ComboBox();
            labelProblemaSaude = new Label();
            labelTrabalhoPastoralSocialQual = new Label();
            labelTrabalhoPastoralSocial = new Label();
            textBoxTrabalhoPastoralSocial = new TextBox();
            textBoxAtividade = new TextBox();
            labelAtividadeQual = new Label();
            labelAtividade = new Label();
            textBoxTrabalhoVoluntario = new TextBox();
            labelTrabalhoVoluntarioQual = new Label();
            labelTrabalhoVoluntario = new Label();
            textBoxTrabalhoVoluntarioOnde = new TextBox();
            labelTrabalhoVoluntarioOnde = new Label();
            ButtonCancelar = new Button();
            ButtonSalvar = new Button();
            radioButtonNaoEstaNoCeinf = new RadioButton();
            panel1 = new Panel();
            radioButtonSimEstaNoCeinf = new RadioButton();
            panel2 = new Panel();
            radioButtonSimProgramaPastoral = new RadioButton();
            radioButtonNaoProgramaPastoral = new RadioButton();
            panel8 = new Panel();
            radioButtonSimTrabalhoPastoral = new RadioButton();
            radioButtonNaoTrabalhoPastoral = new RadioButton();
            panel9 = new Panel();
            radioButtonSimAtividade = new RadioButton();
            radioButtonNaoAtividade = new RadioButton();
            panel10 = new Panel();
            radioButtonSimTrabalhoVoluntario = new RadioButton();
            radioButtonNaoTrabalhoVoluntario = new RadioButton();
            panel3 = new Panel();
            radioButtonSimAlfabetizado = new RadioButton();
            radioButtonNaoAlfabetizado = new RadioButton();
            panel4 = new Panel();
            radioButtonSimEstuda = new RadioButton();
            radioButtonNaoEstuda = new RadioButton();
            textBoxSaudeExplique = new TextBox();
            textBoxDeficienciaExplique = new TextBox();
            panel5 = new Panel();
            radioButtonSimFazTratamento = new RadioButton();
            radioButtonNaoFazTratamento = new RadioButton();
            labelTratamento = new Label();
            textBoxTratamentoOnde = new TextBox();
            labelTratamentoOnde = new Label();
            labelMedicamentoControlado = new Label();
            labelUbsLocal = new Label();
            panel7 = new Panel();
            radioButtonSimRecursoUbs = new RadioButton();
            radioButtonNaoRecursoUbs = new RadioButton();
            panel6 = new Panel();
            radioButtonSimMedicamentoControlado = new RadioButton();
            radioButtonNaoMedicamentoControlado = new RadioButton();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // textDataNascimento
            // 
            textDataNascimento.CustomFormat = "";
            textDataNascimento.Format = DateTimePickerFormat.Custom;
            textDataNascimento.Location = new Point(603, 54);
            textDataNascimento.Margin = new Padding(4, 3, 4, 3);
            textDataNascimento.Name = "textDataNascimento";
            textDataNascimento.Size = new Size(114, 23);
            textDataNascimento.TabIndex = 2;
            // 
            // labelDataNascimento
            // 
            labelDataNascimento.AutoSize = true;
            labelDataNascimento.BackColor = Color.Transparent;
            labelDataNascimento.Location = new Point(603, 35);
            labelDataNascimento.Margin = new Padding(4, 0, 4, 0);
            labelDataNascimento.Name = "labelDataNascimento";
            labelDataNascimento.Size = new Size(114, 15);
            labelDataNascimento.TabIndex = 2;
            labelDataNascimento.Text = "Data de Nascimento";
            // 
            // textNome
            // 
            textNome.AllowDrop = true;
            textNome.Location = new Point(46, 54);
            textNome.Margin = new Padding(4, 3, 4, 3);
            textNome.Name = "textNome";
            textNome.Size = new Size(437, 23);
            textNome.TabIndex = 0;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.BackColor = Color.Transparent;
            labelNome.Location = new Point(46, 36);
            labelNome.Margin = new Padding(4, 0, 4, 0);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(96, 15);
            labelNome.TabIndex = 4;
            labelNome.Text = "Nome Completo";
            // 
            // comboBoxParentesco
            // 
            comboBoxParentesco.AutoCompleteCustomSource.AddRange(new string[] { "Avô(ó)", "Bisneto(a)", "Conjulgue", "Cunhado(a)", "Filho(a)", "Genro", "Mãe", "Neto(a)", "Nora", "Pai", "Primo(a)", "Sobrinho(a)", "Sogro(a)", "Tetraneto(a)", "Tio(a)" });
            comboBoxParentesco.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxParentesco.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxParentesco.DropDownHeight = 100;
            comboBoxParentesco.FormattingEnabled = true;
            comboBoxParentesco.IntegralHeight = false;
            comboBoxParentesco.Items.AddRange(new object[] { "Avô(ó)", "Bisavô(ó)", "Bisneto(a)", "Cônjugue", "Cunhado(a)", "Filho(a)", "Genro", "Irmão", "Mãe", "Neto(a)", "Nora", "Pai", "Sobrinho(a)", "Sogro(a)", "Tio(a)" });
            comboBoxParentesco.Location = new Point(507, 54);
            comboBoxParentesco.Margin = new Padding(4, 3, 4, 3);
            comboBoxParentesco.Name = "comboBoxParentesco";
            comboBoxParentesco.Size = new Size(79, 23);
            comboBoxParentesco.TabIndex = 1;
            // 
            // labelParentesco
            // 
            labelParentesco.AutoSize = true;
            labelParentesco.BackColor = Color.Transparent;
            labelParentesco.Location = new Point(507, 35);
            labelParentesco.Margin = new Padding(4, 0, 4, 0);
            labelParentesco.Name = "labelParentesco";
            labelParentesco.Size = new Size(65, 15);
            labelParentesco.TabIndex = 6;
            labelParentesco.Text = "Parentesco";
            // 
            // labelEstaNoCeinf
            // 
            labelEstaNoCeinf.AutoSize = true;
            labelEstaNoCeinf.BackColor = Color.Transparent;
            labelEstaNoCeinf.Location = new Point(46, 102);
            labelEstaNoCeinf.Margin = new Padding(4, 0, 4, 0);
            labelEstaNoCeinf.Name = "labelEstaNoCeinf";
            labelEstaNoCeinf.Size = new Size(242, 15);
            labelEstaNoCeinf.TabIndex = 9;
            labelEstaNoCeinf.Text = "Está no CEINF (Centro de Educação Infantil)?";
            // 
            // textBoxCeinf
            // 
            textBoxCeinf.AllowDrop = true;
            textBoxCeinf.Enabled = false;
            textBoxCeinf.Location = new Point(401, 116);
            textBoxCeinf.Margin = new Padding(4, 3, 4, 3);
            textBoxCeinf.Name = "textBoxCeinf";
            textBoxCeinf.Size = new Size(383, 23);
            textBoxCeinf.TabIndex = 5;
            // 
            // labelCeinf
            // 
            labelCeinf.AutoSize = true;
            labelCeinf.BackColor = Color.Transparent;
            labelCeinf.Location = new Point(401, 98);
            labelCeinf.Margin = new Padding(4, 0, 4, 0);
            labelCeinf.Name = "labelCeinf";
            labelCeinf.Size = new Size(39, 15);
            labelCeinf.TabIndex = 11;
            labelCeinf.Text = "CEINF";
            // 
            // labelCeinfBairro
            // 
            labelCeinfBairro.AutoSize = true;
            labelCeinfBairro.BackColor = Color.Transparent;
            labelCeinfBairro.Location = new Point(806, 97);
            labelCeinfBairro.Margin = new Padding(4, 0, 4, 0);
            labelCeinfBairro.Name = "labelCeinfBairro";
            labelCeinfBairro.Size = new Size(38, 15);
            labelCeinfBairro.TabIndex = 13;
            labelCeinfBairro.Text = "Bairro";
            // 
            // textBoxCeinfBairro
            // 
            textBoxCeinfBairro.AllowDrop = true;
            textBoxCeinfBairro.Enabled = false;
            textBoxCeinfBairro.Location = new Point(806, 116);
            textBoxCeinfBairro.Margin = new Padding(4, 3, 4, 3);
            textBoxCeinfBairro.Name = "textBoxCeinfBairro";
            textBoxCeinfBairro.Size = new Size(348, 23);
            textBoxCeinfBairro.TabIndex = 6;
            // 
            // labelProgramaPastoralLocal
            // 
            labelProgramaPastoralLocal.AutoSize = true;
            labelProgramaPastoralLocal.BackColor = Color.Transparent;
            labelProgramaPastoralLocal.Location = new Point(806, 156);
            labelProgramaPastoralLocal.Margin = new Padding(4, 0, 4, 0);
            labelProgramaPastoralLocal.Name = "labelProgramaPastoralLocal";
            labelProgramaPastoralLocal.Size = new Size(35, 15);
            labelProgramaPastoralLocal.TabIndex = 19;
            labelProgramaPastoralLocal.Text = "Local";
            // 
            // textBoxProgramaPastoralLocal
            // 
            textBoxProgramaPastoralLocal.AllowDrop = true;
            textBoxProgramaPastoralLocal.Enabled = false;
            textBoxProgramaPastoralLocal.Location = new Point(806, 174);
            textBoxProgramaPastoralLocal.Margin = new Padding(4, 3, 4, 3);
            textBoxProgramaPastoralLocal.Name = "textBoxProgramaPastoralLocal";
            textBoxProgramaPastoralLocal.Size = new Size(348, 23);
            textBoxProgramaPastoralLocal.TabIndex = 8;
            // 
            // labelProgramaPastoralQual
            // 
            labelProgramaPastoralQual.AutoSize = true;
            labelProgramaPastoralQual.BackColor = Color.Transparent;
            labelProgramaPastoralQual.Location = new Point(401, 157);
            labelProgramaPastoralQual.Margin = new Padding(4, 0, 4, 0);
            labelProgramaPastoralQual.Name = "labelProgramaPastoralQual";
            labelProgramaPastoralQual.Size = new Size(106, 15);
            labelProgramaPastoralQual.TabIndex = 17;
            labelProgramaPastoralQual.Text = "Programa/Pastoral";
            // 
            // textBoxProgramaPastoral
            // 
            textBoxProgramaPastoral.AllowDrop = true;
            textBoxProgramaPastoral.Enabled = false;
            textBoxProgramaPastoral.Location = new Point(401, 174);
            textBoxProgramaPastoral.Margin = new Padding(4, 3, 4, 3);
            textBoxProgramaPastoral.Name = "textBoxProgramaPastoral";
            textBoxProgramaPastoral.Size = new Size(383, 23);
            textBoxProgramaPastoral.TabIndex = 7;
            // 
            // labelProgramaPastoral
            // 
            labelProgramaPastoral.AutoSize = true;
            labelProgramaPastoral.BackColor = Color.Transparent;
            labelProgramaPastoral.Location = new Point(46, 157);
            labelProgramaPastoral.Margin = new Padding(4, 0, 4, 0);
            labelProgramaPastoral.Name = "labelProgramaPastoral";
            labelProgramaPastoral.Size = new Size(335, 15);
            labelProgramaPastoral.TabIndex = 15;
            labelProgramaPastoral.Text = "Participa de algum programa de saúde ou pastoral da criança?";
            // 
            // labelNivelSerieAtualConcluido
            // 
            labelNivelSerieAtualConcluido.AutoSize = true;
            labelNivelSerieAtualConcluido.BackColor = Color.Transparent;
            labelNivelSerieAtualConcluido.Location = new Point(713, 212);
            labelNivelSerieAtualConcluido.Margin = new Padding(4, 0, 4, 0);
            labelNivelSerieAtualConcluido.Name = "labelNivelSerieAtualConcluido";
            labelNivelSerieAtualConcluido.Size = new Size(169, 15);
            labelNivelSerieAtualConcluido.TabIndex = 25;
            labelNivelSerieAtualConcluido.Text = "Nível e Série Atual e Concluído";
            // 
            // labelAlfabetizado
            // 
            labelAlfabetizado.AutoSize = true;
            labelAlfabetizado.BackColor = Color.Transparent;
            labelAlfabetizado.Location = new Point(559, 212);
            labelAlfabetizado.Margin = new Padding(4, 0, 4, 0);
            labelAlfabetizado.Name = "labelAlfabetizado";
            labelAlfabetizado.Size = new Size(78, 15);
            labelAlfabetizado.TabIndex = 23;
            labelAlfabetizado.Text = "Alfabetizado?";
            // 
            // labelSituacaoOcupacional
            // 
            labelSituacaoOcupacional.AutoSize = true;
            labelSituacaoOcupacional.BackColor = Color.Transparent;
            labelSituacaoOcupacional.Location = new Point(46, 217);
            labelSituacaoOcupacional.Margin = new Padding(4, 0, 4, 0);
            labelSituacaoOcupacional.MaximumSize = new Size(242, 0);
            labelSituacaoOcupacional.Name = "labelSituacaoOcupacional";
            labelSituacaoOcupacional.Size = new Size(122, 15);
            labelSituacaoOcupacional.TabIndex = 21;
            labelSituacaoOcupacional.Text = "Situação Ocupacional";
            // 
            // comboBoxSituacaoOcupacional
            // 
            comboBoxSituacaoOcupacional.AutoCompleteCustomSource.AddRange(new string[] { "Avô(ó)", "Bisneto(a)", "Conjulgue", "Cunhado(a)", "Filho(a)", "Genro", "Mãe", "Neto(a)", "Nora", "Pai", "Primo(a)", "Sobrinho(a)", "Sogro(a)", "Tetraneto(a)", "Tio(a)" });
            comboBoxSituacaoOcupacional.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxSituacaoOcupacional.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxSituacaoOcupacional.DropDownHeight = 100;
            comboBoxSituacaoOcupacional.FormattingEnabled = true;
            comboBoxSituacaoOcupacional.IntegralHeight = false;
            comboBoxSituacaoOcupacional.Items.AddRange(new object[] { "Assalariado c/ Carteira Assinada ou Funcionário Público", "Assalariado s/ Carteira Assinada", "Aposentado", "Pensionista", "Diarista", "Autônomo", "Aprendiz", "Trabalho Informal (bico)", "Desempregado", "Outro" });
            comboBoxSituacaoOcupacional.Location = new Point(46, 235);
            comboBoxSituacaoOcupacional.Margin = new Padding(4, 3, 4, 3);
            comboBoxSituacaoOcupacional.Name = "comboBoxSituacaoOcupacional";
            comboBoxSituacaoOcupacional.Size = new Size(333, 23);
            comboBoxSituacaoOcupacional.TabIndex = 9;
            // 
            // labelEstudaAtualmente
            // 
            labelEstudaAtualmente.AutoSize = true;
            labelEstudaAtualmente.BackColor = Color.Transparent;
            labelEstudaAtualmente.Location = new Point(401, 212);
            labelEstudaAtualmente.Margin = new Padding(4, 0, 4, 0);
            labelEstudaAtualmente.Name = "labelEstudaAtualmente";
            labelEstudaAtualmente.Size = new Size(110, 15);
            labelEstudaAtualmente.TabIndex = 28;
            labelEstudaAtualmente.Text = "Estuda atualmente?";
            // 
            // comboBoxNivelSerie
            // 
            comboBoxNivelSerie.AutoCompleteCustomSource.AddRange(new string[] { "Avô(ó)", "Bisneto(a)", "Conjulgue", "Cunhado(a)", "Filho(a)", "Genro", "Mãe", "Neto(a)", "Nora", "Pai", "Primo(a)", "Sobrinho(a)", "Sogro(a)", "Tetraneto(a)", "Tio(a)" });
            comboBoxNivelSerie.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxNivelSerie.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxNivelSerie.DropDownHeight = 100;
            comboBoxNivelSerie.FormattingEnabled = true;
            comboBoxNivelSerie.IntegralHeight = false;
            comboBoxNivelSerie.Items.AddRange(new object[] { "Educação Infantil", "Ensino Fundamental completo", "Ensino Fundamental incompleto", "Ensino Médio completo", "Ensino Médio incompleto", "Superior completo", "Superior incompleto" });
            comboBoxNivelSerie.Location = new Point(713, 236);
            comboBoxNivelSerie.Margin = new Padding(4, 3, 4, 3);
            comboBoxNivelSerie.Name = "comboBoxNivelSerie";
            comboBoxNivelSerie.Size = new Size(199, 23);
            comboBoxNivelSerie.TabIndex = 10;
            // 
            // comboBoxCursoFormacao
            // 
            comboBoxCursoFormacao.AutoCompleteCustomSource.AddRange(new string[] { "Avô(ó)", "Bisneto(a)", "Conjulgue", "Cunhado(a)", "Filho(a)", "Genro", "Mãe", "Neto(a)", "Nora", "Pai", "Primo(a)", "Sobrinho(a)", "Sogro(a)", "Tetraneto(a)", "Tio(a)" });
            comboBoxCursoFormacao.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxCursoFormacao.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxCursoFormacao.DropDownHeight = 100;
            comboBoxCursoFormacao.FormattingEnabled = true;
            comboBoxCursoFormacao.IntegralHeight = false;
            comboBoxCursoFormacao.Items.AddRange(new object[] { "Técnico", "MOVA (Alfabetização)", "EJA (Ensino de jovens e adultos)", "Outro" });
            comboBoxCursoFormacao.Location = new Point(938, 236);
            comboBoxCursoFormacao.Margin = new Padding(4, 3, 4, 3);
            comboBoxCursoFormacao.Name = "comboBoxCursoFormacao";
            comboBoxCursoFormacao.Size = new Size(216, 23);
            comboBoxCursoFormacao.TabIndex = 11;
            // 
            // labelCursoTecnicoFormacaoProfissional
            // 
            labelCursoTecnicoFormacaoProfissional.AutoSize = true;
            labelCursoTecnicoFormacaoProfissional.BackColor = Color.Transparent;
            labelCursoTecnicoFormacaoProfissional.Location = new Point(938, 212);
            labelCursoTecnicoFormacaoProfissional.Margin = new Padding(4, 0, 4, 0);
            labelCursoTecnicoFormacaoProfissional.Name = "labelCursoTecnicoFormacaoProfissional";
            labelCursoTecnicoFormacaoProfissional.Size = new Size(216, 15);
            labelCursoTecnicoFormacaoProfissional.TabIndex = 31;
            labelCursoTecnicoFormacaoProfissional.Text = "Cursos Técnico e Formação Profissional";
            // 
            // labelAposentado
            // 
            labelAposentado.AutoSize = true;
            labelAposentado.BackColor = Color.Transparent;
            labelAposentado.Location = new Point(935, 35);
            labelAposentado.Margin = new Padding(4, 0, 4, 0);
            labelAposentado.Name = "labelAposentado";
            labelAposentado.Size = new Size(76, 15);
            labelAposentado.TabIndex = 34;
            labelAposentado.Text = "Aposentado?";
            // 
            // comboBoxAposentadoMotivo
            // 
            comboBoxAposentadoMotivo.AutoCompleteCustomSource.AddRange(new string[] { "Avô(ó)", "Bisneto(a)", "Conjulgue", "Cunhado(a)", "Filho(a)", "Genro", "Mãe", "Neto(a)", "Nora", "Pai", "Primo(a)", "Sobrinho(a)", "Sogro(a)", "Tetraneto(a)", "Tio(a)" });
            comboBoxAposentadoMotivo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxAposentadoMotivo.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxAposentadoMotivo.DropDownHeight = 100;
            comboBoxAposentadoMotivo.FormattingEnabled = true;
            comboBoxAposentadoMotivo.IntegralHeight = false;
            comboBoxAposentadoMotivo.Items.AddRange(new object[] { "Não", "Tempo de Serviço", "Proporcional", "Invalidez", "Funrural", "Reserva", "Outro" });
            comboBoxAposentadoMotivo.Location = new Point(935, 53);
            comboBoxAposentadoMotivo.Margin = new Padding(4, 3, 4, 3);
            comboBoxAposentadoMotivo.Name = "comboBoxAposentadoMotivo";
            comboBoxAposentadoMotivo.Size = new Size(122, 23);
            comboBoxAposentadoMotivo.TabIndex = 4;
            // 
            // labelDeficiencia
            // 
            labelDeficiencia.AutoSize = true;
            labelDeficiencia.BackColor = Color.Transparent;
            labelDeficiencia.Location = new Point(46, 271);
            labelDeficiencia.Margin = new Padding(4, 0, 4, 0);
            labelDeficiencia.MaximumSize = new Size(242, 0);
            labelDeficiencia.Name = "labelDeficiencia";
            labelDeficiencia.Size = new Size(149, 15);
            labelDeficiencia.TabIndex = 37;
            labelDeficiencia.Text = "Possui alguma deficiência?";
            // 
            // labelDeficienciaQual
            // 
            labelDeficienciaQual.AutoSize = true;
            labelDeficienciaQual.BackColor = Color.Transparent;
            labelDeficienciaQual.Location = new Point(237, 269);
            labelDeficienciaQual.Margin = new Padding(4, 0, 4, 0);
            labelDeficienciaQual.Name = "labelDeficienciaQual";
            labelDeficienciaQual.Size = new Size(37, 15);
            labelDeficienciaQual.TabIndex = 40;
            labelDeficienciaQual.Text = "Qual?";
            // 
            // comboBoxDeficiencia
            // 
            comboBoxDeficiencia.AutoCompleteCustomSource.AddRange(new string[] { "Avô(ó)", "Bisneto(a)", "Conjulgue", "Cunhado(a)", "Filho(a)", "Genro", "Mãe", "Neto(a)", "Nora", "Pai", "Primo(a)", "Sobrinho(a)", "Sogro(a)", "Tetraneto(a)", "Tio(a)" });
            comboBoxDeficiencia.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxDeficiencia.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxDeficiencia.DropDownHeight = 100;
            comboBoxDeficiencia.FormattingEnabled = true;
            comboBoxDeficiencia.IntegralHeight = false;
            comboBoxDeficiencia.Items.AddRange(new object[] { "Não", "Auditiva", "Visual", "Mental", "Física", "Múltiplas", "Outra" });
            comboBoxDeficiencia.Location = new Point(46, 287);
            comboBoxDeficiencia.Margin = new Padding(4, 3, 4, 3);
            comboBoxDeficiencia.Name = "comboBoxDeficiencia";
            comboBoxDeficiencia.Size = new Size(149, 23);
            comboBoxDeficiencia.TabIndex = 12;
            comboBoxDeficiencia.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            // 
            // comboBoxBeneficio
            // 
            comboBoxBeneficio.AutoCompleteCustomSource.AddRange(new string[] { "Avô(ó)", "Bisneto(a)", "Conjulgue", "Cunhado(a)", "Filho(a)", "Genro", "Mãe", "Neto(a)", "Nora", "Pai", "Primo(a)", "Sobrinho(a)", "Sogro(a)", "Tetraneto(a)", "Tio(a)" });
            comboBoxBeneficio.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxBeneficio.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxBeneficio.DropDownHeight = 100;
            comboBoxBeneficio.FormattingEnabled = true;
            comboBoxBeneficio.IntegralHeight = false;
            comboBoxBeneficio.Items.AddRange(new object[] { "Não", "Benefício de Prestação Continuada idoso", "Benefício de Prestação Continuada PcD", "Programa Bolsa Família", "Pré Jovem", "Passe Social", "Outro" });
            comboBoxBeneficio.Location = new Point(559, 287);
            comboBoxBeneficio.Margin = new Padding(4, 3, 4, 3);
            comboBoxBeneficio.Name = "comboBoxBeneficio";
            comboBoxBeneficio.Size = new Size(248, 23);
            comboBoxBeneficio.TabIndex = 14;
            comboBoxBeneficio.Text = "Não";
            // 
            // labelBeneficio
            // 
            labelBeneficio.AutoSize = true;
            labelBeneficio.BackColor = Color.Transparent;
            labelBeneficio.Location = new Point(559, 269);
            labelBeneficio.Margin = new Padding(4, 0, 4, 0);
            labelBeneficio.MaximumSize = new Size(242, 0);
            labelBeneficio.Name = "labelBeneficio";
            labelBeneficio.Size = new Size(139, 15);
            labelBeneficio.TabIndex = 42;
            labelBeneficio.Text = "Recebe algum benefício?";
            // 
            // labelRenda
            // 
            labelRenda.AutoSize = true;
            labelRenda.BackColor = Color.Transparent;
            labelRenda.Location = new Point(746, 36);
            labelRenda.Margin = new Padding(4, 0, 4, 0);
            labelRenda.Name = "labelRenda";
            labelRenda.Size = new Size(40, 15);
            labelRenda.TabIndex = 46;
            labelRenda.Text = "Renda";
            // 
            // comboBoxRenda
            // 
            comboBoxRenda.AutoCompleteCustomSource.AddRange(new string[] { "Avô(ó)", "Bisneto(a)", "Conjulgue", "Cunhado(a)", "Filho(a)", "Genro", "Mãe", "Neto(a)", "Nora", "Pai", "Primo(a)", "Sobrinho(a)", "Sogro(a)", "Tetraneto(a)", "Tio(a)" });
            comboBoxRenda.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxRenda.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxRenda.DropDownHeight = 100;
            comboBoxRenda.FormattingEnabled = true;
            comboBoxRenda.IntegralHeight = false;
            comboBoxRenda.Items.AddRange(new object[] { "Sem renda", "Até 1 salário mínimo", "Até 2 salários mínimos", "Acima de 2 salários mínimos" });
            comboBoxRenda.Location = new Point(746, 54);
            comboBoxRenda.Margin = new Padding(4, 3, 4, 3);
            comboBoxRenda.Name = "comboBoxRenda";
            comboBoxRenda.Size = new Size(170, 23);
            comboBoxRenda.TabIndex = 3;
            // 
            // labelProblemaSaudeQual
            // 
            labelProblemaSaudeQual.AutoSize = true;
            labelProblemaSaudeQual.BackColor = Color.Transparent;
            labelProblemaSaudeQual.Location = new Point(237, 325);
            labelProblemaSaudeQual.Margin = new Padding(4, 0, 4, 0);
            labelProblemaSaudeQual.Name = "labelProblemaSaudeQual";
            labelProblemaSaudeQual.Size = new Size(37, 15);
            labelProblemaSaudeQual.TabIndex = 50;
            labelProblemaSaudeQual.Text = "Qual?";
            // 
            // comboBoxSaude
            // 
            comboBoxSaude.AutoCompleteCustomSource.AddRange(new string[] { "Avô(ó)", "Bisneto(a)", "Conjulgue", "Cunhado(a)", "Filho(a)", "Genro", "Mãe", "Neto(a)", "Nora", "Pai", "Primo(a)", "Sobrinho(a)", "Sogro(a)", "Tetraneto(a)", "Tio(a)" });
            comboBoxSaude.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxSaude.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxSaude.DropDownHeight = 100;
            comboBoxSaude.FormattingEnabled = true;
            comboBoxSaude.IntegralHeight = false;
            comboBoxSaude.Items.AddRange(new object[] { "Não", "Diabetes", "Colesterol", "Hipertensão", "Renal", "Cardíaca", "Osteoporose", "Artrose", "Colunas", "Epilepsia", "HIV", "Hanseníase", "Alcoólatra", "Dependente químico", "Outro" });
            comboBoxSaude.Location = new Point(46, 344);
            comboBoxSaude.Margin = new Padding(4, 3, 4, 3);
            comboBoxSaude.Name = "comboBoxSaude";
            comboBoxSaude.Size = new Size(149, 23);
            comboBoxSaude.TabIndex = 15;
            comboBoxSaude.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            // 
            // labelProblemaSaude
            // 
            labelProblemaSaude.AutoSize = true;
            labelProblemaSaude.BackColor = Color.Transparent;
            labelProblemaSaude.Location = new Point(46, 326);
            labelProblemaSaude.Margin = new Padding(4, 0, 4, 0);
            labelProblemaSaude.MaximumSize = new Size(242, 0);
            labelProblemaSaude.Name = "labelProblemaSaude";
            labelProblemaSaude.Size = new Size(174, 15);
            labelProblemaSaude.TabIndex = 48;
            labelProblemaSaude.Text = "Apresenta problemas de saúde?";
            // 
            // labelTrabalhoPastoralSocialQual
            // 
            labelTrabalhoPastoralSocialQual.AutoSize = true;
            labelTrabalhoPastoralSocialQual.BackColor = Color.Transparent;
            labelTrabalhoPastoralSocialQual.Location = new Point(434, 442);
            labelTrabalhoPastoralSocialQual.Margin = new Padding(4, 0, 4, 0);
            labelTrabalhoPastoralSocialQual.Name = "labelTrabalhoPastoralSocialQual";
            labelTrabalhoPastoralSocialQual.Size = new Size(37, 15);
            labelTrabalhoPastoralSocialQual.TabIndex = 54;
            labelTrabalhoPastoralSocialQual.Text = "Qual?";
            // 
            // labelTrabalhoPastoralSocial
            // 
            labelTrabalhoPastoralSocial.AutoSize = true;
            labelTrabalhoPastoralSocial.BackColor = Color.Transparent;
            labelTrabalhoPastoralSocial.Location = new Point(46, 442);
            labelTrabalhoPastoralSocial.Margin = new Padding(4, 0, 4, 0);
            labelTrabalhoPastoralSocial.Name = "labelTrabalhoPastoralSocial";
            labelTrabalhoPastoralSocial.Size = new Size(366, 15);
            labelTrabalhoPastoralSocial.TabIndex = 52;
            labelTrabalhoPastoralSocial.Text = "Faz algum trabalho pastoral ou social na sua Igreja ou no seu bairro?";
            // 
            // textBoxTrabalhoPastoralSocial
            // 
            textBoxTrabalhoPastoralSocial.AllowDrop = true;
            textBoxTrabalhoPastoralSocial.Enabled = false;
            textBoxTrabalhoPastoralSocial.Location = new Point(434, 460);
            textBoxTrabalhoPastoralSocial.Margin = new Padding(4, 3, 4, 3);
            textBoxTrabalhoPastoralSocial.Name = "textBoxTrabalhoPastoralSocial";
            textBoxTrabalhoPastoralSocial.Size = new Size(413, 23);
            textBoxTrabalhoPastoralSocial.TabIndex = 18;
            // 
            // textBoxAtividade
            // 
            textBoxAtividade.AllowDrop = true;
            textBoxAtividade.Enabled = false;
            textBoxAtividade.Location = new Point(434, 512);
            textBoxAtividade.Margin = new Padding(4, 3, 4, 3);
            textBoxAtividade.Name = "textBoxAtividade";
            textBoxAtividade.Size = new Size(413, 23);
            textBoxAtividade.TabIndex = 19;
            // 
            // labelAtividadeQual
            // 
            labelAtividadeQual.AutoSize = true;
            labelAtividadeQual.BackColor = Color.Transparent;
            labelAtividadeQual.Location = new Point(434, 494);
            labelAtividadeQual.Margin = new Padding(4, 0, 4, 0);
            labelAtividadeQual.Name = "labelAtividadeQual";
            labelAtividadeQual.Size = new Size(37, 15);
            labelAtividadeQual.TabIndex = 58;
            labelAtividadeQual.Text = "Qual?";
            // 
            // labelAtividade
            // 
            labelAtividade.AutoSize = true;
            labelAtividade.BackColor = Color.Transparent;
            labelAtividade.Location = new Point(46, 494);
            labelAtividade.Margin = new Padding(4, 0, 4, 0);
            labelAtividade.Name = "labelAtividade";
            labelAtividade.Size = new Size(343, 15);
            labelAtividade.TabIndex = 57;
            labelAtividade.Text = "Desenvolve alguma atividade  na Comunidade Sagrada Família?";
            // 
            // textBoxTrabalhoVoluntario
            // 
            textBoxTrabalhoVoluntario.AllowDrop = true;
            textBoxTrabalhoVoluntario.Enabled = false;
            textBoxTrabalhoVoluntario.Location = new Point(434, 568);
            textBoxTrabalhoVoluntario.Margin = new Padding(4, 3, 4, 3);
            textBoxTrabalhoVoluntario.Name = "textBoxTrabalhoVoluntario";
            textBoxTrabalhoVoluntario.Size = new Size(413, 23);
            textBoxTrabalhoVoluntario.TabIndex = 20;
            // 
            // labelTrabalhoVoluntarioQual
            // 
            labelTrabalhoVoluntarioQual.AutoSize = true;
            labelTrabalhoVoluntarioQual.BackColor = Color.Transparent;
            labelTrabalhoVoluntarioQual.Location = new Point(434, 550);
            labelTrabalhoVoluntarioQual.Margin = new Padding(4, 0, 4, 0);
            labelTrabalhoVoluntarioQual.Name = "labelTrabalhoVoluntarioQual";
            labelTrabalhoVoluntarioQual.Size = new Size(37, 15);
            labelTrabalhoVoluntarioQual.TabIndex = 62;
            labelTrabalhoVoluntarioQual.Text = "Qual?";
            // 
            // labelTrabalhoVoluntario
            // 
            labelTrabalhoVoluntario.AutoSize = true;
            labelTrabalhoVoluntario.BackColor = Color.Transparent;
            labelTrabalhoVoluntario.Location = new Point(46, 550);
            labelTrabalhoVoluntario.Margin = new Padding(4, 0, 4, 0);
            labelTrabalhoVoluntario.Name = "labelTrabalhoVoluntario";
            labelTrabalhoVoluntario.Size = new Size(253, 15);
            labelTrabalhoVoluntario.TabIndex = 61;
            labelTrabalhoVoluntario.Text = "Deseja desenvolver algum trabalho voluntário?";
            // 
            // textBoxTrabalhoVoluntarioOnde
            // 
            textBoxTrabalhoVoluntarioOnde.AllowDrop = true;
            textBoxTrabalhoVoluntarioOnde.Enabled = false;
            textBoxTrabalhoVoluntarioOnde.Location = new Point(875, 568);
            textBoxTrabalhoVoluntarioOnde.Margin = new Padding(4, 3, 4, 3);
            textBoxTrabalhoVoluntarioOnde.Name = "textBoxTrabalhoVoluntarioOnde";
            textBoxTrabalhoVoluntarioOnde.Size = new Size(279, 23);
            textBoxTrabalhoVoluntarioOnde.TabIndex = 21;
            // 
            // labelTrabalhoVoluntarioOnde
            // 
            labelTrabalhoVoluntarioOnde.AutoSize = true;
            labelTrabalhoVoluntarioOnde.BackColor = Color.Transparent;
            labelTrabalhoVoluntarioOnde.Location = new Point(875, 550);
            labelTrabalhoVoluntarioOnde.Margin = new Padding(4, 0, 4, 0);
            labelTrabalhoVoluntarioOnde.Name = "labelTrabalhoVoluntarioOnde";
            labelTrabalhoVoluntarioOnde.Size = new Size(41, 15);
            labelTrabalhoVoluntarioOnde.TabIndex = 64;
            labelTrabalhoVoluntarioOnde.Text = "Onde?";
            // 
            // ButtonCancelar
            // 
            ButtonCancelar.Cursor = Cursors.Hand;
            ButtonCancelar.FlatAppearance.BorderSize = 0;
            ButtonCancelar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonCancelar.Image = Properties.Resources.icon_cancelar;
            ButtonCancelar.Location = new Point(925, 614);
            ButtonCancelar.Margin = new Padding(4, 3, 4, 3);
            ButtonCancelar.Name = "ButtonCancelar";
            ButtonCancelar.Size = new Size(98, 27);
            ButtonCancelar.TabIndex = 65;
            ButtonCancelar.TabStop = false;
            ButtonCancelar.Text = "Cancelar";
            ButtonCancelar.TextAlign = ContentAlignment.MiddleRight;
            ButtonCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            ButtonCancelar.UseVisualStyleBackColor = true;
            ButtonCancelar.Click += ButtonCancelar_Click;
            // 
            // ButtonSalvar
            // 
            ButtonSalvar.Cursor = Cursors.Hand;
            ButtonSalvar.FlatAppearance.BorderSize = 0;
            ButtonSalvar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonSalvar.Image = Properties.Resources.icon_salvar;
            ButtonSalvar.Location = new Point(1056, 614);
            ButtonSalvar.Margin = new Padding(4, 3, 4, 3);
            ButtonSalvar.Name = "ButtonSalvar";
            ButtonSalvar.Size = new Size(98, 27);
            ButtonSalvar.TabIndex = 22;
            ButtonSalvar.Text = "Salvar";
            ButtonSalvar.TextAlign = ContentAlignment.MiddleRight;
            ButtonSalvar.TextImageRelation = TextImageRelation.ImageBeforeText;
            ButtonSalvar.UseVisualStyleBackColor = true;
            ButtonSalvar.Click += ButtonSalvar_Click;
            // 
            // radioButtonNaoEstaNoCeinf
            // 
            radioButtonNaoEstaNoCeinf.AutoSize = true;
            radioButtonNaoEstaNoCeinf.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radioButtonNaoEstaNoCeinf.Location = new Point(5, 3);
            radioButtonNaoEstaNoCeinf.Name = "radioButtonNaoEstaNoCeinf";
            radioButtonNaoEstaNoCeinf.Size = new Size(47, 19);
            radioButtonNaoEstaNoCeinf.TabIndex = 0;
            radioButtonNaoEstaNoCeinf.Text = "Não";
            radioButtonNaoEstaNoCeinf.UseVisualStyleBackColor = true;
            radioButtonNaoEstaNoCeinf.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(radioButtonSimEstaNoCeinf);
            panel1.Controls.Add(radioButtonNaoEstaNoCeinf);
            panel1.Location = new Point(46, 117);
            panel1.Name = "panel1";
            panel1.Size = new Size(116, 23);
            panel1.TabIndex = 68;
            // 
            // radioButtonSimEstaNoCeinf
            // 
            radioButtonSimEstaNoCeinf.AutoSize = true;
            radioButtonSimEstaNoCeinf.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radioButtonSimEstaNoCeinf.Location = new Point(59, 3);
            radioButtonSimEstaNoCeinf.Name = "radioButtonSimEstaNoCeinf";
            radioButtonSimEstaNoCeinf.Size = new Size(46, 19);
            radioButtonSimEstaNoCeinf.TabIndex = 1;
            radioButtonSimEstaNoCeinf.Text = "Sim";
            radioButtonSimEstaNoCeinf.UseVisualStyleBackColor = true;
            radioButtonSimEstaNoCeinf.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(radioButtonSimProgramaPastoral);
            panel2.Controls.Add(radioButtonNaoProgramaPastoral);
            panel2.Location = new Point(46, 175);
            panel2.Name = "panel2";
            panel2.Size = new Size(116, 23);
            panel2.TabIndex = 69;
            // 
            // radioButtonSimProgramaPastoral
            // 
            radioButtonSimProgramaPastoral.AutoSize = true;
            radioButtonSimProgramaPastoral.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radioButtonSimProgramaPastoral.Location = new Point(59, 3);
            radioButtonSimProgramaPastoral.Name = "radioButtonSimProgramaPastoral";
            radioButtonSimProgramaPastoral.Size = new Size(46, 19);
            radioButtonSimProgramaPastoral.TabIndex = 1;
            radioButtonSimProgramaPastoral.Text = "Sim";
            radioButtonSimProgramaPastoral.UseVisualStyleBackColor = true;
            radioButtonSimProgramaPastoral.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // radioButtonNaoProgramaPastoral
            // 
            radioButtonNaoProgramaPastoral.AutoSize = true;
            radioButtonNaoProgramaPastoral.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radioButtonNaoProgramaPastoral.Location = new Point(5, 3);
            radioButtonNaoProgramaPastoral.Name = "radioButtonNaoProgramaPastoral";
            radioButtonNaoProgramaPastoral.Size = new Size(47, 19);
            radioButtonNaoProgramaPastoral.TabIndex = 0;
            radioButtonNaoProgramaPastoral.Text = "Não";
            radioButtonNaoProgramaPastoral.UseVisualStyleBackColor = true;
            radioButtonNaoProgramaPastoral.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Transparent;
            panel8.Controls.Add(radioButtonSimTrabalhoPastoral);
            panel8.Controls.Add(radioButtonNaoTrabalhoPastoral);
            panel8.Location = new Point(46, 460);
            panel8.Name = "panel8";
            panel8.Size = new Size(116, 23);
            panel8.TabIndex = 72;
            // 
            // radioButtonSimTrabalhoPastoral
            // 
            radioButtonSimTrabalhoPastoral.AutoSize = true;
            radioButtonSimTrabalhoPastoral.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radioButtonSimTrabalhoPastoral.Location = new Point(59, 3);
            radioButtonSimTrabalhoPastoral.Name = "radioButtonSimTrabalhoPastoral";
            radioButtonSimTrabalhoPastoral.Size = new Size(46, 19);
            radioButtonSimTrabalhoPastoral.TabIndex = 1;
            radioButtonSimTrabalhoPastoral.Text = "Sim";
            radioButtonSimTrabalhoPastoral.UseVisualStyleBackColor = true;
            radioButtonSimTrabalhoPastoral.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // radioButtonNaoTrabalhoPastoral
            // 
            radioButtonNaoTrabalhoPastoral.AutoSize = true;
            radioButtonNaoTrabalhoPastoral.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radioButtonNaoTrabalhoPastoral.Location = new Point(5, 3);
            radioButtonNaoTrabalhoPastoral.Name = "radioButtonNaoTrabalhoPastoral";
            radioButtonNaoTrabalhoPastoral.Size = new Size(47, 19);
            radioButtonNaoTrabalhoPastoral.TabIndex = 0;
            radioButtonNaoTrabalhoPastoral.Text = "Não";
            radioButtonNaoTrabalhoPastoral.UseVisualStyleBackColor = true;
            radioButtonNaoTrabalhoPastoral.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // panel9
            // 
            panel9.BackColor = Color.Transparent;
            panel9.Controls.Add(radioButtonSimAtividade);
            panel9.Controls.Add(radioButtonNaoAtividade);
            panel9.Location = new Point(46, 512);
            panel9.Name = "panel9";
            panel9.Size = new Size(116, 23);
            panel9.TabIndex = 69;
            // 
            // radioButtonSimAtividade
            // 
            radioButtonSimAtividade.AutoSize = true;
            radioButtonSimAtividade.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radioButtonSimAtividade.Location = new Point(59, 3);
            radioButtonSimAtividade.Name = "radioButtonSimAtividade";
            radioButtonSimAtividade.Size = new Size(46, 19);
            radioButtonSimAtividade.TabIndex = 1;
            radioButtonSimAtividade.Text = "Sim";
            radioButtonSimAtividade.UseVisualStyleBackColor = true;
            radioButtonSimAtividade.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // radioButtonNaoAtividade
            // 
            radioButtonNaoAtividade.AutoSize = true;
            radioButtonNaoAtividade.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radioButtonNaoAtividade.Location = new Point(5, 3);
            radioButtonNaoAtividade.Name = "radioButtonNaoAtividade";
            radioButtonNaoAtividade.Size = new Size(47, 19);
            radioButtonNaoAtividade.TabIndex = 0;
            radioButtonNaoAtividade.Text = "Não";
            radioButtonNaoAtividade.UseVisualStyleBackColor = true;
            radioButtonNaoAtividade.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // panel10
            // 
            panel10.BackColor = Color.Transparent;
            panel10.Controls.Add(radioButtonSimTrabalhoVoluntario);
            panel10.Controls.Add(radioButtonNaoTrabalhoVoluntario);
            panel10.Location = new Point(46, 568);
            panel10.Name = "panel10";
            panel10.Size = new Size(116, 23);
            panel10.TabIndex = 69;
            // 
            // radioButtonSimTrabalhoVoluntario
            // 
            radioButtonSimTrabalhoVoluntario.AutoSize = true;
            radioButtonSimTrabalhoVoluntario.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radioButtonSimTrabalhoVoluntario.Location = new Point(59, 3);
            radioButtonSimTrabalhoVoluntario.Name = "radioButtonSimTrabalhoVoluntario";
            radioButtonSimTrabalhoVoluntario.Size = new Size(46, 19);
            radioButtonSimTrabalhoVoluntario.TabIndex = 1;
            radioButtonSimTrabalhoVoluntario.Text = "Sim";
            radioButtonSimTrabalhoVoluntario.UseVisualStyleBackColor = true;
            radioButtonSimTrabalhoVoluntario.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // radioButtonNaoTrabalhoVoluntario
            // 
            radioButtonNaoTrabalhoVoluntario.AutoSize = true;
            radioButtonNaoTrabalhoVoluntario.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radioButtonNaoTrabalhoVoluntario.Location = new Point(5, 3);
            radioButtonNaoTrabalhoVoluntario.Name = "radioButtonNaoTrabalhoVoluntario";
            radioButtonNaoTrabalhoVoluntario.Size = new Size(47, 19);
            radioButtonNaoTrabalhoVoluntario.TabIndex = 0;
            radioButtonNaoTrabalhoVoluntario.Text = "Não";
            radioButtonNaoTrabalhoVoluntario.UseVisualStyleBackColor = true;
            radioButtonNaoTrabalhoVoluntario.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(radioButtonSimAlfabetizado);
            panel3.Controls.Add(radioButtonNaoAlfabetizado);
            panel3.Location = new Point(559, 236);
            panel3.Name = "panel3";
            panel3.Size = new Size(116, 23);
            panel3.TabIndex = 70;
            // 
            // radioButtonSimAlfabetizado
            // 
            radioButtonSimAlfabetizado.AutoSize = true;
            radioButtonSimAlfabetizado.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radioButtonSimAlfabetizado.Location = new Point(59, 3);
            radioButtonSimAlfabetizado.Name = "radioButtonSimAlfabetizado";
            radioButtonSimAlfabetizado.Size = new Size(46, 19);
            radioButtonSimAlfabetizado.TabIndex = 1;
            radioButtonSimAlfabetizado.Text = "Sim";
            radioButtonSimAlfabetizado.UseVisualStyleBackColor = true;
            radioButtonSimAlfabetizado.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // radioButtonNaoAlfabetizado
            // 
            radioButtonNaoAlfabetizado.AutoSize = true;
            radioButtonNaoAlfabetizado.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radioButtonNaoAlfabetizado.Location = new Point(5, 3);
            radioButtonNaoAlfabetizado.Name = "radioButtonNaoAlfabetizado";
            radioButtonNaoAlfabetizado.Size = new Size(47, 19);
            radioButtonNaoAlfabetizado.TabIndex = 0;
            radioButtonNaoAlfabetizado.Text = "Não";
            radioButtonNaoAlfabetizado.UseVisualStyleBackColor = true;
            radioButtonNaoAlfabetizado.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(radioButtonSimEstuda);
            panel4.Controls.Add(radioButtonNaoEstuda);
            panel4.Location = new Point(401, 236);
            panel4.Name = "panel4";
            panel4.Size = new Size(116, 23);
            panel4.TabIndex = 70;
            // 
            // radioButtonSimEstuda
            // 
            radioButtonSimEstuda.AutoSize = true;
            radioButtonSimEstuda.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radioButtonSimEstuda.Location = new Point(59, 3);
            radioButtonSimEstuda.Name = "radioButtonSimEstuda";
            radioButtonSimEstuda.Size = new Size(46, 19);
            radioButtonSimEstuda.TabIndex = 1;
            radioButtonSimEstuda.Text = "Sim";
            radioButtonSimEstuda.UseVisualStyleBackColor = true;
            // 
            // radioButtonNaoEstuda
            // 
            radioButtonNaoEstuda.AutoSize = true;
            radioButtonNaoEstuda.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radioButtonNaoEstuda.Location = new Point(5, 3);
            radioButtonNaoEstuda.Name = "radioButtonNaoEstuda";
            radioButtonNaoEstuda.Size = new Size(47, 19);
            radioButtonNaoEstuda.TabIndex = 0;
            radioButtonNaoEstuda.Text = "Não";
            radioButtonNaoEstuda.UseVisualStyleBackColor = true;
            // 
            // textBoxSaudeExplique
            // 
            textBoxSaudeExplique.AllowDrop = true;
            textBoxSaudeExplique.Enabled = false;
            textBoxSaudeExplique.Location = new Point(237, 344);
            textBoxSaudeExplique.Margin = new Padding(4, 3, 4, 3);
            textBoxSaudeExplique.Name = "textBoxSaudeExplique";
            textBoxSaudeExplique.Size = new Size(292, 23);
            textBoxSaudeExplique.TabIndex = 16;
            // 
            // textBoxDeficienciaExplique
            // 
            textBoxDeficienciaExplique.AllowDrop = true;
            textBoxDeficienciaExplique.Enabled = false;
            textBoxDeficienciaExplique.Location = new Point(237, 287);
            textBoxDeficienciaExplique.Margin = new Padding(4, 3, 4, 3);
            textBoxDeficienciaExplique.Name = "textBoxDeficienciaExplique";
            textBoxDeficienciaExplique.Size = new Size(292, 23);
            textBoxDeficienciaExplique.TabIndex = 13;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.Controls.Add(radioButtonSimFazTratamento);
            panel5.Controls.Add(radioButtonNaoFazTratamento);
            panel5.Location = new Point(559, 343);
            panel5.Name = "panel5";
            panel5.Size = new Size(116, 23);
            panel5.TabIndex = 77;
            // 
            // radioButtonSimFazTratamento
            // 
            radioButtonSimFazTratamento.AutoSize = true;
            radioButtonSimFazTratamento.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radioButtonSimFazTratamento.Location = new Point(59, 3);
            radioButtonSimFazTratamento.Name = "radioButtonSimFazTratamento";
            radioButtonSimFazTratamento.Size = new Size(46, 19);
            radioButtonSimFazTratamento.TabIndex = 1;
            radioButtonSimFazTratamento.Text = "Sim";
            radioButtonSimFazTratamento.UseVisualStyleBackColor = true;
            radioButtonSimFazTratamento.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // radioButtonNaoFazTratamento
            // 
            radioButtonNaoFazTratamento.AutoSize = true;
            radioButtonNaoFazTratamento.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radioButtonNaoFazTratamento.Location = new Point(5, 3);
            radioButtonNaoFazTratamento.Name = "radioButtonNaoFazTratamento";
            radioButtonNaoFazTratamento.Size = new Size(47, 19);
            radioButtonNaoFazTratamento.TabIndex = 0;
            radioButtonNaoFazTratamento.Text = "Não";
            radioButtonNaoFazTratamento.UseVisualStyleBackColor = true;
            radioButtonNaoFazTratamento.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // labelTratamento
            // 
            labelTratamento.AutoSize = true;
            labelTratamento.BackColor = Color.Transparent;
            labelTratamento.Location = new Point(559, 326);
            labelTratamento.Margin = new Padding(4, 0, 4, 0);
            labelTratamento.Name = "labelTratamento";
            labelTratamento.Size = new Size(128, 15);
            labelTratamento.TabIndex = 76;
            labelTratamento.Text = "Faz algum tratamento?";
            // 
            // textBoxTratamentoOnde
            // 
            textBoxTratamentoOnde.AllowDrop = true;
            textBoxTratamentoOnde.Enabled = false;
            textBoxTratamentoOnde.Location = new Point(713, 343);
            textBoxTratamentoOnde.Margin = new Padding(4, 3, 4, 3);
            textBoxTratamentoOnde.Name = "textBoxTratamentoOnde";
            textBoxTratamentoOnde.Size = new Size(292, 23);
            textBoxTratamentoOnde.TabIndex = 17;
            // 
            // labelTratamentoOnde
            // 
            labelTratamentoOnde.AutoSize = true;
            labelTratamentoOnde.BackColor = Color.Transparent;
            labelTratamentoOnde.Location = new Point(713, 325);
            labelTratamentoOnde.Margin = new Padding(4, 0, 4, 0);
            labelTratamentoOnde.Name = "labelTratamentoOnde";
            labelTratamentoOnde.Size = new Size(41, 15);
            labelTratamentoOnde.TabIndex = 79;
            labelTratamentoOnde.Text = "Onde?";
            // 
            // labelMedicamentoControlado
            // 
            labelMedicamentoControlado.AutoSize = true;
            labelMedicamentoControlado.BackColor = Color.Transparent;
            labelMedicamentoControlado.Location = new Point(46, 384);
            labelMedicamentoControlado.Margin = new Padding(4, 0, 4, 0);
            labelMedicamentoControlado.Name = "labelMedicamentoControlado";
            labelMedicamentoControlado.Size = new Size(169, 15);
            labelMedicamentoControlado.TabIndex = 81;
            labelMedicamentoControlado.Text = "Usa medicamento controlado?";
            // 
            // labelUbsLocal
            // 
            labelUbsLocal.AutoSize = true;
            labelUbsLocal.BackColor = Color.Transparent;
            labelUbsLocal.Location = new Point(237, 384);
            labelUbsLocal.Margin = new Padding(4, 0, 4, 0);
            labelUbsLocal.Name = "labelUbsLocal";
            labelUbsLocal.Size = new Size(146, 15);
            labelUbsLocal.TabIndex = 83;
            labelUbsLocal.Text = "Usa recursos da UBS local?";
            // 
            // panel7
            // 
            panel7.BackColor = Color.Transparent;
            panel7.Controls.Add(radioButtonSimRecursoUbs);
            panel7.Controls.Add(radioButtonNaoRecursoUbs);
            panel7.Location = new Point(237, 401);
            panel7.Name = "panel7";
            panel7.Size = new Size(116, 23);
            panel7.TabIndex = 104;
            // 
            // radioButtonSimRecursoUbs
            // 
            radioButtonSimRecursoUbs.AutoSize = true;
            radioButtonSimRecursoUbs.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radioButtonSimRecursoUbs.Location = new Point(59, 3);
            radioButtonSimRecursoUbs.Name = "radioButtonSimRecursoUbs";
            radioButtonSimRecursoUbs.Size = new Size(46, 19);
            radioButtonSimRecursoUbs.TabIndex = 1;
            radioButtonSimRecursoUbs.Text = "Sim";
            radioButtonSimRecursoUbs.UseVisualStyleBackColor = true;
            // 
            // radioButtonNaoRecursoUbs
            // 
            radioButtonNaoRecursoUbs.AutoSize = true;
            radioButtonNaoRecursoUbs.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radioButtonNaoRecursoUbs.Location = new Point(5, 3);
            radioButtonNaoRecursoUbs.Name = "radioButtonNaoRecursoUbs";
            radioButtonNaoRecursoUbs.Size = new Size(47, 19);
            radioButtonNaoRecursoUbs.TabIndex = 0;
            radioButtonNaoRecursoUbs.Text = "Não";
            radioButtonNaoRecursoUbs.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Transparent;
            panel6.Controls.Add(radioButtonSimMedicamentoControlado);
            panel6.Controls.Add(radioButtonNaoMedicamentoControlado);
            panel6.Location = new Point(46, 402);
            panel6.Name = "panel6";
            panel6.Size = new Size(116, 23);
            panel6.TabIndex = 103;
            // 
            // radioButtonSimMedicamentoControlado
            // 
            radioButtonSimMedicamentoControlado.AutoSize = true;
            radioButtonSimMedicamentoControlado.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radioButtonSimMedicamentoControlado.Location = new Point(59, 3);
            radioButtonSimMedicamentoControlado.Name = "radioButtonSimMedicamentoControlado";
            radioButtonSimMedicamentoControlado.Size = new Size(46, 19);
            radioButtonSimMedicamentoControlado.TabIndex = 1;
            radioButtonSimMedicamentoControlado.Text = "Sim";
            radioButtonSimMedicamentoControlado.UseVisualStyleBackColor = true;
            // 
            // radioButtonNaoMedicamentoControlado
            // 
            radioButtonNaoMedicamentoControlado.AutoSize = true;
            radioButtonNaoMedicamentoControlado.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radioButtonNaoMedicamentoControlado.Location = new Point(5, 3);
            radioButtonNaoMedicamentoControlado.Name = "radioButtonNaoMedicamentoControlado";
            radioButtonNaoMedicamentoControlado.Size = new Size(47, 19);
            radioButtonNaoMedicamentoControlado.TabIndex = 0;
            radioButtonNaoMedicamentoControlado.Text = "Não";
            radioButtonNaoMedicamentoControlado.UseVisualStyleBackColor = true;
            // 
            // FormCadastroDependente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background_gradiente;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1194, 681);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(labelUbsLocal);
            Controls.Add(labelMedicamentoControlado);
            Controls.Add(textBoxTratamentoOnde);
            Controls.Add(labelTratamentoOnde);
            Controls.Add(panel5);
            Controls.Add(labelTratamento);
            Controls.Add(textBoxDeficienciaExplique);
            Controls.Add(textBoxSaudeExplique);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel10);
            Controls.Add(panel9);
            Controls.Add(panel8);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(ButtonCancelar);
            Controls.Add(ButtonSalvar);
            Controls.Add(textBoxTrabalhoVoluntarioOnde);
            Controls.Add(labelTrabalhoVoluntarioOnde);
            Controls.Add(textBoxTrabalhoVoluntario);
            Controls.Add(labelTrabalhoVoluntarioQual);
            Controls.Add(labelTrabalhoVoluntario);
            Controls.Add(textBoxAtividade);
            Controls.Add(labelAtividadeQual);
            Controls.Add(labelAtividade);
            Controls.Add(textBoxTrabalhoPastoralSocial);
            Controls.Add(labelTrabalhoPastoralSocialQual);
            Controls.Add(labelTrabalhoPastoralSocial);
            Controls.Add(labelProblemaSaudeQual);
            Controls.Add(comboBoxSaude);
            Controls.Add(labelProblemaSaude);
            Controls.Add(labelRenda);
            Controls.Add(comboBoxRenda);
            Controls.Add(comboBoxBeneficio);
            Controls.Add(labelBeneficio);
            Controls.Add(labelDeficienciaQual);
            Controls.Add(comboBoxDeficiencia);
            Controls.Add(labelDeficiencia);
            Controls.Add(comboBoxAposentadoMotivo);
            Controls.Add(labelAposentado);
            Controls.Add(comboBoxCursoFormacao);
            Controls.Add(labelCursoTecnicoFormacaoProfissional);
            Controls.Add(comboBoxNivelSerie);
            Controls.Add(labelEstudaAtualmente);
            Controls.Add(comboBoxSituacaoOcupacional);
            Controls.Add(labelNivelSerieAtualConcluido);
            Controls.Add(labelAlfabetizado);
            Controls.Add(labelSituacaoOcupacional);
            Controls.Add(labelProgramaPastoralLocal);
            Controls.Add(textBoxProgramaPastoralLocal);
            Controls.Add(labelProgramaPastoralQual);
            Controls.Add(textBoxProgramaPastoral);
            Controls.Add(labelProgramaPastoral);
            Controls.Add(labelCeinfBairro);
            Controls.Add(textBoxCeinfBairro);
            Controls.Add(labelCeinf);
            Controls.Add(textBoxCeinf);
            Controls.Add(labelEstaNoCeinf);
            Controls.Add(comboBoxParentesco);
            Controls.Add(labelParentesco);
            Controls.Add(textDataNascimento);
            Controls.Add(labelDataNascimento);
            Controls.Add(textNome);
            Controls.Add(labelNome);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastroDependente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ASFA - Cadastro de Dependente";
            Load += FormCadastroDependente_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker textDataNascimento;
        private TextBox textNome;
        private TextBox textBoxTratamentoOnde;
        private Button ButtonCancelar;
        private Button ButtonSalvar;
        private Panel panel1;
        private RadioButton radioButtonNaoEstaNoCeinf;
        private RadioButton radioButtonSimEstaNoCeinf;
        private Panel panel2;
        private RadioButton radioButtonNaoProgramaPastoral;
        private RadioButton radioButtonSimProgramaPastoral;
        private Panel panel3;
        private RadioButton radioButtonNaoAlfabetizado;
        private RadioButton radioButtonSimAlfabetizado;
        private Panel panel4;
        private RadioButton radioButtonNaoEstuda;
        private RadioButton radioButtonSimEstuda;
        private Panel panel5;
        private RadioButton radioButtonSimFazTratamento;
        private RadioButton radioButtonNaoFazTratamento;
        private Panel panel6;
        private RadioButton radioButtonSimMedicamentoControlado;
        private RadioButton radioButtonNaoMedicamentoControlado;
        private Panel panel7;
        private RadioButton radioButtonSimRecursoUbs;
        private RadioButton radioButtonNaoRecursoUbs;
        private Panel panel8;
        private RadioButton radioButtonNaoTrabalhoPastoral;
        private RadioButton radioButtonSimTrabalhoPastoral;
        private Panel panel9;
        private RadioButton radioButtonNaoAtividade;
        private RadioButton radioButtonSimAtividade;
        private Panel panel10;
        private RadioButton radioButtonNaoTrabalhoVoluntario;
        private RadioButton radioButtonSimTrabalhoVoluntario;
        private ComboBox comboBoxParentesco;
        private TextBox textBoxCeinf;
        private TextBox textBoxCeinfBairro;
        private TextBox textBoxProgramaPastoralLocal;
        private TextBox textBoxProgramaPastoral;
        private ComboBox comboBoxSituacaoOcupacional;
        private ComboBox comboBoxNivelSerie;
        private ComboBox comboBoxCursoFormacao;
        private ComboBox comboBoxRenda;
        private ComboBox comboBoxAposentadoMotivo;
        private ComboBox comboBoxDeficiencia;
        private ComboBox comboBoxBeneficio;
        private ComboBox comboBoxSaude;
        private TextBox textBoxTrabalhoPastoralSocial;
        private TextBox textBoxAtividade;
        private TextBox textBoxTrabalhoVoluntario;
        private TextBox textBoxTrabalhoVoluntarioOnde;
        private TextBox textBoxSaudeExplique;
        private TextBox textBoxDeficienciaExplique;
        private Label labelDataNascimento;
        private Label labelNome;
        private Label labelParentesco;
        private Label labelEstaNoCeinf;
        private Label labelCeinf;
        private Label labelCeinfBairro;
        private Label labelProgramaPastoralLocal;
        private Label labelProgramaPastoralQual;
        private Label labelProgramaPastoral;
        private Label labelNivelSerieAtualConcluido;
        private Label labelSituacaoOcupacional;
        private Label labelEstudaAtualmente;
        private Label labelCursoTecnicoFormacaoProfissional;
        private Label labelAposentado;
        private Label labelDeficiencia;
        private Label labelDeficienciaQual;
        private Label labelRenda;
        private Label labelBeneficio;
        private Label labelProblemaSaudeQual;
        private Label labelProblemaSaude;
        private Label labelTrabalhoPastoralSocialQual;
        private Label labelTrabalhoPastoralSocial;
        private Label labelAtividadeQual;
        private Label labelAtividade;
        private Label labelTrabalhoVoluntarioQual;
        private Label labelTrabalhoVoluntario;
        private Label labelTrabalhoVoluntarioOnde;
        private Label labelTratamento;
        private Label labelTratamentoOnde;
        private Label labelMedicamentoControlado;
        private Label labelUbsLocal;
        private Label labelAlfabetizado;
    }
}