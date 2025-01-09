namespace Sajda.Data;

public class Location
{
    public double Longitude { get; set; }
    public double Latitude { get; set; }
}

public class PrayerResponse
{
    public int Code { get; set; }
    public string? Status { get; set; }
    public PrayerData? Data { get; set; }
}

public class PrayerData
{
    public Timings? Timings { get; set; }
    public DateInfo? Date { get; set; }
    public MetaInfo? Meta { get; set; }
}

public class Timings
{
    public string? Fajr { get; set; }
    public string? Sunrise { get; set; }
    public string? Dhuhr { get; set; }
    public string? Asr { get; set; }
    public string? Sunset { get; set; }
    public string? Maghrib { get; set; }
    public string? Isha { get; set; }
    public string? Imsak { get; set; }
    public string? Midnight { get; set; }
    public string? Firstthird { get; set; }
    public string? Lastthird { get; set; }
}

public class DateInfo
{
    public string? Readable { get; set; }
    public long Timestamp { get; set; }
    public Hijri? Hijri { get; set; }
    public Gregorian? Gregorian { get; set; }
}

public class Hijri
{
    public string? Date { get; set; }
    public string? Format { get; set; }
    public string? Day { get; set; }
    public Weekday? Weekday { get; set; }
    public Month? Month { get; set; }
    public string? Year { get; set; }
    public Designation? Designation { get; set; }
}

public class Gregorian
{
    public string? Date { get; set; }
    public string? Format { get; set; }
    public string? Day { get; set; }
    public Weekday? Weekday { get; set; }
    public Month? Month { get; set; }
    public string? Year { get; set; }
    public Designation? Designation { get; set; }
    public bool LunarSighting { get; set; }
}

public class Weekday
{
    public string? En { get; set; }
    public string? Ar { get; set; }
}

public class Month
{
    public int Number { get; set; }
    public string? En { get; set; }
    public string? Ar { get; set; }
    public int Days { get; set; }
}

public class Designation
{
    public string? Abbreviated { get; set; }
    public string? Expanded { get; set; }
}

public class MetaInfo
{
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public string? Timezone { get; set; }
    public Method? Method { get; set; }
    public string? LatitudeAdjustmentMethod { get; set; }
    public string? MidnightMode { get; set; }
    public string? School { get; set; }
    public Offset? Offset { get; set; }
}

public class Method
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public MethodParams? Params { get; set; }
    public Location? Location { get; set; }
}

public class MethodParams
{
    public double Fajr { get; set; }
    public double Isha { get; set; }
    public double Maghrib { get; set; }
    public string? Midnight { get; set; }
}
public class Offset
{
    public int Imsak { get; set; }
    public int Fajr { get; set; }
    public int Sunrise { get; set; }
    public int Dhuhr { get; set; }
    public int Asr { get; set; }
    public int Maghrib { get; set; }
    public int Sunset { get; set; }
    public int Isha { get; set; }
    public int Midnight { get; set; }
}
