using Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application
{
    public interface IFormationsRepository : IBaseRepository<Formations>
    {
    #region Generated Custom

    Task<IReadOnlyList<Formations>> SearchAsync(ReadFormationsQuery request);

    #endregion

    }
}
