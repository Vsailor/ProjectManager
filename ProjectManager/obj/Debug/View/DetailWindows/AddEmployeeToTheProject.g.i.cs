﻿#pragma checksum "..\..\..\..\View\DetailWindows\AddEmployeeToTheProject.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "529D0D5A436D9BC66B9AC57FA61D2DBD"
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
    /// AddEmployeeToTheProject
    /// </summary>
    public partial class AddEmployeeToTheProject : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 88 "..\..\..\..\View\DetailWindows\AddEmployeeToTheProject.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Name;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\..\View\DetailWindows\AddEmployeeToTheProject.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Surname;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\..\..\View\DetailWindows\AddEmployeeToTheProject.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Login;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\..\..\View\DetailWindows\AddEmployeeToTheProject.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Skype;
        
        #line default
        #line hidden
        
        
        #line 141 "..\..\..\..\View\DetailWindows\AddEmployeeToTheProject.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Countries;
        
        #line default
        #line hidden
        
        
        #line 149 "..\..\..\..\View\DetailWindows\AddEmployeeToTheProject.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Statuses;
        
        #line default
        #line hidden
        
        
        #line 157 "..\..\..\..\View\DetailWindows\AddEmployeeToTheProject.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox States;
        
        #line default
        #line hidden
        
        
        #line 166 "..\..\..\..\View\DetailWindows\AddEmployeeToTheProject.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Email;
        
        #line default
        #line hidden
        
        
        #line 186 "..\..\..\..\View\DetailWindows\AddEmployeeToTheProject.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox SkillsListBox;
        
        #line default
        #line hidden
        
        
        #line 205 "..\..\..\..\View\DetailWindows\AddEmployeeToTheProject.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid EmployeesCollectionDataGrid;
        
        #line default
        #line hidden
        
        
        #line 229 "..\..\..\..\View\DetailWindows\AddEmployeeToTheProject.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddButton;
        
        #line default
        #line hidden
        
        
        #line 234 "..\..\..\..\View\DetailWindows\AddEmployeeToTheProject.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RemoveButton;
        
        #line default
        #line hidden
        
        
        #line 239 "..\..\..\..\View\DetailWindows\AddEmployeeToTheProject.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ProfileButton;
        
        #line default
        #line hidden
        
        
        #line 244 "..\..\..\..\View\DetailWindows\AddEmployeeToTheProject.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveAllButton;
        
        #line default
        #line hidden
        
        
        #line 252 "..\..\..\..\View\DetailWindows\AddEmployeeToTheProject.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox EmployeesToAddListBox;
        
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
            System.Uri resourceLocater = new System.Uri("/ProjectManager;component/view/detailwindows/addemployeetotheproject.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\DetailWindows\AddEmployeeToTheProject.xaml"
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
            
            #line 10 "..\..\..\..\View\DetailWindows\AddEmployeeToTheProject.xaml"
            ((PMView.AddEmployeeToTheProject)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Name = ((System.Windows.Controls.TextBox)(target));
            
            #line 88 "..\..\..\..\View\DetailWindows\AddEmployeeToTheProject.xaml"
            this.Name.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Name_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Surname = ((System.Windows.Controls.TextBox)(target));
            
            #line 99 "..\..\..\..\View\DetailWindows\AddEmployeeToTheProject.xaml"
            this.Surname.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Surname_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Login = ((System.Windows.Controls.TextBox)(target));
            
            #line 110 "..\..\..\..\View\DetailWindows\AddEmployeeToTheProject.xaml"
            this.Login.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Login_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Skype = ((System.Windows.Controls.TextBox)(target));
            
            #line 121 "..\..\..\..\View\DetailWindows\AddEmployeeToTheProject.xaml"
            this.Skype.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Skype_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Countries = ((System.Windows.Controls.ComboBox)(target));
            
            #line 141 "..\..\..\..\View\DetailWindows\AddEmployeeToTheProject.xaml"
            this.Countries.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Countries_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Statuses = ((System.Windows.Controls.ComboBox)(target));
            
            #line 149 "..\..\..\..\View\DetailWindows\AddEmployeeToTheProject.xaml"
            this.Statuses.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Statuses_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.States = ((System.Windows.Controls.ComboBox)(target));
            
            #line 157 "..\..\..\..\View\DetailWindows\AddEmployeeToTheProject.xaml"
            this.States.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.States_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Email = ((System.Windows.Controls.TextBox)(target));
            
            #line 166 "..\..\..\..\View\DetailWindows\AddEmployeeToTheProject.xaml"
            this.Email.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Email_TextChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.SkillsListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 11:
            this.EmployeesCollectionDataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 209 "..\..\..\..\View\DetailWindows\AddEmployeeToTheProject.xaml"
            this.EmployeesCollectionDataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.EmployeesCollectionDataGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 12:
            this.AddButton = ((System.Windows.Controls.Button)(target));
            
            #line 229 "..\..\..\..\View\DetailWindows\AddEmployeeToTheProject.xaml"
            this.AddButton.Click += new System.Windows.RoutedEventHandler(this.AddButton_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.RemoveButton = ((System.Windows.Controls.Button)(target));
            
            #line 234 "..\..\..\..\View\DetailWindows\AddEmployeeToTheProject.xaml"
            this.RemoveButton.Click += new System.Windows.RoutedEventHandler(this.RemoveButton_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.ProfileButton = ((System.Windows.Controls.Button)(target));
            
            #line 239 "..\..\..\..\View\DetailWindows\AddEmployeeToTheProject.xaml"
            this.ProfileButton.Click += new System.Windows.RoutedEventHandler(this.ProfileButton_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            this.SaveAllButton = ((System.Windows.Controls.Button)(target));
            
            #line 244 "..\..\..\..\View\DetailWindows\AddEmployeeToTheProject.xaml"
            this.SaveAllButton.Click += new System.Windows.RoutedEventHandler(this.SaveAllButton_Click);
            
            #line default
            #line hidden
            return;
            case 16:
            this.EmployeesToAddListBox = ((System.Windows.Controls.ListBox)(target));
            
            #line 252 "..\..\..\..\View\DetailWindows\AddEmployeeToTheProject.xaml"
            this.EmployeesToAddListBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.EmployeesToAddListBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

