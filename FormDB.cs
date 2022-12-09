// Decompiled with JetBrains decompiler
// Type: SC4Tool.FormDB
// Assembly: SC4Tool, Version=2.2.7.0, Culture=neutral, PublicKeyToken=null
// MVID: 69A50BC4-87A5-4C5E-BEFC-08274BC6D498
// Assembly location: C:\Program Files (x86)\SC4 Utilities\SC4Tool\SC4Tool.exe

using C1.Win.C1FlexGrid;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using sr_SC4Lib;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using TD.Eyefinder;
using TD.SandBar;

namespace SC4Tool
{
  public class FormDB : Form
  {
    [AccessedThroughProperty("BATButtonEnd")]
    private ButtonItem _BATButtonEnd;
    [AccessedThroughProperty("GewerbeToolButton2")]
    private ButtonItem _GewerbeToolButton2;
    [AccessedThroughProperty("GewerbeToolButton1")]
    private ButtonItem _GewerbeToolButton1;
    [AccessedThroughProperty("WohnenToolBar")]
    private TD.SandBar.ToolBar _WohnenToolBar;
    [AccessedThroughProperty("GewerbeToolBar")]
    private TD.SandBar.ToolBar _GewerbeToolBar;
    [AccessedThroughProperty("IndustrieButtonEnd")]
    private ButtonItem _IndustrieButtonEnd;
    [AccessedThroughProperty("WohnenToolButton1")]
    private ButtonItem _WohnenToolButton1;
    [AccessedThroughProperty("WohnenToolButton2")]
    private ButtonItem _WohnenToolButton2;
    [AccessedThroughProperty("IndustrieToolButton2")]
    private ButtonItem _IndustrieToolButton2;
    [AccessedThroughProperty("IndustrieToolButton1")]
    private ButtonItem _IndustrieToolButton1;
    [AccessedThroughProperty("WohnenToolButton3")]
    private ButtonItem _WohnenToolButton3;
    [AccessedThroughProperty("IndustrieToolBar")]
    private TD.SandBar.ToolBar _IndustrieToolBar;
    [AccessedThroughProperty("WohnenTreeView")]
    private TreeView _WohnenTreeView;
    [AccessedThroughProperty("WohnenButtonEnd")]
    private ButtonItem _WohnenButtonEnd;
    [AccessedThroughProperty("GewerbeTreeView")]
    private TreeView _GewerbeTreeView;
    [AccessedThroughProperty("IndustrieTreeView")]
    private TreeView _IndustrieTreeView;
    [AccessedThroughProperty("BATToolBar")]
    private TD.SandBar.ToolBar _BATToolBar;
    [AccessedThroughProperty("ButtonSave")]
    private ButtonItem _ButtonSave;
    [AccessedThroughProperty("ButtonHTML")]
    private ButtonItem _ButtonHTML;
    [AccessedThroughProperty("BATPane")]
    private NavigationPane _BATPane;
    [AccessedThroughProperty("AusgabeFlexGrid")]
    private C1.Win.C1FlexGrid.C1FlexGrid _AusgabeFlexGrid;
    [AccessedThroughProperty("ShowGrid")]
    private C1.Win.C1FlexGrid.C1FlexGrid _ShowGrid;
    [AccessedThroughProperty("GewerbeButtonEnd")]
    private ButtonItem _GewerbeButtonEnd;
    [AccessedThroughProperty("IndustriePane")]
    private NavigationPane _IndustriePane;
    [AccessedThroughProperty("BATToolButton1")]
    private ButtonItem _BATToolButton1;
    [AccessedThroughProperty("GewerbePane")]
    private NavigationPane _GewerbePane;
    [AccessedThroughProperty("BATToolButton2")]
    private ButtonItem _BATToolButton2;
    [AccessedThroughProperty("WohnenPane")]
    private NavigationPane _WohnenPane;
    [AccessedThroughProperty("MainAusgabeGrid")]
    private C1.Win.C1FlexGrid.C1FlexGrid _MainAusgabeGrid;
    [AccessedThroughProperty("ImageList1")]
    private ImageList _ImageList1;
    [AccessedThroughProperty("NavigationBar1")]
    private NavigationBar _NavigationBar1;
    [AccessedThroughProperty("Splitter1")]
    private Splitter _Splitter1;
    [AccessedThroughProperty("HeaderControl2")]
    private HeaderControl _HeaderControl2;
    [AccessedThroughProperty("ToolBar1")]
    private TD.SandBar.ToolBar _ToolBar1;
    private bool FirstStart;
    private string SuchAusgabeText;
    private DataSet AusgabeDataSet;
    private TreeView AktuellerTreeView;
    private int IndexCol;
    private int InfoCol;
    private int AusgabeCol;
    private IContainer components;

    public FormDB()
    {
      this.Load += new EventHandler(this.FormDB_Load);
      this.Closed += new EventHandler(this.FormDB_Closed);
      this.AusgabeDataSet = new DataSet();
      this.InitializeComponent();
      this.IndustriePane.SmallImage = this.ImageList1.Images[22];
      this.IndustriePane.LargeImage = this.ImageList1.Images[22];
      this.GewerbePane.SmallImage = this.ImageList1.Images[21];
      this.GewerbePane.LargeImage = this.ImageList1.Images[21];
      this.WohnenPane.SmallImage = this.ImageList1.Images[23];
      this.WohnenPane.LargeImage = this.ImageList1.Images[23];
      this.BATPane.SmallImage = this.ImageList1.Images[28];
      this.BATPane.LargeImage = this.ImageList1.Images[28];
      C1.Win.C1FlexGrid.C1FlexGrid mainAusgabeGrid = this.MainAusgabeGrid;
      mainAusgabeGrid.AllowDragging = AllowDraggingEnum.None;
      mainAusgabeGrid.AllowSorting = AllowSortingEnum.None;
      mainAusgabeGrid.AllowMerging = AllowMergingEnum.Free;
      mainAusgabeGrid.AllowEditing = true;
      mainAusgabeGrid.ExtendLastCol = true;
      mainAusgabeGrid.Styles.Add("ShowBoolean");
      mainAusgabeGrid.Styles["ShowBoolean"].DataType = System.Type.GetType("System.Boolean");
      mainAusgabeGrid.Styles["ShowBoolean"].ImageAlign = ImageAlignEnum.CenterCenter;
      mainAusgabeGrid.Styles.Add("LeftText");
      mainAusgabeGrid.Styles["LeftText"].TextAlign = TextAlignEnum.LeftCenter;
      mainAusgabeGrid.Styles.Add("LeftTopText");
      mainAusgabeGrid.Styles["LeftTopText"].TextAlign = TextAlignEnum.LeftTop;
      mainAusgabeGrid.Styles["LeftTopText"].ImageAlign = ImageAlignEnum.LeftTop;
      mainAusgabeGrid.Styles.Add("CenterText");
      mainAusgabeGrid.Styles["LeftText"].TextAlign = TextAlignEnum.LeftCenter;
      mainAusgabeGrid.Styles.Add("LeftBlueText");
      mainAusgabeGrid.Styles["LeftBlueText"].TextAlign = TextAlignEnum.LeftCenter;
      mainAusgabeGrid.Styles["LeftBlueText"].BackColor = Color.SteelBlue;
      mainAusgabeGrid.Styles["LeftBlueText"].ForeColor = Color.White;
      mainAusgabeGrid.Styles.Add("CenterBlueText");
      mainAusgabeGrid.Styles["CenterBlueText"].TextAlign = TextAlignEnum.CenterCenter;
      mainAusgabeGrid.Styles["CenterBlueText"].Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      mainAusgabeGrid.Styles.Add("EmptyText");
      mainAusgabeGrid.Styles["EmptyText"].TextAlign = TextAlignEnum.LeftCenter;
      mainAusgabeGrid.Styles["EmptyText"].BackColor = mainAusgabeGrid.BackColor;
      mainAusgabeGrid.Styles["EmptyText"].Border.Color = mainAusgabeGrid.BackColor;
      mainAusgabeGrid.Styles["EmptyText"].ForeColor = mainAusgabeGrid.ForeColor;
      mainAusgabeGrid.Styles.Add("BoldText");
      mainAusgabeGrid.Styles["BoldText"].TextAlign = TextAlignEnum.LeftCenter;
      mainAusgabeGrid.Styles["BoldText"].Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      mainAusgabeGrid.Styles.Add("RightImage");
      mainAusgabeGrid.Styles["RightImage"].ImageAlign = ImageAlignEnum.RightCenter;
      mainAusgabeGrid.Styles.Add("CenterImage");
      mainAusgabeGrid.Styles["CenterImage"].ImageAlign = ImageAlignEnum.CenterCenter;
      mainAusgabeGrid.Styles.Add("LeftImage");
      mainAusgabeGrid.Styles["LeftImage"].ImageAlign = ImageAlignEnum.LeftCenter;
      mainAusgabeGrid.Styles["LeftImage"].TextAlign = TextAlignEnum.LeftCenter;
      mainAusgabeGrid.Styles["LeftImage"].Font = new Font("Arial", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      mainAusgabeGrid.Styles["LeftImage"].BackColor = Color.SteelBlue;
      mainAusgabeGrid.Styles["LeftImage"].ForeColor = Color.White;
      mainAusgabeGrid.Styles["LeftImage"].Border.Width = 0;
      mainAusgabeGrid.Styles.Add("LeftNormalImage");
      mainAusgabeGrid.Styles["LeftImage"].ImageAlign = ImageAlignEnum.LeftCenter;
      mainAusgabeGrid.Styles["LeftImage"].TextAlign = TextAlignEnum.LeftCenter;
      mainAusgabeGrid.Styles.Add("LeerZeile");
      mainAusgabeGrid.Styles["LeerZeile"].BackColor = mainAusgabeGrid.Styles.Normal.BackColor;
      mainAusgabeGrid.Styles["LeerZeile"].ForeColor = mainAusgabeGrid.Styles.Normal.BackColor;
      mainAusgabeGrid.Styles.Add("MainImage");
      mainAusgabeGrid.Styles["MainImage"].ImageAlign = ImageAlignEnum.CenterCenter;
      mainAusgabeGrid.Styles["MainImage"].BackColor = mainAusgabeGrid.BackColor;
      mainAusgabeGrid.Styles["MainImage"].Border.Color = mainAusgabeGrid.BackColor;
      mainAusgabeGrid.Styles["MainImage"].ForeColor = mainAusgabeGrid.ForeColor;
      mainAusgabeGrid.Styles["MainImage"].TextAlign = TextAlignEnum.LeftTop;
      mainAusgabeGrid.HighLight = HighLightEnum.WithFocus;
      mainAusgabeGrid.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
      mainAusgabeGrid.ScrollBars = ScrollBars.Both;
      mainAusgabeGrid.Styles.Fixed.BackColor = Color.SteelBlue;
      mainAusgabeGrid.Styles.Fixed.ForeColor = Color.White;
      mainAusgabeGrid.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter;
      mainAusgabeGrid.Styles.Fixed.TextEffect = TextEffectEnum.Flat;
      mainAusgabeGrid.Styles.Fixed.Border.Color = Color.White;
      mainAusgabeGrid.Styles.Fixed.Font = this.Font;
      mainAusgabeGrid.Styles.Frozen.Font = this.Font;
      mainAusgabeGrid.Styles.Normal.Font = this.Font;
      mainAusgabeGrid.Styles.Normal.TextAlign = TextAlignEnum.CenterCenter;
      mainAusgabeGrid.Styles.Alternate.BackColor = mainAusgabeGrid.Styles.Frozen.BackColor;
      mainAusgabeGrid.Cols.Count = 8;
      mainAusgabeGrid.Cols.Fixed = 0;
      mainAusgabeGrid.Cols.Frozen = 0;
      mainAusgabeGrid.Rows.Count = 0;
      mainAusgabeGrid.Rows.Fixed = 0;
      mainAusgabeGrid.SelectionMode = SelectionModeEnum.Cell;
      mainAusgabeGrid.Cols[0].Name = "Info";
      mainAusgabeGrid.Cols[1].Name = "Ausgabe1";
      mainAusgabeGrid.Cols[2].Name = "Ausgabe2";
      mainAusgabeGrid.Cols[3].Name = "Ausgabe3";
      mainAusgabeGrid.Cols[4].Name = "Ausgabe4";
      mainAusgabeGrid.Cols[5].Name = "Ausgabe5";
      mainAusgabeGrid.Cols[6].Name = "Ausgabe6";
      mainAusgabeGrid.Cols[7].Name = nameof (IndexCol);
      mainAusgabeGrid.Cols["Info"].Visible = false;
      mainAusgabeGrid.Cols["Info"].Width = 250;
      mainAusgabeGrid.Cols["Ausgabe1"].Width = mainAusgabeGrid.Cols["Info"].Width;
      mainAusgabeGrid.Cols["Ausgabe2"].Width = 120;
      mainAusgabeGrid.Cols["Ausgabe3"].Width = 120;
      mainAusgabeGrid.Cols["Ausgabe4"].Width = 120;
      mainAusgabeGrid.Cols["Ausgabe5"].Width = 120;
      mainAusgabeGrid.Cols[nameof (IndexCol)].Visible = false;
      mainAusgabeGrid.Cols[nameof (IndexCol)].Width = 50;
      mainAusgabeGrid.Cols["Ausgabe1"].Style = mainAusgabeGrid.Styles["LeftText"];
      this.InfoCol = mainAusgabeGrid.Cols["Info"].Index;
      this.AusgabeCol = mainAusgabeGrid.Cols["Ausgabe1"].Index;
      this.IndexCol = mainAusgabeGrid.Cols[nameof (IndexCol)].Index;
      C1.Win.C1FlexGrid.C1FlexGrid ausgabeFlexGrid = this.AusgabeFlexGrid;
      ausgabeFlexGrid.AllowDragging = AllowDraggingEnum.Columns;
      ausgabeFlexGrid.AllowSorting = AllowSortingEnum.SingleColumn;
      ausgabeFlexGrid.AllowMerging = AllowMergingEnum.FixedOnly;
      ausgabeFlexGrid.AllowEditing = false;
      ausgabeFlexGrid.Styles.Add("ShowBoolean");
      ausgabeFlexGrid.Styles["ShowBoolean"].DataType = System.Type.GetType("System.Boolean");
      ausgabeFlexGrid.Styles["ShowBoolean"].ImageAlign = ImageAlignEnum.CenterCenter;
      ausgabeFlexGrid.Styles.Add("LeftText");
      ausgabeFlexGrid.Styles["LeftText"].TextAlign = TextAlignEnum.LeftCenter;
      ausgabeFlexGrid.Styles.Add("BoldText");
      ausgabeFlexGrid.Styles["BoldText"].TextAlign = TextAlignEnum.LeftCenter;
      ausgabeFlexGrid.Styles["BoldText"].Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ausgabeFlexGrid.Styles.Add("RightImage");
      ausgabeFlexGrid.Styles["RightImage"].ImageAlign = ImageAlignEnum.RightCenter;
      ausgabeFlexGrid.Styles.Add("CenterImage");
      ausgabeFlexGrid.Styles["CenterImage"].ImageAlign = ImageAlignEnum.CenterCenter;
      ausgabeFlexGrid.HighLight = HighLightEnum.WithFocus;
      ausgabeFlexGrid.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
      ausgabeFlexGrid.ScrollBars = ScrollBars.Both;
      ausgabeFlexGrid.Styles.Fixed.BackColor = Color.SteelBlue;
      ausgabeFlexGrid.Styles.Fixed.ForeColor = Color.White;
      ausgabeFlexGrid.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter;
      ausgabeFlexGrid.Styles.Fixed.TextEffect = TextEffectEnum.Flat;
      ausgabeFlexGrid.Styles.Fixed.Border.Color = Color.White;
      ausgabeFlexGrid.Styles.Fixed.Font = this.Font;
      ausgabeFlexGrid.Styles.Frozen.Font = this.Font;
      ausgabeFlexGrid.Styles.Normal.Font = this.Font;
      ausgabeFlexGrid.Styles.Normal.TextAlign = TextAlignEnum.CenterCenter;
      ausgabeFlexGrid.Styles.Alternate.BackColor = ausgabeFlexGrid.Styles.Frozen.BackColor;
      ausgabeFlexGrid.Cols.Count = 22;
      ausgabeFlexGrid.Cols.Fixed = 0;
      ausgabeFlexGrid.Cols.Frozen = 1;
      ausgabeFlexGrid.Rows.Count = 2;
      ausgabeFlexGrid.Rows.Fixed = 2;
      ausgabeFlexGrid.SelectionMode = SelectionModeEnum.Cell;
      ausgabeFlexGrid.Cols[0].Name = "Name";
      ausgabeFlexGrid.Cols[1].Name = "Typ";
      ausgabeFlexGrid.Cols[2].Name = "Set";
      ausgabeFlexGrid.Cols[3].Name = "building_value";
      ausgabeFlexGrid.Cols[4].Name = "Stage";
      ausgabeFlexGrid.Cols[5].Name = "capacity0";
      ausgabeFlexGrid.Cols[6].Name = "capacity1";
      ausgabeFlexGrid.Cols[7].Name = "capacity2";
      ausgabeFlexGrid.Cols[8].Name = "bulldoze_cost";
      ausgabeFlexGrid.Cols[9].Name = "Schadenswert";
      ausgabeFlexGrid.Cols[10].Name = "flammability";
      ausgabeFlexGrid.Cols[11].Name = "max_fire_stage";
      ausgabeFlexGrid.Cols[12].Name = "energy_consumed";
      ausgabeFlexGrid.Cols[13].Name = "water_consumed";
      ausgabeFlexGrid.Cols[14].Name = "pollution_air";
      ausgabeFlexGrid.Cols[15].Name = "pollution_water";
      ausgabeFlexGrid.Cols[16].Name = "pollution_garbage";
      ausgabeFlexGrid.Cols[17].Name = "pollution_radiation";
      ausgabeFlexGrid.Cols[18].Name = "pollution_air_radius";
      ausgabeFlexGrid.Cols[19].Name = "pollution_water_radius";
      ausgabeFlexGrid.Cols[20].Name = "pollution_garbage_radius";
      ausgabeFlexGrid.Cols[21].Name = "pollution_radiation_radius";
      ausgabeFlexGrid.Rows[0].AllowMerging = true;
      ausgabeFlexGrid.Cols["Name"].Width = 250;
      ausgabeFlexGrid.Cols["Name"].Style = ausgabeFlexGrid.Styles["LeftText"];
      C1.Win.C1FlexGrid.C1FlexGrid showGrid = this.ShowGrid;
      showGrid.Styles.Fixed.BackColor = Color.SteelBlue;
      showGrid.Styles.Fixed.ForeColor = Color.White;
      showGrid.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter;
      showGrid.Styles.Fixed.TextEffect = TextEffectEnum.Raised;
      showGrid.Styles.Fixed.Font = this.Font;
      showGrid.Styles.Frozen.Font = this.Font;
      showGrid.Styles.Normal.Font = this.Font;
      showGrid.Styles.Alternate.BackColor = showGrid.Styles.Frozen.BackColor;
      showGrid.Styles.EmptyArea.BackColor = showGrid.Styles.Alternate.BackColor;
      showGrid.Styles.EmptyArea.ForeColor = showGrid.Styles.Alternate.BackColor;
      showGrid.AllowMerging = AllowMergingEnum.Free;
      showGrid.Cols.Count = 3;
      showGrid.Cols[0].Width = 30;
      showGrid.Cols[1].Width = 200;
      showGrid.Cols[2].Visible = false;
      showGrid.Rows.Count = 0;
      showGrid.Cols.Fixed = 0;
      showGrid.Cols.Frozen = 0;
      showGrid.Cols.MaxSize = 0;
      showGrid.Cols.MinSize = 0;
      showGrid.Rows.Fixed = 0;
      showGrid.HighLight = HighLightEnum.WithFocus;
      showGrid.SelectionMode = SelectionModeEnum.Cell;
      showGrid.Styles.Add("Show");
      showGrid.Styles["Show"].DataType = System.Type.GetType("System.Boolean");
      showGrid.Styles["Show"].ImageAlign = ImageAlignEnum.CenterCenter;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
      ClassThisProg.frmForm1 = (FormDB) null;
    }

    internal virtual ImageList ImageList1
    {
      get => this._ImageList1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ImageList1 == null)
          ;
        this._ImageList1 = value;
        if (this._ImageList1 == null)
          ;
      }
    }

