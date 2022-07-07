using System;

namespace NetCoreTransientScopedSingleton.Models
{
    public interface ITransient
    {
        Guid GetOperation();
    }
}
