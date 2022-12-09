// Decompiled with JetBrains decompiler
// Type: SC4Tool.FormTransitDirection
// Assembly: SC4Tool, Version=2.2.7.0, Culture=neutral, PublicKeyToken=null
// MVID: 69A50BC4-87A5-4C5E-BEFC-08274BC6D498
// Assembly location: C:\Program Files (x86)\SC4 Utilities\SC4Tool\SC4Tool.exe

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
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SC4Tool
{
  public class FormTransitDirection : Form
  {
    [AccessedThroughProperty("Label2")]
    private Label _Label2;
    [AccessedThroughProperty("BeschreibungsGrid")]
    private Grid _BeschreibungsGrid;
    [AccessedThroughProperty("SuedListBox")]
    private CheckedListBox _SuedListBox;
    [AccessedThroughProperty("OstListBox")]
    private CheckedListBox _OstListBox;
    [AccessedThroughProperty("NordListBox")]
    private CheckedListBox _NordListBox;
    [AccessedThroughProperty("WestListBox")]
    private CheckedListBox _WestListBox;
    [AccessedThroughProperty("Button1")]
    private System.Windows.Forms.Button _Button1;
    [AccessedThroughProperty("Graphicgrid2")]
    private graphicgrid _Graphicgrid2;
    [AccessedThroughProperty("HelpGrid")]
    private Grid _HelpGrid;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("Label3")]
    private Label _Label3;
    [AccessedThroughProperty("Label4")]
    private Label _Label4;
    [AccessedThroughProperty("Panel2")]
    private Panel _Panel2;
    [AccessedThroughProperty("Button3")]
    private System.Windows.Forms.Button _Button3;
    public LotTile AktuellesTile;
    private Lot myLot;
    private int myIndex;
    private LotTile.BitmapAusgabe[] AusgabeBilder;
    private bool isLoading;
    private Common l_TitleModel;
    private Common l_CenterModel;
    private Common l_HelpModel;
    private IContainer components;

    public FormTransitDirection(Lot AktuellesLot, LotTile myTile, int Index)
    {
      this.Load += new EventHandler(this.FormTransitDirection_Load);
      this.Closed += new EventHandler(this.FormTransitDirection_Closed);
      this.isLoading = true;
      this.l_TitleModel = new Common(false);
      this.l_CenterModel = new Common(false);
      this.l_HelpModel = new Common(false);
      this.InitializeComponent();
      this.AktuellesTile = myTile;
      this.myLot = AktuellesLot;
      this.myIndex = Index;
      Point point;
      point.X = 0;
      point.Y = 0;
      this.AusgabeBilder = new LotTile.BitmapAusgabe[0];
      this.AusgabeBilder = AktuellesLot.GetTileBitmaps(Index);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
      ClassThisProg.frmTransitDirection = (FormTransitDirection) null;
    }

    internal virtual Panel Panel2
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Panel2 == null)
          ;
        this._Panel2 = value;
        if (this._Panel2 == null)
          ;
      }
      get => this._Panel2;
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

    internal virtual Grid BeschreibungsGrid
    {
      get => this._BeschreibungsGrid;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._BeschreibungsGrid == null)
          ;
        this._BeschreibungsGrid = value;
        if (this._BeschreibungsGrid == null)
          ;
      }
    }

    internal virtual CheckedListBox SuedListBox
    {
      get => this._SuedListBox;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._SuedListBox != null)
          this._SuedListBox.SelectedIndexChanged -= new EventHandler(this.SuedListBox_SelectedIndexChanged);
        this._SuedListBox = value;
        if (this._SuedListBox == null)
          return;
        this._SuedListBox.SelectedIndexChanged += new EventHandler(this.SuedListBox_SelectedIndexChanged);
      }
    }

    internal virtual CheckedListBox OstListBox
    {
      get => this._OstListBox;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._OstListBox != null)
          this._OstListBox.SelectedIndexChanged -= new EventHandler(this.OstListBox_SelectedIndexChanged);
        this._OstListBox = value;
        if (this._OstListBox == null)
          return;
        this._OstListBox.SelectedIndexChanged += new EventHandler(this.OstListBox_SelectedIndexChanged);
      }
    }

    internal virtual CheckedListBox NordListBox
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._NordListBox != null)
          this._NordListBox.SelectedIndexChanged -= new EventHandler(this.NordListBox_SelectedIndexChanged);
        this._NordListBox = value;
        if (this._NordListBox == null)
          return;
        this._NordListBox.SelectedIndexChanged += new EventHandler(this.NordListBox_SelectedIndexChanged);
      }
      get => this._NordListBox;
    }

    internal virtual CheckedListBox WestListBox
    {
      get => this._WestListBox;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._WestListBox != null)
          this._WestListBox.SelectedIndexChanged -= new EventHandler(this.WestListBox_SelectedIndexChanged);
        this._WestListBox = value;
        if (this._WestListBox == null)
          return;
        this._WestListBox.SelectedIndexChanged += new EventHandler(this.WestListBox_SelectedIndexChanged);
      }
    }

    internal virtual System.Windows.Forms.Button Button1
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

    internal virtual graphicgrid Graphicgrid2
    {
      get => this._Graphicgrid2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Graphicgrid2 == null)
          ;
        this._Graphicgrid2 = value;
        if (this._Graphicgrid2 == null)
          ;
      }
    }

    internal virtual System.Windows.Forms.Button Button3
    {
      get => this._Button3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Button3 == null)
          ;
        this._Button3 = value;
        if (this._Button3 == null)
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

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.Panel2 = new Panel();
      this.Label4 = new Label();
      this.BeschreibungsGrid = new Grid();
      this.SuedListBox = new CheckedListBox();
      this.OstListBox = new CheckedListBox();
      this.NordListBox = new CheckedListBox();
      this.WestListBox = new CheckedListBox();
      this.Button1 = new System.Windows.Forms.Button();
      this.Graphicgrid2 = new graphicgrid();
      this.Button3 = new System.Windows.Forms.Button();
      this.Label1 = new Label();
      this.Label2 = new Label();
      this.Label3 = new Label();
      this.HelpGrid = new Grid();
      this.Panel2.SuspendLayout();
      this.SuspendLayout();
      this.Panel2.AutoScroll = true;
      this.Panel2.Controls.Add((Control) this.Label4);
      this.Panel2.Controls.Add((Control) this.BeschreibungsGrid);
      this.Panel2.Controls.Add((Control) this.SuedListBox);
      this.Panel2.Controls.Add((Control) this.OstListBox);
      this.Panel2.Controls.Add((Control) this.NordListBox);
      this.Panel2.Controls.Add((Control) this.WestListBox);
      this.Panel2.Controls.Add((Control) this.Button1);
      this.Panel2.Controls.Add((Control) this.Graphicgrid2);
      this.Panel2.Controls.Add((Control) this.Button3);
      this.Panel2.Controls.Add((Control) this.Label1);
      this.Panel2.Controls.Add((Control) this.Label2);
      this.Panel2.Controls.Add((Control) this.Label3);
      this.Panel2.Dock = DockStyle.Fill;
      Panel panel2_1 = this.Panel2;
      Point point1 = new Point(0, 0);
      Point point2 = point1;
      panel2_1.Location = point2;
      this.Panel2.Name = "Panel2";
      Panel panel2_2 = this.Panel2;
      Size size1 = new Size(522, 543);
      Size size2 = size1;
      panel2_2.Size = size2;
      this.Panel2.TabIndex = 1;
      this.Label4.BorderStyle = BorderStyle.FixedSingle;
      this.Label4.Font = new Font("Arial", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      Label label4_1 = this.Label4;
      point1 = new Point(16, 172);
      Point point3 = point1;
      label4_1.Location = point3;
      this.Label4.Name = "Label4";
      Label label4_2 = this.Label4;
      size1 = new Size(28, 24);
      Size size3 = size1;
      label4_2.Size = size3;
      this.Label4.TabIndex = 23;
      this.Label4.Text = "1";
      this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.BeschreibungsGrid.AutoSizeMinHeight = 10;
      this.BeschreibungsGrid.AutoSizeMinWidth = 10;
      this.BeschreibungsGrid.AutoStretchColumnsToFitWidth = false;
      this.BeschreibungsGrid.AutoStretchRowsToFitHeight = false;
      this.BeschreibungsGrid.ContextMenuStyle = ContextMenuStyle.None;
      this.BeschreibungsGrid.CustomSort = false;
      this.BeschreibungsGrid.GridToolTipActive = true;
      Grid beschreibungsGrid1 = this.BeschreibungsGrid;
      point1 = new Point(400, 36);
      Point point4 = point1;
      beschreibungsGrid1.Location = point4;
      this.BeschreibungsGrid.Name = "BeschreibungsGrid";
      Grid beschreibungsGrid2 = this.BeschreibungsGrid;
      size1 = new Size(112, 64);
      Size size4 = size1;
      beschreibungsGrid2.Size = size4;
      this.BeschreibungsGrid.SpecialKeys = GridSpecialKeys.Default;
      this.BeschreibungsGrid.TabIndex = 18;
      this.SuedListBox.CheckOnClick = true;
      this.SuedListBox.Enabled = false;
      this.SuedListBox.Items.AddRange(new object[6]
      {
        (object) "00",
        (object) "01",
        (object) "02",
        (object) "03",
        (object) "04",
        (object) "FF"
      });
      CheckedListBox suedListBox1 = this.SuedListBox;
      point1 = new Point(140, 236);
      Point point5 = point1;
      suedListBox1.Location = point5;
      this.SuedListBox.Name = "SuedListBox";
      CheckedListBox suedListBox2 = this.SuedListBox;
      size1 = new Size(72, 94);
      Size size5 = size1;
      suedListBox2.Size = size5;
      this.SuedListBox.TabIndex = 17;
      this.OstListBox.CheckOnClick = true;
      this.OstListBox.Enabled = false;
      this.OstListBox.Items.AddRange(new object[6]
      {
        (object) "00",
        (object) "01",
        (object) "02",
        (object) "03",
        (object) "04",
        (object) "FF"
      });
      CheckedListBox ostListBox1 = this.OstListBox;
      point1 = new Point(228, 136);
      Point point6 = point1;
      ostListBox1.Location = point6;
      this.OstListBox.Name = "OstListBox";
      CheckedListBox ostListBox2 = this.OstListBox;
      size1 = new Size(72, 94);
      Size size6 = size1;
      ostListBox2.Size = size6;
      this.OstListBox.TabIndex = 16;
      this.NordListBox.CheckOnClick = true;
      this.NordListBox.Enabled = false;
      this.NordListBox.Items.AddRange(new object[6]
      {
        (object) "00",
        (object) "01",
        (object) "02",
        (object) "03",
        (object) "04",
        (object) "FF"
      });
      CheckedListBox nordListBox1 = this.NordListBox;
      point1 = new Point(140, 36);
      Point point7 = point1;
      nordListBox1.Location = point7;
      this.NordListBox.Name = "NordListBox";
      CheckedListBox nordListBox2 = this.NordListBox;
      size1 = new Size(72, 94);
      Size size7 = size1;
      nordListBox2.Size = size7;
      this.NordListBox.TabIndex = 15;
      this.WestListBox.CheckOnClick = true;
      this.WestListBox.Enabled = false;
      this.WestListBox.Items.AddRange(new object[6]
      {
        (object) "00",
        (object) "01",
        (object) "02",
        (object) "03",
        (object) "04",
        (object) "FF"
      });
      CheckedListBox westListBox1 = this.WestListBox;
      point1 = new Point(52, 136);
      Point point8 = point1;
      westListBox1.Location = point8;
      this.WestListBox.Name = "WestListBox";
      CheckedListBox westListBox2 = this.WestListBox;
      size1 = new Size(72, 94);
      Size size8 = size1;
      westListBox2.Size = size8;
      this.WestListBox.TabIndex = 14;
      this.Button1.Enabled = false;
      System.Windows.Forms.Button button1_1 = this.Button1;
      point1 = new Point(400, 112);
      Point point9 = point1;
      button1_1.Location = point9;
      this.Button1.Name = "Button1";
      System.Windows.Forms.Button button1_2 = this.Button1;
      size1 = new Size(112, 32);
      Size size9 = size1;
      button1_2.Size = size9;
      this.Button1.TabIndex = 13;
      this.Button1.Text = "OK";
      this.Graphicgrid2.AllowDrop = true;
      this.Graphicgrid2.BackColor = Color.FromArgb(154, 179, 230);
      graphicgrid graphicgrid2_1 = this.Graphicgrid2;
      size1 = new Size(1, 1);
      Size size10 = size1;
      graphicgrid2_1.Cells = size10;
      this.Graphicgrid2.CellSize = 96;
      this.Graphicgrid2.GridColor = Color.White;
      this.Graphicgrid2.GridHighLiteColor = Color.Red;
      graphicgrid graphicgrid2_2 = this.Graphicgrid2;
      point1 = new Point(128, 136);
      Point point10 = point1;
      graphicgrid2_2.Location = point10;
      this.Graphicgrid2.Name = "Graphicgrid2";
      this.Graphicgrid2.ShowTransitString = false;
      graphicgrid graphicgrid2_3 = this.Graphicgrid2;
      size1 = new Size(96, 96);
      Size size11 = size1;
      graphicgrid2_3.Size = size11;
      this.Graphicgrid2.TabIndex = 12;
      this.Button3.DialogResult = DialogResult.Cancel;
      System.Windows.Forms.Button button3_1 = this.Button3;
      point1 = new Point(400, 156);
      Point point11 = point1;
      button3_1.Location = point11;
      this.Button3.Name = "Button3";
      System.Windows.Forms.Button button3_2 = this.Button3;
      size1 = new Size(112, 32);
      Size size12 = size1;
      button3_2.Size = size12;
      this.Button3.TabIndex = 14;
      this.Button3.Text = "Cancel";
      this.Label1.BorderStyle = BorderStyle.FixedSingle;
      this.Label1.Font = new Font("Arial", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      Label label1_1 = this.Label1;
      point1 = new Point(160, 8);
      Point point12 = point1;
      label1_1.Location = point12;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      size1 = new Size(28, 24);
      Size size13 = size1;
      label1_2.Size = size13;
      this.Label1.TabIndex = 24;
      this.Label1.Text = "0";
      this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.Label2.BorderStyle = BorderStyle.FixedSingle;
      this.Label2.Font = new Font("Arial", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      Label label2_1 = this.Label2;
      point1 = new Point(160, 340);
      Point point13 = point1;
      label2_1.Location = point13;
      this.Label2.Name = "Label2";
      Label label2_2 = this.Label2;
      size1 = new Size(28, 24);
      Size size14 = size1;
      label2_2.Size = size14;
      this.Label2.TabIndex = 24;
      this.Label2.Text = "2";
      this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.Label3.BorderStyle = BorderStyle.FixedSingle;
      this.Label3.Font = new Font("Arial", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      Label label3_1 = this.Label3;
      point1 = new Point(308, 172);
      Point point14 = point1;
      label3_1.Location = point14;
      this.Label3.Name = "Label3";
      Label label3_2 = this.Label3;
      size1 = new Size(28, 24);
      Size size15 = size1;
      label3_2.Size = size15;
      this.Label3.TabIndex = 24;
      this.Label3.Text = "3";
      this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.HelpGrid.AutoSizeMinHeight = 10;
      this.HelpGrid.AutoSizeMinWidth = 10;
      this.HelpGrid.AutoStretchColumnsToFitWidth = true;
      this.HelpGrid.AutoStretchRowsToFitHeight = false;
      this.HelpGrid.ContextMenuStyle = ContextMenuStyle.None;
      this.HelpGrid.CustomSort = false;
      this.HelpGrid.GridToolTipActive = true;
      Grid helpGrid1 = this.HelpGrid;
      point1 = new Point(8, 376);
      Point point15 = point1;
      helpGrid1.Location = point15;
      this.HelpGrid.Name = "HelpGrid";
      Grid helpGrid2 = this.HelpGrid;
      size1 = new Size(504, 160);
      Size size16 = size1;
      helpGrid2.Size = size16;
      this.HelpGrid.SpecialKeys = GridSpecialKeys.Default;
      this.HelpGrid.TabIndex = 2;
      this.AcceptButton = (IButtonControl) this.Button1;
      size1 = new Size(5, 13);
      this.AutoScaleBaseSize = size1;
      this.CancelButton = (IButtonControl) this.Button3;
      size1 = new Size(522, 543);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.HelpGrid);
      this.Controls.Add((Control) this.Panel2);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (FormTransitDirection);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = nameof (FormTransitDirection);
      this.Panel2.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    private object UpdateTile()
    {
      ArrayList newArray = new ArrayList();
      if (!this.isLoading)
      {
        this.AusgabeBilder = new LotTile.BitmapAusgabe[0];
        newArray.Add((object) this.GetListenWerte(this.NordListBox));
        newArray.Add((object) this.GetListenWerte(this.WestListBox));
        newArray.Add((object) this.GetListenWerte(this.SuedListBox));
        newArray.Add((object) this.GetListenWerte(this.OstListBox));
        this.AktuellesTile.SetDirectionArray(newArray);
        this.BeschreibungsGrid[2, 0].Value = RuntimeHelpers.GetObjectValue(this.AktuellesTile.DirectionArray[0]);
        this.BeschreibungsGrid[2, 1].Value = RuntimeHelpers.GetObjectValue(this.AktuellesTile.DirectionArray[1]);
        this.BeschreibungsGrid[2, 2].Value = RuntimeHelpers.GetObjectValue(this.AktuellesTile.DirectionArray[2]);
        this.BeschreibungsGrid[2, 3].Value = RuntimeHelpers.GetObjectValue(this.AktuellesTile.DirectionArray[3]);
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
        this.Graphicgrid2.removeCell(Cell);
        if (this.AusgabeBilder.GetUpperBound(0) > -1)
        {
          int upperBound = this.AusgabeBilder.GetUpperBound(0);
          int index = 0;
          while (index <= upperBound)
          {
            this.Graphicgrid2.setCell(Cell, this.AusgabeBilder[index].AusgabeBild, this.AusgabeBilder[index].Direction, this.AusgabeBilder[index].isTransparent, this.AusgabeBilder[index].isMirror);
            checked { ++index; }
          }
        }
      }
      object obj;
      return obj;
    }

    public object SetzeTexte()
    {
      this.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[431]);
      this.Button3.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[390]);
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

    private void FormTransitDirection_Load(object sender, EventArgs e)
    {
      this.isLoading = true;
      sr_Userinterface.AendereFarben((Form) this, ClassThisProg.DefReader.FarbSchema);
      this.l_TitleModel.BackColor = Color.SteelBlue;
      this.l_TitleModel.ForeColor = Color.White;
      this.l_TitleModel.Font = this.Font;
      this.l_TitleModel.TextAlignment = SourceLibrary.Drawing.ContentAlignment.MiddleCenter;
      this.l_CenterModel.Font = this.Font;
      this.l_CenterModel.TextAlignment = SourceLibrary.Drawing.ContentAlignment.MiddleCenter;
      this.l_HelpModel.BackColor = Color.SteelBlue;
      this.l_HelpModel.ForeColor = Color.White;
      this.l_HelpModel.Font = this.Font;
      this.l_HelpModel.TextAlignment = SourceLibrary.Drawing.ContentAlignment.MiddleLeft;
      this.BeschreibungsGrid.Width = this.Button1.Width;
      this.BeschreibungsGrid.RowsCount = 3;
      this.BeschreibungsGrid.ColumnsCount = 4;
      this.BeschreibungsGrid.Selection.SelectionMode = GridSelectionMode.Row;
      int num = checked (this.BeschreibungsGrid.ColumnsCount - 1);
      int p = 0;
      while (p <= num)
      {
        this.BeschreibungsGrid.Columns[p].Width = checked ((int) Math.Round(unchecked ((double) this.BeschreibungsGrid.Width / (double) this.BeschreibungsGrid.ColumnsCount)));
        checked { ++p; }
      }
      this.BeschreibungsGrid[0, 0] = (ICell) new Cell((object) "Rep15 Value", (IDataModel) null, (IVisualModel) this.l_TitleModel);
      this.BeschreibungsGrid[0, 0].ColumnSpan = this.BeschreibungsGrid.ColumnsCount;
      this.BeschreibungsGrid[1, 0] = (ICell) new Cell((object) "0", (IDataModel) null, (IVisualModel) this.l_TitleModel);
      this.BeschreibungsGrid[1, 1] = (ICell) new Cell((object) "1", (IDataModel) null, (IVisualModel) this.l_TitleModel);
      this.BeschreibungsGrid[1, 2] = (ICell) new Cell((object) "2", (IDataModel) null, (IVisualModel) this.l_TitleModel);
      this.BeschreibungsGrid[1, 3] = (ICell) new Cell((object) "3", (IDataModel) null, (IVisualModel) this.l_TitleModel);
      this.BeschreibungsGrid[2, 0] = (ICell) new Cell((object) "", (IDataModel) null, (IVisualModel) this.l_CenterModel);
      this.BeschreibungsGrid[2, 1] = (ICell) new Cell((object) "", (IDataModel) null, (IVisualModel) this.l_CenterModel);
      this.BeschreibungsGrid[2, 2] = (ICell) new Cell((object) "", (IDataModel) null, (IVisualModel) this.l_CenterModel);
      this.BeschreibungsGrid[2, 3] = (ICell) new Cell((object) "", (IDataModel) null, (IVisualModel) this.l_CenterModel);
      this.BeschreibungsGrid[2, 0].Value = RuntimeHelpers.GetObjectValue(this.AktuellesTile.DirectionArray[0]);
      this.BeschreibungsGrid[2, 1].Value = RuntimeHelpers.GetObjectValue(this.AktuellesTile.DirectionArray[1]);
      this.BeschreibungsGrid[2, 2].Value = RuntimeHelpers.GetObjectValue(this.AktuellesTile.DirectionArray[2]);
      this.BeschreibungsGrid[2, 3].Value = RuntimeHelpers.GetObjectValue(this.AktuellesTile.DirectionArray[3]);
      this.HelpGrid.RowsCount = 8;
      this.HelpGrid.ColumnsCount = 2;
      this.HelpGrid.Selection.SelectionMode = GridSelectionMode.Row;
      this.HelpGrid.GridToolTipActive = true;
      this.HelpGrid.Columns[0].Width = 30;
      this.HelpGrid.Columns[1].Width = checked (this.HelpGrid.Width - this.HelpGrid.Columns[0].Width - 20);
      this.HelpGrid[0, 0] = (ICell) new Cell((object) "Flag", (IDataModel) null, (IVisualModel) this.l_HelpModel);
      this.HelpGrid[0, 1] = (ICell) new Cell((object) "", (IDataModel) null, (IVisualModel) this.l_HelpModel);
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
      this.SetzeListen(true);
      this.isLoading = false;
      this.ZeichneTile();
    }

    private object CheckClickedValue(CheckedListBox myListBox)
    {
      int selectedIndex = myListBox.SelectedIndex;
      string transitArt = this.AktuellesTile.TransitArt;
      if (StringType.StrCmp(transitArt, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[330]), false) == 0)
      {
        if (myListBox.SelectedIndex == 1 | myListBox.SelectedIndex == 3 | myListBox.SelectedIndex == 4)
        {
          myListBox.SetItemChecked(selectedIndex, false);
          int num = (int) MessageBox.Show((IWin32Window) this, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[410]), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[57]), MessageBoxButtons.OK, MessageBoxIcon.Hand);
          goto label_29;
        }
      }
      else if (StringType.StrCmp(transitArt, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[331]), false) == 0)
      {
        if (myListBox.SelectedIndex == 1 | myListBox.SelectedIndex == 3 | myListBox.SelectedIndex == 4)
        {
          myListBox.SetItemChecked(selectedIndex, false);
          int num = (int) MessageBox.Show((IWin32Window) this, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[410]), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[57]), MessageBoxButtons.OK, MessageBoxIcon.Hand);
          goto label_29;
        }
      }
      else if (StringType.StrCmp(transitArt, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[332]), false) != 0)
      {
        if (StringType.StrCmp(transitArt, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[333]), false) == 0)
        {
          if (myListBox.SelectedIndex == 1 | myListBox.SelectedIndex == 3 | myListBox.SelectedIndex == 4)
          {
            myListBox.SetItemChecked(selectedIndex, false);
            int num = (int) MessageBox.Show((IWin32Window) this, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[410]), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[57]), MessageBoxButtons.OK, MessageBoxIcon.Hand);
            goto label_29;
          }
        }
        else if (StringType.StrCmp(transitArt, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[334]), false) == 0)
        {
          if (myListBox.SelectedIndex == 1 | myListBox.SelectedIndex == 3)
          {
            myListBox.SetItemChecked(selectedIndex, false);
            int num = (int) MessageBox.Show((IWin32Window) this, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[410]), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[57]), MessageBoxButtons.OK, MessageBoxIcon.Hand);
            goto label_29;
          }
        }
        else if (StringType.StrCmp(transitArt, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[335]), false) == 0)
        {
          if (myListBox.SelectedIndex == 1 | myListBox.SelectedIndex == 3 | myListBox.SelectedIndex == 4)
          {
            myListBox.SetItemChecked(selectedIndex, false);
            int num = (int) MessageBox.Show((IWin32Window) this, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[410]), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[57]), MessageBoxButtons.OK, MessageBoxIcon.Hand);
            goto label_29;
          }
        }
        else if (StringType.StrCmp(transitArt, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[336]), false) == 0)
        {
          if (myListBox.SelectedIndex == 1 | myListBox.SelectedIndex == 3 | myListBox.SelectedIndex == 4)
          {
            myListBox.SetItemChecked(selectedIndex, false);
            int num = (int) MessageBox.Show((IWin32Window) this, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[410]), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[57]), MessageBoxButtons.OK, MessageBoxIcon.Hand);
            goto label_29;
          }
        }
        else if (StringType.StrCmp(transitArt, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[337]), false) == 0)
        {
          if (myListBox.SelectedIndex == 1 | myListBox.SelectedIndex == 3 | myListBox.SelectedIndex == 4)
          {
            myListBox.SetItemChecked(selectedIndex, false);
            int num = (int) MessageBox.Show((IWin32Window) this, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[410]), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[57]), MessageBoxButtons.OK, MessageBoxIcon.Hand);
            goto label_29;
          }
        }
        else if (StringType.StrCmp(transitArt, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[338]), false) != 0)
          ;
      }
      int num1 = checked (myListBox.Items.Count - 1);
      int index = 0;
      while (index <= num1)
      {
        if (index != myListBox.SelectedIndex)
          myListBox.SetItemChecked(index, false);
        checked { ++index; }
      }
      this.UpdateTile();
