﻿#pragma checksum "..\..\..\..\View\DetailWindows\AddTeamToTheProject.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A8B96910354ACA18D5E6190F94C757D8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
    /// AddTeamToTheProject
    /// </summary>
    public partial class AddTeamToTheProject : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 52 "..\..\..\..\View\DetailWindows\AddTeamToTheProject.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Name;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\..\View\DetailWindows\AddTeamToTheProject.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid TeamsCollectionDataGrid;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\..\View\DetailWindows\AddTeamToTheProject.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox TeamsToAddListBox;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\..\View\DetailWindows\AddTeamToTheProject.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddButton;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\..\..\View\DetailWindows\AddTeamToTheProject.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RemoveButton;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\..\..\View\DetailWindows\AddTeamToTheProject.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DetailsButton;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\..\..\View\DetailWindows\AddTeamToTheProject.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveAllButton;
        
        #line default
        #line hidden
        
        
        #line 137 "..\..\..\..\View\DetailWindows\AddTeamToTheProject.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddSkill;
        
        #line default
        #line hidden
        
        
        #line 146 "..\..\..\..\View\DetailWindows\AddTeamToTheProject.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox SkillsListBox;
        
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
            System.Uri resourceLocater = new System.Uri("/PMView;component/view/detailwindows/addteamtotheproject.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\DetailWindows\AddTeamToTheProject.xaml"
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
            
            #line 8 "..\..\..\..\View\DetailWindows\AddTeamToTheProject.xaml"
            ((PMView.AddTeamToTheProject)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Name = ((System.Windows.Controls.TextBox)(target));
            
            #line 52 "..\..\..\..\View\DetailWindows\AddTeamToTheProject.xaml"
            this.Name.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Name_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TeamsCollectionDataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 67 "..\..\..\..\View\DetailWindows\AddTeamToTheProject.xaml"
            this.TeamsCollectionDataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DataGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TeamsToAddListBox = ((System.Windows.Controls.ListBox)(target));
            
            #line 79 "..\..\..\..\View\DetailWindows\AddTeamToTheProject.xaml"
            this.TeamsToAddListBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.TeamsToAddListBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.AddButton = ((System.Windows.Controls.Button)(target));
            
            #line 101 "..\..\..\..\View\DetailWindows\AddTeamToTheProject.xaml"
            this.AddButton.Click += new System.Windows.RoutedEventHandler(this.AddButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.RemoveButton = ((System.Windows.Controls.Button)(target));
            
            #line 106 "..\..\..\..\View\DetailWindows\AddTeamToTheProject.xaml"
            this.RemoveButton.Click += new System.Windows.RoutedEventHandler(this.RemoveButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.DetailsButton = ((System.Windows.Controls.Button)(target));
            
            #line 111 "..\..\..\..\View\DetailWindows\AddTeamToTheProject.xaml"
            this.DetailsButton.Click += new System.Windows.RoutedEventHandler(this.DetailsButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.SaveAllButton = ((System.Windows.Controls.Button)(target));
            
            #line 116 "..\..\..\..\View\DetailWindows\AddTeamToTheProject.xaml"
            this.SaveAllButton.Click += new System.Windows.RoutedEventHandler(this.SaveAllButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.AddSkill = ((System.Windows.Controls.Button)(target));
            
            #line 137 "..\..\..\..\View\DetailWindows\AddTeamToTheProject.xaml"
            this.AddSkill.Click += new System.Windows.RoutedEventHandler(this.AddSkill_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.SkillsListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

