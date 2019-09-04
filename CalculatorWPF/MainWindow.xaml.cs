using System;
using System.Windows;
using Calc;
using System.Windows.Controls;


namespace CalculatorWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Calculator c = new Calculator();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double val1 = Convert.ToDouble(boxval1.Text), val2 = Convert.ToDouble(boxval2.Text);
            switch (Combo.Text)
            {
                case "Add":
                    MessageBox.Show("Results are: " + c.Add(val1, val2));
                    break;
                case "Subtract":
                    MessageBox.Show("Result is: " + c.Subtract(val1, val2));
                    break;
                case "Multiply":
                    MessageBox.Show("Result is: " + c.Multiply(val1 , val2));
                    break;
                case "Divide":
                    MessageBox.Show("Result is: " + c.Divide(val1, val2));
                    break;
            }
        }

        private void Boxval2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
