// Decompiled with JetBrains decompiler
// Type: SC4Tool.FormProgress
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
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SC4Tool
{
  public class FormProgress : Form
  {
    [AccessedThroughProperty("Label2")]
    private Label _Label2;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("ProgressBar1")]
    private ProgressBar _ProgressBar1;
    private string LeseTyp;
    private IContainer components;

    public FormProgress(string Art)
    {
      this.Closed += new EventHandler(this.FormProgress_Closed);
      this.Load += new EventHandler(this.FormProgress_Load);
      this.InitializeComponent();
      this.LeseTyp = Art;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
      ClassThisProg.frmProgress = (FormProgress) null;
    }

    internal virtual ProgressBar ProgressBar1
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ProgressBar1 == null)
          ;
        this._ProgressBar1 = value;
        if (this._ProgressBar1 == null)
          ;
      }
      get => this._ProgressBar1;
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

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.ProgressBar1 = new ProgressBar();
      this.Label1 = new Label();
      this.Label2 = new Label();
      this.SuspendLayout();
      ProgressBar progressBar1_1 = this.ProgressBar1;
      Point point1 = new Point(16, 40);
      Point point2 = point1;
      progressBar1_1.Location = point2;
      this.ProgressBar1.Name = "ProgressBar1";
      ProgressBar progressBar1_2 = this.ProgressBar1;
      Size size1 = new Size(400, 24);
      Size size2 = size1;
      progressBar1_2.Size = size2;
      this.ProgressBar1.TabIndex = 0;
      Label label1_1 = this.Label1;
      point1 = new Point(16, 72);
      Point point3 = point1;
      label1_1.Location = point3;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      size1 = new Size(400, 40);
      Size size3 = size1;
      label1_2.Size = size3;
      this.Label1.TabIndex = 1;
      Label label2_1 = this.Label2;
      point1 = new Point(16, 8);
      Point point4 = point1;
      label2_1.Location = point4;
      this.Label2.Name = "Label2";
      Label label2_2 = this.Label2;
      size1 = new Size(344, 24);
      Size size4 = size1;
      label2_2.Size = size4;
      this.Label2.TabIndex = 2;
      size1 = new Size(5, 13);
      this.AutoScaleBaseSize = size1;
      size1 = new Size(426, 114);
      this.ClientSize = size1;
      this.ControlBox = false;
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.ProgressBar1);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (FormProgress);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.ResumeLayout(false);
    }

    private void FormProgress_Load(object sender, EventArgs e)
    {
      this.Show();
      Application.DoEvents();
      this.Cursor = Cursors.WaitCursor;
      if (this.GetFileList())
      {
        if (StringType.StrCmp(this.LeseTyp, "T", false) == 0)
          this.ReadSimCityTexturen();
        else
          this.ReadDepListe();
      }
      this.Cursor = Cursors.Default;
      this.Dispose();
    }

    private bool GetFileList()
    {
      ArrayList PatternList = new ArrayList();
      PatternList.Add((object) "*.dat");
      PatternList.Add((object) "*.sc4Lot");
      PatternList.Add((object) "*.sc4Desc");
      ArrayList arrayList = new ArrayList();
      ArrayList Array1 = new ArrayList();
      bool flag = false;
      if (ClassThisProg.DefReader.MainFolderArray.Count > 0)
        return true;
      arrayList.Add((object) "SIMCITY_2.DAT");
      arrayList.Add((object) "SIMCITY_3.DAT");
      arrayList.Add((object) "SIMCITY_4.DAT");
      arrayList.Add((object) "SIMCITY_5.DAT");
      try
      {
        ClassThisProg.DefReader.MainFolderArray.Clear();
        ClassThisProg.DefReader.MainCommonFolderArray.Clear();
        ClassThisProg.DefReader.MainPrivateFolderArray.Clear();
        ClassThisProg.DefReader.AllSmallFilesArray.Clear();
        if (new DirectoryInfo(ClassThisProg.DefReader.SC4Path).Exists)
        {
          FileInfo fileInfo1 = new FileInfo(ClassThisProg.DefReader.SC4Path + "\\SimCity_2.dat");
          if (fileInfo1.Exists)
            ClassThisProg.DefReader.SimCity2 = fileInfo1.FullName;
          FileInfo fileInfo2 = new FileInfo(ClassThisProg.DefReader.SC4Path + "\\SimCity_1.dat");
          if (fileInfo2.Exists)
          {
            ClassThisProg.DefReader.MainFolderArray.Add((object) fileInfo2.FullName);
            ClassThisProg.DefReader.MainCommonFolderArray.Add((object) fileInfo2.FullName);
            ClassThisProg.DefReader.AllSmallFilesArray.Add((object) fileInfo2.Name);
          }
          if (StringType.StrCmp(ClassThisProg.DefReader.SC4Path, "", false) != 0 && new DirectoryInfo(ClassThisProg.DefReader.SC4Path + "\\Plugins").Exists)
          {
            sr_DirBrowser.StartRead(ClassThisProg.DefReader.SC4Path + "\\Plugins", PatternList, ref Array1);
            if (Array1.Count > 0)
            {
              int num = checked (Array1.Count - 1);
              int index = 0;
              while (index <= num)
              {
                FileInfo fileInfo3 = new FileInfo(StringType.FromObject(Array1[index]));
                if (arrayList.IndexOf((object) fileInfo3.Name.ToUpper()) == -1)
                {
                  ClassThisProg.DefReader.MainFolderArray.Add(RuntimeHelpers.GetObjectValue(Array1[index]));
                  ClassThisProg.DefReader.MainCommonFolderArray.Add(RuntimeHelpers.GetObjectValue(Array1[index]));
                  ClassThisProg.DefReader.AllSmallFilesArray.Add((object) fileInfo3.Name);
                }
                checked { ++index; }
              }
              flag = true;
            }
          }
        }
        Array1.Clear();
        if (StringType.StrCmp(ClassThisProg.DefReader.sc4LocalPath, "", false) != 0)
        {
          if (new DirectoryInfo(ClassThisProg.DefReader.sc4LocalPath).Exists)
          {
            sr_DirBrowser.StartRead(ClassThisProg.DefReader.sc4LocalPath, PatternList, ref Array1);
            if (Array1.Count > 0)
            {
              int num = checked (Array1.Count - 1);
              int index = 0;
              while (index <= num)
              {
                FileInfo fileInfo = new FileInfo(StringType.FromObject(Array1[index]));
                if (arrayList.IndexOf((object) fileInfo.Name.ToUpper()) == -1)
                {
                  ClassThisProg.DefReader.MainFolderArray.Add(RuntimeHelpers.GetObjectValue(Array1[index]));
                  ClassThisProg.DefReader.MainPrivateFolderArray.Add(RuntimeHelpers.GetObjectValue(Array1[index]));
                  ClassThisProg.DefReader.AllSmallFilesArray.Add((object) fileInfo.Name);
                }
                checked { ++index; }
              }
              flag = true;
            }
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ClassThisProg.DefReader.MainFolderArray.Clear();
        ClassThisProg.DefReader.MainCommonFolderArray.Clear();
        ClassThisProg.DefReader.MainPrivateFolderArray.Clear();
        ClassThisProg.DefReader.AllSmallFilesArray.Clear();
        ProjectData.ClearProjectError();
      }
      return ClassThisProg.DefReader.MainFolderArray.Count > 0;
    }

    private bool ReadDepListe()
    {
      bool flag;
      try
      {
        if (!Information.IsNothing((object) ClassThisProg.DefReader.DepListe))
          ClassThisProg.DefReader.DepListe.Dispose();
        ClassThisProg.DefReader.DepListe = new sr_DepBrowser();
        this.Label2.Text = "Scanning Files....";
        this.ProgressBar1.Minimum = 0;
        this.ProgressBar1.Maximum = checked (ClassThisProg.DefReader.MainFolderArray.Count + 2);
        this.ProgressBar1.Value = this.ProgressBar1.Minimum;
        this.ProgressBar1.Step = 1;
        this.Label1.Text = "Reading Standard-Props....";
        Application.DoEvents();
        int num = checked (ClassThisProg.DefReader.MainFolderArray.Count - 1);
        int index = 0;
        while (index <= num)
        {
          this.ProgressBar1.PerformStep();
          this.Label1.Text = StringType.FromObject(ClassThisProg.DefReader.AllSmallFilesArray[index]);
          Application.DoEvents();
          ClassThisProg.DefReader.DepListe.GetOneFile(StringType.FromObject(ClassThisProg.DefReader.MainFolderArray[index]));
          checked { ++index; }
        }
        Application.DoEvents();
        if (StringType.StrCmp(ClassThisProg.DefReader.SimCity2, "", false) != 0)
        {
          this.Label1.Text = "SimCity_2.Dat";
          Application.DoEvents();
          ClassThisProg.DefReader.DepListe.GetOneFile(ClassThisProg.DefReader.SimCity2);
        }
        ClassThisProg.DefReader.HasReadDeps = true;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        flag = false;
        ProjectData.ClearProjectError();
        goto label_11;
      }
      flag = true;
label_11:
      return flag;
    }

    private bool ReadSimCityTexturen()
    {
      bool flag;
      try
      {
        if (!Information.IsNothing((object) ClassThisProg.DefReader.TextureListe))
          ClassThisProg.DefReader.TextureListe.Dispose();
        ClassThisProg.DefReader.TextureListe = new TextureReader();
        this.Label2.Text = "Reading Textures....";
        this.ProgressBar1.Minimum = 0;
        this.ProgressBar1.Maximum = checked (ClassThisProg.DefReader.MainFolderArray.Count + 1);
        this.ProgressBar1.Value = this.ProgressBar1.Minimum;
        this.ProgressBar1.Step = 1;
        if (StringType.StrCmp(ClassThisProg.DefReader.SimCity2, "", false) != 0)
        {
          this.Label1.Text = "SimCity_2.Dat";
          Application.DoEvents();
          ClassThisProg.DefReader.TextureListe.GetTextures(ClassThisProg.DefReader.SimCity2);
        }
        int num = checked (ClassThisProg.DefReader.MainFolderArray.Count - 1);
        int index = 0;
        while (index <= num)
        {
          this.ProgressBar1.PerformStep();
          if (StringType.StrCmp(new FileInfo(StringType.FromObject(ClassThisProg.DefReader.MainFolderArray[index])).Extension.ToUpper(), ".SC4DESC", false) != 0)
          {
            this.Label1.Text = StringType.FromObject(ClassThisProg.DefReader.AllSmallFilesArray[index]);
            Application.DoEvents();
            ClassThisProg.DefReader.TextureListe.GetTextures(StringType.FromObject(ClassThisProg.DefReader.MainFolderArray[index]));
          }
          checked { ++index; }
        }
        ClassThisProg.DefReader.HasReadTextures = true;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        flag = false;
        ProjectData.ClearProjectError();
        goto label_13;
      }
      flag = true;
label_13:
      return flag;
    }

    private void FormProgress_Closed(object sender, EventArgs e) => ClassThisProg.frmProgress = (FormProgress) null;
  }
}
