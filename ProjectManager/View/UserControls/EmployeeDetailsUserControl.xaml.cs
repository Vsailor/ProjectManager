﻿using PMDataLayer;
using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PMView.View
{
    /// <summary>
    /// Interaction logic for EmployeeDetailsUserControl.xaml
    /// </summary>
    public partial class EmployeeDetailsUserControl : UserControl
    {
        private EmployeeDetailsUserControlVM _employeeDetailsUserControlVM;

        private List<CheckBox> _skills = new List<CheckBox>();

        public EmployeeDetailsUserControl(IEmployee employee, ILoadData lastScreen)
        {
            InitializeComponent();
            _employeeDetailsUserControlVM = new EmployeeDetailsUserControlVM(employee, lastScreen);
            DataContext = _employeeDetailsUserControlVM;

            foreach (var item in Skill.Items)
            {
                var cb = new CheckBox();
                cb.Content = item.Name;
                _skills.Add(cb);
                cb.IsChecked = false;
                cb.Click += new System.Windows.RoutedEventHandler(this.CheckBox_Checked);
            }
            SkillsListBox.Items.Clear();
            foreach (var item in _skills)
            {
                SkillsListBox.Items.Add(item);
            }
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}