    internal virtual NavigationBar NavigationBar1
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._NavigationBar1 != null)
        {
          this._NavigationBar1.Resize -= new EventHandler(this.NavigationBar1_Resize);
          this._NavigationBar1.SelectedPaneChanged -= new EventHandler(this.NavigationBar1_SelectedPaneChanged);
        }
        this._NavigationBar1 = value;
        if (this._NavigationBar1 == null)
          return;
        this._NavigationBar1.Resize += new EventHandler(this.NavigationBar1_Resize);
        this._NavigationBar1.SelectedPaneChanged += new EventHandler(this.NavigationBar1_SelectedPaneChanged);
      }
      get => this._NavigationBar1;
    }

    internal virtual NavigationPane WohnenPane
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._WohnenPane == null)
          ;
        this._WohnenPane = value;
        if (this._WohnenPane == null)
          ;
      }
      get => this._WohnenPane;
    }

    internal virtual NavigationPane GewerbePane
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._GewerbePane == null)
          ;
        this._GewerbePane = value;
        if (this._GewerbePane == null)
          ;
      }
      get => this._GewerbePane;
    }

    internal virtual NavigationPane IndustriePane
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._IndustriePane == null)
          ;
        this._IndustriePane = value;
        if (this._IndustriePane == null)
          ;
      }
      get => this._IndustriePane;
    }

    internal virtual NavigationPane BATPane
    {
      get => this._BATPane;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._BATPane == null)
          ;
        this._BATPane = value;
        if (this._BATPane == null)
          ;
      }
    }

    internal virtual TreeView IndustrieTreeView
    {
      get => this._IndustrieTreeView;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._IndustrieTreeView != null)
          this._IndustrieTreeView.AfterSelect -= new TreeViewEventHandler(this.IndustrieTreeView_AfterSelect);
        this._IndustrieTreeView = value;
        if (this._IndustrieTreeView == null)
          return;
        this._IndustrieTreeView.AfterSelect += new TreeViewEventHandler(this.IndustrieTreeView_AfterSelect);
      }
    }

    internal virtual TreeView GewerbeTreeView
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._GewerbeTreeView != null)
          this._GewerbeTreeView.AfterSelect -= new TreeViewEventHandler(this.GewerbeTreeView_AfterSelect);
        this._GewerbeTreeView = value;
        if (this._GewerbeTreeView == null)
          return;
        this._GewerbeTreeView.AfterSelect += new TreeViewEventHandler(this.GewerbeTreeView_AfterSelect);
      }
      get => this._GewerbeTreeView;
    }

    internal virtual TreeView WohnenTreeView
    {
      get => this._WohnenTreeView;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._WohnenTreeView != null)
          this._WohnenTreeView.AfterSelect -= new TreeViewEventHandler(this.WohnenTreeView_AfterSelect);
        this._WohnenTreeView = value;
        if (this._WohnenTreeView == null)
          return;
        this._WohnenTreeView.AfterSelect += new TreeViewEventHandler(this.WohnenTreeView_AfterSelect);
      }
    }

    internal virtual Splitter Splitter1
    {
      get => this._Splitter1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Splitter1 == null)
          ;
        this._Splitter1 = value;
        if (this._Splitter1 == null)
          ;
      }
    }

    internal virtual TD.SandBar.ToolBar IndustrieToolBar
    {
      get => this._IndustrieToolBar;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._IndustrieToolBar == null)
          ;
        this._IndustrieToolBar = value;
        if (this._IndustrieToolBar == null)
          ;
      }
    }

    internal virtual ButtonItem IndustrieToolButton1
    {
      get => this._IndustrieToolButton1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._IndustrieToolButton1 != null)
          this._IndustrieToolButton1.Activate -= new EventHandler(this.IndustrieToolButton1_Activate);
        this._IndustrieToolButton1 = value;
        if (this._IndustrieToolButton1 == null)
          return;
        this._IndustrieToolButton1.Activate += new EventHandler(this.IndustrieToolButton1_Activate);
      }
    }

    internal virtual ButtonItem IndustrieToolButton2
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._IndustrieToolButton2 != null)
          this._IndustrieToolButton2.Activate -= new EventHandler(this.IndustrieToolButton2_Activate);
        this._IndustrieToolButton2 = value;
        if (this._IndustrieToolButton2 == null)
          return;
        this._IndustrieToolButton2.Activate += new EventHandler(this.IndustrieToolButton2_Activate);
      }
      get => this._IndustrieToolButton2;
    }

    internal virtual ButtonItem IndustrieButtonEnd
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._IndustrieButtonEnd != null)
          this._IndustrieButtonEnd.Activate -= new EventHandler(this.IndustrieButtonEnd_Activate);
        this._IndustrieButtonEnd = value;
        if (this._IndustrieButtonEnd == null)
          return;
        this._IndustrieButtonEnd.Activate += new EventHandler(this.IndustrieButtonEnd_Activate);
      }
      get => this._IndustrieButtonEnd;
    }

    internal virtual TD.SandBar.ToolBar GewerbeToolBar
    {
      get => this._GewerbeToolBar;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._GewerbeToolBar == null)
          ;
        this._GewerbeToolBar = value;
        if (this._GewerbeToolBar == null)
          ;
      }
    }

    internal virtual ButtonItem GewerbeToolButton1
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._GewerbeToolButton1 != null)
          this._GewerbeToolButton1.Activate -= new EventHandler(this.IndustrieToolButton1_Activate);
        this._GewerbeToolButton1 = value;
        if (this._GewerbeToolButton1 == null)
          return;
        this._GewerbeToolButton1.Activate += new EventHandler(this.IndustrieToolButton1_Activate);
      }
      get => this._GewerbeToolButton1;
    }

    internal virtual ButtonItem GewerbeToolButton2
    {
      get => this._GewerbeToolButton2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._GewerbeToolButton2 != null)
          this._GewerbeToolButton2.Activate -= new EventHandler(this.IndustrieToolButton2_Activate);
        this._GewerbeToolButton2 = value;
        if (this._GewerbeToolButton2 == null)
          return;
        this._GewerbeToolButton2.Activate += new EventHandler(this.IndustrieToolButton2_Activate);
      }
    }

    internal virtual ButtonItem GewerbeButtonEnd
    {
      get => this._GewerbeButtonEnd;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._GewerbeButtonEnd != null)
          this._GewerbeButtonEnd.Activate -= new EventHandler(this.GewerbeButtonEnd_Activate);
        this._GewerbeButtonEnd = value;
        if (this._GewerbeButtonEnd == null)
          return;
        this._GewerbeButtonEnd.Activate += new EventHandler(this.GewerbeButtonEnd_Activate);
      }
    }

    internal virtual TD.SandBar.ToolBar WohnenToolBar
    {
      get => this._WohnenToolBar;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._WohnenToolBar == null)
          ;
        this._WohnenToolBar = value;
        if (this._WohnenToolBar == null)
          ;
      }
    }

    internal virtual ButtonItem WohnenToolButton1
    {
      get => this._WohnenToolButton1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._WohnenToolButton1 != null)
          this._WohnenToolButton1.Activate -= new EventHandler(this.IndustrieToolButton1_Activate);
        this._WohnenToolButton1 = value;
        if (this._WohnenToolButton1 == null)
          return;
        this._WohnenToolButton1.Activate += new EventHandler(this.IndustrieToolButton1_Activate);
      }
    }

    internal virtual ButtonItem WohnenToolButton2
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._WohnenToolButton2 != null)
          this._WohnenToolButton2.Activate -= new EventHandler(this.IndustrieToolButton2_Activate);
        this._WohnenToolButton2 = value;
        if (this._WohnenToolButton2 == null)
          return;
        this._WohnenToolButton2.Activate += new EventHandler(this.IndustrieToolButton2_Activate);
      }
      get => this._WohnenToolButton2;
    }

    internal virtual ButtonItem WohnenToolButton3
    {
      get => this._WohnenToolButton3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._WohnenToolButton3 == null)
          ;
        this._WohnenToolButton3 = value;
        if (this._WohnenToolButton3 == null)
          ;
      }
    }

    internal virtual ButtonItem WohnenButtonEnd
    {
      get => this._WohnenButtonEnd;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._WohnenButtonEnd != null)
          this._WohnenButtonEnd.Activate -= new EventHandler(this.WohnenButtonEnd_Activate);
        this._WohnenButtonEnd = value;
        if (this._WohnenButtonEnd == null)
          return;
        this._WohnenButtonEnd.Activate += new EventHandler(this.WohnenButtonEnd_Activate);
      }
    }

    internal virtual TD.SandBar.ToolBar BATToolBar
    {
      get => this._BATToolBar;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._BATToolBar == null)
          ;
        this._BATToolBar = value;
        if (this._BATToolBar == null)
          ;
      }
    }

    internal virtual HeaderControl HeaderControl2
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._HeaderControl2 == null)
          ;
        this._HeaderControl2 = value;
        if (this._HeaderControl2 == null)
          ;
      }
      get => this._HeaderControl2;
    }

    internal virtual TD.SandBar.ToolBar ToolBar1
    {
      get => this._ToolBar1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ToolBar1 == null)
          ;
        this._ToolBar1 = value;
        if (this._ToolBar1 == null)
          ;
      }
    }

    internal virtual ButtonItem ButtonSave
    {
      get => this._ButtonSave;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ButtonSave != null)
          this._ButtonSave.Activate -= new EventHandler(this.ButtonSave_Activate);
        this._ButtonSave = value;
        if (this._ButtonSave == null)
          return;
        this._ButtonSave.Activate += new EventHandler(this.ButtonSave_Activate);
      }
    }

    internal virtual ButtonItem ButtonHTML
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ButtonHTML != null)
          this._ButtonHTML.Activate -= new EventHandler(this.ButtonHTML_Activate);
        this._ButtonHTML = value;
        if (this._ButtonHTML == null)
          return;
        this._ButtonHTML.Activate += new EventHandler(this.ButtonHTML_Activate);
      }
      get => this._ButtonHTML;
    }

    internal virtual C1.Win.C1FlexGrid.C1FlexGrid AusgabeFlexGrid
    {
      get => this._AusgabeFlexGrid;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._AusgabeFlexGrid == null)
          ;
        this._AusgabeFlexGrid = value;
        if (this._AusgabeFlexGrid == null)
          ;
      }
    }

    internal virtual C1.Win.C1FlexGrid.C1FlexGrid ShowGrid
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ShowGrid != null)
        {
          this._ShowGrid.AfterEdit -= new RowColEventHandler(this.ShowGrid_AfterEdit);
          this._ShowGrid.BeforeEdit -= new RowColEventHandler(this.ShowGrid_BeforeEdit);
        }
        this._ShowGrid = value;
        if (this._ShowGrid == null)
          return;
        this._ShowGrid.AfterEdit += new RowColEventHandler(this.ShowGrid_AfterEdit);
        this._ShowGrid.BeforeEdit += new RowColEventHandler(this.ShowGrid_BeforeEdit);
      }
      get => this._ShowGrid;
    }

    internal virtual ButtonItem BATButtonEnd
    {
      get => this._BATButtonEnd;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._BATButtonEnd != null)
          this._BATButtonEnd.Activate -= new EventHandler(this.BATButtonEnd_Activate);
        this._BATButtonEnd = value;
        if (this._BATButtonEnd == null)
          return;
        this._BATButtonEnd.Activate += new EventHandler(this.BATButtonEnd_Activate);
      }
    }

    internal virtual ButtonItem BATToolButton1
    {
      get => this._BATToolButton1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._BATToolButton1 != null)
          this._BATToolButton1.Activate -= new EventHandler(this.IndustrieToolButton1_Activate);
        this._BATToolButton1 = value;
        if (this._BATToolButton1 == null)
          return;
        this._BATToolButton1.Activate += new EventHandler(this.IndustrieToolButton1_Activate);
      }
    }

    internal virtual ButtonItem BATToolButton2
    {
      get => this._BATToolButton2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._BATToolButton2 != null)
          this._BATToolButton2.Activate -= new EventHandler(this.IndustrieToolButton2_Activate);
        this._BATToolButton2 = value;
        if (this._BATToolButton2 == null)
          return;
        this._BATToolButton2.Activate += new EventHandler(this.IndustrieToolButton2_Activate);
      }
    }

    internal virtual C1.Win.C1FlexGrid.C1FlexGrid MainAusgabeGrid
    {
      get => this._MainAusgabeGrid;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MainAusgabeGrid != null)
        {
          this._MainAusgabeGrid.BeforeEdit -= new RowColEventHandler(this.MainAusgabeGrid_BeforeEdit);
          this._MainAusgabeGrid.Click -= new EventHandler(this.MainAusgabeGrid_Click);
        }
        this._MainAusgabeGrid = value;
        if (this._MainAusgabeGrid == null)
          return;
        this._MainAusgabeGrid.BeforeEdit += new RowColEventHandler(this.MainAusgabeGrid_BeforeEdit);
        this._MainAusgabeGrid.Click += new EventHandler(this.MainAusgabeGrid_Click);
      }
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      ResourceManager resourceManager = new ResourceManager(typeof (FormDB));
      this.ImageList1 = new ImageList(this.components);
      this.NavigationBar1 = new NavigationBar();
      this.BATPane = new NavigationPane();
      this.ShowGrid = new C1.Win.C1FlexGrid.C1FlexGrid();
      this.BATToolBar = new TD.SandBar.ToolBar();
      this.BATButtonEnd = new ButtonItem();
      this.BATToolButton1 = new ButtonItem();
      this.BATToolButton2 = new ButtonItem();
      this.WohnenPane = new NavigationPane();
      this.WohnenTreeView = new TreeView();
      this.WohnenToolBar = new TD.SandBar.ToolBar();
      this.WohnenButtonEnd = new ButtonItem();
      this.WohnenToolButton1 = new ButtonItem();
      this.WohnenToolButton2 = new ButtonItem();
      this.WohnenToolButton3 = new ButtonItem();
      this.GewerbePane = new NavigationPane();
      this.GewerbeTreeView = new TreeView();
      this.GewerbeToolBar = new TD.SandBar.ToolBar();
      this.GewerbeButtonEnd = new ButtonItem();
      this.GewerbeToolButton1 = new ButtonItem();
      this.GewerbeToolButton2 = new ButtonItem();
      this.IndustriePane = new NavigationPane();
      this.IndustrieTreeView = new TreeView();
      this.IndustrieToolBar = new TD.SandBar.ToolBar();
      this.IndustrieButtonEnd = new ButtonItem();
      this.IndustrieToolButton1 = new ButtonItem();
      this.IndustrieToolButton2 = new ButtonItem();
      this.Splitter1 = new Splitter();
      this.HeaderControl2 = new HeaderControl();
      this.AusgabeFlexGrid = new C1.Win.C1FlexGrid.C1FlexGrid();
      this.ToolBar1 = new TD.SandBar.ToolBar();
      this.ButtonSave = new ButtonItem();
      this.ButtonHTML = new ButtonItem();
      this.MainAusgabeGrid = new C1.Win.C1FlexGrid.C1FlexGrid();
      this.NavigationBar1.SuspendLayout();
      this.BATPane.SuspendLayout();
      this.ShowGrid.BeginInit();
      this.WohnenPane.SuspendLayout();
      this.GewerbePane.SuspendLayout();
      this.IndustriePane.SuspendLayout();
      this.HeaderControl2.SuspendLayout();
      this.AusgabeFlexGrid.BeginInit();
      this.MainAusgabeGrid.BeginInit();
      this.SuspendLayout();
      ImageList imageList1 = this.ImageList1;
      Size size1 = new Size(16, 16);
      Size size2 = size1;
      imageList1.ImageSize = size2;
      this.ImageList1.ImageStream = (ImageListStreamer) resourceManager.GetObject("ImageList1.ImageStream");
      this.ImageList1.TransparentColor = Color.Transparent;
      this.NavigationBar1.Controls.Add((Control) this.BATPane);
      this.NavigationBar1.Controls.Add((Control) this.WohnenPane);
      this.NavigationBar1.Controls.Add((Control) this.GewerbePane);
      this.NavigationBar1.Controls.Add((Control) this.IndustriePane);
      this.NavigationBar1.DrawActionsButton = false;
      this.NavigationBar1.HeaderFont = new Font("Tahoma", 12f, FontStyle.Bold);
      NavigationBar navigationBar1_1 = this.NavigationBar1;
      Point point1 = new Point(0, 0);
      Point point2 = point1;
      navigationBar1_1.Location = point2;
      this.NavigationBar1.Name = "NavigationBar1";
      this.NavigationBar1.PaneFont = new Font("Tahoma", 8.25f, FontStyle.Bold);
      this.NavigationBar1.SelectedPane = this.BATPane;
      this.NavigationBar1.ShowPanes = 4;
      NavigationBar navigationBar1_2 = this.NavigationBar1;
      size1 = new Size(200, 573);
      Size size3 = size1;
      navigationBar1_2.Size = size3;
      this.NavigationBar1.TabIndex = 3;
      this.NavigationBar1.Text = "Navigation";
      this.BATPane.Controls.Add((Control) this.ShowGrid);
      this.BATPane.Controls.Add((Control) this.BATToolBar);
      NavigationPane batPane1 = this.BATPane;
      point1 = new Point(1, 26);
      Point point3 = point1;
      batPane1.Location = point3;
      this.BATPane.Name = "BATPane";
      NavigationPane batPane2 = this.BATPane;
      size1 = new Size(198, 420);
      Size size4 = size1;
      batPane2.Size = size4;
      this.BATPane.TabIndex = 3;
      this.BATPane.Text = "List";
      this.ShowGrid.ColumnInfo = "10,1,0,0,0,95,Columns:";
      this.ShowGrid.Dock = DockStyle.Fill;
      C1.Win.C1FlexGrid.C1FlexGrid showGrid1 = this.ShowGrid;
      point1 = new Point(0, 24);
      Point point4 = point1;
      showGrid1.Location = point4;
      this.ShowGrid.Name = "ShowGrid";
      this.ShowGrid.Rows.DefaultSize = 19;
      C1.Win.C1FlexGrid.C1FlexGrid showGrid2 = this.ShowGrid;
      size1 = new Size(198, 396);
      Size size5 = size1;
      showGrid2.Size = size5;
      this.ShowGrid.Styles = new CellStyleCollection("");
      this.ShowGrid.TabIndex = 3;
      this.ShowGrid.Visible = false;
      TD.SandBar.ToolBar batToolBar1 = this.BATToolBar;
      Guid guid1 = new Guid("7b2eb06c-e622-43bd-a059-5cf9589003d6");
      Guid guid2 = guid1;
      batToolBar1.Guid = guid2;
      this.BATToolBar.ImageList = this.ImageList1;
      this.BATToolBar.Items.AddRange(new ToolbarItemBase[3]
      {
        (ToolbarItemBase) this.BATButtonEnd,
        (ToolbarItemBase) this.BATToolButton1,
        (ToolbarItemBase) this.BATToolButton2
      });
      TD.SandBar.ToolBar batToolBar2 = this.BATToolBar;
      point1 = new Point(0, 0);
      Point point5 = point1;
      batToolBar2.Location = point5;
      this.BATToolBar.Name = "BATToolBar";
      TD.SandBar.ToolBar batToolBar3 = this.BATToolBar;
      size1 = new Size(198, 24);
      Size size6 = size1;
      batToolBar3.Size = size6;
      this.BATToolBar.TabIndex = 2;
      this.BATToolBar.Text = "IndustrieToolBar";
      this.BATButtonEnd.BeginGroup = true;
      this.BATButtonEnd.ImageIndex = 4;
      this.BATButtonEnd.ToolTipText = "Datensatz suchen";
      this.BATToolButton1.BeginGroup = true;
      this.BATToolButton1.ImageIndex = 18;
      this.BATToolButton1.ToolTipText = "sortieren nach Original-Name";
      this.BATToolButton2.BeginGroup = true;
      this.BATToolButton2.ImageIndex = 19;
      this.BATToolButton2.ToolTipText = "sortieren nach lokalem Namen";
      this.WohnenPane.Controls.Add((Control) this.WohnenTreeView);
      this.WohnenPane.Controls.Add((Control) this.WohnenToolBar);
      NavigationPane wohnenPane1 = this.WohnenPane;
      point1 = new Point(1, 26);
      Point point6 = point1;
      wohnenPane1.Location = point6;
      this.WohnenPane.Name = "WohnenPane";
      NavigationPane wohnenPane2 = this.WohnenPane;
      size1 = new Size(198, 420);
      Size size7 = size1;
      wohnenPane2.Size = size7;
      this.WohnenPane.TabIndex = 1;
      this.WohnenPane.Text = "Wohnen";
      this.WohnenTreeView.Dock = DockStyle.Fill;
      this.WohnenTreeView.ImageIndex = -1;
      TreeView wohnenTreeView1 = this.WohnenTreeView;
      point1 = new Point(0, 24);
      Point point7 = point1;
      wohnenTreeView1.Location = point7;
      this.WohnenTreeView.Name = "WohnenTreeView";
      this.WohnenTreeView.SelectedImageIndex = -1;
      TreeView wohnenTreeView2 = this.WohnenTreeView;
      size1 = new Size(198, 396);
      Size size8 = size1;
      wohnenTreeView2.Size = size8;
      this.WohnenTreeView.TabIndex = 0;
      TD.SandBar.ToolBar wohnenToolBar1 = this.WohnenToolBar;
      guid1 = new Guid("7b2eb06c-e622-43bd-a059-5cf9589003d6");
      Guid guid3 = guid1;
      wohnenToolBar1.Guid = guid3;
      this.WohnenToolBar.ImageList = this.ImageList1;
      this.WohnenToolBar.Items.AddRange(new ToolbarItemBase[4]
      {
        (ToolbarItemBase) this.WohnenButtonEnd,
        (ToolbarItemBase) this.WohnenToolButton1,
        (ToolbarItemBase) this.WohnenToolButton2,
        (ToolbarItemBase) this.WohnenToolButton3
      });
      TD.SandBar.ToolBar wohnenToolBar2 = this.WohnenToolBar;
      point1 = new Point(0, 0);
      Point point8 = point1;
      wohnenToolBar2.Location = point8;
      this.WohnenToolBar.Name = "WohnenToolBar";
      TD.SandBar.ToolBar wohnenToolBar3 = this.WohnenToolBar;
      size1 = new Size(198, 24);
      Size size9 = size1;
      wohnenToolBar3.Size = size9;
      this.WohnenToolBar.TabIndex = 2;
      this.WohnenToolBar.Text = "WohnenToolBar";
      this.WohnenButtonEnd.BeginGroup = true;
      this.WohnenButtonEnd.ImageIndex = 4;
      this.WohnenToolButton1.BeginGroup = true;
      this.WohnenToolButton1.ImageIndex = 18;
      this.WohnenToolButton2.BeginGroup = true;
      this.WohnenToolButton2.ImageIndex = 19;
      this.WohnenToolButton3.BeginGroup = true;
      this.WohnenToolButton3.ImageIndex = 13;
      this.WohnenToolButton3.ToolTipText = "Datensatz suchen";
      this.WohnenToolButton3.Visible = false;
      this.GewerbePane.Controls.Add((Control) this.GewerbeTreeView);
      this.GewerbePane.Controls.Add((Control) this.GewerbeToolBar);
      NavigationPane gewerbePane1 = this.GewerbePane;
      point1 = new Point(1, 26);
      Point point9 = point1;
      gewerbePane1.Location = point9;
      this.GewerbePane.Name = "GewerbePane";
      NavigationPane gewerbePane2 = this.GewerbePane;
      size1 = new Size(198, 420);
      Size size10 = size1;
      gewerbePane2.Size = size10;
      this.GewerbePane.TabIndex = 2;
      this.GewerbePane.Text = "Gewerbe";
      this.GewerbeTreeView.Dock = DockStyle.Fill;
      this.GewerbeTreeView.ImageIndex = -1;
      TreeView gewerbeTreeView1 = this.GewerbeTreeView;
      point1 = new Point(0, 24);
      Point point10 = point1;
      gewerbeTreeView1.Location = point10;
      this.GewerbeTreeView.Name = "GewerbeTreeView";
      this.GewerbeTreeView.SelectedImageIndex = -1;
      TreeView gewerbeTreeView2 = this.GewerbeTreeView;
      size1 = new Size(198, 396);
      Size size11 = size1;
      gewerbeTreeView2.Size = size11;
      this.GewerbeTreeView.TabIndex = 0;
      TD.SandBar.ToolBar gewerbeToolBar1 = this.GewerbeToolBar;
      guid1 = new Guid("7b2eb06c-e622-43bd-a059-5cf9589003d6");
      Guid guid4 = guid1;
      gewerbeToolBar1.Guid = guid4;
      this.GewerbeToolBar.ImageList = this.ImageList1;
      this.GewerbeToolBar.Items.AddRange(new ToolbarItemBase[3]
      {
        (ToolbarItemBase) this.GewerbeButtonEnd,
        (ToolbarItemBase) this.GewerbeToolButton1,
        (ToolbarItemBase) this.GewerbeToolButton2
      });
      TD.SandBar.ToolBar gewerbeToolBar2 = this.GewerbeToolBar;
      point1 = new Point(0, 0);
      Point point11 = point1;
      gewerbeToolBar2.Location = point11;
      this.GewerbeToolBar.Name = "GewerbeToolBar";
      TD.SandBar.ToolBar gewerbeToolBar3 = this.GewerbeToolBar;
      size1 = new Size(198, 24);
      Size size12 = size1;
      gewerbeToolBar3.Size = size12;
      this.GewerbeToolBar.TabIndex = 2;
      this.GewerbeToolBar.Text = "GewerbeToolBar";
      this.GewerbeButtonEnd.BeginGroup = true;
      this.GewerbeButtonEnd.ImageIndex = 4;
      this.GewerbeToolButton1.BeginGroup = true;
      this.GewerbeToolButton1.ImageIndex = 18;
      this.GewerbeToolButton2.BeginGroup = true;
      this.GewerbeToolButton2.ImageIndex = 19;
      this.IndustriePane.Controls.Add((Control) this.IndustrieTreeView);
      this.IndustriePane.Controls.Add((Control) this.IndustrieToolBar);
      NavigationPane industriePane1 = this.IndustriePane;
      point1 = new Point(1, 26);
      Point point12 = point1;
      industriePane1.Location = point12;
      this.IndustriePane.Name = "IndustriePane";
      NavigationPane industriePane2 = this.IndustriePane;
      size1 = new Size(198, 420);
      Size size13 = size1;
      industriePane2.Size = size13;
      this.IndustriePane.TabIndex = 3;
      this.IndustriePane.Text = "Industrie";
      this.IndustrieTreeView.Dock = DockStyle.Fill;
      this.IndustrieTreeView.ImageIndex = -1;
      TreeView industrieTreeView1 = this.IndustrieTreeView;
      point1 = new Point(0, 24);
      Point point13 = point1;
      industrieTreeView1.Location = point13;
      this.IndustrieTreeView.Name = "IndustrieTreeView";
      this.IndustrieTreeView.SelectedImageIndex = -1;
      TreeView industrieTreeView2 = this.IndustrieTreeView;
      size1 = new Size(198, 396);
      Size size14 = size1;
      industrieTreeView2.Size = size14;
      this.IndustrieTreeView.TabIndex = 0;
      TD.SandBar.ToolBar industrieToolBar1 = this.IndustrieToolBar;
      guid1 = new Guid("7b2eb06c-e622-43bd-a059-5cf9589003d6");
      Guid guid5 = guid1;
      industrieToolBar1.Guid = guid5;
      this.IndustrieToolBar.ImageList = this.ImageList1;
      this.IndustrieToolBar.Items.AddRange(new ToolbarItemBase[3]
      {
        (ToolbarItemBase) this.IndustrieButtonEnd,
        (ToolbarItemBase) this.IndustrieToolButton1,
        (ToolbarItemBase) this.IndustrieToolButton2
      });
      TD.SandBar.ToolBar industrieToolBar2 = this.IndustrieToolBar;
      point1 = new Point(0, 0);
      Point point14 = point1;
      industrieToolBar2.Location = point14;
      this.IndustrieToolBar.Name = "IndustrieToolBar";
      TD.SandBar.ToolBar industrieToolBar3 = this.IndustrieToolBar;
      size1 = new Size(198, 24);
      Size size15 = size1;
      industrieToolBar3.Size = size15;
      this.IndustrieToolBar.TabIndex = 2;
      this.IndustrieToolBar.Text = "IndustrieToolBar";
      this.IndustrieButtonEnd.BeginGroup = true;
      this.IndustrieButtonEnd.ImageIndex = 4;
      this.IndustrieToolButton1.BeginGroup = true;
      this.IndustrieToolButton1.ImageIndex = 18;
      this.IndustrieToolButton1.ToolTipText = "sortieren nach Original-Name";
      this.IndustrieToolButton2.BeginGroup = true;
      this.IndustrieToolButton2.ImageIndex = 19;
      this.IndustrieToolButton2.ToolTipText = "sortieren nach lokalem Namen";
      Splitter splitter1_1 = this.Splitter1;
      point1 = new Point(200, 0);
      Point point15 = point1;
      splitter1_1.Location = point15;
      this.Splitter1.Name = "Splitter1";
      Splitter splitter1_2 = this.Splitter1;
      size1 = new Size(8, 573);
      Size size16 = size1;
      splitter1_2.Size = size16;
      this.Splitter1.TabIndex = 4;
      this.Splitter1.TabStop = false;
      this.HeaderControl2.Controls.Add((Control) this.MainAusgabeGrid);
      this.HeaderControl2.Controls.Add((Control) this.AusgabeFlexGrid);
      this.HeaderControl2.Controls.Add((Control) this.ToolBar1);
      this.HeaderControl2.Dock = DockStyle.Fill;
      this.HeaderControl2.HeaderFont = new Font("Tahoma", 12f, FontStyle.Bold);
      HeaderControl headerControl2_1 = this.HeaderControl2;
      point1 = new Point(208, 0);
      Point point16 = point1;
      headerControl2_1.Location = point16;
      this.HeaderControl2.Name = "HeaderControl2";
      HeaderControl headerControl2_2 = this.HeaderControl2;
      size1 = new Size(584, 573);
      Size size17 = size1;
      headerControl2_2.Size = size17;
      this.HeaderControl2.TabIndex = 8;
      this.HeaderControl2.Text = "<....>";
      this.AusgabeFlexGrid.ColumnInfo = "10,1,0,0,0,95,Columns:";
      this.AusgabeFlexGrid.Dock = DockStyle.Fill;
      C1.Win.C1FlexGrid.C1FlexGrid ausgabeFlexGrid1 = this.AusgabeFlexGrid;
      point1 = new Point(1, 50);
      Point point17 = point1;
      ausgabeFlexGrid1.Location = point17;
      this.AusgabeFlexGrid.Name = "AusgabeFlexGrid";
      this.AusgabeFlexGrid.Rows.Count = 0;
      this.AusgabeFlexGrid.Rows.DefaultSize = 19;
      this.AusgabeFlexGrid.Rows.Fixed = 0;
      C1.Win.C1FlexGrid.C1FlexGrid ausgabeFlexGrid2 = this.AusgabeFlexGrid;
      size1 = new Size(582, 522);
      Size size18 = size1;
      ausgabeFlexGrid2.Size = size18;
      this.AusgabeFlexGrid.Styles = new CellStyleCollection("");
      this.AusgabeFlexGrid.TabIndex = 10;
      this.AusgabeFlexGrid.Visible = false;
      TD.SandBar.ToolBar toolBar1_1 = this.ToolBar1;
      guid1 = new Guid("0b7d4ef2-f5d8-4a95-9858-aebbfc58424c");
      Guid guid6 = guid1;
      toolBar1_1.Guid = guid6;
      this.ToolBar1.ImageList = this.ImageList1;
      this.ToolBar1.Items.AddRange(new ToolbarItemBase[2]
      {
        (ToolbarItemBase) this.ButtonSave,
        (ToolbarItemBase) this.ButtonHTML
      });
      TD.SandBar.ToolBar toolBar1_2 = this.ToolBar1;
      point1 = new Point(1, 26);
      Point point18 = point1;
      toolBar1_2.Location = point18;
      this.ToolBar1.Name = "ToolBar1";
      TD.SandBar.ToolBar toolBar1_3 = this.ToolBar1;
      size1 = new Size(582, 24);
      Size size19 = size1;
      toolBar1_3.Size = size19;
      this.ToolBar1.TabIndex = 0;
      this.ToolBar1.Text = "ToolBar1";
      this.ButtonSave.Enabled = false;
      this.ButtonSave.BeginGroup = true;
      this.ButtonSave.ImageIndex = 10;
      this.ButtonHTML.BeginGroup = true;
      this.ButtonHTML.ImageIndex = 24;
      this.MainAusgabeGrid.ColumnInfo = "10,1,0,0,0,95,Columns:";
      this.MainAusgabeGrid.Dock = DockStyle.Fill;
      C1.Win.C1FlexGrid.C1FlexGrid mainAusgabeGrid1 = this.MainAusgabeGrid;
      point1 = new Point(1, 50);
      Point point19 = point1;
      mainAusgabeGrid1.Location = point19;
      this.MainAusgabeGrid.Name = "MainAusgabeGrid";
      this.MainAusgabeGrid.Rows.DefaultSize = 19;
      C1.Win.C1FlexGrid.C1FlexGrid mainAusgabeGrid2 = this.MainAusgabeGrid;
      size1 = new Size(582, 522);
      Size size20 = size1;
      mainAusgabeGrid2.Size = size20;
      this.MainAusgabeGrid.Styles = new CellStyleCollection("");
      this.MainAusgabeGrid.TabIndex = 11;
      size1 = new Size(6, 15);
      this.AutoScaleBaseSize = size1;
      this.BackColor = SystemColors.Control;
      size1 = new Size(792, 573);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.HeaderControl2);
      this.Controls.Add((Control) this.Splitter1);
      this.Controls.Add((Control) this.NavigationBar1);
      this.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Name = nameof (FormDB);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.NavigationBar1.ResumeLayout(false);
      this.BATPane.ResumeLayout(false);
      this.ShowGrid.EndInit();
      this.WohnenPane.ResumeLayout(false);
      this.GewerbePane.ResumeLayout(false);
      this.IndustriePane.ResumeLayout(false);
      this.HeaderControl2.ResumeLayout(false);
      this.AusgabeFlexGrid.EndInit();
      this.MainAusgabeGrid.EndInit();
      this.ResumeLayout(false);
    }

    private void ShowGrid_BeforeEdit(object sender, RowColEventArgs e)
    {
      if (e.Col != 1)
        return;
      e.Cancel = true;
    }

    private void ShowGrid_AfterEdit(object sender, RowColEventArgs e)
    {
      string columnName = StringType.FromObject(this.ShowGrid[e.Row, 2]);
      if (ObjectType.ObjTst(this.ShowGrid[e.Row, e.Col], (object) true, false) == 0)
        this.AusgabeFlexGrid.Cols[columnName].Visible = true;
      else
        this.AusgabeFlexGrid.Cols[columnName].Visible = false;
    }

    private object SetFlexTexte()
    {
      ArrayList arrayList = new ArrayList();
      C1.Win.C1FlexGrid.C1FlexGrid ausgabeFlexGrid = this.AusgabeFlexGrid;
      if (StringType.StrCmp(ClassThisProg.DefReader.SortierKriterium, "A", false) == 0)
      {
        arrayList.Add(RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[129]));
        ausgabeFlexGrid[1, "Name"] = RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[129]);
      }
      else
      {
        arrayList.Add(RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[130]));
        ausgabeFlexGrid[1, "Name"] = RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[130]);
      }
      arrayList.Add(RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[121]));
      ausgabeFlexGrid[1, "Typ"] = RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[121]);
      arrayList.Add(RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[118]));
      ausgabeFlexGrid[1, "Set"] = RuntimeHelpers.GetObjectValue(arrayList[checked (arrayList.Count - 1)]);
      arrayList.Add(RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[114]));
      ausgabeFlexGrid[1, "building_value"] = RuntimeHelpers.GetObjectValue(arrayList[checked (arrayList.Count - 1)]);
      arrayList.Add(RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[119]));
      ausgabeFlexGrid[1, "Stage"] = RuntimeHelpers.GetObjectValue(arrayList[checked (arrayList.Count - 1)]);
      arrayList.Add(RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[117]));
      ausgabeFlexGrid[0, "capacity0"] = RuntimeHelpers.GetObjectValue(arrayList[checked (arrayList.Count - 1)]);
      ausgabeFlexGrid[0, "capacity1"] = RuntimeHelpers.GetObjectValue(arrayList[checked (arrayList.Count - 1)]);
      ausgabeFlexGrid[0, "capacity2"] = RuntimeHelpers.GetObjectValue(arrayList[checked (arrayList.Count - 1)]);
      ausgabeFlexGrid[1, "capacity0"] = RuntimeHelpers.GetObjectValue(arrayList[checked (arrayList.Count - 1)]);
      arrayList.Add(RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[116]));
      ausgabeFlexGrid[1, "capacity1"] = RuntimeHelpers.GetObjectValue(arrayList[checked (arrayList.Count - 1)]);
      arrayList.Add(RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[115]));
      ausgabeFlexGrid[1, "capacity2"] = RuntimeHelpers.GetObjectValue(arrayList[checked (arrayList.Count - 1)]);
      arrayList.Add(RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[113]));
      ausgabeFlexGrid[1, "bulldoze_cost"] = RuntimeHelpers.GetObjectValue(arrayList[checked (arrayList.Count - 1)]);
      arrayList.Add(RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[112]));
      ausgabeFlexGrid[1, "Schadenswert"] = RuntimeHelpers.GetObjectValue(arrayList[checked (arrayList.Count - 1)]);
      arrayList.Add(RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[109]));
      ausgabeFlexGrid[1, "flammability"] = RuntimeHelpers.GetObjectValue(arrayList[checked (arrayList.Count - 1)]);
      arrayList.Add(RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[108]));
      ausgabeFlexGrid[1, "max_fire_stage"] = RuntimeHelpers.GetObjectValue(arrayList[checked (arrayList.Count - 1)]);
      arrayList.Add(RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[111]));
      ausgabeFlexGrid[1, "energy_consumed"] = RuntimeHelpers.GetObjectValue(arrayList[checked (arrayList.Count - 1)]);
      arrayList.Add(RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[110]));
      ausgabeFlexGrid[1, "water_consumed"] = RuntimeHelpers.GetObjectValue(arrayList[checked (arrayList.Count - 1)]);
      ausgabeFlexGrid[0, "pollution_air"] = ObjectType.StrCatObj(ObjectType.StrCatObj(ClassThisProg.DefReader.LanguageArray[101], (object) " "), ClassThisProg.DefReader.LanguageArray[103]);
      ausgabeFlexGrid[0, "pollution_water"] = ObjectType.StrCatObj(ObjectType.StrCatObj(ClassThisProg.DefReader.LanguageArray[101], (object) " "), ClassThisProg.DefReader.LanguageArray[103]);
      ausgabeFlexGrid[0, "pollution_garbage"] = ObjectType.StrCatObj(ObjectType.StrCatObj(ClassThisProg.DefReader.LanguageArray[101], (object) " "), ClassThisProg.DefReader.LanguageArray[103]);
      ausgabeFlexGrid[0, "pollution_radiation"] = ObjectType.StrCatObj(ObjectType.StrCatObj(ClassThisProg.DefReader.LanguageArray[101], (object) " "), ClassThisProg.DefReader.LanguageArray[103]);
      ausgabeFlexGrid[1, "pollution_air"] = RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[107]);
      ausgabeFlexGrid[1, "pollution_water"] = RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[106]);
      ausgabeFlexGrid[1, "pollution_garbage"] = RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[105]);
      ausgabeFlexGrid[1, "pollution_radiation"] = RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[104]);
      arrayList.Add(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(ClassThisProg.DefReader.LanguageArray[101], (object) " "), ClassThisProg.DefReader.LanguageArray[103]), (object) " "), ClassThisProg.DefReader.LanguageArray[107]));
      arrayList.Add(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(ClassThisProg.DefReader.LanguageArray[101], (object) " "), ClassThisProg.DefReader.LanguageArray[103]), (object) " "), ClassThisProg.DefReader.LanguageArray[106]));
      arrayList.Add(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(ClassThisProg.DefReader.LanguageArray[101], (object) " "), ClassThisProg.DefReader.LanguageArray[103]), (object) " "), ClassThisProg.DefReader.LanguageArray[105]));
      arrayList.Add(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(ClassThisProg.DefReader.LanguageArray[101], (object) " "), ClassThisProg.DefReader.LanguageArray[103]), (object) " "), ClassThisProg.DefReader.LanguageArray[104]));
      ausgabeFlexGrid[0, "pollution_air_radius"] = ObjectType.StrCatObj(ObjectType.StrCatObj(ClassThisProg.DefReader.LanguageArray[101], (object) " "), ClassThisProg.DefReader.LanguageArray[102]);
      ausgabeFlexGrid[0, "pollution_water_radius"] = ObjectType.StrCatObj(ObjectType.StrCatObj(ClassThisProg.DefReader.LanguageArray[101], (object) " "), ClassThisProg.DefReader.LanguageArray[102]);
      ausgabeFlexGrid[0, "pollution_garbage_radius"] = ObjectType.StrCatObj(ObjectType.StrCatObj(ClassThisProg.DefReader.LanguageArray[101], (object) " "), ClassThisProg.DefReader.LanguageArray[102]);
      ausgabeFlexGrid[0, "pollution_radiation_radius"] = ObjectType.StrCatObj(ObjectType.StrCatObj(ClassThisProg.DefReader.LanguageArray[101], (object) " "), ClassThisProg.DefReader.LanguageArray[102]);
      ausgabeFlexGrid[1, "pollution_air_radius"] = RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[107]);
      ausgabeFlexGrid[1, "pollution_water_radius"] = RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[106]);
      ausgabeFlexGrid[1, "pollution_garbage_radius"] = RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[105]);
      ausgabeFlexGrid[1, "pollution_radiation_radius"] = RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[104]);
      arrayList.Add(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(ClassThisProg.DefReader.LanguageArray[101], (object) " "), ClassThisProg.DefReader.LanguageArray[102]), (object) " "), ClassThisProg.DefReader.LanguageArray[107]));
      arrayList.Add(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(ClassThisProg.DefReader.LanguageArray[101], (object) " "), ClassThisProg.DefReader.LanguageArray[102]), (object) " "), ClassThisProg.DefReader.LanguageArray[106]));
      arrayList.Add(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(ClassThisProg.DefReader.LanguageArray[101], (object) " "), ClassThisProg.DefReader.LanguageArray[102]), (object) " "), ClassThisProg.DefReader.LanguageArray[105]));
      arrayList.Add(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(ClassThisProg.DefReader.LanguageArray[101], (object) " "), ClassThisProg.DefReader.LanguageArray[102]), (object) " "), ClassThisProg.DefReader.LanguageArray[104]));
      this.ShowGrid.Rows.Count = 0;
      int num = checked (ausgabeFlexGrid.Cols.Count - 1);
      int index = 0;
      while (index <= num)
      {
        this.ShowGrid.Rows.Add();
        this.ShowGrid.GetCellRange(checked (this.ShowGrid.Rows.Count - 1), 0).Style = this.ShowGrid.Styles["Show"];
        this.ShowGrid[checked (this.ShowGrid.Rows.Count - 1), 0] = (object) true;
        this.ShowGrid[checked (this.ShowGrid.Rows.Count - 1), 1] = RuntimeHelpers.GetObjectValue(arrayList[index]);
        this.ShowGrid[checked (this.ShowGrid.Rows.Count - 1), 2] = (object) ausgabeFlexGrid.Cols[index].Name;
        checked { ++index; }
      }
      object obj;
      return obj;
    }

    private object SetFlexGridRows(DataRow[] AusgabeRows, string WertString)
    {
      ArrayList arrayList1 = new ArrayList();
      arrayList1.Add((object) "building_value");
      arrayList1.Add((object) "Stage");
      arrayList1.Add((object) "capacity0");
      arrayList1.Add((object) "capacity1");
      arrayList1.Add((object) "capacity2");
      arrayList1.Add((object) "bulldoze_cost");
      arrayList1.Add((object) "Schadenswert");
      arrayList1.Add((object) "flammability");
      arrayList1.Add((object) "max_fire_stage");
      arrayList1.Add((object) "energy_consumed");
      arrayList1.Add((object) "water_consumed");
      arrayList1.Add((object) "pollution_air");
      arrayList1.Add((object) "pollution_water");
      arrayList1.Add((object) "pollution_garbage");
      arrayList1.Add((object) "pollution_radiation");
      arrayList1.Add((object) "pollution_air_radius");
      arrayList1.Add((object) "pollution_water_radius");
      arrayList1.Add((object) "pollution_garbage_radius");
      arrayList1.Add((object) "pollution_radiation_radius");
      C1.Win.C1FlexGrid.C1FlexGrid ausgabeFlexGrid = this.AusgabeFlexGrid;
      int upperBound = AusgabeRows.GetUpperBound(0);
      int index1 = 0;
      while (index1 <= upperBound)
      {
        ausgabeFlexGrid.Rows.Add();
        ausgabeFlexGrid[checked (ausgabeFlexGrid.Rows.Count - 1), "Typ"] = (object) WertString;
        string str;
        if (StringType.StrCmp(ClassThisProg.DefReader.SortierKriterium, "A", false) == 0)
        {
          if (!AusgabeRows[index1].IsNull("Name"))
            str = StringType.FromObject(AusgabeRows[index1]["Name"]);
        }
        else if (!AusgabeRows[index1].IsNull("yourName"))
          str = StringType.FromObject(AusgabeRows[index1]["yourName"]);
        ausgabeFlexGrid[checked (ausgabeFlexGrid.Rows.Count - 1), "Name"] = (object) str;
        str = "";
        if (!AusgabeRows[index1].IsNull("Set"))
        {
          int num = -1;
          object o1 = LateBinding.LateGet(AusgabeRows[index1]["Set"], (System.Type) null, "toupper", new object[0], (string[]) null, (bool[]) null);
          if (ObjectType.ObjTst(o1, (object) "HOU", false) == 0)
            num = 0;
          else if (ObjectType.ObjTst(o1, (object) "NY", false) == 0)
            num = 1;
          else if (ObjectType.ObjTst(o1, (object) "CHI", false) == 0)
            num = 2;
          else if (ObjectType.ObjTst(o1, (object) "EUR", false) == 0)
            num = 3;
          if (num > -1)
            str = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[checked (122 + num)]);
        }
        ausgabeFlexGrid[checked (ausgabeFlexGrid.Rows.Count - 1), "Set"] = (object) str;
        int num1 = checked (arrayList1.Count - 1);
        int index2 = 0;
        while (index2 <= num1)
        {
          DataRow ausgabeRow = AusgabeRows[index1];
          object[] objArray1 = new object[1];
          object[] objArray2 = objArray1;
          ArrayList arrayList2 = arrayList1;
          ArrayList arrayList3 = arrayList2;
          int index3 = index2;
          int index4 = index3;
          object objectValue = RuntimeHelpers.GetObjectValue(arrayList3[index4]);
          objArray2[0] = objectValue;
          object[] objArray3 = objArray1;
          object[] args = objArray3;
          bool[] flagArray = new bool[1]{ true };
          bool[] CopyBack = flagArray;
          object o1 = LateBinding.LateGet((object) ausgabeRow, (System.Type) null, "IsNull", args, (string[]) null, CopyBack);
          if (flagArray[0])
            arrayList2[index3] = RuntimeHelpers.GetObjectValue(objArray3[0]);
          // ISSUE: variable of a boxed type
          __Boxed<bool> local = (System.ValueType) false;
          if (ObjectType.ObjTst(o1, (object) local, false) == 0)
          {
            try
            {
              LateBinding.LateSet((object) ausgabeFlexGrid, (System.Type) null, "Item", new object[3]
              {
                (object) checked (ausgabeFlexGrid.Rows.Count - 1),
                RuntimeHelpers.GetObjectValue(arrayList1[index2]),
                (object) LongType.FromObject(LateBinding.LateGet((object) AusgabeRows[index1], (System.Type) null, "Item", new object[1]
                {
                  RuntimeHelpers.GetObjectValue(arrayList1[index2])
                }, (string[]) null, (bool[]) null))
              }, (string[]) null);
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              LateBinding.LateSet((object) ausgabeFlexGrid, (System.Type) null, "Item", new object[3]
              {
                (object) checked (ausgabeFlexGrid.Rows.Count - 1),
                RuntimeHelpers.GetObjectValue(arrayList1[index2]),
                RuntimeHelpers.GetObjectValue(LateBinding.LateGet((object) AusgabeRows[index1], (System.Type) null, "Item", new object[1]
                {
                  RuntimeHelpers.GetObjectValue(arrayList1[index2])
                }, (string[]) null, (bool[]) null))
              }, (string[]) null);
              ProjectData.ClearProjectError();
            }
          }
          checked { ++index2; }
        }
        checked { ++index1; }
      }
      object obj;
      return obj;
    }

    private object FillFlexGrid()
    {
      ArrayList arrayList = new ArrayList();
      try
      {
        this.Cursor = Cursors.WaitCursor;
        this.AusgabeFlexGrid.Redraw = false;
        this.AusgabeFlexGrid.Rows.Count = this.AusgabeFlexGrid.Rows.Fixed;
        arrayList.Add((object) "Industrie");
        arrayList.Add((object) "Gewerbe");
        arrayList.Add((object) "Wohnen");
        int num1 = checked (arrayList.Count - 1);
        int index1 = 0;
        while (index1 <= num1)
        {
          object o1 = arrayList[index1];
          int num2;
          int num3;
          int num4;
          if (ObjectType.ObjTst(o1, (object) "Industrie", false) == 0)
          {
            num2 = 136;
            num3 = 139;
            num4 = 1;
          }
          else if (ObjectType.ObjTst(o1, (object) "Gewerbe", false) == 0)
          {
            num2 = 141;
            num3 = 142;
            num4 = 6;
          }
          else if (ObjectType.ObjTst(o1, (object) "Wohnen", false) == 0)
          {
            num2 = 140;
            num3 = 140;
            num4 = 5;
          }
          int num5 = num2;
          int num6 = num3;
          int index2 = num5;
          while (index2 <= num6)
          {
            int num7 = 0;
            do
            {
              string str;
              switch (num7)
              {
                case 0:
                  str = "§";
                  break;
                case 1:
                  str = "§§";
                  break;
                case 2:
                  str = "§§§";
                  break;
              }
              string SelectionString = "Typ = '" + num4.ToString() + "' and Wohlstand = '" + str + "'";
              string WertString = StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj(ClassThisProg.DefReader.LanguageArray[index2], (object) " "), (object) str));
              DataRow[] wantedSelection = this.GetWantedSelection(SelectionString);
              if (wantedSelection.GetUpperBound(0) > -1)
                this.SetFlexGridRows(wantedSelection, WertString);
              checked { ++num7; }
            }
            while (num7 <= 2);
            checked { ++num4; }
            checked { ++index2; }
          }
          checked { ++index1; }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      this.AusgabeFlexGrid.Redraw = true;
      this.Cursor = Cursors.Default;
      object obj;
      return obj;
    }

    private bool FillTreeViews(TreeView MyTreeView, string Art)
    {
      DataSet dataSet = new DataSet();
      TreeView treeView = MyTreeView;
      treeView.Visible = false;
      treeView.Nodes.Clear();
      treeView.ImageList = this.ImageList1;
      treeView.AllowDrop = false;
      treeView.CheckBoxes = false;
      treeView.FullRowSelect = true;
      treeView.ShowLines = true;
      treeView.ShowPlusMinus = true;
      treeView.ShowRootLines = true;
      treeView.HideSelection = false;
      treeView.SuspendLayout();
      treeView.BeginUpdate();
      int index1 = 0;
      string sLeft = Art;
      int num1;
      int num2;
      int num3;
      if (StringType.StrCmp(sLeft, "Industrie", false) == 0)
      {
        num1 = 136;
        num2 = 139;
        num3 = 1;
      }
      else if (StringType.StrCmp(sLeft, "Gewerbe", false) == 0)
      {
        num1 = 141;
        num2 = 142;
        num3 = 6;
      }
      else if (StringType.StrCmp(sLeft, "Wohnen", false) == 0)
      {
        num1 = 140;
        num2 = 140;
        num3 = 5;
      }
      int num4 = num1;
      int num5 = num2;
      int index2 = num4;
      while (index2 <= num5)
      {
        int num6 = 0;
        do
        {
          string str1;
          switch (num6)
          {
            case 0:
              str1 = "§";
              break;
            case 1:
              str1 = "§§";
              break;
            case 2:
              str1 = "§§§";
              break;
          }
          string SelectionString = "Typ = '" + num3.ToString() + "' and Wohlstand = '" + str1 + "'";
          string str2 = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[index2]);
          int index3 = -1;
          DataRow[] wantedSelection = this.GetWantedSelection(SelectionString);
          if (wantedSelection.GetUpperBound(0) > -1)
          {
            treeView.Nodes.Add(new TreeNode(str2 + " " + str1));
            treeView.Nodes[index1].Tag = (object) ("L" + num3.ToString());
            treeView.Nodes[index1].SelectedImageIndex = 0;
            treeView.Nodes[index1].ImageIndex = 1;
            int upperBound = wantedSelection.GetUpperBound(0);
            int index4 = 0;
            while (index4 <= upperBound)
            {
              DataRow dataRow = wantedSelection[index4];
              if (StringType.StrCmp(ClassThisProg.DefReader.SortierKriterium, "A", false) == 0)
                treeView.Nodes[index1].Nodes.Add(new TreeNode(StringType.FromObject(dataRow["name"])));
              else
                treeView.Nodes[index1].Nodes.Add(new TreeNode(StringType.FromObject(dataRow["yourName"])));
              checked { ++index3; }
              treeView.Nodes[index1].Nodes[index3].Tag = ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(dataRow["ID"], (object) "#"), dataRow["name"]), (object) "#"), dataRow["yourName"]);
              treeView.Nodes[index1].Nodes[index3].SelectedImageIndex = 0;
              treeView.Nodes[index1].Nodes[index3].ImageIndex = 1;
              checked { ++index4; }
            }
            checked { ++index1; }
          }
          checked { ++num6; }
        }
        while (num6 <= 2);
        checked { ++num3; }
        checked { ++index2; }
      }
      treeView.Visible = true;
      treeView.EndUpdate();
      return true;
    }

    private object SetzeAusgabeArt(string Art)
    {
      this.Cursor = Cursors.WaitCursor;
      ClassThisProg.DefReader.SortierKriterium = Art;
      ClassThisProg.DefReader.SaveSettings();
      IEnumerator enumerator1 = this.IndustrieTreeView.Nodes.GetEnumerator();
      while (enumerator1.MoveNext())
      {
        TreeNode current = (TreeNode) enumerator1.Current;
        string[] strArray1 = current.Tag.ToString().Split('#');
        if (strArray1.GetUpperBound(0) == 2)
        {
          if (StringType.StrCmp(ClassThisProg.DefReader.SortierKriterium, "A", false) == 0)
            ((TreeNode) enumerator1.Current).Text = strArray1[1];
          else
            ((TreeNode) enumerator1.Current).Text = strArray1[2];
        }
        else
        {
          int nodeCount = current.GetNodeCount(true);
          if (nodeCount > 0)
          {
            int num = checked (nodeCount - 1);
            int index = 0;
            while (index <= num)
            {
              string[] strArray2 = current.Nodes[index].Tag.ToString().Split('#');
              if (strArray2.GetUpperBound(0) == 2)
                current.Nodes[index].Text = StringType.StrCmp(ClassThisProg.DefReader.SortierKriterium, "A", false) != 0 ? strArray2[2] : strArray2[1];
              checked { ++index; }
            }
          }
        }
      }
      IEnumerator enumerator2 = this.GewerbeTreeView.Nodes.GetEnumerator();
      while (enumerator2.MoveNext())
      {
        TreeNode current = (TreeNode) enumerator2.Current;
        string[] strArray3 = current.Tag.ToString().Split('#');
        if (strArray3.GetUpperBound(0) == 2)
        {
          if (StringType.StrCmp(ClassThisProg.DefReader.SortierKriterium, "A", false) == 0)
            ((TreeNode) enumerator2.Current).Text = strArray3[1];
          else
            ((TreeNode) enumerator2.Current).Text = strArray3[2];
        }
        else
        {
          int nodeCount = current.GetNodeCount(true);
          if (nodeCount > 0)
          {
            int num = checked (nodeCount - 1);
            int index = 0;
            while (index <= num)
            {
              string[] strArray4 = current.Nodes[index].Tag.ToString().Split('#');
              if (strArray4.GetUpperBound(0) == 2)
                current.Nodes[index].Text = StringType.StrCmp(ClassThisProg.DefReader.SortierKriterium, "A", false) != 0 ? strArray4[2] : strArray4[1];
              checked { ++index; }
            }
          }
        }
      }
      IEnumerator enumerator3 = this.WohnenTreeView.Nodes.GetEnumerator();
      while (enumerator3.MoveNext())
      {
        TreeNode current = (TreeNode) enumerator3.Current;
        string[] strArray5 = current.Tag.ToString().Split('#');
        if (strArray5.GetUpperBound(0) == 2)
        {
          if (StringType.StrCmp(ClassThisProg.DefReader.SortierKriterium, "A", false) == 0)
            ((TreeNode) enumerator3.Current).Text = strArray5[1];
          else
            ((TreeNode) enumerator3.Current).Text = strArray5[2];
        }
        else
        {
          int nodeCount = current.GetNodeCount(true);
          if (nodeCount > 0)
          {
            int num = checked (nodeCount - 1);
            int index = 0;
            while (index <= num)
            {
              string[] strArray6 = current.Nodes[index].Tag.ToString().Split('#');
              if (strArray6.GetUpperBound(0) == 2)
                current.Nodes[index].Text = StringType.StrCmp(ClassThisProg.DefReader.SortierKriterium, "A", false) != 0 ? strArray6[2] : strArray6[1];
              checked { ++index; }
            }
          }
        }
      }
      if (this.AusgabeFlexGrid.Rows.Count > this.AusgabeFlexGrid.Rows.Fixed)
      {
        this.SetFlexTexte();
        this.FillFlexGrid();
      }
      else
        this.SetFlexTexte();
      this.Cursor = Cursors.Default;
      object obj;
      return obj;
    }

    private DataRow[] GetWantedSelection(string SelectionString)
    {
      string sort = StringType.StrCmp(ClassThisProg.DefReader.SortierKriterium, "A", false) != 0 ? "yourName" : "Name";
      return ClassThisProg.DefReader.DB_xmldoc.DataSet.Tables["Buildings"].Select(SelectionString, sort);
    }

    private object ChangeTreeViewLanguage(TreeView myTreeView)
    {
      if (myTreeView.GetNodeCount(false) > 0)
      {
        int num = checked (myTreeView.GetNodeCount(false) - 1);
        int index = 0;
        while (index <= num)
        {
          string str1 = myTreeView.Nodes[index].Text;
          int startIndex = myTreeView.Nodes[index].Text.IndexOf("§");
          string str2 = "";
          if (startIndex > 0)
            str2 = myTreeView.Nodes[index].Text.Substring(startIndex, checked (myTreeView.Nodes[index].Text.Length - startIndex));
          if (ObjectType.ObjTst(myTreeView.Nodes[index].Tag, (object) "", false) != 0)
          {
            string sLeft = StringType.FromObject(LateBinding.LateGet(myTreeView.Nodes[index].Tag, (System.Type) null, "Substring", new object[2]
            {
              (object) 1,
              (object) 1
            }, (string[]) null, (bool[]) null));
            if (StringType.StrCmp(sLeft, "1", false) == 0)
              str1 = StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj(ClassThisProg.DefReader.LanguageArray[136], (object) " "), (object) str2));
            else if (StringType.StrCmp(sLeft, "2", false) == 0)
              str1 = StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj(ClassThisProg.DefReader.LanguageArray[137], (object) " "), (object) str2));
            else if (StringType.StrCmp(sLeft, "3", false) == 0)
              str1 = StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj(ClassThisProg.DefReader.LanguageArray[138], (object) " "), (object) str2));
            else if (StringType.StrCmp(sLeft, "4", false) == 0)
              str1 = StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj(ClassThisProg.DefReader.LanguageArray[139], (object) " "), (object) str2));
            else if (StringType.StrCmp(sLeft, "5", false) == 0)
              str1 = StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj(ClassThisProg.DefReader.LanguageArray[140], (object) " "), (object) str2));
            else if (StringType.StrCmp(sLeft, "6", false) == 0)
              str1 = StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj(ClassThisProg.DefReader.LanguageArray[141], (object) " "), (object) str2));
            else if (StringType.StrCmp(sLeft, "7", false) == 0)
              str1 = StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj(ClassThisProg.DefReader.LanguageArray[142], (object) " "), (object) str2));
          }
          myTreeView.Nodes[index].Text = str1;
          checked { ++index; }
        }
      }
      object obj;
      return obj;
    }

    public object SetzeTexte()
    {
      ArrayList arrayList = new ArrayList();
      this.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[1]);
      this.IndustriePane.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[5]);
      this.GewerbePane.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[6]);
      this.WohnenPane.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[7]);
      this.IndustrieToolButton1.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[8]);
      this.IndustrieToolButton2.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[9]);
      this.GewerbeToolButton1.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[8]);
      this.GewerbeToolButton2.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[9]);
      this.WohnenToolButton1.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[8]);
      this.WohnenToolButton2.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[9]);
      this.BATToolButton1.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[8]);
      this.BATToolButton2.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[9]);
      this.IndustrieButtonEnd.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[3]);
      this.GewerbeButtonEnd.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[3]);
      this.WohnenButtonEnd.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[3]);
      this.BATButtonEnd.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[3]);
      this.ButtonSave.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[17]);
      this.ButtonHTML.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[63]);
      this.SuchAusgabeText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[134]);
      this.ChangeTreeViewLanguage(this.IndustrieTreeView);
      this.ChangeTreeViewLanguage(this.GewerbeTreeView);
      this.ChangeTreeViewLanguage(this.WohnenTreeView);
      this.BATPane.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[479]);
      this.SetFlexTexte();
      object obj;
      return obj;
    }

    private void IndustrieToolButton1_Activate(object sender, EventArgs e) => this.SetzeAusgabeArt("A");

    private void IndustrieToolButton2_Activate(object sender, EventArgs e) => this.SetzeAusgabeArt("B");

    private void IndustrieTreeView_AfterSelect(object sender, TreeViewEventArgs e)
    {
      this.HeaderControl2.Text = "<....>";
      this.MainAusgabeGrid.Rows.Count = 0;
      this.ButtonSave.Enabled = false;
      this.AktuellerTreeView = this.IndustrieTreeView;
      string[] strArray = e.Node.Tag.ToString().Split('#');
      if (strArray.GetUpperBound(0) != 2 || !Information.IsNumeric((object) strArray[0]))
        return;
      this.GetDisplayDataSet(strArray[0]);
    }

    private void GewerbeTreeView_AfterSelect(object sender, TreeViewEventArgs e)
    {
      this.HeaderControl2.Text = "<....>";
      this.MainAusgabeGrid.Rows.Count = 0;
      this.ButtonSave.Enabled = false;
      this.AktuellerTreeView = this.GewerbeTreeView;
      string[] strArray = e.Node.Tag.ToString().Split('#');
      if (strArray.GetUpperBound(0) != 2 || !Information.IsNumeric((object) strArray[0]))
        return;
      this.GetDisplayDataSet(strArray[0]);
    }

    private void WohnenTreeView_AfterSelect(object sender, TreeViewEventArgs e)
    {
      this.HeaderControl2.Text = "<....>";
      this.MainAusgabeGrid.Rows.Count = 0;
      this.ButtonSave.Enabled = false;
      this.AktuellerTreeView = this.WohnenTreeView;
      string[] strArray = e.Node.Tag.ToString().Split('#');
      if (strArray.GetUpperBound(0) != 2 || !Information.IsNumeric((object) strArray[0]))
        return;
      this.GetDisplayDataSet(strArray[0]);
    }

    private void FormDB_Load(object sender, EventArgs e)
    {
      this.Cursor = Cursors.AppStarting;
      this.FirstStart = true;
      sr_Userinterface.AendereFarben((Form) this, ClassThisProg.DefReader.FarbSchema);
      this.SetzeTexte();
      this.Show();
      Application.DoEvents();
      if (!this.FillTreeViews(this.IndustrieTreeView, "Industrie"))
      {
        this.Cursor = Cursors.Default;
        int num = (int) MessageBox.Show((IWin32Window) this, "Fehler in der Systemumgebung!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.Dispose();
      }
      if (!this.FillTreeViews(this.GewerbeTreeView, "Gewerbe"))
      {
        this.Cursor = Cursors.Default;
        int num = (int) MessageBox.Show((IWin32Window) this, "Fehler in der Systemumgebung!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.Dispose();
      }
      if (!this.FillTreeViews(this.WohnenTreeView, "Wohnen"))
      {
        this.Cursor = Cursors.Default;
        int num = (int) MessageBox.Show((IWin32Window) this, "Fehler in der Systemumgebung!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.Dispose();
      }
      this.FirstStart = false;
      this.NavigationBar1.SelectedPane = this.IndustriePane;
      this.Cursor = Cursors.Default;
    }

    private object SetFlexUeberschrift(string AusgabeText, Image AusgabeImage)
    {
      C1.Win.C1FlexGrid.C1FlexGrid mainAusgabeGrid = this.MainAusgabeGrid;
      mainAusgabeGrid.Rows.Add();
      mainAusgabeGrid.SetData(checked (mainAusgabeGrid.Rows.Count - 1), this.InfoCol, (object) "");
      mainAusgabeGrid.SetData(checked (mainAusgabeGrid.Rows.Count - 1), this.IndexCol, (object) "");
      CellRange cellRange = mainAusgabeGrid.GetCellRange(checked (mainAusgabeGrid.Rows.Count - 1), this.AusgabeCol, checked (mainAusgabeGrid.Rows.Count - 1), checked (mainAusgabeGrid.Cols.Count - 1));
      cellRange.Style = mainAusgabeGrid.Styles["LeftImage"];
      cellRange.Image = AusgabeImage;
      cellRange.Data = (object) AusgabeText;
      mainAusgabeGrid.Rows[checked (mainAusgabeGrid.Rows.Count - 1)].HeightDisplay = checked (cellRange.Image.Height + 10);
      mainAusgabeGrid.Rows[checked (mainAusgabeGrid.Rows.Count - 1)].AllowMerging = true;
      object obj;
      return obj;
    }

    private object SetFlexAusgabe(
      DataRow ResultRow,
      string DBSpalte,
      bool SetFlag,
      string NameText)
    {
      C1.Win.C1FlexGrid.C1FlexGrid mainAusgabeGrid = this.MainAusgabeGrid;
      string str = "";
      string sLeft1 = "LeftText";
      if (!ResultRow.IsNull(DBSpalte))
        str = StringType.FromObject(ResultRow[DBSpalte]);
      string sLeft2 = DBSpalte;
      if (StringType.StrCmp(sLeft2, "Typ", false) == 0)
      {
        sLeft1 = "CenterText";
        if (!ResultRow.IsNull("Typ") && Information.IsNumeric(RuntimeHelpers.GetObjectValue(ResultRow["Typ"])) && IntegerType.FromObject(ResultRow["Typ"]) > 0)
          str = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[checked (136 + IntegerType.FromObject(ResultRow["Typ"]) - 1)]);
      }
      else if (StringType.StrCmp(sLeft2, "Set", false) == 0)
      {
        if (!ResultRow.IsNull("Set"))
        {
          int num = -1;
          object o1 = LateBinding.LateGet(ResultRow["Set"], (System.Type) null, "toupper", new object[0], (string[]) null, (bool[]) null);
          if (ObjectType.ObjTst(o1, (object) "HOU", false) == 0)
            num = 0;
          else if (ObjectType.ObjTst(o1, (object) "NY", false) == 0)
            num = 1;
          else if (ObjectType.ObjTst(o1, (object) "CHI", false) == 0)
            num = 2;
          else if (ObjectType.ObjTst(o1, (object) "EUR", false) == 0)
            num = 3;
          if (num > -1)
            str = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[checked (122 + num)]);
        }
      }
      else
        sLeft1 = StringType.StrCmp(sLeft2, "Wohlstand", false) != 0 ? (StringType.StrCmp(sLeft2, "Name", false) == 0 || StringType.StrCmp(sLeft2, "yourName", false) == 0 || StringType.StrCmp(sLeft2, "notes", false) == 0 ? "LeftText" : "CenterText") : "CenterText";
      mainAusgabeGrid.Rows.Add();
      mainAusgabeGrid.SetData(checked (mainAusgabeGrid.Rows.Count - 1), this.AusgabeCol, (object) NameText);
      if (SetFlag)
      {
        mainAusgabeGrid.SetData(checked (mainAusgabeGrid.Rows.Count - 1), this.InfoCol, (object) DBSpalte);
        mainAusgabeGrid.SetData(checked (mainAusgabeGrid.Rows.Count - 1), this.IndexCol, RuntimeHelpers.GetObjectValue(ResultRow["ID"]));
      }
      else
      {
        mainAusgabeGrid.SetData(checked (mainAusgabeGrid.Rows.Count - 1), this.InfoCol, (object) "");
        mainAusgabeGrid.SetData(checked (mainAusgabeGrid.Rows.Count - 1), this.IndexCol, (object) "");
      }
      CellRange cellRange;
      if (StringType.StrCmp(sLeft1, "CenterText", false) == 0)
      {
        cellRange = mainAusgabeGrid.GetCellRange(checked (mainAusgabeGrid.Rows.Count - 1), checked (this.AusgabeCol + 1));
        cellRange.Style = mainAusgabeGrid.Styles["CenterText"];
      }
      else
      {
        cellRange = mainAusgabeGrid.GetCellRange(checked (mainAusgabeGrid.Rows.Count - 1), checked (this.AusgabeCol + 1), checked (mainAusgabeGrid.Rows.Count - 1), checked (this.IndexCol - 1));
        cellRange.Style = mainAusgabeGrid.Styles["LeftText"];
        mainAusgabeGrid.Rows[checked (mainAusgabeGrid.Rows.Count - 1)].AllowMerging = true;
      }
      cellRange.Data = (object) Convert.ToString(str);
      object obj;
      return obj;
    }

    private object SetFlexLeerZeile(int InfoSpalte)
    {
      C1.Win.C1FlexGrid.C1FlexGrid mainAusgabeGrid = this.MainAusgabeGrid;
      mainAusgabeGrid.Rows.Add();
      mainAusgabeGrid.SetData(checked (mainAusgabeGrid.Rows.Count - 1), InfoSpalte, (object) "N");
      mainAusgabeGrid.Rows[checked (mainAusgabeGrid.Rows.Count - 1)].HeightDisplay = 5;
      mainAusgabeGrid.GetCellRange(checked (mainAusgabeGrid.Rows.Count - 1), 0, checked (mainAusgabeGrid.Rows.Count - 1), checked (mainAusgabeGrid.Cols.Count - 1)).Style = mainAusgabeGrid.Styles["LeerZeile"];
      object obj;
      return obj;
    }

    private object DisplayDataSet(DataRow ResultRow)
    {
      ArrayList arrayList1 = new ArrayList();
      ArrayList arrayList2 = new ArrayList();
      arrayList1.Add((object) this.ImageList1.Images[26]);
      arrayList1.Add((object) this.ImageList1.Images[29]);
      arrayList1.Add((object) this.ImageList1.Images[17]);
      arrayList1.Add((object) this.ImageList1.Images[16]);
      arrayList1.Add((object) this.ImageList1.Images[25]);
      arrayList1.Add((object) this.ImageList1.Images[27]);
      arrayList2.Add(RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[515]));
      arrayList2.Add(RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[117]));
      arrayList2.Add(RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[447]));
      arrayList2.Add(RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[101]));
      arrayList2.Add(RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[551]));
      arrayList2.Add(RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[364]));
      int num = -1;
      C1.Win.C1FlexGrid.C1FlexGrid mainAusgabeGrid = this.MainAusgabeGrid;
      mainAusgabeGrid.Rows.Count = 0;
      mainAusgabeGrid.Redraw = false;
      int index1 = checked (num + 1);
      this.SetFlexUeberschrift(StringType.FromObject(arrayList2[index1]), (Image) arrayList1[index1]);
      this.SetFlexAusgabe(ResultRow, "Name", true, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[129]));
      this.SetFlexAusgabe(ResultRow, "yourName", true, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[130]));
      int index2 = checked (index1 + 1);
      this.SetFlexUeberschrift(StringType.FromObject(arrayList2[index2]), (Image) arrayList1[index2]);
      mainAusgabeGrid.Rows.Add();
      mainAusgabeGrid.SetData(checked (mainAusgabeGrid.Rows.Count - 1), this.InfoCol, (object) "");
      mainAusgabeGrid.SetData(checked (mainAusgabeGrid.Rows.Count - 1), this.IndexCol, (object) "");
      mainAusgabeGrid.Rows.Add();
      mainAusgabeGrid.SetData(checked (mainAusgabeGrid.Rows.Count - 1), this.InfoCol, (object) "");
      mainAusgabeGrid.SetData(checked (mainAusgabeGrid.Rows.Count - 1), this.IndexCol, (object) "");
      mainAusgabeGrid.SetData(checked (mainAusgabeGrid.Rows.Count - 2), checked (this.AusgabeCol + 1), RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[117]));
      mainAusgabeGrid.SetData(checked (mainAusgabeGrid.Rows.Count - 2), checked (this.AusgabeCol + 2), RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[116]));
      mainAusgabeGrid.SetData(checked (mainAusgabeGrid.Rows.Count - 2), checked (this.AusgabeCol + 3), RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[115]));
      mainAusgabeGrid.GetCellRange(checked (mainAusgabeGrid.Rows.Count - 2), checked (this.AusgabeCol + 1), checked (mainAusgabeGrid.Rows.Count - 2), checked (mainAusgabeGrid.Cols.Count - 1)).Style = mainAusgabeGrid.Styles["CenterBlueText"];
      string str1 = "";
      if (!ResultRow.IsNull("capacity0"))
        str1 = StringType.FromObject(ResultRow["capacity0"]);
      mainAusgabeGrid.SetData(checked (mainAusgabeGrid.Rows.Count - 1), checked (this.AusgabeCol + 1), (object) str1);
      string str2 = "";
      if (!ResultRow.IsNull("capacity1"))
        str2 = StringType.FromObject(ResultRow["capacity1"]);
      mainAusgabeGrid.SetData(checked (mainAusgabeGrid.Rows.Count - 1), checked (this.AusgabeCol + 2), (object) str2);
      string str3 = "";
      if (!ResultRow.IsNull("capacity2"))
        str3 = StringType.FromObject(ResultRow["capacity2"]);
      mainAusgabeGrid.SetData(checked (mainAusgabeGrid.Rows.Count - 1), checked (this.AusgabeCol + 3), (object) str3);
      CellRange cellRange = mainAusgabeGrid.GetCellRange(checked (mainAusgabeGrid.Rows.Count - 1), checked (this.AusgabeCol + 1), checked (mainAusgabeGrid.Rows.Count - 1), checked (mainAusgabeGrid.Cols.Count - 1));
      cellRange.Style = mainAusgabeGrid.Styles["CenterText"];
      int index3 = checked (index2 + 1);
      this.SetFlexUeberschrift(StringType.FromObject(arrayList2[index3]), (Image) arrayList1[index3]);
      this.SetFlexAusgabe(ResultRow, "Typ", false, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[121]));
      this.SetFlexAusgabe(ResultRow, "Set", false, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[118]));
      this.SetFlexAusgabe(ResultRow, "Wohlstand", false, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[120]));
      this.SetFlexAusgabe(ResultRow, "building_value", false, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[114]));
      this.SetFlexAusgabe(ResultRow, "Stage", false, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[119]));
      this.SetFlexAusgabe(ResultRow, "bulldoze_cost", false, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[113]));
      this.SetFlexAusgabe(ResultRow, "Schadenswert", false, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[112]));
      this.SetFlexAusgabe(ResultRow, "flammability", false, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[109]));
      this.SetFlexAusgabe(ResultRow, "max_fire_stage", false, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[108]));
      this.SetFlexAusgabe(ResultRow, "energy_consumed", false, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[111]));
      this.SetFlexAusgabe(ResultRow, "water_consumed", false, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[110]));
      int index4 = checked (index3 + 1);
      this.SetFlexUeberschrift(StringType.FromObject(arrayList2[index4]), (Image) arrayList1[index4]);
      mainAusgabeGrid.Rows.Add();
      mainAusgabeGrid.SetData(checked (mainAusgabeGrid.Rows.Count - 1), this.InfoCol, (object) "");
      mainAusgabeGrid.SetData(checked (mainAusgabeGrid.Rows.Count - 1), this.IndexCol, (object) "");
      mainAusgabeGrid.Rows.Add();
      mainAusgabeGrid.SetData(checked (mainAusgabeGrid.Rows.Count - 1), this.InfoCol, (object) "");
      mainAusgabeGrid.SetData(checked (mainAusgabeGrid.Rows.Count - 1), this.IndexCol, (object) "");
      mainAusgabeGrid.Rows.Add();
      mainAusgabeGrid.SetData(checked (mainAusgabeGrid.Rows.Count - 1), this.InfoCol, (object) "");
      mainAusgabeGrid.SetData(checked (mainAusgabeGrid.Rows.Count - 1), this.IndexCol, (object) "");
      mainAusgabeGrid.SetData(checked (mainAusgabeGrid.Rows.Count - 2), this.AusgabeCol, RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[103]));
      mainAusgabeGrid.SetData(checked (mainAusgabeGrid.Rows.Count - 1), this.AusgabeCol, RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[102]));
      cellRange = mainAusgabeGrid.GetCellRange(checked (mainAusgabeGrid.Rows.Count - 2), this.AusgabeCol, checked (mainAusgabeGrid.Rows.Count - 1), this.AusgabeCol);
      cellRange.Style = mainAusgabeGrid.Styles["LeftText"];
      mainAusgabeGrid.SetData(checked (mainAusgabeGrid.Rows.Count - 3), checked (this.AusgabeCol + 1), RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[107]));
      mainAusgabeGrid.SetData(checked (mainAusgabeGrid.Rows.Count - 3), checked (this.AusgabeCol + 2), RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[106]));
      mainAusgabeGrid.SetData(checked (mainAusgabeGrid.Rows.Count - 3), checked (this.AusgabeCol + 3), RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[105]));
      mainAusgabeGrid.SetData(checked (mainAusgabeGrid.Rows.Count - 3), checked (this.AusgabeCol + 4), RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[104]));
      cellRange = mainAusgabeGrid.GetCellRange(checked (mainAusgabeGrid.Rows.Count - 3), checked (this.AusgabeCol + 1), checked (mainAusgabeGrid.Rows.Count - 3), checked (mainAusgabeGrid.Cols.Count - 1));
      cellRange.Style = mainAusgabeGrid.Styles["CenterBlueText"];
      string str4 = "";
      if (!ResultRow.IsNull("pollution_air"))
        str4 = StringType.FromObject(ResultRow["pollution_air"]);
      mainAusgabeGrid.SetData(checked (mainAusgabeGrid.Rows.Count - 2), checked (this.AusgabeCol + 1), (object) str4);
      string str5 = "";
      if (!ResultRow.IsNull("pollution_water"))
        str5 = StringType.FromObject(ResultRow["pollution_water"]);
      mainAusgabeGrid.SetData(checked (mainAusgabeGrid.Rows.Count - 2), checked (this.AusgabeCol + 2), (object) str5);
      string str6 = "";
      if (!ResultRow.IsNull("pollution_garbage"))
        str6 = StringType.FromObject(ResultRow["pollution_garbage"]);
      mainAusgabeGrid.SetData(checked (mainAusgabeGrid.Rows.Count - 2), checked (this.AusgabeCol + 3), (object) str6);
      string str7 = "";
      if (!ResultRow.IsNull("pollution_radiation"))
        str7 = StringType.FromObject(ResultRow["pollution_radiation"]);
      mainAusgabeGrid.SetData(checked (mainAusgabeGrid.Rows.Count - 2), checked (this.AusgabeCol + 4), (object) str7);
      string str8 = "";
      if (!ResultRow.IsNull("pollution_air_radius"))
        str8 = StringType.FromObject(ResultRow["pollution_air_radius"]);
      mainAusgabeGrid.SetData(checked (mainAusgabeGrid.Rows.Count - 1), checked (this.AusgabeCol + 1), (object) str8);
      string str9 = "";
      if (!ResultRow.IsNull("pollution_water_radius"))
        str9 = StringType.FromObject(ResultRow["pollution_water_radius"]);
      mainAusgabeGrid.SetData(checked (mainAusgabeGrid.Rows.Count - 1), checked (this.AusgabeCol + 2), (object) str9);
      string str10 = "";
      if (!ResultRow.IsNull("pollution_garbage_radius"))
        str10 = StringType.FromObject(ResultRow["pollution_garbage_radius"]);
      mainAusgabeGrid.SetData(checked (mainAusgabeGrid.Rows.Count - 1), checked (this.AusgabeCol + 3), (object) str10);
      string str11 = "";
      if (!ResultRow.IsNull("pollution_radiation_radius"))
        str11 = StringType.FromObject(ResultRow["pollution_radiation_radius"]);
      mainAusgabeGrid.SetData(checked (mainAusgabeGrid.Rows.Count - 1), checked (this.AusgabeCol + 4), (object) str11);
      int index5 = checked (index4 + 1);
      this.SetFlexUeberschrift(StringType.FromObject(arrayList2[index5]), (Image) arrayList1[index5]);
      mainAusgabeGrid.Rows.Add();
      mainAusgabeGrid.SetData(checked (mainAusgabeGrid.Rows.Count - 1), this.InfoCol, (object) "notes");
      mainAusgabeGrid.SetData(checked (mainAusgabeGrid.Rows.Count - 1), this.IndexCol, RuntimeHelpers.GetObjectValue(ResultRow["ID"]));
      string str12 = "";
      if (!ResultRow.IsNull("notes"))
        str12 = StringType.FromObject(ResultRow["notes"]);
      cellRange = mainAusgabeGrid.GetCellRange(checked (mainAusgabeGrid.Rows.Count - 1), this.AusgabeCol, checked (mainAusgabeGrid.Rows.Count - 1), checked (this.IndexCol - 1));
      cellRange.Style = mainAusgabeGrid.Styles["EmptyText"];
      mainAusgabeGrid.Rows[checked (mainAusgabeGrid.Rows.Count - 1)].AllowMerging = true;
      mainAusgabeGrid.Rows[checked (mainAusgabeGrid.Rows.Count - 1)].HeightDisplay = checked (mainAusgabeGrid.Rows[0].Height * 2);
      cellRange.Data = (object) Convert.ToString(str12);
      int index6 = checked (index5 + 1);
      this.SetFlexUeberschrift(StringType.FromObject(arrayList2[index6]), (Image) arrayList1[index6]);
      if (!ResultRow.IsNull("ImagePath"))
      {
        string ImageFileName = StringType.FromObject(ResultRow["ImagePath"]);
        Image imageFromPath = this.GetImageFromPath(ref ImageFileName);
        if (!Information.IsNothing((object) imageFromPath))
        {
          mainAusgabeGrid.Rows.Add();
          mainAusgabeGrid.SetData(checked (mainAusgabeGrid.Rows.Count - 1), this.InfoCol, (object) "ImagePath");
          mainAusgabeGrid.SetData(checked (mainAusgabeGrid.Rows.Count - 1), this.IndexCol, RuntimeHelpers.GetObjectValue(ResultRow["ID"]));
          this.ShowImage((object) imageFromPath, (object) ImageFileName);
        }
      }
      mainAusgabeGrid.Redraw = true;
      if (mainAusgabeGrid.Rows.Count > 0)
        this.ButtonSave.Enabled = true;
      object obj;
      return obj;
    }

    private Image GetImageFromPath(ref string ImageFileName)
    {
      Image image1 = (Image) null;
      Image image2;
      try
      {
        FileInfo fileInfo1 = new FileInfo(ImageFileName);
        if (!fileInfo1.Exists)
        {
          FileInfo fileInfo2 = new FileInfo(ClassThisProg.DefReader.ImageDir + "\\" + ImageFileName);
          if (fileInfo2.Exists)
          {
            ImageFileName = fileInfo2.Name;
            image1 = Image.FromFile(fileInfo2.FullName);
          }
        }
        else
        {
          ImageFileName = StringType.StrCmp(fileInfo1.DirectoryName, ClassThisProg.DefReader.ImageDir, false) != 0 ? fileInfo1.FullName : fileInfo1.Name;
          image1 = Image.FromFile(fileInfo1.FullName);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        image2 = (Image) null;
        ProjectData.ClearProjectError();
        goto label_7;
      }
      image2 = image1;
label_7:
      return image2;
    }

    private void MainAusgabeGrid_Click(object sender, EventArgs e)
    {
      C1.Win.C1FlexGrid.C1FlexGrid mainAusgabeGrid = this.MainAusgabeGrid;
      if (mainAusgabeGrid.Selection.r1 == checked (mainAusgabeGrid.Rows.Count - 1) && mainAusgabeGrid.Selection.c1 == checked (this.AusgabeCol + 1))
      {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Multiselect = false;
        openFileDialog.RestoreDirectory = true;
        openFileDialog.Title = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[144]);
        openFileDialog.ShowReadOnly = true;
        openFileDialog.CheckFileExists = true;
        openFileDialog.Filter = "Images (*.jpg;*.bmp;*.png)|*.jpg;*.bmp;*.png|All (*.*)|*.*";
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
          string fileName = openFileDialog.FileName;
          Image imageFromPath = this.GetImageFromPath(ref fileName);
          if (!Information.IsNothing((object) imageFromPath))
          {
            this.ShowImage((object) imageFromPath, (object) fileName);
          }
          else
          {
            int num = (int) MessageBox.Show((IWin32Window) this, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[146]), "Images", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          }
        }
      }
    }

    private object ShowImage(object AusgabeImage, object AusgabeText)
    {
      C1.Win.C1FlexGrid.C1FlexGrid mainAusgabeGrid = this.MainAusgabeGrid;
      if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(AusgabeImage)))
      {
        CellRange cellRange = mainAusgabeGrid.GetCellRange(checked (mainAusgabeGrid.Rows.Count - 1), this.AusgabeCol);
        cellRange.Image = (Image) AusgabeImage;
        cellRange.Style = mainAusgabeGrid.Styles["MainImage"];
        if (checked (cellRange.Image.Width + 10) > mainAusgabeGrid.Cols[this.InfoCol].Width)
          mainAusgabeGrid.Cols[this.AusgabeCol].Width = checked (cellRange.Image.Width + 10);
        else
          mainAusgabeGrid.Cols[this.AusgabeCol].Width = mainAusgabeGrid.Cols[this.InfoCol].Width;
        mainAusgabeGrid.Rows[checked (mainAusgabeGrid.Rows.Count - 1)].HeightDisplay = checked (cellRange.Image.Height + 10);
        cellRange = mainAusgabeGrid.GetCellRange(checked (mainAusgabeGrid.Rows.Count - 1), checked (this.AusgabeCol + 1), checked (mainAusgabeGrid.Rows.Count - 1), checked (this.IndexCol - 1));
        cellRange.Style = mainAusgabeGrid.Styles["LeftTopText"];
        cellRange.Data = (object) Convert.ToString(RuntimeHelpers.GetObjectValue(AusgabeText));
        cellRange.Image = this.ImageList1.Images[0];
        mainAusgabeGrid.Rows[checked (mainAusgabeGrid.Rows.Count - 1)].AllowMerging = true;
      }
      else
        mainAusgabeGrid.Cols[this.AusgabeCol].Width = mainAusgabeGrid.Cols[this.InfoCol].Width;
      object obj;
      return obj;
    }

    private object GetDisplayDataSet(string SuchID)
    {
      string str = StringType.StrCmp(ClassThisProg.DefReader.SortierKriterium, "A", false) != 0 ? "yourName" : "Name";
      string filterExpression = "ID = " + SuchID;
      DataRow[] dataRowArray = ClassThisProg.DefReader.DB_xmldoc.DataSet.Tables["Buildings"].Select(filterExpression, str);
      if (dataRowArray.GetUpperBound(0) > -1)
      {
        this.HeaderControl2.Text = StringType.FromObject(dataRowArray[0][str]);
        this.DisplayDataSet(dataRowArray[0]);
      }
      object obj;
      return obj;
    }

    private void MainAusgabeGrid_BeforeEdit(object sender, RowColEventArgs e)
    {
      C1.Win.C1FlexGrid.C1FlexGrid mainAusgabeGrid = this.MainAusgabeGrid;
      if (e.Col == this.AusgabeCol)
      {
        if (Information.IsNothing(RuntimeHelpers.GetObjectValue(mainAusgabeGrid.GetData(e.Row, this.InfoCol))))
          e.Cancel = true;
        if (StringType.StrCmp(mainAusgabeGrid.GetData(e.Row, this.InfoCol).GetType().FullName, "System.String", false) != 0)
          e.Cancel = true;
        if (StringType.StrCmp(mainAusgabeGrid.GetData(e.Row, this.InfoCol).ToString().ToUpper(), "NOTES", false) == 0)
          return;
        e.Cancel = true;
      }
      else
      {
        if (e.Col != checked (this.AusgabeCol + 1))
          e.Cancel = true;
        if (Information.IsNothing(RuntimeHelpers.GetObjectValue(mainAusgabeGrid.GetData(e.Row, this.InfoCol))))
          e.Cancel = true;
        if (StringType.StrCmp(mainAusgabeGrid.GetData(e.Row, this.InfoCol).ToString(), "", false) == 0)
          e.Cancel = true;
        if (Information.IsNothing(RuntimeHelpers.GetObjectValue(mainAusgabeGrid.GetData(e.Row, this.IndexCol))))
          e.Cancel = true;
        if (StringType.StrCmp(mainAusgabeGrid.GetData(e.Row, this.IndexCol).ToString(), "", false) == 0)
          e.Cancel = true;
        if (StringType.StrCmp(mainAusgabeGrid.GetData(e.Row, this.InfoCol).ToString().ToUpper(), "IMAGEPATH", false) == 0)
          e.Cancel = true;
      }
    }

    private void FormDB_Closed(object sender, EventArgs e) => ClassThisProg.frmForm1 = (FormDB) null;

    private void IndustrieButtonEnd_Activate(object sender, EventArgs e) => this.Dispose();

    private void GewerbeButtonEnd_Activate(object sender, EventArgs e) => this.Dispose();

    private void WohnenButtonEnd_Activate(object sender, EventArgs e) => this.Dispose();

    private void ButtonSave_Activate(object sender, EventArgs e)
    {
      string str1 = "";
      string sLeft1 = "";
      string sLeft2 = "";
      string str2 = "";
      string sLeft3 = "";
      C1.Win.C1FlexGrid.C1FlexGrid mainAusgabeGrid = this.MainAusgabeGrid;
      if (mainAusgabeGrid.Rows.Count == 0)
        return;
      int num = checked (mainAusgabeGrid.Rows.Count - 1);
      int row = 0;
      while (row <= num)
      {
        if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(mainAusgabeGrid.GetData(row, this.IndexCol))))
        {
          sLeft3 = StringType.FromObject(mainAusgabeGrid.GetData(row, this.IndexCol));
          if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(mainAusgabeGrid.GetData(row, this.InfoCol))))
          {
            string upper = mainAusgabeGrid.GetData(row, this.InfoCol).ToString().ToUpper();
            if (StringType.StrCmp(upper, "NAME", false) == 0)
            {
              if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(mainAusgabeGrid.GetData(row, checked (this.AusgabeCol + 1)))))
                sLeft1 = StringType.FromObject(mainAusgabeGrid.GetData(row, checked (this.AusgabeCol + 1)));
            }
            else if (StringType.StrCmp(upper, "YOURNAME", false) == 0)
            {
              if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(mainAusgabeGrid.GetData(row, checked (this.AusgabeCol + 1)))))
                sLeft2 = StringType.FromObject(mainAusgabeGrid.GetData(row, checked (this.AusgabeCol + 1)));
            }
            else if (StringType.StrCmp(upper, "NOTES", false) == 0)
            {
              if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(mainAusgabeGrid.GetData(row, this.AusgabeCol))))
                str2 = StringType.FromObject(mainAusgabeGrid.GetData(row, this.AusgabeCol));
            }
            else if (StringType.StrCmp(upper, "IMAGEPATH", false) == 0 && !Information.IsNothing(RuntimeHelpers.GetObjectValue(mainAusgabeGrid.GetData(row, checked (this.AusgabeCol + 1)))))
              str1 = StringType.FromObject(mainAusgabeGrid.GetData(row, checked (this.AusgabeCol + 1)));
          }
        }
        checked { ++row; }
      }
      if (StringType.StrCmp(sLeft3, "", false) == 0 || StringType.StrCmp(sLeft1, "", false) == 0)
        return;
      if (StringType.StrCmp(sLeft2, "", false) == 0)
        return;
      try
      {
        if (StringType.StrCmp(sLeft3, "", false) != 0)
        {
          string filterExpression = "ID = " + sLeft3;
          DataRow[] dataRowArray = ClassThisProg.DefReader.DB_xmldoc.DataSet.Tables["Buildings"].Select(filterExpression);
          if (dataRowArray.GetUpperBound(0) > -1)
          {
            dataRowArray[0]["Name"] = (object) sLeft1;
            dataRowArray[0]["yourName"] = (object) sLeft2;
            dataRowArray[0]["ImagePath"] = (object) str1;
            dataRowArray[0]["notes"] = (object) str2;
            ClassThisProg.DefReader.DB_xmldoc.DataSet.Tables["Buildings"].AcceptChanges();
            ClassThisProg.DefReader.DB_xmldoc.Save(ClassThisProg.DefReader.DBXMLDatei);
          }
          string str3 = StringType.StrCmp(ClassThisProg.DefReader.SortierKriterium, "A", false) != 0 ? sLeft2 : sLeft1;
          if (!Information.IsNothing((object) this.AktuellerTreeView))
          {
            if (this.AktuellerTreeView.SelectedNode.Tag.ToString().Split('#').GetUpperBound(0) == 2)
            {
              this.AktuellerTreeView.SelectedNode.Tag = (object) (sLeft3 + "#" + sLeft1 + "#" + sLeft2);
              this.AktuellerTreeView.SelectedNode.Text = str3;
            }
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void NavigationBar1_SelectedPaneChanged(object sender, EventArgs e)
    {
      if (StringType.StrCmp(this.NavigationBar1.SelectedPane.Name.ToUpper(), "BATPANE", false) == 0)
      {
        this.ShowGrid.Visible = true;
        this.MainAusgabeGrid.Visible = false;
        this.AusgabeFlexGrid.Visible = true;
        this.ButtonSave.Enabled = false;
        this.HeaderControl2.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[479]);
        if (this.AusgabeFlexGrid.Rows.Count != this.AusgabeFlexGrid.Rows.Fixed)
          return;
        this.FillFlexGrid();
      }
      else
      {
        this.MainAusgabeGrid.Visible = true;
        this.AusgabeFlexGrid.Visible = false;
      }
    }

    private void NavigationBar1_Resize(object sender, EventArgs e)
    {
      if (this.ShowGrid.Cols.Count <= 0)
        return;
      this.ShowGrid.Cols[1].Width = this.NavigationBar1.Width;
    }

    private void ButtonHTML_Activate(object sender, EventArgs e)
    {
      if (this.MainAusgabeGrid.Visible)
      {
        if (this.MainAusgabeGrid.Rows.Count <= this.MainAusgabeGrid.Rows.Fixed)
          return;
        MainFunctionClass.SaveToHTML((Form) this, this.MainAusgabeGrid);
      }
      else if (this.AusgabeFlexGrid.Rows.Count > this.AusgabeFlexGrid.Rows.Fixed)
        MainFunctionClass.SaveToHTML((Form) this, this.AusgabeFlexGrid);
    }

    private void BATButtonEnd_Activate(object sender, EventArgs e) => this.Dispose();
  }
}
