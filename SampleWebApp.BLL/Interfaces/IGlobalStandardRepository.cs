using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleWebApp.BLL.Interfaces
{
    public interface IStandardRepository<TEntity> : IReadOnlyRepository<TEntity>, ICanDelete<TEntity>, ICanSave<TEntity>
    { }
}
