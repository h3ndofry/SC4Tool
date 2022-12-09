// Decompiled with JetBrains decompiler
// Type: SC4Tool.FormIntro
// Assembly: SC4Tool, Version=2.2.7.0, Culture=neutral, PublicKeyToken=null
// MVID: 69A50BC4-87A5-4C5E-BEFC-08274BC6D498
// Assembly location: C:\Program Files (x86)\SC4 Utilities\SC4Tool\SC4Tool.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SC4Tool
{
  public class FormIntro : Form
  {
    [AccessedThroughProperty("IntroLabel6")]
    private Label _IntroLabel6;
    [AccessedThroughProperty("IntroLabel1")]
    private Label _IntroLabel1;
    [AccessedThroughProperty("PictureBox6")]
    private PictureBox _PictureBox6;
    [AccessedThroughProperty("IntroLabel7")]
    private Label _IntroLabel7;
    [AccessedThroughProperty("PictureBox7")]
    private PictureBox _PictureBox7;
    [AccessedThroughProperty("PictureBox4")]
    private PictureBox _PictureBox4;
    [AccessedThroughProperty("ImageList1")]
    private ImageList _ImageList1;
    [AccessedThroughProperty("IntroLabel2")]
    private Label _IntroLabel2;
    [AccessedThroughProperty("IntroLabel3")]
    private Label _IntroLabel3;
    [AccessedThroughProperty("PictureBox3")]
    private PictureBox _PictureBox3;
    [AccessedThroughProperty("IntroLabel4")]
    private Label _IntroLabel4;
    [AccessedThroughProperty("CheckBox1")]
    private CheckBox _CheckBox1;
    [AccessedThroughProperty("PictureBox10")]
    private PictureBox _PictureBox10;
    [AccessedThroughProperty("PictureBox5")]
    private PictureBox _PictureBox5;
    [AccessedThroughProperty("IntroLabel5")]
    private Label _IntroLabel5;
    [AccessedThroughProperty("ToolTip1")]
    private ToolTip _ToolTip1;
    [AccessedThroughProperty("PictureBox8")]
    private PictureBox _PictureBox8;
    [AccessedThroughProperty("IntroLabel8")]
    private Label _IntroLabel8;
    [AccessedThroughProperty("Button1")]
    private Button _Button1;
    [AccessedThroughProperty("IntroLabel9")]
    private Label _IntroLabel9;
    [AccessedThroughProperty("PictureBox9")]
    private PictureBox _PictureBox9;
    [AccessedThroughProperty("PictureBox1")]
    private PictureBox _PictureBox1;
    [AccessedThroughProperty("PictureBox2")]
    private PictureBox _PictureBox2;
    [AccessedThroughProperty("IntroLabel10")]
    private Label _IntroLabel10;
    private IContainer components;

    public FormIntro()
    {
      this.Load += new EventHandler(this.FormIntro_Load);
      this.Closed += new EventHandler(this.FormIntro_Closed);
      this.InitializeComponent();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      if (this.CheckBox1.Checked)
      {
        ClassThisProg.DefReader.ShowIntro = false;
        ClassThisProg.DefReader.StartupProgramm = 10;
        ClassThisProg.DefReader.SaveSettings();
      }
      base.Dispose(disposing);
      ClassThisProg.frmIntro = (FormIntro) null;
    }

    internal virtual PictureBox PictureBox1
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._PictureBox1 == null)
          ;
        this._PictureBox1 = value;
        if (this._PictureBox1 == null)
          ;
      }
      get => this._PictureBox1;
    }

    internal virtual CheckBox CheckBox1
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._CheckBox1 == null)
          ;
        this._CheckBox1 = value;
        if (this._CheckBox1 == null)
          ;
      }
      get => this._CheckBox1;
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

    internal virtual PictureBox PictureBox2
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._PictureBox2 != null)
          this._PictureBox2.Click -= new EventHandler(this.PictureBox2_Click);
        this._PictureBox2 = value;
        if (this._PictureBox2 == null)
          return;
        this._PictureBox2.Click += new EventHandler(this.PictureBox2_Click);
      }
      get => this._PictureBox2;
    }

    internal virtual PictureBox PictureBox3
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._PictureBox3 != null)
          this._PictureBox3.Click -= new EventHandler(this.PictureBox3_Click);
        this._PictureBox3 = value;
        if (this._PictureBox3 == null)
          return;
        this._PictureBox3.Click += new EventHandler(this.PictureBox3_Click);
      }
      get => this._PictureBox3;
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

    internal virtual Label IntroLabel1
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._IntroLabel1 == null)
          ;
        this._IntroLabel1 = value;
        if (this._IntroLabel1 == null)
          ;
      }
      get => this._IntroLabel1;
    }

    internal virtual Label IntroLabel2
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._IntroLabel2 == null)
          ;
        this._IntroLabel2 = value;
        if (this._IntroLabel2 == null)
          ;
      }
      get => this._IntroLabel2;
    }

    internal virtual Label IntroLabel3
    {
      get => this._IntroLabel3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._IntroLabel3 == null)
          ;
        this._IntroLabel3 = value;
        if (this._IntroLabel3 == null)
          ;
      }
    }

    internal virtual Label IntroLabel4
    {
      get => this._IntroLabel4;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._IntroLabel4 == null)
          ;
        this._IntroLabel4 = value;
        if (this._IntroLabel4 == null)
          ;
      }
    }

    internal virtual Button Button1
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Button1 != null)
          this._Button1.Click -= new EventHandler(this.Button1_Click1);
        this._Button1 = value;
        if (this._Button1 == null)
          return;
        this._Button1.Click += new EventHandler(this.Button1_Click1);
      }
      get => this._Button1;
    }

    internal virtual PictureBox PictureBox5
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._PictureBox5 != null)
          this._PictureBox5.Click -= new EventHandler(this.PictureBox5_Click);
        this._PictureBox5 = value;
        if (this._PictureBox5 == null)
          return;
        this._PictureBox5.Click += new EventHandler(this.PictureBox5_Click);
      }
      get => this._PictureBox5;
    }

    internal virtual Label IntroLabel5
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._IntroLabel5 == null)
          ;
        this._IntroLabel5 = value;
        if (this._IntroLabel5 == null)
          ;
      }
      get => this._IntroLabel5;
    }

    internal virtual Label IntroLabel6
    {
      get => this._IntroLabel6;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._IntroLabel6 == null)
          ;
        this._IntroLabel6 = value;
        if (this._IntroLabel6 == null)
          ;
      }
    }

    internal virtual PictureBox PictureBox6
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._PictureBox6 != null)
          this._PictureBox6.Click -= new EventHandler(this.PictureBox6_Click);
        this._PictureBox6 = value;
        if (this._PictureBox6 == null)
          return;
        this._PictureBox6.Click += new EventHandler(this.PictureBox6_Click);
      }
      get => this._PictureBox6;
    }

    internal virtual Label IntroLabel7
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._IntroLabel7 == null)
          ;
        this._IntroLabel7 = value;
        if (this._IntroLabel7 == null)
          ;
      }
      get => this._IntroLabel7;
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

    internal virtual ToolTip ToolTip1
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ToolTip1 == null)
          ;
        this._ToolTip1 = value;
        if (this._ToolTip1 == null)
          ;
      }
      get => this._ToolTip1;
    }

    internal virtual PictureBox PictureBox8
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._PictureBox8 != null)
          this._PictureBox8.Click -= new EventHandler(this.PictureBox8_Click);
        this._PictureBox8 = value;
        if (this._PictureBox8 == null)
          return;
        this._PictureBox8.Click += new EventHandler(this.PictureBox8_Click);
      }
      get => this._PictureBox8;
    }

    internal virtual Label IntroLabel8
    {
      get => this._IntroLabel8;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._IntroLabel8 == null)
          ;
        this._IntroLabel8 = value;
        if (this._IntroLabel8 == null)
          ;
      }
    }

    internal virtual Label IntroLabel9
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._IntroLabel9 == null)
          ;
        this._IntroLabel9 = value;
        if (this._IntroLabel9 == null)
          ;
      }
      get => this._IntroLabel9;
    }

    internal virtual PictureBox PictureBox9
    {
      get => this._PictureBox9;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._PictureBox9 != null)
          this._PictureBox9.Click -= new EventHandler(this.PictureBox9_Click);
        this._PictureBox9 = value;
        if (this._PictureBox9 == null)
          return;
        this._PictureBox9.Click += new EventHandler(this.PictureBox9_Click);
      }
    }

    internal virtual Label IntroLabel10
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._IntroLabel10 == null)
          ;
        this._IntroLabel10 = value;
        if (this._IntroLabel10 == null)
          ;
      }
      get => this._IntroLabel10;
    }

    internal virtual PictureBox PictureBox10
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._PictureBox10 != null)
          this._PictureBox10.Click -= new EventHandler(this.PictureBox10_Click);
        this._PictureBox10 = value;
        if (this._PictureBox10 == null)
          return;
        this._PictureBox10.Click += new EventHandler(this.PictureBox10_Click);
      }
      get => this._PictureBox10;
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      ResourceManager resourceManager = new ResourceManager(typeof (FormIntro));
      this.PictureBox1 = new PictureBox();
      this.CheckBox1 = new CheckBox();
      this.ImageList1 = new ImageList(this.components);
      this.PictureBox2 = new PictureBox();
      this.PictureBox3 = new PictureBox();
      this.PictureBox4 = new PictureBox();
      this.IntroLabel1 = new Label();
      this.IntroLabel2 = new Label();
      this.IntroLabel3 = new Label();
      this.IntroLabel4 = new Label();
      this.Button1 = new Button();
      this.IntroLabel5 = new Label();
      this.PictureBox5 = new PictureBox();
      this.IntroLabel6 = new Label();
      this.PictureBox6 = new PictureBox();
      this.IntroLabel7 = new Label();
      this.PictureBox7 = new PictureBox();
      this.ToolTip1 = new ToolTip(this.components);
      this.PictureBox8 = new PictureBox();
      this.IntroLabel8 = new Label();
      this.IntroLabel9 = new Label();
      this.PictureBox9 = new PictureBox();
      this.IntroLabel10 = new Label();
      this.PictureBox10 = new PictureBox();
      this.SuspendLayout();
      this.PictureBox1.Cursor = Cursors.Hand;
      this.PictureBox1.Dock = DockStyle.Top;
      this.PictureBox1.Image = (Image) resourceManager.GetObject("PictureBox1.Image");
      PictureBox pictureBox1_1 = this.PictureBox1;
      Point point1 = new Point(0, 0);
      Point point2 = point1;
      pictureBox1_1.Location = point2;
      this.PictureBox1.Name = "PictureBox1";
      PictureBox pictureBox1_2 = this.PictureBox1;
      Size size1 = new Size(698, 60);
      Size size2 = size1;
      pictureBox1_2.Size = size2;
      this.PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
      this.PictureBox1.TabIndex = 0;
      this.PictureBox1.TabStop = false;
      this.CheckBox1.FlatStyle = FlatStyle.Popup;
      this.CheckBox1.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      CheckBox checkBox1_1 = this.CheckBox1;
      point1 = new Point(16, 472);
      Point point3 = point1;
      checkBox1_1.Location = point3;
      this.CheckBox1.Name = "CheckBox1";
      CheckBox checkBox1_2 = this.CheckBox1;
      size1 = new Size(248, 24);
      Size size3 = size1;
      checkBox1_2.Size = size3;
      this.CheckBox1.TabIndex = 1;
      ImageList imageList1 = this.ImageList1;
      size1 = new Size(16, 16);
      Size size4 = size1;
      imageList1.ImageSize = size4;
      this.ImageList1.TransparentColor = Color.Transparent;
      this.PictureBox2.BackColor = Color.Transparent;
      this.PictureBox2.Cursor = Cursors.Hand;
      this.PictureBox2.Image = (Image) resourceManager.GetObject("PictureBox2.Image");
      PictureBox pictureBox2_1 = this.PictureBox2;
      point1 = new Point(16, 144);
      Point point4 = point1;
      pictureBox2_1.Location = point4;
      this.PictureBox2.Name = "PictureBox2";
      PictureBox pictureBox2_2 = this.PictureBox2;
      size1 = new Size(50, 40);
      Size size5 = size1;
      pictureBox2_2.Size = size5;
      this.PictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
      this.PictureBox2.TabIndex = 9;
      this.PictureBox2.TabStop = false;
      this.PictureBox3.BackColor = Color.Transparent;
      this.PictureBox3.Cursor = Cursors.Hand;
      this.PictureBox3.Image = (Image) resourceManager.GetObject("PictureBox3.Image");
      PictureBox pictureBox3_1 = this.PictureBox3;
      point1 = new Point(16, 272);
      Point point5 = point1;
      pictureBox3_1.Location = point5;
      this.PictureBox3.Name = "PictureBox3";
      PictureBox pictureBox3_2 = this.PictureBox3;
      size1 = new Size(50, 40);
      Size size6 = size1;
      pictureBox3_2.Size = size6;
      this.PictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
      this.PictureBox3.TabIndex = 10;
      this.PictureBox3.TabStop = false;
      this.PictureBox4.BackColor = Color.Transparent;
      this.PictureBox4.Cursor = Cursors.Hand;
      this.PictureBox4.Image = (Image) resourceManager.GetObject("PictureBox4.Image");
      PictureBox pictureBox4_1 = this.PictureBox4;
      point1 = new Point(16, 208);
      Point point6 = point1;
      pictureBox4_1.Location = point6;
      this.PictureBox4.Name = "PictureBox4";
      PictureBox pictureBox4_2 = this.PictureBox4;
      size1 = new Size(50, 40);
      Size size7 = size1;
      pictureBox4_2.Size = size7;
      this.PictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
      this.PictureBox4.TabIndex = 11;
      this.PictureBox4.TabStop = false;
      this.IntroLabel1.BackColor = Color.Transparent;
      this.IntroLabel1.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label introLabel1_1 = this.IntroLabel1;
      point1 = new Point(16, 72);
      Point point7 = point1;
      introLabel1_1.Location = point7;
      this.IntroLabel1.Name = "IntroLabel1";
      Label introLabel1_2 = this.IntroLabel1;
      size1 = new Size(672, 64);
      Size size8 = size1;
      introLabel1_2.Size = size8;
      this.IntroLabel1.TabIndex = 12;
      this.IntroLabel2.BackColor = Color.Transparent;
      this.IntroLabel2.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label introLabel2_1 = this.IntroLabel2;
      point1 = new Point(88, 144);
      Point point8 = point1;
      introLabel2_1.Location = point8;
      this.IntroLabel2.Name = "IntroLabel2";
      Label introLabel2_2 = this.IntroLabel2;
      size1 = new Size(256, 56);
      Size size9 = size1;
      introLabel2_2.Size = size9;
      this.IntroLabel2.TabIndex = 13;
      this.IntroLabel2.Text = "DB";
      this.IntroLabel3.BackColor = Color.Transparent;
      this.IntroLabel3.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label introLabel3_1 = this.IntroLabel3;
      point1 = new Point(88, 272);
      Point point9 = point1;
      introLabel3_1.Location = point9;
      this.IntroLabel3.Name = "IntroLabel3";
      Label introLabel3_2 = this.IntroLabel3;
      size1 = new Size(256, 56);
      Size size10 = size1;
      introLabel3_2.Size = size10;
      this.IntroLabel3.TabIndex = 14;
      this.IntroLabel3.Text = "Analyser";
      this.IntroLabel4.BackColor = Color.Transparent;
      this.IntroLabel4.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label introLabel4_1 = this.IntroLabel4;
      point1 = new Point(88, 336);
      Point point10 = point1;
      introLabel4_1.Location = point10;
      this.IntroLabel4.Name = "IntroLabel4";
      Label introLabel4_2 = this.IntroLabel4;
      size1 = new Size(256, 56);
      Size size11 = size1;
      introLabel4_2.Size = size11;
      this.IntroLabel4.TabIndex = 15;
      this.IntroLabel4.Text = "TexturScanner";
      this.Button1.BackColor = SystemColors.Control;
      this.Button1.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Button button1_1 = this.Button1;
      point1 = new Point(568, 464);
      Point point11 = point1;
      button1_1.Location = point11;
      this.Button1.Name = "Button1";
      Button button1_2 = this.Button1;
      size1 = new Size(120, 32);
      Size size12 = size1;
      button1_2.Size = size12;
      this.Button1.TabIndex = 16;
      this.Button1.Text = "Button1";
      this.IntroLabel5.BackColor = Color.Transparent;
      this.IntroLabel5.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label introLabel5_1 = this.IntroLabel5;
      point1 = new Point(85, 208);
      Point point12 = point1;
      introLabel5_1.Location = point12;
      this.IntroLabel5.Name = "IntroLabel5";
      Label introLabel5_2 = this.IntroLabel5;
      size1 = new Size(256, 56);
      Size size13 = size1;
      introLabel5_2.Size = size13;
      this.IntroLabel5.TabIndex = 18;
      this.IntroLabel5.Text = "Referenz";
      this.PictureBox5.BackColor = Color.Transparent;
      this.PictureBox5.Cursor = Cursors.Hand;
      this.PictureBox5.Image = (Image) resourceManager.GetObject("PictureBox5.Image");
      PictureBox pictureBox5_1 = this.PictureBox5;
      point1 = new Point(16, 336);
      Point point13 = point1;
      pictureBox5_1.Location = point13;
      this.PictureBox5.Name = "PictureBox5";
      PictureBox pictureBox5_2 = this.PictureBox5;
      size1 = new Size(50, 40);
      Size size14 = size1;
      pictureBox5_2.Size = size14;
      this.PictureBox5.SizeMode = PictureBoxSizeMode.AutoSize;
      this.PictureBox5.TabIndex = 17;
      this.PictureBox5.TabStop = false;
      this.IntroLabel6.BackColor = Color.Transparent;
      this.IntroLabel6.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label introLabel6_1 = this.IntroLabel6;
      point1 = new Point(432, 208);
      Point point14 = point1;
      introLabel6_1.Location = point14;
      this.IntroLabel6.Name = "IntroLabel6";
      Label introLabel6_2 = this.IntroLabel6;
      size1 = new Size(256, 56);
      Size size15 = size1;
      introLabel6_2.Size = size15;
      this.IntroLabel6.TabIndex = 19;
      this.IntroLabel6.Text = "TE-Editor";
      this.PictureBox6.BackColor = Color.Transparent;
      this.PictureBox6.Cursor = Cursors.Hand;
      this.PictureBox6.Image = (Image) resourceManager.GetObject("PictureBox6.Image");
      PictureBox pictureBox6_1 = this.PictureBox6;
      point1 = new Point(360, 208);
      Point point15 = point1;
      pictureBox6_1.Location = point15;
      this.PictureBox6.Name = "PictureBox6";
      PictureBox pictureBox6_2 = this.PictureBox6;
      size1 = new Size(50, 40);
      Size size16 = size1;
      pictureBox6_2.Size = size16;
      this.PictureBox6.SizeMode = PictureBoxSizeMode.AutoSize;
      this.PictureBox6.TabIndex = 20;
      this.PictureBox6.TabStop = false;
      this.IntroLabel7.BackColor = Color.Transparent;
      this.IntroLabel7.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label introLabel7_1 = this.IntroLabel7;
      point1 = new Point(432, 144);
      Point point16 = point1;
      introLabel7_1.Location = point16;
      this.IntroLabel7.Name = "IntroLabel7";
      Label introLabel7_2 = this.IntroLabel7;
      size1 = new Size(256, 56);
      Size size17 = size1;
      introLabel7_2.Size = size17;
      this.IntroLabel7.TabIndex = 21;
      this.IntroLabel7.Text = "TextureCreator";
      this.PictureBox7.BackColor = Color.Transparent;
      this.PictureBox7.Cursor = Cursors.Hand;
      this.PictureBox7.Image = (Image) resourceManager.GetObject("PictureBox7.Image");
      PictureBox pictureBox7_1 = this.PictureBox7;
      point1 = new Point(360, 144);
      Point point17 = point1;
      pictureBox7_1.Location = point17;
      this.PictureBox7.Name = "PictureBox7";
      PictureBox pictureBox7_2 = this.PictureBox7;
      size1 = new Size(50, 40);
      Size size18 = size1;
      pictureBox7_2.Size = size18;
      this.PictureBox7.SizeMode = PictureBoxSizeMode.AutoSize;
      this.PictureBox7.TabIndex = 22;
      this.PictureBox7.TabStop = false;
      this.PictureBox8.BackColor = Color.Transparent;
      this.PictureBox8.Cursor = Cursors.Hand;
      this.PictureBox8.Image = (Image) resourceManager.GetObject("PictureBox8.Image");
      PictureBox pictureBox8_1 = this.PictureBox8;
      point1 = new Point(360, 272);
      Point point18 = point1;
      pictureBox8_1.Location = point18;
      this.PictureBox8.Name = "PictureBox8";
      PictureBox pictureBox8_2 = this.PictureBox8;
      size1 = new Size(50, 40);
      Size size19 = size1;
      pictureBox8_2.Size = size19;
      this.PictureBox8.SizeMode = PictureBoxSizeMode.AutoSize;
      this.PictureBox8.TabIndex = 23;
      this.PictureBox8.TabStop = false;
      this.IntroLabel8.BackColor = Color.Transparent;
      this.IntroLabel8.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label introLabel8_1 = this.IntroLabel8;
      point1 = new Point(432, 272);
      Point point19 = point1;
      introLabel8_1.Location = point19;
      this.IntroLabel8.Name = "IntroLabel8";
      Label introLabel8_2 = this.IntroLabel8;
      size1 = new Size(256, 56);
      Size size20 = size1;
      introLabel8_2.Size = size20;
      this.IntroLabel8.TabIndex = 24;
      this.IntroLabel8.Text = "Comparer";
      this.IntroLabel9.BackColor = Color.Transparent;
      this.IntroLabel9.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label introLabel9_1 = this.IntroLabel9;
      point1 = new Point(432, 336);
      Point point20 = point1;
      introLabel9_1.Location = point20;
      this.IntroLabel9.Name = "IntroLabel9";
      Label introLabel9_2 = this.IntroLabel9;
      size1 = new Size(256, 56);
      Size size21 = size1;
      introLabel9_2.Size = size21;
      this.IntroLabel9.TabIndex = 26;
      this.IntroLabel9.Text = "Exemplar-Editor";
      this.PictureBox9.BackColor = Color.Transparent;
      this.PictureBox9.Cursor = Cursors.Hand;
      this.PictureBox9.Image = (Image) resourceManager.GetObject("PictureBox9.Image");
      PictureBox pictureBox9_1 = this.PictureBox9;
      point1 = new Point(360, 336);
      Point point21 = point1;
      pictureBox9_1.Location = point21;
      this.PictureBox9.Name = "PictureBox9";
      PictureBox pictureBox9_2 = this.PictureBox9;
      size1 = new Size(50, 40);
      Size size22 = size1;
      pictureBox9_2.Size = size22;
      this.PictureBox9.SizeMode = PictureBoxSizeMode.AutoSize;
      this.PictureBox9.TabIndex = 25;
      this.PictureBox9.TabStop = false;
      this.IntroLabel10.BackColor = Color.Transparent;
      this.IntroLabel10.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label introLabel10_1 = this.IntroLabel10;
      point1 = new Point(88, 400);
      Point point22 = point1;
      introLabel10_1.Location = point22;
      this.IntroLabel10.Name = "IntroLabel10";
      Label introLabel10_2 = this.IntroLabel10;
      size1 = new Size(256, 56);
      Size size23 = size1;
      introLabel10_2.Size = size23;
      this.IntroLabel10.TabIndex = 28;
      this.IntroLabel10.Text = "DepScanner";
      this.PictureBox10.BackColor = Color.Transparent;
      this.PictureBox10.Cursor = Cursors.Hand;
      this.PictureBox10.Image = (Image) resourceManager.GetObject("PictureBox10.Image");
      PictureBox pictureBox10_1 = this.PictureBox10;
      point1 = new Point(16, 400);
      Point point23 = point1;
      pictureBox10_1.Location = point23;
      this.PictureBox10.Name = "PictureBox10";
      PictureBox pictureBox10_2 = this.PictureBox10;
      size1 = new Size(50, 40);
      Size size24 = size1;
      pictureBox10_2.Size = size24;
      this.PictureBox10.SizeMode = PictureBoxSizeMode.AutoSize;
      this.PictureBox10.TabIndex = 27;
      this.PictureBox10.TabStop = false;
      this.AutoScale = false;
      size1 = new Size(5, 13);
      this.AutoScaleBaseSize = size1;
      size1 = new Size(698, 511);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.IntroLabel10);
      this.Controls.Add((Control) this.PictureBox10);
      this.Controls.Add((Control) this.IntroLabel9);
      this.Controls.Add((Control) this.PictureBox9);
      this.Controls.Add((Control) this.IntroLabel8);
      this.Controls.Add((Control) this.PictureBox8);
      this.Controls.Add((Control) this.PictureBox7);
      this.Controls.Add((Control) this.IntroLabel7);
      this.Controls.Add((Control) this.PictureBox6);
      this.Controls.Add((Control) this.IntroLabel6);
      this.Controls.Add((Control) this.IntroLabel5);
      this.Controls.Add((Control) this.PictureBox5);
      this.Controls.Add((Control) this.Button1);
      this.Controls.Add((Control) this.IntroLabel4);
      this.Controls.Add((Control) this.IntroLabel3);
      this.Controls.Add((Control) this.IntroLabel2);
      this.Controls.Add((Control) this.IntroLabel1);
      this.Controls.Add((Control) this.PictureBox4);
      this.Controls.Add((Control) this.PictureBox3);
      this.Controls.Add((Control) this.PictureBox2);
      this.Controls.Add((Control) this.CheckBox1);
      this.Controls.Add((Control) this.PictureBox1);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (FormIntro);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.ResumeLayout(false);
    }

    private void FormIntro_Load(object sender, EventArgs e)
    {
      this.BackColor = ClassThisProg.DefReader.simsZoneBeige;
      this.PictureBox1.BackColor = ClassThisProg.DefReader.simsZoneBlau;
      this.PictureBox2.Enabled = ClassThisProg.DefReader.isDatabaseOpen;
      this.SetzeTexte();
      this.Show();
    }

    public object SetzeTexte()
    {
      this.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[386]);
      this.IntroLabel1.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[300]);
      this.IntroLabel2.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[301]);
      this.IntroLabel3.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[302]);
      this.IntroLabel4.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[315]);
      this.IntroLabel5.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[316]);
      this.IntroLabel6.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[428]);
      this.IntroLabel7.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[460]);
      this.IntroLabel8.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[510]);
      this.IntroLabel9.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[508]);
      this.IntroLabel10.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[509]);
      this.ToolTip1.SetToolTip((Control) this.PictureBox2, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[45]));
      this.ToolTip1.SetToolTip((Control) this.PictureBox4, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[379]));
      this.ToolTip1.SetToolTip((Control) this.PictureBox3, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[46]));
      this.ToolTip1.SetToolTip((Control) this.PictureBox5, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[313]));
      this.ToolTip1.SetToolTip((Control) this.PictureBox6, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[429]));
      this.ToolTip1.SetToolTip((Control) this.PictureBox7, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[434]));
      this.ToolTip1.SetToolTip((Control) this.PictureBox8, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[470]));
      this.ToolTip1.SetToolTip((Control) this.PictureBox9, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[502]));
      this.ToolTip1.SetToolTip((Control) this.PictureBox10, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[478]));
      this.CheckBox1.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[303]);
      this.Button1.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[304]);
      object obj;
      return obj;
    }

    private void PictureBox2_Click(object sender, EventArgs e)
    {
      if (ClassThisProg.frmForm1 != null)
        return;
      this.Hide();
      MainModule.FrmMain.LadeFormForm1();
      this.Dispose();
    }

    private void PictureBox3_Click(object sender, EventArgs e)
    {
      if (ClassThisProg.frmBAT != null)
        return;
      this.Hide();
      MainModule.FrmMain.LadeFormBAT();
      this.Dispose();
    }

    private void PictureBox4_Click(object sender, EventArgs e)
    {
      if (ClassThisProg.frmReferenz != null)
        return;
      this.Hide();
      MainModule.FrmMain.LadeFormFormReferenz();
      this.Dispose();
    }

    private void Button1_Click1(object sender, EventArgs e) => this.Dispose();

    private void PictureBox5_Click(object sender, EventArgs e)
    {
      if (ClassThisProg.frmForm8 != null)
        return;
      this.Hide();
      MainModule.FrmMain.LadeFormForm8();
      this.Dispose();
    }

    private void PictureBox6_Click(object sender, EventArgs e)
    {
      if (ClassThisProg.frmLotEditor != null)
        return;
      this.Hide();
      MainModule.FrmMain.LadeFormLotEditor();
      this.Dispose();
    }

    private void PictureBox7_Click(object sender, EventArgs e)
    {
      if (ClassThisProg.frmTM != null)
        return;
      this.Hide();
      MainModule.FrmMain.LadeFormTM();
      this.Dispose();
    }

    private void FormIntro_Closed(object sender, EventArgs e) => ClassThisProg.frmIntro = (FormIntro) null;

    private void PictureBox8_Click(object sender, EventArgs e)
    {
      if (ClassThisProg.frmCompare != null)
        return;
      this.Hide();
      MainModule.FrmMain.LadeFormCompare();
      this.Dispose();
    }

    private void PictureBox9_Click(object sender, EventArgs e)
    {
      if (ClassThisProg.frmEditor != null)
        return;
      this.Hide();
      MainModule.FrmMain.LadeFormEditor();
      this.Dispose();
    }

    private void PictureBox10_Click(object sender, EventArgs e)
    {
      if (ClassThisProg.frmDepScanner != null)
        return;
      this.Hide();
      MainModule.FrmMain.LadeFormDepScanner();
      this.Dispose();
    }
  }
}
