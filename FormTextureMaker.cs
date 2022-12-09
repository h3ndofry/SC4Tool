// Decompiled with JetBrains decompiler
// Type: SC4Tool.FormTextureMaker
// Assembly: SC4Tool, Version=2.2.7.0, Culture=neutral, PublicKeyToken=null
// MVID: 69A50BC4-87A5-4C5E-BEFC-08274BC6D498
// Assembly location: C:\Program Files (x86)\SC4 Utilities\SC4Tool\SC4Tool.exe

using FSHLib;
using Microsoft.VisualBasic;
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

namespace SC4Tool
{
  public class FormTextureMaker : Form
  {
    [AccessedThroughProperty("ToolBar1")]
    private TD.SandBar.ToolBar _ToolBar1;
    [AccessedThroughProperty("ImageList1")]
    private ImageList _ImageList1;
    [AccessedThroughProperty("CheckBox2")]
    private CheckBox _CheckBox2;
    [AccessedThroughProperty("GroupBox1")]
    private GroupBox _GroupBox1;
    [AccessedThroughProperty("ButtonItem1")]
    private ButtonItem _ButtonItem1;
    [AccessedThroughProperty("ButtonItem2")]
    private ButtonItem _ButtonItem2;
    [AccessedThroughProperty("LinkLabel1")]
    private LinkLabel _LinkLabel1;
    [AccessedThroughProperty("Label6")]
    private Label _Label6;
    [AccessedThroughProperty("MinRangeLabel")]
    private Label _MinRangeLabel;
    [AccessedThroughProperty("MaxRangeLabel")]
    private Label _MaxRangeLabel;
    [AccessedThroughProperty("Label8")]
    private Label _Label8;
    [AccessedThroughProperty("Label7")]
    private Label _Label7;
    [AccessedThroughProperty("CopyAlpha")]
    private PictureBox _CopyAlpha;
    [AccessedThroughProperty("CopyBitmap")]
    private PictureBox _CopyBitmap;
    [AccessedThroughProperty("Button3")]
    private Button _Button3;
    [AccessedThroughProperty("GroupBox2")]
    private GroupBox _GroupBox2;
    [AccessedThroughProperty("GroupBox3")]
    private GroupBox _GroupBox3;
    [AccessedThroughProperty("GroupBox4")]
    private GroupBox _GroupBox4;
    [AccessedThroughProperty("GroupBox5")]
    private GroupBox _GroupBox5;
    [AccessedThroughProperty("GroupBox6")]
    private GroupBox _GroupBox6;
    [AccessedThroughProperty("InstanceTextBox")]
    private TextBox _InstanceTextBox;
    [AccessedThroughProperty("RadioButton1")]
    private RadioButton _RadioButton1;
    [AccessedThroughProperty("RadioButton2")]
    private RadioButton _RadioButton2;
    [AccessedThroughProperty("Label_8")]
    private Label _Label_8;
    [AccessedThroughProperty("Label_16")]
    private Label _Label_16;
    [AccessedThroughProperty("Label_32")]
    private Label _Label_32;
    [AccessedThroughProperty("Label_64")]
    private Label _Label_64;
    [AccessedThroughProperty("Label_128")]
    private Label _Label_128;
    [AccessedThroughProperty("Open_64")]
    private PictureBox _Open_64;
    [AccessedThroughProperty("Open_32")]
    private PictureBox _Open_32;
    [AccessedThroughProperty("Open_16")]
    private PictureBox _Open_16;
    [AccessedThroughProperty("Open_8")]
    private PictureBox _Open_8;
    [AccessedThroughProperty("Label5")]
    private Label _Label5;
    [AccessedThroughProperty("Open_A_128")]
    private PictureBox _Open_A_128;
    [AccessedThroughProperty("Pic_8")]
    private PictureBox _Pic_8;
    [AccessedThroughProperty("Pic_16")]
    private PictureBox _Pic_16;
    [AccessedThroughProperty("CheckBox1")]
    private CheckBox _CheckBox1;
    [AccessedThroughProperty("A_Pic_128")]
    private PictureBox _A_Pic_128;
    [AccessedThroughProperty("A_Pic_64")]
    private PictureBox _A_Pic_64;
    [AccessedThroughProperty("A_Pic_32")]
    private PictureBox _A_Pic_32;
    [AccessedThroughProperty("A_Pic_16")]
    private PictureBox _A_Pic_16;
    [AccessedThroughProperty("A_Pic_8")]
    private PictureBox _A_Pic_8;
    [AccessedThroughProperty("Label20")]
    private Label _Label20;
    [AccessedThroughProperty("Label19")]
    private Label _Label19;
    [AccessedThroughProperty("Pic_32")]
    private PictureBox _Pic_32;
    [AccessedThroughProperty("Label3")]
    private Label _Label3;
    [AccessedThroughProperty("Label18")]
    private Label _Label18;
    [AccessedThroughProperty("A_Label_128")]
    private Label _A_Label_128;
    [AccessedThroughProperty("Label2")]
    private Label _Label2;
    [AccessedThroughProperty("A_Label_64")]
    private Label _A_Label_64;
    [AccessedThroughProperty("Label17")]
    private Label _Label17;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("Button1")]
    private Button _Button1;
    [AccessedThroughProperty("Label4")]
    private Label _Label4;
    [AccessedThroughProperty("Label16")]
    private Label _Label16;
    [AccessedThroughProperty("Open_A_32")]
    private PictureBox _Open_A_32;
    [AccessedThroughProperty("A_Label_32")]
    private Label _A_Label_32;
    [AccessedThroughProperty("A_Label_16")]
    private Label _A_Label_16;
    [AccessedThroughProperty("ToolTip1")]
    private ToolTip _ToolTip1;
    [AccessedThroughProperty("Open_A_8")]
    private PictureBox _Open_A_8;
    [AccessedThroughProperty("A_Label_8")]
    private Label _A_Label_8;
    [AccessedThroughProperty("Open_128")]
    private PictureBox _Open_128;
    [AccessedThroughProperty("Pic_128")]
    private PictureBox _Pic_128;
    [AccessedThroughProperty("Pic_64")]
    private PictureBox _Pic_64;
    [AccessedThroughProperty("Open_A_16")]
    private PictureBox _Open_A_16;
    [AccessedThroughProperty("Open_A_64")]
    private PictureBox _Open_A_64;
    private bool HasAddedImages;
    private string CurrentDatei;
    public bool isNewFile;
    private TextureReader.TextureDef CurrentPic_128;
    private TextureReader.TextureDef CurrentPic_64;
    private TextureReader.TextureDef CurrentPic_32;
    private TextureReader.TextureDef CurrentPic_16;
    private TextureReader.TextureDef CurrentPic_8;
    private TextureReader.TextureDef CurrentPic_A_128;
    private TextureReader.TextureDef CurrentPic_A_64;
    private TextureReader.TextureDef CurrentPic_A_32;
    private TextureReader.TextureDef CurrentPic_A_16;
    private TextureReader.TextureDef CurrentPic_A_8;
    private FormTextureMaker.eMouseState MouseState;
    private IContainer components;

