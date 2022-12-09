// Decompiled with JetBrains decompiler
// Type: SC4Tool.sr_DirBrowser
// Assembly: SC4Tool, Version=2.2.7.0, Culture=neutral, PublicKeyToken=null
// MVID: 69A50BC4-87A5-4C5E-BEFC-08274BC6D498
// Assembly location: C:\Program Files (x86)\SC4 Utilities\SC4Tool\SC4Tool.exe

using Microsoft.VisualBasic.CompilerServices;
using System.Collections;
using System.IO;

namespace SC4Tool
{
  public class sr_DirBrowser
  {
    public static ArrayList ResultArray = new ArrayList();
    public static string SuchMuster;
    public static bool ZielGefunden;
    public static string ZielDir;

    public static string SearchOneFile(string StartDir, string SuchDatei)
    {
      sr_DirBrowser.ZielDir = "";
      sr_DirBrowser.ZielGefunden = false;
      sr_DirBrowser.ProcessDirectoryA(StartDir, SuchDatei);
      return sr_DirBrowser.ZielDir;
    }

    public static object ProcessDirectoryA(string targetDirectory, string SuchDatei)
    {
      string[] files = Directory.GetFiles(targetDirectory, SuchDatei);
      if (!sr_DirBrowser.ZielGefunden)
      {
        string[] strArray = files;
        int index1 = 0;
        if (index1 < strArray.Length)
        {
          string str = strArray[index1];
          sr_DirBrowser.ZielGefunden = true;
          sr_DirBrowser.ZielDir = targetDirectory;
        }
        else
        {
          string[] directories = Directory.GetDirectories(targetDirectory);
          int index2 = 0;
          while (index2 < directories.Length)
          {
            string targetDirectory1 = directories[index2];
            if (!sr_DirBrowser.ZielGefunden)
            {
              sr_DirBrowser.ProcessDirectoryA(targetDirectory1, SuchDatei);
              checked { ++index2; }
            }
            else
              break;
          }
        }
      }
      object obj;
      return obj;
    }

    public static ArrayList StartRead(string StartDir, string SearchPattern)
    {
      sr_DirBrowser.ProcessDirectory(StartDir, SearchPattern);
      return sr_DirBrowser.ResultArray;
    }

    public static ArrayList ProcessDirectory(string targetDirectory, string SearchPattern)
    {
      string[] files = Directory.GetFiles(targetDirectory, SearchPattern);
      int index1 = 0;
      while (index1 < files.Length)
      {
        sr_DirBrowser.ProcessFile(files[index1]);
        checked { ++index1; }
      }
      string[] directories = Directory.GetDirectories(targetDirectory);
      int index2 = 0;
      while (index2 < directories.Length)
      {
        sr_DirBrowser.ProcessDirectory(directories[index2], SearchPattern);
        checked { ++index2; }
      }
      ArrayList arrayList;
      return arrayList;
    }

    public static object StartRead(string StartDir, ArrayList PatternList, ref ArrayList Array1)
    {
      int num = checked (PatternList.Count - 1);
      int index = 0;
      while (index <= num)
      {
        sr_DirBrowser.ProcessDirectory(StartDir, StringType.FromObject(PatternList[index]), ref Array1);
        checked { ++index; }
      }
      return (object) sr_DirBrowser.ResultArray;
    }

    public static ArrayList ProcessDirectory(
      string targetDirectory,
      string SearchPattern,
      ref ArrayList Array1)
    {
      string[] directories = Directory.GetDirectories(targetDirectory);
      string[] files = Directory.GetFiles(targetDirectory, SearchPattern);
      int index1 = 0;
      while (index1 < files.Length)
      {
        FileInfo fileInfo = new FileInfo(files[index1]);
        Array1.Add((object) fileInfo.FullName);
        checked { ++index1; }
      }
      string[] strArray = directories;
      int index2 = 0;
      while (index2 < strArray.Length)
      {
        sr_DirBrowser.ProcessDirectory(strArray[index2], SearchPattern, ref Array1);
        checked { ++index2; }
      }
      ArrayList arrayList;
      return arrayList;
    }

    public static object ProcessFile(string path)
    {
      FileInfo fileInfo = new FileInfo(path);
      sr_DirBrowser.ResultArray.Add((object) fileInfo.FullName);
      object obj;
      return obj;
    }
  }
}
