﻿#pragma checksum "..\..\..\Views\MyCart.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FC62C88B191406ADD4A31205F342CFFA70AE601F7E4266372DA4AEF1DC1A563B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using VetApp.Views;


namespace VetApp.Views {
    
    
    /// <summary>
    /// MyCart
    /// </summary>
    public partial class MyCart : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\Views\MyCart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Interventions;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Views\MyCart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid UsedProducts;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Views\MyCart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Price;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Views\MyCart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PlaceInterventions;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/VetApp;component/views/mycart.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\MyCart.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Interventions = ((System.Windows.Controls.DataGrid)(target));
            
            #line 28 "..\..\..\Views\MyCart.xaml"
            this.Interventions.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.Interventions_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 2:
            this.UsedProducts = ((System.Windows.Controls.DataGrid)(target));
            
            #line 40 "..\..\..\Views\MyCart.xaml"
            this.UsedProducts.CurrentCellChanged += new System.EventHandler<System.EventArgs>(this.UsedProducts_CurrentCellChanged);
            
            #line default
            #line hidden
            
            #line 40 "..\..\..\Views\MyCart.xaml"
            this.UsedProducts.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.UsedProducts_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Price = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.PlaceInterventions = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\Views\MyCart.xaml"
            this.PlaceInterventions.Click += new System.Windows.RoutedEventHandler(this.PlaceInterventions_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

