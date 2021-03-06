﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PMView.View;

namespace PMView
{
    public partial class Skeleton : Window
    { 
        public Skeleton()
        {
            InitializeComponent();
            Body = BodyGrid;
            MenuBarGrid.Children.Add(new MenuBarUserControl());
        }

        public static Grid Body { get; set; }
    }
}
