//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("App_DoeCalor_Final.Pages.DoadorPage.xaml", "Pages/DoadorPage.xaml", typeof(global::App_DoeCalor_Final.Pages.DoadorPage))]

namespace App_DoeCalor_Final.Pages {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("Pages\\DoadorPage.xaml")]
    public partial class DoadorPage : global::Xamarin.Forms.ContentPage {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::App_DoeCalor_Final.ViewModels.ExtendedMap Mapa;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.Label LatitudeLabel;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.Label LongitudeLabel;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.Maps.Map Mapas;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(DoadorPage));
            Mapa = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::App_DoeCalor_Final.ViewModels.ExtendedMap>(this, "Mapa");
            LatitudeLabel = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Label>(this, "LatitudeLabel");
            LongitudeLabel = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Label>(this, "LongitudeLabel");
            Mapas = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Maps.Map>(this, "Mapas");
        }
    }
}
