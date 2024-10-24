using System;
using AutoMapper;
using Domain;

namespace Application
{
    public partial class ProjetsPersonnelsProfile
        : AutoMapper.Profile
    {
        public ProjetsPersonnelsProfile()
        {
            CreateMap<ProjetsPersonnels, CreateProjetsPersonnelsCommand>().ReverseMap();;

            CreateMap<ProjetsPersonnels, CreateProjetsPersonnelsViewModel>().ReverseMap();;

            CreateMap<ProjetsPersonnels, UpdateProjetsPersonnelsCommand>().ReverseMap();;

            CreateMap<ProjetsPersonnels, UpdateProjetsPersonnelsViewModel>().ReverseMap();;

            CreateMap<ProjetsPersonnels, DeleteProjetsPersonnelsCommand>().ReverseMap();;

            CreateMap<ProjetsPersonnels, DeleteProjetsPersonnelsViewModel>().ReverseMap();;

            CreateMap<ProjetsPersonnels, ReadProjetsPersonnelsQuery>().ReverseMap();;

            CreateMap<ProjetsPersonnels, ReadProjetsPersonnelsViewModel>().ReverseMap();;

        }

    }
}
