﻿#pragma checksum "..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "272CEB8BFF68864CA6E2E9351B96540D615E9540"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
using Szyfr_Hilla;


namespace Szyfr_Hilla {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 36 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbInput;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbKey1;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbKey2;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbKey3;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbKey4;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox combOption;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bExec;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbOutput;
        
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
            System.Uri resourceLocater = new System.Uri("/Szyfr_Hilla;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.tbInput = ((System.Windows.Controls.TextBox)(target));
            
            #line 36 "..\..\MainWindow.xaml"
            this.tbInput.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.tbText_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tbKey1 = ((System.Windows.Controls.TextBox)(target));
            
            #line 46 "..\..\MainWindow.xaml"
            this.tbKey1.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.tbKey1_PreviewTextInput);
            
            #line default
            #line hidden
            
            #line 46 "..\..\MainWindow.xaml"
            this.tbKey1.AddHandler(System.Windows.Input.CommandManager.PreviewExecutedEvent, new System.Windows.Input.ExecutedRoutedEventHandler(this.tbKey1_PreviewExecuted));
            
            #line default
            #line hidden
            return;
            case 3:
            this.tbKey2 = ((System.Windows.Controls.TextBox)(target));
            
            #line 47 "..\..\MainWindow.xaml"
            this.tbKey2.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.tbKey2_PreviewTextInput);
            
            #line default
            #line hidden
            
            #line 47 "..\..\MainWindow.xaml"
            this.tbKey2.AddHandler(System.Windows.Input.CommandManager.PreviewExecutedEvent, new System.Windows.Input.ExecutedRoutedEventHandler(this.tbKey2_PreviewExecuted));
            
            #line default
            #line hidden
            return;
            case 4:
            this.tbKey3 = ((System.Windows.Controls.TextBox)(target));
            
            #line 56 "..\..\MainWindow.xaml"
            this.tbKey3.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.tbKey3_PreviewTextInput);
            
            #line default
            #line hidden
            
            #line 56 "..\..\MainWindow.xaml"
            this.tbKey3.AddHandler(System.Windows.Input.CommandManager.PreviewExecutedEvent, new System.Windows.Input.ExecutedRoutedEventHandler(this.tbKey3_PreviewExecuted));
            
            #line default
            #line hidden
            return;
            case 5:
            this.tbKey4 = ((System.Windows.Controls.TextBox)(target));
            
            #line 57 "..\..\MainWindow.xaml"
            this.tbKey4.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.tbKey4_PreviewTextInput);
            
            #line default
            #line hidden
            
            #line 57 "..\..\MainWindow.xaml"
            this.tbKey4.AddHandler(System.Windows.Input.CommandManager.PreviewExecutedEvent, new System.Windows.Input.ExecutedRoutedEventHandler(this.tbKey4_PreviewExecuted));
            
            #line default
            #line hidden
            return;
            case 6:
            this.combOption = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.bExec = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\MainWindow.xaml"
            this.bExec.Click += new System.Windows.RoutedEventHandler(this.bExec_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.tbOutput = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
