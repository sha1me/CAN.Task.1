using CAN.Task._1.Core;
using System;
using System.Windows;
using System.Windows.Controls;

namespace CAN.Task._1.View.Pages.TaskPages
{
    public partial class Task5Page : Page
    {
        public Task5Page()
        {
            InitializeComponent();
        }

        private void BtnMainPage_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new MainPage());
        }
        private void BtnTask5_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double t = Convert.ToDouble(TbT.Text);
                double a = Convert.ToDouble(TbA.Text);
                double y = Convert.ToDouble(TbY.Text);


                MessageBox.Show($"D = {(7.8*Math.Pow(a,3)+3.52*t)/Math.Log10(a+2*y)+Math.Exp(y)}", "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);

                TbT.Text = string.Empty;
                TbA.Text = string.Empty;
                TbY.Text = string.Empty;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