label_29:
      object obj;
      return obj;
    }

    private string GetListenWerte(CheckedListBox myListBox)
    {
      if (myListBox.GetItemChecked(0))
        return "00";
      if (myListBox.GetItemChecked(1))
        return "01";
      if (myListBox.GetItemChecked(2))
        return "02";
      if (myListBox.GetItemChecked(3))
        return "03";
      if (myListBox.GetItemChecked(4))
        return "04";
      return myListBox.GetItemChecked(5) ? "FF" : "00";
    }

    private object SetzeEinzelListe(
      CheckedListBox myListBox,
      bool AllowClick,
      int myValue,
      int GridSpalte)
    {
      int num = checked (this.NordListBox.Items.Count - 1);
      int index1 = 0;
      while (index1 <= num)
      {
        myListBox.SetItemChecked(index1, false);
        myListBox.SetItemChecked(index1, false);
        myListBox.SetItemChecked(index1, false);
        myListBox.SetItemChecked(index1, false);
        checked { ++index1; }
      }
      myListBox.SelectedIndex = 0;
      myListBox.SelectedItem = (object) 0;
      int index2 = -1;
      if (AllowClick)
      {
        switch (myValue)
        {
          case 0:
            index2 = 0;
            this.BeschreibungsGrid[2, GridSpalte].Value = (object) "00";
            break;
          case 1:
            index2 = 1;
            this.BeschreibungsGrid[2, GridSpalte].Value = (object) "01";
            break;
          case 2:
            index2 = 2;
            this.BeschreibungsGrid[2, GridSpalte].Value = (object) "02";
            break;
          case 3:
            index2 = 3;
            this.BeschreibungsGrid[2, GridSpalte].Value = (object) "03";
            break;
          case 4:
            index2 = 4;
            this.BeschreibungsGrid[2, GridSpalte].Value = (object) "04";
            break;
          case (int) byte.MaxValue:
            index2 = 5;
            this.BeschreibungsGrid[2, GridSpalte].Value = (object) "FF";
            break;
        }
        if (index2 > -1)
        {
          myListBox.Enabled = true;
          this.Button1.Enabled = true;
          myListBox.SelectedIndex = index2;
          myListBox.SelectedItem = (object) index2;
          myListBox.SetItemChecked(index2, true);
        }
      }
      else
      {
        this.Button1.Enabled = false;
        myListBox.Enabled = false;
      }
      object obj;
      return obj;
    }

    private object SetzeListen(bool AllowClick)
    {
      this.SetzeEinzelListe(this.NordListBox, AllowClick, IntegerType.FromObject(this.AktuellesTile.DirectionArray[0]), 0);
      this.SetzeEinzelListe(this.WestListBox, AllowClick, IntegerType.FromObject(this.AktuellesTile.DirectionArray[1]), 1);
      this.SetzeEinzelListe(this.SuedListBox, AllowClick, IntegerType.FromObject(this.AktuellesTile.DirectionArray[2]), 2);
      this.SetzeEinzelListe(this.OstListBox, AllowClick, IntegerType.FromObject(this.AktuellesTile.DirectionArray[3]), 3);
      object obj;
      return obj;
    }

    private void FormTransitDirection_Closed(object sender, EventArgs e) => ClassThisProg.frmTransitDirection = (FormTransitDirection) null;

    private void Button1_Click(object sender, EventArgs e)
    {
      this.AktuellesTile.SetDirectionArray(new ArrayList()
      {
        (object) this.GetListenWerte(this.NordListBox),
        (object) this.GetListenWerte(this.WestListBox),
        (object) this.GetListenWerte(this.SuedListBox),
        (object) this.GetListenWerte(this.OstListBox)
      });
      this.DialogResult = DialogResult.OK;
    }

    private void NordListBox_SelectedIndexChanged(object sender, EventArgs e) => this.CheckClickedValue(this.NordListBox);

    private void WestListBox_SelectedIndexChanged(object sender, EventArgs e) => this.CheckClickedValue(this.WestListBox);

    private void SuedListBox_SelectedIndexChanged(object sender, EventArgs e) => this.CheckClickedValue(this.SuedListBox);

    private void OstListBox_SelectedIndexChanged(object sender, EventArgs e) => this.CheckClickedValue(this.OstListBox);
  }
}
