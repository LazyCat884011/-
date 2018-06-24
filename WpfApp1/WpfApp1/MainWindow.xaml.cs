using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        int itemnumber = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MySlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            GameTxt.Text = MySlider.Value.ToString();
        }

        private void WorkSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            WorkTxt.Text = WorkSlider.Value.ToString();
        }
        private void addTask_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
            // 產生
            UserControl1 text1 = new UserControl1();
            itemnumber = itemnumber + 1;
            //放到清單
            TaskList.Children.Add(text1);
            
            text1.ItN.Text = itemnumber.ToString();
            
        }
    }
}
