﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMDataLayer;

namespace PMView.View.WrapperVM
{
    public class UserVM : BaseVM, IUser, IEmployee
    {
        private User _user;

        public UserVM(User user)
        {
            _user = user;
        }

        public User User
        {
            get { return _user; }
            set { _user = value; }
        }

        public string Name
        {
            get { return _user.Name; }
            set { _user.Name = value; }
        }

        public string Surname
        {
            get { return _user.Surname; }
            set { _user.Surname = value; }
        }

        public string Password
        {
            get { return _user.Password; }
            set { _user.Password = value; }
        }

        public string Login
        {
            get { return _user.Login; }
            set { _user.Login = value; }
        }

        public DateTime Birthday
        {
            get { return _user.Birthday; }
            set { _user.Birthday = value; }
        }

        public string Email
        {
            get { return _user.Email; }
            set { _user.Email = value; }
        }

        public string Skype
        {
            get { return _user.Skype; }
            set { _user.Skype = value; }
        }

        public string Country
        {
            get { return _user.Country; }
            set { _user.Country = value; }
        }

        public byte[] Image
        {
            get { return _user.Image; }
            set { _user.Image = value; }
        }

        public User.Roles Role
        {
            get { return _user.Role; }
            set { _user.Role = value; }
        }

        public User.Statuses Status
        {
            get { return _user.Status; }
            set { _user.Status = value; }
        }

        public string Description
        {
            get { return _user.Description; }
            set { _user.Description = value; }
        }

        public User.States State
        {
            get { return _user.State; }
            set { _user.State = value; }
        }

        public IEnumerable<Skill> Skills
        {
            get { return _user.Skills; }
        }

        public IEnumerable<Report> Reports
        {
            get { return _user.Reports; }
        }

        public IEnumerable<Message> Inbox
        {
            get { return _user.Inbox; }
        }

        public IEnumerable<Message> Sentbox
        {
            get { return _user.Sentbox; }
        }

        public IEnumerable<Project> Projects
        {
            get { return _user.Projects; }
        }

        public IEnumerable<Comment> Comments
        {
            get { return _user.Comments; }
        }

        public IEnumerable<Team> Teams
        {
            get { return _user.Teams; }
        }

        public override string ToString()
        {
            return Name + " " + Surname;
        }

        public override bool Equals(object obj)
        {
            var item = obj as User;
            if (item == User)
                return true;
            var userVM = obj as UserVM;

            if (item != null)
            {
                if (item.Name == Name && item.Surname == Surname && item.Skype == Skype && item.State.ToString() == State.ToString()
               && item.Status.ToString() == Status.ToString() && item.Description == Description && item.Country == Country)
                    return true;
            }

            if (userVM != null)
            {
                if (userVM.Name == Name && userVM.Surname == Surname && userVM.Skype == Skype && userVM.State.ToString() == State.ToString()
               && userVM.Status.ToString() == Status.ToString() && userVM.Description == Description && userVM.Country == Country)
                    return true;
            }

            return false;
        }
    }
}
