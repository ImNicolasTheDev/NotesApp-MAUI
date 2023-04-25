namespace Notes.Models;

internal class About
{
    public string Title => AppInfo.Name;
    public string Version => AppInfo.VersionString;
    public string MoreInfoUrl => "https://github.com/ImNicolasTheDev";
    public string Message => "Developed by ImNicolasTheDev (thanks to Microsoft).";
}