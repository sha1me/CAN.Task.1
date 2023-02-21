using CAN.Task._1.Core;
using System;
using System.Windows;
using System.Windows.Controls;

namespace CAN.Task._1.View.Pages.TaskPages
{
    public partial class Task1Page : Page
    {
        public Task1Page()
        {
            InitializeComponent();
        }

        private void BtnMainPage_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new MainPage());
        }
        private void BtnTask1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double y = Convert.ToDouble(TbY.Text);
                double f = Convert.ToDouble(TbF.Text);

                MessageBox.Show($"G = {Math.Exp(2*y) + Math.Sin(f)/Math.Log10(3.8*y+f)}", "Системное сообщение", 
                    MessageBoxButton.OK, 
                    MessageBoxImage.Error);

                TbY.Text = string.Empty; 
                TbF.Text = string.Empty;   
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(),"Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
