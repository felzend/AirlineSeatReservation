﻿using System;
using System.Collections.Generic;
using AirlineSeatReservation.ViewModels;
using AirlineSeatReservation.Views;
using Xamarin.Forms;

namespace AirlineSeatReservation
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
