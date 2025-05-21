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
using System.Diagnostics;
using Microsoft.UI;
using Windows.UI;
using Windows.UI.Xaml;
// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace PiugTest
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// 
    
    public class Procesor
    {
        public string Nume { get; set; }
        public int Pret { get; set; }
    }
    public class Cooler
    {
        public string Nume { get; set; }
        public int Pret { get; set; }
    }
    public class PlacaDeBaza
    {
        public string Nume { get; set; }
        public int Pret { get; set; }
    }
    public class RAM
    {
        public string Nume { get; set; }
        public int Pret { get; set; }
    }
    public class Storage
    {
        public string Nume { get; set; }
        public int Pret { get; set; }
    }
    public class PlacaVideo
    {
        public string Nume { get; set; }
        public int Pret { get; set; }
    }
    public class Sursa
    {
        public string Nume { get; set; }
        public int Pret { get; set; }
    }
    public class Carcasa
    {
        public string Nume { get; set; }
        public decimal Pret { get; set; }
    }
    public sealed partial class BuildPage : Page
    {
        private readonly List<Color> TextColors = new List<Color>
        {
            Colors.White,
            Colors.Red,
            Colors.LimeGreen,
            Colors.Yellow
        };
        private int currentColorIndex = 0;
        private void CalculeazaPretTotal()
        {
            decimal total = 0;

            if (ProcesorComboBox.SelectedItem is Procesor proc)
                total += proc.Pret;

            if (CoolerComboBox.SelectedItem is Cooler cooler)
                total += cooler.Pret;

            if (PlaciComboBox.SelectedItem is PlacaDeBaza placa)
                total += placa.Pret;

            if (RAMComboBox.SelectedItem is RAM ram)
                total += ram.Pret;

            if (StorageComboBox.SelectedItem is Storage stoc)
                total += stoc.Pret;

            if (PlaciVideoComboBox.SelectedItem is PlacaVideo gpu)
                total += gpu.Pret;

            if (SursaComboBox.SelectedItem is Sursa sursa)
                total += sursa.Pret;

            if (CarcasaComboBox.SelectedItem is Carcasa carcasa)
                total += carcasa.Pret;

            PretTotalText.Text = $"{total} RON";
        }
        private BuildPredefinit buildPredefinitCurent;
        private bool estePredefinit = false;
        public BuildPage()
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

            ProcesorComboBox.ItemsSource = procesoare;
            var coolere = new List<Cooler>
{
                new Cooler { Nume = "Pure Rock 2 (Air)", Pret = 250 },
                new Cooler { Nume = "Hyper 212 (Air)", Pret = 300 },
                new Cooler { Nume = "NH-D15 (Air)", Pret = 450 },
                new Cooler { Nume = "H100i (Water)", Pret = 750 },
                new Cooler { Nume = "Ryuo 240 (AIO)", Pret = 950 },
                new Cooler { Nume = "Z73 (Water)", Pret = 1400 }
};

            CoolerComboBox.ItemsSource = coolere;
            var placiDeBaza = new List<PlacaDeBaza>
            {
                new PlacaDeBaza { Nume = "MSI B760-INTEL", Pret = 900 },
                new PlacaDeBaza { Nume = "ASUS Z790-INTEL", Pret = 1500 },
                new PlacaDeBaza { Nume = "Gigabyte Z690-INTEL", Pret = 1700 },
                new PlacaDeBaza { Nume = "Gigabyte B550-AMD", Pret = 1100 },
                new PlacaDeBaza { Nume = "ASUS B650-AMD", Pret = 1300 },
                new PlacaDeBaza { Nume = "MSI X670-AMD", Pret = 1800 },
            };
            PlaciComboBox.ItemsSource= placiDeBaza;
            var rami = new List<RAM>
            {
                new RAM { Nume = "Corsair 16GB", Pret = 350 },
                new RAM { Nume = "G.Skill 32GB", Pret = 650 },
                new RAM { Nume = "Kingston 64GB", Pret = 1200 },
                new RAM { Nume = "Crucial 128GB", Pret = 2300 }
            };

            RAMComboBox.ItemsSource = rami;
            var storages = new List<Storage>
            {
                new Storage { Nume = "500 GB", Pret = 250 },
                new Storage { Nume = "1 TB", Pret = 400 },
                new Storage { Nume = "2 TB", Pret = 700 },
                new Storage { Nume = "4 TB", Pret = 1300 }
            };

            StorageComboBox.ItemsSource = storages;
            var placiVideo = new List<PlacaVideo>
            {
                new PlacaVideo { Nume = "NVIDIA RTX 3060", Pret = 1500 },
                new PlacaVideo { Nume = "AMD RX 6600", Pret = 2100 },
                new PlacaVideo { Nume = "NVIDIA RTX 4070", Pret = 3700 },
                new PlacaVideo { Nume = "AMD RX 6700 XT", Pret = 5500 },
                new PlacaVideo { Nume = "AMD RX 7900 XT", Pret = 7700 },
                new PlacaVideo { Nume = "NVIDIA RTX 5090", Pret = 15000 }
            };

            PlaciVideoComboBox.ItemsSource = placiVideo;
            var surse = new List<Sursa>
            {
                new Sursa { Nume = "Corsair RM650", Pret = 350 },
                new Sursa { Nume = "be quiet! Pure Power 11 750W", Pret = 420 },
                new Sursa { Nume = "Seasonic Focus GX-850", Pret = 510 },
                new Sursa { Nume = "ASUS ROG STRIX 1000W", Pret = 670 },
                new Sursa { Nume = "Corsair HX1200", Pret = 850 },
                new Sursa { Nume = "Cooler Master M2000 Platinum 1600W", Pret = 1150 }
            };

            SursaComboBox.ItemsSource = surse;
            var carcase = new List<Carcasa>
            {
                new Carcasa { Nume = "MSI Forge 100R", Pret = 200 },
                new Carcasa { Nume = "NZXT H5 Flow", Pret = 330 },
                new Carcasa { Nume = "Fractal Pop Air", Pret = 450 },
                new Carcasa { Nume = "Lian Li O11D", Pret = 650 }
            };

            CarcasaComboBox.ItemsSource = carcase;
        }
        
        private void ProcesorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ProcesorComboBox.SelectedItem is Procesor procesor)
            {
                PretProcesor.Text = $"{procesor.Pret} RON";
            }
            else
            {
                PretProcesor.Text = string.Empty;
            }
            CalculeazaPretTotal();
        }
        private void CoolerComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CoolerComboBox.SelectedItem is Cooler cooler)
            {
                PretCooler.Text = $"{cooler.Pret} RON";
            }
            else
            {
                PretCooler.Text = string.Empty;
            }
            CalculeazaPretTotal();
        }
        private void PlaciComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (PlaciComboBox.SelectedItem is PlacaDeBaza placa)
            {
                PretPlaca.Text = $"{placa.Pret} RON";
            }
            else
            {
                PretPlaca.Text = string.Empty;
            }
            CalculeazaPretTotal();
        }
        private void RAMComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (RAMComboBox.SelectedItem is RAM ram)
            {
                PretRAM.Text = $"{ram.Pret} RON";
            }
            else
            {
                PretRAM.Text = "0 RON";
            }
            CalculeazaPretTotal();
        }
        private void StorageComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (StorageComboBox.SelectedItem is Storage storage)
            {
                PretStorage.Text = $"{storage.Pret} RON";
            }
            else
            {
                PretStorage.Text = "0 RON";
            }
            CalculeazaPretTotal();
        }
        private void PlaciVideoComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (PlaciVideoComboBox.SelectedItem is PlacaVideo placa)
            {
                PretPlacaVideo.Text = $"{placa.Pret} RON";
            }
            else
            {
                PretPlacaVideo.Text = "0 RON";
            }
            CalculeazaPretTotal();
        }
        private void SursaComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SursaComboBox.SelectedItem is Sursa sursa)
            {
                PretSursa.Text = $"{sursa.Pret} RON";
            }
            else
            {
                PretSursa.Text = "0 RON";
            }
            CalculeazaPretTotal();
        }
        private void CarcasaComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CarcasaComboBox.SelectedItem is Carcasa carcasa)
            {
                PretCarcasa.Text = $"{carcasa.Pret} RON";
            }
            else
            {
                PretCarcasa.Text = "0 RON";
            }
            CalculeazaPretTotal();
        }
        public void InitializeWithBuild(BuildPredefinit build)
        {
            buildPredefinitCurent = build;

            ProcesorComboBox.SelectedItem = build.Procesor;
            CoolerComboBox.SelectedItem = build.Cooler;
            PlaciComboBox.SelectedItem = build.PlacaDeBaza;
            RAMComboBox.SelectedItem = build.RAM;
            StorageComboBox.SelectedItem = build.Storage;
            PlaciVideoComboBox.SelectedItem = build.PlacaVideo;
            SursaComboBox.SelectedItem = build.Sursa;
            CarcasaComboBox.SelectedItem = build.Carcasa;

            CalculeazaPretTotal();
            estePredefinit = true;
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            if (e.Parameter is BuildPredefinit build)
            {
                InitializeWithBuild(build);
            }
        }
        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new SelectPage();
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
