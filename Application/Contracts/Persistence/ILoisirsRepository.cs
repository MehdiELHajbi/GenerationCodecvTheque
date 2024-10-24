using Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application
{
    public interface ILoisirsRepository : IBaseRepository<Loisirs>
    {
    #region Generated Custom

    Task<IReadOnlyList<Loisirs>> SearchAsync(ReadLoisirsQuery request);

    #endregion

    }
}
