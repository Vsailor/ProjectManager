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
using PMDataLayer;

namespace PMView
{
    /// <summary>
    /// Interaction logic for ProjectModuleEdit.xaml
    /// </summary>
    public partial class ProjectModuleEdit : Window, ILoadDataSender, ILoadData
    {
        private ILoadData _lastScreen;

        private ProjectModuleEditVM _projectModuleEditVM;
        private List<CheckBox> _skills = new List<CheckBox>();
        private List<CheckBox> _savedSkills;
        private ProjectVM _projectVM;

        public ProjectModuleEdit(ProjectsUserControlVM projectsUserControlVM)
        {
            InitializeComponent();
            _lastScreen = projectsUserControlVM;
            _projectModuleEditVM = new ProjectModuleEditVM(this, projectsUserControlVM);
            DataContext = _projectModuleEditVM;
            fillCheckboxList();
            FormTitle.Text = "Add module";
        }

        public ProjectModuleEdit(ProjectsUserControlVM projectsUserControlVM, ProjectVM projectVM)
        {
            InitializeComponent();
            _lastScreen = projectsUserControlVM;
            _projectModuleEditVM = new ProjectModuleEditVM(this, projectsUserControlVM, projectVM);
            DataContext = _projectModuleEditVM;
            _projectVM = projectVM;
            fillCheckboxList();
            FormTitle.Text = "Edit module";
        }

        private void fillCheckboxList()
        {

            _skills.Clear();
            foreach (var item in SkillVM.Skills)
            {
                var cb = new CheckBox();
                cb.Content = item.Name;
                _skills.Add(cb);
                cb.IsChecked = false;
            }

            SkillsListBox.Items.Clear();
            foreach (var item in _skills)
            {
                SkillsListBox.Items.Add(item);
            }

            if (_projectModuleEditVM != null && _projectModuleEditVM.ProjectVM != null)
            {
                var selectedSkills = _projectModuleEditVM.Skills;
                foreach (var item in _skills)
                {
                    if (_savedSkills == null)
                        item.IsChecked = selectedSkills.FirstOrDefault(skill => skill == item.Content.ToString()) != null ? true : false;
                    else
                    {
                        var isExist = _savedSkills.FirstOrDefault(skill => skill.Content.ToString() == item.Content.ToString());
                        item.IsChecked = isExist == null ? false : isExist.IsChecked;
                    }
                }
                _savedSkills = null;
            }
        }

        private void SomeProperty_Changed(object sender, TextChangedEventArgs e)
        {
            _projectModuleEditVM.SaveButton = true;
        }

        private void AddEmployeeToTheProject_Click(object sender, RoutedEventArgs e)
        {
            LeadersCollection.SelectedItem = null;
            (new AddEmployeeToTheProject(_projectModuleEditVM, _projectModuleEditVM)).Show();
        }

        private void AddSkill_Click(object sender, RoutedEventArgs e)
        {
            _savedSkills = new List<CheckBox>();
            foreach (var item in _skills)
            {
                _savedSkills.Add(item);
            }

            (new SkillWindow(_projectModuleEditVM)).Show();
        }

        public void LoadData()
        {
            _lastScreen.LoadData();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _projectModuleEditVM.AddProject((from items in _skills where items.IsChecked == true select items.Content.ToString()).ToArray());
                var mres = MessageBox.Show("Module was saved", "Module information", MessageBoxButton.OK, MessageBoxImage.Information);
                if (mres == MessageBoxResult.OK || mres == MessageBoxResult.None)
                    this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void StateCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void LeadersCollection_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

               _projectModuleEditVM.SelectedLeader = LeadersCollection.SelectedItem as UserVM;
        }

        public void LoadData(object sender)
        {
            var skillWindow = sender as SkillWindowVM;

            if (skillWindow != null)
            {
                fillCheckboxList();
            }
            LoadData();
        }
    }
}
