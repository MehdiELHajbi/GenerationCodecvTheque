using System;
using AutoMapper;
using Domain;

namespace Application
{
    public partial class LoisirsProfile
        : AutoMapper.Profile
    {
        public LoisirsProfile()
        {
            CreateMap<Loisirs, CreateLoisirsCommand>().ReverseMap();;

            CreateMap<Loisirs, CreateLoisirsViewModel>().ReverseMap();;

            CreateMap<Loisirs, UpdateLoisirsCommand>().ReverseMap();;

            CreateMap<Loisirs, UpdateLoisirsViewModel>().ReverseMap();;

            CreateMap<Loisirs, DeleteLoisirsCommand>().ReverseMap();;

            CreateMap<Loisirs, DeleteLoisirsViewModel>().ReverseMap();;

            CreateMap<Loisirs, ReadLoisirsQuery>().ReverseMap();;

            CreateMap<Loisirs, ReadLoisirsViewModel>().ReverseMap();;

        }

    }
}
