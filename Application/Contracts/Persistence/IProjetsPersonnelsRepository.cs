using Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application
{
    public interface IProjetsPersonnelsRepository : IBaseRepository<ProjetsPersonnels>
    {
    #region Generated Custom

    Task<IReadOnlyList<ProjetsPersonnels>> SearchAsync(ReadProjetsPersonnelsQuery request);

    #endregion

    }
}
