﻿#pragma checksum "..\..\DeleteNotes.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AC7765C3BDEADFA6F64D795FB0D564EAE111D6693B08B842F61CD7A6F38E0D4C"
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
    /// DeleteNotes
    /// </summary>
    public partial class DeleteNotes : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\DeleteNotes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal УП_Ver2.DeleteNotes DeletePage;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\DeleteNotes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DeleteNotes_Textbox;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\DeleteNotes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteNotes_Button;
        
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
            System.Uri resourceLocater = new System.Uri("/УП Ver2;component/deletenotes.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\DeleteNotes.xaml"
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
            this.DeletePage = ((УП_Ver2.DeleteNotes)(target));
            return;
            case 2:
            this.DeleteNotes_Textbox = ((System.Windows.Controls.TextBox)(target));
            
            #line 54 "..\..\DeleteNotes.xaml"
            this.DeleteNotes_Textbox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.DeleteNotes_Textbox_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 3:
            this.DeleteNotes_Button = ((System.Windows.Controls.Button)(target));
            
            #line 67 "..\..\DeleteNotes.xaml"
            this.DeleteNotes_Button.Click += new System.Windows.RoutedEventHandler(this.DeleteNotes_Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

