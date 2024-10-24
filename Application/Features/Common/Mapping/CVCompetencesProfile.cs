using System;
using AutoMapper;
using Domain;

namespace Application
{
    public partial class CVCompetencesProfile
        : AutoMapper.Profile
    {
        public CVCompetencesProfile()
        {
            CreateMap<CVCompetences, CreateCVCompetencesCommand>().ReverseMap();;

            CreateMap<CVCompetences, CreateCVCompetencesViewModel>().ReverseMap();;

            CreateMap<CVCompetences, UpdateCVCompetencesCommand>().ReverseMap();;

            CreateMap<CVCompetences, UpdateCVCompetencesViewModel>().ReverseMap();;

            CreateMap<CVCompetences, DeleteCVCompetencesCommand>().ReverseMap();;

            CreateMap<CVCompetences, DeleteCVCompetencesViewModel>().ReverseMap();;

            CreateMap<CVCompetences, ReadCVCompetencesQuery>().ReverseMap();;

            CreateMap<CVCompetences, ReadCVCompetencesViewModel>().ReverseMap();;

        }

    }
}
