using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleWebApp.BLL.Interfaces
{
    public interface IStandardLogRepository<TEntity> : IStandardRepository<TEntity>, ICanSaveWithLog<TEntity>, ICanCreate<TEntity>
    { }
}
