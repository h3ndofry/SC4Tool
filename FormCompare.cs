// Decompiled with JetBrains decompiler
// Type: SC4Tool.FormCompare
// Assembly: SC4Tool, Version=2.2.7.0, Culture=neutral, PublicKeyToken=null
// MVID: 69A50BC4-87A5-4C5E-BEFC-08274BC6D498
// Assembly location: C:\Program Files (x86)\SC4 Utilities\SC4Tool\SC4Tool.exe

using sr_SC4Lib;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SC4Tool
{
  public class FormCompare : Form
  {
    [AccessedThroughProperty("Sr_Comparer1")]
    private sr_Comparer _Sr_Comparer1;
    [AccessedThroughProperty("ImageList1")]
    private ImageList _ImageList1;
    private IContainer components;
    private bool isLoading;

    public FormCompare()
    {
      this.Load += new EventHandler(this.FormCompare_Load);
      this.Closed += new EventHandler(this.FormCompare_Closed);
      this.isLoading = true;
      this.InitializeComponent();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
      ClassThisProg.frmCompare = (FormCompare) null;
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

    internal virtual sr_Comparer Sr_Comparer1
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Sr_Comparer1 != null)
        {
          this._Sr_Comparer1.EndRead -= new sr_Comparer.EndReadEventHandler(this.Sr_Comparer1_EndRead);
          this._Sr_Comparer1.StartRead -= new sr_Comparer.StartReadEventHandler(this.Sr_Comparer1_StartRead);
          this._Sr_Comparer1.ExitWork -= new sr_Comparer.ExitWorkEventHandler(this.Sr_Comparer1_ExitWork);
        }
        this._Sr_Comparer1 = value;
        if (this._Sr_Comparer1 == null)
          return;
        this._Sr_Comparer1.EndRead += new sr_Comparer.EndReadEventHandler(this.Sr_Comparer1_EndRead);
        this._Sr_Comparer1.StartRead += new sr_Comparer.StartReadEventHandler(this.Sr_Comparer1_StartRead);
        this._Sr_Comparer1.ExitWork += new sr_Comparer.ExitWorkEventHandler(this.Sr_Comparer1_ExitWork);
      }
      get => this._Sr_Comparer1;
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      ResourceManager resourceManager = new ResourceManager(typeof (FormCompare));
      this.ImageList1 = new ImageList(this.components);
      this.Sr_Comparer1 = new sr_Comparer();
      this.SuspendLayout();
      ImageList imageList1 = this.ImageList1;
      Size size1 = new Size(16, 16);
      Size size2 = size1;
      imageList1.ImageSize = size2;
      this.ImageList1.ImageStream = (ImageListStreamer) resourceManager.GetObject("ImageList1.ImageStream");
      this.ImageList1.TransparentColor = Color.Transparent;
      this.Sr_Comparer1.Dock = DockStyle.Fill;
      this.Sr_Comparer1.Location = new Point(0, 0);
      this.Sr_Comparer1.Name = "Sr_Comparer1";
      this.Sr_Comparer1.SC4LocalPath = "";
      this.Sr_Comparer1.SC4Path = "";
      sr_Comparer srComparer1 = this.Sr_Comparer1;
      size1 = new Size(782, 557);
      Size size3 = size1;
      srComparer1.Size = size3;
      this.Sr_Comparer1.TabIndex = 0;
      size1 = new Size(5, 13);
      this.AutoScaleBaseSize = size1;
      size1 = new Size(782, 557);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.Sr_Comparer1);
      this.Name = nameof (FormCompare);
      this.Text = "Comparer";
      this.ResumeLayout(false);
    }

    public object SetzeTexte()
    {
      this.Sr_Comparer1.LanguageArray = ClassThisProg.DefReader.LanguageArray;
      object obj;
      return obj;
    }

    private void FormCompare_Load(object sender, EventArgs e)
    {
      sr_Userinterface.AendereFarben((Form) this, ClassThisProg.DefReader.FarbSchema);
      this.Sr_Comparer1.SC4Path = ClassThisProg.DefReader.SC4Path;
      this.Sr_Comparer1.SC4LocalPath = ClassThisProg.DefReader.sc4LocalPath;
      this.Sr_Comparer1.PropXMLReader = ClassThisProg.DefReader.PropXMLReader;
      this.Sr_Comparer1.ComparerDataTable = ClassThisProg.DefReader.ComparerDataTable;
      this.Sr_Comparer1.CreateBackup = ClassThisProg.DefReader.CreateBackup;
      this.SetzeTexte();
    }

    private void FormCompare_Closed(object sender, EventArgs e) => ClassThisProg.frmCompare = (FormCompare) null;

    private void ButtonEnd_Activate(object sender, EventArgs e) => this.Dispose();

    private void Sr_Comparer1_ExitWork() => this.Dispose();

    private void Sr_Comparer1_StartRead() => this.Cursor = Cursors.WaitCursor;

    private void Sr_Comparer1_EndRead() => this.Cursor = Cursors.Default;
  }
}
