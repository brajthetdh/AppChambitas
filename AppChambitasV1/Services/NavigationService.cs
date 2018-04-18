﻿using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using AppChambitasV1.Views;

namespace AppChambitasV1.Services
{
    public class NavigationService
    {
        public void SetMainPage(string pageName)
        {
            switch (pageName)
            {
                case "LoginView":
                    Application.Current.MainPage = new NavigationPage(new LoginView());
                    break;
                case "MasterView":
                    Application.Current.MainPage = new MasterView();
                    break;
            }
        }

        public async Task NavigateOnMaster(string pageName)
        {
            App.Master.IsPresented = false;

            switch (pageName)
            {
                case "CategoriesView":
                    await App.Navigator.PushAsync(
                        new CategoriesView());
                    break;
                case "TiposServiciosDetalleView":
                    await App.Navigator.PushAsync(
                        new TiposServiciosDetalleView());
                    break;
                case "TecnicosView":
                    await App.Navigator.PushAsync(
                        new TecnicosView());
                    break;
                //case "EditCategoryView":
                //    await App.Navigator.PushAsync(
                //        new EditCategoryView());
                //    break;
                //case "NewProductView":
                //    await App.Navigator.PushAsync(
                //        new NewProductView());
                //    break;
                //case "EditProductView":
                    //await App.Navigator.PushAsync(
                    //    new EditProductView());
                    //break;
                case "UbicationsView":
                    await App.Navigator.PushAsync(
                        new UbicationsView());
                    break;
                //case "SyncView":
                    //await App.Navigator.PushAsync(
                        //new SyncView());
                    //break;
                case "MyProfileView":
                    await App.Navigator.PushAsync(
                        new MyProfileView());
                    break;
            }
        }

        public async Task NavigateOnLogin(string pageName)
        {
            switch (pageName)
            {
                case "NewCustomerView":
                    await Application.Current.MainPage.Navigation.PushAsync(
                        new NewCustomerView());
                    break;
                case "LoginFacebookView":
                    await Application.Current.MainPage.Navigation.PushAsync(
                        new LoginFacebookView());
                    break;
                case "PasswordRecoveryView":
                    await Application.Current.MainPage.Navigation.PushAsync(
                        new PasswordRecoveryView());
                    break;
            }
        }

        public async Task BackOnMaster()
        {
            await App.Navigator.PopAsync();
        }

        public async Task BackOnLogin()
        {
            await Application.Current.MainPage.Navigation.PopAsync();
        }    
    }
}
