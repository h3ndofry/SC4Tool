// Decompiled with JetBrains decompiler
// Type: SC4Tool.FormEditTransit
// Assembly: SC4Tool, Version=2.2.7.0, Culture=neutral, PublicKeyToken=null
// MVID: 69A50BC4-87A5-4C5E-BEFC-08274BC6D498
// Assembly location: C:\Program Files (x86)\SC4 Utilities\SC4Tool\SC4Tool.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using sr_SC4Lib;
using sr_SourceGrid;
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

namespace SC4Tool
{
  public class FormEditTransit : Form
  {
    [AccessedThroughProperty("Label3")]
    private Label _Label3;
    [AccessedThroughProperty("RadioButton1")]
    private RadioButton _RadioButton1;
    [AccessedThroughProperty("RadioButton2")]
    private RadioButton _RadioButton2;
    [AccessedThroughProperty("GroupBox1")]
    private GroupBox _GroupBox1;
    [AccessedThroughProperty("CheckMirror")]
    private System.Windows.Forms.CheckBox _CheckMirror;
    [AccessedThroughProperty("NordText")]
    private TextBox _NordText;
    [AccessedThroughProperty("RepLabel")]
    private Label _RepLabel;
    [AccessedThroughProperty("PictureBox11")]
    private PictureBox _PictureBox11;
    [AccessedThroughProperty("CheckSouth")]
    private System.Windows.Forms.CheckBox _CheckSouth;
    [AccessedThroughProperty("Button2")]
    private System.Windows.Forms.Button _Button2;
    [AccessedThroughProperty("HelpGrid")]
    private Grid _HelpGrid;
    [AccessedThroughProperty("CheckWest")]
    private System.Windows.Forms.CheckBox _CheckWest;
    [AccessedThroughProperty("CheckEast")]
    private System.Windows.Forms.CheckBox _CheckEast;
    [AccessedThroughProperty("Button1")]
    private System.Windows.Forms.Button _Button1;
    [AccessedThroughProperty("CheckNorth")]
    private System.Windows.Forms.CheckBox _CheckNorth;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("GroupBox7")]
    private GroupBox _GroupBox7;
    [AccessedThroughProperty("GroupBox2")]
    private GroupBox _GroupBox2;
    [AccessedThroughProperty("Label2")]
    private Label _Label2;
    [AccessedThroughProperty("GroupBox3")]
    private GroupBox _GroupBox3;
    [AccessedThroughProperty("WestText")]
    private TextBox _WestText;
    [AccessedThroughProperty("GroupBox6")]
    private GroupBox _GroupBox6;
    [AccessedThroughProperty("GroupBox4")]
    private GroupBox _GroupBox4;
    [AccessedThroughProperty("Label4")]
    private Label _Label4;
    [AccessedThroughProperty("ButtonDelete")]
    private System.Windows.Forms.Button _ButtonDelete;
    [AccessedThroughProperty("GroupBox5")]
    private GroupBox _GroupBox5;
    [AccessedThroughProperty("Rep14Text")]
    private TextBox _Rep14Text;
    [AccessedThroughProperty("Rep16Text")]
    private TextBox _Rep16Text;
    [AccessedThroughProperty("Graphicgrid1")]
    private graphicgrid _Graphicgrid1;
    [AccessedThroughProperty("SuedText")]
    private TextBox _SuedText;
    [AccessedThroughProperty("OstText")]
    private TextBox _OstText;
    [AccessedThroughProperty("ErrorProvider1")]
    private ErrorProvider _ErrorProvider1;
    public LotTile AktuellesTile;
    private Lot myLot;
    private int myIndex;
    private LotTile.BitmapAusgabe[] AusgabeBilder;
    private bool ShowTransitString;
    private bool isLoading;
    private IContainer components;

