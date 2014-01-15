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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Runtime.InteropServices;
using System.Windows.Interop;

namespace BensOSK
{
    /// <summary>
    /// Interaction logic for BensOnScreenKeyboard.xaml
    /// </summary>
    public partial class BensOnScreenKeyboard : UserControl
    {
        [DllImport("user32.dll")]
        public static extern int SetWindowLong(IntPtr hWnd, int nIndex, IntPtr dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern UInt32 GetWindowLong(IntPtr hWnd, int nIndex);

        /// <summary>
        /// Get or set the collection of keys 
        /// </summary>
        private List<Button> keyCollection = new List<Button>();

        /// <summary>
        /// Get or set this controls parent window
        /// </summary>
        private Window parentWindow;

        /// <summary>
        /// Get or set this controls element to focus on
        /// </summary>
        private IInputElement focusedInputElement;

        /// <summary>
        /// Create a new BensOnScreenKeyboard
        /// </summary>
        /// <param name="parent">The parent window that calls this control</param>
        public BensOnScreenKeyboard(Window parent)
        {
            // set parent
            this.parentWindow = parent;
            // setup this control
            this.setupKeyboardControl();
        }

        /// <summary>
        /// Create a new SingerOnScreenKeyboard
        /// </summary>
        /// <param name="parent">A specified element to hold this controls focus</param>
        public BensOnScreenKeyboard(IInputElement elementToFocusOn)
        {
            // set focus
            this.focusedInputElement = elementToFocusOn;
            // setup this control
            this.setupKeyboardControl();
        }

        /// <summary>
        /// Setup the keyboard control
        /// </summary>
        private void setupKeyboardControl()
        {
            InitializeComponent();
            // add all keys to internal collection
            this.addAllKeysToInternalCollection();
            // install clicks
            this.installAllClickEventsForCollection(this.keyCollection);
        }

        /// <summary>
        /// Add all keys to internal collection
        /// </summary>
        private void addAllKeysToInternalCollection()
        {
            // itterate all panels
            foreach (Panel panelElement in allKeysGrid.Children)
            {
                // itterate all buttons
                foreach (Button buttonElement in panelElement.Children)
                {
                    // add to list
                    this.keyCollection.Add(buttonElement);
                }
            }
        }

        /// <summary>
        /// Install click events for all keys in a collection
        /// </summary>
        /// <param name="keysToInstall"></param>
        private void installAllClickEventsForCollection(List<Button> keysToInstall)
        {
            // itterate all
            foreach (Button buttonElement in keysToInstall)
            {
                // install click event
                buttonElement.Click += new RoutedEventHandler(buttonElement_Click);
            }
        }

        /// <summary>
        /// Switch the character case of all buttons in a given list
        /// </summary>
        /// <param name="keysToSwitch"></param>
        private void switchCase(List<Button> keysToSwitch)
        {
            // itterate all
            foreach (Button buttonElement in keysToSwitch)
            {
                // if key is single char
                if (buttonElement.Content.ToString().Length == 1)
                {
                    // switch char
                    buttonElement.Content = this.switchCase(buttonElement.Content.ToString());
                    // switch command parameter
                    buttonElement.CommandParameter = this.switchCase(buttonElement.CommandParameter.ToString());
                }
            }

            // set abc button size
            this.shiftButton.Content = this.switchCase(this.shiftButton.Content.ToString());
        }

        /// <summary>
        /// Switch the case of an input string
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        private String switchCase(String inputString)
        {
            // if a string
            if (!String.IsNullOrEmpty(inputString))
            {
                // the string to return
                String returnString = "";

                // switch each char of string
                foreach (Char currentChar in inputString)
                {
                    // if a capital
                    if ((currentChar >= 65) && (currentChar <= 90))
                    {
                        // set to lower
                        returnString += currentChar.ToString().ToLower();
                    }
                    // else if lower
                    else if ((currentChar >= 97) && (currentChar <= 122))
                    {
                        // set to upper
                        returnString += currentChar.ToString().ToUpper();
                    }
                    else
                    {
                        // add as it is
                        returnString += currentChar.ToString();
                    }
                }

                // return string
                return returnString;
            }
            else
            {
                // return black string
                return "";
            }
        }

        void buttonElement_Click(object sender, RoutedEventArgs e)
        {
            // create variable for holding string
            String sendString = "";

            try
            {
                // stop all event handling
                e.Handled = true;

                // set sendstring to key
                sendString = ((Button)sender).CommandParameter.ToString();

                // if something to send
                if (!String.IsNullOrEmpty(sendString))
                {
                    // if sending a string
                    if (sendString.Length > 1)
                    {
                        // add {}
                        sendString = "{" + sendString + "}";
                    }

                    // if a focusable element has been specified
                    if (this.focusedInputElement != null)
                    {
                        // set keyboard focus
                        Keyboard.Focus(this.focusedInputElement);
                        // set normal focus
                        this.focusedInputElement.Focus();
                    }

                    // send key to simulate key press
                    System.Windows.Forms.SendKeys.SendWait(sendString);
                    
                }
            }
            catch (Exception)
            {
                // do nothing - not important for now
                Console.WriteLine("Could not send key press: {0}", sendString);
            }
        }

        private void shiftButton_Click(object sender, RoutedEventArgs e)
        {
            // switch case
            this.switchCase(this.keyCollection);
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            // if we have specified a parent
            if (this.parentWindow != null)
            {
                // Get this window's handle
                IntPtr HWND = new WindowInteropHelper(this.parentWindow).Handle;

                // style of window?
                int GWL_EXSTYLE = (-20);
                // get - retrieves information about a specified window
                GetWindowLong(HWND, GWL_EXSTYLE);
                // set - changes the attribute of a specified window - I think this stops it being focused on
                SetWindowLong(HWND, GWL_EXSTYLE, (IntPtr)(0x8000000));
            }
        }


    }
}
