using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyLifeTime.Web.Models
{
    public class MyTransientService : IMyTransientService
    {
        public Guid instanceId { get; set; }

        public MyTransientService() : this(Guid.NewGuid())
        {

        }
        public MyTransientService(Guid instanceId)
        {
            this.instanceId = instanceId;
        }
    }
}
