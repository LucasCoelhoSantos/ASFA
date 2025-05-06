using ASFA.Helpers;
using ASFA.Models;
using ASFA.Services.Interfaces;

namespace ASFA;

public partial class FormCadastroDependente : Form
{
    private readonly IDependenteService _dependenteService;

    public Dependente DadosDependente { get; private set; }
    private bool _ehEdicao;
    private int _dependenteIdParaEdicao;

    public FormCadastroDependente(IDependenteService dependenteService, bool ehEdicao = false, int dependenteIdParaEdicao = 0)
    {
        _dependenteService = dependenteService;
        _ehEdicao = ehEdicao;
        _dependenteIdParaEdicao = dependenteIdParaEdicao;

        InitializeComponent();
    }

    private async void FormCadastroDependente_Load(object sender, EventArgs e)
    {
        try
        {
            if (_ehEdicao && _dependenteIdParaEdicao == 0)
            {
                MessageBoxHelper.ShowWarning("Dependente não salvo! Para habilitar edição salve primeiro!");
                this.Close();
            }

            if (_ehEdicao)
            {
                var dadosDependenteEditado = await _dependenteService.ObterPorIdAsync(_dependenteIdParaEdicao);

                if (dadosDependenteEditado != null)
                {
                    PreencherDados(dadosDependenteEditado);
                }
            }
        }
        catch (Exception ex)
        {
            MessageBoxHelper.ShowError(ex.Message);
        }
    }

    private void PreencherDados(Dependente dadosDependente)
    {
        textNome.Text = dadosDependente.Nome;
        comboBoxParentesco.Text = dadosDependente.Parentesco;
        textDataNascimento.Text = dadosDependente.DataNascimento.ToString();
        comboBoxRenda.Text = dadosDependente.ComposicaoFamiliar.Renda;
        comboBoxAposentadoMotivo.Text = dadosDependente.ComposicaoFamiliar.Aposentado;

        radioButtonNaoEstaNoCeinf.Checked = dadosDependente.Ceinf == null;
        radioButtonSimEstaNoCeinf.Checked = dadosDependente.Ceinf != null;
        textBoxCeinf.Text = dadosDependente.Ceinf;
        textBoxCeinfBairro.Text = dadosDependente.CeinfBairro;

        radioButtonNaoProgramaPastoral.Checked = dadosDependente.ProgramaSaudePastoralCrianca == null;
        radioButtonSimProgramaPastoral.Checked = dadosDependente.ProgramaSaudePastoralCrianca != null;
        textBoxProgramaPastoral.Text = dadosDependente.ProgramaSaudePastoralCrianca;
        textBoxProgramaPastoralLocal.Text = dadosDependente.ProgramaSaudePastoralCriancaLocal;

        comboBoxSituacaoOcupacional.Text = dadosDependente.ComposicaoFamiliar.SituacaoOcupacional;

        radioButtonNaoAlfabetizado.Checked = !dadosDependente.ComposicaoFamiliar.Alfabetizado;
        radioButtonSimAlfabetizado.Checked = dadosDependente.ComposicaoFamiliar.Alfabetizado;

        radioButtonNaoEstuda.Checked = !dadosDependente.ComposicaoFamiliar.EstudaAtualmente;
        radioButtonSimEstuda.Checked = dadosDependente.ComposicaoFamiliar.EstudaAtualmente;

        comboBoxNivelSerie.Text = dadosDependente.ComposicaoFamiliar.NivelSerieAtualConcluido;
        comboBoxCursoFormacao.Text = dadosDependente.ComposicaoFamiliar.CursosTecnicoFormacaoProfissional;

        comboBoxDeficiencia.Text = dadosDependente.ComposicaoFamiliar.Deficiencia;

        if (dadosDependente.ComposicaoFamiliar.Deficiencia == "Outro")
            textBoxDeficienciaExplique.Text = dadosDependente.ComposicaoFamiliar.Deficiencia;

        comboBoxBeneficio.Text = dadosDependente.ComposicaoFamiliar.Beneficio;

        comboBoxSaude.Text = dadosDependente.ComposicaoFamiliar.ProblemaDeSaude;

        if (dadosDependente .ComposicaoFamiliar.ProblemaDeSaude == "Outro")
            textBoxSaudeExplique.Text = dadosDependente.ComposicaoFamiliar.ProblemaDeSaude;

        radioButtonNaoFazTratamento.Checked = !dadosDependente.ComposicaoFamiliar.FazAlgumTratamento;
        radioButtonSimFazTratamento.Checked = dadosDependente.ComposicaoFamiliar.FazAlgumTratamento;
        textBoxTratamentoOnde.Text = dadosDependente.ComposicaoFamiliar.FazAlgumTratamentoOnde;

        radioButtonNaoMedicamentoControlado.Checked = !dadosDependente.ComposicaoFamiliar.UsaMedicamentoControlado;
        radioButtonSimMedicamentoControlado.Checked = dadosDependente.ComposicaoFamiliar.UsaMedicamentoControlado;

        radioButtonNaoRecursoUbs.Checked = !dadosDependente.ComposicaoFamiliar.UsaRecursosUbsLocal;
        radioButtonSimRecursoUbs.Checked = dadosDependente.ComposicaoFamiliar.UsaRecursosUbsLocal;

        radioButtonNaoTrabalhoPastoral.Checked = dadosDependente.ComposicaoFamiliar.TrabalhoPastoralOuSocial == null;
        radioButtonSimTrabalhoPastoral.Checked = dadosDependente.ComposicaoFamiliar.TrabalhoPastoralOuSocial != null;
        textBoxTrabalhoPastoralSocial.Text = dadosDependente.ComposicaoFamiliar.TrabalhoPastoralOuSocial;

        radioButtonNaoAtividade.Checked = dadosDependente.ComposicaoFamiliar.AtividadeNaComunidadeSagradaFamilia == null;
        radioButtonSimAtividade.Checked = dadosDependente.ComposicaoFamiliar.AtividadeNaComunidadeSagradaFamilia != null;
        textBoxAtividade.Text = dadosDependente.ComposicaoFamiliar.AtividadeNaComunidadeSagradaFamilia;

        radioButtonNaoTrabalhoVoluntario.Checked = dadosDependente.ComposicaoFamiliar.TrabalhoVoluntario == null;
        radioButtonSimTrabalhoVoluntario.Checked = dadosDependente.ComposicaoFamiliar.TrabalhoVoluntario != null;
        textBoxTrabalhoVoluntario.Text = dadosDependente.ComposicaoFamiliar.TrabalhoVoluntario;
        textBoxTrabalhoVoluntarioOnde.Text = dadosDependente.ComposicaoFamiliar.TrabalhoVoluntarioOnde;
    }

