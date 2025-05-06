using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASFA.Models;

public class ComposicaoFamiliar : Entity
{
    // Escolaridade
    [Required(ErrorMessage = "O campo alfabetizado é obrigatório.")]
    public bool Alfabetizado { get; private set; }

    [Required(ErrorMessage = "O campo é estuda atualmente obrigatório.")]
    public bool EstudaAtualmente { get; private set; }

    [Required(ErrorMessage = "O campo é nível e série atual concluído obrigatório.")]
    public string NivelSerieAtualConcluido { get; private set; }

    [Required(ErrorMessage = "O campo cursos técnicos e formação profissional é obrigatório.")]
    public string CursosTecnicoFormacaoProfissional { get; private set; }

    // Renda
    [Required(ErrorMessage = "O campo situação ocupacional é obrigatório.")]
    public string SituacaoOcupacional { get; private set; }

    [Required(ErrorMessage = "O campo renda é obrigatório.")]
    public string Renda { get; private set; }

    [Required(ErrorMessage = "O campo aposentado é obrigatório.")]
    public string Aposentado { get; private set; }

    // [Required(ErrorMessage = "O campo incapaz de prover seu próprio sustento é obrigatório.")]
    // public bool 18 - IdosoIncapazDeProverSeuProprioSustento { get; private set; } // Acima de 65 anos

    // Saúde
    [Required(ErrorMessage = "O campo benefício é obrigatório.")]
    public string Beneficio { get; private set; }

    [Required(ErrorMessage = "O campo deficiência é obrigatório.")]
    public string Deficiencia { get; private set; }

    [Required(ErrorMessage = "O campo problema de saúde é obrigatório.")]
    public string ProblemaDeSaude { get; private set; }

    [Required(ErrorMessage = "O campo faz algum tratamento é obrigatório.")]
    public bool FazAlgumTratamento { get; private set; }
    
    public string FazAlgumTratamentoOnde { get; private set; }

    [Required(ErrorMessage = "O campo usa medicamento controlado é obrigatório.")]
    public bool UsaMedicamentoControlado { get; private set; }

    [Required(ErrorMessage = "O campo usa recursos da ubs local é obrigatório.")]
    public bool UsaRecursosUbsLocal { get; private set; }

    // Atividades
    public string TrabalhoPastoralOuSocial { get; private set; }

    public string AtividadeNaComunidadeSagradaFamilia { get; private set; }

    public string TrabalhoVoluntario { get; private set; }

    public string TrabalhoVoluntarioOnde { get; private set; }

    // Relacionamentos
    public int PessoaId { get; set; }

    [ForeignKey("PessoaId")]
    public Pessoa Pessoa { get; set; }

    protected ComposicaoFamiliar() { }

    public static ComposicaoFamiliar Criar(bool alfabetizado, bool estudaAtualmente, string nivelSerieAtualConcluido, string cursosTecnicoFormacaoProfissional,
        string situacaoOcupacional, string renda, string aposentado, string beneficio, string deficiencia, string problemaDeSaude, bool fazAlgumTratamento,
        string fazAlgumTratamentoOnde, bool usaMedicamentoControlado, bool usaRecursosUbsLocal, string trabalhoPastoralOuSocial, string atividadeNaComunidadeSagradaFamilia,
        string trabalhoVoluntario, string trabalhoVoluntarioOnde)
    {
        var composicaoFamiliar = new ComposicaoFamiliar();
        composicaoFamiliar.DefinirDados(alfabetizado, estudaAtualmente, nivelSerieAtualConcluido, cursosTecnicoFormacaoProfissional, situacaoOcupacional, renda, aposentado,
            beneficio, deficiencia, problemaDeSaude, fazAlgumTratamento, fazAlgumTratamentoOnde, usaMedicamentoControlado, usaRecursosUbsLocal, trabalhoPastoralOuSocial,
            atividadeNaComunidadeSagradaFamilia, trabalhoVoluntario, trabalhoVoluntarioOnde);
        return composicaoFamiliar;
    }

