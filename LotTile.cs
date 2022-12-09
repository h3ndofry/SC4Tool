// Decompiled with JetBrains decompiler
// Type: SC4Tool.LotTile
// Assembly: SC4Tool, Version=2.2.7.0, Culture=neutral, PublicKeyToken=null
// MVID: 69A50BC4-87A5-4C5E-BEFC-08274BC6D498
// Assembly location: C:\Program Files (x86)\SC4 Utilities\SC4Tool\SC4Tool.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using sr_Resources;
using sr_SC4Lib;
using System;
using System.Collections;
using System.Drawing;

namespace SC4Tool
{
  public class LotTile : CollectionBase
  {
    private const int RepSpalte = 3;
    private const int RepZeile = 5;
    private string m_Name;
    private int m_Zeile;
    private int m_Spalte;
    private LotTile.LotTexture[] m_Textures;
    private ArrayList m_WerteString;
    private ArrayList m_SaveWerteString;
    private string m_TransitArt;
    private bool m_isWater;
    private bool m_isLand;
    private LotTile.BitmapAusgabe[] m_Bitmaps;
    private ArrayList m_EingabeWerte;
    private ArrayList m_DirectionArray;
    private bool m_HasRep16;
    private bool m_MustExpert;

    public bool MustExpert => this.m_MustExpert;

    public bool HasRep16
    {
      get => this.m_HasRep16;
      set => this.m_HasRep16 = false;
    }

    public ArrayList DirectionArray
    {
      get => this.m_DirectionArray;
      set => this.m_DirectionArray = (ArrayList) value.Clone();
    }

    public ArrayList SaveWerteString
    {
      get => this.m_SaveWerteString;
      set => this.m_SaveWerteString = (ArrayList) value.Clone();
    }

    public ArrayList WerteString => this.m_WerteString;

    public LotTile.BitmapAusgabe[] Bitmaps => this.m_Bitmaps;

    public bool isLand => this.m_isLand;

    public bool isWater => this.m_isWater;

    public string TransitArt => this.m_TransitArt;

    public LotTile.LotTexture[] Textures => this.m_Textures;

    public int Spalte => this.m_Spalte;

    public int Zeile => this.m_Zeile;

    public string Name => this.m_Name;

    public LotTile(int RechtsWert, int HochWert)
    {
      this.m_WerteString = new ArrayList();
      this.m_SaveWerteString = new ArrayList();
      this.m_EingabeWerte = new ArrayList();
      this.m_DirectionArray = new ArrayList();
      this.m_HasRep16 = false;
      this.m_MustExpert = false;
      this.m_EingabeWerte.Clear();
      this.m_Zeile = HochWert;
      this.m_Spalte = RechtsWert;
      this.m_DirectionArray.Add((object) "00");
      this.m_DirectionArray.Add((object) "00");
      this.m_DirectionArray.Add((object) "00");
      this.m_DirectionArray.Add((object) "00");
      this.m_Name = RechtsWert.ToString() + ":" + HochWert.ToString();
      this.m_WerteString = new ArrayList();
      this.m_WerteString.Clear();
      this.m_Textures = new LotTile.LotTexture[0];
      this.m_Bitmaps = new LotTile.BitmapAusgabe[0];
      this.m_TransitArt = "";
      this.m_isWater = false;
      this.m_isLand = false;
      this.m_HasRep16 = false;
    }

    public bool addWerte(ArrayList Werte)
    {
      this.m_EingabeWerte.Clear();
      this.m_EingabeWerte = (ArrayList) Werte.Clone();
      if (this.CheckCellPosition())
      {
        this.SetTile();
        this.FillWerteString();
        this.m_EingabeWerte.Clear();
        return true;
      }
      this.m_EingabeWerte.Clear();
      return false;
    }

    public string GetRep14()
    {
      string str = "";
      if (this.m_WerteString.Count > 0)
      {
        int num = checked (this.m_WerteString.Count - 1);
        int index = 0;
        while (index <= num)
        {
          string[] strArray = this.m_WerteString[index].ToString().Split(',');
          if (StringType.StrCmp(strArray[0].ToUpper(), "0X00000007", false) == 0 && strArray.GetUpperBound(0) >= 13)
          {
            str = strArray[13];
            break;
          }
          checked { ++index; }
        }
      }
      return str;
    }

    public string GetRep16()
    {
      string str = "";
      if (this.m_WerteString.Count > 0)
      {
        int num = checked (this.m_WerteString.Count - 1);
        int index = 0;
        while (index <= num)
        {
          string[] strArray = this.m_WerteString[index].ToString().Split(',');
          if (StringType.StrCmp(strArray[0].ToUpper(), "0X00000007", false) == 0 && strArray.GetUpperBound(0) == 15)
          {
            str = strArray[15];
            break;
          }
          checked { ++index; }
        }
      }
      return str;
    }

