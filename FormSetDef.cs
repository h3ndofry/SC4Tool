// Decompiled with JetBrains decompiler
// Type: SC4Tool.FormSetDef
// Assembly: SC4Tool, Version=2.2.7.0, Culture=neutral, PublicKeyToken=null
// MVID: 69A50BC4-87A5-4C5E-BEFC-08274BC6D498
// Assembly location: C:\Program Files (x86)\SC4 Utilities\SC4Tool\SC4Tool.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SC4Tool
{
  public class FormSetDef : Form
  {
    [AccessedThroughProperty("PictureDelete")]
    private PictureBox _PictureDelete;
    [AccessedThroughProperty("InfoLabel3")]
    private Label _InfoLabel3;
    [AccessedThroughProperty("PictureOK8")]
    private PictureBox _PictureOK8;
    [AccessedThroughProperty("InfoLabel8")]
    private Label _InfoLabel8;
    [AccessedThroughProperty("PictureOK7")]
    private PictureBox _PictureOK7;
    [AccessedThroughProperty("PictureBox1")]
    private PictureBox _PictureBox1;
    [AccessedThroughProperty("PictureOK6")]
    private PictureBox _PictureOK6;
    [AccessedThroughProperty("PictureOK5")]
    private PictureBox _PictureOK5;
    [AccessedThroughProperty("PictureOK4")]
    private PictureBox _PictureOK4;
    [AccessedThroughProperty("PictureOK3")]
    private PictureBox _PictureOK3;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("InfoLabel1")]
    private Label _InfoLabel1;
    [AccessedThroughProperty("PictureOK2")]
    private PictureBox _PictureOK2;
    [AccessedThroughProperty("InfoLabel2")]
    private Label _InfoLabel2;
    [AccessedThroughProperty("InfoLabel4")]
    private Label _InfoLabel4;
    [AccessedThroughProperty("InfoLabel5")]
    private Label _InfoLabel5;
    [AccessedThroughProperty("InfoLabel7")]
    private Label _InfoLabel7;
    [AccessedThroughProperty("PictureRead")]
    private PictureBox _PictureRead;
    [AccessedThroughProperty("InfoLabel6")]
    private Label _InfoLabel6;
    [AccessedThroughProperty("PictureOK1")]
    private PictureBox _PictureOK1;
    private IContainer components;

    public FormSetDef()
    {
      this.Paint += new PaintEventHandler(this.FormSetDef_Paint);
      this.Load += new EventHandler(this.FormSetDef_Load);
      this.InitializeComponent();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    internal virtual PictureBox PictureDelete
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._PictureDelete == null)
          ;
        this._PictureDelete = value;
        if (this._PictureDelete == null)
          ;
      }
      get => this._PictureDelete;
    }

    internal virtual PictureBox PictureRead
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._PictureRead == null)
          ;
        this._PictureRead = value;
        if (this._PictureRead == null)
          ;
      }
      get => this._PictureRead;
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

    internal virtual Label InfoLabel3
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._InfoLabel3 == null)
          ;
        this._InfoLabel3 = value;
        if (this._InfoLabel3 == null)
          ;
      }
      get => this._InfoLabel3;
    }

    internal virtual Label InfoLabel1
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._InfoLabel1 == null)
          ;
        this._InfoLabel1 = value;
        if (this._InfoLabel1 == null)
          ;
      }
      get => this._InfoLabel1;
    }

    internal virtual Label InfoLabel2
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._InfoLabel2 == null)
          ;
        this._InfoLabel2 = value;
        if (this._InfoLabel2 == null)
          ;
      }
      get => this._InfoLabel2;
    }

    internal virtual Label InfoLabel4
    {
      get => this._InfoLabel4;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._InfoLabel4 == null)
          ;
        this._InfoLabel4 = value;
        if (this._InfoLabel4 == null)
          ;
      }
    }

    internal virtual Label InfoLabel5
    {
      get => this._InfoLabel5;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._InfoLabel5 == null)
          ;
        this._InfoLabel5 = value;
        if (this._InfoLabel5 == null)
          ;
      }
    }

    internal virtual Label InfoLabel7
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._InfoLabel7 == null)
          ;
        this._InfoLabel7 = value;
        if (this._InfoLabel7 == null)
          ;
      }
      get => this._InfoLabel7;
    }

    internal virtual Label InfoLabel6
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._InfoLabel6 == null)
          ;
        this._InfoLabel6 = value;
        if (this._InfoLabel6 == null)
          ;
      }
      get => this._InfoLabel6;
    }

    internal virtual PictureBox PictureOK1
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._PictureOK1 == null)
          ;
        this._PictureOK1 = value;
        if (this._PictureOK1 == null)
          ;
      }
      get => this._PictureOK1;
    }

    internal virtual PictureBox PictureOK2
    {
      get => this._PictureOK2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._PictureOK2 == null)
          ;
        this._PictureOK2 = value;
        if (this._PictureOK2 == null)
          ;
      }
    }

    internal virtual PictureBox PictureOK3
    {
      get => this._PictureOK3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._PictureOK3 == null)
          ;
        this._PictureOK3 = value;
        if (this._PictureOK3 == null)
          ;
      }
    }

    internal virtual PictureBox PictureOK4
    {
      get => this._PictureOK4;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._PictureOK4 == null)
          ;
        this._PictureOK4 = value;
        if (this._PictureOK4 == null)
          ;
      }
    }

    internal virtual PictureBox PictureOK5
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._PictureOK5 == null)
          ;
        this._PictureOK5 = value;
        if (this._PictureOK5 == null)
          ;
      }
      get => this._PictureOK5;
    }

    internal virtual PictureBox PictureOK6
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._PictureOK6 == null)
          ;
        this._PictureOK6 = value;
        if (this._PictureOK6 == null)
          ;
      }
      get => this._PictureOK6;
    }

    internal virtual PictureBox PictureOK7
    {
      get => this._PictureOK7;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._PictureOK7 == null)
          ;
        this._PictureOK7 = value;
        if (this._PictureOK7 == null)
          ;
      }
    }

    internal virtual Label InfoLabel8
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._InfoLabel8 == null)
          ;
        this._InfoLabel8 = value;
        if (this._InfoLabel8 == null)
          ;
      }
      get => this._InfoLabel8;
    }

    internal virtual PictureBox PictureOK8
    {
      get => this._PictureOK8;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._PictureOK8 == null)
          ;
        this._PictureOK8 = value;
        if (this._PictureOK8 == null)
          ;
      }
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      ResourceManager resourceManager = new ResourceManager(typeof (FormSetDef));
      this.PictureDelete = new PictureBox();
      this.PictureRead = new PictureBox();
      this.PictureOK1 = new PictureBox();
      this.PictureBox1 = new PictureBox();
      this.Label1 = new Label();
      this.InfoLabel3 = new Label();
      this.InfoLabel1 = new Label();
      this.InfoLabel2 = new Label();
      this.InfoLabel4 = new Label();
      this.InfoLabel5 = new Label();
      this.InfoLabel7 = new Label();
      this.InfoLabel6 = new Label();
      this.PictureOK2 = new PictureBox();
      this.PictureOK3 = new PictureBox();
      this.PictureOK4 = new PictureBox();
      this.PictureOK5 = new PictureBox();
      this.PictureOK6 = new PictureBox();
      this.PictureOK7 = new PictureBox();
      this.InfoLabel8 = new Label();
      this.PictureOK8 = new PictureBox();
      this.SuspendLayout();
      this.PictureDelete.Image = (Image) resourceManager.GetObject("PictureDelete.Image");
      PictureBox pictureDelete1 = this.PictureDelete;
      Point point1 = new Point(272, 140);
      Point point2 = point1;
      pictureDelete1.Location = point2;
      this.PictureDelete.Name = "PictureDelete";
      PictureBox pictureDelete2 = this.PictureDelete;
      Size size1 = new Size(16, 16);
      Size size2 = size1;
      pictureDelete2.Size = size2;
      this.PictureDelete.SizeMode = PictureBoxSizeMode.AutoSize;
      this.PictureDelete.TabIndex = 2;
      this.PictureDelete.TabStop = false;
      this.PictureDelete.Visible = false;
      this.PictureRead.Image = (Image) resourceManager.GetObject("PictureRead.Image");
      PictureBox pictureRead1 = this.PictureRead;
      point1 = new Point(28, 112);
      Point point3 = point1;
      pictureRead1.Location = point3;
      this.PictureRead.Name = "PictureRead";
      PictureBox pictureRead2 = this.PictureRead;
      size1 = new Size(16, 20);
      Size size3 = size1;
      pictureRead2.Size = size3;
      this.PictureRead.SizeMode = PictureBoxSizeMode.CenterImage;
      this.PictureRead.TabIndex = 3;
      this.PictureRead.TabStop = false;
      this.PictureRead.Visible = false;
      this.PictureOK1.Image = (Image) resourceManager.GetObject("PictureOK1.Image");
      PictureBox pictureOk1_1 = this.PictureOK1;
      point1 = new Point(320, 116);
      Point point4 = point1;
      pictureOk1_1.Location = point4;
      this.PictureOK1.Name = "PictureOK1";
      PictureBox pictureOk1_2 = this.PictureOK1;
      size1 = new Size(16, 16);
      Size size4 = size1;
      pictureOk1_2.Size = size4;
      this.PictureOK1.SizeMode = PictureBoxSizeMode.AutoSize;
      this.PictureOK1.TabIndex = 4;
      this.PictureOK1.TabStop = false;
      this.PictureOK1.Visible = false;
      this.PictureBox1.BackColor = SystemColors.ActiveCaptionText;
      PictureBox pictureBox1_1 = this.PictureBox1;
      point1 = new Point(4, 8);
      Point point5 = point1;
      pictureBox1_1.Location = point5;
      this.PictureBox1.Name = "PictureBox1";
      PictureBox pictureBox1_2 = this.PictureBox1;
      size1 = new Size(408, 52);
      Size size5 = size1;
      pictureBox1_2.Size = size5;
      this.PictureBox1.TabIndex = 5;
      this.PictureBox1.TabStop = false;
      this.Label1.BackColor = SystemColors.ActiveCaptionText;
      this.Label1.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label1.ForeColor = SystemColors.ControlText;
      Label label1_1 = this.Label1;
      point1 = new Point(8, 24);
      Point point6 = point1;
      label1_1.Location = point6;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      size1 = new Size(204, 20);
      Size size6 = size1;
      label1_2.Size = size6;
      this.Label1.TabIndex = 6;
      this.Label1.Text = "SC4Tool Startup";
      this.InfoLabel3.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label infoLabel3_1 = this.InfoLabel3;
      point1 = new Point(56, 184);
      Point point7 = point1;
      infoLabel3_1.Location = point7;
      this.InfoLabel3.Name = "InfoLabel3";
      Label infoLabel3_2 = this.InfoLabel3;
      size1 = new Size(188, 20);
      Size size7 = size1;
      infoLabel3_2.Size = size7;
      this.InfoLabel3.TabIndex = 7;
      this.InfoLabel3.Text = "read Default Language";
      this.InfoLabel3.TextAlign = ContentAlignment.MiddleLeft;
      this.InfoLabel1.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label infoLabel1_1 = this.InfoLabel1;
      point1 = new Point(56, 112);
      Point point8 = point1;
      infoLabel1_1.Location = point8;
      this.InfoLabel1.Name = "InfoLabel1";
      Label infoLabel1_2 = this.InfoLabel1;
      size1 = new Size(188, 20);
      Size size8 = size1;
      infoLabel1_2.Size = size8;
      this.InfoLabel1.TabIndex = 8;
      this.InfoLabel1.Text = "check paths and files";
      this.InfoLabel1.TextAlign = ContentAlignment.MiddleLeft;
      this.InfoLabel2.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label infoLabel2_1 = this.InfoLabel2;
      point1 = new Point(56, 148);
      Point point9 = point1;
      infoLabel2_1.Location = point9;
      this.InfoLabel2.Name = "InfoLabel2";
      Label infoLabel2_2 = this.InfoLabel2;
      size1 = new Size(188, 20);
      Size size9 = size1;
      infoLabel2_2.Size = size9;
      this.InfoLabel2.TabIndex = 9;
      this.InfoLabel2.Text = "check Groups.xml";
      this.InfoLabel2.TextAlign = ContentAlignment.MiddleLeft;
      this.InfoLabel4.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label infoLabel4_1 = this.InfoLabel4;
      point1 = new Point(56, 220);
      Point point10 = point1;
      infoLabel4_1.Location = point10;
      this.InfoLabel4.Name = "InfoLabel4";
      Label infoLabel4_2 = this.InfoLabel4;
      size1 = new Size(188, 20);
      Size size10 = size1;
      infoLabel4_2.Size = size10;
      this.InfoLabel4.TabIndex = 10;
      this.InfoLabel4.Text = "read Settings.dat";
      this.InfoLabel4.TextAlign = ContentAlignment.MiddleLeft;
      this.InfoLabel5.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label infoLabel5_1 = this.InfoLabel5;
      point1 = new Point(56, 256);
      Point point11 = point1;
      infoLabel5_1.Location = point11;
      this.InfoLabel5.Name = "InfoLabel5";
      Label infoLabel5_2 = this.InfoLabel5;
      size1 = new Size(188, 20);
      Size size11 = size1;
      infoLabel5_2.Size = size11;
      this.InfoLabel5.TabIndex = 11;
      this.InfoLabel5.Text = "read new_properties.xml";
      this.InfoLabel5.TextAlign = ContentAlignment.MiddleLeft;
      this.InfoLabel7.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label infoLabel7_1 = this.InfoLabel7;
      point1 = new Point(56, 328);
      Point point12 = point1;
      infoLabel7_1.Location = point12;
      this.InfoLabel7.Name = "InfoLabel7";
      Label infoLabel7_2 = this.InfoLabel7;
      size1 = new Size(188, 20);
      Size size12 = size1;
      infoLabel7_2.Size = size12;
      this.InfoLabel7.TabIndex = 12;
      this.InfoLabel7.Text = "connect to database";
      this.InfoLabel7.TextAlign = ContentAlignment.MiddleLeft;
      this.InfoLabel6.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label infoLabel6_1 = this.InfoLabel6;
      point1 = new Point(56, 292);
      Point point13 = point1;
      infoLabel6_1.Location = point13;
      this.InfoLabel6.Name = "InfoLabel6";
      Label infoLabel6_2 = this.InfoLabel6;
      size1 = new Size(188, 20);
      Size size13 = size1;
      infoLabel6_2.Size = size13;
      this.InfoLabel6.TabIndex = 13;
      this.InfoLabel6.Text = "load pictures";
      this.InfoLabel6.TextAlign = ContentAlignment.MiddleLeft;
      this.PictureOK2.Image = (Image) resourceManager.GetObject("PictureOK2.Image");
      PictureBox pictureOk2_1 = this.PictureOK2;
      point1 = new Point(316, 148);
      Point point14 = point1;
      pictureOk2_1.Location = point14;
      this.PictureOK2.Name = "PictureOK2";
      PictureBox pictureOk2_2 = this.PictureOK2;
      size1 = new Size(16, 16);
      Size size14 = size1;
      pictureOk2_2.Size = size14;
      this.PictureOK2.SizeMode = PictureBoxSizeMode.AutoSize;
      this.PictureOK2.TabIndex = 14;
      this.PictureOK2.TabStop = false;
      this.PictureOK2.Visible = false;
      this.PictureOK3.Image = (Image) resourceManager.GetObject("PictureOK3.Image");
      PictureBox pictureOk3_1 = this.PictureOK3;
      point1 = new Point(312, 176);
      Point point15 = point1;
      pictureOk3_1.Location = point15;
      this.PictureOK3.Name = "PictureOK3";
      PictureBox pictureOk3_2 = this.PictureOK3;
      size1 = new Size(16, 16);
      Size size15 = size1;
      pictureOk3_2.Size = size15;
      this.PictureOK3.SizeMode = PictureBoxSizeMode.AutoSize;
      this.PictureOK3.TabIndex = 15;
      this.PictureOK3.TabStop = false;
      this.PictureOK3.Visible = false;
      this.PictureOK4.Image = (Image) resourceManager.GetObject("PictureOK4.Image");
      PictureBox pictureOk4_1 = this.PictureOK4;
      point1 = new Point(312, 200);
      Point point16 = point1;
      pictureOk4_1.Location = point16;
      this.PictureOK4.Name = "PictureOK4";
      PictureBox pictureOk4_2 = this.PictureOK4;
      size1 = new Size(16, 16);
      Size size16 = size1;
      pictureOk4_2.Size = size16;
      this.PictureOK4.SizeMode = PictureBoxSizeMode.AutoSize;
      this.PictureOK4.TabIndex = 16;
      this.PictureOK4.TabStop = false;
      this.PictureOK4.Visible = false;
      this.PictureOK5.Image = (Image) resourceManager.GetObject("PictureOK5.Image");
      PictureBox pictureOk5_1 = this.PictureOK5;
      point1 = new Point(316, 224);
      Point point17 = point1;
      pictureOk5_1.Location = point17;
      this.PictureOK5.Name = "PictureOK5";
      PictureBox pictureOk5_2 = this.PictureOK5;
      size1 = new Size(16, 16);
      Size size17 = size1;
      pictureOk5_2.Size = size17;
      this.PictureOK5.SizeMode = PictureBoxSizeMode.AutoSize;
      this.PictureOK5.TabIndex = 17;
      this.PictureOK5.TabStop = false;
      this.PictureOK5.Visible = false;
      this.PictureOK6.Image = (Image) resourceManager.GetObject("PictureOK6.Image");
      PictureBox pictureOk6_1 = this.PictureOK6;
      point1 = new Point(312, 256);
      Point point18 = point1;
      pictureOk6_1.Location = point18;
      this.PictureOK6.Name = "PictureOK6";
      PictureBox pictureOk6_2 = this.PictureOK6;
      size1 = new Size(16, 16);
      Size size18 = size1;
      pictureOk6_2.Size = size18;
      this.PictureOK6.SizeMode = PictureBoxSizeMode.AutoSize;
      this.PictureOK6.TabIndex = 18;
      this.PictureOK6.TabStop = false;
      this.PictureOK6.Visible = false;
      this.PictureOK7.Image = (Image) resourceManager.GetObject("PictureOK7.Image");
      PictureBox pictureOk7_1 = this.PictureOK7;
      point1 = new Point(308, 284);
      Point point19 = point1;
      pictureOk7_1.Location = point19;
      this.PictureOK7.Name = "PictureOK7";
      PictureBox pictureOk7_2 = this.PictureOK7;
      size1 = new Size(16, 16);
      Size size19 = size1;
      pictureOk7_2.Size = size19;
      this.PictureOK7.SizeMode = PictureBoxSizeMode.AutoSize;
      this.PictureOK7.TabIndex = 19;
      this.PictureOK7.TabStop = false;
      this.PictureOK7.Visible = false;
      this.InfoLabel8.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label infoLabel8_1 = this.InfoLabel8;
      point1 = new Point(56, 364);
      Point point20 = point1;
      infoLabel8_1.Location = point20;
      this.InfoLabel8.Name = "InfoLabel8";
      Label infoLabel8_2 = this.InfoLabel8;
      size1 = new Size(188, 20);
      Size size20 = size1;
      infoLabel8_2.Size = size20;
      this.InfoLabel8.TabIndex = 20;
      this.InfoLabel8.Text = "check SC4Files.xml";
      this.InfoLabel8.TextAlign = ContentAlignment.MiddleLeft;
      this.PictureOK8.Image = (Image) resourceManager.GetObject("PictureOK8.Image");
      PictureBox pictureOk8_1 = this.PictureOK8;
      point1 = new Point(288, 304);
      Point point21 = point1;
      pictureOk8_1.Location = point21;
      this.PictureOK8.Name = "PictureOK8";
      PictureBox pictureOk8_2 = this.PictureOK8;
      size1 = new Size(16, 16);
      Size size21 = size1;
      pictureOk8_2.Size = size21;
      this.PictureOK8.SizeMode = PictureBoxSizeMode.AutoSize;
      this.PictureOK8.TabIndex = 21;
      this.PictureOK8.TabStop = false;
      this.PictureOK8.Visible = false;
      size1 = new Size(5, 13);
      this.AutoScaleBaseSize = size1;
      size1 = new Size(420, 404);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.PictureOK8);
      this.Controls.Add((Control) this.InfoLabel8);
      this.Controls.Add((Control) this.PictureOK7);
      this.Controls.Add((Control) this.PictureOK6);
      this.Controls.Add((Control) this.PictureOK5);
      this.Controls.Add((Control) this.PictureOK4);
      this.Controls.Add((Control) this.PictureOK3);
      this.Controls.Add((Control) this.PictureOK2);
      this.Controls.Add((Control) this.InfoLabel6);
      this.Controls.Add((Control) this.InfoLabel7);
      this.Controls.Add((Control) this.InfoLabel5);
      this.Controls.Add((Control) this.InfoLabel4);
      this.Controls.Add((Control) this.InfoLabel2);
      this.Controls.Add((Control) this.InfoLabel1);
      this.Controls.Add((Control) this.InfoLabel3);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.PictureBox1);
      this.Controls.Add((Control) this.PictureOK1);
      this.Controls.Add((Control) this.PictureRead);
      this.Controls.Add((Control) this.PictureDelete);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Name = nameof (FormSetDef);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Start SC4Tool....";
      this.ResumeLayout(false);
    }

    private void FormSetDef_Paint(object sender, PaintEventArgs e)
    {
      string s = "SC4Tool";
      SolidBrush solidBrush = new SolidBrush(Color.Gainsboro);
      StringFormat format = new StringFormat();
      PointF point = new PointF();
      SizeF sizeF = new SizeF();
      Font font = new Font("Arial", 48f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      format.FormatFlags = StringFormatFlags.DirectionVertical;
      point.X = (float) checked (this.Width - 80);
      point.Y = 75f;
      e.Graphics.DrawString(s, font, (Brush) solidBrush, point, format);
    }

    private void FormSetDef_Load(object sender, EventArgs e)
    {
      this.Show();
      this.Cursor = Cursors.AppStarting;
      this.PictureRead.Visible = true;
      try
      {
        this.PictureRead.Left = 28;
        this.PictureRead.Top = this.InfoLabel1.Top;
        Application.DoEvents();
        string text1 = "Error creating Log-Dir";
        if (!ClassThisProg.DefReader.Startup_Main())
        {
          this.PictureDelete.Left = this.PictureRead.Left;
          this.PictureDelete.Top = this.PictureRead.Top;
          this.PictureRead.Visible = false;
          this.PictureDelete.Visible = true;
          Application.DoEvents();
          this.Cursor = Cursors.Default;
          int num = (int) MessageBox.Show((IWin32Window) this, text1, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          ProjectData.EndApp();
        }
        StreamWriter streamWriter = new StreamWriter(ClassThisProg.DefReader.LogDir + "\\Startup.log");
        DateTime now1 = DateTime.Now;
        streamWriter.WriteLine(now1.ToString() + "....................Start");
        string text2 = "Error creating directories";
        string sLeft1 = ClassThisProg.DefReader.Startup_GettingFilesAndDirs(streamWriter);
        DateTime now2;
        if (StringType.StrCmp(sLeft1, "", false) != 0)
        {
          now2 = DateTime.Now;
          streamWriter.WriteLine(now2.ToString() + "...................." + sLeft1);
          streamWriter.Close();
          this.PictureDelete.Left = this.PictureRead.Left;
          this.PictureDelete.Top = this.PictureRead.Top;
          this.PictureRead.Visible = false;
          this.PictureDelete.Visible = true;
          Application.DoEvents();
          this.Cursor = Cursors.Default;
          int num = (int) MessageBox.Show((IWin32Window) this, text2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          ProjectData.EndApp();
        }
        this.PictureOK1.Left = this.PictureRead.Left;
        this.PictureOK1.Top = this.PictureRead.Top;
        this.PictureOK1.Visible = true;
        this.PictureRead.Left = 28;
        this.PictureRead.Top = this.InfoLabel2.Top;
        Application.DoEvents();
        string text3 = "Error reading Groups.xsd,Groups.xml!";
        string sLeft2 = ClassThisProg.DefReader.Startup_CheckGroupsxml(streamWriter);
        if (StringType.StrCmp(sLeft2, "", false) != 0)
        {
          now2 = DateTime.Now;
          streamWriter.WriteLine(now2.ToString() + "...................." + sLeft2);
          streamWriter.Close();
          this.PictureDelete.Left = this.PictureRead.Left;
          this.PictureDelete.Top = this.PictureRead.Top;
          this.PictureRead.Visible = false;
          this.PictureDelete.Visible = true;
          Application.DoEvents();
          this.Cursor = Cursors.Default;
          int num = (int) MessageBox.Show((IWin32Window) this, text3, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          ProjectData.EndApp();
        }
        this.PictureOK2.Left = this.PictureRead.Left;
        this.PictureOK2.Top = this.PictureRead.Top;
        this.PictureOK2.Visible = true;
        this.PictureRead.Left = 28;
        this.PictureRead.Top = this.InfoLabel3.Top;
        Application.DoEvents();
        string text4 = "Can't create default Language!";
        string defaultLanguage = ClassThisProg.DefReader.Startup_CreateDefaultLanguage(streamWriter);
        if (StringType.StrCmp(defaultLanguage, "", false) != 0)
        {
          now2 = DateTime.Now;
          streamWriter.WriteLine(now2.ToString() + "...................." + defaultLanguage);
          streamWriter.Close();
          this.PictureDelete.Left = this.PictureRead.Left;
          this.PictureDelete.Top = this.PictureRead.Top;
          this.PictureRead.Visible = false;
          this.PictureDelete.Visible = true;
          Application.DoEvents();
          this.Cursor = Cursors.Default;
          int num = (int) MessageBox.Show((IWin32Window) this, text4, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          ProjectData.EndApp();
        }
        this.PictureOK3.Left = this.PictureRead.Left;
        this.PictureOK3.Top = this.PictureRead.Top;
        this.PictureOK3.Visible = true;
        this.PictureRead.Left = 28;
        this.PictureRead.Top = this.InfoLabel4.Top;
        Application.DoEvents();
        string text5 = "Error reading Settings!";
        string sLeft3 = ClassThisProg.DefReader.Startup_ReadSettingsDat(streamWriter);
        if (StringType.StrCmp(sLeft3, "", false) != 0)
        {
          now2 = DateTime.Now;
          streamWriter.WriteLine(now2.ToString() + "...................." + sLeft3);
          streamWriter.Close();
          this.PictureDelete.Left = this.PictureRead.Left;
          this.PictureDelete.Top = this.PictureRead.Top;
          this.PictureRead.Visible = false;
          this.PictureDelete.Visible = true;
          Application.DoEvents();
          this.Cursor = Cursors.Default;
          int num = (int) MessageBox.Show((IWin32Window) this, text5, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          ProjectData.EndApp();
        }
        this.PictureOK4.Left = this.PictureRead.Left;
        this.PictureOK4.Top = this.PictureRead.Top;
        this.PictureOK4.Visible = true;
        this.PictureRead.Left = 28;
        this.PictureRead.Top = this.InfoLabel5.Top;
        Application.DoEvents();
        string text6 = "Error reading new_properties.xml,new_properties.xsd!";
        string sLeft4 = ClassThisProg.DefReader.Startup_ReadPropertiesXML(streamWriter);
        if (StringType.StrCmp(sLeft4, "", false) != 0)
        {
          now2 = DateTime.Now;
          streamWriter.WriteLine(now2.ToString() + "...................." + sLeft4);
          streamWriter.Close();
          this.PictureDelete.Left = this.PictureRead.Left;
          this.PictureDelete.Top = this.PictureRead.Top;
          this.PictureRead.Visible = false;
          this.PictureDelete.Visible = true;
          Application.DoEvents();
          this.Cursor = Cursors.Default;
          int num = (int) MessageBox.Show((IWin32Window) this, text6, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          ProjectData.EndApp();
        }
        this.PictureOK5.Left = this.PictureRead.Left;
        this.PictureOK5.Top = this.PictureRead.Top;
        this.PictureOK5.Visible = true;
        this.PictureRead.Left = 28;
        this.PictureRead.Top = this.InfoLabel6.Top;
        Application.DoEvents();
        string text7 = "Error loading pictures";
        string sLeft5 = ClassThisProg.DefReader.Startup_LoadPictures(streamWriter);
        if (StringType.StrCmp(sLeft5, "", false) != 0)
        {
          now2 = DateTime.Now;
          streamWriter.WriteLine(now2.ToString() + "...................." + sLeft5);
          streamWriter.Close();
          this.PictureDelete.Left = this.PictureRead.Left;
          this.PictureDelete.Top = this.PictureRead.Top;
          this.PictureRead.Visible = false;
          this.PictureDelete.Visible = true;
          Application.DoEvents();
          this.Cursor = Cursors.Default;
          int num = (int) MessageBox.Show((IWin32Window) this, text7, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          ProjectData.EndApp();
        }
        this.PictureOK6.Left = this.PictureRead.Left;
        this.PictureOK6.Top = this.PictureRead.Top;
        this.PictureOK6.Visible = true;
        this.PictureRead.Left = 28;
        this.PictureRead.Top = this.InfoLabel7.Top;
        Application.DoEvents();
        string sLeft6 = ClassThisProg.DefReader.Startup_LoadDatabase(streamWriter);
        this.PictureRead.Visible = false;
        if (StringType.StrCmp(sLeft6, "", false) != 0)
        {
          this.PictureDelete.Left = this.PictureRead.Left;
          this.PictureDelete.Top = this.PictureRead.Top;
          this.PictureDelete.Visible = true;
        }
        else
        {
          this.PictureOK7.Left = this.PictureRead.Left;
          this.PictureOK7.Top = this.PictureRead.Top;
          this.PictureOK7.Visible = true;
        }
        Application.DoEvents();
        this.PictureRead.Left = 28;
        this.PictureRead.Top = this.InfoLabel8.Top;
        Application.DoEvents();
        string text8 = "Error reading SC4Files.xsd,SC4Files.xml!";
        string sLeft7 = ClassThisProg.DefReader.Startup_GettingSC4FilesXML(streamWriter);
        if (StringType.StrCmp(sLeft7, "", false) != 0)
        {
          now2 = DateTime.Now;
          streamWriter.WriteLine(now2.ToString() + "...................." + sLeft7);
          streamWriter.Close();
          this.PictureDelete.Left = this.PictureRead.Left;
          this.PictureDelete.Top = this.PictureRead.Top;
          this.PictureRead.Visible = false;
          this.PictureDelete.Visible = true;
          Application.DoEvents();
          this.Cursor = Cursors.Default;
          int num = (int) MessageBox.Show((IWin32Window) this, text8, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          ProjectData.EndApp();
        }
        this.PictureOK8.Left = this.PictureRead.Left;
        this.PictureOK8.Top = this.PictureRead.Top;
        this.PictureOK8.Visible = true;
        now2 = DateTime.Now;
        streamWriter.WriteLine(now2.ToString() + "....................Settings successfully loaded");
        streamWriter.WriteLine(now2.ToString() + " SC4Path............" + ClassThisProg.DefReader.SC4Path);
        streamWriter.WriteLine(now2.ToString() + " SC4LocalPath......." + ClassThisProg.DefReader.sc4LocalPath);
        TimeSpan timeSpan = DateAndTime.Now.Subtract(now1);
        string[] strArray = timeSpan.ToString().Split(':');
        if (strArray.GetUpperBound(0) == 2)
          streamWriter.WriteLine(now2.ToString() + " Time to load......." + strArray[2] + " sec");
        else
          streamWriter.WriteLine(now2.ToString() + " Time to load......." + timeSpan.ToString());
        streamWriter.Close();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Cursor = Cursors.Default;
        int num = (int) MessageBox.Show((IWin32Window) this, "Error reading Settings", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        ProjectData.EndApp();
        ProjectData.ClearProjectError();
      }
      this.Cursor = Cursors.Default;
      this.Dispose();
    }
  }
}
