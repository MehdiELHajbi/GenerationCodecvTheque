using AutoMapper;
using MediatR;
using Newtonsoft.Json;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using Application;
using System.Collections.Generic;

namespace Application
{

    public class ReadCertificationsQueryHandler : IRequestHandler<ReadCertificationsQuery,IReadOnlyList<ReadCertificationsViewModel>>{
     private readonly ICertificationsRepository _CertificationsRepository;
    private readonly IMapper _mapper;
     public ReadCertificationsQueryHandler(IMapper mapper, ICertificationsRepository CertificationsRepository)
    {
     _mapper = mapper;
     _CertificationsRepository = CertificationsRepository;
     }
     public async Task<IReadOnlyList<ReadCertificationsViewModel>> Handle(ReadCertificationsQuery request, CancellationToken cancellationToken)
    {
    var entity = await _CertificationsRepository.SearchAsync(request);
    IReadOnlyList<ReadCertificationsViewModel> response = null;
    response = _mapper.Map(entity, response);
    return response;
     }
    }
}
