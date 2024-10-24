using Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application
{
    public interface ILogsRepository : IBaseRepository<Logs>
    {
    #region Generated Custom

    Task<IReadOnlyList<Logs>> SearchAsync(ReadLogsQuery request);

    #endregion

    }
}
