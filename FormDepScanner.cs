// Decompiled with JetBrains decompiler
// Type: SC4Tool.FormDepScanner
// Assembly: SC4Tool, Version=2.2.7.0, Culture=neutral, PublicKeyToken=null
// MVID: 69A50BC4-87A5-4C5E-BEFC-08274BC6D498
// Assembly location: C:\Program Files (x86)\SC4 Utilities\SC4Tool\SC4Tool.exe

using C1.Win.C1FlexGrid;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using sr_SC4Lib;
using sr_SourceGrid;
using sr_SourceGrid.VisualModels;
using System;
using System.Collections;
using System.ComponentModel;
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
  public class FormDepScanner : Form
  {
    [AccessedThroughProperty("Panel1")]
    private Panel _Panel1;
    [AccessedThroughProperty("Splitter1")]
    private Splitter _Splitter1;
    [AccessedThroughProperty("Sr_DepGrid1")]
    private sr_DepGrid _Sr_DepGrid1;
    [AccessedThroughProperty("MenuButtonItemPersonal")]
    private MenuButtonItem _MenuButtonItemPersonal;
    [AccessedThroughProperty("ErrorGrid")]
    private C1.Win.C1FlexGrid.C1FlexGrid _ErrorGrid;
    [AccessedThroughProperty("MenuButtonCommon")]
    private MenuButtonItem _MenuButtonCommon;
    [AccessedThroughProperty("AusgabePanel")]
    private Panel _AusgabePanel;
    [AccessedThroughProperty("MenuButtonItemAll")]
    private MenuButtonItem _MenuButtonItemAll;
    [AccessedThroughProperty("ToolBar1")]
    private TD.SandBar.ToolBar _ToolBar1;
    [AccessedThroughProperty("ButtonCreateReport")]
    private ButtonItem _ButtonCreateReport;
    [AccessedThroughProperty("StatusBar1")]
    private StatusBar _StatusBar1;
    [AccessedThroughProperty("ImagesToolBar")]
    private TD.SandBar.ToolBar _ImagesToolBar;
    [AccessedThroughProperty("StatusBarPanel1")]
    private StatusBarPanel _StatusBarPanel1;
    [AccessedThroughProperty("ImageToolButton2")]
    private ButtonItem _ImageToolButton2;
    [AccessedThroughProperty("MenuButtonItem5")]
    private MenuButtonItem _MenuButtonItem5;
    [AccessedThroughProperty("MenuButtonItem2")]
    private MenuButtonItem _MenuButtonItem2;
    [AccessedThroughProperty("MenuButtonItem1")]
    private MenuButtonItem _MenuButtonItem1;
    [AccessedThroughProperty("StatusBarPanel2")]
    private StatusBarPanel _StatusBarPanel2;
    [AccessedThroughProperty("ImageList1")]
    private ImageList _ImageList1;
    [AccessedThroughProperty("HeaderControl2")]
    private HeaderControl _HeaderControl2;
    [AccessedThroughProperty("TreeView1")]
    private TreeView _TreeView1;
    [AccessedThroughProperty("ButtonClearSelection")]
    private ButtonItem _ButtonClearSelection;
    [AccessedThroughProperty("DropDownMenuItem1")]
    private DropDownMenuItem _DropDownMenuItem1;
    [AccessedThroughProperty("ButtonItem1")]
    private ButtonItem _ButtonItem1;
    private IContainer components;
    private Common LeftModel;
    private Common CenterModel;
    private SC4FileStorer BuildingListe;
    private Common LeftTitelModel;
    private ArrayList LinkArray;
    private bool isLoading;
    private ArrayList AuswahlArray;
    private ArrayList ErrorArray;

    public FormDepScanner()
    {
      this.Closed += new EventHandler(this.FormDepScanner_Closed);
      this.Load += new EventHandler(this.FormDepScanner_Load);
      this.BuildingListe = new SC4FileStorer();
      this.LinkArray = new ArrayList();
      this.isLoading = true;
      this.AuswahlArray = new ArrayList();
      this.ErrorArray = new ArrayList();
      this.InitializeComponent();
      if (!ClassThisProg.DefReader.HasReadDeps && ClassThisProg.frmProgress == null)
      {
        ClassThisProg.frmProgress = new FormProgress("D");
        ClassThisProg.frmProgress.MdiParent = (Form) ClassThisProg.frmMain;
        int num = (int) ClassThisProg.frmProgress.ShowDialog();
      }
      C1.Win.C1FlexGrid.C1FlexGrid errorGrid = this.ErrorGrid;
      errorGrid.AllowDragging = AllowDraggingEnum.None;
      errorGrid.AllowSorting = AllowSortingEnum.None;
      errorGrid.AllowMerging = AllowMergingEnum.Free;
      errorGrid.AllowEditing = false;
      errorGrid.AllowResizing = AllowResizingEnum.Columns;
      errorGrid.HighLight = HighLightEnum.WithFocus;
      errorGrid.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
      errorGrid.SelectionMode = SelectionModeEnum.Cell;
      errorGrid.Styles.Fixed.BackColor = Color.SteelBlue;
      errorGrid.Styles.Fixed.ForeColor = Color.White;
      errorGrid.Styles.Fixed.TextAlign = TextAlignEnum.LeftCenter;
      errorGrid.Styles.Add("LeftTitel");
      errorGrid.Styles["LeftTitel"].TextAlign = TextAlignEnum.LeftCenter;
      errorGrid.Styles["LeftTitel"].BackColor = Color.SteelBlue;
      errorGrid.Styles["LeftTitel"].ForeColor = Color.White;
      errorGrid.Styles.Normal.Font = this.Font;
      errorGrid.Styles.Normal.TextAlign = TextAlignEnum.LeftCenter;
      errorGrid.Styles.Alternate.BackColor = errorGrid.Styles.Frozen.BackColor;
      errorGrid.Rows.Count = 1;
      errorGrid.Rows.Fixed = 1;
      errorGrid.Cols.Count = 2;
      errorGrid.Cols.Fixed = 0;
      errorGrid.Cols[0].Width = 500;
      errorGrid.Cols[1].Width = 300;
      errorGrid.SetData(checked (errorGrid.Rows.Count - 1), 0, (object) "Report");
      errorGrid.Tree.Column = 0;
      errorGrid.Tree.Style = TreeStyleFlags.Simple;
      errorGrid.AllowMerging = AllowMergingEnum.Nodes;
    }

    protected override void Dispose(bool disposing)
    {
      if (!Information.IsNothing((object) this.BuildingListe))
        this.BuildingListe.Dispose();
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
      ClassThisProg.frmDepScanner = (FormDepScanner) null;
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
      get => this._StatusBarPanel1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._StatusBarPanel1 == null)
          ;
        this._StatusBarPanel1 = value;
        if (this._StatusBarPanel1 == null)
          ;
      }
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

    internal virtual Panel Panel1
    {
      get => this._Panel1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Panel1 != null)
          this._Panel1.Resize -= new EventHandler(this.Panel1_Resize);
        this._Panel1 = value;
        if (this._Panel1 == null)
          return;
        this._Panel1.Resize += new EventHandler(this.Panel1_Resize);
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

    internal virtual ButtonItem ButtonItem1
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ButtonItem1 != null)
          this._ButtonItem1.Activate -= new EventHandler(this.ButtonItem1_Activate_1);
        this._ButtonItem1 = value;
        if (this._ButtonItem1 == null)
          return;
        this._ButtonItem1.Activate += new EventHandler(this.ButtonItem1_Activate_1);
      }
      get => this._ButtonItem1;
    }

    internal virtual DropDownMenuItem DropDownMenuItem1
    {
      get => this._DropDownMenuItem1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._DropDownMenuItem1 == null)
          ;
        this._DropDownMenuItem1 = value;
        if (this._DropDownMenuItem1 == null)
          ;
      }
    }

    internal virtual MenuButtonItem MenuButtonItem1
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuButtonItem1 == null)
          ;
        this._MenuButtonItem1 = value;
        if (this._MenuButtonItem1 == null)
          ;
      }
      get => this._MenuButtonItem1;
    }

    internal virtual MenuButtonItem MenuButtonItemAll
    {
      get => this._MenuButtonItemAll;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuButtonItemAll != null)
          this._MenuButtonItemAll.Activate -= new EventHandler(this.MenuButtonItemAll_Activate);
        this._MenuButtonItemAll = value;
        if (this._MenuButtonItemAll == null)
          return;
        this._MenuButtonItemAll.Activate += new EventHandler(this.MenuButtonItemAll_Activate);
      }
    }

    internal virtual MenuButtonItem MenuButtonCommon
    {
      get => this._MenuButtonCommon;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuButtonCommon != null)
          this._MenuButtonCommon.Activate -= new EventHandler(this.MenuButtonCommon_Activate);
        this._MenuButtonCommon = value;
        if (this._MenuButtonCommon == null)
          return;
        this._MenuButtonCommon.Activate += new EventHandler(this.MenuButtonCommon_Activate);
      }
    }

    internal virtual MenuButtonItem MenuButtonItemPersonal
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuButtonItemPersonal != null)
          this._MenuButtonItemPersonal.Activate -= new EventHandler(this.MenuButtonItemPersonal_Activate);
        this._MenuButtonItemPersonal = value;
        if (this._MenuButtonItemPersonal == null)
          return;
        this._MenuButtonItemPersonal.Activate += new EventHandler(this.MenuButtonItemPersonal_Activate);
      }
      get => this._MenuButtonItemPersonal;
    }

    internal virtual MenuButtonItem MenuButtonItem2
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuButtonItem2 != null)
          this._MenuButtonItem2.Activate -= new EventHandler(this.MenuButtonItem2_Activate);
        this._MenuButtonItem2 = value;
        if (this._MenuButtonItem2 == null)
          return;
        this._MenuButtonItem2.Activate += new EventHandler(this.MenuButtonItem2_Activate);
      }
      get => this._MenuButtonItem2;
    }

    internal virtual MenuButtonItem MenuButtonItem5
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuButtonItem5 != null)
          this._MenuButtonItem5.Activate -= new EventHandler(this.MenuButtonItem5_Activate);
        this._MenuButtonItem5 = value;
        if (this._MenuButtonItem5 == null)
          return;
        this._MenuButtonItem5.Activate += new EventHandler(this.MenuButtonItem5_Activate);
      }
      get => this._MenuButtonItem5;
    }

    internal virtual ButtonItem ButtonCreateReport
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ButtonCreateReport != null)
          this._ButtonCreateReport.Activate -= new EventHandler(this.ButtonCreateReport_Activate);
        this._ButtonCreateReport = value;
        if (this._ButtonCreateReport == null)
          return;
        this._ButtonCreateReport.Activate += new EventHandler(this.ButtonCreateReport_Activate);
      }
      get => this._ButtonCreateReport;
    }

    internal virtual ButtonItem ButtonClearSelection
    {
      get => this._ButtonClearSelection;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ButtonClearSelection != null)
          this._ButtonClearSelection.Activate -= new EventHandler(this.ButtonClearSelection_Activate);
        this._ButtonClearSelection = value;
        if (this._ButtonClearSelection == null)
          return;
        this._ButtonClearSelection.Activate += new EventHandler(this.ButtonClearSelection_Activate);
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
      get => this._ImageToolButton2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ImageToolButton2 != null)
          this._ImageToolButton2.Activate -= new EventHandler(this.ImageToolButton2_Activate);
        this._ImageToolButton2 = value;
        if (this._ImageToolButton2 == null)
          return;
        this._ImageToolButton2.Activate += new EventHandler(this.ImageToolButton2_Activate);
      }
    }

    internal virtual Panel AusgabePanel
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._AusgabePanel == null)
          ;
        this._AusgabePanel = value;
        if (this._AusgabePanel == null)
          ;
      }
      get => this._AusgabePanel;
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

    internal virtual C1.Win.C1FlexGrid.C1FlexGrid ErrorGrid
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ErrorGrid == null)
          ;
        this._ErrorGrid = value;
        if (this._ErrorGrid == null)
          ;
      }
      get => this._ErrorGrid;
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      ResourceManager resourceManager = new ResourceManager(typeof (FormDepScanner));
      this.StatusBar1 = new StatusBar();
      this.StatusBarPanel1 = new StatusBarPanel();
      this.StatusBarPanel2 = new StatusBarPanel();
      this.ImageList1 = new ImageList(this.components);
      this.Panel1 = new Panel();
      this.TreeView1 = new TreeView();
      this.ToolBar1 = new TD.SandBar.ToolBar();
      this.ButtonItem1 = new ButtonItem();
      this.DropDownMenuItem1 = new DropDownMenuItem();
      this.MenuButtonItem1 = new MenuButtonItem();
      this.MenuButtonItemAll = new MenuButtonItem();
      this.MenuButtonCommon = new MenuButtonItem();
      this.MenuButtonItemPersonal = new MenuButtonItem();
      this.MenuButtonItem2 = new MenuButtonItem();
      this.MenuButtonItem5 = new MenuButtonItem();
      this.ButtonCreateReport = new ButtonItem();
      this.ButtonClearSelection = new ButtonItem();
      this.Splitter1 = new Splitter();
      this.HeaderControl2 = new HeaderControl();
      this.AusgabePanel = new Panel();
      this.Sr_DepGrid1 = new sr_DepGrid();
      this.ImagesToolBar = new TD.SandBar.ToolBar();
      this.ImageToolButton2 = new ButtonItem();
      this.ErrorGrid = new C1.Win.C1FlexGrid.C1FlexGrid();
      this.StatusBarPanel1.BeginInit();
      this.StatusBarPanel2.BeginInit();
      this.Panel1.SuspendLayout();
      this.HeaderControl2.SuspendLayout();
      this.AusgabePanel.SuspendLayout();
      this.ErrorGrid.BeginInit();
      this.SuspendLayout();
      StatusBar statusBar1_1 = this.StatusBar1;
      Point point1 = new Point(0, 539);
      Point point2 = point1;
      statusBar1_1.Location = point2;
      this.StatusBar1.Name = "StatusBar1";
      this.StatusBar1.Panels.AddRange(new StatusBarPanel[2]
      {
        this.StatusBarPanel1,
        this.StatusBarPanel2
      });
      this.StatusBar1.ShowPanels = true;
      StatusBar statusBar1_2 = this.StatusBar1;
      Size size1 = new Size(782, 24);
      Size size2 = size1;
      statusBar1_2.Size = size2;
      this.StatusBar1.TabIndex = 3;
      this.StatusBar1.Text = "StatusBar1";
      this.StatusBarPanel1.Text = "Ready";
      this.StatusBarPanel2.AutoSize = StatusBarPanelAutoSize.Spring;
      this.StatusBarPanel2.Width = 666;
      ImageList imageList1 = this.ImageList1;
      size1 = new Size(16, 16);
      Size size3 = size1;
      imageList1.ImageSize = size3;
      this.ImageList1.ImageStream = (ImageListStreamer) resourceManager.GetObject("ImageList1.ImageStream");
      this.ImageList1.TransparentColor = Color.Transparent;
      this.Panel1.Controls.Add((Control) this.TreeView1);
      this.Panel1.Controls.Add((Control) this.ToolBar1);
      this.Panel1.Dock = DockStyle.Left;
      Panel panel1_1 = this.Panel1;
      point1 = new Point(0, 0);
      Point point3 = point1;
      panel1_1.Location = point3;
      this.Panel1.Name = "Panel1";
      Panel panel1_2 = this.Panel1;
      size1 = new Size(240, 539);
      Size size4 = size1;
      panel1_2.Size = size4;
      this.Panel1.TabIndex = 4;
      this.TreeView1.Dock = DockStyle.Fill;
      this.TreeView1.ImageIndex = -1;
      TreeView treeView1_1 = this.TreeView1;
      point1 = new Point(0, 24);
      Point point4 = point1;
      treeView1_1.Location = point4;
      this.TreeView1.Name = "TreeView1";
      this.TreeView1.SelectedImageIndex = -1;
      TreeView treeView1_2 = this.TreeView1;
      size1 = new Size(240, 515);
      Size size5 = size1;
      treeView1_2.Size = size5;
      this.TreeView1.TabIndex = 3;
      TD.SandBar.ToolBar toolBar1_1 = this.ToolBar1;
      Guid guid1 = new Guid("3c4727f4-b78a-4f5a-a9e2-7598838d812c");
      Guid guid2 = guid1;
      toolBar1_1.Guid = guid2;
      this.ToolBar1.ImageList = this.ImageList1;
      this.ToolBar1.Items.AddRange(new ToolbarItemBase[4]
      {
        (ToolbarItemBase) this.ButtonItem1,
        (ToolbarItemBase) this.DropDownMenuItem1,
        (ToolbarItemBase) this.ButtonCreateReport,
        (ToolbarItemBase) this.ButtonClearSelection
      });
      TD.SandBar.ToolBar toolBar1_2 = this.ToolBar1;
      point1 = new Point(0, 0);
      Point point5 = point1;
      toolBar1_2.Location = point5;
      this.ToolBar1.Name = "ToolBar1";
      TD.SandBar.ToolBar toolBar1_3 = this.ToolBar1;
      size1 = new Size(240, 24);
      Size size6 = size1;
      toolBar1_3.Size = size6;
      this.ToolBar1.TabIndex = 2;
      this.ToolBar1.Text = "ToolBar1";
      this.ButtonItem1.BeginGroup = true;
      this.ButtonItem1.ImageIndex = 0;
      this.DropDownMenuItem1.BeginGroup = true;
      this.DropDownMenuItem1.ImageIndex = 4;
      this.DropDownMenuItem1.Items.AddRange(new ToolbarItemBase[3]
      {
        (ToolbarItemBase) this.MenuButtonItem1,
        (ToolbarItemBase) this.MenuButtonItem2,
        (ToolbarItemBase) this.MenuButtonItem5
      });
      this.DropDownMenuItem1.MenuImageList = this.ImageList1;
      this.DropDownMenuItem1.Text = "Scan....";
      this.MenuButtonItem1.BeginGroup = true;
      this.MenuButtonItem1.Items.AddRange(new ToolbarItemBase[3]
      {
        (ToolbarItemBase) this.MenuButtonItemAll,
        (ToolbarItemBase) this.MenuButtonCommon,
        (ToolbarItemBase) this.MenuButtonItemPersonal
      });
      this.MenuButtonItemAll.BeginGroup = true;
      this.MenuButtonCommon.BeginGroup = true;
      this.MenuButtonItemPersonal.BeginGroup = true;
      this.MenuButtonItem2.BeginGroup = true;
      this.MenuButtonItem5.BeginGroup = true;
      this.ButtonCreateReport.BeginGroup = true;
      this.ButtonCreateReport.ImageIndex = 12;
      this.ButtonClearSelection.BeginGroup = true;
      this.ButtonClearSelection.ImageIndex = 16;
      Splitter splitter1_1 = this.Splitter1;
      point1 = new Point(240, 0);
      Point point6 = point1;
      splitter1_1.Location = point6;
      this.Splitter1.Name = "Splitter1";
      Splitter splitter1_2 = this.Splitter1;
      size1 = new Size(8, 539);
      Size size7 = size1;
      splitter1_2.Size = size7;
      this.Splitter1.TabIndex = 5;
      this.Splitter1.TabStop = false;
      this.HeaderControl2.Controls.Add((Control) this.AusgabePanel);
      this.HeaderControl2.Controls.Add((Control) this.ImagesToolBar);
      this.HeaderControl2.Dock = DockStyle.Fill;
      this.HeaderControl2.HeaderFont = new Font("Tahoma", 12f, FontStyle.Bold);
      HeaderControl headerControl2_1 = this.HeaderControl2;
      point1 = new Point(248, 0);
      Point point7 = point1;
      headerControl2_1.Location = point7;
      this.HeaderControl2.Name = "HeaderControl2";
      HeaderControl headerControl2_2 = this.HeaderControl2;
      size1 = new Size(534, 539);
      Size size8 = size1;
      headerControl2_2.Size = size8;
      this.HeaderControl2.TabIndex = 8;
      this.HeaderControl2.Text = "<....>";
      this.AusgabePanel.AutoScroll = true;
      this.AusgabePanel.Controls.Add((Control) this.ErrorGrid);
      this.AusgabePanel.Controls.Add((Control) this.Sr_DepGrid1);
      this.AusgabePanel.Dock = DockStyle.Fill;
      Panel ausgabePanel1 = this.AusgabePanel;
      point1 = new Point(1, 50);
      Point point8 = point1;
      ausgabePanel1.Location = point8;
      this.AusgabePanel.Name = "AusgabePanel";
      Panel ausgabePanel2 = this.AusgabePanel;
      size1 = new Size(532, 488);
      Size size9 = size1;
      ausgabePanel2.Size = size9;
      this.AusgabePanel.TabIndex = 4;
      this.Sr_DepGrid1.DepListe = (sr_DepBrowser) null;
      this.Sr_DepGrid1.Dock = DockStyle.Fill;
      sr_DepGrid srDepGrid1_1 = this.Sr_DepGrid1;
      point1 = new Point(0, 0);
      Point point9 = point1;
      srDepGrid1_1.Location = point9;
      this.Sr_DepGrid1.Name = "Sr_DepGrid1";
      sr_DepGrid srDepGrid1_2 = this.Sr_DepGrid1;
      size1 = new Size(532, 488);
      Size size10 = size1;
      srDepGrid1_2.Size = size10;
      this.Sr_DepGrid1.TabIndex = 5;
      TD.SandBar.ToolBar imagesToolBar1 = this.ImagesToolBar;
      guid1 = new Guid("b312afcb-11b1-4d09-bf41-47bfc09e055b");
      Guid guid3 = guid1;
      imagesToolBar1.Guid = guid3;
      this.ImagesToolBar.ImageList = this.ImageList1;
      this.ImagesToolBar.Items.AddRange(new ToolbarItemBase[1]
      {
        (ToolbarItemBase) this.ImageToolButton2
      });
      TD.SandBar.ToolBar imagesToolBar2 = this.ImagesToolBar;
      point1 = new Point(1, 26);
      Point point10 = point1;
      imagesToolBar2.Location = point10;
      this.ImagesToolBar.Name = "ImagesToolBar";
      TD.SandBar.ToolBar imagesToolBar3 = this.ImagesToolBar;
      size1 = new Size(532, 24);
      Size size11 = size1;
      imagesToolBar3.Size = size11;
      this.ImagesToolBar.TabIndex = 3;
      this.ImagesToolBar.Text = "ToolBar2";
      this.ImageToolButton2.BeginGroup = true;
      this.ImageToolButton2.ImageIndex = 11;
      this.ErrorGrid.ColumnInfo = "10,1,0,0,0,85,Columns:";
      this.ErrorGrid.Dock = DockStyle.Fill;
      C1.Win.C1FlexGrid.C1FlexGrid errorGrid1 = this.ErrorGrid;
      point1 = new Point(0, 0);
      Point point11 = point1;
      errorGrid1.Location = point11;
      this.ErrorGrid.Name = "ErrorGrid";
      this.ErrorGrid.Rows.DefaultSize = 17;
      C1.Win.C1FlexGrid.C1FlexGrid errorGrid2 = this.ErrorGrid;
      size1 = new Size(532, 488);
      Size size12 = size1;
      errorGrid2.Size = size12;
      this.ErrorGrid.Styles = new CellStyleCollection("");
      this.ErrorGrid.TabIndex = 6;
      this.ErrorGrid.Visible = false;
      size1 = new Size(5, 13);
      this.AutoScaleBaseSize = size1;
      size1 = new Size(782, 563);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.HeaderControl2);
      this.Controls.Add((Control) this.Splitter1);
      this.Controls.Add((Control) this.Panel1);
      this.Controls.Add((Control) this.StatusBar1);
      this.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Name = nameof (FormDepScanner);
      this.StatusBarPanel1.EndInit();
      this.StatusBarPanel2.EndInit();
      this.Panel1.ResumeLayout(false);
      this.HeaderControl2.ResumeLayout(false);
      this.AusgabePanel.ResumeLayout(false);
      this.ErrorGrid.EndInit();
      this.ResumeLayout(false);
    }

    private object ClearAll()
    {
      this.AuswahlArray.Clear();
      this.TreeView1.Nodes.Clear();
      this.Sr_DepGrid1.Clear();
      this.Sr_DepGrid1.Visible = true;
      this.ErrorGrid.Visible = false;
      this.ErrorGrid.Rows.Count = this.ErrorGrid.Rows.Fixed;
      this.HeaderControl2.Text = "<....>";
      this.StatusBarPanel2.Text = "";
      this.BuildingListe.Clear();
      this.BuildingListe.Dispose();
      object obj;
      return obj;
    }

    private object SaveDepListeToHTML()
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
        FileInfo fileInfo = new FileInfo(saveFileDialog.FileName);
        if (!this.Sr_DepGrid1.ExportToHTML(fileInfo.FullName, fileInfo.DirectoryName))
        {
          int num = (int) MessageBox.Show((IWin32Window) this, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[64]), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[17]), MessageBoxButtons.OK, MessageBoxIcon.Hand);
          goto label_5;
        }
        else
        {
          int num1 = (int) MessageBox.Show((IWin32Window) this, StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(ClassThisProg.DefReader.LanguageArray[356], (object) " "), ClassThisProg.DefReader.LanguageArray[145]), (object) " "), (object) fileInfo.FullName)), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[17]), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
      }