    public object AddRep16(string RepValue)
    {
      if (this.m_WerteString.Count > 0)
      {
        int num = checked (this.m_WerteString.Count - 1);
        int index = 0;
        while (index <= num)
        {
          string[] strArray = this.m_WerteString[index].ToString().Split(',');
          if (StringType.StrCmp(strArray[0].ToUpper(), "0X00000007", false) == 0 && strArray.GetUpperBound(0) == 14)
          {
            this.m_WerteString[index] = ObjectType.StrCatObj(ObjectType.StrCatObj(this.m_WerteString[index], (object) ","), (object) RepValue);
            this.m_HasRep16 = true;
            break;
          }
          checked { ++index; }
        }
      }
      object obj;
      return obj;
    }

    public object ModifyRep14(string RepValue)
    {
      if (this.m_WerteString.Count > 0)
      {
        int num = checked (this.m_WerteString.Count - 1);
        int index1 = 0;
        while (index1 <= num)
        {
          string[] strArray = this.m_WerteString[index1].ToString().Split(',');
          if (StringType.StrCmp(strArray[0].ToUpper(), "0X00000007", false) == 0 && strArray.GetUpperBound(0) >= 13)
          {
            strArray[13] = RepValue;
            this.WerteString[index1] = (object) strArray[0];
            int upperBound = strArray.GetUpperBound(0);
            int index2 = 1;
            while (index2 <= upperBound)
            {
              this.WerteString[index1] = ObjectType.StrCatObj(ObjectType.StrCatObj(this.WerteString[index1], (object) ","), (object) strArray[index2]);
              checked { ++index2; }
            }
            break;
          }
          checked { ++index1; }
        }
      }
      object obj;
      return obj;
    }

    public object ModifyRep16(string RepValue)
    {
      this.RemoveRep16();
      this.AddRep16(RepValue);
      object obj;
      return obj;
    }

