// Decompiled with JetBrains decompiler
// Type: SC4Tool.FormBAT
// Assembly: SC4Tool, Version=2.2.7.0, Culture=neutral, PublicKeyToken=null
// MVID: 69A50BC4-87A5-4C5E-BEFC-08274BC6D498
// Assembly location: C:\Program Files (x86)\SC4 Utilities\SC4Tool\SC4Tool.exe

using C1.Win.C1FlexGrid;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using SourceLibrary.Utility;
using sr_SC4Lib;
using sr_SourceGrid;
using sr_SourceGrid.BehaviorModels;
using sr_SourceGrid.Cells;
using sr_SourceGrid.Cells.Real;
using sr_SourceGrid.DataModels;
using sr_SourceGrid.VisualModels;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using TD.Eyefinder;
using TD.SandBar;
using TD.SandDock;

namespace SC4Tool
{
  public class FormBAT : Form
  {
    [AccessedThroughProperty("SC4_ToolBar1")]
    private TD.SandBar.ToolBar _SC4_ToolBar1;
    [AccessedThroughProperty("ImageDropDownMenu1")]
    private DropDownMenuItem _ImageDropDownMenu1;
    [AccessedThroughProperty("LotToolBar")]
    private TD.SandBar.ToolBar _LotToolBar;
    [AccessedThroughProperty("SC4_AusgabePanel")]
    private Panel _SC4_AusgabePanel;
    [AccessedThroughProperty("ToolButton4")]
    private ButtonItem _ToolButton4;
    [AccessedThroughProperty("Sr_TextureViewer1")]
    private sr_TextureViewer _Sr_TextureViewer1;
    [AccessedThroughProperty("AusgabeGrid")]
    private C1.Win.C1FlexGrid.C1FlexGrid _AusgabeGrid;
    [AccessedThroughProperty("SC4_BemBox1")]
    private TextBox _SC4_BemBox1;
    [AccessedThroughProperty("ImageToolButton2")]
    private ButtonItem _ImageToolButton2;
    [AccessedThroughProperty("dockTextures")]
    private DockControl _dockTextures;
    [AccessedThroughProperty("InfoToolBar")]
    private TD.SandBar.ToolBar _InfoToolBar;
    [AccessedThroughProperty("ImagesToolBar")]
    private TD.SandBar.ToolBar _ImagesToolBar;
    [AccessedThroughProperty("dockProp")]
    private DockControl _dockProp;
    [AccessedThroughProperty("StatusBarPanel2")]
    private StatusBarPanel _StatusBarPanel2;
    [AccessedThroughProperty("dockDep")]
    private DockControl _dockDep;
    [AccessedThroughProperty("Splitter1")]
    private Splitter _Splitter1;
    [AccessedThroughProperty("DBTreeView")]
    private TreeView _DBTreeView;
    [AccessedThroughProperty("StatusBarPanel1")]
    private StatusBarPanel _StatusBarPanel1;
    [AccessedThroughProperty("dockLot")]
    private DockControl _dockLot;
    [AccessedThroughProperty("Panel1")]
    private Panel _Panel1;
    [AccessedThroughProperty("dockBuilding")]
    private DockControl _dockBuilding;
    [AccessedThroughProperty("StatusBar1")]
    private StatusBar _StatusBar1;
    [AccessedThroughProperty("ImageList1")]
    private ImageList _ImageList1;
    [AccessedThroughProperty("SC4_ToolButton2")]
    private ButtonItem _SC4_ToolButton2;
    [AccessedThroughProperty("SC4_ToolButton1")]
    private ButtonItem _SC4_ToolButton1;
    [AccessedThroughProperty("ToolButton1")]
    private ButtonItem _ToolButton1;
    [AccessedThroughProperty("ToolButton2")]
    private ButtonItem _ToolButton2;
    [AccessedThroughProperty("StatusBarPanel3")]
    private StatusBarPanel _StatusBarPanel3;
    [AccessedThroughProperty("ImageMenuItem1")]
    private MenuButtonItem _ImageMenuItem1;
    [AccessedThroughProperty("dock2")]
    private DockControl _dock2;
    [AccessedThroughProperty("InfoGrid")]
    private Grid _InfoGrid;
    [AccessedThroughProperty("ImageMenuItem2")]
    private MenuButtonItem _ImageMenuItem2;
    [AccessedThroughProperty("ToolButton3")]
    private ButtonItem _ToolButton3;
    [AccessedThroughProperty("doc")]
    private DocumentContainer _doc;
    [AccessedThroughProperty("SandDockManager1")]
    private SandDockManager _SandDockManager1;
    [AccessedThroughProperty("InfoToolButton1")]
    private ButtonItem _InfoToolButton1;
    [AccessedThroughProperty("ImageMenuItem3")]
    private MenuButtonItem _ImageMenuItem3;
    [AccessedThroughProperty("HeaderControl2")]
    private HeaderControl _HeaderControl2;
    [AccessedThroughProperty("AutorDropDownMenu")]
    private DropDownMenuItem _AutorDropDownMenu;
    [AccessedThroughProperty("ImageMenuItem4")]
    private MenuButtonItem _ImageMenuItem4;
    [AccessedThroughProperty("TeamDropDownMenu")]
    private DropDownMenuItem _TeamDropDownMenu;
    [AccessedThroughProperty("ImageMenuItem5")]
    private MenuButtonItem _ImageMenuItem5;
    [AccessedThroughProperty("InfoToolButton2")]
    private ButtonItem _InfoToolButton2;
    [AccessedThroughProperty("ImageMenuItem6")]
    private MenuButtonItem _ImageMenuItem6;
    [AccessedThroughProperty("ButtonItem1")]
    private ButtonItem _ButtonItem1;
    [AccessedThroughProperty("ToolBar1")]
    private TD.SandBar.ToolBar _ToolBar1;
    [AccessedThroughProperty("InfoToolButton3")]
    private ButtonItem _InfoToolButton3;
    [AccessedThroughProperty("TreeView1")]
    private TreeView _TreeView1;
    [AccessedThroughProperty("InfoToolButton4")]
    private ButtonItem _InfoToolButton4;
    [AccessedThroughProperty("TreePanel")]
    private Panel _TreePanel;
    [AccessedThroughProperty("InfoToolButton5")]
    private ButtonItem _InfoToolButton5;
    [AccessedThroughProperty("LotAusgabePanel")]
    private Panel _LotAusgabePanel;
    [AccessedThroughProperty("Sr_DepGrid1")]
    private sr_DepGrid _Sr_DepGrid1;
    [AccessedThroughProperty("SC4_ToolButton3")]
    private ButtonItem _SC4_ToolButton3;
    [AccessedThroughProperty("ButtonSearchBuilding")]
    private ButtonItem _ButtonSearchBuilding;
    [AccessedThroughProperty("Panel2")]
    private Panel _Panel2;
    [AccessedThroughProperty("PropGrid")]
    private C1.Win.C1FlexGrid.C1FlexGrid _PropGrid;
    [AccessedThroughProperty("LotGrid")]
    private C1.Win.C1FlexGrid.C1FlexGrid _LotGrid;
    [AccessedThroughProperty("dock3")]
    private DockControl _dock3;
    private string AktuelleLeseDatei;
    private int AktuellerDBIndex;
    private SC4FileStorer ExemplarListe;
    private ArrayList DBBildDateiListe;
    private string DBAutor;
    private string DBTeam;
    private string DBNotes;
    private int TeamZeile;
    private int TeamSpalte;
    private int AutorZeile;
    private int AutorSpalte;
    private cTexture SchreibPicture;
    private int AktuellerBuildingIndex;
    private int AktuellerLotIndex;
    private TextureReader TextureListe;
    private sr_SourceGrid.VisualModels.Common l_TitleModel;
    private sr_SourceGrid.VisualModels.Common l_CaptionModel;
    private sr_SourceGrid.VisualModels.Common m_VisualModel1;
    private sr_SourceGrid.VisualModels.Common ellipsesModel;
    private bool isLoading;
    private IContainer components;

    public FormBAT()
    {
      this.Closed += new EventHandler(this.FormBAT_Closed);
      this.Load += new EventHandler(this.FormBAT_Load);
      this.DBBildDateiListe = new ArrayList();
      this.AktuellerBuildingIndex = -1;
      this.AktuellerLotIndex = -1;
      this.l_TitleModel = new sr_SourceGrid.VisualModels.Common(false);
      this.l_CaptionModel = new sr_SourceGrid.VisualModels.Common(false);
      this.m_VisualModel1 = new sr_SourceGrid.VisualModels.Common();
      this.ellipsesModel = new sr_SourceGrid.VisualModels.Common();
      this.isLoading = true;
      this.InitializeComponent();
      if (!ClassThisProg.DefReader.HasReadDeps && ClassThisProg.frmProgress == null)
      {
        ClassThisProg.frmProgress = new FormProgress("D");
        ClassThisProg.frmProgress.MdiParent = (Form) ClassThisProg.frmMain;
        int num = (int) ClassThisProg.frmProgress.ShowDialog();
      }
      this.isLoading = true;
      C1.Win.C1FlexGrid.C1FlexGrid propGrid = this.PropGrid;
      propGrid.AllowDragging = AllowDraggingEnum.None;
      propGrid.AllowSorting = AllowSortingEnum.None;
      propGrid.AllowMerging = AllowMergingEnum.Free;
      propGrid.AllowEditing = false;
      propGrid.AllowResizing = AllowResizingEnum.Columns;
      propGrid.SelectionMode = SelectionModeEnum.Cell;
      propGrid.Styles.Add("ShowBoolean");
      propGrid.Styles["ShowBoolean"].DataType = System.Type.GetType("System.Boolean");
      propGrid.Styles["ShowBoolean"].ImageAlign = ImageAlignEnum.CenterCenter;
      propGrid.Styles.Add("LeftText");
      propGrid.Styles["LeftText"].TextAlign = TextAlignEnum.LeftCenter;
      propGrid.Styles.Add("BoldText");
      propGrid.Styles["BoldText"].TextAlign = TextAlignEnum.LeftCenter;
      propGrid.Styles["BoldText"].Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      propGrid.Styles.Add("RightImage");
      propGrid.Styles["RightImage"].ImageAlign = ImageAlignEnum.RightCenter;
      propGrid.Styles.Add("CenterImage");
      propGrid.Styles["CenterImage"].ImageAlign = ImageAlignEnum.CenterCenter;
      propGrid.Styles.Add("LeftImage");
      propGrid.Styles["LeftImage"].ImageAlign = ImageAlignEnum.LeftCenter;
      propGrid.Styles["LeftImage"].TextAlign = TextAlignEnum.LeftCenter;
      propGrid.Styles["LeftImage"].Font = new Font("Arial", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      propGrid.Styles["LeftImage"].BackColor = Color.SteelBlue;
      propGrid.Styles["LeftImage"].ForeColor = Color.White;
      propGrid.Styles.Add("LeftImage_1");
      propGrid.Styles["LeftImage_1"].ImageAlign = ImageAlignEnum.LeftCenter;
      propGrid.Styles["LeftImage_1"].TextAlign = TextAlignEnum.LeftCenter;
      propGrid.Styles.Add("TopText");
      propGrid.Styles["TopText"].TextAlign = TextAlignEnum.CenterCenter;
      propGrid.Styles["TopText"].BackColor = Color.SteelBlue;
      propGrid.Styles["TopText"].ForeColor = Color.White;
      propGrid.HighLight = HighLightEnum.WithFocus;
      propGrid.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
      propGrid.ScrollBars = ScrollBars.Both;
      propGrid.Styles.Fixed.BackColor = Color.SteelBlue;
      propGrid.Styles.Fixed.ForeColor = Color.White;
      propGrid.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter;
      propGrid.Styles.Fixed.TextEffect = TextEffectEnum.Flat;
      propGrid.Styles.Fixed.Border.Color = Color.White;
      propGrid.Styles.Fixed.Font = this.Font;
      propGrid.Styles.Frozen.Font = this.Font;
      propGrid.Styles.Normal.Font = this.Font;
      propGrid.Styles.Normal.TextAlign = TextAlignEnum.CenterCenter;
      propGrid.Styles.Alternate.BackColor = propGrid.Styles.Frozen.BackColor;
      propGrid.Rows.Fixed = 1;
      propGrid.Rows.Count = propGrid.Rows.Fixed;
      propGrid.Cols.Count = 6;
      propGrid.Cols.Fixed = 0;
      propGrid.Cols.Frozen = 0;
      propGrid.Cols.MaxSize = 0;
      propGrid.Cols.MinSize = 0;
      propGrid.Cols[0].Width = 100;
      propGrid.Cols[1].Width = 250;
      propGrid.Cols[2].Width = 180;
      propGrid.Cols[3].Width = 180;
      propGrid.Cols[4].Width = 180;
      propGrid.Cols[5].Width = 180;
      C1.Win.C1FlexGrid.C1FlexGrid lotGrid = this.LotGrid;
      lotGrid.AllowDragging = AllowDraggingEnum.None;
      lotGrid.AllowSorting = AllowSortingEnum.None;
      lotGrid.AllowMerging = AllowMergingEnum.Free;
      lotGrid.AllowEditing = false;
      lotGrid.AllowResizing = AllowResizingEnum.Columns;
      lotGrid.SelectionMode = SelectionModeEnum.Cell;
      lotGrid.Styles.Add("ShowBoolean");
      lotGrid.Styles["ShowBoolean"].DataType = System.Type.GetType("System.Boolean");
      lotGrid.Styles["ShowBoolean"].ImageAlign = ImageAlignEnum.CenterCenter;
      lotGrid.Styles.Add("LeftText");
      lotGrid.Styles["LeftText"].TextAlign = TextAlignEnum.LeftCenter;
      lotGrid.Styles.Add("BoldText");
      lotGrid.Styles["BoldText"].TextAlign = TextAlignEnum.LeftCenter;
      lotGrid.Styles["BoldText"].Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      lotGrid.Styles.Add("RightImage");
      lotGrid.Styles["RightImage"].ImageAlign = ImageAlignEnum.RightCenter;
      lotGrid.Styles.Add("CenterImage");
      lotGrid.Styles["CenterImage"].ImageAlign = ImageAlignEnum.CenterCenter;
      lotGrid.Styles.Add("LeftImage");
      lotGrid.Styles["LeftImage"].ImageAlign = ImageAlignEnum.LeftCenter;
      lotGrid.Styles["LeftImage"].TextAlign = TextAlignEnum.LeftCenter;
      lotGrid.Styles["LeftImage"].Font = new Font("Arial", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      lotGrid.Styles["LeftImage"].BackColor = Color.SteelBlue;
      lotGrid.Styles["LeftImage"].ForeColor = Color.White;
      lotGrid.Styles.Add("LeftImage_1");
      lotGrid.Styles["LeftImage_1"].ImageAlign = ImageAlignEnum.LeftCenter;
      lotGrid.Styles["LeftImage_1"].TextAlign = TextAlignEnum.LeftCenter;
      lotGrid.Styles.Add("TopText");
      lotGrid.Styles["TopText"].TextAlign = TextAlignEnum.CenterCenter;
      lotGrid.Styles["TopText"].BackColor = Color.SteelBlue;
      lotGrid.Styles["TopText"].ForeColor = Color.White;
      lotGrid.HighLight = HighLightEnum.WithFocus;
      lotGrid.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
      lotGrid.ScrollBars = ScrollBars.Both;
      lotGrid.Styles.Fixed.BackColor = Color.SteelBlue;
      lotGrid.Styles.Fixed.ForeColor = Color.White;
      lotGrid.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter;
      lotGrid.Styles.Fixed.TextEffect = TextEffectEnum.Flat;
      lotGrid.Styles.Fixed.Border.Color = Color.White;
      lotGrid.Styles.Fixed.Font = this.Font;
      lotGrid.Styles.Frozen.Font = this.Font;
      lotGrid.Styles.Normal.Font = this.Font;
      lotGrid.Styles.Normal.TextAlign = TextAlignEnum.CenterCenter;
      lotGrid.Styles.Alternate.BackColor = lotGrid.Styles.Frozen.BackColor;
      lotGrid.Rows.Fixed = 1;
      lotGrid.Rows.Count = lotGrid.Rows.Fixed;
      lotGrid.Cols.Count = 5;
      lotGrid.Cols.Fixed = 0;
      lotGrid.Cols.Frozen = 0;
      lotGrid.Cols.MaxSize = 0;
      lotGrid.Cols.MinSize = 0;
      lotGrid.Cols[0].Width = 250;
      lotGrid.Cols[1].Width = 180;
      lotGrid.Cols[2].Width = 180;
      lotGrid.Cols[3].Width = 180;
      lotGrid.Cols[4].Width = 180;
      C1.Win.C1FlexGrid.C1FlexGrid ausgabeGrid = this.AusgabeGrid;
      ausgabeGrid.AllowDragging = AllowDraggingEnum.None;
      ausgabeGrid.AllowSorting = AllowSortingEnum.None;
      ausgabeGrid.AllowMerging = AllowMergingEnum.Free;
      ausgabeGrid.AllowEditing = false;
      ausgabeGrid.AllowResizing = AllowResizingEnum.Columns;
      ausgabeGrid.Styles.Add("ShowBoolean");
      ausgabeGrid.Styles["ShowBoolean"].DataType = System.Type.GetType("System.Boolean");
      ausgabeGrid.Styles["ShowBoolean"].ImageAlign = ImageAlignEnum.CenterCenter;
      ausgabeGrid.Styles.Add("LeftText");
      ausgabeGrid.Styles["LeftText"].TextAlign = TextAlignEnum.LeftCenter;
      ausgabeGrid.Styles.Add("BoldText");
      ausgabeGrid.Styles["BoldText"].TextAlign = TextAlignEnum.LeftCenter;
      ausgabeGrid.Styles["BoldText"].Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ausgabeGrid.Styles.Add("RightImage");
      ausgabeGrid.Styles["RightImage"].ImageAlign = ImageAlignEnum.RightCenter;
      ausgabeGrid.Styles.Add("CenterImage");
      ausgabeGrid.Styles["CenterImage"].ImageAlign = ImageAlignEnum.CenterCenter;
      ausgabeGrid.Styles.Add("LeftImage");
      ausgabeGrid.Styles["LeftImage"].ImageAlign = ImageAlignEnum.LeftCenter;
      ausgabeGrid.Styles["LeftImage"].TextAlign = TextAlignEnum.LeftCenter;
      ausgabeGrid.Styles["LeftImage"].Font = new Font("Arial", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ausgabeGrid.Styles["LeftImage"].BackColor = Color.SteelBlue;
      ausgabeGrid.Styles["LeftImage"].ForeColor = Color.White;
      ausgabeGrid.Styles.Add("LeftImage_1");
      ausgabeGrid.Styles["LeftImage_1"].ImageAlign = ImageAlignEnum.LeftCenter;
      ausgabeGrid.Styles["LeftImage_1"].TextAlign = TextAlignEnum.LeftCenter;
      ausgabeGrid.Styles.Add("TopText");
      ausgabeGrid.Styles["TopText"].TextAlign = TextAlignEnum.CenterCenter;
      ausgabeGrid.Styles["TopText"].BackColor = Color.SteelBlue;
      ausgabeGrid.Styles["TopText"].ForeColor = Color.White;
      ausgabeGrid.HighLight = HighLightEnum.WithFocus;
      ausgabeGrid.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
      ausgabeGrid.ScrollBars = ScrollBars.Both;
      ausgabeGrid.Styles.Fixed.BackColor = Color.SteelBlue;
      ausgabeGrid.Styles.Fixed.ForeColor = Color.White;
      ausgabeGrid.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter;
      ausgabeGrid.Styles.Fixed.TextEffect = TextEffectEnum.Flat;
      ausgabeGrid.Styles.Fixed.Border.Color = Color.White;
      ausgabeGrid.Styles.Fixed.Font = this.Font;
      ausgabeGrid.Styles.Frozen.Font = this.Font;
      ausgabeGrid.Styles.Normal.Font = this.Font;
      ausgabeGrid.Styles.Normal.TextAlign = TextAlignEnum.CenterCenter;
      ausgabeGrid.Styles.Alternate.BackColor = ausgabeGrid.Styles.Frozen.BackColor;
      ausgabeGrid.Rows.Fixed = 1;
      ausgabeGrid.Rows.Count = 0;
      ausgabeGrid.Cols.Count = 7;
      ausgabeGrid.Cols.Fixed = 0;
      ausgabeGrid.Cols.Frozen = 0;
      ausgabeGrid.Cols.MaxSize = 0;
      ausgabeGrid.Cols.MinSize = 0;
      ausgabeGrid.Cols[0].Width = 250;
      ausgabeGrid.Cols[1].Width = 120;
      ausgabeGrid.Cols[2].Width = 120;
      ausgabeGrid.Cols[3].Width = 120;
      ausgabeGrid.Cols[4].Width = 120;
      ausgabeGrid.Cols[5].Width = 120;
      ausgabeGrid.Cols[6].Width = 120;
      ausgabeGrid.SelectionMode = SelectionModeEnum.Cell;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
      ClassThisProg.frmBAT = (FormBAT) null;
    }

    public virtual SandDockManager SandDockManager1
    {
      get => this._SandDockManager1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._SandDockManager1 == null)
          ;
        this._SandDockManager1 = value;
        if (this._SandDockManager1 == null)
          ;
      }
    }

    internal virtual Panel TreePanel
    {
      get => this._TreePanel;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._TreePanel != null)
          this._TreePanel.Resize -= new EventHandler(this.TreePanel_Resize);
        this._TreePanel = value;
        if (this._TreePanel == null)
          return;
        this._TreePanel.Resize += new EventHandler(this.TreePanel_Resize);
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

    internal virtual HeaderControl HeaderControl2
    {
      get => this._HeaderControl2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._HeaderControl2 == null)
          ;
        this._HeaderControl2 = value;
        if (this._HeaderControl2 == null)
          ;
      }
    }

