using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ComboBoxPersona
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ObservableCollection<Persona> personas = Persona.GetPersonas();
            ListaPersonasComboBox.DataContext = personas;
            
        }

        private void StackPanel_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            SelectorId.DataContext = ListaPersonasComboBox.SelectedItem;
        }
    }
}
