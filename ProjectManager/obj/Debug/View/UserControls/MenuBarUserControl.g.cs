﻿#pragma checksum "..\..\..\..\View\UserControls\MenuBarUserControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4959F0B2F702B954516313BC5FB08602"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PMView.View;
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


namespace PMView.View {
    
    
    /// <summary>
    /// MenuBarUserControl
    /// </summary>
    public partial class MenuBarUserControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\..\View\UserControls\MenuBarUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ProjectsButton;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\View\UserControls\MenuBarUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ClientsButton;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\View\UserControls\MenuBarUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EmployeesButton;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\View\UserControls\MenuBarUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button TeamsButton;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\View\UserControls\MenuBarUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ReportsButton;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\View\UserControls\MenuBarUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MessagesButton;
        
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
            System.Uri resourceLocater = new System.Uri("/ProjectManager;component/view/usercontrols/menubarusercontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\UserControls\MenuBarUserControl.xaml"
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
            this.ProjectsButton = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\..\View\UserControls\MenuBarUserControl.xaml"
            this.ProjectsButton.Click += new System.Windows.RoutedEventHandler(this.ProjectsButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ClientsButton = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\..\View\UserControls\MenuBarUserControl.xaml"
            this.ClientsButton.Click += new System.Windows.RoutedEventHandler(this.ClientsButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.EmployeesButton = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\..\View\UserControls\MenuBarUserControl.xaml"
            this.EmployeesButton.Click += new System.Windows.RoutedEventHandler(this.EmployeesButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TeamsButton = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\..\View\UserControls\MenuBarUserControl.xaml"
            this.TeamsButton.Click += new System.Windows.RoutedEventHandler(this.TeamsButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ReportsButton = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\..\View\UserControls\MenuBarUserControl.xaml"
            this.ReportsButton.Click += new System.Windows.RoutedEventHandler(this.ReportsButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.MessagesButton = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\..\View\UserControls\MenuBarUserControl.xaml"
            this.MessagesButton.Click += new System.Windows.RoutedEventHandler(this.MessagesButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