    public FormTextureMaker(string EingabeDatei, bool MakeNewFile)
    {
      this.Load += new EventHandler(this.FormTextureMaker_Load);
      this.Closed += new EventHandler(this.FormTextureMaker_Closed);
      this.MouseState = FormTextureMaker.eMouseState.NoMouse;
      this.InitializeComponent();
      this.CurrentDatei = EingabeDatei;
      this.isNewFile = MakeNewFile;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
      ClassThisProg.frmTextureMaker = (FormTextureMaker) null;
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

    internal virtual Label Label_8
    {
      get => this._Label_8;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Label_8 == null)
          ;
        this._Label_8 = value;
        if (this._Label_8 == null)
          ;
      }
    }

    internal virtual Label Label_16
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Label_16 == null)
          ;
        this._Label_16 = value;
        if (this._Label_16 == null)
          ;
      }
      get => this._Label_16;
    }

    internal virtual Label Label_32
    {
      get => this._Label_32;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Label_32 == null)
          ;
        this._Label_32 = value;
        if (this._Label_32 == null)
          ;
      }
    }

    internal virtual Label Label_64
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Label_64 == null)
          ;
        this._Label_64 = value;
        if (this._Label_64 == null)
          ;
      }
      get => this._Label_64;
    }

    internal virtual Label Label_128
    {
      get => this._Label_128;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Label_128 == null)
          ;
        this._Label_128 = value;
        if (this._Label_128 == null)
          ;
      }
    }

    internal virtual PictureBox Open_64
    {
      get => this._Open_64;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Open_64 != null)
        {
          this._Open_64.MouseLeave -= new EventHandler(this.Open_64_MouseLeave);
          this._Open_64.MouseEnter -= new EventHandler(this.Open_64_MouseEnter);
          this._Open_64.MouseUp -= new MouseEventHandler(this.Open_64_MouseUp);
          this._Open_64.MouseDown -= new MouseEventHandler(this.Open_64_MouseDown);
          this._Open_64.Paint -= new PaintEventHandler(this.Open_64_Paint);
          this._Open_64.Click -= new EventHandler(this.Open_64_Click);
        }
        this._Open_64 = value;
        if (this._Open_64 == null)
          return;
        this._Open_64.MouseLeave += new EventHandler(this.Open_64_MouseLeave);
        this._Open_64.MouseEnter += new EventHandler(this.Open_64_MouseEnter);
        this._Open_64.MouseUp += new MouseEventHandler(this.Open_64_MouseUp);
        this._Open_64.MouseDown += new MouseEventHandler(this.Open_64_MouseDown);
        this._Open_64.Paint += new PaintEventHandler(this.Open_64_Paint);
        this._Open_64.Click += new EventHandler(this.Open_64_Click);
      }
    }

    internal virtual PictureBox Open_32
    {
      get => this._Open_32;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Open_32 != null)
        {
          this._Open_32.MouseLeave -= new EventHandler(this.Open_32_MouseLeave);
          this._Open_32.MouseEnter -= new EventHandler(this.Open_32_MouseEnter);
          this._Open_32.MouseUp -= new MouseEventHandler(this.Open_32_MouseUp);
          this._Open_32.MouseDown -= new MouseEventHandler(this.Open_32_MouseDown);
          this._Open_32.Paint -= new PaintEventHandler(this.Open_32_Paint);
          this._Open_32.Click -= new EventHandler(this.Open_32_Click);
        }
        this._Open_32 = value;
        if (this._Open_32 == null)
          return;
        this._Open_32.MouseLeave += new EventHandler(this.Open_32_MouseLeave);
        this._Open_32.MouseEnter += new EventHandler(this.Open_32_MouseEnter);
        this._Open_32.MouseUp += new MouseEventHandler(this.Open_32_MouseUp);
        this._Open_32.MouseDown += new MouseEventHandler(this.Open_32_MouseDown);
        this._Open_32.Paint += new PaintEventHandler(this.Open_32_Paint);
        this._Open_32.Click += new EventHandler(this.Open_32_Click);
      }
    }

    internal virtual PictureBox Open_16
    {
      get => this._Open_16;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Open_16 != null)
        {
          this._Open_16.MouseLeave -= new EventHandler(this.Open_16_MouseLeave);
          this._Open_16.MouseEnter -= new EventHandler(this.Open_16_MouseEnter);
          this._Open_16.MouseUp -= new MouseEventHandler(this.Open_16_MouseUp);
          this._Open_16.MouseDown -= new MouseEventHandler(this.Open_16_MouseDown);
          this._Open_16.Paint -= new PaintEventHandler(this.Open_16_Paint);
          this._Open_16.Click -= new EventHandler(this.Open_16_Click);
        }
        this._Open_16 = value;
        if (this._Open_16 == null)
          return;
        this._Open_16.MouseLeave += new EventHandler(this.Open_16_MouseLeave);
        this._Open_16.MouseEnter += new EventHandler(this.Open_16_MouseEnter);
        this._Open_16.MouseUp += new MouseEventHandler(this.Open_16_MouseUp);
        this._Open_16.MouseDown += new MouseEventHandler(this.Open_16_MouseDown);
        this._Open_16.Paint += new PaintEventHandler(this.Open_16_Paint);
        this._Open_16.Click += new EventHandler(this.Open_16_Click);
      }
    }

    internal virtual PictureBox Open_8
    {
      get => this._Open_8;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Open_8 != null)
        {
          this._Open_8.MouseLeave -= new EventHandler(this.Open_8_MouseLeave);
          this._Open_8.MouseEnter -= new EventHandler(this.Open_8_MouseEnter);
          this._Open_8.MouseUp -= new MouseEventHandler(this.Open_8_MouseUp);
          this._Open_8.MouseDown -= new MouseEventHandler(this.Open_8_MouseDown);
          this._Open_8.Paint -= new PaintEventHandler(this.Open_8_Paint);
          this._Open_8.Click -= new EventHandler(this.Open_8_Click);
        }
        this._Open_8 = value;
        if (this._Open_8 == null)
          return;
        this._Open_8.MouseLeave += new EventHandler(this.Open_8_MouseLeave);
        this._Open_8.MouseEnter += new EventHandler(this.Open_8_MouseEnter);
        this._Open_8.MouseUp += new MouseEventHandler(this.Open_8_MouseUp);
        this._Open_8.MouseDown += new MouseEventHandler(this.Open_8_MouseDown);
        this._Open_8.Paint += new PaintEventHandler(this.Open_8_Paint);
        this._Open_8.Click += new EventHandler(this.Open_8_Click);
      }
    }

    internal virtual Label Label5
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Label5 == null)
          ;
        this._Label5 = value;
        if (this._Label5 == null)
          ;
      }
      get => this._Label5;
    }

    internal virtual Label Label4
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Label4 == null)
          ;
        this._Label4 = value;
        if (this._Label4 == null)
          ;
      }
      get => this._Label4;
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

    internal virtual Label Label2
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Label2 == null)
          ;
        this._Label2 = value;
        if (this._Label2 == null)
          ;
      }
      get => this._Label2;
    }

    internal virtual Label Label1
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Label1 == null)
          ;
        this._Label1 = value;
        if (this._Label1 == null)
          ;
      }
      get => this._Label1;
    }

    internal virtual PictureBox Pic_8
    {
      get => this._Pic_8;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Pic_8 == null)
          ;
        this._Pic_8 = value;
        if (this._Pic_8 == null)
          ;
      }
    }

    internal virtual PictureBox Pic_16
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Pic_16 == null)
          ;
        this._Pic_16 = value;
        if (this._Pic_16 == null)
          ;
      }
      get => this._Pic_16;
    }

    internal virtual PictureBox Pic_32
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Pic_32 == null)
          ;
        this._Pic_32 = value;
        if (this._Pic_32 == null)
          ;
      }
      get => this._Pic_32;
    }

    internal virtual PictureBox Pic_64
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Pic_64 == null)
          ;
        this._Pic_64 = value;
        if (this._Pic_64 == null)
          ;
      }
      get => this._Pic_64;
    }

    internal virtual PictureBox Pic_128
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Pic_128 == null)
          ;
        this._Pic_128 = value;
        if (this._Pic_128 == null)
          ;
      }
      get => this._Pic_128;
    }

    internal virtual PictureBox Open_128
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Open_128 != null)
        {
          this._Open_128.MouseLeave -= new EventHandler(this.Open_128_MouseLeave);
          this._Open_128.MouseEnter -= new EventHandler(this.Open_128_MouseEnter);
          this._Open_128.MouseUp -= new MouseEventHandler(this.Open_128_MouseUp);
          this._Open_128.MouseDown -= new MouseEventHandler(this.Open_128_MouseDown);
          this._Open_128.Paint -= new PaintEventHandler(this.Open_128_Paint);
          this._Open_128.Click -= new EventHandler(this.Open_128_Click);
        }
        this._Open_128 = value;
        if (this._Open_128 == null)
          return;
        this._Open_128.MouseLeave += new EventHandler(this.Open_128_MouseLeave);
        this._Open_128.MouseEnter += new EventHandler(this.Open_128_MouseEnter);
        this._Open_128.MouseUp += new MouseEventHandler(this.Open_128_MouseUp);
        this._Open_128.MouseDown += new MouseEventHandler(this.Open_128_MouseDown);
        this._Open_128.Paint += new PaintEventHandler(this.Open_128_Paint);
        this._Open_128.Click += new EventHandler(this.Open_128_Click);
      }
      get => this._Open_128;
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

    internal virtual Label A_Label_8
    {
      get => this._A_Label_8;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._A_Label_8 == null)
          ;
        this._A_Label_8 = value;
        if (this._A_Label_8 == null)
          ;
      }
    }

    internal virtual Label A_Label_16
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._A_Label_16 == null)
          ;
        this._A_Label_16 = value;
        if (this._A_Label_16 == null)
          ;
      }
      get => this._A_Label_16;
    }

    internal virtual Label A_Label_32
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._A_Label_32 == null)
          ;
        this._A_Label_32 = value;
        if (this._A_Label_32 == null)
          ;
      }
      get => this._A_Label_32;
    }

    internal virtual Label A_Label_64
    {
      get => this._A_Label_64;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._A_Label_64 == null)
          ;
        this._A_Label_64 = value;
        if (this._A_Label_64 == null)
          ;
      }
    }

    internal virtual Label A_Label_128
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._A_Label_128 == null)
          ;
        this._A_Label_128 = value;
        if (this._A_Label_128 == null)
          ;
      }
      get => this._A_Label_128;
    }

    internal virtual PictureBox Open_A_64
    {
      get => this._Open_A_64;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Open_A_64 != null)
        {
          this._Open_A_64.MouseLeave -= new EventHandler(this.Open_A_64_MouseLeave);
          this._Open_A_64.MouseEnter -= new EventHandler(this.Open_A_64_MouseEnter);
          this._Open_A_64.MouseUp -= new MouseEventHandler(this.Open_A_64_MouseUp);
          this._Open_A_64.MouseDown -= new MouseEventHandler(this.Open_A_64_MouseDown);
          this._Open_A_64.Paint -= new PaintEventHandler(this.Open_A_64_Paint);
          this._Open_A_64.Click -= new EventHandler(this.Open_A_64_Click);
        }
        this._Open_A_64 = value;
        if (this._Open_A_64 == null)
          return;
        this._Open_A_64.MouseLeave += new EventHandler(this.Open_A_64_MouseLeave);
        this._Open_A_64.MouseEnter += new EventHandler(this.Open_A_64_MouseEnter);
        this._Open_A_64.MouseUp += new MouseEventHandler(this.Open_A_64_MouseUp);
        this._Open_A_64.MouseDown += new MouseEventHandler(this.Open_A_64_MouseDown);
        this._Open_A_64.Paint += new PaintEventHandler(this.Open_A_64_Paint);
        this._Open_A_64.Click += new EventHandler(this.Open_A_64_Click);
      }
    }

    internal virtual PictureBox Open_A_32
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Open_A_32 != null)
        {
          this._Open_A_32.MouseLeave -= new EventHandler(this.Open_A_32_MouseLeave);
          this._Open_A_32.MouseEnter -= new EventHandler(this.Open_A_32_MouseEnter);
          this._Open_A_32.MouseUp -= new MouseEventHandler(this.Open_A_32_MouseUp);
          this._Open_A_32.MouseDown -= new MouseEventHandler(this.Open_A_32_MouseDown);
          this._Open_A_32.Paint -= new PaintEventHandler(this.Open_A_32_Paint);
          this._Open_A_32.Click -= new EventHandler(this.Open_A_32_Click);
        }
        this._Open_A_32 = value;
        if (this._Open_A_32 == null)
          return;
        this._Open_A_32.MouseLeave += new EventHandler(this.Open_A_32_MouseLeave);
        this._Open_A_32.MouseEnter += new EventHandler(this.Open_A_32_MouseEnter);
        this._Open_A_32.MouseUp += new MouseEventHandler(this.Open_A_32_MouseUp);
        this._Open_A_32.MouseDown += new MouseEventHandler(this.Open_A_32_MouseDown);
        this._Open_A_32.Paint += new PaintEventHandler(this.Open_A_32_Paint);
        this._Open_A_32.Click += new EventHandler(this.Open_A_32_Click);
      }
      get => this._Open_A_32;
    }

    internal virtual PictureBox Open_A_16
    {
      get => this._Open_A_16;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Open_A_16 != null)
        {
          this._Open_A_16.MouseLeave -= new EventHandler(this.Open_A_16_MouseLeave);
          this._Open_A_16.MouseEnter -= new EventHandler(this.Open_A_16_MouseEnter);
          this._Open_A_16.MouseUp -= new MouseEventHandler(this.Open_A_16_MouseUp);
          this._Open_A_16.MouseDown -= new MouseEventHandler(this.Open_A_16_MouseDown);
          this._Open_A_16.Paint -= new PaintEventHandler(this.Open_A_16_Paint);
          this._Open_A_16.Click -= new EventHandler(this.Open_A_16_Click);
        }
        this._Open_A_16 = value;
        if (this._Open_A_16 == null)
          return;
        this._Open_A_16.MouseLeave += new EventHandler(this.Open_A_16_MouseLeave);
        this._Open_A_16.MouseEnter += new EventHandler(this.Open_A_16_MouseEnter);
        this._Open_A_16.MouseUp += new MouseEventHandler(this.Open_A_16_MouseUp);
        this._Open_A_16.MouseDown += new MouseEventHandler(this.Open_A_16_MouseDown);
        this._Open_A_16.Paint += new PaintEventHandler(this.Open_A_16_Paint);
        this._Open_A_16.Click += new EventHandler(this.Open_A_16_Click);
      }
    }

    internal virtual PictureBox Open_A_8
    {
      get => this._Open_A_8;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Open_A_8 != null)
        {
          this._Open_A_8.MouseLeave -= new EventHandler(this.Open_A_8_MouseLeave);
          this._Open_A_8.MouseEnter -= new EventHandler(this.Open_A_8_MouseEnter);
          this._Open_A_8.MouseUp -= new MouseEventHandler(this.Open_A_8_MouseUp);
          this._Open_A_8.MouseDown -= new MouseEventHandler(this.Open_A_8_MouseDown);
          this._Open_A_8.Paint -= new PaintEventHandler(this.Open_A_8_Paint);
          this._Open_A_8.Click -= new EventHandler(this.Open_A_8_Click);
        }
        this._Open_A_8 = value;
        if (this._Open_A_8 == null)
          return;
        this._Open_A_8.MouseLeave += new EventHandler(this.Open_A_8_MouseLeave);
        this._Open_A_8.MouseEnter += new EventHandler(this.Open_A_8_MouseEnter);
        this._Open_A_8.MouseUp += new MouseEventHandler(this.Open_A_8_MouseUp);
        this._Open_A_8.MouseDown += new MouseEventHandler(this.Open_A_8_MouseDown);
        this._Open_A_8.Paint += new PaintEventHandler(this.Open_A_8_Paint);
        this._Open_A_8.Click += new EventHandler(this.Open_A_8_Click);
      }
    }

    internal virtual Label Label16
    {
      get => this._Label16;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Label16 == null)
          ;
        this._Label16 = value;
        if (this._Label16 == null)
          ;
      }
    }

    internal virtual Label Label17
    {
      get => this._Label17;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Label17 == null)
          ;
        this._Label17 = value;
        if (this._Label17 == null)
          ;
      }
    }

    internal virtual Label Label18
    {
      get => this._Label18;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Label18 == null)
          ;
        this._Label18 = value;
        if (this._Label18 == null)
          ;
      }
    }

    internal virtual Label Label19
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Label19 == null)
          ;
        this._Label19 = value;
        if (this._Label19 == null)
          ;
      }
      get => this._Label19;
    }

    internal virtual Label Label20
    {
      get => this._Label20;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Label20 == null)
          ;
        this._Label20 = value;
        if (this._Label20 == null)
          ;
      }
    }

    internal virtual PictureBox A_Pic_8
    {
      get => this._A_Pic_8;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._A_Pic_8 == null)
          ;
        this._A_Pic_8 = value;
        if (this._A_Pic_8 == null)
          ;
      }
    }

    internal virtual PictureBox A_Pic_16
    {
      get => this._A_Pic_16;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._A_Pic_16 == null)
          ;
        this._A_Pic_16 = value;
        if (this._A_Pic_16 == null)
          ;
      }
    }

    internal virtual PictureBox A_Pic_32
    {
      get => this._A_Pic_32;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._A_Pic_32 == null)
          ;
        this._A_Pic_32 = value;
        if (this._A_Pic_32 == null)
          ;
      }
    }

    internal virtual PictureBox A_Pic_64
    {
      get => this._A_Pic_64;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._A_Pic_64 == null)
          ;
        this._A_Pic_64 = value;
        if (this._A_Pic_64 == null)
          ;
      }
    }

    internal virtual PictureBox A_Pic_128
    {
      get => this._A_Pic_128;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._A_Pic_128 == null)
          ;
        this._A_Pic_128 = value;
        if (this._A_Pic_128 == null)
          ;
      }
    }

    internal virtual PictureBox Open_A_128
    {
      get => this._Open_A_128;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Open_A_128 != null)
        {
          this._Open_A_128.MouseLeave -= new EventHandler(this.Open_A_128_MouseLeave);
          this._Open_A_128.MouseEnter -= new EventHandler(this.Open_A_128_MouseEnter);
          this._Open_A_128.MouseUp -= new MouseEventHandler(this.Open_A_128_MouseUp);
          this._Open_A_128.MouseDown -= new MouseEventHandler(this.Open_A_128_MouseDown);
          this._Open_A_128.Paint -= new PaintEventHandler(this.Open_A_128_Paint);
          this._Open_A_128.Click -= new EventHandler(this.Open_A_128_Click);
        }
        this._Open_A_128 = value;
        if (this._Open_A_128 == null)
          return;
        this._Open_A_128.MouseLeave += new EventHandler(this.Open_A_128_MouseLeave);
        this._Open_A_128.MouseEnter += new EventHandler(this.Open_A_128_MouseEnter);
        this._Open_A_128.MouseUp += new MouseEventHandler(this.Open_A_128_MouseUp);
        this._Open_A_128.MouseDown += new MouseEventHandler(this.Open_A_128_MouseDown);
        this._Open_A_128.Paint += new PaintEventHandler(this.Open_A_128_Paint);
        this._Open_A_128.Click += new EventHandler(this.Open_A_128_Click);
      }
    }

    internal virtual GroupBox GroupBox3
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._GroupBox3 == null)
          ;
        this._GroupBox3 = value;
        if (this._GroupBox3 == null)
          ;
      }
      get => this._GroupBox3;
    }

    internal virtual TextBox InstanceTextBox
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._InstanceTextBox != null)
          this._InstanceTextBox.Validating -= new CancelEventHandler(this.InstanceTextBox_Validating);
        this._InstanceTextBox = value;
        if (this._InstanceTextBox == null)
          return;
        this._InstanceTextBox.Validating += new CancelEventHandler(this.InstanceTextBox_Validating);
      }
      get => this._InstanceTextBox;
    }

    internal virtual Button Button3
    {
      get => this._Button3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Button3 != null)
          this._Button3.Click -= new EventHandler(this.Button3_Click);
        this._Button3 = value;
        if (this._Button3 == null)
          return;
        this._Button3.Click += new EventHandler(this.Button3_Click);
      }
    }

    internal virtual GroupBox GroupBox4
    {
      get => this._GroupBox4;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._GroupBox4 == null)
          ;
        this._GroupBox4 = value;
        if (this._GroupBox4 == null)
          ;
      }
    }

    internal virtual Button Button1
    {
      get => this._Button1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Button1 != null)
          this._Button1.Click -= new EventHandler(this.Button1_Click);
        this._Button1 = value;
        if (this._Button1 == null)
          return;
        this._Button1.Click += new EventHandler(this.Button1_Click);
      }
    }

    internal virtual PictureBox CopyBitmap
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._CopyBitmap != null)
          this._CopyBitmap.Click -= new EventHandler(this.CopyBitmap_Click);
        this._CopyBitmap = value;
        if (this._CopyBitmap == null)
          return;
        this._CopyBitmap.Click += new EventHandler(this.CopyBitmap_Click);
      }
      get => this._CopyBitmap;
    }

    internal virtual PictureBox CopyAlpha
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._CopyAlpha != null)
          this._CopyAlpha.Click -= new EventHandler(this.CopyAlpha_Click);
        this._CopyAlpha = value;
        if (this._CopyAlpha == null)
          return;
        this._CopyAlpha.Click += new EventHandler(this.CopyAlpha_Click);
      }
      get => this._CopyAlpha;
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

    internal virtual ButtonItem ButtonItem2
    {
      get => this._ButtonItem2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ButtonItem2 != null)
          this._ButtonItem2.Activate -= new EventHandler(this.ButtonItem2_Activate);
        this._ButtonItem2 = value;
        if (this._ButtonItem2 == null)
          return;
        this._ButtonItem2.Activate += new EventHandler(this.ButtonItem2_Activate);
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

    internal virtual GroupBox GroupBox5
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._GroupBox5 == null)
          ;
        this._GroupBox5 = value;
        if (this._GroupBox5 == null)
          ;
      }
      get => this._GroupBox5;
    }

    internal virtual RadioButton RadioButton1
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._RadioButton1 != null)
          this._RadioButton1.CheckedChanged -= new EventHandler(this.RadioButton1_CheckedChanged);
        this._RadioButton1 = value;
        if (this._RadioButton1 == null)
          return;
        this._RadioButton1.CheckedChanged += new EventHandler(this.RadioButton1_CheckedChanged);
      }
      get => this._RadioButton1;
    }

    internal virtual RadioButton RadioButton2
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._RadioButton2 != null)
          this._RadioButton2.CheckedChanged -= new EventHandler(this.RadioButton2_CheckedChanged);
        this._RadioButton2 = value;
        if (this._RadioButton2 == null)
          return;
        this._RadioButton2.CheckedChanged += new EventHandler(this.RadioButton2_CheckedChanged);
      }
      get => this._RadioButton2;
    }

    internal virtual GroupBox GroupBox6
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._GroupBox6 == null)
          ;
        this._GroupBox6 = value;
        if (this._GroupBox6 == null)
          ;
      }
      get => this._GroupBox6;
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

    internal virtual Label Label7
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Label7 == null)
          ;
        this._Label7 = value;
        if (this._Label7 == null)
          ;
      }
      get => this._Label7;
    }

    internal virtual Label Label8
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Label8 == null)
          ;
        this._Label8 = value;
        if (this._Label8 == null)
          ;
      }
      get => this._Label8;
    }

    internal virtual Label MaxRangeLabel
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MaxRangeLabel == null)
          ;
        this._MaxRangeLabel = value;
        if (this._MaxRangeLabel == null)
          ;
      }
      get => this._MaxRangeLabel;
    }

    internal virtual Label MinRangeLabel
    {
      get => this._MinRangeLabel;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MinRangeLabel == null)
          ;
        this._MinRangeLabel = value;
        if (this._MinRangeLabel == null)
          ;
      }
    }

    internal virtual Label Label6
    {
      get => this._Label6;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Label6 == null)
          ;
        this._Label6 = value;
        if (this._Label6 == null)
          ;
      }
    }

    internal virtual LinkLabel LinkLabel1
    {
      get => this._LinkLabel1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._LinkLabel1 != null)
          this._LinkLabel1.LinkClicked -= new LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
        this._LinkLabel1 = value;
        if (this._LinkLabel1 == null)
          return;
        this._LinkLabel1.LinkClicked += new LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
      }
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

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      ResourceManager resourceManager = new ResourceManager(typeof (FormTextureMaker));
      this.ImageList1 = new ImageList(this.components);
      this.GroupBox1 = new GroupBox();
      this.CopyBitmap = new PictureBox();
      this.Label_8 = new Label();
      this.Label_16 = new Label();
      this.Label_32 = new Label();
      this.Label_64 = new Label();
      this.Label_128 = new Label();
      this.Open_64 = new PictureBox();
      this.Open_32 = new PictureBox();
      this.Open_16 = new PictureBox();
      this.Open_8 = new PictureBox();
      this.Label5 = new Label();
      this.Label4 = new Label();
      this.Label3 = new Label();
      this.Label2 = new Label();
      this.Label1 = new Label();
      this.Pic_8 = new PictureBox();
      this.Pic_16 = new PictureBox();
      this.Pic_32 = new PictureBox();
      this.Pic_64 = new PictureBox();
      this.Pic_128 = new PictureBox();
      this.Open_128 = new PictureBox();
      this.GroupBox2 = new GroupBox();
      this.CopyAlpha = new PictureBox();
      this.A_Label_8 = new Label();
      this.A_Label_16 = new Label();
      this.A_Label_32 = new Label();
      this.A_Label_64 = new Label();
      this.A_Label_128 = new Label();
      this.Open_A_64 = new PictureBox();
      this.Open_A_32 = new PictureBox();
      this.Open_A_16 = new PictureBox();
      this.Open_A_8 = new PictureBox();
      this.Label16 = new Label();
      this.Label17 = new Label();
      this.Label18 = new Label();
      this.Label19 = new Label();
      this.Label20 = new Label();
      this.A_Pic_8 = new PictureBox();
      this.A_Pic_16 = new PictureBox();
      this.A_Pic_32 = new PictureBox();
      this.A_Pic_64 = new PictureBox();
      this.A_Pic_128 = new PictureBox();
      this.Open_A_128 = new PictureBox();
      this.GroupBox3 = new GroupBox();
      this.Button3 = new Button();
      this.InstanceTextBox = new TextBox();
      this.GroupBox4 = new GroupBox();
      this.Button1 = new Button();
      this.ToolBar1 = new TD.SandBar.ToolBar();
      this.ButtonItem1 = new ButtonItem();
      this.ButtonItem2 = new ButtonItem();
      this.ToolTip1 = new ToolTip(this.components);
      this.GroupBox5 = new GroupBox();
      this.RadioButton2 = new RadioButton();
      this.RadioButton1 = new RadioButton();
      this.GroupBox6 = new GroupBox();
      this.LinkLabel1 = new LinkLabel();
      this.CheckBox1 = new CheckBox();
      this.Label7 = new Label();
      this.Label8 = new Label();
      this.MaxRangeLabel = new Label();
      this.MinRangeLabel = new Label();
      this.Label6 = new Label();
      this.CheckBox2 = new CheckBox();
      this.GroupBox1.SuspendLayout();
      this.GroupBox2.SuspendLayout();
      this.GroupBox3.SuspendLayout();
      this.GroupBox4.SuspendLayout();
      this.GroupBox5.SuspendLayout();
      this.GroupBox6.SuspendLayout();
      this.SuspendLayout();
      ImageList imageList1 = this.ImageList1;
      Size size1 = new Size(16, 16);
      Size size2 = size1;
      imageList1.ImageSize = size2;
      this.ImageList1.ImageStream = (ImageListStreamer) resourceManager.GetObject("ImageList1.ImageStream");
      this.ImageList1.TransparentColor = Color.Transparent;
      this.GroupBox1.Controls.Add((Control) this.CopyBitmap);
      this.GroupBox1.Controls.Add((Control) this.Label_8);
      this.GroupBox1.Controls.Add((Control) this.Label_16);
      this.GroupBox1.Controls.Add((Control) this.Label_32);
      this.GroupBox1.Controls.Add((Control) this.Label_64);
      this.GroupBox1.Controls.Add((Control) this.Label_128);
      this.GroupBox1.Controls.Add((Control) this.Open_64);
      this.GroupBox1.Controls.Add((Control) this.Open_32);
      this.GroupBox1.Controls.Add((Control) this.Open_16);
      this.GroupBox1.Controls.Add((Control) this.Open_8);
      this.GroupBox1.Controls.Add((Control) this.Label5);
      this.GroupBox1.Controls.Add((Control) this.Label4);
      this.GroupBox1.Controls.Add((Control) this.Label3);
      this.GroupBox1.Controls.Add((Control) this.Label2);
      this.GroupBox1.Controls.Add((Control) this.Label1);
      this.GroupBox1.Controls.Add((Control) this.Pic_8);
      this.GroupBox1.Controls.Add((Control) this.Pic_16);
      this.GroupBox1.Controls.Add((Control) this.Pic_32);
      this.GroupBox1.Controls.Add((Control) this.Pic_64);
      this.GroupBox1.Controls.Add((Control) this.Pic_128);
      this.GroupBox1.Controls.Add((Control) this.Open_128);
      GroupBox groupBox1_1 = this.GroupBox1;
      Point point1 = new Point(8, 120);
      Point point2 = point1;
      groupBox1_1.Location = point2;
      this.GroupBox1.Name = "GroupBox1";
      GroupBox groupBox1_2 = this.GroupBox1;
      size1 = new Size(536, 160);
      Size size3 = size1;
      groupBox1_2.Size = size3;
      this.GroupBox1.TabIndex = 184;
      this.GroupBox1.TabStop = false;
      this.GroupBox1.Text = "Bitmaps";
      this.CopyBitmap.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.CopyBitmap.Image = (Image) resourceManager.GetObject("CopyBitmap.Image");
      PictureBox copyBitmap1 = this.CopyBitmap;
      point1 = new Point(256, 28);
      Point point3 = point1;
      copyBitmap1.Location = point3;
      this.CopyBitmap.Name = "CopyBitmap";
      PictureBox copyBitmap2 = this.CopyBitmap;
      size1 = new Size(16, 16);
      Size size4 = size1;
      copyBitmap2.Size = size4;
      this.CopyBitmap.TabIndex = 199;
      this.CopyBitmap.TabStop = false;
      this.Label_8.BackColor = SystemColors.ActiveCaptionText;
      this.Label_8.BorderStyle = BorderStyle.Fixed3D;
      this.Label_8.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label8_1 = this.Label_8;
      point1 = new Point(84, 124);
      Point point4 = point1;
      label8_1.Location = point4;
      this.Label_8.Name = "Label_8";
      Label label8_2 = this.Label_8;
      size1 = new Size(128, 16);
      Size size5 = size1;
      label8_2.Size = size5;
      this.Label_8.TabIndex = 198;
      this.Label_8.TextAlign = ContentAlignment.MiddleLeft;
      this.Label_16.BackColor = SystemColors.ActiveCaptionText;
      this.Label_16.BorderStyle = BorderStyle.Fixed3D;
      this.Label_16.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label16_1 = this.Label_16;
      point1 = new Point(84, 100);
      Point point5 = point1;
      label16_1.Location = point5;
      this.Label_16.Name = "Label_16";
      Label label16_2 = this.Label_16;
      size1 = new Size(128, 16);
      Size size6 = size1;
      label16_2.Size = size6;
      this.Label_16.TabIndex = 197;
      this.Label_16.TextAlign = ContentAlignment.MiddleLeft;
      this.Label_32.BackColor = SystemColors.ActiveCaptionText;
      this.Label_32.BorderStyle = BorderStyle.Fixed3D;
      this.Label_32.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label32_1 = this.Label_32;
      point1 = new Point(84, 76);
      Point point6 = point1;
      label32_1.Location = point6;
      this.Label_32.Name = "Label_32";
      Label label32_2 = this.Label_32;
      size1 = new Size(128, 16);
      Size size7 = size1;
      label32_2.Size = size7;
      this.Label_32.TabIndex = 196;
      this.Label_32.TextAlign = ContentAlignment.MiddleLeft;
      this.Label_64.BackColor = SystemColors.ActiveCaptionText;
      this.Label_64.BorderStyle = BorderStyle.Fixed3D;
      this.Label_64.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label64_1 = this.Label_64;
      point1 = new Point(84, 52);
      Point point7 = point1;
      label64_1.Location = point7;
      this.Label_64.Name = "Label_64";
      Label label64_2 = this.Label_64;
      size1 = new Size(128, 16);
      Size size8 = size1;
      label64_2.Size = size8;
      this.Label_64.TabIndex = 195;
      this.Label_64.TextAlign = ContentAlignment.MiddleLeft;
      this.Label_128.BackColor = SystemColors.ActiveCaptionText;
      this.Label_128.BorderStyle = BorderStyle.Fixed3D;
      this.Label_128.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label128_1 = this.Label_128;
      point1 = new Point(84, 28);
      Point point8 = point1;
      label128_1.Location = point8;
      this.Label_128.Name = "Label_128";
      Label label128_2 = this.Label_128;
      size1 = new Size(128, 16);
      Size size9 = size1;
      label128_2.Size = size9;
      this.Label_128.TabIndex = 194;
      this.Label_128.TextAlign = ContentAlignment.MiddleLeft;
      this.Open_64.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Open_64.Image = (Image) resourceManager.GetObject("Open_64.Image");
      PictureBox open64_1 = this.Open_64;
      point1 = new Point(220, 52);
      Point point9 = point1;
      open64_1.Location = point9;
      this.Open_64.Name = "Open_64";
      PictureBox open64_2 = this.Open_64;
      size1 = new Size(16, 16);
      Size size10 = size1;
      open64_2.Size = size10;
      this.Open_64.TabIndex = 193;
      this.Open_64.TabStop = false;
      this.Open_32.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Open_32.Image = (Image) resourceManager.GetObject("Open_32.Image");
      PictureBox open32_1 = this.Open_32;
      point1 = new Point(220, 76);
      Point point10 = point1;
      open32_1.Location = point10;
      this.Open_32.Name = "Open_32";
      PictureBox open32_2 = this.Open_32;
      size1 = new Size(16, 16);
      Size size11 = size1;
      open32_2.Size = size11;
      this.Open_32.TabIndex = 192;
      this.Open_32.TabStop = false;
      this.Open_16.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Open_16.Image = (Image) resourceManager.GetObject("Open_16.Image");
      PictureBox open16_1 = this.Open_16;
      point1 = new Point(220, 100);
      Point point11 = point1;
      open16_1.Location = point11;
      this.Open_16.Name = "Open_16";
      PictureBox open16_2 = this.Open_16;
      size1 = new Size(16, 16);
      Size size12 = size1;
      open16_2.Size = size12;
      this.Open_16.TabIndex = 191;
      this.Open_16.TabStop = false;
      this.Open_8.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Open_8.Image = (Image) resourceManager.GetObject("Open_8.Image");
      PictureBox open8_1 = this.Open_8;
      point1 = new Point(220, 124);
      Point point12 = point1;
      open8_1.Location = point12;
      this.Open_8.Name = "Open_8";
      PictureBox open8_2 = this.Open_8;
      size1 = new Size(16, 16);
      Size size13 = size1;
      open8_2.Size = size13;
      this.Open_8.TabIndex = 190;
      this.Open_8.TabStop = false;
      this.Label5.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label5_1 = this.Label5;
      point1 = new Point(12, 124);
      Point point13 = point1;
      label5_1.Location = point13;
      this.Label5.Name = "Label5";
      Label label5_2 = this.Label5;
      size1 = new Size(64, 16);
      Size size14 = size1;
      label5_2.Size = size14;
      this.Label5.TabIndex = 189;
      this.Label5.Text = "8 x 8";
      this.Label5.TextAlign = ContentAlignment.MiddleRight;
      this.Label4.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label4_1 = this.Label4;
      point1 = new Point(12, 100);
      Point point14 = point1;
      label4_1.Location = point14;
      this.Label4.Name = "Label4";
      Label label4_2 = this.Label4;
      size1 = new Size(64, 16);
      Size size15 = size1;
      label4_2.Size = size15;
      this.Label4.TabIndex = 188;
      this.Label4.Text = "16 x 16";
      this.Label4.TextAlign = ContentAlignment.MiddleRight;
      this.Label3.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label3_1 = this.Label3;
      point1 = new Point(12, 76);
      Point point15 = point1;
      label3_1.Location = point15;
      this.Label3.Name = "Label3";
      Label label3_2 = this.Label3;
      size1 = new Size(64, 16);
      Size size16 = size1;
      label3_2.Size = size16;
      this.Label3.TabIndex = 187;
      this.Label3.Text = "32 x 32";
      this.Label3.TextAlign = ContentAlignment.MiddleRight;
      this.Label2.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label2_1 = this.Label2;
      point1 = new Point(12, 52);
      Point point16 = point1;
      label2_1.Location = point16;
      this.Label2.Name = "Label2";
      Label label2_2 = this.Label2;
      size1 = new Size(64, 16);
      Size size17 = size1;
      label2_2.Size = size17;
      this.Label2.TabIndex = 186;
      this.Label2.Text = "64 x 64";
      this.Label2.TextAlign = ContentAlignment.MiddleRight;
      this.Label1.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label1_1 = this.Label1;
      point1 = new Point(12, 28);
      Point point17 = point1;
      label1_1.Location = point17;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      size1 = new Size(64, 16);
      Size size18 = size1;
      label1_2.Size = size18;
      this.Label1.TabIndex = 185;
      this.Label1.Text = "128 x 128";
      this.Label1.TextAlign = ContentAlignment.MiddleRight;
      this.Pic_8.BorderStyle = BorderStyle.FixedSingle;
      this.Pic_8.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      PictureBox pic8_1 = this.Pic_8;
      point1 = new Point(512, 92);
      Point point18 = point1;
      pic8_1.Location = point18;
      this.Pic_8.Name = "Pic_8";
      PictureBox pic8_2 = this.Pic_8;
      size1 = new Size(8, 8);
      Size size19 = size1;
      pic8_2.Size = size19;
      this.Pic_8.SizeMode = PictureBoxSizeMode.StretchImage;
      this.Pic_8.TabIndex = 184;
      this.Pic_8.TabStop = false;
      this.Pic_16.BorderStyle = BorderStyle.FixedSingle;
      this.Pic_16.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      PictureBox pic16_1 = this.Pic_16;
      point1 = new Point(492, 92);
      Point point19 = point1;
      pic16_1.Location = point19;
      this.Pic_16.Name = "Pic_16";
      PictureBox pic16_2 = this.Pic_16;
      size1 = new Size(16, 16);
      Size size20 = size1;
      pic16_2.Size = size20;
      this.Pic_16.SizeMode = PictureBoxSizeMode.StretchImage;
      this.Pic_16.TabIndex = 183;
      this.Pic_16.TabStop = false;
      this.Pic_32.BorderStyle = BorderStyle.FixedSingle;
      this.Pic_32.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      PictureBox pic32_1 = this.Pic_32;
      point1 = new Point(456, 92);
      Point point20 = point1;
      pic32_1.Location = point20;
      this.Pic_32.Name = "Pic_32";
      PictureBox pic32_2 = this.Pic_32;
      size1 = new Size(32, 32);
      Size size21 = size1;
      pic32_2.Size = size21;
      this.Pic_32.SizeMode = PictureBoxSizeMode.StretchImage;
      this.Pic_32.TabIndex = 182;
      this.Pic_32.TabStop = false;
      this.Pic_64.BorderStyle = BorderStyle.FixedSingle;
      this.Pic_64.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      PictureBox pic64_1 = this.Pic_64;
      point1 = new Point(456, 24);
      Point point21 = point1;
      pic64_1.Location = point21;
      this.Pic_64.Name = "Pic_64";
      PictureBox pic64_2 = this.Pic_64;
      size1 = new Size(64, 64);
      Size size22 = size1;
      pic64_2.Size = size22;
      this.Pic_64.SizeMode = PictureBoxSizeMode.StretchImage;
      this.Pic_64.TabIndex = 181;
      this.Pic_64.TabStop = false;
      this.Pic_128.BorderStyle = BorderStyle.FixedSingle;
      this.Pic_128.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      PictureBox pic128_1 = this.Pic_128;
      point1 = new Point(320, 24);
      Point point22 = point1;
      pic128_1.Location = point22;
      this.Pic_128.Name = "Pic_128";
      PictureBox pic128_2 = this.Pic_128;
      size1 = new Size(128, 128);
      Size size23 = size1;
      pic128_2.Size = size23;
      this.Pic_128.TabIndex = 180;
      this.Pic_128.TabStop = false;
      this.Open_128.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Open_128.Image = (Image) resourceManager.GetObject("Open_128.Image");
      PictureBox open128_1 = this.Open_128;
      point1 = new Point(220, 28);
      Point point23 = point1;
      open128_1.Location = point23;
      this.Open_128.Name = "Open_128";
      PictureBox open128_2 = this.Open_128;
      size1 = new Size(16, 16);
      Size size24 = size1;
      open128_2.Size = size24;
      this.Open_128.TabIndex = 179;
      this.Open_128.TabStop = false;
      this.GroupBox2.Controls.Add((Control) this.CopyAlpha);
      this.GroupBox2.Controls.Add((Control) this.A_Label_8);
      this.GroupBox2.Controls.Add((Control) this.A_Label_16);
      this.GroupBox2.Controls.Add((Control) this.A_Label_32);
      this.GroupBox2.Controls.Add((Control) this.A_Label_64);
      this.GroupBox2.Controls.Add((Control) this.A_Label_128);
      this.GroupBox2.Controls.Add((Control) this.Open_A_64);
      this.GroupBox2.Controls.Add((Control) this.Open_A_32);
      this.GroupBox2.Controls.Add((Control) this.Open_A_16);
      this.GroupBox2.Controls.Add((Control) this.Open_A_8);
      this.GroupBox2.Controls.Add((Control) this.Label16);
      this.GroupBox2.Controls.Add((Control) this.Label17);
      this.GroupBox2.Controls.Add((Control) this.Label18);
      this.GroupBox2.Controls.Add((Control) this.Label19);
      this.GroupBox2.Controls.Add((Control) this.Label20);
      this.GroupBox2.Controls.Add((Control) this.A_Pic_8);
      this.GroupBox2.Controls.Add((Control) this.A_Pic_16);
      this.GroupBox2.Controls.Add((Control) this.A_Pic_32);
      this.GroupBox2.Controls.Add((Control) this.A_Pic_64);
      this.GroupBox2.Controls.Add((Control) this.A_Pic_128);
      this.GroupBox2.Controls.Add((Control) this.Open_A_128);
      GroupBox groupBox2_1 = this.GroupBox2;
      point1 = new Point(8, 284);
      Point point24 = point1;
      groupBox2_1.Location = point24;
      this.GroupBox2.Name = "GroupBox2";
      GroupBox groupBox2_2 = this.GroupBox2;
      size1 = new Size(536, 160);
      Size size25 = size1;
      groupBox2_2.Size = size25;
      this.GroupBox2.TabIndex = 185;
      this.GroupBox2.TabStop = false;
      this.GroupBox2.Text = "Alpha";
      this.CopyAlpha.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.CopyAlpha.Image = (Image) resourceManager.GetObject("CopyAlpha.Image");
      PictureBox copyAlpha1 = this.CopyAlpha;
      point1 = new Point(252, 32);
      Point point25 = point1;
      copyAlpha1.Location = point25;
      this.CopyAlpha.Name = "CopyAlpha";
      PictureBox copyAlpha2 = this.CopyAlpha;
      size1 = new Size(16, 16);
      Size size26 = size1;
      copyAlpha2.Size = size26;
      this.CopyAlpha.TabIndex = 206;
      this.CopyAlpha.TabStop = false;
      this.A_Label_8.BackColor = SystemColors.ActiveCaptionText;
      this.A_Label_8.BorderStyle = BorderStyle.Fixed3D;
      this.A_Label_8.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label aLabel8_1 = this.A_Label_8;
      point1 = new Point(84, 128);
      Point point26 = point1;
      aLabel8_1.Location = point26;
      this.A_Label_8.Name = "A_Label_8";
      Label aLabel8_2 = this.A_Label_8;
      size1 = new Size(128, 16);
      Size size27 = size1;
      aLabel8_2.Size = size27;
      this.A_Label_8.TabIndex = 204;
      this.A_Label_8.TextAlign = ContentAlignment.MiddleLeft;
      this.A_Label_16.BackColor = SystemColors.ActiveCaptionText;
      this.A_Label_16.BorderStyle = BorderStyle.Fixed3D;
      this.A_Label_16.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label aLabel16_1 = this.A_Label_16;
      point1 = new Point(84, 104);
      Point point27 = point1;
      aLabel16_1.Location = point27;
      this.A_Label_16.Name = "A_Label_16";
      Label aLabel16_2 = this.A_Label_16;
      size1 = new Size(128, 16);
      Size size28 = size1;
      aLabel16_2.Size = size28;
      this.A_Label_16.TabIndex = 203;
      this.A_Label_16.TextAlign = ContentAlignment.MiddleLeft;
      this.A_Label_32.BackColor = SystemColors.ActiveCaptionText;
      this.A_Label_32.BorderStyle = BorderStyle.Fixed3D;
      this.A_Label_32.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label aLabel32_1 = this.A_Label_32;
      point1 = new Point(84, 80);
      Point point28 = point1;
      aLabel32_1.Location = point28;
      this.A_Label_32.Name = "A_Label_32";
      Label aLabel32_2 = this.A_Label_32;
      size1 = new Size(128, 16);
      Size size29 = size1;
      aLabel32_2.Size = size29;
      this.A_Label_32.TabIndex = 202;
      this.A_Label_32.TextAlign = ContentAlignment.MiddleLeft;
      this.A_Label_64.BackColor = SystemColors.ActiveCaptionText;
      this.A_Label_64.BorderStyle = BorderStyle.Fixed3D;
      this.A_Label_64.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label aLabel64_1 = this.A_Label_64;
      point1 = new Point(84, 56);
      Point point29 = point1;
      aLabel64_1.Location = point29;
      this.A_Label_64.Name = "A_Label_64";
      Label aLabel64_2 = this.A_Label_64;
      size1 = new Size(128, 16);
      Size size30 = size1;
      aLabel64_2.Size = size30;
      this.A_Label_64.TabIndex = 198;
      this.A_Label_64.TextAlign = ContentAlignment.MiddleLeft;
      this.A_Label_128.BackColor = SystemColors.ActiveCaptionText;
      this.A_Label_128.BorderStyle = BorderStyle.Fixed3D;
      this.A_Label_128.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label aLabel128_1 = this.A_Label_128;
      point1 = new Point(84, 32);
      Point point30 = point1;
      aLabel128_1.Location = point30;
      this.A_Label_128.Name = "A_Label_128";
      Label aLabel128_2 = this.A_Label_128;
      size1 = new Size(128, 16);
      Size size31 = size1;
      aLabel128_2.Size = size31;
      this.A_Label_128.TabIndex = 197;
      this.A_Label_128.TextAlign = ContentAlignment.MiddleLeft;
      this.Open_A_64.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Open_A_64.Image = (Image) resourceManager.GetObject("Open_A_64.Image");
      PictureBox openA64_1 = this.Open_A_64;
      point1 = new Point(220, 56);
      Point point31 = point1;
      openA64_1.Location = point31;
      this.Open_A_64.Name = "Open_A_64";
      PictureBox openA64_2 = this.Open_A_64;
      size1 = new Size(16, 16);
      Size size32 = size1;
      openA64_2.Size = size32;
      this.Open_A_64.TabIndex = 196;
      this.Open_A_64.TabStop = false;
      this.Open_A_32.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Open_A_32.Image = (Image) resourceManager.GetObject("Open_A_32.Image");
      PictureBox openA32_1 = this.Open_A_32;
      point1 = new Point(220, 80);
      Point point32 = point1;
      openA32_1.Location = point32;
      this.Open_A_32.Name = "Open_A_32";
      PictureBox openA32_2 = this.Open_A_32;
      size1 = new Size(16, 16);
      Size size33 = size1;
      openA32_2.Size = size33;
      this.Open_A_32.TabIndex = 195;
      this.Open_A_32.TabStop = false;
      this.Open_A_16.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Open_A_16.Image = (Image) resourceManager.GetObject("Open_A_16.Image");
      PictureBox openA16_1 = this.Open_A_16;
      point1 = new Point(220, 104);
      Point point33 = point1;
      openA16_1.Location = point33;
      this.Open_A_16.Name = "Open_A_16";
      PictureBox openA16_2 = this.Open_A_16;
      size1 = new Size(16, 16);
      Size size34 = size1;
      openA16_2.Size = size34;
      this.Open_A_16.TabIndex = 194;
      this.Open_A_16.TabStop = false;
      this.Open_A_8.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Open_A_8.Image = (Image) resourceManager.GetObject("Open_A_8.Image");
      PictureBox openA8_1 = this.Open_A_8;
      point1 = new Point(220, 128);
      Point point34 = point1;
      openA8_1.Location = point34;
      this.Open_A_8.Name = "Open_A_8";
      PictureBox openA8_2 = this.Open_A_8;
      size1 = new Size(16, 16);
      Size size35 = size1;
      openA8_2.Size = size35;
      this.Open_A_8.TabIndex = 193;
      this.Open_A_8.TabStop = false;
      this.Label16.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label16_3 = this.Label16;
      point1 = new Point(12, 128);
      Point point35 = point1;
      label16_3.Location = point35;
      this.Label16.Name = "Label16";
      Label label16_4 = this.Label16;
      size1 = new Size(64, 16);
      Size size36 = size1;
      label16_4.Size = size36;
      this.Label16.TabIndex = 192;
      this.Label16.Text = "8 x 8";
      this.Label16.TextAlign = ContentAlignment.MiddleRight;
      this.Label17.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label17_1 = this.Label17;
      point1 = new Point(12, 104);
      Point point36 = point1;
      label17_1.Location = point36;
      this.Label17.Name = "Label17";
      Label label17_2 = this.Label17;
      size1 = new Size(64, 16);
      Size size37 = size1;
      label17_2.Size = size37;
      this.Label17.TabIndex = 191;
      this.Label17.Text = "16 x 16";
      this.Label17.TextAlign = ContentAlignment.MiddleRight;
      this.Label18.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label18_1 = this.Label18;
      point1 = new Point(12, 80);
      Point point37 = point1;
      label18_1.Location = point37;
      this.Label18.Name = "Label18";
      Label label18_2 = this.Label18;
      size1 = new Size(64, 16);
      Size size38 = size1;
      label18_2.Size = size38;
      this.Label18.TabIndex = 190;
      this.Label18.Text = "32 x 32";
      this.Label18.TextAlign = ContentAlignment.MiddleRight;
      this.Label19.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label19_1 = this.Label19;
      point1 = new Point(12, 56);
      Point point38 = point1;
      label19_1.Location = point38;
      this.Label19.Name = "Label19";
      Label label19_2 = this.Label19;
      size1 = new Size(64, 16);
      Size size39 = size1;
      label19_2.Size = size39;
      this.Label19.TabIndex = 189;
      this.Label19.Text = "64 x 64";
      this.Label19.TextAlign = ContentAlignment.MiddleRight;
      this.Label20.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label20_1 = this.Label20;
      point1 = new Point(12, 32);
      Point point39 = point1;
      label20_1.Location = point39;
      this.Label20.Name = "Label20";
      Label label20_2 = this.Label20;
      size1 = new Size(64, 16);
      Size size40 = size1;
      label20_2.Size = size40;
      this.Label20.TabIndex = 188;
      this.Label20.Text = "128 x 128";
      this.Label20.TextAlign = ContentAlignment.MiddleRight;
      this.A_Pic_8.BorderStyle = BorderStyle.FixedSingle;
      this.A_Pic_8.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      PictureBox aPic8_1 = this.A_Pic_8;
      point1 = new Point(512, 92);
      Point point40 = point1;
      aPic8_1.Location = point40;
      this.A_Pic_8.Name = "A_Pic_8";
      PictureBox aPic8_2 = this.A_Pic_8;
      size1 = new Size(8, 8);
      Size size41 = size1;
      aPic8_2.Size = size41;
      this.A_Pic_8.TabIndex = 187;
      this.A_Pic_8.TabStop = false;
      this.A_Pic_16.BorderStyle = BorderStyle.FixedSingle;
      this.A_Pic_16.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      PictureBox aPic16_1 = this.A_Pic_16;
      point1 = new Point(492, 92);
      Point point41 = point1;
      aPic16_1.Location = point41;
      this.A_Pic_16.Name = "A_Pic_16";
      PictureBox aPic16_2 = this.A_Pic_16;
      size1 = new Size(16, 16);
      Size size42 = size1;
      aPic16_2.Size = size42;
      this.A_Pic_16.TabIndex = 186;
      this.A_Pic_16.TabStop = false;
      this.A_Pic_32.BorderStyle = BorderStyle.FixedSingle;
      this.A_Pic_32.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      PictureBox aPic32_1 = this.A_Pic_32;
      point1 = new Point(456, 92);
      Point point42 = point1;
      aPic32_1.Location = point42;
      this.A_Pic_32.Name = "A_Pic_32";
      PictureBox aPic32_2 = this.A_Pic_32;
      size1 = new Size(32, 32);
      Size size43 = size1;
      aPic32_2.Size = size43;
      this.A_Pic_32.TabIndex = 185;
      this.A_Pic_32.TabStop = false;
      this.A_Pic_64.BorderStyle = BorderStyle.FixedSingle;
      this.A_Pic_64.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      PictureBox aPic64_1 = this.A_Pic_64;
      point1 = new Point(456, 24);
      Point point43 = point1;
      aPic64_1.Location = point43;
      this.A_Pic_64.Name = "A_Pic_64";
      PictureBox aPic64_2 = this.A_Pic_64;
      size1 = new Size(64, 64);
      Size size44 = size1;
      aPic64_2.Size = size44;
      this.A_Pic_64.TabIndex = 184;
      this.A_Pic_64.TabStop = false;
      this.A_Pic_128.BorderStyle = BorderStyle.FixedSingle;
      this.A_Pic_128.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      PictureBox aPic128_1 = this.A_Pic_128;
      point1 = new Point(320, 24);
      Point point44 = point1;
      aPic128_1.Location = point44;
      this.A_Pic_128.Name = "A_Pic_128";
      PictureBox aPic128_2 = this.A_Pic_128;
      size1 = new Size(128, 128);
      Size size45 = size1;
      aPic128_2.Size = size45;
      this.A_Pic_128.TabIndex = 183;
      this.A_Pic_128.TabStop = false;
      this.Open_A_128.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Open_A_128.Image = (Image) resourceManager.GetObject("Open_A_128.Image");
      PictureBox openA128_1 = this.Open_A_128;
      point1 = new Point(220, 32);
      Point point45 = point1;
      openA128_1.Location = point45;
      this.Open_A_128.Name = "Open_A_128";
      PictureBox openA128_2 = this.Open_A_128;
      size1 = new Size(16, 16);
      Size size46 = size1;
      openA128_2.Size = size46;
      this.Open_A_128.TabIndex = 182;
      this.Open_A_128.TabStop = false;
      this.GroupBox3.Controls.Add((Control) this.CheckBox2);
      this.GroupBox3.Controls.Add((Control) this.Button3);
      this.GroupBox3.Controls.Add((Control) this.InstanceTextBox);
      GroupBox groupBox3_1 = this.GroupBox3;
      point1 = new Point(8, 28);
      Point point46 = point1;
      groupBox3_1.Location = point46;
      this.GroupBox3.Name = "GroupBox3";
      GroupBox groupBox3_2 = this.GroupBox3;
      size1 = new Size(220, 88);
      Size size47 = size1;
      groupBox3_2.Size = size47;
      this.GroupBox3.TabIndex = 186;
      this.GroupBox3.TabStop = false;
      this.GroupBox3.Text = "IID";
      Button button3_1 = this.Button3;
      point1 = new Point(108, 20);
      Point point47 = point1;
      button3_1.Location = point47;
      this.Button3.Name = "Button3";
      Button button3_2 = this.Button3;
      size1 = new Size(104, 36);
      Size size48 = size1;
      button3_2.Size = size48;
      this.Button3.TabIndex = 185;
      this.Button3.Text = "Button3";
      this.InstanceTextBox.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      TextBox instanceTextBox1 = this.InstanceTextBox;
      point1 = new Point(8, 20);
      Point point48 = point1;
      instanceTextBox1.Location = point48;
      this.InstanceTextBox.MaxLength = 10;
      this.InstanceTextBox.Name = "InstanceTextBox";
      TextBox instanceTextBox2 = this.InstanceTextBox;
      size1 = new Size(88, 21);
      Size size49 = size1;
      instanceTextBox2.Size = size49;
      this.InstanceTextBox.TabIndex = 183;
      this.InstanceTextBox.Text = "";
      this.InstanceTextBox.TextAlign = HorizontalAlignment.Center;
      this.GroupBox4.Controls.Add((Control) this.Button1);
      GroupBox groupBox4_1 = this.GroupBox4;
      point1 = new Point(420, 28);
      Point point49 = point1;
      groupBox4_1.Location = point49;
      this.GroupBox4.Name = "GroupBox4";
      GroupBox groupBox4_2 = this.GroupBox4;
      size1 = new Size(120, 88);
      Size size50 = size1;
      groupBox4_2.Size = size50;
      this.GroupBox4.TabIndex = 187;
      this.GroupBox4.TabStop = false;
      this.Button1.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Button button1_1 = this.Button1;
      point1 = new Point(8, 20);
      Point point50 = point1;
      button1_1.Location = point50;
      this.Button1.Name = "Button1";
      Button button1_2 = this.Button1;
      size1 = new Size(104, 36);
      Size size51 = size1;
      button1_2.Size = size51;
      this.Button1.TabIndex = 185;
      this.Button1.Text = "OK";
      this.ToolBar1.Guid = new Guid("ea043dbc-6163-43fb-8e8a-659c17e4623e");
      this.ToolBar1.ImageList = this.ImageList1;
      this.ToolBar1.Items.AddRange(new ToolbarItemBase[2]
      {
        (ToolbarItemBase) this.ButtonItem1,
        (ToolbarItemBase) this.ButtonItem2
      });
      TD.SandBar.ToolBar toolBar1_1 = this.ToolBar1;
      point1 = new Point(0, 0);
      Point point51 = point1;
      toolBar1_1.Location = point51;
      this.ToolBar1.Name = "ToolBar1";
      TD.SandBar.ToolBar toolBar1_2 = this.ToolBar1;
      size1 = new Size(550, 24);
      Size size52 = size1;
      toolBar1_2.Size = size52;
      this.ToolBar1.TabIndex = 188;
      this.ToolBar1.Text = "ToolBar1";
      this.ButtonItem1.BeginGroup = true;
      this.ButtonItem1.ImageIndex = 4;
      this.ButtonItem2.BeginGroup = true;
      this.ButtonItem2.ImageIndex = 20;
      this.GroupBox5.Controls.Add((Control) this.RadioButton2);
      this.GroupBox5.Controls.Add((Control) this.RadioButton1);
      GroupBox groupBox5_1 = this.GroupBox5;
      point1 = new Point(232, 28);
      Point point52 = point1;
      groupBox5_1.Location = point52;
      this.GroupBox5.Name = "GroupBox5";
      GroupBox groupBox5_2 = this.GroupBox5;
      size1 = new Size(140, 88);
      Size size53 = size1;
      groupBox5_2.Size = size53;
      this.GroupBox5.TabIndex = 189;
      this.GroupBox5.TabStop = false;
      this.GroupBox5.Text = "GroupBox5";
      RadioButton radioButton2_1 = this.RadioButton2;
      point1 = new Point(8, 52);
      Point point53 = point1;
      radioButton2_1.Location = point53;
      this.RadioButton2.Name = "RadioButton2";
      RadioButton radioButton2_2 = this.RadioButton2;
      size1 = new Size(124, 20);
      Size size54 = size1;
      radioButton2_2.Size = size54;
      this.RadioButton2.TabIndex = 1;
      this.RadioButton2.Text = "0x1abe787d";
      this.RadioButton1.Checked = true;
      RadioButton radioButton1_1 = this.RadioButton1;
      point1 = new Point(8, 20);
      Point point54 = point1;
      radioButton1_1.Location = point54;
      this.RadioButton1.Name = "RadioButton1";
      RadioButton radioButton1_2 = this.RadioButton1;
      size1 = new Size(124, 20);
      Size size55 = size1;
      radioButton1_2.Size = size55;
      this.RadioButton1.TabIndex = 0;
      this.RadioButton1.TabStop = true;
      this.RadioButton1.Text = "Standard-Texture";
      this.GroupBox6.Controls.Add((Control) this.LinkLabel1);
      this.GroupBox6.Controls.Add((Control) this.CheckBox1);
      this.GroupBox6.Controls.Add((Control) this.Label7);
      this.GroupBox6.Controls.Add((Control) this.Label8);
      this.GroupBox6.Controls.Add((Control) this.MaxRangeLabel);
      this.GroupBox6.Controls.Add((Control) this.MinRangeLabel);
      this.GroupBox6.Controls.Add((Control) this.Label6);
      GroupBox groupBox6_1 = this.GroupBox6;
      point1 = new Point(8, 444);
      Point point55 = point1;
      groupBox6_1.Location = point55;
      this.GroupBox6.Name = "GroupBox6";
      GroupBox groupBox6_2 = this.GroupBox6;
      size1 = new Size(536, 124);
      Size size56 = size1;
      groupBox6_2.Size = size56;
      this.GroupBox6.TabIndex = 190;
      this.GroupBox6.TabStop = false;
      LinkLabel linkLabel1_1 = this.LinkLabel1;
      point1 = new Point(12, 100);
      Point point56 = point1;
      linkLabel1_1.Location = point56;
      this.LinkLabel1.Name = "LinkLabel1";
      LinkLabel linkLabel1_2 = this.LinkLabel1;
      size1 = new Size(516, 20);
      Size size57 = size1;
      linkLabel1_2.Size = size57;
      this.LinkLabel1.TabIndex = 200;
      this.LinkLabel1.TabStop = true;
      this.LinkLabel1.Text = "get IID range from BSC Texture Index";
      CheckBox checkBox1_1 = this.CheckBox1;
      point1 = new Point(408, 20);
      Point point57 = point1;
      checkBox1_1.Location = point57;
      this.CheckBox1.Name = "CheckBox1";
      CheckBox checkBox1_2 = this.CheckBox1;
      size1 = new Size(120, 20);
      Size size58 = size1;
      checkBox1_2.Size = size58;
      this.CheckBox1.TabIndex = 199;
      this.CheckBox1.Text = "disregard this";
      this.Label7.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      Label label7_1 = this.Label7;
      point1 = new Point(8, 44);
      Point point58 = point1;
      label7_1.Location = point58;
      this.Label7.Name = "Label7";
      Label label7_2 = this.Label7;
      size1 = new Size(524, 52);
      Size size59 = size1;
      label7_2.Size = size59;
      this.Label7.TabIndex = 198;
      this.Label7.Text = "If you disregade this, they may occure several Textures with the same IID on SC4-Exchanges.There is a Thread at ST where you can get your own IID-Range.";
      this.Label7.TextAlign = ContentAlignment.MiddleLeft;
      this.Label8.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      Label label8_3 = this.Label8;
      point1 = new Point(292, 20);
      Point point59 = point1;
      label8_3.Location = point59;
      this.Label8.Name = "Label8";
      Label label8_4 = this.Label8;
      size1 = new Size(20, 20);
      Size size60 = size1;
      label8_4.Size = size60;
      this.Label8.TabIndex = 197;
      this.Label8.Text = "-";
      this.Label8.TextAlign = ContentAlignment.MiddleCenter;
      this.MaxRangeLabel.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      Label maxRangeLabel1 = this.MaxRangeLabel;
      point1 = new Point(316, 20);
      Point point60 = point1;
      maxRangeLabel1.Location = point60;
      this.MaxRangeLabel.Name = "MaxRangeLabel";
      Label maxRangeLabel2 = this.MaxRangeLabel;
      size1 = new Size(88, 20);
      Size size61 = size1;
      maxRangeLabel2.Size = size61;
      this.MaxRangeLabel.TabIndex = 196;
      this.MaxRangeLabel.Text = "0x00000000";
      this.MaxRangeLabel.TextAlign = ContentAlignment.MiddleCenter;
      this.MinRangeLabel.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      Label minRangeLabel1 = this.MinRangeLabel;
      point1 = new Point(208, 20);
      Point point61 = point1;
      minRangeLabel1.Location = point61;
      this.MinRangeLabel.Name = "MinRangeLabel";
      Label minRangeLabel2 = this.MinRangeLabel;
      size1 = new Size(84, 20);
      Size size62 = size1;
      minRangeLabel2.Size = size62;
      this.MinRangeLabel.TabIndex = 195;
      this.MinRangeLabel.Text = "0x00000000";
      this.MinRangeLabel.TextAlign = ContentAlignment.MiddleCenter;
      Label label6_1 = this.Label6;
      point1 = new Point(8, 20);
      Point point62 = point1;
      label6_1.Location = point62;
      this.Label6.Name = "Label6";
      Label label6_2 = this.Label6;
      size1 = new Size(196, 20);
      Size size63 = size1;
      label6_2.Size = size63;
      this.Label6.TabIndex = 194;
      this.Label6.Text = "your personal IID Range is";
      this.Label6.TextAlign = ContentAlignment.MiddleLeft;
      CheckBox checkBox2_1 = this.CheckBox2;
      point1 = new Point(8, 64);
      Point point63 = point1;
      checkBox2_1.Location = point63;
      this.CheckBox2.Name = "CheckBox2";
      CheckBox checkBox2_2 = this.CheckBox2;
      size1 = new Size(204, 20);
      Size size64 = size1;
      checkBox2_2.Size = size64;
      this.CheckBox2.TabIndex = 186;
      this.CheckBox2.Text = "disable TGI - checking";
      size1 = new Size(6, 14);
      this.AutoScaleBaseSize = size1;
      size1 = new Size(550, 571);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.GroupBox6);
      this.Controls.Add((Control) this.GroupBox5);
      this.Controls.Add((Control) this.ToolBar1);
      this.Controls.Add((Control) this.GroupBox4);
      this.Controls.Add((Control) this.GroupBox3);
      this.Controls.Add((Control) this.GroupBox2);
      this.Controls.Add((Control) this.GroupBox1);
      this.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (FormTextureMaker);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "TextureMaker";
      this.GroupBox1.ResumeLayout(false);
      this.GroupBox2.ResumeLayout(false);
      this.GroupBox3.ResumeLayout(false);
      this.GroupBox4.ResumeLayout(false);
      this.GroupBox5.ResumeLayout(false);
      this.GroupBox6.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    private MainWriter.SC4Eintrag BitmapToFSH(
      Bitmap myBitmap,
      Bitmap myAlpha,
      string Instance)
    {
      MemoryStream memoryStream = new MemoryStream();
      byte[] numArray1 = new byte[0];
      byte[] numArray2 = new byte[0];
      MainWriter.SC4Eintrag sc4Eintrag = new MainWriter.SC4Eintrag();
      FSHImage fshImage1 = new FSHImage();
      BitmapItem bitmapItem = new BitmapItem();
      try
      {
        bitmapItem.Bitmap = myBitmap;
        if (!Information.IsNothing((object) myAlpha))
        {
          bitmapItem.Alpha = myAlpha;
          bitmapItem.BmpType = FSHBmpType.DXT3;
        }
        else
        {
          bitmapItem.Alpha = new Bitmap(myBitmap.Width, myBitmap.Height, myBitmap.PixelFormat);
          bitmapItem.BmpType = FSHBmpType.DXT1;
        }
        bitmapItem.SetDirName("BMP1");
        fshImage1.Bitmaps.Add((object) bitmapItem);
        fshImage1.Save((Stream) memoryStream);
        byte[] array = memoryStream.ToArray();
        memoryStream.Close();
        if (array.GetUpperBound(0) == -1)
        {
          sc4Eintrag.LeseBytes = (byte[]) null;
          return sc4Eintrag;
        }
        FSHImage fshImage2 = new FSHImage();
        byte[] numArray3;
        try
        {
          numArray3 = fshImage2.Comp(array, true);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          numArray3 = array;
          ProjectData.ClearProjectError();
        }
        if (numArray3.GetUpperBound(0) > -1)
        {
          sc4Eintrag.Index.ExpectedSize = checked (array.GetUpperBound(0) + 1);
        }
        else
        {
          numArray3 = array;
          sc4Eintrag.Index.ExpectedSize = 0;
        }
        sc4Eintrag.Index.Size = checked (numArray3.GetUpperBound(0) + 1);
        sc4Eintrag.LeseBytes = numArray3;
        sc4Eintrag.Index.OriginalType = 2058686020L;
        sc4Eintrag.Index.OriginalGroup = !this.RadioButton1.Checked ? 448690301L : 159781726L;
        string str = Instance.ToUpper().Replace("0X", "&h");
        sc4Eintrag.Index.OriginalInstance = LongType.FromString(str);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        sc4Eintrag.LeseBytes = (byte[]) null;
        ProjectData.ClearProjectError();
      }
      return sc4Eintrag;
    }

    private TextureReader.TextureDef OpenImageFile(int BildGroesse)
    {
      TextureReader.TextureDef textureDef;
      textureDef.Picture = (Bitmap) null;
      textureDef.SmallFileName = "";
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Multiselect = false;
      openFileDialog.RestoreDirectory = true;
      openFileDialog.Title = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[144]);
      openFileDialog.ShowReadOnly = true;
      openFileDialog.CheckFileExists = true;
      openFileDialog.Filter = "Images (*.jpg;*.bmp;*.png)|*.jpg;*.bmp;*.png|All (*.*)|*.*";
      if (openFileDialog.ShowDialog() == DialogResult.OK)
      {
        PictureBox pictureBox = new PictureBox();
        try
        {
          Image image = Image.FromFile(openFileDialog.FileName);
          if (image.Width == BildGroesse & image.Height == BildGroesse)
          {
            textureDef.Picture = (Bitmap) image.Clone();
            textureDef.PictureSize = BildGroesse;
            FileInfo fileInfo = new FileInfo(openFileDialog.FileName);
            textureDef.SmallFileName = fileInfo.Name;
          }
          image.Dispose();
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          int num = (int) MessageBox.Show((IWin32Window) this, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[146]), "Images", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          ProjectData.ClearProjectError();
        }
      }
      return textureDef;
    }

    private object ClearEinzelBild(ref TextureReader.TextureDef ClearBild)
    {
      ClearBild.SmallFileName = "";
      ClearBild.FileName = "";
      ClearBild.Instance = "";
      if (!Information.IsNothing((object) ClearBild.Picture))
        ClearBild.Picture.Dispose();
      object obj;
      return obj;
    }

    private object Clear()
    {
      this.ClearEinzelBild(ref this.CurrentPic_128);
      this.ClearEinzelBild(ref this.CurrentPic_64);
      this.ClearEinzelBild(ref this.CurrentPic_32);
      this.ClearEinzelBild(ref this.CurrentPic_16);
      this.ClearEinzelBild(ref this.CurrentPic_8);
      this.ClearEinzelBild(ref this.CurrentPic_A_128);
      this.ClearEinzelBild(ref this.CurrentPic_A_64);
      this.ClearEinzelBild(ref this.CurrentPic_A_32);
      this.ClearEinzelBild(ref this.CurrentPic_A_16);
      this.ClearEinzelBild(ref this.CurrentPic_A_8);
      if (!Information.IsNothing((object) this.Pic_128.Image))
      {
        this.Pic_128.Image.Dispose();
        this.Pic_128.Image = (Image) null;
      }
      if (!Information.IsNothing((object) this.Pic_64.Image))
      {
        this.Pic_64.Image.Dispose();
        this.Pic_64.Image = (Image) null;
      }
      if (!Information.IsNothing((object) this.Pic_32.Image))
      {
        this.Pic_32.Image.Dispose();
        this.Pic_32.Image = (Image) null;
      }
      if (!Information.IsNothing((object) this.Pic_16.Image))
      {
        this.Pic_16.Image.Dispose();
        this.Pic_16.Image = (Image) null;
      }
      if (!Information.IsNothing((object) this.Pic_8.Image))
      {
        this.Pic_8.Image.Dispose();
        this.Pic_8.Image = (Image) null;
      }
      if (!Information.IsNothing((object) this.A_Pic_128.Image))
      {
        this.A_Pic_128.Image.Dispose();
        this.A_Pic_128.Image = (Image) null;
      }
      if (!Information.IsNothing((object) this.A_Pic_64.Image))
      {
        this.A_Pic_64.Image.Dispose();
        this.A_Pic_64.Image = (Image) null;
      }
      if (!Information.IsNothing((object) this.A_Pic_32.Image))
      {
        this.A_Pic_32.Image.Dispose();
        this.A_Pic_32.Image = (Image) null;
      }
      if (!Information.IsNothing((object) this.A_Pic_16.Image))
      {
        this.A_Pic_16.Image.Dispose();
        this.A_Pic_16.Image = (Image) null;
      }
      if (!Information.IsNothing((object) this.A_Pic_8.Image))
      {
        this.A_Pic_8.Image.Dispose();
        this.A_Pic_8.Image = (Image) null;
      }
      this.Label_128.Text = "";
      this.Label_64.Text = "";
      this.Label_32.Text = "";
      this.Label_16.Text = "";
      this.Label_8.Text = "";
      this.A_Label_128.Text = "";
      this.A_Label_64.Text = "";
      this.A_Label_32.Text = "";
      this.A_Label_16.Text = "";
      this.A_Label_8.Text = "";
      this.InstanceTextBox.Text = "";
      object obj;
      return obj;
    }

    private bool SaveTextures()
    {
      this.Cursor = Cursors.WaitCursor;
      string str1 = this.InstanceTextBox.Text.Substring(0, 9).ToUpper().Replace("0X", "0x");
      string sLeft = this.InstanceTextBox.Text.Substring(9, 1);
      string str2;
      string str3;
      string str4;
      string str5;
      string str6;
      if (StringType.StrCmp(sLeft, "A", false) == 0)
      {
        str2 = "A";
        str3 = "B";
        str4 = "C";
        str5 = "D";
        str6 = "E";
      }
      else if (StringType.StrCmp(sLeft, "0", false) == 0)
      {
        str2 = "0";
        str3 = "1";
        str4 = "2";
        str5 = "3";
        str6 = "4";
      }
      else if (StringType.StrCmp(sLeft, "5", false) == 0)
      {
        str2 = "5";
        str3 = "6";
        str4 = "7";
        str5 = "8";
        str6 = "9";
      }
      FileInfo fileInfo = new FileInfo(this.CurrentDatei);
      this.CurrentPic_128.Instance = str1 + str6;
      this.CurrentPic_128.Gruppe = str1 + str2;
      this.CurrentPic_128.FileName = fileInfo.FullName;
      this.CurrentPic_128.SmallFileName = fileInfo.Name;
      this.CurrentPic_64.Instance = str1 + str5;
      this.CurrentPic_64.Gruppe = str1 + str2;
      this.CurrentPic_64.FileName = fileInfo.FullName;
      this.CurrentPic_64.SmallFileName = fileInfo.Name;
      this.CurrentPic_32.Instance = str1 + str4;
      this.CurrentPic_32.Gruppe = str1 + str2;
      this.CurrentPic_32.FileName = fileInfo.FullName;
      this.CurrentPic_32.SmallFileName = fileInfo.Name;
      this.CurrentPic_16.Instance = str1 + str3;
      this.CurrentPic_16.Gruppe = str1 + str2;
      this.CurrentPic_16.FileName = fileInfo.FullName;
      this.CurrentPic_16.SmallFileName = fileInfo.Name;
      this.CurrentPic_8.Instance = str1 + str2;
      this.CurrentPic_8.Gruppe = str1 + str2;
      this.CurrentPic_8.FileName = fileInfo.FullName;
      this.CurrentPic_8.SmallFileName = fileInfo.Name;
      MainWriter.SC4Eintrag[] sc4EintragArray = new MainWriter.SC4Eintrag[0];
      MainWriter.SC4Eintrag[] TextureIndexes = new MainWriter.SC4Eintrag[5];
      if (Information.IsNothing((object) this.A_Pic_128.Image) | Information.IsNothing((object) this.A_Pic_64.Image) | Information.IsNothing((object) this.A_Pic_32.Image) | Information.IsNothing((object) this.A_Pic_16.Image) | Information.IsNothing((object) this.A_Pic_8.Image))
      {
        if (!Information.IsNothing((object) this.A_Pic_128.Image))
        {
          this.A_Pic_128.Image.Dispose();
          this.A_Pic_128.Image = (Image) null;
        }
        if (!Information.IsNothing((object) this.A_Pic_64.Image))
        {
          this.A_Pic_64.Image.Dispose();
          this.A_Pic_64.Image = (Image) null;
        }
        if (!Information.IsNothing((object) this.A_Pic_32.Image))
        {
          this.A_Pic_32.Image.Dispose();
          this.A_Pic_32.Image = (Image) null;
        }
        if (!Information.IsNothing((object) this.A_Pic_16.Image))
        {
          this.A_Pic_16.Image.Dispose();
          this.A_Pic_16.Image = (Image) null;
        }
        if (!Information.IsNothing((object) this.A_Pic_8.Image))
        {
          this.A_Pic_8.Image.Dispose();
          this.A_Pic_8.Image = (Image) null;
        }
      }
      TextureIndexes[0] = this.BitmapToFSH(this.CurrentPic_128.Picture, (Bitmap) this.A_Pic_128.Image, this.CurrentPic_128.Instance);
      bool flag;
      if (Information.IsNothing((object) TextureIndexes[0].LeseBytes))
      {
        this.Cursor = Cursors.Default;
        flag = false;
      }
      else
      {
        TextureIndexes[1] = this.BitmapToFSH(this.CurrentPic_64.Picture, (Bitmap) this.A_Pic_64.Image, this.CurrentPic_64.Instance);
        if (Information.IsNothing((object) TextureIndexes[1].LeseBytes))
        {
          this.Cursor = Cursors.Default;
          flag = false;
        }
        else
        {
          TextureIndexes[2] = this.BitmapToFSH(this.CurrentPic_32.Picture, (Bitmap) this.A_Pic_32.Image, this.CurrentPic_32.Instance);
          if (Information.IsNothing((object) TextureIndexes[2].LeseBytes))
          {
            this.Cursor = Cursors.Default;
            flag = false;
          }
          else
          {
            TextureIndexes[3] = this.BitmapToFSH(this.CurrentPic_16.Picture, (Bitmap) this.A_Pic_16.Image, this.CurrentPic_16.Instance);
            if (Information.IsNothing((object) TextureIndexes[3].LeseBytes))
            {
              this.Cursor = Cursors.Default;
              flag = false;
            }
            else
            {
              TextureIndexes[4] = this.BitmapToFSH(this.CurrentPic_8.Picture, (Bitmap) this.A_Pic_8.Image, this.CurrentPic_8.Instance);
              if (Information.IsNothing((object) TextureIndexes[4].LeseBytes))
              {
                this.Cursor = Cursors.Default;
                flag = false;
              }
              else
              {
                MainWriter mainWriter = new MainWriter();
                if (!new FileInfo(this.CurrentDatei).Exists)
                {
                  if (!mainWriter.CreateNewTextureFile(this.CurrentDatei, TextureIndexes))
                  {
                    mainWriter.Dispose();
                    this.Cursor = Cursors.Default;
                    flag = false;
                  }
                  else
                  {
                    this.HasAddedImages = true;
                    mainWriter.Dispose();
                    ClassThisProg.DefReader.TextureListe.GetTextures(this.CurrentDatei);
                    if (!Information.IsNothing((object) ClassThisProg.frmTM))
                      ClassThisProg.frmTM.FillFromExtern(this.CurrentDatei);
                    this.Cursor = Cursors.Default;
                    flag = true;
                  }
                }
                else
                {
                  try
                  {
                    mainWriter.LeseDatei = this.CurrentDatei;
                    mainWriter.CreateBackup = ClassThisProg.DefReader.CreateBackup;
                    if (!mainWriter.AddTextures(TextureIndexes))
                    {
                      this.Cursor = Cursors.Default;
                      flag = false;
                      goto label_41;
                    }
                    else
                    {
                      ClassThisProg.DefReader.TextureListe.RefreshTextures(this.CurrentDatei);
                      ClassThisProg.DefReader.TextureListe.GetTextures(this.CurrentDatei);
                      if (!Information.IsNothing((object) ClassThisProg.frmTM))
                        ClassThisProg.frmTM.FillFromExtern(this.CurrentDatei);
                      this.HasAddedImages = true;
                      mainWriter.Dispose();
                    }
                  }
                  catch (Exception ex)
                  {
                    ProjectData.SetProjectError(ex);
                    this.Cursor = Cursors.Default;
                    flag = false;
                    ProjectData.ClearProjectError();
                    goto label_41;
                  }
                  this.Cursor = Cursors.Default;
                  flag = true;
                }
              }
            }
          }
        }
      }
label_41:
      return flag;
    }

    private object PaintPictureBox(PictureBox m_PictureBox, PaintEventArgs e)
    {
      Color color1 = SystemColors.ControlLight;
      Color color2 = SystemColors.ControlDark;
      if (this.MouseState == FormTextureMaker.eMouseState.NoMouse)
      {
        color1 = SystemColors.Control;
        color2 = SystemColors.Control;
      }
      if (this.MouseState == FormTextureMaker.eMouseState.MouseOver)
      {
        color1 = SystemColors.ControlLight;
        color2 = SystemColors.ControlDark;
      }
      if (this.MouseState == FormTextureMaker.eMouseState.MouseDown)
      {
        color1 = SystemColors.ControlDark;
        color2 = SystemColors.ControlLight;
      }
      Pen pen1 = new Pen(color1, 1f);
      Pen pen2 = new Pen(color2, 1f);
      RectangleF rectangleF = new RectangleF(0.0f, 0.0f, (float) m_PictureBox.Width, (float) m_PictureBox.Height);
      RectangleF clipBounds = e.Graphics.ClipBounds;
      e.Graphics.Clear(SystemColors.Control);
      e.Graphics.DrawLine(pen1, 0.0f, 0.0f, 0.0f, rectangleF.Height);
      e.Graphics.DrawLine(pen1, 0.0f, 0.0f, rectangleF.Width, 0.0f);
      e.Graphics.DrawLine(pen2, 0.0f, rectangleF.Height - 1f, rectangleF.Width, rectangleF.Height - 1f);
      e.Graphics.DrawLine(pen2, rectangleF.Width - 1f, 0.0f, rectangleF.Width - 1f, rectangleF.Height);
      e.Graphics.DrawImage(m_PictureBox.Image, 2, 2);
      pen1.Dispose();
      pen2.Dispose();
      object obj;
      return obj;
    }

    public object SetzeTexte()
    {
      this.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[435]);
      this.Button3.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[438]);
      this.ButtonItem1.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[3]);
      this.ButtonItem2.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[441]);
      this.ToolTip1.SetToolTip((Control) this.Open_8, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[16]));
      this.ToolTip1.SetToolTip((Control) this.Open_16, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[16]));
      this.ToolTip1.SetToolTip((Control) this.Open_32, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[16]));
      this.ToolTip1.SetToolTip((Control) this.Open_64, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[16]));
      this.ToolTip1.SetToolTip((Control) this.Open_128, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[16]));
      this.ToolTip1.SetToolTip((Control) this.Open_A_8, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[16]));
      this.ToolTip1.SetToolTip((Control) this.Open_A_16, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[16]));
      this.ToolTip1.SetToolTip((Control) this.Open_A_32, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[16]));
      this.ToolTip1.SetToolTip((Control) this.Open_A_64, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[16]));
      this.ToolTip1.SetToolTip((Control) this.Open_A_128, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[16]));
      this.ToolTip1.SetToolTip((Control) this.CopyBitmap, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[461]));
      this.ToolTip1.SetToolTip((Control) this.CopyAlpha, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[461]));
      this.GroupBox5.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[464]);
      this.RadioButton1.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[465]);
      this.RadioButton2.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[466]);
      this.ToolTip1.SetToolTip((Control) this.RadioButton1, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[462]));
      this.ToolTip1.SetToolTip((Control) this.RadioButton2, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[463]));
      this.Label6.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[552]);
      this.CheckBox1.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[553]);
      this.Label7.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[554]);
      this.LinkLabel1.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[555]);
      this.CheckBox2.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[567]);
      object obj;
      return obj;
    }

    private void FormTextureMaker_Load(object sender, EventArgs e)
    {
      sr_Userinterface.AendereFarben((Form) this, ClassThisProg.DefReader.FarbSchema);
      this.SetzeTexte();
      this.HasAddedImages = false;
      this.MinRangeLabel.Text = ClassThisProg.DefReader.TextureLowerLimit;
      this.MaxRangeLabel.Text = ClassThisProg.DefReader.TextureUpperLimit;
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      cTexture cTexture1 = new cTexture();
      if (this.InstanceTextBox.Text.Length != 10)
      {
        int num1 = (int) MessageBox.Show((IWin32Window) this, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[374]), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      else
      {
        if (this.InstanceTextBox.Text.Length == 8)
          this.InstanceTextBox.Text = "0x" + this.InstanceTextBox.Text;
        if (!this.InstanceTextBox.Text.ToUpper().StartsWith("0X"))
        {
          int num2 = (int) MessageBox.Show((IWin32Window) this, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[374]), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        else if (!this.InstanceTextBox.Text.ToUpper().EndsWith("0") && !this.InstanceTextBox.Text.ToUpper().EndsWith("5") && !this.InstanceTextBox.Text.ToUpper().EndsWith("A"))
        {
          int num3 = (int) MessageBox.Show((IWin32Window) this, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[374]), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        else
        {
          try
          {
            LongType.FromString(this.InstanceTextBox.Text.ToUpper().Replace("0X", "&h"));
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            int num4 = (int) MessageBox.Show((IWin32Window) this, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[374]), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            ProjectData.ClearProjectError();
            return;
          }
          cTexture cTexture2 = ClassThisProg.DefReader.TextureListe.SearchTexture(this.InstanceTextBox.Text.ToUpper().Replace("0X", "0x"), 8);
          if (cTexture2.Count > 0 && !this.CheckBox2.Checked)
          {
            int num5 = (int) MessageBox.Show((IWin32Window) this, StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj(ClassThisProg.DefReader.LanguageArray[439], (object) ":"), (object) cTexture2.get_item(0).SmallFileName)), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
          }
          else if (!Information.IsNothing((object) this.CurrentPic_128.Picture) & !Information.IsNothing((object) this.CurrentPic_64.Picture) & !Information.IsNothing((object) this.CurrentPic_32.Picture) & !Information.IsNothing((object) this.CurrentPic_16.Picture) & !Information.IsNothing((object) this.CurrentPic_8.Picture))
          {
            if (this.SaveTextures())
            {
              int num6 = (int) MessageBox.Show((IWin32Window) this, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[27]), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[17]), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
              this.Clear();
            }
            else
            {
              int num7 = (int) MessageBox.Show((IWin32Window) this, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[26]), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[17]), MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
          }
          else
          {
            int num8 = (int) MessageBox.Show((IWin32Window) this, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[440]), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
          }
        }
      }
    }

    private void FormTextureMaker_Closed(object sender, EventArgs e) => ClassThisProg.frmTextureMaker = (FormTextureMaker) null;

    private void Open_8_Click(object sender, EventArgs e)
    {
      TextureReader.TextureDef textureDef = this.OpenImageFile(8);
      if (StringType.StrCmp(textureDef.SmallFileName, "", false) == 0)
        return;
      this.Label_8.Text = textureDef.SmallFileName;
      this.Pic_8.Image = (Image) textureDef.Picture;
      this.CurrentPic_8 = textureDef;
    }

    private void Open_8_Paint(object sender, PaintEventArgs e) => this.PaintPictureBox(this.Open_8, e);

    private void Open_8_MouseDown(object sender, MouseEventArgs e)
    {
      this.MouseState = FormTextureMaker.eMouseState.MouseDown;
      this.Open_8.Refresh();
    }

    private void Open_8_MouseUp(object sender, MouseEventArgs e)
    {
      this.MouseState = FormTextureMaker.eMouseState.MouseOver;
      this.Open_8.Refresh();
    }

    private void Open_8_MouseEnter(object sender, EventArgs e)
    {
      this.MouseState = FormTextureMaker.eMouseState.MouseOver;
      this.Open_8.Refresh();
    }

    private void Open_8_MouseLeave(object sender, EventArgs e)
    {
      this.MouseState = FormTextureMaker.eMouseState.NoMouse;
      this.Open_8.Refresh();
    }

    private void Open_16_Click(object sender, EventArgs e)
    {
      TextureReader.TextureDef textureDef = this.OpenImageFile(16);
      if (StringType.StrCmp(textureDef.SmallFileName, "", false) == 0)
        return;
      this.Label_16.Text = textureDef.SmallFileName;
      this.Pic_16.Image = (Image) textureDef.Picture;
      this.CurrentPic_16 = textureDef;
    }

    private void Open_16_Paint(object sender, PaintEventArgs e) => this.PaintPictureBox(this.Open_16, e);

    private void Open_16_MouseDown(object sender, MouseEventArgs e)
    {
      this.MouseState = FormTextureMaker.eMouseState.MouseDown;
      this.Open_16.Refresh();
    }

    private void Open_16_MouseUp(object sender, MouseEventArgs e)
    {
      this.MouseState = FormTextureMaker.eMouseState.MouseOver;
      this.Open_16.Refresh();
    }

    private void Open_16_MouseEnter(object sender, EventArgs e)
    {
      this.MouseState = FormTextureMaker.eMouseState.MouseOver;
      this.Open_16.Refresh();
    }

    private void Open_16_MouseLeave(object sender, EventArgs e)
    {
      this.MouseState = FormTextureMaker.eMouseState.NoMouse;
      this.Open_16.Refresh();
    }

    private void Open_32_Click(object sender, EventArgs e)
    {
      TextureReader.TextureDef textureDef = this.OpenImageFile(32);
      if (StringType.StrCmp(textureDef.SmallFileName, "", false) == 0)
        return;
      this.Label_32.Text = textureDef.SmallFileName;
      this.Pic_32.Image = (Image) textureDef.Picture;
      this.CurrentPic_32 = textureDef;
    }

    private void Open_32_Paint(object sender, PaintEventArgs e) => this.PaintPictureBox(this.Open_32, e);

    private void Open_32_MouseDown(object sender, MouseEventArgs e)
    {
      this.MouseState = FormTextureMaker.eMouseState.MouseDown;
      this.Open_32.Refresh();
    }

    private void Open_32_MouseUp(object sender, MouseEventArgs e)
    {
      this.MouseState = FormTextureMaker.eMouseState.MouseOver;
      this.Open_32.Refresh();
    }

    private void Open_32_MouseEnter(object sender, EventArgs e)
    {
      this.MouseState = FormTextureMaker.eMouseState.MouseOver;
      this.Open_32.Refresh();
    }

    private void Open_32_MouseLeave(object sender, EventArgs e)
    {
      this.MouseState = FormTextureMaker.eMouseState.NoMouse;
      this.Open_32.Refresh();
    }

    private void Open_64_Click(object sender, EventArgs e)
    {
      TextureReader.TextureDef textureDef = this.OpenImageFile(64);
      if (StringType.StrCmp(textureDef.SmallFileName, "", false) == 0)
        return;
      this.Label_64.Text = textureDef.SmallFileName;
      this.Pic_64.Image = (Image) textureDef.Picture;
      this.CurrentPic_64 = textureDef;
    }

    private void Open_64_Paint(object sender, PaintEventArgs e) => this.PaintPictureBox(this.Open_64, e);

    private void Open_64_MouseDown(object sender, MouseEventArgs e)
    {
      this.MouseState = FormTextureMaker.eMouseState.MouseDown;
      this.Open_64.Refresh();
    }

    private void Open_64_MouseUp(object sender, MouseEventArgs e)
    {
      this.MouseState = FormTextureMaker.eMouseState.MouseOver;
      this.Open_64.Refresh();
    }

    private void Open_64_MouseEnter(object sender, EventArgs e)
    {
      this.MouseState = FormTextureMaker.eMouseState.MouseOver;
      this.Open_64.Refresh();
    }

    private void Open_64_MouseLeave(object sender, EventArgs e)
    {
      this.MouseState = FormTextureMaker.eMouseState.NoMouse;
      this.Open_64.Refresh();
    }

    private void Open_128_Click(object sender, EventArgs e)
    {
      TextureReader.TextureDef textureDef = this.OpenImageFile(128);
      if (StringType.StrCmp(textureDef.SmallFileName, "", false) == 0)
        return;
      this.Label_128.Text = textureDef.SmallFileName;
      this.Pic_128.Image = (Image) textureDef.Picture;
      this.CurrentPic_128 = textureDef;
    }

    private void Open_128_Paint(object sender, PaintEventArgs e) => this.PaintPictureBox(this.Open_128, e);

    private void Open_128_MouseDown(object sender, MouseEventArgs e)
    {
      this.MouseState = FormTextureMaker.eMouseState.MouseDown;
      this.Open_128.Refresh();
    }

    private void Open_128_MouseUp(object sender, MouseEventArgs e)
    {
      this.MouseState = FormTextureMaker.eMouseState.MouseOver;
      this.Open_128.Refresh();
    }

    private void Open_128_MouseEnter(object sender, EventArgs e)
    {
      this.MouseState = FormTextureMaker.eMouseState.MouseOver;
      this.Open_128.Refresh();
    }

    private void Open_128_MouseLeave(object sender, EventArgs e)
    {
      this.MouseState = FormTextureMaker.eMouseState.NoMouse;
      this.Open_128.Refresh();
    }

    private void Open_A_8_Click(object sender, EventArgs e)
    {
      TextureReader.TextureDef textureDef = this.OpenImageFile(8);
      if (StringType.StrCmp(textureDef.SmallFileName, "", false) == 0)
        return;
      this.A_Label_8.Text = textureDef.SmallFileName;
      this.A_Pic_8.Image = (Image) textureDef.Picture;
      this.CurrentPic_A_8 = textureDef;
    }

    private void Open_A_8_Paint(object sender, PaintEventArgs e) => this.PaintPictureBox(this.Open_A_8, e);

    private void Open_A_8_MouseDown(object sender, MouseEventArgs e)
    {
      this.MouseState = FormTextureMaker.eMouseState.MouseDown;
      this.Open_A_8.Refresh();
    }

    private void Open_A_8_MouseUp(object sender, MouseEventArgs e)
    {
      this.MouseState = FormTextureMaker.eMouseState.MouseOver;
      this.Open_A_8.Refresh();
    }

    private void Open_A_8_MouseEnter(object sender, EventArgs e)
    {
      this.MouseState = FormTextureMaker.eMouseState.MouseOver;
      this.Open_A_8.Refresh();
    }

    private void Open_A_8_MouseLeave(object sender, EventArgs e)
    {
      this.MouseState = FormTextureMaker.eMouseState.NoMouse;
      this.Open_A_8.Refresh();
    }

    private void Open_A_16_Click(object sender, EventArgs e)
    {
      TextureReader.TextureDef textureDef = this.OpenImageFile(16);
      if (StringType.StrCmp(textureDef.SmallFileName, "", false) == 0)
        return;
      this.A_Label_16.Text = textureDef.SmallFileName;
      this.A_Pic_16.Image = (Image) textureDef.Picture;
      this.CurrentPic_A_16 = textureDef;
    }

    private void Open_A_16_Paint(object sender, PaintEventArgs e) => this.PaintPictureBox(this.Open_A_16, e);

    private void Open_A_16_MouseDown(object sender, MouseEventArgs e)
    {
      this.MouseState = FormTextureMaker.eMouseState.MouseDown;
      this.Open_A_16.Refresh();
    }

    private void Open_A_16_MouseUp(object sender, MouseEventArgs e)
    {
      this.MouseState = FormTextureMaker.eMouseState.MouseOver;
      this.Open_A_16.Refresh();
    }

    private void Open_A_16_MouseEnter(object sender, EventArgs e)
    {
      this.MouseState = FormTextureMaker.eMouseState.MouseOver;
      this.Open_A_16.Refresh();
    }

    private void Open_A_16_MouseLeave(object sender, EventArgs e)
    {
      this.MouseState = FormTextureMaker.eMouseState.NoMouse;
      this.Open_A_16.Refresh();
    }

    private void Open_A_32_Click(object sender, EventArgs e)
    {
      TextureReader.TextureDef textureDef = this.OpenImageFile(32);
      if (StringType.StrCmp(textureDef.SmallFileName, "", false) == 0)
        return;
      this.A_Label_32.Text = textureDef.SmallFileName;
      this.A_Pic_32.Image = (Image) textureDef.Picture;
      this.CurrentPic_A_32 = textureDef;
    }

    private void Open_A_32_Paint(object sender, PaintEventArgs e) => this.PaintPictureBox(this.Open_A_32, e);

    private void Open_A_32_MouseDown(object sender, MouseEventArgs e)
    {
      this.MouseState = FormTextureMaker.eMouseState.MouseDown;
      this.Open_A_32.Refresh();
    }

    private void Open_A_32_MouseUp(object sender, MouseEventArgs e)
    {
      this.MouseState = FormTextureMaker.eMouseState.MouseOver;
      this.Open_A_32.Refresh();
    }

    private void Open_A_32_MouseEnter(object sender, EventArgs e)
    {
      this.MouseState = FormTextureMaker.eMouseState.MouseOver;
      this.Open_A_32.Refresh();
    }

    private void Open_A_32_MouseLeave(object sender, EventArgs e)
    {
      this.MouseState = FormTextureMaker.eMouseState.NoMouse;
      this.Open_A_32.Refresh();
    }

    private void Open_A_64_Click(object sender, EventArgs e)
    {
      TextureReader.TextureDef textureDef = this.OpenImageFile(64);
      if (StringType.StrCmp(textureDef.SmallFileName, "", false) == 0)
        return;
      this.A_Label_64.Text = textureDef.SmallFileName;
      this.A_Pic_64.Image = (Image) textureDef.Picture;
      this.CurrentPic_A_64 = textureDef;
    }

    private void Open_A_64_Paint(object sender, PaintEventArgs e) => this.PaintPictureBox(this.Open_A_64, e);

    private void Open_A_64_MouseDown(object sender, MouseEventArgs e)
    {
      this.MouseState = FormTextureMaker.eMouseState.MouseDown;
      this.Open_A_64.Refresh();
    }

    private void Open_A_64_MouseUp(object sender, MouseEventArgs e)
    {
      this.MouseState = FormTextureMaker.eMouseState.MouseOver;
      this.Open_A_64.Refresh();
    }

    private void Open_A_64_MouseEnter(object sender, EventArgs e)
    {
      this.MouseState = FormTextureMaker.eMouseState.MouseOver;
      this.Open_A_64.Refresh();
    }

    private void Open_A_64_MouseLeave(object sender, EventArgs e)
    {
      this.MouseState = FormTextureMaker.eMouseState.NoMouse;
      this.Open_A_64.Refresh();
    }

    private void Open_A_128_Click(object sender, EventArgs e)
    {
      TextureReader.TextureDef textureDef = this.OpenImageFile(128);
      if (StringType.StrCmp(textureDef.SmallFileName, "", false) == 0)
        return;
      this.A_Label_128.Text = textureDef.SmallFileName;
      this.A_Pic_128.Image = (Image) textureDef.Picture;
      this.CurrentPic_A_128 = textureDef;
    }

    private void Open_A_128_Paint(object sender, PaintEventArgs e) => this.PaintPictureBox(this.Open_A_128, e);

    private void Open_A_128_MouseDown(object sender, MouseEventArgs e)
    {
      this.MouseState = FormTextureMaker.eMouseState.MouseDown;
      this.Open_A_128.Refresh();
    }

    private void Open_A_128_MouseUp(object sender, MouseEventArgs e)
    {
      this.MouseState = FormTextureMaker.eMouseState.MouseOver;
      this.Open_A_128.Refresh();
    }

    private void Open_A_128_MouseEnter(object sender, EventArgs e)
    {
      this.MouseState = FormTextureMaker.eMouseState.MouseOver;
      this.Open_A_128.Refresh();
    }

    private void Open_A_128_MouseLeave(object sender, EventArgs e)
    {
      this.MouseState = FormTextureMaker.eMouseState.NoMouse;
      this.Open_A_128.Refresh();
    }

    private void InstanceTextBox_Validating(object sender, CancelEventArgs e)
    {
    }

    private void CopyBitmap_Click(object sender, EventArgs e)
    {
      if (Information.IsNothing((object) this.Pic_128.Image))
        return;
      this.Pic_64.Image = this.Pic_128.Image.GetThumbnailImage(64, 64, (Image.GetThumbnailImageAbort) null, (IntPtr) ((object) null ?? Activator.CreateInstance(typeof (IntPtr))));
      this.Pic_32.Image = this.Pic_128.Image.GetThumbnailImage(32, 32, (Image.GetThumbnailImageAbort) null, (IntPtr) ((object) null ?? Activator.CreateInstance(typeof (IntPtr))));
      this.Pic_16.Image = this.Pic_128.Image.GetThumbnailImage(16, 16, (Image.GetThumbnailImageAbort) null, (IntPtr) ((object) null ?? Activator.CreateInstance(typeof (IntPtr))));
      this.Pic_8.Image = this.Pic_128.Image.GetThumbnailImage(8, 8, (Image.GetThumbnailImageAbort) null, (IntPtr) ((object) null ?? Activator.CreateInstance(typeof (IntPtr))));
      this.CurrentPic_64.Picture = (Bitmap) this.Pic_64.Image;
      this.CurrentPic_32.Picture = (Bitmap) this.Pic_32.Image;
      this.CurrentPic_16.Picture = (Bitmap) this.Pic_16.Image;
      this.CurrentPic_8.Picture = (Bitmap) this.Pic_8.Image;
    }

    private void CopyAlpha_Click(object sender, EventArgs e)
    {
      if (Information.IsNothing((object) this.A_Pic_128.Image))
        return;
      this.A_Pic_64.Image = this.A_Pic_128.Image.GetThumbnailImage(64, 64, (Image.GetThumbnailImageAbort) null, (IntPtr) ((object) null ?? Activator.CreateInstance(typeof (IntPtr))));
      this.A_Pic_32.Image = this.A_Pic_128.Image.GetThumbnailImage(32, 32, (Image.GetThumbnailImageAbort) null, (IntPtr) ((object) null ?? Activator.CreateInstance(typeof (IntPtr))));
      this.A_Pic_16.Image = this.A_Pic_128.Image.GetThumbnailImage(16, 16, (Image.GetThumbnailImageAbort) null, (IntPtr) ((object) null ?? Activator.CreateInstance(typeof (IntPtr))));
      this.A_Pic_8.Image = this.A_Pic_128.Image.GetThumbnailImage(8, 8, (Image.GetThumbnailImageAbort) null, (IntPtr) ((object) null ?? Activator.CreateInstance(typeof (IntPtr))));
      this.CurrentPic_A_64.Picture = (Bitmap) this.A_Pic_64.Image;
      this.CurrentPic_A_32.Picture = (Bitmap) this.A_Pic_32.Image;
      this.CurrentPic_A_16.Picture = (Bitmap) this.A_Pic_16.Image;
      this.CurrentPic_A_8.Picture = (Bitmap) this.A_Pic_8.Image;
    }

    private void ButtonItem1_Activate(object sender, EventArgs e) => this.Dispose();

    private void Button3_Click(object sender, EventArgs e)
    {
      string MinWert = ClassThisProg.DefReader.TextureLowerLimit.ToUpper().Replace("0X", "&h");
      string MaxWert = ClassThisProg.DefReader.TextureUpperLimit.ToUpper().Replace("0X", "&h");
      this.InstanceTextBox.Text = this.CheckBox1.Checked ? (!this.RadioButton1.Checked ? ClassThisProg.DefReader.TextureListe.GetMaxID(true) : ClassThisProg.DefReader.TextureListe.GetMaxID(false)) : (!this.RadioButton1.Checked ? ClassThisProg.DefReader.TextureListe.GetMaxID(true) : ClassThisProg.DefReader.TextureListe.GetMaxID(MinWert, MaxWert));
    }

    private void ButtonItem2_Activate(object sender, EventArgs e) => this.Clear();

    private void RadioButton1_CheckedChanged(object sender, EventArgs e) => this.InstanceTextBox.Text = "";

    private void RadioButton2_CheckedChanged(object sender, EventArgs e) => this.InstanceTextBox.Text = "";

    private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      try
      {
        Process.Start(ClassThisProg.DefReader.TextureLink);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private enum eMouseState
    {
      NoMouse,
      MouseOver,
      MouseDown,
    }
  }
}
