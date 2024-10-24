using System;
using AutoMapper;
using Domain;

namespace Application
{
    public partial class CVLanguesProfile
        : AutoMapper.Profile
    {
        public CVLanguesProfile()
        {
            CreateMap<CVLangues, CreateCVLanguesCommand>().ReverseMap();;

            CreateMap<CVLangues, CreateCVLanguesViewModel>().ReverseMap();;

            CreateMap<CVLangues, UpdateCVLanguesCommand>().ReverseMap();;

            CreateMap<CVLangues, UpdateCVLanguesViewModel>().ReverseMap();;

            CreateMap<CVLangues, DeleteCVLanguesCommand>().ReverseMap();;

            CreateMap<CVLangues, DeleteCVLanguesViewModel>().ReverseMap();;

            CreateMap<CVLangues, ReadCVLanguesQuery>().ReverseMap();;

            CreateMap<CVLangues, ReadCVLanguesViewModel>().ReverseMap();;

        }

    }
}
