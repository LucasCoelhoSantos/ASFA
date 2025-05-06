namespace ASFA.Models.DTOs;

public class DependenteDataGridViewDTO
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public DateTime DataNascimento { get; set; }
    public string Parentesco { get; set; }
    public bool Ativo { get; set; }
    public ComposicaoFamiliar ComposicaoFamiliar { get; set; }

    // Propriedades auxiliares
    public string Renda => ComposicaoFamiliar?.Renda;
    public string SituacaoOcupacional => ComposicaoFamiliar?.SituacaoOcupacional;
    public bool Alfabetizado => ComposicaoFamiliar.Alfabetizado;
    public string Aposentado => ComposicaoFamiliar?.Aposentado;
    public string Deficiencia => ComposicaoFamiliar?.Deficiencia;
    public string ProblemaDeSaude => ComposicaoFamiliar?.ProblemaDeSaude;
}
