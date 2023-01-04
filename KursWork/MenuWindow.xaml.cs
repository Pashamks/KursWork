using KursWork.DataBase;
using Syncfusion.UI.Xaml.Grid.Helpers;
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

namespace KursWork
{
    /// <summary>
    /// Interaction logic for MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        DbRepository dbRepository;
        public MenuWindow()
        {
            InitializeComponent();
            dbRepository = new DbRepository();

            // підписуємося на події        
            grid.KeyDown += Grid_KeyDown; ;
        }

        private void Grid_KeyDown(object sender, KeyEventArgs e)
        {
            
            if(e.Key == Key.Enter)
            {
                AddRow(grid.Items[grid.SelectedIndex]);
            }
            else if(e.Key == Key.Delete)
            {
                DeleteRow(grid.Items[grid.SelectedIndex]);
            }
        }

        // додаємо елемент до списку
        private void AddRow(object row)
        {
            try
            {
                if (row is Applications)
                {
                    var data = row as Applications;
                    dbRepository.AddApplication(data);
                }
                else if(row is Organizations)
                {
                    var data = row as Organizations;
                    dbRepository.AddOrganization(data);
                }
                else if(row is PlanTable)
                {
                    var data = row as PlanTable;
                    dbRepository.AddPlan(data);
                }
                else
                {
                    var data = row as Specializations;
                    dbRepository.AddSpecialization(data);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        // видаляємо елемент зі списку
        private void DeleteRow(object row)
        {
            if (row is Applications)
            {
                var data = row as Applications;
                dbRepository.Remove(data);
            }
            else if (row is Organizations)
            {
                var data = row as Organizations;
                dbRepository.Remove(data);
            }
            else if (row is PlanTable)
            {
                var data = row as PlanTable;
                dbRepository.Remove(data);
            }
            else
            {
                var data = row as Specializations;
                dbRepository.Remove(data);

            }           
        }
        private void PlanButton_Click(object sender, RoutedEventArgs e)
        {
            grid.ItemsSource = dbRepository.GetPlanList();
        }

        private void MeetingsButton_Click(object sender, RoutedEventArgs e)
        {
            grid.ItemsSource = dbRepository.GetApplicationsList();
        }

        private void SpecializationsButton_Click(object sender, RoutedEventArgs e)
        {
            grid.ItemsSource = dbRepository.GetSpecializationsList();
        }

        private void OrganizationsButton_Click(object sender, RoutedEventArgs e)
        {
            grid.ItemsSource = dbRepository.GetOrganizationsList();
        }
    }
}
