// Decompiled with JetBrains decompiler
// Type: SC4Tool.FormFileMerger
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
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SC4Tool
{
  public class FormFileMerger : Form
  {
    [AccessedThroughProperty("Sr_FileMerger1")]
    private sr_FileMerger _Sr_FileMerger1;
    private IContainer components;

    public FormFileMerger()
    {
      this.Load += new EventHandler(this.FormFileMerger_Load);
      this.InitializeComponent();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
      ClassThisProg.frmMerger = (FormFileMerger) null;
    }

    internal virtual sr_FileMerger Sr_FileMerger1
    {
      get => this._Sr_FileMerger1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Sr_FileMerger1 != null)
        {
          this._Sr_FileMerger1.ExitWork -= new sr_FileMerger.ExitWorkEventHandler(this.Sr_FileMerger1_ExitWork);
          this._Sr_FileMerger1.EndRead -= new sr_FileMerger.EndReadEventHandler(this.Sr_FileMerger1_EndRead);
          this._Sr_FileMerger1.StartRead -= new sr_FileMerger.StartReadEventHandler(this.Sr_FileMerger1_StartRead);
        }
        this._Sr_FileMerger1 = value;
        if (this._Sr_FileMerger1 == null)
          return;
        this._Sr_FileMerger1.ExitWork += new sr_FileMerger.ExitWorkEventHandler(this.Sr_FileMerger1_ExitWork);
        this._Sr_FileMerger1.EndRead += new sr_FileMerger.EndReadEventHandler(this.Sr_FileMerger1_EndRead);
        this._Sr_FileMerger1.StartRead += new sr_FileMerger.StartReadEventHandler(this.Sr_FileMerger1_StartRead);
      }
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.Sr_FileMerger1 = new sr_FileMerger();
      this.SuspendLayout();
      this.Sr_FileMerger1.Cursor = Cursors.Default;
      this.Sr_FileMerger1.Dock = DockStyle.Fill;
      this.Sr_FileMerger1.Location = new Point(0, 0);
      this.Sr_FileMerger1.Name = "Sr_FileMerger1";
      sr_FileMerger srFileMerger1 = this.Sr_FileMerger1;
      Size size1 = new Size(782, 563);
      Size size2 = size1;
      srFileMerger1.Size = size2;
      this.Sr_FileMerger1.TabIndex = 0;
      size1 = new Size(5, 13);
      this.AutoScaleBaseSize = size1;
      size1 = new Size(782, 563);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.Sr_FileMerger1);
      this.Name = nameof (FormFileMerger);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Merger";
      this.ResumeLayout(false);
    }

    private void FormFileMerger_Load(object sender, EventArgs e)
    {
      ArrayList arrayList = new ArrayList();
      this.SetzeTexte();
      arrayList.Add((object) ".DAT");
      arrayList.Add((object) ".SC4LOT");
      arrayList.Add((object) ".SC4DESC");
      arrayList.Add((object) ".SC4MODEL");
      this.Sr_FileMerger1.PatternList = arrayList;
      this.Sr_FileMerger1.CreateBackup = ClassThisProg.DefReader.CreateBackup;
      if (Information.IsNothing((object) ClassThisProg.DefReader.sc4LocalPath) || StringType.StrCmp(ClassThisProg.DefReader.sc4LocalPath, "", false) == 0)
        return;
      this.Sr_FileMerger1.StartupDirectory = ClassThisProg.DefReader.sc4LocalPath;
    }

    public object SetzeTexte()
    {
      this.Sr_FileMerger1.LanguageArray = ClassThisProg.DefReader.LanguageArray;
      object obj;
      return obj;
    }

    private void Sr_FileMerger1_StartRead() => this.Cursor = Cursors.WaitCursor;

    private void Sr_FileMerger1_EndRead() => this.Cursor = Cursors.Default;

    private void Sr_FileMerger1_ExitWork() => this.Dispose();
  }
}
