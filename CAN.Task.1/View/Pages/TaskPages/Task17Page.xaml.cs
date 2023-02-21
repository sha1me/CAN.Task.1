using CAN.Task._1.Core;
using System;
using System.Windows;
using System.Windows.Controls;

namespace CAN.Task._1.View.Pages.TaskPages
{
    public partial class Task17Page : Page
    {
        public Task17Page()
        {
            InitializeComponent();
        }

        private void BtnMainPage_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new MainPage());
        }

        private void BtnTask17_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double y = Convert.ToDouble(TbY.Text);
                double n = Convert.ToDouble(TbN.Text);

                MessageBox.Show($"H = {(Math.Pow(y,2)-0.8*y+Math.Sqrt(y))/(23.1*Math.Pow(n,3)+Math.Cos(n))}", "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);

                TbY.Text = string.Empty;
                TbN.Text = string.Empty;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
