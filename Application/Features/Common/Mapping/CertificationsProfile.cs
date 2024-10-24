using System;
using AutoMapper;
using Domain;

namespace Application
{
    public partial class CertificationsProfile
        : AutoMapper.Profile
    {
        public CertificationsProfile()
        {
            CreateMap<Certifications, CreateCertificationsCommand>().ReverseMap();;

            CreateMap<Certifications, CreateCertificationsViewModel>().ReverseMap();;

            CreateMap<Certifications, UpdateCertificationsCommand>().ReverseMap();;

            CreateMap<Certifications, UpdateCertificationsViewModel>().ReverseMap();;

            CreateMap<Certifications, DeleteCertificationsCommand>().ReverseMap();;

            CreateMap<Certifications, DeleteCertificationsViewModel>().ReverseMap();;

            CreateMap<Certifications, ReadCertificationsQuery>().ReverseMap();;

            CreateMap<Certifications, ReadCertificationsViewModel>().ReverseMap();;

        }

    }
}
