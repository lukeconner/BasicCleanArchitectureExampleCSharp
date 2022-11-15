using TimeZone = Ddp.Domain.Models.TimeZone;

namespace Ddp.App.Interfaces;

public interface IDateTimeService
{
    public DateTime GetLocalDateTime(TimeZone timeZone);
}