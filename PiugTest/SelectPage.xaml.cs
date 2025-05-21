using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Microsoft.UI;
using Windows.UI;


// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace PiugTest
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SelectPage : Page
    {
        private readonly List<Color> TextColors = new List<Color>
        {
            Colors.White,
            Colors.Red,
            Colors.LimeGreen,
            Colors.Yellow
        };
        private int currentColorIndex = 0;
        public SelectPage()
        {
            this.InitializeComponent();
        }
        private void PreviewButton_Click(object sender, RoutedEventArgs e)
        {
            // Navighează la pagina PreviewPage folosind this.Content
            this.Content = new PreviewPage();
        }

        private void BuildButton_Click(object sender, RoutedEventArgs e)
        {
            // Navighează la pagina BuildPage folosind this.Content
            this.Content = new BuildPage();
        }
        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
           // this.Content = new MainWindow();
        }
        private bool fundalInchis = true;

        private void SwitchBackgroundButton_Click(object sender, RoutedEventArgs e)
        {

            if (fundalInchis)
                this.Background = new SolidColorBrush(Colors.WhiteSmoke);
            else
                this.Background = new SolidColorBrush(Color.FromArgb(255, 2, 4, 47)); // #02042F

            fundalInchis = !fundalInchis;
        }
        private void ChangeTextColorButton_Click(object sender, RoutedEventArgs e)
        {
            currentColorIndex = (currentColorIndex + 1) % TextColors.Count;
            Color nextColor = TextColors[currentColorIndex];
            ChangeTextColor(this, nextColor);
        }

        private void ChangeTextColor(DependencyObject parent, Color color)
        {
            int count = VisualTreeHelper.GetChildrenCount(parent);
            for (int i = 0; i < count; i++)
            {
                var child = VisualTreeHelper.GetChild(parent, i);

                if (child is TextBlock textBlock)
                {
                    textBlock.Foreground = new SolidColorBrush(color);
                }

                ChangeTextColor(child, color); // recursiv
            }
        }
    }
}
