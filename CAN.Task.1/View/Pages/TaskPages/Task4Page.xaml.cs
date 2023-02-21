using CAN.Task._1.Core;
using System;
using System.Windows;
using System.Windows.Controls;

namespace CAN.Task._1.View.Pages.TaskPages
{
    public partial class Task4Page : Page
    {
        public Task4Page()
        {
            InitializeComponent();
        }

        private void BtnMainPage_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new MainPage());
        }
        private void BtnTask4_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double w = Convert.ToDouble(TbW.Text);
                double y = Convert.ToDouble(TbY.Text);

                MessageBox.Show($"G = {(9.33*Math.Pow(w,3)+Math.Sqrt(w))/Math.Log10(y+3.5)+Math.Sqrt(y)}", "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);

                TbW.Text = string.Empty;
                TbY.Text = string.Empty;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}