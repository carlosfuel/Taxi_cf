using Taxi_cf.Web.Data.Entities;
using Taxi_cf.Common.Models;

namespace Taxi_cf.Web.Helpers
{
    public interface IConverterHelper
    {
        TaxiResponse ToTaxiResponse(TaxiEntity taxiEntity);
    }
}
