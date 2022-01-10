using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyLifeTime.Web.Models
{
    public class MySingletonService : IMySingletonService
    {
        public Guid instanceId { get; set; }

        public MySingletonService() : this(Guid.NewGuid())
        {

        }
        public MySingletonService(Guid instanceId)
        {
            this.instanceId = instanceId;
        }
    }
}
