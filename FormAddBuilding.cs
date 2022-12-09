// Decompiled with JetBrains decompiler
// Type: SC4Tool.FormAddBuilding
// Assembly: SC4Tool, Version=2.2.7.0, Culture=neutral, PublicKeyToken=null
// MVID: 69A50BC4-87A5-4C5E-BEFC-08274BC6D498
// Assembly location: C:\Program Files (x86)\SC4 Utilities\SC4Tool\SC4Tool.exe

using Microsoft.VisualBasic.CompilerServices;
using sr_SC4Lib;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SC4Tool
{
  public class FormAddBuilding : Form
  {
    [AccessedThroughProperty("CheckedListBox1")]
    private CheckedListBox _CheckedListBox1;
    [AccessedThroughProperty("Button1")]
    private Button _Button1;
    [AccessedThroughProperty("Open_File")]
    private PictureBox _Open_File;
    [AccessedThroughProperty("Button2")]
    private Button _Button2;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    private IContainer components;
    private string SuchTyp;
    private SC4FileStorer ExemplarListe;
    private FormAddBuilding.eMouseState MouseState;
    public cLot ResultLot;
    public cBuilding ResultBuilding;

    public FormAddBuilding(string Type)
    {
      this.Load += new EventHandler(this.FormAddBuilding_Load);
      this.SuchTyp = "Lot";
      this.MouseState = FormAddBuilding.eMouseState.NoMouse;
      this.InitializeComponent();
      if (StringType.StrCmp(Type.ToUpper(), "Lot", false) == 0)
      {
        this.SuchTyp = "Lot";
      }
      else
      {
        if (StringType.StrCmp(Type.ToUpper(), "BUILDING", false) != 0)
          return;
        this.SuchTyp = "Building";
      }
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    internal virtual CheckedListBox CheckedListBox1
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._CheckedListBox1 != null)
          this._CheckedListBox1.SelectedIndexChanged -= new EventHandler(this.CheckedListBox1_SelectedIndexChanged);
        this._CheckedListBox1 = value;
        if (this._CheckedListBox1 == null)
          return;
        this._CheckedListBox1.SelectedIndexChanged += new EventHandler(this.CheckedListBox1_SelectedIndexChanged);
      }
      get => this._CheckedListBox1;
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
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Label1 == null)
          ;
        this._Label1 = value;
        if (this._Label1 == null)
          ;
      }
      get => this._Label1;
    }

    internal virtual PictureBox Open_File
    {
      get => this._Open_File;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Open_File != null)
        {
          this._Open_File.MouseLeave -= new EventHandler(this.Open_File_MouseLeave);
          this._Open_File.MouseEnter -= new EventHandler(this.Open_File_MouseEnter);
          this._Open_File.Click -= new EventHandler(this.Open_File_Click);
          this._Open_File.MouseDown -= new MouseEventHandler(this.Open_File_MouseDown);
          this._Open_File.MouseUp -= new MouseEventHandler(this.Open_File_MouseUp);
          this._Open_File.Paint -= new PaintEventHandler(this.Open_File_Paint);
        }
        this._Open_File = value;
        if (this._Open_File == null)
          return;
        this._Open_File.MouseLeave += new EventHandler(this.Open_File_MouseLeave);
        this._Open_File.MouseEnter += new EventHandler(this.Open_File_MouseEnter);
        this._Open_File.Click += new EventHandler(this.Open_File_Click);
        this._Open_File.MouseDown += new MouseEventHandler(this.Open_File_MouseDown);
        this._Open_File.MouseUp += new MouseEventHandler(this.Open_File_MouseUp);
        this._Open_File.Paint += new PaintEventHandler(this.Open_File_Paint);
      }
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      ResourceManager resourceManager = new ResourceManager(typeof (FormAddBuilding));
      this.CheckedListBox1 = new CheckedListBox();
      this.Button1 = new Button();
      this.Button2 = new Button();
      this.Label1 = new Label();
      this.Open_File = new PictureBox();
      this.SuspendLayout();
      this.CheckedListBox1.CheckOnClick = true;
      CheckedListBox checkedListBox1_1 = this.CheckedListBox1;
      Point point1 = new Point(8, 56);
      Point point2 = point1;
      checkedListBox1_1.Location = point2;
      this.CheckedListBox1.Name = "CheckedListBox1";
      CheckedListBox checkedListBox1_2 = this.CheckedListBox1;
      Size size1 = new Size(336, 139);
      Size size2 = size1;
      checkedListBox1_2.Size = size2;
      this.CheckedListBox1.TabIndex = 0;
      Button button1_1 = this.Button1;
      point1 = new Point(376, 16);
      Point point3 = point1;
      button1_1.Location = point3;
      this.Button1.Name = "Button1";
      Button button1_2 = this.Button1;
      size1 = new Size(104, 32);
      Size size3 = size1;
      button1_2.Size = size3;
      this.Button1.TabIndex = 1;
      this.Button1.Text = "OK";
      Button button2_1 = this.Button2;
      point1 = new Point(376, 56);
      Point point4 = point1;
      button2_1.Location = point4;
      this.Button2.Name = "Button2";
      Button button2_2 = this.Button2;
      size1 = new Size(104, 32);
      Size size4 = size1;
      button2_2.Size = size4;
      this.Button2.TabIndex = 2;
      this.Button2.Text = "Cancel";
      this.Label1.BackColor = SystemColors.ActiveCaptionText;
      Label label1_1 = this.Label1;
      point1 = new Point(16, 16);
      Point point5 = point1;
      label1_1.Location = point5;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      size1 = new Size(296, 24);
      Size size5 = size1;
      label1_2.Size = size5;
      this.Label1.TabIndex = 3;
      this.Label1.TextAlign = ContentAlignment.MiddleLeft;
      this.Open_File.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Open_File.Image = (Image) resourceManager.GetObject("Open_File.Image");
      PictureBox openFile1 = this.Open_File;
      point1 = new Point(320, 16);
      Point point6 = point1;
      openFile1.Location = point6;
      this.Open_File.Name = "Open_File";
      PictureBox openFile2 = this.Open_File;
      size1 = new Size(16, 16);
      Size size6 = size1;
      openFile2.Size = size6;
      this.Open_File.TabIndex = 180;
      this.Open_File.TabStop = false;
      size1 = new Size(5, 13);
      this.AutoScaleBaseSize = size1;
      size1 = new Size(488, 205);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.Open_File);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.Button2);
      this.Controls.Add((Control) this.Button1);
      this.Controls.Add((Control) this.CheckedListBox1);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (FormAddBuilding);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = nameof (FormAddBuilding);
      this.ResumeLayout(false);
    }

    private object PaintPictureBox(PictureBox m_PictureBox, PaintEventArgs e)
    {
      Color color1 = SystemColors.ControlLight;
      Color color2 = SystemColors.ControlDark;
      if (this.MouseState == FormAddBuilding.eMouseState.NoMouse)
      {
        color1 = SystemColors.Control;
        color2 = SystemColors.Control;
      }
      if (this.MouseState == FormAddBuilding.eMouseState.MouseOver)
      {
        color1 = SystemColors.ControlLight;
        color2 = SystemColors.ControlDark;
      }
      if (this.MouseState == FormAddBuilding.eMouseState.MouseDown)
      {
        color1 = SystemColors.ControlDark;
        color2 = SystemColors.ControlLight;
      }
      Pen pen1 = new Pen(color1, 1f);
      Pen pen2 = new Pen(color2, 1f);
      RectangleF rectangleF = new RectangleF(0.0f, 0.0f, (float) m_PictureBox.Width, (float) m_PictureBox.Height);
      RectangleF clipBounds = e.Graphics.ClipBounds;
      e.Graphics.Clear(SystemColors.Control);
      e.Graphics.DrawLine(pen1, 0.0f, 0.0f, 0.0f, rectangleF.Height);
      e.Graphics.DrawLine(pen1, 0.0f, 0.0f, rectangleF.Width, 0.0f);
      e.Graphics.DrawLine(pen2, 0.0f, rectangleF.Height - 1f, rectangleF.Width, rectangleF.Height - 1f);
      e.Graphics.DrawLine(pen2, rectangleF.Width - 1f, 0.0f, rectangleF.Width - 1f, rectangleF.Height);
      e.Graphics.DrawImage(m_PictureBox.Image, 2, 2);
      pen1.Dispose();
      pen2.Dispose();
      object obj;
      return obj;
    }

    private object LeseDaten(object EingabeDatei)
    {
      this.ExemplarListe = new SC4FileStorer();
      Application.DoEvents();
      this.ExemplarListe.GetOneFile(StringType.FromObject(EingabeDatei));
      if (StringType.StrCmp(this.SuchTyp, "Lot", false) == 0)
      {
        if (this.ExemplarListe.LotContains.Count > 0)
        {
          int num = checked (this.ExemplarListe.LotContains.Count - 1);
          int number = 0;
          while (number <= num)
          {
            this.CheckedListBox1.Items.Add((object) this.ExemplarListe.LotContains.get_item(number).ExemplarName);
            checked { ++number; }
          }
        }
      }
      else if (StringType.StrCmp(this.SuchTyp, "Building", false) == 0 && this.ExemplarListe.BuildingContains.Count > 0)
      {
        int num = checked (this.ExemplarListe.BuildingContains.Count - 1);
        int number = 0;
        while (number <= num)
        {
          this.CheckedListBox1.Items.Add((object) this.ExemplarListe.BuildingContains.get_item(number).ExemplarName);
          checked { ++number; }
        }
      }
      object obj;
      return obj;
    }

    private void Open_File_Paint(object sender, PaintEventArgs e) => this.PaintPictureBox(this.Open_File, e);

    private void Open_File_MouseUp(object sender, MouseEventArgs e)
    {
      this.MouseState = FormAddBuilding.eMouseState.MouseOver;
      this.Open_File.Refresh();
    }

    private void Open_File_MouseDown(object sender, MouseEventArgs e)
    {
      this.MouseState = FormAddBuilding.eMouseState.MouseDown;
      this.Open_File.Refresh();
    }

    private void Open_File_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.RestoreDirectory = true;
      openFileDialog.Title = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[16]);
      openFileDialog.ShowReadOnly = true;
      openFileDialog.Filter = "SC4-Files (*.dat;*.sc4Lot;*.sc4desc)|*.dat;*.sc4Lot;*.sc4desc|All (*.*)|*.*";
      if (openFileDialog.ShowDialog() != DialogResult.OK)
        return;
      this.Label1.Text = new FileInfo(openFileDialog.FileName).Name;
      Application.DoEvents();
      this.LeseDaten((object) openFileDialog.FileName);
    }

    private void Open_File_MouseEnter(object sender, EventArgs e)
    {
      this.MouseState = FormAddBuilding.eMouseState.MouseOver;
      this.Open_File.Refresh();
    }

    private void Open_File_MouseLeave(object sender, EventArgs e)
    {
      this.MouseState = FormAddBuilding.eMouseState.NoMouse;
      this.Open_File.Refresh();
    }

    private void FormAddBuilding_Load(object sender, EventArgs e)
    {
      this.CheckedListBox1.CheckOnClick = true;
      if (StringType.StrCmp(this.SuchTyp, "Lot", false) == 0)
        this.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[507]);
      else if (StringType.StrCmp(this.SuchTyp, "Building", false) == 0)
        this.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[506]);
      this.Button2.Text = StringType.FromObject(ClassThisProg.DefReader.LanguageArray[390]);
    }

    private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      if (StringType.StrCmp(this.SuchTyp, "Lot", false) == 0)
      {
        if (this.CheckedListBox1.SelectedIndex > -1)
        {
          this.ResultLot = this.ExemplarListe.LotContains.get_item(this.CheckedListBox1.SelectedIndex);
          this.DialogResult = DialogResult.OK;
        }
        else
          this.DialogResult = DialogResult.Cancel;
      }
      else
      {
        if (StringType.StrCmp(this.SuchTyp, "Building", false) != 0)
          return;
        if (this.CheckedListBox1.SelectedIndex > -1)
        {
          this.ResultBuilding = this.ExemplarListe.BuildingContains.get_item(this.CheckedListBox1.SelectedIndex);
          this.DialogResult = DialogResult.OK;
        }
        else
          this.DialogResult = DialogResult.Cancel;
      }
    }

    private void Button2_Click(object sender, EventArgs e) => this.DialogResult = DialogResult.Cancel;

    private enum eMouseState
    {
      NoMouse,
      MouseOver,
      MouseDown,
    }
  }
}
