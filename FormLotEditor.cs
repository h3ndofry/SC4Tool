// Decompiled with JetBrains decompiler
// Type: SC4Tool.FormLotEditor
// Assembly: SC4Tool, Version=2.2.7.0, Culture=neutral, PublicKeyToken=null
// MVID: 69A50BC4-87A5-4C5E-BEFC-08274BC6D498
// Assembly location: C:\Program Files (x86)\SC4 Utilities\SC4Tool\SC4Tool.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using sr_Resources;
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
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using TD.Eyefinder;
using TD.SandBar;
using TD.SandDock;

namespace SC4Tool
{
  public class FormLotEditor : Form
  {
    [AccessedThroughProperty("ModusMenuItem2")]
    private MenuButtonItem _ModusMenuItem2;
    [AccessedThroughProperty("ModusMenuItem1")]
    private MenuButtonItem _ModusMenuItem1;
    [AccessedThroughProperty("DockControl3")]
    private DockControl _DockControl3;
    [AccessedThroughProperty("ModusMenu")]
    private DropDownMenuItem _ModusMenu;
    [AccessedThroughProperty("TransitSwitchGrid")]
    private Grid _TransitSwitchGrid;
    [AccessedThroughProperty("TransitSwitchButton1")]
    private ButtonItem _TransitSwitchButton1;
    [AccessedThroughProperty("PictureBox4")]
    private PictureBox _PictureBox4;
    [AccessedThroughProperty("TreeView1")]
    private TreeView _TreeView1;
    [AccessedThroughProperty("PictureBox5")]
    private PictureBox _PictureBox5;
    [AccessedThroughProperty("TransitSwitchToolBar")]
    private TD.SandBar.ToolBar _TransitSwitchToolBar;
    [AccessedThroughProperty("ToolBar1")]
    private TD.SandBar.ToolBar _ToolBar1;
    [AccessedThroughProperty("Splitter1")]
    private Splitter _Splitter1;
    [AccessedThroughProperty("PictureBox6")]
    private PictureBox _PictureBox6;
    [AccessedThroughProperty("TransitSwitchPanel")]
    private Panel _TransitSwitchPanel;
    [AccessedThroughProperty("Panel1")]
    private Panel _Panel1;
    [AccessedThroughProperty("PictureBox7")]
    private PictureBox _PictureBox7;
    [AccessedThroughProperty("ToolTip1")]
    private ToolTip _ToolTip1;
    [AccessedThroughProperty("DockControl7")]
    private DockControl _DockControl7;
    [AccessedThroughProperty("PictureBox8")]
    private PictureBox _PictureBox8;
    [AccessedThroughProperty("TextureGrid")]
    private Grid _TextureGrid;
    [AccessedThroughProperty("ButtonShowReps")]
    private ButtonItem _ButtonShowReps;
    [AccessedThroughProperty("MainToolBar")]
    private TD.SandBar.ToolBar _MainToolBar;
    [AccessedThroughProperty("T1_Picture_1")]
    private PictureBox _T1_Picture_1;
    [AccessedThroughProperty("T2_Picture_1")]
    private PictureBox _T2_Picture_1;
    [AccessedThroughProperty("ButtonDeleteTile")]
    private ButtonItem _ButtonDeleteTile;
    [AccessedThroughProperty("ButtonSave")]
    private ButtonItem _ButtonSave;
    [AccessedThroughProperty("T3_Picture_1")]
    private PictureBox _T3_Picture_1;
    [AccessedThroughProperty("StatusBar1")]
    private StatusBar _StatusBar1;
    [AccessedThroughProperty("ButtonMinus")]
    private ButtonItem _ButtonMinus;
    [AccessedThroughProperty("StatusBarPanel1")]
    private StatusBarPanel _StatusBarPanel1;
    [AccessedThroughProperty("StatusBarPanel2")]
    private StatusBarPanel _StatusBarPanel2;
    [AccessedThroughProperty("T8_Picture_1")]
    private PictureBox _T8_Picture_1;
    [AccessedThroughProperty("PictureBox2")]
    private PictureBox _PictureBox2;
    [AccessedThroughProperty("T7_Picture_1")]
    private PictureBox _T7_Picture_1;
    [AccessedThroughProperty("ButtonPlus")]
    private ButtonItem _ButtonPlus;
    [AccessedThroughProperty("PictureBox1")]
    private PictureBox _PictureBox1;
    [AccessedThroughProperty("T9_Picture_1")]
    private PictureBox _T9_Picture_1;
    [AccessedThroughProperty("T_Label_3")]
    private Label _T_Label_3;
    [AccessedThroughProperty("ButtonOpen")]
    private ButtonItem _ButtonOpen;
    [AccessedThroughProperty("T_Label_1")]
    private Label _T_Label_1;
    [AccessedThroughProperty("T_Label_2")]
    private Label _T_Label_2;
    [AccessedThroughProperty("T_Label_7")]
    private Label _T_Label_7;
    [AccessedThroughProperty("ButtonLeave")]
    private ButtonItem _ButtonLeave;
    [AccessedThroughProperty("T_Label_8")]
    private Label _T_Label_8;
    [AccessedThroughProperty("T_Label_9")]
    private Label _T_Label_9;
    [AccessedThroughProperty("GroupBox1")]
    private GroupBox _GroupBox1;
    [AccessedThroughProperty("PictureBox11")]
    private PictureBox _PictureBox11;
    [AccessedThroughProperty("DirButton1")]
    private RadioButton _DirButton1;
    [AccessedThroughProperty("CheckSouth")]
    private System.Windows.Forms.CheckBox _CheckSouth;
    [AccessedThroughProperty("StatusBarPanel3")]
    private StatusBarPanel _StatusBarPanel3;
    [AccessedThroughProperty("CheckWest")]
    private System.Windows.Forms.CheckBox _CheckWest;
    [AccessedThroughProperty("DirButton2")]
    private RadioButton _DirButton2;
    [AccessedThroughProperty("T4_Picture_1")]
    private PictureBox _T4_Picture_1;
    [AccessedThroughProperty("CheckEast")]
    private System.Windows.Forms.CheckBox _CheckEast;
    [AccessedThroughProperty("mnuContextMenu")]
    private System.Windows.Forms.ContextMenu _mnuContextMenu;
    [AccessedThroughProperty("RWButton1")]
    private RadioButton _RWButton1;
    [AccessedThroughProperty("CheckNorth")]
    private System.Windows.Forms.CheckBox _CheckNorth;
    [AccessedThroughProperty("HeaderControl1")]
    private HeaderControl _HeaderControl1;
    [AccessedThroughProperty("GroupBox2")]
    private GroupBox _GroupBox2;
    [AccessedThroughProperty("CommonPanel")]
    private Panel _CommonPanel;
    [AccessedThroughProperty("GroupBox3")]
    private GroupBox _GroupBox3;
    [AccessedThroughProperty("GroupBox4")]
    private GroupBox _GroupBox4;
    [AccessedThroughProperty("GrowthText")]
    private TextBox _GrowthText;
    [AccessedThroughProperty("T5_Picture_1")]
    private PictureBox _T5_Picture_1;
    [AccessedThroughProperty("T6_Picture_1")]
    private PictureBox _T6_Picture_1;
    [AccessedThroughProperty("DockControl1")]
    private DockControl _DockControl1;
    [AccessedThroughProperty("Label13")]
    private Label _Label13;
    [AccessedThroughProperty("T_Label_4")]
    private Label _T_Label_4;
    [AccessedThroughProperty("RWButton3")]
    private RadioButton _RWButton3;
    [AccessedThroughProperty("DocumentContainer1")]
    private DocumentContainer _DocumentContainer1;
    [AccessedThroughProperty("T_Label_5")]
    private Label _T_Label_5;
    [AccessedThroughProperty("T_Label_6")]
    private Label _T_Label_6;
    [AccessedThroughProperty("TransitPanel")]
    private Panel _TransitPanel;
    [AccessedThroughProperty("LotMinText")]
    private TextBox _LotMinText;
    [AccessedThroughProperty("GroupBox5")]
    private GroupBox _GroupBox5;
    [AccessedThroughProperty("Splitter4")]
    private Splitter _Splitter4;
    [AccessedThroughProperty("LotPanel")]
    private Panel _LotPanel;
    [AccessedThroughProperty("Splitter3")]
    private Splitter _Splitter3;
    [AccessedThroughProperty("RepGrid")]
    private Grid _RepGrid;
    [AccessedThroughProperty("RepPanel")]
    private Panel _RepPanel;
    [AccessedThroughProperty("MenuDisplayItem2")]
    private MenuButtonItem _MenuDisplayItem2;
    [AccessedThroughProperty("RWButton5")]
    private RadioButton _RWButton5;
    [AccessedThroughProperty("MenuDisplayItem1")]
    private MenuButtonItem _MenuDisplayItem1;
    [AccessedThroughProperty("ImageList1")]
    private ImageList _ImageList1;
    [AccessedThroughProperty("MenuDisplay")]
    private DropDownMenuItem _MenuDisplay;
    [AccessedThroughProperty("LotMaxText")]
    private TextBox _LotMaxText;
    [AccessedThroughProperty("Label14")]
    private Label _Label14;
    [AccessedThroughProperty("Label15")]
    private Label _Label15;
    [AccessedThroughProperty("Graphicgrid1")]
    private graphicgrid _Graphicgrid1;
    [AccessedThroughProperty("CornerButton3")]
    private RadioButton _CornerButton3;
    [AccessedThroughProperty("CornerButton2")]
    private RadioButton _CornerButton2;
    [AccessedThroughProperty("CornerButton1")]
    private RadioButton _CornerButton1;
    [AccessedThroughProperty("PictureBox3")]
    private PictureBox _PictureBox3;
    [AccessedThroughProperty("TRPicture3")]
    private PictureBox _TRPicture3;
    [AccessedThroughProperty("RWButton6")]
    private RadioButton _RWButton6;
    [AccessedThroughProperty("TRPicture2")]
    private PictureBox _TRPicture2;
    [AccessedThroughProperty("TRPicture1")]
    private PictureBox _TRPicture1;
    [AccessedThroughProperty("Label12")]
    private Label _Label12;
    [AccessedThroughProperty("FoundationText")]
    private TextBox _FoundationText;
    [AccessedThroughProperty("ErrorProvider1")]
    private ErrorProvider _ErrorProvider1;
    [AccessedThroughProperty("ThresholdText")]
    private TextBox _ThresholdText;
    [AccessedThroughProperty("Label11")]
    private Label _Label11;
    [AccessedThroughProperty("Label10")]
    private Label _Label10;
    [AccessedThroughProperty("RWButton2")]
    private RadioButton _RWButton2;
    [AccessedThroughProperty("RWButton4")]
    private RadioButton _RWButton4;
    private bool ExpertModus;
    private bool ShowTransitString;
    private ArrayList LotExemplarArray;
    private ArrayList BuildingExemplarArray;
    private ArrayList LotExemplarInstanceArray;
    private ArrayList BuildingExemplarInstanceArray;
    private ArrayList LotIndexArray;
    private ArrayList ExemplarIndexArray;
    private ArrayList NodeArray;
    private MainReader.Exemplar LotExemplar;
    private MainReader.Exemplar BuildingExemplar;
    private string LeseDatei;
    private Point AktuellerGridPoint;
    private int AktuellerLotIndex;
    private int AktuellerTileIndex;
    private sr_SourceGrid.VisualModels.Common l_TitleModel;
    private sr_SourceGrid.VisualModels.Common l_CenterModel;
    private Lot AktuellesLot;
    private Lot.LotDefinition myDefs;
    private ArrayList ChainTable1;
    private ArrayList ChainTable2;
    private object ActiveTrafficArt;
    private bool hasNotSavedChanges;
    private MenuItem mnuItemAdd;
    private MenuItem mnuItemDummy;
    private MenuItem mnuItemRemove;
    private MenuItem mnuItemDummy1;
    private MenuItem mnuItemChangeDirection;
    private MenuItem mnuItemDummy2;
    private MenuItem mnuItemEditTransit;
    private IContainer components;

    public FormLotEditor()
    {
      this.Load += new EventHandler(this.FormLotEditor_Load);
      this.Closed += new EventHandler(this.FormLotEditor_Closed);
      this.ExpertModus = false;
      this.ShowTransitString = false;
      this.LotExemplarArray = new ArrayList();
      this.BuildingExemplarArray = new ArrayList();
      this.LotExemplarInstanceArray = new ArrayList();
      this.BuildingExemplarInstanceArray = new ArrayList();
      this.LotIndexArray = new ArrayList();
      this.ExemplarIndexArray = new ArrayList();
      this.NodeArray = new ArrayList();
      this.AktuellerTileIndex = -1;
      this.l_TitleModel = new sr_SourceGrid.VisualModels.Common(false);
      this.l_CenterModel = new sr_SourceGrid.VisualModels.Common(false);
      this.ChainTable1 = new ArrayList();
      this.ChainTable2 = new ArrayList();
      this.ActiveTrafficArt = (object) "";
      this.hasNotSavedChanges = false;
      this.InitializeComponent();
      if (ClassThisProg.DefReader.HasReadTextures || ClassThisProg.frmProgress != null)
        return;
      ClassThisProg.frmProgress = new FormProgress("T");
      ClassThisProg.frmProgress.MdiParent = (Form) ClassThisProg.frmMain;
      int num = (int) ClassThisProg.frmProgress.ShowDialog();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
      ClassThisProg.frmLotEditor = (FormLotEditor) null;
    }

