﻿#pragma checksum "..\..\..\..\..\View\UserControls\Bodys\ClientsUserControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "651BAD5D5A2E399A95FF3720F3EB8CE6"
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
    /// ClientsUserControl
    /// </summary>
    public partial class ClientsUserControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\..\..\View\UserControls\Bodys\ClientsUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddClient;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\..\View\UserControls\Bodys\ClientsUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditClient;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\..\View\UserControls\Bodys\ClientsUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RemoveClient;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\..\View\UserControls\Bodys\ClientsUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid ClientsDataGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/PMView;component/view/usercontrols/bodys/clientsusercontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\View\UserControls\Bodys\ClientsUserControl.xaml"
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
            this.AddClient = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\..\..\View\UserControls\Bodys\ClientsUserControl.xaml"
            this.AddClient.Click += new System.Windows.RoutedEventHandler(this.AddClient_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.EditClient = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\..\..\View\UserControls\Bodys\ClientsUserControl.xaml"
            this.EditClient.Click += new System.Windows.RoutedEventHandler(this.EditClient_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.RemoveClient = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\..\..\View\UserControls\Bodys\ClientsUserControl.xaml"
            this.RemoveClient.Click += new System.Windows.RoutedEventHandler(this.RemoveClient_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ClientsDataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 49 "..\..\..\..\..\View\UserControls\Bodys\ClientsUserControl.xaml"
            this.ClientsDataGrid.SelectedCellsChanged += new System.Windows.Controls.SelectedCellsChangedEventHandler(this.ClientsDataGrid_SelectedCellsChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

