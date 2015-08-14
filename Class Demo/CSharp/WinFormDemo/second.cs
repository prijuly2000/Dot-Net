using System;
using System.Windows.Forms;
class MyForm:Form
{
   Button b1; 
   
//Step 1
    void OkClicked(object sender,EventArgs e)
    {
           MessageBox.Show("Ok Clicked!");
    }    

    void Initialize()
    {
        b1 = new Button();
        b1.Text = " OK ";
        this.Text = " My Form";   

    //Step 2
        EventHandler d1=new EventHandler(OkClicked);

    //Register the event with delegate
    //step 3
      b1.Click+=d1; 
        this.Controls.Add(b1); //Add the control to the form    
        
     }   
    public MyForm()
   {
         Initialize();
   }
}
class MyApplication
{
	public static void Main()
	{
		MyForm f1=new MyForm();
		Application.Run(f1);
	}
}






