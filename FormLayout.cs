// Decompiled with JetBrains decompiler
// Type: SC4Tool.FormLayout
// Assembly: SC4Tool, Version=2.2.7.0, Culture=neutral, PublicKeyToken=null
// MVID: 69A50BC4-87A5-4C5E-BEFC-08274BC6D498
// Assembly location: C:\Program Files (x86)\SC4 Utilities\SC4Tool\SC4Tool.exe

using Microsoft.VisualBasic.CompilerServices;
using sr_SC4Lib;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using TD.SandBar;
using TD.SandDock;

namespace SC4Tool
{
  public class FormLayout : Form
  {
    [AccessedThroughProperty("RadioButton2")]
    private RadioButton _RadioButton2;
    [AccessedThroughProperty("RadioButton1")]
    private RadioButton _RadioButton1;
    [AccessedThroughProperty("DockControl2")]
    private DockControl _DockControl2;
    [AccessedThroughProperty("Label4")]
    private Label _Label4;
    [AccessedThroughProperty("DockControl1")]
    private DockControl _DockControl1;
    [AccessedThroughProperty("CheckedListBox1")]
    private CheckedListBox _CheckedListBox1;
    [AccessedThroughProperty("DocumentContainer1")]
    private DocumentContainer _DocumentContainer1;
    [AccessedThroughProperty("ToolButton2")]
    private ButtonItem _ToolButton2;
    [AccessedThroughProperty("Label3")]
    private Label _Label3;
    [AccessedThroughProperty("ToolButton1")]
    private ButtonItem _ToolButton1;
    [AccessedThroughProperty("ToolBar1")]
    private TD.SandBar.ToolBar _ToolBar1;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("Sr_OpenFile2")]
    private sr_OpenFile _Sr_OpenFile2;
    [AccessedThroughProperty("Button1")]
    private Button _Button1;
    [AccessedThroughProperty("Sr_OpenFile1")]
    private sr_OpenFile _Sr_OpenFile1;
    [AccessedThroughProperty("CheckBox2")]
    private CheckBox _CheckBox2;
    [AccessedThroughProperty("SandDockManager1")]
    private SandDockManager _SandDockManager1;
    [AccessedThroughProperty("ImageList1")]
    private ImageList _ImageList1;
    [AccessedThroughProperty("GroupBox2")]
    private GroupBox _GroupBox2;
    [AccessedThroughProperty("CheckBox1")]
    private CheckBox _CheckBox1;
    [AccessedThroughProperty("InLabel2")]
    private Label _InLabel2;
    [AccessedThroughProperty("InLabel3")]
    private Label _InLabel3;
    [AccessedThroughProperty("DockControl3")]
    private DockControl _DockControl3;
    [AccessedThroughProperty("GroupBox1")]
    private GroupBox _GroupBox1;
    private IContainer components;

