﻿#pragma checksum "..\..\AdminPanel.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "41ADC547AB55C14D682259E07B8371195B8E6787E99B1F141B5E570D6C8E5846"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using LastProjectPracticeCsharp;
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


namespace LastProjectPracticeCsharp {
    
    
    /// <summary>
    /// AdminPanel
    /// </summary>
    public partial class AdminPanel : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\AdminPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ShopsButton;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\AdminPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GetBack;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\AdminPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AutorizationButton_;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\AdminPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RolesButton;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\AdminPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button StaffButton;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\AdminPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame AdminDataFrame;
        
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
            System.Uri resourceLocater = new System.Uri("/LastProjectPracticeCsharp;component/adminpanel.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AdminPanel.xaml"
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
            this.ShopsButton = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\AdminPanel.xaml"
            this.ShopsButton.Click += new System.Windows.RoutedEventHandler(this.ShopsButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.GetBack = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\AdminPanel.xaml"
            this.GetBack.Click += new System.Windows.RoutedEventHandler(this.GetBack_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.AutorizationButton_ = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\AdminPanel.xaml"
            this.AutorizationButton_.Click += new System.Windows.RoutedEventHandler(this.AutorizationButton__Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.RolesButton = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\AdminPanel.xaml"
            this.RolesButton.Click += new System.Windows.RoutedEventHandler(this.RolesButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.StaffButton = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\AdminPanel.xaml"
            this.StaffButton.Click += new System.Windows.RoutedEventHandler(this.StaffButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.AdminDataFrame = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

