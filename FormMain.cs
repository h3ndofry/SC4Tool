// Decompiled with JetBrains decompiler
// Type: SC4Tool.FormMain
// Assembly: SC4Tool, Version=2.2.7.0, Culture=neutral, PublicKeyToken=null
// MVID: 69A50BC4-87A5-4C5E-BEFC-08274BC6D498
// Assembly location: C:\Program Files (x86)\SC4 Utilities\SC4Tool\SC4Tool.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using SourceLibrary.Utility;
using sr_Resources;
using sr_SC4Lib;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using TD.SandBar;
using TD.SandDock;

namespace SC4Tool
{
  public class FormMain : Form
  {
    [AccessedThroughProperty("MenuToolsItem10")]
    private MenuButtonItem _MenuToolsItem10;
    [AccessedThroughProperty("MenuTools")]
    private MenuBarItem _MenuTools;
    [AccessedThroughProperty("StatusBarPanel2")]
    private StatusBarPanel _StatusBarPanel2;
    [AccessedThroughProperty("MenuToolsItem1")]
    private MenuButtonItem _MenuToolsItem1;
    [AccessedThroughProperty("StatusBarPanel1")]
    private StatusBarPanel _StatusBarPanel1;
    [AccessedThroughProperty("MenuToolsItem2")]
    private MenuButtonItem _MenuToolsItem2;
    [AccessedThroughProperty("StatusBar1")]
    private StatusBar _StatusBar1;
    [AccessedThroughProperty("MenuToolsItem3")]
    private MenuButtonItem _MenuToolsItem3;
    [AccessedThroughProperty("MenuToolsItem4")]
    private MenuButtonItem _MenuToolsItem4;
    [AccessedThroughProperty("MenuToolsItem5")]
    private MenuButtonItem _MenuToolsItem5;
    [AccessedThroughProperty("MenuToolsItem6")]
    private MenuButtonItem _MenuToolsItem6;
    [AccessedThroughProperty("MenuBar1")]
    private MenuBar _MenuBar1;
    [AccessedThroughProperty("MenuToolsItem7")]
    private MenuButtonItem _MenuToolsItem7;
    [AccessedThroughProperty("ImageList1")]
    private ImageList _ImageList1;
    [AccessedThroughProperty("MenuLabel6")]
    private Label _MenuLabel6;
    [AccessedThroughProperty("MenuLabel9")]
    private Label _MenuLabel9;
    [AccessedThroughProperty("MenuLabel7")]
    private Label _MenuLabel7;
    [AccessedThroughProperty("MenuToolsItem8")]
    private MenuButtonItem _MenuToolsItem8;
    [AccessedThroughProperty("MenuHelpItem2")]
    private MenuButtonItem _MenuHelpItem2;
    [AccessedThroughProperty("MenuWindowsVertikal")]
    private MenuButtonItem _MenuWindowsVertikal;
    [AccessedThroughProperty("MenuLabel10")]
    private Label _MenuLabel10;
    [AccessedThroughProperty("MenuWindowsHorizontal")]
    private MenuButtonItem _MenuWindowsHorizontal;
    [AccessedThroughProperty("MenuExtras")]
    private MenuBarItem _MenuExtras;
    [AccessedThroughProperty("MenuExtrasItem1")]
    private MenuButtonItem _MenuExtrasItem1;
    [AccessedThroughProperty("MenuExtrasItem2")]
    private MenuButtonItem _MenuExtrasItem2;
    [AccessedThroughProperty("MenuAdmin")]
    private MenuBarItem _MenuAdmin;
    [AccessedThroughProperty("MenuWindowsCascade")]
    private MenuButtonItem _MenuWindowsCascade;
    [AccessedThroughProperty("MenuLabel2")]
    private Label _MenuLabel2;
    [AccessedThroughProperty("PictureBox10")]
    private PictureBox _PictureBox10;
    [AccessedThroughProperty("MenuToolsItem9")]
    private MenuButtonItem _MenuToolsItem9;
    [AccessedThroughProperty("PictureBox3")]
    private PictureBox _PictureBox3;
    [AccessedThroughProperty("MenuLabel5")]
    private Label _MenuLabel5;
    [AccessedThroughProperty("MenuAdminItem1")]
    private MenuButtonItem _MenuAdminItem1;
    [AccessedThroughProperty("MenuLabel4")]
    private Label _MenuLabel4;
    [AccessedThroughProperty("PictureBox9")]
    private PictureBox _PictureBox9;
    [AccessedThroughProperty("MenuLabel3")]
    private Label _MenuLabel3;
    [AccessedThroughProperty("dctToolbox")]
    private DockControl _dctToolbox;
    [AccessedThroughProperty("MenuAdminItem2")]
    private MenuButtonItem _MenuAdminItem2;
    [AccessedThroughProperty("leftSandDock")]
    private DockContainer _leftSandDock;
    [AccessedThroughProperty("StatusBarPanel3")]
    private StatusBarPanel _StatusBarPanel3;
    [AccessedThroughProperty("DockControl1")]
    private DockControl _DockControl1;
    [AccessedThroughProperty("PictureBox8")]
    private PictureBox _PictureBox8;
    [AccessedThroughProperty("MenuHelpItem1")]
    private MenuButtonItem _MenuHelpItem1;
    [AccessedThroughProperty("ToolTip1")]
    private ToolTip _ToolTip1;
    [AccessedThroughProperty("MenuHelp")]
    private MenuBarItem _MenuHelp;
    [AccessedThroughProperty("PictureBox4")]
    private PictureBox _PictureBox4;
    [AccessedThroughProperty("PictureBox7")]
    private PictureBox _PictureBox7;
    [AccessedThroughProperty("MenuWindows")]
    private MenuBarItem _MenuWindows;
    [AccessedThroughProperty("MenuLabel8")]
    private Label _MenuLabel8;
    [AccessedThroughProperty("MenuDateiItem1")]
    private MenuButtonItem _MenuDateiItem1;
    [AccessedThroughProperty("PictureBox6")]
    private PictureBox _PictureBox6;
    [AccessedThroughProperty("MenuOptionen")]
    private MenuBarItem _MenuOptionen;
    [AccessedThroughProperty("MenuPlugIns")]
    private MenuBarItem _MenuPlugIns;
    [AccessedThroughProperty("MenuOptionenLanguage")]
    private MenuButtonItem _MenuOptionenLanguage;
    [AccessedThroughProperty("MenuOptionenSettings")]
    private MenuButtonItem _MenuOptionenSettings;
    [AccessedThroughProperty("MenuOptionenColors")]
    private MenuButtonItem _MenuOptionenColors;
    [AccessedThroughProperty("PictureBox5")]
    private PictureBox _PictureBox5;
    [AccessedThroughProperty("MenuDatei")]
    private MenuBarItem _MenuDatei;
    [AccessedThroughProperty("PictureBox2")]
    private PictureBox _PictureBox2;
    [AccessedThroughProperty("MenuOptionenColors1")]
    private MenuButtonItem _MenuOptionenColors1;
    [AccessedThroughProperty("MenuOptionenColors2")]
    private MenuButtonItem _MenuOptionenColors2;
    private IContainer components;

    public FormMain()
    {
      this.Load += new EventHandler(this.FormMain_Load);
      this.InitializeComponent();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
      ClassThisProg.frmIntro = (FormIntro) null;
    }

