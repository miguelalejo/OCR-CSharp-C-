﻿#pragma checksum "..\..\MenuBotonWPF.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2AD32D981EECC2D5295F86554CA41940"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión del motor en tiempo de ejecución:2.0.50727.4971
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
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


namespace TabControlStyle {
    
    
    /// <summary>
    /// MenuBotonWPF
    /// </summary>
    public partial class MenuBotonWPF : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 80 "..\..\MenuBotonWPF.xaml"
        internal System.Windows.Controls.Button butonprocesamiento;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\MenuBotonWPF.xaml"
        internal System.Windows.Controls.Button butonayuda;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\MenuBotonWPF.xaml"
        internal System.Windows.Controls.Button butonreportes;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/OCR.Facultad.Ingenieria.ControlesWPF;component/menubotonwpf.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MenuBotonWPF.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.butonprocesamiento = ((System.Windows.Controls.Button)(target));
            
            #line 80 "..\..\MenuBotonWPF.xaml"
            this.butonprocesamiento.Click += new System.Windows.RoutedEventHandler(this.Button_ClickMenuBotonWPF);
            
            #line default
            #line hidden
            return;
            case 2:
            this.butonayuda = ((System.Windows.Controls.Button)(target));
            
            #line 87 "..\..\MenuBotonWPF.xaml"
            this.butonayuda.Click += new System.Windows.RoutedEventHandler(this.Button_ClickMenuBotonWPF);
            
            #line default
            #line hidden
            return;
            case 3:
            this.butonreportes = ((System.Windows.Controls.Button)(target));
            
            #line 93 "..\..\MenuBotonWPF.xaml"
            this.butonreportes.Click += new System.Windows.RoutedEventHandler(this.Button_ClickMenuBotonWPF);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
