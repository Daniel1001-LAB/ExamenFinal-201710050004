﻿using ExamenTercerParcial.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ExamenTercerParcial
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            fechaactual.Date=DateTime.Now;
            //BindingContext = new MainPageModel();
        }

      
    }
}