    internal virtual System.Windows.Forms.ContextMenu mnuContextMenu
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._mnuContextMenu == null)
          ;
        this._mnuContextMenu = value;
        if (this._mnuContextMenu == null)
          ;
      }
      get => this._mnuContextMenu;
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

    internal virtual StatusBar StatusBar1
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._StatusBar1 == null)
          ;
        this._StatusBar1 = value;
        if (this._StatusBar1 == null)
          ;
      }
      get => this._StatusBar1;
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

    internal virtual HeaderControl HeaderControl1
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._HeaderControl1 == null)
          ;
        this._HeaderControl1 = value;
        if (this._HeaderControl1 == null)
          ;
      }
      get => this._HeaderControl1;
    }

    internal virtual DocumentContainer DocumentContainer1
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._DocumentContainer1 == null)
          ;
        this._DocumentContainer1 = value;
        if (this._DocumentContainer1 == null)
          ;
      }
      get => this._DocumentContainer1;
    }

    internal virtual DockControl DockControl1
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._DockControl1 == null)
          ;
        this._DockControl1 = value;
        if (this._DockControl1 == null)
          ;
      }
      get => this._DockControl1;
    }

    internal virtual Panel CommonPanel
    {
      get => this._CommonPanel;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._CommonPanel == null)
          ;
        this._CommonPanel = value;
        if (this._CommonPanel == null)
          ;
      }
    }

    internal virtual GroupBox GroupBox4
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._GroupBox4 == null)
          ;
        this._GroupBox4 = value;
        if (this._GroupBox4 == null)
          ;
      }
      get => this._GroupBox4;
    }

    internal virtual TextBox GrowthText
    {
      get => this._GrowthText;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._GrowthText != null)
        {
          this._GrowthText.Validating -= new CancelEventHandler(this.GrowthText_Validating);
          this._GrowthText.TextChanged -= new EventHandler(this.GrowthText_TextChanged);
        }
        this._GrowthText = value;
        if (this._GrowthText == null)
          return;
        this._GrowthText.Validating += new CancelEventHandler(this.GrowthText_Validating);
        this._GrowthText.TextChanged += new EventHandler(this.GrowthText_TextChanged);
      }
    }

    internal virtual Label Label13
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Label13 == null)
          ;
        this._Label13 = value;
        if (this._Label13 == null)
          ;
      }
      get => this._Label13;
    }

    internal virtual GroupBox GroupBox3
    {
      get => this._GroupBox3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._GroupBox3 == null)
          ;
        this._GroupBox3 = value;
        if (this._GroupBox3 == null)
          ;
      }
    }

    internal virtual TextBox LotMinText
    {
      get => this._LotMinText;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._LotMinText != null)
        {
          this._LotMinText.Validating -= new CancelEventHandler(this.LotMinText_Validating);
          this._LotMinText.TextChanged -= new EventHandler(this.LotMinText_TextChanged);
        }
        this._LotMinText = value;
        if (this._LotMinText == null)
          return;
        this._LotMinText.Validating += new CancelEventHandler(this.LotMinText_Validating);
        this._LotMinText.TextChanged += new EventHandler(this.LotMinText_TextChanged);
      }
    }

    internal virtual TextBox LotMaxText
    {
      get => this._LotMaxText;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._LotMaxText != null)
        {
          this._LotMaxText.Validating -= new CancelEventHandler(this.LotMaxText_Validating);
          this._LotMaxText.TextChanged -= new EventHandler(this.LotMaxText_TextChanged);
        }
        this._LotMaxText = value;
        if (this._LotMaxText == null)
          return;
        this._LotMaxText.Validating += new CancelEventHandler(this.LotMaxText_Validating);
        this._LotMaxText.TextChanged += new EventHandler(this.LotMaxText_TextChanged);
      }
    }

    internal virtual Label Label14
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Label14 == null)
          ;
        this._Label14 = value;
        if (this._Label14 == null)
          ;
      }
      get => this._Label14;
    }

    internal virtual Label Label15
    {
      get => this._Label15;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Label15 == null)
          ;
        this._Label15 = value;
        if (this._Label15 == null)
          ;
      }
    }

    internal virtual GroupBox GroupBox1
    {
      get => this._GroupBox1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._GroupBox1 == null)
          ;
        this._GroupBox1 = value;
        if (this._GroupBox1 == null)
          ;
      }
    }

    internal virtual RadioButton CornerButton3
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._CornerButton3 != null)
          this._CornerButton3.CheckedChanged -= new EventHandler(this.CornerButton3_CheckedChanged);
        this._CornerButton3 = value;
        if (this._CornerButton3 == null)
          return;
        this._CornerButton3.CheckedChanged += new EventHandler(this.CornerButton3_CheckedChanged);
      }
      get => this._CornerButton3;
    }

    internal virtual RadioButton CornerButton2
    {
      get => this._CornerButton2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._CornerButton2 != null)
          this._CornerButton2.CheckedChanged -= new EventHandler(this.CornerButton2_CheckedChanged);
        this._CornerButton2 = value;
        if (this._CornerButton2 == null)
          return;
        this._CornerButton2.CheckedChanged += new EventHandler(this.CornerButton2_CheckedChanged);
      }
    }

    internal virtual RadioButton CornerButton1
    {
      get => this._CornerButton1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._CornerButton1 != null)
          this._CornerButton1.CheckedChanged -= new EventHandler(this.CornerButton1_CheckedChanged);
        this._CornerButton1 = value;
        if (this._CornerButton1 == null)
          return;
        this._CornerButton1.CheckedChanged += new EventHandler(this.CornerButton1_CheckedChanged);
      }
    }

    internal virtual PictureBox TRPicture3
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._TRPicture3 == null)
          ;
        this._TRPicture3 = value;
        if (this._TRPicture3 == null)
          ;
      }
      get => this._TRPicture3;
    }

    internal virtual PictureBox TRPicture2
    {
      get => this._TRPicture2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._TRPicture2 == null)
          ;
        this._TRPicture2 = value;
        if (this._TRPicture2 == null)
          ;
      }
    }

    internal virtual PictureBox TRPicture1
    {
      get => this._TRPicture1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._TRPicture1 == null)
          ;
        this._TRPicture1 = value;
        if (this._TRPicture1 == null)
          ;
      }
    }

    internal virtual GroupBox GroupBox2
    {
      get => this._GroupBox2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._GroupBox2 == null)
          ;
        this._GroupBox2 = value;
        if (this._GroupBox2 == null)
          ;
      }
    }

    internal virtual Label Label12
    {
      get => this._Label12;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Label12 == null)
          ;
        this._Label12 = value;
        if (this._Label12 == null)
          ;
      }
    }

    internal virtual TextBox FoundationText
    {
      get => this._FoundationText;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._FoundationText != null)
        {
          this._FoundationText.Validated -= new EventHandler(this.FoundationText_Validated);
          this._FoundationText.Validating -= new CancelEventHandler(this.FoundationText_Validating);
          this._FoundationText.TextChanged -= new EventHandler(this.FoundationText_TextChanged);
        }
        this._FoundationText = value;
        if (this._FoundationText == null)
          return;
        this._FoundationText.Validated += new EventHandler(this.FoundationText_Validated);
        this._FoundationText.Validating += new CancelEventHandler(this.FoundationText_Validating);
        this._FoundationText.TextChanged += new EventHandler(this.FoundationText_TextChanged);
      }
    }

    internal virtual TextBox ThresholdText
    {
      get => this._ThresholdText;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ThresholdText != null)
        {
          this._ThresholdText.Validating -= new CancelEventHandler(this.ThresholdText_Validating);
          this._ThresholdText.TextChanged -= new EventHandler(this.ThresholdText_TextChanged);
        }
        this._ThresholdText = value;
        if (this._ThresholdText == null)
          return;
        this._ThresholdText.Validating += new CancelEventHandler(this.ThresholdText_Validating);
        this._ThresholdText.TextChanged += new EventHandler(this.ThresholdText_TextChanged);
      }
    }

    internal virtual Label Label11
    {
      get => this._Label11;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Label11 == null)
          ;
        this._Label11 = value;
        if (this._Label11 == null)
          ;
      }
    }

    internal virtual Label Label10
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Label10 == null)
          ;
        this._Label10 = value;
        if (this._Label10 == null)
          ;
      }
      get => this._Label10;
    }

    internal virtual RadioButton RWButton2
    {
      get => this._RWButton2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._RWButton2 != null)
          this._RWButton2.CheckedChanged -= new EventHandler(this.RWButton2_CheckedChanged);
        this._RWButton2 = value;
        if (this._RWButton2 == null)
          return;
        this._RWButton2.CheckedChanged += new EventHandler(this.RWButton2_CheckedChanged);
      }
    }

    internal virtual PictureBox PictureBox6
    {
      get => this._PictureBox6;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._PictureBox6 == null)
          ;
        this._PictureBox6 = value;
        if (this._PictureBox6 == null)
          ;
      }
    }

    internal virtual RadioButton RWButton4
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._RWButton4 != null)
          this._RWButton4.CheckedChanged -= new EventHandler(this.RWButton4_CheckedChanged);
        this._RWButton4 = value;
        if (this._RWButton4 == null)
          return;
        this._RWButton4.CheckedChanged += new EventHandler(this.RWButton4_CheckedChanged);
      }
      get => this._RWButton4;
    }

    internal virtual PictureBox PictureBox5
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._PictureBox5 == null)
          ;
        this._PictureBox5 = value;
        if (this._PictureBox5 == null)
          ;
      }
      get => this._PictureBox5;
    }

    internal virtual RadioButton RWButton6
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._RWButton6 != null)
          this._RWButton6.CheckedChanged -= new EventHandler(this.RWButton6_CheckedChanged);
        this._RWButton6 = value;
        if (this._RWButton6 == null)
          return;
        this._RWButton6.CheckedChanged += new EventHandler(this.RWButton6_CheckedChanged);
      }
      get => this._RWButton6;
    }

    internal virtual PictureBox PictureBox4
    {
      get => this._PictureBox4;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._PictureBox4 == null)
          ;
        this._PictureBox4 = value;
        if (this._PictureBox4 == null)
          ;
      }
    }

    internal virtual RadioButton RWButton5
    {
      get => this._RWButton5;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._RWButton5 != null)
          this._RWButton5.CheckedChanged -= new EventHandler(this.RWButton5_CheckedChanged);
        this._RWButton5 = value;
        if (this._RWButton5 == null)
          return;
        this._RWButton5.CheckedChanged += new EventHandler(this.RWButton5_CheckedChanged);
      }
    }

    internal virtual PictureBox PictureBox3
    {
      get => this._PictureBox3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._PictureBox3 == null)
          ;
        this._PictureBox3 = value;
        if (this._PictureBox3 == null)
          ;
      }
    }

    internal virtual RadioButton RWButton3
    {
      get => this._RWButton3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._RWButton3 != null)
          this._RWButton3.CheckedChanged -= new EventHandler(this.RWButton3_CheckedChanged);
        this._RWButton3 = value;
        if (this._RWButton3 == null)
          return;
        this._RWButton3.CheckedChanged += new EventHandler(this.RWButton3_CheckedChanged);
      }
    }

    internal virtual PictureBox PictureBox2
    {
      get => this._PictureBox2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._PictureBox2 == null)
          ;
        this._PictureBox2 = value;
        if (this._PictureBox2 == null)
          ;
      }
    }

    internal virtual RadioButton RWButton1
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._RWButton1 != null)
          this._RWButton1.CheckedChanged -= new EventHandler(this.RWButton1_CheckedChanged);
        this._RWButton1 = value;
        if (this._RWButton1 == null)
          return;
        this._RWButton1.CheckedChanged += new EventHandler(this.RWButton1_CheckedChanged);
      }
      get => this._RWButton1;
    }

    internal virtual PictureBox PictureBox1
    {
      get => this._PictureBox1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._PictureBox1 == null)
          ;
        this._PictureBox1 = value;
        if (this._PictureBox1 == null)
          ;
      }
    }

    internal virtual DockControl DockControl3
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._DockControl3 == null)
          ;
        this._DockControl3 = value;
        if (this._DockControl3 == null)
          ;
      }
      get => this._DockControl3;
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

    internal virtual ButtonItem ButtonLeave
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ButtonLeave != null)
          this._ButtonLeave.Activate -= new EventHandler(this.ButtonLeave_Activate);
        this._ButtonLeave = value;
        if (this._ButtonLeave == null)
          return;
        this._ButtonLeave.Activate += new EventHandler(this.ButtonLeave_Activate);
      }
      get => this._ButtonLeave;
    }

    internal virtual ButtonItem ButtonOpen
    {
      get => this._ButtonOpen;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ButtonOpen != null)
          this._ButtonOpen.Activate -= new EventHandler(this.ButtonOpen_Activate);
        this._ButtonOpen = value;
        if (this._ButtonOpen == null)
          return;
        this._ButtonOpen.Activate += new EventHandler(this.ButtonOpen_Activate);
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

    internal virtual ButtonItem ButtonPlus
    {
      get => this._ButtonPlus;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ButtonPlus != null)
          this._ButtonPlus.Activate -= new EventHandler(this.ButtonPlus_Activate);
        this._ButtonPlus = value;
        if (this._ButtonPlus == null)
          return;
        this._ButtonPlus.Activate += new EventHandler(this.ButtonPlus_Activate);
      }
    }

    internal virtual ButtonItem ButtonMinus
    {
      get => this._ButtonMinus;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ButtonMinus != null)
          this._ButtonMinus.Activate -= new EventHandler(this.ButtonMinus_Activate);
        this._ButtonMinus = value;
        if (this._ButtonMinus == null)
          return;
        this._ButtonMinus.Activate += new EventHandler(this.ButtonMinus_Activate);
      }
    }

    internal virtual ButtonItem ButtonDeleteTile
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ButtonDeleteTile != null)
          this._ButtonDeleteTile.Activate -= new EventHandler(this.ButtonDeleteTile_Activate);
        this._ButtonDeleteTile = value;
        if (this._ButtonDeleteTile == null)
          return;
        this._ButtonDeleteTile.Activate += new EventHandler(this.ButtonDeleteTile_Activate);
      }
      get => this._ButtonDeleteTile;
    }

    internal virtual TD.SandBar.ToolBar MainToolBar
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MainToolBar == null)
          ;
        this._MainToolBar = value;
        if (this._MainToolBar == null)
          ;
      }
      get => this._MainToolBar;
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

    internal virtual ToolTip ToolTip1
    {
      get => this._ToolTip1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ToolTip1 == null)
          ;
        this._ToolTip1 = value;
        if (this._ToolTip1 == null)
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
      get => this._StatusBarPanel2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._StatusBarPanel2 == null)
          ;
        this._StatusBarPanel2 = value;
        if (this._StatusBarPanel2 == null)
          ;
      }
    }

    internal virtual ErrorProvider ErrorProvider1
    {
      get => this._ErrorProvider1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ErrorProvider1 == null)
          ;
        this._ErrorProvider1 = value;
        if (this._ErrorProvider1 == null)
          ;
      }
    }

    internal virtual DockControl DockControl7
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._DockControl7 == null)
          ;
        this._DockControl7 = value;
        if (this._DockControl7 == null)
          ;
      }
      get => this._DockControl7;
    }

    internal virtual Panel TransitSwitchPanel
    {
      get => this._TransitSwitchPanel;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._TransitSwitchPanel == null)
          ;
        this._TransitSwitchPanel = value;
        if (this._TransitSwitchPanel == null)
          ;
      }
    }

    internal virtual TD.SandBar.ToolBar TransitSwitchToolBar
    {
      get => this._TransitSwitchToolBar;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._TransitSwitchToolBar == null)
          ;
        this._TransitSwitchToolBar = value;
        if (this._TransitSwitchToolBar == null)
          ;
      }
    }

    internal virtual ButtonItem TransitSwitchButton1
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._TransitSwitchButton1 != null)
          this._TransitSwitchButton1.Activate -= new EventHandler(this.TransitSwitchButton1_Activate_1);
        this._TransitSwitchButton1 = value;
        if (this._TransitSwitchButton1 == null)
          return;
        this._TransitSwitchButton1.Activate += new EventHandler(this.TransitSwitchButton1_Activate_1);
      }
      get => this._TransitSwitchButton1;
    }

    internal virtual Grid TransitSwitchGrid
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._TransitSwitchGrid == null)
          ;
        this._TransitSwitchGrid = value;
        if (this._TransitSwitchGrid == null)
          ;
      }
      get => this._TransitSwitchGrid;
    }

    internal virtual DropDownMenuItem ModusMenu
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ModusMenu == null)
          ;
        this._ModusMenu = value;
        if (this._ModusMenu == null)
          ;
      }
      get => this._ModusMenu;
    }

    internal virtual MenuButtonItem ModusMenuItem1
    {
      get => this._ModusMenuItem1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ModusMenuItem1 != null)
          this._ModusMenuItem1.Activate -= new EventHandler(this.ModusMenuItem1_Activate);
        this._ModusMenuItem1 = value;
        if (this._ModusMenuItem1 == null)
          return;
        this._ModusMenuItem1.Activate += new EventHandler(this.ModusMenuItem1_Activate);
      }
    }

    internal virtual MenuButtonItem ModusMenuItem2
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ModusMenuItem2 != null)
          this._ModusMenuItem2.Activate -= new EventHandler(this.ModusMenuItem2_Activate);
        this._ModusMenuItem2 = value;
        if (this._ModusMenuItem2 == null)
          return;
        this._ModusMenuItem2.Activate += new EventHandler(this.ModusMenuItem2_Activate);
      }
      get => this._ModusMenuItem2;
    }

    internal virtual DropDownMenuItem MenuDisplay
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuDisplay == null)
          ;
        this._MenuDisplay = value;
        if (this._MenuDisplay == null)
          ;
      }
      get => this._MenuDisplay;
    }

    internal virtual MenuButtonItem MenuDisplayItem1
    {
      get => this._MenuDisplayItem1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuDisplayItem1 != null)
          this._MenuDisplayItem1.Activate -= new EventHandler(this.MenuDisplayItem1_Activate);
        this._MenuDisplayItem1 = value;
        if (this._MenuDisplayItem1 == null)
          return;
        this._MenuDisplayItem1.Activate += new EventHandler(this.MenuDisplayItem1_Activate);
      }
    }

    internal virtual MenuButtonItem MenuDisplayItem2
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuDisplayItem2 != null)
          this._MenuDisplayItem2.Activate -= new EventHandler(this.MenuDisplayItem2_Activate);
        this._MenuDisplayItem2 = value;
        if (this._MenuDisplayItem2 == null)
          return;
        this._MenuDisplayItem2.Activate += new EventHandler(this.MenuDisplayItem2_Activate);
      }
      get => this._MenuDisplayItem2;
    }

    internal virtual Panel RepPanel
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._RepPanel == null)
          ;
        this._RepPanel = value;
        if (this._RepPanel == null)
          ;
      }
      get => this._RepPanel;
    }

    internal virtual Grid RepGrid
    {
      get => this._RepGrid;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._RepGrid == null)
          ;
        this._RepGrid = value;
        if (this._RepGrid == null)
          ;
      }
    }

    internal virtual Splitter Splitter3
    {
      get => this._Splitter3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Splitter3 == null)
          ;
        this._Splitter3 = value;
        if (this._Splitter3 == null)
          ;
      }
    }

    internal virtual Panel LotPanel
    {
      get => this._LotPanel;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._LotPanel == null)
          ;
        this._LotPanel = value;
        if (this._LotPanel == null)
          ;
      }
    }

    internal virtual graphicgrid Graphicgrid1
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Graphicgrid1 != null)
        {
          this._Graphicgrid1.gridMouseDown -= new graphicgrid.gridMouseDownEventHandler(this.Graphicgrid1_gridMouseDown);
          this._Graphicgrid1.gridClick -= new graphicgrid.gridClickEventHandler(this.Graphicgrid1_gridClick);
          this._Graphicgrid1.DragOver -= new DragEventHandler(this.Graphicgrid1_DragOver);
          this._Graphicgrid1.DragDrop -= new DragEventHandler(this.Graphicgrid1_DragDrop);
          this._Graphicgrid1.DragEnter -= new DragEventHandler(this.Graphicgrid1_DragEnter);
        }
        this._Graphicgrid1 = value;
        if (this._Graphicgrid1 == null)
          return;
        this._Graphicgrid1.gridMouseDown += new graphicgrid.gridMouseDownEventHandler(this.Graphicgrid1_gridMouseDown);
        this._Graphicgrid1.gridClick += new graphicgrid.gridClickEventHandler(this.Graphicgrid1_gridClick);
        this._Graphicgrid1.DragOver += new DragEventHandler(this.Graphicgrid1_DragOver);
        this._Graphicgrid1.DragDrop += new DragEventHandler(this.Graphicgrid1_DragDrop);
        this._Graphicgrid1.DragEnter += new DragEventHandler(this.Graphicgrid1_DragEnter);
      }
      get => this._Graphicgrid1;
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

    internal virtual Splitter Splitter4
    {
      get => this._Splitter4;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Splitter4 == null)
          ;
        this._Splitter4 = value;
        if (this._Splitter4 == null)
          ;
      }
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

    internal virtual Panel TransitPanel
    {
      get => this._TransitPanel;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._TransitPanel == null)
          ;
        this._TransitPanel = value;
        if (this._TransitPanel == null)
          ;
      }
    }

    internal virtual GroupBox GroupBox5
    {
      get => this._GroupBox5;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._GroupBox5 == null)
          ;
        this._GroupBox5 = value;
        if (this._GroupBox5 == null)
          ;
      }
    }

    internal virtual Label T_Label_6
    {
      get => this._T_Label_6;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._T_Label_6 == null)
          ;
        this._T_Label_6 = value;
        if (this._T_Label_6 == null)
          ;
      }
    }

    internal virtual Label T_Label_5
    {
      get => this._T_Label_5;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._T_Label_5 == null)
          ;
        this._T_Label_5 = value;
        if (this._T_Label_5 == null)
          ;
      }
    }

    internal virtual Label T_Label_4
    {
      get => this._T_Label_4;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._T_Label_4 == null)
          ;
        this._T_Label_4 = value;
        if (this._T_Label_4 == null)
          ;
      }
    }

    internal virtual PictureBox T6_Picture_1
    {
      get => this._T6_Picture_1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._T6_Picture_1 != null)
        {
          this._T6_Picture_1.MouseMove -= new MouseEventHandler(this.T6_Picture_1_MouseMove);
          this._T6_Picture_1.MouseDown -= new MouseEventHandler(this.T6_Picture_1_MouseDown);
        }
        this._T6_Picture_1 = value;
        if (this._T6_Picture_1 == null)
          return;
        this._T6_Picture_1.MouseMove += new MouseEventHandler(this.T6_Picture_1_MouseMove);
        this._T6_Picture_1.MouseDown += new MouseEventHandler(this.T6_Picture_1_MouseDown);
      }
    }

    internal virtual PictureBox T5_Picture_1
    {
      get => this._T5_Picture_1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._T5_Picture_1 != null)
        {
          this._T5_Picture_1.MouseMove -= new MouseEventHandler(this.T5_Picture_1_MouseMove);
          this._T5_Picture_1.MouseDown -= new MouseEventHandler(this.T5_Picture_1_MouseDown);
        }
        this._T5_Picture_1 = value;
        if (this._T5_Picture_1 == null)
          return;
        this._T5_Picture_1.MouseMove += new MouseEventHandler(this.T5_Picture_1_MouseMove);
        this._T5_Picture_1.MouseDown += new MouseEventHandler(this.T5_Picture_1_MouseDown);
      }
    }

    internal virtual PictureBox T4_Picture_1
    {
      get => this._T4_Picture_1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._T4_Picture_1 != null)
        {
          this._T4_Picture_1.MouseMove -= new MouseEventHandler(this.T4_Picture_1_MouseMove);
          this._T4_Picture_1.MouseDown -= new MouseEventHandler(this.T4_Picture_1_MouseDown);
        }
        this._T4_Picture_1 = value;
        if (this._T4_Picture_1 == null)
          return;
        this._T4_Picture_1.MouseMove += new MouseEventHandler(this.T4_Picture_1_MouseMove);
        this._T4_Picture_1.MouseDown += new MouseEventHandler(this.T4_Picture_1_MouseDown);
      }
    }

    internal virtual RadioButton DirButton2
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._DirButton2 == null)
          ;
        this._DirButton2 = value;
        if (this._DirButton2 == null)
          ;
      }
      get => this._DirButton2;
    }

    internal virtual PictureBox PictureBox8
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._PictureBox8 == null)
          ;
        this._PictureBox8 = value;
        if (this._PictureBox8 == null)
          ;
      }
      get => this._PictureBox8;
    }

    internal virtual RadioButton DirButton1
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._DirButton1 == null)
          ;
        this._DirButton1 = value;
        if (this._DirButton1 == null)
          ;
      }
      get => this._DirButton1;
    }

    internal virtual PictureBox PictureBox7
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._PictureBox7 == null)
          ;
        this._PictureBox7 = value;
        if (this._PictureBox7 == null)
          ;
      }
      get => this._PictureBox7;
    }

    internal virtual Label T_Label_9
    {
      get => this._T_Label_9;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._T_Label_9 == null)
          ;
        this._T_Label_9 = value;
        if (this._T_Label_9 == null)
          ;
      }
    }

    internal virtual Label T_Label_8
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._T_Label_8 == null)
          ;
        this._T_Label_8 = value;
        if (this._T_Label_8 == null)
          ;
      }
      get => this._T_Label_8;
    }

    internal virtual Label T_Label_7
    {
      get => this._T_Label_7;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._T_Label_7 == null)
          ;
        this._T_Label_7 = value;
        if (this._T_Label_7 == null)
          ;
      }
    }

    internal virtual Label T_Label_2
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._T_Label_2 == null)
          ;
        this._T_Label_2 = value;
        if (this._T_Label_2 == null)
          ;
      }
      get => this._T_Label_2;
    }

    internal virtual Label T_Label_1
    {
      get => this._T_Label_1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._T_Label_1 == null)
          ;
        this._T_Label_1 = value;
        if (this._T_Label_1 == null)
          ;
      }
    }

    internal virtual Label T_Label_3
    {
      get => this._T_Label_3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._T_Label_3 == null)
          ;
        this._T_Label_3 = value;
        if (this._T_Label_3 == null)
          ;
      }
    }

    internal virtual PictureBox T9_Picture_1
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._T9_Picture_1 != null)
        {
          this._T9_Picture_1.MouseMove -= new MouseEventHandler(this.T9_Picture_1_MouseMove);
          this._T9_Picture_1.MouseDown -= new MouseEventHandler(this.T9_Picture_1_MouseDown);
        }
        this._T9_Picture_1 = value;
        if (this._T9_Picture_1 == null)
          return;
        this._T9_Picture_1.MouseMove += new MouseEventHandler(this.T9_Picture_1_MouseMove);
        this._T9_Picture_1.MouseDown += new MouseEventHandler(this.T9_Picture_1_MouseDown);
      }
      get => this._T9_Picture_1;
    }

    internal virtual PictureBox T7_Picture_1
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._T7_Picture_1 != null)
        {
          this._T7_Picture_1.MouseMove -= new MouseEventHandler(this.T7_Picture_1_MouseMove);
          this._T7_Picture_1.MouseDown -= new MouseEventHandler(this.T7_Picture_1_MouseDown);
        }
        this._T7_Picture_1 = value;
        if (this._T7_Picture_1 == null)
          return;
        this._T7_Picture_1.MouseMove += new MouseEventHandler(this.T7_Picture_1_MouseMove);
        this._T7_Picture_1.MouseDown += new MouseEventHandler(this.T7_Picture_1_MouseDown);
      }
      get => this._T7_Picture_1;
    }

    internal virtual PictureBox T8_Picture_1
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._T8_Picture_1 != null)
        {
          this._T8_Picture_1.MouseMove -= new MouseEventHandler(this.T8_Picture_1_MouseMove);
          this._T8_Picture_1.MouseDown -= new MouseEventHandler(this.T8_Picture_1_MouseDown);
        }
        this._T8_Picture_1 = value;
        if (this._T8_Picture_1 == null)
          return;
        this._T8_Picture_1.MouseMove += new MouseEventHandler(this.T8_Picture_1_MouseMove);
        this._T8_Picture_1.MouseDown += new MouseEventHandler(this.T8_Picture_1_MouseDown);
      }
      get => this._T8_Picture_1;
    }

    internal virtual PictureBox T3_Picture_1
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._T3_Picture_1 != null)
        {
          this._T3_Picture_1.MouseMove -= new MouseEventHandler(this.T3_Picture_1_MouseMove);
          this._T3_Picture_1.MouseDown -= new MouseEventHandler(this.T3_Picture_1_MouseDown);
        }
        this._T3_Picture_1 = value;
        if (this._T3_Picture_1 == null)
          return;
        this._T3_Picture_1.MouseMove += new MouseEventHandler(this.T3_Picture_1_MouseMove);
        this._T3_Picture_1.MouseDown += new MouseEventHandler(this.T3_Picture_1_MouseDown);
      }
      get => this._T3_Picture_1;
    }

    internal virtual PictureBox T2_Picture_1
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._T2_Picture_1 != null)
        {
          this._T2_Picture_1.MouseMove -= new MouseEventHandler(this.T2_Picture_1_MouseMove);
          this._T2_Picture_1.MouseDown -= new MouseEventHandler(this.T2_Picture_1_MouseDown);
        }
        this._T2_Picture_1 = value;
        if (this._T2_Picture_1 == null)
          return;
        this._T2_Picture_1.MouseMove += new MouseEventHandler(this.T2_Picture_1_MouseMove);
        this._T2_Picture_1.MouseDown += new MouseEventHandler(this.T2_Picture_1_MouseDown);
      }
      get => this._T2_Picture_1;
    }

    internal virtual PictureBox T1_Picture_1
    {
      get => this._T1_Picture_1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._T1_Picture_1 != null)
        {
          this._T1_Picture_1.MouseMove -= new MouseEventHandler(this.T1_Picture_1_MouseMove);
          this._T1_Picture_1.MouseDown -= new MouseEventHandler(this.T1_Picture_1_MouseDown);
        }
        this._T1_Picture_1 = value;
        if (this._T1_Picture_1 == null)
          return;
        this._T1_Picture_1.MouseMove += new MouseEventHandler(this.T1_Picture_1_MouseMove);
        this._T1_Picture_1.MouseDown += new MouseEventHandler(this.T1_Picture_1_MouseDown);
      }
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

    internal virtual System.Windows.Forms.CheckBox CheckSouth
    {
      get => this._CheckSouth;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._CheckSouth == null)
          ;
        this._CheckSouth = value;
        if (this._CheckSouth == null)
          ;
      }
    }

    internal virtual System.Windows.Forms.CheckBox CheckWest
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._CheckWest == null)
          ;
        this._CheckWest = value;
        if (this._CheckWest == null)
          ;
      }
      get => this._CheckWest;
    }

    internal virtual System.Windows.Forms.CheckBox CheckEast
    {
      get => this._CheckEast;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._CheckEast == null)
          ;
        this._CheckEast = value;
        if (this._CheckEast == null)
          ;
      }
    }

    internal virtual System.Windows.Forms.CheckBox CheckNorth
    {
      get => this._CheckNorth;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._CheckNorth == null)
          ;
        this._CheckNorth = value;
        if (this._CheckNorth == null)
          ;
      }
    }

    internal virtual ButtonItem ButtonShowReps
    {
      get => this._ButtonShowReps;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ButtonShowReps != null)
          this._ButtonShowReps.Activate -= new EventHandler(this.ButtonShowReps_Activate);
        this._ButtonShowReps = value;
        if (this._ButtonShowReps == null)
          return;
        this._ButtonShowReps.Activate += new EventHandler(this.ButtonShowReps_Activate);
      }
    }

    internal virtual Grid TextureGrid
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._TextureGrid == null)
          ;
        this._TextureGrid = value;
        if (this._TextureGrid == null)
          ;
      }
      get => this._TextureGrid;
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      ResourceManager resourceManager = new ResourceManager(typeof (FormLotEditor));
      this.MainToolBar = new TD.SandBar.ToolBar();
      this.ImageList1 = new ImageList(this.components);
      this.ButtonLeave = new ButtonItem();
      this.ButtonOpen = new ButtonItem();
      this.ButtonSave = new ButtonItem();
      this.ModusMenu = new DropDownMenuItem();
      this.ModusMenuItem1 = new MenuButtonItem();
      this.ModusMenuItem2 = new MenuButtonItem();
      this.StatusBar1 = new StatusBar();
      this.StatusBarPanel1 = new StatusBarPanel();
      this.StatusBarPanel2 = new StatusBarPanel();
      this.StatusBarPanel3 = new StatusBarPanel();
      this.Panel1 = new Panel();
      this.TreeView1 = new TreeView();
      this.HeaderControl1 = new HeaderControl();
      this.DocumentContainer1 = new DocumentContainer();
      this.DockControl1 = new DockControl();
      this.CommonPanel = new Panel();
      this.GroupBox4 = new GroupBox();
      this.GrowthText = new TextBox();
      this.Label13 = new Label();
      this.GroupBox3 = new GroupBox();
      this.LotMinText = new TextBox();
      this.LotMaxText = new TextBox();
      this.Label14 = new Label();
      this.Label15 = new Label();
      this.GroupBox1 = new GroupBox();
      this.CornerButton3 = new RadioButton();
      this.CornerButton2 = new RadioButton();
      this.CornerButton1 = new RadioButton();
      this.TRPicture3 = new PictureBox();
      this.TRPicture2 = new PictureBox();
      this.TRPicture1 = new PictureBox();
      this.GroupBox2 = new GroupBox();
      this.Label12 = new Label();
      this.FoundationText = new TextBox();
      this.ThresholdText = new TextBox();
      this.Label11 = new Label();
      this.Label10 = new Label();
      this.RWButton2 = new RadioButton();
      this.PictureBox6 = new PictureBox();
      this.RWButton4 = new RadioButton();
      this.PictureBox5 = new PictureBox();
      this.RWButton6 = new RadioButton();
      this.PictureBox4 = new PictureBox();
      this.RWButton5 = new RadioButton();
      this.PictureBox3 = new PictureBox();
      this.RWButton3 = new RadioButton();
      this.PictureBox2 = new PictureBox();
      this.RWButton1 = new RadioButton();
      this.PictureBox1 = new PictureBox();
      this.DockControl3 = new DockControl();
      this.TransitPanel = new Panel();
      this.GroupBox5 = new GroupBox();
      this.T_Label_6 = new Label();
      this.T_Label_5 = new Label();
      this.T_Label_4 = new Label();
      this.T6_Picture_1 = new PictureBox();
      this.T5_Picture_1 = new PictureBox();
      this.T4_Picture_1 = new PictureBox();
      this.DirButton2 = new RadioButton();
      this.PictureBox8 = new PictureBox();
      this.DirButton1 = new RadioButton();
      this.PictureBox7 = new PictureBox();
      this.T_Label_9 = new Label();
      this.T_Label_8 = new Label();
      this.T_Label_7 = new Label();
      this.T_Label_2 = new Label();
      this.T_Label_1 = new Label();
      this.T_Label_3 = new Label();
      this.T9_Picture_1 = new PictureBox();
      this.T7_Picture_1 = new PictureBox();
      this.T8_Picture_1 = new PictureBox();
      this.T3_Picture_1 = new PictureBox();
      this.T2_Picture_1 = new PictureBox();
      this.T1_Picture_1 = new PictureBox();
      this.PictureBox11 = new PictureBox();
      this.CheckSouth = new System.Windows.Forms.CheckBox();
      this.CheckWest = new System.Windows.Forms.CheckBox();
      this.CheckEast = new System.Windows.Forms.CheckBox();
      this.CheckNorth = new System.Windows.Forms.CheckBox();
      this.Splitter4 = new Splitter();
      this.LotPanel = new Panel();
      this.Graphicgrid1 = new graphicgrid();
      this.Splitter3 = new Splitter();
      this.RepPanel = new Panel();
      this.RepGrid = new Grid();
      this.TextureGrid = new Grid();
      this.ToolBar1 = new TD.SandBar.ToolBar();
      this.ButtonPlus = new ButtonItem();
      this.ButtonMinus = new ButtonItem();
      this.MenuDisplay = new DropDownMenuItem();
      this.MenuDisplayItem1 = new MenuButtonItem();
      this.MenuDisplayItem2 = new MenuButtonItem();
      this.ButtonShowReps = new ButtonItem();
      this.DockControl7 = new DockControl();
      this.TransitSwitchPanel = new Panel();
      this.TransitSwitchGrid = new Grid();
      this.TransitSwitchToolBar = new TD.SandBar.ToolBar();
      this.TransitSwitchButton1 = new ButtonItem();
      this.ButtonDeleteTile = new ButtonItem();
      this.ToolTip1 = new ToolTip(this.components);
      this.ErrorProvider1 = new ErrorProvider();
      this.Splitter1 = new Splitter();
      this.StatusBarPanel1.BeginInit();
      this.StatusBarPanel2.BeginInit();
      this.StatusBarPanel3.BeginInit();
      this.Panel1.SuspendLayout();
      this.HeaderControl1.SuspendLayout();
      this.DocumentContainer1.SuspendLayout();
      this.DockControl1.SuspendLayout();
      this.CommonPanel.SuspendLayout();
      this.GroupBox4.SuspendLayout();
      this.GroupBox3.SuspendLayout();
      this.GroupBox1.SuspendLayout();
      this.GroupBox2.SuspendLayout();
      this.DockControl3.SuspendLayout();
      this.TransitPanel.SuspendLayout();
      this.GroupBox5.SuspendLayout();
      this.LotPanel.SuspendLayout();
      this.RepPanel.SuspendLayout();
      this.DockControl7.SuspendLayout();
      this.TransitSwitchPanel.SuspendLayout();
      this.SuspendLayout();
      TD.SandBar.ToolBar mainToolBar1 = this.MainToolBar;
      Guid guid1 = new Guid("16e54b79-d274-47e3-8346-b88da3aee34c");
      Guid guid2 = guid1;
      mainToolBar1.Guid = guid2;
      this.MainToolBar.ImageList = this.ImageList1;
      this.MainToolBar.Items.AddRange(new ToolbarItemBase[3]
      {
        (ToolbarItemBase) this.ButtonLeave,
        (ToolbarItemBase) this.ButtonOpen,
        (ToolbarItemBase) this.ButtonSave
      });
      TD.SandBar.ToolBar mainToolBar2 = this.MainToolBar;
      Point point1 = new Point(0, 0);
      Point point2 = point1;
      mainToolBar2.Location = point2;
      this.MainToolBar.Name = "MainToolBar";
      TD.SandBar.ToolBar mainToolBar3 = this.MainToolBar;
      Size size1 = new Size(787, 24);
      Size size2 = size1;
      mainToolBar3.Size = size2;
      this.MainToolBar.TabIndex = 0;
      this.MainToolBar.Text = "MainToolBar";
      ImageList imageList1 = this.ImageList1;
      size1 = new Size(16, 16);
      Size size3 = size1;
      imageList1.ImageSize = size3;
      this.ImageList1.ImageStream = (ImageListStreamer) resourceManager.GetObject("ImageList1.ImageStream");
      this.ImageList1.TransparentColor = Color.Transparent;
      this.ButtonLeave.BeginGroup = true;
      this.ButtonLeave.ImageIndex = 0;
      this.ButtonOpen.BeginGroup = true;
      this.ButtonOpen.ImageIndex = 19;
      this.ButtonSave.BeginGroup = true;
      this.ButtonSave.ImageIndex = 3;
      this.ModusMenu.BeginGroup = true;
      this.ModusMenu.Items.AddRange(new ToolbarItemBase[2]
      {
        (ToolbarItemBase) this.ModusMenuItem1,
        (ToolbarItemBase) this.ModusMenuItem2
      });
      this.ModusMenu.Text = "Mode";
      this.ModusMenuItem1.Checked = true;
      this.ModusMenuItem1.Text = "Standard";
      this.ModusMenuItem2.BeginGroup = true;
      this.ModusMenuItem2.Text = "Expert";
      StatusBar statusBar1_1 = this.StatusBar1;
      point1 = new Point(0, 544);
      Point point3 = point1;
      statusBar1_1.Location = point3;
      this.StatusBar1.Name = "StatusBar1";
      this.StatusBar1.Panels.AddRange(new StatusBarPanel[3]
      {
        this.StatusBarPanel1,
        this.StatusBarPanel2,
        this.StatusBarPanel3
      });
      this.StatusBar1.ShowPanels = true;
      StatusBar statusBar1_2 = this.StatusBar1;
      size1 = new Size(787, 24);
      Size size4 = size1;
      statusBar1_2.Size = size4;
      this.StatusBar1.TabIndex = 1;
      this.StatusBar1.Text = "StatusBar1";
      this.StatusBarPanel2.AutoSize = StatusBarPanelAutoSize.Spring;
      this.StatusBarPanel2.Width = 661;
      this.StatusBarPanel3.Alignment = HorizontalAlignment.Center;
      this.StatusBarPanel3.AutoSize = StatusBarPanelAutoSize.Contents;
      this.StatusBarPanel3.Width = 10;
      this.Panel1.Controls.Add((Control) this.TreeView1);
      this.Panel1.Dock = DockStyle.Left;
      Panel panel1_1 = this.Panel1;
      point1 = new Point(0, 24);
      Point point4 = point1;
      panel1_1.Location = point4;
      this.Panel1.Name = "Panel1";
      Panel panel1_2 = this.Panel1;
      size1 = new Size(184, 520);
      Size size5 = size1;
      panel1_2.Size = size5;
      this.Panel1.TabIndex = 2;
      this.TreeView1.Dock = DockStyle.Fill;
      this.TreeView1.ImageList = this.ImageList1;
      TreeView treeView1_1 = this.TreeView1;
      point1 = new Point(0, 0);
      Point point5 = point1;
      treeView1_1.Location = point5;
      this.TreeView1.Name = "TreeView1";
      TreeView treeView1_2 = this.TreeView1;
      size1 = new Size(184, 520);
      Size size6 = size1;
      treeView1_2.Size = size6;
      this.TreeView1.TabIndex = 0;
      this.HeaderControl1.Controls.Add((Control) this.DocumentContainer1);
      this.HeaderControl1.Dock = DockStyle.Fill;
      this.HeaderControl1.HeaderFont = new Font("Tahoma", 12f, FontStyle.Bold);
      HeaderControl headerControl1_1 = this.HeaderControl1;
      point1 = new Point(192, 24);
      Point point6 = point1;
      headerControl1_1.Location = point6;
      this.HeaderControl1.Name = "HeaderControl1";
      HeaderControl headerControl1_2 = this.HeaderControl1;
      size1 = new Size(595, 520);
      Size size7 = size1;
      headerControl1_2.Size = size7;
      this.HeaderControl1.TabIndex = 4;
      this.HeaderControl1.Text = "HeaderControl1";
      this.DocumentContainer1.Controls.Add((Control) this.DockControl1);
      this.DocumentContainer1.Controls.Add((Control) this.DockControl3);
      this.DocumentContainer1.Controls.Add((Control) this.DockControl7);
      DocumentContainer documentContainer1_1 = this.DocumentContainer1;
      guid1 = new Guid("54eeafb8-0fea-4a38-8eaf-4ec7bc47bce8");
      Guid guid3 = guid1;
      documentContainer1_1.Guid = guid3;
      this.DocumentContainer1.LayoutSystem = new SplitLayoutSystem(250, 400, Orientation.Horizontal, new LayoutSystemBase[1]
      {
        (LayoutSystemBase) new DocumentLayoutSystem(591, 491, new DockControl[3]
        {
          this.DockControl3,
          this.DockControl7,
          this.DockControl1
        }, this.DockControl7)
      });
      DocumentContainer documentContainer1_2 = this.DocumentContainer1;
      point1 = new Point(1, 26);
      Point point7 = point1;
      documentContainer1_2.Location = point7;
      this.DocumentContainer1.Manager = (SandDockManager) null;
      this.DocumentContainer1.Name = "DocumentContainer1";
      DocumentContainer documentContainer1_3 = this.DocumentContainer1;
      size1 = new Size(593, 493);
      Size size8 = size1;
      documentContainer1_3.Size = size8;
      this.DocumentContainer1.TabIndex = 1;
      this.DockControl1.Closable = false;
      this.DockControl1.Collapsible = false;
      this.DockControl1.Controls.Add((Control) this.CommonPanel);
      this.DockControl1.Floatable = false;
      DockControl dockControl1_1 = this.DockControl1;
      guid1 = new Guid("f285bd9f-d796-45e6-87a9-85a600418c3b");
      Guid guid4 = guid1;
      dockControl1_1.Guid = guid4;
      DockControl dockControl1_2 = this.DockControl1;
      point1 = new Point(3, 23);
      Point point8 = point1;
      dockControl1_2.Location = point8;
      this.DockControl1.Name = "DockControl1";
      DockControl dockControl1_3 = this.DockControl1;
      size1 = new Size(587, 467);
      Size size9 = size1;
      dockControl1_3.Size = size9;
      this.DockControl1.TabIndex = 0;
      this.DockControl1.Text = "Common";
      this.DockControl1.Visible = false;
      this.CommonPanel.AutoScroll = true;
      this.CommonPanel.Controls.Add((Control) this.GroupBox4);
      this.CommonPanel.Controls.Add((Control) this.GroupBox3);
      this.CommonPanel.Controls.Add((Control) this.GroupBox1);
      this.CommonPanel.Controls.Add((Control) this.GroupBox2);
      this.CommonPanel.Dock = DockStyle.Fill;
      Panel commonPanel1 = this.CommonPanel;
      point1 = new Point(0, 0);
      Point point9 = point1;
      commonPanel1.Location = point9;
      this.CommonPanel.Name = "CommonPanel";
      Panel commonPanel2 = this.CommonPanel;
      size1 = new Size(587, 467);
      Size size10 = size1;
      commonPanel2.Size = size10;
      this.CommonPanel.TabIndex = 0;
      this.GroupBox4.Controls.Add((Control) this.GrowthText);
      this.GroupBox4.Controls.Add((Control) this.Label13);
      GroupBox groupBox4_1 = this.GroupBox4;
      point1 = new Point(224, 104);
      Point point10 = point1;
      groupBox4_1.Location = point10;
      this.GroupBox4.Name = "GroupBox4";
      GroupBox groupBox4_2 = this.GroupBox4;
      size1 = new Size(176, 184);
      Size size11 = size1;
      groupBox4_2.Size = size11;
      this.GroupBox4.TabIndex = 24;
      this.GroupBox4.TabStop = false;
      this.GroupBox4.Visible = false;
      TextBox growthText1 = this.GrowthText;
      point1 = new Point(100, 24);
      Point point11 = point1;
      growthText1.Location = point11;
      this.GrowthText.MaxLength = 3;
      this.GrowthText.Name = "GrowthText";
      TextBox growthText2 = this.GrowthText;
      size1 = new Size(40, 20);
      Size size12 = size1;
      growthText2.Size = size12;
      this.GrowthText.TabIndex = 31;
      this.GrowthText.Text = "";
      this.GrowthText.TextAlign = HorizontalAlignment.Center;
      Label label13_1 = this.Label13;
      point1 = new Point(12, 24);
      Point point12 = point1;
      label13_1.Location = point12;
      this.Label13.Name = "Label13";
      Label label13_2 = this.Label13;
      size1 = new Size(72, 22);
      Size size13 = size1;
      label13_2.Size = size13;
      this.Label13.TabIndex = 30;
      this.Label13.Text = "Growth";
      this.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.GroupBox3.Controls.Add((Control) this.LotMinText);
      this.GroupBox3.Controls.Add((Control) this.LotMaxText);
      this.GroupBox3.Controls.Add((Control) this.Label14);
      this.GroupBox3.Controls.Add((Control) this.Label15);
      GroupBox groupBox3_1 = this.GroupBox3;
      point1 = new Point(224, 300);
      Point point13 = point1;
      groupBox3_1.Location = point13;
      this.GroupBox3.Name = "GroupBox3";
      GroupBox groupBox3_2 = this.GroupBox3;
      size1 = new Size(176, 108);
      Size size14 = size1;
      groupBox3_2.Size = size14;
      this.GroupBox3.TabIndex = 23;
      this.GroupBox3.TabStop = false;
      this.GroupBox3.Text = "Elevation Change";
      this.GroupBox3.Visible = false;
      TextBox lotMinText1 = this.LotMinText;
      point1 = new Point(104, 64);
      Point point14 = point1;
      lotMinText1.Location = point14;
      this.LotMinText.MaxLength = 6;
      this.LotMinText.Name = "LotMinText";
      TextBox lotMinText2 = this.LotMinText;
      size1 = new Size(48, 20);
      Size size15 = size1;
      lotMinText2.Size = size15;
      this.LotMinText.TabIndex = 30;
      this.LotMinText.Text = "";
      this.LotMinText.TextAlign = HorizontalAlignment.Center;
      TextBox lotMaxText1 = this.LotMaxText;
      point1 = new Point(104, 32);
      Point point15 = point1;
      lotMaxText1.Location = point15;
      this.LotMaxText.MaxLength = 6;
      this.LotMaxText.Name = "LotMaxText";
      TextBox lotMaxText2 = this.LotMaxText;
      size1 = new Size(48, 20);
      Size size16 = size1;
      lotMaxText2.Size = size16;
      this.LotMaxText.TabIndex = 29;
      this.LotMaxText.Text = "";
      this.LotMaxText.TextAlign = HorizontalAlignment.Center;
      Label label14_1 = this.Label14;
      point1 = new Point(16, 64);
      Point point16 = point1;
      label14_1.Location = point16;
      this.Label14.Name = "Label14";
      Label label14_2 = this.Label14;
      size1 = new Size(72, 16);
      Size size17 = size1;
      label14_2.Size = size17;
      this.Label14.TabIndex = 28;
      this.Label14.Text = "Lot Min";
      Label label15_1 = this.Label15;
      point1 = new Point(16, 32);
      Point point17 = point1;
      label15_1.Location = point17;
      this.Label15.Name = "Label15";
      Label label15_2 = this.Label15;
      size1 = new Size(72, 22);
      Size size18 = size1;
      label15_2.Size = size18;
      this.Label15.TabIndex = 27;
      this.Label15.Text = "Lot Max";
      this.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.GroupBox1.Controls.Add((Control) this.CornerButton3);
      this.GroupBox1.Controls.Add((Control) this.CornerButton2);
      this.GroupBox1.Controls.Add((Control) this.CornerButton1);
      this.GroupBox1.Controls.Add((Control) this.TRPicture3);
      this.GroupBox1.Controls.Add((Control) this.TRPicture2);
      this.GroupBox1.Controls.Add((Control) this.TRPicture1);
      GroupBox groupBox1_1 = this.GroupBox1;
      point1 = new Point(224, 4);
      Point point18 = point1;
      groupBox1_1.Location = point18;
      this.GroupBox1.Name = "GroupBox1";
      GroupBox groupBox1_2 = this.GroupBox1;
      size1 = new Size(176, 88);
      Size size19 = size1;
      groupBox1_2.Size = size19;
      this.GroupBox1.TabIndex = 22;
      this.GroupBox1.TabStop = false;
      this.GroupBox1.Text = "Corners";
      this.CornerButton3.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
      RadioButton cornerButton3_1 = this.CornerButton3;
      point1 = new Point(128, 64);
      Point point19 = point1;
      cornerButton3_1.Location = point19;
      this.CornerButton3.Name = "CornerButton3";
      RadioButton cornerButton3_2 = this.CornerButton3;
      size1 = new Size(32, 16);
      Size size20 = size1;
      cornerButton3_2.Size = size20;
      this.CornerButton3.TabIndex = 5;
      this.CornerButton2.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
      RadioButton cornerButton2_1 = this.CornerButton2;
      point1 = new Point(72, 64);
      Point point20 = point1;
      cornerButton2_1.Location = point20;
      this.CornerButton2.Name = "CornerButton2";
      RadioButton cornerButton2_2 = this.CornerButton2;
      size1 = new Size(32, 16);
      Size size21 = size1;
      cornerButton2_2.Size = size21;
      this.CornerButton2.TabIndex = 4;
      this.CornerButton1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
      RadioButton cornerButton1_1 = this.CornerButton1;
      point1 = new Point(16, 64);
      Point point21 = point1;
      cornerButton1_1.Location = point21;
      this.CornerButton1.Name = "CornerButton1";
      RadioButton cornerButton1_2 = this.CornerButton1;
      size1 = new Size(32, 16);
      Size size22 = size1;
      cornerButton1_2.Size = size22;
      this.CornerButton1.TabIndex = 3;
      this.TRPicture3.Image = (Image) resourceManager.GetObject("TRPicture3.Image");
      PictureBox trPicture3_1 = this.TRPicture3;
      point1 = new Point(128, 24);
      Point point22 = point1;
      trPicture3_1.Location = point22;
      this.TRPicture3.Name = "TRPicture3";
      PictureBox trPicture3_2 = this.TRPicture3;
      size1 = new Size(30, 30);
      Size size23 = size1;
      trPicture3_2.Size = size23;
      this.TRPicture3.TabIndex = 2;
      this.TRPicture3.TabStop = false;
      this.TRPicture2.Image = (Image) resourceManager.GetObject("TRPicture2.Image");
      PictureBox trPicture2_1 = this.TRPicture2;
      point1 = new Point(72, 24);
      Point point23 = point1;
      trPicture2_1.Location = point23;
      this.TRPicture2.Name = "TRPicture2";
      PictureBox trPicture2_2 = this.TRPicture2;
      size1 = new Size(30, 30);
      Size size24 = size1;
      trPicture2_2.Size = size24;
      this.TRPicture2.TabIndex = 1;
      this.TRPicture2.TabStop = false;
      this.TRPicture1.Image = (Image) resourceManager.GetObject("TRPicture1.Image");
      PictureBox trPicture1_1 = this.TRPicture1;
      point1 = new Point(16, 24);
      Point point24 = point1;
      trPicture1_1.Location = point24;
      this.TRPicture1.Name = "TRPicture1";
      PictureBox trPicture1_2 = this.TRPicture1;
      size1 = new Size(30, 30);
      Size size25 = size1;
      trPicture1_2.Size = size25;
      this.TRPicture1.TabIndex = 0;
      this.TRPicture1.TabStop = false;
      this.GroupBox2.Controls.Add((Control) this.Label12);
      this.GroupBox2.Controls.Add((Control) this.FoundationText);
      this.GroupBox2.Controls.Add((Control) this.ThresholdText);
      this.GroupBox2.Controls.Add((Control) this.Label11);
      this.GroupBox2.Controls.Add((Control) this.Label10);
      this.GroupBox2.Controls.Add((Control) this.RWButton2);
      this.GroupBox2.Controls.Add((Control) this.PictureBox6);
      this.GroupBox2.Controls.Add((Control) this.RWButton4);
      this.GroupBox2.Controls.Add((Control) this.PictureBox5);
      this.GroupBox2.Controls.Add((Control) this.RWButton6);
      this.GroupBox2.Controls.Add((Control) this.PictureBox4);
      this.GroupBox2.Controls.Add((Control) this.RWButton5);
      this.GroupBox2.Controls.Add((Control) this.PictureBox3);
      this.GroupBox2.Controls.Add((Control) this.RWButton3);
      this.GroupBox2.Controls.Add((Control) this.PictureBox2);
      this.GroupBox2.Controls.Add((Control) this.RWButton1);
      this.GroupBox2.Controls.Add((Control) this.PictureBox1);
      GroupBox groupBox2_1 = this.GroupBox2;
      point1 = new Point(4, 4);
      Point point25 = point1;
      groupBox2_1.Location = point25;
      this.GroupBox2.Name = "GroupBox2";
      GroupBox groupBox2_2 = this.GroupBox2;
      size1 = new Size(212, 308);
      Size size26 = size1;
      groupBox2_2.Size = size26;
      this.GroupBox2.TabIndex = 21;
      this.GroupBox2.TabStop = false;
      this.GroupBox2.Text = "Foundation";
      Label label12_1 = this.Label12;
      point1 = new Point(8, 280);
      Point point26 = point1;
      label12_1.Location = point26;
      this.Label12.Name = "Label12";
      Label label12_2 = this.Label12;
      size1 = new Size(48, 16);
      Size size27 = size1;
      label12_2.Size = size27;
      this.Label12.TabIndex = 31;
      this.Label12.Text = "Retaining Walls";
      this.Label12.Visible = false;
      TextBox foundationText1 = this.FoundationText;
      point1 = new Point(112, 296);
      Point point27 = point1;
      foundationText1.Location = point27;
      this.FoundationText.MaxLength = 10;
      this.FoundationText.Name = "FoundationText";
      TextBox foundationText2 = this.FoundationText;
      size1 = new Size(80, 20);
      Size size28 = size1;
      foundationText2.Size = size28;
      this.FoundationText.TabIndex = 30;
      this.FoundationText.Text = "";
      this.FoundationText.TextAlign = HorizontalAlignment.Center;
      this.FoundationText.Visible = false;
      TextBox thresholdText1 = this.ThresholdText;
      point1 = new Point(128, 272);
      Point point28 = point1;
      thresholdText1.Location = point28;
      this.ThresholdText.MaxLength = 3;
      this.ThresholdText.Name = "ThresholdText";
      TextBox thresholdText2 = this.ThresholdText;
      size1 = new Size(40, 20);
      Size size29 = size1;
      thresholdText2.Size = size29;
      this.ThresholdText.TabIndex = 29;
      this.ThresholdText.Text = "";
      this.ThresholdText.TextAlign = HorizontalAlignment.Center;
      this.ThresholdText.Visible = false;
      Label label11_1 = this.Label11;
      point1 = new Point(48, 296);
      Point point29 = point1;
      label11_1.Location = point29;
      this.Label11.Name = "Label11";
      Label label11_2 = this.Label11;
      size1 = new Size(72, 16);
      Size size30 = size1;
      label11_2.Size = size30;
      this.Label11.TabIndex = 28;
      this.Label11.Text = "Foundation";
      this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.Label11.Visible = false;
      Label label10_1 = this.Label10;
      point1 = new Point(56, 272);
      Point point30 = point1;
      label10_1.Location = point30;
      this.Label10.Name = "Label10";
      Label label10_2 = this.Label10;
      size1 = new Size(72, 22);
      Size size31 = size1;
      label10_2.Size = size31;
      this.Label10.TabIndex = 27;
      this.Label10.Text = "Threshold";
      this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.Label10.Visible = false;
      this.RWButton2.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
      RadioButton rwButton2_1 = this.RWButton2;
      point1 = new Point(136, 88);
      Point point31 = point1;
      rwButton2_1.Location = point31;
      this.RWButton2.Name = "RWButton2";
      RadioButton rwButton2_2 = this.RWButton2;
      size1 = new Size(48, 16);
      Size size32 = size1;
      rwButton2_2.Size = size32;
      this.RWButton2.TabIndex = 26;
      this.PictureBox6.BorderStyle = BorderStyle.FixedSingle;
      this.PictureBox6.Image = (Image) resourceManager.GetObject("PictureBox6.Image");
      PictureBox pictureBox6_1 = this.PictureBox6;
      point1 = new Point(136, 32);
      Point point32 = point1;
      pictureBox6_1.Location = point32;
      this.PictureBox6.Name = "PictureBox6";
      PictureBox pictureBox6_2 = this.PictureBox6;
      size1 = new Size(48, 48);
      Size size33 = size1;
      pictureBox6_2.Size = size33;
      this.PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox6.TabIndex = 25;
      this.PictureBox6.TabStop = false;
      this.RWButton4.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
      RadioButton rwButton4_1 = this.RWButton4;
      point1 = new Point(136, 168);
      Point point33 = point1;
      rwButton4_1.Location = point33;
      this.RWButton4.Name = "RWButton4";
      RadioButton rwButton4_2 = this.RWButton4;
      size1 = new Size(48, 16);
      Size size34 = size1;
      rwButton4_2.Size = size34;
      this.RWButton4.TabIndex = 24;
      this.PictureBox5.BorderStyle = BorderStyle.FixedSingle;
      this.PictureBox5.Image = (Image) resourceManager.GetObject("PictureBox5.Image");
      PictureBox pictureBox5_1 = this.PictureBox5;
      point1 = new Point(136, 112);
      Point point34 = point1;
      pictureBox5_1.Location = point34;
      this.PictureBox5.Name = "PictureBox5";
      PictureBox pictureBox5_2 = this.PictureBox5;
      size1 = new Size(48, 48);
      Size size35 = size1;
      pictureBox5_2.Size = size35;
      this.PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox5.TabIndex = 23;
      this.PictureBox5.TabStop = false;
      this.RWButton6.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
      RadioButton rwButton6_1 = this.RWButton6;
      point1 = new Point(136, 248);
      Point point35 = point1;
      rwButton6_1.Location = point35;
      this.RWButton6.Name = "RWButton6";
      RadioButton rwButton6_2 = this.RWButton6;
      size1 = new Size(48, 16);
      Size size36 = size1;
      rwButton6_2.Size = size36;
      this.RWButton6.TabIndex = 22;
      this.PictureBox4.BorderStyle = BorderStyle.FixedSingle;
      this.PictureBox4.Image = (Image) resourceManager.GetObject("PictureBox4.Image");
      PictureBox pictureBox4_1 = this.PictureBox4;
      point1 = new Point(136, 192);
      Point point36 = point1;
      pictureBox4_1.Location = point36;
      this.PictureBox4.Name = "PictureBox4";
      PictureBox pictureBox4_2 = this.PictureBox4;
      size1 = new Size(48, 48);
      Size size37 = size1;
      pictureBox4_2.Size = size37;
      this.PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox4.TabIndex = 21;
      this.PictureBox4.TabStop = false;
      this.RWButton5.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
      RadioButton rwButton5_1 = this.RWButton5;
      point1 = new Point(24, 248);
      Point point37 = point1;
      rwButton5_1.Location = point37;
      this.RWButton5.Name = "RWButton5";
      RadioButton rwButton5_2 = this.RWButton5;
      size1 = new Size(48, 16);
      Size size38 = size1;
      rwButton5_2.Size = size38;
      this.RWButton5.TabIndex = 20;
      this.PictureBox3.BorderStyle = BorderStyle.FixedSingle;
      this.PictureBox3.Image = (Image) resourceManager.GetObject("PictureBox3.Image");
      PictureBox pictureBox3_1 = this.PictureBox3;
      point1 = new Point(24, 192);
      Point point38 = point1;
      pictureBox3_1.Location = point38;
      this.PictureBox3.Name = "PictureBox3";
      PictureBox pictureBox3_2 = this.PictureBox3;
      size1 = new Size(48, 48);
      Size size39 = size1;
      pictureBox3_2.Size = size39;
      this.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox3.TabIndex = 19;
      this.PictureBox3.TabStop = false;
      this.RWButton3.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
      RadioButton rwButton3_1 = this.RWButton3;
      point1 = new Point(24, 168);
      Point point39 = point1;
      rwButton3_1.Location = point39;
      this.RWButton3.Name = "RWButton3";
      RadioButton rwButton3_2 = this.RWButton3;
      size1 = new Size(48, 16);
      Size size40 = size1;
      rwButton3_2.Size = size40;
      this.RWButton3.TabIndex = 18;
      this.PictureBox2.BorderStyle = BorderStyle.FixedSingle;
      this.PictureBox2.Image = (Image) resourceManager.GetObject("PictureBox2.Image");
      PictureBox pictureBox2_1 = this.PictureBox2;
      point1 = new Point(24, 112);
      Point point40 = point1;
      pictureBox2_1.Location = point40;
      this.PictureBox2.Name = "PictureBox2";
      PictureBox pictureBox2_2 = this.PictureBox2;
      size1 = new Size(48, 48);
      Size size41 = size1;
      pictureBox2_2.Size = size41;
      this.PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox2.TabIndex = 17;
      this.PictureBox2.TabStop = false;
      this.RWButton1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
      RadioButton rwButton1_1 = this.RWButton1;
      point1 = new Point(24, 88);
      Point point41 = point1;
      rwButton1_1.Location = point41;
      this.RWButton1.Name = "RWButton1";
      RadioButton rwButton1_2 = this.RWButton1;
      size1 = new Size(48, 16);
      Size size42 = size1;
      rwButton1_2.Size = size42;
      this.RWButton1.TabIndex = 16;
      this.PictureBox1.BorderStyle = BorderStyle.FixedSingle;
      this.PictureBox1.Image = (Image) resourceManager.GetObject("PictureBox1.Image");
      PictureBox pictureBox1_1 = this.PictureBox1;
      point1 = new Point(24, 32);
      Point point42 = point1;
      pictureBox1_1.Location = point42;
      this.PictureBox1.Name = "PictureBox1";
      PictureBox pictureBox1_2 = this.PictureBox1;
      size1 = new Size(48, 48);
      Size size43 = size1;
      pictureBox1_2.Size = size43;
      this.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox1.TabIndex = 15;
      this.PictureBox1.TabStop = false;
      this.DockControl3.Closable = false;
      this.DockControl3.Collapsible = false;
      this.DockControl3.Controls.Add((Control) this.TransitPanel);
      this.DockControl3.Controls.Add((Control) this.Splitter4);
      this.DockControl3.Controls.Add((Control) this.LotPanel);
      this.DockControl3.Controls.Add((Control) this.Splitter3);
      this.DockControl3.Controls.Add((Control) this.RepPanel);
      this.DockControl3.Controls.Add((Control) this.ToolBar1);
      this.DockControl3.Floatable = false;
      DockControl dockControl3_1 = this.DockControl3;
      guid1 = new Guid("b0a7ee15-7fc8-49a6-9369-55c0ac72318a");
      Guid guid5 = guid1;
      dockControl3_1.Guid = guid5;
      DockControl dockControl3_2 = this.DockControl3;
      point1 = new Point(3, 23);
      Point point43 = point1;
      dockControl3_2.Location = point43;
      this.DockControl3.Name = "DockControl3";
      DockControl dockControl3_3 = this.DockControl3;
      size1 = new Size(587, 467);
      Size size44 = size1;
      dockControl3_3.Size = size44;
      this.DockControl3.TabIndex = 0;
      this.DockControl3.Text = "Lot";
      this.TransitPanel.AutoScroll = true;
      this.TransitPanel.BorderStyle = BorderStyle.Fixed3D;
      this.TransitPanel.Controls.Add((Control) this.GroupBox5);
      this.TransitPanel.Controls.Add((Control) this.T_Label_9);
      this.TransitPanel.Controls.Add((Control) this.T_Label_8);
      this.TransitPanel.Controls.Add((Control) this.T_Label_7);
      this.TransitPanel.Controls.Add((Control) this.T_Label_2);
      this.TransitPanel.Controls.Add((Control) this.T_Label_1);
      this.TransitPanel.Controls.Add((Control) this.T_Label_3);
      this.TransitPanel.Controls.Add((Control) this.T9_Picture_1);
      this.TransitPanel.Controls.Add((Control) this.T7_Picture_1);
      this.TransitPanel.Controls.Add((Control) this.T8_Picture_1);
      this.TransitPanel.Controls.Add((Control) this.T3_Picture_1);
      this.TransitPanel.Controls.Add((Control) this.T2_Picture_1);
      this.TransitPanel.Controls.Add((Control) this.T1_Picture_1);
      this.TransitPanel.Controls.Add((Control) this.PictureBox11);
      this.TransitPanel.Controls.Add((Control) this.CheckSouth);
      this.TransitPanel.Controls.Add((Control) this.CheckWest);
      this.TransitPanel.Controls.Add((Control) this.CheckEast);
      this.TransitPanel.Controls.Add((Control) this.CheckNorth);
      this.TransitPanel.Dock = DockStyle.Fill;
      Panel transitPanel1 = this.TransitPanel;
      point1 = new Point(404, 24);
      Point point44 = point1;
      transitPanel1.Location = point44;
      this.TransitPanel.Name = "TransitPanel";
      Panel transitPanel2 = this.TransitPanel;
      size1 = new Size(183, 343);
      Size size45 = size1;
      transitPanel2.Size = size45;
      this.TransitPanel.TabIndex = 92;
      this.GroupBox5.Controls.Add((Control) this.T_Label_6);
      this.GroupBox5.Controls.Add((Control) this.T_Label_5);
      this.GroupBox5.Controls.Add((Control) this.T_Label_4);
      this.GroupBox5.Controls.Add((Control) this.T6_Picture_1);
      this.GroupBox5.Controls.Add((Control) this.T5_Picture_1);
      this.GroupBox5.Controls.Add((Control) this.T4_Picture_1);
      this.GroupBox5.Controls.Add((Control) this.DirButton2);
      this.GroupBox5.Controls.Add((Control) this.PictureBox8);
      this.GroupBox5.Controls.Add((Control) this.DirButton1);
      this.GroupBox5.Controls.Add((Control) this.PictureBox7);
      GroupBox groupBox5_1 = this.GroupBox5;
      point1 = new Point(8, 148);
      Point point45 = point1;
      groupBox5_1.Location = point45;
      this.GroupBox5.Name = "GroupBox5";
      GroupBox groupBox5_2 = this.GroupBox5;
      size1 = new Size(156, 148);
      Size size46 = size1;
      groupBox5_2.Size = size46;
      this.GroupBox5.TabIndex = 100;
      this.GroupBox5.TabStop = false;
      this.T_Label_6.BorderStyle = BorderStyle.Fixed3D;
      this.T_Label_6.Font = new Font("Arial", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      Label tLabel6_1 = this.T_Label_6;
      point1 = new Point(48, 100);
      Point point46 = point1;
      tLabel6_1.Location = point46;
      this.T_Label_6.Name = "T_Label_6";
      Label tLabel6_2 = this.T_Label_6;
      size1 = new Size(40, 40);
      Size size47 = size1;
      tLabel6_2.Size = size47;
      this.T_Label_6.TabIndex = 66;
      this.T_Label_6.Text = "F";
      this.T_Label_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.T_Label_5.BorderStyle = BorderStyle.Fixed3D;
      this.T_Label_5.Font = new Font("Arial", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      Label tLabel5_1 = this.T_Label_5;
      point1 = new Point(48, 56);
      Point point47 = point1;
      tLabel5_1.Location = point47;
      this.T_Label_5.Name = "T_Label_5";
      Label tLabel5_2 = this.T_Label_5;
      size1 = new Size(40, 40);
      Size size48 = size1;
      tLabel5_2.Size = size48;
      this.T_Label_5.TabIndex = 65;
      this.T_Label_5.Text = "E";
      this.T_Label_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.T_Label_4.BorderStyle = BorderStyle.Fixed3D;
      this.T_Label_4.Font = new Font("Arial", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      Label tLabel4_1 = this.T_Label_4;
      point1 = new Point(48, 12);
      Point point48 = point1;
      tLabel4_1.Location = point48;
      this.T_Label_4.Name = "T_Label_4";
      Label tLabel4_2 = this.T_Label_4;
      size1 = new Size(40, 40);
      Size size49 = size1;
      tLabel4_2.Size = size49;
      this.T_Label_4.TabIndex = 64;
      this.T_Label_4.Text = "D";
      this.T_Label_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.T6_Picture_1.BorderStyle = BorderStyle.FixedSingle;
      this.T6_Picture_1.Image = (Image) resourceManager.GetObject("T6_Picture_1.Image");
      PictureBox t6Picture1_1 = this.T6_Picture_1;
      point1 = new Point(4, 100);
      Point point49 = point1;
      t6Picture1_1.Location = point49;
      this.T6_Picture_1.Name = "T6_Picture_1";
      PictureBox t6Picture1_2 = this.T6_Picture_1;
      size1 = new Size(42, 42);
      Size size50 = size1;
      t6Picture1_2.Size = size50;
      this.T6_Picture_1.SizeMode = PictureBoxSizeMode.StretchImage;
      this.T6_Picture_1.TabIndex = 63;
      this.T6_Picture_1.TabStop = false;
      this.T5_Picture_1.BorderStyle = BorderStyle.FixedSingle;
      this.T5_Picture_1.Image = (Image) resourceManager.GetObject("T5_Picture_1.Image");
      PictureBox t5Picture1_1 = this.T5_Picture_1;
      point1 = new Point(4, 56);
      Point point50 = point1;
      t5Picture1_1.Location = point50;
      this.T5_Picture_1.Name = "T5_Picture_1";
      PictureBox t5Picture1_2 = this.T5_Picture_1;
      size1 = new Size(42, 42);
      Size size51 = size1;
      t5Picture1_2.Size = size51;
      this.T5_Picture_1.SizeMode = PictureBoxSizeMode.StretchImage;
      this.T5_Picture_1.TabIndex = 62;
      this.T5_Picture_1.TabStop = false;
      this.T4_Picture_1.BorderStyle = BorderStyle.FixedSingle;
      this.T4_Picture_1.Image = (Image) resourceManager.GetObject("T4_Picture_1.Image");
      PictureBox t4Picture1_1 = this.T4_Picture_1;
      point1 = new Point(4, 12);
      Point point51 = point1;
      t4Picture1_1.Location = point51;
      this.T4_Picture_1.Name = "T4_Picture_1";
      PictureBox t4Picture1_2 = this.T4_Picture_1;
      size1 = new Size(42, 42);
      Size size52 = size1;
      t4Picture1_2.Size = size52;
      this.T4_Picture_1.SizeMode = PictureBoxSizeMode.StretchImage;
      this.T4_Picture_1.TabIndex = 61;
      this.T4_Picture_1.TabStop = false;
      this.DirButton2.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
      RadioButton dirButton2_1 = this.DirButton2;
      point1 = new Point(108, 112);
      Point point52 = point1;
      dirButton2_1.Location = point52;
      this.DirButton2.Name = "DirButton2";
      RadioButton dirButton2_2 = this.DirButton2;
      size1 = new Size(32, 12);
      Size size53 = size1;
      dirButton2_2.Size = size53;
      this.DirButton2.TabIndex = 3;
      PictureBox pictureBox8_1 = this.PictureBox8;
      point1 = new Point(108, 76);
      Point point53 = point1;
      pictureBox8_1.Location = point53;
      this.PictureBox8.Name = "PictureBox8";
      PictureBox pictureBox8_2 = this.PictureBox8;
      size1 = new Size(32, 32);
      Size size54 = size1;
      pictureBox8_2.Size = size54;
      this.PictureBox8.TabIndex = 2;
      this.PictureBox8.TabStop = false;
      this.DirButton1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.DirButton1.Checked = true;
      RadioButton dirButton1_1 = this.DirButton1;
      point1 = new Point(108, 52);
      Point point54 = point1;
      dirButton1_1.Location = point54;
      this.DirButton1.Name = "DirButton1";
      RadioButton dirButton1_2 = this.DirButton1;
      size1 = new Size(32, 12);
      Size size55 = size1;
      dirButton1_2.Size = size55;
      this.DirButton1.TabIndex = 1;
      this.DirButton1.TabStop = true;
      PictureBox pictureBox7_1 = this.PictureBox7;
      point1 = new Point(108, 20);
      Point point55 = point1;
      pictureBox7_1.Location = point55;
      this.PictureBox7.Name = "PictureBox7";
      PictureBox pictureBox7_2 = this.PictureBox7;
      size1 = new Size(32, 24);
      Size size56 = size1;
      pictureBox7_2.Size = size56;
      this.PictureBox7.TabIndex = 0;
      this.PictureBox7.TabStop = false;
      this.T_Label_9.BorderStyle = BorderStyle.Fixed3D;
      this.T_Label_9.Font = new Font("Arial", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      Label tLabel9_1 = this.T_Label_9;
      point1 = new Point(56, 392);
      Point point56 = point1;
      tLabel9_1.Location = point56;
      this.T_Label_9.Name = "T_Label_9";
      Label tLabel9_2 = this.T_Label_9;
      size1 = new Size(40, 40);
      Size size57 = size1;
      tLabel9_2.Size = size57;
      this.T_Label_9.TabIndex = 99;
      this.T_Label_9.Text = "I";
      this.T_Label_9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.T_Label_8.BorderStyle = BorderStyle.Fixed3D;
      this.T_Label_8.Font = new Font("Arial", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      Label tLabel8_1 = this.T_Label_8;
      point1 = new Point(56, 348);
      Point point57 = point1;
      tLabel8_1.Location = point57;
      this.T_Label_8.Name = "T_Label_8";
      Label tLabel8_2 = this.T_Label_8;
      size1 = new Size(40, 40);
      Size size58 = size1;
      tLabel8_2.Size = size58;
      this.T_Label_8.TabIndex = 98;
      this.T_Label_8.Text = "H";
      this.T_Label_8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.T_Label_7.BorderStyle = BorderStyle.Fixed3D;
      this.T_Label_7.Font = new Font("Arial", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      Label tLabel7_1 = this.T_Label_7;
      point1 = new Point(56, 304);
      Point point58 = point1;
      tLabel7_1.Location = point58;
      this.T_Label_7.Name = "T_Label_7";
      Label tLabel7_2 = this.T_Label_7;
      size1 = new Size(40, 40);
      Size size59 = size1;
      tLabel7_2.Size = size59;
      this.T_Label_7.TabIndex = 97;
      this.T_Label_7.Text = "G";
      this.T_Label_7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.T_Label_2.BorderStyle = BorderStyle.Fixed3D;
      this.T_Label_2.Font = new Font("Arial", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.T_Label_2.ForeColor = SystemColors.ControlText;
      Label tLabel2_1 = this.T_Label_2;
      point1 = new Point(56, 60);
      Point point59 = point1;
      tLabel2_1.Location = point59;
      this.T_Label_2.Name = "T_Label_2";
      Label tLabel2_2 = this.T_Label_2;
      size1 = new Size(40, 40);
      Size size60 = size1;
      tLabel2_2.Size = size60;
      this.T_Label_2.TabIndex = 96;
      this.T_Label_2.Text = "B";
      this.T_Label_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.T_Label_1.BorderStyle = BorderStyle.Fixed3D;
      this.T_Label_1.Font = new Font("Arial", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.T_Label_1.ForeColor = SystemColors.ControlText;
      Label tLabel1_1 = this.T_Label_1;
      point1 = new Point(56, 16);
      Point point60 = point1;
      tLabel1_1.Location = point60;
      this.T_Label_1.Name = "T_Label_1";
      Label tLabel1_2 = this.T_Label_1;
      size1 = new Size(40, 40);
      Size size61 = size1;
      tLabel1_2.Size = size61;
      this.T_Label_1.TabIndex = 95;
      this.T_Label_1.Text = "A";
      this.T_Label_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.T_Label_3.BorderStyle = BorderStyle.Fixed3D;
      this.T_Label_3.Font = new Font("Arial", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      Label tLabel3_1 = this.T_Label_3;
      point1 = new Point(56, 104);
      Point point61 = point1;
      tLabel3_1.Location = point61;
      this.T_Label_3.Name = "T_Label_3";
      Label tLabel3_2 = this.T_Label_3;
      size1 = new Size(40, 40);
      Size size62 = size1;
      tLabel3_2.Size = size62;
      this.T_Label_3.TabIndex = 94;
      this.T_Label_3.Text = "C";
      this.T_Label_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.T9_Picture_1.BorderStyle = BorderStyle.FixedSingle;
      this.T9_Picture_1.Image = (Image) resourceManager.GetObject("T9_Picture_1.Image");
      PictureBox t9Picture1_1 = this.T9_Picture_1;
      point1 = new Point(12, 392);
      Point point62 = point1;
      t9Picture1_1.Location = point62;
      this.T9_Picture_1.Name = "T9_Picture_1";
      PictureBox t9Picture1_2 = this.T9_Picture_1;
      size1 = new Size(42, 42);
      Size size63 = size1;
      t9Picture1_2.Size = size63;
      this.T9_Picture_1.SizeMode = PictureBoxSizeMode.StretchImage;
      this.T9_Picture_1.TabIndex = 93;
      this.T9_Picture_1.TabStop = false;
      this.T7_Picture_1.BorderStyle = BorderStyle.FixedSingle;
      this.T7_Picture_1.Image = (Image) resourceManager.GetObject("T7_Picture_1.Image");
      PictureBox t7Picture1_1 = this.T7_Picture_1;
      point1 = new Point(12, 304);
      Point point63 = point1;
      t7Picture1_1.Location = point63;
      this.T7_Picture_1.Name = "T7_Picture_1";
      PictureBox t7Picture1_2 = this.T7_Picture_1;
      size1 = new Size(42, 42);
      Size size64 = size1;
      t7Picture1_2.Size = size64;
      this.T7_Picture_1.SizeMode = PictureBoxSizeMode.StretchImage;
      this.T7_Picture_1.TabIndex = 92;
      this.T7_Picture_1.TabStop = false;
      this.T8_Picture_1.BorderStyle = BorderStyle.FixedSingle;
      this.T8_Picture_1.Image = (Image) resourceManager.GetObject("T8_Picture_1.Image");
      PictureBox t8Picture1_1 = this.T8_Picture_1;
      point1 = new Point(12, 348);
      Point point64 = point1;
      t8Picture1_1.Location = point64;
      this.T8_Picture_1.Name = "T8_Picture_1";
      PictureBox t8Picture1_2 = this.T8_Picture_1;
      size1 = new Size(42, 42);
      Size size65 = size1;
      t8Picture1_2.Size = size65;
      this.T8_Picture_1.SizeMode = PictureBoxSizeMode.StretchImage;
      this.T8_Picture_1.TabIndex = 91;
      this.T8_Picture_1.TabStop = false;
      this.T3_Picture_1.BorderStyle = BorderStyle.FixedSingle;
      this.T3_Picture_1.Image = (Image) resourceManager.GetObject("T3_Picture_1.Image");
      PictureBox t3Picture1_1 = this.T3_Picture_1;
      point1 = new Point(12, 104);
      Point point65 = point1;
      t3Picture1_1.Location = point65;
      this.T3_Picture_1.Name = "T3_Picture_1";
      PictureBox t3Picture1_2 = this.T3_Picture_1;
      size1 = new Size(42, 42);
      Size size66 = size1;
      t3Picture1_2.Size = size66;
      this.T3_Picture_1.SizeMode = PictureBoxSizeMode.StretchImage;
      this.T3_Picture_1.TabIndex = 90;
      this.T3_Picture_1.TabStop = false;
      this.T2_Picture_1.BorderStyle = BorderStyle.FixedSingle;
      this.T2_Picture_1.Image = (Image) resourceManager.GetObject("T2_Picture_1.Image");
      PictureBox t2Picture1_1 = this.T2_Picture_1;
      point1 = new Point(12, 60);
      Point point66 = point1;
      t2Picture1_1.Location = point66;
      this.T2_Picture_1.Name = "T2_Picture_1";
      PictureBox t2Picture1_2 = this.T2_Picture_1;
      size1 = new Size(42, 42);
      Size size67 = size1;
      t2Picture1_2.Size = size67;
      this.T2_Picture_1.SizeMode = PictureBoxSizeMode.StretchImage;
      this.T2_Picture_1.TabIndex = 89;
      this.T2_Picture_1.TabStop = false;
      this.T1_Picture_1.BorderStyle = BorderStyle.FixedSingle;
      this.T1_Picture_1.Image = (Image) resourceManager.GetObject("T1_Picture_1.Image");
      PictureBox t1Picture1_1 = this.T1_Picture_1;
      point1 = new Point(12, 16);
      Point point67 = point1;
      t1Picture1_1.Location = point67;
      this.T1_Picture_1.Name = "T1_Picture_1";
      PictureBox t1Picture1_2 = this.T1_Picture_1;
      size1 = new Size(42, 42);
      Size size68 = size1;
      t1Picture1_2.Size = size68;
      this.T1_Picture_1.SizeMode = PictureBoxSizeMode.StretchImage;
      this.T1_Picture_1.TabIndex = 88;
      this.T1_Picture_1.TabStop = false;
      this.PictureBox11.Image = (Image) resourceManager.GetObject("PictureBox11.Image");
      PictureBox pictureBox11_1 = this.PictureBox11;
      point1 = new Point(116, 28);
      Point point68 = point1;
      pictureBox11_1.Location = point68;
      this.PictureBox11.Name = "PictureBox11";
      PictureBox pictureBox11_2 = this.PictureBox11;
      size1 = new Size(43, 43);
      Size size69 = size1;
      pictureBox11_2.Size = size69;
      this.PictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox11.TabIndex = 87;
      this.PictureBox11.TabStop = false;
      this.CheckSouth.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
      System.Windows.Forms.CheckBox checkSouth1 = this.CheckSouth;
      point1 = new Point(128, 72);
      Point point69 = point1;
      checkSouth1.Location = point69;
      this.CheckSouth.Name = "CheckSouth";
      System.Windows.Forms.CheckBox checkSouth2 = this.CheckSouth;
      size1 = new Size(16, 16);
      Size size70 = size1;
      checkSouth2.Size = size70;
      this.CheckSouth.TabIndex = 86;
      this.CheckWest.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
      System.Windows.Forms.CheckBox checkWest1 = this.CheckWest;
      point1 = new Point(100, 44);
      Point point70 = point1;
      checkWest1.Location = point70;
      this.CheckWest.Name = "CheckWest";
      System.Windows.Forms.CheckBox checkWest2 = this.CheckWest;
      size1 = new Size(16, 16);
      Size size71 = size1;
      checkWest2.Size = size71;
      this.CheckWest.TabIndex = 85;
      this.CheckEast.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
      System.Windows.Forms.CheckBox checkEast1 = this.CheckEast;
      point1 = new Point(160, 44);
      Point point71 = point1;
      checkEast1.Location = point71;
      this.CheckEast.Name = "CheckEast";
      System.Windows.Forms.CheckBox checkEast2 = this.CheckEast;
      size1 = new Size(16, 16);
      Size size72 = size1;
      checkEast2.Size = size72;
      this.CheckEast.TabIndex = 84;
      this.CheckNorth.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.CheckNorth.Checked = true;
      this.CheckNorth.CheckState = CheckState.Checked;
      System.Windows.Forms.CheckBox checkNorth1 = this.CheckNorth;
      point1 = new Point(128, 12);
      Point point72 = point1;
      checkNorth1.Location = point72;
      this.CheckNorth.Name = "CheckNorth";
      System.Windows.Forms.CheckBox checkNorth2 = this.CheckNorth;
      size1 = new Size(16, 16);
      Size size73 = size1;
      checkNorth2.Size = size73;
      this.CheckNorth.TabIndex = 83;
      Splitter splitter4_1 = this.Splitter4;
      point1 = new Point(396, 24);
      Point point73 = point1;
      splitter4_1.Location = point73;
      this.Splitter4.Name = "Splitter4";
      Splitter splitter4_2 = this.Splitter4;
      size1 = new Size(8, 343);
      Size size74 = size1;
      splitter4_2.Size = size74;
      this.Splitter4.TabIndex = 90;
      this.Splitter4.TabStop = false;
      this.LotPanel.AutoScroll = true;
      this.LotPanel.BorderStyle = BorderStyle.Fixed3D;
      this.LotPanel.Controls.Add((Control) this.Graphicgrid1);
      this.LotPanel.Dock = DockStyle.Left;
      Panel lotPanel1 = this.LotPanel;
      point1 = new Point(0, 24);
      Point point74 = point1;
      lotPanel1.Location = point74;
      this.LotPanel.Name = "LotPanel";
      Panel lotPanel2 = this.LotPanel;
      size1 = new Size(396, 343);
      Size size75 = size1;
      lotPanel2.Size = size75;
      this.LotPanel.TabIndex = 89;
      this.Graphicgrid1.AllowDrop = true;
      this.Graphicgrid1.BackColor = Color.FromArgb(154, 179, 230);
      graphicgrid graphicgrid1_1 = this.Graphicgrid1;
      size1 = new Size(1, 5);
      Size size76 = size1;
      graphicgrid1_1.Cells = size76;
      this.Graphicgrid1.CellSize = 0;
      this.Graphicgrid1.GridColor = Color.White;
      this.Graphicgrid1.GridHighLiteColor = Color.Red;
      graphicgrid graphicgrid1_2 = this.Graphicgrid1;
      point1 = new Point(8, 20);
      Point point75 = point1;
      graphicgrid1_2.Location = point75;
      this.Graphicgrid1.Name = "Graphicgrid1";
      this.Graphicgrid1.ShowTransitString = false;
      graphicgrid graphicgrid1_3 = this.Graphicgrid1;
      size1 = new Size(96, 64);
      Size size77 = size1;
      graphicgrid1_3.Size = size77;
      this.Graphicgrid1.TabIndex = 89;
      this.Splitter3.Dock = DockStyle.Bottom;
      Splitter splitter3_1 = this.Splitter3;
      point1 = new Point(0, 367);
      Point point76 = point1;
      splitter3_1.Location = point76;
      this.Splitter3.Name = "Splitter3";
      Splitter splitter3_2 = this.Splitter3;
      size1 = new Size(587, 8);
      Size size78 = size1;
      splitter3_2.Size = size78;
      this.Splitter3.TabIndex = 7;
      this.Splitter3.TabStop = false;
      this.RepPanel.AutoScroll = true;
      this.RepPanel.BorderStyle = BorderStyle.Fixed3D;
      this.RepPanel.Controls.Add((Control) this.RepGrid);
      this.RepPanel.Controls.Add((Control) this.TextureGrid);
      this.RepPanel.Dock = DockStyle.Bottom;
      Panel repPanel1 = this.RepPanel;
      point1 = new Point(0, 375);
      Point point77 = point1;
      repPanel1.Location = point77;
      this.RepPanel.Name = "RepPanel";
      Panel repPanel2 = this.RepPanel;
      size1 = new Size(587, 92);
      Size size79 = size1;
      repPanel2.Size = size79;
      this.RepPanel.TabIndex = 6;
      this.RepGrid.AutoSizeMinHeight = 10;
      this.RepGrid.AutoSizeMinWidth = 10;
      this.RepGrid.AutoStretchColumnsToFitWidth = false;
      this.RepGrid.AutoStretchRowsToFitHeight = false;
      this.RepGrid.ContextMenuStyle = ContextMenuStyle.None;
      this.RepGrid.CustomSort = false;
      this.RepGrid.Dock = DockStyle.Fill;
      this.RepGrid.GridToolTipActive = true;
      Grid repGrid1 = this.RepGrid;
      point1 = new Point(0, 0);
      Point point78 = point1;
      repGrid1.Location = point78;
      this.RepGrid.Name = "RepGrid";
      Grid repGrid2 = this.RepGrid;
      size1 = new Size(583, 88);
      Size size80 = size1;
      repGrid2.Size = size80;
      this.RepGrid.SpecialKeys = GridSpecialKeys.Default;
      this.RepGrid.TabIndex = 0;
      this.TextureGrid.AutoSizeMinHeight = 10;
      this.TextureGrid.AutoSizeMinWidth = 10;
      this.TextureGrid.AutoStretchColumnsToFitWidth = false;
      this.TextureGrid.AutoStretchRowsToFitHeight = false;
      this.TextureGrid.ContextMenuStyle = ContextMenuStyle.None;
      this.TextureGrid.CustomSort = false;
      this.TextureGrid.Dock = DockStyle.Fill;
      this.TextureGrid.GridToolTipActive = true;
      Grid textureGrid1 = this.TextureGrid;
      point1 = new Point(0, 0);
      Point point79 = point1;
      textureGrid1.Location = point79;
      this.TextureGrid.Name = "TextureGrid";
      Grid textureGrid2 = this.TextureGrid;
      size1 = new Size(583, 88);
      Size size81 = size1;
      textureGrid2.Size = size81;
      this.TextureGrid.SpecialKeys = GridSpecialKeys.Default;
      this.TextureGrid.TabIndex = 13;
      this.ToolBar1.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      TD.SandBar.ToolBar toolBar1_1 = this.ToolBar1;
      guid1 = new Guid("589ac1a0-4e3b-459b-95d7-6d689d924ab4");
      Guid guid6 = guid1;
      toolBar1_1.Guid = guid6;
      this.ToolBar1.ImageList = this.ImageList1;
      this.ToolBar1.Items.AddRange(new ToolbarItemBase[5]
      {
        (ToolbarItemBase) this.ButtonPlus,
        (ToolbarItemBase) this.ButtonMinus,
        (ToolbarItemBase) this.ModusMenu,
        (ToolbarItemBase) this.MenuDisplay,
        (ToolbarItemBase) this.ButtonShowReps
      });
      TD.SandBar.ToolBar toolBar1_2 = this.ToolBar1;
      point1 = new Point(0, 0);
      Point point80 = point1;
      toolBar1_2.Location = point80;
      this.ToolBar1.Name = "ToolBar1";
      TD.SandBar.ToolBar toolBar1_3 = this.ToolBar1;
      size1 = new Size(587, 24);
      Size size82 = size1;
      toolBar1_3.Size = size82;
      this.ToolBar1.TabIndex = 3;
      this.ToolBar1.Text = "ToolBar1";
      this.ButtonPlus.BeginGroup = true;
      this.ButtonPlus.Image = (Image) resourceManager.GetObject("ButtonPlus.Image");
      this.ButtonMinus.BeginGroup = true;
      this.ButtonMinus.Image = (Image) resourceManager.GetObject("ButtonMinus.Image");
      this.MenuDisplay.BeginGroup = true;
      this.MenuDisplay.Items.AddRange(new ToolbarItemBase[2]
      {
        (ToolbarItemBase) this.MenuDisplayItem1,
        (ToolbarItemBase) this.MenuDisplayItem2
      });
      this.MenuDisplay.Text = "Display";
      this.MenuDisplayItem1.Text = "Values";
      this.MenuDisplayItem2.BeginGroup = true;
      this.MenuDisplayItem2.Checked = true;
      this.MenuDisplayItem2.Text = "Arrows";
      this.ButtonShowReps.BeginGroup = true;
      this.ButtonShowReps.ImageIndex = 12;
      this.DockControl7.Controls.Add((Control) this.TransitSwitchPanel);
      DockControl dockControl7_1 = this.DockControl7;
      guid1 = new Guid("8e0d2e96-e700-46a3-a759-8b3be4455e50");
      Guid guid7 = guid1;
      dockControl7_1.Guid = guid7;
      DockControl dockControl7_2 = this.DockControl7;
      point1 = new Point(3, 23);
      Point point81 = point1;
      dockControl7_2.Location = point81;
      this.DockControl7.Name = "DockControl7";
      DockControl dockControl7_3 = this.DockControl7;
      size1 = new Size(587, 467);
      Size size83 = size1;
      dockControl7_3.Size = size83;
      this.DockControl7.TabIndex = 5;
      this.DockControl7.Text = "Transit Switch";
      this.TransitSwitchPanel.Controls.Add((Control) this.TransitSwitchGrid);
      this.TransitSwitchPanel.Controls.Add((Control) this.TransitSwitchToolBar);
      this.TransitSwitchPanel.Dock = DockStyle.Fill;
      Panel transitSwitchPanel1 = this.TransitSwitchPanel;
      point1 = new Point(0, 0);
      Point point82 = point1;
      transitSwitchPanel1.Location = point82;
      this.TransitSwitchPanel.Name = "TransitSwitchPanel";
      Panel transitSwitchPanel2 = this.TransitSwitchPanel;
      size1 = new Size(587, 467);
      Size size84 = size1;
      transitSwitchPanel2.Size = size84;
      this.TransitSwitchPanel.TabIndex = 0;
      this.TransitSwitchGrid.AutoSizeMinHeight = 10;
      this.TransitSwitchGrid.AutoSizeMinWidth = 10;
      this.TransitSwitchGrid.AutoStretchColumnsToFitWidth = false;
      this.TransitSwitchGrid.AutoStretchRowsToFitHeight = false;
      this.TransitSwitchGrid.ContextMenuStyle = ContextMenuStyle.None;
      this.TransitSwitchGrid.CustomSort = false;
      this.TransitSwitchGrid.Dock = DockStyle.Fill;
      this.TransitSwitchGrid.GridToolTipActive = true;
      Grid transitSwitchGrid1 = this.TransitSwitchGrid;
      point1 = new Point(0, 24);
      Point point83 = point1;
      transitSwitchGrid1.Location = point83;
      this.TransitSwitchGrid.Name = "TransitSwitchGrid";
      Grid transitSwitchGrid2 = this.TransitSwitchGrid;
      size1 = new Size(587, 443);
      Size size85 = size1;
      transitSwitchGrid2.Size = size85;
      this.TransitSwitchGrid.SpecialKeys = GridSpecialKeys.Default;
      this.TransitSwitchGrid.TabIndex = 1;
      TD.SandBar.ToolBar transitSwitchToolBar1 = this.TransitSwitchToolBar;
      guid1 = new Guid("c25eb29c-9616-4dd7-9f88-1749bf16e03f");
      Guid guid8 = guid1;
      transitSwitchToolBar1.Guid = guid8;
      this.TransitSwitchToolBar.ImageList = this.ImageList1;
      this.TransitSwitchToolBar.Items.AddRange(new ToolbarItemBase[1]
      {
        (ToolbarItemBase) this.TransitSwitchButton1
      });
      TD.SandBar.ToolBar transitSwitchToolBar2 = this.TransitSwitchToolBar;
      point1 = new Point(0, 0);
      Point point84 = point1;
      transitSwitchToolBar2.Location = point84;
      this.TransitSwitchToolBar.Name = "TransitSwitchToolBar";
      TD.SandBar.ToolBar transitSwitchToolBar3 = this.TransitSwitchToolBar;
      size1 = new Size(587, 24);
      Size size86 = size1;
      transitSwitchToolBar3.Size = size86;
      this.TransitSwitchToolBar.TabIndex = 0;
      this.TransitSwitchToolBar.Text = "ToolBar2";
      this.TransitSwitchButton1.BeginGroup = true;
      this.TransitSwitchButton1.ImageIndex = 6;
      this.ButtonDeleteTile.BeginGroup = true;
      this.ButtonDeleteTile.ImageIndex = 16;
      this.ErrorProvider1.ContainerControl = (ContainerControl) this;
      Splitter splitter1_1 = this.Splitter1;
      point1 = new Point(184, 24);
      Point point85 = point1;
      splitter1_1.Location = point85;
      this.Splitter1.Name = "Splitter1";
      Splitter splitter1_2 = this.Splitter1;
      size1 = new Size(8, 520);
      Size size87 = size1;
      splitter1_2.Size = size87;
      this.Splitter1.TabIndex = 3;
      this.Splitter1.TabStop = false;
      size1 = new Size(5, 13);
      this.AutoScaleBaseSize = size1;
      size1 = new Size(787, 568);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.HeaderControl1);
      this.Controls.Add((Control) this.Splitter1);
      this.Controls.Add((Control) this.Panel1);
      this.Controls.Add((Control) this.StatusBar1);
      this.Controls.Add((Control) this.MainToolBar);
      this.Name = nameof (FormLotEditor);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Lot Editor";
      this.StatusBarPanel1.EndInit();
      this.StatusBarPanel2.EndInit();
      this.StatusBarPanel3.EndInit();
      this.Panel1.ResumeLayout(false);
      this.HeaderControl1.ResumeLayout(false);
      this.DocumentContainer1.ResumeLayout(false);
      this.DockControl1.ResumeLayout(false);
      this.CommonPanel.ResumeLayout(false);
      this.GroupBox4.ResumeLayout(false);
      this.GroupBox3.ResumeLayout(false);
      this.GroupBox1.ResumeLayout(false);
      this.GroupBox2.ResumeLayout(false);
      this.DockControl3.ResumeLayout(false);
      this.TransitPanel.ResumeLayout(false);
      this.GroupBox5.ResumeLayout(false);
      this.LotPanel.ResumeLayout(false);
      this.RepPanel.ResumeLayout(false);
      this.DockControl7.ResumeLayout(false);
      this.TransitSwitchPanel.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    private object SwitchToExpert()
    {
      this.ExpertModus = true;
      this.ModusMenuItem1.Checked = false;
      this.ModusMenuItem2.Checked = true;
      this.MenuDisplay.Visible = true;
      this.mnuItemEditTransit.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[432]);
      this.StatusBarPanel3.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[444]);
      object obj;
      return obj;
    }

    private object SwitchToStandard()
    {
      this.ExpertModus = false;
      this.ShowTransitString = false;
      this.ModusMenuItem1.Checked = true;
      this.ModusMenuItem2.Checked = false;
      this.MenuDisplay.Visible = false;
      this.MenuDisplayItem1.Checked = false;
      this.MenuDisplayItem2.Checked = true;
      if (!Information.IsNothing((object) this.AktuellesLot))
        this.RefreshOutput();
      this.mnuItemEditTransit.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[431]);
      this.StatusBarPanel3.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[443]);
      object obj;
      return obj;
    }

    private void FormLotEditor_Load(object sender, EventArgs e)
    {
      Color color = new Color();
      sr_Userinterface.AendereFarben((Form) this, ClassThisProg.DefReader.FarbSchema);
      Color transparentColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
      this.mnuContextMenu = new System.Windows.Forms.ContextMenu();
      this.mnuItemAdd = new MenuItem();
      this.mnuItemDummy = new MenuItem();
      this.mnuItemRemove = new MenuItem();
      this.mnuItemDummy1 = new MenuItem();
      this.mnuItemChangeDirection = new MenuItem();
      this.mnuItemDummy2 = new MenuItem();
      this.mnuItemEditTransit = new MenuItem();
      this.RepGrid.Visible = true;
      this.TextureGrid.Visible = false;
      this.SetzeTexte();
      if (StringType.StrCmp(ClassThisProg.DefReader.TEModus, "E", false) == 0)
        this.SwitchToExpert();
      else
        this.SwitchToStandard();
      this.l_TitleModel.BackColor = Color.SteelBlue;
      this.l_TitleModel.ForeColor = Color.White;
      this.l_TitleModel.Font = this.Font;
      this.l_TitleModel.TextAlignment = SourceLibrary.Drawing.ContentAlignment.MiddleCenter;
      this.l_CenterModel.Font = this.Font;
      this.l_CenterModel.TextAlignment = SourceLibrary.Drawing.ContentAlignment.MiddleCenter;
      this.StatusBarPanel1.Width = checked ((int) Math.Round(unchecked ((double) this.Panel1.Width + (double) this.Splitter1.Width / 2.0)));
      Loader loader = new Loader();
      Bitmap pictureFromResource1 = loader.GetPictureFromResource("NordSued.bmp");
      pictureFromResource1.MakeTransparent(transparentColor);
      this.PictureBox7.Image = (Image) pictureFromResource1;
      Bitmap pictureFromResource2 = loader.GetPictureFromResource("WestOst.bmp");
      pictureFromResource2.MakeTransparent(transparentColor);
      this.PictureBox8.Image = (Image) pictureFromResource2;
      loader.Dispose();
      this.RepGrid.RowsCount = 0;
      this.RepGrid.ColumnsCount = 17;
      this.RepGrid.Selection.SelectionMode = GridSelectionMode.Row;
      int num1 = checked (this.RepGrid.ColumnsCount - 1);
      int p1 = 0;
      while (p1 <= num1)
      {
        this.RepGrid.Columns[p1].Width = 70;
        checked { ++p1; }
      }
      this.RepGrid.Width = checked (this.RepGrid.Columns[0].Width * this.RepGrid.ColumnsCount + 10);
      this.RepGrid.Rows.Insert(this.RepGrid.RowsCount);
      int num2 = checked (this.RepGrid.ColumnsCount - 1);
      int col = 0;
      while (col <= num2)
      {
        ICell cell = (ICell) new Cell((object) ((double) col + DoubleType.FromString(1.ToString())), (IDataModel) null, (IVisualModel) this.l_TitleModel);
        this.RepGrid[checked (this.RepGrid.RowsCount - 1), col] = cell;
        checked { ++col; }
      }
      this.TextureGrid.RowsCount = 0;
      this.TextureGrid.ColumnsCount = 2;
      this.TextureGrid.Selection.SelectionMode = GridSelectionMode.Row;
      int num3 = checked (this.TextureGrid.ColumnsCount - 1);
      int p2 = 0;
      while (p2 <= num3)
      {
        this.TextureGrid.Columns[p2].Width = 70;
        checked { ++p2; }
      }
      this.TextureGrid.Width = checked (this.TextureGrid.Columns[0].Width * this.TextureGrid.ColumnsCount + 10);
      this.TextureGrid.Rows.Insert(this.TextureGrid.RowsCount);
      ICell cell1 = (ICell) new Cell((object) "Textures", (IDataModel) null, (IVisualModel) this.l_TitleModel);
      cell1.ColumnSpan = this.TextureGrid.ColumnsCount;
      this.TextureGrid[checked (this.TextureGrid.RowsCount - 1), 0] = cell1;
      this.TextureGrid.Rows.Insert(this.TextureGrid.RowsCount);
      this.TextureGrid[checked (this.TextureGrid.RowsCount - 1), 0] = (ICell) new Cell((object) "Base", (IDataModel) null, (IVisualModel) this.l_TitleModel);
      this.TextureGrid[checked (this.TextureGrid.RowsCount - 1), 1] = (ICell) new Cell((object) "Overlay", (IDataModel) null, (IVisualModel) this.l_TitleModel);
      this.Graphicgrid1.ContextMenu = this.mnuContextMenu;
      this.mnuContextMenu.MenuItems.Add(this.mnuItemAdd);
      this.mnuContextMenu.MenuItems.Add(this.mnuItemDummy);
      this.mnuContextMenu.MenuItems.Add(this.mnuItemRemove);
      this.mnuContextMenu.MenuItems.Add(this.mnuItemDummy1);
      this.mnuContextMenu.MenuItems.Add(this.mnuItemChangeDirection);
      this.mnuContextMenu.MenuItems.Add(this.mnuItemDummy2);
      this.mnuContextMenu.MenuItems.Add(this.mnuItemEditTransit);
      this.mnuItemAdd.Click += new EventHandler(this.mnuItemAdd_Click);
      this.mnuItemRemove.Click += new EventHandler(this.mnuItemRemove_Click);
      this.mnuItemChangeDirection.Click += new EventHandler(this.mnuItemChangeDirection_Click);
      this.mnuItemEditTransit.Click += new EventHandler(this.mnuItemEditTransit_Click);
      this.Clear();
    }

    public object SetzeTexte()
    {
      this.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[429]);
      this.DockControl1.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[75]);
      this.ButtonLeave.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[3]);
      this.ButtonOpen.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[16]);
      this.ButtonSave.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[17]);
      this.ButtonDeleteTile.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[400]);
      this.ButtonPlus.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[401]);
      this.ButtonMinus.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[402]);
      this.TransitSwitchButton1.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[453]);
      if (this.RepGrid.Visible)
        this.ButtonShowReps.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[468]);
      else
        this.ButtonShowReps.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[467]);
      this.GroupBox2.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[454]);
      this.GroupBox1.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[455]);
      this.ToolTip1.SetToolTip((Control) this.PictureBox11, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[403]));
      this.ToolTip1.SetToolTip((Control) this.CheckNorth, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[350]));
      this.ToolTip1.SetToolTip((Control) this.CheckWest, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[351]));
      this.ToolTip1.SetToolTip((Control) this.CheckSouth, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[352]));
      this.ToolTip1.SetToolTip((Control) this.CheckEast, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[353]));
      this.mnuItemAdd.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[399]);
      this.mnuItemDummy.Text = "-";
      this.mnuItemRemove.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[400]);
      this.mnuItemDummy1.Text = "-";
      this.mnuItemChangeDirection.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[430]);
      this.mnuItemDummy2.Text = "-";
      this.mnuItemEditTransit.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[431]);
      this.ToolTip1.SetToolTip((Control) this.T1_Picture_1, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[333]));
      this.ToolTip1.SetToolTip((Control) this.T2_Picture_1, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[337]));
      this.ToolTip1.SetToolTip((Control) this.T3_Picture_1, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[330]));
      this.ToolTip1.SetToolTip((Control) this.T4_Picture_1, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[334]));
      this.ToolTip1.SetToolTip((Control) this.T5_Picture_1, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[332]));
      this.ToolTip1.SetToolTip((Control) this.T6_Picture_1, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[338]));
      this.ToolTip1.SetToolTip((Control) this.T7_Picture_1, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[331]));
      this.ToolTip1.SetToolTip((Control) this.T8_Picture_1, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[335]));
      this.ToolTip1.SetToolTip((Control) this.T9_Picture_1, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[336]));
      this.T1_Picture_1.Cursor = Cursors.Hand;
      this.T2_Picture_1.Cursor = Cursors.Hand;
      this.T3_Picture_1.Cursor = Cursors.Hand;
      this.T4_Picture_1.Cursor = Cursors.Hand;
      this.T5_Picture_1.Cursor = Cursors.Hand;
      this.T6_Picture_1.Cursor = Cursors.Hand;
      this.T7_Picture_1.Cursor = Cursors.Hand;
      this.T8_Picture_1.Cursor = Cursors.Hand;
      this.T9_Picture_1.Cursor = Cursors.Hand;
      this.ModusMenu.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[442]);
      this.ModusMenuItem1.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[443]);
      this.ModusMenuItem2.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[444]);
      this.MenuDisplay.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[445]);
      this.MenuDisplayItem1.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[447]);
      this.MenuDisplayItem2.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[446]);
      object obj;
      return obj;
    }

    private bool StartRead()
    {
      bool flag;
      try
      {
        this.Cursor = Cursors.WaitCursor;
        this.hasNotSavedChanges = false;
        this.LotExemplarArray.Clear();
        this.LotIndexArray.Clear();
        this.BuildingExemplarArray.Clear();
        this.ExemplarIndexArray.Clear();
        this.LotExemplarInstanceArray.Clear();
        this.BuildingExemplarInstanceArray.Clear();
        this.NodeArray.Clear();
        this.AktuellesLot = (Lot) null;
        this.Clear();
        if (!this.LeseDaten())
        {
          this.Cursor = Cursors.Default;
          int num = (int) MessageBox.Show((IWin32Window) this, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[67]), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[17]), MessageBoxButtons.OK, MessageBoxIcon.Hand);
          flag = false;
          goto label_5;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Cursor = Cursors.Default;
        int num = (int) MessageBox.Show((IWin32Window) this, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[67]), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[17]), MessageBoxButtons.OK, MessageBoxIcon.Hand);
        flag = false;
        ProjectData.ClearProjectError();
        goto label_5;
      }
      this.Cursor = Cursors.Default;
      flag = true;
