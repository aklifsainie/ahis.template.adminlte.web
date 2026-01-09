using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ahis.template.adminlte.domain.Interfaces.Endpoints
{
    public interface IGenericEndpoint<R> where R : class
    {
        Task<List<R>> GetListAsync();
        Task<R> GetByIdAsync(R request);
        Task<R> PostAsync(R request);
    }
}
