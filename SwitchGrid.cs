// Decompiled with JetBrains decompiler
// Type: SC4Tool.SwitchGrid
// Assembly: SC4Tool, Version=2.2.7.0, Culture=neutral, PublicKeyToken=null
// MVID: 69A50BC4-87A5-4C5E-BEFC-08274BC6D498
// Assembly location: C:\Program Files (x86)\SC4 Utilities\SC4Tool\SC4Tool.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using sr_SourceGrid;
using sr_SourceGrid.Cells;
using sr_SourceGrid.Cells.Real;
using sr_SourceGrid.DataModels;
using sr_SourceGrid.VisualModels;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using TD.SandBar;

namespace SC4Tool
{
  public class SwitchGrid : UserControl
  {
    [AccessedThroughProperty("FlatComboBox1")]
    private FlatComboBox _FlatComboBox1;
    [AccessedThroughProperty("FlatComboBox2")]
    private FlatComboBox _FlatComboBox2;
    [AccessedThroughProperty("Grid1")]
    private Grid _Grid1;
    [AccessedThroughProperty("FlatComboBox3")]
    private FlatComboBox _FlatComboBox3;
    [AccessedThroughProperty("PictureBox11")]
    private PictureBox _PictureBox11;
    [AccessedThroughProperty("CheckSouth")]
    private System.Windows.Forms.CheckBox _CheckSouth;
    [AccessedThroughProperty("CheckWest")]
    private System.Windows.Forms.CheckBox _CheckWest;
    [AccessedThroughProperty("CheckEast")]
    private System.Windows.Forms.CheckBox _CheckEast;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("Label3")]
    private Label _Label3;
    [AccessedThroughProperty("Label2")]
    private Label _Label2;
    [AccessedThroughProperty("CheckNorth")]
    private System.Windows.Forms.CheckBox _CheckNorth;
    private IContainer components;
    private Common l_CenterModel;
    private ICell AusgabeZelle1;
    private ICell AusgabeZelle2;
    private ICell AusgabeZelle3;
    private ICell AusgabeZelle4;
    private ArrayList TransitTypeDefWerte;
    private ArrayList TransitTypeArtWerte;
    private ArrayList TransitTypeArtListe;
    private ArrayList m_TransitTypeListe;
    private bool m_North;
    private bool m_West;
    private bool m_South;
    private bool m_East;
    private bool isLoading;

