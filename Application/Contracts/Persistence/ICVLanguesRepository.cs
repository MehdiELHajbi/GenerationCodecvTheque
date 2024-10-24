using Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application
{
    public interface ICVLanguesRepository : IBaseRepository<CVLangues>
    {
    #region Generated Custom

    Task<IReadOnlyList<CVLangues>> SearchAsync(ReadCVLanguesQuery request);

    #endregion

    }
}
