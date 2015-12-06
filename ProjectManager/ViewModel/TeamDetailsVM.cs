﻿using PMDataLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace PMView.View
{
    public class TeamDetailsVM : INotifyPropertyChanged
    {
        private ObservableCollection<User_Team> _employeesCollection = new ObservableCollection<User_Team>();

        private ObservableCollection<Skill> _skillsCollection = new ObservableCollection<Skill>();

        private ObservableCollection<Position> _positionsCollection = new ObservableCollection<Position>();

        private ObservableCollection<Position> _positionsToAddCollection = new ObservableCollection<Position>();

        private ProjectsUserControlVM _projectsUserControlVM;

        public event PropertyChangedEventHandler PropertyChanged;

        public TeamDetailsVM(Team team, ProjectsUserControlVM control)
        {
            if (team == null)
                return;

            _projectsUserControlVM = control;
            CurrentTeam = team;
            var users = team.Users.ToList();
            for (int i=0; i<users.Count; i++)
            {
                bool exist = false;
                for (int j = 0; j < _employeesCollection.Count; j++)
                {
                    if (_employeesCollection[j].User == users[i].User)
                    {
                        exist = true;
                    }
                }
                if (!exist)
                _employeesCollection.Add(users[i]);
            }

            foreach (var employee in _employeesCollection)
            {
                var skills = from items in User_Skill.Items where items.User.Id == employee.User.Id select items;
                foreach (var item in skills)
                {
                    while (_skillsCollection.All(items=>item.Skill!=items))
                    _skillsCollection.Add(item.Skill);
                }
            }

            LoadPositions();
            LoadData();
        }

        public User SelectedEmployee { get; set; }

        public Team CurrentTeam { get; private set; }

        public string Name
        {
            get { return CurrentTeam.Name; }
            set
            {
                CurrentTeam.Name = value;
                _projectsUserControlVM.LoadData();
            }
        }

        public string Description
        {
            get { return CurrentTeam.Description; }
            set
            {
                CurrentTeam.Description = value;
                _projectsUserControlVM.LoadData();
            }
        }

        public ObservableCollection<Position> PositionsCollection
        {
            get { return _positionsCollection; }
        }

        public ObservableCollection<Position> PositionsToAddCollection
        {
            get { return _positionsToAddCollection; }
        }

        public IEnumerable<User_Team> Employees
        {
            get { return CurrentTeam.Users; }
        }

        public Team SelectedTeam { get; set; }

        public ObservableCollection<User_Team> EmployeesCollection
        {
            get { return _employeesCollection; }
        }

        public ObservableCollection<Skill> SkillsCollection
        {
            get { return _skillsCollection; }
        }

        public void LoadPositions()
        {
            _positionsCollection.Clear();
            foreach (var item in _employeesCollection)
            {
                if (item.User == SelectedEmployee)
                {
                    foreach (var position in item.Positions)
                    {
                        _positionsCollection.Add(position);
                    }
                }
            }

            if (SelectedEmployee == null)
                return;

            _positionsToAddCollection.Clear();
            foreach (var item in Position.Items)
            {
                if (!_positionsCollection.Contains(item))
                    _positionsToAddCollection.Add(item);
            }
        }

        private void LoadData()
        {
            OnPropertyChanged("Name");
            OnPropertyChanged("Description");
            OnPropertyChanged("Employees");
        }


        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
