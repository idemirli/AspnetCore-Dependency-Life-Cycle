using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyLifeTime.Web.Models
{
    public class WorkService : IMyScopedService, IMySingletonService, IMyTransientService
    {
        public Guid instanceId { get; set; }
        public WorkService()
        {
            instanceId = Guid.NewGuid();
        }
    }
}
