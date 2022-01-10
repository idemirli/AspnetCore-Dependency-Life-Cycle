using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyLifeTime.Web.Models
{
    public class MyScopedService : IMyScopedService
    {
        public Guid instanceId { get; set; }

        public MyScopedService() : this(Guid.NewGuid())
        {

        }

        public MyScopedService(Guid instanceId)
        {
            this.instanceId = instanceId;
        }


    }
}
