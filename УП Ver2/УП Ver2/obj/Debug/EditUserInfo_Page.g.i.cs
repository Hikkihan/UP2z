﻿#pragma checksum "..\..\EditUserInfo_Page.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0A0BA0FC32FC4B969191F5B94A553AFD9CC6192C8B3DC146CBD3A5B8B7938720"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using УП_Ver2;


namespace УП_Ver2 {
    
    
    /// <summary>
    /// EditUserInfo_Page
    /// </summary>
    public partial class EditUserInfo_Page : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\EditUserInfo_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal УП_Ver2.EditUserInfo_Page DeletePage;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\EditUserInfo_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LoginUser;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\EditUserInfo_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameUser;
        
        #line default
        #line hidden
        
        
        #line 127 "..\..\EditUserInfo_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FemaleUser;
        
        #line default
        #line hidden
        
        
        #line 144 "..\..\EditUserInfo_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PhoneUser;
        
        #line default
        #line hidden
        
        
        #line 161 "..\..\EditUserInfo_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ContinueEditUserInfo;
        
        #line default
        #line hidden
        
        
        #line 175 "..\..\EditUserInfo_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EndEditUserInfo;
        
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
            System.Uri resourceLocater = new System.Uri("/УП Ver2;component/edituserinfo_page.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\EditUserInfo_Page.xaml"
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
            this.DeletePage = ((УП_Ver2.EditUserInfo_Page)(target));
            return;
            case 2:
            this.LoginUser = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.NameUser = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.FemaleUser = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.PhoneUser = ((System.Windows.Controls.TextBox)(target));
            
            #line 145 "..\..\EditUserInfo_Page.xaml"
            this.PhoneUser.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.PhoneUser_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ContinueEditUserInfo = ((System.Windows.Controls.Button)(target));
            
            #line 162 "..\..\EditUserInfo_Page.xaml"
            this.ContinueEditUserInfo.Click += new System.Windows.RoutedEventHandler(this.ContinueEditUserInfo_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.EndEditUserInfo = ((System.Windows.Controls.Button)(target));
            
            #line 176 "..\..\EditUserInfo_Page.xaml"
            this.EndEditUserInfo.Click += new System.Windows.RoutedEventHandler(this.EndEditUserInfo_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

