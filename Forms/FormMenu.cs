using ASFA.Helpers;
using ASFA.Models;
using ASFA.Models.DTOs;
using ASFA.Services.Interfaces;
using AutoMapper;
using LinqKit;
using Microsoft.Reporting.WinForms;
using System.Data;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Net;
using System.Threading.Tasks;

namespace ASFA;

public partial class FormMenu : Form
{
    private readonly IPessoaIdosaService _pessoaIdosaService;
    private readonly IDependenteService _dependenteService;
    private readonly IMapper _mapper;
    private int pessoaIdosaIdSelecionado;

    public FormMenu(IPessoaIdosaService pessoaIdosaService, IDependenteService dependenteService, IMapper mapper)
    {
        _pessoaIdosaService = pessoaIdosaService;
        _dependenteService = dependenteService;
        _mapper = mapper;

        InitializeComponent();
    }

    private async void FormMenuUsuarios_Load(object sender, EventArgs e)
    {
        try
        {
            buttonEditar.Enabled = false;
            buttonRelatorio.Enabled = false;
            buttonFicha.Enabled = false;
            dataGridPessoaIdosa.DataSource = await _pessoaIdosaService.ObterAsync(x => x.Ativo);
        }
        catch (Exception ex)
        {
            MessageBoxHelper.ShowError($"{ex.Message}");
        }
        finally
        {
            EncerrarAnimacaoCarregar();
            DataGridListHelper.FormataLinhaAtivoInativo(dataGridPessoaIdosa);
            Rodape();

            buttonRelatorio.Enabled = dataGridPessoaIdosa.RowCount != 0;
            labelNadaEncontrado.Visible = dataGridPessoaIdosa.RowCount == 0;
        }
    }

    private void ButtonAdicionar_Click(object sender, EventArgs e)
    {
        try
        {
            using FormCadastroPessoaIdosa formulario = new(_pessoaIdosaService, _dependenteService, _mapper);
            if (formulario.ShowDialog() == DialogResult.OK)
                ButtonRecarregar_Click(sender, e);
        }
        catch (Exception ex)
        {
            MessageBoxHelper.ShowError(ex.Message);
        }
    }

    private async void ButtonEditar_Click(object sender, EventArgs e)
    {
        if (dataGridPessoaIdosa.CurrentRow == null)
        {
            MessageBoxHelper.ShowWarning("Nenhum item selecionado.");
            return;
        }

        try
        {
            FormCadastroPessoaIdosa formulario = new(_pessoaIdosaService, _dependenteService, _mapper, pessoaIdosaIdSelecionado);
            if (formulario.ShowDialog() == DialogResult.OK)
                ButtonRecarregar_Click(sender, e);
        }
        catch (Exception ex)
        {
            MessageBoxHelper.ShowError(ex.Message);
        }
    }

    private void ButtonRelatorio_Click(object sender, EventArgs e)
    {
        if (dataGridPessoaIdosa.DataSource == null)
        {
            MessageBoxHelper.ShowWarning("Nenhum dado disponível para gerar o relatório.");
            return;
        }

        try
        {
            IniciarAnimacaoCarregar();
            var dadosDataGrid = DataGridListHelper.ObterDadosDataGridView(dataGridPessoaIdosa);

            string ativos = dadosDataGrid.AsEnumerable().Count(row => row["Ativo"]?.ToString().ToLower() == "true").ToString();
            string inativos = dadosDataGrid.AsEnumerable().Count(row => row["Ativo"]?.ToString().ToLower() == "false").ToString();
            
            ReportParameterCollection parametros = new()
            {
                new ReportParameter("QuantidadeAtivos", ativos),
                new ReportParameter("QuantidadeInativos", inativos)
            };

            ReportDataSource reportDataSource = new("DataSetPessoasIdosa", dadosDataGrid);
            RelatorioHelper.GerarPDF(reportViewerRelatorio, "RelatorioPDF", "RelatorioPDF.rdlc", parametros, reportDataSource);
        }
        catch (Exception ex)
        {
            MessageBoxHelper.ShowError(ex.Message);
        }
        finally
        {
            EncerrarAnimacaoCarregar();
        }
    }

