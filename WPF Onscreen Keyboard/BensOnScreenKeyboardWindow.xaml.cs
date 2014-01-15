using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BensOSK
{
    /// <summary>
    /// Interaction logic for BensOnScreenKeyboardWindow.xaml
    /// </summary>
    public partial class BensOnScreenKeyboardWindow : Window
    {
        /// <summary>
        /// Create a new BensOnScreenKeyboardWindow
        /// </summary>
        public BensOnScreenKeyboardWindow()
        {
            InitializeComponent();
            // add keyboard
            this.keyGrid.Children.Add(new BensOnScreenKeyboard(this));
        }

        /// <summary>
        /// Create a new BensOnScreenKeyboardWindow
        /// </summary>
        /// <param name="focusableElement">Specifies element to hold keyboards focus</param>
        public BensOnScreenKeyboardWindow(IInputElement focusableElement)
        {
            InitializeComponent();
            // add keyboard
            this.keyGrid.Children.Add(new BensOnScreenKeyboard(focusableElement));
        }

        /// <summary>
        /// Setup this window
        /// </summary>
        private void setupKeyboardWindow()
        {
            //// set top
            //this.Top = SystemParameters.PrimaryScreenHeight - this.Height;
            //// set left
            //this.Left = 0;
            //// set width
            //this.Width = SystemParameters.PrimaryScreenWidth;
        }

        /// <summary>
        /// Set the apps skin
        /// </summary>
        /// <param name="skinName"></param>
        private void setSkin(String skinName)
        {
            // create uri to skin
            Uri skinUri = new Uri(String.Format("/Skins/{0}.xaml", skinName), UriKind.Relative);
            // tell app to load skins
            App app = Application.Current as App;
            // load skins
            app.ApplySkin(skinUri);
        }

        private void Window_Initialized(object sender, EventArgs e)
        {
            // setup
            this.setupKeyboardWindow();
        }

        private void normalButton_Click(object sender, RoutedEventArgs e)
        {
            // set skin
            this.setSkin(normalButton.CommandParameter.ToString());
        }

        private void blackButton_Click(object sender, RoutedEventArgs e)
        {
            // set skin
            this.setSkin(blackButton.CommandParameter.ToString());
        }

        private void blueButton_Click(object sender, RoutedEventArgs e)
        {
            // set skin
            this.setSkin(blueButton.CommandParameter.ToString());
        }
    }

}
