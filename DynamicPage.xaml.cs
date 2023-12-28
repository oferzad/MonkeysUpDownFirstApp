using Microsoft.Maui.Graphics;

namespace MauiApp2;

public partial class DynamicPage : ContentPage
{
    int count = 0;
    List<Monkey> monkeyList;

    //Declare dynamic controls
    Button BtnUp, BtnDown;
    Image TheImage;
    Label TheLabel;
    public DynamicPage()
	{
		InitializeComponent();
        AddControlsDynamically();
        monkeyList = Monkey.GetMonkeys();
        count = 0;
        TheImage.Source = monkeyList[count].Image;
        TheLabel.Text = monkeyList[count].Name;
        BtnUp.IsEnabled = true;
    }

    private void AddControlsDynamically()
    {
        BtnUp = new Button()
        {
            Text = "Up",
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center,
            IsEnabled = false
        };

        BtnUp.Clicked += BtnUp_Clicked;

        BtnDown = new Button()
        {
            Text = "Down",
            HorizontalOptions = LayoutOptions.Center, 
            VerticalOptions = LayoutOptions.Center,
            IsEnabled = false
        };
        BtnDown.Clicked += BtnDown_Clicked;

        TheImage = new Image()
        {
            HeightRequest = 200,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center,
        };

        TheLabel = new Label()
        {
            FontSize = 20,
            TextColor = Colors.Blue,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center,
        };

        //Insert objects to page
        RootLayout.Children.Add(BtnUp);
        RootLayout.Children.Add(TheImage);
        RootLayout.Children.Add(TheLabel);
        RootLayout.Children.Add(BtnDown);
        
    }

    private void BtnUp_Clicked(object sender, EventArgs e)
    {

        if (count < monkeyList.Count - 1)
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