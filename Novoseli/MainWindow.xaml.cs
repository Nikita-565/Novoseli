using System.Windows;

namespace LoginApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            // Получаем текст из текстового поля
            string userName = NameTextBox.Text;

            // Проверяем, что имя не пустое
            if (string.IsNullOrWhiteSpace(userName))
            {
                MessageBox.Show("Пожалуйста, введите ваше имя.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                // Открываем новое окно
                WelcomeWindow welcomeWindow = new WelcomeWindow(userName);
                welcomeWindow.Show(); // Показываем новое окно

                // Закрываем текущее окно (если нужно)
                this.Close(); // Закрывает текущее окно, если вы хотите, чтобы оно не оставалось открытым
            }
        }
    }
}