    public object SetDirectionArray(ArrayList newArray)
    {
      this.m_DirectionArray = (ArrayList) newArray.Clone();
      string str1 = StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(this.m_DirectionArray[0], this.m_DirectionArray[1]), this.m_DirectionArray[2]), this.m_DirectionArray[3]));
      newArray.Clear();
      if (this.m_WerteString.Count > 0)
      {
        int num = checked (this.m_WerteString.Count - 1);
        int index1 = 0;
        while (index1 <= num)
        {
          string[] strArray = this.m_WerteString[index1].ToString().Split(',');
          if (StringType.StrCmp(strArray[0].ToUpper(), "0X00000007", false) == 0)
          {
            strArray[14] = "0X" + str1;
            this.RemoveTraffic();
            string str2 = strArray[0];
            newArray.Add((object) str2);
            int upperBound = strArray.GetUpperBound(0);
            int index2 = 1;
            while (index2 <= upperBound)
            {
              newArray.Add((object) strArray[index2]);
              checked { ++index2; }
            }
            this.addWerte(newArray);
            break;
          }
          checked { ++index1; }
        }
      }
      object obj;
      return obj;
    }

    public object RemoveTexture(string TextureID)
    {
      LotTile.BitmapAusgabe[] bitmapAusgabeArray = new LotTile.BitmapAusgabe[0];
      if (this.m_Bitmaps.GetUpperBound(0) > -1)
      {
        int upperBound = this.m_Bitmaps.GetUpperBound(0);
        int index = 0;
        while (index <= upperBound)
        {
          string typ = this.m_Bitmaps[index].Typ;
          if (StringType.StrCmp(typ, "Water", false) == 0 || StringType.StrCmp(typ, "Land", false) == 0)
          {
            bitmapAusgabeArray = (LotTile.BitmapAusgabe[]) Utils.CopyArray((Array) bitmapAusgabeArray, (Array) new LotTile.BitmapAusgabe[checked (bitmapAusgabeArray.GetUpperBound(0) + 1 + 1)]);
            bitmapAusgabeArray[bitmapAusgabeArray.GetUpperBound(0)] = this.m_Bitmaps[index];
          }
          else if (StringType.StrCmp(typ, "TrafficArt", false) == 0 || StringType.StrCmp(typ, "TrafficDirection", false) == 0)
          {
            bitmapAusgabeArray = (LotTile.BitmapAusgabe[]) Utils.CopyArray((Array) bitmapAusgabeArray, (Array) new LotTile.BitmapAusgabe[checked (bitmapAusgabeArray.GetUpperBound(0) + 1 + 1)]);
            bitmapAusgabeArray[bitmapAusgabeArray.GetUpperBound(0)] = this.m_Bitmaps[index];
          }
          else if (StringType.StrCmp(this.m_Bitmaps[index].Instance.ToUpper(), TextureID.ToUpper(), false) != 0)
          {
            bitmapAusgabeArray = (LotTile.BitmapAusgabe[]) Utils.CopyArray((Array) bitmapAusgabeArray, (Array) new LotTile.BitmapAusgabe[checked (bitmapAusgabeArray.GetUpperBound(0) + 1 + 1)]);
            bitmapAusgabeArray[bitmapAusgabeArray.GetUpperBound(0)] = this.m_Bitmaps[index];
          }
          checked { ++index; }
        }
      }
      if ((uint) checked (bitmapAusgabeArray.GetUpperBound(0) - 1) > 0U)
      {
        this.m_Bitmaps = new LotTile.BitmapAusgabe[checked (bitmapAusgabeArray.GetUpperBound(0) + 1)];
        this.m_Bitmaps = bitmapAusgabeArray;
      }
      else
        this.m_Bitmaps = new LotTile.BitmapAusgabe[0];
      if (this.m_WerteString.Count > 0)
      {
        int num = checked (this.m_WerteString.Count - 1);
        int index = 0;
        while (index <= num)
        {
          string[] strArray = this.m_WerteString[index].ToString().Split(',');
          if (StringType.StrCmp(strArray[0].ToUpper(), "0X00000002", false) == 0 && StringType.StrCmp(strArray[12], TextureID, false) == 0)
          {
            this.m_WerteString.RemoveAt(index);
            break;
          }
          checked { ++index; }
        }
      }
      LotTile.LotTexture[] lotTextureArray = new LotTile.LotTexture[0];
      if (this.m_Textures.GetUpperBound(0) > -1)
      {
        int upperBound = this.m_Textures.GetUpperBound(0);
        int index = 0;
        while (index <= upperBound)
        {
          if (StringType.StrCmp(this.m_Textures[index].Gruppe, TextureID, false) != 0)
          {
            bitmapAusgabeArray = (LotTile.BitmapAusgabe[]) Utils.CopyArray((Array) bitmapAusgabeArray, (Array) new LotTile.BitmapAusgabe[checked (bitmapAusgabeArray.GetUpperBound(0) + 1 + 1)]);
            lotTextureArray[lotTextureArray.GetUpperBound(0)] = this.m_Textures[index];
          }
          checked { ++index; }
        }
      }
      if ((uint) checked (lotTextureArray.GetUpperBound(0) - 1) > 0U)
      {
        this.m_Textures = new LotTile.LotTexture[checked (lotTextureArray.GetUpperBound(0) + 1)];
        this.m_Textures = lotTextureArray;
      }
      else
        this.m_Textures = new LotTile.LotTexture[0];
      object obj;
      return obj;
    }

    public bool RemoveLand()
    {
      LotTile.BitmapAusgabe[] bitmapAusgabeArray = new LotTile.BitmapAusgabe[0];
      if (this.m_Bitmaps.GetUpperBound(0) > -1)
      {
        int upperBound = this.m_Bitmaps.GetUpperBound(0);
        int index = 0;
        while (index <= upperBound)
        {
          if (StringType.StrCmp(this.m_Bitmaps[index].Typ, "Land", false) != 0)
          {
            bitmapAusgabeArray = (LotTile.BitmapAusgabe[]) Utils.CopyArray((Array) bitmapAusgabeArray, (Array) new LotTile.BitmapAusgabe[checked (bitmapAusgabeArray.GetUpperBound(0) + 1 + 1)]);
            bitmapAusgabeArray[bitmapAusgabeArray.GetUpperBound(0)] = this.m_Bitmaps[index];
          }
          checked { ++index; }
        }
        if ((uint) checked (bitmapAusgabeArray.GetUpperBound(0) - 1) > 0U)
        {
          this.m_Bitmaps = new LotTile.BitmapAusgabe[checked (bitmapAusgabeArray.GetUpperBound(0) + 1)];
          this.m_Bitmaps = bitmapAusgabeArray;
        }
        else
          this.m_Bitmaps = new LotTile.BitmapAusgabe[0];
        this.RemoveWerteString("0X00000006");
      }
      bool flag;
      return flag;
    }

    public bool RemoveWater()
    {
      LotTile.BitmapAusgabe[] bitmapAusgabeArray = new LotTile.BitmapAusgabe[0];
      if (this.m_Bitmaps.GetUpperBound(0) > -1)
      {
        int upperBound = this.m_Bitmaps.GetUpperBound(0);
        int index = 0;
        while (index <= upperBound)
        {
          if (StringType.StrCmp(this.m_Bitmaps[index].Typ, "Land", false) != 0)
          {
            bitmapAusgabeArray = (LotTile.BitmapAusgabe[]) Utils.CopyArray((Array) bitmapAusgabeArray, (Array) new LotTile.BitmapAusgabe[checked (bitmapAusgabeArray.GetUpperBound(0) + 1 + 1)]);
            bitmapAusgabeArray[bitmapAusgabeArray.GetUpperBound(0)] = this.m_Bitmaps[index];
          }
          checked { ++index; }
        }
        if ((uint) checked (bitmapAusgabeArray.GetUpperBound(0) - 1) > 0U)
        {
          this.m_Bitmaps = new LotTile.BitmapAusgabe[checked (bitmapAusgabeArray.GetUpperBound(0) + 1)];
          this.m_Bitmaps = bitmapAusgabeArray;
        }
        else
          this.m_Bitmaps = new LotTile.BitmapAusgabe[0];
        this.RemoveWerteString("0X00000005");
      }
      bool flag;
      return flag;
    }

    public bool RemoveTraffic()
    {
      LotTile.BitmapAusgabe[] bitmapAusgabeArray = new LotTile.BitmapAusgabe[0];
      if (this.m_Bitmaps.GetUpperBound(0) > -1)
      {
        int upperBound = this.m_Bitmaps.GetUpperBound(0);
        int index = 0;
        while (index <= upperBound)
        {
          if (StringType.StrCmp(this.m_Bitmaps[index].Typ, "TrafficArt", false) != 0 && StringType.StrCmp(this.m_Bitmaps[index].Typ, "TrafficDirection", false) != 0)
          {
            bitmapAusgabeArray = (LotTile.BitmapAusgabe[]) Utils.CopyArray((Array) bitmapAusgabeArray, (Array) new LotTile.BitmapAusgabe[checked (bitmapAusgabeArray.GetUpperBound(0) + 1 + 1)]);
            bitmapAusgabeArray[bitmapAusgabeArray.GetUpperBound(0)] = this.m_Bitmaps[index];
          }
          checked { ++index; }
        }
        if (bitmapAusgabeArray.GetUpperBound(0) > -1)
        {
          this.m_Bitmaps = new LotTile.BitmapAusgabe[checked (bitmapAusgabeArray.GetUpperBound(0) + 1)];
          this.m_Bitmaps = bitmapAusgabeArray;
        }
        else
          this.m_Bitmaps = new LotTile.BitmapAusgabe[0];
        this.RemoveWerteString("0X00000007");
        this.m_TransitArt = "";
        this.m_MustExpert = false;
        this.m_DirectionArray[0] = (object) "00";
        this.m_DirectionArray[1] = (object) "00";
        this.m_DirectionArray[2] = (object) "00";
        this.m_DirectionArray[3] = (object) "00";
      }
      bool flag;
      return flag;
    }

    public object RemoveRep16()
    {
      if (this.m_WerteString.Count > 0)
      {
        int num1 = checked (this.m_WerteString.Count - 1);
        int index1 = 0;
        while (index1 <= num1)
        {
          string[] strArray = this.m_WerteString[index1].ToString().Split(',');
          if (StringType.StrCmp(strArray[0].ToUpper(), "0X00000007", false) == 0 && strArray.GetUpperBound(0) == 15)
          {
            string str = strArray[0];
            int num2 = checked (strArray.GetUpperBound(0) - 1);
            int index2 = 1;
            while (index2 <= num2)
            {
              str = str + "," + strArray[index2];
              checked { ++index2; }
            }
            this.m_WerteString[index1] = (object) str;
            this.m_HasRep16 = false;
            break;
          }
          checked { ++index1; }
        }
      }
      object obj;
      return obj;
    }

    public object RemoveWerteString(string Kennung)
    {
      if (this.m_WerteString.Count > 0)
      {
        int num = checked (this.m_WerteString.Count - 1);
        int index = 0;
        while (index <= num)
        {
          if (StringType.StrCmp(this.m_WerteString[index].ToString().Split(',')[0].ToUpper(), Kennung, false) == 0)
          {
            this.m_WerteString.RemoveAt(index);
            break;
          }
          checked { ++index; }
        }
      }
      object obj;
      return obj;
    }

    public string GetRotateMirrorString()
    {
      if (this.m_WerteString.Count > 0)
      {
        int num = checked (this.m_WerteString.Count - 1);
        int index = 0;
        while (index <= num)
        {
          string[] strArray = this.m_WerteString[index].ToString().Split(',');
          if (StringType.StrCmp(strArray[0].ToUpper(), "0X00000007", false) == 0)
            return strArray[2];
          checked { ++index; }
        }
      }
      return "";
    }

    public object SetRotateMirrorString(string EingabeString)
    {
      if (this.m_WerteString.Count > 0)
      {
        int num = checked (this.m_WerteString.Count - 1);
        int index1 = 0;
        while (index1 <= num)
        {
          string[] strArray = this.m_WerteString[index1].ToString().Split(',');
          if (StringType.StrCmp(strArray[0].ToUpper(), "0X00000007", false) == 0)
          {
            string str = strArray[0];
            int upperBound = strArray.GetUpperBound(0);
            int index2 = 1;
            while (index2 <= upperBound)
            {
              str = index2 != 2 ? str + "," + strArray[index2] : str + "," + EingabeString;
              checked { ++index2; }
            }
            this.m_WerteString[index1] = (object) str;
            break;
          }
          checked { ++index1; }
        }
      }
      object obj;
      return obj;
    }

    private object SetTile()
    {
      if (this.m_EingabeWerte.Count > 11)
      {
        string sLeft = StringType.FromObject(LateBinding.LateGet(this.m_EingabeWerte[0], (Type) null, "toupper", new object[0], (string[]) null, (bool[]) null));
        if (StringType.StrCmp(sLeft, "0X00000002", false) == 0 | StringType.StrCmp(sLeft, "0X00000007", false) == 0 | StringType.StrCmp(sLeft, "0X00000005", false) == 0 | StringType.StrCmp(sLeft, "0X00000006", false) == 0)
        {
          object o1 = LateBinding.LateGet(this.m_EingabeWerte[0], (Type) null, "toupper", new object[0], (string[]) null, (bool[]) null);
          if (ObjectType.ObjTst(o1, (object) "0X00000002", false) == 0)
            this.GetTextureData();
          else if (ObjectType.ObjTst(o1, (object) "0X00000005", false) == 0)
          {
            this.m_isWater = true;
            this.GetWaterAndLand();
          }
          else if (ObjectType.ObjTst(o1, (object) "0X00000006", false) == 0)
          {
            this.m_isLand = true;
            this.GetWaterAndLand();
          }
          else if (ObjectType.ObjTst(o1, (object) "0X00000007", false) == 0 && this.m_EingabeWerte.Count >= 15)
          {
            string str = "";
            string upper = this.m_EingabeWerte[12].ToString().ToUpper();
            if (StringType.StrCmp(upper, "0X00000000", false) == 0)
              str = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[330]);
            else if (StringType.StrCmp(upper, "0X00000001", false) == 0)
              str = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[331]);
            else if (StringType.StrCmp(upper, "0X00000002", false) == 0)
              str = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[332]);
            else if (StringType.StrCmp(upper, "0X00000003", false) == 0)
              str = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[333]);
            else if (StringType.StrCmp(upper, "0X00000006", false) == 0)
              str = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[334]);
            else if (StringType.StrCmp(upper, "0X00000008", false) == 0)
              str = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[335]);
            else if (StringType.StrCmp(upper, "0X00000009", false) == 0)
              str = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[336]);
            else if (StringType.StrCmp(upper, "0X0000000A", false) == 0)
              str = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[337]);
            else if (StringType.StrCmp(upper, "0X0000000C", false) == 0)
              str = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[338]);
            this.m_TransitArt = str;
            this.GetTrafficDirection(StringType.FromObject(this.m_EingabeWerte[14]));
            this.GetTraffic(StringType.FromObject(this.m_EingabeWerte[2]));
            if (this.m_EingabeWerte.Count == 16)
              this.m_HasRep16 = true;
          }
        }
      }
      object obj;
      return obj;
    }

    private object GetTextureData()
    {
      int p = checked (this.m_Textures.GetUpperBound(0) + 1);
      this.m_Textures = (LotTile.LotTexture[]) Utils.CopyArray((Array) this.m_Textures, (Array) new LotTile.LotTexture[checked (p + 1)]);
      this.m_Textures[p].Gruppe = this.m_EingabeWerte[12].ToString();
      this.m_Textures[p].Rotation = "0";
      this.m_Textures[p].mirror = false;
      this.m_Textures[p].isBase = false;
      string str = this.m_EingabeWerte[2].ToString();
      if (str.Length == 10)
      {
        if (DoubleType.FromString(str.Substring(2, 1)) == 8.0)
          this.m_Textures[p].mirror = true;
        string sLeft = str.Substring(9, 1);
        if (StringType.StrCmp(sLeft, "0", false) == 0)
          this.m_Textures[p].Rotation = "180";
        else if (StringType.StrCmp(sLeft, "1", false) == 0)
          this.m_Textures[p].Rotation = "270";
        else if (StringType.StrCmp(sLeft, "2", false) == 0)
          this.m_Textures[p].Rotation = "0";
        else if (StringType.StrCmp(sLeft, "3", false) == 0)
          this.m_Textures[p].Rotation = "90";
      }
      this.GetTexture(p);
      object obj;
      return obj;
    }

    private object GetTexture(int p)
    {
      TextureReader.TextureImage textureImage = ClassThisProg.DefReader.TextureListe.SelectTextureWithImage(this.m_Textures[p].Gruppe, 64);
      if (!Information.IsNothing((object) textureImage.TextureBitmap))
      {
        this.m_Bitmaps = (LotTile.BitmapAusgabe[]) Utils.CopyArray((Array) this.m_Bitmaps, (Array) new LotTile.BitmapAusgabe[checked (this.m_Bitmaps.GetUpperBound(0) + 1 + 1)]);
        this.m_Bitmaps[this.m_Bitmaps.GetUpperBound(0)].AusgabeBild = textureImage.TextureBitmap;
        this.m_Bitmaps[this.m_Bitmaps.GetUpperBound(0)].Typ = "Texture";
        this.m_Bitmaps[this.m_Bitmaps.GetUpperBound(0)].isBase = textureImage.isBase;
        this.m_Bitmaps[this.m_Bitmaps.GetUpperBound(0)].Instance = this.m_Textures[p].Gruppe;
        this.m_Bitmaps[this.m_Bitmaps.GetUpperBound(0)].isTransparent = true;
        this.m_Textures[p].isBase = textureImage.isBase;
        string str = "NORTH";
        string rotation = this.m_Textures[p].Rotation;
        if (StringType.StrCmp(rotation, "0", false) == 0)
          str = "NORTH";
        else if (StringType.StrCmp(rotation, "90", false) == 0)
          str = "EAST";
        else if (StringType.StrCmp(rotation, "180", false) == 0)
          str = "SOUTH";
        else if (StringType.StrCmp(rotation, "270", false) == 0)
          str = "WEST";
        this.m_Bitmaps[this.m_Bitmaps.GetUpperBound(0)].Direction = str;
        this.m_Bitmaps[this.m_Bitmaps.GetUpperBound(0)].isMirror = this.m_Textures[p].mirror;
      }
      else
      {
        Loader loader = new Loader();
        this.m_Bitmaps = (LotTile.BitmapAusgabe[]) Utils.CopyArray((Array) this.m_Bitmaps, (Array) new LotTile.BitmapAusgabe[checked (this.m_Bitmaps.GetUpperBound(0) + 1 + 1)]);
        this.m_Bitmaps[this.m_Bitmaps.GetUpperBound(0)].AusgabeBild = loader.GetPictureFromResource("notfound.bmp");
        this.m_Bitmaps[this.m_Bitmaps.GetUpperBound(0)].Typ = "Texture";
        this.m_Bitmaps[this.m_Bitmaps.GetUpperBound(0)].isBase = false;
        this.m_Bitmaps[this.m_Bitmaps.GetUpperBound(0)].Instance = this.m_Textures[p].Gruppe;
        this.m_Bitmaps[this.m_Bitmaps.GetUpperBound(0)].isTransparent = true;
        this.m_Bitmaps[this.m_Bitmaps.GetUpperBound(0)].Direction = "NORTH";
        this.m_Bitmaps[this.m_Bitmaps.GetUpperBound(0)].isMirror = false;
        loader.Dispose();
      }
      object obj;
      return obj;
    }

    private object GetWaterAndLand()
    {
      Loader loader = new Loader();
      Bitmap pictureFromResource1;
      string str;
      if (this.m_isLand)
      {
        pictureFromResource1 = loader.GetPictureFromResource("Land.bmp");
        str = "Land";
      }
      else
      {
        pictureFromResource1 = loader.GetPictureFromResource("Water.bmp");
        str = "Water";
      }
      Bitmap pictureFromResource2 = loader.GetPictureFromResource("GreyScale.bmp");
      Bitmap bitmapWithAlpha = AllgemeineKlasse.GetBitmapWithAlpha(pictureFromResource1, pictureFromResource2);
      loader.Dispose();
      this.m_Bitmaps = (LotTile.BitmapAusgabe[]) Utils.CopyArray((Array) this.m_Bitmaps, (Array) new LotTile.BitmapAusgabe[checked (this.m_Bitmaps.GetUpperBound(0) + 1 + 1)]);
      this.m_Bitmaps[this.m_Bitmaps.GetUpperBound(0)].AusgabeBild = bitmapWithAlpha;
      this.m_Bitmaps[this.m_Bitmaps.GetUpperBound(0)].Typ = str;
      this.m_Bitmaps[this.m_Bitmaps.GetUpperBound(0)].Direction = "NORTH";
      this.m_Bitmaps[this.m_Bitmaps.GetUpperBound(0)].isTransparent = false;
      object obj;
      return obj;
    }

    private object GetTraffic(string RotateString)
    {
      ArrayList arrayList = new ArrayList();
      Loader loader = new Loader();
      string str = "NORTH";
      bool flag = false;
      string sLeft = RotateString.Substring(9, 1);
      if (StringType.StrCmp(sLeft, "2", false) == 0)
      {
        this.m_MustExpert = true;
        str = "SOUTH";
      }
      else if (StringType.StrCmp(sLeft, "3", false) == 0)
      {
        this.m_MustExpert = true;
        str = "WEST";
      }
      else if (StringType.StrCmp(sLeft, "0", false) == 0)
      {
        this.m_MustExpert = false;
        str = "NORTH";
      }
      else if (StringType.StrCmp(sLeft, "1", false) == 0)
      {
        this.m_MustExpert = true;
        str = "EAST";
      }
      if (DoubleType.FromString(RotateString.Substring(2, 1)) == 8.0)
      {
        this.m_MustExpert = true;
        flag = true;
      }
      if (StringType.StrCmp(this.m_TransitArt, "", false) != 0)
      {
        string transitArt = this.m_TransitArt;
        Bitmap pictureFromResource;
        if (StringType.StrCmp(transitArt, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[333]), false) == 0)
          pictureFromResource = loader.GetPictureFromResource("A.bmp");
        else if (StringType.StrCmp(transitArt, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[337]), false) == 0)
          pictureFromResource = loader.GetPictureFromResource("B.bmp");
        else if (StringType.StrCmp(transitArt, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[330]), false) == 0)
          pictureFromResource = loader.GetPictureFromResource("C.bmp");
        else if (StringType.StrCmp(transitArt, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[334]), false) == 0)
          pictureFromResource = loader.GetPictureFromResource("D.bmp");
        else if (StringType.StrCmp(transitArt, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[332]), false) == 0)
          pictureFromResource = loader.GetPictureFromResource("E.bmp");
        else if (StringType.StrCmp(transitArt, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[338]), false) == 0)
          pictureFromResource = loader.GetPictureFromResource("F.bmp");
        else if (StringType.StrCmp(transitArt, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[331]), false) == 0)
          pictureFromResource = loader.GetPictureFromResource("G.bmp");
        else if (StringType.StrCmp(transitArt, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[335]), false) == 0)
          pictureFromResource = loader.GetPictureFromResource("H.bmp");
        else if (StringType.StrCmp(transitArt, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[336]), false) == 0)
          pictureFromResource = loader.GetPictureFromResource("I.bmp");
        LotTile.BitmapAusgabe bitmapAusgabe;
        if (ObjectType.ObjTst(this.m_DirectionArray[0], (object) "00", false) != 0)
        {
          bitmapAusgabe.Direction = str;
          bitmapAusgabe.AusgabeBild = loader.GetPictureFromResource("North.bmp");
          bitmapAusgabe.Typ = "TrafficDirection";
          bitmapAusgabe.isMirror = flag;
          arrayList.Add((object) bitmapAusgabe);
        }
        if (ObjectType.ObjTst(this.m_DirectionArray[1], (object) "00", false) != 0)
        {
          bitmapAusgabe.Direction = str;
          bitmapAusgabe.AusgabeBild = loader.GetPictureFromResource("West.bmp");
          bitmapAusgabe.Typ = "TrafficDirection";
          bitmapAusgabe.isMirror = flag;
          arrayList.Add((object) bitmapAusgabe);
        }
        if (ObjectType.ObjTst(this.m_DirectionArray[2], (object) "00", false) != 0)
        {
          bitmapAusgabe.Direction = str;
          bitmapAusgabe.AusgabeBild = loader.GetPictureFromResource("South.bmp");
          bitmapAusgabe.Typ = "TrafficDirection";
          bitmapAusgabe.isMirror = flag;
          arrayList.Add((object) bitmapAusgabe);
        }
        if (ObjectType.ObjTst(this.m_DirectionArray[3], (object) "00", false) != 0)
        {
          bitmapAusgabe.Direction = str;
          bitmapAusgabe.AusgabeBild = loader.GetPictureFromResource("East.bmp");
          bitmapAusgabe.Typ = "TrafficDirection";
          bitmapAusgabe.isMirror = flag;
          arrayList.Add((object) bitmapAusgabe);
        }
        int num1 = checked (this.m_DirectionArray.Count - 1);
        int index1 = 0;
        while (index1 <= num1)
        {
          if (BooleanType.FromObject(ObjectType.BitAndObj(ObjectType.BitAndObj(ObjectType.BitAndObj(ObjectType.BitAndObj(ObjectType.BitAndObj((object) (ObjectType.ObjTst(LateBinding.LateGet(this.m_DirectionArray[index1], (Type) null, "toupper", new object[0], (string[]) null, (bool[]) null), (object) "00", false) != 0), (object) (ObjectType.ObjTst(LateBinding.LateGet(this.m_DirectionArray[index1], (Type) null, "toupper", new object[0], (string[]) null, (bool[]) null), (object) "01", false) != 0)), (object) (ObjectType.ObjTst(LateBinding.LateGet(this.m_DirectionArray[index1], (Type) null, "toupper", new object[0], (string[]) null, (bool[]) null), (object) "02", false) != 0)), (object) (ObjectType.ObjTst(LateBinding.LateGet(this.m_DirectionArray[index1], (Type) null, "toupper", new object[0], (string[]) null, (bool[]) null), (object) "03", false) != 0)), (object) (ObjectType.ObjTst(LateBinding.LateGet(this.m_DirectionArray[index1], (Type) null, "toupper", new object[0], (string[]) null, (bool[]) null), (object) "04", false) != 0)), (object) (ObjectType.ObjTst(LateBinding.LateGet(this.m_DirectionArray[index1], (Type) null, "toupper", new object[0], (string[]) null, (bool[]) null), (object) "FF", false) != 0))))
          {
            this.m_MustExpert = true;
            break;
          }
          checked { ++index1; }
        }
        if (arrayList.Count > 0 && !Information.IsNothing((object) pictureFromResource))
        {
          this.m_Bitmaps = (LotTile.BitmapAusgabe[]) Utils.CopyArray((Array) this.m_Bitmaps, (Array) new LotTile.BitmapAusgabe[checked (this.m_Bitmaps.GetUpperBound(0) + 1 + 1)]);
          this.m_Bitmaps[this.m_Bitmaps.GetUpperBound(0)].AusgabeBild = pictureFromResource;
          this.m_Bitmaps[this.m_Bitmaps.GetUpperBound(0)].Typ = "TrafficArt";
          this.m_Bitmaps[this.m_Bitmaps.GetUpperBound(0)].Direction = "NORTH";
          this.m_Bitmaps[this.m_Bitmaps.GetUpperBound(0)].isMirror = false;
          int num2 = checked (arrayList.Count - 1);
          int index2 = 0;
          while (index2 <= num2)
          {
            this.m_Bitmaps = (LotTile.BitmapAusgabe[]) Utils.CopyArray((Array) this.m_Bitmaps, (Array) new LotTile.BitmapAusgabe[checked (this.m_Bitmaps.GetUpperBound(0) + 1 + 1)]);
            this.m_Bitmaps[this.m_Bitmaps.GetUpperBound(0)] = (LotTile.BitmapAusgabe) (arrayList[index2] ?? Activator.CreateInstance(typeof (LotTile.BitmapAusgabe)));
            checked { ++index2; }
          }
        }
      }
      loader.Dispose();
      object obj;
      return obj;
    }

    private object GetTrafficDirection(string EingabeString)
    {
      string str = EingabeString.ToUpper().Replace("0X", "");
      if (str.Length == 8)
      {
        this.m_DirectionArray[0] = (object) str.Substring(0, 2);
        this.m_DirectionArray[1] = (object) str.Substring(2, 2);
        this.m_DirectionArray[2] = (object) str.Substring(4, 2);
        this.m_DirectionArray[3] = (object) str.Substring(6, 2);
      }
      object obj;
      return obj;
    }

    private object FillWerteString()
    {
      string str = "";
      int num = checked (this.m_EingabeWerte.Count - 1);
      int index = 0;
      while (index <= num)
      {
        str = str + "," + this.m_EingabeWerte[index].ToString();
        checked { ++index; }
      }
      if (str.StartsWith(","))
        str = str.Substring(1, checked (str.Length - 1));
      this.m_WerteString.Add((object) str);
      object obj;
      return obj;
    }

    private bool CheckCellPosition()
    {
      int num1 = 0;
      int num2 = 0;
      string str1 = this.m_EingabeWerte[3].ToString().Substring(0, 5).Replace("0x", "&h");
      string str2 = this.m_EingabeWerte[5].ToString().Substring(0, 5).Replace("0x", "&h");
      if (StringType.StrCmp(this.m_EingabeWerte[3].ToString().Substring(5, 1), "0", false) != 0)
        num2 = 1;
      if (StringType.StrCmp(this.m_EingabeWerte[5].ToString().Substring(5, 1), "0", false) != 0)
        num1 = 1;
      if (Information.IsNumeric((object) str1) & Information.IsNumeric((object) str2))
      {
        string str3 = StringType.FromDouble(DoubleType.FromString(str1) - 1.0);
        if (checked (IntegerType.FromString(StringType.FromDouble(unchecked (DoubleType.FromString(str2) - 1.0))) + num1) == this.m_Zeile & checked (IntegerType.FromString(str3) + num2) == this.m_Spalte)
          return true;
      }
      return false;
    }

    public struct BitmapAusgabe
    {
      public Bitmap AusgabeBild;
      public string Typ;
      public string Direction;
      public bool isBase;
      public bool isMirror;
      public string Instance;
      public bool isTransparent;
    }

    public struct LotTexture
    {
      public string Gruppe;
      public string Rotation;
      public bool mirror;
      public bool isBase;
    }
  }
}
