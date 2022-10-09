using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging.Abstractions;

namespace Infrastructure.Test.Caching;

public class LocalCacheService : CacheService<Pet.Social.Network.Infrastructure.Caching.LocalCacheService>
{
    protected override Pet.Social.Network.Infrastructure.Caching.LocalCacheService CreateCacheService() =>
        new(
            new MemoryCache(new MemoryCacheOptions()),
            NullLogger<Pet.Social.Network.Infrastructure.Caching.LocalCacheService>.Instance);
}