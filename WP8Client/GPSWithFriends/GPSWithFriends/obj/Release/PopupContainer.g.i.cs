﻿#pragma checksum "C:\Users\bunny_000\Documents\SS\0G000 Group\UO\gps_with_friends\WP8Client\GPSWithFriends\GPSWithFriends\PopupContainer.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "780610175903722EC4A2DA01861FE843"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18046
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
    
    
    public partial class PopupContainer : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Shapes.Rectangle mask;
        
        internal System.Windows.Controls.Grid popupArea;
        
        internal System.Windows.Media.CompositeTransform popupTransform;
        
        internal System.Windows.Controls.Grid contentArea;
        
        internal System.Windows.Shapes.Rectangle shadow;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/GPSWithFriends;component/PopupContainer.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.mask = ((System.Windows.Shapes.Rectangle)(this.FindName("mask")));
            this.popupArea = ((System.Windows.Controls.Grid)(this.FindName("popupArea")));
            this.popupTransform = ((System.Windows.Media.CompositeTransform)(this.FindName("popupTransform")));
            this.contentArea = ((System.Windows.Controls.Grid)(this.FindName("contentArea")));
            this.shadow = ((System.Windows.Shapes.Rectangle)(this.FindName("shadow")));
        }
    }
}

