// Decompiled with JetBrains decompiler
// Type: SC4Tool.Form8
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
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using TD.SandBar;

namespace SC4Tool
{
  public class Form8 : Form
  {
    [AccessedThroughProperty("StatusBar1")]
    private StatusBar _StatusBar1;
    [AccessedThroughProperty("ProgressBar1")]
    private ProgressBar _ProgressBar1;
    [AccessedThroughProperty("SearchButton")]
    private ButtonItem _SearchButton;
    [AccessedThroughProperty("AusgabeMenuItem2")]
    private MenuButtonItem _AusgabeMenuItem2;
    [AccessedThroughProperty("AusgabeMenuItem1")]
    private MenuButtonItem _AusgabeMenuItem1;
    [AccessedThroughProperty("StatusBarPanel2")]
    private StatusBarPanel _StatusBarPanel2;
    [AccessedThroughProperty("AusgabeMenu")]
    private DropDownMenuItem _AusgabeMenu;
    [AccessedThroughProperty("ButtonClearSelection")]
    private ButtonItem _ButtonClearSelection;
    [AccessedThroughProperty("DisplayMenuItem6")]
    private MenuButtonItem _DisplayMenuItem6;
    [AccessedThroughProperty("DisplayMenuItem5")]
    private MenuButtonItem _DisplayMenuItem5;
    [AccessedThroughProperty("DisplayMenuItem4")]
    private MenuButtonItem _DisplayMenuItem4;
    [AccessedThroughProperty("AusgabeGrid")]
    private C1.Win.C1FlexGrid.C1FlexGrid _AusgabeGrid;
    [AccessedThroughProperty("DisplayMenuItem3")]
    private MenuButtonItem _DisplayMenuItem3;
    [AccessedThroughProperty("Sr_TextureViewer1")]
    private sr_TextureViewer _Sr_TextureViewer1;
    [AccessedThroughProperty("Panel1")]
    private Panel _Panel1;
    [AccessedThroughProperty("DisplayMenuItem2")]
    private MenuButtonItem _DisplayMenuItem2;
    [AccessedThroughProperty("Splitter1")]
    private Splitter _Splitter1;
    [AccessedThroughProperty("ImagesToolBar")]
    private TD.SandBar.ToolBar _ImagesToolBar;
    [AccessedThroughProperty("ImageToolButton2")]
    private ButtonItem _ImageToolButton2;
    [AccessedThroughProperty("DisplayMenuItem1")]
    private MenuButtonItem _DisplayMenuItem1;
    [AccessedThroughProperty("ImageDropDownMenu1")]
    private DropDownMenuItem _ImageDropDownMenu1;
    [AccessedThroughProperty("ImageMenuItem1")]
    private MenuButtonItem _ImageMenuItem1;
    [AccessedThroughProperty("ImageMenuItem2")]
    private MenuButtonItem _ImageMenuItem2;
    [AccessedThroughProperty("DisplayMenu")]
    private DropDownMenuItem _DisplayMenu;
    [AccessedThroughProperty("ImageMenuItem3")]
    private MenuButtonItem _ImageMenuItem3;
    [AccessedThroughProperty("ImageMenuItem4")]
    private MenuButtonItem _ImageMenuItem4;
    [AccessedThroughProperty("ImageMenuItem5")]
    private MenuButtonItem _ImageMenuItem5;
    [AccessedThroughProperty("ImageMenuItem6")]
    private MenuButtonItem _ImageMenuItem6;
    [AccessedThroughProperty("ToolBar1")]
    private TD.SandBar.ToolBar _ToolBar1;
    [AccessedThroughProperty("TreeView1")]
    private TreeView _TreeView1;
    [AccessedThroughProperty("DropDownMenuItem1")]
    private DropDownMenuItem _DropDownMenuItem1;
    [AccessedThroughProperty("MenuSortItem2")]
    private MenuButtonItem _MenuSortItem2;
    [AccessedThroughProperty("MenuButtonItem1")]
    private MenuButtonItem _MenuButtonItem1;
    [AccessedThroughProperty("StatusBarPanel1")]
    private StatusBarPanel _StatusBarPanel1;
    [AccessedThroughProperty("MenuSortItem1")]
    private MenuButtonItem _MenuSortItem1;
    [AccessedThroughProperty("MenuButtonItem2")]
    private MenuButtonItem _MenuButtonItem2;
    [AccessedThroughProperty("SortMenu")]
    private DropDownMenuItem _SortMenu;
    [AccessedThroughProperty("MenuButtonItem5")]
    private MenuButtonItem _MenuButtonItem5;
    [AccessedThroughProperty("MenuButtonItemAll")]
    private MenuButtonItem _MenuButtonItemAll;
    [AccessedThroughProperty("MenuButtonCommon")]
    private MenuButtonItem _MenuButtonCommon;
    [AccessedThroughProperty("ButtonItem1")]
    private ButtonItem _ButtonItem1;
    [AccessedThroughProperty("MenuButtonItemPersonal")]
    private MenuButtonItem _MenuButtonItemPersonal;
    [AccessedThroughProperty("Panel2")]
    private Panel _Panel2;
    private string MainSortString;
    private string SelectString;
    private int DisplaySize;
    private string AusgabeModus;
    private int MainNodeCount;
    private string SearchID;
    private bool isLoading;
    private ArrayList SearchFileArray;
    internal StatusBarChild sbcProgressBar;
    private ArrayList SizeArray;
    private cTexture ResultTexturen;
    private cTexture[] MainSelectListe;
    private IContainer components;

    public Form8()
    {
      this.Load += new EventHandler(this.Form8_Load);
      this.Resize += new EventHandler(this.Form8_Resize);
      this.Closed += new EventHandler(this.Form8_Closed);
      this.MainSortString = "FileName";
      this.DisplaySize = 32;
      this.SearchFileArray = new ArrayList();
      this.SizeArray = new ArrayList();
      this.ResultTexturen = new cTexture();
      this.InitializeComponent();
      if (!ClassThisProg.DefReader.HasReadTextures && ClassThisProg.frmProgress == null)
      {
        ClassThisProg.frmProgress = new FormProgress("T");
        ClassThisProg.frmProgress.MdiParent = (Form) ClassThisProg.frmMain;
        int num = (int) ClassThisProg.frmProgress.ShowDialog();
      }
      this.FormatAusgabeGrid();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
      ClassThisProg.frmForm8 = (Form8) null;
    }

