using System.Windows;
using System.Windows.Controls;

namespace OstoskärrySovellus
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox valittuTuote = sender as CheckBox;
            TextBlock tuoteTeksti = new TextBlock
            {
                Text = valittuTuote.Content.ToString(),
                Name = "tuoteTeksti" + valittuTuote.Name
            };
            kärryPaneeli.Children.Add(tuoteTeksti);
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            CheckBox poistettuTuote = sender as CheckBox;
            TextBlock poistettavaTeksti = null;
            foreach (TextBlock tuoteTeksti in kärryPaneeli.Children)
            {
                if (tuoteTeksti.Name == "tuoteTeksti" + poistettuTuote.Name)
                {
                    poistettavaTeksti = tuoteTeksti;
                    break;
                }
            }
            if (poistettavaTeksti != null)
            {
                kärryPaneeli.Children.Remove(poistettavaTeksti);
            }
        }

        private void Osta_Click(object sender, RoutedEventArgs e)
        {
            // Tyhjennä kärry
            kärryPaneeli.Children.Clear();

            // Aseta kaikki CheckBoxit unchecked-tilaan
            tuote1.IsChecked = false;
            tuote2.IsChecked = false;
            tuote3.IsChecked = false;
            tuote4.IsChecked = false;
        }
    }
}


