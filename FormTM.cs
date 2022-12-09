// Decompiled with JetBrains decompiler
// Type: SC4Tool.FormTM
// Assembly: SC4Tool, Version=2.2.7.0, Culture=neutral, PublicKeyToken=null
// MVID: 69A50BC4-87A5-4C5E-BEFC-08274BC6D498
// Assembly location: C:\Program Files (x86)\SC4 Utilities\SC4Tool\SC4Tool.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using sr_SC4Lib;
using System;
using System.Collections;
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
  public class FormTM : Form
  {
    [AccessedThroughProperty("ButtonNew")]
    private ButtonItem _ButtonNew;
    [AccessedThroughProperty("ImageList2")]
    private ImageList _ImageList2;
    [AccessedThroughProperty("Sr_TextureViewer1")]
    private sr_TextureViewer _Sr_TextureViewer1;
    [AccessedThroughProperty("StatusBarPanel2")]
    private StatusBarPanel _StatusBarPanel2;
    [AccessedThroughProperty("ButtonLeave")]
    private ButtonItem _ButtonLeave;
    [AccessedThroughProperty("ButtonDeleteTexture")]
    private ButtonItem _ButtonDeleteTexture;
    [AccessedThroughProperty("ButtonOpen")]
    private ButtonItem _ButtonOpen;
    [AccessedThroughProperty("StatusBarPanel1")]
    private StatusBarPanel _StatusBarPanel1;
    [AccessedThroughProperty("ButtonNewTexture")]
    private ButtonItem _ButtonNewTexture;
    [AccessedThroughProperty("Splitter1")]
    private Splitter _Splitter1;
    [AccessedThroughProperty("TreeView1")]
    private TreeView _TreeView1;
    [AccessedThroughProperty("Panel1")]
    private Panel _Panel1;
    [AccessedThroughProperty("StatusBar1")]
    private StatusBar _StatusBar1;
    [AccessedThroughProperty("ButtonSave")]
    private ButtonItem _ButtonSave;
    [AccessedThroughProperty("ToolBar1")]
    private TD.SandBar.ToolBar _ToolBar1;
    private bool isNewFile;
    private bool HasAddedImages;
    private cTexture ResultTexturen;
    private string CurrentDatei;
    private ArrayList AktuelleSuchIndexes;
    private IContainer components;

    public FormTM()
    {
      this.Load += new EventHandler(this.FormTM_Load);
      this.Closed += new EventHandler(this.FormTM_Closed);
      this.isNewFile = false;
      this.ResultTexturen = new cTexture();
      this.AktuelleSuchIndexes = new ArrayList();
      this.InitializeComponent();
      if (ClassThisProg.DefReader.HasReadTextures || ClassThisProg.frmProgress != null)
        return;
      ClassThisProg.frmProgress = new FormProgress("T");
      ClassThisProg.frmProgress.MdiParent = (Form) ClassThisProg.frmMain;
      int num = (int) ClassThisProg.frmProgress.ShowDialog();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
      ClassThisProg.frmTM = (FormTM) null;
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

    internal virtual ButtonItem ButtonLeave
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ButtonLeave != null)
          this._ButtonLeave.Activate -= new EventHandler(this.ButtonLeave_Activate);
        this._ButtonLeave = value;
        if (this._ButtonLeave == null)
          return;
        this._ButtonLeave.Activate += new EventHandler(this.ButtonLeave_Activate);
      }
      get => this._ButtonLeave;
    }

    internal virtual ButtonItem ButtonOpen
    {
      get => this._ButtonOpen;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ButtonOpen != null)
          this._ButtonOpen.Activate -= new EventHandler(this.ButtonOpen_Activate);
        this._ButtonOpen = value;
        if (this._ButtonOpen == null)
          return;
        this._ButtonOpen.Activate += new EventHandler(this.ButtonOpen_Activate);
      }
    }

    internal virtual ButtonItem ButtonNew
    {
      get => this._ButtonNew;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ButtonNew != null)
          this._ButtonNew.Activate -= new EventHandler(this.ButtonNew_Activate);
        this._ButtonNew = value;
        if (this._ButtonNew == null)
          return;
        this._ButtonNew.Activate += new EventHandler(this.ButtonNew_Activate);
      }
    }

    internal virtual ButtonItem ButtonSave
    {
      get => this._ButtonSave;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ButtonSave != null)
          this._ButtonSave.Activate -= new EventHandler(this.ButtonSave_Activate);
        this._ButtonSave = value;
        if (this._ButtonSave == null)
          return;
        this._ButtonSave.Activate += new EventHandler(this.ButtonSave_Activate);
      }
    }

    internal virtual ButtonItem ButtonNewTexture
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ButtonNewTexture != null)
          this._ButtonNewTexture.Activate -= new EventHandler(this.ButtonNewTexture_Activate);
        this._ButtonNewTexture = value;
        if (this._ButtonNewTexture == null)
          return;
        this._ButtonNewTexture.Activate += new EventHandler(this.ButtonNewTexture_Activate);
      }
      get => this._ButtonNewTexture;
    }

    internal virtual ButtonItem ButtonDeleteTexture
    {
      get => this._ButtonDeleteTexture;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ButtonDeleteTexture != null)
          this._ButtonDeleteTexture.Activate -= new EventHandler(this.ButtonDeleteTexture_Activate);
        this._ButtonDeleteTexture = value;
        if (this._ButtonDeleteTexture == null)
          return;
        this._ButtonDeleteTexture.Activate += new EventHandler(this.ButtonDeleteTexture_Activate);
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

    internal virtual Panel Panel1
    {
      get => this._Panel1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Panel1 != null)
          this._Panel1.Resize -= new EventHandler(this.Panel1_Resize);
        this._Panel1 = value;
        if (this._Panel1 == null)
          return;
        this._Panel1.Resize += new EventHandler(this.Panel1_Resize);
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
      get => this._TreeView1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._TreeView1 != null)
          this._TreeView1.AfterSelect -= new TreeViewEventHandler(this.TreeView1_AfterSelect);
        this._TreeView1 = value;
        if (this._TreeView1 == null)
          return;
        this._TreeView1.AfterSelect += new TreeViewEventHandler(this.TreeView1_AfterSelect);
      }
    }

    internal virtual StatusBarPanel StatusBarPanel1
    {
      get => this._StatusBarPanel1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._StatusBarPanel1 == null)
          ;
        this._StatusBarPanel1 = value;
        if (this._StatusBarPanel1 == null)
          ;
      }
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

    internal virtual ImageList ImageList2
    {
      get => this._ImageList2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ImageList2 == null)
          ;
        this._ImageList2 = value;
        if (this._ImageList2 == null)
          ;
      }
    }

    internal virtual sr_TextureViewer Sr_TextureViewer1
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Sr_TextureViewer1 == null)
          ;
        this._Sr_TextureViewer1 = value;
        if (this._Sr_TextureViewer1 == null)
          ;
      }
      get => this._Sr_TextureViewer1;
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      ResourceManager resourceManager = new ResourceManager(typeof (FormTM));
      this.ToolBar1 = new TD.SandBar.ToolBar();
      this.ImageList2 = new ImageList(this.components);
      this.ButtonLeave = new ButtonItem();
      this.ButtonOpen = new ButtonItem();
      this.ButtonNew = new ButtonItem();
      this.ButtonSave = new ButtonItem();
      this.ButtonNewTexture = new ButtonItem();
      this.ButtonDeleteTexture = new ButtonItem();
      this.StatusBar1 = new StatusBar();
      this.StatusBarPanel1 = new StatusBarPanel();
      this.StatusBarPanel2 = new StatusBarPanel();
      this.Panel1 = new Panel();
      this.TreeView1 = new TreeView();
      this.Splitter1 = new Splitter();
      this.Sr_TextureViewer1 = new sr_TextureViewer();
      this.StatusBarPanel1.BeginInit();
      this.StatusBarPanel2.BeginInit();
      this.Panel1.SuspendLayout();
      this.SuspendLayout();
      this.ToolBar1.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.ToolBar1.Guid = new Guid("bb8bcf92-1062-447f-ab87-3346a8bbdd66");
      this.ToolBar1.ImageList = this.ImageList2;
      this.ToolBar1.Items.AddRange(new ToolbarItemBase[6]
      {
        (ToolbarItemBase) this.ButtonLeave,
        (ToolbarItemBase) this.ButtonOpen,
        (ToolbarItemBase) this.ButtonNew,
        (ToolbarItemBase) this.ButtonSave,
        (ToolbarItemBase) this.ButtonNewTexture,
        (ToolbarItemBase) this.ButtonDeleteTexture
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
      this.ToolBar1.TabIndex = 3;
      this.ToolBar1.Text = "ToolBar1";
      ImageList imageList2 = this.ImageList2;
      size1 = new Size(16, 16);
      Size size3 = size1;
      imageList2.ImageSize = size3;
      this.ImageList2.ImageStream = (ImageListStreamer) resourceManager.GetObject("ImageList2.ImageStream");
      this.ImageList2.TransparentColor = Color.Transparent;
      this.ButtonLeave.BeginGroup = true;
      this.ButtonLeave.ImageIndex = 0;
      this.ButtonOpen.BeginGroup = true;
      this.ButtonOpen.ImageIndex = 4;
      this.ButtonNew.BeginGroup = true;
      this.ButtonNew.ImageIndex = 6;
      this.ButtonSave.BeginGroup = true;
      this.ButtonSave.ImageIndex = 3;
      this.ButtonSave.Visible = false;
      this.ButtonNewTexture.BeginGroup = true;
      this.ButtonNewTexture.ImageIndex = 14;
      this.ButtonNewTexture.Text = "+";
      this.ButtonDeleteTexture.BeginGroup = true;
      this.ButtonDeleteTexture.ImageIndex = 16;
      StatusBar statusBar1_1 = this.StatusBar1;
      point1 = new Point(0, 538);
      Point point3 = point1;
      statusBar1_1.Location = point3;
      this.StatusBar1.Name = "StatusBar1";
      this.StatusBar1.Panels.AddRange(new StatusBarPanel[2]
      {
        this.StatusBarPanel1,
        this.StatusBarPanel2
      });
      this.StatusBar1.ShowPanels = true;
      StatusBar statusBar1_2 = this.StatusBar1;
      size1 = new Size(782, 25);
      Size size4 = size1;
      statusBar1_2.Size = size4;
      this.StatusBar1.TabIndex = 2;
      this.StatusBar1.Text = "StatusBar1";
      this.StatusBarPanel1.MinWidth = 60;
      this.StatusBarPanel1.Text = "Ready";
      this.StatusBarPanel1.Width = 270;
      this.StatusBarPanel2.AutoSize = StatusBarPanelAutoSize.Spring;
      this.StatusBarPanel2.MinWidth = 100;
      this.StatusBarPanel2.Width = 496;
      this.Panel1.Controls.Add((Control) this.TreeView1);
      this.Panel1.Dock = DockStyle.Left;
      Panel panel1_1 = this.Panel1;
      point1 = new Point(0, 24);
      Point point4 = point1;
      panel1_1.Location = point4;
      this.Panel1.Name = "Panel1";
      Panel panel1_2 = this.Panel1;
      size1 = new Size(140, 514);
      Size size5 = size1;
      panel1_2.Size = size5;
      this.Panel1.TabIndex = 5;
      this.TreeView1.Dock = DockStyle.Fill;
      this.TreeView1.ImageIndex = 17;
      this.TreeView1.ImageList = this.ImageList2;
      TreeView treeView1_1 = this.TreeView1;
      point1 = new Point(0, 0);
      Point point5 = point1;
      treeView1_1.Location = point5;
      this.TreeView1.Name = "TreeView1";
      TreeView treeView1_2 = this.TreeView1;
      size1 = new Size(140, 514);
      Size size6 = size1;
      treeView1_2.Size = size6;
      this.TreeView1.TabIndex = 0;
      Splitter splitter1_1 = this.Splitter1;
      point1 = new Point(140, 24);
      Point point6 = point1;
      splitter1_1.Location = point6;
      this.Splitter1.Name = "Splitter1";
      Splitter splitter1_2 = this.Splitter1;
      size1 = new Size(8, 514);
      Size size7 = size1;
      splitter1_2.Size = size7;
      this.Splitter1.TabIndex = 6;
      this.Splitter1.TabStop = false;
      this.Sr_TextureViewer1.Dock = DockStyle.Fill;
      sr_TextureViewer srTextureViewer1_1 = this.Sr_TextureViewer1;
      point1 = new Point(148, 24);
      Point point7 = point1;
      srTextureViewer1_1.Location = point7;
      this.Sr_TextureViewer1.Name = "Sr_TextureViewer1";
      sr_TextureViewer srTextureViewer1_2 = this.Sr_TextureViewer1;
      size1 = new Size(634, 514);
      Size size8 = size1;
      srTextureViewer1_2.Size = size8;
      this.Sr_TextureViewer1.TabIndex = 7;
      size1 = new Size(5, 13);
      this.AutoScaleBaseSize = size1;
      size1 = new Size(782, 563);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.Sr_TextureViewer1);
      this.Controls.Add((Control) this.Splitter1);
      this.Controls.Add((Control) this.Panel1);
      this.Controls.Add((Control) this.StatusBar1);
      this.Controls.Add((Control) this.ToolBar1);
      this.Name = nameof (FormTM);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Texture-Maker";
      this.StatusBarPanel1.EndInit();
      this.StatusBarPanel2.EndInit();
      this.Panel1.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    public object FillFromExtern(string EingabeDatei)
    {
      this.CurrentDatei = EingabeDatei;
      this.GetImagesFromFile();
      object obj;
      return obj;
    }

    private bool GetImagesFromFile()
    {
      this.Cursor = Cursors.WaitCursor;
      this.TreeView1.Nodes.Clear();
      this.Sr_TextureViewer1.Clear();
      this.ResultTexturen.Clear();
      this.StatusBarPanel1.Text = "0 Textures";
      this.StatusBarPanel2.Text = this.CurrentDatei;
      this.ButtonSave.Enabled = false;
      this.ButtonNewTexture.Enabled = true;
      this.ButtonDeleteTexture.Enabled = false;
      this.AktuelleSuchIndexes.Clear();
      if (!ClassThisProg.DefReader.TextureListe.isFileInArray(this.CurrentDatei))
        ClassThisProg.DefReader.TextureListe.GetTextures(this.CurrentDatei);
      this.ResultTexturen = ClassThisProg.DefReader.TextureListe.SelectTexture(this.CurrentDatei);
      if (this.ResultTexturen.Count < 0)
      {
        this.Cursor = Cursors.Default;
      }
      else
      {
        TreeView treeView1 = this.TreeView1;
        treeView1.BeginUpdate();
        treeView1.SuspendLayout();
        treeView1.Enabled = false;
        treeView1.Nodes.Clear();
        treeView1.AllowDrop = false;
        treeView1.CheckBoxes = false;
        treeView1.FullRowSelect = true;
        treeView1.ShowLines = true;
        treeView1.ShowPlusMinus = true;
        treeView1.ShowRootLines = true;
        treeView1.HideSelection = false;
        treeView1.Nodes.Add(new TreeNode()
        {
          Text = "All",
          Tag = (object) "All",
          SelectedImageIndex = 19,
          ImageIndex = 17
        });
        string sLeft = "";
        int num = checked (this.ResultTexturen.Count - 1);
        int number = 0;
        int index;
        while (number <= num)
        {
          if (StringType.StrCmp(sLeft, this.ResultTexturen.get_item(number).Gruppe, false) != 0)
          {
            treeView1.Nodes[0].Nodes.Add(new TreeNode()
            {
              Tag = (object) this.ResultTexturen.get_item(number).Gruppe,
              Text = this.ResultTexturen.get_item(number).Instance,
              SelectedImageIndex = 19,
              ImageIndex = 17
            });
            index = checked (treeView1.Nodes[0].Nodes.Count - 1);
          }
          treeView1.Nodes[0].Nodes[index].Nodes.Add(new TreeNode()
          {
            Tag = (object) number.ToString(),
            Text = this.ResultTexturen.get_item(number).Instance,
            SelectedImageIndex = 19,
            ImageIndex = 17
          });
          sLeft = this.ResultTexturen.get_item(number).Gruppe;
          checked { ++number; }
        }
        treeView1.Nodes[0].Expand();
        treeView1.ResumeLayout();
        treeView1.EndUpdate();
        this.StatusBarPanel1.Text = StringType.FromDouble((double) index + DoubleType.FromString(1.ToString())) + " Textures";
        if (this.ResultTexturen.Count > -1)
          this.ButtonSave.Enabled = true;
        else
          this.ButtonSave.Enabled = false;
        this.ButtonNewTexture.Enabled = true;
        this.TreeView1.Enabled = true;
        this.Cursor = Cursors.Default;
      }
      bool flag;
      return flag;
    }

    private object LoescheTexture()
    {
      bool flag = false;
      if (MessageBox.Show((IWin32Window) this, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[131]), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[132]), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        if (this.AktuelleSuchIndexes.Count > 0)
        {
          cTexture[] DelTexture = new cTexture[checked (this.AktuelleSuchIndexes.Count - 1 + 1)];
          this.AktuelleSuchIndexes.CopyTo((Array) DelTexture);
          flag = new MainWriter()
          {
            LeseDatei = this.CurrentDatei
          }.DeleteTexture(DelTexture);
        }
        if (flag)
        {
          ClassThisProg.DefReader.TextureListe.DeleteTexture(this.CurrentDatei);
          ClassThisProg.DefReader.TextureListe.GetTextures(this.CurrentDatei);
          this.AktuelleSuchIndexes.Clear();
          this.GetImagesFromFile();
          int num = (int) MessageBox.Show((IWin32Window) this, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[133]), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[132]), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        else
        {
          int num1 = (int) MessageBox.Show((IWin32Window) this, StringType.FromObject(ClassThisProg.DefReader.LanguageArray[89]), StringType.FromObject(ClassThisProg.DefReader.LanguageArray[132]), MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
      }
      object obj;
      return obj;
    }

    public object SetzeTexte()
    {
      this.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[434]);
      this.ButtonOpen.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[16]);
      this.ButtonNew.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[51]);
      this.ButtonSave.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[17]);
      this.ButtonLeave.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[3]);
      this.ButtonNewTexture.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[435]);
      this.ButtonDeleteTexture.ToolTipText = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[436]);
      object obj;
      return obj;
    }

    private void FormTM_Load(object sender, EventArgs e)
    {
      sr_Userinterface.AendereFarben((Form) this, ClassThisProg.DefReader.FarbSchema);
      this.StatusBarPanel1.Width = checked ((int) Math.Round(unchecked ((double) this.Panel1.Width + (double) this.Splitter1.Width / 2.0)));
      this.SetzeTexte();
      this.HasAddedImages = false;
      this.CurrentDatei = "";
      this.Sr_TextureViewer1.Clear();
      this.ButtonSave.Enabled = false;
      this.ButtonNewTexture.Enabled = false;
      this.ButtonDeleteTexture.Enabled = false;
    }

    private void FormTM_Closed(object sender, EventArgs e) => ClassThisProg.frmTM = (FormTM) null;

    private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
    {
      this.Sr_TextureViewer1.Clear();
      this.Sr_TextureViewer1.GridNoRedraw();
      if (this.ResultTexturen.Count == 0)
        return;
      this.AktuelleSuchIndexes.Clear();
      this.ButtonDeleteTexture.Enabled = false;
      this.Cursor = Cursors.WaitCursor;
      if (Information.IsNumeric(RuntimeHelpers.GetObjectValue(e.Node.Tag)))
      {
        this.ButtonDeleteTexture.Enabled = false;
        int number1 = IntegerType.FromObject(e.Node.Tag);
        if (Information.IsNothing((object) this.ResultTexturen.get_item(number1).Picture))
        {
          TextureReader textureListe = ClassThisProg.DefReader.TextureListe;
          cTexture resultTexturen = this.ResultTexturen;
          cTexture cTexture1 = resultTexturen;
          int number2 = number1;
          int number3 = number2;
          cTexture cTexture2 = cTexture1.get_item(number3);
          ref cTexture local = ref cTexture2;
          textureListe.GetTextureImage(ref local);
          resultTexturen.set_item(number2, cTexture2);
        }
        if (!Information.IsNothing((object) this.ResultTexturen.get_item(number1).Picture))
          this.Sr_TextureViewer1.AddImage(this.ResultTexturen.get_item(number1));
      }
      else if (ObjectType.ObjTst(e.Node.Tag, (object) "All", false) != 0)
      {
        this.ButtonDeleteTexture.Enabled = true;
        int num = checked (this.ResultTexturen.Count - 1);
        int number4 = 0;
        while (number4 <= num)
        {
          if (ObjectType.ObjTst((object) this.ResultTexturen.get_item(number4).Gruppe, e.Node.Tag, false) == 0)
          {
            this.AktuelleSuchIndexes.Add((object) this.ResultTexturen.get_item(number4));
            if (Information.IsNothing((object) this.ResultTexturen.get_item(number4).Picture))
            {
              TextureReader textureListe = ClassThisProg.DefReader.TextureListe;
              cTexture resultTexturen = this.ResultTexturen;
              cTexture cTexture3 = resultTexturen;
              int number5 = number4;
              int number6 = number5;
              cTexture cTexture4 = cTexture3.get_item(number6);
              ref cTexture local = ref cTexture4;
              textureListe.GetTextureImage(ref local);
              resultTexturen.set_item(number5, cTexture4);
            }
            if (!Information.IsNothing((object) this.ResultTexturen.get_item(number4).Picture))
              this.Sr_TextureViewer1.AddImage(this.ResultTexturen.get_item(number4));
          }
          checked { ++number4; }
        }
      }
      this.Sr_TextureViewer1.GridRedraw();
      this.Cursor = Cursors.Default;
    }

    private void Panel1_Resize(object sender, EventArgs e) => this.StatusBarPanel1.Width = checked ((int) Math.Round(unchecked ((double) this.Panel1.Width + (double) this.Splitter1.Width / 2.0)));

    private object OpenExistingFile()
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.RestoreDirectory = true;
      openFileDialog.CheckFileExists = true;
      openFileDialog.Title = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[16]);
      openFileDialog.ShowReadOnly = true;
      openFileDialog.Filter = "Dat-Files (*.dat)|*.dat";
      if (openFileDialog.ShowDialog() == DialogResult.OK)
      {
        this.HasAddedImages = false;
        this.isNewFile = false;
        this.CurrentDatei = openFileDialog.FileName;
        this.GetImagesFromFile();
      }
      object obj;
      return obj;
    }

    private object OpenNewFile()
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.RestoreDirectory = true;
      openFileDialog.Title = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[16]);
      openFileDialog.CheckFileExists = false;
      openFileDialog.ShowReadOnly = true;
      openFileDialog.Filter = "Dat-Files (*.dat)|*.dat";
      if (openFileDialog.ShowDialog() == DialogResult.OK)
      {
        this.CurrentDatei = openFileDialog.FileName;
        this.HasAddedImages = false;
        if (!new FileInfo(openFileDialog.FileName).Exists)
        {
          this.ResultTexturen.Clear();
          this.StatusBarPanel1.Text = "0 Textures";
          this.StatusBarPanel2.Text = this.CurrentDatei;
          this.ButtonSave.Enabled = false;
          this.ButtonNewTexture.Enabled = true;
          this.ButtonDeleteTexture.Enabled = false;
          this.AktuelleSuchIndexes.Clear();
          this.TreeView1.Nodes.Clear();
          this.Sr_TextureViewer1.Clear();
        }
        else
          this.GetImagesFromFile();
      }
      object obj;
      return obj;
    }

    private object OpenTextureForm()
    {
      cTexture[] cTextureArray = new cTexture[0];
      if (ClassThisProg.frmTextureMaker == null)
      {
        FormTextureMaker formTextureMaker = new FormTextureMaker(this.CurrentDatei, this.isNewFile);
        int num = (int) formTextureMaker.ShowDialog();
        formTextureMaker.Dispose();
        this.GetImagesFromFile();
      }
      object obj;
      return obj;
    }

    private void MenuDateiItem1_Activate(object sender, EventArgs e) => this.OpenExistingFile();

    private void ButtonOpen_Activate(object sender, EventArgs e) => this.OpenExistingFile();

    private void ButtonNew_Activate(object sender, EventArgs e) => this.OpenNewFile();

    private void MenuDateiItem2_Activate(object sender, EventArgs e) => this.OpenNewFile();

    private void ButtonLeave_Activate(object sender, EventArgs e) => this.Dispose();

    private void MenuDateiItem5_Activate(object sender, EventArgs e) => this.Dispose();

    private void ButtonNewTexture_Activate(object sender, EventArgs e) => this.OpenTextureForm();

    private void MenuTextureItem1_Activate(object sender, EventArgs e) => this.OpenTextureForm();

    private void ButtonDeleteTexture_Activate(object sender, EventArgs e) => this.LoescheTexture();

    private void ButtonSave_Activate(object sender, EventArgs e)
    {
    }
  }
}
