using Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application
{
    public interface ICVsRepository : IBaseRepository<CVs>
    {
    #region Generated Custom

    Task<IReadOnlyList<CVs>> SearchAsync(ReadCVsQuery request);

    #endregion

    }
}
