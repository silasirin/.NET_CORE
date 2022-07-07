using System;

namespace NetCoreTransientScopedSingleton.Models
{
    public interface ISingleton
    {
        Guid GetOperation();
    }
}
