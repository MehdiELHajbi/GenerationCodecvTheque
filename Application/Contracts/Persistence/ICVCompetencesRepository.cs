using Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application
{
    public interface ICVCompetencesRepository : IBaseRepository<CVCompetences>
    {
    #region Generated Custom

    Task<IReadOnlyList<CVCompetences>> SearchAsync(ReadCVCompetencesQuery request);

    #endregion

    }
}
