// Decompiled with JetBrains decompiler
// Type: SC4Tool.PropViewForm
// Assembly: SC4Tool, Version=2.2.7.0, Culture=neutral, PublicKeyToken=null
// MVID: 69A50BC4-87A5-4C5E-BEFC-08274BC6D498
// Assembly location: C:\Program Files (x86)\SC4 Utilities\SC4Tool\SC4Tool.exe

using Microsoft.VisualBasic.CompilerServices;
using sr_SC4Lib;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SC4Tool
{
  public class PropViewForm : Form
  {
    [AccessedThroughProperty("Sr_xmlEditor1")]
    private sr_xmlEditor _Sr_xmlEditor1;
    private IContainer components;

    public PropViewForm()
    {
      this.Load += new EventHandler(this.PropViewForm_Load);
      this.Closed += new EventHandler(this.PropViewForm_Closed);
      this.InitializeComponent();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
      ClassThisProg.frmProp = (PropViewForm) null;
    }

    internal virtual sr_xmlEditor Sr_xmlEditor1
    {
      get => this._Sr_xmlEditor1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Sr_xmlEditor1 != null)
          this._Sr_xmlEditor1.ExitWork -= new sr_xmlEditor.ExitWorkEventHandler(this.Sr_xmlEditor1_ExitWork);
        this._Sr_xmlEditor1 = value;
        if (this._Sr_xmlEditor1 == null)
          return;
        this._Sr_xmlEditor1.ExitWork += new sr_xmlEditor.ExitWorkEventHandler(this.Sr_xmlEditor1_ExitWork);
      }
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.Sr_xmlEditor1 = new sr_xmlEditor();
      this.SuspendLayout();
      this.Sr_xmlEditor1.Dock = DockStyle.Fill;
      this.Sr_xmlEditor1.Location = new Point(0, 0);
      this.Sr_xmlEditor1.Name = "Sr_xmlEditor1";
      sr_xmlEditor srXmlEditor1 = this.Sr_xmlEditor1;
      Size size1 = new Size(782, 563);
      Size size2 = size1;
      srXmlEditor1.Size = size2;
      this.Sr_xmlEditor1.TabIndex = 0;
      this.Sr_xmlEditor1.xmlDatei = "";
      this.Sr_xmlEditor1.xsdDatei = "";
      size1 = new Size(5, 13);
      this.AutoScaleBaseSize = size1;
      size1 = new Size(782, 563);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.Sr_xmlEditor1);
      this.Name = nameof (PropViewForm);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = nameof (PropViewForm);
      this.ResumeLayout(false);
    }

    public object SetzeTexte()
    {
      this.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[395]);
      this.Sr_xmlEditor1.LanguageArray = ClassThisProg.DefReader.LanguageArray;
      object obj;
      return obj;
    }

    private void PropViewForm_Load(object sender, EventArgs e)
    {
      sr_Userinterface.AendereFarben((Form) this, ClassThisProg.DefReader.FarbSchema);
      this.SetzeTexte();
      this.Sr_xmlEditor1.xmlDatei = ClassThisProg.DefReader.PropertiesXMLDatei;
      this.Sr_xmlEditor1.xsdDatei = ClassThisProg.DefReader.PropertiesXSDDatei;
      this.Sr_xmlEditor1.Start();
    }

    private void PropViewForm_Closed(object sender, EventArgs e) => ClassThisProg.frmProp = (PropViewForm) null;

    private void Sr_xmlEditor1_ExitWork() => this.Dispose();
  }
}
