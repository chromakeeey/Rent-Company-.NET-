﻿#pragma checksum "..\..\..\..\Dialogs\CustomDefaultDialog\DialogOkNoCancel.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4EBDD89BAF500CD97D128E63D398EC06732F0504209A1E703FCA98FFD314FDCD"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using ClientVehicle.Dialogs.CustomDefaultDialog;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace ClientVehicle.Dialogs.CustomDefaultDialog {
    
    
    /// <summary>
    /// DialogOkNoCancel
    /// </summary>
    public partial class DialogOkNoCancel : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\..\..\Dialogs\CustomDefaultDialog\DialogOkNoCancel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Caption;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\Dialogs\CustomDefaultDialog\DialogOkNoCancel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.PackIcon Icon;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\Dialogs\CustomDefaultDialog\DialogOkNoCancel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Message;
        
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
            System.Uri resourceLocater = new System.Uri("/ClientVehicle;component/dialogs/customdefaultdialog/dialogoknocancel.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Dialogs\CustomDefaultDialog\DialogOkNoCancel.xaml"
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
            this.Caption = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.Icon = ((MaterialDesignThemes.Wpf.PackIcon)(target));
            return;
            case 3:
            this.Message = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            
            #line 59 "..\..\..\..\Dialogs\CustomDefaultDialog\DialogOkNoCancel.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.onOkClick);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 66 "..\..\..\..\Dialogs\CustomDefaultDialog\DialogOkNoCancel.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.onNoClick);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 73 "..\..\..\..\Dialogs\CustomDefaultDialog\DialogOkNoCancel.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.onCancelClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