    private async void ButtonFichaCadastral_Click(object sender, EventArgs e)
    {
        if (dataGridPessoaIdosa.CurrentRow == null)
        {
            MessageBoxHelper.ShowWarning("Nenhum item selecionado.");
            return;
        }
        
        try
        {
            IniciarAnimacaoCarregar();
            var dadosPessoaIdosa = await _pessoaIdosaService.ObterPorIdAsync(pessoaIdosaIdSelecionado);

            ReportParameterCollection parametros = new()
            {
                new ReportParameter("DataCadastro", dadosPessoaIdosa.DataCadastro.ToString("dd/MM/yyyy")),
                new ReportParameter("Nome", dadosPessoaIdosa.Nome),
                new ReportParameter("DataNascimento", dadosPessoaIdosa.DataNascimento.ToString("dd/MM/yyyy")),
                new ReportParameter("Idade", (DateTime.Today.Year - dadosPessoaIdosa.DataNascimento.Year).ToString()),
                new ReportParameter("Naturalidade", dadosPessoaIdosa.Naturalidade),
                new ReportParameter("Cpf", dadosPessoaIdosa.Cpf),
                new ReportParameter("Rg", dadosPessoaIdosa.Rg),
                new ReportParameter("OrgaoEmissor", dadosPessoaIdosa.OrgaoEmissor),
                new ReportParameter("Cep", dadosPessoaIdosa.Endereco.Cep),
                new ReportParameter("Logradouro", dadosPessoaIdosa.Endereco.Logradouro),
                new ReportParameter("Numero", dadosPessoaIdosa.Endereco.Numero),
                new ReportParameter("Bairro", dadosPessoaIdosa.Endereco.Bairro),
                new ReportParameter("Estado", dadosPessoaIdosa.Endereco.Estado),
                new ReportParameter("Cidade", dadosPessoaIdosa.Endereco.Cidade),
                new ReportParameter("Telefone", dadosPessoaIdosa.Telefone),
                new ReportParameter("EstadoCivil", dadosPessoaIdosa.EstadoCivil),
                new ReportParameter("Moradia", dadosPessoaIdosa.Endereco.Moradia),
                new ReportParameter("Religiao", dadosPessoaIdosa.Religiao),
                new ReportParameter("AposentadoConsegueSeManterComSuaRenda", dadosPessoaIdosa.AposentadoConsegueSeManterComSuaRenda ? "Sim" : "Não"),
                new ReportParameter("Alfabetizado", dadosPessoaIdosa.ComposicaoFamiliar.Alfabetizado ? "Sim" : "Não"),
                new ReportParameter("Aposentado", dadosPessoaIdosa.ComposicaoFamiliar.Aposentado),
                new ReportParameter("AtividadeNaComunidadeSagradaFamilia", dadosPessoaIdosa.ComposicaoFamiliar.AtividadeNaComunidadeSagradaFamilia),
                new ReportParameter("Beneficio", dadosPessoaIdosa.ComposicaoFamiliar.Beneficio),
                new ReportParameter("CursosTecnicoFormacaoProfissional", dadosPessoaIdosa.ComposicaoFamiliar.CursosTecnicoFormacaoProfissional),
                new ReportParameter("Deficiencia", dadosPessoaIdosa.ComposicaoFamiliar.Deficiencia),
                new ReportParameter("EstudaAtualmente", dadosPessoaIdosa.ComposicaoFamiliar.EstudaAtualmente ? "Sim" : "Não"),
                new ReportParameter("FazAlgumTratamento", dadosPessoaIdosa.ComposicaoFamiliar.FazAlgumTratamento ? "Sim" : "Não"),
                new ReportParameter("FazAlgumTratamentoOnde", dadosPessoaIdosa.ComposicaoFamiliar.FazAlgumTratamentoOnde),
                new ReportParameter("NivelSerieAtualConcluido", dadosPessoaIdosa.ComposicaoFamiliar.NivelSerieAtualConcluido),
                new ReportParameter("ProblemaDeSaude", dadosPessoaIdosa.ComposicaoFamiliar.ProblemaDeSaude),
                new ReportParameter("Renda", dadosPessoaIdosa.ComposicaoFamiliar.Renda),
                new ReportParameter("SituacaoOcupacional", dadosPessoaIdosa.ComposicaoFamiliar.SituacaoOcupacional),
                new ReportParameter("TrabalhoPastoralOuSocial", dadosPessoaIdosa.ComposicaoFamiliar.TrabalhoPastoralOuSocial),
                new ReportParameter("TrabalhoVoluntario", dadosPessoaIdosa.ComposicaoFamiliar.TrabalhoVoluntario),
                new ReportParameter("TrabalhoVoluntarioOnde", dadosPessoaIdosa.ComposicaoFamiliar.TrabalhoVoluntarioOnde),
                new ReportParameter("UsaMedicamentoControlado", dadosPessoaIdosa.ComposicaoFamiliar.UsaMedicamentoControlado ? "Sim" : "Não"),
                new ReportParameter("UsaRecursosUbsLocal", dadosPessoaIdosa.ComposicaoFamiliar.UsaRecursosUbsLocal ? "Sim" : "Não"),
                new ReportParameter("Observacao", dadosPessoaIdosa.Observacao),
                new ReportParameter("HistoricoFamiliarSocial", dadosPessoaIdosa.HistoricoFamiliarSocial),
                new ReportParameter("Ativo", dadosPessoaIdosa.Ativo ? "Sim" : "Não")
            };

            ReportDataSource reportDataSource = new("DataSetDependentes", dadosPessoaIdosa.Dependentes);
            RelatorioHelper.GerarPDF(reportViewerRelatorio, "FichaCadastral", "FichaCadastral.rdlc", parametros, reportDataSource);
        }
        catch (Exception ex)
        {
            MessageBoxHelper.ShowError($"Erro ao Gerar PDF: {ex.Message}");
        }
        finally
        {
            EncerrarAnimacaoCarregar();
        }
    }

