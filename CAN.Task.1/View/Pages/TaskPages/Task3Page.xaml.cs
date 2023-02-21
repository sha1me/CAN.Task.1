using CAN.Task._1.Core;
using System;
using System.Windows;
using System.Windows.Controls;

namespace CAN.Task._1.View.Pages.TaskPages
{
    public partial class Task3Page : Page
    {
        public Task3Page()
        {
            InitializeComponent();
        }

        private void BtnMainPage_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new MainPage());
        }

        private void BtnTask3_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double k = Convert.ToDouble(TbK.Text);
                double y = Convert.ToDouble(TbY.Text);

                MessageBox.Show($"U = {(Math.Log10(k-y)+Math.Pow(y,4))/(Math.Exp(y)+2.355*Math.Pow(k,2))}", "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);

                TbK.Text = string.Empty;
                TbY.Text = string.Empty;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}