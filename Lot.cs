// Decompiled with JetBrains decompiler
// Type: SC4Tool.Lot
// Assembly: SC4Tool, Version=2.2.7.0, Culture=neutral, PublicKeyToken=null
// MVID: 69A50BC4-87A5-4C5E-BEFC-08274BC6D498
// Assembly location: C:\Program Files (x86)\SC4 Utilities\SC4Tool\SC4Tool.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using sr_SC4Lib;
using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;

namespace SC4Tool
{
  public class Lot
  {
    private const int RepSpalte = 3;
    private const int RepZeile = 5;
    private Lot.LotDefinition m_CommonDefs;
    private AllgemeineKlasse.ValueList[] m_WerteListe;
    private AllgemeineKlasse.ValueList[] m_BuildingWerteListe;
    private AllgemeineKlasse.ValueList[] m_TempWerteListe;
    private int m_Index;
    private int m_Breite;
    private int m_Hoehe;
    private LotTile[] m_Tiles;
    private int m_PropertyCount;
    private int m_BuildingPropertyCount;
    private bool m_isValid;
    private bool m_hasBadTiles;
    private int m_ExemplarIndex;
    private Lot.ExemplarTransitSettings m_TransitSettings;
    private ArrayList WerteArray;
    private ArrayList TileArray;
    private ArrayList SuchArray;
    private ArrayList BuildingSuchArray;
    private ArrayList BuildingWerteArray;

    public bool hasBadTiles => this.m_hasBadTiles;

    public bool isValid => this.m_isValid;

    public Lot.ExemplarTransitSettings TransitSettings
    {
      get => this.m_TransitSettings;
      set => this.m_TransitSettings = value;
    }

    public Lot.LotDefinition CommonDefs
    {
      get => this.m_CommonDefs;
      set => this.m_CommonDefs = value;
    }

    public int Breite => this.m_Breite;

    public int Hoehe => this.m_Hoehe;

    public LotTile[] Tiles
    {
      get => this.m_Tiles;
      set => this.m_Tiles = value;
    }

    public int Index
    {
      get => this.m_Index;
      set => this.m_Index = value;
    }

    public int ExemplarIndex
    {
      get => this.m_ExemplarIndex;
      set => this.m_ExemplarIndex = value;
    }

    public Lot(
      MainReader.Exemplar LotExemplar,
      int Index,
      MainReader.Exemplar BuildingExemplar,
      int ExIndex)
    {
      this.m_Index = -1;
      this.m_isValid = false;
      this.m_hasBadTiles = false;
      this.m_ExemplarIndex = -1;
      this.TileArray = new ArrayList();
      this.SuchArray = new ArrayList();
      this.BuildingSuchArray = new ArrayList();
      this.m_Breite = 0;
      this.m_Hoehe = 0;
      this.m_CommonDefs.Corner = (string) null;
      this.m_CommonDefs.ElevMax = 0.0f;
      this.m_CommonDefs.ElevMin = 0.0f;
      this.m_CommonDefs.Foundation = (string) null;
      this.m_CommonDefs.Growth = 0;
      this.m_CommonDefs.RetainingWall = (string) null;
      this.m_CommonDefs.Threshold = 0.0f;
      this.m_WerteListe = new AllgemeineKlasse.ValueList[0];
      this.m_Tiles = new LotTile[0];
      this.m_BuildingWerteListe = new AllgemeineKlasse.ValueList[0];
      this.Index = Index;
      this.ExemplarIndex = ExIndex;
      this.WerteArray = new ArrayList();
      this.TileArray = new ArrayList();
      this.SuchArray = new ArrayList();
      this.SuchArray.Add((object) "0X88FCD877");
      this.SuchArray.Add((object) "0X88EDC798");
      this.SuchArray.Add((object) "0X4A4A88F0");
      this.SuchArray.Add((object) "0X27812837");
      this.SuchArray.Add((object) "0X699B08A4");
      this.SuchArray.Add((object) "0XE99B068C");
      this.SuchArray.Add((object) "0X88EDC792");
      this.m_isValid = this.GetWerteFromExemplar(LotExemplar);
      this.m_TransitSettings.TransitSwitchPoint = (string[]) null;
      this.m_TransitSettings.TransitEntryCost = 0.0;
      this.m_TransitSettings.TransitCapacity = 0.0;
      this.BuildingWerteArray = new ArrayList();
      this.BuildingSuchArray = new ArrayList();
      this.BuildingSuchArray.Add((object) "0XE90E25A1");
      this.BuildingSuchArray.Add((object) "0XE90E25A2");
      this.BuildingSuchArray.Add((object) "0XE90E25A3");
      if (this.m_ExemplarIndex <= -1)
        return;
      this.GetWerteFromBuildingExemplar(BuildingExemplar);
    }

    public int SearchTile(Point SuchPoint) => this.TileArray.IndexOf((object) (SuchPoint.X.ToString() + ":" + SuchPoint.Y.ToString()));

    public LotTile.BitmapAusgabe[] GetTileBitmaps(int i)
    {
      Color transparentColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
      ArrayList arrayList = new ArrayList();
      LotTile.BitmapAusgabe[] bitmapAusgabeArray1 = new LotTile.BitmapAusgabe[0];
      LotTile.BitmapAusgabe[] bitmapAusgabeArray2 = new LotTile.BitmapAusgabe[0];
      LotTile.BitmapAusgabe[] bitmapAusgabeArray3 = new LotTile.BitmapAusgabe[0];
      LotTile.BitmapAusgabe[] bitmapAusgabeArray4 = new LotTile.BitmapAusgabe[0];
      if (this.m_Tiles[i].Bitmaps.GetUpperBound(0) > -1)
      {
        int upperBound = this.m_Tiles[i].Bitmaps.GetUpperBound(0);
        int index = 0;
        while (index <= upperBound)
        {
          string typ = this.m_Tiles[i].Bitmaps[index].Typ;
          if (StringType.StrCmp(typ, "Texture", false) == 0)
          {
            if (this.m_Tiles[i].Bitmaps[index].isBase)
            {
              bitmapAusgabeArray2 = (LotTile.BitmapAusgabe[]) Utils.CopyArray((Array) bitmapAusgabeArray2, (Array) new LotTile.BitmapAusgabe[checked (bitmapAusgabeArray2.GetUpperBound(0) + 1 + 1)]);
              bitmapAusgabeArray2[bitmapAusgabeArray2.GetUpperBound(0)] = this.m_Tiles[i].Bitmaps[index];
            }
            else
            {
              bitmapAusgabeArray3 = (LotTile.BitmapAusgabe[]) Utils.CopyArray((Array) bitmapAusgabeArray3, (Array) new LotTile.BitmapAusgabe[checked (bitmapAusgabeArray3.GetUpperBound(0) + 1 + 1)]);
              bitmapAusgabeArray3[bitmapAusgabeArray3.GetUpperBound(0)] = this.m_Tiles[i].Bitmaps[index];
            }
          }
          else if (StringType.StrCmp(typ, "TrafficArt", false) == 0 || StringType.StrCmp(typ, "TrafficDirection", false) == 0)
          {
            Bitmap ausgabeBild = this.m_Tiles[i].Bitmaps[index].AusgabeBild;
            ausgabeBild.MakeTransparent(transparentColor);
            bitmapAusgabeArray4 = (LotTile.BitmapAusgabe[]) Utils.CopyArray((Array) bitmapAusgabeArray4, (Array) new LotTile.BitmapAusgabe[checked (bitmapAusgabeArray4.GetUpperBound(0) + 1 + 1)]);
            bitmapAusgabeArray4[bitmapAusgabeArray4.GetUpperBound(0)] = this.m_Tiles[i].Bitmaps[index];
            bitmapAusgabeArray4[bitmapAusgabeArray4.GetUpperBound(0)].AusgabeBild = ausgabeBild;
          }
          else if (StringType.StrCmp(typ, "Water", false) == 0 || StringType.StrCmp(typ, "Land", false) == 0)
          {
            bitmapAusgabeArray4 = (LotTile.BitmapAusgabe[]) Utils.CopyArray((Array) bitmapAusgabeArray4, (Array) new LotTile.BitmapAusgabe[checked (bitmapAusgabeArray4.GetUpperBound(0) + 1 + 1)]);
            bitmapAusgabeArray4[bitmapAusgabeArray4.GetUpperBound(0)] = this.m_Tiles[i].Bitmaps[index];
          }
          checked { ++index; }
        }
      }
      if (bitmapAusgabeArray2.GetUpperBound(0) > -1)
      {
        int upperBound = bitmapAusgabeArray2.GetUpperBound(0);
        i = 0;
        while (i <= upperBound)
        {
          arrayList.Add((object) bitmapAusgabeArray2[i]);
          checked { ++i; }
        }
      }
      if (bitmapAusgabeArray3.GetUpperBound(0) > -1)
      {
        int upperBound = bitmapAusgabeArray3.GetUpperBound(0);
        i = 0;
        while (i <= upperBound)
        {
          arrayList.Add((object) bitmapAusgabeArray3[i]);
          checked { ++i; }
        }
      }
      if (bitmapAusgabeArray4.GetUpperBound(0) > -1)
      {
        int upperBound = bitmapAusgabeArray4.GetUpperBound(0);
        i = 0;
        while (i <= upperBound)
        {
          arrayList.Add((object) bitmapAusgabeArray4[i]);
          checked { ++i; }
        }
      }
      if (arrayList.Count > 0)
      {
        bitmapAusgabeArray1 = new LotTile.BitmapAusgabe[checked (arrayList.Count - 1 + 1)];
        arrayList.CopyTo((Array) bitmapAusgabeArray1);
      }
      return bitmapAusgabeArray1;
    }