    internal virtual MenuBar MenuBar1
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuBar1 == null)
          ;
        this._MenuBar1 = value;
        if (this._MenuBar1 == null)
          ;
      }
      get => this._MenuBar1;
    }

    internal virtual MenuBarItem MenuTools
    {
      get => this._MenuTools;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuTools == null)
          ;
        this._MenuTools = value;
        if (this._MenuTools == null)
          ;
      }
    }

    internal virtual MenuButtonItem MenuToolsItem1
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuToolsItem1 != null)
          this._MenuToolsItem1.Activate -= new EventHandler(this.MenuToolsItem1_Activate);
        this._MenuToolsItem1 = value;
        if (this._MenuToolsItem1 == null)
          return;
        this._MenuToolsItem1.Activate += new EventHandler(this.MenuToolsItem1_Activate);
      }
      get => this._MenuToolsItem1;
    }

    internal virtual MenuButtonItem MenuToolsItem2
    {
      get => this._MenuToolsItem2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuToolsItem2 != null)
          this._MenuToolsItem2.Activate -= new EventHandler(this.MenuToolsItem2_Activate);
        this._MenuToolsItem2 = value;
        if (this._MenuToolsItem2 == null)
          return;
        this._MenuToolsItem2.Activate += new EventHandler(this.MenuToolsItem2_Activate);
      }
    }

    internal virtual MenuButtonItem MenuToolsItem3
    {
      get => this._MenuToolsItem3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuToolsItem3 != null)
          this._MenuToolsItem3.Activate -= new EventHandler(this.MenuToolsItem3_Activate);
        this._MenuToolsItem3 = value;
        if (this._MenuToolsItem3 == null)
          return;
        this._MenuToolsItem3.Activate += new EventHandler(this.MenuToolsItem3_Activate);
      }
    }

    internal virtual MenuButtonItem MenuToolsItem4
    {
      get => this._MenuToolsItem4;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuToolsItem4 != null)
          this._MenuToolsItem4.Activate -= new EventHandler(this.MenuToolsItem4_Activate);
        this._MenuToolsItem4 = value;
        if (this._MenuToolsItem4 == null)
          return;
        this._MenuToolsItem4.Activate += new EventHandler(this.MenuToolsItem4_Activate);
      }
    }

    internal virtual MenuButtonItem MenuToolsItem5
    {
      get => this._MenuToolsItem5;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuToolsItem5 != null)
          this._MenuToolsItem5.Activate -= new EventHandler(this.MenuToolsItem5_Activate);
        this._MenuToolsItem5 = value;
        if (this._MenuToolsItem5 == null)
          return;
        this._MenuToolsItem5.Activate += new EventHandler(this.MenuToolsItem5_Activate);
      }
    }

    internal virtual MenuButtonItem MenuToolsItem6
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuToolsItem6 != null)
          this._MenuToolsItem6.Activate -= new EventHandler(this.MenuToolsItem6_Activate);
        this._MenuToolsItem6 = value;
        if (this._MenuToolsItem6 == null)
          return;
        this._MenuToolsItem6.Activate += new EventHandler(this.MenuToolsItem6_Activate);
      }
      get => this._MenuToolsItem6;
    }

    internal virtual MenuButtonItem MenuToolsItem7
    {
      get => this._MenuToolsItem7;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuToolsItem7 != null)
          this._MenuToolsItem7.Activate -= new EventHandler(this.MenuToolsItem7_Activate);
        this._MenuToolsItem7 = value;
        if (this._MenuToolsItem7 == null)
          return;
        this._MenuToolsItem7.Activate += new EventHandler(this.MenuToolsItem7_Activate);
      }
    }

    internal virtual MenuButtonItem MenuToolsItem8
    {
      get => this._MenuToolsItem8;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuToolsItem8 != null)
          this._MenuToolsItem8.Activate -= new EventHandler(this.MenuToolsItem8_Activate);
        this._MenuToolsItem8 = value;
        if (this._MenuToolsItem8 == null)
          return;
        this._MenuToolsItem8.Activate += new EventHandler(this.MenuToolsItem8_Activate);
      }
    }

    internal virtual MenuButtonItem MenuToolsItem9
    {
      get => this._MenuToolsItem9;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuToolsItem9 != null)
          this._MenuToolsItem9.Activate -= new EventHandler(this.MenuToolsItem9_Activate);
        this._MenuToolsItem9 = value;
        if (this._MenuToolsItem9 == null)
          return;
        this._MenuToolsItem9.Activate += new EventHandler(this.MenuToolsItem9_Activate);
      }
    }

    internal virtual MenuButtonItem MenuToolsItem10
    {
      get => this._MenuToolsItem10;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuToolsItem10 != null)
          this._MenuToolsItem10.Activate -= new EventHandler(this.MenuToolsItem10_Activate);
        this._MenuToolsItem10 = value;
        if (this._MenuToolsItem10 == null)
          return;
        this._MenuToolsItem10.Activate += new EventHandler(this.MenuToolsItem10_Activate);
      }
    }

    internal virtual MenuBarItem MenuOptionen
    {
      get => this._MenuOptionen;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuOptionen == null)
          ;
        this._MenuOptionen = value;
        if (this._MenuOptionen == null)
          ;
      }
    }

    internal virtual MenuBarItem MenuPlugIns
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuPlugIns == null)
          ;
        this._MenuPlugIns = value;
        if (this._MenuPlugIns == null)
          ;
      }
      get => this._MenuPlugIns;
    }

    internal virtual MenuButtonItem MenuOptionenLanguage
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuOptionenLanguage == null)
          ;
        this._MenuOptionenLanguage = value;
        if (this._MenuOptionenLanguage == null)
          ;
      }
      get => this._MenuOptionenLanguage;
    }

    internal virtual MenuButtonItem MenuOptionenSettings
    {
      get => this._MenuOptionenSettings;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuOptionenSettings != null)
          this._MenuOptionenSettings.Activate -= new EventHandler(this.MenuOptionenSettings_Activate);
        this._MenuOptionenSettings = value;
        if (this._MenuOptionenSettings == null)
          return;
        this._MenuOptionenSettings.Activate += new EventHandler(this.MenuOptionenSettings_Activate);
      }
    }

    internal virtual MenuButtonItem MenuOptionenColors
    {
      get => this._MenuOptionenColors;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuOptionenColors == null)
          ;
        this._MenuOptionenColors = value;
        if (this._MenuOptionenColors == null)
          ;
      }
    }

    internal virtual MenuButtonItem MenuOptionenColors1
    {
      get => this._MenuOptionenColors1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuOptionenColors1 != null)
          this._MenuOptionenColors1.Activate -= new EventHandler(this.MenuOptionenColors1_Activate);
        this._MenuOptionenColors1 = value;
        if (this._MenuOptionenColors1 == null)
          return;
        this._MenuOptionenColors1.Activate += new EventHandler(this.MenuOptionenColors1_Activate);
      }
    }

    internal virtual MenuButtonItem MenuOptionenColors2
    {
      get => this._MenuOptionenColors2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuOptionenColors2 != null)
          this._MenuOptionenColors2.Activate -= new EventHandler(this.MenuOptionenColors2_Activate);
        this._MenuOptionenColors2 = value;
        if (this._MenuOptionenColors2 == null)
          return;
        this._MenuOptionenColors2.Activate += new EventHandler(this.MenuOptionenColors2_Activate);
      }
    }

    internal virtual MenuBarItem MenuDatei
    {
      get => this._MenuDatei;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuDatei == null)
          ;
        this._MenuDatei = value;
        if (this._MenuDatei == null)
          ;
      }
    }

    internal virtual MenuButtonItem MenuDateiItem1
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuDateiItem1 != null)
          this._MenuDateiItem1.Activate -= new EventHandler(this.MenuDateiItem1_Activate);
        this._MenuDateiItem1 = value;
        if (this._MenuDateiItem1 == null)
          return;
        this._MenuDateiItem1.Activate += new EventHandler(this.MenuDateiItem1_Activate);
      }
      get => this._MenuDateiItem1;
    }

    internal virtual MenuBarItem MenuWindows
    {
      get => this._MenuWindows;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuWindows == null)
          ;
        this._MenuWindows = value;
        if (this._MenuWindows == null)
          ;
      }
    }

    internal virtual MenuBarItem MenuHelp
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuHelp == null)
          ;
        this._MenuHelp = value;
        if (this._MenuHelp == null)
          ;
      }
      get => this._MenuHelp;
    }

    internal virtual MenuButtonItem MenuHelpItem1
    {
      get => this._MenuHelpItem1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuHelpItem1 != null)
          this._MenuHelpItem1.Activate -= new EventHandler(this.MenuHelpItem1_Activate);
        this._MenuHelpItem1 = value;
        if (this._MenuHelpItem1 == null)
          return;
        this._MenuHelpItem1.Activate += new EventHandler(this.MenuHelpItem1_Activate);
      }
    }

    internal virtual ImageList ImageList1
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ImageList1 == null)
          ;
        this._ImageList1 = value;
        if (this._ImageList1 == null)
          ;
      }
      get => this._ImageList1;
    }

    internal virtual DockContainer leftSandDock
    {
      get => this._leftSandDock;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._leftSandDock == null)
          ;
        this._leftSandDock = value;
        if (this._leftSandDock == null)
          ;
      }
    }

    internal virtual DockControl dctToolbox
    {
      get => this._dctToolbox;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._dctToolbox == null)
          ;
        this._dctToolbox = value;
        if (this._dctToolbox == null)
          ;
      }
    }

    internal virtual PictureBox PictureBox5
    {
      get => this._PictureBox5;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._PictureBox5 != null)
          this._PictureBox5.Click -= new EventHandler(this.PictureBox5_Click);
        this._PictureBox5 = value;
        if (this._PictureBox5 == null)
          return;
        this._PictureBox5.Click += new EventHandler(this.PictureBox5_Click);
      }
    }

    internal virtual PictureBox PictureBox4
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._PictureBox4 != null)
          this._PictureBox4.Click -= new EventHandler(this.PictureBox4_Click);
        this._PictureBox4 = value;
        if (this._PictureBox4 == null)
          return;
        this._PictureBox4.Click += new EventHandler(this.PictureBox4_Click);
      }
      get => this._PictureBox4;
    }

    internal virtual PictureBox PictureBox3
    {
      get => this._PictureBox3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._PictureBox3 != null)
          this._PictureBox3.Click -= new EventHandler(this.PictureBox3_Click);
        this._PictureBox3 = value;
        if (this._PictureBox3 == null)
          return;
        this._PictureBox3.Click += new EventHandler(this.PictureBox3_Click);
      }
    }

    internal virtual PictureBox PictureBox2
    {
      get => this._PictureBox2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._PictureBox2 != null)
          this._PictureBox2.Click -= new EventHandler(this.PictureBox2_Click);
        this._PictureBox2 = value;
        if (this._PictureBox2 == null)
          return;
        this._PictureBox2.Click += new EventHandler(this.PictureBox2_Click);
      }
    }

    internal virtual Label MenuLabel3
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuLabel3 == null)
          ;
        this._MenuLabel3 = value;
        if (this._MenuLabel3 == null)
          ;
      }
      get => this._MenuLabel3;
    }

    internal virtual Label MenuLabel4
    {
      get => this._MenuLabel4;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuLabel4 == null)
          ;
        this._MenuLabel4 = value;
        if (this._MenuLabel4 == null)
          ;
      }
    }

    internal virtual Label MenuLabel5
    {
      get => this._MenuLabel5;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuLabel5 == null)
          ;
        this._MenuLabel5 = value;
        if (this._MenuLabel5 == null)
          ;
      }
    }

    internal virtual Label MenuLabel2
    {
      get => this._MenuLabel2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuLabel2 == null)
          ;
        this._MenuLabel2 = value;
        if (this._MenuLabel2 == null)
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

    internal virtual MenuButtonItem MenuWindowsCascade
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuWindowsCascade != null)
          this._MenuWindowsCascade.Activate -= new EventHandler(this.MenuWindowsCascade_Activate);
        this._MenuWindowsCascade = value;
        if (this._MenuWindowsCascade == null)
          return;
        this._MenuWindowsCascade.Activate += new EventHandler(this.MenuWindowsCascade_Activate);
      }
      get => this._MenuWindowsCascade;
    }

    internal virtual MenuButtonItem MenuWindowsHorizontal
    {
      get => this._MenuWindowsHorizontal;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuWindowsHorizontal != null)
          this._MenuWindowsHorizontal.Activate -= new EventHandler(this.MenuWindowsHorizontal_Activate);
        this._MenuWindowsHorizontal = value;
        if (this._MenuWindowsHorizontal == null)
          return;
        this._MenuWindowsHorizontal.Activate += new EventHandler(this.MenuWindowsHorizontal_Activate);
      }
    }

    internal virtual MenuButtonItem MenuWindowsVertikal
    {
      get => this._MenuWindowsVertikal;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuWindowsVertikal != null)
          this._MenuWindowsVertikal.Activate -= new EventHandler(this.MenuWindowsVertikal_Activate);
        this._MenuWindowsVertikal = value;
        if (this._MenuWindowsVertikal == null)
          return;
        this._MenuWindowsVertikal.Activate += new EventHandler(this.MenuWindowsVertikal_Activate);
      }
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

    internal virtual MenuButtonItem MenuHelpItem2
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuHelpItem2 == null)
          ;
        this._MenuHelpItem2 = value;
        if (this._MenuHelpItem2 == null)
          ;
      }
      get => this._MenuHelpItem2;
    }

    internal virtual DockControl DockControl1
    {
      get => this._DockControl1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._DockControl1 == null)
          ;
        this._DockControl1 = value;
        if (this._DockControl1 == null)
          ;
      }
    }

    internal virtual Label MenuLabel7
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuLabel7 == null)
          ;
        this._MenuLabel7 = value;
        if (this._MenuLabel7 == null)
          ;
      }
      get => this._MenuLabel7;
    }

    internal virtual PictureBox PictureBox7
    {
      get => this._PictureBox7;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._PictureBox7 != null)
          this._PictureBox7.Click -= new EventHandler(this.PictureBox7_Click);
        this._PictureBox7 = value;
        if (this._PictureBox7 == null)
          return;
        this._PictureBox7.Click += new EventHandler(this.PictureBox7_Click);
      }
    }

    internal virtual Label MenuLabel6
    {
      get => this._MenuLabel6;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuLabel6 == null)
          ;
        this._MenuLabel6 = value;
        if (this._MenuLabel6 == null)
          ;
      }
    }

    internal virtual PictureBox PictureBox6
    {
      get => this._PictureBox6;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._PictureBox6 != null)
          this._PictureBox6.Click -= new EventHandler(this.PictureBox6_Click);
        this._PictureBox6 = value;
        if (this._PictureBox6 == null)
          return;
        this._PictureBox6.Click += new EventHandler(this.PictureBox6_Click);
      }
    }

    internal virtual PictureBox PictureBox8
    {
      get => this._PictureBox8;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._PictureBox8 != null)
          this._PictureBox8.Click -= new EventHandler(this.PictureBox8_Click);
        this._PictureBox8 = value;
        if (this._PictureBox8 == null)
          return;
        this._PictureBox8.Click += new EventHandler(this.PictureBox8_Click);
      }
    }

    internal virtual Label MenuLabel8
    {
      get => this._MenuLabel8;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuLabel8 == null)
          ;
        this._MenuLabel8 = value;
        if (this._MenuLabel8 == null)
          ;
      }
    }

    internal virtual PictureBox PictureBox9
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._PictureBox9 != null)
          this._PictureBox9.Click -= new EventHandler(this.PictureBox9_Click);
        this._PictureBox9 = value;
        if (this._PictureBox9 == null)
          return;
        this._PictureBox9.Click += new EventHandler(this.PictureBox9_Click);
      }
      get => this._PictureBox9;
    }

    internal virtual Label MenuLabel9
    {
      get => this._MenuLabel9;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuLabel9 == null)
          ;
        this._MenuLabel9 = value;
        if (this._MenuLabel9 == null)
          ;
      }
    }

    internal virtual PictureBox PictureBox10
    {
      get => this._PictureBox10;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._PictureBox10 != null)
          this._PictureBox10.Click -= new EventHandler(this.PictureBox10_Click);
        this._PictureBox10 = value;
        if (this._PictureBox10 == null)
          return;
        this._PictureBox10.Click += new EventHandler(this.PictureBox10_Click);
      }
    }

    internal virtual Label MenuLabel10
    {
      get => this._MenuLabel10;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuLabel10 == null)
          ;
        this._MenuLabel10 = value;
        if (this._MenuLabel10 == null)
          ;
      }
    }

    internal virtual MenuBarItem MenuExtras
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuExtras == null)
          ;
        this._MenuExtras = value;
        if (this._MenuExtras == null)
          ;
      }
      get => this._MenuExtras;
    }

    internal virtual MenuButtonItem MenuExtrasItem1
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuExtrasItem1 != null)
          this._MenuExtrasItem1.Activate -= new EventHandler(this.MenuExtrasItem1_Activate);
        this._MenuExtrasItem1 = value;
        if (this._MenuExtrasItem1 == null)
          return;
        this._MenuExtrasItem1.Activate += new EventHandler(this.MenuExtrasItem1_Activate);
      }
      get => this._MenuExtrasItem1;
    }

    internal virtual MenuButtonItem MenuExtrasItem2
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuExtrasItem2 != null)
          this._MenuExtrasItem2.Activate -= new EventHandler(this.MenuExtrasItem2_Activate);
        this._MenuExtrasItem2 = value;
        if (this._MenuExtrasItem2 == null)
          return;
        this._MenuExtrasItem2.Activate += new EventHandler(this.MenuExtrasItem2_Activate);
      }
      get => this._MenuExtrasItem2;
    }

    internal virtual MenuBarItem MenuAdmin
    {
      get => this._MenuAdmin;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuAdmin == null)
          ;
        this._MenuAdmin = value;
        if (this._MenuAdmin == null)
          ;
      }
    }

    internal virtual MenuButtonItem MenuAdminItem1
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuAdminItem1 != null)
          this._MenuAdminItem1.Activate -= new EventHandler(this.MenuAdminItem1_Activate);
        this._MenuAdminItem1 = value;
        if (this._MenuAdminItem1 == null)
          return;
        this._MenuAdminItem1.Activate += new EventHandler(this.MenuAdminItem1_Activate);
      }
      get => this._MenuAdminItem1;
    }

    internal virtual MenuButtonItem MenuAdminItem2
    {
      get => this._MenuAdminItem2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuAdminItem2 != null)
          this._MenuAdminItem2.Activate -= new EventHandler(this.MenuAdminItem2_Activate);
        this._MenuAdminItem2 = value;
        if (this._MenuAdminItem2 == null)
          return;
        this._MenuAdminItem2.Activate += new EventHandler(this.MenuAdminItem2_Activate);
      }
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      ResourceManager resourceManager = new ResourceManager(typeof (FormMain));
      this.MenuBar1 = new MenuBar();
      this.ImageList1 = new ImageList(this.components);
      this.MenuDatei = new MenuBarItem();
      this.MenuDateiItem1 = new MenuButtonItem();
      this.MenuTools = new MenuBarItem();
      this.MenuToolsItem1 = new MenuButtonItem();
      this.MenuToolsItem2 = new MenuButtonItem();
      this.MenuToolsItem3 = new MenuButtonItem();
      this.MenuToolsItem4 = new MenuButtonItem();
      this.MenuToolsItem9 = new MenuButtonItem();
      this.MenuPlugIns = new MenuBarItem();
      this.MenuToolsItem6 = new MenuButtonItem();
      this.MenuToolsItem5 = new MenuButtonItem();
      this.MenuToolsItem7 = new MenuButtonItem();
      this.MenuToolsItem8 = new MenuButtonItem();
      this.MenuToolsItem10 = new MenuButtonItem();
      this.MenuExtras = new MenuBarItem();
      this.MenuExtrasItem1 = new MenuButtonItem();
      this.MenuExtrasItem2 = new MenuButtonItem();
      this.MenuOptionen = new MenuBarItem();
      this.MenuOptionenLanguage = new MenuButtonItem();
      this.MenuOptionenSettings = new MenuButtonItem();
      this.MenuOptionenColors = new MenuButtonItem();
      this.MenuOptionenColors1 = new MenuButtonItem();
      this.MenuOptionenColors2 = new MenuButtonItem();
      this.MenuWindows = new MenuBarItem();
      this.MenuWindowsCascade = new MenuButtonItem();
      this.MenuWindowsHorizontal = new MenuButtonItem();
      this.MenuWindowsVertikal = new MenuButtonItem();
      this.MenuHelp = new MenuBarItem();
      this.MenuHelpItem1 = new MenuButtonItem();
      this.MenuHelpItem2 = new MenuButtonItem();
      this.MenuAdmin = new MenuBarItem();
      this.MenuAdminItem1 = new MenuButtonItem();
      this.MenuAdminItem2 = new MenuButtonItem();
      this.leftSandDock = new DockContainer();
      this.dctToolbox = new DockControl();
      this.MenuLabel10 = new Label();
      this.PictureBox10 = new PictureBox();
      this.MenuLabel5 = new Label();
      this.MenuLabel4 = new Label();
      this.MenuLabel3 = new Label();
      this.MenuLabel2 = new Label();
      this.PictureBox5 = new PictureBox();
      this.PictureBox4 = new PictureBox();
      this.PictureBox3 = new PictureBox();
      this.PictureBox2 = new PictureBox();
      this.DockControl1 = new DockControl();
      this.MenuLabel9 = new Label();
      this.PictureBox9 = new PictureBox();
      this.MenuLabel8 = new Label();
      this.PictureBox8 = new PictureBox();
      this.MenuLabel7 = new Label();
      this.PictureBox7 = new PictureBox();
      this.MenuLabel6 = new Label();
      this.PictureBox6 = new PictureBox();
      this.StatusBar1 = new StatusBar();
      this.StatusBarPanel2 = new StatusBarPanel();
      this.StatusBarPanel3 = new StatusBarPanel();
      this.StatusBarPanel1 = new StatusBarPanel();
      this.ToolTip1 = new ToolTip(this.components);
      this.leftSandDock.SuspendLayout();
      this.dctToolbox.SuspendLayout();
      this.DockControl1.SuspendLayout();
      this.StatusBarPanel2.BeginInit();
      this.StatusBarPanel3.BeginInit();
      this.StatusBarPanel1.BeginInit();
      this.SuspendLayout();
      this.MenuBar1.AddRemoveButtonsVisible = false;
      MenuBar menuBar1_1 = this.MenuBar1;
      Guid guid1 = new Guid("7e67adec-f9d1-4bbd-a2ff-c4b1fefe632b");
      Guid guid2 = guid1;
      menuBar1_1.Guid = guid2;
      this.MenuBar1.ImageList = this.ImageList1;
      this.MenuBar1.Items.AddRange(new ToolbarItemBase[8]
      {
        (ToolbarItemBase) this.MenuDatei,
        (ToolbarItemBase) this.MenuTools,
        (ToolbarItemBase) this.MenuPlugIns,
        (ToolbarItemBase) this.MenuExtras,
        (ToolbarItemBase) this.MenuOptionen,
        (ToolbarItemBase) this.MenuWindows,
        (ToolbarItemBase) this.MenuHelp,
        (ToolbarItemBase) this.MenuAdmin
      });
      MenuBar menuBar1_2 = this.MenuBar1;
      Point point1 = new Point(0, 0);
      Point point2 = point1;
      menuBar1_2.Location = point2;
      this.MenuBar1.MenuAnimation = TopLevelMenuItemBase.MenuAnimation.None;
      this.MenuBar1.Movable = false;
      this.MenuBar1.Name = "MenuBar1";
      this.MenuBar1.OwnerForm = (Form) this;
      this.MenuBar1.Resizable = false;
      MenuBar menuBar1_3 = this.MenuBar1;
      Size size1 = new Size(782, 22);
      Size size2 = size1;
      menuBar1_3.Size = size2;
      this.MenuBar1.Stretch = false;
      this.MenuBar1.TabIndex = 1;
      this.MenuBar1.Tearable = false;
      this.MenuBar1.Text = "MenuBar1";
      ImageList imageList1 = this.ImageList1;
      size1 = new Size(16, 16);
      Size size3 = size1;
      imageList1.ImageSize = size3;
      this.ImageList1.ImageStream = (ImageListStreamer) resourceManager.GetObject("ImageList1.ImageStream");
      this.ImageList1.TransparentColor = Color.Transparent;
      this.MenuDatei.Items.AddRange(new ToolbarItemBase[1]
      {
        (ToolbarItemBase) this.MenuDateiItem1
      });
      this.MenuDateiItem1.ImageIndex = 4;
      this.MenuTools.Items.AddRange(new ToolbarItemBase[5]
      {
        (ToolbarItemBase) this.MenuToolsItem1,
        (ToolbarItemBase) this.MenuToolsItem2,
        (ToolbarItemBase) this.MenuToolsItem3,
        (ToolbarItemBase) this.MenuToolsItem4,
        (ToolbarItemBase) this.MenuToolsItem9
      });
      this.MenuToolsItem1.BeginGroup = true;
      this.MenuToolsItem2.BeginGroup = true;
      this.MenuToolsItem3.BeginGroup = true;
      this.MenuToolsItem4.BeginGroup = true;
      this.MenuToolsItem9.BeginGroup = true;
      this.MenuPlugIns.Items.AddRange(new ToolbarItemBase[5]
      {
        (ToolbarItemBase) this.MenuToolsItem6,
        (ToolbarItemBase) this.MenuToolsItem5,
        (ToolbarItemBase) this.MenuToolsItem7,
        (ToolbarItemBase) this.MenuToolsItem8,
        (ToolbarItemBase) this.MenuToolsItem10
      });
      this.MenuPlugIns.Text = "PlugIns";
      this.MenuToolsItem6.BeginGroup = true;
      this.MenuToolsItem5.BeginGroup = true;
      this.MenuToolsItem7.BeginGroup = true;
      this.MenuToolsItem8.BeginGroup = true;
      this.MenuToolsItem10.BeginGroup = true;
      this.MenuExtras.Items.AddRange(new ToolbarItemBase[2]
      {
        (ToolbarItemBase) this.MenuExtrasItem1,
        (ToolbarItemBase) this.MenuExtrasItem2
      });
      this.MenuExtras.Text = "Extras";
      this.MenuExtrasItem1.BeginGroup = true;
      this.MenuExtrasItem2.BeginGroup = true;
      this.MenuOptionen.Items.AddRange(new ToolbarItemBase[3]
      {
        (ToolbarItemBase) this.MenuOptionenLanguage,
        (ToolbarItemBase) this.MenuOptionenSettings,
        (ToolbarItemBase) this.MenuOptionenColors
      });
      this.MenuOptionenLanguage.BeginGroup = true;
      this.MenuOptionenSettings.BeginGroup = true;
      this.MenuOptionenColors.BeginGroup = true;
      this.MenuOptionenColors.Items.AddRange(new ToolbarItemBase[2]
      {
        (ToolbarItemBase) this.MenuOptionenColors1,
        (ToolbarItemBase) this.MenuOptionenColors2
      });
      this.MenuOptionenColors1.BeginGroup = true;
      this.MenuOptionenColors2.BeginGroup = true;
      this.MenuWindows.Items.AddRange(new ToolbarItemBase[3]
      {
        (ToolbarItemBase) this.MenuWindowsCascade,
        (ToolbarItemBase) this.MenuWindowsHorizontal,
        (ToolbarItemBase) this.MenuWindowsVertikal
      });
      this.MenuWindows.MdiWindowList = true;
      this.MenuWindowsCascade.BeginGroup = true;
      this.MenuWindowsCascade.Text = "Cascade";
      this.MenuWindowsHorizontal.BeginGroup = true;
      this.MenuWindowsHorizontal.Text = "Horizontal";
      this.MenuWindowsVertikal.BeginGroup = true;
      this.MenuWindowsVertikal.Text = "Vertical";
      this.MenuHelp.Items.AddRange(new ToolbarItemBase[2]
      {
        (ToolbarItemBase) this.MenuHelpItem1,
        (ToolbarItemBase) this.MenuHelpItem2
      });
      this.MenuHelpItem1.BeginGroup = true;
      this.MenuHelpItem2.BeginGroup = true;
      this.MenuHelpItem2.Text = "Tutorials";
      this.MenuAdmin.Items.AddRange(new ToolbarItemBase[2]
      {
        (ToolbarItemBase) this.MenuAdminItem1,
        (ToolbarItemBase) this.MenuAdminItem2
      });
      this.MenuAdmin.Text = "Admin";
      this.MenuAdmin.Visible = false;
      this.MenuAdminItem1.ImageIndex = 18;
      this.MenuAdminItem1.Text = "Icon-Extract";
      this.MenuAdminItem2.ImageIndex = 11;
      this.MenuAdminItem2.Text = "Language-Items";
      this.leftSandDock.Controls.Add((Control) this.dctToolbox);
      this.leftSandDock.Controls.Add((Control) this.DockControl1);
      this.leftSandDock.Dock = DockStyle.Left;
      DockContainer leftSandDock1 = this.leftSandDock;
      guid1 = new Guid("92d4c9f9-625b-44a9-8b0c-a318cfe4be2f");
      Guid guid3 = guid1;
      leftSandDock1.Guid = guid3;
      this.leftSandDock.LayoutSystem = new SplitLayoutSystem(250, 400, Orientation.Horizontal, new LayoutSystemBase[2]
      {
        (LayoutSystemBase) new ControlLayoutSystem(146, 285, new DockControl[1]
        {
          this.dctToolbox
        }, this.dctToolbox),
        (LayoutSystemBase) new ControlLayoutSystem(146, 227, new DockControl[1]
        {
          this.DockControl1
        }, this.DockControl1)
      });
      DockContainer leftSandDock2 = this.leftSandDock;
      point1 = new Point(0, 22);
      Point point3 = point1;
      leftSandDock2.Location = point3;
      this.leftSandDock.Manager = (SandDockManager) null;
      this.leftSandDock.Name = "leftSandDock";
      DockContainer leftSandDock3 = this.leftSandDock;
      size1 = new Size(150, 517);
      Size size4 = size1;
      leftSandDock3.Size = size4;
      this.leftSandDock.TabIndex = 4;
      this.dctToolbox.BorderStyle = TD.SandDock.Rendering.BorderStyle.Flat;
      this.dctToolbox.Closable = false;
      this.dctToolbox.Controls.Add((Control) this.MenuLabel10);
      this.dctToolbox.Controls.Add((Control) this.PictureBox10);
      this.dctToolbox.Controls.Add((Control) this.MenuLabel5);
      this.dctToolbox.Controls.Add((Control) this.MenuLabel4);
      this.dctToolbox.Controls.Add((Control) this.MenuLabel3);
      this.dctToolbox.Controls.Add((Control) this.MenuLabel2);
      this.dctToolbox.Controls.Add((Control) this.PictureBox5);
      this.dctToolbox.Controls.Add((Control) this.PictureBox4);
      this.dctToolbox.Controls.Add((Control) this.PictureBox3);
      this.dctToolbox.Controls.Add((Control) this.PictureBox2);
      this.dctToolbox.Floatable = false;
      DockControl dctToolbox1 = this.dctToolbox;
      guid1 = new Guid("d1d55771-cb52-492a-b1bd-af79be3a0135");
      Guid guid4 = guid1;
      dctToolbox1.Guid = guid4;
      DockControl dctToolbox2 = this.dctToolbox;
      point1 = new Point(0, 16);
      Point point4 = point1;
      dctToolbox2.Location = point4;
      this.dctToolbox.Name = "dctToolbox";
      DockControl dctToolbox3 = this.dctToolbox;
      size1 = new Size(146, 247);
      Size size5 = size1;
      dctToolbox3.Size = size5;
      this.dctToolbox.TabIndex = 0;
      this.dctToolbox.Text = "Toolbox";
      this.MenuLabel10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      Label menuLabel10_1 = this.MenuLabel10;
      point1 = new Point(1, 364);
      Point point5 = point1;
      menuLabel10_1.Location = point5;
      this.MenuLabel10.Name = "MenuLabel10";
      Label menuLabel10_2 = this.MenuLabel10;
      size1 = new Size(144, 16);
      Size size6 = size1;
      menuLabel10_2.Size = size6;
      this.MenuLabel10.TabIndex = 29;
      this.MenuLabel10.Text = "MenuLabel10";
      this.MenuLabel10.TextAlign = ContentAlignment.MiddleCenter;
      this.PictureBox10.BackColor = Color.Transparent;
      this.PictureBox10.Cursor = Cursors.Hand;
      this.PictureBox10.Image = (Image) resourceManager.GetObject("PictureBox10.Image");
      PictureBox pictureBox10_1 = this.PictureBox10;
      point1 = new Point(48, 316);
      Point point6 = point1;
      pictureBox10_1.Location = point6;
      this.PictureBox10.Name = "PictureBox10";
      PictureBox pictureBox10_2 = this.PictureBox10;
      size1 = new Size(50, 40);
      Size size7 = size1;
      pictureBox10_2.Size = size7;
      this.PictureBox10.SizeMode = PictureBoxSizeMode.AutoSize;
      this.PictureBox10.TabIndex = 28;
      this.PictureBox10.TabStop = false;
      this.MenuLabel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      Label menuLabel5_1 = this.MenuLabel5;
      point1 = new Point(1, 288);
      Point point7 = point1;
      menuLabel5_1.Location = point7;
      this.MenuLabel5.Name = "MenuLabel5";
      Label menuLabel5_2 = this.MenuLabel5;
      size1 = new Size(144, 16);
      Size size8 = size1;
      menuLabel5_2.Size = size8;
      this.MenuLabel5.TabIndex = 25;
      this.MenuLabel5.Text = "MenuLabel5";
      this.MenuLabel5.TextAlign = ContentAlignment.MiddleCenter;
      this.MenuLabel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      Label menuLabel4_1 = this.MenuLabel4;
      point1 = new Point(1, 136);
      Point point8 = point1;
      menuLabel4_1.Location = point8;
      this.MenuLabel4.Name = "MenuLabel4";
      Label menuLabel4_2 = this.MenuLabel4;
      size1 = new Size(144, 16);
      Size size9 = size1;
      menuLabel4_2.Size = size9;
      this.MenuLabel4.TabIndex = 24;
      this.MenuLabel4.Text = "MenuLabel4";
      this.MenuLabel4.TextAlign = ContentAlignment.MiddleCenter;
      this.MenuLabel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      Label menuLabel3_1 = this.MenuLabel3;
      point1 = new Point(1, 212);
      Point point9 = point1;
      menuLabel3_1.Location = point9;
      this.MenuLabel3.Name = "MenuLabel3";
      Label menuLabel3_2 = this.MenuLabel3;
      size1 = new Size(144, 16);
      Size size10 = size1;
      menuLabel3_2.Size = size10;
      this.MenuLabel3.TabIndex = 23;
      this.MenuLabel3.Text = "MenuLabel3";
      this.MenuLabel3.TextAlign = ContentAlignment.MiddleCenter;
      this.MenuLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      Label menuLabel2_1 = this.MenuLabel2;
      point1 = new Point(1, 60);
      Point point10 = point1;
      menuLabel2_1.Location = point10;
      this.MenuLabel2.Name = "MenuLabel2";
      Label menuLabel2_2 = this.MenuLabel2;
      size1 = new Size(144, 16);
      Size size11 = size1;
      menuLabel2_2.Size = size11;
      this.MenuLabel2.TabIndex = 22;
      this.MenuLabel2.Text = "MenuLabel2";
      this.MenuLabel2.TextAlign = ContentAlignment.MiddleCenter;
      this.PictureBox5.BackColor = Color.Transparent;
      this.PictureBox5.Cursor = Cursors.Hand;
      this.PictureBox5.Image = (Image) resourceManager.GetObject("PictureBox5.Image");
      PictureBox pictureBox5_1 = this.PictureBox5;
      point1 = new Point(48, 240);
      Point point11 = point1;
      pictureBox5_1.Location = point11;
      this.PictureBox5.Name = "PictureBox5";
      PictureBox pictureBox5_2 = this.PictureBox5;
      size1 = new Size(50, 40);
      Size size12 = size1;
      pictureBox5_2.Size = size12;
      this.PictureBox5.SizeMode = PictureBoxSizeMode.AutoSize;
      this.PictureBox5.TabIndex = 21;
      this.PictureBox5.TabStop = false;
      this.PictureBox4.BackColor = Color.Transparent;
      this.PictureBox4.Cursor = Cursors.Hand;
      this.PictureBox4.Image = (Image) resourceManager.GetObject("PictureBox4.Image");
      PictureBox pictureBox4_1 = this.PictureBox4;
      point1 = new Point(48, 88);
      Point point12 = point1;
      pictureBox4_1.Location = point12;
      this.PictureBox4.Name = "PictureBox4";
      PictureBox pictureBox4_2 = this.PictureBox4;
      size1 = new Size(50, 40);
      Size size13 = size1;
      pictureBox4_2.Size = size13;
      this.PictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
      this.PictureBox4.TabIndex = 20;
      this.PictureBox4.TabStop = false;
      this.PictureBox3.BackColor = Color.Transparent;
      this.PictureBox3.Cursor = Cursors.Hand;
      this.PictureBox3.Image = (Image) resourceManager.GetObject("PictureBox3.Image");
      PictureBox pictureBox3_1 = this.PictureBox3;
      point1 = new Point(48, 164);
      Point point13 = point1;
      pictureBox3_1.Location = point13;
      this.PictureBox3.Name = "PictureBox3";
      PictureBox pictureBox3_2 = this.PictureBox3;
      size1 = new Size(50, 40);
      Size size14 = size1;
      pictureBox3_2.Size = size14;
      this.PictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
      this.PictureBox3.TabIndex = 19;
      this.PictureBox3.TabStop = false;
      this.PictureBox2.BackColor = Color.Transparent;
      this.PictureBox2.Cursor = Cursors.Hand;
      this.PictureBox2.Image = (Image) resourceManager.GetObject("PictureBox2.Image");
      PictureBox pictureBox2_1 = this.PictureBox2;
      point1 = new Point(46, 12);
      Point point14 = point1;
      pictureBox2_1.Location = point14;
      this.PictureBox2.Name = "PictureBox2";
      PictureBox pictureBox2_2 = this.PictureBox2;
      size1 = new Size(50, 40);
      Size size15 = size1;
      pictureBox2_2.Size = size15;
      this.PictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
      this.PictureBox2.TabIndex = 18;
      this.PictureBox2.TabStop = false;
      this.DockControl1.BorderStyle = TD.SandDock.Rendering.BorderStyle.Flat;
      this.DockControl1.Closable = false;
      this.DockControl1.Controls.Add((Control) this.MenuLabel9);
      this.DockControl1.Controls.Add((Control) this.PictureBox9);
      this.DockControl1.Controls.Add((Control) this.MenuLabel8);
      this.DockControl1.Controls.Add((Control) this.PictureBox8);
      this.DockControl1.Controls.Add((Control) this.MenuLabel7);
      this.DockControl1.Controls.Add((Control) this.PictureBox7);
      this.DockControl1.Controls.Add((Control) this.MenuLabel6);
      this.DockControl1.Controls.Add((Control) this.PictureBox6);
      DockControl dockControl1_1 = this.DockControl1;
      guid1 = new Guid("c891a63e-9b65-4a13-9541-587cef1bd2e0");
      Guid guid5 = guid1;
      dockControl1_1.Guid = guid5;
      DockControl dockControl1_2 = this.DockControl1;
      point1 = new Point(0, 306);
      Point point15 = point1;
      dockControl1_2.Location = point15;
      this.DockControl1.Name = "DockControl1";
      DockControl dockControl1_3 = this.DockControl1;
      size1 = new Size(146, 188);
      Size size16 = size1;
      dockControl1_3.Size = size16;
      this.DockControl1.TabIndex = 1;
      this.DockControl1.Text = "DockControl1";
      this.MenuLabel9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      Label menuLabel9_1 = this.MenuLabel9;
      point1 = new Point(1, 304);
      Point point16 = point1;
      menuLabel9_1.Location = point16;
      this.MenuLabel9.Name = "MenuLabel9";
      Label menuLabel9_2 = this.MenuLabel9;
      size1 = new Size(144, 16);
      Size size17 = size1;
      menuLabel9_2.Size = size17;
      this.MenuLabel9.TabIndex = 37;
      this.MenuLabel9.Text = "MenuLabel9";
      this.MenuLabel9.TextAlign = ContentAlignment.MiddleCenter;
      this.PictureBox9.BackColor = Color.Transparent;
      this.PictureBox9.Cursor = Cursors.Hand;
      this.PictureBox9.Image = (Image) resourceManager.GetObject("PictureBox9.Image");
      PictureBox pictureBox9_1 = this.PictureBox9;
      point1 = new Point(52, 256);
      Point point17 = point1;
      pictureBox9_1.Location = point17;
      this.PictureBox9.Name = "PictureBox9";
      PictureBox pictureBox9_2 = this.PictureBox9;
      size1 = new Size(50, 40);
      Size size18 = size1;
      pictureBox9_2.Size = size18;
      this.PictureBox9.SizeMode = PictureBoxSizeMode.AutoSize;
      this.PictureBox9.TabIndex = 36;
      this.PictureBox9.TabStop = false;
      this.MenuLabel8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      Label menuLabel8_1 = this.MenuLabel8;
      point1 = new Point(1, 224);
      Point point18 = point1;
      menuLabel8_1.Location = point18;
      this.MenuLabel8.Name = "MenuLabel8";
      Label menuLabel8_2 = this.MenuLabel8;
      size1 = new Size(144, 16);
      Size size19 = size1;
      menuLabel8_2.Size = size19;
      this.MenuLabel8.TabIndex = 35;
      this.MenuLabel8.Text = "MenuLabel8";
      this.MenuLabel8.TextAlign = ContentAlignment.MiddleCenter;
      this.PictureBox8.BackColor = Color.Transparent;
      this.PictureBox8.Cursor = Cursors.Hand;
      this.PictureBox8.Image = (Image) resourceManager.GetObject("PictureBox8.Image");
      PictureBox pictureBox8_1 = this.PictureBox8;
      point1 = new Point(52, 173);
      Point point19 = point1;
      pictureBox8_1.Location = point19;
      this.PictureBox8.Name = "PictureBox8";
      PictureBox pictureBox8_2 = this.PictureBox8;
      size1 = new Size(50, 40);
      Size size20 = size1;
      pictureBox8_2.Size = size20;
      this.PictureBox8.SizeMode = PictureBoxSizeMode.AutoSize;
      this.PictureBox8.TabIndex = 34;
      this.PictureBox8.TabStop = false;
      this.MenuLabel7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      Label menuLabel7_1 = this.MenuLabel7;
      point1 = new Point(1, 64);
      Point point20 = point1;
      menuLabel7_1.Location = point20;
      this.MenuLabel7.Name = "MenuLabel7";
      Label menuLabel7_2 = this.MenuLabel7;
      size1 = new Size(144, 16);
      Size size21 = size1;
      menuLabel7_2.Size = size21;
      this.MenuLabel7.TabIndex = 33;
      this.MenuLabel7.Text = "MenuLabel7";
      this.MenuLabel7.TextAlign = ContentAlignment.MiddleCenter;
      this.PictureBox7.BackColor = Color.Transparent;
      this.PictureBox7.Cursor = Cursors.Hand;
      this.PictureBox7.Image = (Image) resourceManager.GetObject("PictureBox7.Image");
      PictureBox pictureBox7_1 = this.PictureBox7;
      point1 = new Point(52, 16);
      Point point21 = point1;
      pictureBox7_1.Location = point21;
      this.PictureBox7.Name = "PictureBox7";
      PictureBox pictureBox7_2 = this.PictureBox7;
      size1 = new Size(50, 40);
      Size size22 = size1;
      pictureBox7_2.Size = size22;
      this.PictureBox7.SizeMode = PictureBoxSizeMode.AutoSize;
      this.PictureBox7.TabIndex = 32;
      this.PictureBox7.TabStop = false;
      this.MenuLabel6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      Label menuLabel6_1 = this.MenuLabel6;
      point1 = new Point(1, 144);
      Point point22 = point1;
      menuLabel6_1.Location = point22;
      this.MenuLabel6.Name = "MenuLabel6";
      Label menuLabel6_2 = this.MenuLabel6;
      size1 = new Size(144, 16);
      Size size23 = size1;
      menuLabel6_2.Size = size23;
      this.MenuLabel6.TabIndex = 31;
      this.MenuLabel6.Text = "MenuLabel6";
      this.MenuLabel6.TextAlign = ContentAlignment.MiddleCenter;
      this.PictureBox6.BackColor = Color.Transparent;
      this.PictureBox6.Cursor = Cursors.Hand;
      this.PictureBox6.Image = (Image) resourceManager.GetObject("PictureBox6.Image");
      PictureBox pictureBox6_1 = this.PictureBox6;
      point1 = new Point(52, 96);
      Point point23 = point1;
      pictureBox6_1.Location = point23;
      this.PictureBox6.Name = "PictureBox6";
      PictureBox pictureBox6_2 = this.PictureBox6;
      size1 = new Size(50, 40);
      Size size24 = size1;
      pictureBox6_2.Size = size24;
      this.PictureBox6.SizeMode = PictureBoxSizeMode.AutoSize;
      this.PictureBox6.TabIndex = 30;
      this.PictureBox6.TabStop = false;
      StatusBar statusBar1_1 = this.StatusBar1;
      point1 = new Point(0, 539);
      Point point24 = point1;
      statusBar1_1.Location = point24;
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
      Size size25 = size1;
      statusBar1_2.Size = size25;
      this.StatusBar1.TabIndex = 6;
      this.StatusBar1.Text = "Ready";
      this.StatusBarPanel2.Text = "Ready";
      this.StatusBarPanel3.AutoSize = StatusBarPanelAutoSize.Spring;
      this.StatusBarPanel3.Width = 634;
      this.StatusBarPanel1.Alignment = HorizontalAlignment.Right;
      this.StatusBarPanel1.Width = 32;
      size1 = new Size(5, 13);
      this.AutoScaleBaseSize = size1;
      this.BackgroundImage = (Image) resourceManager.GetObject("$this.BackgroundImage");
      size1 = new Size(782, 563);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.leftSandDock);
      this.Controls.Add((Control) this.MenuBar1);
      this.Controls.Add((Control) this.StatusBar1);
      this.Icon = (Icon) resourceManager.GetObject("$this.Icon");
      this.IsMdiContainer = true;
      this.Name = nameof (FormMain);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Form1";
      this.WindowState = FormWindowState.Maximized;
      this.leftSandDock.ResumeLayout(false);
      this.dctToolbox.ResumeLayout(false);
      this.DockControl1.ResumeLayout(false);
      this.StatusBarPanel2.EndInit();
      this.StatusBarPanel3.EndInit();
      this.StatusBarPanel1.EndInit();
      this.ResumeLayout(false);
    }

    private object GetAllTutorialFiles()
    {
      int index1 = 0;
      string path = Application.StartupPath.ToString() + "\\Tutorial";
      string searchPattern = "sc4tool_tutorial_*.htm";
      if (new DirectoryInfo(path).Exists)
      {
        string[] files = Directory.GetFiles(path, searchPattern);
        int index2 = 0;
        while (index2 < files.Length)
        {
          FileInfo fileInfo = new FileInfo(files[index2]);
          ClassThisProg.DefReader.TutorialFileArray.Add((object) fileInfo.FullName);
          string str = fileInfo.Name.Replace(fileInfo.Extension, "").Replace("sc4tool_tutorial_", "");
          MenuButtonItem[] menuButtonItemArray = new MenuButtonItem[checked (index1 + 1)];
          menuButtonItemArray[index1] = new MenuButtonItem();
          menuButtonItemArray[index1].Text = str;
          menuButtonItemArray[index1].BeginGroup = true;
          menuButtonItemArray[index1].Tag = (object) index1.ToString();
          this.MenuHelpItem2.Items.Add((ToolbarItemBase) menuButtonItemArray[index1]);
          menuButtonItemArray[index1].Activate += new EventHandler(this.MenuTutorialItem_Activate);
          checked { ++index1; }
          checked { ++index2; }
        }
      }
      object obj;
      return obj;
    }

    private object GetAllLanguageFiles()
    {
      if (ClassThisProg.DefReader.LanguageFileArray.Count > 0)
      {
        int num = checked (ClassThisProg.DefReader.LanguageFileArray.Count - 1);
        int index = 0;
        while (index <= num)
        {
          if (ObjectType.ObjTst(LateBinding.LateGet(ClassThisProg.DefReader.LanguageFileArray[index], (System.Type) null, "toupper", new object[0], (string[]) null, (bool[]) null), (object) "DEFAULT", false) != 0)
          {
            MenuButtonItem[] menuButtonItemArray = new MenuButtonItem[checked (index + 1)];
            menuButtonItemArray[index] = new MenuButtonItem();
            menuButtonItemArray[index].Text = StringType.FromObject(ClassThisProg.DefReader.LanguageFileArray[index]);
            menuButtonItemArray[index].BeginGroup = true;
            menuButtonItemArray[index].Tag = (object) index.ToString();
            if (ObjectType.ObjTst(ClassThisProg.DefReader.LanguageIconArray[index], (object) "", false) != 0)
            {
              Loader loader = new Loader();
              menuButtonItemArray[index].Image = loader.GetImageFromResource(StringType.FromObject(ClassThisProg.DefReader.LanguageIconArray[index]));
              loader.Dispose();
            }
            this.MenuOptionenLanguage.Items.Add((ToolbarItemBase) menuButtonItemArray[index]);
            menuButtonItemArray[index].Activate += new EventHandler(this.MenuLanguageItem_Activate);
          }
          checked { ++index; }
        }
      }
      object obj;
      return obj;
    }

    private object SetzeTexte()
    {
      this.MenuDatei.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[2]);
      this.MenuDateiItem1.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[3]);
      this.MenuTools.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[511]);
      this.dctToolbox.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[511]);
      this.DockControl1.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[42]);
      this.MenuToolsItem1.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[45]);
      this.MenuToolsItem2.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[379]);
      this.MenuToolsItem3.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[46]);
      this.MenuToolsItem4.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[313]);
      this.MenuToolsItem5.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[429]);
      this.MenuToolsItem6.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[434]);
      this.MenuToolsItem7.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[470]);
      this.MenuToolsItem8.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[502]);
      this.MenuToolsItem9.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[478]);
      this.MenuToolsItem10.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[558]);
      this.MenuPlugIns.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[42]);
      this.MenuOptionen.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[29]);
      this.MenuOptionenLanguage.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[4]);
      this.MenuOptionenSettings.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[32]);
      this.MenuOptionenColors.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[14]);
      this.MenuOptionenColors1.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[43]);
      this.MenuOptionenColors2.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[44]);
      this.MenuWindows.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[36]);
      this.MenuHelp.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[37]);
      this.MenuHelpItem1.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[38]);
      this.MenuLabel2.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[45]);
      this.MenuLabel3.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[46]);
      this.MenuLabel4.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[379]);
      this.MenuLabel5.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[313]);
      this.MenuLabel6.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[429]);
      this.MenuLabel7.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[434]);
      this.MenuLabel8.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[470]);
      this.MenuLabel9.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[502]);
      this.MenuLabel10.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[478]);
      this.MenuExtras.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[519]);
      this.MenuExtrasItem1.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[41]);
      this.MenuExtrasItem2.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[395]);
      this.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[28]);
      this.MenuWindowsCascade.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[387]);
      this.MenuWindowsHorizontal.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[388]);
      this.MenuWindowsVertikal.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[389]);
      this.ToolTip1.SetToolTip((Control) this.PictureBox2, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[301]));
      this.ToolTip1.SetToolTip((Control) this.PictureBox4, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[316]));
      this.ToolTip1.SetToolTip((Control) this.PictureBox3, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[302]));
      this.ToolTip1.SetToolTip((Control) this.PictureBox5, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[315]));
      this.ToolTip1.SetToolTip((Control) this.PictureBox6, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[428]));
      this.ToolTip1.SetToolTip((Control) this.PictureBox7, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[460]));
      object obj;
      return obj;
    }

    private void FormMain_Load(object sender, EventArgs e)
    {
      string text = "HKEY_CURRENT_USER\\Control Panel\\Desktop\\MenuShowDelay =0\n" + "This causes problems to menu functionality.\n" + "Please change the value to something > 0";
      if (ObjectType.ObjTst(LateBinding.LateGet(ClassThisProg.DefReader.User, (System.Type) null, "toupper", new object[0], (string[]) null, (bool[]) null), (object) "ADMIN@SC4TOOL", false) == 0)
        this.MenuAdmin.Visible = true;
      this.dctToolbox.LayoutSystem.Collapsed = true;
      this.dctToolbox.BackColor = ClassThisProg.DefReader.simsZoneBeige;
      this.DockControl1.LayoutSystem.Collapsed = true;
      this.DockControl1.BackColor = ClassThisProg.DefReader.simsZoneBeige;
      if (StringType.StrCmp(ClassThisProg.DefReader.FarbSchema, "LunaBlue", false) == 0)
      {
        this.MenuOptionenColors1.Checked = true;
        this.MenuOptionenColors2.Checked = false;
      }
      else
      {
        this.MenuOptionenColors1.Checked = false;
        this.MenuOptionenColors2.Checked = true;
      }
      sr_Userinterface.AendereFarben((Form) this, ClassThisProg.DefReader.FarbSchema);
      this.GetAllTutorialFiles();
      this.MenuToolsItem1.Enabled = ClassThisProg.DefReader.isDatabaseOpen;
      this.PictureBox2.Enabled = ClassThisProg.DefReader.isDatabaseOpen;
      this.GetAllLanguageFiles();
      this.SetzeTexte();
      Loader loader = new Loader();
      this.StatusBarPanel1.Icon = loader.GetIconFromResource(StringType.FromObject(ClassThisProg.DefReader.LanguageIconArray[ClassThisProg.DefReader.AktuellerLanguageIndex]));
      loader.Dispose();
      this.Show();
      if (ClassThisProg.DefReader.CheckRegKey() == 0)
      {
        this.StatusBarPanel3.Text = "Warning!";
        this.StatusBarPanel3.Icon = loader.GetIconFromResource("MSGBOX01.ICO");
        int num = (int) MessageBox.Show((IWin32Window) this, text, "Caution", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      if (ClassThisProg.DefReader.ShowIntro)
      {
        if (ClassThisProg.frmIntro != null)
          return;
        ClassThisProg.frmIntro = new FormIntro();
        ClassThisProg.frmIntro.MdiParent = (Form) this;
        ClassThisProg.frmIntro.Show();
      }
      else
      {
        switch (ClassThisProg.DefReader.StartupProgramm)
        {
          case 0:
            if (ClassThisProg.frmIntro == null)
            {
              ClassThisProg.frmIntro = new FormIntro();
              ClassThisProg.frmIntro.MdiParent = (Form) this;
              ClassThisProg.frmIntro.Show();
              break;
            }
            break;
          case 1:
            this.LadeFormForm1();
            break;
          case 2:
            this.LadeFormFormReferenz();
            break;
          case 3:
            this.LadeFormBAT();
            break;
          case 4:
            this.LadeFormForm8();
            break;
          case 5:
            this.LadeFormLotEditor();
            break;
          case 6:
            this.LadeFormTM();
            break;
          case 7:
            this.LadeFormCompare();
            break;
          case 8:
            this.LadeFormEditor();
            break;
          case 9:
            this.LadeFormDepScanner();
            break;
          case 10:
            this.LadeFormMerger();
            break;
          default:
            if (ClassThisProg.frmIntro == null)
            {
              ClassThisProg.frmIntro = new FormIntro();
              ClassThisProg.frmIntro.MdiParent = (Form) this;
              ClassThisProg.frmIntro.Show();
            }
            break;
        }
      }
    }

    private void MenuTutorialItem_Activate(object sender, EventArgs e)
    {
      if (!Information.IsNumeric(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(sender, (System.Type) null, "tag", new object[0], (string[]) null, (bool[]) null))))
        return;
      string str = StringType.FromObject(ClassThisProg.DefReader.TutorialFileArray[IntegerType.FromObject(LateBinding.LateGet(sender, (System.Type) null, "tag", new object[0], (string[]) null, (bool[]) null))]);
      if (new FileInfo(str).Exists)
      {
        try
        {
          Shell.OpenFile(str);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
    }

    private void MenuLanguageItem_Activate(object sender, EventArgs e)
    {
      if (ClassThisProg.frmLanguage != null)
      {
        int num1 = (int) MessageBox.Show((IWin32Window) this, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[53]), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[41]), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      else if (Information.IsNumeric(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(sender, (System.Type) null, "tag", new object[0], (string[]) null, (bool[]) null))))
      {
        this.Cursor = Cursors.WaitCursor;
        string LanguageFile = StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj((object) (ClassThisProg.DefReader.LanguageDir + "\\"), ClassThisProg.DefReader.LanguageFileArray[IntegerType.FromObject(LateBinding.LateGet(sender, (System.Type) null, "tag", new object[0], (string[]) null, (bool[]) null))]), (object) ".xml"));
        if (!ClassThisProg.DefReader.SetLanguage(LanguageFile))
        {
          string text = "Error reading Language-File!";
          this.Cursor = Cursors.Default;
          int num2 = (int) MessageBox.Show((IWin32Window) this, text, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        else
        {
          ClassThisProg.DefReader.AktuellerLanguageIndex = IntegerType.FromObject(LateBinding.LateGet(sender, (System.Type) null, "tag", new object[0], (string[]) null, (bool[]) null));
          ClassThisProg.DefReader.SaveSettings();
          Loader loader = new Loader();
          this.StatusBarPanel1.Icon = loader.GetIconFromResource(StringType.FromObject(ClassThisProg.DefReader.LanguageIconArray[ClassThisProg.DefReader.AktuellerLanguageIndex]));
          loader.Dispose();
          this.SetzeTexte();
          if (ClassThisProg.frmForm1 != null)
            ClassThisProg.frmForm1.SetzeTexte();
          if (ClassThisProg.frmLayout != null)
            ClassThisProg.frmLayout.SetzeTexte();
          if (ClassThisProg.frmBAT != null)
            ClassThisProg.frmBAT.SetzeTexte();
          if (ClassThisProg.frmIntro != null)
            ClassThisProg.frmIntro.SetzeTexte();
          if (ClassThisProg.frmAbout != null)
            ClassThisProg.frmAbout.SetzeTexte();
          if (ClassThisProg.frmForm8 != null)
            ClassThisProg.frmForm8.SetzeTexte();
          if (ClassThisProg.frmProp != null)
            ClassThisProg.frmProp.SetzeTexte();
          if (ClassThisProg.frmLotEditor != null)
            ClassThisProg.frmLotEditor.SetzeTexte();
          if (ClassThisProg.frmTM != null)
            ClassThisProg.frmTM.SetzeTexte();
          if (ClassThisProg.frmTextureMaker != null)
            ClassThisProg.frmTextureMaker.SetzeTexte();
          if (ClassThisProg.frmTransitSwitch != null)
            ClassThisProg.frmTransitSwitch.SetzeTexte();
          if (ClassThisProg.frmEditTransit != null)
            ClassThisProg.frmEditTransit.SetzeTexte();
          if (ClassThisProg.frmCompare != null)
            ClassThisProg.frmCompare.SetzeTexte();
          if (ClassThisProg.frmEditor != null)
            ClassThisProg.frmEditor.SetzeTexte();
          if (ClassThisProg.frmDepScanner != null)
            ClassThisProg.frmDepScanner.SetzeTexte();
          if (ClassThisProg.frmMerger != null)
            ClassThisProg.frmMerger.SetzeTexte();
          this.Cursor = Cursors.Default;
        }
      }
    }

    private void MenuOptionenSettings_Activate(object sender, EventArgs e) => this.LadeFormLayout();

    private void MenuDateiItem1_Activate(object sender, EventArgs e) => ProjectData.EndApp();

    private void MenuOptionenColors1_Activate(object sender, EventArgs e)
    {
      ClassThisProg.DefReader.FarbSchema = "LunaBlue";
      sr_Userinterface.AendereFarben((Form) this, ClassThisProg.DefReader.FarbSchema);
      ClassThisProg.DefReader.SaveSettings();
      this.MenuOptionenColors1.Checked = true;
      this.MenuOptionenColors2.Checked = false;
    }

    private void MenuOptionenColors2_Activate(object sender, EventArgs e)
    {
      ClassThisProg.DefReader.FarbSchema = "Standard";
      sr_Userinterface.AendereFarben((Form) this, ClassThisProg.DefReader.FarbSchema);
      ClassThisProg.DefReader.SaveSettings();
      this.MenuOptionenColors1.Checked = false;
      this.MenuOptionenColors2.Checked = true;
    }

    private void MenuToolsItem1_Activate(object sender, EventArgs e) => this.LadeFormForm1();

    private void MenuToolsItem2_Activate(object sender, EventArgs e)
    {
      if (StringType.StrCmp(ClassThisProg.DefReader.SC4RefDatei, "", false) == 0)
        return;
      this.LadeFormFormReferenz();
    }

    private void MenuToolsItem3_Activate(object sender, EventArgs e) => this.LadeFormBAT();

    private void MenuToolsItem4_Activate(object sender, EventArgs e) => this.LadeFormForm8();

    private void MenuToolsItem5_Activate(object sender, EventArgs e) => this.LadeFormLotEditor();

    private void MenuToolsItem6_Activate(object sender, EventArgs e) => this.LadeFormTM();

    private void MenuToolsItem7_Activate(object sender, EventArgs e) => this.LadeFormCompare();

    private void MenuToolsItem8_Activate(object sender, EventArgs e) => this.LadeFormEditor();

    private void MenuToolsItem9_Activate(object sender, EventArgs e) => this.LadeFormDepScanner();

    private void MenuToolsItem10_Activate(object sender, EventArgs e) => this.LadeFormMerger();

    public object LadeFormMerger()
    {
      if (ClassThisProg.frmMerger == null)
      {
        this.Cursor = Cursors.WaitCursor;
        ClassThisProg.frmMerger = new FormFileMerger();
        ClassThisProg.frmMerger.MdiParent = (Form) this;
        ClassThisProg.frmMerger.Show();
        this.Cursor = Cursors.Default;
      }
      else
        ClassThisProg.frmMerger.Focus();
      object obj;
      return obj;
    }

    public object LadeFormDepScanner()
    {
      if (ClassThisProg.frmDepScanner == null)
      {
        ClassThisProg.frmDepScanner = new FormDepScanner();
        ClassThisProg.frmDepScanner.MdiParent = (Form) this;
        ClassThisProg.frmDepScanner.Show();
      }
      else
        ClassThisProg.frmDepScanner.Focus();
      object obj;
      return obj;
    }

    public object LadeFormEditor()
    {
      if (ClassThisProg.frmEditor == null)
      {
        ClassThisProg.frmEditor = new FormEditor();
        ClassThisProg.frmEditor.MdiParent = (Form) this;
        ClassThisProg.frmEditor.Show();
      }
      else
        ClassThisProg.frmEditor.Focus();
      object obj;
      return obj;
    }

    public object LadeFormCompare()
    {
      if (ClassThisProg.frmCompare == null)
      {
        ClassThisProg.frmCompare = new FormCompare();
        ClassThisProg.frmCompare.MdiParent = (Form) this;
        ClassThisProg.frmCompare.Show();
      }
      else
        ClassThisProg.frmCompare.Focus();
      object obj;
      return obj;
    }

    public object LadeFormTM()
    {
      if (ClassThisProg.frmTM == null)
      {
        ClassThisProg.frmTM = new FormTM();
        ClassThisProg.frmTM.MdiParent = (Form) this;
        ClassThisProg.frmTM.Show();
      }
      else
        ClassThisProg.frmTM.Focus();
      object obj;
      return obj;
    }

    public object LadeFormFormReferenz()
    {
      if (ClassThisProg.frmReferenz == null)
      {
        ClassThisProg.frmReferenz = new FormReferenz();
        ClassThisProg.frmReferenz.MdiParent = (Form) this;
        ClassThisProg.frmReferenz.Show();
      }
      else
        ClassThisProg.frmReferenz.Focus();
      object obj;
      return obj;
    }

    public object LadeFormFormProp()
    {
      if (ClassThisProg.frmProp == null)
      {
        ClassThisProg.frmProp = new PropViewForm();
        ClassThisProg.frmProp.MdiParent = (Form) this;
        ClassThisProg.frmProp.Show();
      }
      else
        ClassThisProg.frmProp.Focus();
      object obj;
      return obj;
    }

    public object LadeFormForm8()
    {
      if (StringType.StrCmp(ClassThisProg.DefReader.SC4Path, "", false) == 0)
        this.LadeFormLayout();
      else if (ClassThisProg.frmForm8 == null)
      {
        ClassThisProg.frmForm8 = new Form8();
        ClassThisProg.frmForm8.MdiParent = (Form) this;
        ClassThisProg.frmForm8.Show();
      }
      else
        ClassThisProg.frmForm8.Focus();
      object obj;
      return obj;
    }

    public object LadeFormForm1()
    {
      if (!ClassThisProg.DefReader.isDatabaseOpen)
      {
        int num = (int) MessageBox.Show((IWin32Window) this, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[24]), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      else if (ClassThisProg.frmForm1 == null)
      {
        ClassThisProg.frmForm1 = new FormDB();
        ClassThisProg.frmForm1.MdiParent = (Form) this;
        ClassThisProg.frmForm1.Show();
      }
      else
        ClassThisProg.frmForm1.Focus();
      object obj;
      return obj;
    }

    public object LadeFormLotEditor()
    {
      if (StringType.StrCmp(ClassThisProg.DefReader.SC4Path, "", false) == 0)
        this.LadeFormLayout();
      else if (ClassThisProg.frmLotEditor == null)
      {
        ClassThisProg.frmLotEditor = new FormLotEditor();
        ClassThisProg.frmLotEditor.MdiParent = (Form) this;
        ClassThisProg.frmLotEditor.Show();
      }
      else
        ClassThisProg.frmLotEditor.Focus();
      object obj;
      return obj;
    }

    public object LadeFormBAT()
    {
      if (StringType.StrCmp(ClassThisProg.DefReader.SC4Path, "", false) == 0)
        this.LadeFormLayout();
      else if (ClassThisProg.frmBAT == null)
      {
        ClassThisProg.frmBAT = new FormBAT();
        ClassThisProg.frmBAT.MdiParent = (Form) this;
        ClassThisProg.frmBAT.Show();
      }
      else
        ClassThisProg.frmBAT.Focus();
      object obj;
      return obj;
    }

    public object LadeFormLanguage()
    {
      if (ClassThisProg.frmLanguage == null)
      {
        ClassThisProg.frmLanguage = new FormLanguage();
        ClassThisProg.frmLanguage.MdiParent = (Form) this;
        ClassThisProg.frmLanguage.Show();
      }
      else
        ClassThisProg.frmLanguage.Focus();
      object obj;
      return obj;
    }

    public object LadeFormLayout()
    {
      if (ClassThisProg.frmLayout == null)
      {
        ClassThisProg.frmLayout = new FormLayout();
        ClassThisProg.frmLayout.MdiParent = (Form) this;
        ClassThisProg.frmLayout.Show();
      }
      else
        ClassThisProg.frmLayout.Focus();
      object obj;
      return obj;
    }

    public object LadeFormAbout()
    {
      if (ClassThisProg.frmAbout == null)
      {
        ClassThisProg.frmAbout = new FormAbout();
        ClassThisProg.frmAbout.MdiParent = (Form) this;
        ClassThisProg.frmAbout.Show();
      }
      else
        ClassThisProg.frmAbout.Focus();
      object obj;
      return obj;
    }

    private void PictureBox2_Click(object sender, EventArgs e) => this.LadeFormForm1();

    private void PictureBox3_Click(object sender, EventArgs e) => this.LadeFormBAT();

    private void PictureBox4_Click(object sender, EventArgs e) => this.LadeFormFormReferenz();

    private void PictureBox5_Click(object sender, EventArgs e) => this.LadeFormForm8();

    private void PictureBox6_Click(object sender, EventArgs e) => this.LadeFormLotEditor();

    private void PictureBox7_Click(object sender, EventArgs e) => this.LadeFormTM();

    private void PictureBox8_Click(object sender, EventArgs e) => this.LadeFormCompare();

    private void PictureBox9_Click(object sender, EventArgs e) => this.LadeFormEditor();

    private void PictureBox10_Click(object sender, EventArgs e) => this.LadeFormDepScanner();

    private void MenuHelpItem1_Activate(object sender, EventArgs e) => this.LadeFormAbout();

    private void MenuWindowsCascade_Activate(object sender, EventArgs e) => this.LayoutMdi(MdiLayout.Cascade);

    private void MenuWindowsHorizontal_Activate(object sender, EventArgs e) => this.LayoutMdi(MdiLayout.TileHorizontal);

    private void MenuWindowsVertikal_Activate(object sender, EventArgs e) => this.LayoutMdi(MdiLayout.TileVertical);

    private void MenuExtrasItem1_Activate(object sender, EventArgs e) => this.LadeFormLanguage();

    private void MenuExtrasItem2_Activate(object sender, EventArgs e) => this.LadeFormFormProp();

    private void MenuAdminItem2_Activate(object sender, EventArgs e)
    {
      int num = checked (ClassThisProg.DefReader.LanguageArray.Count - 1);
      int index = 0;
      while (index <= num)
      {
        ClassThisProg.DefReader.LanguageArray[index] = ObjectType.StrCatObj((object) (index.ToString() + " - "), ClassThisProg.DefReader.LanguageArray[index]);
        checked { ++index; }
      }
      this.SetzeTexte();
    }

    private void MenuAdminItem1_Activate(object sender, EventArgs e)
    {
      int Counter = 0;
      this.LeseControl("ImageList1.ImageStream", new ResourceManager(typeof (FormMain)), ref Counter);
      this.LeseControl("ImageList1.ImageStream", new ResourceManager(typeof (FormLayout)), ref Counter);
      this.LeseControl("ImageList1.ImageStream", new ResourceManager(typeof (FormBAT)), ref Counter);
      this.LeseControl("ImageList1.ImageStream", new ResourceManager(typeof (FormDB)), ref Counter);
      this.LeseControl("ImageList1.ImageStream", new ResourceManager(typeof (FormDB)), ref Counter);
      this.LeseControl("ImageList1.ImageStream", new ResourceManager(typeof (FormDepScanner)), ref Counter);
      this.LeseControl("ImageList1.ImageStream", new ResourceManager(typeof (FormDepScanner)), ref Counter);
      this.LeseControl("ImageList1.ImageStream", new ResourceManager(typeof (FormEditor)), ref Counter);
      this.LeseControl("ImageList1.ImageStream", new ResourceManager(typeof (FormLanguage)), ref Counter);
      this.LeseControl("ImageList1.ImageStream", new ResourceManager(typeof (FormTextureMaker)), ref Counter);
      this.LeseControl("ImageList2.ImageStream", new ResourceManager(typeof (FormTM)), ref Counter);
    }

    private object LeseControl(string TestString, ResourceManager resources, ref int Counter)
    {
      this.ExtractIcons(new ImageList()
      {
        ImageStream = (ImageListStreamer) resources.GetObject(TestString)
      }, ref Counter);
      object obj;
      return obj;
    }

    private object ExtractIcons(ImageList SuchControl, ref int Counter)
    {
      int num = checked (SuchControl.Images.Count - 1);
      int index = 0;
      while (index <= num)
      {
        string filename = Application.StartupPath.ToString() + "\\Export\\" + Counter.ToString() + ".PNG";
        SuchControl.Images[index].Save(filename, ImageFormat.Png);
        checked { ++Counter; }
        checked { ++index; }
      }
      object obj;
      return obj;
    }
  }
}
