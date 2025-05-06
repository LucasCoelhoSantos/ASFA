using System.ComponentModel.DataAnnotations.Schema;

namespace ASFA.Models;

public class Anexo : Entity
{
    public TipoAnexo TipoAnexo { get; private set; }
    public string Url { get; private set; }

    // Relacionamentos

    public int PessoaIdosaId { get; set; }

    [ForeignKey("PessoaIdosaId")]
    public PessoaIdosa PessoaIdosa { get; set; }

    protected Anexo() { }

    public static Anexo Criar(TipoAnexo tipoAnexo, string url)
    {
        var anexo = new Anexo();
        anexo.DefinirDados(tipoAnexo, url);
        return anexo;
    }

    public void AtualizarCom(Anexo outro)
    {
        DefinirDados(outro.TipoAnexo, outro.Url);
    }

    private void DefinirDados(TipoAnexo tipoAnexo, string url)
    {
        TipoAnexo = tipoAnexo;
        Url = url;
    }
}
