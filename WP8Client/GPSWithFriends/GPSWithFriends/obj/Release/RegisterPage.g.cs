﻿#pragma checksum "C:\Users\bunny_000\Documents\SS\0G000 Group\UO\gps_with_friends\WP8Client\GPSWithFriends\GPSWithFriends\RegisterPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "40979D93C2B2329E18EBCE80FE5220BA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18046
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace GPSWithFriends {
    
    
    public partial class RegisterPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBox RegisterEmailTextBox;
        
        internal System.Windows.Controls.PasswordBox RegisterPasswordBox;
        
        internal System.Windows.Controls.PasswordBox RegisterPasswordAgainBox;
        
        internal System.Windows.Controls.TextBox RegisterNickNameTextBox;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/GPSWithFriends;component/RegisterPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.RegisterEmailTextBox = ((System.Windows.Controls.TextBox)(this.FindName("RegisterEmailTextBox")));
            this.RegisterPasswordBox = ((System.Windows.Controls.PasswordBox)(this.FindName("RegisterPasswordBox")));
            this.RegisterPasswordAgainBox = ((System.Windows.Controls.PasswordBox)(this.FindName("RegisterPasswordAgainBox")));
            this.RegisterNickNameTextBox = ((System.Windows.Controls.TextBox)(this.FindName("RegisterNickNameTextBox")));
        }
    }
}

