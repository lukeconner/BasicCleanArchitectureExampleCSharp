using Ddp.App.Interfaces;
using TimeZone = Ddp.Domain.Models.TimeZone;

namespace Ddp.Shared.Services;

public class DateTimeService : IDateTimeService
{
    public DateTime GetLocalDateTime(TimeZone timeZone)
    {
        TimeZoneInfo time;
            
        if (timeZone == null || timeZone.Id == 0)
        {
            try
            {
                time = TimeZoneInfo.FindSystemTimeZoneById("US Mountain Standard Time");
            }
            catch
            {
                time = TimeZoneInfo.FindSystemTimeZoneById("America / Phoenix");
            }

            return TimeZoneInfo.ConvertTime(DateTime.Now, time);
        }
        else
        {
            try
            {
                time = TimeZoneInfo.FindSystemTimeZoneById(timeZone.Name);
            }
            catch
            {
                time = TimeZoneInfo.FindSystemTimeZoneById(timeZone.NixName);
            }

            return TimeZoneInfo.ConvertTime(DateTime.Now, time);
        }
    }
}