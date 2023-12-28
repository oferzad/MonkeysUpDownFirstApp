using System.Text.Json;
using System.Text.Json.Serialization;

namespace MauiApp2;


public partial class MainPage : ContentPage
{
	int count = 0;
	List<Monkey> monkeyList;
	public MainPage()
	{
		InitializeComponent();
        monkeyList = Monkey.GetMonkeys();
        count = 0;
        TheImage.Source = monkeyList[count].Image;
        TheLabel.Text = monkeyList[count].Name;
        BtnUp.IsEnabled = true;
    }


    private void BtnUp_Clicked(object sender, EventArgs e)
    {
        
        if (count < monkeyList.Count-1)
        {
            count++;
            TheImage.Source = monkeyList[count].Image;
            TheLabel.Text = monkeyList[count].Name;
            BtnDown.IsEnabled = true;
        }
        if (count == monkeyList.Count - 1)
        {
            BtnUp.IsEnabled = false;
            
        }
        
    }

    private void BtnDown_Clicked(object sender, EventArgs e)
    {
        
        if (count > 0)
        {
            count--;
            TheImage.Source = monkeyList[count].Image;
            TheLabel.Text = monkeyList[count].Name;
            BtnUp.IsEnabled = true;
        }
        if (count == 0)
        {
            
            BtnDown.IsEnabled = false;
        }
        
    }
}