    internal virtual DocumentContainer doc
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._doc == null)
          ;
        this._doc = value;
        if (this._doc == null)
          ;
      }
      get => this._doc;
    }

    internal virtual DockControl dock2
    {
      get => this._dock2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._dock2 == null)
          ;
        this._dock2 = value;
        if (this._dock2 == null)
          ;
      }
    }

    internal virtual DockControl dock3
    {
      get => this._dock3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._dock3 == null)
          ;
        this._dock3 = value;
        if (this._dock3 == null)
          ;
      }
    }

    internal virtual Panel Panel1
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Panel1 == null)
          ;
        this._Panel1 = value;
        if (this._Panel1 == null)
          ;
      }
      get => this._Panel1;
    }

    internal virtual TextBox SC4_BemBox1
    {
      get => this._SC4_BemBox1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._SC4_BemBox1 == null)
          ;
        this._SC4_BemBox1 = value;
        if (this._SC4_BemBox1 == null)
          ;
      }
    }

    internal virtual TD.SandBar.ToolBar ToolBar1
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ToolBar1 == null)
          ;
        this._ToolBar1 = value;
        if (this._ToolBar1 == null)
          ;
      }
      get => this._ToolBar1;
    }

    internal virtual TD.SandBar.ToolBar InfoToolBar
    {
      get => this._InfoToolBar;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._InfoToolBar == null)
          ;
        this._InfoToolBar = value;
        if (this._InfoToolBar == null)
          ;
      }
    }

    internal virtual TreeView TreeView1
    {
      get => this._TreeView1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._TreeView1 != null)
          this._TreeView1.AfterSelect -= new TreeViewEventHandler(this.TreeView1_AfterSelect);
        this._TreeView1 = value;
        if (this._TreeView1 == null)
          return;
        this._TreeView1.AfterSelect += new TreeViewEventHandler(this.TreeView1_AfterSelect);
      }
    }

    internal virtual TreeView DBTreeView
    {
      get => this._DBTreeView;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._DBTreeView != null)
          this._DBTreeView.AfterSelect -= new TreeViewEventHandler(this.DBTreeView_AfterSelect);
        this._DBTreeView = value;
        if (this._DBTreeView == null)
          return;
        this._DBTreeView.AfterSelect += new TreeViewEventHandler(this.DBTreeView_AfterSelect);
      }
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

    internal virtual ButtonItem ToolButton1
    {
      get => this._ToolButton1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ToolButton1 != null)
          this._ToolButton1.Activate -= new EventHandler(this.ToolButton1_Activate);
        this._ToolButton1 = value;
        if (this._ToolButton1 == null)
          return;
        this._ToolButton1.Activate += new EventHandler(this.ToolButton1_Activate);
      }
    }

    internal virtual ButtonItem ToolButton2
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ToolButton2 != null)
          this._ToolButton2.Activate -= new EventHandler(this.ToolButton2_Activate);
        this._ToolButton2 = value;
        if (this._ToolButton2 == null)
          return;
        this._ToolButton2.Activate += new EventHandler(this.ToolButton2_Activate);
      }
      get => this._ToolButton2;
    }

    internal virtual ButtonItem ToolButton3
    {
      get => this._ToolButton3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ToolButton3 != null)
          this._ToolButton3.Activate -= new EventHandler(this.ToolButton3_Activate);
        this._ToolButton3 = value;
        if (this._ToolButton3 == null)
          return;
        this._ToolButton3.Activate += new EventHandler(this.ToolButton3_Activate);
      }
    }

    internal virtual ButtonItem ToolButton4
    {
      get => this._ToolButton4;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ToolButton4 != null)
          this._ToolButton4.Activate -= new EventHandler(this.ToolButton4_Activate);
        this._ToolButton4 = value;
        if (this._ToolButton4 == null)
          return;
        this._ToolButton4.Activate += new EventHandler(this.ToolButton4_Activate);
      }
    }

    internal virtual Panel SC4_AusgabePanel
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._SC4_AusgabePanel == null)
          ;
        this._SC4_AusgabePanel = value;
        if (this._SC4_AusgabePanel == null)
          ;
      }
      get => this._SC4_AusgabePanel;
    }

    internal virtual TD.SandBar.ToolBar SC4_ToolBar1
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._SC4_ToolBar1 == null)
          ;
        this._SC4_ToolBar1 = value;
        if (this._SC4_ToolBar1 == null)
          ;
      }
      get => this._SC4_ToolBar1;
    }

    internal virtual ButtonItem SC4_ToolButton1
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._SC4_ToolButton1 == null)
          ;
        this._SC4_ToolButton1 = value;
        if (this._SC4_ToolButton1 == null)
          ;
      }
      get => this._SC4_ToolButton1;
    }

    internal virtual ButtonItem SC4_ToolButton2
    {
      get => this._SC4_ToolButton2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._SC4_ToolButton2 != null)
          this._SC4_ToolButton2.Activate -= new EventHandler(this.SC4_ToolButton2_Activate);
        this._SC4_ToolButton2 = value;
        if (this._SC4_ToolButton2 == null)
          return;
        this._SC4_ToolButton2.Activate += new EventHandler(this.SC4_ToolButton2_Activate);
      }
    }

    internal virtual DockControl dockBuilding
    {
      get => this._dockBuilding;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._dockBuilding == null)
          ;
        this._dockBuilding = value;
        if (this._dockBuilding == null)
          ;
      }
    }

    internal virtual DockControl dockLot
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._dockLot == null)
          ;
        this._dockLot = value;
        if (this._dockLot == null)
          ;
      }
      get => this._dockLot;
    }

    internal virtual DockControl dockDep
    {
      get => this._dockDep;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._dockDep == null)
          ;
        this._dockDep = value;
        if (this._dockDep == null)
          ;
      }
    }

    internal virtual DockControl dockProp
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._dockProp == null)
          ;
        this._dockProp = value;
        if (this._dockProp == null)
          ;
      }
      get => this._dockProp;
    }

    internal virtual DockControl dockTextures
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._dockTextures == null)
          ;
        this._dockTextures = value;
        if (this._dockTextures == null)
          ;
      }
      get => this._dockTextures;
    }

    internal virtual TD.SandBar.ToolBar LotToolBar
    {
      get => this._LotToolBar;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._LotToolBar == null)
          ;
        this._LotToolBar = value;
        if (this._LotToolBar == null)
          ;
      }
    }

    internal virtual StatusBar StatusBar1
    {
      get => this._StatusBar1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._StatusBar1 == null)
          ;
        this._StatusBar1 = value;
        if (this._StatusBar1 == null)
          ;
      }
    }

    internal virtual StatusBarPanel StatusBarPanel1
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._StatusBarPanel1 == null)
          ;
        this._StatusBarPanel1 = value;
        if (this._StatusBarPanel1 == null)
          ;
      }
      get => this._StatusBarPanel1;
    }

    internal virtual StatusBarPanel StatusBarPanel2
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._StatusBarPanel2 == null)
          ;
        this._StatusBarPanel2 = value;
        if (this._StatusBarPanel2 == null)
          ;
      }
      get => this._StatusBarPanel2;
    }

    internal virtual StatusBarPanel StatusBarPanel3
    {
      get => this._StatusBarPanel3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._StatusBarPanel3 == null)
          ;
        this._StatusBarPanel3 = value;
        if (this._StatusBarPanel3 == null)
          ;
      }
    }

    internal virtual Grid InfoGrid
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._InfoGrid == null)
          ;
        this._InfoGrid = value;
        if (this._InfoGrid == null)
          ;
      }
      get => this._InfoGrid;
    }

    internal virtual ButtonItem InfoToolButton1
    {
      get => this._InfoToolButton1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._InfoToolButton1 != null)
          this._InfoToolButton1.Activate -= new EventHandler(this.InfoToolButton1_Activate);
        this._InfoToolButton1 = value;
        if (this._InfoToolButton1 == null)
          return;
        this._InfoToolButton1.Activate += new EventHandler(this.InfoToolButton1_Activate);
      }
    }

    internal virtual DropDownMenuItem AutorDropDownMenu
    {
      get => this._AutorDropDownMenu;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._AutorDropDownMenu == null)
          ;
        this._AutorDropDownMenu = value;
        if (this._AutorDropDownMenu == null)
          ;
      }
    }

    internal virtual DropDownMenuItem TeamDropDownMenu
    {
      get => this._TeamDropDownMenu;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._TeamDropDownMenu == null)
          ;
        this._TeamDropDownMenu = value;
        if (this._TeamDropDownMenu == null)
          ;
      }
    }

    internal virtual ButtonItem InfoToolButton2
    {
      get => this._InfoToolButton2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._InfoToolButton2 != null)
          this._InfoToolButton2.Activate -= new EventHandler(this.InfoToolButton2_Activate);
        this._InfoToolButton2 = value;
        if (this._InfoToolButton2 == null)
          return;
        this._InfoToolButton2.Activate += new EventHandler(this.InfoToolButton2_Activate);
      }
    }

    internal virtual ButtonItem InfoToolButton3
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._InfoToolButton3 != null)
          this._InfoToolButton3.Activate -= new EventHandler(this.InfoToolButton3_Activate);
        this._InfoToolButton3 = value;
        if (this._InfoToolButton3 == null)
          return;
        this._InfoToolButton3.Activate += new EventHandler(this.InfoToolButton3_Activate);
      }
      get => this._InfoToolButton3;
    }

    internal virtual ButtonItem InfoToolButton4
    {
      get => this._InfoToolButton4;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._InfoToolButton4 != null)
          this._InfoToolButton4.Activate -= new EventHandler(this.InfoToolButton4_Activate);
        this._InfoToolButton4 = value;
        if (this._InfoToolButton4 == null)
          return;
        this._InfoToolButton4.Activate += new EventHandler(this.InfoToolButton4_Activate);
      }
    }

    internal virtual ButtonItem InfoToolButton5
    {
      get => this._InfoToolButton5;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._InfoToolButton5 != null)
          this._InfoToolButton5.Activate -= new EventHandler(this.InfoToolButton5_Activate);
        this._InfoToolButton5 = value;
        if (this._InfoToolButton5 == null)
          return;
        this._InfoToolButton5.Activate += new EventHandler(this.InfoToolButton5_Activate);
      }
    }

    internal virtual Panel LotAusgabePanel
    {
      get => this._LotAusgabePanel;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._LotAusgabePanel == null)
          ;
        this._LotAusgabePanel = value;
        if (this._LotAusgabePanel == null)
          ;
      }
    }

    internal virtual sr_DepGrid Sr_DepGrid1
    {
      get => this._Sr_DepGrid1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Sr_DepGrid1 == null)
          ;
        this._Sr_DepGrid1 = value;
        if (this._Sr_DepGrid1 == null)
          ;
      }
    }

    internal virtual ButtonItem SC4_ToolButton3
    {
      get => this._SC4_ToolButton3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._SC4_ToolButton3 != null)
          this._SC4_ToolButton3.Activate -= new EventHandler(this.SC4_ToolButton3_Activate);
        this._SC4_ToolButton3 = value;
        if (this._SC4_ToolButton3 == null)
          return;
        this._SC4_ToolButton3.Activate += new EventHandler(this.SC4_ToolButton3_Activate);
      }
    }

    internal virtual ButtonItem ButtonSearchBuilding
    {
      get => this._ButtonSearchBuilding;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ButtonSearchBuilding != null)
          this._ButtonSearchBuilding.Activate -= new EventHandler(this.ButtonSearchBuilding_Activate);
        this._ButtonSearchBuilding = value;
        if (this._ButtonSearchBuilding == null)
          return;
        this._ButtonSearchBuilding.Activate += new EventHandler(this.ButtonSearchBuilding_Activate);
      }
    }

    internal virtual Panel Panel2
    {
      get => this._Panel2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Panel2 == null)
          ;
        this._Panel2 = value;
        if (this._Panel2 == null)
          ;
      }
    }

    internal virtual TD.SandBar.ToolBar ImagesToolBar
    {
      get => this._ImagesToolBar;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ImagesToolBar == null)
          ;
        this._ImagesToolBar = value;
        if (this._ImagesToolBar == null)
          ;
      }
    }

    internal virtual ButtonItem ImageToolButton2
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ImageToolButton2 != null)
          this._ImageToolButton2.Activate -= new EventHandler(this.ImageToolButton2_Activate);
        this._ImageToolButton2 = value;
        if (this._ImageToolButton2 == null)
          return;
        this._ImageToolButton2.Activate += new EventHandler(this.ImageToolButton2_Activate);
      }
      get => this._ImageToolButton2;
    }

    internal virtual DropDownMenuItem ImageDropDownMenu1
    {
      get => this._ImageDropDownMenu1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ImageDropDownMenu1 == null)
          ;
        this._ImageDropDownMenu1 = value;
        if (this._ImageDropDownMenu1 == null)
          ;
      }
    }

    internal virtual MenuButtonItem ImageMenuItem1
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ImageMenuItem1 != null)
          this._ImageMenuItem1.Activate -= new EventHandler(this.ImageMenuItem1_Activate);
        this._ImageMenuItem1 = value;
        if (this._ImageMenuItem1 == null)
          return;
        this._ImageMenuItem1.Activate += new EventHandler(this.ImageMenuItem1_Activate);
      }
      get => this._ImageMenuItem1;
    }

    internal virtual MenuButtonItem ImageMenuItem2
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ImageMenuItem2 != null)
          this._ImageMenuItem2.Activate -= new EventHandler(this.ImageMenuItem2_Activate);
        this._ImageMenuItem2 = value;
        if (this._ImageMenuItem2 == null)
          return;
        this._ImageMenuItem2.Activate += new EventHandler(this.ImageMenuItem2_Activate);
      }
      get => this._ImageMenuItem2;
    }

    internal virtual MenuButtonItem ImageMenuItem3
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ImageMenuItem3 != null)
          this._ImageMenuItem3.Activate -= new EventHandler(this.ImageMenuItem3_Activate);
        this._ImageMenuItem3 = value;
        if (this._ImageMenuItem3 == null)
          return;
        this._ImageMenuItem3.Activate += new EventHandler(this.ImageMenuItem3_Activate);
      }
      get => this._ImageMenuItem3;
    }

    internal virtual MenuButtonItem ImageMenuItem4
    {
      get => this._ImageMenuItem4;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ImageMenuItem4 != null)
          this._ImageMenuItem4.Activate -= new EventHandler(this.ImageMenuItem4_Activate);
        this._ImageMenuItem4 = value;
        if (this._ImageMenuItem4 == null)
          return;
        this._ImageMenuItem4.Activate += new EventHandler(this.ImageMenuItem4_Activate);
      }
    }

    internal virtual MenuButtonItem ImageMenuItem5
    {
      get => this._ImageMenuItem5;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ImageMenuItem5 != null)
          this._ImageMenuItem5.Activate -= new EventHandler(this.ImageMenuItem5_Activate);
        this._ImageMenuItem5 = value;
        if (this._ImageMenuItem5 == null)
          return;
        this._ImageMenuItem5.Activate += new EventHandler(this.ImageMenuItem5_Activate);
      }
    }

    internal virtual MenuButtonItem ImageMenuItem6
    {
      get => this._ImageMenuItem6;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ImageMenuItem6 != null)
          this._ImageMenuItem6.Activate -= new EventHandler(this.ImageMenuItem6_Activate);
        this._ImageMenuItem6 = value;
        if (this._ImageMenuItem6 == null)
          return;
        this._ImageMenuItem6.Activate += new EventHandler(this.ImageMenuItem6_Activate);
      }
    }

    internal virtual C1.Win.C1FlexGrid.C1FlexGrid AusgabeGrid
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._AusgabeGrid == null)
          ;
        this._AusgabeGrid = value;
        if (this._AusgabeGrid == null)
          ;
      }
      get => this._AusgabeGrid;
    }

    internal virtual C1.Win.C1FlexGrid.C1FlexGrid LotGrid
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._LotGrid == null)
          ;
        this._LotGrid = value;
        if (this._LotGrid == null)
          ;
      }
      get => this._LotGrid;
    }

    internal virtual C1.Win.C1FlexGrid.C1FlexGrid PropGrid
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._PropGrid == null)
          ;
        this._PropGrid = value;
        if (this._PropGrid == null)
          ;
      }
      get => this._PropGrid;
    }

    internal virtual ButtonItem ButtonItem1
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ButtonItem1 != null)
          this._ButtonItem1.Activate -= new EventHandler(this.ButtonItem1_Activate);
        this._ButtonItem1 = value;
        if (this._ButtonItem1 == null)
          return;
        this._ButtonItem1.Activate += new EventHandler(this.ButtonItem1_Activate);
      }
      get => this._ButtonItem1;
    }

    internal virtual sr_TextureViewer Sr_TextureViewer1
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Sr_TextureViewer1 == null)
          ;
        this._Sr_TextureViewer1 = value;
        if (this._Sr_TextureViewer1 == null)
          ;
      }
      get => this._Sr_TextureViewer1;
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      ResourceManager resourceManager = new ResourceManager(typeof (FormBAT));
      this.SandDockManager1 = new SandDockManager();
      this.TreePanel = new Panel();
      this.TreeView1 = new TreeView();
      this.ImageList1 = new ImageList(this.components);
      this.DBTreeView = new TreeView();
      this.ToolBar1 = new TD.SandBar.ToolBar();
      this.ToolButton1 = new ButtonItem();
      this.ToolButton2 = new ButtonItem();
      this.ToolButton3 = new ButtonItem();
      this.ToolButton4 = new ButtonItem();
      this.InfoToolBar = new TD.SandBar.ToolBar();
      this.InfoToolButton1 = new ButtonItem();
      this.InfoToolButton2 = new ButtonItem();
      this.InfoToolButton3 = new ButtonItem();
      this.InfoToolButton4 = new ButtonItem();
      this.InfoToolButton5 = new ButtonItem();
      this.AutorDropDownMenu = new DropDownMenuItem();
      this.TeamDropDownMenu = new DropDownMenuItem();
      this.Splitter1 = new Splitter();
      this.HeaderControl2 = new HeaderControl();
      this.doc = new DocumentContainer();
      this.dockProp = new DockControl();
      this.PropGrid = new C1.Win.C1FlexGrid.C1FlexGrid();
      this.dockTextures = new DockControl();
      this.Panel2 = new Panel();
      this.ImagesToolBar = new TD.SandBar.ToolBar();
      this.ImageToolButton2 = new ButtonItem();
      this.ImageDropDownMenu1 = new DropDownMenuItem();
      this.ImageMenuItem1 = new MenuButtonItem();
      this.ImageMenuItem2 = new MenuButtonItem();
      this.ImageMenuItem3 = new MenuButtonItem();
      this.ImageMenuItem4 = new MenuButtonItem();
      this.ImageMenuItem5 = new MenuButtonItem();
      this.ImageMenuItem6 = new MenuButtonItem();
      this.dockBuilding = new DockControl();
      this.SC4_AusgabePanel = new Panel();
      this.AusgabeGrid = new C1.Win.C1FlexGrid.C1FlexGrid();
      this.SC4_ToolBar1 = new TD.SandBar.ToolBar();
      this.SC4_ToolButton1 = new ButtonItem();
      this.SC4_ToolButton2 = new ButtonItem();
      this.SC4_ToolButton3 = new ButtonItem();
      this.dockLot = new DockControl();
      this.LotAusgabePanel = new Panel();
      this.LotGrid = new C1.Win.C1FlexGrid.C1FlexGrid();
      this.LotToolBar = new TD.SandBar.ToolBar();
      this.ButtonSearchBuilding = new ButtonItem();
      this.ButtonItem1 = new ButtonItem();
      this.dockDep = new DockControl();
      this.Sr_DepGrid1 = new sr_DepGrid();
      this.dock3 = new DockControl();
      this.SC4_BemBox1 = new TextBox();
      this.dock2 = new DockControl();
      this.Panel1 = new Panel();
      this.InfoGrid = new Grid();
      this.StatusBar1 = new StatusBar();
      this.StatusBarPanel2 = new StatusBarPanel();
      this.StatusBarPanel3 = new StatusBarPanel();
      this.StatusBarPanel1 = new StatusBarPanel();
      this.Sr_TextureViewer1 = new sr_TextureViewer();
      this.TreePanel.SuspendLayout();
      this.HeaderControl2.SuspendLayout();
      this.doc.SuspendLayout();
      this.dockProp.SuspendLayout();
      this.PropGrid.BeginInit();
      this.dockTextures.SuspendLayout();
      this.Panel2.SuspendLayout();
      this.dockBuilding.SuspendLayout();
      this.SC4_AusgabePanel.SuspendLayout();
      this.AusgabeGrid.BeginInit();
      this.dockLot.SuspendLayout();
      this.LotAusgabePanel.SuspendLayout();
      this.LotGrid.BeginInit();
      this.dockDep.SuspendLayout();
      this.dock3.SuspendLayout();
      this.dock2.SuspendLayout();
      this.Panel1.SuspendLayout();
      this.StatusBarPanel2.BeginInit();
      this.StatusBarPanel3.BeginInit();
      this.StatusBarPanel1.BeginInit();
      this.SuspendLayout();
      this.SandDockManager1.OwnerForm = (Form) this;
      this.TreePanel.Controls.Add((Control) this.TreeView1);
      this.TreePanel.Controls.Add((Control) this.DBTreeView);
      this.TreePanel.Controls.Add((Control) this.ToolBar1);
      this.TreePanel.Dock = DockStyle.Left;
      Panel treePanel1 = this.TreePanel;
      Point point1 = new Point(0, 0);
      Point point2 = point1;
      treePanel1.Location = point2;
      this.TreePanel.Name = "TreePanel";
      Panel treePanel2 = this.TreePanel;
      Size size1 = new Size(140, 539);
      Size size2 = size1;
      treePanel2.Size = size2;
      this.TreePanel.TabIndex = 0;
      this.TreeView1.Dock = DockStyle.Fill;
      this.TreeView1.FullRowSelect = true;
      this.TreeView1.ImageList = this.ImageList1;
      TreeView treeView1_1 = this.TreeView1;
      point1 = new Point(0, 24);
      Point point3 = point1;
      treeView1_1.Location = point3;
      this.TreeView1.Name = "TreeView1";
      TreeView treeView1_2 = this.TreeView1;
      size1 = new Size(140, 515);
      Size size3 = size1;
      treeView1_2.Size = size3;
      this.TreeView1.TabIndex = 1;
      ImageList imageList1 = this.ImageList1;
      size1 = new Size(16, 16);
      Size size4 = size1;
      imageList1.ImageSize = size4;
      this.ImageList1.ImageStream = (ImageListStreamer) resourceManager.GetObject("ImageList1.ImageStream");
      this.ImageList1.TransparentColor = Color.Transparent;
      this.DBTreeView.Dock = DockStyle.Fill;
      this.DBTreeView.FullRowSelect = true;
      this.DBTreeView.ImageList = this.ImageList1;
      TreeView dbTreeView1 = this.DBTreeView;
      point1 = new Point(0, 24);
      Point point4 = point1;
      dbTreeView1.Location = point4;
      this.DBTreeView.Name = "DBTreeView";
      TreeView dbTreeView2 = this.DBTreeView;
      size1 = new Size(140, 515);
      Size size5 = size1;
      dbTreeView2.Size = size5;
      this.DBTreeView.TabIndex = 1;
      TD.SandBar.ToolBar toolBar1_1 = this.ToolBar1;
      Guid guid1 = new Guid("921fc396-f743-47bc-ba87-619b60e0ab9b");
      Guid guid2 = guid1;
      toolBar1_1.Guid = guid2;
      this.ToolBar1.ImageList = this.ImageList1;
      this.ToolBar1.Items.AddRange(new ToolbarItemBase[4]
      {
        (ToolbarItemBase) this.ToolButton1,
        (ToolbarItemBase) this.ToolButton2,
        (ToolbarItemBase) this.ToolButton3,
        (ToolbarItemBase) this.ToolButton4
      });
      TD.SandBar.ToolBar toolBar1_2 = this.ToolBar1;
      point1 = new Point(0, 0);
      Point point5 = point1;
      toolBar1_2.Location = point5;
      this.ToolBar1.Name = "ToolBar1";
      TD.SandBar.ToolBar toolBar1_3 = this.ToolBar1;
      size1 = new Size(140, 24);
      Size size6 = size1;
      toolBar1_3.Size = size6;
      this.ToolBar1.TabIndex = 0;
      this.ToolBar1.Text = "ToolBar1";
      this.ToolButton1.BeginGroup = true;
      this.ToolButton1.ImageIndex = 0;
      this.ToolButton2.BeginGroup = true;
      this.ToolButton2.ImageIndex = 4;
      this.ToolButton3.BeginGroup = true;
      this.ToolButton3.ImageIndex = 12;
      this.ToolButton4.BeginGroup = true;
      this.ToolButton4.ImageIndex = 13;
      TD.SandBar.ToolBar infoToolBar1 = this.InfoToolBar;
      guid1 = new Guid("921fc396-f743-47bc-ba87-619b60e0ab9b");
      Guid guid3 = guid1;
      infoToolBar1.Guid = guid3;
      this.InfoToolBar.ImageList = this.ImageList1;
      this.InfoToolBar.Items.AddRange(new ToolbarItemBase[7]
      {
        (ToolbarItemBase) this.InfoToolButton1,
        (ToolbarItemBase) this.InfoToolButton2,
        (ToolbarItemBase) this.InfoToolButton3,
        (ToolbarItemBase) this.InfoToolButton4,
        (ToolbarItemBase) this.InfoToolButton5,
        (ToolbarItemBase) this.AutorDropDownMenu,
        (ToolbarItemBase) this.TeamDropDownMenu
      });
      TD.SandBar.ToolBar infoToolBar2 = this.InfoToolBar;
      point1 = new Point(1, 1);
      Point point6 = point1;
      infoToolBar2.Location = point6;
      this.InfoToolBar.Name = "InfoToolBar";
      TD.SandBar.ToolBar infoToolBar3 = this.InfoToolBar;
      size1 = new Size(622, 24);
      Size size7 = size1;
      infoToolBar3.Size = size7;
      this.InfoToolBar.TabIndex = 0;
      this.InfoToolBar.Text = "InfoToolBar";
      this.InfoToolButton1.BeginGroup = true;
      this.InfoToolButton1.ImageIndex = 14;
      this.InfoToolButton2.BeginGroup = true;
      this.InfoToolButton2.ImageIndex = 11;
      this.InfoToolButton3.BeginGroup = true;
      this.InfoToolButton3.ImageIndex = 15;
      this.InfoToolButton4.BeginGroup = true;
      this.InfoToolButton4.ImageIndex = 3;
      this.InfoToolButton5.BeginGroup = true;
      this.InfoToolButton5.ImageIndex = 16;
      this.AutorDropDownMenu.BeginGroup = true;
      this.AutorDropDownMenu.Text = "Autor";
      this.TeamDropDownMenu.BeginGroup = true;
      this.TeamDropDownMenu.Text = "Team";
      Splitter splitter1_1 = this.Splitter1;
      point1 = new Point(140, 0);
      Point point7 = point1;
      splitter1_1.Location = point7;
      this.Splitter1.Name = "Splitter1";
      Splitter splitter1_2 = this.Splitter1;
      size1 = new Size(8, 539);
      Size size8 = size1;
      splitter1_2.Size = size8;
      this.Splitter1.TabIndex = 1;
      this.Splitter1.TabStop = false;
      this.HeaderControl2.Controls.Add((Control) this.doc);
      this.HeaderControl2.Dock = DockStyle.Fill;
      this.HeaderControl2.HeaderFont = new Font("Tahoma", 12f, FontStyle.Bold);
      HeaderControl headerControl2_1 = this.HeaderControl2;
      point1 = new Point(148, 0);
      Point point8 = point1;
      headerControl2_1.Location = point8;
      this.HeaderControl2.Name = "HeaderControl2";
      HeaderControl headerControl2_2 = this.HeaderControl2;
      size1 = new Size(634, 539);
      Size size9 = size1;
      headerControl2_2.Size = size9;
      this.HeaderControl2.TabIndex = 2;
      this.HeaderControl2.Text = "<....>";
      this.doc.BorderStyle = TD.SandDock.Rendering.BorderStyle.None;
      this.doc.Controls.Add((Control) this.dockTextures);
      this.doc.Controls.Add((Control) this.dockProp);
      this.doc.Controls.Add((Control) this.dockBuilding);
      this.doc.Controls.Add((Control) this.dockLot);
      this.doc.Controls.Add((Control) this.dockDep);
      this.doc.Controls.Add((Control) this.dock3);
      this.doc.Controls.Add((Control) this.dock2);
      this.doc.Cursor = Cursors.Default;
      this.doc.DockingHints = DockingHints.RubberBand;
      DocumentContainer doc1 = this.doc;
      guid1 = new Guid("bb90b9a8-8c91-491a-9d68-ed3efc735a37");
      Guid guid4 = guid1;
      doc1.Guid = guid4;
      this.doc.LayoutSystem = new SplitLayoutSystem(250, 400, Orientation.Horizontal, new LayoutSystemBase[1]
      {
        (LayoutSystemBase) new DocumentLayoutSystem(632, 512, new DockControl[7]
        {
          this.dockBuilding,
          this.dockLot,
          this.dockProp,
          this.dockTextures,
          this.dockDep,
          this.dock3,
          this.dock2
        }, this.dockTextures)
      });
      DocumentContainer doc2 = this.doc;
      point1 = new Point(1, 26);
      Point point9 = point1;
      doc2.Location = point9;
      this.doc.Manager = this.SandDockManager1;
      this.doc.Name = "doc";
      this.doc.Renderer = (TD.SandDock.Rendering.RendererBase) new TD.SandDock.Rendering.Office2003Renderer();
      DocumentContainer doc3 = this.doc;
      size1 = new Size(632, 512);
      Size size10 = size1;
      doc3.Size = size10;
      this.doc.TabIndex = 9;
      this.dockProp.Closable = false;
      this.dockProp.Controls.Add((Control) this.PropGrid);
      this.dockProp.Floatable = false;
      this.dockProp.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      DockControl dockProp1 = this.dockProp;
      guid1 = new Guid("af546717-cf59-40c6-aa8f-06cc4be0ec63");
      Guid guid5 = guid1;
      dockProp1.Guid = guid5;
      DockControl dockProp2 = this.dockProp;
      point1 = new Point(4, 32);
      Point point10 = point1;
      dockProp2.Location = point10;
      this.dockProp.Name = "dockProp";
      DockControl dockProp3 = this.dockProp;
      size1 = new Size(624, 476);
      Size size11 = size1;
      dockProp3.Size = size11;
      this.dockProp.TabIndex = 8;
      this.dockProp.Text = "Props";
      this.PropGrid.ColumnInfo = "10,1,0,0,0,95,Columns:";
      this.PropGrid.Dock = DockStyle.Fill;
      C1.Win.C1FlexGrid.C1FlexGrid propGrid1 = this.PropGrid;
      point1 = new Point(0, 0);
      Point point11 = point1;
      propGrid1.Location = point11;
      this.PropGrid.Name = "PropGrid";
      this.PropGrid.Rows.DefaultSize = 19;
      C1.Win.C1FlexGrid.C1FlexGrid propGrid2 = this.PropGrid;
      size1 = new Size(624, 476);
      Size size12 = size1;
      propGrid2.Size = size12;
      this.PropGrid.Styles = new CellStyleCollection("");
      this.PropGrid.TabIndex = 0;
      this.dockTextures.Closable = false;
      this.dockTextures.Controls.Add((Control) this.Panel2);
      this.dockTextures.Floatable = false;
      this.dockTextures.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      DockControl dockTextures1 = this.dockTextures;
      guid1 = new Guid("6462eff0-39f6-471f-8467-4c70720a90f3");
      Guid guid6 = guid1;
      dockTextures1.Guid = guid6;
      DockControl dockTextures2 = this.dockTextures;
      point1 = new Point(4, 32);
      Point point12 = point1;
      dockTextures2.Location = point12;
      this.dockTextures.Name = "dockTextures";
      DockControl dockTextures3 = this.dockTextures;
      size1 = new Size(624, 476);
      Size size13 = size1;
      dockTextures3.Size = size13;
      this.dockTextures.TabIndex = 8;
      this.dockTextures.Text = "Textures";
      this.Panel2.Controls.Add((Control) this.Sr_TextureViewer1);
      this.Panel2.Controls.Add((Control) this.ImagesToolBar);
      this.Panel2.Dock = DockStyle.Fill;
      Panel panel2_1 = this.Panel2;
      point1 = new Point(0, 0);
      Point point13 = point1;
      panel2_1.Location = point13;
      this.Panel2.Name = "Panel2";
      Panel panel2_2 = this.Panel2;
      size1 = new Size(624, 476);
      Size size14 = size1;
      panel2_2.Size = size14;
      this.Panel2.TabIndex = 0;
      this.ImagesToolBar.Enabled = false;
      TD.SandBar.ToolBar imagesToolBar1 = this.ImagesToolBar;
      guid1 = new Guid("b312afcb-11b1-4d09-bf41-47bfc09e055b");
      Guid guid7 = guid1;
      imagesToolBar1.Guid = guid7;
      this.ImagesToolBar.ImageList = this.ImageList1;
      this.ImagesToolBar.Items.AddRange(new ToolbarItemBase[2]
      {
        (ToolbarItemBase) this.ImageToolButton2,
        (ToolbarItemBase) this.ImageDropDownMenu1
      });
      TD.SandBar.ToolBar imagesToolBar2 = this.ImagesToolBar;
      point1 = new Point(0, 0);
      Point point14 = point1;
      imagesToolBar2.Location = point14;
      this.ImagesToolBar.Name = "ImagesToolBar";
      TD.SandBar.ToolBar imagesToolBar3 = this.ImagesToolBar;
      size1 = new Size(624, 24);
      Size size15 = size1;
      imagesToolBar3.Size = size15;
      this.ImagesToolBar.TabIndex = 3;
      this.ImagesToolBar.Text = "ToolBar2";
      this.ImageToolButton2.BeginGroup = true;
      this.ImageToolButton2.ImageIndex = 11;
      this.ImageDropDownMenu1.BeginGroup = true;
      this.ImageDropDownMenu1.ImageIndex = 3;
      this.ImageDropDownMenu1.Items.AddRange(new ToolbarItemBase[6]
      {
        (ToolbarItemBase) this.ImageMenuItem1,
        (ToolbarItemBase) this.ImageMenuItem2,
        (ToolbarItemBase) this.ImageMenuItem3,
        (ToolbarItemBase) this.ImageMenuItem4,
        (ToolbarItemBase) this.ImageMenuItem5,
        (ToolbarItemBase) this.ImageMenuItem6
      });
      this.ImageMenuItem1.BeginGroup = true;
      this.ImageMenuItem1.Text = "bmp";
      this.ImageMenuItem2.BeginGroup = true;
      this.ImageMenuItem2.Text = "jpg";
      this.ImageMenuItem3.BeginGroup = true;
      this.ImageMenuItem3.Text = "png";
      this.ImageMenuItem4.BeginGroup = true;
      this.ImageMenuItem4.Text = "tif";
      this.ImageMenuItem5.BeginGroup = true;
      this.ImageMenuItem5.Text = "wmf";
      this.ImageMenuItem6.BeginGroup = true;
      this.ImageMenuItem6.Text = "gif";
      this.dockBuilding.BorderStyle = TD.SandDock.Rendering.BorderStyle.Flat;
      this.dockBuilding.Closable = false;
      this.dockBuilding.Collapsible = false;
      this.dockBuilding.Controls.Add((Control) this.SC4_AusgabePanel);
      this.dockBuilding.Controls.Add((Control) this.SC4_ToolBar1);
      this.dockBuilding.Floatable = false;
      this.dockBuilding.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      DockControl dockBuilding1 = this.dockBuilding;
      guid1 = new Guid("b3f92331-1d86-4191-a677-2c4b5865af66");
      Guid guid8 = guid1;
      dockBuilding1.Guid = guid8;
      DockControl dockBuilding2 = this.dockBuilding;
      point1 = new Point(4, 32);
      Point point15 = point1;
      dockBuilding2.Location = point15;
      this.dockBuilding.Name = "dockBuilding";
      DockControl dockBuilding3 = this.dockBuilding;
      size1 = new Size(624, 476);
      Size size16 = size1;
      dockBuilding3.Size = size16;
      this.dockBuilding.TabIndex = 6;
      this.dockBuilding.Text = "Building";
      this.SC4_AusgabePanel.AutoScroll = true;
      this.SC4_AusgabePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.SC4_AusgabePanel.Controls.Add((Control) this.AusgabeGrid);
      this.SC4_AusgabePanel.Dock = DockStyle.Fill;
      this.SC4_AusgabePanel.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Panel sc4AusgabePanel1 = this.SC4_AusgabePanel;
      point1 = new Point(1, 25);
      Point point16 = point1;
      sc4AusgabePanel1.Location = point16;
      this.SC4_AusgabePanel.Name = "SC4_AusgabePanel";
      Panel sc4AusgabePanel2 = this.SC4_AusgabePanel;
      size1 = new Size(622, 450);
      Size size17 = size1;
      sc4AusgabePanel2.Size = size17;
      this.SC4_AusgabePanel.TabIndex = 65;
      this.AusgabeGrid.ColumnInfo = "10,1,0,0,0,95,Columns:";
      this.AusgabeGrid.Dock = DockStyle.Fill;
      C1.Win.C1FlexGrid.C1FlexGrid ausgabeGrid1 = this.AusgabeGrid;
      point1 = new Point(0, 0);
      Point point17 = point1;
      ausgabeGrid1.Location = point17;
      this.AusgabeGrid.Name = "AusgabeGrid";
      this.AusgabeGrid.Rows.DefaultSize = 19;
      C1.Win.C1FlexGrid.C1FlexGrid ausgabeGrid2 = this.AusgabeGrid;
      size1 = new Size(618, 446);
      Size size18 = size1;
      ausgabeGrid2.Size = size18;
      this.AusgabeGrid.Styles = new CellStyleCollection("");
      this.AusgabeGrid.TabIndex = 0;
      this.SC4_ToolBar1.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      TD.SandBar.ToolBar sc4ToolBar1_1 = this.SC4_ToolBar1;
      guid1 = new Guid("5707e504-9a48-48a9-8a02-a59ecc015a12");
      Guid guid9 = guid1;
      sc4ToolBar1_1.Guid = guid9;
      this.SC4_ToolBar1.ImageList = this.ImageList1;
      this.SC4_ToolBar1.Items.AddRange(new ToolbarItemBase[3]
      {
        (ToolbarItemBase) this.SC4_ToolButton1,
        (ToolbarItemBase) this.SC4_ToolButton2,
        (ToolbarItemBase) this.SC4_ToolButton3
      });
      TD.SandBar.ToolBar sc4ToolBar1_2 = this.SC4_ToolBar1;
      point1 = new Point(1, 1);
      Point point18 = point1;
      sc4ToolBar1_2.Location = point18;
      this.SC4_ToolBar1.Name = "SC4_ToolBar1";
      TD.SandBar.ToolBar sc4ToolBar1_3 = this.SC4_ToolBar1;
      size1 = new Size(622, 24);
      Size size19 = size1;
      sc4ToolBar1_3.Size = size19;
      this.SC4_ToolBar1.TabIndex = 0;
      this.SC4_ToolBar1.Text = "ToolBar1";
      this.SC4_ToolButton1.BeginGroup = true;
      this.SC4_ToolButton1.ImageIndex = 3;
      this.SC4_ToolButton1.Visible = false;
      this.SC4_ToolButton2.BeginGroup = true;
      this.SC4_ToolButton2.Enabled = false;
      this.SC4_ToolButton2.ImageIndex = 11;
      this.SC4_ToolButton3.BeginGroup = true;
      this.SC4_ToolButton3.ImageIndex = 21;
      this.dockLot.Closable = false;
      this.dockLot.Controls.Add((Control) this.LotAusgabePanel);
      this.dockLot.Controls.Add((Control) this.LotToolBar);
      this.dockLot.Floatable = false;
      this.dockLot.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      DockControl dockLot1 = this.dockLot;
      guid1 = new Guid("8e500f3f-d8d0-43e0-a1a0-4b828484c1a9");
      Guid guid10 = guid1;
      dockLot1.Guid = guid10;
      DockControl dockLot2 = this.dockLot;
      point1 = new Point(4, 32);
      Point point19 = point1;
      dockLot2.Location = point19;
      this.dockLot.Name = "dockLot";
      DockControl dockLot3 = this.dockLot;
      size1 = new Size(624, 476);
      Size size20 = size1;
      dockLot3.Size = size20;
      this.dockLot.TabIndex = 8;
      this.dockLot.Text = "Lot";
      this.LotAusgabePanel.AutoScroll = true;
      this.LotAusgabePanel.Controls.Add((Control) this.LotGrid);
      this.LotAusgabePanel.Dock = DockStyle.Fill;
      Panel lotAusgabePanel1 = this.LotAusgabePanel;
      point1 = new Point(0, 24);
      Point point20 = point1;
      lotAusgabePanel1.Location = point20;
      this.LotAusgabePanel.Name = "LotAusgabePanel";
      Panel lotAusgabePanel2 = this.LotAusgabePanel;
      size1 = new Size(624, 452);
      Size size21 = size1;
      lotAusgabePanel2.Size = size21;
      this.LotAusgabePanel.TabIndex = 1;
      this.LotGrid.ColumnInfo = "10,1,0,0,0,95,Columns:";
      this.LotGrid.Dock = DockStyle.Fill;
      C1.Win.C1FlexGrid.C1FlexGrid lotGrid1 = this.LotGrid;
      point1 = new Point(0, 0);
      Point point21 = point1;
      lotGrid1.Location = point21;
      this.LotGrid.Name = "LotGrid";
      this.LotGrid.Rows.DefaultSize = 19;
      C1.Win.C1FlexGrid.C1FlexGrid lotGrid2 = this.LotGrid;
      size1 = new Size(624, 452);
      Size size22 = size1;
      lotGrid2.Size = size22;
      this.LotGrid.Styles = new CellStyleCollection("");
      this.LotGrid.TabIndex = 0;
      TD.SandBar.ToolBar lotToolBar1 = this.LotToolBar;
      guid1 = new Guid("68c4e003-6891-4ca5-82a5-b80dbdca8845");
      Guid guid11 = guid1;
      lotToolBar1.Guid = guid11;
      this.LotToolBar.ImageList = this.ImageList1;
      this.LotToolBar.Items.AddRange(new ToolbarItemBase[2]
      {
        (ToolbarItemBase) this.ButtonSearchBuilding,
        (ToolbarItemBase) this.ButtonItem1
      });
      TD.SandBar.ToolBar lotToolBar2 = this.LotToolBar;
      point1 = new Point(0, 0);
      Point point22 = point1;
      lotToolBar2.Location = point22;
      this.LotToolBar.Name = "LotToolBar";
      TD.SandBar.ToolBar lotToolBar3 = this.LotToolBar;
      size1 = new Size(624, 24);
      Size size23 = size1;
      lotToolBar3.Size = size23;
      this.LotToolBar.TabIndex = 0;
      this.LotToolBar.Text = "ToolBar2";
      this.ButtonSearchBuilding.BeginGroup = true;
      this.ButtonSearchBuilding.ImageIndex = 21;
      this.ButtonItem1.BeginGroup = true;
      this.ButtonItem1.Enabled = false;
      this.ButtonItem1.ImageIndex = 11;
      this.dockDep.Closable = false;
      this.dockDep.Controls.Add((Control) this.Sr_DepGrid1);
      this.dockDep.Floatable = false;
      this.dockDep.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      DockControl dockDep1 = this.dockDep;
      guid1 = new Guid("c4abdab4-f860-4eb8-9def-5cd91e354456");
      Guid guid12 = guid1;
      dockDep1.Guid = guid12;
      DockControl dockDep2 = this.dockDep;
      point1 = new Point(4, 32);
      Point point23 = point1;
      dockDep2.Location = point23;
      this.dockDep.Name = "dockDep";
      DockControl dockDep3 = this.dockDep;
      size1 = new Size(624, 476);
      Size size24 = size1;
      dockDep3.Size = size24;
      this.dockDep.TabIndex = 8;
      this.dockDep.Text = "Dependencies";
      this.Sr_DepGrid1.DepListe = (sr_DepBrowser) null;
      this.Sr_DepGrid1.Dock = DockStyle.Fill;
      sr_DepGrid srDepGrid1_1 = this.Sr_DepGrid1;
      point1 = new Point(0, 0);
      Point point24 = point1;
      srDepGrid1_1.Location = point24;
      this.Sr_DepGrid1.Name = "Sr_DepGrid1";
      sr_DepGrid srDepGrid1_2 = this.Sr_DepGrid1;
      size1 = new Size(624, 476);
      Size size25 = size1;
      srDepGrid1_2.Size = size25;
      this.Sr_DepGrid1.TabIndex = 0;
      this.dock3.BorderStyle = TD.SandDock.Rendering.BorderStyle.Flat;
      this.dock3.Closable = false;
      this.dock3.Controls.Add((Control) this.SC4_BemBox1);
      this.dock3.Floatable = false;
      this.dock3.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      DockControl dock3_1 = this.dock3;
      guid1 = new Guid("dac28d4f-2b32-4a3f-82fe-947f593113f4");
      Guid guid13 = guid1;
      dock3_1.Guid = guid13;
      DockControl dock3_2 = this.dock3;
      point1 = new Point(4, 32);
      Point point25 = point1;
      dock3_2.Location = point25;
      this.dock3.Name = "dock3";
      DockControl dock3_3 = this.dock3;
      size1 = new Size(624, 476);
      Size size26 = size1;
      dock3_3.Size = size26;
      this.dock3.TabImage = (Image) resourceManager.GetObject("dock3.TabImage");
      this.dock3.TabIndex = 0;
      this.SC4_BemBox1.AcceptsReturn = true;
      this.SC4_BemBox1.AutoSize = false;
      this.SC4_BemBox1.Dock = DockStyle.Fill;
      TextBox sc4BemBox1_1 = this.SC4_BemBox1;
      point1 = new Point(1, 1);
      Point point26 = point1;
      sc4BemBox1_1.Location = point26;
      this.SC4_BemBox1.Multiline = true;
      this.SC4_BemBox1.Name = "SC4_BemBox1";
      TextBox sc4BemBox1_2 = this.SC4_BemBox1;
      size1 = new Size(622, 474);
      Size size27 = size1;
      sc4BemBox1_2.Size = size27;
      this.SC4_BemBox1.TabIndex = 28;
      this.SC4_BemBox1.Text = "";
      this.dock2.BorderStyle = TD.SandDock.Rendering.BorderStyle.Flat;
      this.dock2.Closable = false;
      this.dock2.Controls.Add((Control) this.Panel1);
      this.dock2.Controls.Add((Control) this.InfoToolBar);
      this.dock2.Floatable = false;
      this.dock2.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      DockControl dock2_1 = this.dock2;
      guid1 = new Guid("5c892ee5-e815-4277-af75-8353ff4a2db6");
      Guid guid14 = guid1;
      dock2_1.Guid = guid14;
      DockControl dock2_2 = this.dock2;
      point1 = new Point(4, 32);
      Point point27 = point1;
      dock2_2.Location = point27;
      this.dock2.Name = "dock2";
      DockControl dock2_3 = this.dock2;
      size1 = new Size(624, 476);
      Size size28 = size1;
      dock2_3.Size = size28;
      this.dock2.TabImage = (Image) resourceManager.GetObject("dock2.TabImage");
      this.dock2.TabIndex = 7;
      this.Panel1.AutoScroll = true;
      this.Panel1.Controls.Add((Control) this.InfoGrid);
      this.Panel1.Dock = DockStyle.Fill;
      Panel panel1_1 = this.Panel1;
      point1 = new Point(1, 25);
      Point point28 = point1;
      panel1_1.Location = point28;
      this.Panel1.Name = "Panel1";
      Panel panel1_2 = this.Panel1;
      size1 = new Size(622, 450);
      Size size29 = size1;
      panel1_2.Size = size29;
      this.Panel1.TabIndex = 29;
      this.InfoGrid.AutoSizeMinHeight = 10;
      this.InfoGrid.AutoSizeMinWidth = 10;
      this.InfoGrid.AutoStretchColumnsToFitWidth = false;
      this.InfoGrid.AutoStretchRowsToFitHeight = false;
      this.InfoGrid.ContextMenuStyle = ContextMenuStyle.None;
      this.InfoGrid.CustomSort = false;
      this.InfoGrid.Dock = DockStyle.Fill;
      this.InfoGrid.GridToolTipActive = true;
      Grid infoGrid1 = this.InfoGrid;
      point1 = new Point(0, 0);
      Point point29 = point1;
      infoGrid1.Location = point29;
      this.InfoGrid.Name = "InfoGrid";
      Grid infoGrid2 = this.InfoGrid;
      size1 = new Size(622, 450);
      Size size30 = size1;
      infoGrid2.Size = size30;
      this.InfoGrid.SpecialKeys = GridSpecialKeys.Default;
      this.InfoGrid.TabIndex = 0;
      StatusBar statusBar1_1 = this.StatusBar1;
      point1 = new Point(0, 539);
      Point point30 = point1;
      statusBar1_1.Location = point30;
      this.StatusBar1.Name = "StatusBar1";
      this.StatusBar1.Panels.AddRange(new StatusBarPanel[3]
      {
        this.StatusBarPanel2,
        this.StatusBarPanel3,
        this.StatusBarPanel1
      });
      this.StatusBar1.ShowPanels = true;
      StatusBar statusBar1_2 = this.StatusBar1;
      size1 = new Size(782, 24);
      Size size31 = size1;
      statusBar1_2.Size = size31;
      this.StatusBar1.TabIndex = 6;
      this.StatusBar1.Text = "Ready";
      this.StatusBarPanel2.Text = "Ready";
      this.StatusBarPanel3.Alignment = HorizontalAlignment.Center;
      this.StatusBarPanel3.AutoSize = StatusBarPanelAutoSize.Spring;
      this.StatusBarPanel3.Width = 634;
      this.StatusBarPanel1.Alignment = HorizontalAlignment.Right;
      this.StatusBarPanel1.Width = 32;
      this.Sr_TextureViewer1.Dock = DockStyle.Fill;
      sr_TextureViewer srTextureViewer1_1 = this.Sr_TextureViewer1;
      point1 = new Point(0, 24);
      Point point31 = point1;
      srTextureViewer1_1.Location = point31;
      this.Sr_TextureViewer1.Name = "Sr_TextureViewer1";
      sr_TextureViewer srTextureViewer1_2 = this.Sr_TextureViewer1;
      size1 = new Size(624, 452);
      Size size32 = size1;
      srTextureViewer1_2.Size = size32;
      this.Sr_TextureViewer1.TabIndex = 4;
      size1 = new Size(6, 15);
      this.AutoScaleBaseSize = size1;
      size1 = new Size(782, 563);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.HeaderControl2);
      this.Controls.Add((Control) this.Splitter1);
      this.Controls.Add((Control) this.TreePanel);
      this.Controls.Add((Control) this.StatusBar1);
      this.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Name = nameof (FormBAT);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = nameof (FormBAT);
      this.TreePanel.ResumeLayout(false);
      this.HeaderControl2.ResumeLayout(false);
      this.doc.ResumeLayout(false);
      this.dockProp.ResumeLayout(false);
      this.PropGrid.EndInit();
      this.dockTextures.ResumeLayout(false);
      this.Panel2.ResumeLayout(false);
      this.dockBuilding.ResumeLayout(false);
      this.SC4_AusgabePanel.ResumeLayout(false);
      this.AusgabeGrid.EndInit();
      this.dockLot.ResumeLayout(false);
      this.LotAusgabePanel.ResumeLayout(false);
      this.LotGrid.EndInit();
      this.dockDep.ResumeLayout(false);
      this.dock3.ResumeLayout(false);
      this.dock2.ResumeLayout(false);
      this.Panel1.ResumeLayout(false);
      this.StatusBarPanel2.EndInit();
      this.StatusBarPanel3.EndInit();
      this.StatusBarPanel1.EndInit();
      this.ResumeLayout(false);
    }

    private object GetBuildingFromDB()
    {
      int number1 = -1;
      int number2 = -1;
      ArrayList arrayList = new ArrayList();
      this.AktuellerLotIndex = -1;
      this.AktuellerBuildingIndex = -1;
      this.DBBildDateiListe.Clear();
      this.DBAutor = "";
      this.DBTeam = "";
      this.Cursor = Cursors.WaitCursor;
      int aktuellerDbIndex = this.AktuellerDBIndex;
      this.ResetAll(true);
      this.AktuellerDBIndex = aktuellerDbIndex;
      this.StatusBarPanel2.Text = "Reading";
      Application.DoEvents();
      string filterExpression = "ID = " + this.AktuellerDBIndex.ToString();
      DataRow[] dataRowArray = ClassThisProg.DefReader.DB_xmldoc.DataSet.Tables["BAT"].Select(filterExpression);
      if (dataRowArray.GetUpperBound(0) < 0)
      {
        this.Cursor = Cursors.Default;
        this.StatusBarPanel2.Text = "Ready";
        Application.DoEvents();
        int num = (int) MessageBox.Show((IWin32Window) this, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[76]), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[57]), MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.LoescheAktuellenDatenSatz();
      }
      else
      {
        string str1 = "";
        string str2 = "";
        this.DBAutor = "";
        this.DBTeam = "";
        this.DBNotes = "";
        string str3 = "";
        string str4 = "";
        if (!dataRowArray[0].IsNull("Autor"))
          this.DBAutor = StringType.FromObject(dataRowArray[0]["Autor"]);
        if (!dataRowArray[0].IsNull("Team"))
          this.DBTeam = StringType.FromObject(dataRowArray[0]["Team"]);
        if (!dataRowArray[0].IsNull("notes"))
          this.DBNotes = StringType.FromObject(dataRowArray[0]["notes"]);
        if (!dataRowArray[0].IsNull("B_TGI"))
          str2 = StringType.FromObject(dataRowArray[0]["B_TGI"]);
        if (!dataRowArray[0].IsNull("L_TGI"))
          str1 = StringType.FromObject(dataRowArray[0]["L_TGI"]);
        if (!dataRowArray[0].IsNull("BFile"))
          str3 = StringType.FromObject(dataRowArray[0]["BFile"]);
        if (!dataRowArray[0].IsNull("TFile"))
          str4 = StringType.FromObject(dataRowArray[0]["TFile"]);
        if (StringType.StrCmp(str3, "", false) == 0)
        {
          this.Cursor = Cursors.Default;
          this.StatusBarPanel2.Text = "Ready";
          Application.DoEvents();
          int num = (int) MessageBox.Show((IWin32Window) this, StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(ClassThisProg.DefReader.LanguageArray[2], (object) " "), (object) str3), (object) " "), ClassThisProg.DefReader.LanguageArray[13])), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[57]), MessageBoxButtons.OK, MessageBoxIcon.Hand);
          this.LoescheAktuellenDatenSatz();
        }
        else if (!new FileInfo(str3).Exists)
        {
          this.Cursor = Cursors.Default;
          this.StatusBarPanel2.Text = "Ready";
          Application.DoEvents();
          int num = (int) MessageBox.Show((IWin32Window) this, StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(ClassThisProg.DefReader.LanguageArray[2], (object) " "), (object) str3), (object) " "), ClassThisProg.DefReader.LanguageArray[13])), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[57]), MessageBoxButtons.OK, MessageBoxIcon.Hand);
          this.LoescheAktuellenDatenSatz();
        }
        else
        {
          arrayList.Add((object) str3);
          if (StringType.StrCmp(str4, "", false) != 0 && StringType.StrCmp(str4, str3, false) != 0)
          {
            if (!new FileInfo(str4).Exists)
            {
              this.Cursor = Cursors.Default;
              this.StatusBarPanel2.Text = "Ready";
              Application.DoEvents();
              int num = (int) MessageBox.Show((IWin32Window) this, StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(ClassThisProg.DefReader.LanguageArray[2], (object) " "), (object) str4), (object) " "), ClassThisProg.DefReader.LanguageArray[13])), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[57]), MessageBoxButtons.OK, MessageBoxIcon.Hand);
              this.LoescheAktuellenDatenSatz();
              goto label_68;
            }
            else
              arrayList.Add((object) str4);
          }
          SC4FileStorer sc4FileStorer = new SC4FileStorer();
          int num1 = checked (arrayList.Count - 1);
          int index1 = 0;
          while (index1 <= num1)
          {
            sc4FileStorer.GetOneFile(StringType.FromObject(arrayList[index1]));
            checked { ++index1; }
          }
          if (sc4FileStorer.BuildingContains.Count == 0)
          {
            this.Cursor = Cursors.Default;
            int num2 = (int) MessageBox.Show((IWin32Window) this, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[68]), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[17]), MessageBoxButtons.OK, MessageBoxIcon.Hand);
            this.LoescheAktuellenDatenSatz();
            Application.DoEvents();
          }
          else if (sc4FileStorer.LotContains.Count == 0)
          {
            this.Cursor = Cursors.Default;
            int num3 = (int) MessageBox.Show((IWin32Window) this, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[68]), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[17]), MessageBoxButtons.OK, MessageBoxIcon.Hand);
            this.LoescheAktuellenDatenSatz();
            Application.DoEvents();
          }
          else
          {
            if (!Information.IsNothing((object) this.ExemplarListe))
              this.ExemplarListe.Dispose();
            int num4 = checked (sc4FileStorer.BuildingContains.Count - 1);
            int number3 = 0;
            while (number3 <= num4)
            {
              string HexWert1 = sc4FileStorer.BuildingContains.get_item(number3).Type.ToUpper();
              string HexWert2 = sc4FileStorer.BuildingContains.get_item(number3).Group.ToUpper();
              string HexWert3 = sc4FileStorer.BuildingContains.get_item(number3).Instance.ToUpper();
              if (!HexWert1.StartsWith("0X"))
                HexWert1 = AllgemeineKlasse.FormatiereHexWert(HexWert1);
              if (!HexWert2.StartsWith("0X"))
                HexWert2 = AllgemeineKlasse.FormatiereHexWert(HexWert2);
              if (!HexWert3.StartsWith("0X"))
                HexWert3 = AllgemeineKlasse.FormatiereHexWert(HexWert3);
              if (StringType.StrCmp((HexWert1 + "," + HexWert2 + "," + HexWert3).ToUpper(), str2.ToUpper(), false) == 0)
              {
                number1 = number3;
                break;
              }
              checked { ++number3; }
            }
            int num5 = checked (sc4FileStorer.LotContains.Count - 1);
            int number4 = 0;
            while (number4 <= num5)
            {
              string HexWert4 = sc4FileStorer.LotContains.get_item(number4).Type.ToUpper();
              string HexWert5 = sc4FileStorer.LotContains.get_item(number4).Group.ToUpper();
              string HexWert6 = sc4FileStorer.LotContains.get_item(number4).Instance.ToUpper();
              if (!HexWert4.StartsWith("0X"))
                HexWert4 = AllgemeineKlasse.FormatiereHexWert(HexWert4);
              if (!HexWert5.StartsWith("0X"))
                HexWert5 = AllgemeineKlasse.FormatiereHexWert(HexWert5);
              if (!HexWert6.StartsWith("0X"))
                HexWert6 = AllgemeineKlasse.FormatiereHexWert(HexWert6);
              if (StringType.StrCmp((HexWert4 + "," + HexWert5 + "," + HexWert6).ToUpper(), str1.ToUpper(), false) == 0)
              {
                number2 = number4;
                break;
              }
              checked { ++number4; }
            }
            if (number1 == -1 | number2 == -1)
            {
              this.Cursor = Cursors.Default;
              int num6 = (int) MessageBox.Show((IWin32Window) this, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[68]), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[17]), MessageBoxButtons.OK, MessageBoxIcon.Hand);
              this.LoescheAktuellenDatenSatz();
              Application.DoEvents();
            }
            else
            {
              this.ExemplarListe = new SC4FileStorer();
              this.ExemplarListe.AddBuilding(sc4FileStorer.BuildingContains.get_item(number1));
              this.ExemplarListe.AddLot(sc4FileStorer.LotContains.get_item(number2));
              sc4FileStorer.Dispose();
              if (this.ExemplarListe.BuildingContains.Count == 0)
              {
                this.Cursor = Cursors.Default;
                int num7 = (int) MessageBox.Show((IWin32Window) this, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[68]), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[17]), MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.LoescheAktuellenDatenSatz();
                Application.DoEvents();
              }
              else if (this.ExemplarListe.LotContains.Count == 0)
              {
                this.Cursor = Cursors.Default;
                int num8 = (int) MessageBox.Show((IWin32Window) this, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[68]), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[17]), MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.LoescheAktuellenDatenSatz();
                Application.DoEvents();
              }
              else
              {
                this.SC4_ToolButton1.Enabled = ClassThisProg.DefReader.isDatabaseOpen;
                this.SC4_ToolButton2.Enabled = true;
                this.SC4_ToolButton3.Enabled = false;
                this.ButtonSearchBuilding.Enabled = false;
                if (dataRowArray.GetUpperBound(0) > -1)
                {
                  DataRow[] childRows = dataRowArray[0].GetChildRows(ClassThisProg.DefReader.BATRelation, DataRowVersion.Default);
                  if (childRows.GetUpperBound(0) > -1)
                  {
                    int upperBound = childRows.GetUpperBound(0);
                    int index2 = 0;
                    while (index2 <= upperBound)
                    {
                      this.DBBildDateiListe.Add(RuntimeHelpers.GetObjectValue(childRows[index2]["Path"]));
                      checked { ++index2; }
                    }
                  }
                }
                this.AktuellerLotIndex = 0;
                this.AktuellerBuildingIndex = 0;
                this.ShowProps();
                this.TextureListe = new TextureReader();
                this.TextureListe.GetTextures(str3);
                this.ShowImages(str3);
                this.ShowBuilding();
                this.StatusBarPanel2.Text = "Ready";
                this.Cursor = Cursors.Default;
                Application.DoEvents();
              }
            }
          }
        }
      }
