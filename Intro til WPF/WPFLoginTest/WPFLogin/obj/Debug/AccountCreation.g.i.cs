﻿#pragma checksum "..\..\AccountCreation.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D1DC365E2D4F1D65EE128FAFB8B7B6C71B3470AA5F3F588DC9969241DE73EE6B"
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
using WPFLogin;


namespace WPFLogin {
    
    
    /// <summary>
    /// AccountCreation
    /// </summary>
    public partial class AccountCreation : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 45 "..\..\AccountCreation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox enterFirstName;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\AccountCreation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox enterLastName;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\AccountCreation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox enterAccountName;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\AccountCreation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox enterEmail;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\AccountCreation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox enterPassword;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\AccountCreation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox confirmPassword;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\AccountCreation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button submitButton;
        
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
            System.Uri resourceLocater = new System.Uri("/WPFLogin;component/accountcreation.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AccountCreation.xaml"
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
            this.enterFirstName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.enterLastName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.enterAccountName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.enterEmail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.enterPassword = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 6:
            this.confirmPassword = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 7:
            this.submitButton = ((System.Windows.Controls.Button)(target));
            
            #line 104 "..\..\AccountCreation.xaml"
            this.submitButton.Click += new System.Windows.RoutedEventHandler(this.submitButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
