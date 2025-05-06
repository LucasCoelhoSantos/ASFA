using ASFA.Forms;
using ASFA.Helpers;
using ASFA.Models;
using ASFA.Models.DTOs;
using ASFA.Services.Interfaces;
using AutoMapper;
using System.Text.RegularExpressions;

namespace ASFA;

public partial class FormCadastroPessoaIdosa : Form
{
    private readonly IPessoaIdosaService _pessoaIdosaService;
    private readonly IDependenteService _dependenteService;
    private readonly IMapper _mapper;
    private readonly GoogleDriveHelper _salvarGoogleDrive;
    private readonly ManipularArquivoHelper _manipularArquivo;
    private readonly int _pessoaIdosaIdSelecionado;
    
    private PessoaIdosa _dadosPessoaIdosa;
    private int dependenteIdSelecionado;
    
    private string urlFotoPerfil;

    public FormCadastroPessoaIdosa(IPessoaIdosaService pessoaIdosaService, IDependenteService dependenteService, IMapper mapper, int pessoaIdosaIdSelecionado = 0)
    {
        _pessoaIdosaService = pessoaIdosaService;
        _dependenteService = dependenteService;
        _mapper = mapper;
        _salvarGoogleDrive = new GoogleDriveHelper();
        _manipularArquivo = new ManipularArquivoHelper();
        _pessoaIdosaIdSelecionado = pessoaIdosaIdSelecionado;

        InitializeComponent();
    }

    private async void FormCadUsuario_Load(object sender, EventArgs e)
    {
        if (_pessoaIdosaIdSelecionado != 0)
        {
            try
            {
                _dadosPessoaIdosa = await _pessoaIdosaService.ObterPorIdAsync(_pessoaIdosaIdSelecionado);
                PreencherCampos(_dadosPessoaIdosa);
            }
            catch (Exception ex)
            {
                MessageBoxHelper.ShowError(ex.Message);
            }
        }
        else
        {
            _dadosPessoaIdosa = PessoaIdosa.Criar("", DateTime.Now, "", "", "", "", "", "", "", "", false, "", "", "", null, true);
        }
    }

