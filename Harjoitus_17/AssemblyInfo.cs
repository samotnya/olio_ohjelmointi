using System.Windows;

namespace YksinkertainenKotiOhjausApp
{
    public partial class MainWindow : Window
    {
        // Muuttujat
        private float lämpötila = 20.0f;
        private bool keittiöValot = false;
        private bool olohuoneenValot = false;
        private bool oviLukossa = true;

        public MainWindow()
        {
            InitializeComponent();
            PaivitaKayttoliittyma();
        }

        private void PaivitaKayttoliittyma()
        {
            LampotilaTextBlock.Text = $"Lämpötila: {lämpötila} °C";
            KeittionValotButton.Content = keittiöValot ? "Keittiön valot: Päällä" : "Keittiön valot: Pois";
            OlohuoneenValotButton.Content = olohuoneenValot ? "Olohuoneen valot: Päällä" : "Olohuoneen valot: Pois";
            OviLukitusButton.Content = oviLukossa ? "Ovi: Lukossa" : "Ovi: Auki";
        }

        private void KeittionValotButton_Click(object sender, RoutedEventArgs e)
        {
            keittiöValot = !keittiöValot;
            PaivitaKayttoliittyma();
        }

        private void OlohuoneenValotButton_Click(object sender, RoutedEventArgs e)
        {
            olohuoneenValot = !olohuoneenValot;
            PaivitaKayttoliittyma();
        }

        private void OviLukitusButton_Click(object sender, RoutedEventArgs e)
        {
            oviLukossa = !oviLukossa;
            PaivitaKayttoliittyma();
        }

        private void LisaaLampotilaButton_Click(object sender, RoutedEventArgs e)
        {
            lämpötila += 1.0f;
            PaivitaKayttoliittyma();
        }

        private void VahennaLampotilaButton_Click(object sender, RoutedEventArgs e)
        {
            lämpötila -= 1.0f;
            PaivitaKayttoliittyma();
        }
    }
}
