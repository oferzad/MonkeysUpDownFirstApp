namespace MauiApp2;

public partial class App : Application
{
	public App()
	{
        //1. show how to add a new page and use it in the app as main page
        //2. show how an object can be inserted dynamically to the page
		InitializeComponent();
        //MainPage = new MainPage();
        //MainPage = new DynamicPage();
        MainPage = new EditorPage();
    }
}