    private void PreencherCampos(PessoaIdosa dadosPessoaIdosa)
    {
        labelId.Text = $"Código Pessoa Idosa: {dadosPessoaIdosa.Id}";
        var temFotoPerfil = dadosPessoaIdosa.Anexos.FirstOrDefault(a => a.TipoAnexo == TipoAnexo.FotoPerfil);
        if (temFotoPerfil != null)
        {
            imagemDePerfil.ImageLocation = temFotoPerfil.Url;
            urlFotoPerfil = temFotoPerfil.Url;
        }
        textNome.Text = dadosPessoaIdosa.Nome;
        textDataNascimento.Text = dadosPessoaIdosa.DataNascimento.ToString();
        comboBoxEstadoCivil.Text = dadosPessoaIdosa.EstadoCivil;
        textNaturalidade.Text = dadosPessoaIdosa.Naturalidade;
        textBoxProntuarioDeSaude.Text = dadosPessoaIdosa.ProntuarioSaude;
        textCPF.Text = dadosPessoaIdosa.Cpf;
        textRG.Text = dadosPessoaIdosa.Rg;
        textOrgaoEmissor.Text = dadosPessoaIdosa.OrgaoEmissor;
        textReligiao.Text = dadosPessoaIdosa.Religiao;
        radioButtonNaoAlfabetizado.Checked = !dadosPessoaIdosa.ComposicaoFamiliar.Alfabetizado;
        radioButtonSimAlfabetizado.Checked = dadosPessoaIdosa.ComposicaoFamiliar.Alfabetizado;
        comboBoxBeneficio.Text = dadosPessoaIdosa.ComposicaoFamiliar.Beneficio;
        comboBoxRenda.Text = dadosPessoaIdosa.ComposicaoFamiliar.Renda;
        comboBoxSituacaoOcupacional.Text = dadosPessoaIdosa.ComposicaoFamiliar.SituacaoOcupacional;
        comboBoxAposentado.Text = dadosPessoaIdosa.ComposicaoFamiliar.Aposentado;
        radioButtonNaoMantem.Checked = !dadosPessoaIdosa.AposentadoConsegueSeManterComSuaRenda;
        radioButtonSimMantem.Checked = dadosPessoaIdosa.AposentadoConsegueSeManterComSuaRenda;
        textBoxComoComplementa.Text = dadosPessoaIdosa.ComoComplementa;
        textCEP.Text = dadosPessoaIdosa.Endereco.Cep;
        textLogradouro.Text = dadosPessoaIdosa.Endereco.Logradouro;
        comboBoxEstado.Text = dadosPessoaIdosa.Endereco.Estado;
        comboBoxCidade.Text = dadosPessoaIdosa.Endereco.Cidade;
        textBairro.Text = dadosPessoaIdosa.Endereco.Bairro;
        textNumero.Text = dadosPessoaIdosa.Endereco.Numero;
        comboBoxMoradia.Text = dadosPessoaIdosa.Endereco.Moradia;
        textTelefone.Text = dadosPessoaIdosa.Telefone;

        comboBoxDeficiencia.Text = dadosPessoaIdosa.ComposicaoFamiliar.Deficiencia;
        if (dadosPessoaIdosa.ComposicaoFamiliar.Deficiencia != "Não")
        {
            comboBoxDeficiencia.Text = "Outra";
            textBoxDeficienciaOutra.Text = dadosPessoaIdosa.ComposicaoFamiliar.Deficiencia;
        }

        radioButtonNaoEstuda.Checked = !dadosPessoaIdosa.ComposicaoFamiliar.EstudaAtualmente;
        radioButtonSimEstuda.Checked = dadosPessoaIdosa.ComposicaoFamiliar.EstudaAtualmente;

        comboBoxNivelSerie.Text = dadosPessoaIdosa.ComposicaoFamiliar.NivelSerieAtualConcluido;
        comboBoxCursoFormacao.Text = dadosPessoaIdosa.ComposicaoFamiliar.CursosTecnicoFormacaoProfissional;

        comboBoxProblemaSaude.Text = dadosPessoaIdosa.ComposicaoFamiliar.ProblemaDeSaude;
        if (dadosPessoaIdosa.ComposicaoFamiliar.ProblemaDeSaude != "Não")
        {
            comboBoxProblemaSaude.Text = "Outro";
            textBoxProblemaSaudeOutro.Text = dadosPessoaIdosa.ComposicaoFamiliar.ProblemaDeSaude;
        }

        radioButtonNaoTratamento.Checked = !dadosPessoaIdosa.ComposicaoFamiliar.FazAlgumTratamento;
        radioButtonSimTratamento.Checked = dadosPessoaIdosa.ComposicaoFamiliar.FazAlgumTratamento;

        if (dadosPessoaIdosa.ComposicaoFamiliar.FazAlgumTratamento)
            textBoxTratamentoOnde.Text = dadosPessoaIdosa.ComposicaoFamiliar.FazAlgumTratamentoOnde;

        radioButtonNaoMedicamentoControlado.Checked = !dadosPessoaIdosa.ComposicaoFamiliar.UsaMedicamentoControlado;
        radioButtonSimMedicamentoControlado.Checked = dadosPessoaIdosa.ComposicaoFamiliar.UsaMedicamentoControlado;

        radioButtonNaoRecursoUbs.Checked = !dadosPessoaIdosa.ComposicaoFamiliar.UsaRecursosUbsLocal;
        radioButtonSimRecursoUbs.Checked = dadosPessoaIdosa.ComposicaoFamiliar.UsaRecursosUbsLocal;

        radioButtonNaoPastoralSocial.Checked = true;
        if (!string.IsNullOrWhiteSpace(dadosPessoaIdosa.ComposicaoFamiliar.TrabalhoPastoralOuSocial))
        {
            radioButtonSimPastoralSocial.Checked = true;
            textBoxTrabalhoPastoralSocial.Text = dadosPessoaIdosa.ComposicaoFamiliar.TrabalhoPastoralOuSocial;
        }

        radioButtonNaoAtividade.Checked = true;
        if (!string.IsNullOrWhiteSpace(dadosPessoaIdosa.ComposicaoFamiliar.AtividadeNaComunidadeSagradaFamilia))
        {
            radioButtonSimAtividade.Checked = true;
            textBoxQualAtividade.Text = dadosPessoaIdosa.ComposicaoFamiliar.AtividadeNaComunidadeSagradaFamilia;
        }

        radioButtonNaoTrabalhoVoluntario.Checked = true;
        if (!string.IsNullOrWhiteSpace(dadosPessoaIdosa.ComposicaoFamiliar.TrabalhoVoluntario))
        {
            radioButtonSimTrabalhoVoluntario.Checked = true;
            textBoxTrabalhoVoluntarioQual.Text = dadosPessoaIdosa.ComposicaoFamiliar.TrabalhoVoluntario;
            textBoxTrabalhoVoluntarioOnde.Text = dadosPessoaIdosa.ComposicaoFamiliar.TrabalhoVoluntarioOnde;
        }

        dataGridDependentes.DataSource = _mapper.Map<List<DependenteDataGridViewDTO>>(dadosPessoaIdosa.Dependentes);
        textBoxObservacao.Text = dadosPessoaIdosa.Observacao;
        textBoxHistoricoFamiliarSocial.Text = dadosPessoaIdosa.HistoricoFamiliarSocial;
        checkBoxSituacao.Checked = dadosPessoaIdosa.Ativo;

        labelNenhumDependenteCadastrado.Visible = true;

        if (dataGridDependentes.RowCount > 0)
        {
            labelNenhumDependenteCadastrado.Visible = false;
            DataGridListHelper.FormataLinhaAtivoInativo(dataGridDependentes);
        }

        labelRendaPerCapita.Text = CalculaRendaPerCapitaFamilia(dadosPessoaIdosa.ComposicaoFamiliar.Renda, dadosPessoaIdosa.Dependentes.Select(d => d.ComposicaoFamiliar.Renda));
    }

