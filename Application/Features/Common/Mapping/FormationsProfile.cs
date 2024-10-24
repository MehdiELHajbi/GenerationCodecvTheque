using System;
using AutoMapper;
using Domain;

namespace Application
{
    public partial class FormationsProfile
        : AutoMapper.Profile
    {
        public FormationsProfile()
        {
            CreateMap<Formations, CreateFormationsCommand>().ReverseMap();;

            CreateMap<Formations, CreateFormationsViewModel>().ReverseMap();;

            CreateMap<Formations, UpdateFormationsCommand>().ReverseMap();;

            CreateMap<Formations, UpdateFormationsViewModel>().ReverseMap();;

            CreateMap<Formations, DeleteFormationsCommand>().ReverseMap();;

            CreateMap<Formations, DeleteFormationsViewModel>().ReverseMap();;

            CreateMap<Formations, ReadFormationsQuery>().ReverseMap();;

            CreateMap<Formations, ReadFormationsViewModel>().ReverseMap();;

        }

    }
}
