using Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application
{
    public interface ILanguesRepository : IBaseRepository<Langues>
    {
    #region Generated Custom

    Task<IReadOnlyList<Langues>> SearchAsync(ReadLanguesQuery request);

    #endregion

    }
}