    public bool AddTraffic(int i, string TrafficString, string DirectionString)
    {
      ArrayList Werte = new ArrayList();
      if (i < 0 || StringType.StrCmp(this.m_Tiles[i].TransitArt, "", false) != 0 || this.m_Tiles[i].isWater || this.m_Tiles[i].WerteString.Count == 0)
        return false;
      string[] strArray1 = (string[]) LateBinding.LateGet(this.m_Tiles[i].WerteString[0], (Type) null, "split", new object[1]
      {
        (object) ","
      }, (string[]) null, (bool[]) null);
      if (strArray1.GetUpperBound(0) == 12)
      {
        string[] strArray2 = (string[]) Utils.CopyArray((Array) strArray1, (Array) new string[15]);
        strArray2[0] = "0x00000007";
        strArray2[2] = "0x00000000";
        strArray2[12] = TrafficString;
        strArray2[13] = "0x00000000";
        strArray2[14] = DirectionString;
        int upperBound = strArray2.GetUpperBound(0);
        int index = 0;
        while (index <= upperBound)
        {
          Werte.Add((object) strArray2[index]);
          checked { ++index; }
        }
        this.m_Tiles[i].addWerte(Werte);
      }
      if (this.m_ExemplarIndex > -1)
      {
        if (Information.IsNothing((object) this.m_TransitSettings.TransitCapacity) | this.m_TransitSettings.TransitCapacity == 0.0)
          this.m_TransitSettings.TransitCapacity = 100.0;
        if (Information.IsNothing((object) this.m_TransitSettings.TransitEntryCost))
          this.m_TransitSettings.TransitEntryCost = 0.0;
        if (this.m_TransitSettings.TransitSwitchPoint.GetUpperBound(0) == -1)
        {
          string upper = TrafficString.ToUpper();
          if (StringType.StrCmp(upper, "0X00000003", false) == 0 || StringType.StrCmp(upper, "0X0000000A", false) == 0 || StringType.StrCmp(upper, "0X00000000", false) == 0 || StringType.StrCmp(upper, "0X00000006", false) == 0)
          {
            string str1 = "0X00000081,0X000000F0,0x00000000,0x00000000";
            int index1 = checked (this.m_TransitSettings.TransitSwitchPoint.GetUpperBound(0) + 1);
            this.m_TransitSettings.TransitSwitchPoint = (string[]) Utils.CopyArray((Array) this.m_TransitSettings.TransitSwitchPoint, (Array) new string[checked (index1 + 1)]);
            this.m_TransitSettings.TransitSwitchPoint[index1] = str1;
            string str2 = "0X00000082,0X000000F0,0x00000000,0x00000000";
            int index2 = checked (this.m_TransitSettings.TransitSwitchPoint.GetUpperBound(0) + 1);
            this.m_TransitSettings.TransitSwitchPoint = (string[]) Utils.CopyArray((Array) this.m_TransitSettings.TransitSwitchPoint, (Array) new string[checked (index2 + 1)]);
            this.m_TransitSettings.TransitSwitchPoint[index2] = str2;
            string str3 = "0X00000081,0X000000F0,0x00000001,0x00000001";
            int index3 = checked (this.m_TransitSettings.TransitSwitchPoint.GetUpperBound(0) + 1);
            this.m_TransitSettings.TransitSwitchPoint = (string[]) Utils.CopyArray((Array) this.m_TransitSettings.TransitSwitchPoint, (Array) new string[checked (index3 + 1)]);
            this.m_TransitSettings.TransitSwitchPoint[index3] = str3;
            string str4 = "0X00000082,0X000000F0,0x00000001,0x00000001";
            int index4 = checked (this.m_TransitSettings.TransitSwitchPoint.GetUpperBound(0) + 1);
            this.m_TransitSettings.TransitSwitchPoint = (string[]) Utils.CopyArray((Array) this.m_TransitSettings.TransitSwitchPoint, (Array) new string[checked (index4 + 1)]);
            this.m_TransitSettings.TransitSwitchPoint[index4] = str4;
            string str5 = "0X00000081,0X000000F0,0x00000002,0x00000002";
            int index5 = checked (this.m_TransitSettings.TransitSwitchPoint.GetUpperBound(0) + 1);
            this.m_TransitSettings.TransitSwitchPoint = (string[]) Utils.CopyArray((Array) this.m_TransitSettings.TransitSwitchPoint, (Array) new string[checked (index5 + 1)]);
            this.m_TransitSettings.TransitSwitchPoint[index5] = str5;
            string str6 = "0X00000082,0X000000F0,0x00000002,0x00000002";
            int index6 = checked (this.m_TransitSettings.TransitSwitchPoint.GetUpperBound(0) + 1);
            this.m_TransitSettings.TransitSwitchPoint = (string[]) Utils.CopyArray((Array) this.m_TransitSettings.TransitSwitchPoint, (Array) new string[checked (index6 + 1)]);
            this.m_TransitSettings.TransitSwitchPoint[index6] = str6;
            string str7 = "0X00000081,0X000000F0,0x00000004,0x00000004";
            int index7 = checked (this.m_TransitSettings.TransitSwitchPoint.GetUpperBound(0) + 1);
            this.m_TransitSettings.TransitSwitchPoint = (string[]) Utils.CopyArray((Array) this.m_TransitSettings.TransitSwitchPoint, (Array) new string[checked (index7 + 1)]);
            this.m_TransitSettings.TransitSwitchPoint[index7] = str7;
            string str8 = "0X00000082,0X000000F0,0x00000004,0x00000004";
            int index8 = checked (this.m_TransitSettings.TransitSwitchPoint.GetUpperBound(0) + 1);
            this.m_TransitSettings.TransitSwitchPoint = (string[]) Utils.CopyArray((Array) this.m_TransitSettings.TransitSwitchPoint, (Array) new string[checked (index8 + 1)]);
            this.m_TransitSettings.TransitSwitchPoint[index8] = str8;
          }
          else if (StringType.StrCmp(upper, "0X00000002", false) == 0 || StringType.StrCmp(upper, "0X0000000C", false) == 0)
          {
            string str9 = "0X00000081,0X000000F0,0x00000001,0x00000001";
            int index9 = checked (this.m_TransitSettings.TransitSwitchPoint.GetUpperBound(0) + 1);
            this.m_TransitSettings.TransitSwitchPoint = (string[]) Utils.CopyArray((Array) this.m_TransitSettings.TransitSwitchPoint, (Array) new string[checked (index9 + 1)]);
            this.m_TransitSettings.TransitSwitchPoint[index9] = str9;
            string str10 = "0X00000082,0X000000F0,0x00000001,0x00000001";
            int index10 = checked (this.m_TransitSettings.TransitSwitchPoint.GetUpperBound(0) + 1);
            this.m_TransitSettings.TransitSwitchPoint = (string[]) Utils.CopyArray((Array) this.m_TransitSettings.TransitSwitchPoint, (Array) new string[checked (index10 + 1)]);
            this.m_TransitSettings.TransitSwitchPoint[index10] = str10;
            string str11 = "0X00000081,0X000000F0,0x00000002,0x00000002";
            int index11 = checked (this.m_TransitSettings.TransitSwitchPoint.GetUpperBound(0) + 1);
            this.m_TransitSettings.TransitSwitchPoint = (string[]) Utils.CopyArray((Array) this.m_TransitSettings.TransitSwitchPoint, (Array) new string[checked (index11 + 1)]);
            this.m_TransitSettings.TransitSwitchPoint[index11] = str11;
            string str12 = "0X00000082,0X000000F0,0x00000002,0x00000002";
            int index12 = checked (this.m_TransitSettings.TransitSwitchPoint.GetUpperBound(0) + 1);
            this.m_TransitSettings.TransitSwitchPoint = (string[]) Utils.CopyArray((Array) this.m_TransitSettings.TransitSwitchPoint, (Array) new string[checked (index12 + 1)]);
            this.m_TransitSettings.TransitSwitchPoint[index12] = str12;
            string str13 = "0X00000081,0X000000F0,0x00000004,0x00000004";
            int index13 = checked (this.m_TransitSettings.TransitSwitchPoint.GetUpperBound(0) + 1);
            this.m_TransitSettings.TransitSwitchPoint = (string[]) Utils.CopyArray((Array) this.m_TransitSettings.TransitSwitchPoint, (Array) new string[checked (index13 + 1)]);
            this.m_TransitSettings.TransitSwitchPoint[index13] = str13;
            string str14 = "0X00000082,0X000000F0,0x00000004,0x00000004";
            int index14 = checked (this.m_TransitSettings.TransitSwitchPoint.GetUpperBound(0) + 1);
            this.m_TransitSettings.TransitSwitchPoint = (string[]) Utils.CopyArray((Array) this.m_TransitSettings.TransitSwitchPoint, (Array) new string[checked (index14 + 1)]);
            this.m_TransitSettings.TransitSwitchPoint[index14] = str14;
          }
          else if (StringType.StrCmp(upper, "0X00000001", false) == 0)
          {
            string str15 = "0X00000081,0X000000F0,0x00000003,0x00000003";
            int index15 = checked (this.m_TransitSettings.TransitSwitchPoint.GetUpperBound(0) + 1);
            this.m_TransitSettings.TransitSwitchPoint = (string[]) Utils.CopyArray((Array) this.m_TransitSettings.TransitSwitchPoint, (Array) new string[checked (index15 + 1)]);
            this.m_TransitSettings.TransitSwitchPoint[index15] = str15;
            string str16 = "0X00000082,0X000000F0,0x00000003,0x00000003";
            int index16 = checked (this.m_TransitSettings.TransitSwitchPoint.GetUpperBound(0) + 1);
            this.m_TransitSettings.TransitSwitchPoint = (string[]) Utils.CopyArray((Array) this.m_TransitSettings.TransitSwitchPoint, (Array) new string[checked (index16 + 1)]);
            this.m_TransitSettings.TransitSwitchPoint[index16] = str16;
            string str17 = "0X00000081,0X000000F0,0x00000005,0x00000005";
            int index17 = checked (this.m_TransitSettings.TransitSwitchPoint.GetUpperBound(0) + 1);
            this.m_TransitSettings.TransitSwitchPoint = (string[]) Utils.CopyArray((Array) this.m_TransitSettings.TransitSwitchPoint, (Array) new string[checked (index17 + 1)]);
            this.m_TransitSettings.TransitSwitchPoint[index17] = str17;
            string str18 = "0X00000082,0X000000F0,0x00000005,0x00000005";
            int index18 = checked (this.m_TransitSettings.TransitSwitchPoint.GetUpperBound(0) + 1);
            this.m_TransitSettings.TransitSwitchPoint = (string[]) Utils.CopyArray((Array) this.m_TransitSettings.TransitSwitchPoint, (Array) new string[checked (index18 + 1)]);
            this.m_TransitSettings.TransitSwitchPoint[index18] = str18;
          }
          else if (StringType.StrCmp(upper, "0X00000008", false) == 0)
          {
            string str19 = "0X00000081,0X000000F0,0x00000007,0x00000007";
            int index19 = checked (this.m_TransitSettings.TransitSwitchPoint.GetUpperBound(0) + 1);
            this.m_TransitSettings.TransitSwitchPoint = (string[]) Utils.CopyArray((Array) this.m_TransitSettings.TransitSwitchPoint, (Array) new string[checked (index19 + 1)]);
            this.m_TransitSettings.TransitSwitchPoint[index19] = str19;
            string str20 = "0X00000082,0X000000F0,0x00000007,0x00000007";
            int index20 = checked (this.m_TransitSettings.TransitSwitchPoint.GetUpperBound(0) + 1);
            this.m_TransitSettings.TransitSwitchPoint = (string[]) Utils.CopyArray((Array) this.m_TransitSettings.TransitSwitchPoint, (Array) new string[checked (index20 + 1)]);
            this.m_TransitSettings.TransitSwitchPoint[index20] = str20;
          }
          else if (StringType.StrCmp(upper, "0X00000009", false) == 0)
          {
            string str21 = "0X00000081,0X000000F0,0x00000008,0x00000008";
            int index21 = checked (this.m_TransitSettings.TransitSwitchPoint.GetUpperBound(0) + 1);
            this.m_TransitSettings.TransitSwitchPoint = (string[]) Utils.CopyArray((Array) this.m_TransitSettings.TransitSwitchPoint, (Array) new string[checked (index21 + 1)]);
            this.m_TransitSettings.TransitSwitchPoint[index21] = str21;
            string str22 = "0X00000082,0X000000F0,0x00000008,0x00000008";
            int index22 = checked (this.m_TransitSettings.TransitSwitchPoint.GetUpperBound(0) + 1);
            this.m_TransitSettings.TransitSwitchPoint = (string[]) Utils.CopyArray((Array) this.m_TransitSettings.TransitSwitchPoint, (Array) new string[checked (index22 + 1)]);
            this.m_TransitSettings.TransitSwitchPoint[index22] = str22;
          }
        }
      }
      return true;
    }