label_5:
      return flag;
    }

    private object Clear()
    {
      this.ChainTable1.Clear();
      this.ChainTable2.Clear();
      this.HeaderControl1.Text = "<....>";
      this.Graphicgrid1.clearCells();
      this.Graphicgrid1.CellSize = 64;
      this.Graphicgrid1.SelectedCells.Clear();
      this.Graphicgrid1.Visible = false;
      this.Graphicgrid1.Enabled = false;
      this.ToolBar1.Enabled = false;
      this.TransitPanel.Enabled = false;
      this.mnuItemAdd.Enabled = false;
      this.mnuItemDummy.Enabled = false;
      this.mnuItemRemove.Enabled = false;
      this.ButtonSave.Enabled = false;
      this.GroupBox1.Enabled = false;
      this.GroupBox2.Enabled = false;
      this.GroupBox3.Enabled = false;
      this.GroupBox4.Enabled = false;
      this.CornerButton1.Checked = false;
      this.CornerButton2.Checked = false;
      this.CornerButton3.Checked = false;
      this.RWButton1.Checked = false;
      this.RWButton2.Checked = false;
      this.RWButton3.Checked = false;
      this.RWButton4.Checked = false;
      this.RWButton5.Checked = false;
      this.RWButton6.Checked = false;
      this.ThresholdText.Text = "";
      this.FoundationText.Text = "";
      this.LotMaxText.Text = "";
      this.LotMinText.Text = "";
      this.GrowthText.Text = "";
      this.RepGrid.Redim(1, 17);
      this.TransitSwitchGrid.Redim(0, 0);
      this.TransitSwitchToolBar.Enabled = false;
      this.mnuItemAdd.Enabled = false;
      this.mnuItemRemove.Enabled = false;
      this.mnuItemChangeDirection.Enabled = false;
      this.mnuItemEditTransit.Enabled = false;
      this.ModusMenuItem1.Enabled = true;
      this.AktuellerTileIndex = -1;
      this.hasNotSavedChanges = false;
      object obj;
      return obj;
    }

    private object GebeLotAus()
    {
      this.Graphicgrid1.clearCells();
      this.Graphicgrid1.SelectedCells.Clear();
      this.Graphicgrid1.Width = 0;
      this.Graphicgrid1.Height = 0;
      if (this.AktuellesLot.Tiles.GetUpperBound(0) > -1)
      {
        Size size;
        size.Width = this.AktuellesLot.Breite;
        size.Height = this.AktuellesLot.Hoehe;
        this.Graphicgrid1.Cells = size;
        graphicgrid graphicgrid1_1 = this.Graphicgrid1;
        int cellSize1 = this.Graphicgrid1.CellSize;
        Size cells = this.Graphicgrid1.Cells;
        int width = cells.Width;
        int num1 = checked (cellSize1 * width);
        graphicgrid1_1.Width = num1;
        graphicgrid graphicgrid1_2 = this.Graphicgrid1;
        int cellSize2 = this.Graphicgrid1.CellSize;
        cells = this.Graphicgrid1.Cells;
        int height = cells.Height;
        int num2 = checked (cellSize2 * height);
        graphicgrid1_2.Height = num2;
        int upperBound = this.AktuellesLot.Tiles.GetUpperBound(0);
        int i = 0;
        while (i <= upperBound)
        {
          this.ZeichneTile(i);
          if (this.AktuellesLot.Tiles[i].MustExpert)
          {
            this.ModusMenuItem1.Enabled = false;
            this.ModusMenuItem1.Checked = false;
            this.ModusMenuItem2.Checked = true;
            this.SwitchToExpert();
          }
          checked { ++i; }
        }
      }
      if (!Information.IsNothing((object) this.AktuellesLot.CommonDefs.Threshold))
      {
        this.ThresholdText.Text = this.AktuellesLot.CommonDefs.Threshold.ToString();
        this.ThresholdText.Enabled = true;
      }
      if (!Information.IsNothing((object) this.AktuellesLot.CommonDefs.Foundation))
      {
        this.FoundationText.Text = this.AktuellesLot.CommonDefs.Foundation.ToString();
        this.FoundationText.Enabled = true;
      }
      if (!Information.IsNothing((object) this.AktuellesLot.CommonDefs.ElevMax))
      {
        this.LotMaxText.Text = this.AktuellesLot.CommonDefs.ElevMax.ToString();
        this.LotMaxText.Enabled = true;
      }
      if (!Information.IsNothing((object) this.AktuellesLot.CommonDefs.ElevMin))
      {
        this.LotMinText.Text = this.AktuellesLot.CommonDefs.ElevMin.ToString();
        this.LotMinText.Enabled = true;
      }
      if (!Information.IsNothing((object) this.AktuellesLot.CommonDefs.Growth))
      {
        this.GrowthText.Text = this.AktuellesLot.CommonDefs.Growth.ToString();
        this.GrowthText.Enabled = true;
      }
      string upper1 = this.AktuellesLot.CommonDefs.Corner.ToUpper();
      if (StringType.StrCmp(upper1, "LEFT", false) == 0)
        this.CornerButton1.Checked = true;
      else if (StringType.StrCmp(upper1, "CENTER", false) == 0)
        this.CornerButton2.Checked = true;
      else if (StringType.StrCmp(upper1, "RIGHT", false) == 0)
        this.CornerButton3.Checked = true;
      if (!Information.IsNothing((object) this.AktuellesLot.CommonDefs.RetainingWall))
      {
        string upper2 = this.AktuellesLot.CommonDefs.RetainingWall.ToUpper();
        if (StringType.StrCmp(upper2, "0XC96D2132", false) == 0)
          this.RWButton1.Checked = true;
        else if (StringType.StrCmp(upper2, "0XC96D2133", false) == 0)
          this.RWButton2.Checked = true;
        else if (StringType.StrCmp(upper2, "0XC96D2134", false) == 0)
          this.RWButton3.Checked = true;
        else if (StringType.StrCmp(upper2, "0XC96D2135", false) == 0)
          this.RWButton4.Checked = true;
        else if (StringType.StrCmp(upper2, "0XC96D2136", false) == 0)
          this.RWButton5.Checked = true;
        else if (StringType.StrCmp(upper2, "0XC96D2137", false) == 0)
          this.RWButton6.Checked = true;
      }
      this.Graphicgrid1.Visible = true;
      this.Graphicgrid1.Enabled = true;
      this.Graphicgrid1.SelectedCells.Clear();
      this.GroupBox1.Enabled = true;
      this.GroupBox2.Enabled = true;
      this.GroupBox3.Enabled = true;
      this.GroupBox4.Enabled = true;
      this.ToolBar1.Enabled = true;
      this.TransitPanel.Enabled = true;
      object obj;
      return obj;
    }

    private object GebeBuildingAus()
    {
      if (this.AktuellesLot.ExemplarIndex > -1)
      {
        this.DockControl7.Enabled = true;
        this.TransitSwitchToolBar.Enabled = true;
        this.TransitSwitchGrid.RowsCount = 0;
        this.TransitSwitchGrid.ColumnsCount = 7;
        this.TransitSwitchGrid.Columns[0].Width = 30;
        this.TransitSwitchGrid.Columns[1].Width = 30;
        this.TransitSwitchGrid.Columns[2].Width = 150;
        this.TransitSwitchGrid.Columns[3].Width = 150;
        this.TransitSwitchGrid.Columns[4].Width = 100;
        this.TransitSwitchGrid.Columns[5].Width = 100;
        this.TransitSwitchGrid.Columns[6].Width = 0;
        this.TransitSwitchGrid.Rows.Insert(this.TransitSwitchGrid.RowsCount);
        sr_SourceGrid.VisualModels.Common common1 = new sr_SourceGrid.VisualModels.Common();
        common1.Image = this.ImageList1.Images[21];
        common1.ImageAlignment = SourceLibrary.Drawing.ContentAlignment.MiddleCenter;
        PositionEventHandler p_Click1 = new PositionEventHandler(this.TransitSwitchGrid_EditButtonClick);
        PositionEventHandler p_Click2 = new PositionEventHandler(this.TransitSwitchGrid_DelButtonClick);
        PositionEventHandler p_Click3 = new PositionEventHandler(this.TransitSwitchGrid_EditSwitchButtonClick);
        sr_SourceGrid.Cells.Real.Button button1 = new sr_SourceGrid.Cells.Real.Button((object) "", p_Click1, (IVisualModel) common1, (IBehaviorModel) null);
        sr_SourceGrid.VisualModels.Common common2 = new sr_SourceGrid.VisualModels.Common();
        common2.Image = this.ImageList1.Images[16];
        common2.ImageAlignment = SourceLibrary.Drawing.ContentAlignment.MiddleCenter;
        this.TransitSwitchGrid.Rows.Insert(this.TransitSwitchGrid.RowsCount);
        this.TransitSwitchGrid[checked (this.TransitSwitchGrid.RowsCount - 1), 0] = (ICell) button1;
        string str1 = "0";
        Lot.ExemplarTransitSettings transitSettings = this.AktuellesLot.TransitSettings;
        if (!Information.IsNothing((object) transitSettings.TransitEntryCost))
          str1 = this.AktuellesLot.TransitSettings.TransitEntryCost.ToString();
        this.TransitSwitchGrid[checked (this.TransitSwitchGrid.RowsCount - 1), 2] = (ICell) new Cell(RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[425]), (IDataModel) null, (IVisualModel) this.l_TitleModel);
        ICell cell1 = (ICell) new Cell((object) str1);
        cell1.ColumnSpan = 3;
        this.TransitSwitchGrid[checked (this.TransitSwitchGrid.RowsCount - 1), 3] = cell1;
        this.TransitSwitchGrid.Rows.Insert(this.TransitSwitchGrid.RowsCount);
        string str2 = "0";
        if (!Information.IsNothing((object) this.AktuellesLot.TransitSettings.TransitCapacity))
        {
          transitSettings = this.AktuellesLot.TransitSettings;
          str2 = transitSettings.TransitCapacity.ToString();
        }
        this.TransitSwitchGrid[checked (this.TransitSwitchGrid.RowsCount - 1), 2] = (ICell) new Cell(RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[426]), (IDataModel) null, (IVisualModel) this.l_TitleModel);
        ICell cell2 = (ICell) new Cell((object) str2);
        cell2.ColumnSpan = 3;
        this.TransitSwitchGrid[checked (this.TransitSwitchGrid.RowsCount - 1), 3] = cell2;
        this.TransitSwitchGrid.Rows.Insert(this.TransitSwitchGrid.RowsCount);
        if (this.AktuellesLot.TransitSettings.TransitSwitchPoint.GetUpperBound(0) > -1)
        {
          transitSettings = this.AktuellesLot.TransitSettings;
          int upperBound = transitSettings.TransitSwitchPoint.GetUpperBound(0);
          int index = 0;
          while (index <= upperBound)
          {
            string[] strArray = this.AktuellesLot.TransitSettings.TransitSwitchPoint[index].Split(',');
            if (strArray.GetUpperBound(0) == 3)
            {
              this.TransitSwitchGrid.Rows.Insert(this.TransitSwitchGrid.RowsCount);
              sr_SourceGrid.Cells.Real.Button button2 = new sr_SourceGrid.Cells.Real.Button((object) "", p_Click2, (IVisualModel) common2, (IBehaviorModel) null);
              button2.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[132]);
              sr_SourceGrid.Cells.Real.Button button3 = new sr_SourceGrid.Cells.Real.Button((object) "", p_Click3, (IVisualModel) common1, (IBehaviorModel) null);
              button3.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[431]);
              this.TransitSwitchGrid[checked (this.TransitSwitchGrid.RowsCount - 1), 0] = (ICell) button3;
              this.TransitSwitchGrid[checked (this.TransitSwitchGrid.RowsCount - 1), 1] = (ICell) button2;
              string upper = strArray[0].ToUpper();
              this.TransitSwitchGrid[checked (this.TransitSwitchGrid.RowsCount - 1), 2] = (ICell) new Cell(StringType.StrCmp(upper, "0X00000081", false) != 0 ? (StringType.StrCmp(upper, "0X00000082", false) != 0 ? (object) "" : (object) StringType.FromObject(ClassThisProg.DefReader.LanguageArray[420])) : (object) StringType.FromObject(ClassThisProg.DefReader.LanguageArray[421]), (IDataModel) null, (IVisualModel) this.l_TitleModel);
              this.TransitSwitchGrid[checked (this.TransitSwitchGrid.RowsCount - 1), 3] = (ICell) new Cell((object) AllgemeineKlasse.GetTransitSwitchDirectionString(strArray[1], ClassThisProg.DefReader.LanguageArray), (IDataModel) null, (IVisualModel) this.l_CenterModel);
              this.TransitSwitchGrid[checked (this.TransitSwitchGrid.RowsCount - 1), 4] = (ICell) new Cell((object) AllgemeineKlasse.GetTransitSwitchTypeString(strArray[2], ClassThisProg.DefReader.LanguageArray), (IDataModel) null, (IVisualModel) this.l_CenterModel);
              this.TransitSwitchGrid[checked (this.TransitSwitchGrid.RowsCount - 1), 5] = (ICell) new Cell((object) AllgemeineKlasse.GetTransitSwitchTypeString(strArray[3], ClassThisProg.DefReader.LanguageArray), (IDataModel) null, (IVisualModel) this.l_CenterModel);
              this.TransitSwitchGrid[checked (this.TransitSwitchGrid.RowsCount - 1), 6] = (ICell) new Cell((object) index.ToString());
              this.TransitSwitchGrid.Rows.Insert(this.TransitSwitchGrid.RowsCount);
            }
            checked { ++index; }
          }
        }
      }
      else
      {
        this.DockControl7.Enabled = false;
        this.TransitSwitchToolBar.Enabled = false;
      }
      object obj;
      return obj;
    }

    private bool LeseDaten()
    {
      MainReader mainReader = new MainReader();
      this.LotExemplarArray.Clear();
      this.BuildingExemplarArray.Clear();
      this.LotIndexArray.Clear();
      this.ExemplarIndexArray.Clear();
      this.LotExemplarInstanceArray.Clear();
      this.BuildingExemplarInstanceArray.Clear();
      this.NodeArray.Clear();
      bool flag = false;
      TreeView treeView1_1 = this.TreeView1;
      treeView1_1.Nodes.Clear();
      treeView1_1.ImageList = this.ImageList1;
      treeView1_1.AllowDrop = false;
      treeView1_1.CheckBoxes = false;
      treeView1_1.FullRowSelect = true;
      treeView1_1.ShowLines = false;
      treeView1_1.ShowPlusMinus = false;
      treeView1_1.ShowRootLines = false;
      treeView1_1.HideSelection = false;
      treeView1_1.SuspendLayout();
      treeView1_1.BeginUpdate();
      mainReader.EingabeDatei = this.LeseDatei;
      if (!mainReader.StartRead())
        return false;
      if (mainReader.IndexEntries.Count == 0)
      {
        this.Cursor = Cursors.Default;
        return false;
      }
      int num1 = checked (mainReader.IndexEntries.Count - 1);
      int num2 = 0;
      while (num2 <= num1)
      {
        if (ObjectType.ObjTst(LateBinding.LateGet(mainReader.IndexEntries[num2], (System.Type) null, "FileTyp", new object[0], (string[]) null, (bool[]) null), (object) "Exemplar", false) == 0)
        {
          MainReader.Exemplar NewExemplar = new MainReader.Exemplar();
          NewExemplar.ExemplarTyp = "";
          NewExemplar.Values = new ArrayList();
          NewExemplar.Instance = AllgemeineKlasse.FormatiereHexWert(LateBinding.LateGet(mainReader.IndexEntries[num2], (System.Type) null, "Instance", new object[0], (string[]) null, (bool[]) null).ToString());
          byte[] bytesOfFile = mainReader.GetBytesOfFile(num2);
          mainReader.ReadExemplar(ref NewExemplar, bytesOfFile, checked (bytesOfFile.GetUpperBound(0) - 1));
          if (NewExemplar.Values.Count > 0)
          {
            string exemplarTyp = NewExemplar.ExemplarTyp;
            if (StringType.StrCmp(exemplarTyp, "Lot", false) == 0)
            {
              if (NewExemplar.Values.Count > 0)
              {
                this.LotExemplarArray.Add((object) NewExemplar);
                this.LotExemplarInstanceArray.Add((object) NewExemplar.Instance);
                this.LotIndexArray.Add((object) num2);
                int num3;
                checked { ++num3; }
              }
            }
            else if (StringType.StrCmp(exemplarTyp, "Building", false) == 0 && NewExemplar.Values.Count > 0)
            {
              this.BuildingExemplarArray.Add((object) NewExemplar);
              this.BuildingExemplarInstanceArray.Add((object) NewExemplar.Instance);
              this.ExemplarIndexArray.Add((object) num2);
            }
          }
        }
        checked { ++num2; }
      }
      mainReader.Dispose();
      int index1 = 0;
      TreeView treeView1_2 = this.TreeView1;
      if (this.LotExemplarArray.Count > 0)
      {
        flag = true;
        int num4 = checked (this.LotExemplarArray.Count - 1);
        int index2 = 0;
        while (index2 <= num4)
        {
          treeView1_2.Nodes.Add(new TreeNode(StringType.FromObject(LateBinding.LateGet(this.LotExemplarArray[index2], (System.Type) null, "ExemplarName", new object[0], (string[]) null, (bool[]) null))));
          treeView1_2.Nodes[index1].Tag = (object) index2;
          int num5 = -1;
          if (this.BuildingExemplarArray.Count > 0)
            num5 = this.BuildingExemplarInstanceArray.IndexOf(RuntimeHelpers.GetObjectValue(this.LotExemplarInstanceArray[index2]));
          this.NodeArray.Add((object) num5);
          if (num5 > -1)
          {
            treeView1_2.Nodes[index1].SelectedImageIndex = 9;
            treeView1_2.Nodes[index1].ImageIndex = 9;
          }
          else
          {
            treeView1_2.Nodes[index1].SelectedImageIndex = 10;
            treeView1_2.Nodes[index1].ImageIndex = 10;
          }
          checked { ++index1; }
          checked { ++index2; }
        }
      }
      treeView1_2.EndUpdate();
      this.hasNotSavedChanges = false;
      if (flag)
        this.TreeView1.SelectedNode = this.TreeView1.Nodes[0];
      return flag;
    }

    private object FillWerteGitter()
    {
      this.RepGrid.RowsCount = 1;
      sr_SourceGrid.VisualModels.Common common = new sr_SourceGrid.VisualModels.Common(false);
      common.TextAlignment = SourceLibrary.Drawing.ContentAlignment.MiddleCenter;
      common.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      if (this.AktuellesLot.Tiles[this.AktuellerTileIndex].WerteString.Count > 0)
      {
        int num = checked (this.AktuellesLot.Tiles[this.AktuellerTileIndex].WerteString.Count - 1);
        int index = 0;
        while (index <= num)
        {
          string[] strArray = this.AktuellesLot.Tiles[this.AktuellerTileIndex].WerteString[index].ToString().Split(',');
          if (strArray.GetUpperBound(0) > -1)
          {
            this.RepGrid.Rows.Insert(this.RepGrid.RowsCount);
            int upperBound = strArray.GetUpperBound(0);
            int col = 0;
            while (col <= upperBound)
            {
              ICell cell = (ICell) new Cell((object) strArray[col], (IDataModel) null, (IVisualModel) common);
              this.RepGrid[checked (this.RepGrid.RowsCount - 1), col] = cell;
              checked { ++col; }
            }
          }
          checked { ++index; }
        }
      }
      this.RepGrid.Height = checked (this.RepGrid.RowsCount * 20 + 20);
      object obj;
      return obj;
    }

    private object RefreshOutput()
    {
      this.Graphicgrid1.ShowTransitString = this.ShowTransitString;
      if (this.Graphicgrid1.CellSize < 64)
        this.Graphicgrid1.ShowTransitString = false;
      int upperBound1 = this.AktuellesLot.Tiles.GetUpperBound(0);
      int i = 0;
      while (i <= upperBound1)
      {
        if (StringType.StrCmp(this.AktuellesLot.Tiles[i].TransitArt, "", false) != 0)
        {
          LotTile.BitmapAusgabe[] bitmapAusgabeArray = new LotTile.BitmapAusgabe[0];
          LotTile tile = this.AktuellesLot.Tiles[i];
          Point Cell;
          Cell.X = tile.Spalte;
          Cell.Y = tile.Zeile;
          LotTile.BitmapAusgabe[] tileBitmaps = this.AktuellesLot.GetTileBitmaps(i);
          if (tileBitmaps.GetUpperBound(0) > -1)
          {
            this.Graphicgrid1.removeCell(Cell);
            int upperBound2 = tileBitmaps.GetUpperBound(0);
            int index = 0;
            while (index <= upperBound2)
            {
              if (this.Graphicgrid1.ShowTransitString)
              {
                if (StringType.StrCmp(tileBitmaps[index].Typ, "TrafficDirection", false) != 0)
                  this.Graphicgrid1.setCell(Cell, tileBitmaps[index].AusgabeBild, tileBitmaps[index].Direction, tileBitmaps[index].isTransparent, tileBitmaps[index].isMirror);
              }
              else
                this.Graphicgrid1.setCell(Cell, tileBitmaps[index].AusgabeBild, tileBitmaps[index].Direction, tileBitmaps[index].isTransparent, tileBitmaps[index].isMirror);
              checked { ++index; }
            }
            if (this.Graphicgrid1.ShowTransitString && StringType.StrCmp(this.AktuellesLot.Tiles[i].TransitArt, "", false) != 0)
            {
              AllgemeineKlasse.DirectionText DirText;
              DirText.TextTop = Conversion.Hex(RuntimeHelpers.GetObjectValue(this.AktuellesLot.Tiles[i].DirectionArray[0])).ToString();
              DirText.TextLeft = Conversion.Hex(RuntimeHelpers.GetObjectValue(this.AktuellesLot.Tiles[i].DirectionArray[1])).ToString();
              DirText.TextButtom = Conversion.Hex(RuntimeHelpers.GetObjectValue(this.AktuellesLot.Tiles[i].DirectionArray[2])).ToString();
              DirText.TextRight = Conversion.Hex(RuntimeHelpers.GetObjectValue(this.AktuellesLot.Tiles[i].DirectionArray[3])).ToString();
              this.Graphicgrid1.setCell(Cell, DirText);
            }
          }
        }
        checked { ++i; }
      }
      object obj;
      return obj;
    }

    private object ZeichneTile(int i)
    {
      LotTile.BitmapAusgabe[] bitmapAusgabeArray = new LotTile.BitmapAusgabe[0];
      LotTile tile = this.AktuellesLot.Tiles[i];
      Point Cell;
      Cell.X = tile.Spalte;
      Cell.Y = tile.Zeile;
      this.Graphicgrid1.removeCell(Cell);
      this.Graphicgrid1.ShowTransitString = this.ShowTransitString;
      if (this.Graphicgrid1.CellSize < 64)
        this.Graphicgrid1.ShowTransitString = false;
      LotTile.BitmapAusgabe[] tileBitmaps = this.AktuellesLot.GetTileBitmaps(i);
      if (tileBitmaps.GetUpperBound(0) > -1)
      {
        int upperBound = tileBitmaps.GetUpperBound(0);
        int index = 0;
        while (index <= upperBound)
        {
          if (this.Graphicgrid1.ShowTransitString)
          {
            if (StringType.StrCmp(tileBitmaps[index].Typ, "TrafficDirection", false) != 0)
              this.Graphicgrid1.setCell(Cell, tileBitmaps[index].AusgabeBild, tileBitmaps[index].Direction, tileBitmaps[index].isTransparent, tileBitmaps[index].isMirror);
          }
          else
            this.Graphicgrid1.setCell(Cell, tileBitmaps[index].AusgabeBild, tileBitmaps[index].Direction, tileBitmaps[index].isTransparent, tileBitmaps[index].isMirror);
          checked { ++index; }
        }
        if (this.Graphicgrid1.ShowTransitString && StringType.StrCmp(this.AktuellesLot.Tiles[i].TransitArt, "", false) != 0)
        {
          AllgemeineKlasse.DirectionText DirText;
          DirText.TextTop = Conversion.Hex(RuntimeHelpers.GetObjectValue(this.AktuellesLot.Tiles[i].DirectionArray[0])).ToString();
          DirText.TextLeft = Conversion.Hex(RuntimeHelpers.GetObjectValue(this.AktuellesLot.Tiles[i].DirectionArray[1])).ToString();
          DirText.TextButtom = Conversion.Hex(RuntimeHelpers.GetObjectValue(this.AktuellesLot.Tiles[i].DirectionArray[2])).ToString();
          DirText.TextRight = Conversion.Hex(RuntimeHelpers.GetObjectValue(this.AktuellesLot.Tiles[i].DirectionArray[3])).ToString();
          this.Graphicgrid1.setCell(Cell, DirText);
        }
      }
      object obj;
      return obj;
    }

    private object SetActiveCell(object GridPoint)
    {
      ArrayList arrayList1 = new ArrayList();
      ArrayList arrayList2 = new ArrayList();
      this.Graphicgrid1.SelectedCells.Clear();
      this.Graphicgrid1.SelectedCells.Add(RuntimeHelpers.GetObjectValue(GridPoint));
      this.RepGrid.Redim(1, 17);
      this.TextureGrid.Redim(2, 2);
      this.AktuellerGridPoint = (Point) (GridPoint ?? Activator.CreateInstance(typeof (Point)));
      this.AktuellerTileIndex = this.AktuellesLot.SearchTile(this.AktuellerGridPoint);
      this.mnuItemAdd.Enabled = false;
      this.mnuItemRemove.Enabled = false;
      this.mnuItemChangeDirection.Enabled = false;
      this.mnuItemEditTransit.Enabled = false;
      if (this.AktuellerTileIndex > -1)
      {
        if (this.AktuellesLot.Tiles[this.AktuellerTileIndex].Textures.GetUpperBound(0) > -1)
        {
          int upperBound = this.AktuellesLot.Tiles[this.AktuellerTileIndex].Textures.GetUpperBound(0);
          int index1 = 0;
          while (index1 <= upperBound)
          {
            this.TextureGrid.Rows.Insert(this.TextureGrid.RowsCount);
            if (this.AktuellesLot.Tiles[this.AktuellerTileIndex].Textures[index1].isBase)
              arrayList1.Add((object) this.AktuellesLot.Tiles[this.AktuellerTileIndex].Textures[index1].Gruppe);
            else
              arrayList2.Add((object) this.AktuellesLot.Tiles[this.AktuellerTileIndex].Textures[index1].Gruppe);
            checked { ++index1; }
          }
          try
          {
            int row1 = 2;
            if (arrayList1.Count > 0)
            {
              int num = checked (arrayList1.Count - 1);
              int index2 = 0;
              while (index2 <= num)
              {
                ICell cell = (ICell) new Cell(RuntimeHelpers.GetObjectValue(arrayList1[index2]));
                this.TextureGrid[row1, 0] = cell;
                checked { ++row1; }
                checked { ++index2; }
              }
            }
            int row2 = 2;
            if (arrayList2.Count > 0)
            {
              int num = checked (arrayList2.Count - 1);
              int index3 = 0;
              while (index3 <= num)
              {
                ICell cell = (ICell) new Cell(RuntimeHelpers.GetObjectValue(arrayList2[index3]));
                this.TextureGrid[row2, 1] = cell;
                checked { ++row2; }
                checked { ++index3; }
              }
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
        }
        this.FillWerteGitter();
        if (StringType.StrCmp(this.AktuellesLot.Tiles[this.AktuellerTileIndex].TransitArt, "", false) == 0)
        {
          if (ObjectType.ObjTst(this.ActiveTrafficArt, (object) "", false) != 0 && !this.AktuellesLot.Tiles[this.AktuellerTileIndex].isWater)
            this.mnuItemAdd.Enabled = true;
        }
        else
        {
          this.mnuItemRemove.Enabled = true;
          this.mnuItemChangeDirection.Enabled = true;
          this.mnuItemEditTransit.Enabled = true;
        }
      }
      object obj;
      return obj;
    }

    private object RotateTransit()
    {
      ArrayList arrayList1 = new ArrayList();
      ArrayList arrayList2 = new ArrayList();
      ArrayList newArray = (ArrayList) this.AktuellesLot.Tiles[this.AktuellerTileIndex].DirectionArray.Clone();
      ArrayList arrayList3 = (ArrayList) newArray.Clone();
      newArray[0] = RuntimeHelpers.GetObjectValue(arrayList3[1]);
      newArray[1] = RuntimeHelpers.GetObjectValue(arrayList3[2]);
      newArray[2] = RuntimeHelpers.GetObjectValue(arrayList3[3]);
      newArray[3] = RuntimeHelpers.GetObjectValue(arrayList3[0]);
      int num = checked (newArray.Count - 1);
      int index = 0;
      while (index <= num)
      {
        if (newArray[index].ToString().Length == 1)
          newArray[index] = ObjectType.StrCatObj((object) "0", newArray[index]);
        checked { ++index; }
      }
      this.hasNotSavedChanges = true;
      this.AktuellesLot.Tiles[this.AktuellerTileIndex].SetDirectionArray(newArray);
      this.SetActiveCell((object) this.AktuellerGridPoint);
      this.ZeichneTile(this.AktuellerTileIndex);
      object obj;
      return obj;
    }

    private bool GetTrafficString(
      string DummyText,
      ref string TrafficString,
      ref string DirectionString,
      string Position)
    {
      string str1 = "00";
      string str2 = "00";
      string str3 = "00";
      string str4 = "00";
      TrafficString = "";
      DirectionString = "0X";
      string sLeft = DummyText;
      if (StringType.StrCmp(sLeft, "A", false) == 0)
        TrafficString = "0x00000003";
      else if (StringType.StrCmp(sLeft, "B", false) == 0)
        TrafficString = "0x0000000A";
      else if (StringType.StrCmp(sLeft, "C", false) == 0)
        TrafficString = "0x00000000";
      else if (StringType.StrCmp(sLeft, "D", false) == 0)
        TrafficString = "0x00000006";
      else if (StringType.StrCmp(sLeft, "E", false) == 0)
        TrafficString = "0x00000002";
      else if (StringType.StrCmp(sLeft, "F", false) == 0)
        TrafficString = "0x0000000C";
      else if (StringType.StrCmp(sLeft, "G", false) == 0)
        TrafficString = "0x00000001";
      else if (StringType.StrCmp(sLeft, "H", false) == 0)
        TrafficString = "0x00000008";
      else if (StringType.StrCmp(sLeft, "I", false) == 0)
        TrafficString = "0x00000009";
      if (StringType.StrCmp(TrafficString, "", false) == 0)
        return false;
      if (this.CheckNorth.Checked)
        str1 = "02";
      if (this.CheckWest.Checked)
        str2 = "02";
      if (this.CheckSouth.Checked)
        str3 = "02";
      if (this.CheckEast.Checked)
        str4 = "02";
      DirectionString = "0X" + str1 + str2 + str3 + str4;
      if (StringType.StrCmp(DirectionString, "0X00000000", false) == 0)
      {
        TrafficString = "";
        DirectionString = "";
        return false;
      }
      if (StringType.StrCmp(Position, "", false) != 0)
      {
        if (this.DirButton1.Checked)
        {
          if (StringType.StrCmp(Position, "1", false) == 0)
            str4 = "04";
          else
            str2 = "04";
        }
        else if (StringType.StrCmp(Position, "1", false) == 0)
          str3 = "04";
        else
          str1 = "04";
        DirectionString = "0X" + str1 + str2 + str3 + str4;
      }
      return true;
    }

    private Point CheckTraffic(Point GridPoint)
    {
      Point point1;
      point1.X = -1;
      point1.Y = -1;
      string sLeft = "West";
      if (this.DirButton1.Checked)
        sLeft = "North";
      Point point2;
      if (this.AktuellesLot.SearchTile(GridPoint) == -1)
        point2 = point1;
      else if (StringType.StrCmp(sLeft, "West", false) == 0)
      {
        point1.X = GridPoint.X;
        if (checked (GridPoint.Y + 1) <= checked (this.AktuellesLot.Hoehe - 1))
          point1.Y = checked (GridPoint.Y + 1);
        else if (checked (GridPoint.Y - 1) >= 0)
          point1.Y = checked (GridPoint.Y - 1);
        point2 = point1;
      }
      else if (StringType.StrCmp(sLeft, "North", false) == 0)
      {
        point1.Y = GridPoint.Y;
        if (checked (GridPoint.X + 1) <= checked (this.AktuellesLot.Breite - 1))
          point1.X = checked (GridPoint.X + 1);
        else if (checked (GridPoint.X - 1) >= 0)
          point1.X = checked (GridPoint.X - 1);
        point2 = point1;
      }
      return point2;
    }

    private object AddTraffic(Point GridPoint, string DummyText)
    {
      if (StringType.StrCmp(DummyText, "D", false) == 0 | StringType.StrCmp(DummyText, "E", false) == 0 | StringType.StrCmp(DummyText, "F", false) == 0)
      {
        Point SuchPoint = this.CheckTraffic(GridPoint);
        if (SuchPoint.X > -1 & SuchPoint.Y > -1)
        {
          int i1 = this.AktuellesLot.SearchTile(GridPoint);
          int i2 = this.AktuellesLot.SearchTile(SuchPoint);
          if (i1 != i2)
          {
            string TrafficString1;
            string DirectionString1;
            this.GetTrafficString(DummyText, ref TrafficString1, ref DirectionString1, "1");
            if (StringType.StrCmp(TrafficString1, "", false) != 0 & StringType.StrCmp(DirectionString1, "", false) != 0)
            {
              string TrafficString2;
              string DirectionString2;
              this.GetTrafficString(DummyText, ref TrafficString2, ref DirectionString2, "2");
              if (StringType.StrCmp(TrafficString2, "", false) != 0 & StringType.StrCmp(DirectionString2, "", false) != 0 && this.AktuellesLot.AddTraffic(i1, TrafficString1, DirectionString1) && this.AktuellesLot.AddTraffic(i2, TrafficString2, DirectionString2))
              {
                this.ZeichneTile(i1);
                this.ZeichneTile(i2);
                this.ChainTable1.Add((object) i1);
                this.ChainTable2.Add((object) i2);
                this.hasNotSavedChanges = true;
                this.GebeBuildingAus();
              }
            }
          }
        }
      }
      else
      {
        int i = this.AktuellesLot.SearchTile(GridPoint);
        string TrafficString;
        string DirectionString;
        this.GetTrafficString(DummyText, ref TrafficString, ref DirectionString, "");
        if (StringType.StrCmp(TrafficString, "", false) != 0 & StringType.StrCmp(DirectionString, "", false) != 0 && this.AktuellesLot.AddTraffic(i, TrafficString, DirectionString))
        {
          this.hasNotSavedChanges = true;
          this.ZeichneTile(i);
          this.GebeBuildingAus();
        }
      }
      this.SetActiveCell((object) GridPoint);
      object obj;
      return obj;
    }

    private object RemoveTraffic()
    {
      int i = -1;
      if (this.AktuellerTileIndex > -1)
      {
        int aktuellerTileIndex = this.AktuellerTileIndex;
        if (this.ChainTable1.Count > 0)
        {
          int index1 = this.ChainTable1.IndexOf((object) this.AktuellerTileIndex);
          if (index1 > -1)
          {
            i = IntegerType.FromObject(this.ChainTable2[index1]);
            this.ChainTable2.RemoveAt(index1);
            this.ChainTable1.RemoveAt(index1);
          }
          else
          {
            int index2 = this.ChainTable2.IndexOf((object) this.AktuellerTileIndex);
            if (index2 > -1)
            {
              i = IntegerType.FromObject(this.ChainTable1[index2]);
              this.ChainTable1.RemoveAt(index2);
              this.ChainTable2.RemoveAt(index2);
            }
          }
        }
        if (aktuellerTileIndex > -1)
        {
          this.AktuellesLot.RemoveTraffic(aktuellerTileIndex);
          this.hasNotSavedChanges = true;
          this.ZeichneTile(aktuellerTileIndex);
        }
        if (i > -1)
        {
          this.AktuellesLot.RemoveTraffic(i);
          this.ZeichneTile(i);
        }
        this.SetActiveCell((object) this.AktuellerGridPoint);
        this.GebeBuildingAus();
      }
      object obj;
      return obj;
    }

    private object CheckIfMustSave()
    {
      if (!Information.IsNothing((object) this.AktuellesLot) && this.ButtonSave.Enabled && this.hasNotSavedChanges && MessageBox.Show((IWin32Window) this, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[469]), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[429]), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        this.SaveFiles();
      object obj;
      return obj;
    }

    private object SaveFiles()
    {
      this.AktuellesLot.CommonDefs = this.myDefs;
      if (this.AktuellesLot.Save(this.LeseDatei, this.LeseDatei))
      {
        int num = (int) MessageBox.Show((IWin32Window) this, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[27]), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[17]), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.hasNotSavedChanges = false;
      }
      else
      {
        int num1 = (int) MessageBox.Show((IWin32Window) this, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[26]), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[17]), MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      object obj;
      return obj;
    }

    private object ResetLabelColors(int i)
    {
      this.T_Label_1.ForeColor = SystemColors.ControlText;
      this.T_Label_2.ForeColor = SystemColors.ControlText;
      this.T_Label_3.ForeColor = SystemColors.ControlText;
      this.T_Label_4.ForeColor = SystemColors.ControlText;
      this.T_Label_5.ForeColor = SystemColors.ControlText;
      this.T_Label_6.ForeColor = SystemColors.ControlText;
      this.T_Label_7.ForeColor = SystemColors.ControlText;
      this.T_Label_8.ForeColor = SystemColors.ControlText;
      this.T_Label_9.ForeColor = SystemColors.ControlText;
      switch (i)
      {
        case 1:
          this.ActiveTrafficArt = (object) "A";
          this.T_Label_1.ForeColor = Color.Red;
          break;
        case 2:
          this.ActiveTrafficArt = (object) "B";
          this.T_Label_2.ForeColor = Color.Red;
          break;
        case 3:
          this.ActiveTrafficArt = (object) "C";
          this.T_Label_3.ForeColor = Color.Red;
          break;
        case 4:
          this.ActiveTrafficArt = (object) "D";
          this.T_Label_4.ForeColor = Color.Red;
          break;
        case 5:
          this.ActiveTrafficArt = (object) "E";
          this.T_Label_5.ForeColor = Color.Red;
          break;
        case 6:
          this.ActiveTrafficArt = (object) "F";
          this.T_Label_6.ForeColor = Color.Red;
          break;
        case 7:
          this.ActiveTrafficArt = (object) "G";
          this.T_Label_7.ForeColor = Color.Red;
          break;
        case 8:
          this.ActiveTrafficArt = (object) "H";
          this.T_Label_8.ForeColor = Color.Red;
          break;
        case 9:
          this.ActiveTrafficArt = (object) "I";
          this.T_Label_9.ForeColor = Color.Red;
          break;
      }
      object obj;
      return obj;
    }

    private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
    {
      if (!(Information.IsNumeric(RuntimeHelpers.GetObjectValue(e.Node.Tag)) & this.LotExemplarArray.Count > 0) || IntegerType.FromObject(e.Node.Tag) > checked (this.LotExemplarArray.Count - 1))
        return;
      this.CheckIfMustSave();
      this.Cursor = Cursors.WaitCursor;
      Application.DoEvents();
      this.Clear();
      this.HeaderControl1.Text = "Reading....";
      this.StatusBarPanel1.Text = "Reading....";
      int index = IntegerType.FromObject(e.Node.Tag);
      MainReader.Exemplar exemplar1 = new MainReader.Exemplar();
      MainReader.Exemplar LotExemplar = (MainReader.Exemplar) (this.LotExemplarArray[index] ?? Activator.CreateInstance(typeof (MainReader.Exemplar)));
      MainReader.Exemplar exemplar2;
      if (ObjectType.ObjTst(this.NodeArray[index], (object) -1, false) > 0)
      {
        exemplar2 = new MainReader.Exemplar();
        MainReader.Exemplar BuildingExemplar = (MainReader.Exemplar) (this.BuildingExemplarArray[IntegerType.FromObject(this.NodeArray[index])] ?? Activator.CreateInstance(typeof (MainReader.Exemplar)));
        this.AktuellesLot = new Lot(LotExemplar, IntegerType.FromObject(this.LotIndexArray[index]), BuildingExemplar, IntegerType.FromObject(this.ExemplarIndexArray[index]));
      }
      else
      {
        exemplar2 = (MainReader.Exemplar) ((object) null ?? Activator.CreateInstance(typeof (MainReader.Exemplar)));
        this.AktuellesLot = new Lot(LotExemplar, IntegerType.FromObject(this.LotIndexArray[index]), (MainReader.Exemplar) ((object) null ?? Activator.CreateInstance(typeof (MainReader.Exemplar))), -1);
      }
      if (this.AktuellesLot.isValid)
      {
        this.HeaderControl1.Text = e.Node.Text;
        this.StatusBarPanel1.Text = "";
        this.hasNotSavedChanges = false;
        this.AktuellesLot.Index = IntegerType.FromObject(this.LotIndexArray[index]);
        this.GebeLotAus();
        this.GebeBuildingAus();
        if (this.AktuellesLot.hasBadTiles)
          this.ButtonSave.Enabled = false;
        else
          this.ButtonSave.Enabled = true;
      }
      else
      {
        this.HeaderControl1.Text = "<error>";
        this.StatusBarPanel1.Text = "<error>";
      }
      this.Cursor = Cursors.Default;
    }

    private void Graphicgrid1_DragEnter(object sender, DragEventArgs e)
    {
      if (e.Data.GetDataPresent(DataFormats.Text))
        e.Effect = DragDropEffects.Copy;
      else
        e.Effect = DragDropEffects.None;
    }

    private void Graphicgrid1_DragDrop(object sender, DragEventArgs e)
    {
      Point client = this.Graphicgrid1.PointToClient(Control.MousePosition);
      this.AddTraffic(new Point(checked ((int) Math.Round(Conversion.Int(unchecked ((double) client.X / (double) this.Graphicgrid1.CellSize)))), checked ((int) Math.Round(Conversion.Int(unchecked ((double) client.Y / (double) this.Graphicgrid1.CellSize))))), StringType.FromObject(e.Data.GetData(DataFormats.Text)));
    }

    private void Graphicgrid1_DragOver(object sender, DragEventArgs e)
    {
    }

    private void Graphicgrid1_gridClick(object sender, Point GridPoint)
    {
    }

    private void T1_Picture_1_MouseDown(object sender, MouseEventArgs e)
    {
      this.AktuellerGridPoint = (Point) ((object) null ?? Activator.CreateInstance(typeof (Point)));
      this.ResetLabelColors(1);
    }

    private void T2_Picture_1_MouseDown(object sender, MouseEventArgs e)
    {
      this.AktuellerGridPoint = (Point) ((object) null ?? Activator.CreateInstance(typeof (Point)));
      this.ResetLabelColors(2);
    }

    private void T3_Picture_1_MouseDown(object sender, MouseEventArgs e)
    {
      this.AktuellerGridPoint = (Point) ((object) null ?? Activator.CreateInstance(typeof (Point)));
      this.ResetLabelColors(3);
    }

    private void T4_Picture_1_MouseDown(object sender, MouseEventArgs e)
    {
      this.AktuellerGridPoint = (Point) ((object) null ?? Activator.CreateInstance(typeof (Point)));
      this.ResetLabelColors(4);
    }

    private void T5_Picture_1_MouseDown(object sender, MouseEventArgs e)
    {
      this.AktuellerGridPoint = (Point) ((object) null ?? Activator.CreateInstance(typeof (Point)));
      this.ResetLabelColors(5);
    }

    private void T6_Picture_1_MouseDown(object sender, MouseEventArgs e)
    {
      this.AktuellerGridPoint = (Point) ((object) null ?? Activator.CreateInstance(typeof (Point)));
      this.ResetLabelColors(6);
    }

    private void T7_Picture_1_MouseDown(object sender, MouseEventArgs e)
    {
      this.AktuellerGridPoint = (Point) ((object) null ?? Activator.CreateInstance(typeof (Point)));
      this.ResetLabelColors(7);
    }

    private void T8_Picture_1_MouseDown(object sender, MouseEventArgs e)
    {
      this.AktuellerGridPoint = (Point) ((object) null ?? Activator.CreateInstance(typeof (Point)));
      this.ResetLabelColors(8);
    }

    private void T9_Picture_1_MouseDown(object sender, MouseEventArgs e)
    {
      this.AktuellerGridPoint = (Point) ((object) null ?? Activator.CreateInstance(typeof (Point)));
      this.ResetLabelColors(9);
    }

    private void T1_Picture_1_MouseMove(object sender, MouseEventArgs e)
    {
      if ((e.Button & MouseButtons.Left) != MouseButtons.Left)
        return;
      int num = (int) this.T1_Picture_1.DoDragDrop((object) "A", DragDropEffects.Copy);
    }

    private void T2_Picture_1_MouseMove(object sender, MouseEventArgs e)
    {
      if ((e.Button & MouseButtons.Left) != MouseButtons.Left)
        return;
      int num = (int) this.T2_Picture_1.DoDragDrop((object) "B", DragDropEffects.Copy);
    }

    private void T3_Picture_1_MouseMove(object sender, MouseEventArgs e)
    {
      if ((e.Button & MouseButtons.Left) != MouseButtons.Left)
        return;
      int num = (int) this.T3_Picture_1.DoDragDrop((object) "C", DragDropEffects.Copy);
    }

    private void T4_Picture_1_MouseMove(object sender, MouseEventArgs e)
    {
      if ((e.Button & MouseButtons.Left) != MouseButtons.Left)
        return;
      int num = (int) this.T4_Picture_1.DoDragDrop((object) "D", DragDropEffects.Copy);
    }

    private void T5_Picture_1_MouseMove(object sender, MouseEventArgs e)
    {
      if ((e.Button & MouseButtons.Left) != MouseButtons.Left)
        return;
      int num = (int) this.T5_Picture_1.DoDragDrop((object) "E", DragDropEffects.Copy);
    }

    private void T6_Picture_1_MouseMove(object sender, MouseEventArgs e)
    {
      if ((e.Button & MouseButtons.Left) != MouseButtons.Left)
        return;
      int num = (int) this.T6_Picture_1.DoDragDrop((object) "F", DragDropEffects.Copy);
    }

    private void T7_Picture_1_MouseMove(object sender, MouseEventArgs e)
    {
      if ((e.Button & MouseButtons.Left) != MouseButtons.Left)
        return;
      int num = (int) this.T7_Picture_1.DoDragDrop((object) "G", DragDropEffects.Copy);
    }

    private void T8_Picture_1_MouseMove(object sender, MouseEventArgs e)
    {
      if ((e.Button & MouseButtons.Left) != MouseButtons.Left)
        return;
      int num = (int) this.T8_Picture_1.DoDragDrop((object) "H", DragDropEffects.Copy);
    }

    private void T9_Picture_1_MouseMove(object sender, MouseEventArgs e)
    {
      if ((e.Button & MouseButtons.Left) != MouseButtons.Left)
        return;
      int num = (int) this.T9_Picture_1.DoDragDrop((object) "I", DragDropEffects.Copy);
    }

    private void CornerButton1_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.CornerButton1.Checked)
        return;
      this.myDefs.Corner = "Left";
    }

    private void CornerButton2_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.CornerButton2.Checked)
        return;
      this.myDefs.Corner = "Center";
    }

    private void CornerButton3_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.CornerButton3.Checked)
        return;
      this.myDefs.Corner = "Right";
    }

    private void ThresholdText_TextChanged(object sender, EventArgs e)
    {
      if (!Information.IsNumeric((object) this.ThresholdText.Text))
        return;
      this.myDefs.Threshold = (float) IntegerType.FromString(this.ThresholdText.Text);
    }

    private void ThresholdText_Validating(object sender, CancelEventArgs e)
    {
      if (Information.IsNumeric((object) this.ThresholdText.Text) || StringType.StrCmp(this.ThresholdText.Text, "", false) == 0)
        return;
      e.Cancel = true;
    }

    private void LotMaxText_TextChanged(object sender, EventArgs e)
    {
      if (!Information.IsNumeric((object) this.LotMaxText.Text))
        return;
      this.myDefs.ElevMax = (float) IntegerType.FromString(this.LotMaxText.Text);
    }

    private void LotMaxText_Validating(object sender, CancelEventArgs e)
    {
      if (Information.IsNumeric((object) this.LotMaxText.Text) || StringType.StrCmp(this.LotMaxText.Text, "", false) == 0)
        return;
      e.Cancel = true;
    }

    private void LotMinText_TextChanged(object sender, EventArgs e)
    {
      if (!Information.IsNumeric((object) this.LotMinText.Text))
        return;
      this.myDefs.ElevMin = (float) IntegerType.FromString(this.LotMinText.Text);
    }

    private void LotMinText_Validating(object sender, CancelEventArgs e)
    {
      if (Information.IsNumeric((object) this.LotMinText.Text) || StringType.StrCmp(this.LotMinText.Text, "", false) == 0)
        return;
      e.Cancel = true;
    }

    private void RWButton1_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.RWButton1.Checked)
        return;
      this.myDefs.RetainingWall = "0XC96D2132";
    }

    private void RWButton2_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.RWButton2.Checked)
        return;
      this.myDefs.RetainingWall = "0XC96D2133";
    }

    private void RWButton3_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.RWButton3.Checked)
        return;
      this.myDefs.RetainingWall = "0XC96D2134";
    }

    private void RWButton4_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.RWButton4.Checked)
        return;
      this.myDefs.RetainingWall = "0XC96D2135";
    }

    private void RWButton5_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.RWButton5.Checked)
        return;
      this.myDefs.RetainingWall = "0XC96D2136";
    }

    private void RWButton6_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.RWButton6.Checked)
        return;
      this.myDefs.RetainingWall = "0XC96D2137";
    }

    private void GrowthText_TextChanged(object sender, EventArgs e)
    {
      if (!Information.IsNumeric((object) this.GrowthText.Text))
        return;
      this.myDefs.Growth = IntegerType.FromString(this.GrowthText.Text);
    }

    private void GrowthText_Validating(object sender, CancelEventArgs e)
    {
      if (!Information.IsNumeric((object) this.GrowthText.Text))
      {
        if (StringType.StrCmp(this.GrowthText.Text, "", false) == 0)
          return;
        e.Cancel = true;
      }
      else
      {
        if (IntegerType.FromString(this.GrowthText.Text) > (int) byte.MaxValue)
          e.Cancel = true;
        if (IntegerType.FromString(this.GrowthText.Text) < 0)
          e.Cancel = true;
      }
    }

    private void FoundationText_TextChanged(object sender, EventArgs e) => this.myDefs.Foundation = this.FoundationText.Text;

    private void FoundationText_Validating(object sender, CancelEventArgs e)
    {
    }

    private void FoundationText_Validated(object sender, EventArgs e)
    {
    }

    private void ButtonSave_Activate(object sender, EventArgs e) => this.SaveFiles();

    private void ButtonDeleteTile_Activate(object sender, EventArgs e) => this.RemoveTraffic();

    private void ButtonMinus_Activate(object sender, EventArgs e)
    {
      switch (this.Graphicgrid1.CellSize)
      {
        case 16:
          return;
        case 32:
          this.Graphicgrid1.CellSize = 16;
          break;
        case 64:
          this.Graphicgrid1.CellSize = 32;
          break;
        case 96:
          this.Graphicgrid1.CellSize = 64;
          break;
        case 128:
          this.Graphicgrid1.CellSize = 96;
          break;
      }
      graphicgrid graphicgrid1_1 = this.Graphicgrid1;
      int cellSize1 = this.Graphicgrid1.CellSize;
      Size cells = this.Graphicgrid1.Cells;
      int width = cells.Width;
      int num1 = checked (cellSize1 * width);
      graphicgrid1_1.Width = num1;
      graphicgrid graphicgrid1_2 = this.Graphicgrid1;
      int cellSize2 = this.Graphicgrid1.CellSize;
      cells = this.Graphicgrid1.Cells;
      int height = cells.Height;
      int num2 = checked (cellSize2 * height);
      graphicgrid1_2.Height = num2;
      this.RefreshOutput();
    }

    private void ButtonPlus_Activate(object sender, EventArgs e)
    {
      switch (this.Graphicgrid1.CellSize)
      {
        case 16:
          this.Graphicgrid1.CellSize = 32;
          break;
        case 32:
          this.Graphicgrid1.CellSize = 64;
          break;
        case 64:
          this.Graphicgrid1.CellSize = 96;
          break;
        case 96:
          this.Graphicgrid1.CellSize = 128;
          break;
        case 128:
          return;
      }
      this.Graphicgrid1.Width = checked (this.Graphicgrid1.CellSize * this.Graphicgrid1.Cells.Width);
      this.Graphicgrid1.Height = checked (this.Graphicgrid1.CellSize * this.Graphicgrid1.Cells.Height);
      this.RefreshOutput();
    }

    private void ButtonOpen_Activate(object sender, EventArgs e)
    {
      this.CheckIfMustSave();
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.RestoreDirectory = true;
      openFileDialog.Title = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[16]);
      openFileDialog.ShowReadOnly = true;
      openFileDialog.Filter = "SC4-Files (*.dat;*.sc4Lot|*.dat;*.sc4Lot|All (*.*)|*.*";
      if (openFileDialog.ShowDialog() != DialogResult.OK)
        return;
      this.StatusBarPanel2.Text = openFileDialog.FileName;
      this.LeseDatei = openFileDialog.FileName;
      this.StartRead();
    }

    private void ButtonLeave_Activate(object sender, EventArgs e)
    {
      this.CheckIfMustSave();
      this.Dispose();
    }

    private void FormLotEditor_Closed(object sender, EventArgs e)
    {
      this.CheckIfMustSave();
      ClassThisProg.frmLotEditor = (FormLotEditor) null;
    }

    private void mnuItemAdd_Click(object sender, EventArgs e) => this.AddTraffic(this.AktuellerGridPoint, StringType.FromObject(this.ActiveTrafficArt));

    private void mnuItemRemove_Click(object sender, EventArgs e) => this.RemoveTraffic();

    private void mnuItemChangeDirection_Click(object sender, EventArgs e) => this.RotateTransit();

    private void Panel1_Resize(object sender, EventArgs e) => this.StatusBarPanel1.Width = checked ((int) Math.Round(unchecked ((double) this.Panel1.Width + (double) this.Splitter1.Width / 2.0)));

    private void Graphicgrid1_gridMouseDown(object sender, MouseEventArgs e, Point GridPoint)
    {
      if (e.Button == MouseButtons.Left)
        this.SetActiveCell((object) GridPoint);
      else if (e.Button == MouseButtons.Right)
      {
        this.Graphicgrid1.SelectedCells.Clear();
        this.SetActiveCell((object) GridPoint);
      }
    }

    private void TransitSwitchGrid_EditSwitchButtonClick(object sender, PositionEventArgs e)
    {
      if (!Information.IsNumeric(RuntimeHelpers.GetObjectValue(this.TransitSwitchGrid[e.Position.Row, 6].Value)))
        return;
      int index = IntegerType.FromObject(this.TransitSwitchGrid[e.Position.Row, 6].Value);
      string EingabeString = this.AktuellesLot.TransitSettings.TransitSwitchPoint[index];
      if (ClassThisProg.frmTransitSwitch == null)
      {
        FormTransitSwitch formTransitSwitch = new FormTransitSwitch(EingabeString);
        if (formTransitSwitch.ShowDialog((IWin32Window) this) == DialogResult.OK)
        {
          string text = formTransitSwitch.TextBox1.Text;
          this.AktuellesLot.TransitSettings.TransitSwitchPoint[index] = text;
        }
        formTransitSwitch.Dispose();
        this.GebeBuildingAus();
      }
    }

    private void TransitSwitchGrid_EditButtonClick(object sender, PositionEventArgs e)
    {
      string Wert1 = "0";
      string Wert2 = "0";
      Lot.ExemplarTransitSettings transitSettings = this.AktuellesLot.TransitSettings;
      if (!Information.IsNothing((object) transitSettings.TransitEntryCost))
        Wert1 = transitSettings.TransitEntryCost.ToString();
      if (!Information.IsNothing((object) transitSettings.TransitEntryCost))
        Wert2 = transitSettings.TransitCapacity.ToString();
      if (ClassThisProg.frmMaskedInput != null)
        return;
      FormMaskedInput formMaskedInput = new FormMaskedInput(Wert1, Wert2);
      if (formMaskedInput.ShowDialog((IWin32Window) this) == DialogResult.OK)
      {
        transitSettings.TransitEntryCost = DoubleType.FromString(formMaskedInput.TextBox1.Text);
        transitSettings.TransitCapacity = DoubleType.FromString(formMaskedInput.TextBox2.Text);
        this.AktuellesLot.TransitSettings = transitSettings;
      }
      formMaskedInput.Dispose();
      this.GebeBuildingAus();
    }

    private void TransitSwitchGrid_DelButtonClick(object sender, PositionEventArgs e)
    {
      if (MessageBox.Show((IWin32Window) this, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[131]), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[132]), MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
      Lot.ExemplarTransitSettings exemplarTransitSettings;
      exemplarTransitSettings.TransitSwitchPoint = new string[0];
      Lot.ExemplarTransitSettings transitSettings;
      if (!Information.IsNothing((object) this.AktuellesLot.TransitSettings.TransitEntryCost))
      {
        ref Lot.ExemplarTransitSettings local = ref exemplarTransitSettings;
        transitSettings = this.AktuellesLot.TransitSettings;
        double transitEntryCost = transitSettings.TransitEntryCost;
        local.TransitEntryCost = transitEntryCost;
      }
      transitSettings = this.AktuellesLot.TransitSettings;
      if (!Information.IsNothing((object) transitSettings.TransitCapacity))
        exemplarTransitSettings.TransitCapacity = this.AktuellesLot.TransitSettings.TransitCapacity;
      if (Information.IsNumeric(RuntimeHelpers.GetObjectValue(this.TransitSwitchGrid[e.Position.Row, 6].Value)))
      {
        int num1 = IntegerType.FromObject(this.TransitSwitchGrid[e.Position.Row, 6].Value);
        transitSettings = this.AktuellesLot.TransitSettings;
        int upperBound = transitSettings.TransitSwitchPoint.GetUpperBound(0);
        int index1 = 0;
        while (index1 <= upperBound)
        {
          if (index1 != num1)
          {
            int num2 = checked (exemplarTransitSettings.TransitSwitchPoint.GetUpperBound(0) + 1);
            exemplarTransitSettings.TransitSwitchPoint = (string[]) Utils.CopyArray((Array) exemplarTransitSettings.TransitSwitchPoint, (Array) new string[checked (num2 + 1)]);
            string[] transitSwitchPoint = exemplarTransitSettings.TransitSwitchPoint;
            int index2 = num2;
            transitSettings = this.AktuellesLot.TransitSettings;
            string str = transitSettings.TransitSwitchPoint[index1];
            transitSwitchPoint[index2] = str;
          }
          checked { ++index1; }
        }
        this.hasNotSavedChanges = true;
        this.AktuellesLot.TransitSettings = exemplarTransitSettings;
        this.GebeBuildingAus();
      }
    }

    private void TransitSwitchButton1_Activate_1(object sender, EventArgs e)
    {
      Lot.ExemplarTransitSettings exemplarTransitSettings;
      exemplarTransitSettings.TransitSwitchPoint = new string[0];
      if (ClassThisProg.frmTransitSwitch != null)
        return;
      string EingabeString = "0X00000081,0X00000050,0x00000000,0x00000000";
      if (this.AktuellesLot.Breite > this.AktuellesLot.Hoehe)
        EingabeString = "0X00000081,0X000000A0,0x00000000,0x00000000";
      FormTransitSwitch formTransitSwitch = new FormTransitSwitch(EingabeString);
      if (formTransitSwitch.ShowDialog((IWin32Window) this) == DialogResult.OK)
      {
        string text = formTransitSwitch.TextBox1.Text;
        if (this.AktuellesLot.TransitSettings.TransitSwitchPoint.GetUpperBound(0) > -1)
        {
          int upperBound = this.AktuellesLot.TransitSettings.TransitSwitchPoint.GetUpperBound(0);
          int index1 = 0;
          while (index1 <= upperBound)
          {
            int index2 = checked (exemplarTransitSettings.TransitSwitchPoint.GetUpperBound(0) + 1);
            exemplarTransitSettings.TransitSwitchPoint = (string[]) Utils.CopyArray((Array) exemplarTransitSettings.TransitSwitchPoint, (Array) new string[checked (index2 + 1)]);
            exemplarTransitSettings.TransitSwitchPoint[index2] = this.AktuellesLot.TransitSettings.TransitSwitchPoint[index1];
            checked { ++index1; }
          }
        }
        Lot.ExemplarTransitSettings transitSettings;
        if (Information.IsNothing((object) this.AktuellesLot.TransitSettings.TransitCapacity))
        {
          exemplarTransitSettings.TransitCapacity = 1000.0;
        }
        else
        {
          transitSettings = this.AktuellesLot.TransitSettings;
          if (transitSettings.TransitCapacity == 0.0)
            exemplarTransitSettings.TransitCapacity = 1000.0;
        }
        transitSettings = this.AktuellesLot.TransitSettings;
        if (Information.IsNothing((object) transitSettings.TransitCapacity))
        {
          exemplarTransitSettings.TransitEntryCost = 1.0;
        }
        else
        {
          transitSettings = this.AktuellesLot.TransitSettings;
          if (transitSettings.TransitEntryCost == 0.0)
            exemplarTransitSettings.TransitEntryCost = 1.0;
        }
        int index = checked (exemplarTransitSettings.TransitSwitchPoint.GetUpperBound(0) + 1);
        exemplarTransitSettings.TransitSwitchPoint = (string[]) Utils.CopyArray((Array) exemplarTransitSettings.TransitSwitchPoint, (Array) new string[checked (index + 1)]);
        exemplarTransitSettings.TransitSwitchPoint[index] = text;
        this.AktuellesLot.TransitSettings = exemplarTransitSettings;
        this.hasNotSavedChanges = true;
        this.GebeBuildingAus();
      }
      formTransitSwitch.Dispose();
    }

    private void mnuItemEditTransit_Click(object sender, EventArgs e)
    {
      if (this.ExpertModus)
      {
        if (ClassThisProg.frmEditTransit != null)
          return;
        FormEditTransit formEditTransit = new FormEditTransit(this.AktuellesLot, this.AktuellesLot.Tiles[this.AktuellerTileIndex], this.AktuellerTileIndex);
        if (formEditTransit.ShowDialog((IWin32Window) this) == DialogResult.OK)
        {
          this.hasNotSavedChanges = true;
          this.AktuellesLot.Tiles[this.AktuellerTileIndex] = formEditTransit.AktuellesTile;
          this.SetActiveCell((object) this.AktuellerGridPoint);
          this.ZeichneTile(this.AktuellerTileIndex);
          this.FillWerteGitter();
        }
        formEditTransit.Dispose();
      }
      else if (ClassThisProg.frmTransitDirection == null)
      {
        FormTransitDirection transitDirection = new FormTransitDirection(this.AktuellesLot, this.AktuellesLot.Tiles[this.AktuellerTileIndex], this.AktuellerTileIndex);
        if (transitDirection.ShowDialog((IWin32Window) this) == DialogResult.OK)
        {
          this.hasNotSavedChanges = true;
          this.AktuellesLot.Tiles[this.AktuellerTileIndex] = transitDirection.AktuellesTile;
          this.SetActiveCell((object) this.AktuellerGridPoint);
          this.ZeichneTile(this.AktuellerTileIndex);
          this.FillWerteGitter();
        }
        transitDirection.Dispose();
      }
    }

    private void MenuDisplayItem1_Activate(object sender, EventArgs e)
    {
      if (!this.MenuDisplayItem1.Checked)
      {
        this.MenuDisplayItem1.Checked = true;
        this.MenuDisplayItem2.Checked = false;
      }
      this.ShowTransitString = true;
      this.RefreshOutput();
    }

    private void MenuDisplayItem2_Activate(object sender, EventArgs e)
    {
      if (!this.MenuDisplayItem2.Checked)
      {
        this.MenuDisplayItem2.Checked = true;
        this.MenuDisplayItem1.Checked = false;
      }
      this.ShowTransitString = false;
      this.RefreshOutput();
    }

    private void ModusMenuItem1_Activate(object sender, EventArgs e)
    {
      if (this.ModusMenuItem1.Checked)
        return;
      this.ModusMenuItem1.Checked = true;
      this.ModusMenuItem2.Checked = false;
      this.SwitchToStandard();
    }

    private void ModusMenuItem2_Activate(object sender, EventArgs e)
    {
      if (this.ModusMenuItem2.Checked)
        return;
      this.ModusMenuItem2.Checked = true;
      this.ModusMenuItem1.Checked = false;
      this.SwitchToExpert();
    }

    private void ButtonShowReps_Activate(object sender, EventArgs e)
    {
      if (this.RepGrid.Visible)
      {
        this.RepGrid.Visible = false;
        this.TextureGrid.Visible = true;
      }
      else
      {
        this.RepGrid.Visible = true;
        this.TextureGrid.Visible = false;
      }
      if (this.RepGrid.Visible)
        this.ButtonShowReps.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[468]);
      else
        this.ButtonShowReps.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[467]);
    }
  }
}
