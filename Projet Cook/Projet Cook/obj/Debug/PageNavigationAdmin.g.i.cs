﻿#pragma checksum "..\..\PageNavigationAdmin.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F79507EE640B04B0CD70D0420BD7FE115DEB249818F8DABA186372338C53415F"
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
    /// PageNavigationAdmin
    /// </summary>
    public partial class PageNavigationAdmin : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\PageNavigationAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BBoard;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\PageNavigationAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BClient;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\PageNavigationAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BREcipe;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\PageNavigationAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTransactions;
        
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
            System.Uri resourceLocater = new System.Uri("/Projet Cook;component/pagenavigationadmin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PageNavigationAdmin.xaml"
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
            this.BBoard = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\PageNavigationAdmin.xaml"
            this.BBoard.Click += new System.Windows.RoutedEventHandler(this.BBoard_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BClient = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\PageNavigationAdmin.xaml"
            this.BClient.Click += new System.Windows.RoutedEventHandler(this.BClient_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BREcipe = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\PageNavigationAdmin.xaml"
            this.BREcipe.Click += new System.Windows.RoutedEventHandler(this.BREcipe_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BTransactions = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\PageNavigationAdmin.xaml"
            this.BTransactions.Click += new System.Windows.RoutedEventHandler(this.BTransactions_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

