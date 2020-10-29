using System.Windows;
using System.Windows.Controls;

namespace Ejercicio5._2ut3
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        { int cont = 1;
            
            InitializeComponent();
            for (int i = 0; i < 3; i++)
            {
                for (int x = 2; x < 5; x++)
                {
                    Button b = new Button();
                    TextBlock text = new TextBlock();
                    text.Text = cont.ToString();
                    Viewbox viewbox = new Viewbox();
                    viewbox.Child = text;
                    b.Content = viewbox;
                    b.Tag = cont.ToString();
                    Grid.SetColumn(b,i);
                    Grid.SetRow(b,x);
                        cont++;
                } 
            }

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string textoAnterior = texto.Text;
            texto.Text = textoAnterior + (sender as Button).Tag.ToString();
        }
        
    }
}
