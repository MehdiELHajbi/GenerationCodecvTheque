using System;
using AutoMapper;
using Domain;

namespace Application
{
    public partial class ReferencesContactProfile
        : AutoMapper.Profile
    {
        public ReferencesContactProfile()
        {
            CreateMap<ReferencesContact, CreateReferencesContactCommand>().ReverseMap();;

            CreateMap<ReferencesContact, CreateReferencesContactViewModel>().ReverseMap();;

            CreateMap<ReferencesContact, UpdateReferencesContactCommand>().ReverseMap();;

            CreateMap<ReferencesContact, UpdateReferencesContactViewModel>().ReverseMap();;

            CreateMap<ReferencesContact, DeleteReferencesContactCommand>().ReverseMap();;

            CreateMap<ReferencesContact, DeleteReferencesContactViewModel>().ReverseMap();;

            CreateMap<ReferencesContact, ReadReferencesContactQuery>().ReverseMap();;

            CreateMap<ReferencesContact, ReadReferencesContactViewModel>().ReverseMap();;

        }

    }
}
