﻿#pragma checksum "..\..\..\..\Dialogs\DialogsVehicle\FinalRentWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C798310828D1DC5CBBC07BDE94226866C4CA0F697F19CF246D5D9C78331D6954"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using ClientVehicle.Dialogs.DialogsVehicle;
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


namespace ClientVehicle.Dialogs.DialogsVehicle {
    
    
    /// <summary>
    /// FinalRentWindow
    /// </summary>
    public partial class FinalRentWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 51 "..\..\..\..\Dialogs\DialogsVehicle\FinalRentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox field_Fuel;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\..\Dialogs\DialogsVehicle\FinalRentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox field_Mileage;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\..\Dialogs\DialogsVehicle\FinalRentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock label_Error;
        
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
            System.Uri resourceLocater = new System.Uri("/ClientVehicle;component/dialogs/dialogsvehicle/finalrentwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Dialogs\DialogsVehicle\FinalRentWindow.xaml"
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
            
            #line 19 "..\..\..\..\Dialogs\DialogsVehicle\FinalRentWindow.xaml"
            ((MaterialDesignThemes.Wpf.PackIcon)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.onClickHide);
            
            #line default
            #line hidden
            return;
            case 2:
            this.field_Fuel = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.field_Mileage = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.label_Error = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            
            #line 99 "..\..\..\..\Dialogs\DialogsVehicle\FinalRentWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.onClickSuccess);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

