﻿#pragma checksum "..\..\PageAdminClient.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4A40DEC5B3E271A3835C0B27E948E3A3F2D6B3ED2749A75B175CF1239021ED20"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using Projet_Cook;
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


namespace Projet_Cook {
    
    
    /// <summary>
    /// PageAdminClient
    /// </summary>
    public partial class PageAdminClient : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 54 "..\..\PageAdminClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView LVclient;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\PageAdminClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BDelete;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\PageAdminClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BCDR;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\PageAdminClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BChef;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\PageAdminClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BAdmin;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\PageAdminClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TTotal;
        
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
            System.Uri resourceLocater = new System.Uri("/Projet Cook;component/pageadminclient.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PageAdminClient.xaml"
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
            this.LVclient = ((System.Windows.Controls.ListView)(target));
            return;
            case 2:
            this.BDelete = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\PageAdminClient.xaml"
            this.BDelete.Click += new System.Windows.RoutedEventHandler(this.BDelete_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BCDR = ((System.Windows.Controls.Button)(target));
            
            #line 67 "..\..\PageAdminClient.xaml"
            this.BCDR.Click += new System.Windows.RoutedEventHandler(this.BCDR_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BChef = ((System.Windows.Controls.Button)(target));
            
            #line 68 "..\..\PageAdminClient.xaml"
            this.BChef.Click += new System.Windows.RoutedEventHandler(this.BChef_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BAdmin = ((System.Windows.Controls.Button)(target));
            
            #line 69 "..\..\PageAdminClient.xaml"
            this.BAdmin.Click += new System.Windows.RoutedEventHandler(this.BAdmin_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.TTotal = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