    private async void ButtonProcurar_Click(object sender, EventArgs e)
    {
        try
        {
            IniciarAnimacaoCarregar();
            dataGridPessoaIdosa.DataSource = await _pessoaIdosaService.ObterAsync(GerarCriterios());
        }
        catch (Exception ex)
        {
            MessageBoxHelper.ShowError(ex.Message);
        }
        finally
        {
            EncerrarAnimacaoCarregar();
            labelNadaEncontrado.Visible = dataGridPessoaIdosa.RowCount == 0;
            DataGridListHelper.FormataLinhaAtivoInativo(dataGridPessoaIdosa);
            Rodape();
        }
    }

    private async void ButtonRecarregar_Click(object sender, EventArgs e)
    {
        try
        {
            IniciarAnimacaoCarregar();

            textNome.Text = null;
            textCPFouRG.Text = null;
            comboBoxEstadoCivil.Text = null;
            textEndereco.Text = null;
            comboBoxSituacao.Text = "Ativo";

            dataGridPessoaIdosa.ClearSelection();

            dataGridPessoaIdosa.DataSource = await _pessoaIdosaService.ObterAsync(x => x.Ativo);
        }
        catch (Exception ex)
        {
            MessageBoxHelper.ShowError(ex.Message);
        }
        finally
        {
            EncerrarAnimacaoCarregar();
            DataGridListHelper.FormataLinhaAtivoInativo(dataGridPessoaIdosa);
            Rodape();

            buttonEditar.Enabled = false;
            buttonFicha.Enabled = false;
            pessoaIdosaIdSelecionado = 0;
            labelNadaEncontrado.Visible = dataGridPessoaIdosa.RowCount == 0;
        }
    }

    private void IniciarAnimacaoCarregar()
    {
        buttonAdicionar.Enabled = false;
        buttonEditar.Enabled = false;
        buttonFicha.Enabled = false;
        buttonRelatorio.Enabled = false;
        buttonProcurar.Enabled = false;
        buttonRecarregar.Enabled = false;
        pictureBoxCarregando.Visible = true;
    }

    private void EncerrarAnimacaoCarregar()
    {
        buttonAdicionar.Enabled = true;
        buttonRelatorio.Enabled = true;
        buttonProcurar.Enabled = true;
        buttonRecarregar.Enabled = true;
        pictureBoxCarregando.Visible = false;
        dataGridPessoaIdosa.ClearSelection();
    }

    private void DatagridLista_Sorted(object sender, EventArgs e)
    {
        DataGridListHelper.FormataLinhaAtivoInativo(dataGridPessoaIdosa);
        buttonEditar.Enabled = false;
        buttonFicha.Enabled = false;
    }

    private void DatagridLista_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        buttonEditar.Enabled = true;
        buttonFicha.Enabled = true;
        pessoaIdosaIdSelecionado = Convert.ToInt32(dataGridPessoaIdosa.CurrentRow.Cells["id"].Value);
    }

    private void Rodape()
    {
        int total = 0;
        int ativos = 0;
        int inativos = 0;

        if (dataGridPessoaIdosa.DataSource is List<PessoaIdosaDataGridViewDTO> dados && dados.Count > 0)
        {
            total = dados.Count;
            ativos = dados.Cast<dynamic>().Count(x => x.Ativo);
            inativos = total - ativos;
        }

        labelTotalEncontrado.Text = $"Total Encontrado: {total}";
        labelTotalAtivo.Text = $"Total Ativo: {ativos}";
        labelTotalCancelado.Text = $"Total Inativos: {inativos}";
    }

    private Expression<Func<PessoaIdosa, bool>> GerarCriterios()
    {
        var criterios = PredicateBuilder.New<PessoaIdosa>(x => true);

        if (!string.IsNullOrWhiteSpace(textNome.Text))
            criterios = criterios.And(x => x.Nome.Contains(textNome.Text));

        if (!string.IsNullOrWhiteSpace(textCPFouRG.Text))
            criterios = criterios.And(x => x.Cpf.Contains(textCPFouRG.Text) || x.Rg.Contains(textCPFouRG.Text));

        if (!string.IsNullOrWhiteSpace(comboBoxEstadoCivil.Text))
            criterios = criterios.And(x => x.EstadoCivil.Contains(comboBoxEstadoCivil.Text));

        if (!string.IsNullOrWhiteSpace(textEndereco.Text))
            criterios = criterios.And(x => x.Endereco.Logradouro.Contains(textEndereco.Text));

        if (!string.IsNullOrWhiteSpace(comboBoxSituacao.Text) && comboBoxSituacao.Text != "Todos")
            criterios = criterios.And(x => x.Ativo == (comboBoxSituacao.Text == "Ativo"));

        return criterios;
    }
}
