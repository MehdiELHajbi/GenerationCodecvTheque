using System;
using AutoMapper;
using Domain;

namespace Application
{
    public partial class CVsProfile
        : AutoMapper.Profile
    {
        public CVsProfile()
        {
            CreateMap<CVs, CreateCVsCommand>().ReverseMap();;

            CreateMap<CVs, CreateCVsViewModel>().ReverseMap();;

            CreateMap<CVs, UpdateCVsCommand>().ReverseMap();;

            CreateMap<CVs, UpdateCVsViewModel>().ReverseMap();;

            CreateMap<CVs, DeleteCVsCommand>().ReverseMap();;

            CreateMap<CVs, DeleteCVsViewModel>().ReverseMap();;

            CreateMap<CVs, ReadCVsQuery>().ReverseMap();;

            CreateMap<CVs, ReadCVsViewModel>().ReverseMap();;

        }

    }
}
