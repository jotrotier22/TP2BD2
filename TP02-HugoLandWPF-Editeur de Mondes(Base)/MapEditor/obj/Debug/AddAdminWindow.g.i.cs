﻿#pragma checksum "..\..\AddAdminWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "965F5B65974656DEA61B2424A878140C6CBCBD2B8EC02462F864FF617D7A9F32"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using MapEditor;
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


namespace MapEditor {
    
    
    /// <summary>
    /// AddAdminWindow
    /// </summary>
    public partial class AddAdminWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\AddAdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_RechercherParID;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\AddAdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_RechercherParPseudo;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\AddAdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_RechercherParID;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\AddAdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_RechercherParPseudo;
        
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
            System.Uri resourceLocater = new System.Uri("/MapEditor;component/addadminwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddAdminWindow.xaml"
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
            this.txt_RechercherParID = ((System.Windows.Controls.TextBox)(target));
            
            #line 10 "..\..\AddAdminWindow.xaml"
            this.txt_RechercherParID.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txt_RechercherParID_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txt_RechercherParPseudo = ((System.Windows.Controls.TextBox)(target));
            
            #line 11 "..\..\AddAdminWindow.xaml"
            this.txt_RechercherParPseudo.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txt_RechercherParPseudo_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btn_RechercherParID = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\AddAdminWindow.xaml"
            this.btn_RechercherParID.Click += new System.Windows.RoutedEventHandler(this.btn_RechercherParID_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btn_RechercherParPseudo = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\AddAdminWindow.xaml"
            this.btn_RechercherParPseudo.Click += new System.Windows.RoutedEventHandler(this.btn_RechercherParPseudo_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