    internal virtual Panel Panel1
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Panel1 != null)
          this._Panel1.Resize -= new EventHandler(this.Panel1_Resize);
        this._Panel1 = value;
        if (this._Panel1 == null)
          return;
        this._Panel1.Resize += new EventHandler(this.Panel1_Resize);
      }
      get => this._Panel1;
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
        if (this._ImageDropDownMenu1 != null)
          this._ImageDropDownMenu1.BeforePopup -= new MenuItemBase.BeforePopupEventHandler(this.ImageDropDownMenu1_BeforePopup);
        this._ImageDropDownMenu1 = value;
        if (this._ImageDropDownMenu1 == null)
          return;
        this._ImageDropDownMenu1.BeforePopup += new MenuItemBase.BeforePopupEventHandler(this.ImageDropDownMenu1_BeforePopup);
      }
    }

    internal virtual MenuButtonItem ImageMenuItem1
    {
      get => this._ImageMenuItem1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ImageMenuItem1 != null)
          this._ImageMenuItem1.Activate -= new EventHandler(this.ImageMenuItem1_Activate);
        this._ImageMenuItem1 = value;
        if (this._ImageMenuItem1 == null)
          return;
        this._ImageMenuItem1.Activate += new EventHandler(this.ImageMenuItem1_Activate);
      }
    }

    internal virtual MenuButtonItem ImageMenuItem2
    {
      get => this._ImageMenuItem2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ImageMenuItem2 != null)
          this._ImageMenuItem2.Activate -= new EventHandler(this.ImageMenuItem2_Activate);
        this._ImageMenuItem2 = value;
        if (this._ImageMenuItem2 == null)
          return;
        this._ImageMenuItem2.Activate += new EventHandler(this.ImageMenuItem2_Activate);
      }
    }

    internal virtual MenuButtonItem ImageMenuItem3
    {
      get => this._ImageMenuItem3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ImageMenuItem3 != null)
          this._ImageMenuItem3.Activate -= new EventHandler(this.ImageMenuItem3_Activate);
        this._ImageMenuItem3 = value;
        if (this._ImageMenuItem3 == null)
          return;
        this._ImageMenuItem3.Activate += new EventHandler(this.ImageMenuItem3_Activate);
      }
    }

    internal virtual MenuButtonItem ImageMenuItem4
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ImageMenuItem4 != null)
          this._ImageMenuItem4.Activate -= new EventHandler(this.ImageMenuItem4_Activate);
        this._ImageMenuItem4 = value;
        if (this._ImageMenuItem4 == null)
          return;
        this._ImageMenuItem4.Activate += new EventHandler(this.ImageMenuItem4_Activate);
      }
      get => this._ImageMenuItem4;
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

    internal virtual TreeView TreeView1
    {
      get => this._TreeView1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._TreeView1 != null)
        {
          this._TreeView1.AfterSelect -= new TreeViewEventHandler(this.TreeView1_AfterSelect);
          this._TreeView1.BeforeExpand -= new TreeViewCancelEventHandler(this.TreeView1_BeforeExpand);
          this._TreeView1.BeforeSelect -= new TreeViewCancelEventHandler(this.TreeView1_BeforeSelect);
        }
        this._TreeView1 = value;
        if (this._TreeView1 == null)
          return;
        this._TreeView1.AfterSelect += new TreeViewEventHandler(this.TreeView1_AfterSelect);
        this._TreeView1.BeforeExpand += new TreeViewCancelEventHandler(this.TreeView1_BeforeExpand);
        this._TreeView1.BeforeSelect += new TreeViewCancelEventHandler(this.TreeView1_BeforeSelect);
      }
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
      get => this._MenuButtonItem1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuButtonItem1 == null)
          ;
        this._MenuButtonItem1 = value;
        if (this._MenuButtonItem1 == null)
          ;
      }
    }

    internal virtual MenuButtonItem MenuButtonItem2
    {
      get => this._MenuButtonItem2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuButtonItem2 != null)
          this._MenuButtonItem2.Activate -= new EventHandler(this.MenuButtonItem2_Activate);
        this._MenuButtonItem2 = value;
        if (this._MenuButtonItem2 == null)
          return;
        this._MenuButtonItem2.Activate += new EventHandler(this.MenuButtonItem2_Activate);
      }
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

    internal virtual DropDownMenuItem SortMenu
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._SortMenu == null)
          ;
        this._SortMenu = value;
        if (this._SortMenu == null)
          ;
      }
      get => this._SortMenu;
    }

    internal virtual MenuButtonItem MenuSortItem1
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuSortItem1 != null)
          this._MenuSortItem1.Activate -= new EventHandler(this.MenuSortItem1_Activate);
        this._MenuSortItem1 = value;
        if (this._MenuSortItem1 == null)
          return;
        this._MenuSortItem1.Activate += new EventHandler(this.MenuSortItem1_Activate);
      }
      get => this._MenuSortItem1;
    }

    internal virtual MenuButtonItem MenuSortItem2
    {
      get => this._MenuSortItem2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuSortItem2 != null)
          this._MenuSortItem2.Activate -= new EventHandler(this.MenuSortItem2_Activate);
        this._MenuSortItem2 = value;
        if (this._MenuSortItem2 == null)
          return;
        this._MenuSortItem2.Activate += new EventHandler(this.MenuSortItem2_Activate);
      }
    }

    internal virtual DropDownMenuItem DisplayMenu
    {
      get => this._DisplayMenu;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._DisplayMenu == null)
          ;
        this._DisplayMenu = value;
        if (this._DisplayMenu == null)
          ;
      }
    }

    internal virtual MenuButtonItem DisplayMenuItem1
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._DisplayMenuItem1 != null)
          this._DisplayMenuItem1.Activate -= new EventHandler(this.DisplayMenuItem1_Activate);
        this._DisplayMenuItem1 = value;
        if (this._DisplayMenuItem1 == null)
          return;
        this._DisplayMenuItem1.Activate += new EventHandler(this.DisplayMenuItem1_Activate);
      }
      get => this._DisplayMenuItem1;
    }

    internal virtual MenuButtonItem DisplayMenuItem2
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._DisplayMenuItem2 != null)
          this._DisplayMenuItem2.Activate -= new EventHandler(this.DisplayMenuItem2_Activate);
        this._DisplayMenuItem2 = value;
        if (this._DisplayMenuItem2 == null)
          return;
        this._DisplayMenuItem2.Activate += new EventHandler(this.DisplayMenuItem2_Activate);
      }
      get => this._DisplayMenuItem2;
    }

    internal virtual MenuButtonItem DisplayMenuItem3
    {
      get => this._DisplayMenuItem3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._DisplayMenuItem3 != null)
          this._DisplayMenuItem3.Activate -= new EventHandler(this.DisplayMenuItem3_Activate);
        this._DisplayMenuItem3 = value;
        if (this._DisplayMenuItem3 == null)
          return;
        this._DisplayMenuItem3.Activate += new EventHandler(this.DisplayMenuItem3_Activate);
      }
    }

    internal virtual MenuButtonItem DisplayMenuItem4
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._DisplayMenuItem4 != null)
          this._DisplayMenuItem4.Activate -= new EventHandler(this.DisplayMenuItem4_Activate);
        this._DisplayMenuItem4 = value;
        if (this._DisplayMenuItem4 == null)
          return;
        this._DisplayMenuItem4.Activate += new EventHandler(this.DisplayMenuItem4_Activate);
      }
      get => this._DisplayMenuItem4;
    }

    internal virtual MenuButtonItem DisplayMenuItem5
    {
      get => this._DisplayMenuItem5;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._DisplayMenuItem5 != null)
          this._DisplayMenuItem5.Activate -= new EventHandler(this.DisplayMenuItem5_Activate);
        this._DisplayMenuItem5 = value;
        if (this._DisplayMenuItem5 == null)
          return;
        this._DisplayMenuItem5.Activate += new EventHandler(this.DisplayMenuItem5_Activate);
      }
    }

    internal virtual MenuButtonItem DisplayMenuItem6
    {
      get => this._DisplayMenuItem6;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._DisplayMenuItem6 != null)
          this._DisplayMenuItem6.Activate -= new EventHandler(this.DisplayMenuItem6_Activate);
        this._DisplayMenuItem6 = value;
        if (this._DisplayMenuItem6 == null)
          return;
        this._DisplayMenuItem6.Activate += new EventHandler(this.DisplayMenuItem6_Activate);
      }
    }

    internal virtual DropDownMenuItem AusgabeMenu
    {
      get => this._AusgabeMenu;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._AusgabeMenu == null)
          ;
        this._AusgabeMenu = value;
        if (this._AusgabeMenu == null)
          ;
      }
    }

    internal virtual MenuButtonItem AusgabeMenuItem1
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._AusgabeMenuItem1 != null)
          this._AusgabeMenuItem1.Activate -= new EventHandler(this.AusgabeMenuItem1_Activate);
        this._AusgabeMenuItem1 = value;
        if (this._AusgabeMenuItem1 == null)
          return;
        this._AusgabeMenuItem1.Activate += new EventHandler(this.AusgabeMenuItem1_Activate);
      }
      get => this._AusgabeMenuItem1;
    }

    internal virtual MenuButtonItem AusgabeMenuItem2
    {
      get => this._AusgabeMenuItem2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._AusgabeMenuItem2 != null)
          this._AusgabeMenuItem2.Activate -= new EventHandler(this.AusgabeMenuItem2_Activate);
        this._AusgabeMenuItem2 = value;
        if (this._AusgabeMenuItem2 == null)
          return;
        this._AusgabeMenuItem2.Activate += new EventHandler(this.AusgabeMenuItem2_Activate);
      }
    }

    internal virtual ButtonItem SearchButton
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._SearchButton != null)
          this._SearchButton.Activate -= new EventHandler(this.SearchButton_Activate);
        this._SearchButton = value;
        if (this._SearchButton == null)
          return;
        this._SearchButton.Activate += new EventHandler(this.SearchButton_Activate);
      }
      get => this._SearchButton;
    }

    internal virtual ProgressBar ProgressBar1
    {
      get => this._ProgressBar1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ProgressBar1 == null)
          ;
        this._ProgressBar1 = value;
        if (this._ProgressBar1 == null)
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

    internal virtual C1.Win.C1FlexGrid.C1FlexGrid AusgabeGrid
    {
      get => this._AusgabeGrid;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._AusgabeGrid == null)
          ;
        this._AusgabeGrid = value;
        if (this._AusgabeGrid == null)
          ;
      }
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
      this.SearchButton = new ButtonItem();
      this.ButtonClearSelection = new ButtonItem();
      this.Splitter1 = new Splitter();
      this.ImagesToolBar = new TD.SandBar.ToolBar();
      this.SortMenu = new DropDownMenuItem();
      this.MenuSortItem1 = new MenuButtonItem();
      this.MenuSortItem2 = new MenuButtonItem();
      this.DisplayMenu = new DropDownMenuItem();
      this.DisplayMenuItem1 = new MenuButtonItem();
      this.DisplayMenuItem2 = new MenuButtonItem();
      this.DisplayMenuItem3 = new MenuButtonItem();
      this.DisplayMenuItem4 = new MenuButtonItem();
      this.DisplayMenuItem5 = new MenuButtonItem();
      this.DisplayMenuItem6 = new MenuButtonItem();
      this.AusgabeMenu = new DropDownMenuItem();
      this.AusgabeMenuItem1 = new MenuButtonItem();
      this.AusgabeMenuItem2 = new MenuButtonItem();
      this.ImageToolButton2 = new ButtonItem();
      this.ImageDropDownMenu1 = new DropDownMenuItem();
      this.ImageMenuItem1 = new MenuButtonItem();
      this.ImageMenuItem2 = new MenuButtonItem();
      this.ImageMenuItem3 = new MenuButtonItem();
      this.ImageMenuItem4 = new MenuButtonItem();
      this.ImageMenuItem5 = new MenuButtonItem();
      this.ImageMenuItem6 = new MenuButtonItem();
      this.Panel2 = new Panel();
      this.AusgabeGrid = new C1.Win.C1FlexGrid.C1FlexGrid();
      this.ProgressBar1 = new ProgressBar();
      this.StatusBar1 = new StatusBar();
      this.StatusBarPanel1 = new StatusBarPanel();
      this.StatusBarPanel2 = new StatusBarPanel();
      this.Sr_TextureViewer1 = new sr_TextureViewer();
      this.Panel1.SuspendLayout();
      this.Panel2.SuspendLayout();
      this.AusgabeGrid.BeginInit();
      this.StatusBarPanel1.BeginInit();
      this.StatusBarPanel2.BeginInit();
      this.SuspendLayout();
      this.Panel1.Controls.Add((Control) this.TreeView1);
      this.Panel1.Controls.Add((Control) this.ToolBar1);
      this.Panel1.Dock = DockStyle.Left;
      Panel panel1_1 = this.Panel1;
      Point point1 = new Point(0, 0);
      Point point2 = point1;
      panel1_1.Location = point2;
      this.Panel1.Name = "Panel1";
      Panel panel1_2 = this.Panel1;
      Size size1 = new Size(270, 538);
      Size size2 = size1;
      panel1_2.Size = size2;
      this.Panel1.TabIndex = 0;
      this.TreeView1.Dock = DockStyle.Fill;
      this.TreeView1.ImageIndex = -1;
      TreeView treeView1_1 = this.TreeView1;
      point1 = new Point(0, 23);
      Point point3 = point1;
      treeView1_1.Location = point3;
      this.TreeView1.Name = "TreeView1";
      this.TreeView1.SelectedImageIndex = -1;
      TreeView treeView1_2 = this.TreeView1;
      size1 = new Size(270, 515);
      Size size3 = size1;
      treeView1_2.Size = size3;
      this.TreeView1.TabIndex = 2;
      TD.SandBar.ToolBar toolBar1_1 = this.ToolBar1;
      Guid guid1 = new Guid("3c4727f4-b78a-4f5a-a9e2-7598838d812c");
      Guid guid2 = guid1;
      toolBar1_1.Guid = guid2;
      this.ToolBar1.Items.AddRange(new ToolbarItemBase[4]
      {
        (ToolbarItemBase) this.ButtonItem1,
        (ToolbarItemBase) this.DropDownMenuItem1,
        (ToolbarItemBase) this.SearchButton,
        (ToolbarItemBase) this.ButtonClearSelection
      });
      TD.SandBar.ToolBar toolBar1_2 = this.ToolBar1;
      point1 = new Point(0, 0);
      Point point4 = point1;
      toolBar1_2.Location = point4;
      this.ToolBar1.Name = "ToolBar1";
      TD.SandBar.ToolBar toolBar1_3 = this.ToolBar1;
      size1 = new Size(270, 23);
      Size size4 = size1;
      toolBar1_3.Size = size4;
      this.ToolBar1.TabIndex = 1;
      this.ToolBar1.Text = "ToolBar1";
      this.ButtonItem1.BeginGroup = true;
      this.DropDownMenuItem1.BeginGroup = true;
      this.DropDownMenuItem1.Items.AddRange(new ToolbarItemBase[3]
      {
        (ToolbarItemBase) this.MenuButtonItem1,
        (ToolbarItemBase) this.MenuButtonItem2,
        (ToolbarItemBase) this.MenuButtonItem5
      });
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
      this.SearchButton.BeginGroup = true;
      this.ButtonClearSelection.BeginGroup = true;
      Splitter splitter1_1 = this.Splitter1;
      point1 = new Point(270, 0);
      Point point5 = point1;
      splitter1_1.Location = point5;
      this.Splitter1.Name = "Splitter1";
      Splitter splitter1_2 = this.Splitter1;
      size1 = new Size(8, 538);
      Size size5 = size1;
      splitter1_2.Size = size5;
      this.Splitter1.TabIndex = 1;
      this.Splitter1.TabStop = false;
      TD.SandBar.ToolBar imagesToolBar1 = this.ImagesToolBar;
      guid1 = new Guid("b312afcb-11b1-4d09-bf41-47bfc09e055b");
      Guid guid3 = guid1;
      imagesToolBar1.Guid = guid3;
      this.ImagesToolBar.Items.AddRange(new ToolbarItemBase[5]
      {
        (ToolbarItemBase) this.SortMenu,
        (ToolbarItemBase) this.DisplayMenu,
        (ToolbarItemBase) this.AusgabeMenu,
        (ToolbarItemBase) this.ImageToolButton2,
        (ToolbarItemBase) this.ImageDropDownMenu1
      });
      TD.SandBar.ToolBar imagesToolBar2 = this.ImagesToolBar;
      point1 = new Point(278, 0);
      Point point6 = point1;
      imagesToolBar2.Location = point6;
      this.ImagesToolBar.Name = "ImagesToolBar";
      TD.SandBar.ToolBar imagesToolBar3 = this.ImagesToolBar;
      size1 = new Size(504, 23);
      Size size6 = size1;
      imagesToolBar3.Size = size6;
      this.ImagesToolBar.TabIndex = 2;
      this.ImagesToolBar.Text = "ToolBar2";
      this.SortMenu.BeginGroup = true;
      this.SortMenu.Items.AddRange(new ToolbarItemBase[2]
      {
        (ToolbarItemBase) this.MenuSortItem1,
        (ToolbarItemBase) this.MenuSortItem2
      });
      this.SortMenu.Visible = false;
      this.MenuSortItem1.BeginGroup = true;
      this.MenuSortItem1.Checked = true;
      this.MenuSortItem2.BeginGroup = true;
      this.DisplayMenu.BeginGroup = true;
      this.DisplayMenu.Items.AddRange(new ToolbarItemBase[6]
      {
        (ToolbarItemBase) this.DisplayMenuItem1,
        (ToolbarItemBase) this.DisplayMenuItem2,
        (ToolbarItemBase) this.DisplayMenuItem3,
        (ToolbarItemBase) this.DisplayMenuItem4,
        (ToolbarItemBase) this.DisplayMenuItem5,
        (ToolbarItemBase) this.DisplayMenuItem6
      });
      this.DisplayMenuItem1.BeginGroup = true;
      this.DisplayMenuItem2.BeginGroup = true;
      this.DisplayMenuItem2.Text = "128 x 128";
      this.DisplayMenuItem3.BeginGroup = true;
      this.DisplayMenuItem3.Text = "64 x 64";
      this.DisplayMenuItem4.BeginGroup = true;
      this.DisplayMenuItem4.Text = "32 x 32";
      this.DisplayMenuItem5.BeginGroup = true;
      this.DisplayMenuItem5.Text = "16 x 16";
      this.DisplayMenuItem6.BeginGroup = true;
      this.DisplayMenuItem6.Text = "8 x 8";
      this.AusgabeMenu.Items.AddRange(new ToolbarItemBase[2]
      {
        (ToolbarItemBase) this.AusgabeMenuItem1,
        (ToolbarItemBase) this.AusgabeMenuItem2
      });
      this.AusgabeMenu.Text = "Mode";
      this.AusgabeMenuItem1.BeginGroup = true;
      this.AusgabeMenuItem1.Text = "Image List";
      this.AusgabeMenuItem2.BeginGroup = true;
      this.AusgabeMenuItem2.Text = "Report";
      this.ImageToolButton2.BeginGroup = true;
      this.ImageDropDownMenu1.BeginGroup = true;
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
      this.Panel2.AutoScroll = true;
      this.Panel2.BorderStyle = BorderStyle.Fixed3D;
      this.Panel2.Controls.Add((Control) this.Sr_TextureViewer1);
      this.Panel2.Controls.Add((Control) this.AusgabeGrid);
      this.Panel2.Dock = DockStyle.Fill;
      Panel panel2_1 = this.Panel2;
      point1 = new Point(278, 23);
      Point point7 = point1;
      panel2_1.Location = point7;
      this.Panel2.Name = "Panel2";
      Panel panel2_2 = this.Panel2;
      size1 = new Size(504, 515);
      Size size7 = size1;
      panel2_2.Size = size7;
      this.Panel2.TabIndex = 4;
      this.AusgabeGrid.ColumnInfo = "10,1,0,0,0,90,Columns:";
      this.AusgabeGrid.Dock = DockStyle.Fill;
      C1.Win.C1FlexGrid.C1FlexGrid ausgabeGrid1 = this.AusgabeGrid;
      point1 = new Point(0, 0);
      Point point8 = point1;
      ausgabeGrid1.Location = point8;
      this.AusgabeGrid.Name = "AusgabeGrid";
      this.AusgabeGrid.Rows.DefaultSize = 18;
      C1.Win.C1FlexGrid.C1FlexGrid ausgabeGrid2 = this.AusgabeGrid;
      size1 = new Size(500, 511);
      Size size8 = size1;
      ausgabeGrid2.Size = size8;
      this.AusgabeGrid.Styles = new CellStyleCollection("");
      this.AusgabeGrid.TabIndex = 6;
      ProgressBar progressBar1 = this.ProgressBar1;
      point1 = new Point(72, 152);
      Point point9 = point1;
      progressBar1.Location = point9;
      this.ProgressBar1.Maximum = 50000;
      this.ProgressBar1.Name = "ProgressBar1";
      this.ProgressBar1.TabIndex = 1;
      StatusBar statusBar1_1 = this.StatusBar1;
      point1 = new Point(0, 538);
      Point point10 = point1;
      statusBar1_1.Location = point10;
      this.StatusBar1.Name = "StatusBar1";
      this.StatusBar1.Panels.AddRange(new StatusBarPanel[2]
      {
        this.StatusBarPanel1,
        this.StatusBarPanel2
      });
      this.StatusBar1.ShowPanels = true;
      StatusBar statusBar1_2 = this.StatusBar1;
      size1 = new Size(782, 25);
      Size size9 = size1;
      statusBar1_2.Size = size9;
      this.StatusBar1.TabIndex = 2;
      this.StatusBar1.Text = "StatusBar1";
      this.StatusBarPanel1.MinWidth = 60;
      this.StatusBarPanel1.Text = "Ready";
      this.StatusBarPanel1.Width = 270;
      this.StatusBarPanel2.AutoSize = StatusBarPanelAutoSize.Spring;
      this.StatusBarPanel2.MinWidth = 100;
      this.StatusBarPanel2.Text = "StatusBarPanel2";
      this.StatusBarPanel2.Width = 496;
      this.Sr_TextureViewer1.Dock = DockStyle.Fill;
      sr_TextureViewer srTextureViewer1_1 = this.Sr_TextureViewer1;
      point1 = new Point(0, 0);
      Point point11 = point1;
      srTextureViewer1_1.Location = point11;
      this.Sr_TextureViewer1.Name = "Sr_TextureViewer1";
      sr_TextureViewer srTextureViewer1_2 = this.Sr_TextureViewer1;
      size1 = new Size(500, 511);
      Size size10 = size1;
      srTextureViewer1_2.Size = size10;
      this.Sr_TextureViewer1.TabIndex = 7;
      this.Sr_TextureViewer1.Visible = false;
      size1 = new Size(6, 14);
      this.AutoScaleBaseSize = size1;
      size1 = new Size(782, 563);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.Panel2);
      this.Controls.Add((Control) this.ImagesToolBar);
      this.Controls.Add((Control) this.Splitter1);
      this.Controls.Add((Control) this.Panel1);
      this.Controls.Add((Control) this.StatusBar1);
      this.Controls.Add((Control) this.ProgressBar1);
      this.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Name = nameof (Form8);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Form2";
      this.Panel1.ResumeLayout(false);
      this.Panel2.ResumeLayout(false);
      this.AusgabeGrid.EndInit();
      this.StatusBarPanel1.EndInit();
      this.StatusBarPanel2.EndInit();
      this.ResumeLayout(false);
    }

    private object ScanFiles(ArrayList DateiArray1, bool isNew)
    {
      this.isLoading = true;
      this.ImagesToolBar.Enabled = false;
      int num = checked (DateiArray1.Count - 1);
      int index = 0;
      while (index <= num)
      {
        ClassThisProg.DefReader.TextureListe.GetTextures(StringType.FromObject(DateiArray1[index]));
        if (this.SearchFileArray.IndexOf(RuntimeHelpers.GetObjectValue(DateiArray1[index])) < 0)
          this.SearchFileArray.Add(RuntimeHelpers.GetObjectValue(DateiArray1[index]));
        checked { ++index; }
      }
      if (this.SearchFileArray.Count > 0)
        this.GetSelection();
      object obj;
      return obj;
    }

    private object FormatAusgabeGrid()
    {
      C1.Win.C1FlexGrid.C1FlexGrid ausgabeGrid = this.AusgabeGrid;
      ausgabeGrid.AllowDrop = false;
      ausgabeGrid.AllowDragging = ~AllowDraggingEnum.None;
      ausgabeGrid.AllowEditing = false;
      ausgabeGrid.AllowMerging = AllowMergingEnum.None;
      ausgabeGrid.AllowSorting = AllowSortingEnum.None;
      ausgabeGrid.AllowResizing = AllowResizingEnum.Columns;
      ausgabeGrid.ScrollBars = ScrollBars.Both;
      ausgabeGrid.SelectionMode = SelectionModeEnum.Row;
      ausgabeGrid.Styles.EmptyArea.BackColor = ausgabeGrid.Styles.Normal.BackColor;
      ausgabeGrid.Styles.EmptyArea.Border.Style = C1.Win.C1FlexGrid.BorderStyleEnum.None;
      ausgabeGrid.HighLight = HighLightEnum.WithFocus;
      ausgabeGrid.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
      ausgabeGrid.ScrollBars = ScrollBars.Both;
      ausgabeGrid.Styles.Fixed.BackColor = Color.SteelBlue;
      ausgabeGrid.Styles.Fixed.ForeColor = Color.White;
      ausgabeGrid.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter;
      ausgabeGrid.Styles.Fixed.TextEffect = TextEffectEnum.Flat;
      ausgabeGrid.Styles.Fixed.Border.Color = Color.White;
      ausgabeGrid.Styles.Fixed.Font = this.Font;
      ausgabeGrid.Styles.Normal.Font = this.Font;
      ausgabeGrid.Styles.Normal.TextAlign = TextAlignEnum.CenterCenter;
      ausgabeGrid.Styles.Alternate.BackColor = ausgabeGrid.Styles.Frozen.BackColor;
      ausgabeGrid.ExtendLastCol = true;
      ausgabeGrid.Cols.Count = 6;
      ausgabeGrid.Rows.Count = 1;
      ausgabeGrid.Cols.Fixed = 0;
      ausgabeGrid.Rows.Fixed = 1;
      ausgabeGrid.Cols[0].Name = "8";
      ausgabeGrid.Cols[1].Name = "16";
      ausgabeGrid.Cols[2].Name = "32";
      ausgabeGrid.Cols[3].Name = "64";
      ausgabeGrid.Cols[4].Name = "128";
      ausgabeGrid.Cols[5].Name = "Datei";
      ausgabeGrid.Cols[ausgabeGrid.Cols["8"].Index].Width = 80;
      ausgabeGrid.Cols[ausgabeGrid.Cols["16"].Index].Width = 80;
      ausgabeGrid.Cols[ausgabeGrid.Cols["32"].Index].Width = 80;
      ausgabeGrid.Cols[ausgabeGrid.Cols["64"].Index].Width = 80;
      ausgabeGrid.Cols[ausgabeGrid.Cols["128"].Index].Width = 80;
      ausgabeGrid.Cols[ausgabeGrid.Cols["Datei"].Index].Width = 80;
      ausgabeGrid.Cols[ausgabeGrid.Cols["8"].Index].TextAlign = TextAlignEnum.CenterCenter;
      ausgabeGrid.Cols[ausgabeGrid.Cols["8"].Index].TextAlignFixed = TextAlignEnum.CenterCenter;
      ausgabeGrid.Cols[ausgabeGrid.Cols["16"].Index].TextAlign = TextAlignEnum.CenterCenter;
      ausgabeGrid.Cols[ausgabeGrid.Cols["16"].Index].TextAlignFixed = TextAlignEnum.CenterCenter;
      ausgabeGrid.Cols[ausgabeGrid.Cols["32"].Index].TextAlign = TextAlignEnum.CenterCenter;
      ausgabeGrid.Cols[ausgabeGrid.Cols["32"].Index].TextAlignFixed = TextAlignEnum.CenterCenter;
      ausgabeGrid.Cols[ausgabeGrid.Cols["64"].Index].TextAlign = TextAlignEnum.CenterCenter;
      ausgabeGrid.Cols[ausgabeGrid.Cols["64"].Index].TextAlignFixed = TextAlignEnum.CenterCenter;
      ausgabeGrid.Cols[ausgabeGrid.Cols["128"].Index].TextAlign = TextAlignEnum.CenterCenter;
      ausgabeGrid.Cols[ausgabeGrid.Cols["128"].Index].TextAlignFixed = TextAlignEnum.CenterCenter;
      ausgabeGrid.Cols[ausgabeGrid.Cols["Datei"].Index].TextAlign = TextAlignEnum.LeftCenter;
      ausgabeGrid.Cols[ausgabeGrid.Cols["Datei"].Index].TextAlignFixed = TextAlignEnum.LeftCenter;
      ausgabeGrid.SetData(0, ausgabeGrid.Cols["8"].Index, (object) "8 x 8");
      ausgabeGrid.SetData(0, ausgabeGrid.Cols["16"].Index, (object) "16 x 16");
      ausgabeGrid.SetData(0, ausgabeGrid.Cols["32"].Index, (object) "32 x 32");
      ausgabeGrid.SetData(0, ausgabeGrid.Cols["64"].Index, (object) "64 x 64");
      ausgabeGrid.SetData(0, ausgabeGrid.Cols["128"].Index, (object) "128 x 128");
      ausgabeGrid.SetData(0, ausgabeGrid.Cols["Datei"].Index, RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[362]));
      object obj;
      return obj;
    }

    private object ShowReport()
    {
      this.Cursor = Cursors.WaitCursor;
      this.StatusBarPanel2.Text = this.ResultTexturen.Count.ToString() + " Textures";
      C1.Win.C1FlexGrid.C1FlexGrid ausgabeGrid = this.AusgabeGrid;
      ausgabeGrid.Rows.Count = ausgabeGrid.Rows.Fixed;
      if (this.ResultTexturen.Count > 0)
      {
        string gruppe = this.ResultTexturen.get_item(0).Gruppe;
        int num = checked (this.ResultTexturen.Count - 1);
        int number1 = 0;
        while (number1 <= num)
        {
          ausgabeGrid.Rows.Add();
          ausgabeGrid.SetData(checked (ausgabeGrid.Rows.Count - 1), ausgabeGrid.Cols["Datei"].Index, (object) this.ResultTexturen.get_item(number1).FileName);
          bool flag = true;
          int number2 = number1;
          while (flag)
          {
            if (number2 <= checked (this.ResultTexturen.Count - 1))
            {
              if (StringType.StrCmp(this.ResultTexturen.get_item(number2).Gruppe, gruppe, false) != 0)
              {
                number1 = checked (number2 - 1);
                gruppe = this.ResultTexturen.get_item(number2).Gruppe;
                break;
              }
              switch (this.ResultTexturen.get_item(number2).PictureSize)
              {
                case 8:
                  ausgabeGrid.SetData(checked (ausgabeGrid.Rows.Count - 1), ausgabeGrid.Cols["8"].Index, (object) this.ResultTexturen.get_item(number2).Instance);
                  break;
                case 16:
                  ausgabeGrid.SetData(checked (ausgabeGrid.Rows.Count - 1), ausgabeGrid.Cols["16"].Index, (object) this.ResultTexturen.get_item(number2).Instance);
                  break;
                case 32:
                  ausgabeGrid.SetData(checked (ausgabeGrid.Rows.Count - 1), ausgabeGrid.Cols["32"].Index, (object) this.ResultTexturen.get_item(number2).Instance);
                  break;
                case 64:
                  ausgabeGrid.SetData(checked (ausgabeGrid.Rows.Count - 1), ausgabeGrid.Cols["64"].Index, (object) this.ResultTexturen.get_item(number2).Instance);
                  break;
                case 128:
                  ausgabeGrid.SetData(checked (ausgabeGrid.Rows.Count - 1), ausgabeGrid.Cols["128"].Index, (object) this.ResultTexturen.get_item(number2).Instance);
                  break;
              }
              checked { ++number2; }
            }
            else
              goto label_16;
          }
          checked { ++number1; }
        }
      }
label_16:
      if (ausgabeGrid.Rows.Count > ausgabeGrid.Rows.Fixed)
        this.ImagesToolBar.Enabled = true;
      this.Cursor = Cursors.Default;
      object obj;
      return obj;
    }

    private object ShowImages()
    {
      bool flag1 = false;
      this.StatusBarPanel1.Text = "Reading Images....";
      this.Sr_TextureViewer1.Clear();
      this.Sr_TextureViewer1.GridNoRedraw();
      try
      {
        StatusBarPanel statusBarPanel2 = this.StatusBarPanel2;
        int number1 = this.ResultTexturen.Count;
        string str1 = number1.ToString() + " Textures";
        statusBarPanel2.Text = str1;
        if (this.ResultTexturen.Count > 0)
        {
          this.ProgressBar1.Minimum = 0;
          this.ProgressBar1.Maximum = checked (this.ResultTexturen.Count - 1);
          this.ProgressBar1.Value = this.ProgressBar1.Minimum;
          this.ProgressBar1.Visible = true;
          this.Cursor = Cursors.WaitCursor;
          this.Panel2.AutoScroll = false;
          int num = checked (this.ResultTexturen.Count - 1);
          int number2 = 0;
          while (number2 <= num)
          {
            bool flag2 = false;
            string str2 = " = " + StringType.FromInteger(this.DisplaySize);
            cTexture cTexture1;
            cTexture cTexture2;
            if (this.DisplaySize == 1000)
            {
              if (Information.IsNothing((object) this.ResultTexturen.get_item(number2).Picture))
              {
                TextureReader textureListe = ClassThisProg.DefReader.TextureListe;
                cTexture1 = this.ResultTexturen;
                cTexture cTexture3 = cTexture1;
                number1 = number2;
                int number3 = number1;
                cTexture2 = cTexture3.get_item(number3);
                ref cTexture local = ref cTexture2;
                textureListe.GetTextureImage(ref local);
                cTexture1.set_item(number1, cTexture2);
              }
              flag2 = true;
            }
            else if (this.ResultTexturen.get_item(number2).PictureSize == this.DisplaySize)
            {
              flag2 = true;
              if (Information.IsNothing((object) this.ResultTexturen.get_item(number2).Picture))
              {
                TextureReader textureListe = ClassThisProg.DefReader.TextureListe;
                cTexture2 = this.ResultTexturen;
                cTexture cTexture4 = cTexture2;
                number1 = number2;
                int number4 = number1;
                cTexture1 = cTexture4.get_item(number4);
                ref cTexture local = ref cTexture1;
                textureListe.GetTextureImage(ref local);
                cTexture2.set_item(number1, cTexture1);
              }
            }
            if (flag2 && !Information.IsNothing((object) this.ResultTexturen.get_item(number2).Picture))
              this.Sr_TextureViewer1.AddImage(this.ResultTexturen.get_item(number2));
            this.ProgressBar1.PerformStep();
            checked { ++number2; }
          }
          this.ProgressBar1.Visible = false;
          this.Sr_TextureViewer1.GridRedraw();
          this.Cursor = Cursors.Default;
          this.StatusBarPanel1.Text = "Ready";
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        flag1 = false;
        ProjectData.ClearProjectError();
      }
      if (flag1)
      {
        this.ImagesToolBar.Enabled = true;
        this.ImageDropDownMenu1.Enabled = true;
        this.DisplayMenu.Enabled = true;
      }
      object obj;
      return obj;
    }

    private object SavePicture(string SaveFormat)
    {
      if (StringType.StrCmp(this.Sr_TextureViewer1.SelectPictureName(), "", false) == 0)
      {
        int num1 = (int) MessageBox.Show((IWin32Window) this, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[71]), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[17]), MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      else
      {
        string[] strArray = this.Sr_TextureViewer1.SelectPictureName().Split(',');
        if (strArray.GetUpperBound(0) != 1)
        {
          int num2 = (int) MessageBox.Show((IWin32Window) this, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[71]), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[17]), MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
            int num3 = checked (this.SizeArray.Count - 1);
            int index = 0;
            while (index <= num3)
            {
              TextureReader.TextureImage textureImage = ClassThisProg.DefReader.TextureListe.SelectTextureWithImage(strArray[1], strArray[0], IntegerType.FromObject(this.SizeArray[index]));
              if (!Information.IsNothing((object) textureImage))
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
            int num4 = (int) MessageBox.Show((IWin32Window) this, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[71]), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[17]), MessageBoxButtons.OK, MessageBoxIcon.Hand);
            ProjectData.ClearProjectError();
            goto label_26;
          }
          int num5 = (int) MessageBox.Show((IWin32Window) this, StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj(ClassThisProg.DefReader.LanguageArray[70], (object) " "), (object) ClassThisProg.DefReader.ExportDir)), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[17]), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
      }
