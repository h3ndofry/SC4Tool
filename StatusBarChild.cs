// Decompiled with JetBrains decompiler
// Type: SC4Tool.StatusBarChild
// Assembly: SC4Tool, Version=2.2.7.0, Culture=neutral, PublicKeyToken=null
// MVID: 69A50BC4-87A5-4C5E-BEFC-08274BC6D498
// Assembly location: C:\Program Files (x86)\SC4 Utilities\SC4Tool\SC4Tool.exe

using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SC4Tool
{
  internal class StatusBarChild
  {
    public Control ChildControl;
    public StatusBar StatusBar;
    public short Panel;
    public int Margin;
    public const long WM_USER = 1024;
    public const long SB_GETRECT = 1034;

    [DllImport("user32", EntryPoint = "SendMessageA", CharSet = CharSet.Ansi, SetLastError = true)]
    public static extern long SendMessage(
      int hwnd,
      int msg,
      int wParam,
      ref StatusBarChild.RECT lParam);

    public StatusBarChild(
      ref Control obj,
      ref StatusBar sb,
      ref short intPanelNumber = 0,
      int intMargin = 2)
    {
      this.ChildControl = obj;
      this.StatusBar = sb;
      this.Panel = intPanelNumber;
      this.Margin = intMargin;
      this.ChildControl.Parent = (Control) this.StatusBar;
      this.Resize();
      this.ChildControl.Visible = true;
    }

    public void Resize()
    {
      StatusBarChild.RECT lParam;
      StatusBarChild.SendMessage(this.StatusBar.Handle.ToInt32(), 1034, (int) this.Panel, ref lParam);
      Control childControl = this.ChildControl;
      childControl.Left = checked (lParam.Left + this.Margin);
      childControl.Top = checked (lParam.Top + this.Margin);
      childControl.Height = checked (lParam.Bottom - lParam.Top - 2 * this.Margin);
      childControl.Width = checked (lParam.Right - lParam.Left - 2 * this.Margin);
    }

    public struct RECT
    {
      public int Left;
      public int Top;
      public int Right;
      public int Bottom;
    }
  }
}
