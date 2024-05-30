using System.Windows;

namespace YksinkertainenKotiOhjausApp
{
    public partial class MainWindow : Window
    {
        // Muuttujat
        private float l�mp�tila = 20.0f;
        private bool keitti�Valot = false;
        private bool olohuoneenValot = false;
        private bool oviLukossa = true;

        public MainWindow()
        {
            InitializeComponent();
            PaivitaKayttoliittyma();
        }

        private void PaivitaKayttoliittyma()
        {
            LampotilaTextBlock.Text = $"L�mp�tila: {l�mp�tila} �C";
            KeittionValotButton.Content = keitti�Valot ? "Keitti�n valot: P��ll�" : "Keitti�n valot: Pois";
            OlohuoneenValotButton.Content = olohuoneenValot ? "Olohuoneen valot: P��ll�" : "Olohuoneen valot: Pois";
            OviLukitusButton.Content = oviLukossa ? "Ovi: Lukossa" : "Ovi: Auki";
        }

        private void KeittionValotButton_Click(object sender, RoutedEventArgs e)
        {
            keitti�Valot = !keitti�Valot;
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
            l�mp�tila += 1.0f;
            PaivitaKayttoliittyma();
        }

        private void VahennaLampotilaButton_Click(object sender, RoutedEventArgs e)
        {
            l�mp�tila -= 1.0f;
            PaivitaKayttoliittyma();
        }
    }
}
