using System.Threading.Tasks;
using Taxi_cf.Common.Models;

namespace Taxi_cf.Common.Services
{
    public interface IApiService
    {
        Task<Response> GetTaxiAsync(string plaque, string urlBase, string servicePrefix, string controller);
    }
}
