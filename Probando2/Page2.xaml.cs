namespace Probando2;

public partial class Page2 : ContentPage
{
	public Page2(string UserName)
	{
		InitializeComponent();
		LblName.Text = UserName;
	}

}