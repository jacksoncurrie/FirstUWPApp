using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace FirstUWPApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private MessageDialog CreateMessageDialog(string message, string title = "Alert!")
        {
            var dialog = new MessageDialog(message, title);
            return dialog;
        }

        private async void AlertMe_Click(object sender, RoutedEventArgs e)
        {
            var dialog = CreateMessageDialog(TextField.Text);
            await dialog.ShowAsync();
        }

        private void ChangeText_Click(object sender, RoutedEventArgs e)
        {
            TextField.Text = "Here is some new text for you...";
        }
    }
}
