using CAN.Task._1.Core;
using System;
using System.Windows;
using System.Windows.Controls;

namespace CAN.Task._1.View.Pages.TaskPages
{
    public partial class Task26Page : Page
    {
        public Task26Page()
        {
            InitializeComponent();
        }

        private void BtnMainPage_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new MainPage());
        }

        private void BtnTask26_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double y = Convert.ToDouble(TbY.Text);
                double u = Convert.ToDouble(TbU.Text);

                MessageBox.Show($"T = {(Math.Sin(2*u))/(Math.Log10(2*y+u))}", "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);

                TbY.Text = string.Empty;
                TbU.Text = string.Empty;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
