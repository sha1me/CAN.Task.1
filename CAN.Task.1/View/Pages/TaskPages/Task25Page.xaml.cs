using CAN.Task._1.Core;
using System;
using System.Windows;
using System.Windows.Controls;

namespace CAN.Task._1.View.Pages.TaskPages
{
    public partial class Task25Page : Page
    {
        public Task25Page()
        {
            InitializeComponent();
        }

        private void BtnMainPage_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new MainPage());
        }

        private void BtnTask25_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double c = Convert.ToDouble(TbC.Text);
                double t = Convert.ToDouble(TbT.Text);

                MessageBox.Show($"L = {Math.Pow(Math.Cos(c),2)+(3*Math.Pow(t,2)+4)/(Math.Sqrt(c+t))}", "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);

                TbC.Text = string.Empty;
                TbT.Text = string.Empty;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
