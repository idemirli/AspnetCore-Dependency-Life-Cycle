using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyLifeTime.Web.Models
{
    public class AllManagementService
    {
        public IMyTransientService _transientService { get; set; }
        public IMyScopedService _scopedService { get; set; }
        public IMySingletonService _singletonService { get; set; }
        public AllManagementService(IMyTransientService myTransientService,IMyScopedService myScopedService,IMySingletonService mySingletonService)
        {
            _transientService = myTransientService;
            _scopedService = myScopedService;
            _singletonService = mySingletonService;

        }
    }
}
