// Decompiled with JetBrains decompiler
// Type: SC4Tool.FormEditor
// Assembly: SC4Tool, Version=2.2.7.0, Culture=neutral, PublicKeyToken=null
// MVID: 69A50BC4-87A5-4C5E-BEFC-08274BC6D498
// Assembly location: C:\Program Files (x86)\SC4 Utilities\SC4Tool\SC4Tool.exe

using Microsoft.VisualBasic.CompilerServices;
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
  public class FormEditor : Form
  {
    [AccessedThroughProperty("ImageList1")]
    private ImageList _ImageList1;
    [AccessedThroughProperty("Sr_NewValueEditor1")]
    private sr_NewValueEditor _Sr_NewValueEditor1;
    private IContainer components;

    public FormEditor()
    {
      this.Load += new EventHandler(this.FormEditor_Load);
      this.Closed += new EventHandler(this.FormEditor_Closed);
      this.InitializeComponent();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
      ClassThisProg.frmEditor = (FormEditor) null;
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

    internal virtual sr_NewValueEditor Sr_NewValueEditor1
    {
      get => this._Sr_NewValueEditor1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Sr_NewValueEditor1 != null)
        {
          this._Sr_NewValueEditor1.EndRead -= new sr_NewValueEditor.EndReadEventHandler(this.Sr_NewValueEditor1_EndRead);
          this._Sr_NewValueEditor1.StartRead -= new sr_NewValueEditor.StartReadEventHandler(this.Sr_NewValueEditor1_StartRead);
          this._Sr_NewValueEditor1.ExitWork -= new sr_NewValueEditor.ExitWorkEventHandler(this.Sr_NewValueEditor1_ExitWork);
        }
        this._Sr_NewValueEditor1 = value;
        if (this._Sr_NewValueEditor1 == null)
          return;
        this._Sr_NewValueEditor1.EndRead += new sr_NewValueEditor.EndReadEventHandler(this.Sr_NewValueEditor1_EndRead);
        this._Sr_NewValueEditor1.StartRead += new sr_NewValueEditor.StartReadEventHandler(this.Sr_NewValueEditor1_StartRead);
        this._Sr_NewValueEditor1.ExitWork += new sr_NewValueEditor.ExitWorkEventHandler(this.Sr_NewValueEditor1_ExitWork);
      }
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      ResourceManager resourceManager = new ResourceManager(typeof (FormEditor));
      this.ImageList1 = new ImageList(this.components);
      this.Sr_NewValueEditor1 = new sr_NewValueEditor();
      this.SuspendLayout();
      ImageList imageList1 = this.ImageList1;
      Size size1 = new Size(16, 16);
      Size size2 = size1;
      imageList1.ImageSize = size2;
      this.ImageList1.ImageStream = (ImageListStreamer) resourceManager.GetObject("ImageList1.ImageStream");
      this.ImageList1.TransparentColor = Color.Transparent;
      this.Sr_NewValueEditor1.Dock = DockStyle.Fill;
      this.Sr_NewValueEditor1.Location = new Point(0, 0);
      this.Sr_NewValueEditor1.Name = "Sr_NewValueEditor1";
      this.Sr_NewValueEditor1.PropXMLReader = (sr_PropertyXMLReader) null;
      sr_NewValueEditor srNewValueEditor1 = this.Sr_NewValueEditor1;
      size1 = new Size(782, 563);
      Size size3 = size1;
      srNewValueEditor1.Size = size3;
      this.Sr_NewValueEditor1.TabIndex = 0;
      size1 = new Size(6, 14);
      this.AutoScaleBaseSize = size1;
      size1 = new Size(782, 563);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.Sr_NewValueEditor1);
      this.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Name = nameof (FormEditor);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = nameof (FormEditor);
      this.ResumeLayout(false);
    }

    public object SetzeTexte()
    {
      this.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[502]);
      this.Sr_NewValueEditor1.LanguageArray = ClassThisProg.DefReader.LanguageArray;
      object obj;
      return obj;
    }

    private void FormEditor_Load(object sender, EventArgs e)
    {
      sr_Userinterface.AendereFarben((Form) this, ClassThisProg.DefReader.FarbSchema);
      this.SetzeTexte();
      this.Sr_NewValueEditor1.PropXMLReader = ClassThisProg.DefReader.PropXMLReader;
      this.Sr_NewValueEditor1.CreateBackup = ClassThisProg.DefReader.CreateBackup;
      this.Sr_NewValueEditor1.isBSCUser = ClassThisProg.DefReader.isBSCUser;
    }

    private void FormEditor_Closed(object sender, EventArgs e)
    {
      if (this.Sr_NewValueEditor1.hasChanges)
        this.Sr_NewValueEditor1.AskForSaving();
      ClassThisProg.frmEditor = (FormEditor) null;
    }

    private void Sr_NewValueEditor1_ExitWork() => this.Dispose();

    private void Sr_NewValueEditor1_StartRead() => this.Cursor = Cursors.WaitCursor;

    private void Sr_NewValueEditor1_EndRead() => this.Cursor = Cursors.Default;
  }
}