    public FormEditTransit(Lot AktuellesLot, LotTile myTile, int Index)
    {
      this.Load += new EventHandler(this.FormEditTransit_Load);
      this.Closed += new EventHandler(this.FormEditTransit_Closed);
      this.ShowTransitString = true;
      this.isLoading = true;
      this.InitializeComponent();
      this.AusgabeBilder = new LotTile.BitmapAusgabe[0];
      this.AktuellesTile = myTile;
      this.myLot = AktuellesLot;
      this.myIndex = Index;
      this.AusgabeBilder = AktuellesLot.GetTileBitmaps(Index);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
      ClassThisProg.frmEditTransit = (FormEditTransit) null;
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

    internal virtual System.Windows.Forms.CheckBox CheckMirror
    {
      get => this._CheckMirror;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._CheckMirror != null)
          this._CheckMirror.CheckedChanged -= new EventHandler(this.CheckMirror_CheckedChanged);
        this._CheckMirror = value;
        if (this._CheckMirror == null)
          return;
        this._CheckMirror.CheckedChanged += new EventHandler(this.CheckMirror_CheckedChanged);
      }
    }

    internal virtual Label RepLabel
    {
      get => this._RepLabel;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._RepLabel == null)
          ;
        this._RepLabel = value;
        if (this._RepLabel == null)
          ;
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
        if (this._CheckSouth != null)
          this._CheckSouth.CheckedChanged -= new EventHandler(this.CheckSouth_CheckedChanged);
        this._CheckSouth = value;
        if (this._CheckSouth == null)
          return;
        this._CheckSouth.CheckedChanged += new EventHandler(this.CheckSouth_CheckedChanged);
      }
    }

    internal virtual System.Windows.Forms.CheckBox CheckWest
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._CheckWest != null)
          this._CheckWest.CheckedChanged -= new EventHandler(this.CheckWest_CheckedChanged);
        this._CheckWest = value;
        if (this._CheckWest == null)
          return;
        this._CheckWest.CheckedChanged += new EventHandler(this.CheckWest_CheckedChanged);
      }
      get => this._CheckWest;
    }

    internal virtual System.Windows.Forms.CheckBox CheckEast
    {
      get => this._CheckEast;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._CheckEast != null)
          this._CheckEast.CheckedChanged -= new EventHandler(this.CheckEast_CheckedChanged);
        this._CheckEast = value;
        if (this._CheckEast == null)
          return;
        this._CheckEast.CheckedChanged += new EventHandler(this.CheckEast_CheckedChanged);
      }
    }

    internal virtual System.Windows.Forms.CheckBox CheckNorth
    {
      get => this._CheckNorth;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._CheckNorth != null)
          this._CheckNorth.CheckedChanged -= new EventHandler(this.CheckNorth_CheckedChanged);
        this._CheckNorth = value;
        if (this._CheckNorth == null)
          return;
        this._CheckNorth.CheckedChanged += new EventHandler(this.CheckNorth_CheckedChanged);
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

    internal virtual System.Windows.Forms.Button ButtonDelete
    {
      get => this._ButtonDelete;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ButtonDelete != null)
          this._ButtonDelete.Click -= new EventHandler(this.ButtonDelete_Click);
        this._ButtonDelete = value;
        if (this._ButtonDelete == null)
          return;
        this._ButtonDelete.Click += new EventHandler(this.ButtonDelete_Click);
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

    internal virtual System.Windows.Forms.Button Button1
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

    internal virtual System.Windows.Forms.Button Button2
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Button2 != null)
          this._Button2.Click -= new EventHandler(this.Button2_Click);
        this._Button2 = value;
        if (this._Button2 == null)
          return;
        this._Button2.Click += new EventHandler(this.Button2_Click);
      }
      get => this._Button2;
    }

    internal virtual TextBox Rep14Text
    {
      get => this._Rep14Text;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Rep14Text != null)
          this._Rep14Text.Validating -= new CancelEventHandler(this.Rep14Text_Validating);
        this._Rep14Text = value;
        if (this._Rep14Text == null)
          return;
        this._Rep14Text.Validating += new CancelEventHandler(this.Rep14Text_Validating);
      }
    }

    internal virtual TextBox Rep16Text
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Rep16Text != null)
          this._Rep16Text.Validating -= new CancelEventHandler(this.Rep16Text_Validating);
        this._Rep16Text = value;
        if (this._Rep16Text == null)
          return;
        this._Rep16Text.Validating += new CancelEventHandler(this.Rep16Text_Validating);
      }
      get => this._Rep16Text;
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

    internal virtual Label Label2
    {
      get => this._Label2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Label2 == null)
          ;
        this._Label2 = value;
        if (this._Label2 == null)
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

    internal virtual graphicgrid Graphicgrid1
    {
      get => this._Graphicgrid1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Graphicgrid1 == null)
          ;
        this._Graphicgrid1 = value;
        if (this._Graphicgrid1 == null)
          ;
      }
    }

    internal virtual TextBox OstText
    {
      get => this._OstText;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._OstText != null)
        {
          this._OstText.Validated -= new EventHandler(this.OstText_Validated);
          this._OstText.Validating -= new CancelEventHandler(this.OstText_Validating);
        }
        this._OstText = value;
        if (this._OstText == null)
          return;
        this._OstText.Validated += new EventHandler(this.OstText_Validated);
        this._OstText.Validating += new CancelEventHandler(this.OstText_Validating);
      }
    }

    internal virtual TextBox SuedText
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._SuedText != null)
        {
          this._SuedText.Validated -= new EventHandler(this.SuedText_Validated);
          this._SuedText.Validating -= new CancelEventHandler(this.SuedText_Validating);
        }
        this._SuedText = value;
        if (this._SuedText == null)
          return;
        this._SuedText.Validated += new EventHandler(this.SuedText_Validated);
        this._SuedText.Validating += new CancelEventHandler(this.SuedText_Validating);
      }
      get => this._SuedText;
    }

    internal virtual TextBox WestText
    {
      get => this._WestText;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._WestText != null)
        {
          this._WestText.Validated -= new EventHandler(this.WestText_Validated);
          this._WestText.Validating -= new CancelEventHandler(this.WestText_Validating);
        }
        this._WestText = value;
        if (this._WestText == null)
          return;
        this._WestText.Validated += new EventHandler(this.WestText_Validated);
        this._WestText.Validating += new CancelEventHandler(this.WestText_Validating);
      }
    }

    internal virtual TextBox NordText
    {
      get => this._NordText;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._NordText != null)
        {
          this._NordText.Validated -= new EventHandler(this.NordText_Validated);
          this._NordText.Validating -= new CancelEventHandler(this.NordText_Validating);
        }
        this._NordText = value;
        if (this._NordText == null)
          return;
        this._NordText.Validated += new EventHandler(this.NordText_Validated);
        this._NordText.Validating += new CancelEventHandler(this.NordText_Validating);
      }
    }

    internal virtual GroupBox GroupBox6
    {
      get => this._GroupBox6;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._GroupBox6 == null)
          ;
        this._GroupBox6 = value;
        if (this._GroupBox6 == null)
          ;
      }
    }

    internal virtual RadioButton RadioButton1
    {
      get => this._RadioButton1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._RadioButton1 != null)
          this._RadioButton1.CheckedChanged -= new EventHandler(this.RadioButton1_CheckedChanged);
        this._RadioButton1 = value;
        if (this._RadioButton1 == null)
          return;
        this._RadioButton1.CheckedChanged += new EventHandler(this.RadioButton1_CheckedChanged);
      }
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

    internal virtual GroupBox GroupBox7
    {
      get => this._GroupBox7;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._GroupBox7 == null)
          ;
        this._GroupBox7 = value;
        if (this._GroupBox7 == null)
          ;
      }
    }

    internal virtual Grid HelpGrid
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._HelpGrid == null)
          ;
        this._HelpGrid = value;
        if (this._HelpGrid == null)
          ;
      }
      get => this._HelpGrid;
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      ResourceManager resourceManager = new ResourceManager(typeof (FormEditTransit));
      this.GroupBox1 = new GroupBox();
      this.CheckMirror = new System.Windows.Forms.CheckBox();
      this.RepLabel = new Label();
      this.PictureBox11 = new PictureBox();
      this.CheckSouth = new System.Windows.Forms.CheckBox();
      this.CheckWest = new System.Windows.Forms.CheckBox();
      this.CheckEast = new System.Windows.Forms.CheckBox();
      this.CheckNorth = new System.Windows.Forms.CheckBox();
      this.GroupBox2 = new GroupBox();
      this.Rep14Text = new TextBox();
      this.GroupBox3 = new GroupBox();
      this.Label4 = new Label();
      this.Label3 = new Label();
      this.Label2 = new Label();
      this.Label1 = new Label();
      this.OstText = new TextBox();
      this.SuedText = new TextBox();
      this.WestText = new TextBox();
      this.NordText = new TextBox();
      this.GroupBox4 = new GroupBox();
      this.Rep16Text = new TextBox();
      this.ButtonDelete = new System.Windows.Forms.Button();
      this.GroupBox5 = new GroupBox();
      this.Button2 = new System.Windows.Forms.Button();
      this.Button1 = new System.Windows.Forms.Button();
      this.Graphicgrid1 = new graphicgrid();
      this.GroupBox6 = new GroupBox();
      this.RadioButton2 = new RadioButton();
      this.RadioButton1 = new RadioButton();
      this.ErrorProvider1 = new ErrorProvider();
      this.GroupBox7 = new GroupBox();
      this.HelpGrid = new Grid();
      this.GroupBox1.SuspendLayout();
      this.GroupBox2.SuspendLayout();
      this.GroupBox3.SuspendLayout();
      this.GroupBox4.SuspendLayout();
      this.GroupBox5.SuspendLayout();
      this.GroupBox6.SuspendLayout();
      this.GroupBox7.SuspendLayout();
      this.SuspendLayout();
      this.GroupBox1.Controls.Add((Control) this.CheckMirror);
      this.GroupBox1.Controls.Add((Control) this.RepLabel);
      this.GroupBox1.Controls.Add((Control) this.PictureBox11);
      this.GroupBox1.Controls.Add((Control) this.CheckSouth);
      this.GroupBox1.Controls.Add((Control) this.CheckWest);
      this.GroupBox1.Controls.Add((Control) this.CheckEast);
      this.GroupBox1.Controls.Add((Control) this.CheckNorth);
      GroupBox groupBox1_1 = this.GroupBox1;
      Point point1 = new Point(12, 12);
      Point point2 = point1;
      groupBox1_1.Location = point2;
      this.GroupBox1.Name = "GroupBox1";
      GroupBox groupBox1_2 = this.GroupBox1;
      Size size1 = new Size(356, 116);
      Size size2 = size1;
      groupBox1_2.Size = size2;
      this.GroupBox1.TabIndex = 0;
      this.GroupBox1.TabStop = false;
      this.GroupBox1.Text = "Rep 3";
      System.Windows.Forms.CheckBox checkMirror1 = this.CheckMirror;
      point1 = new Point(144, 56);
      Point point3 = point1;
      checkMirror1.Location = point3;
      this.CheckMirror.Name = "CheckMirror";
      System.Windows.Forms.CheckBox checkMirror2 = this.CheckMirror;
      size1 = new Size(96, 20);
      Size size3 = size1;
      checkMirror2.Size = size3;
      this.CheckMirror.TabIndex = 0;
      this.CheckMirror.TabStop = false;
      this.CheckMirror.Text = "CheckMirror";
      this.RepLabel.BackColor = SystemColors.ActiveCaptionText;
      this.RepLabel.BorderStyle = BorderStyle.Fixed3D;
      Label repLabel1 = this.RepLabel;
      point1 = new Point(12, 56);
      Point point4 = point1;
      repLabel1.Location = point4;
      this.RepLabel.Name = "RepLabel";
      Label repLabel2 = this.RepLabel;
      size1 = new Size(76, 20);
      Size size4 = size1;
      repLabel2.Size = size4;
      this.RepLabel.TabIndex = 60;
      this.RepLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.PictureBox11.Image = (Image) resourceManager.GetObject("PictureBox11.Image");
      PictureBox pictureBox11_1 = this.PictureBox11;
      point1 = new Point(280, 40);
      Point point5 = point1;
      pictureBox11_1.Location = point5;
      this.PictureBox11.Name = "PictureBox11";
      PictureBox pictureBox11_2 = this.PictureBox11;
      size1 = new Size(43, 43);
      Size size5 = size1;
      pictureBox11_2.Size = size5;
      this.PictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox11.TabIndex = 59;
      this.PictureBox11.TabStop = false;
      this.CheckSouth.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
      System.Windows.Forms.CheckBox checkSouth1 = this.CheckSouth;
      point1 = new Point(292, 88);
      Point point6 = point1;
      checkSouth1.Location = point6;
      this.CheckSouth.Name = "CheckSouth";
      System.Windows.Forms.CheckBox checkSouth2 = this.CheckSouth;
      size1 = new Size(16, 16);
      Size size6 = size1;
      checkSouth2.Size = size6;
      this.CheckSouth.TabIndex = 58;
      this.CheckSouth.TabStop = false;
      this.CheckWest.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
      System.Windows.Forms.CheckBox checkWest1 = this.CheckWest;
      point1 = new Point(260, 56);
      Point point7 = point1;
      checkWest1.Location = point7;
      this.CheckWest.Name = "CheckWest";
      System.Windows.Forms.CheckBox checkWest2 = this.CheckWest;
      size1 = new Size(16, 16);
      Size size7 = size1;
      checkWest2.Size = size7;
      this.CheckWest.TabIndex = 57;
      this.CheckWest.TabStop = false;
      this.CheckEast.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
      System.Windows.Forms.CheckBox checkEast1 = this.CheckEast;
      point1 = new Point(328, 56);
      Point point8 = point1;
      checkEast1.Location = point8;
      this.CheckEast.Name = "CheckEast";
      System.Windows.Forms.CheckBox checkEast2 = this.CheckEast;
      size1 = new Size(16, 16);
      Size size8 = size1;
      checkEast2.Size = size8;
      this.CheckEast.TabIndex = 56;
      this.CheckEast.TabStop = false;
      this.CheckNorth.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
      System.Windows.Forms.CheckBox checkNorth1 = this.CheckNorth;
      point1 = new Point(292, 20);
      Point point9 = point1;
      checkNorth1.Location = point9;
      this.CheckNorth.Name = "CheckNorth";
      System.Windows.Forms.CheckBox checkNorth2 = this.CheckNorth;
      size1 = new Size(16, 16);
      Size size9 = size1;
      checkNorth2.Size = size9;
      this.CheckNorth.TabIndex = 1;
      this.CheckNorth.TabStop = false;
      this.GroupBox2.Controls.Add((Control) this.Rep14Text);
      GroupBox groupBox2_1 = this.GroupBox2;
      point1 = new Point(12, 136);
      Point point10 = point1;
      groupBox2_1.Location = point10;
      this.GroupBox2.Name = "GroupBox2";
      GroupBox groupBox2_2 = this.GroupBox2;
      size1 = new Size(356, 52);
      Size size10 = size1;
      groupBox2_2.Size = size10;
      this.GroupBox2.TabIndex = 1;
      this.GroupBox2.TabStop = false;
      this.GroupBox2.Text = "Rep 14";
      TextBox rep14Text1 = this.Rep14Text;
      point1 = new Point(12, 20);
      Point point11 = point1;
      rep14Text1.Location = point11;
      this.Rep14Text.MaxLength = 10;
      this.Rep14Text.Name = "Rep14Text";
      TextBox rep14Text2 = this.Rep14Text;
      size1 = new Size(80, 21);
      Size size11 = size1;
      rep14Text2.Size = size11;
      this.Rep14Text.TabIndex = 1;
      this.Rep14Text.Text = "";
      this.Rep14Text.TextAlign = HorizontalAlignment.Center;
      this.GroupBox3.Controls.Add((Control) this.Label4);
      this.GroupBox3.Controls.Add((Control) this.Label3);
      this.GroupBox3.Controls.Add((Control) this.Label2);
      this.GroupBox3.Controls.Add((Control) this.Label1);
      this.GroupBox3.Controls.Add((Control) this.OstText);
      this.GroupBox3.Controls.Add((Control) this.SuedText);
      this.GroupBox3.Controls.Add((Control) this.WestText);
      this.GroupBox3.Controls.Add((Control) this.NordText);
      GroupBox groupBox3_1 = this.GroupBox3;
      point1 = new Point(12, 196);
      Point point12 = point1;
      groupBox3_1.Location = point12;
      this.GroupBox3.Name = "GroupBox3";
      GroupBox groupBox3_2 = this.GroupBox3;
      size1 = new Size(356, 76);
      Size size12 = size1;
      groupBox3_2.Size = size12;
      this.GroupBox3.TabIndex = 2;
      this.GroupBox3.TabStop = false;
      this.GroupBox3.Text = "Rep 15";
      Label label4_1 = this.Label4;
      point1 = new Point(196, 24);
      Point point13 = point1;
      label4_1.Location = point13;
      this.Label4.Name = "Label4";
      Label label4_2 = this.Label4;
      size1 = new Size(40, 16);
      Size size13 = size1;
      label4_2.Size = size13;
      this.Label4.TabIndex = 9;
      this.Label4.Text = "East";
      Label label3_1 = this.Label3;
      point1 = new Point(136, 24);
      Point point14 = point1;
      label3_1.Location = point14;
      this.Label3.Name = "Label3";
      Label label3_2 = this.Label3;
      size1 = new Size(40, 16);
      Size size14 = size1;
      label3_2.Size = size14;
      this.Label3.TabIndex = 8;
      this.Label3.Text = "South";
      Label label2_1 = this.Label2;
      point1 = new Point(76, 24);
      Point point15 = point1;
      label2_1.Location = point15;
      this.Label2.Name = "Label2";
      Label label2_2 = this.Label2;
      size1 = new Size(40, 16);
      Size size15 = size1;
      label2_2.Size = size15;
      this.Label2.TabIndex = 7;
      this.Label2.Text = "West";
      Label label1_1 = this.Label1;
      point1 = new Point(16, 24);
      Point point16 = point1;
      label1_1.Location = point16;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      size1 = new Size(40, 16);
      Size size16 = size1;
      label1_2.Size = size16;
      this.Label1.TabIndex = 6;
      this.Label1.Text = "North";
      TextBox ostText1 = this.OstText;
      point1 = new Point(196, 44);
      Point point17 = point1;
      ostText1.Location = point17;
      this.OstText.MaxLength = 2;
      this.OstText.Name = "OstText";
      TextBox ostText2 = this.OstText;
      size1 = new Size(32, 21);
      Size size17 = size1;
      ostText2.Size = size17;
      this.OstText.TabIndex = 5;
      this.OstText.Text = "01";
      this.OstText.TextAlign = HorizontalAlignment.Center;
      TextBox suedText1 = this.SuedText;
      point1 = new Point(136, 44);
      Point point18 = point1;
      suedText1.Location = point18;
      this.SuedText.MaxLength = 2;
      this.SuedText.Name = "SuedText";
      TextBox suedText2 = this.SuedText;
      size1 = new Size(32, 21);
      Size size18 = size1;
      suedText2.Size = size18;
      this.SuedText.TabIndex = 4;
      this.SuedText.Text = "01";
      this.SuedText.TextAlign = HorizontalAlignment.Center;
      TextBox westText1 = this.WestText;
      point1 = new Point(76, 44);
      Point point19 = point1;
      westText1.Location = point19;
      this.WestText.MaxLength = 2;
      this.WestText.Name = "WestText";
      TextBox westText2 = this.WestText;
      size1 = new Size(32, 21);
      Size size19 = size1;
      westText2.Size = size19;
      this.WestText.TabIndex = 3;
      this.WestText.Text = "01";
      this.WestText.TextAlign = HorizontalAlignment.Center;
      TextBox nordText1 = this.NordText;
      point1 = new Point(16, 44);
      Point point20 = point1;
      nordText1.Location = point20;
      this.NordText.MaxLength = 2;
      this.NordText.Name = "NordText";
      TextBox nordText2 = this.NordText;
      size1 = new Size(32, 21);
      Size size20 = size1;
      nordText2.Size = size20;
      this.NordText.TabIndex = 2;
      this.NordText.Text = "01";
      this.NordText.TextAlign = HorizontalAlignment.Center;
      this.GroupBox4.Controls.Add((Control) this.Rep16Text);
      this.GroupBox4.Controls.Add((Control) this.ButtonDelete);
      GroupBox groupBox4_1 = this.GroupBox4;
      point1 = new Point(12, 284);
      Point point21 = point1;
      groupBox4_1.Location = point21;
      this.GroupBox4.Name = "GroupBox4";
      GroupBox groupBox4_2 = this.GroupBox4;
      size1 = new Size(356, 60);
      Size size21 = size1;
      groupBox4_2.Size = size21;
      this.GroupBox4.TabIndex = 3;
      this.GroupBox4.TabStop = false;
      this.GroupBox4.Text = "Rep 16";
      TextBox rep16Text1 = this.Rep16Text;
      point1 = new Point(12, 24);
      Point point22 = point1;
      rep16Text1.Location = point22;
      this.Rep16Text.MaxLength = 10;
      this.Rep16Text.Name = "Rep16Text";
      TextBox rep16Text2 = this.Rep16Text;
      size1 = new Size(80, 21);
      Size size22 = size1;
      rep16Text2.Size = size22;
      this.Rep16Text.TabIndex = 6;
      this.Rep16Text.Text = "";
      this.Rep16Text.TextAlign = HorizontalAlignment.Center;
      this.ButtonDelete.Enabled = false;
      this.ButtonDelete.Image = (Image) resourceManager.GetObject("ButtonDelete.Image");
      System.Windows.Forms.Button buttonDelete1 = this.ButtonDelete;
      point1 = new Point(312, 20);
      Point point23 = point1;
      buttonDelete1.Location = point23;
      this.ButtonDelete.Name = "ButtonDelete";
      System.Windows.Forms.Button buttonDelete2 = this.ButtonDelete;
      size1 = new Size(32, 32);
      Size size23 = size1;
      buttonDelete2.Size = size23;
      this.ButtonDelete.TabIndex = 7;
      this.ButtonDelete.TabStop = false;
      this.GroupBox5.Controls.Add((Control) this.Button2);
      this.GroupBox5.Controls.Add((Control) this.Button1);
      GroupBox groupBox5_1 = this.GroupBox5;
      point1 = new Point(376, 12);
      Point point24 = point1;
      groupBox5_1.Location = point24;
      this.GroupBox5.Name = "GroupBox5";
      GroupBox groupBox5_2 = this.GroupBox5;
      size1 = new Size(132, 116);
      Size size24 = size1;
      groupBox5_2.Size = size24;
      this.GroupBox5.TabIndex = 4;
      this.GroupBox5.TabStop = false;
      this.Button2.DialogResult = DialogResult.Cancel;
      System.Windows.Forms.Button button2_1 = this.Button2;
      point1 = new Point(12, 64);
      Point point25 = point1;
      button2_1.Location = point25;
      this.Button2.Name = "Button2";
      System.Windows.Forms.Button button2_2 = this.Button2;
      size1 = new Size(112, 32);
      Size size25 = size1;
      button2_2.Size = size25;
      this.Button2.TabIndex = 8;
      this.Button2.Text = "Button2";
      System.Windows.Forms.Button button1_1 = this.Button1;
      point1 = new Point(12, 20);
      Point point26 = point1;
      button1_1.Location = point26;
      this.Button1.Name = "Button1";
      System.Windows.Forms.Button button1_2 = this.Button1;
      size1 = new Size(112, 32);
      Size size26 = size1;
      button1_2.Size = size26;
      this.Button1.TabIndex = 0;
      this.Button1.Text = "OK";
      this.Graphicgrid1.AllowDrop = true;
      this.Graphicgrid1.BackColor = Color.FromArgb(154, 179, 230);
      graphicgrid graphicgrid1_1 = this.Graphicgrid1;
      size1 = new Size(1, 1);
      Size size27 = size1;
      graphicgrid1_1.Cells = size27;
      this.Graphicgrid1.CellSize = 96;
      this.Graphicgrid1.GridColor = Color.White;
      this.Graphicgrid1.GridHighLiteColor = Color.Red;
      graphicgrid graphicgrid1_2 = this.Graphicgrid1;
      point1 = new Point(392, 144);
      Point point27 = point1;
      graphicgrid1_2.Location = point27;
      this.Graphicgrid1.Name = "Graphicgrid1";
      this.Graphicgrid1.ShowTransitString = false;
      graphicgrid graphicgrid1_3 = this.Graphicgrid1;
      size1 = new Size(96, 96);
      Size size28 = size1;
      graphicgrid1_3.Size = size28;
      this.Graphicgrid1.TabIndex = 5;
      this.GroupBox6.Controls.Add((Control) this.RadioButton2);
      this.GroupBox6.Controls.Add((Control) this.RadioButton1);
      GroupBox groupBox6_1 = this.GroupBox6;
      point1 = new Point(384, 256);
      Point point28 = point1;
      groupBox6_1.Location = point28;
      this.GroupBox6.Name = "GroupBox6";
      GroupBox groupBox6_2 = this.GroupBox6;
      size1 = new Size(116, 88);
      Size size29 = size1;
      groupBox6_2.Size = size29;
      this.GroupBox6.TabIndex = 6;
      this.GroupBox6.TabStop = false;
      RadioButton radioButton2_1 = this.RadioButton2;
      point1 = new Point(12, 56);
      Point point29 = point1;
      radioButton2_1.Location = point29;
      this.RadioButton2.Name = "RadioButton2";
      RadioButton radioButton2_2 = this.RadioButton2;
      size1 = new Size(96, 16);
      Size size30 = size1;
      radioButton2_2.Size = size30;
      this.RadioButton2.TabIndex = 1;
      this.RadioButton2.Text = "RadioButton2";
      this.RadioButton1.Checked = true;
      RadioButton radioButton1_1 = this.RadioButton1;
      point1 = new Point(12, 28);
      Point point30 = point1;
      radioButton1_1.Location = point30;
      this.RadioButton1.Name = "RadioButton1";
      RadioButton radioButton1_2 = this.RadioButton1;
      size1 = new Size(96, 16);
      Size size31 = size1;
      radioButton1_2.Size = size31;
      this.RadioButton1.TabIndex = 0;
      this.RadioButton1.TabStop = true;
      this.RadioButton1.Text = "RadioButton1";
      this.ErrorProvider1.ContainerControl = (ContainerControl) this;
      this.GroupBox7.Controls.Add((Control) this.HelpGrid);
      GroupBox groupBox7_1 = this.GroupBox7;
      point1 = new Point(12, 352);
      Point point31 = point1;
      groupBox7_1.Location = point31;
      this.GroupBox7.Name = "GroupBox7";
      GroupBox groupBox7_2 = this.GroupBox7;
      size1 = new Size(488, 192);
      Size size32 = size1;
      groupBox7_2.Size = size32;
      this.GroupBox7.TabIndex = 8;
      this.GroupBox7.TabStop = false;
      this.GroupBox7.Text = "GroupBox7";
      this.HelpGrid.AutoSizeMinHeight = 10;
      this.HelpGrid.AutoSizeMinWidth = 10;
      this.HelpGrid.AutoStretchColumnsToFitWidth = true;
      this.HelpGrid.AutoStretchRowsToFitHeight = false;
      this.HelpGrid.ContextMenuStyle = ContextMenuStyle.None;
      this.HelpGrid.CustomSort = false;
      this.HelpGrid.GridToolTipActive = true;
      Grid helpGrid1 = this.HelpGrid;
      point1 = new Point(12, 20);
      Point point32 = point1;
      helpGrid1.Location = point32;
      this.HelpGrid.Name = "HelpGrid";
      Grid helpGrid2 = this.HelpGrid;
      size1 = new Size(464, 160);
      Size size33 = size1;
      helpGrid2.Size = size33;
      this.HelpGrid.SpecialKeys = GridSpecialKeys.Default;
      this.HelpGrid.TabIndex = 8;
      this.AcceptButton = (IButtonControl) this.Button1;
      size1 = new Size(6, 14);
      this.AutoScaleBaseSize = size1;
      this.CancelButton = (IButtonControl) this.Button2;
      size1 = new Size(514, 547);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.GroupBox7);
      this.Controls.Add((Control) this.GroupBox6);
      this.Controls.Add((Control) this.Graphicgrid1);
      this.Controls.Add((Control) this.GroupBox5);
      this.Controls.Add((Control) this.GroupBox4);
      this.Controls.Add((Control) this.GroupBox3);
      this.Controls.Add((Control) this.GroupBox2);
      this.Controls.Add((Control) this.GroupBox1);
      this.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (FormEditTransit);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = nameof (FormEditTransit);
      this.GroupBox1.ResumeLayout(false);
      this.GroupBox2.ResumeLayout(false);
      this.GroupBox3.ResumeLayout(false);
      this.GroupBox4.ResumeLayout(false);
      this.GroupBox5.ResumeLayout(false);
      this.GroupBox6.ResumeLayout(false);
      this.GroupBox7.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    private object UpdateTile()
    {
      if (!this.isLoading)
      {
        this.AusgabeBilder = new LotTile.BitmapAusgabe[0];
        ArrayList newArray = new ArrayList();
        if (this.NordText.Text.Length == 1)
          this.NordText.Text = "0" + this.NordText.Text;
        if (this.WestText.Text.Length == 1)
          this.WestText.Text = "0" + this.WestText.Text;
        if (this.SuedText.Text.Length == 1)
          this.SuedText.Text = "0" + this.SuedText.Text;
        if (this.OstText.Text.Length == 1)
          this.OstText.Text = "0" + this.OstText.Text;
        this.AktuellesTile.SetRotateMirrorString(this.RepLabel.Text);
        newArray.Add((object) this.NordText.Text);
        newArray.Add((object) this.WestText.Text);
        newArray.Add((object) this.SuedText.Text);
        newArray.Add((object) this.OstText.Text);
        this.AktuellesTile.SetDirectionArray(newArray);
        this.AusgabeBilder = this.myLot.GetTileBitmaps(this.myIndex);
        this.ZeichneTile();
      }
      object obj;
      return obj;
    }

    private object ZeichneTile()
    {
      if (!this.isLoading)
      {
        Point Cell;
        Cell.X = 0;
        Cell.Y = 0;
        this.Graphicgrid1.removeCell(Cell);
        this.Graphicgrid1.ShowTransitString = this.ShowTransitString;
        if (this.AusgabeBilder.GetUpperBound(0) > -1)
        {
          int upperBound = this.AusgabeBilder.GetUpperBound(0);
          int index = 0;
          while (index <= upperBound)
          {
            if (this.ShowTransitString)
            {
              if (StringType.StrCmp(this.AusgabeBilder[index].Typ, "TrafficDirection", false) != 0)
                this.Graphicgrid1.setCell(Cell, this.AusgabeBilder[index].AusgabeBild, this.AusgabeBilder[index].Direction, this.AusgabeBilder[index].isTransparent, this.AusgabeBilder[index].isMirror);
            }
            else
              this.Graphicgrid1.setCell(Cell, this.AusgabeBilder[index].AusgabeBild, this.AusgabeBilder[index].Direction, this.AusgabeBilder[index].isTransparent, this.AusgabeBilder[index].isMirror);
            checked { ++index; }
          }
          if (this.ShowTransitString && StringType.StrCmp(this.AktuellesTile.TransitArt, "", false) != 0)
          {
            AllgemeineKlasse.DirectionText DirText;
            DirText.TextTop = Conversion.Hex(RuntimeHelpers.GetObjectValue(this.AktuellesTile.DirectionArray[0])).ToString();
            DirText.TextLeft = Conversion.Hex(RuntimeHelpers.GetObjectValue(this.AktuellesTile.DirectionArray[1])).ToString();
            DirText.TextButtom = Conversion.Hex(RuntimeHelpers.GetObjectValue(this.AktuellesTile.DirectionArray[2])).ToString();
            DirText.TextRight = Conversion.Hex(RuntimeHelpers.GetObjectValue(this.AktuellesTile.DirectionArray[3])).ToString();
            this.Graphicgrid1.setCell(Cell, DirText);
          }
        }
      }
      object obj;
      return obj;
    }

    public object SetzeTexte()
    {
      this.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[432]);
      this.Button2.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[390]);
      this.CheckMirror.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[433]);
      this.RadioButton1.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[447]);
      this.RadioButton2.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[446]);
      this.GroupBox7.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[452]);
      this.Label1.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[448]);
      this.Label2.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[449]);
      this.Label3.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[450]);
      this.Label4.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[451]);
      this.HelpGrid[0, 1].Value = RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[100]);
      this.HelpGrid[1, 1].Value = RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[404]);
      this.HelpGrid[2, 1].Value = RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[405]);
      this.HelpGrid[3, 1].Value = RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[406]);
      this.HelpGrid[4, 1].Value = RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[407]);
      this.HelpGrid[5, 1].Value = RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[408]);
      this.HelpGrid[6, 1].Value = RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[409]);
      ICell cell1 = this.HelpGrid[0, 1];
      cell1.ToolTipText = StringType.FromObject(cell1.Value);
      ICell cell2 = this.HelpGrid[1, 1];
      cell2.ToolTipText = StringType.FromObject(cell2.Value);
      ICell cell3 = this.HelpGrid[2, 1];
      cell3.ToolTipText = StringType.FromObject(cell3.Value);
      ICell cell4 = this.HelpGrid[3, 1];
      cell4.ToolTipText = StringType.FromObject(cell4.Value);
      ICell cell5 = this.HelpGrid[4, 1];
      cell5.ToolTipText = StringType.FromObject(cell5.Value);
      ICell cell6 = this.HelpGrid[5, 1];
      cell6.ToolTipText = StringType.FromObject(cell6.Value);
      ICell cell7 = this.HelpGrid[6, 1];
      cell7.ToolTipText = StringType.FromObject(cell7.Value);
      this.HelpGrid.AutoStretchColumnsToFitWidth = true;
      this.HelpGrid.StretchColumnsToFitWidth();
      object obj;
      return obj;
    }

    private void FormEditTransit_Load(object sender, EventArgs e)
    {
      Common common = new Common(false);
      sr_Userinterface.AendereFarben((Form) this, ClassThisProg.DefReader.FarbSchema);
      this.isLoading = true;
      this.NordText.Text = StringType.FromObject(this.AktuellesTile.DirectionArray[0]);
      this.WestText.Text = StringType.FromObject(this.AktuellesTile.DirectionArray[1]);
      this.SuedText.Text = StringType.FromObject(this.AktuellesTile.DirectionArray[2]);
      this.OstText.Text = StringType.FromObject(this.AktuellesTile.DirectionArray[3]);
      this.RepLabel.Text = this.AktuellesTile.GetRotateMirrorString();
      this.Rep14Text.Text = this.AktuellesTile.GetRep14();
      this.Rep16Text.Text = this.AktuellesTile.GetRep16();
      if (this.AktuellesTile.HasRep16)
        this.ButtonDelete.Enabled = true;
      if (this.NordText.Text.Length == 1)
        this.NordText.Text = "0" + this.NordText.Text;
      if (this.WestText.Text.Length == 1)
        this.WestText.Text = "0" + this.WestText.Text;
      if (this.SuedText.Text.Length == 1)
        this.SuedText.Text = "0" + this.SuedText.Text;
      if (this.OstText.Text.Length == 1)
        this.OstText.Text = "0" + this.OstText.Text;
      if (this.RepLabel.Text.Length == 10)
      {
        if (DoubleType.FromString(this.RepLabel.Text.Substring(2, 1)) == 8.0)
          this.CheckMirror.Checked = true;
        string sLeft = this.RepLabel.Text.Substring(9, 1);
        if (StringType.StrCmp(sLeft, "2", false) == 0)
          this.CheckSouth.Checked = true;
        else if (StringType.StrCmp(sLeft, "3", false) == 0)
          this.CheckWest.Checked = true;
        else if (StringType.StrCmp(sLeft, "0", false) == 0)
          this.CheckNorth.Checked = true;
        else if (StringType.StrCmp(sLeft, "1", false) == 0)
          this.CheckEast.Checked = true;
      }
      this.isLoading = false;
      common.BackColor = Color.SteelBlue;
      common.ForeColor = Color.White;
      common.Font = this.Font;
      common.TextAlignment = SourceLibrary.Drawing.ContentAlignment.MiddleLeft;
      this.HelpGrid.RowsCount = 8;
      this.HelpGrid.ColumnsCount = 2;
      this.HelpGrid.Selection.SelectionMode = GridSelectionMode.Row;
      this.HelpGrid.GridToolTipActive = true;
      this.HelpGrid.Columns[0].Width = 30;
      this.HelpGrid.Columns[1].Width = checked (this.HelpGrid.Width - this.HelpGrid.Columns[0].Width - 20);
      this.HelpGrid[0, 0] = (ICell) new Cell((object) "Flag", (IDataModel) null, (IVisualModel) common);
      this.HelpGrid[0, 1] = (ICell) new Cell((object) "", (IDataModel) null, (IVisualModel) common);
      this.HelpGrid[1, 0] = (ICell) new Cell((object) "00");
      this.HelpGrid[2, 0] = (ICell) new Cell((object) "01");
      this.HelpGrid[3, 0] = (ICell) new Cell((object) "02");
      this.HelpGrid[4, 0] = (ICell) new Cell((object) "03");
      this.HelpGrid[5, 0] = (ICell) new Cell((object) "04");
      this.HelpGrid[6, 0] = (ICell) new Cell((object) "FF");
      this.HelpGrid[1, 1] = (ICell) new Cell();
      this.HelpGrid[2, 1] = (ICell) new Cell();
      this.HelpGrid[3, 1] = (ICell) new Cell();
      this.HelpGrid[4, 1] = (ICell) new Cell();
      this.HelpGrid[5, 1] = (ICell) new Cell();
      this.HelpGrid[6, 1] = (ICell) new Cell();
      this.SetzeTexte();
      this.ZeichneTile();
      this.ActiveControl = (Control) this.Graphicgrid1;
    }

    private void Button1_Click(object sender, EventArgs e) => this.DialogResult = DialogResult.OK;

    private void Button2_Click(object sender, EventArgs e) => this.DialogResult = DialogResult.Cancel;

    private void FormEditTransit_Closed(object sender, EventArgs e) => ClassThisProg.frmEditTransit = (FormEditTransit) null;

    private void CheckMirror_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckMirror.Checked)
        this.RepLabel.Text = this.RepLabel.Text.Replace("0x0", "0x8");
      else
        this.RepLabel.Text = this.RepLabel.Text.Replace("0x8", "0x0");
      this.UpdateTile();
    }

    private void CheckNorth_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckNorth.Checked)
      {
        this.CheckEast.Checked = false;
        this.CheckSouth.Checked = false;
        this.CheckWest.Checked = false;
        this.RepLabel.Text = this.RepLabel.Text.Remove(9, 1) + "0";
      }
      else if (!this.CheckNorth.Checked & !this.CheckEast.Checked & !this.CheckSouth.Checked & !this.CheckWest.Checked)
        this.CheckSouth.Checked = true;
      this.UpdateTile();
    }

    private void CheckEast_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckEast.Checked)
      {
        this.CheckNorth.Checked = false;
        this.CheckSouth.Checked = false;
        this.CheckWest.Checked = false;
        this.RepLabel.Text = this.RepLabel.Text.Remove(9, 1) + "1";
      }
      else if (!this.CheckNorth.Checked & !this.CheckEast.Checked & !this.CheckSouth.Checked & !this.CheckWest.Checked)
        this.CheckSouth.Checked = true;
      this.UpdateTile();
    }

    private void CheckSouth_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckSouth.Checked)
      {
        this.CheckEast.Checked = false;
        this.CheckWest.Checked = false;
        this.CheckNorth.Checked = false;
        this.RepLabel.Text = this.RepLabel.Text.Remove(9, 1) + "2";
      }
      else if (!this.CheckNorth.Checked & !this.CheckEast.Checked & !this.CheckSouth.Checked & !this.CheckWest.Checked)
        this.CheckSouth.Checked = true;
      this.UpdateTile();
    }

    private void CheckWest_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckWest.Checked)
      {
        this.CheckEast.Checked = false;
        this.CheckSouth.Checked = false;
        this.CheckNorth.Checked = false;
        this.RepLabel.Text = this.RepLabel.Text.Remove(9, 1) + "3";
      }
      else if (!this.CheckNorth.Checked & !this.CheckEast.Checked & !this.CheckSouth.Checked & !this.CheckWest.Checked)
        this.CheckSouth.Checked = true;
      this.UpdateTile();
    }

    private void ButtonDelete_Click(object sender, EventArgs e)
    {
      this.Rep16Text.Text = "";
      this.AktuellesTile.RemoveRep16();
      this.ButtonDelete.Enabled = true;
    }

    private void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {
      this.ShowTransitString = this.RadioButton1.Checked;
      this.ZeichneTile();
    }

    private void RadioButton2_CheckedChanged(object sender, EventArgs e)
    {
      this.ShowTransitString = this.RadioButton1.Checked;
      this.ZeichneTile();
    }

    private void NordText_Validating(object sender, CancelEventArgs e)
    {
      try
      {
        if (!Information.IsNothing((object) this.NordText.Text))
        {
          if (StringType.StrCmp(this.NordText.Text, "", false) != 0)
          {
            if (!Information.IsNumeric((object) this.NordText.Text))
              LongType.FromString("&h" + this.NordText.Text);
          }
          else
            this.NordText.Text = "00";
        }
        else
          this.NordText.Text = "00";
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        e.Cancel = true;
        this.ErrorProvider1.SetError((Control) this.NordText, "<>");
        ProjectData.ClearProjectError();
        return;
      }
      this.ErrorProvider1.SetError((Control) this.NordText, "");
    }

    private void NordText_Validated(object sender, EventArgs e) => this.UpdateTile();

    private void WestText_Validating(object sender, CancelEventArgs e)
    {
      try
      {
        if (!Information.IsNothing((object) this.WestText.Text))
        {
          if (StringType.StrCmp(this.WestText.Text, "", false) != 0)
          {
            if (!Information.IsNumeric((object) this.WestText.Text))
              LongType.FromString("&h" + this.WestText.Text);
          }
          else
            this.WestText.Text = "00";
        }
        else
          this.WestText.Text = "00";
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        e.Cancel = true;
        this.ErrorProvider1.SetError((Control) this.WestText, "<>");
        ProjectData.ClearProjectError();
        return;
      }
      this.ErrorProvider1.SetError((Control) this.WestText, "");
    }

    private void WestText_Validated(object sender, EventArgs e) => this.UpdateTile();

    private void SuedText_Validating(object sender, CancelEventArgs e)
    {
      try
      {
        if (!Information.IsNothing((object) this.SuedText.Text))
        {
          if (StringType.StrCmp(this.SuedText.Text, "", false) != 0)
          {
            if (!Information.IsNumeric((object) this.SuedText.Text))
              LongType.FromString("&h" + this.SuedText.Text);
          }
          else
            this.SuedText.Text = "00";
        }
        else
          this.SuedText.Text = "00";
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        e.Cancel = true;
        this.ErrorProvider1.SetError((Control) this.SuedText, "<>");
        ProjectData.ClearProjectError();
        return;
      }
      this.ErrorProvider1.SetError((Control) this.SuedText, "");
    }

    private void SuedText_Validated(object sender, EventArgs e) => this.UpdateTile();

    private void OstText_Validating(object sender, CancelEventArgs e)
    {
      try
      {
        if (!Information.IsNothing((object) this.OstText.Text))
        {
          if (StringType.StrCmp(this.OstText.Text, "", false) != 0)
          {
            if (!Information.IsNumeric((object) this.OstText.Text))
              LongType.FromString("&h" + this.OstText.Text);
          }
          else
            this.OstText.Text = "00";
        }
        else
          this.OstText.Text = "00";
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        e.Cancel = true;
        this.ErrorProvider1.SetError((Control) this.OstText, "<>");
        ProjectData.ClearProjectError();
        return;
      }
      this.ErrorProvider1.SetError((Control) this.OstText, "");
    }

    private void OstText_Validated(object sender, EventArgs e) => this.UpdateTile();

    private void Rep14Text_Validating(object sender, CancelEventArgs e)
    {
      try
      {
        if (!Information.IsNothing((object) this.Rep14Text.Text))
        {
          if (StringType.StrCmp(this.Rep14Text.Text, "", false) != 0)
          {
            if (!this.Rep14Text.Text.ToUpper().StartsWith("0X"))
            {
              this.ErrorProvider1.SetError((Control) this.Rep14Text, "not valid !");
              e.Cancel = true;
            }
            if (this.Rep14Text.Text.Length != 10)
            {
              this.ErrorProvider1.SetError((Control) this.Rep14Text, "not valid !");
              e.Cancel = true;
            }
            LongType.FromString(this.Rep14Text.Text.ToUpper().Replace("0X", "&h"));
            this.ErrorProvider1.SetError((Control) this.Rep14Text, "");
            this.AktuellesTile.ModifyRep14(this.Rep14Text.Text);
          }
          else
          {
            this.Rep14Text.Text = "0x00000000";
            this.ErrorProvider1.SetError((Control) this.Rep14Text, "");
          }
        }
        else
        {
          this.Rep14Text.Text = "0x00000000";
          this.ErrorProvider1.SetError((Control) this.Rep14Text, "");
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.ErrorProvider1.SetError((Control) this.Rep14Text, "not valid !");
        e.Cancel = true;
        ProjectData.ClearProjectError();
      }
    }

    private void Rep16Text_Validating(object sender, CancelEventArgs e)
    {
      try
      {
        if (Information.IsNothing((object) this.Rep16Text.Text))
          return;
        if (StringType.StrCmp(this.Rep16Text.Text, "", false) != 0)
        {
          if (!this.Rep16Text.Text.ToUpper().StartsWith("0X"))
          {
            this.ErrorProvider1.SetError((Control) this.Rep16Text, "not valid !");
            e.Cancel = true;
          }
          if (this.Rep16Text.Text.Length != 10)
          {
            this.ErrorProvider1.SetError((Control) this.Rep16Text, "not valid !");
            e.Cancel = true;
          }
          LongType.FromString(this.Rep16Text.Text.ToUpper().Replace("0X", "&h"));
          this.ErrorProvider1.SetError((Control) this.Rep16Text, "");
          if (this.AktuellesTile.HasRep16)
          {
            this.AktuellesTile.ModifyRep16(this.Rep16Text.Text);
          }
          else
          {
            this.AktuellesTile.AddRep16(this.Rep16Text.Text);
            this.ButtonDelete.Enabled = true;
          }
        }
        else
        {
          this.ErrorProvider1.SetError((Control) this.Rep16Text, "");
          if (this.AktuellesTile.HasRep16)
          {
            this.AktuellesTile.RemoveRep16();
            this.ButtonDelete.Enabled = true;
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.ErrorProvider1.SetError((Control) this.Rep16Text, "not valid !");
        e.Cancel = true;
        ProjectData.ClearProjectError();
      }
    }
  }
}
