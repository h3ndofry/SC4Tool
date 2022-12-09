// Decompiled with JetBrains decompiler
// Type: SC4Tool.FormLanguage
// Assembly: SC4Tool, Version=2.2.7.0, Culture=neutral, PublicKeyToken=null
// MVID: 69A50BC4-87A5-4C5E-BEFC-08274BC6D498
// Assembly location: C:\Program Files (x86)\SC4 Utilities\SC4Tool\SC4Tool.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using sr_Resources;
using sr_SC4Lib;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;
using TD.SandBar;
using TD.SandDock;

namespace SC4Tool
{
  public class FormLanguage : Form
  {
    [AccessedThroughProperty("DocumentContainer1")]
    private DocumentContainer _DocumentContainer1;
    [AccessedThroughProperty("SandDockManager1")]
    private SandDockManager _SandDockManager1;
    [AccessedThroughProperty("DockControl1")]
    private DockControl _DockControl1;
    [AccessedThroughProperty("DockControl2")]
    private DockControl _DockControl2;
    [AccessedThroughProperty("FlagPanel")]
    private Panel _FlagPanel;
    [AccessedThroughProperty("DataGrid1")]
    private DataGrid _DataGrid1;
    [AccessedThroughProperty("ToolButton4")]
    private ButtonItem _ToolButton4;
    [AccessedThroughProperty("ToolBar1")]
    private TD.SandBar.ToolBar _ToolBar1;
    [AccessedThroughProperty("DataSet1")]
    private DataSet _DataSet1;
    [AccessedThroughProperty("DataTable1")]
    private DataTable _DataTable1;
    [AccessedThroughProperty("ToolButton5")]
    private ButtonItem _ToolButton5;
    [AccessedThroughProperty("ToolButton3")]
    private ButtonItem _ToolButton3;
    [AccessedThroughProperty("ToolButton6")]
    private ButtonItem _ToolButton6;
    [AccessedThroughProperty("ToolBar2")]
    private TD.SandBar.ToolBar _ToolBar2;
    [AccessedThroughProperty("ImageList1")]
    private ImageList _ImageList1;
    [AccessedThroughProperty("BildButton1")]
    private ButtonItem _BildButton1;
    [AccessedThroughProperty("FlagImageList")]
    private ImageList _FlagImageList;
    [AccessedThroughProperty("ToolButton1")]
    private ButtonItem _ToolButton1;
    [AccessedThroughProperty("ToolButton2")]
    private ButtonItem _ToolButton2;
    private bool isLoading;
    private string AktuelleLeseDatei;
    private Image[] ImageListe;
    private IContainer components;

    public FormLanguage()
    {
      this.Closed += new EventHandler(this.FormLanguage_Closed);
      this.Load += new EventHandler(this.Form2_Load);
      this.InitializeComponent();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
      ClassThisProg.frmLanguage = (FormLanguage) null;
    }

