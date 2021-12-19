using DLToolkit.Forms.Controls;
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
[assembly: ExportFont("NunitoBlack.ttf", Alias = "Nunito-Black")]
[assembly: ExportFont("NunitoBold.ttf", Alias = "Nunito-Bold")]
[assembly: ExportFont("NunitoExtraBold.ttf", Alias = "Nunito-ExtraBold")]
[assembly: ExportFont("NunitoExtraLight.ttf", Alias = "Nunito-ExtraLight")]
[assembly: ExportFont("NunitoItalic.ttf", Alias = "Nunito-Italic")]
[assembly: ExportFont("NunitoLight.ttf", Alias = "Nunito-Light")]
[assembly: ExportFont("NunitoMedium.ttf", Alias = "Nunito-Medium")]
[assembly: ExportFont("NunitoSemiBold.ttf", Alias = "Nunito-SemiBold")]

/*
[assembly: ExportFont("NunitoBold.ttf", Alias = "Nunito-Bold")]
[assembly: ExportFont("NunitoExtraBold.ttf", Alias = "Nunito-ExtraBold")]
[assembly: ExportFont("NunitoExtraLight.ttf", Alias = "Nunito-ExtraLight")]
[assembly: ExportFont("NunitoItalic.ttf", Alias = "Nunito-Italic")]
[assembly: ExportFont("NunitoLight.ttf", Alias = "Nunito-Light")]
[assembly: ExportFont("NunitoMedium.ttf", Alias = "Nunito-Medium")]
[assembly: ExportFont("NunitoSemiBold.ttf", Alias = "Nunito-SemiBold")]
*/


namespace Rocket.WatchOrganizer.UI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            FlowListView.Init();

        }
    }
}