    private void RadioButton_CheckedChanged(object sender, EventArgs e)
    {
        ToggleControlState(radioButtonNaoEstaNoCeinf, textBoxCeinf, textBoxCeinfBairro, false);
        ToggleControlState(radioButtonSimEstaNoCeinf, textBoxCeinf, textBoxCeinfBairro, true);

        ToggleControlState(radioButtonNaoProgramaPastoral, textBoxProgramaPastoral, textBoxProgramaPastoralLocal, false);
        ToggleControlState(radioButtonSimProgramaPastoral, textBoxProgramaPastoral, textBoxProgramaPastoralLocal, true);

        ToggleControlState(radioButtonNaoFazTratamento, textBoxTratamentoOnde, false);
        ToggleControlState(radioButtonSimFazTratamento, textBoxTratamentoOnde, true);

        ToggleControlState(radioButtonNaoTrabalhoPastoral, textBoxTrabalhoPastoralSocial, false);
        ToggleControlState(radioButtonSimTrabalhoPastoral, textBoxTrabalhoPastoralSocial, true);

        ToggleControlState(radioButtonNaoAtividade, textBoxAtividade, false);
        ToggleControlState(radioButtonSimAtividade, textBoxAtividade, true);

        ToggleControlState(radioButtonNaoTrabalhoVoluntario, textBoxTrabalhoVoluntario, textBoxTrabalhoVoluntarioOnde, false);
        ToggleControlState(radioButtonSimTrabalhoVoluntario, textBoxTrabalhoVoluntario, textBoxTrabalhoVoluntarioOnde, true);
    }

