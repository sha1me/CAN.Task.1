using CAN.Task._1.Core;
using System;
using System.Windows;
using System.Windows.Controls;

namespace CAN.Task._1.View.Pages.TaskPages
{
    public partial class Task2Page : Page
    {
        public Task2Page()
        {
            InitializeComponent();
        }

        private void BtnMainPage_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new MainPage());
        }

        private void BtnTask2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double d = Convert.ToDouble(TbD.Text);
                double y = Convert.ToDouble(TbY.Text);

                MessageBox.Show($"F = {(Math.Log10(d) + 3.5*Math.Pow(d,2)+1)/Math.Cos(2*y)}", "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);

                TbD.Text = string.Empty;
                TbY.Text = string.Empty;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}