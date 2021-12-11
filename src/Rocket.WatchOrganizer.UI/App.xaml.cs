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
[assembly: ExportFont("Nunito-Black.ttf", Alias = "NunitoBlack")]
[assembly: ExportFont("Nunito-Bold.ttf", Alias = "NunitoBold")]
[assembly: ExportFont("Nunito-ExtraBold.ttf", Alias = "NunitoExtraBold")]
[assembly: ExportFont("Nunito-ExtraLight.ttf", Alias = "NunitoExtraLight")]
[assembly: ExportFont("Nunito-Italic.ttf", Alias = "NunitoItalic")]
[assembly: ExportFont("Nunito-Light.ttf", Alias = "NunitoLight")]
[assembly: ExportFont("Nunito-Medium.ttf", Alias = "NunitoMedium")]
[assembly: ExportFont("Nunito-Regular.ttf", Alias = "NunitoRegular")]
[assembly: ExportFont("Nunito-SemiBold.ttf", Alias = "NunitoSemiBold")]


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