    private static void ToggleControlState(RadioButton radioButton, Control control1, Control control2, bool enable)
    {
        if (radioButton.Checked)
        {
            control1.Enabled = enable;
            control2.Enabled = enable;

            if (!enable)
            {
                ClearControlValue(control1);
                ClearControlValue(control2);
            }
        }
    }

    private static void ToggleControlState(RadioButton radioButton, Control control, bool enable)
    {
        if (radioButton.Checked)
        {
            control.Enabled = enable;

            if (!enable)
                ClearControlValue(control);
        }
    }

    private static void ClearControlValue(Control control)
    {
        if (control is TextBox textBox)
            textBox.Clear();
        else if (control is ComboBox comboBox)
            comboBox.SelectedIndex = -1;
    }

    private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        textBoxDeficienciaExplique.Enabled = comboBoxDeficiencia.Text != "Não";
        if (comboBoxDeficiencia.Text == "Não")
        {
            textBoxDeficienciaExplique.Text = string.Empty;
            textBoxDeficienciaExplique.Enabled = false;
        }

        textBoxSaudeExplique.Enabled = comboBoxSaude.Text != "Não";
        if (comboBoxSaude.Text == "Não")
        {
            textBoxSaudeExplique.Text = string.Empty;
            textBoxSaudeExplique.Enabled = false;
        }
    }

    private void ButtonCancelar_Click(object sender, EventArgs e)
    {
        if (MessageBoxHelper.ShowConfirmation("Deseja cancelar o cadastro?") == DialogResult.OK)
            this.Close();
    }

    private void ButtonSalvar_Click(object sender, EventArgs e)
    {
        var erros = ObterErrosValidacao();

        if (erros.Count != 0)
        {
            MessageBoxHelper.ShowWarning(string.Join("\n", erros));
            return;
        }

        try
        {
            DadosDependente = new Dependente
            {
                Id = _dependenteIdParaEdicao,
                Nome = textNome.Text,
                Parentesco = comboBoxParentesco.Text,
                DataNascimento = DateTime.Parse(textDataNascimento.Text),
                Ceinf = textBoxCeinf.Text,
                CeinfBairro = textBoxCeinfBairro.Text,
                ProgramaSaudePastoralCrianca = textBoxProgramaPastoral.Text,
                ProgramaSaudePastoralCriancaLocal = textBoxProgramaPastoralLocal.Text,
                Ativo = true,

                ComposicaoFamiliar = ComposicaoFamiliar.Criar(
                    radioButtonSimAlfabetizado.Checked,
                    radioButtonSimEstuda.Checked,
                    comboBoxNivelSerie.Text,
                    comboBoxCursoFormacao.Text,
                    comboBoxSituacaoOcupacional.Text,
                    comboBoxRenda.Text,
                    comboBoxAposentadoMotivo.Text,
                    comboBoxBeneficio.Text,
                    (comboBoxDeficiencia.Text == "Outra" ? comboBoxDeficiencia.Text : textBoxDeficienciaExplique.Text),
                    (comboBoxSaude.Text == "Outro" ? comboBoxSaude.Text : textBoxSaudeExplique.Text),
                    radioButtonSimFazTratamento.Checked,
                    textBoxTratamentoOnde.Text,
                    radioButtonSimMedicamentoControlado.Checked,
                    radioButtonSimRecursoUbs.Checked,
                    textBoxTrabalhoPastoralSocial.Text,
                    textBoxAtividade.Text,
                    textBoxTrabalhoVoluntario.Text,
                    textBoxTrabalhoVoluntarioOnde.Text
                )
            };

            MessageBoxHelper.ShowSuccess($"Dependente {textNome.Text} adicionado com sucesso");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        catch (Exception ex)
        {
            MessageBoxHelper.ShowError($"Erro ao salvar cadastro: {ex.Message}");
        }
    }

    private List<string> ObterErrosValidacao()
    {
        List<string> erros = [];

        ValidacaoHelper.AdicionarErroCampoNulo(textNome.Text, "Nome", erros);
        ValidacaoHelper.AdicionarErroComboBoxNaoSelecionado(comboBoxParentesco, "Parentesco", erros);
        
        if (!ValidacaoHelper.ValidarDataNascimento(DateTime.Parse(textDataNascimento.Text)))
            erros.Add("Campo Data de Nascimento é inválido.");

        ValidacaoHelper.AdicionarErroComboBoxNaoSelecionado(comboBoxRenda, "Renda", erros);
        ValidacaoHelper.AdicionarErroComboBoxNaoSelecionado(comboBoxAposentadoMotivo, "Aposentado", erros);
        ValidacaoHelper.AdicionarErroRadioButtonDesmarcado(radioButtonNaoEstaNoCeinf, radioButtonSimEstaNoCeinf, "Está no CEINF", erros);
        ValidacaoHelper.AdicionarErroRadioButtonDesmarcado(radioButtonNaoProgramaPastoral, radioButtonSimProgramaPastoral, "Participa de algum programa", erros);
        
        ValidacaoHelper.AdicionarErroComboBoxNaoSelecionado(comboBoxSituacaoOcupacional, "Situação Ocupacional", erros);
        ValidacaoHelper.AdicionarErroRadioButtonDesmarcado(radioButtonNaoEstuda, radioButtonSimEstuda, "Estuda atualmente", erros);
        ValidacaoHelper.AdicionarErroRadioButtonDesmarcado(radioButtonNaoAlfabetizado, radioButtonSimAlfabetizado, "Alfabetizado", erros);
        ValidacaoHelper.AdicionarErroComboBoxNaoSelecionado(comboBoxNivelSerie, "", erros);
        ValidacaoHelper.AdicionarErroComboBoxNaoSelecionado(comboBoxCursoFormacao, "", erros);
        ValidacaoHelper.AdicionarErroComboBoxNaoSelecionado(comboBoxDeficiencia, "Possui alguma deficiência", erros);
        ValidacaoHelper.AdicionarErroComboBoxNaoSelecionado(comboBoxBeneficio, "Recebe algum benefício", erros);
        ValidacaoHelper.AdicionarErroComboBoxNaoSelecionado(comboBoxSaude, "Apresenta problema de saúde", erros);

        ValidacaoHelper.AdicionarErroRadioButtonDesmarcado(radioButtonNaoFazTratamento, radioButtonSimFazTratamento, "Faz algum tratamento", erros);
        if (radioButtonSimFazTratamento.Checked)
            ValidacaoHelper.AdicionarErroCampoNulo(textBoxTratamentoOnde.Text, "Faz tratamento onde", erros);

        ValidacaoHelper.AdicionarErroRadioButtonDesmarcado(radioButtonNaoMedicamentoControlado, radioButtonSimMedicamentoControlado, "Usa medicamento controlado", erros);
        ValidacaoHelper.AdicionarErroRadioButtonDesmarcado(radioButtonNaoRecursoUbs, radioButtonSimRecursoUbs, "Usa recursos da UBS local", erros);

        ValidacaoHelper.AdicionarErroRadioButtonDesmarcado(radioButtonNaoTrabalhoPastoral, radioButtonSimTrabalhoPastoral, "Trabalho pastoral", erros);
        if (radioButtonSimTrabalhoPastoral.Checked)
            ValidacaoHelper.AdicionarErroCampoNulo(textBoxTrabalhoPastoralSocial.Text, "Qual trabalho pastoral", erros);

        ValidacaoHelper.AdicionarErroRadioButtonDesmarcado(radioButtonNaoAtividade, radioButtonSimAtividade, "Atividade", erros);
        if (radioButtonSimAtividade.Checked)
            ValidacaoHelper.AdicionarErroCampoNulo(textBoxAtividade.Text, "Qual atividade", erros);

        ValidacaoHelper.AdicionarErroRadioButtonDesmarcado(radioButtonNaoTrabalhoVoluntario, radioButtonSimTrabalhoVoluntario, "Trabalho voluntário", erros);
        if (radioButtonSimTrabalhoVoluntario.Checked)
        {
            ValidacaoHelper.AdicionarErroCampoNulo(textBoxTrabalhoVoluntario.Text, "Qual trabalho voluntário desenvolveu", erros);
            ValidacaoHelper.AdicionarErroCampoNulo(textBoxTrabalhoVoluntarioOnde.Text, "Onde desenvolveu trabalho voluntário", erros);
        }

        return erros;
    }
}
