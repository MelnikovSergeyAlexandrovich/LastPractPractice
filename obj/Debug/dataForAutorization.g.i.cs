﻿#pragma checksum "..\..\dataForAutorization.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "61BD359E166F0E442D1B98DFD553F11538AB5041696C29886A877BFEF1CA47DD"
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
    /// dataForAutorization
    /// </summary>
    public partial class dataForAutorization : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\dataForAutorization.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox StaffComboBox;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\dataForAutorization.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox AutoComboBox;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\dataForAutorization.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid AutorizationInfoDataGrid;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\dataForAutorization.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PasswordTextBox;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\dataForAutorization.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LoginTextBox;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\dataForAutorization.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CreateAutoButton;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\dataForAutorization.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteAutoButton;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\dataForAutorization.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ChangeAutoButton;
        
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
            System.Uri resourceLocater = new System.Uri("/LastProjectPracticeCsharp;component/dataforautorization.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\dataForAutorization.xaml"
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
            this.StaffComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.AutoComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.AutorizationInfoDataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 47 "..\..\dataForAutorization.xaml"
            this.AutorizationInfoDataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.AutorizationInfoDataGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.PasswordTextBox = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 5:
            this.LoginTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.CreateAutoButton = ((System.Windows.Controls.Button)(target));
            
            #line 74 "..\..\dataForAutorization.xaml"
            this.CreateAutoButton.Click += new System.Windows.RoutedEventHandler(this.CreateAutoButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.DeleteAutoButton = ((System.Windows.Controls.Button)(target));
            
            #line 79 "..\..\dataForAutorization.xaml"
            this.DeleteAutoButton.Click += new System.Windows.RoutedEventHandler(this.DeleteAutoButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ChangeAutoButton = ((System.Windows.Controls.Button)(target));
            
            #line 84 "..\..\dataForAutorization.xaml"
            this.ChangeAutoButton.Click += new System.Windows.RoutedEventHandler(this.ChangeAutoButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
