using System;
using AutoMapper;
using Domain;

namespace Application
{
    public partial class LanguesProfile
        : AutoMapper.Profile
    {
        public LanguesProfile()
        {
            CreateMap<Langues, CreateLanguesCommand>().ReverseMap();;

            CreateMap<Langues, CreateLanguesViewModel>().ReverseMap();;

            CreateMap<Langues, UpdateLanguesCommand>().ReverseMap();;

            CreateMap<Langues, UpdateLanguesViewModel>().ReverseMap();;

            CreateMap<Langues, DeleteLanguesCommand>().ReverseMap();;

            CreateMap<Langues, DeleteLanguesViewModel>().ReverseMap();;

            CreateMap<Langues, ReadLanguesQuery>().ReverseMap();;

            CreateMap<Langues, ReadLanguesViewModel>().ReverseMap();;

        }

    }
}
