﻿#pragma checksum "..\..\..\Pages\pageMainMenu.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "182A51DB62701A0E8B01828E49CF56B03E0E48E1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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
using WpfApp1.Pages;


namespace WpfApp1.Pages {
    
    
    /// <summary>
    /// pageMainMenu
    /// </summary>
    public partial class pageMainMenu : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\Pages\pageMainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button New_Game;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Pages\pageMainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Options;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Pages\pageMainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Leaderboard;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Pages\pageMainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Instructions;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Pages\pageMainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Exit_Game;
        
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
            System.Uri resourceLocater = new System.Uri("/TheUndergroundTower;component/pages/pagemainmenu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\pageMainMenu.xaml"
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
            this.New_Game = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\Pages\pageMainMenu.xaml"
            this.New_Game.Click += new System.Windows.RoutedEventHandler(this.New_Game_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Options = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\Pages\pageMainMenu.xaml"
            this.Options.Click += new System.Windows.RoutedEventHandler(this.Options_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Leaderboard = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\Pages\pageMainMenu.xaml"
            this.Leaderboard.Click += new System.Windows.RoutedEventHandler(this.Leaderboard_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Instructions = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\Pages\pageMainMenu.xaml"
            this.Instructions.Click += new System.Windows.RoutedEventHandler(this.Instructions_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Exit_Game = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\Pages\pageMainMenu.xaml"
            this.Exit_Game.Click += new System.Windows.RoutedEventHandler(this.Exit_Game_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
