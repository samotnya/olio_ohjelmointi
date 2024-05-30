using Harjoitus_18;
using System;
using System.Windows;

namespace YksinkertainenLaskinApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LaskeSumma_Click(object sender, RoutedEventArgs e)
        {
            double luku1 = double.Parse(Luku1TextBox.Text);
            double luku2 = double.Parse(Luku2TextBox.Text);
            double tulos = Laskin.Summa(luku1, luku2);
            TulosTextBlock.Text = $"Tulos: {tulos}";
        }

        private void LaskeErotus_Click(object sender, RoutedEventArgs e)
        {
            double luku1 = double.Parse(Luku1TextBox.Text);
            double luku2 = double.Parse(Luku2TextBox.Text);
            double tulos = Laskin.Erotus(luku1, luku2);
            TulosTextBlock.Text = $"Tulos: {tulos}";
        }

        private void LaskeKertolasku_Click(object sender, RoutedEventArgs e)
        {
            double luku1 = double.Parse(Luku1TextBox.Text);
            double luku2 = double.Parse(Luku2TextBox.Text);
            double tulos = Laskin.Kertolasku(luku1, luku2);
            TulosTextBlock.Text = $"Tulos: {tulos}";
        }

        private void LaskeJakolasku_Click(object sender, RoutedEventArgs e)
        {
            double luku1 = double.Parse(Luku1TextBox.Text);
            double luku2 = double.Parse(Luku2TextBox.Text);
            if (luku2 != 0)
            {
                double tulos = Laskin.Jakolasku(luku1, luku2);
                TulosTextBlock.Text = $"Tulos: {tulos}";
            }
            else
            {
                TulosTextBlock.Text = "Virhe: Nollalla ei voi jakaa";
            }
        }
    }
}

