using System;
using System.Windows;

namespace IkkunaLaskuriSovellus
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Laske_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(leveysTextBox.Text) || string.IsNullOrEmpty(korkeusTextBox.Text) || string.IsNullOrEmpty(karmiTextBox.Text))
            {
                MessageBox.Show("Syötä kaikki arvot.");
                return;
            }

            double leveys = double.Parse(leveysTextBox.Text);
            double korkeus = double.Parse(korkeusTextBox.Text);
            double karmi = double.Parse(karmiTextBox.Text);

            double ikkunaPintaAla = leveys * korkeus;
            double ikkunaLasinPintaAla = (leveys - (2 * karmi)) * (korkeus - (2 * karmi));
            double karmiPiiri = 2 * (leveys + korkeus);

            tulosTextBlock.Text = "Ikkunalasin pinta-ala: " + ikkunaLasinPintaAla + " cm²\n" +
                                  "Karmipuun piiri: " + karmiPiiri + " cm\n" +
                                  "Koko ikkunan pinta-ala: " + ikkunaPintaAla + " cm²";
        }
    }
}
