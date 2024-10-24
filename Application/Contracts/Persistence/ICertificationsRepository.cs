using Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application
{
    public interface ICertificationsRepository : IBaseRepository<Certifications>
    {
    #region Generated Custom

    Task<IReadOnlyList<Certifications>> SearchAsync(ReadCertificationsQuery request);

    #endregion

    }
}
