using CAN.Task._1.Core;
using System;
using System.Windows;
using System.Windows.Controls;

namespace CAN.Task._1.View.Pages.TaskPages
{
    public partial class Task16Page : Page
    {
        public Task16Page()
        {
            InitializeComponent();
        }

        private void BtnMainPage_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new MainPage());
        }
        private void BtnTask16_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double t = Convert.ToDouble(TbT.Text);
                double r = Convert.ToDouble(TbR.Text);
                double y = Convert.ToDouble(TbY.Text);

                MessageBox.Show($"W = {(4 * Math.Pow(t, 3) + Math.Log10(r) / (Math.Exp(y+r)+7.2*Math.Sin(r)))}", "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);

                TbT.Text = string.Empty;
                TbR.Text = string.Empty;
                TbY.Text = string.Empty;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
