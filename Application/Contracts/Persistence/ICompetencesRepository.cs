using Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application
{
    public interface ICompetencesRepository : IBaseRepository<Competences>
    {
    #region Generated Custom

    Task<IReadOnlyList<Competences>> SearchAsync(ReadCompetencesQuery request);

    #endregion

    }
}
