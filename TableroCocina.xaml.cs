using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using BLL;
using System.Data;
using System.Timers;
using System.Windows.Threading;
namespace CocinaSigloXXI_
{
    /// <summary>
    /// Lógica de interacción para TableroCocina.xaml
    /// </summary>
    public partial class TableroCocina : MetroWindow
    {
        public string username = null;
        DispatcherTimer oDispatcherTimer = new DispatcherTimer();
        public TableroCocina()
        {
            InitializeComponent();
        }
        private void Tablero_Loaded(object sender, RoutedEventArgs e)
        {
            lblusr.Content = "Nombre de usuario: " + username;

            oDispatcherTimer.Interval = new TimeSpan(0, 0, 5);
            oDispatcherTimer.Tick += (a, b) =>
            {
                PlatoBLL espBLL = new PlatoBLL();
                System.Data.DataTable dt = espBLL.Get_Orden_espera_plato();
                dtg_espera.ItemsSource = dt.DefaultView;

                PlatoBLL prepBLL = new PlatoBLL();
                System.Data.DataTable dta = prepBLL.Get_Orden_preparacion_plato();
                dtg_prep.ItemsSource = dta.DefaultView;

                PlatoBLL lisBLL = new PlatoBLL();
                System.Data.DataTable dtg = lisBLL.Get_Orden_listo_plato();
                dtg_listo.ItemsSource = dtg.DefaultView;

            };
        }

        private void btnvolver_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainwindow = new MainWindow();
            Close();
            mainwindow.ShowDialog();
        }

        private void dtg_espera_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                object item = dtg_espera.SelectedItem;

                if (item != null)
                {

                    string Orden = (dtg_espera.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                    string bebes = (dtg_espera.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;

                    PlatoBLL us = new PlatoBLL();
                    us.orden_id_orden = Int32.Parse(Orden);
                    us.Id_plato = Int32.Parse(bebes);
                    us.Alter_plato_Preparacion(us);

                }
                else
                {

                }
            }
            catch
            {

            }
        }

        private void dtg_prep_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                object item = dtg_prep.SelectedItem;

                if (item != null)
                {

                    string Orden = (dtg_prep.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                    string bebes = (dtg_prep.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;

                    PlatoBLL us = new PlatoBLL();
                    us.orden_id_orden = Int32.Parse(Orden);
                    us.Id_plato = Int32.Parse(bebes);
                    us.Alter_plato_Listo(us);

                }
                else
                {

                }
            }
            catch
            {

            }
        }

        private void dtg_listo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                object item = dtg_listo.SelectedItem;

                if (item != null)
                {

                    string Orden = (dtg_listo.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                    string bebes = (dtg_listo.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;

                    PlatoBLL us = new PlatoBLL();
                    us.orden_id_orden = Int32.Parse(Orden);
                    us.Id_plato = Int32.Parse(bebes);
                    us.Alter_plato_Entregado(us);

                }
                else
                {

                }
            }
            catch
            {

            }
        }

        private void btnespera_Click(object sender, RoutedEventArgs e)
        {
            oDispatcherTimer.Start();
        }

        private void btnpreparacion_Click(object sender, RoutedEventArgs e)
        {
            oDispatcherTimer.Stop();
        }
    }
}