label_68:
      object obj;
      return obj;
    }

    private object GetBuildingsFromOtherFiles(string StartDir, string EingabeDatei)
    {
      sr_FileBrowser srFileBrowser = new sr_FileBrowser();
      srFileBrowser.StartDir = StartDir;
      srFileBrowser.StartRead("Building");
      if (srFileBrowser.BuildingData.BuildingContains.Count > 0)
      {
        int num = checked (srFileBrowser.BuildingData.BuildingContains.Count - 1);
        int number = 0;
        while (number <= num)
        {
          if (StringType.StrCmp(srFileBrowser.BuildingData.BuildingContains.get_item(number).DateiName, EingabeDatei, false) != 0)
            this.ExemplarListe.AddBuilding(srFileBrowser.BuildingData.BuildingContains.get_item(number));
          checked { ++number; }
        }
      }
      if (srFileBrowser.BuildingData.LotContains.Count > 0)
      {
        int num = checked (srFileBrowser.BuildingData.LotContains.Count - 1);
        int number = 0;
        while (number <= num)
        {
          if (StringType.StrCmp(srFileBrowser.BuildingData.LotContains.get_item(number).DateiName, EingabeDatei, false) != 0)
          {
            srFileBrowser.BuildingData.LotContains.get_item(number).BuildingExemplarIndex = -1;
            this.ExemplarListe.AddLot(srFileBrowser.BuildingData.LotContains.get_item(number));
          }
          checked { ++number; }
        }
      }
      this.ExemplarListe.OrdneLotsZu();
      object obj;
      return obj;
    }

    private object LeseDaten(string EingabeDatei)
    {
      this.Cursor = Cursors.WaitCursor;
      Application.DoEvents();
      this.ResetAll(true);
      this.ExemplarListe = new SC4FileStorer();
      this.StatusBarPanel2.Text = "Reading";
      Application.DoEvents();
      string directoryName = new FileInfo(EingabeDatei).DirectoryName;
      this.ExemplarListe.GetOneFile(EingabeDatei);
      this.ExemplarListe.OrdneLotsZu();
      if (this.ExemplarListe.BuildingContains.Count == 0)
      {
        if (this.ExemplarListe.LotContains.Count != 0)
        {
          int num = checked (this.ExemplarListe.LotContains.Count - 1);
          int number = 0;
          while (number <= num)
          {
            if (this.ExemplarListe.LotContains.get_item(number).BuildingExemplarIndex == -1)
            {
              this.GetBuildingsFromOtherFiles(directoryName, EingabeDatei);
              break;
            }
            checked { ++number; }
          }
        }
        else
          goto label_16;
      }
      else if (this.ExemplarListe.LotContains.Count == 0)
      {
        this.GetBuildingsFromOtherFiles(directoryName, EingabeDatei);
      }
      else
      {
        int num = checked (this.ExemplarListe.LotContains.Count - 1);
        int number = 0;
        while (number <= num)
        {
          if (this.ExemplarListe.LotContains.get_item(number).BuildingExemplarIndex == -1)
          {
            this.GetBuildingsFromOtherFiles(directoryName, EingabeDatei);
            break;
          }
          checked { ++number; }
        }
      }
      this.FillTreeView(EingabeDatei);
      this.ShowProps();
      this.TextureListe = new TextureReader();
      this.TextureListe.GetTextures(EingabeDatei);
      this.ShowImages(EingabeDatei);
      this.StatusBarPanel2.Text = "Ready";
      this.Cursor = Cursors.Default;
label_16:
      object obj;
      return obj;
    }

    public object FillTreeView(string EingabeDatei)
    {
      TreeView treeView1 = this.TreeView1;
      treeView1.Nodes.Clear();
      treeView1.ImageList = this.ImageList1;
      treeView1.Nodes.Clear();
      treeView1.AllowDrop = false;
      treeView1.CheckBoxes = false;
      treeView1.FullRowSelect = true;
      treeView1.ShowLines = false;
      treeView1.ShowPlusMinus = false;
      treeView1.ShowRootLines = false;
      treeView1.HideSelection = false;
      treeView1.SuspendLayout();
      treeView1.BeginUpdate();
      int num1 = checked (this.ExemplarListe.BuildingContains.Count - 1);
      int num2 = 0;
      while (num2 <= num1)
      {
        TreeNode node = new TreeNode()
        {
          Tag = (object) this.GetLotsOfBuilding(num2),
          SelectedImageIndex = 19,
          ImageIndex = 17,
          Text = this.ExemplarListe.BuildingContains.get_item(num2).ExemplarName
        };
        node.ImageIndex = !node.Tag.ToString().EndsWith("-1") ? (!node.Tag.ToString().EndsWith("-2") ? 9 : 8) : 10;
        treeView1.Nodes.Add(node);
        checked { ++num2; }
      }
      if (this.ExemplarListe.LotContains.Count > 0)
      {
        int num3 = checked (this.ExemplarListe.LotContains.Count - 1);
        int number = 0;
        while (number <= num3)
        {
          if (this.ExemplarListe.LotContains.get_item(number).BuildingExemplarIndex == -1)
            treeView1.Nodes.Add(new TreeNode()
            {
              Tag = (object) ("-1#" + number.ToString()),
              SelectedImageIndex = 19,
              ImageIndex = 8,
              Text = this.ExemplarListe.LotContains.get_item(number).ExemplarName
            });
          checked { ++number; }
        }
      }
      treeView1.EndUpdate();
      object obj;
      return obj;
    }

    private string GetLotsOfBuilding(int BuildingIndex)
    {
      ArrayList arrayList = new ArrayList();
      string str = BuildingIndex.ToString() + "#-1";
      int num1 = this.ExemplarListe.LotBuildingArray2.IndexOf((object) BuildingIndex);
      if (num1 > -1)
      {
        int num2 = this.ExemplarListe.LotBuildingArray2.LastIndexOf((object) BuildingIndex);
        int num3 = num1;
        int num4 = num2;
        int index = num3;
        while (index <= num4)
        {
          if (ObjectType.ObjTst(this.ExemplarListe.LotBuildingArray2[index], (object) BuildingIndex, false) == 0)
            return BuildingIndex.ToString() + "#" + this.ExemplarListe.LotBuildingArray1[index].ToString();
          checked { ++index; }
        }
      }
      return str;
    }

    private object SearchForLotsAndBuildings(string EingabeDatei)
    {
      object obj;
      return obj;
    }

    private object FillInfoGrid()
    {
      sr_SourceGrid.VisualModels.Common common1 = new sr_SourceGrid.VisualModels.Common(false);
      common1.StringFormat.Trimming = StringTrimming.EllipsisCharacter;
      sr_SourceGrid.VisualModels.Common common2 = new sr_SourceGrid.VisualModels.Common(false);
      common2.BackColor = this.l_TitleModel.BackColor;
      common2.ForeColor = this.l_TitleModel.ForeColor;
      common2.ImageAlignment = SourceLibrary.Drawing.ContentAlignment.MiddleLeft;
      common2.TextAlignment = SourceLibrary.Drawing.ContentAlignment.MiddleLeft;
      common2.Font = new Font("Arial", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.InfoToolBar.Enabled = true;
      this.InfoGrid.Redim(0, 0);
      this.TeamZeile = -1;
      this.TeamSpalte = -1;
      this.AutorZeile = -1;
      this.AutorSpalte = -1;
      this.InfoGrid.ColumnsCount = 4;
      this.InfoGrid.FixedColumns = 1;
      this.InfoGrid.Columns[0].Width = 200;
      this.InfoGrid.Columns[1].Width = 300;
      this.InfoGrid.Columns[2].Width = 50;
      this.InfoGrid.Columns[3].Width = 50;
      this.SC4_BemBox1.Text = this.DBNotes;
      int num1 = 2;
      ICell cell1 = (ICell) new Cell((object) "Info", (IDataModel) null, (IVisualModel) common2);
      cell1.RowSpan = num1;
      cell1.ColumnSpan = this.InfoGrid.ColumnsCount;
      int rowsCount = this.InfoGrid.RowsCount;
      int num2 = num1;
      int num3 = 1;
      while (num3 <= num2)
      {
        this.InfoGrid.Rows.Insert(this.InfoGrid.RowsCount);
        checked { ++num3; }
      }
      this.InfoGrid[rowsCount, 0] = cell1;
      if (this.AktuellerBuildingIndex > -1)
      {
        this.InfoGrid.Rows.Insert(this.InfoGrid.RowsCount);
        this.InfoGrid[checked (this.InfoGrid.RowsCount - 1), 0] = (ICell) new Cell(RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[77]));
        ICell cell2 = (ICell) new Cell((object) this.ExemplarListe.BuildingContains.get_item(this.AktuellerBuildingIndex).SmallFileName, (IDataModel) null, (IVisualModel) common1);
        cell2.ToolTipText = StringType.FromObject(cell2.Value);
        this.InfoGrid[checked (this.InfoGrid.RowsCount - 1), 1] = cell2;
        this.InfoGrid.Rows.Insert(this.InfoGrid.RowsCount);
        this.InfoGrid[checked (this.InfoGrid.RowsCount - 1), 0] = (ICell) new Cell(RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[79]));
        ICell cell3 = (ICell) new Cell((object) this.ExemplarListe.BuildingContains.get_item(this.AktuellerBuildingIndex).DateCreated, (IDataModel) null, (IVisualModel) common1);
        cell3.ToolTipText = StringType.FromObject(cell3.Value);
        this.InfoGrid[checked (this.InfoGrid.RowsCount - 1), 1] = cell3;
        this.InfoGrid.Rows.Insert(this.InfoGrid.RowsCount);
        this.InfoGrid[checked (this.InfoGrid.RowsCount - 1), 0] = (ICell) new Cell(RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[80]));
        ICell cell4 = (ICell) new Cell((object) this.ExemplarListe.BuildingContains.get_item(this.AktuellerBuildingIndex).DateModified, (IDataModel) null, (IVisualModel) common1);
        cell4.ToolTipText = StringType.FromObject(cell4.Value);
        this.InfoGrid[checked (this.InfoGrid.RowsCount - 1), 1] = cell4;
      }
      if (this.AktuellerLotIndex > -1)
      {
        this.InfoGrid.Rows.Insert(this.InfoGrid.RowsCount);
        this.InfoGrid[checked (this.InfoGrid.RowsCount - 1), 0] = (ICell) new Cell(RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[78]));
        ICell cell5 = (ICell) new Cell((object) this.ExemplarListe.LotContains.get_item(this.AktuellerLotIndex).SmallFileName, (IDataModel) null, (IVisualModel) common1);
        cell5.ToolTipText = StringType.FromObject(cell5.Value);
        this.InfoGrid[checked (this.InfoGrid.RowsCount - 1), 1] = cell5;
        this.InfoGrid.Rows.Insert(this.InfoGrid.RowsCount);
        this.InfoGrid[checked (this.InfoGrid.RowsCount - 1), 0] = (ICell) new Cell(RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[79]));
        ICell cell6 = (ICell) new Cell((object) this.ExemplarListe.LotContains.get_item(this.AktuellerLotIndex).DateCreated, (IDataModel) null, (IVisualModel) common1);
        cell6.ToolTipText = StringType.FromObject(cell6.Value);
        this.InfoGrid[checked (this.InfoGrid.RowsCount - 1), 1] = cell6;
        this.InfoGrid.Rows.Insert(this.InfoGrid.RowsCount);
        this.InfoGrid[checked (this.InfoGrid.RowsCount - 1), 0] = (ICell) new Cell(RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[80]));
        ICell cell7 = (ICell) new Cell((object) this.ExemplarListe.LotContains.get_item(this.AktuellerLotIndex).DateModified, (IDataModel) null, (IVisualModel) common1);
        cell7.ToolTipText = StringType.FromObject(cell7.Value);
        this.InfoGrid[checked (this.InfoGrid.RowsCount - 1), 1] = cell7;
      }
      this.InfoGrid.Rows.Insert(this.InfoGrid.RowsCount);
      this.InfoGrid[checked (this.InfoGrid.RowsCount - 1), 0] = (ICell) new Cell(RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[83]));
      if (this.Sr_DepGrid1.DepResult.Count > 0)
      {
        ICell cell8 = (ICell) new Cell(RuntimeHelpers.GetObjectValue(this.Sr_DepGrid1.DepResult[0]), (IDataModel) null, (IVisualModel) common1);
        cell8.ToolTipText = StringType.FromObject(cell8.Value);
        this.InfoGrid[checked (this.InfoGrid.RowsCount - 1), 1] = cell8;
        int num4 = checked (this.Sr_DepGrid1.DepResult.Count - 1);
        int index = 0;
        while (index <= num4)
        {
          if (index > 0)
          {
            this.InfoGrid.Rows.Insert(this.InfoGrid.RowsCount);
            this.InfoGrid[checked (this.InfoGrid.RowsCount - 1), 0] = (ICell) new Cell((object) "", (IDataModel) null, (IVisualModel) common1);
          }
          ICell cell9 = (ICell) new Cell(RuntimeHelpers.GetObjectValue(this.Sr_DepGrid1.DepResult[index]), (IDataModel) null, (IVisualModel) common1);
          cell9.ToolTipText = StringType.FromObject(cell9.Value);
          this.InfoGrid[checked (this.InfoGrid.RowsCount - 1), 1] = cell9;
          checked { ++index; }
        }
      }
      else
      {
        ICell cell10 = (ICell) new Cell(RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[84]), (IDataModel) null, (IVisualModel) common1);
        cell10.ToolTipText = StringType.FromObject(cell10.Value);
        this.InfoGrid[checked (this.InfoGrid.RowsCount - 1), 1] = cell10;
      }
      this.InfoGrid.Rows.Insert(this.InfoGrid.RowsCount);
      this.InfoGrid[checked (this.InfoGrid.RowsCount - 1), 0] = (ICell) new Cell(RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[81]));
      ICell cell11 = (ICell) new Cell((object) this.DBAutor, (IDataModel) null, (IVisualModel) common1);
      cell11.ToolTipText = StringType.FromObject(cell11.Value);
      this.InfoGrid[checked (this.InfoGrid.RowsCount - 1), 1] = cell11;
      this.AutorZeile = checked (this.InfoGrid.RowsCount - 1);
      this.AutorSpalte = 1;
      this.InfoGrid.Rows.Insert(this.InfoGrid.RowsCount);
      this.InfoGrid[checked (this.InfoGrid.RowsCount - 1), 0] = (ICell) new Cell(RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[82]));
      ICell cell12 = (ICell) new Cell((object) this.DBTeam, (IDataModel) null, (IVisualModel) common1);
      cell12.ToolTipText = StringType.FromObject(cell12.Value);
      this.InfoGrid[checked (this.InfoGrid.RowsCount - 1), 1] = cell12;
      this.TeamZeile = checked (this.InfoGrid.RowsCount - 1);
      this.TeamSpalte = 1;
      if (this.DBBildDateiListe.Count > 0)
      {
        int num5 = checked (this.DBBildDateiListe.Count - 1);
        int index = 0;
        while (index <= num5)
        {
          this.AddPictureToInfoGrid(StringType.FromObject(this.DBBildDateiListe[index]), this.InfoGrid.RowsCount);
          checked { ++index; }
        }
      }
      object obj;
      return obj;
    }

    private object AddPictureToInfoGrid(string Filename, int RowPosition)
    {
      sr_SourceGrid.VisualModels.Common common1 = new sr_SourceGrid.VisualModels.Common();
      common1.Image = this.ImageList1.Images[4];
      common1.ImageAlignment = SourceLibrary.Drawing.ContentAlignment.MiddleCenter;
      sr_SourceGrid.VisualModels.Common common2 = new sr_SourceGrid.VisualModels.Common();
      common2.Image = this.ImageList1.Images[16];
      common2.ImageAlignment = SourceLibrary.Drawing.ContentAlignment.MiddleCenter;
      int row = RowPosition;
      int num1 = 2;
      sr_SourceGrid.VisualModels.Common common3 = new sr_SourceGrid.VisualModels.Common();
      common3.ImageAlignment = SourceLibrary.Drawing.ContentAlignment.MiddleLeft;
      sr_SourceGrid.VisualModels.Common common4 = new sr_SourceGrid.VisualModels.Common();
      common4.TextAlignment = SourceLibrary.Drawing.ContentAlignment.TopLeft;
      common4.StringFormat.Trimming = StringTrimming.EllipsisPath;
      ICell cell1 = (ICell) new Cell((object) Filename, (IDataModel) null, (IVisualModel) common4);
      ICell cell2 = (ICell) new Cell((object) "", (IDataModel) null, (IVisualModel) common3);
      FileInfo fileInfo = new FileInfo(Filename);
      Image image = (Image) null;
      if (fileInfo.Exists)
      {
        try
        {
          image = Image.FromFile(Filename);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        if (!Information.IsNothing((object) image))
        {
          common3.ImageAlignment = SourceLibrary.Drawing.ContentAlignment.TopLeft;
          common3.ImageStretch = false;
          common3.Image = image;
          num1 = checked ((int) Math.Round(unchecked ((double) checked (image.Height + 10) / (double) this.InfoGrid.Rows[checked (this.InfoGrid.RowsCount - 1)].Height + 0.5)));
          if (num1 < 2)
            num1 = 2;
          if (image.Width > this.InfoGrid.Columns[1].Width)
            this.InfoGrid.Columns[1].Width = image.Width;
        }
      }
      int num2 = num1;
      int num3 = 1;
      while (num3 <= num2)
      {
        this.InfoGrid.Rows.Insert(RowPosition);
        checked { ++RowPosition; }
        checked { ++num3; }
      }
      sr_SourceGrid.Cells.Real.Button button1 = new sr_SourceGrid.Cells.Real.Button((object) "", new PositionEventHandler(this.InfoGrid_NewButtonClick), (IVisualModel) common1, (IBehaviorModel) null);
      sr_SourceGrid.Cells.Real.Button button2 = new sr_SourceGrid.Cells.Real.Button((object) "", new PositionEventHandler(this.InfoGrid_DelButtonClick), (IVisualModel) common2, (IBehaviorModel) null);
      cell1.RowSpan = num1;
      cell1.ToolTipText = Filename;
      cell2.RowSpan = num1;
      this.InfoGrid[row, 0] = cell1;
      this.InfoGrid[row, 1] = cell2;
      this.InfoGrid[row, 2] = (ICell) button1;
      this.InfoGrid[row, 3] = (ICell) button2;
      object obj;
      return obj;
    }

    private void InfoGrid_NewButtonClick(object sender, PositionEventArgs e)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      if (e.Position.Row == checked (this.InfoGrid.RowsCount - 1))
        return;
      openFileDialog.Multiselect = false;
      openFileDialog.RestoreDirectory = true;
      openFileDialog.Title = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[144]);
      openFileDialog.ShowReadOnly = true;
      openFileDialog.CheckFileExists = true;
      openFileDialog.Filter = "Images (*.jpg;*.bmp;*.png)|*.jpg;*.bmp;*.png|All (*.*)|*.*";
      if (openFileDialog.ShowDialog() == DialogResult.OK)
      {
        FileInfo fileInfo = new FileInfo(openFileDialog.FileName);
        PictureBox pictureBox = new PictureBox();
        try
        {
          pictureBox.Image = Image.FromFile(openFileDialog.FileName);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          int num = (int) MessageBox.Show((IWin32Window) this, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[146]), "Images", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          ProjectData.ClearProjectError();
          return;
        }
        int row = e.Position.Row;
        int index = this.DBBildDateiListe.IndexOf((object) this.InfoGrid[row, 0].ToolTipText);
        if (index > -1)
        {
          this.DBBildDateiListe[index] = (object) openFileDialog.FileName;
          this.InfoGrid[row, 0].Value = (object) openFileDialog.FileName;
          int rowSpan = this.InfoGrid[row, 1].RowSpan;
          try
          {
            int num1 = rowSpan;
            int num2 = 1;
            while (num2 <= num1 && row != checked (this.InfoGrid.RowsCount - 2))
            {
              this.InfoGrid.Rows.Remove(row);
              checked { ++num2; }
            }
            this.AddPictureToInfoGrid(openFileDialog.FileName, row);
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
        }
        pictureBox.Dispose();
      }
    }

    private void InfoGrid_DelButtonClick(object sender, PositionEventArgs e)
    {
      if (e.Position.Row == checked (this.InfoGrid.RowsCount - 1) || MessageBox.Show((IWin32Window) this, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[131]), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[132]), MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
      int row = e.Position.Row;
      int index = this.DBBildDateiListe.IndexOf((object) this.InfoGrid[row, 0].ToolTipText);
      if (index > -1)
      {
        this.DBBildDateiListe.RemoveAt(index);
        this.InfoGrid[row, 0].Value = (object) "";
        int rowSpan = this.InfoGrid[row, 1].RowSpan;
        try
        {
          int num1 = rowSpan;
          int num2 = 1;
          while (num2 <= num1)
          {
            if (row != checked (this.InfoGrid.RowsCount - 2))
            {
              this.InfoGrid.Rows.Remove(row);
              checked { ++num2; }
            }
            else
              break;
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
    }

    private object ShowTabellenWerte(DataRow[] ResultRows, ArrayList TempArray)
    {
      try
      {
        string dateiName = this.ExemplarListe.BuildingContains.get_item(this.AktuellerBuildingIndex).DateiName;
        int lowerBound = ResultRows.GetLowerBound(0);
        int upperBound = ResultRows.GetUpperBound(0);
        int index1 = lowerBound;
        while (index1 <= upperBound)
        {
          int index2 = TempArray.IndexOf((object) ResultRows[index1]["member"].ToString().ToUpper());
          if (index2 > -1)
            MainFunctionClass.GebePropertyAus(this.AusgabeGrid, (MainReader.ExemplarValues) (this.ExemplarListe.BuildingContains.get_item(this.AktuellerBuildingIndex).Values[index2] ?? Activator.CreateInstance(typeof (MainReader.ExemplarValues))), ClassThisProg.DefReader.PropXMLReader, dateiName, 0);
          checked { ++index1; }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.AusgabeGrid.Rows.Add();
        this.AusgabeGrid[checked (this.AusgabeGrid.Rows.Count - 1), 0] = (object) "Error";
        ProjectData.ClearProjectError();
      }
      object obj;
      return obj;
    }

    private object ShowBuilding()
    {
      ArrayList arrayList1 = new ArrayList();
      ArrayList arrayList2 = new ArrayList();
      try
      {
        this.Cursor = Cursors.WaitCursor;
        this.Sr_DepGrid1.Clear();
        this.AusgabeGrid.Rows.Count = this.AusgabeGrid.Rows.Fixed;
        this.LotGrid.Rows.Count = this.LotGrid.Rows.Fixed;
        this.InfoToolButton4.Enabled = false;
        if (this.AktuellerBuildingIndex > -1 & this.AktuellerLotIndex > -1)
          this.InfoToolButton4.Enabled = true;
        if (this.AktuellerBuildingIndex > -1)
        {
          this.SC4_ToolButton2.Enabled = true;
          this.AusgabeGrid.Redraw = false;
          this.HeaderControl2.Text = this.ExemplarListe.BuildingContains.get_item(this.AktuellerBuildingIndex).SmallFileName;
          ArrayList TempArray = (ArrayList) this.ExemplarListe.BuildingContains.get_item(this.AktuellerBuildingIndex).KennungsListe.Clone();
          ArrayList arrayList3 = (ArrayList) TempArray.Clone();
          if (ClassThisProg.DefReader.GroupDefDataView.Table.Rows.Count > 0)
          {
            int num1 = checked (ClassThisProg.DefReader.GroupDefDataView.Table.Rows.Count - 1);
            int index1 = 0;
            while (index1 <= num1)
            {
              bool flag = false;
              string filterExpression = StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj((object) "group = '", ClassThisProg.DefReader.GroupDefDataView.Table.Rows[index1]["name"]), (object) "'"));
              DataRow[] ResultRows = ClassThisProg.DefReader.GroupMemberDataTable.Select(filterExpression);
              if (ResultRows.GetUpperBound(0) > -1)
              {
                int lowerBound = ResultRows.GetLowerBound(0);
                int upperBound = ResultRows.GetUpperBound(0);
                int index2 = lowerBound;
                while (index2 <= upperBound)
                {
                  int num2 = checked (TempArray.Count - 1);
                  int num3 = 0;
                  while (num3 <= num2)
                  {
                    int index3 = arrayList3.IndexOf((object) ResultRows[index2]["member"].ToString().ToUpper());
                    if (index3 > -1)
                    {
                      arrayList3.RemoveAt(index3);
                      flag = true;
                      break;
                    }
                    checked { ++num3; }
                  }
                  checked { ++index2; }
                }
                if (flag)
                {
                  string str = StringType.FromObject(ClassThisProg.DefReader.GroupDefDataView.Table.Rows[index1]["Image"]);
                  MainFunctionClass.WriteThemenHeader(this.AusgabeGrid, ClassThisProg.DefReader.ProgImageDir + "\\" + str, StringType.FromObject(ClassThisProg.DefReader.GroupDefDataView.Table.Rows[index1]["desc"]));
                  this.ShowTabellenWerte(ResultRows, TempArray);
                }
              }
              checked { ++index1; }
            }
          }
          this.AusgabeGrid.Redraw = true;
        }
        this.ShowLot();
        this.FillInfoGrid();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        if (!this.AusgabeGrid.Redraw)
          this.AusgabeGrid.Redraw = true;
        ProjectData.ClearProjectError();
      }
      this.Cursor = Cursors.Default;
      object obj;
      return obj;
    }

    private object ShowLot()
    {
      if (this.AktuellerLotIndex != -1)
      {
        int num = checked (this.ExemplarListe.LotContains.get_item(this.AktuellerLotIndex).Values.Count - 1);
        int index = 0;
        while (index <= num)
        {
          if (!LateBinding.LateGet(this.ExemplarListe.LotContains.get_item(this.AktuellerLotIndex).Values[index], (System.Type) null, "Kennung", new object[0], (string[]) null, (bool[]) null).ToString().ToUpper().StartsWith("0X88ED"))
          {
            if (!LateBinding.LateGet(this.ExemplarListe.LotContains.get_item(this.AktuellerLotIndex).Values[index], (System.Type) null, "Kennung", new object[0], (string[]) null, (bool[]) null).ToString().ToUpper().StartsWith("PARENTCOHORT") && !LateBinding.LateGet(this.ExemplarListe.LotContains.get_item(this.AktuellerLotIndex).Values[index], (System.Type) null, "Kennung", new object[0], (string[]) null, (bool[]) null).ToString().ToUpper().StartsWith("0X00000010"))
              MainFunctionClass.GebePropertyAus(this.LotGrid, (MainReader.ExemplarValues) (this.ExemplarListe.LotContains.get_item(this.AktuellerLotIndex).Values[index] ?? Activator.CreateInstance(typeof (MainReader.ExemplarValues))), ClassThisProg.DefReader.PropXMLReader, this.ExemplarListe.LotContains.get_item(this.AktuellerLotIndex).DateiName, 0);
          }
          else if (LateBinding.LateGet(this.ExemplarListe.LotContains.get_item(this.AktuellerLotIndex).Values[index], (System.Type) null, "Kennung", new object[0], (string[]) null, (bool[]) null).ToString().ToUpper().StartsWith("0X88EDC7"))
            MainFunctionClass.GebePropertyAus(this.LotGrid, (MainReader.ExemplarValues) (this.ExemplarListe.LotContains.get_item(this.AktuellerLotIndex).Values[index] ?? Activator.CreateInstance(typeof (MainReader.ExemplarValues))), ClassThisProg.DefReader.PropXMLReader, this.ExemplarListe.LotContains.get_item(this.AktuellerLotIndex).DateiName, 0);
          checked { ++index; }
        }
        this.Sr_DepGrid1.Clear();
        this.Sr_DepGrid1.Start(this.AktuellerLotIndex, this.ExemplarListe, ClassThisProg.DefReader.AllSmallFilesArray);
      }
      object obj;
      return obj;
    }

    private object ShowProps()
    {
      int count = this.PropGrid.Rows.Fixed;
      if (this.ExemplarListe.PropContains.Count > 0)
      {
        int num1 = checked (this.ExemplarListe.PropContains.Count - 1);
        int number = 0;
        while (number <= num1)
        {
          int num2 = checked (this.ExemplarListe.PropContains.get_item(number).Values.Count - 1);
          int index = 0;
          while (index <= num2)
          {
            if (!LateBinding.LateGet(this.ExemplarListe.PropContains.get_item(number).Values[index], (System.Type) null, "Kennung", new object[0], (string[]) null, (bool[]) null).ToString().ToUpper().StartsWith("PARENTCOHORT") && !LateBinding.LateGet(this.ExemplarListe.PropContains.get_item(number).Values[index], (System.Type) null, "Kennung", new object[0], (string[]) null, (bool[]) null).ToString().ToUpper().StartsWith("0X00000010") && !LateBinding.LateGet(this.ExemplarListe.PropContains.get_item(number).Values[index], (System.Type) null, "Kennung", new object[0], (string[]) null, (bool[]) null).ToString().ToUpper().StartsWith("0X00000020"))
              MainFunctionClass.GebePropertyAus(this.PropGrid, (MainReader.ExemplarValues) (this.ExemplarListe.PropContains.get_item(number).Values[index] ?? Activator.CreateInstance(typeof (MainReader.ExemplarValues))), ClassThisProg.DefReader.PropXMLReader, this.ExemplarListe.PropContains.get_item(number).DateiName, 1);
            checked { ++index; }
          }
          int num3 = count;
          int num4 = checked (this.PropGrid.Rows.Count - 1);
          int row = num3;
          while (row <= num4)
          {
            this.PropGrid[row, 0] = (object) this.ExemplarListe.PropContains.get_item(number).ExemplarName;
            checked { ++row; }
          }
          count = this.PropGrid.Rows.Count;
          checked { ++number; }
        }
        this.PropGrid.Cols[0].Visible = false;
        this.PropGrid.Tree.Column = 1;
        this.PropGrid.Tree.Style = TreeStyleFlags.SimpleLeaf;
        this.PropGrid.Subtotal(AggregateEnum.Clear);
        this.PropGrid.Subtotal(AggregateEnum.None, 0, 0, 0, "{0}");
      }
      object obj;
      return obj;
    }

    private object SetDefinitionen()
    {
      this.l_TitleModel.BackColor = Color.SteelBlue;
      this.l_TitleModel.ForeColor = Color.White;
      this.l_TitleModel.Font = this.Font;
      this.l_TitleModel.TextAlignment = SourceLibrary.Drawing.ContentAlignment.MiddleCenter;
      this.l_CaptionModel.BackColor = this.AusgabeGrid.BackColor;
      this.m_VisualModel1.ImageAlignment = SourceLibrary.Drawing.ContentAlignment.MiddleLeft;
      this.m_VisualModel1.AlignTextToImage = true;
      this.m_VisualModel1.BackColor = this.l_TitleModel.BackColor;
      this.m_VisualModel1.ForeColor = this.l_TitleModel.ForeColor;
      this.ellipsesModel.StringFormat.Trimming = StringTrimming.EllipsisCharacter;
      object obj;
      return obj;
    }

    private object SaveToHTML(C1.Win.C1FlexGrid.C1FlexGrid LeseGrid)
    {
      MainFunctionClass.SaveToHTML((Form) this, LeseGrid);
      object obj;
      return obj;
    }

    private object ResetAll(bool DelTree)
    {
      this.SC4_ToolButton1.Enabled = false;
      this.SC4_ToolButton2.Enabled = false;
      this.SC4_ToolButton3.Enabled = false;
      this.ButtonSearchBuilding.Enabled = false;
      this.ImagesToolBar.Enabled = false;
      this.InfoToolBar.Enabled = false;
      this.SchreibPicture = (cTexture) null;
      this.AusgabeGrid.Rows.Count = this.AusgabeGrid.Rows.Fixed;
      this.LotGrid.Rows.Count = this.LotGrid.Rows.Fixed;
      this.PropGrid.Rows.Count = this.PropGrid.Rows.Fixed;
      this.InfoGrid.Redim(0, 0);
      this.AutorZeile = -1;
      this.AutorSpalte = -1;
      this.TeamZeile = -1;
      this.TeamSpalte = -1;
      if (!Information.IsNothing((object) this.ExemplarListe))
        this.ExemplarListe.Clear();
      this.AktuellerDBIndex = -1;
      this.AktuellerBuildingIndex = -1;
      this.AktuellerLotIndex = -1;
      if (!Information.IsNothing((object) this.TextureListe))
        this.TextureListe.Dispose();
      this.HeaderControl2.Text = "<....>";
      this.TreeView1.Nodes.Clear();
      this.SC4_BemBox1.Text = "";
      object obj;
      return obj;
    }

    private bool LoescheAktuellenDatenSatz()
    {
      this.Cursor = Cursors.Default;
      bool flag;
      if (MessageBox.Show((IWin32Window) this, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[(int) sbyte.MaxValue]), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[132]), MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        flag = false;
      else if (this.AktuellerDBIndex < 0)
      {
        int num = (int) MessageBox.Show((IWin32Window) this, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[89]), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[57]), MessageBoxButtons.OK, MessageBoxIcon.Hand);
        flag = false;
      }
      else
      {
        try
        {
          string filterExpression = "ID = " + StringType.FromInteger(this.AktuellerDBIndex);
          DataRow[] dataRowArray = ClassThisProg.DefReader.DB_xmldoc.DataSet.Tables["BAT"].Select(filterExpression);
          if (dataRowArray.GetUpperBound(0) == 0)
            dataRowArray[0].Delete();
          ClassThisProg.DefReader.DB_xmldoc.Save(ClassThisProg.DefReader.DBXMLDatei);
          this.DBTreeView.Nodes.Remove(this.DBTreeView.SelectedNode);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          int num = (int) MessageBox.Show((IWin32Window) this, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[24]), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[17]), MessageBoxButtons.OK, MessageBoxIcon.Hand);
          flag = false;
          ProjectData.ClearProjectError();
          goto label_9;
        }
        flag = true;
      }