    private string CalculaRendaPerCapitaFamilia(string? rendaPessoaIdosa, IEnumerable<string>? rendaDependentes)
    {
        Match matchPessoaIdosa = Regex.Match(rendaPessoaIdosa, @"\d+");

        if (matchPessoaIdosa.Success)
        {
            int numeroRenda = int.Parse(matchPessoaIdosa.Value);

            foreach (var rendaDependente in rendaDependentes)
            {
                Match matchDependente = Regex.Match(rendaDependente, @"\d+");

                if (matchDependente.Success)
                    numeroRenda += int.Parse(matchDependente.Value);
            }

            return $"Acima de {numeroRenda} salário(s) mínimo(s).";
        }
        else
        {
            return "Sem renda";
        }
    }

    private void TextBoxCpf_TextChanged(object sender, EventArgs e)
    {
        if (textCPF.Text.Trim().Length == 11 && !ValidacaoHelper.ValidarCPF(textCPF.Text))
        {
            textCPF.Text = string.Empty;
            MessageBoxHelper.ShowError("CPF inválido");
        }
    }

    private async void TextBoxCep_TextChanged(object sender, EventArgs e)
    {
        if (textCEP.Text.Trim().Length == 8)
            await PreencherCamposEndereco(textCEP.Text.Trim());
    }

    private async Task PreencherCamposEndereco(string cep)
    {
        try
        {
            labelAguardandoBusca.Visible = true;

            EnderecoViaCep endereco = await ViaCepHelper.BuscarCepAsync(cep);
            textLogradouro.Text = endereco.Logradouro;
            comboBoxEstado.Text = endereco.Estado;
            comboBoxCidade.Text = endereco.Localidade;
            textBairro.Text = endereco.Bairro;
        }
        catch (Exception ex)
        {
            MessageBoxHelper.ShowError($"Erro ao buscar CEP: {ex.Message}");
        }
        finally
        {
            labelAguardandoBusca.Visible = false;
        }
    }

