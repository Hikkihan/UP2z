﻿#pragma checksum "..\..\User_cabinet.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C042178A1609AF9C50B8C06BD0153F30394DC80A7A34E378F1084C9473282204"
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
    /// User_cabinet
    /// </summary>
    public partial class User_cabinet : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 113 "..\..\User_cabinet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OpenBase;
        
        #line default
        #line hidden
        
        
        #line 131 "..\..\User_cabinet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PrintBase;
        
        #line default
        #line hidden
        
        
        #line 147 "..\..\User_cabinet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataBase;
        
        #line default
        #line hidden
        
        
        #line 160 "..\..\User_cabinet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Photo;
        
        #line default
        #line hidden
        
        
        #line 172 "..\..\User_cabinet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditPhoto;
        
        #line default
        #line hidden
        
        
        #line 195 "..\..\User_cabinet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Notes;
        
        #line default
        #line hidden
        
        
        #line 211 "..\..\User_cabinet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Favourites;
        
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
            System.Uri resourceLocater = new System.Uri("/УП Ver2;component/user_cabinet.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\User_cabinet.xaml"
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
            this.OpenBase = ((System.Windows.Controls.Button)(target));
            
            #line 114 "..\..\User_cabinet.xaml"
            this.OpenBase.Click += new System.Windows.RoutedEventHandler(this.OpenBase_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.PrintBase = ((System.Windows.Controls.Button)(target));
            
            #line 132 "..\..\User_cabinet.xaml"
            this.PrintBase.Click += new System.Windows.RoutedEventHandler(this.PrintBase_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.DataBase = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            this.Photo = ((System.Windows.Controls.Image)(target));
            
            #line 161 "..\..\User_cabinet.xaml"
            this.Photo.AddHandler(System.Windows.Input.Mouse.MouseEnterEvent, new System.Windows.Input.MouseEventHandler(this.EditPhoto_MouseEnter));
            
            #line default
            #line hidden
            
            #line 162 "..\..\User_cabinet.xaml"
            this.Photo.AddHandler(System.Windows.Input.Mouse.MouseLeaveEvent, new System.Windows.Input.MouseEventHandler(this.EditPhoto_MouseLeave));
            
            #line default
            #line hidden
            return;
            case 5:
            this.EditPhoto = ((System.Windows.Controls.Button)(target));
            
            #line 170 "..\..\User_cabinet.xaml"
            this.EditPhoto.MouseLeave += new System.Windows.Input.MouseEventHandler(this.EditPhoto_MouseLeave_1);
            
            #line default
            #line hidden
            
            #line 171 "..\..\User_cabinet.xaml"
            this.EditPhoto.AddHandler(System.Windows.Input.Mouse.MouseEnterEvent, new System.Windows.Input.MouseEventHandler(this.EditPhoto_MouseEnter_1));
            
            #line default
            #line hidden
            
            #line 179 "..\..\User_cabinet.xaml"
            this.EditPhoto.Click += new System.Windows.RoutedEventHandler(this.EditPhoto_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Notes = ((System.Windows.Controls.Button)(target));
            
            #line 195 "..\..\User_cabinet.xaml"
            this.Notes.Click += new System.Windows.RoutedEventHandler(this.Notes_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Favourites = ((System.Windows.Controls.Button)(target));
            
            #line 212 "..\..\User_cabinet.xaml"
            this.Favourites.Click += new System.Windows.RoutedEventHandler(this.Favourites_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

