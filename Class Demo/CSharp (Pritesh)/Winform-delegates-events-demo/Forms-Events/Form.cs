using System;
using System.Windows.Forms;

class Myform:Form
{
	public Myform()
	{
		init();
	}
	public void init()
	{
		Button b1=new Button();
		b1.Text="OK";
		this.Text="My Form";
		this.Controls.Add(b1);
		EventHandler d1=new EventHandler(Ok);
		b1.Click+=d1;
	}
	void Ok(object sender,EventArgs e)
	{
		MessageBox.Show("OK clicked");
	} 

}

class main
{
	static void Main()
	{
		Myform f1=new Myform();
		Application.Run(f1);
		
		Myform f2=new Myform();
		Application.Run(f2);
		
	}
} 