label_26:
      object obj;
      return obj;
    }

    private object SaveThumbToHTML()
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
        if (!this.Sr_TextureViewer1.SaveToHTML(saveFileDialog.FileName))
        {
          int num1 = (int) MessageBox.Show((IWin32Window) this, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[64]), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[17]), MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        else
        {
          int num2 = (int) MessageBox.Show((IWin32Window) this, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[65]), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[17]), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
      }
      object obj;
      return obj;
    }

    private object GetSelection()
    {
      ArrayList arrayList = new ArrayList();
      if (this.SearchFileArray.Count != 0)
      {
        this.isLoading = true;
        this.Cursor = Cursors.WaitCursor;
        this.ResultTexturen.Clear();
        this.MainSelectListe = new cTexture[0];
        int num = checked (this.SearchFileArray.Count - 1);
        int index = 0;
        while (index <= num)
        {
          arrayList.AddRange((ICollection) ClassThisProg.DefReader.TextureListe.SelectTexture(StringType.FromObject(this.SearchFileArray[index])));
          checked { ++index; }
        }
        if (arrayList.Count > 0)
        {
          this.MainSelectListe = new cTexture[checked (arrayList.Count - 1 + 1)];
          arrayList.CopyTo((Array) this.MainSelectListe);
          this.FillTreeView();
        }
        this.isLoading = false;
        this.Cursor = Cursors.Default;
      }
      object obj;
      return obj;
    }

    private object FillTreeView()
    {
      this.isLoading = true;
      TreeView treeView1 = this.TreeView1;
      treeView1.BeginUpdate();
      treeView1.SuspendLayout();
      treeView1.Enabled = false;
      treeView1.Nodes.Clear();
      treeView1.AllowDrop = false;
      treeView1.CheckBoxes = false;
      treeView1.FullRowSelect = true;
      treeView1.ShowLines = true;
      treeView1.ShowPlusMinus = true;
      treeView1.ShowRootLines = true;
      treeView1.HideSelection = false;
      string sLeft1 = "";
      string sLeft2 = "";
      TreeNode firstNode;
      if (this.MainSelectListe.GetUpperBound(0) > -1)
      {
        treeView1.Nodes.Add(new TreeNode()
        {
          Text = "All",
          Tag = (object) "All",
          SelectedImageIndex = ClassThisProg.DefReader.IconIndexFolderOpen,
          ImageIndex = ClassThisProg.DefReader.IconIndexFolderClosed
        });
        treeView1.Nodes.Add(new TreeNode()
        {
          Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[378]),
          Tag = (object) "Search",
          SelectedImageIndex = ClassThisProg.DefReader.IconIndexSearch,
          ImageIndex = ClassThisProg.DefReader.IconIndexSearch
        });
        int upperBound = this.MainSelectListe.GetUpperBound(0);
        int index1 = 0;
        while (index1 <= upperBound)
        {
          int index2;
          if (StringType.StrCmp(sLeft1, this.MainSelectListe[index1].FileName, false) != 0)
          {
            treeView1.Nodes[0].Nodes.Add(new TreeNode()
            {
              Tag = (object) this.MainSelectListe[index1].FileName,
              Text = this.MainSelectListe[index1].SmallFileName,
              SelectedImageIndex = ClassThisProg.DefReader.IconIndexFolderOpen,
              ImageIndex = ClassThisProg.DefReader.IconIndexFolderClosed
            });
            index2 = checked (treeView1.Nodes[0].Nodes.Count - 1);
            firstNode = treeView1.Nodes[0].FirstNode;
          }
          if (StringType.StrCmp(sLeft2, this.MainSelectListe[index1].Gruppe, false) != 0)
            treeView1.Nodes[0].Nodes[index2].Nodes.Add(new TreeNode()
            {
              Tag = (object) (this.MainSelectListe[index1].FileName.ToString() + "*" + this.MainSelectListe[index1].Gruppe),
              Text = this.MainSelectListe[index1].Gruppe,
              SelectedImageIndex = ClassThisProg.DefReader.IconIndexFolderOpen,
              ImageIndex = ClassThisProg.DefReader.IconIndexFolderClosed
            });
          sLeft1 = this.MainSelectListe[index1].FileName;
          sLeft2 = this.MainSelectListe[index1].Gruppe;
          checked { ++index1; }
        }
        this.ImagesToolBar.Enabled = true;
      }
      if (!Information.IsNothing((object) firstNode))
        treeView1.Nodes[0].Expand();
      treeView1.ResumeLayout();
      treeView1.EndUpdate();
      this.TreeView1.Enabled = true;
      this.isLoading = false;
      if (!Information.IsNothing((object) firstNode))
        this.TreeView1.SelectedNode = firstNode;
      object obj;
      return obj;
    }

    public object SetzeTexte()
    {
      this.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[311]);
      this.MenuButtonItem1.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[354]);
      this.MenuButtonItemAll.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[357]);
      this.MenuButtonCommon.Text = ClassThisProg.DefReader.SC4Path;
      this.MenuButtonItemPersonal.Text = ClassThisProg.DefReader.sc4LocalPath;
      this.MenuButtonItem2.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[355]);
      this.MenuButtonItem5.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[356]);
      this.ImageDropDownMenu1.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[360]);
      this.SortMenu.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[361]);
      this.MenuSortItem1.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[362]);
      this.MenuSortItem2.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[363]);
      this.DisplayMenu.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[364]);
      this.DisplayMenuItem1.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[357]);
      this.ImageToolButton2.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[63]);
      this.ButtonItem1.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[3]);
      this.DropDownMenuItem1.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[365]);
      this.AusgabeMenu.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[367]);
      this.AusgabeMenuItem1.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[368]);
      this.AusgabeMenuItem2.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[369]);
      this.SearchButton.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[372]);
      this.ButtonClearSelection.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[377]);
      object obj;
      return obj;
    }

    private void Form8_Load(object sender, EventArgs e)
    {
      sr_Userinterface.AendereFarben((Form) this, ClassThisProg.DefReader.FarbSchema);
      this.SetzeTexte();
      this.TreeView1.ImageList = ClassThisProg.DefReader.MainImageList;
      this.DropDownMenuItem1.MenuImageList = ClassThisProg.DefReader.MainImageList;
      this.ToolBar1.ImageList = ClassThisProg.DefReader.MainImageList;
      this.ImagesToolBar.ImageList = ClassThisProg.DefReader.MainImageList;
      this.SortMenu.MenuImageList = ClassThisProg.DefReader.MainImageList;
      this.ImageDropDownMenu1.ImageIndex = ClassThisProg.DefReader.IconIndexSave;
      this.ImageToolButton2.ImageIndex = ClassThisProg.DefReader.IconIndexInternet1;
      this.AusgabeMenuItem2.ImageIndex = ClassThisProg.DefReader.IconIndexTabelle;
      this.AusgabeMenuItem1.ImageIndex = ClassThisProg.DefReader.IconIndexBild;
      this.ButtonClearSelection.ImageIndex = ClassThisProg.DefReader.IconIndexDeleteRed;
      this.SearchButton.ImageIndex = ClassThisProg.DefReader.IconIndexSearch;
      this.DropDownMenuItem1.ImageIndex = ClassThisProg.DefReader.IconIndexFolderOpen;
      this.ButtonItem1.ImageIndex = ClassThisProg.DefReader.IconIndexExit;
      this.SizeArray.Add((object) 8);
      this.SizeArray.Add((object) 16);
      this.SizeArray.Add((object) 32);
      this.SizeArray.Add((object) 64);
      this.SizeArray.Add((object) 128);
      this.Sr_TextureViewer1.Visible = false;
      this.AusgabeGrid.Visible = true;
      Control progressBar1 = (Control) this.ProgressBar1;
      ref Control local1 = ref progressBar1;
      StatusBar statusBar1 = this.StatusBar1;
      ref StatusBar local2 = ref statusBar1;
      short num = 1;
      ref short local3 = ref num;
      StatusBarChild statusBarChild = new StatusBarChild(ref local1, ref local2, ref local3);
      this.StatusBar1 = statusBar1;
      this.ProgressBar1 = (ProgressBar) progressBar1;
      this.sbcProgressBar = statusBarChild;
      this.StatusBarPanel1.Width = checked ((int) Math.Round(unchecked ((double) this.Panel1.Width + (double) this.Splitter1.Width / 2.0)));
      this.sbcProgressBar.Resize();
      if (StringType.StrCmp(ClassThisProg.DefReader.SC4Path, "", false) == 0)
      {
        this.MenuButtonItem1.Enabled = false;
        this.SearchButton.Enabled = false;
      }
      this.MenuSortItem1.Checked = true;
      this.ImagesToolBar.Enabled = false;
      this.ImageDropDownMenu1.Enabled = false;
      this.ResultTexturen.Clear();
      this.MainSelectListe = new cTexture[0];
      this.AusgabeModus = "Report";
      this.isLoading = true;
      this.DisplayMenuItem3.Checked = true;
      this.DisplaySize = 64;
      this.SearchFileArray.Clear();
    }

    private void ImageMenuItem1_Activate(object sender, EventArgs e) => this.SavePicture(this.ImageMenuItem1.Text);

    private void ImageMenuItem2_Activate(object sender, EventArgs e) => this.SavePicture(this.ImageMenuItem2.Text);

    private void ImageMenuItem3_Activate(object sender, EventArgs e) => this.SavePicture(this.ImageMenuItem3.Text);

    private void ImageMenuItem4_Activate(object sender, EventArgs e) => this.SavePicture(this.ImageMenuItem4.Text);

    private void ImageMenuItem5_Activate(object sender, EventArgs e) => this.SavePicture(this.ImageMenuItem5.Text);

    private void ImageMenuItem6_Activate(object sender, EventArgs e) => this.SavePicture(this.ImageMenuItem6.Text);

    private void MenuButtonItemAll_Activate(object sender, EventArgs e)
    {
      this.SearchFileArray.Clear();
      this.SearchFileArray.AddRange((ICollection) ClassThisProg.DefReader.MainCommonFolderArray);
      this.SearchFileArray.AddRange((ICollection) ClassThisProg.DefReader.MainPrivateFolderArray);
      this.GetSelection();
    }

    private void MenuButtonCommon_Activate(object sender, EventArgs e)
    {
      this.SearchFileArray.Clear();
      this.SearchFileArray = (ArrayList) ClassThisProg.DefReader.MainCommonFolderArray.Clone();
      this.GetSelection();
    }

    private void MenuButtonItemPersonal_Activate(object sender, EventArgs e)
    {
      this.SearchFileArray.Clear();
      this.SearchFileArray = (ArrayList) ClassThisProg.DefReader.MainPrivateFolderArray.Clone();
      this.GetSelection();
    }

    private void ImageToolButton2_Activate(object sender, EventArgs e)
    {
      if (this.AusgabeGrid.Visible)
        MainFunctionClass.SaveToHTML((Form) this, this.AusgabeGrid);
      else
        this.SaveThumbToHTML();
    }

    private void MenuButtonItem5_Activate(object sender, EventArgs e)
    {
      ArrayList DateiArray1 = new ArrayList();
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.RestoreDirectory = true;
      openFileDialog.Title = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[16]);
      openFileDialog.ShowReadOnly = true;
      openFileDialog.Filter = "SC4-Files (*.dat;*.sc4Lot)|*.dat;*.sc4Lot|All (*.*)|*.*";
      if (openFileDialog.ShowDialog() != DialogResult.OK)
        return;
      this.Cursor = Cursors.WaitCursor;
      this.StatusBarPanel1.Text = "Reading....";
      FileInfo fileInfo = new FileInfo(openFileDialog.FileName);
      DateiArray1.Add((object) fileInfo.FullName);
      this.ScanFiles(DateiArray1, true);
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
      this.Cursor = Cursors.WaitCursor;
      this.StatusBarPanel1.Text = "Reading....";
      sr_DirBrowser.StartRead(StringType.FromObject(LateBinding.LateGet(o, (System.Type) null, "SelectedPath", new object[0], (string[]) null, (bool[]) null)), PatternList, ref Array1);
      this.ScanFiles(Array1, true);
      this.StatusBarPanel1.Text = "Ready";
      this.Cursor = Cursors.Default;
    }

    private void ButtonItem1_Activate(object sender, EventArgs e) => this.Dispose();

    private void MenuSortItem1_Activate(object sender, EventArgs e)
    {
      this.MenuSortItem1.Checked = true;
      this.MenuSortItem2.Checked = false;
      this.MainSortString = "FileName,Gruppe";
      if (StringType.StrCmp(this.AusgabeModus, "Images", false) == 0)
        this.ShowImages();
      else
        this.ShowReport();
    }

    private void MenuSortItem2_Activate(object sender, EventArgs e)
    {
      this.MenuSortItem1.Checked = false;
      this.MenuSortItem2.Checked = true;
      this.MainSortString = "Gruppe,FileName";
      if (StringType.StrCmp(this.AusgabeModus, "Images", false) == 0)
        this.ShowImages();
      else
        this.ShowReport();
    }

    private void DisplayMenuItem1_Activate(object sender, EventArgs e)
    {
      this.DisplayMenuItem1.Checked = true;
      this.DisplayMenuItem2.Checked = false;
      this.DisplayMenuItem3.Checked = false;
      this.DisplayMenuItem4.Checked = false;
      this.DisplayMenuItem5.Checked = false;
      this.DisplayMenuItem6.Checked = false;
      this.DisplaySize = 1000;
      if (StringType.StrCmp(this.AusgabeModus, "Images", false) != 0)
        return;
      this.ShowImages();
    }

    private void DisplayMenuItem2_Activate(object sender, EventArgs e)
    {
      this.DisplayMenuItem1.Checked = false;
      this.DisplayMenuItem2.Checked = true;
      this.DisplayMenuItem3.Checked = false;
      this.DisplayMenuItem4.Checked = false;
      this.DisplayMenuItem5.Checked = false;
      this.DisplayMenuItem6.Checked = false;
      this.DisplaySize = 128;
      if (StringType.StrCmp(this.AusgabeModus, "Images", false) != 0)
        return;
      this.ShowImages();
    }

    private void DisplayMenuItem3_Activate(object sender, EventArgs e)
    {
      this.DisplayMenuItem1.Checked = false;
      this.DisplayMenuItem2.Checked = false;
      this.DisplayMenuItem3.Checked = true;
      this.DisplayMenuItem4.Checked = false;
      this.DisplayMenuItem5.Checked = false;
      this.DisplayMenuItem6.Checked = false;
      this.DisplaySize = 64;
      if (StringType.StrCmp(this.AusgabeModus, "Images", false) != 0)
        return;
      this.ShowImages();
    }

    private void DisplayMenuItem4_Activate(object sender, EventArgs e)
    {
      this.DisplayMenuItem1.Checked = false;
      this.DisplayMenuItem2.Checked = false;
      this.DisplayMenuItem3.Checked = false;
      this.DisplayMenuItem4.Checked = true;
      this.DisplayMenuItem5.Checked = false;
      this.DisplayMenuItem6.Checked = false;
      this.DisplaySize = 32;
      if (StringType.StrCmp(this.AusgabeModus, "Images", false) != 0)
        return;
      this.ShowImages();
    }

    private void DisplayMenuItem5_Activate(object sender, EventArgs e)
    {
      this.DisplayMenuItem1.Checked = false;
      this.DisplayMenuItem2.Checked = false;
      this.DisplayMenuItem3.Checked = false;
      this.DisplayMenuItem4.Checked = false;
      this.DisplayMenuItem5.Checked = true;
      this.DisplayMenuItem6.Checked = false;
      this.DisplaySize = 16;
      if (StringType.StrCmp(this.AusgabeModus, "Images", false) != 0)
        return;
      this.ShowImages();
    }

    private void DisplayMenuItem6_Activate(object sender, EventArgs e)
    {
      this.DisplayMenuItem1.Checked = false;
      this.DisplayMenuItem2.Checked = false;
      this.DisplayMenuItem3.Checked = false;
      this.DisplayMenuItem4.Checked = false;
      this.DisplayMenuItem5.Checked = false;
      this.DisplayMenuItem6.Checked = true;
      this.DisplaySize = 8;
      if (StringType.StrCmp(this.AusgabeModus, "Images", false) != 0)
        return;
      this.ShowImages();
    }

    private void AusgabeMenuItem1_Activate(object sender, EventArgs e)
    {
      this.ImageDropDownMenu1.Enabled = true;
      this.DisplayMenu.Enabled = true;
      this.AusgabeModus = "Images";
      this.Sr_TextureViewer1.Visible = true;
      this.AusgabeGrid.Visible = false;
      this.ShowImages();
    }

    private void AusgabeMenuItem2_Activate(object sender, EventArgs e)
    {
      this.ImageDropDownMenu1.Enabled = false;
      this.DisplayMenu.Enabled = false;
      this.AusgabeModus = "Report";
      this.Sr_TextureViewer1.Visible = false;
      this.AusgabeGrid.Visible = true;
      this.ShowReport();
    }

    private void SearchButton_Activate(object sender, EventArgs e)
    {
      cTexture cTexture1 = new cTexture();
      int index1 = -1;
      string sLeft1 = Interaction.InputBox(StringType.FromObject(ClassThisProg.DefReader.LanguageArray[373]), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[372]));
      if (StringType.StrCmp(sLeft1, "", false) == 0)
        return;
      if (!sLeft1.ToString().ToUpper().StartsWith("0X"))
        sLeft1 = "0x" + sLeft1;
      if (sLeft1.ToString().Length != 10)
      {
        int num1 = (int) MessageBox.Show((IWin32Window) this, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[374]), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[372]), MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      else
      {
        string Gruppe = sLeft1.ToUpper().Replace("0X", "0x");
        int PictureSize = 128;
        cTexture cTexture2 = ClassThisProg.DefReader.TextureListe.SearchTexture(Gruppe, PictureSize);
        if (cTexture2.Count == 0)
        {
          int num2 = (int) MessageBox.Show((IWin32Window) this, StringType.FromObject(ObjectType.StrCatObj((object) (Gruppe + " "), ClassThisProg.DefReader.LanguageArray[13])), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[372]), MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        else
        {
          this.isLoading = true;
          int index2 = 1;
          try
          {
            TreeView treeView1 = this.TreeView1;
            if (treeView1.GetNodeCount(true) == 0)
            {
              treeView1.Nodes.Add(new TreeNode()
              {
                Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[378]),
                Tag = (object) "Search",
                SelectedImageIndex = ClassThisProg.DefReader.IconIndexSearch,
                ImageIndex = ClassThisProg.DefReader.IconIndexSearch
              });
              index2 = 0;
            }
            treeView1.BeginUpdate();
            string sLeft2 = "";
            string sLeft3 = "";
            int num3 = checked (cTexture2.Count - 1);
            int number = 0;
            while (number <= num3)
            {
              this.ResultTexturen.add(cTexture2.get_item(number));
              int index3;
              if (StringType.StrCmp(sLeft2, cTexture2.get_item(number).FileName, false) != 0)
              {
                treeView1.Nodes[index2].Nodes.Add(new TreeNode()
                {
                  Tag = (object) cTexture2.get_item(number).FileName,
                  Text = cTexture2.get_item(number).SmallFileName,
                  SelectedImageIndex = ClassThisProg.DefReader.IconIndexFolderOpen,
                  ImageIndex = ClassThisProg.DefReader.IconIndexFolderClosed
                });
                index3 = checked (treeView1.Nodes[index2].Nodes.Count - 1);
              }
              if (StringType.StrCmp(sLeft3, cTexture2.get_item(number).Gruppe, false) != 0)
              {
                treeView1.Nodes[index2].Nodes[index3].Nodes.Add(new TreeNode()
                {
                  Tag = (object) (cTexture2.get_item(number).FileName + "*" + cTexture2.get_item(number).Gruppe),
                  Text = cTexture2.get_item(number).Gruppe,
                  SelectedImageIndex = ClassThisProg.DefReader.IconIndexFolderOpen,
                  ImageIndex = ClassThisProg.DefReader.IconIndexFolderClosed
                });
                if (index1 == -1)
                  index1 = index3;
              }
              sLeft2 = cTexture2.get_item(number).FileName;
              sLeft3 = cTexture2.get_item(number).Gruppe;
              checked { ++number; }
            }
            this.isLoading = false;
            treeView1.EndUpdate();
            if (index1 > -1)
            {
              treeView1.SelectedNode = treeView1.Nodes[1].Nodes[index1].Nodes[0];
              treeView1.Nodes[index2].Nodes[index1].Nodes[0].EnsureVisible();
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
        }
      }
    }

    private void Form8_Resize(object sender, EventArgs e)
    {
    }

    private void Panel1_Resize(object sender, EventArgs e)
    {
      this.StatusBarPanel1.Width = checked ((int) Math.Round(unchecked ((double) this.Panel1.Width + (double) this.Splitter1.Width / 2.0)));
      if (this.sbcProgressBar == null)
        return;
      this.sbcProgressBar.Resize();
    }

    private void ButtonClearSelection_Activate(object sender, EventArgs e)
    {
      this.Cursor = Cursors.WaitCursor;
      this.TreeView1.Nodes.Clear();
      this.StatusBarPanel2.Text = "";
      this.AusgabeGrid.Rows.Count = this.AusgabeGrid.Rows.Fixed;
      this.Sr_TextureViewer1.Clear();
      this.ResultTexturen.Clear();
      this.MainSelectListe = new cTexture[0];
      this.MainNodeCount = -1;
      this.SearchFileArray.Clear();
      this.ImagesToolBar.Enabled = false;
      this.ImageDropDownMenu1.Enabled = false;
      this.Cursor = Cursors.Default;
    }

    private void Form8_Closed(object sender, EventArgs e) => ClassThisProg.frmForm8 = (Form8) null;

    private void TreeView1_BeforeSelect(object sender, TreeViewCancelEventArgs e)
    {
    }

    private void TreeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
    {
    }

    private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
    {
      if (this.isLoading || ObjectType.ObjTst(e.Node.Tag, (object) "Search", false) == 0)
        return;
      this.StatusBarPanel2.Text = "";
      this.ResultTexturen.Clear();
      if (ObjectType.ObjTst(e.Node.Tag, (object) "All", false) != 0)
      {
        string[] strArray = e.Node.Tag.ToString().Split('*');
        this.ResultTexturen = strArray.GetUpperBound(0) != 0 ? ClassThisProg.DefReader.TextureListe.SelectTexture(strArray[0], strArray[1]) : ClassThisProg.DefReader.TextureListe.SelectTexture(strArray[0]);
      }
      if (StringType.StrCmp(this.AusgabeModus, "Images", false) == 0)
        this.ShowImages();
      else
        this.ShowReport();
    }

    private void ImageDropDownMenu1_BeforePopup(object sender, MenuPopupEventArgs e)
    {
    }
  }
}
