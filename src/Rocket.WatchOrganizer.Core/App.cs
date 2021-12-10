using MvvmCross.IoC;
using MvvmCross.ViewModels;
using Rocket.WatchOrganizer.Core.ViewModels.Root;

namespace Rocket.WatchOrganizer.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<RootViewModel>();
        }
    }
}
