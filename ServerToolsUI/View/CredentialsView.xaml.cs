using System.Windows;
using System.Windows.Controls;

namespace ServerToolsUI.View
{
    /// <summary>
    /// Logical interaction for Credentials View.xam
    /// </summary>
    public partial class CredentialsView : UserControl
    {
        public CredentialsView()
        {
            InitializeComponent();
        }

        private void PasswordText_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (this.DataContext != null)
            { ((dynamic)this.DataContext).SecurePassword = ((PasswordBox)sender).SecurePassword; }
        }
    }
}
