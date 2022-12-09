// Decompiled with JetBrains decompiler
// Type: SC4Tool.MainModule
// Assembly: SC4Tool, Version=2.2.7.0, Culture=neutral, PublicKeyToken=null
// MVID: 69A50BC4-87A5-4C5E-BEFC-08274BC6D498
// Assembly location: C:\Program Files (x86)\SC4 Utilities\SC4Tool\SC4Tool.exe

using Microsoft.VisualBasic.CompilerServices;
using System;

namespace SC4Tool
{
  [StandardModule]
  internal sealed class MainModule
  {
    public static FormSetDef FrmStartUp = new FormSetDef();
    public static FormMain FrmMain = new FormMain();

    [STAThread]
    public static void Main()
    {
      int num1 = (int) MainModule.FrmStartUp.ShowDialog();
      int num2 = (int) MainModule.FrmMain.ShowDialog();
    }
  }
}