label_9:
      return flag;
    }

    private bool CheckName(string SuchName)
    {
      bool flag;
      try
      {
        string filterExpression = "Name = '" + SuchName + "'";
        if (ClassThisProg.DefReader.DB_xmldoc.DataSet.Tables["BAT"].Select(filterExpression).GetUpperBound(0) < 0)
        {
          flag = false;
          goto label_5;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        flag = true;
        ProjectData.ClearProjectError();
        goto label_5;
      }
      flag = true;
label_5:
      return flag;
    }

    private object UpdateDB()
    {
      string filterExpression = "ID = " + StringType.FromInteger(this.AktuellerDBIndex);
      DataRow[] dataRowArray = ClassThisProg.DefReader.DB_xmldoc.DataSet.Tables["BAT"].Select(filterExpression);
      if (dataRowArray.GetUpperBound(0) == 0)
      {
        DataRow[] childRows = dataRowArray[0].GetChildRows(ClassThisProg.DefReader.BATRelation, DataRowVersion.Default);
        if (childRows.GetUpperBound(0) > -1)
        {
          int upperBound = childRows.GetUpperBound(0);
          int index = 0;
          while (index <= upperBound)
          {
            childRows[index].Delete();
            checked { ++index; }
          }
        }
      }
      if (this.DBBildDateiListe.Count > 0)
      {
        int num = checked (this.DBBildDateiListe.Count - 1);
        int index = 0;
        while (index <= num)
        {
          DataRow row = ClassThisProg.DefReader.BATRelation.ChildTable.NewRow();
          row["Path"] = RuntimeHelpers.GetObjectValue(this.DBBildDateiListe[index]);
          row.SetParentRow(dataRowArray[0], ClassThisProg.DefReader.BATRelation);
          ClassThisProg.DefReader.BATRelation.ChildTable.Rows.Add(row);
          checked { ++index; }
        }
      }
      dataRowArray[0]["notes"] = (object) this.SC4_BemBox1.Text;
      dataRowArray[0]["Autor"] = (object) this.DBAutor;
      dataRowArray[0]["Team"] = (object) this.DBTeam;
      ClassThisProg.DefReader.DB_xmldoc.DataSet.Tables["BAT"].AcceptChanges();
      ClassThisProg.DefReader.DB_xmldoc.Save(ClassThisProg.DefReader.DBXMLDatei);
      object obj;
      return obj;
    }

    private object SaveToDB()
    {
      if (this.AktuellerBuildingIndex < 0)
      {
        int num1 = (int) MessageBox.Show((IWin32Window) this, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[89]), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[57]), MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      else
      {
        string str1 = Interaction.InputBox(StringType.FromObject(ClassThisProg.DefReader.LanguageArray[134]), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[150]), this.ExemplarListe.BuildingContains.get_item(this.AktuellerBuildingIndex).ExemplarName);
        if (StringType.StrCmp(str1, "", false) != 0)
        {
          if (this.CheckName(str1))
          {
            int num2 = (int) MessageBox.Show((IWin32Window) this, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[135]), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[17]), MessageBoxButtons.OK, MessageBoxIcon.Hand);
          }
          else
          {
            try
            {
              DataRow dataRow = ClassThisProg.DefReader.DB_xmldoc.DataSet.Tables["BAT"].NewRow();
              dataRow["Name"] = (object) str1;
              dataRow["BFile"] = (object) this.ExemplarListe.BuildingContains.get_item(this.AktuellerBuildingIndex).DateiName;
              string str2 = AllgemeineKlasse.FormatiereHexWert(this.ExemplarListe.BuildingContains.get_item(this.AktuellerBuildingIndex).Type) + "," + AllgemeineKlasse.FormatiereHexWert(this.ExemplarListe.BuildingContains.get_item(this.AktuellerBuildingIndex).Group) + "," + AllgemeineKlasse.FormatiereHexWert(this.ExemplarListe.BuildingContains.get_item(this.AktuellerBuildingIndex).Instance);
              dataRow["B_TGI"] = (object) str2;
              string str3;
              string str4;
              if (this.AktuellerLotIndex > -1)
              {
                str3 = this.ExemplarListe.LotContains.get_item(this.AktuellerLotIndex).DateiName;
                str4 = AllgemeineKlasse.FormatiereHexWert(this.ExemplarListe.LotContains.get_item(this.AktuellerLotIndex).Type) + "," + AllgemeineKlasse.FormatiereHexWert(this.ExemplarListe.LotContains.get_item(this.AktuellerLotIndex).Group) + "," + AllgemeineKlasse.FormatiereHexWert(this.ExemplarListe.LotContains.get_item(this.AktuellerLotIndex).Instance);
              }
              else
              {
                str3 = "";
                str4 = "";
              }
              dataRow["TFile"] = (object) str3;
              dataRow["L_TGI"] = (object) str4;
              dataRow["Autor"] = (object) this.DBAutor;
              dataRow["Team"] = (object) this.DBTeam;
              dataRow["notes"] = (object) this.SC4_BemBox1.Text;
              if (this.DBBildDateiListe.Count > 0)
              {
                int num3 = checked (this.DBBildDateiListe.Count - 1);
                int index = 0;
                while (index <= num3)
                {
                  DataRow row = ClassThisProg.DefReader.BATRelation.ChildTable.NewRow();
                  row["Path"] = RuntimeHelpers.GetObjectValue(this.DBBildDateiListe[index]);
                  row.SetParentRow(dataRow, ClassThisProg.DefReader.BATRelation);
                  ClassThisProg.DefReader.BATRelation.ChildTable.Rows.Add(row);
                  checked { ++index; }
                }
              }
              ClassThisProg.DefReader.DB_xmldoc.DataSet.Tables["BAT"].Rows.Add(dataRow);
              ClassThisProg.DefReader.DB_xmldoc.DataSet.Tables["BAT"].AcceptChanges();
              ClassThisProg.DefReader.DB_xmldoc.Save(ClassThisProg.DefReader.DBXMLDatei);
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              int num4 = (int) MessageBox.Show((IWin32Window) this, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[24]), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[17]), MessageBoxButtons.OK, MessageBoxIcon.Hand);
              ProjectData.ClearProjectError();
              goto label_15;
            }
            int num5 = (int) MessageBox.Show((IWin32Window) this, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[27]), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[17]), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          }
        }
      }
