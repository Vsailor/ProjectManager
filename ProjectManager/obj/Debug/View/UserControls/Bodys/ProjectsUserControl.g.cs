﻿#pragma checksum "..\..\..\..\..\View\UserControls\Bodys\ProjectsUserControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0C1E4BA6D45668A20C4CF5B021690E49"
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


namespace PMView.View {
    
    
    /// <summary>
    /// ProjectsUserControl
    /// </summary>
    public partial class ProjectsUserControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\..\..\View\UserControls\Bodys\ProjectsUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid ProjectsDataGrid;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\..\View\UserControls\Bodys\ProjectsUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid ProjectDetailsGrid;
        
        #line default
        #line hidden
        
        
        #line 123 "..\..\..\..\..\View\UserControls\Bodys\ProjectsUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox TeamsListBox;
        
        #line default
        #line hidden
        
        
        #line 142 "..\..\..\..\..\View\UserControls\Bodys\ProjectsUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox EmployeesListBox;
        
        #line default
        #line hidden
        
        
        #line 168 "..\..\..\..\..\View\UserControls\Bodys\ProjectsUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ProfileImage;
        
        #line default
        #line hidden
        
        
        #line 177 "..\..\..\..\..\View\UserControls\Bodys\ProjectsUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border CustomerProfileButton;
        
        #line default
        #line hidden
        
        
        #line 257 "..\..\..\..\..\View\UserControls\Bodys\ProjectsUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid TasksDataGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/ProjectManager;component/view/usercontrols/bodys/projectsusercontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\View\UserControls\Bodys\ProjectsUserControl.xaml"
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
            this.ProjectsDataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 27 "..\..\..\..\..\View\UserControls\Bodys\ProjectsUserControl.xaml"
            this.ProjectsDataGrid.SelectedCellsChanged += new System.Windows.Controls.SelectedCellsChangedEventHandler(this.ProjectsDataGrid_SelectedCellsChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ProjectDetailsGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.TeamsListBox = ((System.Windows.Controls.ListBox)(target));
            
            #line 123 "..\..\..\..\..\View\UserControls\Bodys\ProjectsUserControl.xaml"
            this.TeamsListBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.TeamsListBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.EmployeesListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 5:
            this.ProfileImage = ((System.Windows.Controls.Image)(target));
            return;
            case 6:
            this.CustomerProfileButton = ((System.Windows.Controls.Border)(target));
            
            #line 177 "..\..\..\..\..\View\UserControls\Bodys\ProjectsUserControl.xaml"
            this.CustomerProfileButton.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.CustomerProfileButton_MouseDown);
            
            #line default
            #line hidden
            
            #line 177 "..\..\..\..\..\View\UserControls\Bodys\ProjectsUserControl.xaml"
            this.CustomerProfileButton.MouseEnter += new System.Windows.Input.MouseEventHandler(this.CustomerProfileButton_MouseEnter);
            
            #line default
            #line hidden
            
            #line 177 "..\..\..\..\..\View\UserControls\Bodys\ProjectsUserControl.xaml"
            this.CustomerProfileButton.MouseLeave += new System.Windows.Input.MouseEventHandler(this.CustomerProfileButton_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 222 "..\..\..\..\..\View\UserControls\Bodys\ProjectsUserControl.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddProject_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.TasksDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

