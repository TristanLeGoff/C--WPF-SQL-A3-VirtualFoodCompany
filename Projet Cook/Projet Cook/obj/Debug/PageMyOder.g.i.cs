﻿#pragma checksum "..\..\PageMyOder.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8009E322E8ACC7131C4762911BB73F3F2878E34F48A6F8BA88DF574143A1FB75"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
    /// PageMyOder
    /// </summary>
    public partial class PageMyOder : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 41 "..\..\PageMyOder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView LVrecipe;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\PageMyOder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BDelete;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\PageMyOder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BDetail;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\PageMyOder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TPrice;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\PageMyOder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TDescription;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\PageMyOder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BCommand;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\PageMyOder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TError;
        
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
            System.Uri resourceLocater = new System.Uri("/Projet Cook;component/pagemyoder.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PageMyOder.xaml"
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
            this.LVrecipe = ((System.Windows.Controls.ListView)(target));
            return;
            case 2:
            this.BDelete = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\PageMyOder.xaml"
            this.BDelete.Click += new System.Windows.RoutedEventHandler(this.BDelete_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BDetail = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\PageMyOder.xaml"
            this.BDetail.Click += new System.Windows.RoutedEventHandler(this.BDetail_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TPrice = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.TDescription = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.BCommand = ((System.Windows.Controls.Button)(target));
            
            #line 72 "..\..\PageMyOder.xaml"
            this.BCommand.Click += new System.Windows.RoutedEventHandler(this.BCommand_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.TError = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

