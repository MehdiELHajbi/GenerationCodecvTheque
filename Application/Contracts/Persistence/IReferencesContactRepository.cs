using Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application
{
    public interface IReferencesContactRepository : IBaseRepository<ReferencesContact>
    {
    #region Generated Custom

    Task<IReadOnlyList<ReferencesContact>> SearchAsync(ReadReferencesContactQuery request);

    #endregion

    }
}
