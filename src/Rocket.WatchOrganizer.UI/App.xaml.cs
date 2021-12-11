using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

//Declaramos aqui o nome do arquivo da fonte e o "Alias" que vamos utilizar para chamar a fonte

//MATERIAL DESIGN FONTS
[assembly: ExportFont("MaterialIconsOutlined-Regular.otf", Alias = "MaterialIconsOutlined")]
[assembly: ExportFont("MaterialIcons-Regular.ttf", Alias = "MaterialIconsRegular")]
[assembly: ExportFont("MaterialIconsRound-Regular.otf", Alias = "MaterialIconsRound")]
[assembly: ExportFont("MaterialIconsSharp-Regular.otf", Alias = "MaterialIconsSharp")]
[assembly: ExportFont("MaterialIconsTwoTone-Regular.otf", Alias = "MaterialIconsTwoTone")]

//INTERFACE FONTS

[assembly: ExportFont("NunitoRegular.ttf", Alias = "Nunito-Regular")]

/*
[assembly: ExportFont("NunitoBlack.ttf", Alias = "NunitoBlack")]
[assembly: ExportFont("NunitoBold.ttf", Alias = "NunitoBold")]
[assembly: ExportFont("NunitoExtraBold.ttf", Alias = "NunitoExtraBold")]
[assembly: ExportFont("NunitoExtraLight.ttf", Alias = "NunitoExtraLight")]
[assembly: ExportFont("NunitoItalic.ttf", Alias = "NunitoItalic")]
[assembly: ExportFont("NunitoLight.ttf", Alias = "NunitoLight")]
[assembly: ExportFont("NunitoMedium.ttf", Alias = "NunitoMedium")]
[assembly: ExportFont("NunitoSemiBold.ttf", Alias = "NunitoSemiBold")]
*/


namespace Rocket.WatchOrganizer.UI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }
    }
}
