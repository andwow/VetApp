﻿#pragma checksum "..\..\..\Views\Stocks.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "71CCC7B866945F4B0ADC94E6E19D9CD4641B7D4DE14EDB1D19E8CADB1BE60110"
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
    /// Stocks
    /// </summary>
    public partial class Stocks : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 96 "..\..\..\Views\Stocks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Refresh;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\Views\Stocks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CreateProduct;
        
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
            System.Uri resourceLocater = new System.Uri("/VetApp;component/views/stocks.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\Stocks.xaml"
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
            
            #line 86 "..\..\..\Views\Stocks.xaml"
            ((System.Windows.Controls.DataGrid)(target)).MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.DataGrid_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Refresh = ((System.Windows.Controls.Button)(target));
            
            #line 96 "..\..\..\Views\Stocks.xaml"
            this.Refresh.Click += new System.Windows.RoutedEventHandler(this.Refresh_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.CreateProduct = ((System.Windows.Controls.Button)(target));
            
            #line 97 "..\..\..\Views\Stocks.xaml"
            this.CreateProduct.Click += new System.Windows.RoutedEventHandler(this.CreateProduct_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

