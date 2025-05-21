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
    public sealed partial class PreviewPage : Page
    {
        private List<BuildPredefinit> builduriPredefinite;
        private readonly List<Color> TextColors = new List<Color>
        {
            Colors.White,
            Colors.Red,
            Colors.LimeGreen,
            Colors.Yellow
        };
        private int currentColorIndex = 0;
        public PreviewPage()
        {
            this.InitializeComponent();
            var procesoare = new List<Procesor>
    {
        new Procesor { Nume = "Intel Core i5-13400F", Pret = 950 },
        new Procesor { Nume = "Intel Core i7-13700K", Pret = 1900 },
        new Procesor { Nume = "Intel Core i9-13900K", Pret = 3100 },
        new Procesor { Nume = "AMD Ryzen 5 7600", Pret = 1050 },
        new Procesor { Nume = "AMD Ryzen 7 7700X", Pret = 1750 },
        new Procesor { Nume = "AMD Ryzen 9 7950X", Pret = 3200 }
    };

            var coolere = new List<Cooler>
    {
        new Cooler { Nume = "Pure Rock 2 (Air)", Pret = 250 },
        new Cooler { Nume = "Hyper 212 (Air)", Pret = 300 },
        new Cooler { Nume = "NH-D15 (Air)", Pret = 450 },
        new Cooler { Nume = "H100i (Water)", Pret = 750 },
        new Cooler { Nume = "Ryuo 240 (AIO)", Pret = 950 },
        new Cooler { Nume = "Z73 (Water)", Pret = 1400 }
    };

            var placiDeBaza = new List<PlacaDeBaza>
    {
        new PlacaDeBaza { Nume = "MSI B760-INTEL", Pret = 900 },
        new PlacaDeBaza { Nume = "ASUS Z790-INTEL", Pret = 1500 },
        new PlacaDeBaza { Nume = "Gigabyte Z690-INTEL", Pret = 1700 },
        new PlacaDeBaza { Nume = "Gigabyte B550-AMD", Pret = 1100 },
        new PlacaDeBaza { Nume = "ASUS B650-AMD", Pret = 1300 },
        new PlacaDeBaza { Nume = "MSI X670-AMD", Pret = 1800 },
    };

            var rami = new List<RAM>
    {
        new RAM { Nume = "Corsair 16GB", Pret = 350 },
        new RAM { Nume = "G.Skill 32GB", Pret = 650 },
        new RAM { Nume = "Kingston 64GB", Pret = 1200 },
        new RAM { Nume = "Crucial 128GB", Pret = 2300 }
    };

            var storages = new List<Storage>
    {
        new Storage { Nume = "500 GB", Pret = 250 },
        new Storage { Nume = "1 TB", Pret = 400 },
        new Storage { Nume = "2 TB", Pret = 700 },
        new Storage { Nume = "4 TB", Pret = 1300 }
    };

            var placiVideo = new List<PlacaVideo>
    {
        new PlacaVideo { Nume = "NVIDIA RTX 3060", Pret = 1500 },
        new PlacaVideo { Nume = "AMD RX 6600", Pret = 2100 },
        new PlacaVideo { Nume = "NVIDIA RTX 4070", Pret = 3700 },
        new PlacaVideo { Nume = "AMD RX 6700 XT", Pret = 5500 },
        new PlacaVideo { Nume = "AMD RX 7900 XT", Pret = 7700 },
        new PlacaVideo { Nume = "NVIDIA RTX 5090", Pret = 15000 }
    };

            var surse = new List<Sursa>
    {
        new Sursa { Nume = "Corsair RM650", Pret = 350 },
        new Sursa { Nume = "be quiet! Pure Power 11 750W", Pret = 420 },
        new Sursa { Nume = "Seasonic Focus GX-850", Pret = 510 },
        new Sursa { Nume = "ASUS ROG STRIX 1000W", Pret = 670 },
        new Sursa { Nume = "Corsair HX1200", Pret = 850 },
        new Sursa { Nume = "Cooler Master M2000 Platinum 1600W", Pret = 1150 }
    };

            var carcase = new List<Carcasa>
    {
        new Carcasa { Nume = "MSI Forge 100R", Pret = 200 },
        new Carcasa { Nume = "NZXT H5 Flow", Pret = 330 },
        new Carcasa { Nume = "Fractal Pop Air", Pret = 450 },
        new Carcasa { Nume = "Lian Li O11D", Pret = 650 }
    };

            // Lista build-urilor predefinite:
            builduriPredefinite = new List<BuildPredefinit>
    {
        new BuildPredefinit
        {
            Nume = "AMD 1000$",
            Procesor = procesoare.First(p => p.Nume.Contains("AMD Ryzen 5 7600")),
            Cooler = coolere.First(c => c.Nume == "Pure Rock 2 (Air)"),
            PlacaDeBaza = placiDeBaza.First(p => p.Nume == "Gigabyte B550-AMD"),
            RAM = rami.First(r => r.Nume == "Corsair 16GB"),
            Storage = storages.First(s => s.Nume == "500 GB"),
            PlacaVideo = placiVideo.First(pv => pv.Nume == "AMD RX 6600"),
            Sursa = surse.First(s => s.Nume == "Corsair RM650"),
            Carcasa = carcase.First(ca => ca.Nume == "MSI Forge 100R")
        },
        new BuildPredefinit
        {
            Nume = "Intel 1000$",
            Procesor = procesoare.First(p => p.Nume.Contains("Intel Core i5-13400F")),
            Cooler = coolere.First(c => c.Nume == "Pure Rock 2 (Air)"),
            PlacaDeBaza = placiDeBaza.First(p => p.Nume == "MSI B760-INTEL"),
            RAM = rami.First(r => r.Nume == "Corsair 16GB"),
            Storage = storages.First(s => s.Nume == "500 GB"),
            PlacaVideo = placiVideo.First(pv => pv.Nume == "NVIDIA RTX 3060"),
            Sursa = surse.First(s => s.Nume == "Corsair RM650"),
            Carcasa = carcase.First(ca => ca.Nume == "MSI Forge 100R")
        },
        new BuildPredefinit
        {
            Nume = "AMD 2000$",
            Procesor = procesoare.First(p => p.Nume.Contains("AMD Ryzen 7 7700X")),
            Cooler = coolere.First(c => c.Nume == "Hyper 212 (Air)"),
            PlacaDeBaza = placiDeBaza.First(p => p.Nume == "ASUS B650-AMD"),
            RAM = rami.First(r => r.Nume == "G.Skill 32GB"),
            Storage = storages.First(s => s.Nume == "1 TB"),
            PlacaVideo = placiVideo.First(pv => pv.Nume == "AMD RX 6700 XT"),
            Sursa = surse.First(s => s.Nume == "be quiet! Pure Power 11 750W"),
            Carcasa = carcase.First(ca => ca.Nume == "NZXT H5 Flow")
        },
        new BuildPredefinit
        {
            Nume = "Intel 2000$",
            Procesor = procesoare.First(p => p.Nume.Contains("Intel Core i7-13700K")),
            Cooler = coolere.First(c => c.Nume == "Hyper 212 (Air)"),
            PlacaDeBaza = placiDeBaza.First(p => p.Nume == "ASUS Z790-INTEL"),
            RAM = rami.First(r => r.Nume == "G.Skill 32GB"),
            Storage = storages.First(s => s.Nume == "1 TB"),
            PlacaVideo = placiVideo.First(pv => pv.Nume == "NVIDIA RTX 4070"),
            Sursa = surse.First(s => s.Nume == "be quiet! Pure Power 11 750W"),
            Carcasa = carcase.First(ca => ca.Nume == "NZXT H5 Flow")
        },
        new BuildPredefinit
        {
            Nume = "AMD Streaming 3000$",
            Procesor = procesoare.First(p => p.Nume.Contains("AMD Ryzen 9 7950X")),
            Cooler = coolere.First(c => c.Nume == "NH-D15 (Air)"),
            PlacaDeBaza = placiDeBaza.First(p => p.Nume == "MSI X670-AMD"),
            RAM = rami.First(r => r.Nume == "Kingston 64GB"),
            Storage = storages.First(s => s.Nume == "2 TB"),
            PlacaVideo = placiVideo.First(pv => pv.Nume == "AMD RX 7900 XT"),
            Sursa = surse.First(s => s.Nume == "Seasonic Focus GX-850"),
            Carcasa = carcase.First(ca => ca.Nume == "Fractal Pop Air")
        },
        new BuildPredefinit
        {
            Nume = "Intel Streaming 3000$",
            Procesor = procesoare.First(p => p.Nume.Contains("Intel Core i9-13900K")),
            Cooler = coolere.First(c => c.Nume == "NH-D15 (Air)"),
            PlacaDeBaza = placiDeBaza.First(p => p.Nume == "Gigabyte Z690-INTEL"),
            RAM = rami.First(r => r.Nume == "Kingston 64GB"),
            Storage = storages.First(s => s.Nume == "2 TB"),
            PlacaVideo = placiVideo.First(pv => pv.Nume == "NVIDIA RTX 5090"),
            Sursa = surse.First(s => s.Nume == "Seasonic Focus GX-850"),
            Carcasa = carcase.First(ca => ca.Nume == "Fractal Pop Air")
        },
        new BuildPredefinit
        {
            Nume = "AMD Streaming 4000$",
            Procesor = procesoare.First(p => p.Nume.Contains("AMD Ryzen 9 7950X")),
            Cooler = coolere.First(c => c.Nume == "Z73 (Water)"),
            PlacaDeBaza = placiDeBaza.First(p => p.Nume == "MSI X670-AMD"),
            RAM = rami.First(r => r.Nume == "Crucial 128GB"),
            Storage = storages.First(s => s.Nume == "4 TB"),
            PlacaVideo = placiVideo.First(pv => pv.Nume == "AMD RX 7900 XT"),
            Sursa = surse.First(s => s.Nume == "Cooler Master M2000 Platinum 1600W"),
            Carcasa = carcase.First(ca => ca.Nume == "Lian Li O11D")
        },
        new BuildPredefinit
        {
            Nume = "Intel Streaming 4000$",
            Procesor = procesoare.First(p => p.Nume.Contains("Intel Core i9-13900K")),
            Cooler = coolere.First(c => c.Nume == "Z73 (Water)"),
            PlacaDeBaza = placiDeBaza.First(p => p.Nume == "Gigabyte Z690-INTEL"),
            RAM = rami.First(r => r.Nume == "Crucial 128GB"),
            Storage = storages.First(s => s.Nume == "4 TB"),
            PlacaVideo = placiVideo.First(pv => pv.Nume == "NVIDIA RTX 5090"),
            Sursa = surse.First(s => s.Nume == "Cooler Master M2000 Platinum 1600W"),
            Carcasa = carcase.First(ca => ca.Nume == "Lian Li O11D")
        }
    };
        }
        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new SelectPage();
        }
        private void AMD1Button_Click(object sender, RoutedEventArgs e)
        {
            if (Frame != null && builduriPredefinite != null)
            {
                var build = builduriPredefinite.First(b => b.Nume.StartsWith("AMD 1000$"));
                Frame.Navigate(typeof(BuildPage), build);
            }
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