    public SwitchGrid()
    {
      this.l_CenterModel = new Common(false);
      this.TransitTypeDefWerte = new ArrayList();
      this.TransitTypeArtWerte = new ArrayList();
      this.TransitTypeArtListe = new ArrayList();
      this.m_TransitTypeListe = new ArrayList();
      this.m_North = false;
      this.m_West = false;
      this.m_South = false;
      this.m_East = false;
      this.isLoading = false;
      this.InitializeComponent();
      this.l_CenterModel.Font = this.Font;
      this.l_CenterModel.TextAlignment = SourceLibrary.Drawing.ContentAlignment.MiddleCenter;
      this.Grid1.RowsCount = 1;
      this.Grid1.ColumnsCount = 4;
      this.Grid1.Selection.SelectionMode = GridSelectionMode.Row;
      int num1 = checked (this.Grid1.ColumnsCount - 1);
      int p = 0;
      while (p <= num1)
      {
        this.Grid1.Columns[p].Width = 80;
        checked { ++p; }
      }
      this.Grid1.Width = checked (this.Grid1.ColumnsCount * 90 + 10);
      this.AusgabeZelle1 = (ICell) new Cell((object) "", (IDataModel) null, (IVisualModel) this.l_CenterModel);
      this.AusgabeZelle2 = (ICell) new Cell((object) "", (IDataModel) null, (IVisualModel) this.l_CenterModel);
      this.AusgabeZelle3 = (ICell) new Cell((object) "", (IDataModel) null, (IVisualModel) this.l_CenterModel);
      this.AusgabeZelle4 = (ICell) new Cell((object) "", (IDataModel) null, (IVisualModel) this.l_CenterModel);
      this.Grid1[checked (this.Grid1.RowsCount - 1), 0] = this.AusgabeZelle1;
      this.Grid1[checked (this.Grid1.RowsCount - 1), 1] = this.AusgabeZelle2;
      this.Grid1[checked (this.Grid1.RowsCount - 1), 2] = this.AusgabeZelle3;
      this.Grid1[checked (this.Grid1.RowsCount - 1), 3] = this.AusgabeZelle4;
      this.m_TransitTypeListe.Add((object) "Pedestrians");
      this.m_TransitTypeListe.Add((object) "Car");
      this.m_TransitTypeListe.Add((object) "Bus");
      this.m_TransitTypeListe.Add((object) "Train");
      this.m_TransitTypeListe.Add((object) "Fraight Truck");
      this.m_TransitTypeListe.Add((object) "Fraight Train");
      this.m_TransitTypeListe.Add((object) "Subway");
      this.m_TransitTypeListe.Add((object) "EL Train");
      this.m_TransitTypeListe.Add((object) "Monorail");
      this.TransitTypeDefWerte.Add((object) "0x00000000");
      this.TransitTypeDefWerte.Add((object) "0x00000001");
      this.TransitTypeDefWerte.Add((object) "0x00000002");
      this.TransitTypeDefWerte.Add((object) "0x00000003");
      this.TransitTypeDefWerte.Add((object) "0x00000004");
      this.TransitTypeDefWerte.Add((object) "0x00000005");
      this.TransitTypeDefWerte.Add((object) "0x00000006");
      this.TransitTypeDefWerte.Add((object) "0x00000007");
      this.TransitTypeDefWerte.Add((object) "0x00000008");
      this.TransitTypeArtWerte.Add((object) "0x00000081");
      this.TransitTypeArtWerte.Add((object) "0x00000082");
      this.TransitTypeArtListe.Add((object) "Outside to Inside");
      this.TransitTypeArtListe.Add((object) "Inside to Outside");
      int num2 = checked (this.TransitTypeArtListe.Count - 1);
      int index1 = 0;
      while (index1 <= num2)
      {
        this.FlatComboBox3.Items.Add(RuntimeHelpers.GetObjectValue(this.TransitTypeArtListe[index1]));
        checked { ++index1; }
      }
      int num3 = checked (this.m_TransitTypeListe.Count - 1);
      int index2 = 0;
      while (index2 <= num3)
      {
        this.FlatComboBox1.Items.Add(RuntimeHelpers.GetObjectValue(this.m_TransitTypeListe[index2]));
        this.FlatComboBox2.Items.Add(RuntimeHelpers.GetObjectValue(this.m_TransitTypeListe[index2]));
        checked { ++index2; }
      }
      this.FlatComboBox1.SelectedIndex = 0;
      this.FlatComboBox2.SelectedIndex = 0;
      this.FlatComboBox3.SelectedIndex = 0;
      this.CheckNorth.Checked = true;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    internal virtual System.Windows.Forms.CheckBox CheckWest
    {
      get => this._CheckWest;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._CheckWest != null)
          this._CheckWest.CheckedChanged -= new EventHandler(this.CheckWest_CheckedChanged);
        this._CheckWest = value;
        if (this._CheckWest == null)
          return;
        this._CheckWest.CheckedChanged += new EventHandler(this.CheckWest_CheckedChanged);
      }
    }

    internal virtual System.Windows.Forms.CheckBox CheckEast
    {
      get => this._CheckEast;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._CheckEast != null)
          this._CheckEast.CheckedChanged -= new EventHandler(this.CheckEast_CheckedChanged);
        this._CheckEast = value;
        if (this._CheckEast == null)
          return;
        this._CheckEast.CheckedChanged += new EventHandler(this.CheckEast_CheckedChanged);
      }
    }

    internal virtual System.Windows.Forms.CheckBox CheckSouth
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._CheckSouth != null)
          this._CheckSouth.CheckedChanged -= new EventHandler(this.CheckSouth_CheckedChanged);
        this._CheckSouth = value;
        if (this._CheckSouth == null)
          return;
        this._CheckSouth.CheckedChanged += new EventHandler(this.CheckSouth_CheckedChanged);
      }
      get => this._CheckSouth;
    }

    internal virtual System.Windows.Forms.CheckBox CheckNorth
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._CheckNorth != null)
          this._CheckNorth.CheckedChanged -= new EventHandler(this.CheckNorth_CheckedChanged);
        this._CheckNorth = value;
        if (this._CheckNorth == null)
          return;
        this._CheckNorth.CheckedChanged += new EventHandler(this.CheckNorth_CheckedChanged);
      }
      get => this._CheckNorth;
    }

    internal virtual FlatComboBox FlatComboBox1
    {
      get => this._FlatComboBox1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._FlatComboBox1 != null)
          this._FlatComboBox1.SelectedIndexChanged -= new EventHandler(this.FlatComboBox1_SelectedIndexChanged);
        this._FlatComboBox1 = value;
        if (this._FlatComboBox1 == null)
          return;
        this._FlatComboBox1.SelectedIndexChanged += new EventHandler(this.FlatComboBox1_SelectedIndexChanged);
      }
    }

    internal virtual FlatComboBox FlatComboBox2
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._FlatComboBox2 != null)
          this._FlatComboBox2.SelectedIndexChanged -= new EventHandler(this.FlatComboBox2_SelectedIndexChanged);
        this._FlatComboBox2 = value;
        if (this._FlatComboBox2 == null)
          return;
        this._FlatComboBox2.SelectedIndexChanged += new EventHandler(this.FlatComboBox2_SelectedIndexChanged);
      }
      get => this._FlatComboBox2;
    }

    internal virtual PictureBox PictureBox11
    {
      get => this._PictureBox11;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._PictureBox11 == null)
          ;
        this._PictureBox11 = value;
        if (this._PictureBox11 == null)
          ;
      }
    }

    internal virtual Grid Grid1
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Grid1 == null)
          ;
        this._Grid1 = value;
        if (this._Grid1 == null)
          ;
      }
      get => this._Grid1;
    }

    internal virtual Label Label1
    {
      get => this._Label1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Label1 == null)
          ;
        this._Label1 = value;
        if (this._Label1 == null)
          ;
      }
    }

    internal virtual Label Label2
    {
      get => this._Label2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Label2 == null)
          ;
        this._Label2 = value;
        if (this._Label2 == null)
          ;
      }
    }

    internal virtual Label Label3
    {
      get => this._Label3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Label3 == null)
          ;
        this._Label3 = value;
        if (this._Label3 == null)
          ;
      }
    }

    internal virtual FlatComboBox FlatComboBox3
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._FlatComboBox3 != null)
          this._FlatComboBox3.SelectedIndexChanged -= new EventHandler(this.FlatComboBox3_SelectedIndexChanged);
        this._FlatComboBox3 = value;
        if (this._FlatComboBox3 == null)
          return;
        this._FlatComboBox3.SelectedIndexChanged += new EventHandler(this.FlatComboBox3_SelectedIndexChanged);
      }
      get => this._FlatComboBox3;
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      ResourceManager resourceManager = new ResourceManager(typeof (SwitchGrid));
      this.CheckWest = new System.Windows.Forms.CheckBox();
      this.CheckEast = new System.Windows.Forms.CheckBox();
      this.CheckSouth = new System.Windows.Forms.CheckBox();
      this.CheckNorth = new System.Windows.Forms.CheckBox();
      this.FlatComboBox2 = new FlatComboBox();
      this.FlatComboBox1 = new FlatComboBox();
      this.PictureBox11 = new PictureBox();
      this.Grid1 = new Grid();
      this.Label1 = new Label();
      this.Label2 = new Label();
      this.Label3 = new Label();
      this.FlatComboBox3 = new FlatComboBox();
      this.SuspendLayout();
      this.CheckWest.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
      System.Windows.Forms.CheckBox checkWest1 = this.CheckWest;
      Point point1 = new Point(20, 60);
      Point point2 = point1;
      checkWest1.Location = point2;
      this.CheckWest.Name = "CheckWest";
      System.Windows.Forms.CheckBox checkWest2 = this.CheckWest;
      Size size1 = new Size(13, 13);
      Size size2 = size1;
      checkWest2.Size = size2;
      this.CheckWest.TabIndex = 163;
      this.CheckEast.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
      System.Windows.Forms.CheckBox checkEast1 = this.CheckEast;
      point1 = new Point(80, 60);
      Point point3 = point1;
      checkEast1.Location = point3;
      this.CheckEast.Name = "CheckEast";
      System.Windows.Forms.CheckBox checkEast2 = this.CheckEast;
      size1 = new Size(13, 13);
      Size size3 = size1;
      checkEast2.Size = size3;
      this.CheckEast.TabIndex = 162;
      this.CheckSouth.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
      System.Windows.Forms.CheckBox checkSouth1 = this.CheckSouth;
      point1 = new Point(52, 88);
      Point point4 = point1;
      checkSouth1.Location = point4;
      this.CheckSouth.Name = "CheckSouth";
      System.Windows.Forms.CheckBox checkSouth2 = this.CheckSouth;
      size1 = new Size(13, 13);
      Size size4 = size1;
      checkSouth2.Size = size4;
      this.CheckSouth.TabIndex = 161;
      this.CheckNorth.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
      System.Windows.Forms.CheckBox checkNorth1 = this.CheckNorth;
      point1 = new Point(52, 28);
      Point point5 = point1;
      checkNorth1.Location = point5;
      this.CheckNorth.Name = "CheckNorth";
      System.Windows.Forms.CheckBox checkNorth2 = this.CheckNorth;
      size1 = new Size(13, 13);
      Size size5 = size1;
      checkNorth2.Size = size5;
      this.CheckNorth.TabIndex = 160;
      this.FlatComboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
      FlatComboBox flatComboBox2_1 = this.FlatComboBox2;
      point1 = new Point(192, 84);
      Point point6 = point1;
      flatComboBox2_1.Location = point6;
      this.FlatComboBox2.Name = "FlatComboBox2";
      FlatComboBox flatComboBox2_2 = this.FlatComboBox2;
      size1 = new Size(136, 23);
      Size size6 = size1;
      flatComboBox2_2.Size = size6;
      this.FlatComboBox2.TabIndex = 159;
      this.FlatComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
      FlatComboBox flatComboBox1_1 = this.FlatComboBox1;
      point1 = new Point(192, 56);
      Point point7 = point1;
      flatComboBox1_1.Location = point7;
      this.FlatComboBox1.Name = "FlatComboBox1";
      FlatComboBox flatComboBox1_2 = this.FlatComboBox1;
      size1 = new Size(136, 23);
      Size size7 = size1;
      flatComboBox1_2.Size = size7;
      this.FlatComboBox1.TabIndex = 158;
      this.PictureBox11.Image = (Image) resourceManager.GetObject("PictureBox11.Image");
      PictureBox pictureBox11_1 = this.PictureBox11;
      point1 = new Point(36, 44);
      Point point8 = point1;
      pictureBox11_1.Location = point8;
      this.PictureBox11.Name = "PictureBox11";
      PictureBox pictureBox11_2 = this.PictureBox11;
      size1 = new Size(43, 43);
      Size size8 = size1;
      pictureBox11_2.Size = size8;
      this.PictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox11.TabIndex = 167;
      this.PictureBox11.TabStop = false;
      this.Grid1.AutoSizeMinHeight = 10;
      this.Grid1.AutoSizeMinWidth = 10;
      this.Grid1.AutoStretchColumnsToFitWidth = false;
      this.Grid1.AutoStretchRowsToFitHeight = false;
      this.Grid1.ContextMenuStyle = ContextMenuStyle.None;
      this.Grid1.CustomSort = false;
      this.Grid1.GridToolTipActive = true;
      Grid grid1_1 = this.Grid1;
      point1 = new Point(8, 132);
      Point point9 = point1;
      grid1_1.Location = point9;
      this.Grid1.Name = "Grid1";
      Grid grid1_2 = this.Grid1;
      size1 = new Size(348, 40);
      Size size9 = size1;
      grid1_2.Size = size9;
      this.Grid1.SpecialKeys = GridSpecialKeys.Default;
      this.Grid1.TabIndex = 168;
      Label label1_1 = this.Label1;
      point1 = new Point(108, 56);
      Point point10 = point1;
      label1_1.Location = point10;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      size1 = new Size(76, 23);
      Size size10 = size1;
      label1_2.Size = size10;
      this.Label1.TabIndex = 169;
      this.Label1.Text = "In";
      this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      Label label2_1 = this.Label2;
      point1 = new Point(108, 84);
      Point point11 = point1;
      label2_1.Location = point11;
      this.Label2.Name = "Label2";
      Label label2_2 = this.Label2;
      size1 = new Size(76, 23);
      Size size11 = size1;
      label2_2.Size = size11;
      this.Label2.TabIndex = 170;
      this.Label2.Text = "Out";
      this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      Label label3_1 = this.Label3;
      point1 = new Point(108, 24);
      Point point12 = point1;
      label3_1.Location = point12;
      this.Label3.Name = "Label3";
      Label label3_2 = this.Label3;
      size1 = new Size(76, 23);
      Size size12 = size1;
      label3_2.Size = size12;
      this.Label3.TabIndex = 172;
      this.Label3.Text = "In";
      this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.FlatComboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
      FlatComboBox flatComboBox3_1 = this.FlatComboBox3;
      point1 = new Point(192, 24);
      Point point13 = point1;
      flatComboBox3_1.Location = point13;
      this.FlatComboBox3.Name = "FlatComboBox3";
      FlatComboBox flatComboBox3_2 = this.FlatComboBox3;
      size1 = new Size(136, 23);
      Size size13 = size1;
      flatComboBox3_2.Size = size13;
      this.FlatComboBox3.TabIndex = 171;
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.FlatComboBox3);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.Grid1);
      this.Controls.Add((Control) this.PictureBox11);
      this.Controls.Add((Control) this.CheckWest);
      this.Controls.Add((Control) this.CheckEast);
      this.Controls.Add((Control) this.CheckSouth);
      this.Controls.Add((Control) this.CheckNorth);
      this.Controls.Add((Control) this.FlatComboBox2);
      this.Controls.Add((Control) this.FlatComboBox1);
      this.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Name = nameof (SwitchGrid);
      size1 = new Size(376, 188);
      this.Size = size1;
      this.ResumeLayout(false);
    }

    public string Ergebnis => StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(this.AusgabeZelle1.Value, (object) ","), this.AusgabeZelle2.Value), (object) ","), this.AusgabeZelle3.Value), (object) ","), this.AusgabeZelle4.Value));

    public string Art
    {
      get => StringType.FromObject(this.TransitTypeArtWerte[this.FlatComboBox3.SelectedIndex]);
      set
      {
        if (Information.IsNothing((object) value))
          return;
        value = value.Replace("0X", "0x");
        int num = this.TransitTypeArtWerte.IndexOf((object) value);
        if (num > -1)
          this.FlatComboBox3.SelectedIndex = num;
      }
    }

    public string InsideString
    {
      get => StringType.FromObject(this.TransitTypeDefWerte[this.FlatComboBox1.SelectedIndex]);
      set
      {
        if (Information.IsNothing((object) value))
          return;
        value = value.Replace("0X", "0x");
        int num = this.TransitTypeDefWerte.IndexOf((object) value);
        if (num > -1)
          this.FlatComboBox1.SelectedIndex = num;
      }
    }

    public string OutString
    {
      get => StringType.FromObject(this.TransitTypeDefWerte[this.FlatComboBox2.SelectedIndex]);
      set
      {
        if (Information.IsNothing((object) value))
          return;
        value = value.Replace("0X", "0x");
        int num = this.TransitTypeDefWerte.IndexOf((object) value);
        if (num > -1)
          this.FlatComboBox2.SelectedIndex = num;
      }
    }

    public string DirectionString
    {
      get => this.GetDirectionString();
      set
      {
        if (Information.IsNothing((object) value))
          return;
        this.SetDirectionString(value);
      }
    }

    public object SetzeTexte(ArrayList LanguageArray)
    {
      this.isLoading = true;
      int selectedIndex1 = this.FlatComboBox1.SelectedIndex;
      int selectedIndex2 = this.FlatComboBox2.SelectedIndex;
      int selectedIndex3 = this.FlatComboBox3.SelectedIndex;
      this.FlatComboBox1.Items.Clear();
      this.FlatComboBox2.Items.Clear();
      this.FlatComboBox3.Items.Clear();
      int index = 411;
      do
      {
        this.FlatComboBox1.Items.Add(RuntimeHelpers.GetObjectValue(LanguageArray[index]));
        this.FlatComboBox2.Items.Add(RuntimeHelpers.GetObjectValue(LanguageArray[index]));
        checked { ++index; }
      }
      while (index <= 419);
      this.FlatComboBox3.Items.Add(RuntimeHelpers.GetObjectValue(LanguageArray[421]));
      this.FlatComboBox3.Items.Add(RuntimeHelpers.GetObjectValue(LanguageArray[420]));
      this.isLoading = false;
      this.FlatComboBox1.SelectedIndex = selectedIndex1;
      this.FlatComboBox2.SelectedIndex = selectedIndex2;
      this.FlatComboBox2.SelectedIndex = selectedIndex3;
      this.Label1.Text = StringType.FromObject(LanguageArray[422]);
      this.Label2.Text = StringType.FromObject(LanguageArray[423]);
      this.Label3.Text = StringType.FromObject(LanguageArray[121]);
      object obj;
      return obj;
    }

    private object SetDirectionString(string EingabeString)
    {
      string upper = EingabeString.ToUpper();
      if (StringType.StrCmp(upper, "0X00000010", false) == 0)
      {
        this.m_East = false;
        this.m_North = false;
        this.m_West = false;
        this.m_South = true;
      }
      else if (StringType.StrCmp(upper, "0X00000020", false) == 0)
      {
        this.m_East = true;
        this.m_North = false;
        this.m_West = false;
        this.m_South = false;
      }
      else if (StringType.StrCmp(upper, "0X00000030", false) == 0)
      {
        this.m_East = true;
        this.m_North = false;
        this.m_West = false;
        this.m_South = true;
      }
      else if (StringType.StrCmp(upper, "0X00000040", false) == 0)
      {
        this.m_East = false;
        this.m_North = true;
        this.m_West = false;
        this.m_South = false;
      }
      else if (StringType.StrCmp(upper, "0X00000050", false) == 0)
      {
        this.m_East = false;
        this.m_North = true;
        this.m_West = false;
        this.m_South = true;
      }
      else if (StringType.StrCmp(upper, "0X00000060", false) == 0)
      {
        this.m_East = true;
        this.m_North = true;
        this.m_West = false;
        this.m_South = false;
      }
      else if (StringType.StrCmp(upper, "0X00000070", false) == 0)
      {
        this.m_East = true;
        this.m_North = true;
        this.m_West = false;
        this.m_South = true;
      }
      else if (StringType.StrCmp(upper, "0X00000080", false) == 0)
      {
        this.m_East = false;
        this.m_North = false;
        this.m_West = true;
        this.m_South = false;
      }
      else if (StringType.StrCmp(upper, "0X00000090", false) == 0)
      {
        this.m_East = false;
        this.m_North = false;
        this.m_West = true;
        this.m_South = true;
      }
      else if (StringType.StrCmp(upper, "0X000000A0", false) == 0)
      {
        this.m_East = true;
        this.m_North = false;
        this.m_West = true;
        this.m_South = false;
      }
      else if (StringType.StrCmp(upper, "0X000000B0", false) == 0)
      {
        this.m_East = true;
        this.m_North = false;
        this.m_West = true;
        this.m_South = true;
      }
      else if (StringType.StrCmp(upper, "0X000000C0", false) == 0)
      {
        this.m_East = false;
        this.m_North = true;
        this.m_West = true;
        this.m_South = false;
      }
      else if (StringType.StrCmp(upper, "0X000000D0", false) == 0)
      {
        this.m_East = false;
        this.m_North = true;
        this.m_West = true;
        this.m_South = true;
      }
      else if (StringType.StrCmp(upper, "0X000000E0", false) == 0)
      {
        this.m_East = true;
        this.m_North = true;
        this.m_West = true;
        this.m_South = false;
      }
      else if (StringType.StrCmp(upper, "0X000000F0", false) == 0)
      {
        this.m_East = true;
        this.m_North = true;
        this.m_West = true;
        this.m_South = true;
      }
      else if (StringType.StrCmp(upper, "", false) == 0)
      {
        this.m_East = false;
        this.m_North = false;
        this.m_West = false;
        this.m_South = false;
      }
      this.CheckNorth.Checked = this.m_North;
      this.CheckWest.Checked = this.m_West;
      this.CheckSouth.Checked = this.m_South;
      this.CheckEast.Checked = this.m_East;
      object obj;
      return obj;
    }

    private string GetDirectionString()
    {
      string str = "0x00000010";
      if (!this.m_East & !this.m_North & !this.m_West & this.m_South)
        str = "0x00000010";
      else if (this.m_East & !this.m_North & !this.m_West & !this.m_South)
        str = "0x00000020";
      else if (this.m_East & !this.m_North & !this.m_West & this.m_South)
        str = "0x00000030";
      else if (!this.m_East & this.m_North & !this.m_West & !this.m_South)
        str = "0x00000040";
      else if (!this.m_East & this.m_North & !this.m_West & this.m_South)
        str = "0x00000050";
      else if (this.m_East & this.m_North & !this.m_West & !this.m_South)
        str = "0x00000060";
      else if (this.m_East & this.m_North & !this.m_West & this.m_South)
        str = "0x00000070";
      else if (!this.m_East & !this.m_North & this.m_West & !this.m_South)
        str = "0x00000080";
      else if (!this.m_East & !this.m_North & this.m_West & this.m_South)
        str = "0x00000090";
      else if (this.m_East & !this.m_North & this.m_West & !this.m_South)
        str = "0x000000A0";
      else if (this.m_East & !this.m_North & this.m_West & this.m_South)
        str = "0x000000B0";
      else if (!this.m_East & this.m_North & this.m_West & !this.m_South)
        str = "0x000000C0";
      else if (!this.m_East & this.m_North & this.m_West & this.m_South)
        str = "0x000000D0";
      else if (this.m_East & this.m_North & this.m_West & !this.m_South)
        str = "0x000000E0";
      else if (this.m_East & this.m_North & this.m_West & this.m_South)
        str = "0x000000F0";
      else if (!this.m_East & !this.m_North & !this.m_West & !this.m_South)
      {
        this.CheckNorth.Checked = true;
        str = "0x00000010";
      }
      this.AusgabeZelle2.Value = (object) str;
      return str;
    }

    private void CheckNorth_CheckedChanged(object sender, EventArgs e)
    {
      this.m_North = this.CheckNorth.Checked;
      this.GetDirectionString();
    }

    private void CheckWest_CheckedChanged(object sender, EventArgs e)
    {
      this.m_West = this.CheckWest.Checked;
      this.GetDirectionString();
    }

    private void CheckEast_CheckedChanged(object sender, EventArgs e)
    {
      this.m_East = this.CheckEast.Checked;
      this.GetDirectionString();
    }

    private void CheckSouth_CheckedChanged(object sender, EventArgs e)
    {
      this.m_South = this.CheckSouth.Checked;
      this.GetDirectionString();
    }

    private Bitmap GetPictureFromResource(string BitmapName)
    {
      Assembly executingAssembly = Assembly.GetExecutingAssembly();
      string str = executingAssembly.GetName().Name.ToString();
      return (Bitmap) Image.FromStream(executingAssembly.GetManifestResourceStream(str + "." + BitmapName));
    }

    private void FlatComboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.isLoading)
        return;
      this.AusgabeZelle3.Value = RuntimeHelpers.GetObjectValue(this.TransitTypeDefWerte[this.FlatComboBox1.SelectedIndex]);
    }

    private void FlatComboBox3_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.isLoading)
        return;
      this.AusgabeZelle1.Value = RuntimeHelpers.GetObjectValue(this.TransitTypeArtWerte[this.FlatComboBox3.SelectedIndex]);
    }

    private void FlatComboBox2_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.isLoading)
        return;
      this.AusgabeZelle4.Value = RuntimeHelpers.GetObjectValue(this.TransitTypeDefWerte[this.FlatComboBox2.SelectedIndex]);
    }
  }
}
