namespace MauiApp2;

public partial class EditorPage : ContentPage
{
	public EditorPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		myLabel.Text = myEditor.Text;
    }
}