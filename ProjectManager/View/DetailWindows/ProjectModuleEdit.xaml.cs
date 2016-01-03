﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using PMView.View;
using PMView.View.WrapperVM;

namespace PMView
{
    /// <summary>
    /// Interaction logic for ProjectModuleEdit.xaml
    /// </summary>
    public partial class ProjectModuleEdit : Window
    {
        private ProjectsUserControlVM _projectsUserControlVM;

        private ProjectModuleEditVM _projectModuleEditVM;

        public ProjectModuleEdit()
        {
            InitializeComponent();
        }

        public ProjectModuleEdit(ProjectsUserControlVM projectsUserControlVM)
        {
            InitializeComponent();
            _projectsUserControlVM = projectsUserControlVM;
            _projectModuleEditVM = new ProjectModuleEditVM(_projectsUserControlVM.SelectedOrder);
            DataContext = _projectModuleEditVM;
        }

        private void SomeProperty_Changed(object sender, TextChangedEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void Button_Cli2ck(object sender, RoutedEventArgs e)
        {

        }
    }
}
