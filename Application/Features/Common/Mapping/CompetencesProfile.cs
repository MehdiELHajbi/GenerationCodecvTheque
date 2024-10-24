using System;
using AutoMapper;
using Domain;

namespace Application
{
    public partial class CompetencesProfile
        : AutoMapper.Profile
    {
        public CompetencesProfile()
        {
            CreateMap<Competences, CreateCompetencesCommand>().ReverseMap();;

            CreateMap<Competences, CreateCompetencesViewModel>().ReverseMap();;

            CreateMap<Competences, UpdateCompetencesCommand>().ReverseMap();;

            CreateMap<Competences, UpdateCompetencesViewModel>().ReverseMap();;

            CreateMap<Competences, DeleteCompetencesCommand>().ReverseMap();;

            CreateMap<Competences, DeleteCompetencesViewModel>().ReverseMap();;

            CreateMap<Competences, ReadCompetencesQuery>().ReverseMap();;

            CreateMap<Competences, ReadCompetencesViewModel>().ReverseMap();;

        }

    }
}