    public bool RemoveTraffic(int i)
    {
      ArrayList arrayList = new ArrayList();
      if (StringType.StrCmp(this.m_Tiles[i].TransitArt, "", false) == 0 || this.m_Tiles[i].WerteString.Count == 0)
        return false;
      this.m_Tiles[i].RemoveTraffic();
      int upperBound = this.m_Tiles.GetUpperBound(0);
      int index = 0;
      while (index <= upperBound)
      {
        if (StringType.StrCmp(this.m_Tiles[index].TransitArt, "", false) != 0)
          return true;
        checked { ++index; }
      }
      this.m_TransitSettings.TransitSwitchPoint = new string[0];
      this.m_TransitSettings.TransitCapacity = 0.0;
      this.m_TransitSettings.TransitEntryCost = 0.0;
      return true;
    }

    private bool GetWerteFromBuildingExemplar(MainReader.Exemplar BuildingExemplar)
    {
      ArrayList arrayList = new ArrayList();
      if (BuildingExemplar.Values.Count <= 0)
        return false;
      int num1 = checked (BuildingExemplar.Values.Count - 1);
      int index = 0;
      while (index <= num1)
      {
        this.BuildingWerteArray.Add(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(BuildingExemplar.Values[index], (Type) null, "Kennung", new object[0], (string[]) null, (bool[]) null), (Type) null, "toupper", new object[0], (string[]) null, (bool[]) null)));
        AllgemeineKlasse.ValueList valueList;
        valueList.Werte = new ArrayList();
        valueList.OriginalWerte = new ArrayList();
        valueList.Kennung = StringType.FromObject(LateBinding.LateGet(LateBinding.LateGet(BuildingExemplar.Values[index], (Type) null, "Kennung", new object[0], (string[]) null, (bool[]) null), (Type) null, "toupper", new object[0], (string[]) null, (bool[]) null));
        valueList.Typ = StringType.FromObject(LateBinding.LateGet(BuildingExemplar.Values[index], (Type) null, "Typ", new object[0], (string[]) null, (bool[]) null));
        valueList.KeyType = StringType.FromObject(LateBinding.LateGet(BuildingExemplar.Values[index], (Type) null, "KeyType", new object[0], (string[]) null, (bool[]) null));
        valueList.NumberOfValues = IntegerType.FromObject(LateBinding.LateGet(BuildingExemplar.Values[index], (Type) null, "NumberOfValues", new object[0], (string[]) null, (bool[]) null));
        int num2 = IntegerType.FromObject(ObjectType.SubObj(LateBinding.LateGet(LateBinding.LateGet(BuildingExemplar.Values[index], (Type) null, "Werte", new object[0], (string[]) null, (bool[]) null), (Type) null, "count", new object[0], (string[]) null, (bool[]) null), (object) 1));
        int num3 = 0;
        while (num3 <= num2)
        {
          ArrayList werte = valueList.Werte;
          object o1 = BuildingExemplar.Values[index];
          object[] objArray1 = new object[1]
          {
            (object) num3
          };
          object[] args1 = objArray1;
          bool[] flagArray1 = new bool[1]{ true };
          bool[] CopyBack1 = flagArray1;
          object obj1 = LateBinding.LateGet(o1, (Type) null, "Werte", args1, (string[]) null, CopyBack1);
          if (flagArray1[0])
            num3 = IntegerType.FromObject(objArray1[0]);
          object objectValue1 = RuntimeHelpers.GetObjectValue(obj1);
          werte.Add(objectValue1);
          ArrayList originalWerte = valueList.OriginalWerte;
          object o2 = BuildingExemplar.Values[index];
          object[] objArray2 = new object[1]
          {
            (object) num3
          };
          object[] args2 = objArray2;
          bool[] flagArray2 = new bool[1]{ true };
          bool[] CopyBack2 = flagArray2;
          object obj2 = LateBinding.LateGet(o2, (Type) null, "OriginalWerte", args2, (string[]) null, CopyBack2);
          if (flagArray2[0])
            num3 = IntegerType.FromObject(objArray2[0]);
          object objectValue2 = RuntimeHelpers.GetObjectValue(obj2);
          originalWerte.Add(objectValue2);
          checked { ++num3; }
        }
        arrayList.Add((object) valueList);
        checked { ++index; }
      }
      this.m_BuildingWerteListe = new AllgemeineKlasse.ValueList[checked (arrayList.Count - 1 + 1)];
      arrayList.CopyTo((Array) this.m_BuildingWerteListe);
      return this.GetBuildingWerte();
    }

    private bool GetWerteFromExemplar(MainReader.Exemplar LotExemplar)
    {
      ArrayList arrayList = new ArrayList();
      if (LotExemplar.Values.Count <= 0)
        return false;
      int num1 = checked (LotExemplar.Values.Count - 1);
      int index = 0;
      while (index <= num1)
      {
        this.WerteArray.Add(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(LotExemplar.Values[index], (Type) null, "Kennung", new object[0], (string[]) null, (bool[]) null), (Type) null, "toupper", new object[0], (string[]) null, (bool[]) null)));
        AllgemeineKlasse.ValueList valueList;
        valueList.Werte = new ArrayList();
        valueList.OriginalWerte = new ArrayList();
        valueList.Kennung = StringType.FromObject(LateBinding.LateGet(LateBinding.LateGet(LotExemplar.Values[index], (Type) null, "Kennung", new object[0], (string[]) null, (bool[]) null), (Type) null, "toupper", new object[0], (string[]) null, (bool[]) null));
        valueList.Typ = StringType.FromObject(LateBinding.LateGet(LotExemplar.Values[index], (Type) null, "Typ", new object[0], (string[]) null, (bool[]) null));
        valueList.KeyType = StringType.FromObject(LateBinding.LateGet(LotExemplar.Values[index], (Type) null, "KeyType", new object[0], (string[]) null, (bool[]) null));
        valueList.NumberOfValues = IntegerType.FromObject(LateBinding.LateGet(LotExemplar.Values[index], (Type) null, "NumberOfValues", new object[0], (string[]) null, (bool[]) null));
        int num2 = IntegerType.FromObject(ObjectType.SubObj(LateBinding.LateGet(LateBinding.LateGet(LotExemplar.Values[index], (Type) null, "Werte", new object[0], (string[]) null, (bool[]) null), (Type) null, "count", new object[0], (string[]) null, (bool[]) null), (object) 1));
        int num3 = 0;
        while (num3 <= num2)
        {
          ArrayList werte = valueList.Werte;
          object o1 = LotExemplar.Values[index];
          object[] objArray1 = new object[1]
          {
            (object) num3
          };
          object[] args1 = objArray1;
          bool[] flagArray1 = new bool[1]{ true };
          bool[] CopyBack1 = flagArray1;
          object obj1 = LateBinding.LateGet(o1, (Type) null, "Werte", args1, (string[]) null, CopyBack1);
          if (flagArray1[0])
            num3 = IntegerType.FromObject(objArray1[0]);
          object objectValue1 = RuntimeHelpers.GetObjectValue(obj1);
          werte.Add(objectValue1);
          ArrayList originalWerte = valueList.OriginalWerte;
          object o2 = LotExemplar.Values[index];
          object[] objArray2 = new object[1]
          {
            (object) num3
          };
          object[] args2 = objArray2;
          bool[] flagArray2 = new bool[1]{ true };
          bool[] CopyBack2 = flagArray2;
          object obj2 = LateBinding.LateGet(o2, (Type) null, "OriginalWerte", args2, (string[]) null, CopyBack2);
          if (flagArray2[0])
            num3 = IntegerType.FromObject(objArray2[0]);
          object objectValue2 = RuntimeHelpers.GetObjectValue(obj2);
          originalWerte.Add(objectValue2);
          checked { ++num3; }
        }
        arrayList.Add((object) valueList);
        checked { ++index; }
      }
      this.m_WerteListe = new AllgemeineKlasse.ValueList[checked (arrayList.Count - 1 + 1)];
      arrayList.CopyTo((Array) this.m_WerteListe);
      this.GetBreiteUndHoehe();
      if (this.m_Breite == 0 | this.m_Hoehe == 0)
        return false;
      this.GetTiles();
      return this.GetWerte();
    }

    private object GetBreiteUndHoehe()
    {
      try
      {
        int index1 = this.WerteArray.IndexOf((object) "0X88EDC790");
        if (index1 > -1)
        {
          if (this.m_WerteListe[index1].Werte.Count == 2 && Information.IsNumeric(RuntimeHelpers.GetObjectValue(this.m_WerteListe[index1].Werte[0])) && Information.IsNumeric(RuntimeHelpers.GetObjectValue(this.m_WerteListe[index1].Werte[1])))
          {
            int num1 = IntegerType.FromObject(this.m_WerteListe[index1].Werte[0]);
            int num2 = IntegerType.FromObject(this.m_WerteListe[index1].Werte[1]);
            if (num1 > 0 & num2 > 0)
            {
              this.m_Breite = num1;
              this.m_Hoehe = num2;
              int num3 = checked (this.m_Breite - 1);
              int RechtsWert = 0;
              while (RechtsWert <= num3)
              {
                int num4 = checked (this.m_Hoehe - 1);
                int HochWert = 0;
                while (HochWert <= num4)
                {
                  LotTile lotTile = new LotTile(RechtsWert, HochWert);
                  int index2 = checked (this.m_Tiles.GetUpperBound(0) + 1);
                  this.m_Tiles = (LotTile[]) Utils.CopyArray((Array) this.m_Tiles, (Array) new LotTile[checked (index2 + 1)]);
                  this.m_Tiles[index2] = lotTile;
                  this.TileArray.Add((object) (RechtsWert.ToString() + ":" + HochWert.ToString()));
                  checked { ++HochWert; }
                }
                checked { ++RechtsWert; }
              }
            }
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.m_Breite = 0;
        this.m_Hoehe = 0;
        ProjectData.ClearProjectError();
      }
      object obj;
      return obj;
    }

    private object GetTiles()
    {
      int upperBound = this.m_WerteListe.GetUpperBound(0);
      int index = 0;
      while (index <= upperBound)
      {
        if (this.m_WerteListe[index].Kennung.StartsWith("0X88EDC") && StringType.StrCmp(this.m_WerteListe[index].Kennung.Substring(7, 1), "7", false) != 0 && ObjectType.ObjTst(LateBinding.LateGet(this.m_WerteListe[index].OriginalWerte[0], (Type) null, "toupper", new object[0], (string[]) null, (bool[]) null), (object) "0X00000000", false) != 0 && ObjectType.ObjTst(LateBinding.LateGet(this.m_WerteListe[index].OriginalWerte[0], (Type) null, "toupper", new object[0], (string[]) null, (bool[]) null), (object) "0X00000001", false) != 0)
        {
          int lotTile = this.GetLotTile(this.m_WerteListe[index].OriginalWerte);
          if (lotTile > -1)
            this.m_Tiles[lotTile].addWerte(this.m_WerteListe[index].OriginalWerte);
          else
            this.m_hasBadTiles = true;
        }
        checked { ++index; }
      }
      object obj;
      return obj;
    }

    private int GetLotTile(ArrayList TempArray)
    {
      int num1 = -1;
      int num2 = -1;
      int num3 = -1;
      int num4 = 0;
      int num5 = 0;
      string str1 = TempArray[3].ToString().Substring(0, 5).Replace("0x", "&h");
      string str2 = TempArray[5].ToString().Substring(0, 5).Replace("0x", "&h");
      if (StringType.StrCmp(TempArray[3].ToString().Substring(5, 1), "0", false) != 0)
        num5 = 1;
      if (StringType.StrCmp(TempArray[3].ToString().Substring(5, 1), "0", false) != 0)
        num4 = 1;
      if (Information.IsNumeric((object) str2) & Information.IsNumeric((object) str1))
      {
        num2 = checked (IntegerType.FromString(str2) - 1 + num4);
        num3 = checked (IntegerType.FromString(str1) - 1 + num5);
        if (num3 > this.m_Breite)
          num3 = -1;
        if (num2 > this.m_Hoehe)
          num2 = -1;
      }
      if (num2 > -1 & num3 > -1)
        num1 = this.TileArray.IndexOf((object) (num3.ToString() + ":" + num2.ToString()));
      return num1;
    }

    private bool GetBuildingWerte()
    {
      bool flag;
      try
      {
        this.m_TransitSettings.TransitSwitchPoint = new string[0];
        int num1 = checked (this.BuildingSuchArray.Count - 1);
        int index1 = 0;
        while (index1 <= num1)
        {
          int index2 = this.BuildingWerteArray.IndexOf(RuntimeHelpers.GetObjectValue(this.BuildingSuchArray[index1]));
          if (index2 > -1)
          {
            object o1 = LateBinding.LateGet(this.BuildingSuchArray[index1], (Type) null, "toupper", new object[0], (string[]) null, (bool[]) null);
            if (ObjectType.ObjTst(o1, (object) "0XE90E25A1", false) == 0)
            {
              if (BooleanType.FromObject(ObjectType.BitOrObj((object) (ObjectType.ObjTst(LateBinding.LateGet(this.m_BuildingWerteListe[index2].OriginalWerte[0], (Type) null, "toupper", new object[0], (string[]) null, (bool[]) null), (object) "0X00000081", false) == 0), (object) (ObjectType.ObjTst(LateBinding.LateGet(this.m_BuildingWerteListe[index2].OriginalWerte[0], (Type) null, "toupper", new object[0], (string[]) null, (bool[]) null), (object) "0X00000082", false) == 0))))
              {
                int num2 = checked (this.m_BuildingWerteListe[index2].OriginalWerte.Count - 1);
                for (int index3 = 0; index3 <= num2; index3 = checked (index3 + 3 + 1))
                {
                  if (checked (index3 + 3) <= checked (this.m_BuildingWerteListe[index2].OriginalWerte.Count - 1))
                  {
                    string str = StringType.FromObject(LateBinding.LateGet(this.m_BuildingWerteListe[index2].OriginalWerte[index3], (Type) null, "ToUpper", new object[0], (string[]) null, (bool[]) null));
                    int num3 = checked (index3 + 1);
                    int num4 = checked (index3 + 3);
                    int index4 = num3;
                    while (index4 <= num4)
                    {
                      str = StringType.FromObject(ObjectType.StrCatObj((object) (str + ","), LateBinding.LateGet(this.m_BuildingWerteListe[index2].OriginalWerte[index4], (Type) null, "ToUpper", new object[0], (string[]) null, (bool[]) null)));
                      checked { ++index4; }
                    }
                    int index5 = checked (this.m_TransitSettings.TransitSwitchPoint.GetUpperBound(0) + 1);
                    this.m_TransitSettings.TransitSwitchPoint = (string[]) Utils.CopyArray((Array) this.m_TransitSettings.TransitSwitchPoint, (Array) new string[checked (index5 + 1)]);
                    this.m_TransitSettings.TransitSwitchPoint[index5] = str;
                  }
                }
              }
            }
            else if (ObjectType.ObjTst(o1, (object) "0XE90E25A2", false) == 0)
            {
              string str = this.m_BuildingWerteListe[index2].Werte[0].ToString();
              if (Information.IsNumeric((object) str))
                this.m_TransitSettings.TransitEntryCost = DoubleType.FromString(str);
            }
            else if (ObjectType.ObjTst(o1, (object) "0XE90E25A3", false) == 0)
            {
              string str = this.m_BuildingWerteListe[index2].Werte[0].ToString();
              if (Information.IsNumeric((object) str))
                this.m_TransitSettings.TransitCapacity = DoubleType.FromString(str);
            }
          }
          checked { ++index1; }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        flag = false;
        ProjectData.ClearProjectError();
        goto label_25;
      }
      flag = true;
label_25:
      return flag;
    }

    private bool GetWerte()
    {
      bool flag;
      try
      {
        int num = checked (this.SuchArray.Count - 1);
        int index1 = 0;
        while (index1 <= num)
        {
          int index2 = this.WerteArray.IndexOf(RuntimeHelpers.GetObjectValue(this.SuchArray[index1]));
          if (index2 > -1)
          {
            object o1_1 = LateBinding.LateGet(this.SuchArray[index1], (Type) null, "toupper", new object[0], (string[]) null, (bool[]) null);
            if (ObjectType.ObjTst(o1_1, (object) "0X88FCD877", false) == 0)
              this.m_CommonDefs.Foundation = this.m_WerteListe[index2].OriginalWerte[0].ToString();
            else if (ObjectType.ObjTst(o1_1, (object) "0X88EDC798", false) == 0)
              this.m_CommonDefs.RetainingWall = this.m_WerteListe[index2].OriginalWerte[0].ToString();
            else if (ObjectType.ObjTst(o1_1, (object) "0X4A4A88F0", false) == 0)
            {
              object o1_2 = LateBinding.LateGet(this.m_WerteListe[index2].OriginalWerte[0], (Type) null, "toupper", new object[0], (string[]) null, (bool[]) null);
              if (ObjectType.ObjTst(o1_2, (object) "0X00000008", false) == 0)
                this.m_CommonDefs.Corner = "Center";
              else if (ObjectType.ObjTst(o1_2, (object) "0X00000009", false) == 0)
                this.m_CommonDefs.Corner = "Left";
              else if (ObjectType.ObjTst(o1_2, (object) "0X0000000C", false) == 0)
                this.m_CommonDefs.Corner = "Right";
            }
            else if (ObjectType.ObjTst(o1_1, (object) "0X27812837", false) == 0)
            {
              if (Information.IsNumeric(RuntimeHelpers.GetObjectValue(this.m_WerteListe[index2].Werte[0])))
                this.m_CommonDefs.Growth = IntegerType.FromObject(this.m_WerteListe[index2].Werte[0]);
            }
            else if (ObjectType.ObjTst(o1_1, (object) "0X699B08A4", false) == 0)
            {
              if (Information.IsNumeric(RuntimeHelpers.GetObjectValue(this.m_WerteListe[index2].Werte[0])))
                this.m_CommonDefs.ElevMin = SingleType.FromObject(this.m_WerteListe[index2].Werte[0]);
            }
            else if (ObjectType.ObjTst(o1_1, (object) "0XE99B068C", false) == 0)
            {
              if (Information.IsNumeric(RuntimeHelpers.GetObjectValue(this.m_WerteListe[index2].Werte[0])))
                this.m_CommonDefs.ElevMax = SingleType.FromObject(this.m_WerteListe[index2].Werte[0]);
            }
            else if (ObjectType.ObjTst(o1_1, (object) "0X88EDC792", false) == 0 && Information.IsNumeric(RuntimeHelpers.GetObjectValue(this.m_WerteListe[index2].Werte[0])))
              this.m_CommonDefs.Threshold = SingleType.FromObject(this.m_WerteListe[index2].Werte[0]);
          }
          checked { ++index1; }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        flag = false;
        ProjectData.ClearProjectError();
        goto label_30;
      }
      flag = true;
label_30:
      return flag;
    }

    public bool Save(string LeseDatei, string SchreibDatei)
    {
      byte[] numArray1 = new byte[0];
      byte[] numArray2 = new byte[0];
      MainWriter.SaveListe[] saveListeArray1 = new MainWriter.SaveListe[0];
      if (!this.SetWerte())
        return false;
      byte[] lotExemplarBytes = this.GetLotExemplarBytes();
      if (lotExemplarBytes.GetUpperBound(0) < 0 || this.m_Index == -1)
        return false;
      byte[] buildingExemplarBytes = this.GetBuildingExemplarBytes();
      int index1 = checked (saveListeArray1.GetUpperBound(0) + 1);
      MainWriter.SaveListe[] saveListeArray2 = (MainWriter.SaveListe[]) Utils.CopyArray((Array) saveListeArray1, (Array) new MainWriter.SaveListe[checked (index1 + 1)]);
      saveListeArray2[index1].Index = this.m_Index;
      saveListeArray2[index1].ByteListe = lotExemplarBytes;
      if (this.m_ExemplarIndex > -1 && buildingExemplarBytes.GetUpperBound(0) > -1)
      {
        int index2 = checked (saveListeArray2.GetUpperBound(0) + 1);
        saveListeArray2 = (MainWriter.SaveListe[]) Utils.CopyArray((Array) saveListeArray2, (Array) new MainWriter.SaveListe[checked (index2 + 1)]);
        saveListeArray2[index2].Index = this.m_ExemplarIndex;
        saveListeArray2[index2].ByteListe = buildingExemplarBytes;
      }
      MainWriter mainWriter = new MainWriter();
      mainWriter.LeseDatei = LeseDatei;
      mainWriter.SaveIndexes = saveListeArray2;
      mainWriter.CreateBackup = ClassThisProg.DefReader.CreateBackup;
      bool sc4 = mainWriter.SaveToSC4();
      mainWriter.Dispose();
      return sc4;
    }

    private byte[] GetBuildingExemplarBytes()
    {
      MemoryStream memoryStream = new MemoryStream();
      ArrayList arrayList1 = new ArrayList();
      ArrayList arrayList2 = new ArrayList();
      byte[] numArray1 = new byte[0];
      byte[] numArray2;
      try
      {
        ArrayList buildingBytes = this.GetBuildingBytes();
        if (this.m_BuildingPropertyCount == 0)
          return numArray1;
        ArrayList exemplarHeader = AllgemeineKlasse.GetExemplarHeader(this.m_BuildingPropertyCount, this.m_BuildingWerteListe[0].Werte);
        if (exemplarHeader.Count > 0)
        {
          exemplarHeader.AddRange((ICollection) buildingBytes);
          numArray2 = new byte[checked (exemplarHeader.Count - 1 + 1)];
          exemplarHeader.CopyTo((Array) numArray2);
        }
        else
          numArray2 = new byte[0];
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        numArray2 = new byte[0];
        ProjectData.ClearProjectError();
      }
      return numArray2;
    }

    private ArrayList GetBuildingBytes()
    {
      ArrayList arrayList1 = new ArrayList();
      ArrayList arrayList2 = new ArrayList();
      this.m_BuildingPropertyCount = -1;
      int upperBound1 = this.m_BuildingWerteListe.GetUpperBound(0);
      int index1 = 0;
      while (index1 <= upperBound1)
      {
        arrayList2.Clear();
        string upper = this.m_BuildingWerteListe[index1].Kennung.ToString().ToUpper();
        if (StringType.StrCmp(upper, "0XE90E25A1", false) != 0 & StringType.StrCmp(upper, "0XE90E25A2", false) != 0 & StringType.StrCmp(upper, "0XE90E25A3", false) != 0)
        {
          if (StringType.StrCmp(upper, "0XEA3209F8", false) == 0)
            Console.WriteLine("Hallo");
          if (this.m_BuildingWerteListe[index1].OriginalWerte.Count > 0)
          {
            arrayList2 = AllgemeineKlasse.GetBytes(this.m_BuildingWerteListe[index1]);
            arrayList1.AddRange((ICollection) arrayList2);
            checked { ++this.m_BuildingPropertyCount; }
          }
        }
        checked { ++index1; }
      }
      arrayList2.Clear();
      this.SetBuildingWerte();
      if (this.m_TempWerteListe.GetUpperBound(0) > -1)
      {
        int upperBound2 = this.m_TempWerteListe.GetUpperBound(0);
        int index2 = 0;
        while (index2 <= upperBound2)
        {
          if (this.m_TempWerteListe[index2].Werte.Count > 0)
          {
            ArrayList bytes = AllgemeineKlasse.GetBytes(this.m_TempWerteListe[index2]);
            arrayList1.AddRange((ICollection) bytes);
            checked { ++this.m_BuildingPropertyCount; }
          }
          checked { ++index2; }
        }
      }
      return arrayList1;
    }

    private object SetBuildingWerte()
    {
      this.m_TempWerteListe = new AllgemeineKlasse.ValueList[0];
      if (this.m_TransitSettings.TransitSwitchPoint.GetUpperBound(0) > -1)
      {
        AllgemeineKlasse.ValueList valueList;
        valueList.Kennung = "0XE90E25A1";
        valueList.Typ = "UINT8";
        valueList.KeyType = "80";
        valueList.Werte = new ArrayList();
        int num = 0;
        int upperBound1 = this.m_TransitSettings.TransitSwitchPoint.GetUpperBound(0);
        int index1 = 0;
        while (index1 <= upperBound1)
        {
          string[] strArray = this.m_TransitSettings.TransitSwitchPoint[index1].Split(',');
          if (strArray.GetUpperBound(0) == 3)
          {
            checked { num += 4; }
            int upperBound2 = strArray.GetUpperBound(0);
            int index2 = 0;
            while (index2 <= upperBound2)
            {
              valueList.Werte.Add((object) IntegerType.FromString(strArray[index2].ToUpper().Replace("0X", "&h")));
              checked { ++index2; }
            }
          }
          checked { ++index1; }
        }
        if (num > 0)
        {
          valueList.NumberOfValues = num;
          int index3 = checked (this.m_TempWerteListe.GetUpperBound(0) + 1);
          this.m_TempWerteListe = (AllgemeineKlasse.ValueList[]) Utils.CopyArray((Array) this.m_TempWerteListe, (Array) new AllgemeineKlasse.ValueList[checked (index3 + 1)]);
          this.m_TempWerteListe[index3] = valueList;
        }
        valueList.Kennung = "0XE90E25A2";
        valueList.Typ = "FLOAT32";
        valueList.KeyType = "80";
        valueList.NumberOfValues = 1;
        valueList.Werte = new ArrayList();
        if (!Information.IsNothing((object) this.m_TransitSettings.TransitEntryCost))
          valueList.Werte.Add((object) this.m_TransitSettings.TransitEntryCost);
        else
          valueList.Werte.Add((object) 1);
        int index4 = checked (this.m_TempWerteListe.GetUpperBound(0) + 1);
        this.m_TempWerteListe = (AllgemeineKlasse.ValueList[]) Utils.CopyArray((Array) this.m_TempWerteListe, (Array) new AllgemeineKlasse.ValueList[checked (index4 + 1)]);
        this.m_TempWerteListe[index4] = valueList;
        valueList.Kennung = "0XE90E25A3";
        valueList.Typ = "FLOAT32";
        valueList.KeyType = "80";
        valueList.NumberOfValues = 1;
        valueList.Werte = new ArrayList();
        if (!Information.IsNothing((object) this.m_TransitSettings.TransitCapacity))
          valueList.Werte.Add((object) this.m_TransitSettings.TransitCapacity);
        else
          valueList.Werte.Add((object) 1000);
        int index5 = checked (this.m_TempWerteListe.GetUpperBound(0) + 1);
        this.m_TempWerteListe = (AllgemeineKlasse.ValueList[]) Utils.CopyArray((Array) this.m_TempWerteListe, (Array) new AllgemeineKlasse.ValueList[checked (index5 + 1)]);
        this.m_TempWerteListe[index5] = valueList;
      }
      object obj;
      return obj;
    }

    private byte[] GetLotExemplarBytes()
    {
      ArrayList arrayList1 = new ArrayList();
      ArrayList arrayList2 = new ArrayList();
      byte[] numArray1 = new byte[0];
      byte[] numArray2;
      try
      {
        ArrayList lotBytes = this.GetLotBytes();
        if (this.m_PropertyCount == 0)
          return numArray1;
        ArrayList exemplarHeader = AllgemeineKlasse.GetExemplarHeader(this.m_PropertyCount, this.m_WerteListe[0].Werte);
        if (exemplarHeader.Count > 0)
        {
          exemplarHeader.AddRange((ICollection) lotBytes);
          numArray2 = new byte[checked (exemplarHeader.Count - 1 + 1)];
          exemplarHeader.CopyTo((Array) numArray2);
        }
        else
          numArray2 = new byte[0];
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        numArray2 = new byte[0];
        ProjectData.ClearProjectError();
      }
      return numArray2;
    }

    private ArrayList GetLotBytes()
    {
      ArrayList arrayList1 = new ArrayList();
      ArrayList arrayList2 = new ArrayList();
      int int32 = Convert.ToInt32(-1997682432);
      int index1;
      if (!this.m_WerteListe[index1].Kennung.StartsWith("0X88EDC"))
        ;
      int upperBound1 = this.m_Tiles.GetUpperBound(0);
      int index2 = 0;
      while (index2 <= upperBound1)
      {
        this.m_Tiles[index2].SaveWerteString = (ArrayList) this.m_Tiles[index2].WerteString.Clone();
        checked { ++index2; }
      }
      this.m_PropertyCount = -1;
      int upperBound2 = this.m_WerteListe.GetUpperBound(0);
      int index3 = 0;
      while (index3 <= upperBound2)
      {
        arrayList2.Clear();
        if (this.m_WerteListe[index3].Kennung.ToString().ToUpper().StartsWith("0X88EDC"))
        {
          if (StringType.StrCmp(this.m_WerteListe[index3].Kennung.Substring(7, 1), "7", false) != 0)
          {
            if (this.m_WerteListe[index3].OriginalWerte.Count > 11)
            {
              string upper = StringType.FromObject(this.m_WerteListe[index3].OriginalWerte[0]).ToUpper();
              if (StringType.StrCmp(upper, "0X00000000", false) == 0 || StringType.StrCmp(upper, "0X00000001", false) == 0)
              {
                string Werte = StringType.FromObject(this.m_WerteListe[index3].OriginalWerte[0]);
                int num = checked (this.m_WerteListe[index3].OriginalWerte.Count - 1);
                int index4 = 1;
                while (index4 <= num)
                {
                  Werte = StringType.FromObject(ObjectType.StrCatObj((object) (Werte + ","), this.m_WerteListe[index3].OriginalWerte[index4]));
                  checked { ++index4; }
                }
                arrayList2 = this.GetWerteBytes(int32, Werte);
                arrayList1.AddRange((ICollection) arrayList2);
                checked { ++int32; }
                checked { ++this.m_PropertyCount; }
              }
              else if (StringType.StrCmp(upper, "0X00000002", false) == 0 || StringType.StrCmp(upper, "0X00000007", false) == 0 || StringType.StrCmp(upper, "0X00000005", false) == 0 || StringType.StrCmp(upper, "0X00000006", false) == 0)
              {
                int lotTile = this.GetLotTile(this.m_WerteListe[index3].OriginalWerte);
                if (lotTile > -1 && this.m_Tiles[lotTile].WerteString.Count > 0)
                {
                  int num = checked (this.m_Tiles[lotTile].WerteString.Count - 1);
                  int index5 = 0;
                  while (index5 <= num)
                  {
                    if (ObjectType.ObjTst(this.m_Tiles[lotTile].WerteString[index5], (object) "", false) != 0)
                    {
                      arrayList2 = this.GetWerteBytes(int32, StringType.FromObject(this.m_Tiles[lotTile].WerteString[index5]));
                      arrayList1.AddRange((ICollection) arrayList2);
                      checked { ++int32; }
                      checked { ++this.m_PropertyCount; }
                      this.m_Tiles[lotTile].SaveWerteString[index5] = RuntimeHelpers.GetObjectValue(this.m_Tiles[lotTile].WerteString[index5]);
                      this.m_Tiles[lotTile].WerteString[index5] = (object) "";
                    }
                    checked { ++index5; }
                  }
                }
              }
              else if (this.m_WerteListe[index3].Werte.Count > 0)
              {
                arrayList2 = AllgemeineKlasse.GetBytes(this.m_WerteListe[index3]);
                arrayList1.AddRange((ICollection) arrayList2);
                checked { ++this.m_PropertyCount; }
              }
            }
          }
          else if (this.m_WerteListe[index3].Werte.Count > 0)
          {
            arrayList2 = AllgemeineKlasse.GetBytes(this.m_WerteListe[index3]);
            arrayList1.AddRange((ICollection) arrayList2);
            checked { ++this.m_PropertyCount; }
          }
        }
        else if (this.m_WerteListe[index3].Werte.Count > 0)
        {
          arrayList2 = AllgemeineKlasse.GetBytes(this.m_WerteListe[index3]);
          arrayList1.AddRange((ICollection) arrayList2);
          checked { ++this.m_PropertyCount; }
        }
        checked { ++index3; }
      }
      int upperBound3 = this.m_Tiles.GetUpperBound(0);
      int index6 = 0;
      while (index6 <= upperBound3)
      {
        int num = checked (this.m_Tiles[index6].SaveWerteString.Count - 1);
        int index7 = 0;
        while (index7 <= num)
        {
          this.m_Tiles[index6].WerteString[index7] = RuntimeHelpers.GetObjectValue(this.m_Tiles[index6].SaveWerteString[index7]);
          checked { ++index7; }
        }
        checked { ++index6; }
      }
      return arrayList1;
    }

    private ArrayList GetWerteBytes(int Nummer, string Werte)
    {
      MemoryStream memoryStream = new MemoryStream();
      ArrayList arrayList = new ArrayList();
      BinaryWriter binaryWriter = new BinaryWriter((Stream) memoryStream);
      string[] strArray = Werte.Split(',');
      if (strArray.GetUpperBound(0) > -1)
      {
        binaryWriter.Write(Nummer);
        binaryWriter.Write(Convert.ToUInt16(768));
        binaryWriter.Write(Convert.ToUInt16(128));
        binaryWriter.Write(Convert.ToByte(0));
        binaryWriter.Write(Convert.ToUInt32(checked (strArray.GetUpperBound(0) + 1)));
        int upperBound = strArray.GetUpperBound(0);
        int index = 0;
        while (index <= upperBound)
        {
          string str = StringType.FromLong(LongType.FromString(strArray[index].ToUpper().Replace("0X", "&H")));
          binaryWriter.Write(Convert.ToUInt32(str));
          checked { ++index; }
        }
      }
      byte[] array = memoryStream.ToArray();
      binaryWriter.Close();
      memoryStream.Close();
      int upperBound1 = array.GetUpperBound(0);
      int index1 = 0;
      while (index1 <= upperBound1)
      {
        arrayList.Add((object) array[index1]);
        checked { ++index1; }
      }
      return arrayList;
    }

    private bool SetWerte()
    {
      bool flag;
      try
      {
        int num = checked (this.SuchArray.Count - 1);
        int index1 = 0;
        while (index1 <= num)
        {
          int index2 = this.WerteArray.IndexOf(RuntimeHelpers.GetObjectValue(this.SuchArray[index1]));
          if (index2 > -1)
          {
            object o1 = LateBinding.LateGet(this.SuchArray[index1], (Type) null, "toupper", new object[0], (string[]) null, (bool[]) null);
            if (ObjectType.ObjTst(o1, (object) "0X88EDC798", false) == 0)
            {
              if (!Information.IsNothing((object) this.m_CommonDefs.RetainingWall))
                this.m_WerteListe[index2].Werte[0] = (object) LongType.FromString(this.m_CommonDefs.RetainingWall.ToUpper().Replace("0X", "&h"));
            }
            else if (ObjectType.ObjTst(o1, (object) "0X4A4A88F0", false) == 0)
            {
              string corner = this.m_CommonDefs.Corner;
              if (StringType.StrCmp(corner, "Center", false) == 0)
                this.m_WerteListe[index2].OriginalWerte[0] = (object) 8;
              else if (StringType.StrCmp(corner, "Left", false) == 0)
                this.m_WerteListe[index2].OriginalWerte[0] = (object) 9;
              else if (StringType.StrCmp(corner, "Right", false) == 0)
                this.m_WerteListe[index2].OriginalWerte[0] = (object) 12;
            }
          }
          checked { ++index1; }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        flag = false;
        ProjectData.ClearProjectError();
        goto label_19;
      }
      flag = true;
label_19:
      return flag;
    }

    public struct LotDefinition
    {
      public string RetainingWall;
      public float Threshold;
      public string Foundation;
      public int Growth;
      public float ElevMax;
      public float ElevMin;
      public string Corner;
    }

    public struct ExemplarTransitSettings
    {
      public double TransitCapacity;
      public double TransitEntryCost;
      public string[] TransitSwitchPoint;
    }
  }
}
