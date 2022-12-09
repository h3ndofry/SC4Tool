// Decompiled with JetBrains decompiler
// Type: SC4Tool.FormAbout
// Assembly: SC4Tool, Version=2.2.7.0, Culture=neutral, PublicKeyToken=null
// MVID: 69A50BC4-87A5-4C5E-BEFC-08274BC6D498
// Assembly location: C:\Program Files (x86)\SC4 Utilities\SC4Tool\SC4Tool.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
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
  public class FormAbout : Form
  {
    [AccessedThroughProperty("Label3")]
    private Label _Label3;
    [AccessedThroughProperty("Label2")]
    private Label _Label2;
    [AccessedThroughProperty("DisplayGrid")]
    private Grid _DisplayGrid;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("Label4")]
    private Label _Label4;
    [AccessedThroughProperty("Button1")]
    private System.Windows.Forms.Button _Button1;
    [AccessedThroughProperty("PictureBox1")]
    private PictureBox _PictureBox1;
    [AccessedThroughProperty("PictureBox2")]
    private PictureBox _PictureBox2;
    private ArrayList TextArray;
    private IContainer components;

    public FormAbout()
    {
      this.Load += new EventHandler(this.FormAbout_Load);
      this.Closed += new EventHandler(this.FormAbout_Closed);
      this.TextArray = new ArrayList();
      this.InitializeComponent();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
      ClassThisProg.frmAbout = (FormAbout) null;
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

    internal virtual Label Label1
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Label1 != null)
          this._Label1.Click -= new EventHandler(this.Label1_Click);
        this._Label1 = value;
        if (this._Label1 == null)
          return;
        this._Label1.Click += new EventHandler(this.Label1_Click);
      }
      get => this._Label1;
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

    internal virtual PictureBox PictureBox2
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._PictureBox2 == null)
          ;
        this._PictureBox2 = value;
        if (this._PictureBox2 == null)
          ;
      }
      get => this._PictureBox2;
    }

    internal virtual Grid DisplayGrid
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._DisplayGrid == null)
          ;
        this._DisplayGrid = value;
        if (this._DisplayGrid == null)
          ;
      }
      get => this._DisplayGrid;
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      ResourceManager resourceManager = new ResourceManager(typeof (FormAbout));
      this.Button1 = new System.Windows.Forms.Button();
      this.Label1 = new Label();
      this.Label2 = new Label();
      this.Label3 = new Label();
      this.Label4 = new Label();
      this.PictureBox1 = new PictureBox();
      this.PictureBox2 = new PictureBox();
      this.DisplayGrid = new Grid();
      this.SuspendLayout();
      System.Windows.Forms.Button button1_1 = this.Button1;
      Point point1 = new Point(352, 392);
      Point point2 = point1;
      button1_1.Location = point2;
      this.Button1.Name = "Button1";
      System.Windows.Forms.Button button1_2 = this.Button1;
      Size size1 = new Size(112, 32);
      Size size2 = size1;
      button1_2.Size = size2;
      this.Button1.TabIndex = 1;
      this.Button1.Text = "Close";
      this.Label1.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      Label label1_1 = this.Label1;
      point1 = new Point(16, 48);
      Point point3 = point1;
      label1_1.Location = point3;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      size1 = new Size(88, 16);
      Size size3 = size1;
      label1_2.Size = size3;
      this.Label1.TabIndex = 2;
      this.Label1.Text = "Version 2.2.7";
      this.Label2.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label2_1 = this.Label2;
      point1 = new Point(16, 16);
      Point point4 = point1;
      label2_1.Location = point4;
      this.Label2.Name = "Label2";
      Label label2_2 = this.Label2;
      size1 = new Size(168, 24);
      Size size4 = size1;
      label2_2.Size = size4;
      this.Label2.TabIndex = 3;
      this.Label2.Text = "SC4Tool for Win2000, WinXP";
      this.Label3.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label3_1 = this.Label3;
      point1 = new Point(16, 104);
      Point point5 = point1;
      label3_1.Location = point5;
      this.Label3.Name = "Label3";
      Label label3_2 = this.Label3;
      size1 = new Size(360, 16);
      Size size5 = size1;
      label3_2.Size = size5;
      this.Label3.TabIndex = 4;
      this.Label3.Text = "Copyright(C) 2005 by simrolle,  Andreas Roth";
      this.Label4.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label4_1 = this.Label4;
      point1 = new Point(16, 128);
      Point point6 = point1;
      label4_1.Location = point6;
      this.Label4.Name = "Label4";
      Label label4_2 = this.Label4;
      size1 = new Size(168, 24);
      Size size6 = size1;
      label4_2.Size = size6;
      this.Label4.TabIndex = 5;
      this.Label4.Text = "E-Mail: simrolle@oleco.net";
      this.PictureBox1.Image = (Image) resourceManager.GetObject("PictureBox1.Image");
      PictureBox pictureBox1_1 = this.PictureBox1;
      point1 = new Point(240, 16);
      Point point7 = point1;
      pictureBox1_1.Location = point7;
      this.PictureBox1.Name = "PictureBox1";
      PictureBox pictureBox1_2 = this.PictureBox1;
      size1 = new Size(139, 80);
      Size size7 = size1;
      pictureBox1_2.Size = size7;
      this.PictureBox1.TabIndex = 8;
      this.PictureBox1.TabStop = false;
      this.PictureBox2.Image = (Image) resourceManager.GetObject("PictureBox2.Image");
      PictureBox pictureBox2_1 = this.PictureBox2;
      point1 = new Point(400, 16);
      Point point8 = point1;
      pictureBox2_1.Location = point8;
      this.PictureBox2.Name = "PictureBox2";
      PictureBox pictureBox2_2 = this.PictureBox2;
      size1 = new Size(80, 80);
      Size size8 = size1;
      pictureBox2_2.Size = size8;
      this.PictureBox2.TabIndex = 9;
      this.PictureBox2.TabStop = false;
      this.DisplayGrid.AutoSizeMinHeight = 10;
      this.DisplayGrid.AutoSizeMinWidth = 10;
      this.DisplayGrid.AutoStretchColumnsToFitWidth = false;
      this.DisplayGrid.AutoStretchRowsToFitHeight = false;
      this.DisplayGrid.ContextMenuStyle = ContextMenuStyle.None;
      this.DisplayGrid.CustomSort = false;
      this.DisplayGrid.GridToolTipActive = true;
      Grid displayGrid1 = this.DisplayGrid;
      point1 = new Point(16, 160);
      Point point9 = point1;
      displayGrid1.Location = point9;
      this.DisplayGrid.Name = "DisplayGrid";
      Grid displayGrid2 = this.DisplayGrid;
      size1 = new Size(464, 216);
      Size size9 = size1;
      displayGrid2.Size = size9;
      this.DisplayGrid.SpecialKeys = GridSpecialKeys.Default;
      this.DisplayGrid.TabIndex = 10;
      size1 = new Size(5, 13);
      this.AutoScaleBaseSize = size1;
      size1 = new Size(488, 429);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.DisplayGrid);
      this.Controls.Add((Control) this.PictureBox2);
      this.Controls.Add((Control) this.PictureBox1);
      this.Controls.Add((Control) this.Label4);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.Button1);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (FormAbout);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "About SC4Tool";
      this.ResumeLayout(false);
    }

    public object SetzeTexte()
    {
      this.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[398]);
      this.Button1.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[3]);
      this.TextArray.Add((object) "Credits#1");
      this.TextArray.Add((object) "- Andreas from www.simszone.de for idea, testing, layout....#0");
      this.TextArray.Add((object) "- Eddie from the BSC-Team for the patience to test version of version#0");
      this.TextArray.Add((object) "- CJMarshall from the BSC-Team who shared his knowledge about TE#0");
      this.TextArray.Add((object) "- Deadwoods from the BSC-Team who helped me designing TextureScanner#0");
      this.TextArray.Add((object) "- The BSC-Team for testing#0");
      this.TextArray.Add((object) "- DarkMatter for his FSHLib#0");
      this.TextArray.Add((object) "Translations#1");
      this.TextArray.Add((object) "- Dutch     : Thunderman#0");
      this.TextArray.Add((object) "- Portugese : Suico#0");
      this.TextArray.Add((object) "- Spanish   : jeronij#0");
      this.TextArray.Add((object) "- Suomi     : Zeddic#0");
      this.TextArray.Add((object) "- Italian   : vinlabsc3k#0");
      this.TextArray.Add((object) "Third party software#1");
      this.TextArray.Add((object) "SourceGrid Copyright (c) 2004, Davide Icardi#0");
      this.TextArray.Add((object) "This is an Open Source CSharp Project founded by Davide Icardi.#0");
      this.TextArray.Add((object) "I strongly recommend that you do not use sr_sourcegrid.dll, because I've#0");
      this.TextArray.Add((object) "made a few accommodations for the project.The behavior of some#0");
      this.TextArray.Add((object) "features are changed in a radical, not documented way.#0");
      this.TextArray.Add((object) "You can download the original code from www.devage.com#0");
      this.TextArray.Add((object) "Thanks to Davide for his great work.#0");
      this.TextArray.Add((object) "Eyefinder, SandBar, SandDock#1");
      this.TextArray.Add((object) "Copyright (c) 2005 by Divelements Limited.#0");
      this.TextArray.Add((object) "Eyefinder,SandDock and SandBar can be downloaded from www.divelements.co.uk#0");
      this.TextArray.Add((object) "for use with free software free of charge. The license requires your software#0");
      this.TextArray.Add((object) "generate no profit, be available for public download over the internet and contain#0");
      this.TextArray.Add((object) "a link to www.divelements.co.uk#0");
      this.TextArray.Add((object) "The license does not permit distribution of the product with any commercial application#0");
      this.TextArray.Add((object) " or application that is not available for free download.#0");
      object obj;
      return obj;
    }

    private object FillGrid()
    {
      Common common1 = new Common();
      Common common2 = common1;
      RectangleBorder rectangleBorder1;
      ref RectangleBorder local1 = ref rectangleBorder1;
      Border border1 = new Border(common1.BackColor, 1);
      Border p_Top1 = border1;
      Border border2 = new Border(common1.BackColor, 0);
      Border p_Bottom1 = border2;
      Border border3 = new Border(common1.BackColor, 0);
      Border p_Left1 = border3;
      Border border4 = new Border(common1.BackColor, 0);
      Border p_Right1 = border4;
      local1 = new RectangleBorder(p_Top1, p_Bottom1, p_Left1, p_Right1);
      RectangleBorder rectangleBorder2 = rectangleBorder1;
      common2.Border = rectangleBorder2;
      Common common3 = new Common();
      Common common4 = common3;
      ref RectangleBorder local2 = ref rectangleBorder1;
      border4 = new Border(common1.BackColor, 1);
      Border p_Top2 = border4;
      border3 = new Border(common1.BackColor, 0);
      Border p_Bottom2 = border3;
      border2 = new Border(common1.BackColor, 0);
      Border p_Left2 = border2;
      border1 = new Border(common1.BackColor, 0);
      Border p_Right2 = border1;
      local2 = new RectangleBorder(p_Top2, p_Bottom2, p_Left2, p_Right2);
      RectangleBorder rectangleBorder3 = rectangleBorder1;
      common4.Border = rectangleBorder3;
      common3.Font = new Font("Arial", 9f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, (byte) 0);
      this.DisplayGrid.ColumnsCount = 1;
      this.DisplayGrid.Columns[0].Width = checked (this.DisplayGrid.Width - 20);
      int num = checked (this.TextArray.Count - 1);
      int index = 0;
      while (index <= num)
      {
        string[] strArray = Strings.Split(StringType.FromObject(this.TextArray[index]), "#");
        if (StringType.StrCmp(strArray[1], "0", false) == 0)
        {
          this.DisplayGrid.Rows.Insert(this.DisplayGrid.RowsCount);
          this.DisplayGrid[checked (this.DisplayGrid.RowsCount - 1), 0] = (ICell) new Cell((object) strArray[0], (IDataModel) null, (IVisualModel) common1);
        }
        else
        {
          if (index > 0)
          {
            this.DisplayGrid.Rows.Insert(this.DisplayGrid.RowsCount);
            this.DisplayGrid[checked (this.DisplayGrid.RowsCount - 1), 0] = (ICell) new Cell((object) "", (IDataModel) null, (IVisualModel) common1);
          }
          this.DisplayGrid.Rows.Insert(this.DisplayGrid.RowsCount);
          this.DisplayGrid[checked (this.DisplayGrid.RowsCount - 1), 0] = (ICell) new Cell((object) strArray[0], (IDataModel) null, (IVisualModel) common3);
        }
        checked { ++index; }
      }
      object obj;
      return obj;
    }

    private void FormAbout_Load(object sender, EventArgs e)
    {
      this.SetzeTexte();
      this.FillGrid();
    }

    private void Button1_Click(object sender, EventArgs e) => this.Dispose();

    private void FormAbout_Closed(object sender, EventArgs e) => ClassThisProg.frmAbout = (FormAbout) null;

    private void Label1_Click(object sender, EventArgs e)
    {
    }
  }
}
