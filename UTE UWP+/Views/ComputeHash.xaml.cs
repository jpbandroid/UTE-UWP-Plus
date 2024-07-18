using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using UTE_UWP_.Helpers;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UTE_UWP_.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ComputeHash : Page
    {
        public ComputeHash()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainPage mainPage = (App.Window.Content as Frame).Content as MainPage;
            string docText = mainPage.docText;
            docText = EncryptorsDecryptors.Base64Encode(docText);
            base64_result.Text = docText;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainPage mainPage = (App.Window.Content as Frame).Content as MainPage;
            string docText = mainPage.docText;
            docText = EncryptorsDecryptors.Base64Decode(docText);
            base64_result.Text = docText;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainPage mainPage = (App.Window.Content as Frame).Content as MainPage;
            string docText = mainPage.docText;
            docText = EncryptorsDecryptors.SHA1Encrypt(docText);
            sha1_result.Text = docText;
        }
    }
}