label_5:
      object obj;
      return obj;
    }

    private object SaveToHTML(Grid LeseGrid)
    {
      if (LeseGrid.RowsCount != 0)
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
          FileInfo fileInfo;
          try
          {
            fileInfo = new FileInfo(saveFileDialog.FileName);
            string fullName = fileInfo.FullName;
            string directoryName = fileInfo.DirectoryName;
            FileStream fileStream = new FileStream(fullName, FileMode.Create, FileAccess.Write);
            LeseGrid.ExportHTML((IHTMLExport) new HTMLExport(ExportHTMLMode.Default, directoryName, "", (Stream) fileStream));
            fileStream.Close();
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            int num = (int) MessageBox.Show((IWin32Window) this, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[64]), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[17]), MessageBoxButtons.OK, MessageBoxIcon.Hand);
            ProjectData.ClearProjectError();
            goto label_6;
          }
          int num1 = (int) MessageBox.Show((IWin32Window) this, StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(ClassThisProg.DefReader.LanguageArray[356], (object) " "), ClassThisProg.DefReader.LanguageArray[145]), (object) " "), (object) fileInfo.FullName)), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[17]), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
      }
label_6:
      object obj;
      return obj;
    }

    private object GetOwnNodes(object EingabeDatei)
    {
      int index1 = this.BuildingListe.LotDateiArray.IndexOf(RuntimeHelpers.GetObjectValue(EingabeDatei));
      int num1 = this.BuildingListe.LotDateiArray.LastIndexOf(RuntimeHelpers.GetObjectValue(EingabeDatei));
      if (index1 != -1)
      {
        TreeNode[] treeNodeArray = new TreeNode[0];
        int num2 = index1;
        int num3 = num1;
        int num4 = num2;
        while (num4 <= num3)
        {
          if (ObjectType.ObjTst(this.BuildingListe.LotDateiArray[num4], EingabeDatei, false) == 0)
          {
            int index2 = checked (treeNodeArray.GetUpperBound(0) + 1);
            treeNodeArray = (TreeNode[]) Utils.CopyArray((Array) treeNodeArray, (Array) new TreeNode[checked (index2 + 1)]);
            treeNodeArray[index2] = new TreeNode();
            treeNodeArray[index2].Text = this.BuildingListe.LotContains.get_item(num4).ExemplarName;
            treeNodeArray[index2].Tag = (object) num4.ToString();
            if (this.ScanOneFileQuick(num4))
            {
              treeNodeArray[index2].ImageIndex = 9;
              treeNodeArray[index2].SelectedImageIndex = 9;
            }
            else
            {
              treeNodeArray[index2].ImageIndex = 10;
              treeNodeArray[index2].SelectedImageIndex = 10;
            }
          }
          checked { ++num4; }
        }
        if (treeNodeArray.GetUpperBound(0) != -1)
        {
          TreeNode node = new TreeNode();
          node.Text = StringType.FromObject(this.BuildingListe.LotSmallFileArray[index1]);
          node.Tag = (object) "";
          node.SelectedImageIndex = 21;
          node.ImageIndex = 22;
          int upperBound = treeNodeArray.GetUpperBound(0);
          int index3 = 0;
          while (index3 <= upperBound)
          {
            node.Nodes.Add(treeNodeArray[index3]);
            checked { ++index3; }
          }
          this.TreeView1.Nodes.Add(node);
        }
      }
      object obj;
      return obj;
    }

    private object SetTreeView()
    {
      if (this.AuswahlArray.Count != 0)
      {
        this.HeaderControl2.Text = "<....>";
        this.StatusBarPanel2.Text = "";
        TreeView treeView1 = this.TreeView1;
        treeView1.Enabled = false;
        treeView1.BeginUpdate();
        treeView1.SuspendLayout();
        treeView1.Nodes.Clear();
        treeView1.AllowDrop = false;
        treeView1.CheckBoxes = false;
        treeView1.FullRowSelect = true;
        treeView1.ShowLines = true;
        treeView1.ShowPlusMinus = true;
        treeView1.ShowRootLines = true;
        treeView1.HideSelection = false;
        treeView1.CheckBoxes = false;
        treeView1.ImageList = this.ImageList1;
        if (this.BuildingListe.LotContains.Count > 0 && this.AuswahlArray.Count > 0)
        {
          int num = checked (this.AuswahlArray.Count - 1);
          int index = 0;
          while (index <= num)
          {
            this.GetOwnNodes(RuntimeHelpers.GetObjectValue(this.AuswahlArray[index]));
            checked { ++index; }
          }
        }
        treeView1.ResumeLayout();
        treeView1.Enabled = true;
        treeView1.EndUpdate();
      }
      object obj;
      return obj;
    }

    private bool ScanOneFileQuick(int i)
    {
      if (this.BuildingListe.LotContains.get_item(i).BuildingExemplarIndex == -1)
        return false;
      if (this.BuildingListe.LotContains.get_item(i).Props.Count > 0)
      {
        int num = checked (this.BuildingListe.LotContains.get_item(i).Props.Count - 1);
        int index = 0;
        while (index <= num)
        {
          string str = StringType.FromObject(LateBinding.LateGet(this.BuildingListe.LotContains.get_item(i).Props[index], (System.Type) null, "toupper", new object[0], (string[]) null, (bool[]) null));
          if (ClassThisProg.DefReader.DepListe.PropInstanceArray.IndexOf((object) str) == -1)
            return false;
          checked { ++index; }
        }
      }
      if (this.BuildingListe.LotContains.get_item(i).Textures.Count > 0)
      {
        int num = checked (this.BuildingListe.LotContains.get_item(i).Textures.Count - 1);
        int index = 0;
        while (index <= num)
        {
          string str = StringType.FromObject(LateBinding.LateGet(this.BuildingListe.LotContains.get_item(i).Textures[index], (System.Type) null, "toupper", new object[0], (string[]) null, (bool[]) null));
          if (ClassThisProg.DefReader.DepListe.TextureInstanceArray.IndexOf((object) str) == -1)
            return false;
          checked { ++index; }
        }
      }
      return true;
    }

    private object CreateReport()
    {
      this.Cursor = Cursors.WaitCursor;
      this.HeaderControl2.Text = "Report";
      C1.Win.C1FlexGrid.C1FlexGrid errorGrid = this.ErrorGrid;
      try
      {
        errorGrid.Redraw = false;
        errorGrid.Rows.Count = errorGrid.Rows.Fixed;
        if (this.BuildingListe.LotContains.Count > 0)
        {
          this.Sr_DepGrid1.Clear();
          int num1 = checked (this.BuildingListe.LotContains.Count - 1);
          int number = 0;
          while (number <= num1)
          {
            this.StatusBarPanel1.Text = "Scanning...." + (checked ((int) Math.Round(unchecked ((double) checked (100 * number + 1) / (double) this.BuildingListe.LotContains.Count)))).ToString() + "%";
            this.Sr_DepGrid1.GetReportData(this.BuildingListe.LotContains.get_item(number), ClassThisProg.DefReader.AllSmallFilesArray);
            checked { ++number; }
          }
          if (this.Sr_DepGrid1.MissingFiles.Count > 0 | this.Sr_DepGrid1.MissingProps.Count > 0 | this.Sr_DepGrid1.MissingTextures.Count > 0)
          {
            int num2 = checked (this.Sr_DepGrid1.MissingFiles.Count - 1);
            int index1 = 0;
            while (index1 <= num2)
            {
              if (index1 == 0)
              {
                errorGrid.Rows.Add();
                errorGrid.SetData(checked (errorGrid.Rows.Count - 1), 0, RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[487]));
                errorGrid.SetData(checked (errorGrid.Rows.Count - 1), 1, RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[484]));
                errorGrid.Rows[checked (errorGrid.Rows.Count - 1)].IsNode = true;
                errorGrid.Rows[checked (errorGrid.Rows.Count - 1)].Node.EnsureVisible();
                errorGrid.GetCellRange(checked (errorGrid.Rows.Count - 1), 0, checked (errorGrid.Rows.Count - 1), checked (errorGrid.Cols.Count - 1)).Style = errorGrid.Styles["LeftTitel"];
              }
              errorGrid.Rows.Add();
              errorGrid.SetData(checked (errorGrid.Rows.Count - 1), 0, RuntimeHelpers.GetObjectValue(this.Sr_DepGrid1.MissingFiles[index1]));
              errorGrid.SetData(checked (errorGrid.Rows.Count - 1), 1, (object) "<n/a>");
              checked { ++index1; }
            }
            int num3 = checked (this.Sr_DepGrid1.MissingTextures.Count - 1);
            int index2 = 0;
            while (index2 <= num3)
            {
              if (index2 == 0)
              {
                errorGrid.Rows.Add();
                errorGrid.SetData(checked (errorGrid.Rows.Count - 1), 0, RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[488]));
                errorGrid.SetData(checked (errorGrid.Rows.Count - 1), 1, (object) "");
                errorGrid.GetCellRange(checked (errorGrid.Rows.Count - 1), 0, checked (errorGrid.Rows.Count - 1), checked (errorGrid.Cols.Count - 1)).Style = errorGrid.Styles["LeftTitel"];
                errorGrid.Rows[checked (errorGrid.Rows.Count - 1)].IsNode = true;
              }
              errorGrid.Rows.Add();
              errorGrid.SetData(checked (errorGrid.Rows.Count - 1), 0, RuntimeHelpers.GetObjectValue(this.Sr_DepGrid1.MissingTextures[index2]));
              errorGrid.SetData(checked (errorGrid.Rows.Count - 1), 1, (object) "");
              checked { ++index2; }
            }
            int num4 = checked (this.Sr_DepGrid1.MissingProps.Count - 1);
            int index3 = 0;
            while (index3 <= num4)
            {
              if (index3 == 0)
              {
                errorGrid.Rows.Add();
                errorGrid.SetData(checked (errorGrid.Rows.Count - 1), 0, RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[512]));
                errorGrid.SetData(checked (errorGrid.Rows.Count - 1), 1, (object) "");
                errorGrid.GetCellRange(checked (errorGrid.Rows.Count - 1), 0, checked (errorGrid.Rows.Count - 1), checked (errorGrid.Cols.Count - 1)).Style = errorGrid.Styles["LeftTitel"];
                errorGrid.Rows[checked (errorGrid.Rows.Count - 1)].IsNode = true;
              }
              errorGrid.Rows.Add();
              errorGrid.SetData(checked (errorGrid.Rows.Count - 1), 0, RuntimeHelpers.GetObjectValue(this.Sr_DepGrid1.MissingProps[index3]));
              errorGrid.SetData(checked (errorGrid.Rows.Count - 1), 1, (object) "");
              checked { ++index3; }
            }
            this.StatusBarPanel1.Text = "Ready";
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      errorGrid.Redraw = true;
      this.StatusBarPanel1.Text = "Ready";
      this.Cursor = Cursors.Default;
      object obj;
      return obj;
    }

    private object StartScan(int LotIndex)
    {
      this.Cursor = Cursors.WaitCursor;
      this.Sr_DepGrid1.Clear();
      this.Sr_DepGrid1.Start(LotIndex, this.BuildingListe, ClassThisProg.DefReader.AllSmallFilesArray);
      this.Cursor = Cursors.Default;
      object obj;
      return obj;
    }

    public object SetzeTexte()
    {
      this.isLoading = true;
      this.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[314]);
      this.MenuButtonItem1.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[354]);
      this.MenuButtonItemAll.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[357]);
      this.MenuButtonCommon.Text = ClassThisProg.DefReader.SC4Path;
      this.MenuButtonItemPersonal.Text = ClassThisProg.DefReader.sc4LocalPath;
      this.MenuButtonItem2.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[355]);
      this.MenuButtonItem5.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[356]);
      this.ButtonItem1.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[3]);
      this.ButtonClearSelection.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[377]);
      this.ImageToolButton2.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[63]);
      this.ButtonCreateReport.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[369]);
      object obj;
      return obj;
    }

    private void FormDepScanner_Load(object sender, EventArgs e)
    {
      this.isLoading = true;
      sr_Userinterface.AendereFarben((Form) this, ClassThisProg.DefReader.FarbSchema);
      this.SetzeTexte();
      this.Sr_DepGrid1.Visible = true;
      this.Sr_DepGrid1.DepListe = ClassThisProg.DefReader.DepListe;
      this.ErrorGrid.Visible = false;
    }

    private void ButtonClearSelection_Activate(object sender, EventArgs e) => this.ClearAll();

    private void ButtonCreateReport_Activate(object sender, EventArgs e)
    {
      if (this.AuswahlArray.Count == 0)
        return;
      this.Sr_DepGrid1.Visible = false;
      this.ErrorGrid.Visible = true;
      this.ErrorGrid.Rows.Count = this.ErrorGrid.Rows.Fixed;
      this.HeaderControl2.Text = "<....>";
      this.StatusBarPanel2.Text = "";
      this.CreateReport();
    }

    private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
    {
      this.Sr_DepGrid1.Visible = true;
      this.ErrorGrid.Visible = false;
      if (!Information.IsNumeric(RuntimeHelpers.GetObjectValue(e.Node.Tag)))
        return;
      this.StartScan(IntegerType.FromObject(e.Node.Tag));
      this.HeaderControl2.Text = e.Node.Text;
    }

    private void ImageToolButton2_Activate(object sender, EventArgs e)
    {
      if (!this.Sr_DepGrid1.Visible)
        return;
      this.SaveDepListeToHTML();
    }

    private void Panel1_Resize(object sender, EventArgs e) => this.StatusBarPanel1.Width = checked ((int) Math.Round(unchecked ((double) this.Panel1.Width + (double) this.Splitter1.Width / 2.0)));

    private void ButtonItem1_Activate_1(object sender, EventArgs e) => this.Dispose();

    private void FormDepScanner_Closed(object sender, EventArgs e) => ClassThisProg.frmDepScanner = (FormDepScanner) null;

    private void MenuButtonItemAll_Activate(object sender, EventArgs e)
    {
      Application.DoEvents();
      this.Cursor = Cursors.WaitCursor;
      this.ClearAll();
      int num1 = checked (ClassThisProg.DefReader.MainCommonFolderArray.Count + ClassThisProg.DefReader.MainPrivateFolderArray.Count);
      int num2 = checked (ClassThisProg.DefReader.MainCommonFolderArray.Count - 1);
      int index1 = 0;
      while (index1 <= num2)
      {
        this.StatusBarPanel1.Text = "Scanning...." + (checked ((int) Math.Round(unchecked ((double) checked (100 * index1 + 1) / (double) num1)))).ToString() + "%";
        this.BuildingListe.GetOneFile(StringType.FromObject(ClassThisProg.DefReader.MainCommonFolderArray[index1]));
        checked { ++index1; }
      }
      int num3 = checked (ClassThisProg.DefReader.MainPrivateFolderArray.Count - 1);
      int index2 = 0;
      while (index2 <= num3)
      {
        this.StatusBarPanel1.Text = "Scanning...." + (checked ((int) Math.Round(unchecked ((double) checked (100 * index2 + 1) / (double) num1)))).ToString() + "%";
        this.BuildingListe.GetOneFile(StringType.FromObject(ClassThisProg.DefReader.MainPrivateFolderArray[index2]));
        checked { ++index2; }
      }
      this.BuildingListe.OrdneLotsZu();
      this.AuswahlArray.AddRange((ICollection) ClassThisProg.DefReader.MainCommonFolderArray);
      this.AuswahlArray.AddRange((ICollection) ClassThisProg.DefReader.MainPrivateFolderArray);
      this.SetTreeView();
      this.StatusBarPanel1.Text = "Ready";
      this.Cursor = Cursors.Default;
    }

    private void MenuButtonCommon_Activate(object sender, EventArgs e)
    {
      Application.DoEvents();
      this.Cursor = Cursors.WaitCursor;
      this.ClearAll();
      int count = ClassThisProg.DefReader.MainCommonFolderArray.Count;
      int num = checked (ClassThisProg.DefReader.MainCommonFolderArray.Count - 1);
      int index = 0;
      while (index <= num)
      {
        this.StatusBarPanel1.Text = "Scanning...." + (checked ((int) Math.Round(unchecked ((double) checked (100 * index + 1) / (double) count)))).ToString() + "%";
        this.BuildingListe.GetOneFile(StringType.FromObject(ClassThisProg.DefReader.MainCommonFolderArray[index]));
        checked { ++index; }
      }
      this.BuildingListe.OrdneLotsZu();
      this.AuswahlArray.AddRange((ICollection) ClassThisProg.DefReader.MainCommonFolderArray);
      this.SetTreeView();
      this.StatusBarPanel1.Text = "Ready";
      this.Cursor = Cursors.Default;
    }

    private void MenuButtonItemPersonal_Activate(object sender, EventArgs e)
    {
      Application.DoEvents();
      this.Cursor = Cursors.WaitCursor;
      this.ClearAll();
      int count = ClassThisProg.DefReader.MainPrivateFolderArray.Count;
      int num = checked (ClassThisProg.DefReader.MainPrivateFolderArray.Count - 1);
      int index = 0;
      while (index <= num)
      {
        this.StatusBarPanel1.Text = "Scanning...." + (checked ((int) Math.Round(unchecked ((double) checked (100 * index + 1) / (double) count)))).ToString() + "%";
        this.BuildingListe.GetOneFile(StringType.FromObject(ClassThisProg.DefReader.MainPrivateFolderArray[index]));
        checked { ++index; }
      }
      this.BuildingListe.OrdneLotsZu();
      this.AuswahlArray.AddRange((ICollection) ClassThisProg.DefReader.MainPrivateFolderArray);
      this.SetTreeView();
      this.StatusBarPanel1.Text = "Ready";
      this.Cursor = Cursors.Default;
    }

    private void MenuButtonItem2_Activate(object sender, EventArgs e)
    {
      ArrayList Array1 = new ArrayList();
      object o = (object) new FolderBrowserDialog();
      ArrayList PatternList = new ArrayList();
      PatternList.Add((object) "*.dat");
      PatternList.Add((object) "*.sc4Lot");
      PatternList.Add((object) "*.sc4desc");
      LateBinding.LateSet(o, (System.Type) null, "ShowNewFolderButton", new object[1]
      {
        (object) false
      }, (string[]) null);
      LateBinding.LateSet(o, (System.Type) null, "RootFolder", new object[1]
      {
        (object) Environment.SpecialFolder.MyComputer
      }, (string[]) null);
      LateBinding.LateSet(o, (System.Type) null, "Description", new object[1]
      {
        (object) "Select"
      }, (string[]) null);
      if (IntegerType.FromObject(LateBinding.LateGet(o, (System.Type) null, "ShowDialog", new object[0], (string[]) null, (bool[]) null)) != 1)
        return;
      Application.DoEvents();
      this.Cursor = Cursors.WaitCursor;
      this.ClearAll();
      this.StatusBarPanel1.Text = "Reading....";
      sr_DirBrowser.StartRead(StringType.FromObject(LateBinding.LateGet(o, (System.Type) null, "SelectedPath", new object[0], (string[]) null, (bool[]) null)), PatternList, ref Array1);
      int count = Array1.Count;
      if (Array1.Count > 0)
      {
        int num = checked (Array1.Count - 1);
        int index = 0;
        while (index <= num)
        {
          this.StatusBarPanel1.Text = "Scanning...." + (checked ((int) Math.Round(unchecked ((double) checked (100 * index + 1) / (double) count)))).ToString() + "%";
          this.BuildingListe.GetOneFile(StringType.FromObject(Array1[index]));
          this.AuswahlArray.Add(RuntimeHelpers.GetObjectValue(Array1[index]));
          checked { ++index; }
        }
        this.BuildingListe.OrdneLotsZu();
      }
      this.StatusBarPanel1.Text = "Ready";
      this.Cursor = Cursors.Default;
      this.SetTreeView();
    }

    private void MenuButtonItem5_Activate(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.RestoreDirectory = true;
      openFileDialog.Title = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[16]);
      openFileDialog.ShowReadOnly = true;
      openFileDialog.Filter = "SC4-Files (*.dat;*.sc4Lot)|*.dat;*.sc4Lot|All (*.*)|*.*";
      if (openFileDialog.ShowDialog() != DialogResult.OK)
        return;
      Application.DoEvents();
      this.Cursor = Cursors.WaitCursor;
      this.StatusBarPanel1.Text = "Reading....";
      this.ClearAll();
      this.BuildingListe.GetOneFile(openFileDialog.FileName);
      this.BuildingListe.OrdneLotsZu();
      this.AuswahlArray.Add((object) openFileDialog.FileName);
      this.SetTreeView();
      this.StatusBarPanel1.Text = "Ready";
      this.Cursor = Cursors.Default;
    }
  }
}
