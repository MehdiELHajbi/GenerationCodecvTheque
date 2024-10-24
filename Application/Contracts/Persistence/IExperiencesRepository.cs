using Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application
{
    public interface IExperiencesRepository : IBaseRepository<Experiences>
    {
    #region Generated Custom

    Task<IReadOnlyList<Experiences>> SearchAsync(ReadExperiencesQuery request);

    #endregion

    }
}
