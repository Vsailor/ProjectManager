﻿#pragma checksum "..\..\..\View\UsersDetails.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6DF3163099F0330CBC2A73F868EFC6B8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PMDataLayer;
using PMView;
using PMView.View.WrapperVM;
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


namespace PMView {
    
    
    /// <summary>
    /// UsersDetails
    /// </summary>
    public partial class UsersDetails : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 100 "..\..\..\View\UsersDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveButton;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\..\View\UsersDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RetrieveButton;
        
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
            System.Uri resourceLocater = new System.Uri("/ProjectManager;component/view/usersdetails.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\UsersDetails.xaml"
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
            
            #line 10 "..\..\..\View\UsersDetails.xaml"
            ((PMView.UsersDetails)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 63 "..\..\..\View\UsersDetails.xaml"
            ((System.Windows.Controls.TextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.SomeProperty_Changed);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 65 "..\..\..\View\UsersDetails.xaml"
            ((System.Windows.Controls.TextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.SomeProperty_Changed);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 67 "..\..\..\View\UsersDetails.xaml"
            ((System.Windows.Controls.ComboBox)(target)).SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 69 "..\..\..\View\UsersDetails.xaml"
            ((System.Windows.Controls.ComboBox)(target)).SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 83 "..\..\..\View\UsersDetails.xaml"
            ((System.Windows.Controls.DatePicker)(target)).SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.ComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 85 "..\..\..\View\UsersDetails.xaml"
            ((System.Windows.Controls.TextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.SomeProperty_Changed);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 87 "..\..\..\View\UsersDetails.xaml"
            ((System.Windows.Controls.TextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.SomeProperty_Changed);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 89 "..\..\..\View\UsersDetails.xaml"
            ((System.Windows.Controls.TextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.SomeProperty_Changed);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 93 "..\..\..\View\UsersDetails.xaml"
            ((System.Windows.Controls.TextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.SomeProperty_Changed);
            
            #line default
            #line hidden
            return;
            case 11:
            this.SaveButton = ((System.Windows.Controls.Button)(target));
            
            #line 100 "..\..\..\View\UsersDetails.xaml"
            this.SaveButton.Click += new System.Windows.RoutedEventHandler(this.SaveButton_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.RetrieveButton = ((System.Windows.Controls.Button)(target));
            
            #line 109 "..\..\..\View\UsersDetails.xaml"
            this.RetrieveButton.Click += new System.Windows.RoutedEventHandler(this.RetrieveButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

