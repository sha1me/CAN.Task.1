using CAN.Task._1.Core;
using System;
using System.Windows;
using System.Windows.Controls;

namespace CAN.Task._1.View.Pages.TaskPages
{
    public partial class Task19Page : Page
    {
        public Task19Page()
        {
            InitializeComponent();
        }

        private void BtnMainPage_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new MainPage());
        }
        private void BtnTask19_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double y = Convert.ToDouble(TbY.Text);
                double q = Convert.ToDouble(TbQ.Text);

                MessageBox.Show($"E = {(Math.Log10(0.7*y+2*q))/(Math.Sqrt(3*Math.Pow(y,2)+0.5*y+4))}", "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);

                TbY.Text = string.Empty;
                TbQ.Text = string.Empty;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
