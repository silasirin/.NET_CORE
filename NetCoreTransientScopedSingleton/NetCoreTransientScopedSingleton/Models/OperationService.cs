using System;

namespace NetCoreTransientScopedSingleton.Models
{
    public class OperationService : ITransient, ISingleton, IScoped
    {
        private Guid _id;

        public OperationService()
        {
            _id = Guid.NewGuid();
        }
        public Guid GetOperation()
        {
            return _id;
        }
    }
}
