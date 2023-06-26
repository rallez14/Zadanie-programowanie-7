const int seconds = 332;
string formattedTime = FormatTime(seconds);
Console.WriteLine(formattedTime);

string FormatTime(int totalSeconds)
{
    int hours = totalSeconds / 3600;
    int minutes = (totalSeconds % 3600) / 60;
    int seconds = totalSeconds % 60;
        
    string formattedHours = hours.ToString("D2");
    string formattedMinutes = minutes.ToString("D2");
    string formattedSeconds = seconds.ToString("D2");
        
    string formattedTime = $"{formattedHours}:{formattedMinutes}:{formattedSeconds}";
    return formattedTime;
}