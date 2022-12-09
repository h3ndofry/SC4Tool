// Decompiled with JetBrains decompiler
// Type: SC4Tool.FormTransitSwitch
// Assembly: SC4Tool, Version=2.2.7.0, Culture=neutral, PublicKeyToken=null
// MVID: 69A50BC4-87A5-4C5E-BEFC-08274BC6D498
// Assembly location: C:\Program Files (x86)\SC4 Utilities\SC4Tool\SC4Tool.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SC4Tool
{
  public class FormTransitSwitch : Form
  {
    [AccessedThroughProperty("SwitchGrid4")]
    private SwitchGrid _SwitchGrid4;
    [AccessedThroughProperty("Button1")]
    private Button _Button1;
    [AccessedThroughProperty("TextBox1")]
    private TextBox _TextBox1;
    [AccessedThroughProperty("Button2")]
    private Button _Button2;
    [AccessedThroughProperty("SwitchGrid1")]
    private SwitchGrid _SwitchGrid1;
    private IContainer components;

    public FormTransitSwitch(string EingabeString)
    {
      this.Load += new EventHandler(this.FormTransitSwitch_Load);
      this.Closed += new EventHandler(this.FormTransitSwitch_Closed);
      this.InitializeComponent();
      this.SwitchGrid4.SetzeTexte(ClassThisProg.DefReader.LanguageArray);
      if (StringType.StrCmp(EingabeString, "", false) == 0)
        return;
      string[] strArray = EingabeString.Split(',');
      if (strArray.GetUpperBound(0) == 3)
      {
        this.SwitchGrid4.Art = strArray[0];
        this.SwitchGrid4.DirectionString = strArray[1];
        this.SwitchGrid4.InsideString = strArray[2];
        this.SwitchGrid4.OutString = strArray[3];
      }
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
      ClassThisProg.frmTransitSwitch = (FormTransitSwitch) null;
    }

    internal virtual SwitchGrid SwitchGrid1
    {
      get => this._SwitchGrid1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._SwitchGrid1 == null)
          ;
        this._SwitchGrid1 = value;
        if (this._SwitchGrid1 == null)
          ;
      }
    }

    internal virtual Button Button1
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

    internal virtual Button Button2
    {
      get => this._Button2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Button2 != null)
          this._Button2.Click -= new EventHandler(this.Button2_Click);
        this._Button2 = value;
        if (this._Button2 == null)
          return;
        this._Button2.Click += new EventHandler(this.Button2_Click);
      }
    }

    internal virtual TextBox TextBox1
    {
      get => this._TextBox1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._TextBox1 == null)
          ;
        this._TextBox1 = value;
        if (this._TextBox1 == null)
          ;
      }
    }

    internal virtual SwitchGrid SwitchGrid4
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._SwitchGrid4 == null)
          ;
        this._SwitchGrid4 = value;
        if (this._SwitchGrid4 == null)
          ;
      }
      get => this._SwitchGrid4;
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.Button1 = new Button();
      this.Button2 = new Button();
      this.TextBox1 = new TextBox();
      this.SwitchGrid4 = new SwitchGrid();
      this.SuspendLayout();
      Button button1_1 = this.Button1;
      Point point1 = new Point(368, 12);
      Point point2 = point1;
      button1_1.Location = point2;
      this.Button1.Name = "Button1";
      Button button1_2 = this.Button1;
      Size size1 = new Size(96, 40);
      Size size2 = size1;
      button1_2.Size = size2;
      this.Button1.TabIndex = 6;
      this.Button1.Text = "OK";
      this.Button2.DialogResult = DialogResult.Cancel;
      Button button2_1 = this.Button2;
      point1 = new Point(368, 56);
      Point point3 = point1;
      button2_1.Location = point3;
      this.Button2.Name = "Button2";
      Button button2_2 = this.Button2;
      size1 = new Size(96, 40);
      Size size3 = size1;
      button2_2.Size = size3;
      this.Button2.TabIndex = 7;
      this.Button2.Text = "Button2";
      TextBox textBox1_1 = this.TextBox1;
      point1 = new Point(384, 108);
      Point point4 = point1;
      textBox1_1.Location = point4;
      this.TextBox1.Name = "TextBox1";
      TextBox textBox1_2 = this.TextBox1;
      size1 = new Size(76, 21);
      Size size4 = size1;
      textBox1_2.Size = size4;
      this.TextBox1.TabIndex = 8;
      this.TextBox1.Text = "";
      this.TextBox1.Visible = false;
      this.SwitchGrid4.Art = "0x00000081";
      this.SwitchGrid4.DirectionString = "0x00000040";
      this.SwitchGrid4.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.SwitchGrid4.InsideString = "0x00000000";
      SwitchGrid switchGrid4_1 = this.SwitchGrid4;
      point1 = new Point(12, 12);
      Point point5 = point1;
      switchGrid4_1.Location = point5;
      this.SwitchGrid4.Name = "SwitchGrid4";
      this.SwitchGrid4.OutString = "0x00000000";
      SwitchGrid switchGrid4_2 = this.SwitchGrid4;
      size1 = new Size(336, 164);
      Size size5 = size1;
      switchGrid4_2.Size = size5;
      this.SwitchGrid4.TabIndex = 9;
      this.AcceptButton = (IButtonControl) this.Button1;
      size1 = new Size(6, 14);
      this.AutoScaleBaseSize = size1;
      this.CancelButton = (IButtonControl) this.Button2;
      size1 = new Size(476, 181);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.SwitchGrid4);
      this.Controls.Add((Control) this.TextBox1);
      this.Controls.Add((Control) this.Button2);
      this.Controls.Add((Control) this.Button1);
      this.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (FormTransitSwitch);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Transit Switch Point";
      this.ResumeLayout(false);
    }

    public object SetzeTexte()
    {
      this.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[424]);
      this.Button2.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[390]);
      object obj;
      return obj;
    }

    private void FormTransitSwitch_Load(object sender, EventArgs e) => this.SetzeTexte();

    private void FormTransitSwitch_Closed(object sender, EventArgs e) => ClassThisProg.frmTransitSwitch = (FormTransitSwitch) null;

    private void Button1_Click(object sender, EventArgs e)
    {
      this.TextBox1.Text = this.SwitchGrid4.Ergebnis;
      this.DialogResult = DialogResult.OK;
    }

    private void Button2_Click(object sender, EventArgs e) => this.DialogResult = DialogResult.Cancel;
  }
}
