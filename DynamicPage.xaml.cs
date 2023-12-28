using Microsoft.Maui.Graphics;
using System.Drawing;
using Color = Microsoft.Maui.Graphics.Color;

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
            HorizontalOptions = new LayoutOptions(LayoutAlignment.Center, false),
            VerticalOptions = new LayoutOptions(LayoutAlignment.Center, false),
            IsEnabled = false
        };

        BtnUp.Clicked += BtnUp_Clicked;

        BtnDown = new Button()
        {
            Text = "Down",
            HorizontalOptions = new LayoutOptions(LayoutAlignment.Center, false),
            VerticalOptions = new LayoutOptions(LayoutAlignment.Center, false),
            IsEnabled = false
        };
        BtnDown.Clicked += BtnDown_Clicked;

        TheImage = new Image()
        {
            HeightRequest = 200,
            HorizontalOptions = new LayoutOptions(LayoutAlignment.Center, false),
            VerticalOptions = new LayoutOptions(LayoutAlignment.Center, false)
        };

        TheLabel = new Label()
        {
            FontSize = 20,
            TextColor = new Color(0,0,1),
            HorizontalOptions = new LayoutOptions(LayoutAlignment.Center, false),
            VerticalOptions = new LayoutOptions(LayoutAlignment.Center, false)
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