    public FormLayout()
    {
      this.Load += new EventHandler(this.FormLayout_Load);
      this.Closed += new EventHandler(this.FormLayout_Closed);
      this.InitializeComponent();
      sr_OpenFile srOpenFile1 = this.Sr_OpenFile1;
      srOpenFile1.OpenType = "Folder";
      srOpenFile1.OpenTitle = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[47]);
      srOpenFile1.StartPfad = StringType.FromInteger(17);
      srOpenFile1.ShowNewFolderButton = false;
      sr_OpenFile srOpenFile2 = this.Sr_OpenFile2;
      srOpenFile2.OpenType = "Folder";
      srOpenFile2.OpenTitle = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[48]);
      srOpenFile2.StartPfad = StringType.FromInteger(5);
      srOpenFile2.ShowNewFolderButton = false;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
      ClassThisProg.frmLayout = (FormLayout) null;
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

    internal virtual ButtonItem ToolButton1
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ToolButton1 != null)
          this._ToolButton1.Activate -= new EventHandler(this.ToolButton1_Activate);
        this._ToolButton1 = value;
        if (this._ToolButton1 == null)
          return;
        this._ToolButton1.Activate += new EventHandler(this.ToolButton1_Activate);
      }
      get => this._ToolButton1;
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

    internal virtual DockControl DockControl2
    {
      get => this._DockControl2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._DockControl2 == null)
          ;
        this._DockControl2 = value;
        if (this._DockControl2 == null)
          ;
      }
    }

    internal virtual Label InLabel2
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._InLabel2 == null)
          ;
        this._InLabel2 = value;
        if (this._InLabel2 == null)
          ;
      }
      get => this._InLabel2;
    }

    internal virtual CheckedListBox CheckedListBox1
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._CheckedListBox1 != null)
          this._CheckedListBox1.ItemCheck -= new ItemCheckEventHandler(this.CheckedListBox1_ItemCheck);
        this._CheckedListBox1 = value;
        if (this._CheckedListBox1 == null)
          return;
        this._CheckedListBox1.ItemCheck += new ItemCheckEventHandler(this.CheckedListBox1_ItemCheck);
      }
      get => this._CheckedListBox1;
    }

    internal virtual Label InLabel3
    {
      get => this._InLabel3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._InLabel3 == null)
          ;
        this._InLabel3 = value;
        if (this._InLabel3 == null)
          ;
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

    internal virtual Label Label4
    {
      get => this._Label4;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Label4 == null)
          ;
        this._Label4 = value;
        if (this._Label4 == null)
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

    internal virtual CheckBox CheckBox1
    {
      get => this._CheckBox1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._CheckBox1 == null)
          ;
        this._CheckBox1 = value;
        if (this._CheckBox1 == null)
          ;
      }
    }

    internal virtual Button Button1
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Button1 != null)
          this._Button1.Click -= new EventHandler(this.Button1_Click);
        this._Button1 = value;
        if (this._Button1 == null)
          return;
        this._Button1.Click += new EventHandler(this.Button1_Click);
      }
      get => this._Button1;
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

    internal virtual DockControl DockControl3
    {
      get => this._DockControl3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._DockControl3 == null)
          ;
        this._DockControl3 = value;
        if (this._DockControl3 == null)
          ;
      }
    }

    internal virtual GroupBox GroupBox2
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._GroupBox2 == null)
          ;
        this._GroupBox2 = value;
        if (this._GroupBox2 == null)
          ;
      }
      get => this._GroupBox2;
    }

    internal virtual CheckBox CheckBox2
    {
      get => this._CheckBox2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._CheckBox2 == null)
          ;
        this._CheckBox2 = value;
        if (this._CheckBox2 == null)
          ;
      }
    }

    internal virtual GroupBox GroupBox1
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._GroupBox1 == null)
          ;
        this._GroupBox1 = value;
        if (this._GroupBox1 == null)
          ;
      }
      get => this._GroupBox1;
    }

    internal virtual RadioButton RadioButton2
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._RadioButton2 == null)
          ;
        this._RadioButton2 = value;
        if (this._RadioButton2 == null)
          ;
      }
      get => this._RadioButton2;
    }

    internal virtual RadioButton RadioButton1
    {
      get => this._RadioButton1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._RadioButton1 == null)
          ;
        this._RadioButton1 = value;
        if (this._RadioButton1 == null)
          ;
      }
    }

    internal virtual sr_OpenFile Sr_OpenFile1
    {
      get => this._Sr_OpenFile1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Sr_OpenFile1 != null)
          this._Sr_OpenFile1.Click -= new EventHandler(this.Sr_OpenFile1_Click);
        this._Sr_OpenFile1 = value;
        if (this._Sr_OpenFile1 == null)
          return;
        this._Sr_OpenFile1.Click += new EventHandler(this.Sr_OpenFile1_Click);
      }
    }

    internal virtual sr_OpenFile Sr_OpenFile2
    {
      get => this._Sr_OpenFile2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Sr_OpenFile2 != null)
          this._Sr_OpenFile2.Click -= new EventHandler(this.Sr_OpenFile2_Click);
        this._Sr_OpenFile2 = value;
        if (this._Sr_OpenFile2 == null)
          return;
        this._Sr_OpenFile2.Click += new EventHandler(this.Sr_OpenFile2_Click);
      }
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      ResourceManager resourceManager = new ResourceManager(typeof (FormLayout));
      this.SandDockManager1 = new SandDockManager();
      this.ToolBar1 = new TD.SandBar.ToolBar();
      this.ImageList1 = new ImageList(this.components);
      this.ToolButton1 = new ButtonItem();
      this.ToolButton2 = new ButtonItem();
      this.DocumentContainer1 = new DocumentContainer();
      this.DockControl2 = new DockControl();
      this.Label1 = new Label();
      this.Button1 = new Button();
      this.CheckBox1 = new CheckBox();
      this.CheckedListBox1 = new CheckedListBox();
      this.DockControl1 = new DockControl();
      this.Sr_OpenFile2 = new sr_OpenFile();
      this.Sr_OpenFile1 = new sr_OpenFile();
      this.Label4 = new Label();
      this.Label3 = new Label();
      this.InLabel3 = new Label();
      this.InLabel2 = new Label();
      this.DockControl3 = new DockControl();
      this.GroupBox2 = new GroupBox();
      this.CheckBox2 = new CheckBox();
      this.GroupBox1 = new GroupBox();
      this.RadioButton2 = new RadioButton();
      this.RadioButton1 = new RadioButton();
      this.DocumentContainer1.SuspendLayout();
      this.DockControl2.SuspendLayout();
      this.DockControl1.SuspendLayout();
      this.DockControl3.SuspendLayout();
      this.GroupBox2.SuspendLayout();
      this.GroupBox1.SuspendLayout();
      this.SuspendLayout();
      this.SandDockManager1.OwnerForm = (Form) this;
      TD.SandBar.ToolBar toolBar1_1 = this.ToolBar1;
      Guid guid1 = new Guid("f4f824b6-10f0-4ffc-a5c8-cfe290482176");
      Guid guid2 = guid1;
      toolBar1_1.Guid = guid2;
      this.ToolBar1.ImageList = this.ImageList1;
      this.ToolBar1.Items.AddRange(new ToolbarItemBase[2]
      {
        (ToolbarItemBase) this.ToolButton1,
        (ToolbarItemBase) this.ToolButton2
      });
      TD.SandBar.ToolBar toolBar1_2 = this.ToolBar1;
      Point point1 = new Point(0, 0);
      Point point2 = point1;
      toolBar1_2.Location = point2;
      this.ToolBar1.Name = "ToolBar1";
      TD.SandBar.ToolBar toolBar1_3 = this.ToolBar1;
      Size size1 = new Size(488, 24);
      Size size2 = size1;
      toolBar1_3.Size = size2;
      this.ToolBar1.TabIndex = 1;
      this.ToolBar1.Text = "ToolBar1";
      ImageList imageList1 = this.ImageList1;
      size1 = new Size(16, 16);
      Size size3 = size1;
      imageList1.ImageSize = size3;
      this.ImageList1.ImageStream = (ImageListStreamer) resourceManager.GetObject("ImageList1.ImageStream");
      this.ImageList1.TransparentColor = Color.Transparent;
      this.ToolButton1.BeginGroup = true;
      this.ToolButton1.ImageIndex = 4;
      this.ToolButton2.BeginGroup = true;
      this.ToolButton2.ImageIndex = 10;
      this.DocumentContainer1.Controls.Add((Control) this.DockControl2);
      this.DocumentContainer1.Controls.Add((Control) this.DockControl1);
      this.DocumentContainer1.Controls.Add((Control) this.DockControl3);
      DocumentContainer documentContainer1_1 = this.DocumentContainer1;
      guid1 = new Guid("b19fd5ba-d7eb-43e6-b089-3ffe10402027");
      Guid guid3 = guid1;
      documentContainer1_1.Guid = guid3;
      this.DocumentContainer1.LayoutSystem = new SplitLayoutSystem(250, 400, Orientation.Horizontal, new LayoutSystemBase[1]
      {
        (LayoutSystemBase) new DocumentLayoutSystem(486, 267, new DockControl[3]
        {
          this.DockControl1,
          this.DockControl2,
          this.DockControl3
        }, this.DockControl1)
      });
      DocumentContainer documentContainer1_2 = this.DocumentContainer1;
      point1 = new Point(0, 24);
      Point point3 = point1;
      documentContainer1_2.Location = point3;
      this.DocumentContainer1.Manager = this.SandDockManager1;
      this.DocumentContainer1.Name = "DocumentContainer1";
      DocumentContainer documentContainer1_3 = this.DocumentContainer1;
      size1 = new Size(488, 269);
      Size size4 = size1;
      documentContainer1_3.Size = size4;
      this.DocumentContainer1.TabIndex = 28;
      this.DockControl2.Closable = false;
      this.DockControl2.Collapsible = false;
      this.DockControl2.Controls.Add((Control) this.Label1);
      this.DockControl2.Controls.Add((Control) this.Button1);
      this.DockControl2.Controls.Add((Control) this.CheckBox1);
      this.DockControl2.Controls.Add((Control) this.CheckedListBox1);
      this.DockControl2.Floatable = false;
      this.DockControl2.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      DockControl dockControl2_1 = this.DockControl2;
      guid1 = new Guid("73c7f9d5-f2de-4fea-bc50-75fcc57d5c85");
      Guid guid4 = guid1;
      dockControl2_1.Guid = guid4;
      DockControl dockControl2_2 = this.DockControl2;
      point1 = new Point(3, 23);
      Point point4 = point1;
      dockControl2_2.Location = point4;
      this.DockControl2.Name = "DockControl2";
      DockControl dockControl2_3 = this.DockControl2;
      size1 = new Size(482, 243);
      Size size5 = size1;
      dockControl2_3.Size = size5;
      this.DockControl2.TabIndex = 1;
      this.DockControl2.Text = "DockControl2";
      this.DockControl2.Visible = false;
      this.Label1.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label1_1 = this.Label1;
      point1 = new Point(8, 24);
      Point point5 = point1;
      label1_1.Location = point5;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      size1 = new Size(276, 24);
      Size size6 = size1;
      label1_2.Size = size6;
      this.Label1.TabIndex = 31;
      this.Label1.TextAlign = ContentAlignment.MiddleLeft;
      this.Button1.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Button button1_1 = this.Button1;
      point1 = new Point(296, 56);
      Point point6 = point1;
      button1_1.Location = point6;
      this.Button1.Name = "Button1";
      Button button1_2 = this.Button1;
      size1 = new Size(164, 40);
      Size size7 = size1;
      button1_2.Size = size7;
      this.Button1.TabIndex = 4;
      this.Button1.Visible = false;
      this.CheckBox1.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      CheckBox checkBox1_1 = this.CheckBox1;
      point1 = new Point(296, 20);
      Point point7 = point1;
      checkBox1_1.Location = point7;
      this.CheckBox1.Name = "CheckBox1";
      CheckBox checkBox1_2 = this.CheckBox1;
      size1 = new Size(164, 32);
      Size size8 = size1;
      checkBox1_2.Size = size8;
      this.CheckBox1.TabIndex = 3;
      this.CheckBox1.Visible = false;
      this.CheckedListBox1.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      CheckedListBox checkedListBox1_1 = this.CheckedListBox1;
      point1 = new Point(4, 56);
      Point point8 = point1;
      checkedListBox1_1.Location = point8;
      this.CheckedListBox1.Name = "CheckedListBox1";
      CheckedListBox checkedListBox1_2 = this.CheckedListBox1;
      size1 = new Size(280, 174);
      Size size9 = size1;
      checkedListBox1_2.Size = size9;
      this.CheckedListBox1.TabIndex = 2;
      this.DockControl1.Closable = false;
      this.DockControl1.Collapsible = false;
      this.DockControl1.Controls.Add((Control) this.Sr_OpenFile2);
      this.DockControl1.Controls.Add((Control) this.Sr_OpenFile1);
      this.DockControl1.Controls.Add((Control) this.Label4);
      this.DockControl1.Controls.Add((Control) this.Label3);
      this.DockControl1.Controls.Add((Control) this.InLabel3);
      this.DockControl1.Controls.Add((Control) this.InLabel2);
      this.DockControl1.Floatable = false;
      this.DockControl1.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      DockControl dockControl1_1 = this.DockControl1;
      guid1 = new Guid("a4930440-4704-4aef-90b5-cdcc960e9fb2");
      Guid guid5 = guid1;
      dockControl1_1.Guid = guid5;
      DockControl dockControl1_2 = this.DockControl1;
      point1 = new Point(3, 23);
      Point point9 = point1;
      dockControl1_2.Location = point9;
      this.DockControl1.Name = "DockControl1";
      DockControl dockControl1_3 = this.DockControl1;
      size1 = new Size(482, 243);
      Size size10 = size1;
      dockControl1_3.Size = size10;
      this.DockControl1.TabIndex = 0;
      this.DockControl1.Text = "DockControl1";
      this.Sr_OpenFile2.AusgabeImage = (Image) null;
      this.Sr_OpenFile2.CheckIfFileExists = true;
      sr_OpenFile srOpenFile2_1 = this.Sr_OpenFile2;
      point1 = new Point(448, 120);
      Point point10 = point1;
      srOpenFile2_1.Location = point10;
      this.Sr_OpenFile2.Name = "Sr_OpenFile2";
      this.Sr_OpenFile2.OpenFilter = "";
      this.Sr_OpenFile2.OpenTitle = "";
      this.Sr_OpenFile2.OpenType = "File";
      this.Sr_OpenFile2.ShowNewFolderButton = true;
      sr_OpenFile srOpenFile2_2 = this.Sr_OpenFile2;
      size1 = new Size(16, 16);
      Size size11 = size1;
      srOpenFile2_2.Size = size11;
      this.Sr_OpenFile2.StartPfad = "";
      this.Sr_OpenFile2.TabIndex = 33;
      this.Sr_OpenFile2.ToolTipText = "";
      this.Sr_OpenFile1.AusgabeImage = (Image) null;
      this.Sr_OpenFile1.CheckIfFileExists = true;
      sr_OpenFile srOpenFile1_1 = this.Sr_OpenFile1;
      point1 = new Point(448, 52);
      Point point11 = point1;
      srOpenFile1_1.Location = point11;
      this.Sr_OpenFile1.Name = "Sr_OpenFile1";
      this.Sr_OpenFile1.OpenFilter = "";
      this.Sr_OpenFile1.OpenTitle = "";
      this.Sr_OpenFile1.OpenType = "File";
      this.Sr_OpenFile1.ShowNewFolderButton = true;
      sr_OpenFile srOpenFile1_2 = this.Sr_OpenFile1;
      size1 = new Size(16, 16);
      Size size12 = size1;
      srOpenFile1_2.Size = size12;
      this.Sr_OpenFile1.StartPfad = "";
      this.Sr_OpenFile1.TabIndex = 32;
      this.Sr_OpenFile1.ToolTipText = "";
      this.Label4.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label4_1 = this.Label4;
      point1 = new Point(16, 88);
      Point point12 = point1;
      label4_1.Location = point12;
      this.Label4.Name = "Label4";
      Label label4_2 = this.Label4;
      size1 = new Size(420, 24);
      Size size13 = size1;
      label4_2.Size = size13;
      this.Label4.TabIndex = 31;
      this.Label4.TextAlign = ContentAlignment.MiddleLeft;
      this.Label3.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label3_1 = this.Label3;
      point1 = new Point(16, 20);
      Point point13 = point1;
      label3_1.Location = point13;
      this.Label3.Name = "Label3";
      Label label3_2 = this.Label3;
      size1 = new Size(420, 24);
      Size size14 = size1;
      label3_2.Size = size14;
      this.Label3.TabIndex = 30;
      this.Label3.TextAlign = ContentAlignment.MiddleLeft;
      this.InLabel3.BackColor = SystemColors.ActiveCaptionText;
      this.InLabel3.BorderStyle = BorderStyle.Fixed3D;
      Label inLabel3_1 = this.InLabel3;
      point1 = new Point(12, 116);
      Point point14 = point1;
      inLabel3_1.Location = point14;
      this.InLabel3.Name = "InLabel3";
      Label inLabel3_2 = this.InLabel3;
      size1 = new Size(424, 24);
      Size size15 = size1;
      inLabel3_2.Size = size15;
      this.InLabel3.TabIndex = 28;
      this.InLabel3.TextAlign = ContentAlignment.MiddleLeft;
      this.InLabel2.BackColor = SystemColors.ActiveCaptionText;
      this.InLabel2.BorderStyle = BorderStyle.Fixed3D;
      this.InLabel2.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label inLabel2_1 = this.InLabel2;
      point1 = new Point(12, 48);
      Point point15 = point1;
      inLabel2_1.Location = point15;
      this.InLabel2.Name = "InLabel2";
      Label inLabel2_2 = this.InLabel2;
      size1 = new Size(424, 24);
      Size size16 = size1;
      inLabel2_2.Size = size16;
      this.InLabel2.TabIndex = 26;
      this.InLabel2.TextAlign = ContentAlignment.MiddleLeft;
      this.DockControl3.Controls.Add((Control) this.GroupBox2);
      this.DockControl3.Controls.Add((Control) this.GroupBox1);
      this.DockControl3.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      DockControl dockControl3_1 = this.DockControl3;
      guid1 = new Guid("324f0fd1-7479-4fbb-bdaa-4a9dc70892f6");
      Guid guid6 = guid1;
      dockControl3_1.Guid = guid6;
      DockControl dockControl3_2 = this.DockControl3;
      point1 = new Point(3, 23);
      Point point16 = point1;
      dockControl3_2.Location = point16;
      this.DockControl3.Name = "DockControl3";
      DockControl dockControl3_3 = this.DockControl3;
      size1 = new Size(482, 243);
      Size size17 = size1;
      dockControl3_3.Size = size17;
      this.DockControl3.TabIndex = 2;
      this.DockControl3.Text = "DockControl3";
      this.GroupBox2.Controls.Add((Control) this.CheckBox2);
      GroupBox groupBox2_1 = this.GroupBox2;
      point1 = new Point(144, 8);
      Point point17 = point1;
      groupBox2_1.Location = point17;
      this.GroupBox2.Name = "GroupBox2";
      GroupBox groupBox2_2 = this.GroupBox2;
      size1 = new Size(208, 96);
      Size size18 = size1;
      groupBox2_2.Size = size18;
      this.GroupBox2.TabIndex = 35;
      this.GroupBox2.TabStop = false;
      this.GroupBox2.Text = "Saving";
      CheckBox checkBox2_1 = this.CheckBox2;
      point1 = new Point(12, 28);
      Point point18 = point1;
      checkBox2_1.Location = point18;
      this.CheckBox2.Name = "CheckBox2";
      CheckBox checkBox2_2 = this.CheckBox2;
      size1 = new Size(188, 16);
      Size size19 = size1;
      checkBox2_2.Size = size19;
      this.CheckBox2.TabIndex = 0;
      this.CheckBox2.Text = "Sicherheitskopie erstellen";
      this.GroupBox1.Controls.Add((Control) this.RadioButton2);
      this.GroupBox1.Controls.Add((Control) this.RadioButton1);
      GroupBox groupBox1_1 = this.GroupBox1;
      point1 = new Point(8, 8);
      Point point19 = point1;
      groupBox1_1.Location = point19;
      this.GroupBox1.Name = "GroupBox1";
      GroupBox groupBox1_2 = this.GroupBox1;
      size1 = new Size(128, 96);
      Size size20 = size1;
      groupBox1_2.Size = size20;
      this.GroupBox1.TabIndex = 34;
      this.GroupBox1.TabStop = false;
      this.GroupBox1.Text = "TE-Editor Mode";
      RadioButton radioButton2_1 = this.RadioButton2;
      point1 = new Point(12, 56);
      Point point20 = point1;
      radioButton2_1.Location = point20;
      this.RadioButton2.Name = "RadioButton2";
      RadioButton radioButton2_2 = this.RadioButton2;
      size1 = new Size(104, 20);
      Size size21 = size1;
      radioButton2_2.Size = size21;
      this.RadioButton2.TabIndex = 1;
      this.RadioButton2.Text = "Expert";
      RadioButton radioButton1_1 = this.RadioButton1;
      point1 = new Point(12, 24);
      Point point21 = point1;
      radioButton1_1.Location = point21;
      this.RadioButton1.Name = "RadioButton1";
      RadioButton radioButton1_2 = this.RadioButton1;
      size1 = new Size(104, 20);
      Size size22 = size1;
      radioButton1_2.Size = size22;
      this.RadioButton1.TabIndex = 0;
      this.RadioButton1.Text = "Standard";
      size1 = new Size(5, 13);
      this.AutoScaleBaseSize = size1;
      size1 = new Size(488, 293);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.DocumentContainer1);
      this.Controls.Add((Control) this.ToolBar1);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (FormLayout);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = nameof (FormLayout);
      this.DocumentContainer1.ResumeLayout(false);
      this.DockControl2.ResumeLayout(false);
      this.DockControl1.ResumeLayout(false);
      this.DockControl3.ResumeLayout(false);
      this.GroupBox2.ResumeLayout(false);
      this.GroupBox1.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    private void FormLayout_Load(object sender, EventArgs e)
    {
      sr_Userinterface.AendereFarben((Form) this, ClassThisProg.DefReader.FarbSchema);
      this.CheckedListBox1.CheckOnClick = true;
      this.CheckedListBox1.ScrollAlwaysVisible = true;
      if (StringType.StrCmp(ClassThisProg.DefReader.TEModus, "S", false) == 0)
        this.RadioButton1.Checked = true;
      else
        this.RadioButton2.Checked = true;
      this.CheckBox2.Checked = ClassThisProg.DefReader.CreateBackup;
      this.DockControl1.Activate();
      this.SetzeTexte();
      this.Show();
    }

    public object SetzeTexte()
    {
      this.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[35]);
      this.InLabel2.Text = ClassThisProg.DefReader.SC4Path;
      this.InLabel3.Text = ClassThisProg.DefReader.sc4LocalPath;
      this.ToolButton1.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[3]);
      this.ToolButton2.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[17]);
      this.Label1.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[32]);
      this.CheckBox1.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[33]);
      this.Button1.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[34]);
      this.Label3.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[49]);
      this.Label4.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[50]);
      this.DockControl1.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[30]);
      this.DockControl2.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[31]);
      this.CheckedListBox1.Items.Clear();
      this.CheckedListBox1.Items.Add((object) "Intro");
      this.CheckedListBox1.Items.Add(RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[45]));
      this.CheckedListBox1.Items.Add(RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[379]));
      this.CheckedListBox1.Items.Add(RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[46]));
      this.CheckedListBox1.Items.Add(RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[313]));
      this.CheckedListBox1.Items.Add(RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[429]));
      this.CheckedListBox1.Items.Add(RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[434]));
      this.CheckedListBox1.Items.Add(RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[470]));
      this.CheckedListBox1.Items.Add(RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[502]));
      this.CheckedListBox1.Items.Add(RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[478]));
      this.CheckedListBox1.Items.Add(RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[558]));
      if (ClassThisProg.DefReader.StartupProgramm <= 10)
        this.CheckedListBox1.SetItemChecked(ClassThisProg.DefReader.StartupProgramm, true);
      this.DockControl3.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[456]);
      this.GroupBox1.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[457]);
      this.GroupBox2.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[458]);
      this.RadioButton1.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[443]);
      this.RadioButton2.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[444]);
      this.CheckBox2.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[459]);
      object obj;
      return obj;
    }

    private void ToolButton2_Activate(object sender, EventArgs e)
    {
      bool flag = false;
      if (this.CheckedListBox1.CheckedIndices.Count == 1)
      {
        ClassThisProg.DefReader.StartupProgramm = this.CheckedListBox1.CheckedIndices[0];
        if (ClassThisProg.DefReader.StartupProgramm != 0)
          ClassThisProg.DefReader.ShowIntro = false;
      }
      else
        ClassThisProg.DefReader.StartupProgramm = 20;
      if (StringType.StrCmp(this.InLabel2.Text, "", false) != 0 && new DirectoryInfo(this.InLabel2.Text).Exists)
      {
        flag = true;
        ClassThisProg.DefReader.SC4Path = this.InLabel2.Text;
      }
      if (StringType.StrCmp(this.InLabel3.Text, "", false) != 0 && new DirectoryInfo(this.InLabel3.Text).Exists)
      {
        flag = true;
        ClassThisProg.DefReader.sc4LocalPath = this.InLabel3.Text;
      }
      ClassThisProg.DefReader.TEModus = !this.RadioButton1.Checked ? "E" : "S";
      ClassThisProg.DefReader.CreateBackup = this.CheckBox2.Checked;
      ClassThisProg.DefReader.SaveSettings();
    }

    private void ToolButton1_Activate(object sender, EventArgs e) => this.Dispose();

    private void Button1_Click(object sender, EventArgs e)
    {
      ClassThisProg.DefReader.StartupProgramm = 0;
      ClassThisProg.DefReader.TEModus = "S";
      ClassThisProg.DefReader.CreateBackup = false;
      this.CheckedListBox1.SetItemChecked(0, true);
      ClassThisProg.DefReader.SaveSettings();
    }

    private void CheckedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
    {
      int num = checked (this.CheckedListBox1.Items.Count - 1);
      int index = 0;
      while (index <= num)
      {
        if (index != e.Index)
          this.CheckedListBox1.SetItemChecked(index, false);
        checked { ++index; }
      }
    }

    private void FormLayout_Closed(object sender, EventArgs e) => ClassThisProg.frmLayout = (FormLayout) null;

    private void Sr_OpenFile1_Click(object sender, EventArgs e)
    {
      if (ObjectType.ObjTst(this.Sr_OpenFile1.ResultFolder, (object) "", false) == 0)
        return;
      this.InLabel2.Text = StringType.FromObject(this.Sr_OpenFile1.ResultFolder);
    }

    private void Sr_OpenFile2_Click(object sender, EventArgs e)
    {
      if (ObjectType.ObjTst(this.Sr_OpenFile2.ResultFolder, (object) "", false) == 0)
        return;
      this.InLabel3.Text = StringType.FromObject(this.Sr_OpenFile2.ResultFolder);
    }
  }
}
