using Ddp.Repository.Models;

namespace Ddp.Repository.Services;

public static class ContextService
{
    private static DdpContext _db;

    public static DdpContext GetContext()
    {
        return _db ??= new DdpContext();
    }
}