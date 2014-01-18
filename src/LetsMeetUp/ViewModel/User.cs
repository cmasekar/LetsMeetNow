﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsMeetUp.ViewModel
{
    public sealed class DummyUser
        : INotifyPropertyChanged
    {
        private string _firstName;
        public string FirstName { get { return _firstName; } set { _firstName = value; if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("FirstName")); } }

        private int _age;
        public int Age { get { return _age; } set { _age = value; if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("Age")); } }


        private string _tagLine;
        public string TagLine { get { return _tagLine; } set { _tagLine = value; if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("TagLine")); } }

        public event PropertyChangedEventHandler PropertyChanged;

        public DummyUser(string firstName, int age, string tagLine)
        {
            FirstName = firstName;
            Age = age;
            TagLine = tagLine;
        }
    }
}
