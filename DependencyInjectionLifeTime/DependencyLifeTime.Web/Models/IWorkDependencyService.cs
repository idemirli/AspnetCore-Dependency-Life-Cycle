using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyLifeTime.Web.Models
{
    public interface IWorkDependencyService
    {
         Guid instanceId { get; set; }
    }
}
