﻿#pragma checksum "..\..\BensOnScreenKeyboardWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "736216076015B3B8F94F46849ECA8DEC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace BensOSK {
    
    
    /// <summary>
    /// BensOnScreenKeyboardWindow
    /// </summary>
    public partial class BensOnScreenKeyboardWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 5 "..\..\BensOnScreenKeyboardWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid keyGrid;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\BensOnScreenKeyboardWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid skinControlGrid;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\BensOnScreenKeyboardWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button normalButton;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\BensOnScreenKeyboardWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button blackButton;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\BensOnScreenKeyboardWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button blueButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WPFosk;component/bensonscreenkeyboardwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\BensOnScreenKeyboardWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 4 "..\..\BensOnScreenKeyboardWindow.xaml"
            ((BensOSK.BensOnScreenKeyboardWindow)(target)).Initialized += new System.EventHandler(this.Window_Initialized);
            
            #line default
            #line hidden
            return;
            case 2:
            this.keyGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.skinControlGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.normalButton = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\BensOnScreenKeyboardWindow.xaml"
            this.normalButton.Click += new System.Windows.RoutedEventHandler(this.normalButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.blackButton = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\BensOnScreenKeyboardWindow.xaml"
            this.blackButton.Click += new System.Windows.RoutedEventHandler(this.blackButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.blueButton = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\BensOnScreenKeyboardWindow.xaml"
            this.blueButton.Click += new System.Windows.RoutedEventHandler(this.blueButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

