﻿#pragma checksum "..\..\..\..\Dialogs\Receipts\ReceiptEdit.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2909956269FAEFDFDB228A472FB43B3CA1FE8ADA39896173290E51CDFB26B885"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using ClientVehicle.Dialogs.Receipts;
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


namespace ClientVehicle.Dialogs.Receipts {
    
    
    /// <summary>
    /// ReceiptEdit
    /// </summary>
    public partial class ReceiptEdit : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 46 "..\..\..\..\Dialogs\Receipts\ReceiptEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox field_Company;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\Dialogs\Receipts\ReceiptEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox field_Street;
        
        #line default
        #line hidden
        
        
        #line 115 "..\..\..\..\Dialogs\Receipts\ReceiptEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock label_Company;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\..\..\Dialogs\Receipts\ReceiptEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock label_Street;
        
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
            System.Uri resourceLocater = new System.Uri("/ClientVehicle;component/dialogs/receipts/receiptedit.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Dialogs\Receipts\ReceiptEdit.xaml"
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
            this.field_Company = ((System.Windows.Controls.TextBox)(target));
            
            #line 57 "..\..\..\..\Dialogs\Receipts\ReceiptEdit.xaml"
            this.field_Company.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.OnCompanyTextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.field_Street = ((System.Windows.Controls.TextBox)(target));
            
            #line 71 "..\..\..\..\Dialogs\Receipts\ReceiptEdit.xaml"
            this.field_Street.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.OnStreeTextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 83 "..\..\..\..\Dialogs\Receipts\ReceiptEdit.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnClickSave);
            
            #line default
            #line hidden
            return;
            case 4:
            this.label_Company = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.label_Street = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