    private void ButtonAdicionaImagem_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(textCPF.Text))
        {
            MessageBoxHelper.ShowWarning("Insira o CPF antes de carregar uma foto");
            return;
        }

        OpenFileDialog arquivoSelecionado = new()
        {
            Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png"
        };

        if (arquivoSelecionado.ShowDialog() == DialogResult.OK)
        {
            try
            {
                imagemDePerfil.Image = Image.FromFile(arquivoSelecionado.FileName);
         
                string caminhoComprimido = _manipularArquivo.ComprimirImagem(arquivoSelecionado.FileName, ManipularArquivoHelper.CalcularHash(textCPF.Text));

                urlFotoPerfil = _salvarGoogleDrive.UploadArquivo(caminhoComprimido, "fotoDePerfil");
                _dadosPessoaIdosa.AdicionarEditarAnexo(Anexo.Criar(TipoAnexo.FotoPerfil, urlFotoPerfil));

                File.Delete(caminhoComprimido);
                MessageBoxHelper.ShowSuccess("Imagem enviada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBoxHelper.ShowError($"Erro ao processar a imagem: {ex.Message}");
            }
        }
    }

    private void ButtonRemoveImagem_Click(object sender, EventArgs e)
    {
        if (imagemDePerfil.Image == Properties.Resources.icon_avatar)
        {
            MessageBoxHelper.ShowWarning("Não há imagem para remover");
            return;
        }

        if (MessageBoxHelper.ShowConfirmation("Deseja remover imagem?") == DialogResult.OK)
        {
            imagemDePerfil.Image = Properties.Resources.icon_avatar;

            try
            {
                _salvarGoogleDrive.DeletarArquivo(textCPF.Text, "fotoDePerfil");
                MessageBoxHelper.ShowSuccess("Imagem deletada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBoxHelper.ShowError($"Erro ao deletar a imagem: {ex.Message}");
            }
        }
    }

    private void DatagridLista_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        ButtonEditarDependente.Enabled = true;
        ButtonRemoverDependente.Enabled = true;
        dependenteIdSelecionado = Convert.ToInt32(dataGridDependentes.CurrentRow.Cells["id"].Value);
    }

    private void ButtonAdicionarDependente_Click(object sender, EventArgs e)
    {
        using FormCadastroDependente formularioDependente = new(_dependenteService);

        if (formularioDependente.ShowDialog() == DialogResult.OK)
        {
            Dependente dependenteNovo = formularioDependente.DadosDependente;

            if (dependenteNovo != null)
                _dadosPessoaIdosa.AdicionarDependente(dependenteNovo);

            AtualizarGridDependentes();
        }
    }

    private async void ButtonEditarDependente_Click(object sender, EventArgs e)
    {
        if (dataGridDependentes.CurrentRow == null)
        {
            MessageBoxHelper.ShowWarning("Nenhum dependente selecionado.");
            return;
        }

        using FormCadastroDependente formularioDependente = new(_dependenteService, true, dependenteIdSelecionado);

        if (formularioDependente.ShowDialog() == DialogResult.OK)
        {
            Dependente dependenteEditado = formularioDependente.DadosDependente;

            if (dependenteEditado != null)
                _dadosPessoaIdosa.EditarDependente(dependenteEditado);

            AtualizarGridDependentes();
        }
    }

    private void ButtonRemoverDependente_Click(object sender, EventArgs e)
    {
        if (dataGridDependentes.CurrentRow == null)
        {
            MessageBoxHelper.ShowWarning("Nenhum dependente selecionado.");
            return;
        }

        _dadosPessoaIdosa.RemoverDependente(dependenteIdSelecionado);
        
        AtualizarGridDependentes();
    }

    private void AtualizarGridDependentes()
    {
        dataGridDependentes.DataSource = _mapper.Map<List<DependenteDataGridViewDTO>>(_dadosPessoaIdosa.Dependentes);
        labelNenhumDependenteCadastrado.Visible = _dadosPessoaIdosa.Dependentes.Count == 0;
        ButtonEditarDependente.Enabled = false;
        ButtonRemoverDependente.Enabled = false;
        dataGridDependentes.ClearSelection();
        dependenteIdSelecionado = 0;
        labelRendaPerCapita.Text = CalculaRendaPerCapitaFamilia(_dadosPessoaIdosa.ComposicaoFamiliar.Renda, _dadosPessoaIdosa.Dependentes.Select(d => d.ComposicaoFamiliar.Renda));
    }

    private void ButtonAnexos_Click(object sender, EventArgs e)
    {
        using FormAnexosPessoaIdosa formAnexosPessoaIdosa = new(textCPF.Text, _dadosPessoaIdosa.Anexos);

        if (formAnexosPessoaIdosa.ShowDialog() == DialogResult.OK)
        {
            foreach (var anexo in formAnexosPessoaIdosa.DadosAnexo)
                _dadosPessoaIdosa.AdicionarEditarAnexo(anexo);
        }
    }

    private void ButtonCancelar_Click(object sender, EventArgs e)
    {
        if (MessageBoxHelper.ShowConfirmation("Deseja cancelar o cadastro?") == DialogResult.OK)
        {
            if (_pessoaIdosaIdSelecionado == 0 && imagemDePerfil.Name != "imagemDePerfil")
                ButtonRemoveImagem_Click(sender, e);
            this.Close();
        }
    }

    private async void ButtonSalvar_Click(object sender, EventArgs e)
    {
        if (MessageBoxHelper.ShowConfirmation("Deseja salvar o cadastro?") == DialogResult.Cancel)
            return;

        var erros = ObterErrosValidacao();

        if (erros.Count != 0)
        {
            MessageBoxHelper.ShowWarning("Faltam preencher os seguintes campos obrigatórios:\n" + string.Join("\n", erros.Select(e => "- " + e)));
            //return;
        }

        try
        {

            if (_dadosPessoaIdosa == null)
                _dadosPessoaIdosa = ObterPessoaIdosaDoFormulario();
            else
                _dadosPessoaIdosa.AtualizarCom(ObterPessoaIdosaDoFormulario());

            if (_dadosPessoaIdosa.ComposicaoFamiliar == null)
                _dadosPessoaIdosa.ComposicaoFamiliar = ObterComposicaoFamiliarDoFormulario();
            else
                _dadosPessoaIdosa.ComposicaoFamiliar.AtualizarCom(ObterComposicaoFamiliarDoFormulario());

            var dependentesAtualizados = new List<Dependente>();

            foreach (var d in _dadosPessoaIdosa.Dependentes)
            {
                var existente = _dadosPessoaIdosa?.Dependentes.FirstOrDefault(dep => dep.Id == d.Id);
                var dependente = existente ?? new Dependente();

                dependente.Nome = d.Nome;
                dependente.DataNascimento = d.DataNascimento;
                dependente.Parentesco = d.Parentesco;
                dependente.Ativo = d.Ativo;
                dependente.Ceinf = d.Ceinf;
                dependente.CeinfBairro = d.CeinfBairro;
                dependente.ProgramaSaudePastoralCrianca = d.ProgramaSaudePastoralCrianca;
                dependente.ProgramaSaudePastoralCriancaLocal = d.ProgramaSaudePastoralCriancaLocal;

                var dependenteComposicaoFamiliar = Models.ComposicaoFamiliar.Criar(
                    d.ComposicaoFamiliar.Alfabetizado,
                    d.ComposicaoFamiliar.EstudaAtualmente,
                    d.ComposicaoFamiliar.NivelSerieAtualConcluido,
                    d.ComposicaoFamiliar.CursosTecnicoFormacaoProfissional,
                    d.ComposicaoFamiliar.SituacaoOcupacional,
                    d.ComposicaoFamiliar.Renda,
                    d.ComposicaoFamiliar.Aposentado,
                    d.ComposicaoFamiliar.Beneficio,
                    d.ComposicaoFamiliar.Deficiencia,
                    d.ComposicaoFamiliar.ProblemaDeSaude,
                    d.ComposicaoFamiliar.FazAlgumTratamento,
                    d.ComposicaoFamiliar.FazAlgumTratamentoOnde,
                    d.ComposicaoFamiliar.UsaMedicamentoControlado,
                    d.ComposicaoFamiliar.UsaRecursosUbsLocal,
                    d.ComposicaoFamiliar.TrabalhoPastoralOuSocial,
                    d.ComposicaoFamiliar.AtividadeNaComunidadeSagradaFamilia,
                    d.ComposicaoFamiliar.TrabalhoVoluntario,
                    d.ComposicaoFamiliar.TrabalhoVoluntarioOnde
                );

                if (existente == null)
                    dependente.ComposicaoFamiliar = dependenteComposicaoFamiliar;
                else
                    dependente.ComposicaoFamiliar.AtualizarCom(dependenteComposicaoFamiliar);

                dependentesAtualizados.Add(dependente);
            }

            _dadosPessoaIdosa.Dependentes = dependentesAtualizados;

            if (_pessoaIdosaIdSelecionado == 0)
                await _pessoaIdosaService.CriarAsync(_dadosPessoaIdosa);
            else
                await _pessoaIdosaService.EditarAsync(_dadosPessoaIdosa);

            MessageBoxHelper.ShowSuccess($"Sucesso ao salvar cadastro de: {textNome.Text}");
            this.Close();
        }
        catch (Exception ex)
        {
            MessageBoxHelper.ShowError($"Erro ao salvar cadastro: {ex.Message}");
        }
    }

    private PessoaIdosa ObterPessoaIdosaDoFormulario()
    {
        return PessoaIdosa.Criar(
            textNome.Text,
            DateTime.SpecifyKind(DateTime.Parse(textDataNascimento.Text), DateTimeKind.Utc),
            comboBoxEstadoCivil.Text,
            textCPF.Text,
            textRG.Text,
            textOrgaoEmissor.Text,
            textReligiao.Text,
            textNaturalidade.Text,
            textTelefone.Text,
            textBoxProntuarioDeSaude.Text,
            radioButtonSimMantem.Checked,
            textBoxComoComplementa.Text,
            textBoxObservacao.Text,
            textBoxHistoricoFamiliarSocial.Text,
            ObterEnderecoDoFormulario(),
            checkBoxSituacao.Checked
        );
    }

    private Endereco ObterEnderecoDoFormulario()
    {
        return Endereco.Criar(
            textCEP.Text,
            textLogradouro.Text,
            textNumero.Text,
            comboBoxEstado.Text,
            comboBoxCidade.Text,
            textBairro.Text,
            comboBoxMoradia.Text
        );
    }

    private ComposicaoFamiliar ObterComposicaoFamiliarDoFormulario()
    {
        return Models.ComposicaoFamiliar.Criar(
            radioButtonSimAlfabetizado.Checked,
            radioButtonSimEstuda.Checked,
            comboBoxNivelSerie.Text,
            comboBoxCursoFormacao.Text,
            comboBoxSituacaoOcupacional.Text,
            comboBoxRenda.Text,
            comboBoxAposentado.Text,
            comboBoxBeneficio.Text,
            comboBoxDeficiencia.Text,
            comboBoxProblemaSaude.Text,
            radioButtonSimTratamento.Checked,
            textBoxTratamentoOnde.Text,
            radioButtonSimMedicamentoControlado.Checked,
            radioButtonSimRecursoUbs.Checked,
            textBoxTrabalhoPastoralSocial.Text,
            textBoxQualAtividade.Text,
            textBoxTrabalhoVoluntarioQual.Text,
            textBoxTrabalhoVoluntarioOnde.Text
        );
    }

    private List<string> ObterErrosValidacao()
    {
        List<string> erros = [];

        ValidacaoHelper.AdicionarErroCampoNulo(textNome.Text, "Nome", erros);
        ValidacaoHelper.AdicionarErroCampoNulo(textDataNascimento.Text, "Data de Nascimento", erros);

        if (!ValidacaoHelper.ValidarDataNascimento(DateTime.Parse(textDataNascimento.Text)))
            erros.Add("Campo Data de Nascimento é inválido.");

        ValidacaoHelper.AdicionarErroComboBoxNaoSelecionado(comboBoxEstadoCivil, "Estado Civil", erros);
        ValidacaoHelper.AdicionarErroCampoNulo(textNaturalidade.Text, "Naturalidade", erros);
        ValidacaoHelper.AdicionarErroCampoNulo(textBoxProntuarioDeSaude.Text, "Prontuário de Saúde", erros);
        ValidacaoHelper.AdicionarErroCampoNulo(textCPF.Text, "CPF", erros);

        if (!ValidacaoHelper.ValidarCPF(textCPF.Text))
            erros.Add("Campo CPF é inválido.");

        ValidacaoHelper.AdicionarErroCampoNulo(textRG.Text, "RG", erros);

        if (!ValidacaoHelper.ValidarRG(textRG.Text))
            erros.Add("Campo RG é inválido.");

        ValidacaoHelper.AdicionarErroCampoNulo(textOrgaoEmissor.Text, "Órgão Emissor", erros);
        ValidacaoHelper.AdicionarErroCampoNulo(textReligiao.Text, "Religião", erros);
        ValidacaoHelper.AdicionarErroRadioButtonDesmarcado(radioButtonNaoEstuda, radioButtonSimEstuda, "Estuda Atualmente", erros);
        ValidacaoHelper.AdicionarErroComboBoxNaoSelecionado(comboBoxBeneficio, "Recebe algum Benefício", erros);
        ValidacaoHelper.AdicionarErroComboBoxNaoSelecionado(comboBoxRenda, "Renda", erros);
        ValidacaoHelper.AdicionarErroComboBoxNaoSelecionado(comboBoxSituacaoOcupacional, "Situação Ocupacional", erros);
        ValidacaoHelper.AdicionarErroComboBoxNaoSelecionado(comboBoxAposentado, "Aposentado", erros);

        if (string.IsNullOrEmpty(comboBoxAposentado.Text) && comboBoxAposentado.Text != "Não")
            ValidacaoHelper.AdicionarErroRadioButtonDesmarcado(radioButtonNaoMantem, radioButtonSimMantem, "Se mantem com a renda", erros);

        if (radioButtonNaoMantem.Checked)
            ValidacaoHelper.AdicionarErroCampoNulo(textBoxComoComplementa.Text, "Como complementa", erros);

        ValidacaoHelper.AdicionarErroCampoNulo(textCEP.Text, "CEP", erros);
        ValidacaoHelper.AdicionarErroCampoNulo(textLogradouro.Text, "Logradouro", erros);
        ValidacaoHelper.AdicionarErroComboBoxNaoSelecionado(comboBoxEstado, "Estado", erros);
        ValidacaoHelper.AdicionarErroComboBoxNaoSelecionado(comboBoxCidade, "Cidade", erros);
        ValidacaoHelper.AdicionarErroCampoNulo(textBairro.Text, "Bairro", erros);
        ValidacaoHelper.AdicionarErroCampoNulo(textNumero.Text, "Número", erros);
        ValidacaoHelper.AdicionarErroComboBoxNaoSelecionado(comboBoxMoradia, "Moradia", erros);
        ValidacaoHelper.AdicionarErroCampoNulo(textTelefone.Text, "Telefone / Celular", erros);

        ValidacaoHelper.AdicionarErroComboBoxNaoSelecionado(comboBoxDeficiencia, "Possui alguma deficiência", erros);

        if (string.IsNullOrEmpty(comboBoxDeficiencia.Text) && comboBoxDeficiencia.Text == "Outra")
            ValidacaoHelper.AdicionarErroCampoNulo(textBoxDeficienciaOutra.Text, "Qual deficiência", erros);

        ValidacaoHelper.AdicionarErroRadioButtonDesmarcado(radioButtonNaoAlfabetizado, radioButtonSimAlfabetizado, "Alfabetizado", erros);

        // TO DO
        /*
        if (radioButtonSimAlfabetizado.Checked)
        {
            ValidacaoHelper.AdicionarErroComboBoxNaoSelecionado(comboBoxNivelSerie, "Nível e Série Atual e Concluído", erros);
            ValidacaoHelper.AdicionarErroComboBoxNaoSelecionado(comboBoxCursoFormacao, "Cursos Técnico e Formação Profissional", erros);
        }
        */

        ValidacaoHelper.AdicionarErroComboBoxNaoSelecionado(comboBoxProblemaSaude, "Apresenta problemas de saúde", erros);

        if (string.IsNullOrEmpty(comboBoxProblemaSaude.Text) && comboBoxProblemaSaude.Text == "Outro")
            ValidacaoHelper.AdicionarErroCampoNulo(textBoxProblemaSaudeOutro.Text, "Qual problema de saúde", erros);

        ValidacaoHelper.AdicionarErroRadioButtonDesmarcado(radioButtonNaoTratamento, radioButtonSimTratamento, "Faz algum tratamento", erros);

        if (radioButtonSimTratamento.Checked)
            ValidacaoHelper.AdicionarErroCampoNulo(textBoxTratamentoOnde.Text, "Onde faz tratamento", erros);

        ValidacaoHelper.AdicionarErroRadioButtonDesmarcado(radioButtonNaoMedicamentoControlado, radioButtonSimMedicamentoControlado, "Usa medicamento controlado", erros);
        ValidacaoHelper.AdicionarErroRadioButtonDesmarcado(radioButtonNaoRecursoUbs, radioButtonSimRecursoUbs, "Usa recursos da ubs local", erros);

        ValidacaoHelper.AdicionarErroRadioButtonDesmarcado(radioButtonNaoPastoralSocial, radioButtonSimPastoralSocial, "Faz algum trabalho Pastoral ou social", erros);

        if (radioButtonSimPastoralSocial.Checked)
            ValidacaoHelper.AdicionarErroCampoNulo(labelQualTrabalhoPastoralSocial.Text, "Qual trabalho pastoral ou social", erros);

        ValidacaoHelper.AdicionarErroRadioButtonDesmarcado(radioButtonNaoAtividade, radioButtonSimAtividade, "Desenvolve alguma atividade", erros);

        if (radioButtonSimAtividade.Checked)
            ValidacaoHelper.AdicionarErroCampoNulo(textBoxQualAtividade.Text, "Qual atividade desenvolve", erros);

        ValidacaoHelper.AdicionarErroRadioButtonDesmarcado(radioButtonNaoTrabalhoVoluntario, radioButtonSimTrabalhoVoluntario, "Desenvolver algum trabalho voluntário", erros);

        if (radioButtonSimTrabalhoVoluntario.Checked)
        {
            ValidacaoHelper.AdicionarErroCampoNulo(textBoxTrabalhoVoluntarioQual.Text, "Qual trabalho voluntário desenvolveu", erros);
            ValidacaoHelper.AdicionarErroCampoNulo(textBoxTrabalhoVoluntarioOnde.Text, "Onde desenvolveu trabalho voluntário", erros);
        }

        return erros;
    }

    private void RadioButton_CheckedChanged(object sender, EventArgs e)
    {
        ValidacaoHelper.HabilitarCampoAdicional(radioButtonNaoMantem, textBoxComoComplementa, true);
        ValidacaoHelper.HabilitarCampoAdicional(radioButtonSimMantem, textBoxComoComplementa, false);

        ValidacaoHelper.HabilitarCampoAdicional(radioButtonNaoTratamento, textBoxTratamentoOnde, false);
        ValidacaoHelper.HabilitarCampoAdicional(radioButtonSimTratamento, textBoxTratamentoOnde, true);

        ValidacaoHelper.HabilitarCampoAdicional(radioButtonNaoPastoralSocial, textBoxTrabalhoPastoralSocial, false);
        ValidacaoHelper.HabilitarCampoAdicional(radioButtonSimPastoralSocial, textBoxTrabalhoPastoralSocial, true);

        ValidacaoHelper.HabilitarCampoAdicional(radioButtonNaoAtividade, textBoxQualAtividade, false);
        ValidacaoHelper.HabilitarCampoAdicional(radioButtonSimAtividade, textBoxQualAtividade, true);

        ValidacaoHelper.HabilitarCamposAdicionais(radioButtonNaoTrabalhoVoluntario, textBoxTrabalhoVoluntarioQual, textBoxTrabalhoVoluntarioOnde, false);
        ValidacaoHelper.HabilitarCamposAdicionais(radioButtonSimTrabalhoVoluntario, textBoxTrabalhoVoluntarioQual, textBoxTrabalhoVoluntarioOnde, true);
    }

    private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        radioButtonNaoMantem.Enabled = !string.IsNullOrEmpty(comboBoxAposentado.Text) && comboBoxAposentado.Text != "Não";
        radioButtonSimMantem.Enabled = !string.IsNullOrEmpty(comboBoxAposentado.Text) && comboBoxAposentado.Text != "Não";
        textBoxComoComplementa.Enabled = radioButtonNaoMantem.Checked;

        if (comboBoxAposentado.Text == "Não")
        {
            radioButtonNaoMantem.Checked = false;
            radioButtonSimMantem.Checked = false;
            textBoxComoComplementa.Text = string.Empty;
        }

        textBoxDeficienciaOutra.Enabled = !string.IsNullOrEmpty(comboBoxDeficiencia.Text) && comboBoxDeficiencia.Text != "Não";

        // TO DO
        /*
        if (radioButtonNaoAlfabetizado.Checked)
        {
            comboBoxNivelSerie.Text = string.Empty;
            comboBoxCursoFormacao.Text = string.Empty;
        }
        */

        textBoxProblemaSaudeOutro.Enabled = !string.IsNullOrEmpty(comboBoxProblemaSaude.Text) && comboBoxProblemaSaude.Text != "Não";
    }
}
