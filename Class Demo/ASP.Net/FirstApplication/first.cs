using System;
using System.Web.UI;

public partial class MyPage:Page
{
   public void DisplayTime(object sender,EventArgs e)
  {
      label1.Text += DateTime.Now.ToString();
  }
}
