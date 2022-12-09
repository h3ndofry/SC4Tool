// Decompiled with JetBrains decompiler
// Type: SC4Tool.FormMaskedInput
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
  public class FormMaskedInput : Form
  {
    [AccessedThroughProperty("Button1")]
    private Button _Button1;
    [AccessedThroughProperty("ErrorProvider1")]
    private ErrorProvider _ErrorProvider1;
    [AccessedThroughProperty("Button2")]
    private Button _Button2;
    [AccessedThroughProperty("Label2")]
    private Label _Label2;
    [AccessedThroughProperty("TextBox1")]
    private TextBox _TextBox1;
    [AccessedThroughProperty("TextBox2")]
    private TextBox _TextBox2;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    private string OrgWert1;
    private string OrgWert2;
    private IContainer components;

    public FormMaskedInput(string Wert1, string Wert2)
    {
      this.Load += new EventHandler(this.FormMaskedInput_Load);
      this.Closed += new EventHandler(this.FormMaskedInput_Closed);
      this.InitializeComponent();
      this.TextBox1.Text = Wert1;
      this.TextBox2.Text = Wert2;
      this.OrgWert1 = Wert1;
      this.OrgWert2 = Wert2;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
      ClassThisProg.frmMaskedInput = (FormMaskedInput) null;
    }

    internal virtual TextBox TextBox1
    {
      get => this._TextBox1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._TextBox1 != null)
          this._TextBox1.Validating -= new CancelEventHandler(this.TextBox1_Validating);
        this._TextBox1 = value;
        if (this._TextBox1 == null)
          return;
        this._TextBox1.Validating += new CancelEventHandler(this.TextBox1_Validating);
      }
    }

    internal virtual TextBox TextBox2
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._TextBox2 != null)
          this._TextBox2.Validating -= new CancelEventHandler(this.TextBox2_Validating);
        this._TextBox2 = value;
        if (this._TextBox2 == null)
          return;
        this._TextBox2.Validating += new CancelEventHandler(this.TextBox2_Validating);
      }
      get => this._TextBox2;
    }

    internal virtual Button Button1
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

    internal virtual Button Button2
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Button2 != null)
          this._Button2.Click -= new EventHandler(this.Button2_Click);
        this._Button2 = value;
        if (this._Button2 == null)
          return;
        this._Button2.Click += new EventHandler(this.Button2_Click);
      }
      get => this._Button2;
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

    internal virtual ErrorProvider ErrorProvider1
    {
      get => this._ErrorProvider1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ErrorProvider1 == null)
          ;
        this._ErrorProvider1 = value;
        if (this._ErrorProvider1 == null)
          ;
      }
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.TextBox1 = new TextBox();
      this.TextBox2 = new TextBox();
      this.Button1 = new Button();
      this.Button2 = new Button();
      this.Label1 = new Label();
      this.Label2 = new Label();
      this.ErrorProvider1 = new ErrorProvider();
      this.SuspendLayout();
      TextBox textBox1_1 = this.TextBox1;
      Point point1 = new Point(116, 28);
      Point point2 = point1;
      textBox1_1.Location = point2;
      this.TextBox1.MaxLength = 10;
      this.TextBox1.Name = "TextBox1";
      TextBox textBox1_2 = this.TextBox1;
      Size size1 = new Size(104, 21);
      Size size2 = size1;
      textBox1_2.Size = size2;
      this.TextBox1.TabIndex = 0;
      this.TextBox1.Text = "";
      TextBox textBox2_1 = this.TextBox2;
      point1 = new Point(116, 60);
      Point point3 = point1;
      textBox2_1.Location = point3;
      this.TextBox2.MaxLength = 10;
      this.TextBox2.Name = "TextBox2";
      TextBox textBox2_2 = this.TextBox2;
      size1 = new Size(104, 21);
      Size size3 = size1;
      textBox2_2.Size = size3;
      this.TextBox2.TabIndex = 1;
      this.TextBox2.Text = "";
      Button button1_1 = this.Button1;
      point1 = new Point(12, 108);
      Point point4 = point1;
      button1_1.Location = point4;
      this.Button1.Name = "Button1";
      Button button1_2 = this.Button1;
      size1 = new Size(96, 36);
      Size size4 = size1;
      button1_2.Size = size4;
      this.Button1.TabIndex = 2;
      this.Button1.Text = "OK";
      this.Button2.DialogResult = DialogResult.Cancel;
      Button button2_1 = this.Button2;
      point1 = new Point(124, 108);
      Point point5 = point1;
      button2_1.Location = point5;
      this.Button2.Name = "Button2";
      Button button2_2 = this.Button2;
      size1 = new Size(96, 36);
      Size size5 = size1;
      button2_2.Size = size5;
      this.Button2.TabIndex = 3;
      this.Button2.Text = "Button2";
      Label label1_1 = this.Label1;
      point1 = new Point(8, 60);
      Point point6 = point1;
      label1_1.Location = point6;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      size1 = new Size(96, 20);
      Size size6 = size1;
      label1_2.Size = size6;
      this.Label1.TabIndex = 4;
      this.Label1.Text = "Capacity";
      this.Label1.TextAlign = ContentAlignment.MiddleLeft;
      Label label2_1 = this.Label2;
      point1 = new Point(8, 28);
      Point point7 = point1;
      label2_1.Location = point7;
      this.Label2.Name = "Label2";
      Label label2_2 = this.Label2;
      size1 = new Size(96, 20);
      Size size7 = size1;
      label2_2.Size = size7;
      this.Label2.TabIndex = 5;
      this.Label2.Text = "Entry Cost";
      this.Label2.TextAlign = ContentAlignment.MiddleLeft;
      this.ErrorProvider1.ContainerControl = (ContainerControl) this;
      this.AcceptButton = (IButtonControl) this.Button1;
      size1 = new Size(6, 14);
      this.AutoScaleBaseSize = size1;
      this.CancelButton = (IButtonControl) this.Button2;
      size1 = new Size(244, 149);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.Button2);
      this.Controls.Add((Control) this.Button1);
      this.Controls.Add((Control) this.TextBox2);
      this.Controls.Add((Control) this.TextBox1);
      this.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (FormMaskedInput);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.ResumeLayout(false);
    }

    public object SetzeTexte()
    {
      this.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[427]);
      this.Label1.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[426]);
      this.Label2.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[425]);
      this.Button2.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[390]);
      object obj;
      return obj;
    }

    private void TextBox1_Validating(object sender, CancelEventArgs e)
    {
      try
      {
        Decimal d1 = Decimal.Parse(this.TextBox1.Text);
        if (Decimal.Compare(d1, 0M) >= 0 && Decimal.Compare(d1, 100000M) <= 0)
          return;
        this.ErrorProvider1.SetError((Control) this.TextBox1, "!");
        e.Cancel = true;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        e.Cancel = true;
        ProjectData.ClearProjectError();
      }
    }

    private void TextBox2_Validating(object sender, CancelEventArgs e)
    {
      try
      {
        Decimal d1 = Decimal.Parse(this.TextBox2.Text);
        if (Decimal.Compare(d1, 0M) >= 0 && Decimal.Compare(d1, 100000M) <= 0)
          return;
        this.ErrorProvider1.SetError((Control) this.TextBox2, "!");
        e.Cancel = true;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        e.Cancel = true;
        ProjectData.ClearProjectError();
      }
    }

    private void FormMaskedInput_Load(object sender, EventArgs e) => this.SetzeTexte();

    private void FormMaskedInput_Closed(object sender, EventArgs e) => ClassThisProg.frmMaskedInput = (FormMaskedInput) null;

    private void Button1_Click(object sender, EventArgs e) => this.DialogResult = DialogResult.OK;

    private void Button2_Click(object sender, EventArgs e) => this.DialogResult = DialogResult.Cancel;
  }
}
