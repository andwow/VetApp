﻿#pragma checksum "..\..\..\Views\AddIntervention.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BF27BA48C8716E216E6994D30A3F49B60BE1778A4A364492EECC0986A3FC38C0"
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
    /// AddIntervention
    /// </summary>
    public partial class AddIntervention : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\..\Views\AddIntervention.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox IntvName;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Views\AddIntervention.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox IntvDate;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Views\AddIntervention.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox IntvNextDate;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\Views\AddIntervention.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid AvailableProducts;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\Views\AddIntervention.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid UsedProducts;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\Views\AddIntervention.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Price;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\Views\AddIntervention.xaml"
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
            System.Uri resourceLocater = new System.Uri("/VetApp;component/views/addintervention.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\AddIntervention.xaml"
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
            this.IntvName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.IntvDate = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.IntvNextDate = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.AvailableProducts = ((System.Windows.Controls.DataGrid)(target));
            
            #line 55 "..\..\..\Views\AddIntervention.xaml"
            this.AvailableProducts.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.AvailableProducts_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.UsedProducts = ((System.Windows.Controls.DataGrid)(target));
            
            #line 66 "..\..\..\Views\AddIntervention.xaml"
            this.UsedProducts.CurrentCellChanged += new System.EventHandler<System.EventArgs>(this.UsedProducts_CurrentCellChanged);
            
            #line default
            #line hidden
            
            #line 66 "..\..\..\Views\AddIntervention.xaml"
            this.UsedProducts.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.UsedProducts_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Price = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.CreateProduct = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

