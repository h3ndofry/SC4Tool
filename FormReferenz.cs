// Decompiled with JetBrains decompiler
// Type: SC4Tool.FormReferenz
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
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using TD.Eyefinder;
using TD.SandBar;

namespace SC4Tool
{
  public class FormReferenz : Form
  {
    [AccessedThroughProperty("ButtonItem2")]
    private ButtonItem _ButtonItem2;
    [AccessedThroughProperty("TreeView1")]
    private TreeView _TreeView1;
    [AccessedThroughProperty("HeaderControl2")]
    private HeaderControl _HeaderControl2;
    [AccessedThroughProperty("Panel1")]
    private Panel _Panel1;
    [AccessedThroughProperty("ToolBar1")]
    private TD.SandBar.ToolBar _ToolBar1;
    [AccessedThroughProperty("AusgabeGrid")]
    private C1.Win.C1FlexGrid.C1FlexGrid _AusgabeGrid;
    [AccessedThroughProperty("ButtonItem1")]
    private ButtonItem _ButtonItem1;
    [AccessedThroughProperty("ImageList1")]
    private ImageList _ImageList1;
    [AccessedThroughProperty("Splitter1")]
    private Splitter _Splitter1;
    private MainReader.Exemplar[] NewExemplarB;
    private ArrayList MainArtListe;
    private ArrayList MainAusgabeListe;
    private IContainer components;