label_15:
      object obj;
      return obj;
    }

    private object FillTreeViewByAutor()
    {
      this.Cursor = Cursors.WaitCursor;
      this.StatusBarPanel2.Text = "Reading";
      Application.DoEvents();
      TreeView dbTreeView = this.DBTreeView;
      dbTreeView.Visible = false;
      dbTreeView.Nodes.Clear();
      dbTreeView.ImageList = this.ImageList1;
      dbTreeView.AllowDrop = false;
      dbTreeView.CheckBoxes = false;
      dbTreeView.FullRowSelect = true;
      dbTreeView.HideSelection = false;
      dbTreeView.SuspendLayout();
      dbTreeView.BeginUpdate();
      dbTreeView.ShowLines = true;
      dbTreeView.ShowPlusMinus = true;
      dbTreeView.ShowRootLines = true;
      int index1 = -1;
      int index2 = -1;
      string str1 = "8i(][po4444";
      DataRow[] dataRowArray = ClassThisProg.DefReader.DB_xmldoc.DataSet.Tables["BAT"].Select("ID > -1", "Autor");
      if (dataRowArray.GetUpperBound(0) > -1)
      {
        int upperBound = dataRowArray.GetUpperBound(0);
        int index3 = 0;
        while (index3 <= upperBound)
        {
          string str2 = StringType.FromObject(dataRowArray[index3]["Autor"]);
          if (StringType.StrCmp(str2, "", false) == 0)
            str2 = "<....>";
          if (StringType.StrCmp(str1.ToUpper(), str2.ToUpper(), false) != 0)
          {
            str1 = str2;
            checked { ++index1; }
            dbTreeView.Nodes.Add(new TreeNode(str2));
            dbTreeView.Nodes[index1].Tag = (object) "A";
            dbTreeView.Nodes[index1].SelectedImageIndex = 19;
            dbTreeView.Nodes[index1].ImageIndex = 17;
            index2 = -1;
          }
          checked { ++index2; }
          dbTreeView.Nodes[index1].Nodes.Add(new TreeNode(StringType.FromObject(dataRowArray[index3]["Name"])));
          dbTreeView.Nodes[index1].Nodes[index2].Tag = RuntimeHelpers.GetObjectValue(dataRowArray[index3]["ID"]);
          dbTreeView.Nodes[index1].Nodes[index2].SelectedImageIndex = 19;
          dbTreeView.Nodes[index1].Nodes[index2].ImageIndex = 17;
          checked { ++index3; }
        }
      }
      dbTreeView.EndUpdate();
      dbTreeView.Visible = true;
      this.Cursor = Cursors.Default;
      this.StatusBarPanel2.Text = "Ready";
      Application.DoEvents();
      object obj;
      return obj;
    }

    private object FillTreeViewByName()
    {
      this.Cursor = Cursors.WaitCursor;
      this.StatusBarPanel2.Text = "Reading";
      Application.DoEvents();
      TreeView dbTreeView = this.DBTreeView;
      dbTreeView.Visible = false;
      dbTreeView.Nodes.Clear();
      dbTreeView.ImageList = this.ImageList1;
      dbTreeView.AllowDrop = false;
      dbTreeView.CheckBoxes = false;
      dbTreeView.FullRowSelect = true;
      dbTreeView.HideSelection = false;
      dbTreeView.SuspendLayout();
      dbTreeView.BeginUpdate();
      dbTreeView.ShowLines = false;
      dbTreeView.ShowPlusMinus = false;
      dbTreeView.ShowRootLines = false;
      int index1 = 0;
      int index2 = -1;
      string str1 = "8i(][po4444";
      DataRow[] dataRowArray = ClassThisProg.DefReader.DB_xmldoc.DataSet.Tables["BAT"].Select("ID > -1", "Name");
      if (dataRowArray.GetUpperBound(0) > -1)
      {
        int upperBound = dataRowArray.GetUpperBound(0);
        int index3 = 0;
        while (index3 <= upperBound)
        {
          string str2 = StringType.FromObject(dataRowArray[index3]["Name"]);
          if (StringType.StrCmp(str2, "", false) == 0)
            str2 = "<....>";
          if (StringType.StrCmp(str1.ToUpper(), str2.ToUpper(), false) != 0)
          {
            str1 = str2;
            checked { ++index1; }
            dbTreeView.Nodes.Add(new TreeNode(str2));
            dbTreeView.Nodes[index1].Tag = (object) "A";
            dbTreeView.Nodes[index1].SelectedImageIndex = 19;
            dbTreeView.Nodes[index1].ImageIndex = 17;
            index2 = -1;
          }
          checked { ++index2; }
          dbTreeView.Nodes[index1].Nodes.Add(new TreeNode(StringType.FromObject(dataRowArray[index3]["Name"])));
          dbTreeView.Nodes[index1].Nodes[index2].Tag = RuntimeHelpers.GetObjectValue(dataRowArray[index3]["ID"]);
          dbTreeView.Nodes[index1].Nodes[index2].SelectedImageIndex = 19;
          dbTreeView.Nodes[index1].Nodes[index2].ImageIndex = 17;
          checked { ++index3; }
        }
      }
      dbTreeView.EndUpdate();
      dbTreeView.Visible = true;
      this.Cursor = Cursors.Default;
      this.StatusBarPanel2.Text = "Ready";
      Application.DoEvents();
      object obj;
      return obj;
    }

    public object SetzeTexte()
    {
      this.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[20]);
      this.dockBuilding.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[150]);
      this.dockLot.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[151]);
      this.dockDep.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[83]);
      this.dock2.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[75]);
      this.dock3.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[100]);
      this.dockTextures.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[341]);
      this.ToolButton1.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[3]);
      this.ToolButton2.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[16]);
      this.ToolButton3.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[72]);
      if (StringType.StrCmp(ClassThisProg.DefReader.SortierKriteriumBAT.ToUpper(), "N", false) == 0)
        this.ToolButton4.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[74]);
      else
        this.ToolButton4.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[73]);
      this.SC4_ToolButton1.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[69]);
      this.SC4_ToolButton2.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[63]);
      this.InfoToolButton1.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[85]);
      this.InfoToolButton2.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[63]);
      this.InfoToolButton3.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[86]);
      if (this.DBTreeView.Visible)
        this.InfoToolButton4.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[128]);
      else
        this.InfoToolButton4.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[23]);
      this.InfoToolButton5.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[(int) sbyte.MaxValue]);
      this.AutorDropDownMenu.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[81]);
      this.TeamDropDownMenu.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[82]);
      this.SC4_ToolButton3.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[507]);
      this.ButtonSearchBuilding.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[506]);
      object obj;
      return obj;
    }

    private void FormBAT_Load(object sender, EventArgs e)
    {
      sr_Userinterface.AendereFarben((Form) this, ClassThisProg.DefReader.FarbSchema);
      this.Sr_DepGrid1.Visible = true;
      this.Sr_DepGrid1.DepListe = ClassThisProg.DefReader.DepListe;
      this.SC4_ToolButton1.Enabled = false;
      this.SC4_ToolButton2.Enabled = false;
      this.SC4_ToolButton3.Enabled = false;
      this.ButtonSearchBuilding.Enabled = false;
      this.ToolButton3.Visible = ClassThisProg.DefReader.isDatabaseOpen;
      this.InfoToolButton4.Visible = ClassThisProg.DefReader.isDatabaseOpen;
      this.TreeView1.Visible = true;
      this.DBTreeView.Visible = false;
      this.ToolButton4.Enabled = false;
      this.InfoToolButton5.Enabled = false;
      this.AktuellerDBIndex = -1;
      this.SetzeTexte();
      this.SetDefinitionen();
      if (ClassThisProg.DefReader.DBAutorenListe.Count > 0)
      {
        int num = checked (ClassThisProg.DefReader.DBAutorenListe.Count - 1);
        int index = 0;
        while (index <= num)
        {
          MenuButtonItem[] menuButtonItemArray = new MenuButtonItem[checked (index + 1)];
          menuButtonItemArray[index] = new MenuButtonItem();
          menuButtonItemArray[index].Text = StringType.FromObject(ClassThisProg.DefReader.DBAutorenListe[index]);
          menuButtonItemArray[index].BeginGroup = true;
          if (index > 0)
            menuButtonItemArray[index].Tag = (object) menuButtonItemArray[index].Text;
          else
            menuButtonItemArray[index].Tag = (object) "Neu";
          this.AutorDropDownMenu.Items.Add((ToolbarItemBase) menuButtonItemArray[index]);
          menuButtonItemArray[index].Activate += new EventHandler(this.MenuAutorItem_Activate);
          checked { ++index; }
        }
      }
      if (ClassThisProg.DefReader.DBTeamListe.Count > 0)
      {
        int num = checked (ClassThisProg.DefReader.DBTeamListe.Count - 1);
        int index = 0;
        while (index <= num)
        {
          MenuButtonItem[] menuButtonItemArray = new MenuButtonItem[checked (index + 1)];
          menuButtonItemArray[index] = new MenuButtonItem();
          menuButtonItemArray[index].Text = StringType.FromObject(ClassThisProg.DefReader.DBTeamListe[index]);
          menuButtonItemArray[index].BeginGroup = true;
          if (index > 0)
            menuButtonItemArray[index].Tag = (object) menuButtonItemArray[index].Text;
          else
            menuButtonItemArray[index].Tag = (object) "Neu";
          this.TeamDropDownMenu.Items.Add((ToolbarItemBase) menuButtonItemArray[index]);
          menuButtonItemArray[index].Activate += new EventHandler(this.MenuTeamItem_Activate);
          checked { ++index; }
        }
      }
      this.InfoToolBar.Enabled = false;
      this.isLoading = false;
    }

    private void MenuTeamItem_Activate(object sender, EventArgs e)
    {
      if (ObjectType.ObjTst(LateBinding.LateGet(sender, (System.Type) null, "tag", new object[0], (string[]) null, (bool[]) null), (object) "Neu", false) != 0)
      {
        if (this.TeamZeile > -1)
        {
          this.InfoGrid[this.TeamZeile, this.TeamSpalte].Value = RuntimeHelpers.GetObjectValue(LateBinding.LateGet(sender, (System.Type) null, "Tag", new object[0], (string[]) null, (bool[]) null));
          this.DBTeam = StringType.FromObject(LateBinding.LateGet(sender, (System.Type) null, "tag", new object[0], (string[]) null, (bool[]) null));
          this.InfoGrid[this.TeamZeile, this.TeamSpalte].Value = (object) this.DBTeam;
        }
      }
      else
      {
        string sLeft = Interaction.InputBox(StringType.FromObject(ClassThisProg.DefReader.LanguageArray[134]), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[88]));
        if (StringType.StrCmp(sLeft, "", false) == 0)
          return;
        int num = checked (this.TeamDropDownMenu.Items.Count - 1);
        int index = 0;
        while (index <= num)
        {
          if (StringType.StrCmp(this.TeamDropDownMenu.Items[index].Text.ToUpper(), sLeft.ToUpper(), false) == 0)
            return;
          checked { ++index; }
        }
        int count = this.TeamDropDownMenu.Items.Count;
        MenuButtonItem[] menuButtonItemArray = new MenuButtonItem[checked (count + 1)];
        menuButtonItemArray[count] = new MenuButtonItem();
        menuButtonItemArray[count].Text = sLeft;
        menuButtonItemArray[count].BeginGroup = true;
        menuButtonItemArray[count].Tag = (object) menuButtonItemArray[count].Text;
        this.TeamDropDownMenu.Items.Add((ToolbarItemBase) menuButtonItemArray[count]);
        menuButtonItemArray[count].Activate += new EventHandler(this.MenuTeamItem_Activate);
        this.DBTeam = sLeft;
        this.InfoGrid[this.TeamZeile, this.TeamSpalte].Value = (object) this.DBTeam;
      }
    }

    private void MenuAutorItem_Activate(object sender, EventArgs e)
    {
      if (ObjectType.ObjTst(LateBinding.LateGet(sender, (System.Type) null, "tag", new object[0], (string[]) null, (bool[]) null), (object) "Neu", false) != 0)
      {
        if (this.AutorZeile > -1)
        {
          this.InfoGrid[this.AutorZeile, this.AutorSpalte].Value = RuntimeHelpers.GetObjectValue(LateBinding.LateGet(sender, (System.Type) null, "Tag", new object[0], (string[]) null, (bool[]) null));
          this.DBAutor = StringType.FromObject(LateBinding.LateGet(sender, (System.Type) null, "tag", new object[0], (string[]) null, (bool[]) null));
          this.InfoGrid[this.AutorZeile, this.AutorSpalte].Value = (object) this.DBAutor;
        }
      }
      else
      {
        string sLeft = Interaction.InputBox(StringType.FromObject(ClassThisProg.DefReader.LanguageArray[134]), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[87]));
        if (StringType.StrCmp(sLeft, "", false) == 0)
          return;
        int num = checked (this.AutorDropDownMenu.Items.Count - 1);
        int index = 0;
        while (index <= num)
        {
          if (StringType.StrCmp(this.AutorDropDownMenu.Items[index].Text.ToUpper(), sLeft.ToUpper(), false) == 0)
            return;
          checked { ++index; }
        }
        int count = this.AutorDropDownMenu.Items.Count;
        MenuButtonItem[] menuButtonItemArray = new MenuButtonItem[checked (count + 1)];
        menuButtonItemArray[count] = new MenuButtonItem();
        menuButtonItemArray[count].Text = sLeft;
        menuButtonItemArray[count].BeginGroup = true;
        menuButtonItemArray[count].Tag = (object) menuButtonItemArray[count].Text;
        this.AutorDropDownMenu.Items.Add((ToolbarItemBase) menuButtonItemArray[count]);
        menuButtonItemArray[count].Activate += new EventHandler(this.MenuAutorItem_Activate);
        this.DBAutor = sLeft;
        this.InfoGrid[this.AutorZeile, this.AutorSpalte].Value = (object) this.DBAutor;
      }
    }

    private void TreePanel_Resize(object sender, EventArgs e) => this.StatusBarPanel2.Width = checked ((int) Math.Round(unchecked ((double) this.TreePanel.Width + (double) this.Splitter1.Width / 2.0)));

    private void ToolButton1_Activate(object sender, EventArgs e) => this.Dispose();

    private void ToolButton2_Activate(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.RestoreDirectory = true;
      openFileDialog.Title = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[16]);
      openFileDialog.ShowReadOnly = true;
      openFileDialog.Filter = "SC4-Files (*.dat;*.sc4Lot;*.sc4desc)|*.dat;*.sc4Lot;*.sc4desc|All (*.*)|*.*";
      if (openFileDialog.ShowDialog() != DialogResult.OK)
        return;
      Application.DoEvents();
      this.TreeView1.Visible = true;
      this.DBTreeView.Visible = false;
      this.DBTreeView.Nodes.Clear();
      this.InfoToolButton4.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[23]);
      this.ToolButton4.Enabled = false;
      this.InfoToolButton5.Enabled = false;
      this.ResetAll(true);
      this.LeseDaten(openFileDialog.FileName);
    }

    private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
    {
      this.DBBildDateiListe.Clear();
      this.DBAutor = "";
      this.DBTeam = "";
      this.InfoToolButton4.Enabled = false;
      string[] strArray = e.Node.Tag.ToString().Split('#');
      if (strArray.GetUpperBound(0) != 1 || !(Information.IsNumeric((object) strArray[0]) & Information.IsNumeric((object) strArray[1])))
        return;
      this.AktuellerBuildingIndex = IntegerType.FromString(strArray[0]);
      this.AktuellerLotIndex = IntegerType.FromString(strArray[1]);
      if (this.AktuellerBuildingIndex == -1)
        this.SC4_ToolButton3.Enabled = true;
      else
        this.SC4_ToolButton3.Enabled = false;
      if (this.AktuellerLotIndex == -1)
        this.ButtonSearchBuilding.Enabled = true;
      else
        this.ButtonSearchBuilding.Enabled = false;
      if (this.AktuellerLotIndex > -1 & this.AktuellerBuildingIndex > -1)
        this.InfoToolButton4.Enabled = false;
      this.ShowBuilding();
    }

    private void DBTreeView_AfterSelect(object sender, TreeViewEventArgs e)
    {
      if (!Information.IsNumeric(RuntimeHelpers.GetObjectValue(e.Node.Tag)))
        return;
      this.ResetAll(false);
      this.AktuellerDBIndex = IntegerType.FromObject(e.Node.Tag);
      this.GetBuildingFromDB();
    }

    private void ToolButton4_Activate(object sender, EventArgs e)
    {
      this.ResetAll(true);
      if (ObjectType.ObjTst((object) this.ToolButton4.ToolTipText, ClassThisProg.DefReader.LanguageArray[74], false) == 0)
      {
        ClassThisProg.DefReader.SortierKriteriumBAT = "A";
        this.ToolButton4.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[73]);
        this.FillTreeViewByAutor();
      }
      else
      {
        ClassThisProg.DefReader.SortierKriteriumBAT = "N";
        this.ToolButton4.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[74]);
        this.FillTreeViewByName();
      }
    }

    private void ToolButton3_Activate(object sender, EventArgs e)
    {
      this.TreeView1.Visible = false;
      this.DBTreeView.Visible = true;
      this.InfoToolButton4.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[128]);
      this.ToolButton4.Enabled = true;
      this.InfoToolButton5.Enabled = true;
      this.ResetAll(true);
      if (StringType.StrCmp(ClassThisProg.DefReader.SortierKriteriumBAT, "N", false) == 0)
        this.FillTreeViewByName();
      else
        this.FillTreeViewByAutor();
    }

    private void InfoToolButton1_Activate(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      if (this.InfoGrid.RowsCount == 0)
        return;
      openFileDialog.Multiselect = false;
      openFileDialog.RestoreDirectory = true;
      openFileDialog.Title = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[144]);
      openFileDialog.ShowReadOnly = true;
      openFileDialog.CheckFileExists = true;
      openFileDialog.Filter = "Images (*.jpg;*.bmp;*.png)|*.jpg;*.bmp;*.png|All (*.*)|*.*";
      if (openFileDialog.ShowDialog() == DialogResult.OK)
      {
        FileInfo fileInfo = new FileInfo(openFileDialog.FileName);
        PictureBox pictureBox = new PictureBox();
        try
        {
          pictureBox.Image = Image.FromFile(openFileDialog.FileName);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          int num = (int) MessageBox.Show((IWin32Window) this, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[146]), "Images", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          ProjectData.ClearProjectError();
          return;
        }
        this.DBBildDateiListe.Add((object) openFileDialog.FileName);
        this.AddPictureToInfoGrid(openFileDialog.FileName, this.InfoGrid.RowsCount);
        pictureBox.Dispose();
      }
    }

    private void InfoToolButton4_Activate(object sender, EventArgs e)
    {
      if (this.AktuellerDBIndex > -1)
        this.UpdateDB();
      else
        this.SaveToDB();
    }

    private void InfoToolButton5_Activate(object sender, EventArgs e)
    {
      if (!this.LoescheAktuellenDatenSatz())
        return;
      this.ResetAll(false);
    }

    private void InfoToolButton3_Activate(object sender, EventArgs e)
    {
      if (this.AktuellerBuildingIndex > -1)
      {
        FileInfo fileInfo = new FileInfo(this.ExemplarListe.BuildingContains.get_item(this.AktuellerBuildingIndex).DateiName);
        if (!fileInfo.Exists)
          return;
        string directoryName = fileInfo.DirectoryName;
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.InitialDirectory = ClassThisProg.DefReader.TemplateDir;
        openFileDialog.Title = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[90]);
        openFileDialog.ShowReadOnly = true;
        openFileDialog.Filter = "Templates (*.htm;*.html)|*.htm;*.html|All (*.*)|*.*";
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
          Application.DoEvents();
          SaveFileDialog saveFileDialog = new SaveFileDialog();
          saveFileDialog.Filter = "HTML-Files (*.htm;*.html)|*.htm;*.html|All (*.*)|*.*";
          saveFileDialog.InitialDirectory = directoryName;
          saveFileDialog.CheckPathExists = true;
          saveFileDialog.CheckFileExists = false;
          saveFileDialog.AddExtension = true;
          saveFileDialog.Title = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[18]);
          if (saveFileDialog.ShowDialog() == DialogResult.OK)
            this.GenerateHTMLFromTemplate(openFileDialog.FileName, saveFileDialog.FileName);
        }
      }
    }

    private object GenerateHTMLFromTemplate(string EingabeDatei, string AusgabeDatei)
    {
      ArrayList TempArrayExemplar = new ArrayList();
      ArrayList TempArrayLot = new ArrayList();
      ArrayList arrayList1 = new ArrayList();
      ArrayList arrayList2 = new ArrayList();
      ArrayList arrayList3 = new ArrayList();
      string str1 = "";
      StreamReader streamReader;
      StreamWriter streamWriter;
      string dateiName;
      string fullName;
      try
      {
        streamReader = new StreamReader(EingabeDatei);
        streamWriter = new StreamWriter(AusgabeDatei);
        dateiName = this.ExemplarListe.BuildingContains.get_item(this.AktuellerBuildingIndex).DateiName;
        if (this.ExemplarListe.BuildingContains.get_item(this.AktuellerBuildingIndex).Values.Count > 0)
        {
          int num = checked (this.ExemplarListe.BuildingContains.get_item(this.AktuellerBuildingIndex).Values.Count - 1);
          int index = 0;
          while (index <= num)
          {
            TempArrayExemplar.Add(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(this.ExemplarListe.BuildingContains.get_item(this.AktuellerBuildingIndex).Values[index], (System.Type) null, "Kennung", new object[0], (string[]) null, (bool[]) null), (System.Type) null, "toupper", new object[0], (string[]) null, (bool[]) null)));
            checked { ++index; }
          }
        }
        if (this.AktuellerLotIndex > -1)
        {
          str1 = this.ExemplarListe.LotContains.get_item(this.AktuellerLotIndex).DateiName;
          if (this.ExemplarListe.LotContains.get_item(this.AktuellerLotIndex).Values.Count > 0)
          {
            int num = checked (this.ExemplarListe.LotContains.get_item(this.AktuellerLotIndex).Values.Count - 1);
            int index = 0;
            while (index <= num)
            {
              TempArrayLot.Add(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(this.ExemplarListe.LotContains.get_item(this.AktuellerLotIndex).Values[index], (System.Type) null, "Kennung", new object[0], (string[]) null, (bool[]) null), (System.Type) null, "toupper", new object[0], (string[]) null, (bool[]) null)));
              checked { ++index; }
            }
          }
        }
        DirectoryInfo directoryInfo = new DirectoryInfo(new FileInfo(AusgabeDatei).DirectoryName + "\\images");
        fullName = directoryInfo.FullName;
        if (!directoryInfo.Exists)
        {
          directoryInfo.Create();
        }
        else
        {
          FileInfo[] files = directoryInfo.GetFiles("*.*");
          int index = 0;
          while (index < files.Length)
          {
            files[index].Delete();
            checked { ++index; }
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) MessageBox.Show((IWin32Window) this, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[64]), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[63]), MessageBoxButtons.OK, MessageBoxIcon.Hand);
        ProjectData.ClearProjectError();
        goto label_97;
      }
      try
      {
        string LeseString;
        do
        {
          LeseString = streamReader.ReadLine();
          if (!Information.IsNothing((object) LeseString))
          {
            arrayList1.Clear();
            arrayList2.Clear();
            string str2 = LeseString;
            bool flag = true;
            bool isMulti = false;
            string[] strArray1 = new string[0];
            string RepString = "";
            arrayList1 = this.ParseString(LeseString, "[", "]");
            if (arrayList1.Count > 0)
            {
              int num1 = checked (arrayList1.Count - 1);
              int index1 = 0;
              while (index1 <= num1)
              {
                int index2 = -10;
                arrayList2.Add(RuntimeHelpers.GetObjectValue(arrayList1[index1]));
                string SuchWert = StringType.FromObject(arrayList1[index1]);
                if (SuchWert.ToUpper().StartsWith("IMAGE_"))
                {
                  string[] strArray2 = (string[]) LateBinding.LateGet(arrayList1[index1], (System.Type) null, "Split", new object[1]
                  {
                    (object) "_"
                  }, (string[]) null, (bool[]) null);
                  if (strArray2.GetUpperBound(0) == 1)
                  {
                    SuchWert = strArray2[0];
                    if (Information.IsNumeric((object) strArray2[1]))
                      index2 = checked (IntegerType.FromString(strArray2[1]) - 1);
                  }
                }
                string upper = SuchWert.ToUpper();
                if (StringType.StrCmp(upper, "B_FILE", false) == 0)
                  arrayList2[index1] = (object) dateiName;
                else if (StringType.StrCmp(upper, "L_FILE", false) == 0)
                  arrayList2[index1] = (object) str1;
                else if (StringType.StrCmp(upper, "NAME", false) == 0)
                  arrayList2[index1] = (object) this.ExemplarListe.BuildingContains.get_item(this.AktuellerBuildingIndex).ExemplarName;
                else if (StringType.StrCmp(upper, "AUTOR", false) == 0 || StringType.StrCmp(upper, "AUTHOR", false) == 0)
                  arrayList2[index1] = (object) this.DBAutor;
                else if (StringType.StrCmp(upper, "DESCRIPTION", false) == 0)
                {
                  string text = this.SC4_BemBox1.Text;
                  if (StringType.StrCmp(this.SC4_BemBox1.Text, "", false) != 0)
                    this.TranslateZeichen(ref text);
                  arrayList2[index1] = (object) text;
                }
                else if (StringType.StrCmp(upper, "DEPENDENCIES", false) == 0)
                {
                  if (this.Sr_DepGrid1.DepResult.Count > 0)
                  {
                    arrayList2[index1] = (object) "";
                    int num2 = checked (this.Sr_DepGrid1.DepResult.Count - 1);
                    int num3 = 0;
                    while (num3 <= num2)
                    {
                      string str3 = str2;
                      object[] objArray1 = new object[2]
                      {
                        ObjectType.StrCatObj(ObjectType.StrCatObj((object) "[", arrayList1[index1]), (object) "]"),
                        null
                      };
                      object[] objArray2 = objArray1;
                      ArrayList depResult = this.Sr_DepGrid1.DepResult;
                      ArrayList arrayList4 = depResult;
                      int index3 = num3;
                      int index4 = index3;
                      object objectValue = RuntimeHelpers.GetObjectValue(arrayList4[index4]);
                      objArray2[1] = objectValue;
                      object[] objArray3 = objArray1;
                      object[] args = objArray3;
                      bool[] flagArray = new bool[2]
                      {
                        false,
                        true
                      };
                      bool[] CopyBack = flagArray;
                      object obj = LateBinding.LateGet((object) str3, (System.Type) null, "Replace", args, (string[]) null, CopyBack);
                      if (flagArray[1])
                        depResult[index3] = RuntimeHelpers.GetObjectValue(objArray3[1]);
                      string str4 = StringType.FromObject(obj);
                      streamWriter.WriteLine(str4);
                      checked { ++num3; }
                    }
                    str2 = "";
                  }
                }
                else if (StringType.StrCmp(upper, "DATE", false) == 0)
                {
                  DateTime dateTime = DateAndTime.DateValue(StringType.FromDate(DateTime.Now));
                  try
                  {
                    arrayList2[index1] = (object) dateTime.ToString(ClassThisProg.DefReader.DatumsFormat);
                  }
                  catch (Exception ex)
                  {
                    ProjectData.SetProjectError(ex);
                    arrayList2[index1] = (object) dateTime.ToString("yyyy-MM-dd");
                    ProjectData.ClearProjectError();
                  }
                }
                else if (StringType.StrCmp(upper, "IMAGE", false) == 0)
                {
                  flag = false;
                  if (index2 > -1 && index2 <= checked (this.DBBildDateiListe.Count - 1))
                  {
                    string fileName = StringType.FromObject(this.DBBildDateiListe[index2]);
                    arrayList2[index1] = RuntimeHelpers.GetObjectValue(this.DBBildDateiListe[index2]);
                    FileInfo fileInfo = new FileInfo(fileName);
                    if (fileInfo.Exists)
                    {
                      string str5 = fullName + "\\" + fileInfo.Name;
                      if (!new FileInfo(str5).Exists)
                        fileInfo.CopyTo(str5);
                      string str6 = "\"images/" + fileInfo.Name + "\"";
                      arrayList2[index1] = (object) str6;
                    }
                  }
                }
                else
                  arrayList2[index1] = (object) this.SucheInExemplars(SuchWert, TempArrayExemplar, TempArrayLot, ref isMulti, ref RepString);
                if (StringType.StrCmp(str2, "", false) != 0)
                {
                  if (isMulti)
                  {
                    string[] strArray3 = (string[]) LateBinding.LateGet(arrayList2[index1], (System.Type) null, "split", new object[1]
                    {
                      (object) ","
                    }, (string[]) null, (bool[]) null);
                    if (strArray3.GetUpperBound(0) > -1)
                    {
                      int upperBound = strArray3.GetUpperBound(0);
                      int index5 = 0;
                      while (index5 <= upperBound)
                      {
                        string str7 = str2.Replace(StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj((object) "[", arrayList1[index1]), (object) "]")), strArray3[index5]);
                        if (index5 > 0 && StringType.StrCmp(RepString, "", false) != 0)
                          str7 = str7.Replace(RepString, "");
                        streamWriter.WriteLine(str7);
                        checked { ++index5; }
                      }
                      str2 = "";
                    }
                  }
                  else
                  {
                    string str8 = str2;
                    object[] objArray4 = new object[2]
                    {
                      ObjectType.StrCatObj(ObjectType.StrCatObj((object) "[", arrayList1[index1]), (object) "]"),
                      null
                    };
                    object[] objArray5 = objArray4;
                    ArrayList arrayList5 = arrayList2;
                    ArrayList arrayList6 = arrayList5;
                    int index6 = index1;
                    int index7 = index6;
                    object objectValue = RuntimeHelpers.GetObjectValue(arrayList6[index7]);
                    objArray5[1] = objectValue;
                    object[] objArray6 = objArray4;
                    object[] args = objArray6;
                    bool[] flagArray = new bool[2]
                    {
                      false,
                      true
                    };
                    bool[] CopyBack = flagArray;
                    object obj = LateBinding.LateGet((object) str8, (System.Type) null, "Replace", args, (string[]) null, CopyBack);
                    if (flagArray[1])
                      arrayList5[index6] = RuntimeHelpers.GetObjectValue(objArray6[1]);
                    str2 = StringType.FromObject(obj);
                  }
                }
                checked { ++index1; }
              }
            }
            if (flag)
            {
              arrayList1 = this.ParseString(str2, "<", ">");
              if (arrayList1.Count > 0)
              {
                int num4 = checked (arrayList1.Count - 1);
                int index = 0;
                while (index <= num4)
                {
                  if (arrayList1[index].ToString().ToUpper().StartsWith("IMG SRC"))
                  {
                    int num5 = arrayList1[index].ToString().IndexOf("=");
                    int num6 = arrayList1[index].ToString().IndexOf(".");
                    if (num6 > num5 && arrayList1[index].ToString().Length >= checked (num5 + 3))
                    {
                      string str9 = arrayList1[index].ToString().Substring(checked (num5 + 1), checked (num6 - num5 - 1)) + "." + arrayList1[index].ToString().Substring(checked (num6 + 1), 3);
                      string oldValue = arrayList1[index].ToString().Substring(checked (num5 + 1), checked (num6 - num5 - 1)) + "." + arrayList1[index].ToString().Substring(checked (num6 + 1), 3) + "\"";
                      string fileName = str9.Replace("\"", "").Replace("/", "\\");
                      FileInfo fileInfo1 = new FileInfo(new FileInfo(EingabeDatei).DirectoryName + "\\" + fileName);
                      if (fileInfo1.Exists)
                      {
                        FileInfo fileInfo2 = new FileInfo(fileName);
                        if (!fileInfo2.Exists)
                          fileInfo1.CopyTo(fileInfo2.FullName);
                        string newValue = "\"images/" + fileInfo1.Name + "\"";
                        str2 = str2.Replace(oldValue, newValue);
                      }
                    }
                  }
                  checked { ++index; }
                }
              }
            }
            streamWriter.WriteLine(str2);
          }
        }
        while (LeseString != null);
        streamReader.Close();
        streamWriter.Close();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) MessageBox.Show((IWin32Window) this, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[64]), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[63]), MessageBoxButtons.OK, MessageBoxIcon.Hand);
        ProjectData.ClearProjectError();
        goto label_97;
      }
      if (MessageBox.Show((IWin32Window) this, StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj(ClassThisProg.DefReader.LanguageArray[65], (object) " "), ClassThisProg.DefReader.LanguageArray[91])), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[63]), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        try
        {
          Shell.OpenFile(AusgabeDatei);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
label_97:
      object obj1;
      return obj1;
    }

    private object TranslateZeichen(ref string EingabeString)
    {
      int CharCode = 161;
      do
      {
        EingabeString = EingabeString.Replace(StringType.FromChar(Strings.Chr(CharCode)), "&#" + CharCode.ToString() + ";");
        checked { ++CharCode; }
      }
      while (CharCode <= (int) byte.MaxValue);
      object obj;
      return obj;
    }

    private string SucheInExemplars(
      string SuchWert,
      ArrayList TempArrayExemplar,
      ArrayList TempArrayLot,
      ref bool isMulti,
      ref string RepString)
    {
      ArrayList arrayList1 = new ArrayList();
      ArrayList WerteArray = new ArrayList();
      ArrayList OriWerteArray = new ArrayList();
      string str1 = "";
      int num1 = -1;
      bool HasPairs = false;
      if (SuchWert.ToUpper().StartsWith("0X"))
      {
        string[] strArray = SuchWert.Split('*');
        if (strArray.GetUpperBound(0) >= 1)
        {
          if (Information.IsNumeric((object) strArray[1]))
          {
            num1 = IntegerType.FromString(strArray[1]);
            SuchWert = strArray[0];
          }
          else if (StringType.StrCmp(strArray[1].ToUpper(), "RL", false) == 0)
          {
            isMulti = true;
            SuchWert = strArray[0];
            if (strArray.GetUpperBound(0) == 2)
              RepString = strArray[2];
          }
        }
      }
      int index1 = TempArrayExemplar.IndexOf((object) SuchWert.ToUpper());
      int num2;
      if (index1 > -1)
      {
        string str2 = "";
        SuchWert = StringType.FromObject(LateBinding.LateGet(this.ExemplarListe.BuildingContains.get_item(this.AktuellerBuildingIndex).Values[index1], (System.Type) null, "Kennung", new object[0], (string[]) null, (bool[]) null));
        if (num1 == -1)
        {
          int num3 = IntegerType.FromObject(ObjectType.SubObj(LateBinding.LateGet(LateBinding.LateGet(this.ExemplarListe.BuildingContains.get_item(this.AktuellerBuildingIndex).Values[index1], (System.Type) null, "Werte", new object[0], (string[]) null, (bool[]) null), (System.Type) null, "count", new object[0], (string[]) null, (bool[]) null), (object) 1));
          int num4 = 0;
          while (num4 <= num3)
          {
            ArrayList arrayList2 = WerteArray;
            object o = this.ExemplarListe.BuildingContains.get_item(this.AktuellerBuildingIndex).Values[index1];
            object[] objArray = new object[1]
            {
              (object) num4
            };
            object[] args = objArray;
            bool[] flagArray = new bool[1]{ true };
            bool[] CopyBack = flagArray;
            object obj = LateBinding.LateGet(o, (System.Type) null, "Werte", args, (string[]) null, CopyBack);
            if (flagArray[0])
              num4 = IntegerType.FromObject(objArray[0]);
            object objectValue = RuntimeHelpers.GetObjectValue(obj);
            arrayList2.Add(objectValue);
            checked { ++num4; }
          }
          int num5 = IntegerType.FromObject(ObjectType.SubObj(LateBinding.LateGet(LateBinding.LateGet(this.ExemplarListe.BuildingContains.get_item(this.AktuellerBuildingIndex).Values[index1], (System.Type) null, "originalWerte", new object[0], (string[]) null, (bool[]) null), (System.Type) null, "count", new object[0], (string[]) null, (bool[]) null), (object) 1));
          int num6 = 0;
          while (num6 <= num5)
          {
            ArrayList arrayList3 = OriWerteArray;
            object o = this.ExemplarListe.BuildingContains.get_item(this.AktuellerBuildingIndex).Values[index1];
            object[] objArray = new object[1]
            {
              (object) num6
            };
            object[] args = objArray;
            bool[] flagArray = new bool[1]{ true };
            bool[] CopyBack = flagArray;
            object obj = LateBinding.LateGet(o, (System.Type) null, "originalWerte", args, (string[]) null, CopyBack);
            if (flagArray[0])
              num6 = IntegerType.FromObject(objArray[0]);
            object objectValue = RuntimeHelpers.GetObjectValue(obj);
            arrayList3.Add(objectValue);
            checked { ++num6; }
          }
        }
        else
        {
          if (ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(this.ExemplarListe.BuildingContains.get_item(this.AktuellerBuildingIndex).Values[index1], (System.Type) null, "Werte", new object[0], (string[]) null, (bool[]) null), (System.Type) null, "count", new object[0], (string[]) null, (bool[]) null), (object) num1, false) <= 0)
            return SuchWert + " : not valid";
          ArrayList arrayList4 = WerteArray;
          object o1 = this.ExemplarListe.BuildingContains.get_item(this.AktuellerBuildingIndex).Values[index1];
          object[] objArray1 = new object[1]
          {
            (object) num1
          };
          object[] args1 = objArray1;
          bool[] flagArray1 = new bool[1]{ true };
          bool[] CopyBack1 = flagArray1;
          object obj1 = LateBinding.LateGet(o1, (System.Type) null, "Werte", args1, (string[]) null, CopyBack1);
          if (flagArray1[0])
            num1 = IntegerType.FromObject(objArray1[0]);
          object objectValue1 = RuntimeHelpers.GetObjectValue(obj1);
          arrayList4.Add(objectValue1);
          ArrayList arrayList5 = OriWerteArray;
          object o2 = this.ExemplarListe.BuildingContains.get_item(this.AktuellerBuildingIndex).Values[index1];
          object[] objArray2 = new object[1]
          {
            (object) num1
          };
          object[] args2 = objArray2;
          bool[] flagArray2 = new bool[1]{ true };
          bool[] CopyBack2 = flagArray2;
          object obj2 = LateBinding.LateGet(o2, (System.Type) null, "originalWerte", args2, (string[]) null, CopyBack2);
          if (flagArray2[0])
            num2 = IntegerType.FromObject(objArray2[0]);
          object objectValue2 = RuntimeHelpers.GetObjectValue(obj2);
          arrayList5.Add(objectValue2);
        }
        ArrayList werteFromDataSet = MainFunctionClass.GetWerteFromDataSet(SuchWert, WerteArray, OriWerteArray, ref HasPairs, this.ExemplarListe.BuildingContains.get_item(this.AktuellerBuildingIndex).Type);
        if (werteFromDataSet.Count > 0)
        {
          if (HasPairs)
          {
            int num7 = checked (werteFromDataSet.Count - 1);
            int index2 = 0;
            while (index2 <= num7)
            {
              if (checked (index2 + 1) <= checked (werteFromDataSet.Count - 1))
                str2 = StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj((object) (str2 + ","), werteFromDataSet[index2]), (object) " : "), werteFromDataSet[checked (index2 + 1)]));
              checked { index2 += 2; }
            }
          }
          else
          {
            int num8 = checked (werteFromDataSet.Count - 1);
            int index3 = 0;
            while (index3 <= num8)
            {
              str2 = StringType.FromObject(ObjectType.StrCatObj((object) (str2 + ","), werteFromDataSet[index3]));
              checked { ++index3; }
            }
          }
          if (str2.StartsWith(","))
            str2 = str2.Substring(1, checked (str2.Length - 1));
        }
        return str2;
      }
      int index4 = TempArrayLot.IndexOf((object) SuchWert.ToUpper());
      if (index4 > -1)
      {
        str1 = "";
        if (num1 > -1)
        {
          if (ObjectType.ObjTst((object) num1, ObjectType.SubObj(LateBinding.LateGet(LateBinding.LateGet(this.ExemplarListe.LotContains.get_item(this.AktuellerLotIndex).Values[index4], (System.Type) null, "Werte", new object[0], (string[]) null, (bool[]) null), (System.Type) null, "count", new object[0], (string[]) null, (bool[]) null), (object) 1), false) <= 0)
          {
            object o = this.ExemplarListe.LotContains.get_item(this.AktuellerLotIndex).Values[index4];
            object[] objArray = new object[1]
            {
              (object) num1
            };
            object[] args = objArray;
            bool[] flagArray = new bool[1]{ true };
            bool[] CopyBack = flagArray;
            object obj = LateBinding.LateGet(o, (System.Type) null, "Werte", args, (string[]) null, CopyBack);
            if (flagArray[0])
              num2 = IntegerType.FromObject(objArray[0]);
            str1 = obj.ToString();
          }
        }
        else
        {
          int num9 = IntegerType.FromObject(ObjectType.SubObj(LateBinding.LateGet(LateBinding.LateGet(this.ExemplarListe.LotContains.get_item(this.AktuellerLotIndex).Values[index4], (System.Type) null, "Werte", new object[0], (string[]) null, (bool[]) null), (System.Type) null, "count", new object[0], (string[]) null, (bool[]) null), (object) 1));
          int num10 = 0;
          while (num10 <= num9)
          {
            string str3 = str1;
            object o = this.ExemplarListe.LotContains.get_item(this.AktuellerLotIndex).Values[index4];
            object[] objArray = new object[1]
            {
              (object) num10
            };
            object[] args = objArray;
            bool[] flagArray = new bool[1]{ true };
            bool[] CopyBack = flagArray;
            object obj = LateBinding.LateGet(o, (System.Type) null, "Werte", args, (string[]) null, CopyBack);
            if (flagArray[0])
              num10 = IntegerType.FromObject(objArray[0]);
            string str4 = obj.ToString();
            str1 = str3 + "," + str4;
            checked { ++num10; }
          }
        }
        if (str1.StartsWith(","))
          str1 = str1.Substring(1, checked (str1.Length - 1));
        if (StringType.StrCmp(SuchWert.ToUpper(), "0X88EDC790", false) == 0)
          str1 = str1.Replace(",", " x ");
      }
      return str1;
    }

    private ArrayList ParseString(
      string LeseString,
      string StartZeichen,
      string EndZeichen)
    {
      ArrayList arrayList = new ArrayList();
      string[] strArray = LeseString.Split(Microsoft.VisualBasic.CompilerServices.CharType.FromString(StartZeichen));
      if (strArray.GetUpperBound(0) > 0)
      {
        int upperBound = strArray.GetUpperBound(0);
        int index = 0;
        while (index <= upperBound)
        {
          int length = strArray[index].IndexOf(EndZeichen);
          if (length > 0)
            arrayList.Add((object) strArray[index].Substring(0, length));
          checked { ++index; }
        }
      }
      return arrayList;
    }

    private void InfoToolButton2_Activate(object sender, EventArgs e)
    {
    }

    private void FormBAT_Closed(object sender, EventArgs e) => ClassThisProg.frmBAT = (FormBAT) null;

    private void SC4_ToolButton3_Activate(object sender, EventArgs e)
    {
      FormAddBuilding formAddBuilding = new FormAddBuilding("Building");
      if (formAddBuilding.ShowDialog((IWin32Window) this) == DialogResult.OK)
      {
        this.ExemplarListe.AddBuilding(formAddBuilding.ResultBuilding);
        TreeNode selectedNode = this.TreeView1.SelectedNode;
        string[] strArray = selectedNode.Tag.ToString().Split('#');
        selectedNode.Tag = (object) (StringType.FromDouble((double) this.ExemplarListe.BuildingContains.Count - DoubleType.FromString(1.ToString())) + "#" + strArray[1]);
        selectedNode.ImageIndex = 9;
        this.AktuellerBuildingIndex = checked (this.ExemplarListe.BuildingContains.Count - 1);
        this.ShowBuilding();
        this.SC4_ToolButton3.Enabled = false;
        this.ButtonSearchBuilding.Enabled = false;
        this.InfoToolButton4.Enabled = true;
      }
      formAddBuilding.Dispose();
    }

    private void ButtonSearchBuilding_Activate(object sender, EventArgs e)
    {
      FormAddBuilding formAddBuilding = new FormAddBuilding("Lot");
      if (formAddBuilding.ShowDialog((IWin32Window) this) == DialogResult.OK)
      {
        this.ExemplarListe.AddLot(formAddBuilding.ResultLot);
        TreeNode selectedNode = this.TreeView1.SelectedNode;
        string[] strArray = selectedNode.Tag.ToString().Split('#');
        selectedNode.Tag = (object) (strArray[0] + "#" + StringType.FromDouble((double) this.ExemplarListe.LotContains.Count - DoubleType.FromString(1.ToString())));
        selectedNode.ImageIndex = 9;
        this.AktuellerLotIndex = checked (this.ExemplarListe.LotContains.Count - 1);
        this.ShowLot();
        this.FillInfoGrid();
        this.SC4_ToolButton3.Enabled = false;
        this.ButtonSearchBuilding.Enabled = false;
        this.InfoToolButton4.Enabled = true;
      }
      formAddBuilding.Dispose();
    }

    private void SC4_ToolButton2_Activate(object sender, EventArgs e)
    {
      if (this.AusgabeGrid.Rows.Count <= this.AusgabeGrid.Rows.Fixed)
        return;
      MainFunctionClass.SaveToHTML((Form) this, this.AusgabeGrid);
    }

    private void ButtonItem1_Activate(object sender, EventArgs e)
    {
      if (this.LotGrid.Rows.Count <= this.LotGrid.Rows.Fixed)
        return;
      MainFunctionClass.SaveToHTML((Form) this, this.LotGrid);
    }

    private object ShowImages(string EingabeDatei)
    {
      ArrayList arrayList = new ArrayList();
      cTexture[] cTextureArray1 = new cTexture[0];
      this.Sr_TextureViewer1.Clear();
      this.SchreibPicture = (cTexture) null;
      this.ImagesToolBar.Enabled = false;
      try
      {
        arrayList.AddRange((ICollection) this.TextureListe.SelectTexture(EingabeDatei));
        if (arrayList.Count != 0)
        {
          cTexture[] cTextureArray2 = new cTexture[checked (arrayList.Count - 1 + 1)];
          arrayList.CopyTo((Array) cTextureArray2);
          if (cTextureArray2.GetUpperBound(0) > -1)
          {
            int upperBound = cTextureArray2.GetUpperBound(0);
            int index = 0;
            while (index <= upperBound)
            {
              ClassThisProg.DefReader.TextureListe.GetTextureImage(ref cTextureArray2[index]);
              this.Sr_TextureViewer1.GridNoRedraw();
              this.Sr_TextureViewer1.AddImage(cTextureArray2[index]);
              this.Sr_TextureViewer1.GridRedraw();
              checked { ++index; }
            }
            this.ImagesToolBar.Enabled = true;
          }
        }
        else
          goto label_9;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.ImagesToolBar.Enabled = false;
        ProjectData.ClearProjectError();
      }
label_9:
      object obj;
      return obj;
    }

    private object SavePicture(string SaveFormat)
    {
      ArrayList arrayList = new ArrayList();
      arrayList.Add((object) 8);
      arrayList.Add((object) 16);
      arrayList.Add((object) 32);
      arrayList.Add((object) 64);
      arrayList.Add((object) 128);
      if (Information.IsNothing((object) this.SchreibPicture))
      {
        int num1 = (int) MessageBox.Show((IWin32Window) this, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[71]), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[17]), MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      else
      {
        string upper = SaveFormat.ToUpper();
        ImageFormat format;
        string str1;
        if (StringType.StrCmp(upper, "BMP", false) == 0)
        {
          format = ImageFormat.Bmp;
          str1 = ".bmp";
        }
        else if (StringType.StrCmp(upper, "JPG", false) == 0 || StringType.StrCmp(upper, "JPEG", false) == 0)
        {
          format = ImageFormat.Jpeg;
          str1 = ".jpg";
        }
        else if (StringType.StrCmp(upper, "PNG", false) == 0)
        {
          format = ImageFormat.Png;
          str1 = ".png";
        }
        else if (StringType.StrCmp(upper, "TIF", false) == 0)
        {
          format = ImageFormat.Tiff;
          str1 = ".tif";
        }
        else if (StringType.StrCmp(upper, "WMF", false) == 0)
        {
          format = ImageFormat.Wmf;
          str1 = ".wmf";
        }
        else if (StringType.StrCmp(upper, "GIF", false) == 0)
        {
          format = ImageFormat.Gif;
          str1 = ".gif";
        }
        try
        {
          int num2 = checked (arrayList.Count - 1);
          int index = 0;
          while (index <= num2)
          {
            TextureReader.TextureImage textureImage = this.TextureListe.SelectTextureWithImage(this.SchreibPicture.FileName, this.SchreibPicture.Gruppe, IntegerType.FromObject(arrayList[index]));
            if (!Information.IsNothing((object) textureImage.Instance))
            {
              string str2 = ClassThisProg.DefReader.ExportDir + "\\" + textureImage.Instance + str1;
              FileInfo fileInfo = new FileInfo(str2);
              if (fileInfo.Exists)
                fileInfo.Delete();
              Image textureBitmap = (Image) textureImage.TextureBitmap;
              FileStream fileStream = new FileStream(str2, FileMode.Create, FileAccess.Write);
              textureBitmap.Save((Stream) fileStream, format);
              fileStream.Close();
            }
            checked { ++index; }
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          int num3 = (int) MessageBox.Show((IWin32Window) this, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[71]), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[17]), MessageBoxButtons.OK, MessageBoxIcon.Hand);
          ProjectData.ClearProjectError();
          goto label_24;
        }
        int num4 = (int) MessageBox.Show((IWin32Window) this, StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj(ClassThisProg.DefReader.LanguageArray[70], (object) " "), (object) ClassThisProg.DefReader.ExportDir)), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[17]), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
