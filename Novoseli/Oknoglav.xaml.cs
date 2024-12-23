using System.Globalization;
using System;
using System.Windows;
using System.Windows.Data;

namespace LoginApp
{
    public partial class WelcomeWindow : Window
    {

        public WelcomeWindow(string userName)
        {
            InitializeComponent();
            this.Title = $"Добро пожаловать, {userName}!";
        }


        private void AddMaterial_Click(object sender, RoutedEventArgs e)
        {
            if (decimal.TryParse(MaterialPriceTextBox.Text, out decimal price) &&
                int.TryParse(MaterialQuantityTextBox.Text, out int quantity))
            {
                var material = new Material
                {
                    Name = MaterialNameTextBox.Text,
                    Price = price,
                    Quantity = quantity
                };
                MaterialsListBox.Items.Add(material);
                MaterialNameTextBox.Clear();
                MaterialQuantityTextBox.Clear();
                MaterialPriceTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректные данные для материала.");
            }
        }

        private void ShowCost_Click(object sender, RoutedEventArgs e)
        {
            decimal totalCost = 0;
            foreach (Material material in MaterialsListBox.Items)
            {
                totalCost += material.Price * material.Quantity;
            }
            TotalCostTextBlock.Text = $"Общая стоимость: {totalCost:C}";
        }
    }

    public class Newcomer
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }

    public class Material
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Quantity} шт. по {Price:C} за единицу";
        }
    }

    public class LengthToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is int length)
            {
                return length == 0 ? Visibility.Visible : Visibility.Collapsed;
            }
            return Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}