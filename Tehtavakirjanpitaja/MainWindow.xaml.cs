using System;
using System.Windows;

namespace Tehtavakirjanpitaja
{
    public partial class MainWindow : Window
    {
        private TehtavaKirja tehtavaKirja = new TehtavaKirja();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void LisääTehtävä_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string nimi = NimiTextBox.Text;
                string kuvaus = KuvausTextBox.Text;
                DateTime määräaika = MääräaikaDatePicker.SelectedDate.Value;

                Tehtava uusiTehtava = new Tehtava(nimi, kuvaus, määräaika);
                tehtavaKirja.LisääTehtava(uusiTehtava);
                PäivitäTehtavaListBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe lisättäessä tehtävää: " + ex.Message);
            }
        }

        private void TallennaTehtävät_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                tehtavaKirja.TallennaTiedostoon();
                MessageBox.Show("Tehtävät tallennettu onnistuneesti.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe tallennettaessa tehtäviä: " + ex.Message);
            }
        }
        
        private void PäivitäTehtavaListBox()
        {
            TehtavaListBox.Items.Clear();
            foreach (Tehtava tehtava in tehtavaKirja.HaeKaikkiTehtavat())
            {
                TehtavaListBox.Items.Add(tehtava.ToString());
            }
        }
    }
}
