// Decompiled with JetBrains decompiler
// Type: SC4Tool.MainFunctionClass
// Assembly: SC4Tool, Version=2.2.7.0, Culture=neutral, PublicKeyToken=null
// MVID: 69A50BC4-87A5-4C5E-BEFC-08274BC6D498
// Assembly location: C:\Program Files (x86)\SC4 Utilities\SC4Tool\SC4Tool.exe

using C1.Win.C1FlexGrid;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using sr_SC4Lib;
using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SC4Tool
{
  public class MainFunctionClass
  {
    public static object SaveToHTML(Form AusgabeForm, C1.Win.C1FlexGrid.C1FlexGrid LeseGrid)
    {
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      saveFileDialog.Filter = "htm (*.htm)|*.htm";
      saveFileDialog.InitialDirectory = ClassThisProg.DefReader.ExportDir;
      saveFileDialog.CheckPathExists = true;
      saveFileDialog.CheckFileExists = false;
      saveFileDialog.AddExtension = true;
      saveFileDialog.Title = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[18]);
      if (saveFileDialog.ShowDialog() == DialogResult.OK)
      {
        if (AllgemeineKlasse.FlexToHTML(LeseGrid, saveFileDialog.FileName, ""))
        {
          int num1 = (int) MessageBox.Show((IWin32Window) AusgabeForm, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[65]), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[17]), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        else
        {
          int num2 = (int) MessageBox.Show((IWin32Window) AusgabeForm, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[64]), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[17]), MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
      }
      object obj;
      return obj;
    }

    public static object GebeNameAus(C1.Win.C1FlexGrid.C1FlexGrid AusgabeGrid, string AusgabeName)
    {
      C1.Win.C1FlexGrid.C1FlexGrid c1FlexGrid = AusgabeGrid;
      c1FlexGrid.Rows.Add();
      c1FlexGrid.Rows.Add();
      AusgabeGrid[checked (c1FlexGrid.Rows.Count - 2), 0] = (object) AusgabeName;
      object obj;
      return obj;
    }

    public static object GebePropertyAus(
      C1.Win.C1FlexGrid.C1FlexGrid AusgabeGrid,
      MainReader.ExemplarValues ExemplarProp,
      sr_PropertyXMLReader PropXMLReader,
      string LeseDatei,
      int MainSpalte)
    {
      ArrayList arrayList1 = new ArrayList();
      ArrayList arrayList2 = new ArrayList();
      C1.Win.C1FlexGrid.C1FlexGrid c1FlexGrid = AusgabeGrid;
      bool flag = false;
      sr_PropertyXMLReader.PropSet row = PropXMLReader.GetRow(ExemplarProp.Kennung, ExemplarProp.Typ);
      string str1 = row.Name.Replace("LotConfigProperty", "").Replace("LotConfig", "");
      int count = c1FlexGrid.Rows.Count;
      int StartCol = checked (MainSpalte + 1);
      int num1 = StartCol;
      arrayList1.Clear();
      string upper = ExemplarProp.Kennung.ToUpper();
      if (StringType.StrCmp(upper, "0X8A416A99", false) == 0 || StringType.StrCmp(upper, "0XCA416AB5", false) == 0)
      {
        string EingabeDatei = LeseDatei;
        int num2 = -1;
        ref int local = ref num2;
        MainReader.ExemplarValues ExemplarProp1 = ExemplarProp;
        string ltext = AllgemeineKlasse.GetLText(EingabeDatei, ref local, ExemplarProp1);
        if (StringType.StrCmp(ltext, "", false) != 0)
        {
          c1FlexGrid.Rows.Add();
          CellRange cellRange = c1FlexGrid.GetCellRange(checked (c1FlexGrid.Rows.Count - 1), checked (MainSpalte + 1), checked (c1FlexGrid.Rows.Count - 1), checked (c1FlexGrid.Cols.Count - 1));
          cellRange.Style = c1FlexGrid.Styles["LeftText"];
          cellRange.Data = (object) ltext;
          c1FlexGrid.Rows[checked (c1FlexGrid.Rows.Count - 1)].AllowMerging = true;
          flag = true;
        }
      }
      else if (StringType.StrCmp(upper, "0XE90E25A1", false) == 0)
      {
        AllgemeineKlasse.ShowTransitSwitchWerte(ExemplarProp, ClassThisProg.DefReader.LanguageArray, AusgabeGrid, StartCol);
        flag = true;
      }
      else if (StringType.StrCmp(upper, "0X8A2602B8", false) == 0)
      {
        C1.Win.C1FlexGrid.C1FlexGrid AusgabeGrid1 = AusgabeGrid;
        string EingabeDatei = LeseDatei;
        int num3 = -1;
        ref int local = ref num3;
        MainReader.ExemplarValues ExemplarProp2 = ExemplarProp;
        int Spalte = checked (MainSpalte + 1);
        flag = MainFunctionClass.ShowItemIcon(AusgabeGrid1, EingabeDatei, ref local, ExemplarProp2, Spalte, true);
      }
      else if (StringType.StrCmp(upper, "0X4A4A88F0", false) == 0)
      {
        c1FlexGrid.Rows.Add();
        MainFunctionClass.ShowRequiredRoads(AusgabeGrid, ExemplarProp.OriginalWerte[0].ToString().ToUpper(), checked (c1FlexGrid.Rows.Count - 1), checked (MainSpalte + 1));
        flag = true;
      }
      else if (StringType.StrCmp(upper, "0X88EDC798", false) == 0)
      {
        if (ExemplarProp.OriginalWerte.Count > 0)
        {
          c1FlexGrid.Rows.Add();
          int num4 = checked (ExemplarProp.OriginalWerte.Count - 1);
          int index = 0;
          while (index <= num4)
          {
            if (num1 == checked (c1FlexGrid.Cols.Count - 1))
            {
              c1FlexGrid.Rows.Add();
              num1 = StartCol;
            }
            MainFunctionClass.ShowRetainingWalls(AusgabeGrid, ExemplarProp.OriginalWerte[index].ToString().ToUpper(), checked (c1FlexGrid.Rows.Count - 1), num1);
            checked { ++num1; }
            checked { ++index; }
          }
          flag = true;
        }
      }
      else if (StringType.StrCmp(upper, "0X88EDC790", false) == 0 && ExemplarProp.OriginalWerte.Count == 2)
      {
        string str2 = ExemplarProp.Werte[0].ToString() + " x " + ExemplarProp.Werte[1].ToString();
        c1FlexGrid.Rows.Add();
        AusgabeGrid[checked (c1FlexGrid.Rows.Count - 1), num1] = (object) str2;
        flag = true;
      }
      CellRange cellRange1;
      if (!flag)
      {
        if (row.SubValue.Count > 0)
        {
          int num5 = checked (row.SubValue.Count - 1);
          int index = 0;
          while (index <= num5)
          {
            if (row.SubValue[index].ToString().ToUpper().StartsWith("COL:"))
              arrayList1.Add((object) row.SubValue[index].ToString().ToUpper().Replace("COL:", ""));
            else
              arrayList1.Add((object) row.SubValue[index].ToString().ToUpper());
            checked { ++index; }
          }
        }
        int col = StartCol;
        if (arrayList1.Count > 0)
        {
          if (Information.IsNumeric(RuntimeHelpers.GetObjectValue(arrayList1[0])))
          {
            c1FlexGrid.Rows.Add();
            c1FlexGrid.Rows.Add();
            AusgabeGrid[checked (c1FlexGrid.Rows.Count - 2), MainSpalte] = (object) str1;
            c1FlexGrid.GetCellRange(checked (c1FlexGrid.Rows.Count - 2), MainSpalte).Style = c1FlexGrid.Styles["TopText"];
            int num6 = checked (arrayList1.Count - 1);
            int index1 = 0;
            while (index1 <= num6)
            {
              if (col == checked (c1FlexGrid.Cols.Count - 1))
              {
                c1FlexGrid.Rows.Add();
                c1FlexGrid.Rows.Add();
                col = StartCol;
              }
              string str3 = StringType.FromObject(row.SubName[index1]);
              AusgabeGrid[checked (c1FlexGrid.Rows.Count - 2), col] = (object) str3;
              cellRange1 = c1FlexGrid.GetCellRange(checked (c1FlexGrid.Rows.Count - 2), col);
              cellRange1.Style = c1FlexGrid.Styles["TopText"];
              string str4 = "";
              if (Information.IsNumeric(RuntimeHelpers.GetObjectValue(arrayList1[index1])))
              {
                int index2 = IntegerType.FromObject(arrayList1[index1]);
                if (index2 <= checked (ExemplarProp.Werte.Count - 1))
                {
                  str4 = StringType.FromObject(ExemplarProp.Werte[index2]);
                  if (StringType.StrCmp(row.Type.ToUpper(), "UINT32", false) == 0 && row.ShowAsHex)
                    str4 = StringType.FromObject(ExemplarProp.OriginalWerte[index2]);
                }
              }
              AusgabeGrid[checked (c1FlexGrid.Rows.Count - 1), col] = (object) str4;
              checked { ++col; }
              checked { ++index1; }
            }
          }
          else
          {
            c1FlexGrid.Rows.Add();
            AusgabeGrid[checked (c1FlexGrid.Rows.Count - 1), MainSpalte] = (object) str1;
            if (StringType.StrCmp(row.Count.ToString(), "-2", false) == 0)
            {
              AusgabeGrid.Rows.Insert(c1FlexGrid.Rows.Count);
              int num7 = checked (ExemplarProp.Werte.Count - 1);
              int index3 = 0;
              while (index3 <= num7)
              {
                if (checked (index3 + 1) <= checked (ExemplarProp.Werte.Count - 1))
                {
                  if (col == checked (c1FlexGrid.Cols.Count - 1))
                  {
                    c1FlexGrid.Rows.Add();
                    c1FlexGrid.Rows.Add();
                    col = StartCol;
                  }
                  int index4 = arrayList1.IndexOf((object) ExemplarProp.OriginalWerte[index3].ToString().ToUpper());
                  string str5 = index4 <= -1 ? StringType.FromObject(ExemplarProp.OriginalWerte[index3]) : StringType.FromObject(row.SubName[index4]);
                  AusgabeGrid[checked (c1FlexGrid.Rows.Count - 2), col] = (object) str5;
                  c1FlexGrid.GetCellRange(checked (c1FlexGrid.Rows.Count - 2), col).Style = c1FlexGrid.Styles["TopText"];
                  string str6 = StringType.FromObject(ExemplarProp.Werte[checked (index3 + 1)]);
                  AusgabeGrid[checked (c1FlexGrid.Rows.Count - 1), col] = (object) str6;
                  checked { ++col; }
                  checked { ++index3; }
                }
                checked { ++index3; }
              }
            }
            else
            {
              int num8 = checked (ExemplarProp.Werte.Count - 1);
              int index5 = 0;
              while (index5 <= num8)
              {
                int index6 = arrayList1.IndexOf((object) ExemplarProp.OriginalWerte[index5].ToString().ToUpper());
                string str7 = index6 <= -1 ? StringType.FromObject(ExemplarProp.OriginalWerte[index5]) : StringType.FromObject(row.SubName[index6]);
                if (col == checked (c1FlexGrid.Cols.Count - 1))
                {
                  c1FlexGrid.Rows.Add();
                  AusgabeGrid.Rows.Insert(c1FlexGrid.Rows.Count);
                  col = StartCol;
                }
                AusgabeGrid[checked (c1FlexGrid.Rows.Count - 1), col] = (object) str7;
                checked { ++col; }
                checked { ++index5; }
              }
            }
          }
        }
        else
        {
          c1FlexGrid.Rows.Add();
          AusgabeGrid[checked (c1FlexGrid.Rows.Count - 1), MainSpalte] = (object) str1;
          ArrayList arrayList3 = (ArrayList) ExemplarProp.Werte.Clone();
          if (StringType.StrCmp(row.Type.ToUpper(), "UINT32", false) == 0 && row.ShowAsHex)
            arrayList3 = (ArrayList) ExemplarProp.OriginalWerte.Clone();
          int num9 = checked (arrayList3.Count - 1);
          int index = 0;
          while (index <= num9)
          {
            if (col == checked (c1FlexGrid.Cols.Count - 1))
            {
              c1FlexGrid.Rows.Add();
              col = StartCol;
            }
            string str8 = arrayList3[index].ToString();
            if (StringType.StrCmp(row.Type.ToUpper(), "STRING", false) == 0)
            {
              cellRange1 = c1FlexGrid.GetCellRange(checked (c1FlexGrid.Rows.Count - 1), checked (MainSpalte + 1), checked (c1FlexGrid.Rows.Count - 1), checked (c1FlexGrid.Cols.Count - 1));
              cellRange1.Style = c1FlexGrid.Styles["LeftText"];
              cellRange1.Data = (object) str8;
              c1FlexGrid.Rows[checked (c1FlexGrid.Rows.Count - 1)].AllowMerging = true;
              col = checked (c1FlexGrid.Cols.Count - 1);
            }
            else
              AusgabeGrid[checked (c1FlexGrid.Rows.Count - 1), col] = (object) str8;
            checked { ++col; }
            checked { ++index; }
          }
        }
      }
      if (c1FlexGrid.Rows.Count > 0)
      {
        cellRange1 = c1FlexGrid.GetCellRange(count, MainSpalte, checked (c1FlexGrid.Rows.Count - 1), MainSpalte);
        cellRange1.Style = c1FlexGrid.Styles["BoldText"];
        cellRange1.Data = (object) str1;
        c1FlexGrid.Cols[MainSpalte].AllowMerging = true;
      }
      object obj;
      return obj;
    }

    public static bool ShowItemIcon(
      C1.Win.C1FlexGrid.C1FlexGrid AusgabeGrid,
      string EingabeDatei,
      ref int CurrentIndex,
      MainReader.ExemplarValues ExemplarProp,
      int Spalte,
      bool Spawn)
    {
      MemoryStream memoryStream = new MemoryStream();
      bool flag = false;
      C1.Win.C1FlexGrid.C1FlexGrid c1FlexGrid = AusgabeGrid;
      try
      {
        byte[] bytesOfIndex = AllgemeineKlasse.GetBytesOfIndex(EingabeDatei, ref CurrentIndex, ExemplarProp);
        if (bytesOfIndex.GetUpperBound(0) > -1)
        {
          Image image = Image.FromStream((Stream) new MemoryStream(bytesOfIndex));
          c1FlexGrid.Rows.Add();
          c1FlexGrid.Rows[checked (c1FlexGrid.Rows.Count - 1)].HeightDisplay = checked (image.Height + 10);
          CellRange cellRange = c1FlexGrid.GetCellRange(checked (c1FlexGrid.Rows.Count - 1), Spalte, checked (c1FlexGrid.Rows.Count - 1), checked (c1FlexGrid.Cols.Count - 1));
          cellRange.Style = c1FlexGrid.Styles["LeftImage_1"];
          cellRange.Image = image;
          cellRange.Data = (object) " ";
          c1FlexGrid.Rows[checked (c1FlexGrid.Rows.Count - 1)].AllowMerging = true;
          flag = true;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      return flag;
    }

    public static object WriteThemenHeader(
      C1.Win.C1FlexGrid.C1FlexGrid AusgabeGrid,
      string SuchImageString,
      string TopText)
    {
      C1.Win.C1FlexGrid.C1FlexGrid c1FlexGrid = AusgabeGrid;
      c1FlexGrid.Rows.Add();
      CellRange cellRange = c1FlexGrid.GetCellRange(checked (c1FlexGrid.Rows.Count - 1), 0, checked (c1FlexGrid.Rows.Count - 1), checked (c1FlexGrid.Cols.Count - 1));
      cellRange.Style = c1FlexGrid.Styles["LeftImage"];
      if (new FileInfo(SuchImageString).Exists)
      {
        try
        {
          Image image = Image.FromFile(SuchImageString);
          cellRange.Image = image;
          c1FlexGrid.Rows[checked (c1FlexGrid.Rows.Count - 1)].HeightDisplay = checked (cellRange.Image.Height + 10);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
      cellRange.Data = (object) TopText;
      c1FlexGrid.Rows[checked (c1FlexGrid.Rows.Count - 1)].AllowMerging = true;
      object obj;
      return obj;
    }

    public static object ShowRequiredRoads(
      C1.Win.C1FlexGrid.C1FlexGrid AusgabeGrid,
      string SuchWert,
      int Zeile,
      int Spalte)
    {
      C1.Win.C1FlexGrid.C1FlexGrid c1FlexGrid = AusgabeGrid;
      CellRange cellRange = c1FlexGrid.GetCellRange(Zeile, Spalte);
      cellRange.Style = c1FlexGrid.Styles["CenterImage"];
      string sLeft = SuchWert;
      if (StringType.StrCmp(sLeft, "0X00000008", false) == 0)
        cellRange.Image = (Image) AllgemeineKlasse.LadeResBild("TrafficCenter.bmp");
      else if (StringType.StrCmp(sLeft, "0X00000009", false) == 0)
        cellRange.Image = (Image) AllgemeineKlasse.LadeResBild("TrafficLeft.bmp");
      else if (StringType.StrCmp(sLeft, "0X0000000C", false) == 0)
        cellRange.Image = (Image) AllgemeineKlasse.LadeResBild("TrafficRight.bmp");
      c1FlexGrid.Rows[Zeile].HeightDisplay = checked (cellRange.Image.Height + 10);
      object obj;
      return obj;
    }

    public static object ShowRetainingWalls(
      C1.Win.C1FlexGrid.C1FlexGrid AusgabeGrid,
      string SuchWert,
      int Zeile,
      int Spalte)
    {
      C1.Win.C1FlexGrid.C1FlexGrid c1FlexGrid = AusgabeGrid;
      CellRange cellRange = c1FlexGrid.GetCellRange(Zeile, Spalte);
      cellRange.Style = c1FlexGrid.Styles["CenterImage"];
      int index = ClassThisProg.DefReader.Ret_Name_Array.IndexOf((object) SuchWert);
      if (index > -1)
      {
        cellRange.Image = ClassThisProg.DefReader.Ret_Picture_List[index];
        if (cellRange.Image.Height > 24)
          c1FlexGrid.Rows[Zeile].HeightDisplay = checked (cellRange.Image.Height + 10);
      }
      object obj;
      return obj;
    }

    public static ArrayList GetWerteFromDataSet(
      string SuchString1,
      ArrayList WerteArray,
      ArrayList OriWerteArray,
      ref bool HasPairs,
      string WerteTyp)
    {
      ArrayList arrayList1 = new ArrayList();
      ArrayList arrayList2 = new ArrayList();
      ArrayList arrayList3 = new ArrayList();
      ArrayList arrayList4 = new ArrayList();
      ArrayList arrayList5 = new ArrayList();
      ArrayList arrayList6 = new ArrayList();
      ArrayList arrayList7 = (ArrayList) OriWerteArray.Clone();
      ArrayList arrayList8 = (ArrayList) WerteArray.Clone();
      HasPairs = false;
      if (!Information.IsNumeric(RuntimeHelpers.GetObjectValue(arrayList8[0])) || Information.IsNothing((object) ClassThisProg.DefReader.PropXMLReader))
        return arrayList7;
      int num1 = checked (arrayList7.Count - 1);
      int index1 = 0;
      while (index1 <= num1)
      {
        arrayList2.Add(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(arrayList7[index1], (System.Type) null, "toupper", new object[0], (string[]) null, (bool[]) null)));
        checked { ++index1; }
      }
      sr_PropertyXMLReader.PropSet row = ClassThisProg.DefReader.PropXMLReader.GetRow(SuchString1, WerteTyp);
      if (StringType.StrCmp(row.Count, "-2", false) == 0)
        HasPairs = true;
      if (!HasPairs)
      {
        if (row.SubName.Count > 0)
        {
          if (row.SubValue[0].ToString().ToUpper().StartsWith("COL"))
          {
            arrayList7 = (ArrayList) arrayList8.Clone();
          }
          else
          {
            int num2 = checked (row.SubName.Count - 1);
            int index2 = 0;
            while (index2 <= num2)
            {
              int index3 = arrayList2.IndexOf((object) row.SubValue[index2].ToString().ToUpper());
              if (index3 > -1)
              {
                int num3 = checked (arrayList7.Count - 1);
                int index4 = 0;
                while (index4 <= num3)
                {
                  if (ObjectType.ObjTst(LateBinding.LateGet(arrayList7[index4], (System.Type) null, "toupper", new object[0], (string[]) null, (bool[]) null), arrayList2[index3], false) == 0)
                    arrayList7[index4] = RuntimeHelpers.GetObjectValue(row.SubName[index2]);
                  checked { ++index4; }
                }
              }
              checked { ++index2; }
            }
          }
        }
        else
        {
          arrayList7 = (ArrayList) arrayList8.Clone();
          if (StringType.StrCmp(row.Type.ToUpper(), "UINT32", false) == 0 && row.ShowAsHex)
            arrayList7 = (ArrayList) OriWerteArray.Clone();
        }
      }
      else
      {
        int num4 = checked (arrayList7.Count - 1);
        for (int index5 = 0; index5 <= num4; index5 = checked (index5 + 1 + 1))
        {
          int num5 = checked (row.SubValue.Count - 1);
          int index6 = 0;
          while (index6 <= num5)
          {
            if (StringType.StrCmp(arrayList7[index5].ToString().ToUpper(), row.SubValue[index6].ToString().ToUpper(), false) == 0 && checked (index5 + 1) <= checked (arrayList8.Count - 1))
            {
              arrayList3.Add(RuntimeHelpers.GetObjectValue(row.SubName[index6]));
              arrayList4.Add((object) arrayList8[checked (index5 + 1)].ToString());
              break;
            }
            checked { ++index6; }
          }
        }
        if (arrayList3.Count > 0)
        {
          arrayList7.Clear();
          int num6 = checked (arrayList3.Count - 1);
          int index7 = 0;
          while (index7 <= num6)
          {
            arrayList7.Add(RuntimeHelpers.GetObjectValue(arrayList3[index7]));
            arrayList7.Add(RuntimeHelpers.GetObjectValue(arrayList4[index7]));
            checked { ++index7; }
          }
        }
      }
      return arrayList7;
    }
  }
}
