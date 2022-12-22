using System.Windows;
using System.Windows.Input;

namespace launcher_train.View
{
    public partial class LoginView : Window
    {
        private bool _AuthClosed = false;
        public LoginView()
        {
            InitializeComponent();
        }

        private void LoginView_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (_AuthClosed == false)
            {
                var res = MessageBox.Show("Вы действительно хотите выйти из приложения?", "Выход из приложения", 
                    MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (res == MessageBoxResult.No)
                    e.Cancel = true;
            }
        }

        private void LoginView_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void BtnMinimize_OnClick(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void BtnClose_OnClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnLogin_OnClick(object sender, RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }        
    }
}