using ASFA.Helpers;
using ASFA.Models;

namespace ASFA.Forms;

public partial class FormAnexosPessoaIdosa : Form
{
    private readonly string _cpf;
    public ICollection<Anexo> AnexosExistentes { get; set; }
    public List<Anexo> DadosAnexo { get; set; } = [];
    private GoogleDriveHelper _salvarGoogleDrive;

    public FormAnexosPessoaIdosa(string cpf, ICollection<Anexo> anexosExistentes)
    {
        _cpf = cpf;
        AnexosExistentes = anexosExistentes;
        _salvarGoogleDrive = new GoogleDriveHelper();

        InitializeComponent();
    }

    private void FormAnexosPessoaIdosa_Load(object sender, EventArgs e)
    {
        try
        {
            labelNomeCpf.Text = AnexosExistentes.Any(a => a.TipoAnexo == TipoAnexo.Cpf) ? "anexo-cpf" : "";
            if (labelNomeCpf.Text == "")
                ButtonRemoverCpf.Enabled = false;

            labelNomeRg.Text = AnexosExistentes.Any(a => a.TipoAnexo == TipoAnexo.Rg) ? "anexo-rg" : "";
            if (labelNomeRg.Text == "")
                ButtonRemoverRg.Enabled = false;

            labelNomeComprovanteEndereco.Text = AnexosExistentes.Any(a => a.TipoAnexo == TipoAnexo.ComprovanteEndereco) ? "anexo-comprovante-endereco" : "";
            if (labelNomeComprovanteEndereco.Text == "")
                ButtonRemoverComprovanteEndereco.Enabled = false;

            labelNomeCartaoSus.Text = AnexosExistentes.Any(a => a.TipoAnexo == TipoAnexo.CartaoSus) ? "anexo-cartao-sus" : "";
            if (labelNomeCartaoSus.Text == "")
                ButtonRemoverCartaoSus.Enabled = false;

            labelNomeCadastroNis.Text = AnexosExistentes.Any(a => a.TipoAnexo == TipoAnexo.CadastroNis) ? "anexo-cadastro-nis" : "";
            if (labelNomeCadastroNis.Text == "")
                ButtonRemoverCadastroNis.Enabled = false;

            labelNomeTermoAutorizacao.Text = AnexosExistentes.Any(a => a.TipoAnexo == TipoAnexo.TermoAutorizacao) ? "anexo-termo-autorizacao" : "";
            if (labelNomeTermoAutorizacao.Text == "")
                ButtonRemoverTermoAutorizacao.Enabled = false;
        }
        catch (Exception ex)
        {
            MessageBoxHelper.ShowError(ex.Message);
        }
    }

    private void AdicionarArquivo(string pasta, TipoAnexo tipoAnexo, Label labelDestino, Button buttonRemover)
    {
        pictureBoxCarregando.Visible = true;
        _salvarGoogleDrive.AdicionarArquivo(_cpf, pasta, out string? nomeArquivo, out string? urlArquivo);
        pictureBoxCarregando.Visible = false;
        labelDestino.Text = nomeArquivo;
        DadosAnexo.RemoveAll(a => a.TipoAnexo == tipoAnexo);
        DadosAnexo.Add(Anexo.Criar(tipoAnexo, urlArquivo));
        buttonRemover.Enabled = true;
    }

    private void RemoverArquivo(string pasta, Label labelDestino, Button buttonRemover)
    {
        pictureBoxCarregando.Visible = true;
        _salvarGoogleDrive.DeletarArquivo(_cpf, pasta);
        pictureBoxCarregando.Visible = false;
        labelDestino.Text = "";
        buttonRemover.Enabled = false;
    }

    private void ButtonAdicionarCpf_Click(object sender, EventArgs e) => AdicionarArquivo("cpf", TipoAnexo.Cpf, labelNomeCpf, ButtonRemoverCpf);
    
    private void ButtonRemoverCpf_Click(object sender, EventArgs e) => RemoverArquivo("cpf", labelNomeCpf, ButtonRemoverCpf);

    private void ButtonAdicionarRg_Click(object sender, EventArgs e) => AdicionarArquivo("rg", TipoAnexo.Rg, labelNomeRg, ButtonRemoverRg);
    
    private void ButtonRemoverRg_Click(object sender, EventArgs e) => RemoverArquivo("rg", labelNomeRg, ButtonRemoverRg);

    private void ButtonAdicionarComprovanteEndereco_Click(object sender, EventArgs e) => AdicionarArquivo("comprovante-endereco", TipoAnexo.ComprovanteEndereco, labelNomeComprovanteEndereco, ButtonRemoverComprovanteEndereco);
    
    private void ButtonRemoverComprovanteEndereco_Click(object sender, EventArgs e) => RemoverArquivo("comprovante-endereco", labelNomeComprovanteEndereco, ButtonRemoverComprovanteEndereco);

    private void ButtonAdicionarCartaoSus_Click(object sender, EventArgs e) => AdicionarArquivo("cartao-sus", TipoAnexo.CartaoSus, labelNomeCartaoSus, ButtonRemoverCartaoSus);
    
    private void ButtonRemoverCartaoSus_Click(object sender, EventArgs e) => RemoverArquivo("cartao-sus", labelNomeCartaoSus, ButtonRemoverCartaoSus);

    private void ButtonAdicionarCadastroNis_Click(object sender, EventArgs e) => AdicionarArquivo("cadastro-nis", TipoAnexo.CadastroNis, labelNomeCadastroNis, ButtonRemoverCadastroNis);
    
    private void ButtonRemoverCadastroNis_Click(object sender, EventArgs e) => RemoverArquivo("cadastro-nis", labelNomeCadastroNis, ButtonRemoverCadastroNis);

    private void ButtonAdicionarTermoAutorizacao_Click(object sender, EventArgs e) => AdicionarArquivo("termo-autorizacao", TipoAnexo.TermoAutorizacao, labelNomeTermoAutorizacao, ButtonRemoverTermoAutorizacao);

    private void ButtonRemoverTermoAutorizacao_Click(object sender, EventArgs e) => RemoverArquivo("termo-autorizacao", labelNomeTermoAutorizacao, ButtonRemoverTermoAutorizacao);

    private void ButtonVoltar_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.OK;
        this.Close();
    }
}
