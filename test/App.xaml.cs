﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace test
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        
public void App_Startup(object sender, StartupEventArgs e)

        {

            this.Properties["Login"] = "mc";

            this.Properties["Password"] = "pwd";

            this.Properties["ConnectedStatus"] = "brak";
        }
    }
}
