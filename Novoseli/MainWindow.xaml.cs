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
            // �������� ����� �� ���������� ����
            string userName = NameTextBox.Text;

            // ���������, ��� ��� �� ������
            if (string.IsNullOrWhiteSpace(userName))
            {
                MessageBox.Show("����������, ������� ���� ���.", "������", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                // ��������� ����� ����
                WelcomeWindow welcomeWindow = new WelcomeWindow(userName);
                welcomeWindow.Show(); // ���������� ����� ����

                // ��������� ������� ���� (���� �����)
                this.Close(); // ��������� ������� ����, ���� �� ������, ����� ��� �� ���������� ��������
            }
        }
    }
}