    public FormReferenz()
    {
      this.Load += new EventHandler(this.FormReferenz_Load);
      this.Closed += new EventHandler(this.FormReferenz_Closed);
      this.MainArtListe = new ArrayList();
      this.MainAusgabeListe = new ArrayList();
      this.InitializeComponent();
      C1.Win.C1FlexGrid.C1FlexGrid ausgabeGrid = this.AusgabeGrid;
      ausgabeGrid.AllowDragging = AllowDraggingEnum.None;
      ausgabeGrid.AllowSorting = AllowSortingEnum.None;
      ausgabeGrid.AllowMerging = AllowMergingEnum.Free;
      ausgabeGrid.AllowEditing = false;
      ausgabeGrid.AllowResizing = AllowResizingEnum.Columns;
      ausgabeGrid.Styles.Add("ShowBoolean");
      ausgabeGrid.Styles["ShowBoolean"].DataType = System.Type.GetType("System.Boolean");
      ausgabeGrid.Styles["ShowBoolean"].ImageAlign = ImageAlignEnum.CenterCenter;
      ausgabeGrid.Styles.Add("LeftText");
      ausgabeGrid.Styles["LeftText"].TextAlign = TextAlignEnum.LeftCenter;
      ausgabeGrid.Styles.Add("BoldText");
      ausgabeGrid.Styles["BoldText"].TextAlign = TextAlignEnum.LeftCenter;
      ausgabeGrid.Styles["BoldText"].Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ausgabeGrid.Styles.Add("RightImage");
      ausgabeGrid.Styles["RightImage"].ImageAlign = ImageAlignEnum.RightCenter;
      ausgabeGrid.Styles.Add("CenterImage");
      ausgabeGrid.Styles["CenterImage"].ImageAlign = ImageAlignEnum.CenterCenter;
      ausgabeGrid.Styles.Add("LeftImage");
      ausgabeGrid.Styles["LeftImage"].ImageAlign = ImageAlignEnum.LeftCenter;
      ausgabeGrid.Styles["LeftImage"].TextAlign = TextAlignEnum.LeftCenter;
      ausgabeGrid.Styles["LeftImage"].Font = new Font("Arial", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ausgabeGrid.Styles["LeftImage"].BackColor = Color.SteelBlue;
      ausgabeGrid.Styles["LeftImage"].ForeColor = Color.White;
      ausgabeGrid.Styles.Add("LeftImage_1");
      ausgabeGrid.Styles["LeftImage_1"].ImageAlign = ImageAlignEnum.LeftCenter;
      ausgabeGrid.Styles["LeftImage_1"].TextAlign = TextAlignEnum.LeftCenter;
      ausgabeGrid.Styles.Add("TopText");
      ausgabeGrid.Styles["TopText"].TextAlign = TextAlignEnum.CenterCenter;
      ausgabeGrid.Styles["TopText"].BackColor = Color.SteelBlue;
      ausgabeGrid.Styles["TopText"].ForeColor = Color.White;
      ausgabeGrid.HighLight = HighLightEnum.WithFocus;
      ausgabeGrid.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
      ausgabeGrid.ScrollBars = ScrollBars.Both;
      ausgabeGrid.Styles.Fixed.BackColor = Color.SteelBlue;
      ausgabeGrid.Styles.Fixed.ForeColor = Color.White;
      ausgabeGrid.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter;
      ausgabeGrid.Styles.Fixed.TextEffect = TextEffectEnum.Flat;
      ausgabeGrid.Styles.Fixed.Border.Color = Color.White;
      ausgabeGrid.Styles.Fixed.Font = this.Font;
      ausgabeGrid.Styles.Frozen.Font = this.Font;
      ausgabeGrid.Styles.Normal.Font = this.Font;
      ausgabeGrid.Styles.Normal.TextAlign = TextAlignEnum.CenterCenter;
      ausgabeGrid.Styles.Alternate.BackColor = ausgabeGrid.Styles.Frozen.BackColor;
      ausgabeGrid.Cols.Count = 7;
      ausgabeGrid.Rows.Count = 0;
      ausgabeGrid.Cols.Fixed = 0;
      ausgabeGrid.Cols.Frozen = 0;
      ausgabeGrid.Cols.MaxSize = 0;
      ausgabeGrid.Cols.MinSize = 0;
      ausgabeGrid.Rows.Fixed = 0;
      ausgabeGrid.Cols[0].Width = 250;
      ausgabeGrid.Cols[1].Width = 120;
      ausgabeGrid.Cols[2].Width = 120;
      ausgabeGrid.Cols[3].Width = 120;
      ausgabeGrid.Cols[4].Width = 120;
      ausgabeGrid.Cols[5].Width = 120;
      ausgabeGrid.Cols[6].Width = 120;
      ausgabeGrid.SelectionMode = SelectionModeEnum.Cell;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
      ClassThisProg.frmReferenz = (FormReferenz) null;
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

    internal virtual Panel Panel1
    {
      get => this._Panel1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Panel1 == null)
          ;
        this._Panel1 = value;
        if (this._Panel1 == null)
          ;
      }
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

    internal virtual TreeView TreeView1
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._TreeView1 != null)
          this._TreeView1.AfterSelect -= new TreeViewEventHandler(this.TreeView1_AfterSelect);
        this._TreeView1 = value;
        if (this._TreeView1 == null)
          return;
        this._TreeView1.AfterSelect += new TreeViewEventHandler(this.TreeView1_AfterSelect);
      }
      get => this._TreeView1;
    }

    internal virtual HeaderControl HeaderControl2
    {
      get => this._HeaderControl2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._HeaderControl2 == null)
          ;
        this._HeaderControl2 = value;
        if (this._HeaderControl2 == null)
          ;
      }
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

    internal virtual ButtonItem ButtonItem1
    {
      get => this._ButtonItem1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ButtonItem1 != null)
          this._ButtonItem1.Activate -= new EventHandler(this.ButtonItem1_Activate);
        this._ButtonItem1 = value;
        if (this._ButtonItem1 == null)
          return;
        this._ButtonItem1.Activate += new EventHandler(this.ButtonItem1_Activate);
      }
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

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      ResourceManager resourceManager = new ResourceManager(typeof (FormReferenz));
      this.ToolBar1 = new TD.SandBar.ToolBar();
      this.ImageList1 = new ImageList(this.components);
      this.ButtonItem1 = new ButtonItem();
      this.ButtonItem2 = new ButtonItem();
      this.Panel1 = new Panel();
      this.TreeView1 = new TreeView();
      this.Splitter1 = new Splitter();
      this.HeaderControl2 = new HeaderControl();
      this.AusgabeGrid = new C1.Win.C1FlexGrid.C1FlexGrid();
      this.Panel1.SuspendLayout();
      this.HeaderControl2.SuspendLayout();
      this.AusgabeGrid.BeginInit();
      this.SuspendLayout();
      this.ToolBar1.Guid = new Guid("5be4e4e2-41ac-4599-a58e-470a417c0e68");
      this.ToolBar1.ImageList = this.ImageList1;
      this.ToolBar1.Items.AddRange(new ToolbarItemBase[2]
      {
        (ToolbarItemBase) this.ButtonItem1,
        (ToolbarItemBase) this.ButtonItem2
      });
      TD.SandBar.ToolBar toolBar1_1 = this.ToolBar1;
      Point point1 = new Point(0, 0);
      Point point2 = point1;
      toolBar1_1.Location = point2;
      this.ToolBar1.Name = "ToolBar1";
      TD.SandBar.ToolBar toolBar1_2 = this.ToolBar1;
      Size size1 = new Size(782, 24);
      Size size2 = size1;
      toolBar1_2.Size = size2;
      this.ToolBar1.TabIndex = 0;
      this.ToolBar1.Text = "ToolBar1";
      ImageList imageList1 = this.ImageList1;
      size1 = new Size(16, 16);
      Size size3 = size1;
      imageList1.ImageSize = size3;
      this.ImageList1.ImageStream = (ImageListStreamer) resourceManager.GetObject("ImageList1.ImageStream");
      this.ImageList1.TransparentColor = Color.Transparent;
      this.ButtonItem1.BeginGroup = true;
      this.ButtonItem1.ImageIndex = 0;
      this.ButtonItem2.BeginGroup = true;
      this.ButtonItem2.ImageIndex = 11;
      this.Panel1.Controls.Add((Control) this.TreeView1);
      this.Panel1.Dock = DockStyle.Left;
      Panel panel1_1 = this.Panel1;
      point1 = new Point(0, 24);
      Point point3 = point1;
      panel1_1.Location = point3;
      this.Panel1.Name = "Panel1";
      Panel panel1_2 = this.Panel1;
      size1 = new Size(200, 539);
      Size size4 = size1;
      panel1_2.Size = size4;
      this.Panel1.TabIndex = 1;
      this.TreeView1.Dock = DockStyle.Fill;
      this.TreeView1.ImageIndex = -1;
      TreeView treeView1_1 = this.TreeView1;
      point1 = new Point(0, 0);
      Point point4 = point1;
      treeView1_1.Location = point4;
      this.TreeView1.Name = "TreeView1";
      this.TreeView1.SelectedImageIndex = -1;
      TreeView treeView1_2 = this.TreeView1;
      size1 = new Size(200, 539);
      Size size5 = size1;
      treeView1_2.Size = size5;
      this.TreeView1.TabIndex = 0;
      Splitter splitter1_1 = this.Splitter1;
      point1 = new Point(200, 24);
      Point point5 = point1;
      splitter1_1.Location = point5;
      this.Splitter1.Name = "Splitter1";
      Splitter splitter1_2 = this.Splitter1;
      size1 = new Size(8, 539);
      Size size6 = size1;
      splitter1_2.Size = size6;
      this.Splitter1.TabIndex = 2;
      this.Splitter1.TabStop = false;
      this.HeaderControl2.Controls.Add((Control) this.AusgabeGrid);
      this.HeaderControl2.Dock = DockStyle.Fill;
      this.HeaderControl2.HeaderFont = new Font("Tahoma", 12f, FontStyle.Bold);
      HeaderControl headerControl2_1 = this.HeaderControl2;
      point1 = new Point(208, 24);
      Point point6 = point1;
      headerControl2_1.Location = point6;
      this.HeaderControl2.Name = "HeaderControl2";
      HeaderControl headerControl2_2 = this.HeaderControl2;
      size1 = new Size(574, 539);
      Size size7 = size1;
      headerControl2_2.Size = size7;
      this.HeaderControl2.TabIndex = 3;
      this.HeaderControl2.Text = "<....>";
      this.AusgabeGrid.ColumnInfo = "10,1,0,0,0,85,Columns:";
      this.AusgabeGrid.Dock = DockStyle.Fill;
      C1.Win.C1FlexGrid.C1FlexGrid ausgabeGrid1 = this.AusgabeGrid;
      point1 = new Point(1, 26);
      Point point7 = point1;
      ausgabeGrid1.Location = point7;
      this.AusgabeGrid.Name = "AusgabeGrid";
      this.AusgabeGrid.Rows.DefaultSize = 17;
      C1.Win.C1FlexGrid.C1FlexGrid ausgabeGrid2 = this.AusgabeGrid;
      size1 = new Size(572, 512);
      Size size8 = size1;
      ausgabeGrid2.Size = size8;
      this.AusgabeGrid.Styles = new CellStyleCollection("");
      this.AusgabeGrid.TabIndex = 0;
      size1 = new Size(5, 13);
      this.AutoScaleBaseSize = size1;
      size1 = new Size(782, 563);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.HeaderControl2);
      this.Controls.Add((Control) this.Splitter1);
      this.Controls.Add((Control) this.Panel1);
      this.Controls.Add((Control) this.ToolBar1);
      this.Name = nameof (FormReferenz);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = nameof (FormReferenz);
      this.Panel1.ResumeLayout(false);
      this.HeaderControl2.ResumeLayout(false);
      this.AusgabeGrid.EndInit();
      this.ResumeLayout(false);
    }

    private object LeseDaten(string LeseDatei)
    {
      MainReader mainReader = new MainReader();
      this.Cursor = Cursors.WaitCursor;
      mainReader.EingabeDatei = LeseDatei;
      if (!mainReader.StartRead())
      {
        int num = (int) MessageBox.Show((IWin32Window) this, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[67]), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[17]), MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.Cursor = Cursors.Default;
        Application.DoEvents();
      }
      else if (mainReader.IndexEntries.Count == 0)
      {
        int num = (int) MessageBox.Show((IWin32Window) this, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[68]), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[17]), MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.Cursor = Cursors.Default;
        Application.DoEvents();
      }
      else
      {
        int num1 = checked (mainReader.IndexEntries.Count - 1);
        int num2 = 0;
        while (num2 <= num1)
        {
          string str1 = AllgemeineKlasse.FormatiereHexWert(LateBinding.LateGet(mainReader.IndexEntries[num2], (System.Type) null, "Type", new object[0], (string[]) null, (bool[]) null).ToString());
          string str2 = AllgemeineKlasse.FormatiereHexWert(LateBinding.LateGet(mainReader.IndexEntries[num2], (System.Type) null, "Group", new object[0], (string[]) null, (bool[]) null).ToString());
          string str3 = AllgemeineKlasse.FormatiereHexWert(LateBinding.LateGet(mainReader.IndexEntries[num2], (System.Type) null, "Instance", new object[0], (string[]) null, (bool[]) null).ToString());
          str1 + "," + str2 + "," + str3;
          if (ObjectType.ObjTst(LateBinding.LateGet(mainReader.IndexEntries[num2], (System.Type) null, "FileTyp", new object[0], (string[]) null, (bool[]) null), (object) "Exemplar", false) == 0)
          {
            MainReader.Exemplar NewExemplar = new MainReader.Exemplar();
            NewExemplar.OrdnungsIndex = -1;
            NewExemplar.ExemplarTyp = "";
            NewExemplar.LotResKey = "";
            NewExemplar.Type = str1;
            NewExemplar.Group = str2;
            NewExemplar.Instance = str3;
            NewExemplar.Values = new ArrayList();
            byte[] bytesOfFile = mainReader.GetBytesOfFile(num2);
            mainReader.ReadExemplar(ref NewExemplar, bytesOfFile, checked (bytesOfFile.GetUpperBound(0) - 1));
            this.NewExemplarB = (MainReader.Exemplar[]) Utils.CopyArray((Array) this.NewExemplarB, (Array) new MainReader.Exemplar[checked (this.NewExemplarB.GetUpperBound(0) + 1 + 1)]);
            this.NewExemplarB[this.NewExemplarB.GetUpperBound(0)] = NewExemplar;
          }
          checked { ++num2; }
        }
        TreeView treeView1 = this.TreeView1;
        treeView1.Nodes.Clear();
        treeView1.ImageList = this.ImageList1;
        treeView1.Nodes.Clear();
        treeView1.AllowDrop = false;
        treeView1.CheckBoxes = false;
        treeView1.FullRowSelect = true;
        treeView1.ShowLines = true;
        treeView1.ShowPlusMinus = true;
        treeView1.ShowRootLines = true;
        treeView1.HideSelection = false;
        treeView1.SuspendLayout();
        treeView1.BeginUpdate();
        int num3 = checked (this.MainArtListe.Count - 1);
        int index1 = 0;
        while (index1 <= num3)
        {
          treeView1.Nodes.Add(new TreeNode()
          {
            Tag = (object) "X",
            Text = StringType.FromObject(this.MainAusgabeListe[index1]),
            ImageIndex = 18,
            SelectedImageIndex = 17
          });
          checked { ++index1; }
        }
        if (this.NewExemplarB.GetUpperBound(0) > -1)
        {
          int lowerBound = this.NewExemplarB.GetLowerBound(0);
          int upperBound = this.NewExemplarB.GetUpperBound(0);
          int index2 = lowerBound;
          while (index2 <= upperBound)
          {
            int index3 = this.MainArtListe.IndexOf((object) this.NewExemplarB[index2].ExemplarName.Substring(0, 2).ToUpper());
            if (index3 == -1)
              index3 = checked (this.MainArtListe.Count - 1);
            string exemplarName = this.NewExemplarB[index2].ExemplarName;
            string[] strArray = this.NewExemplarB[index2].ExemplarName.Split('_');
            if (strArray.GetUpperBound(0) == 2)
              exemplarName = strArray[1];
            treeView1.Nodes[index3].Nodes.Add(new TreeNode()
            {
              Tag = (object) index2.ToString(),
              Text = exemplarName,
              ImageIndex = 18,
              SelectedImageIndex = 17
            });
            checked { ++index2; }
          }
        }
        treeView1.EndUpdate();
        mainReader.Dispose();
        this.Cursor = Cursors.Default;
      }
      object obj;
      return obj;
    }

    private object ShowTabellenWerte(DataRow[] ResultRows, ArrayList TempArray, int ExemplarIndex)
    {
      try
      {
        string dateiName = this.NewExemplarB[ExemplarIndex].DateiName;
        int lowerBound = ResultRows.GetLowerBound(0);
        int upperBound = ResultRows.GetUpperBound(0);
        int index1 = lowerBound;
        while (index1 <= upperBound)
        {
          int index2 = TempArray.IndexOf((object) ResultRows[index1]["member"].ToString().ToUpper());
          if (index2 > -1)
            MainFunctionClass.GebePropertyAus(this.AusgabeGrid, (MainReader.ExemplarValues) (this.NewExemplarB[ExemplarIndex].Values[index2] ?? Activator.CreateInstance(typeof (MainReader.ExemplarValues))), ClassThisProg.DefReader.PropXMLReader, dateiName, 0);
          checked { ++index1; }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.AusgabeGrid.Rows.Add();
        this.AusgabeGrid[checked (this.AusgabeGrid.Rows.Count - 1), 0] = (object) "Error";
        ProjectData.ClearProjectError();
      }
      object obj;
      return obj;
    }

    private object ShowBuilding(int ExemplarIndex)
    {
      ArrayList TempArray = new ArrayList();
      ArrayList arrayList = new ArrayList();
      this.AusgabeGrid.Rows.Count = 0;
      if (this.NewExemplarB[ExemplarIndex].Values.Count > 0)
      {
        int num = checked (this.NewExemplarB[ExemplarIndex].Values.Count - 1);
        int index = 0;
        while (index <= num)
        {
          TempArray.Add(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(this.NewExemplarB[ExemplarIndex].Values[index], (System.Type) null, "Kennung", new object[0], (string[]) null, (bool[]) null), (System.Type) null, "toupper", new object[0], (string[]) null, (bool[]) null)));
          checked { ++index; }
        }
      }
      if (ClassThisProg.DefReader.GroupDefDataView.Table.Rows.Count > 0)
      {
        int num1 = checked (ClassThisProg.DefReader.GroupDefDataView.Table.Rows.Count - 1);
        int index1 = 0;
        while (index1 <= num1)
        {
          arrayList.Clear();
          bool flag = false;
          string filterExpression = StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj((object) "group = '", ClassThisProg.DefReader.GroupDefDataView.Table.Rows[index1]["name"]), (object) "'"));
          DataRow[] ResultRows = ClassThisProg.DefReader.GroupMemberDataTable.Select(filterExpression);
          if (ResultRows.GetUpperBound(0) > -1)
          {
            int lowerBound = ResultRows.GetLowerBound(0);
            int upperBound = ResultRows.GetUpperBound(0);
            int index2 = lowerBound;
            while (index2 <= upperBound)
            {
              int num2 = checked (TempArray.Count - 1);
              int num3 = 0;
              while (num3 <= num2)
              {
                if (TempArray.IndexOf((object) ResultRows[index2]["member"].ToString().ToUpper()) > -1)
                {
                  arrayList.Add((object) ResultRows[index2]["member"].ToString());
                  flag = true;
                  break;
                }
                checked { ++num3; }
              }
              checked { ++index2; }
            }
            if (arrayList.Count > 0)
            {
              if (arrayList.Count == 1)
              {
                if (ClassThisProg.DefReader.ExcludeList.IndexOf((object) arrayList[0].ToString().ToUpper()) > -1)
                  flag = false;
              }
              else if (arrayList.Count == 2 && ClassThisProg.DefReader.ExcludeList.IndexOf((object) arrayList[0].ToString().ToUpper()) > -1 && ClassThisProg.DefReader.ExcludeList.IndexOf((object) arrayList[1].ToString().ToUpper()) > -1)
                flag = false;
              if (flag)
              {
                string str = StringType.FromObject(ClassThisProg.DefReader.GroupDefDataView.Table.Rows[index1]["Image"]);
                MainFunctionClass.WriteThemenHeader(this.AusgabeGrid, ClassThisProg.DefReader.ProgImageDir + "\\" + str, StringType.FromObject(ClassThisProg.DefReader.GroupDefDataView.Table.Rows[index1]["desc"]));
                this.ShowTabellenWerte(ResultRows, TempArray, ExemplarIndex);
              }
            }
          }
          checked { ++index1; }
        }
      }
      object obj;
      return obj;
    }

    public object SetzeTexte()
    {
      this.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[312]);
      this.ButtonItem1.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[3]);
      this.ButtonItem2.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[63]);
      this.MainArtListe.Add((object) "CV");
      this.MainArtListe.Add((object) "RW");
      this.MainArtListe.Add((object) "PZ");
      this.MainArtListe.Add((object) "UW");
      this.MainArtListe.Add((object) "UP");
      this.MainArtListe.Add((object) "US");
      this.MainArtListe.Add((object) "UT");
      this.MainArtListe.Add((object) "LM");
      this.MainAusgabeListe.Add(RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[380]));
      this.MainAusgabeListe.Add(RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[381]));
      this.MainAusgabeListe.Add(RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[382]));
      this.MainAusgabeListe.Add(RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[383]));
      this.MainAusgabeListe.Add(RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[384]));
      this.MainAusgabeListe.Add(RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[201]));
      this.MainAusgabeListe.Add(RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[202]));
      this.MainAusgabeListe.Add(RuntimeHelpers.GetObjectValue(ClassThisProg.DefReader.LanguageArray[385]));
      object obj;
      return obj;
    }

    private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
    {
      if (!Information.IsNumeric(RuntimeHelpers.GetObjectValue(e.Node.Tag)))
        return;
      this.Cursor = Cursors.WaitCursor;
      int ExemplarIndex = IntegerType.FromObject(e.Node.Tag);
      if (ExemplarIndex <= this.NewExemplarB.GetUpperBound(0))
      {
        this.ShowBuilding(ExemplarIndex);
        this.HeaderControl2.Text = e.Node.Text;
      }
      this.Cursor = Cursors.Default;
    }

    private void FormReferenz_Load(object sender, EventArgs e)
    {
      MemoryStream memoryStream = new MemoryStream();
      sr_Userinterface.AendereFarben((Form) this, ClassThisProg.DefReader.FarbSchema);
      this.SetzeTexte();
      this.NewExemplarB = new MainReader.Exemplar[0];
      if (StringType.StrCmp(ClassThisProg.DefReader.SC4RefDatei, "", false) != 0)
        this.LeseDaten(ClassThisProg.DefReader.SC4RefDatei);
      this.Show();
    }

    private void ButtonItem1_Activate(object sender, EventArgs e) => this.Dispose();

    private void ButtonItem2_Activate(object sender, EventArgs e)
    {
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      if (this.AusgabeGrid.Rows.Count > 0)
      {
        saveFileDialog.Filter = "htm (*.htm)|*.htm";
        saveFileDialog.InitialDirectory = ClassThisProg.DefReader.ExportDir;
        saveFileDialog.CheckPathExists = true;
        saveFileDialog.CheckFileExists = false;
        saveFileDialog.AddExtension = true;
        saveFileDialog.Title = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[18]);
        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
          try
          {
            FileInfo fileInfo = new FileInfo(saveFileDialog.FileName);
            DirectoryInfo directoryInfo = new DirectoryInfo(fileInfo.FullName.Replace(fileInfo.Name, "") + "\\" + fileInfo.Name.Replace(fileInfo.Extension, "") + "_images");
            if (!directoryInfo.Exists)
            {
              directoryInfo.Create();
            }
            else
            {
              FileInfo[] files = directoryInfo.GetFiles("*.*");
              int index = 0;
              while (index < files.Length)
              {
                files[index].Delete();
                checked { ++index; }
              }
            }
            string fullName1 = fileInfo.FullName;
            string fullName2 = directoryInfo.FullName;
            new FileStream(fullName1, FileMode.Create, FileAccess.Write).Close();
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            int num = (int) MessageBox.Show((IWin32Window) this, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[64]), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[17]), MessageBoxButtons.OK, MessageBoxIcon.Hand);
            ProjectData.ClearProjectError();
            return;
          }
          int num1 = (int) MessageBox.Show((IWin32Window) this, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[65]), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[17]), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
      }
    }

    private void FormReferenz_Closed(object sender, EventArgs e) => ClassThisProg.frmReferenz = (FormReferenz) null;
  }
}
