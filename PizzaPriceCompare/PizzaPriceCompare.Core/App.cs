using Acr.UserDialogs;
using MvvmCross;
using MvvmCross.IoC;
using MvvmCross.ViewModels;
using PizzaPriceCompare.Core.Services;
using PizzaPriceCompare.Core.ViewModels;
using System;
using System.IO;

namespace PizzaPriceCompare.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            base.Initialize();

            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            Mvx.IoCProvider.RegisterSingleton<IUserDialogs>(() => UserDialogs.Instance);
            Mvx.IoCProvider.RegisterSingleton<IPizzaPriceDatabase>(new PizzaPriceDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "PizzaPrice.db")));

            RegisterAppStart<MasterDetailViewModel>();

        }
    }
}