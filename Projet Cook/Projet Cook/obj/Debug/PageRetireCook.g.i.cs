﻿#pragma checksum "..\..\PageRetireCook.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "109E26686A0FC3E90573BFF60EF7EDBC73694106C96DA2E1A93369A434004245"
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
    /// PageRetireCook
    /// </summary>
    public partial class PageRetireCook : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\PageRetireCook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TPrenom;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\PageRetireCook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TNom;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\PageRetireCook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TMontant;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\PageRetireCook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TAdresse;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\PageRetireCook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BValider;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\PageRetireCook.xaml"
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
            System.Uri resourceLocater = new System.Uri("/Projet Cook;component/pageretirecook.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PageRetireCook.xaml"
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
            this.TPrenom = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.TNom = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TMontant = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.TAdresse = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.BValider = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\PageRetireCook.xaml"
            this.BValider.Click += new System.Windows.RoutedEventHandler(this.BValider_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.TError = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

