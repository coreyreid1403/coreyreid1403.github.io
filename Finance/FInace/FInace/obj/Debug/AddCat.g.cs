﻿#pragma checksum "..\..\AddCat.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "059712A75418E32DF945544858B0CE0DE3A06DF1D7C436C3ADE6561252D01C4A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FInace;
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


namespace FInace {
    
    
    /// <summary>
    /// AddCat
    /// </summary>
    public partial class AddCat : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\AddCat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listBox;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\AddCat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\AddCat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label1;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\AddCat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox catName;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\AddCat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox catNumber;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\AddCat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label2;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\AddCat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label3;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\AddCat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button closeButton;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\AddCat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addButton;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\AddCat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label valueLable;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\AddCat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button removeButton;
        
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
            System.Uri resourceLocater = new System.Uri("/FInace;component/addcat.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddCat.xaml"
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
            this.listBox = ((System.Windows.Controls.ListBox)(target));
            
            #line 10 "..\..\AddCat.xaml"
            this.listBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.listBox_Selected);
            
            #line default
            #line hidden
            return;
            case 2:
            this.label = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.label1 = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.catName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.catNumber = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.label2 = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.label3 = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.closeButton = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\AddCat.xaml"
            this.closeButton.Click += new System.Windows.RoutedEventHandler(this.close);
            
            #line default
            #line hidden
            return;
            case 9:
            this.addButton = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\AddCat.xaml"
            this.addButton.Click += new System.Windows.RoutedEventHandler(this.add);
            
            #line default
            #line hidden
            return;
            case 10:
            this.valueLable = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            this.removeButton = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\AddCat.xaml"
            this.removeButton.Click += new System.Windows.RoutedEventHandler(this.remove);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

