using System;
using AutoMapper;
using Domain;

namespace Application
{
    public partial class ExperiencesProfile
        : AutoMapper.Profile
    {
        public ExperiencesProfile()
        {
            CreateMap<Experiences, CreateExperiencesCommand>().ReverseMap();;

            CreateMap<Experiences, CreateExperiencesViewModel>().ReverseMap();;

            CreateMap<Experiences, UpdateExperiencesCommand>().ReverseMap();;

            CreateMap<Experiences, UpdateExperiencesViewModel>().ReverseMap();;

            CreateMap<Experiences, DeleteExperiencesCommand>().ReverseMap();;

            CreateMap<Experiences, DeleteExperiencesViewModel>().ReverseMap();;

            CreateMap<Experiences, ReadExperiencesQuery>().ReverseMap();;

            CreateMap<Experiences, ReadExperiencesViewModel>().ReverseMap();;

        }

    }
}
