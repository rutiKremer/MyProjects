using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Tools;

public static class LogManager
{
    private static readonly string logDirPath = "Log";

    public static string getTodayDirName()
    {
        string dirPath = @$"{logDirPath}\Log_{DateTime.Now.Year}_{DateTime.Now.Month}";
        if (!Directory.Exists(dirPath))
            Directory.CreateDirectory(dirPath);
        return dirPath;
    }

    public static string getTodayFileName()
    {
        string filePath = @$"{getTodayDirName()}\Log_{DateTime.Now.Year}_{DateTime.Now.Month}_{DateTime.Now.Day}.txt";
        if (!File.Exists(filePath))
            File.Create(filePath).Close();
        return filePath;
    }

    public static void writeToLog(string pjName,string nameFunc, string msg)
    {
        string filePath = getTodayFileName();
        using (StreamWriter sw = new StreamWriter(filePath, true)) 
        {
            sw.WriteLine($"{DateTime.Now}\t{pjName}\t{nameFunc}\t{msg}");
        }
    }

    public static void cleanLogDir()
    {
        DirectoryInfo dir = new DirectoryInfo(logDirPath);
        DirectoryInfo[] directoriesInfo = dir.GetDirectories();
        DateTime dt;
        foreach (DirectoryInfo item in directoriesInfo)
        {
           dt = item.CreationTime;
            if (dt<DateTime.Now.AddMonths(-2))
            {
                    item.Delete();
            }
        }
       
    }

}