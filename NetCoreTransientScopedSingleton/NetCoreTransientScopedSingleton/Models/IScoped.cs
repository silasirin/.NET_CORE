using System;

namespace NetCoreTransientScopedSingleton.Models
{
    public interface IScoped
    {
        Guid GetOperation();
    }
}
