﻿#pragma checksum "..\..\SocialMediasPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BFEED0D7CA11DA73E647B540A4790096CDB3D57867542A0141EB392706D2D96D"
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
    /// SocialMediasPage
    /// </summary>
    public partial class SocialMediasPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\SocialMediasPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid SMDataGrid;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\SocialMediasPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ShopIdComboBox;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\SocialMediasPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CreateButton;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\SocialMediasPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteButton;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\SocialMediasPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ChangeButton;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\SocialMediasPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GetDataButton;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\SocialMediasPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LinkTextBox;
        
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
            System.Uri resourceLocater = new System.Uri("/LastProjectPracticeCsharp;component/socialmediaspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\SocialMediasPage.xaml"
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
            this.SMDataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 23 "..\..\SocialMediasPage.xaml"
            this.SMDataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SMDataGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ShopIdComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.CreateButton = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\SocialMediasPage.xaml"
            this.CreateButton.Click += new System.Windows.RoutedEventHandler(this.CreateButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.DeleteButton = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\SocialMediasPage.xaml"
            this.DeleteButton.Click += new System.Windows.RoutedEventHandler(this.DeleteButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ChangeButton = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\SocialMediasPage.xaml"
            this.ChangeButton.Click += new System.Windows.RoutedEventHandler(this.ChangeButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.GetDataButton = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\SocialMediasPage.xaml"
            this.GetDataButton.Click += new System.Windows.RoutedEventHandler(this.GetDataButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.LinkTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
