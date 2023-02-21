using CAN.Task._1.Core;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Media3D;

namespace CAN.Task._1.View.Pages.TaskPages
{
    public partial class Task14Page : Page
    {
        public Task14Page()
        {
            InitializeComponent();
        }

        private void BtnMainPage_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new MainPage());
        }

        private void BtnTask14_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double y = Convert.ToDouble(TbY.Text);
                double h = Convert.ToDouble(TbH.Text);

                MessageBox.Show($"P = {(Math.Exp(y+2.5)+7.1*Math.Pow(h,3))/(Math.Log10(Math.Sqrt(y+0.04*h)))}", "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);

                TbY.Text = string.Empty;
                TbH.Text = string.Empty;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
