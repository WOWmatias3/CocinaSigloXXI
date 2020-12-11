using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using BLL;

namespace CocinaSigloXXI_
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btningresar_Click(object sender, RoutedEventArgs e)
        {

            UsuarioBLL usrbll = new UsuarioBLL();
            bool check = usrbll.getLogin(txtnomb.Text, pswcontra.Password);
            if (check)
            {
                MessageBox.Show("Bienvenido " + txtnomb.Text);
                TableroCocina finanzas = new TableroCocina();
                finanzas.username = txtnomb.Text;
                Close();
                finanzas.Show();
            }
            else
            {
                MessageBox.Show("Credenciales o Rol Incorrectos \n Intente nuevamente");
            }
        }
    }

}