label_24:
      object obj;
      return obj;
    }

    private void ImageToolButton2_Activate(object sender, EventArgs e)
    {
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      saveFileDialog.Filter = "htm (*.htm)|*.htm";
      saveFileDialog.InitialDirectory = ClassThisProg.DefReader.ExportDir;
      saveFileDialog.CheckPathExists = true;
      saveFileDialog.CheckFileExists = false;
      saveFileDialog.AddExtension = true;
      saveFileDialog.Title = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[18]);
      if (saveFileDialog.ShowDialog() != DialogResult.OK)
        return;
      if (!this.Sr_TextureViewer1.SaveToHTML(saveFileDialog.FileName))
      {
        int num1 = (int) MessageBox.Show((IWin32Window) this, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[64]), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[17]), MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      else
      {
        int num2 = (int) MessageBox.Show((IWin32Window) this, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[65]), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[17]), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
    }

    private void ImageMenuItem1_Activate(object sender, EventArgs e) => this.SavePicture(this.ImageMenuItem1.Text);

    private void ImageMenuItem2_Activate(object sender, EventArgs e) => this.SavePicture(this.ImageMenuItem2.Text);

    private void ImageMenuItem3_Activate(object sender, EventArgs e) => this.SavePicture(this.ImageMenuItem3.Text);

    private void ImageMenuItem4_Activate(object sender, EventArgs e) => this.SavePicture(this.ImageMenuItem4.Text);

    private void ImageMenuItem5_Activate(object sender, EventArgs e) => this.SavePicture(this.ImageMenuItem5.Text);

    private void ImageMenuItem6_Activate(object sender, EventArgs e) => this.SavePicture(this.ImageMenuItem6.Text);
  }
}