    public void AtualizarCom(ComposicaoFamiliar outro)
    {
        DefinirDados(outro.Alfabetizado, outro.EstudaAtualmente, outro.NivelSerieAtualConcluido, outro.CursosTecnicoFormacaoProfissional, outro.SituacaoOcupacional,
            outro.Renda, outro.Aposentado, outro.Beneficio, outro.Deficiencia, outro.ProblemaDeSaude, outro.FazAlgumTratamento, outro.FazAlgumTratamentoOnde,
            outro.UsaMedicamentoControlado, outro.UsaRecursosUbsLocal, outro.TrabalhoPastoralOuSocial, outro.AtividadeNaComunidadeSagradaFamilia,
            outro.TrabalhoVoluntario, outro.TrabalhoVoluntarioOnde);
    }

    private void DefinirDados(bool alfabetizado, bool estudaAtualmente, string nivelSerieAtualConcluido, string cursosTecnicoFormacaoProfissional,
        string situacaoOcupacional, string renda, string aposentado, string beneficio, string deficiencia, string problemaDeSaude, bool fazAlgumTratamento,
        string fazAlgumTratamentoOnde, bool usaMedicamentoControlado, bool usaRecursosUbsLocal, string trabalhoPastoralOuSocial, string atividadeNaComunidadeSagradaFamilia,
        string trabalhoVoluntario, string trabalhoVoluntarioOnde)
    {/*
        if (string.IsNullOrWhiteSpace(nivelSerieAtualConcluido))
            throw new ArgumentException("Nível e Série Atual e Concluído é obrigatório.");
        if (string.IsNullOrWhiteSpace(cursosTecnicoFormacaoProfissional))
            throw new ArgumentException("Cursos Técnico e Formação Profissional é obrigatório.");
        if (string.IsNullOrWhiteSpace(situacaoOcupacional))
            throw new ArgumentException("Situação Ocupacional é obrigatório.");
        if (string.IsNullOrWhiteSpace(renda))
            throw new ArgumentException("Renda é obrigatório.");
        if (string.IsNullOrWhiteSpace(aposentado))
            throw new ArgumentException("Aposentado é obrigatório.");
        if (string.IsNullOrWhiteSpace(beneficio))
            throw new ArgumentException("Benefício é obrigatório.");
        if (string.IsNullOrWhiteSpace(deficiencia))
            throw new ArgumentException("Deficiência é obrigatório.");
        if (string.IsNullOrWhiteSpace(problemaDeSaude))
            throw new ArgumentException("Problema de Saúde é obrigatório.");
        if (fazAlgumTratamento && string.IsNullOrWhiteSpace(fazAlgumTratamentoOnde))
            throw new ArgumentException("Onde faz tratamento é obrigatório.");*/

        Alfabetizado = alfabetizado;
        EstudaAtualmente = estudaAtualmente;
        NivelSerieAtualConcluido = nivelSerieAtualConcluido.Trim();
        CursosTecnicoFormacaoProfissional = cursosTecnicoFormacaoProfissional.Trim();
        SituacaoOcupacional = situacaoOcupacional.Trim();
        Renda = renda.Trim();
        Aposentado = aposentado.Trim();
        Beneficio = beneficio.Trim();
        Deficiencia = deficiencia.Trim();
        ProblemaDeSaude = problemaDeSaude.Trim();
        FazAlgumTratamento = fazAlgumTratamento;
        FazAlgumTratamentoOnde = fazAlgumTratamentoOnde.Trim();
        UsaMedicamentoControlado = usaMedicamentoControlado;
        UsaRecursosUbsLocal = usaRecursosUbsLocal;
        TrabalhoPastoralOuSocial = trabalhoPastoralOuSocial.Trim();
        AtividadeNaComunidadeSagradaFamilia = atividadeNaComunidadeSagradaFamilia.Trim();
        TrabalhoVoluntario = trabalhoVoluntario.Trim();
        TrabalhoVoluntarioOnde = trabalhoVoluntarioOnde.Trim();
    }
}
