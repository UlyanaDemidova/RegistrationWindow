﻿#pragma checksum "..\..\..\..\View\DashboardWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "AEBACFC9B86A5509ABB53D64C90ED9E9DEDEF387"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using RegistrationWindow;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace RegistrationWindow {
    
    
    /// <summary>
    /// DashboardWindow
    /// </summary>
    public partial class DashboardWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\..\View\DashboardWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLoadUsers;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\View\DashboardWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLoadPage1;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\View\DashboardWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLoadPage2;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\View\DashboardWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame mainFrame;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.9.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/RegistrationWindow;component/view/dashboardwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\DashboardWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.9.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.btnLoadUsers = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\..\View\DashboardWindow.xaml"
            this.btnLoadUsers.Click += new System.Windows.RoutedEventHandler(this.btnLoadUsers_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnLoadPage1 = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\..\View\DashboardWindow.xaml"
            this.btnLoadPage1.Click += new System.Windows.RoutedEventHandler(this.btnLoadPage1_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnLoadPage2 = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\..\View\DashboardWindow.xaml"
            this.btnLoadPage2.Click += new System.Windows.RoutedEventHandler(this.btnLoadPage2_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.mainFrame = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

