using CAN.Task._1.Core;
using System;
using System.Windows;
using System.Windows.Controls;

namespace CAN.Task._1.View.Pages.TaskPages
{
    public partial class Task24Page : Page
    {
        public Task24Page()
        {
            InitializeComponent();
        }

        private void BtnMainPage_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new MainPage());
        }

        private void BtnTask24_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double y = Convert.ToDouble(TbY.Text);
                double k = Convert.ToDouble(TbK.Text);

                MessageBox.Show($"U = {(Math.Log10(2*k+4.3))/(Math.Exp(k+y)+Math.Sqrt(y))}", "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);

                TbY.Text = string.Empty;
                TbK.Text = string.Empty;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
