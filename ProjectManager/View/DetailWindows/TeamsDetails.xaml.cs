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
using PMDataLayer;
using PMView.View;
using PMView.View.WrapperVM;
using Core;

namespace PMView
{
    /// <summary>
    /// Interaction logic for TeamsDetails.xaml
    /// </summary>
    public partial class TeamsDetails : Window, ILoadDataSender
    {
        private TeamDetailsVM _teamDetailsVM;

        private List<CheckBox> _positions;
        private ILoadDataSender _lastScreen;

        public TeamsDetails(TeamVM team, ProjectsUserControlVM projectsUserControlVM)
        {
            InitializeComponent();
            _teamDetailsVM = new TeamDetailsVM(team, projectsUserControlVM);
            _lastScreen = projectsUserControlVM;
            DataContext = _teamDetailsVM;
        }

        public TeamsDetails(TeamVM team, ILoadDataSender lastScreen)
        {
            InitializeComponent();
            _lastScreen = lastScreen;
            _teamDetailsVM = new TeamDetailsVM(team, this);
            DataContext = _teamDetailsVM;
        }

        public void LoadData(object sender)
        {
            _teamDetailsVM.LoadData();
            _lastScreen.LoadData(this);
        }

        private void EmployeesListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (EmployeesListBox.SelectedItem == null)
                return;

            PositionsGrid.Visibility = Visibility.Visible;
            _teamDetailsVM.SelectedEmployee = EmployeesListBox.SelectedItem as UserVM;
            _positions = new List<CheckBox>();
            var employeesPositions = _teamDetailsVM.EmployeesPositions;

            foreach (var item in Position.Items)
            {
                var cb = new CheckBox();
                cb.Content = item.Name;
                _positions.Add(cb);
                cb.IsChecked = employeesPositions.FirstOrDefault(pos => item.Id == pos.Position.Id) == null ? false : true;
                cb.Click += new System.Windows.RoutedEventHandler(this.CheckBox_Checked);
            }

            PositionListBox.Items.Clear();
            foreach (var item in _positions)
            {
                PositionListBox.Items.Add(item);
            }
        }

        private void DataGrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            var order = OrdersDataGrid.SelectedItem as OrderVM;
            EmptyWindow ew = new EmptyWindow(order.Name);
            ew.Body.Children.Add(new ProjectsUserControl(order.Order));
            ew.Show();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (_positions != null)
                    _teamDetailsVM.ButtonSaveClick(_positions.Where(items => items.IsChecked == true).Select(item => item.Content.ToString()).ToArray());
                else
                    _teamDetailsVM.ButtonSaveClick(null);
                _teamDetailsVM.LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            _teamDetailsVM.ButtonsActive = true;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _teamDetailsVM.ButtonsActive = false;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            _teamDetailsVM.ButtonsActive = true;
        }

        private void AddEmployee_Click(object sender, RoutedEventArgs e)
        {
            (new AttachEmployee(this, _teamDetailsVM)).Show();
        }
    }
}
