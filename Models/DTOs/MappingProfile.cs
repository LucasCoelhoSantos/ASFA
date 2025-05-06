using AutoMapper;

namespace ASFA.Models.DTOs;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<PessoaIdosaDataGridViewDTO, PessoaIdosa>();
        CreateMap<PessoaIdosa, PessoaIdosaDataGridViewDTO>();

        CreateMap<PessoaIdosaFichaDTO, PessoaIdosa>();
        CreateMap<PessoaIdosa, PessoaIdosaFichaDTO>();

        CreateMap<DependenteDataGridViewDTO, Dependente>();
        CreateMap<Dependente, DependenteDataGridViewDTO>();
    }
}
