using System.Net.Http.Json;
using Microsoft.JSInterop;
using Sajda.Data;

namespace Sajda.Services;

public class SajdaTimeService(
    HttpClient httpClient,
    IJSRuntime jSRuntime)
{
    public async Task<PrayerResponse> RequestLocation()
    {
        var location = await GetLocationAsync();
        return await GetPrayerTimeOnLocationAsync(location.Latitude, location.Longitude);
    }
    public async Task<Location> GetLocationAsync()
    {
        return await jSRuntime.InvokeAsync<Location>("getUserLocation");
    }
    public async Task<PrayerResponse> GetPrayerTimeOnLocationAsync(double latitude, double longitude)
    {
        string url = $"https://api.aladhan.com/v1/timings?latitude={latitude}&longitude={longitude}&method=2";

        var response = await httpClient.GetFromJsonAsync<PrayerResponse>(url);
        return response!;
    }

    public async Task<PrayerResponse> GetPrayerTimes(string city, string country)
    {
        string url = $"https://api.aladhan.com/v1/timingsByCity?city={city}&country={country}";

        var response = await httpClient.GetFromJsonAsync<PrayerResponse>(url);
        return response!;
    }

    public async Task<Dictionary<string, PrayerResponse>> GetAllPrayerTimes()
    {
        var cities = new List<string>
            {
                "Tashkent",
                "Ferghana",
                "Namangan",
                "Andijan",
                "Sirdarya",
                "Jizzakh",
                "Samarkand",
                "Navoi",
                "Bukhara",
                "Kashkadarya",
                "Surkhandaryo",
                "Khorezm"
            };

        var prayerTimesForAll = new Dictionary<string, PrayerResponse>();

        foreach (var city in cities)
        {
                var response = await GetPrayerTimes(city, "Uzbekistan");
                if (response != null)
                    prayerTimesForAll[city] = response;
        }
        return prayerTimesForAll;
    }
}