    public virtual SandDockManager SandDockManager1
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._SandDockManager1 == null)
          ;
        this._SandDockManager1 = value;
        if (this._SandDockManager1 == null)
          ;
      }
      get => this._SandDockManager1;
    }

    internal virtual DocumentContainer DocumentContainer1
    {
      get => this._DocumentContainer1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._DocumentContainer1 == null)
          ;
        this._DocumentContainer1 = value;
        if (this._DocumentContainer1 == null)
          ;
      }
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

    internal virtual Panel FlagPanel
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._FlagPanel == null)
          ;
        this._FlagPanel = value;
        if (this._FlagPanel == null)
          ;
      }
      get => this._FlagPanel;
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

    internal virtual DataGrid DataGrid1
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._DataGrid1 == null)
          ;
        this._DataGrid1 = value;
        if (this._DataGrid1 == null)
          ;
      }
      get => this._DataGrid1;
    }

    internal virtual DataSet DataSet1
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._DataSet1 == null)
          ;
        this._DataSet1 = value;
        if (this._DataSet1 == null)
          ;
      }
      get => this._DataSet1;
    }

    internal virtual DataTable DataTable1
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._DataTable1 != null)
          this._DataTable1.RowChanged -= new DataRowChangeEventHandler(this.DataTable1_RowChanged);
        this._DataTable1 = value;
        if (this._DataTable1 == null)
          return;
        this._DataTable1.RowChanged += new DataRowChangeEventHandler(this.DataTable1_RowChanged);
      }
      get => this._DataTable1;
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
      get => this._ToolButton1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ToolButton1 != null)
          this._ToolButton1.Activate -= new EventHandler(this.ToolButton1_Activate);
        this._ToolButton1 = value;
        if (this._ToolButton1 == null)
          return;
        this._ToolButton1.Activate += new EventHandler(this.ToolButton1_Activate);
      }
    }

    internal virtual ButtonItem ToolButton2
    {
      get => this._ToolButton2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ToolButton2 != null)
          this._ToolButton2.Activate -= new EventHandler(this.ToolButton2_Activate);
        this._ToolButton2 = value;
        if (this._ToolButton2 == null)
          return;
        this._ToolButton2.Activate += new EventHandler(this.ToolButton2_Activate);
      }
    }

    internal virtual ButtonItem ToolButton3
    {
      get => this._ToolButton3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ToolButton3 != null)
          this._ToolButton3.Activate -= new EventHandler(this.ToolButton3_Activate);
        this._ToolButton3 = value;
        if (this._ToolButton3 == null)
          return;
        this._ToolButton3.Activate += new EventHandler(this.ToolButton3_Activate);
      }
    }

    internal virtual ButtonItem ToolButton4
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ToolButton4 != null)
          this._ToolButton4.Activate -= new EventHandler(this.ToolButton4_Activate);
        this._ToolButton4 = value;
        if (this._ToolButton4 == null)
          return;
        this._ToolButton4.Activate += new EventHandler(this.ToolButton4_Activate);
      }
      get => this._ToolButton4;
    }

    internal virtual ButtonItem ToolButton5
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ToolButton5 != null)
          this._ToolButton5.Activate -= new EventHandler(this.ToolButton5_Activate);
        this._ToolButton5 = value;
        if (this._ToolButton5 == null)
          return;
        this._ToolButton5.Activate += new EventHandler(this.ToolButton5_Activate);
      }
      get => this._ToolButton5;
    }

    internal virtual ButtonItem ToolButton6
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ToolButton6 == null)
          ;
        this._ToolButton6 = value;
        if (this._ToolButton6 == null)
          ;
      }
      get => this._ToolButton6;
    }

    internal virtual TD.SandBar.ToolBar ToolBar2
    {
      get => this._ToolBar2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ToolBar2 == null)
          ;
        this._ToolBar2 = value;
        if (this._ToolBar2 == null)
          ;
      }
    }

    internal virtual ButtonItem BildButton1
    {
      get => this._BildButton1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._BildButton1 != null)
          this._BildButton1.Activate -= new EventHandler(this.BildButton1_Activate);
        this._BildButton1 = value;
        if (this._BildButton1 == null)
          return;
        this._BildButton1.Activate += new EventHandler(this.BildButton1_Activate);
      }
    }

    internal virtual ImageList FlagImageList
    {
      get => this._FlagImageList;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._FlagImageList == null)
          ;
        this._FlagImageList = value;
        if (this._FlagImageList == null)
          ;
      }
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      ResourceManager resourceManager = new ResourceManager(typeof (FormLanguage));
      this.SandDockManager1 = new SandDockManager();
      this.ToolBar1 = new TD.SandBar.ToolBar();
      this.ImageList1 = new ImageList(this.components);
      this.ToolButton1 = new ButtonItem();
      this.ToolButton2 = new ButtonItem();
      this.ToolButton3 = new ButtonItem();
      this.ToolButton4 = new ButtonItem();
      this.ToolButton5 = new ButtonItem();
      this.ToolButton6 = new ButtonItem();
      this.DocumentContainer1 = new DocumentContainer();
      this.DockControl1 = new DockControl();
      this.DataGrid1 = new DataGrid();
      this.DockControl2 = new DockControl();
      this.FlagPanel = new Panel();
      this.ToolBar2 = new TD.SandBar.ToolBar();
      this.BildButton1 = new ButtonItem();
      this.DataSet1 = new DataSet();
      this.DataTable1 = new DataTable();
      this.FlagImageList = new ImageList(this.components);
      this.DocumentContainer1.SuspendLayout();
      this.DockControl1.SuspendLayout();
      this.DataGrid1.BeginInit();
      this.DockControl2.SuspendLayout();
      this.FlagPanel.SuspendLayout();
      this.DataSet1.BeginInit();
      this.DataTable1.BeginInit();
      this.SuspendLayout();
      this.SandDockManager1.OwnerForm = (Form) this;
      TD.SandBar.ToolBar toolBar1_1 = this.ToolBar1;
      Guid guid1 = new Guid("4c4c062c-1d83-4197-b509-9b455a41694e");
      Guid guid2 = guid1;
      toolBar1_1.Guid = guid2;
      this.ToolBar1.ImageList = this.ImageList1;
      this.ToolBar1.Items.AddRange(new ToolbarItemBase[6]
      {
        (ToolbarItemBase) this.ToolButton1,
        (ToolbarItemBase) this.ToolButton2,
        (ToolbarItemBase) this.ToolButton3,
        (ToolbarItemBase) this.ToolButton4,
        (ToolbarItemBase) this.ToolButton5,
        (ToolbarItemBase) this.ToolButton6
      });
      TD.SandBar.ToolBar toolBar1_2 = this.ToolBar1;
      Point point1 = new Point(0, 0);
      Point point2 = point1;
      toolBar1_2.Location = point2;
      this.ToolBar1.Name = "ToolBar1";
      TD.SandBar.ToolBar toolBar1_3 = this.ToolBar1;
      Size size1 = new Size(632, 24);
      Size size2 = size1;
      toolBar1_3.Size = size2;
      this.ToolBar1.TabIndex = 0;
      this.ToolBar1.Text = "ToolBar1";
      ImageList imageList1 = this.ImageList1;
      size1 = new Size(16, 16);
      Size size3 = size1;
      imageList1.ImageSize = size3;
      this.ImageList1.ImageStream = (ImageListStreamer) resourceManager.GetObject("ImageList1.ImageStream");
      this.ImageList1.TransparentColor = Color.Transparent;
      this.ToolButton1.BeginGroup = true;
      this.ToolButton1.ImageIndex = 0;
      this.ToolButton2.BeginGroup = true;
      this.ToolButton2.ImageIndex = 6;
      this.ToolButton3.BeginGroup = true;
      this.ToolButton3.ImageIndex = 4;
      this.ToolButton4.BeginGroup = true;
      this.ToolButton4.ImageIndex = 3;
      this.ToolButton5.BeginGroup = true;
      this.ToolButton5.ImageIndex = 1;
      this.ToolButton6.BeginGroup = true;
      this.ToolButton6.ImageIndex = 7;
      this.ToolButton6.Visible = false;
      this.DocumentContainer1.Controls.Add((Control) this.DockControl1);
      this.DocumentContainer1.Controls.Add((Control) this.DockControl2);
      DocumentContainer documentContainer1_1 = this.DocumentContainer1;
      guid1 = new Guid("b19fd5ba-d7eb-43e6-b089-3ffe10402027");
      Guid guid3 = guid1;
      documentContainer1_1.Guid = guid3;
      this.DocumentContainer1.LayoutSystem = new SplitLayoutSystem(250, 400, Orientation.Horizontal, new LayoutSystemBase[1]
      {
        (LayoutSystemBase) new DocumentLayoutSystem(630, 435, new DockControl[2]
        {
          this.DockControl1,
          this.DockControl2
        }, this.DockControl2)
      });
      DocumentContainer documentContainer1_2 = this.DocumentContainer1;
      point1 = new Point(0, 24);
      Point point3 = point1;
      documentContainer1_2.Location = point3;
      this.DocumentContainer1.Manager = this.SandDockManager1;
      this.DocumentContainer1.Name = "DocumentContainer1";
      DocumentContainer documentContainer1_3 = this.DocumentContainer1;
      size1 = new Size(632, 437);
      Size size4 = size1;
      documentContainer1_3.Size = size4;
      this.DocumentContainer1.TabIndex = 29;
      this.DockControl1.Closable = false;
      this.DockControl1.Collapsible = false;
      this.DockControl1.Controls.Add((Control) this.DataGrid1);
      this.DockControl1.Floatable = false;
      this.DockControl1.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      DockControl dockControl1_1 = this.DockControl1;
      guid1 = new Guid("a4930440-4704-4aef-90b5-cdcc960e9fb2");
      Guid guid4 = guid1;
      dockControl1_1.Guid = guid4;
      DockControl dockControl1_2 = this.DockControl1;
      point1 = new Point(3, 23);
      Point point4 = point1;
      dockControl1_2.Location = point4;
      this.DockControl1.Name = "DockControl1";
      DockControl dockControl1_3 = this.DockControl1;
      size1 = new Size(626, 411);
      Size size5 = size1;
      dockControl1_3.Size = size5;
      this.DockControl1.TabIndex = 0;
      this.DockControl1.Text = "DockControl1";
      this.DataGrid1.AlternatingBackColor = SystemColors.ScrollBar;
      this.DataGrid1.DataMember = "";
      this.DataGrid1.Dock = DockStyle.Fill;
      this.DataGrid1.HeaderForeColor = SystemColors.ControlText;
      DataGrid dataGrid1_1 = this.DataGrid1;
      point1 = new Point(0, 0);
      Point point5 = point1;
      dataGrid1_1.Location = point5;
      this.DataGrid1.Name = "DataGrid1";
      DataGrid dataGrid1_2 = this.DataGrid1;
      size1 = new Size(626, 411);
      Size size6 = size1;
      dataGrid1_2.Size = size6;
      this.DataGrid1.TabIndex = 1;
      this.DockControl2.Closable = false;
      this.DockControl2.Collapsible = false;
      this.DockControl2.Controls.Add((Control) this.FlagPanel);
      this.DockControl2.Floatable = false;
      this.DockControl2.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      DockControl dockControl2_1 = this.DockControl2;
      guid1 = new Guid("73c7f9d5-f2de-4fea-bc50-75fcc57d5c85");
      Guid guid5 = guid1;
      dockControl2_1.Guid = guid5;
      DockControl dockControl2_2 = this.DockControl2;
      point1 = new Point(3, 23);
      Point point6 = point1;
      dockControl2_2.Location = point6;
      this.DockControl2.Name = "DockControl2";
      DockControl dockControl2_3 = this.DockControl2;
      size1 = new Size(626, 411);
      Size size7 = size1;
      dockControl2_3.Size = size7;
      this.DockControl2.TabIndex = 1;
      this.DockControl2.Text = "DockControl2";
      this.FlagPanel.AutoScroll = true;
      this.FlagPanel.Controls.Add((Control) this.ToolBar2);
      this.FlagPanel.Dock = DockStyle.Fill;
      Panel flagPanel1 = this.FlagPanel;
      point1 = new Point(0, 0);
      Point point7 = point1;
      flagPanel1.Location = point7;
      this.FlagPanel.Name = "FlagPanel";
      Panel flagPanel2 = this.FlagPanel;
      size1 = new Size(626, 411);
      Size size8 = size1;
      flagPanel2.Size = size8;
      this.FlagPanel.TabIndex = 0;
      TD.SandBar.ToolBar toolBar2_1 = this.ToolBar2;
      guid1 = new Guid("d6428bc8-38a4-4c01-9728-22cd0b82caf8");
      Guid guid6 = guid1;
      toolBar2_1.Guid = guid6;
      this.ToolBar2.ImageList = this.ImageList1;
      this.ToolBar2.Items.AddRange(new ToolbarItemBase[1]
      {
        (ToolbarItemBase) this.BildButton1
      });
      TD.SandBar.ToolBar toolBar2_2 = this.ToolBar2;
      point1 = new Point(0, 0);
      Point point8 = point1;
      toolBar2_2.Location = point8;
      this.ToolBar2.Name = "ToolBar2";
      TD.SandBar.ToolBar toolBar2_3 = this.ToolBar2;
      size1 = new Size(626, 24);
      Size size9 = size1;
      toolBar2_3.Size = size9;
      this.ToolBar2.TabIndex = 0;
      this.ToolBar2.Text = "ToolBar2";
      this.ToolBar2.Visible = false;
      this.BildButton1.BeginGroup = true;
      this.BildButton1.ImageIndex = 4;
      this.BildButton1.Visible = false;
      this.DataSet1.DataSetName = "NewDataSet";
      this.DataSet1.Locale = new CultureInfo("de-DE");
      this.DataSet1.Tables.AddRange(new DataTable[1]
      {
        this.DataTable1
      });
      this.DataTable1.TableName = "Table1";
      ImageList flagImageList = this.FlagImageList;
      size1 = new Size(16, 16);
      Size size10 = size1;
      flagImageList.ImageSize = size10;
      this.FlagImageList.TransparentColor = Color.Transparent;
      size1 = new Size(5, 13);
      this.AutoScaleBaseSize = size1;
      size1 = new Size(632, 461);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.DocumentContainer1);
      this.Controls.Add((Control) this.ToolBar1);
      this.Name = nameof (FormLanguage);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Form2";
      this.DocumentContainer1.ResumeLayout(false);
      this.DockControl1.ResumeLayout(false);
      this.DataGrid1.EndInit();
      this.DockControl2.ResumeLayout(false);
      this.FlagPanel.ResumeLayout(false);
      this.DataSet1.EndInit();
      this.DataTable1.EndInit();
      this.ResumeLayout(false);
    }

    private object CreateImageCheckBoxes()
    {
      Loader loader = new Loader();
      int num1 = 16;
      int num2 = 32;
      int num3 = 100;
      int num4 = 32;
      int x = num1;
      int y = num2;
      int num5 = 1;
      this.ImageListe = new Image[1];
      this.ImageListe = loader.GetAllIconsFromResource();
      loader.Dispose();
      if (this.ImageListe.GetUpperBound(0) > -1)
      {
        int upperBound = this.ImageListe.GetUpperBound(0);
        int index = 0;
        while (index <= upperBound)
        {
          if (num5 == 10)
          {
            num5 = 1;
            checked { x += num3; }
            y = num2;
          }
          RadioButton[] radioButtonArray = new RadioButton[checked (index + 1)];
          radioButtonArray[index] = new RadioButton();
          radioButtonArray[index].Location = new Point(x, y);
          radioButtonArray[index].Size = new Size(52, 16);
          radioButtonArray[index].Image = this.ImageListe[index];
          radioButtonArray[index].ImageAlign = ContentAlignment.BottomLeft;
          radioButtonArray[index].Tag = (object) (Strings.Format((object) index, "00").ToString() + ".ICO");
          radioButtonArray[index].Text = "";
          this.FlagPanel.Controls.Add((Control) radioButtonArray[index]);
          radioButtonArray[index].CheckedChanged += new EventHandler(this.FlagCheckBox_CheckedChanged);
          checked { ++num5; }
          checked { y += num4; }
          checked { ++index; }
        }
      }
      object obj;
      return obj;
    }

    private object FormatDateiDataGrid()
    {
      DataColumn column1 = new DataColumn();
      DataColumn column2 = new DataColumn();
      DataColumn column3 = new DataColumn();
      this.isLoading = true;
      this.DataTable1.TableName = "data";
      this.DataGrid1.CaptionText = "Language-Settings";
      this.DataGrid1.BeginInit();
      this.DataGrid1.AllowNavigation = false;
      column1.DataType = System.Type.GetType("System.Int32");
      column1.ColumnName = "id";
      column1.ReadOnly = true;
      this.DataTable1.Columns.Add(column1);
      column2.DataType = System.Type.GetType("System.String");
      column2.ColumnName = "Standard";
      column2.ReadOnly = true;
      this.DataTable1.Columns.Add(column2);
      column3.DataType = System.Type.GetType("System.String");
      column3.ColumnName = "yours";
      column3.ReadOnly = false;
      this.DataTable1.Columns.Add(column3);
      this.DataGrid1.DataSource = (object) this.DataTable1;
      this.DataGrid1.CaptionVisible = false;
      DataGridTableStyle table = new DataGridTableStyle();
      table.MappingName = "data";
      DataGridTextBoxColumn gridTextBoxColumn1 = new DataGridTextBoxColumn();
      DataGridTextBoxColumn gridTextBoxColumn2 = new DataGridTextBoxColumn();
      DataGridTextBoxColumn gridTextBoxColumn3 = new DataGridTextBoxColumn();
      gridTextBoxColumn1.MappingName = "id";
      gridTextBoxColumn1.HeaderText = "ID";
      gridTextBoxColumn1.ReadOnly = true;
      gridTextBoxColumn1.Width = 40;
      gridTextBoxColumn2.MappingName = "Standard";
      gridTextBoxColumn2.HeaderText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[54]);
      gridTextBoxColumn2.ReadOnly = true;
      gridTextBoxColumn2.Width = 350;
      gridTextBoxColumn3.MappingName = "yours";
      gridTextBoxColumn3.HeaderText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[55]);
      gridTextBoxColumn3.ReadOnly = false;
      gridTextBoxColumn3.Width = 350;
      table.GridColumnStyles.Add((DataGridColumnStyle) gridTextBoxColumn1);
      table.GridColumnStyles.Add((DataGridColumnStyle) gridTextBoxColumn2);
      table.GridColumnStyles.Add((DataGridColumnStyle) gridTextBoxColumn3);
      this.DataGrid1.TableStyles.Add(table);
      this.DataGrid1.EndInit();
      this.DataTable1.BeginLoadData();
      Loader loader = new Loader();
      this.DockControl1.TabImage = (Image) null;
      this.DockControl1.TabImage = loader.GetImageFromResource(StringType.FromObject(ClassThisProg.DefReader.LanguageIconArray[ClassThisProg.DefReader.AktuellerLanguageIndex]));
      loader.Dispose();
      int num = checked (ClassThisProg.DefReader.LanguageArray.Count - 1);
      int index = 1;
      while (index <= num)
      {
        if (ObjectType.ObjTst(ClassThisProg.DefReader.DefaultLanguageArray[index], (object) "", false) != 0)
        {
          DataRow row = this.DataTable1.NewRow();
          row["id"] = (object) index;
          row["Standard"] = RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.DefaultLanguageArray[index]);
          row["yours"] = RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[index]);
          this.DataTable1.Rows.Add(row);
        }
        checked { ++index; }
      }
      this.DataTable1.EndLoadData();
      this.DataTable1.AcceptChanges();
      this.isLoading = false;
      object obj;
      return obj;
    }

    public object ReloadData(DataSet TestDataSet)
    {
      int num1 = checked (this.DataTable1.Rows.Count - 1);
      int index1 = 0;
      while (index1 <= num1)
      {
        int num2 = checked (TestDataSet.Tables["data"].Rows.Count - 1);
        int index2 = 0;
        while (index2 <= num2)
        {
          if (ObjectType.ObjTst(this.DataTable1.Rows[index1]["id"], TestDataSet.Tables["data"].Rows[index2]["id"], false) == 0)
          {
            this.DataTable1.Rows[index1]["yours"] = RuntimeHelpers.GetObjectValue(TestDataSet.Tables["data"].Rows[index2]["value"]);
            break;
          }
          checked { ++index2; }
        }
        checked { ++index1; }
      }
      object obj;
      return obj;
    }

    public object SetzeTexte()
    {
      this.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[41]);
      this.DockControl1.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[41]);
      this.DockControl2.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[366]);
      this.ToolButton1.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[3]);
      this.ToolButton2.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[51]);
      this.ToolButton3.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[16]);
      this.ToolButton4.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[17]);
      this.ToolButton5.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[18]);
      this.ToolButton6.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[52]);
      this.BildButton1.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[60]);
      object obj;
      return obj;
    }

    private void FlagCheckBox_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void Form2_Load(object sender, EventArgs e)
    {
      sr_Userinterface.AendereFarben((Form) this, ClassThisProg.DefReader.FarbSchema);
      try
      {
        string str = StringType.FromObject(ClassThisProg.DefReader.LanguageFileArray[ClassThisProg.DefReader.AktuellerLanguageIndex]);
        this.AktuelleLeseDatei = ClassThisProg.DefReader.LanguageDir + "\\" + str + ".xml";
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Dispose();
        ProjectData.ClearProjectError();
      }
      this.FormatDateiDataGrid();
      this.CreateImageCheckBoxes();
      this.SetzeTexte();
      this.SetBoxChecked();
      this.Show();
      this.DocumentContainer1.ActiveDocument = this.DockControl1;
    }

    private void DataTable1_RowChanged(object sender, DataRowChangeEventArgs e)
    {
      if (this.isLoading || e.Row.RowState != DataRowState.Added)
        return;
      e.Row.Delete();
      int num = (int) MessageBox.Show((IWin32Window) this, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[58]), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[57]), MessageBoxButtons.OK, MessageBoxIcon.Hand);
    }

    private void ToolButton3_Activate(object sender, EventArgs e)
    {
      Loader loader = new Loader();
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.RestoreDirectory = false;
      openFileDialog.InitialDirectory = ClassThisProg.DefReader.LanguageDir;
      openFileDialog.Title = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[16]);
      openFileDialog.ShowReadOnly = false;
      openFileDialog.Filter = "xml-Files (*.xml)|*.xml";
      if (openFileDialog.ShowDialog() == DialogResult.OK)
      {
        DataSet TestDataSet = new DataSet();
        this.AktuelleLeseDatei = openFileDialog.FileName;
        if (!ClassThisProg.DefReader.ReadLanguageFile(ref TestDataSet, this.AktuelleLeseDatei))
        {
          int num = (int) MessageBox.Show((IWin32Window) this, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[56]), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[57]), MessageBoxButtons.OK, MessageBoxIcon.Hand);
          return;
        }
        string str = new FileInfo(this.AktuelleLeseDatei).Name.Replace(".xml", "");
        if (ClassThisProg.DefReader.LanguageFileArray.Count > 0)
        {
          int num = checked (ClassThisProg.DefReader.LanguageFileArray.Count - 1);
          int index = 0;
          while (index <= num)
          {
            if (StringType.StrCmp(StringType.FromObject(ClassThisProg.DefReader.LanguageFileArray[index]).ToUpper(), str.ToUpper(), false) == 0)
            {
              if (ObjectType.ObjTst(ClassThisProg.DefReader.LanguageIconArray[index], (object) "", false) != 0)
              {
                this.DockControl1.TabImage = loader.GetImageFromResource(StringType.FromObject(ClassThisProg.DefReader.LanguageIconArray[index]));
                try
                {
                  foreach (Control control in this.FlagPanel.Controls)
                  {
                    if (StringType.StrCmp(control.GetType().ToString(), "System.Windows.Forms.RadioButton", false) == 0)
                    {
                      RadioButton radioButton = (RadioButton) control;
                      if (ObjectType.ObjTst(radioButton.Tag, ClassThisProg.DefReader.LanguageIconArray[index], false) == 0)
                      {
                        radioButton.Checked = true;
                        break;
                      }
                    }
                  }
                }
                finally
                {
                  IEnumerator enumerator;
                  if (enumerator is IDisposable)
                    ((IDisposable) enumerator).Dispose();
                }
                break;
              }
              break;
            }
            checked { ++index; }
          }
        }
        this.ReloadData(TestDataSet);
      }
      loader.Dispose();
    }

    private object SetBoxChecked()
    {
      int aktuellerLanguageIndex = ClassThisProg.DefReader.AktuellerLanguageIndex;
      try
      {
        foreach (Control control in this.FlagPanel.Controls)
        {
          if (StringType.StrCmp(control.GetType().ToString(), "System.Windows.Forms.RadioButton", false) == 0)
          {
            RadioButton radioButton = (RadioButton) control;
            if (ObjectType.ObjTst(radioButton.Tag, (object) ClassThisProg.DefReader.LanguageIconArray[aktuellerLanguageIndex].ToString(), false) == 0)
            {
              radioButton.Checked = true;
              break;
            }
          }
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          ((IDisposable) enumerator).Dispose();
      }
      object obj;
      return obj;
    }

    private void ToolButton4_Activate(object sender, EventArgs e)
    {
      FileInfo fileInfo = new FileInfo(this.AktuelleLeseDatei);
      if (StringType.StrCmp(fileInfo.DirectoryName.ToUpper(), ClassThisProg.DefReader.LanguageDir.ToUpper(), false) != 0)
      {
        string fileName = ClassThisProg.DefReader.LanguageDir + "\\" + fileInfo.Name;
        if (new FileInfo(fileName).Exists && MessageBox.Show((IWin32Window) this, StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(ClassThisProg.DefReader.LanguageArray[2], (object) " "), (object) fileName), (object) " "), ClassThisProg.DefReader.LanguageArray[59])), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[17]), MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
          return;
        this.AktuelleLeseDatei = ClassThisProg.DefReader.LanguageDir + "\\" + fileInfo.Name;
      }
      this.SpeicherDatei();
    }

    private bool SpeicherDatei()
    {
      XmlDataDocument xmlDataDocument = new XmlDataDocument();
      this.Cursor = Cursors.WaitCursor;
      bool flag;
      try
      {
        xmlDataDocument.DataSet.ReadXmlSchema(ClassThisProg.DefReader.XSDSprachDatei);
        this.DataTable1.AcceptChanges();
        int num = checked (this.DataTable1.Rows.Count - 1);
        int index = 0;
        while (index <= num)
        {
          DataRow row = xmlDataDocument.DataSet.Tables["data"].NewRow();
          row["id"] = RuntimeHelpers.GetObjectValue(this.DataTable1.Rows[index]["id"]);
          row["value"] = RuntimeHelpers.GetObjectValue(this.DataTable1.Rows[index]["yours"]);
          xmlDataDocument.DataSet.Tables["data"].Rows.Add(row);
          checked { ++index; }
        }
        xmlDataDocument.Save(this.AktuelleLeseDatei);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Cursor = Cursors.Default;
        flag = false;
        ProjectData.ClearProjectError();
        goto label_7;
      }
      this.SaveLanguageFileAndIcon();
      this.Cursor = Cursors.Default;
label_7:
      return flag;
    }

    private object SaveLanguageFileAndIcon()
    {
      string str = new FileInfo(this.AktuelleLeseDatei).Name.Replace(".xml", "");
      int index;
      if (ClassThisProg.DefReader.LanguageFileArray.Count > 0)
      {
        index = ClassThisProg.DefReader.LanguageFileArray.IndexOf((object) str);
        if (index < 0)
        {
          ClassThisProg.DefReader.LanguageFileArray.Add((object) str);
          ClassThisProg.DefReader.LanguageIconArray.Add((object) "");
          index = checked (ClassThisProg.DefReader.LanguageFileArray.Count - 1);
        }
      }
      else
      {
        ClassThisProg.DefReader.LanguageFileArray.Add((object) str);
        ClassThisProg.DefReader.LanguageIconArray.Add((object) "");
        index = checked (ClassThisProg.DefReader.LanguageFileArray.Count - 1);
      }
      try
      {
        foreach (Control control in this.FlagPanel.Controls)
        {
          if (StringType.StrCmp(control.GetType().ToString(), "System.Windows.Forms.RadioButton", false) == 0)
          {
            RadioButton radioButton = (RadioButton) control;
            if (radioButton.Checked)
            {
              ClassThisProg.DefReader.LanguageIconArray[index] = RuntimeHelpers.GetObjectValue(radioButton.Tag);
              break;
            }
          }
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          ((IDisposable) enumerator).Dispose();
      }
      this.DockControl1.TabImage = (Image) null;
      if (ObjectType.ObjTst(ClassThisProg.DefReader.LanguageIconArray[index], (object) "", false) != 0)
      {
        Loader loader = new Loader();
        this.DockControl1.TabImage = loader.GetImageFromResource(StringType.FromObject(ClassThisProg.DefReader.LanguageIconArray[index]));
        loader.Dispose();
      }
      ClassThisProg.DefReader.AktuellerLanguageIndex = index;
      ClassThisProg.DefReader.SaveSettings();
      object obj;
      return obj;
    }

    private void ToolButton2_Activate(object sender, EventArgs e)
    {
      string sLeft = Interaction.InputBox(StringType.FromObject(ClassThisProg.DefReader.LanguageArray[134]), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[15]));
      if (StringType.StrCmp(sLeft, "", false) == 0)
        return;
      string fileName = ClassThisProg.DefReader.LanguageDir + "\\" + sLeft.Replace(".xml", "") + ".xml";
      if (new FileInfo(fileName).Exists && MessageBox.Show((IWin32Window) this, StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(ClassThisProg.DefReader.LanguageArray[2], (object) " "), (object) fileName), (object) " "), ClassThisProg.DefReader.LanguageArray[59])), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[17]), MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
      this.AktuelleLeseDatei = ClassThisProg.DefReader.LanguageDir + "\\" + sLeft.Replace(".xml", "") + ".xml";
      this.isLoading = true;
      this.DockControl1.TabImage = (Image) null;
      this.DataTable1.Rows.Clear();
      this.DataTable1.AcceptChanges();
      int num = checked (ClassThisProg.DefReader.LanguageArray.Count - 1);
      int index = 1;
      while (index <= num)
      {
        if (ObjectType.ObjTst(ClassThisProg.DefReader.DefaultLanguageArray[index], (object) "", false) != 0)
        {
          DataRow row = this.DataTable1.NewRow();
          row["id"] = (object) index;
          row["Standard"] = RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.DefaultLanguageArray[index]);
          row["yours"] = RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.DefaultLanguageArray[index]);
          this.DataTable1.Rows.Add(row);
        }
        checked { ++index; }
      }
      this.DataTable1.EndLoadData();
      this.DataTable1.AcceptChanges();
      this.isLoading = false;
    }

    private void ToolButton5_Activate(object sender, EventArgs e)
    {
      string sLeft = Interaction.InputBox(StringType.FromObject(ClassThisProg.DefReader.LanguageArray[134]), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[15]));
      if (StringType.StrCmp(sLeft, "", false) == 0)
        return;
      string fileName = ClassThisProg.DefReader.LanguageDir + "\\" + sLeft.Replace(".xml", "") + ".xml";
      if (new FileInfo(fileName).Exists && MessageBox.Show((IWin32Window) this, StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(ClassThisProg.DefReader.LanguageArray[2], (object) " "), (object) fileName), (object) " "), ClassThisProg.DefReader.LanguageArray[59])), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[17]), MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
      this.AktuelleLeseDatei = ClassThisProg.DefReader.LanguageDir + "\\" + sLeft.Replace(".xml", "") + ".xml";
      this.SpeicherDatei();
    }

    private void BildButton1_Activate(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      bool flag = false;
      openFileDialog.RestoreDirectory = false;
      openFileDialog.InitialDirectory = ClassThisProg.DefReader.LanguageDir;
      openFileDialog.Title = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[16]);
      openFileDialog.ShowReadOnly = false;
      openFileDialog.Filter = "Images (*.ico)|*.ICO";
      if (openFileDialog.ShowDialog() != DialogResult.OK)
        return;
      DataSet dataSet = new DataSet();
      Image image = Image.FromFile(openFileDialog.FileName);
      if (image.Height != 16 | image.Width != 16)
      {
        flag = true;
      }
      else
      {
        try
        {
          this.FlagImageList.Images.Add(image);
          ResXResourceWriter resXresourceWriter = new ResXResourceWriter("D:\\simzone\\Version 03.06.2005\\SC4Tool\\bin\\Temp\\Flags.dat");
          resXresourceWriter.AddResource("Icon2", (object) image);
          resXresourceWriter.Close();
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          flag = true;
          ProjectData.ClearProjectError();
        }
      }
      if (flag)
      {
        int num = (int) MessageBox.Show((IWin32Window) this, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[61]), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[57]), MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void ToolButton1_Activate(object sender, EventArgs e) => this.Dispose();

    private void FormLanguage_Closed(object sender, EventArgs e) => ClassThisProg.frmLanguage = (FormLanguage) null;
  }
}
