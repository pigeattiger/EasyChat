using System.Windows;
using System.Windows.Input;

namespace EasyChat.Views
{
    public partial class ChatView : Window
    {
        public ChatView()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }

        }

        bool IsMaximized = false;
        private void Boreder_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ClickCount ==2)
            {
                if(IsMaximized)
                {
                    this.WindowState = WindowState.Normal;
                    this.Width = 1250;
                    this.Height = 830;

                    IsMaximized = false;
                }
                else
                {
                    this.WindowState = WindowState.Maximized;
                    IsMaximized = true;
                }
            }
        }
    }
}
