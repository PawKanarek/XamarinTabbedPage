
using System.Diagnostics;
using Xamarin.Forms;

namespace TabbePageTest
{

    public class TestTab1 : ContentPage
    {
        public TestTab1()
        {
            Debug.WriteLine("TestTab1 Constuctor");
            this.Title = "Tab1";
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Debug.WriteLine("TestTab1 OnAppearing");
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            Debug.WriteLine("TestTab1 OnDisappearing");
        }
    }

    public class TestTab2 : ContentPage
    {
        public TestTab2()
        {
            Debug.WriteLine("TestTab2 Constuctor");
            this.Title = "Tab2";
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            Debug.WriteLine("TestTab2 OnAppearing");
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            Debug.WriteLine("TestTab2 OnDisappearing");
        }
    }

    public class TestTab3 : ContentPage
    {
        public TestTab3()
        {
            Debug.WriteLine("TestTab3 Constuctor");
            this.Title = "Tab3";
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            Debug.WriteLine("TestTab3 OnAppearing");
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            Debug.WriteLine("TestTab3 OnDisappearing");
        }
    }

    public class TestTab4 : ContentPage
    {
        public TestTab4()
        {
            Debug.WriteLine("TestTab4 Constuctor");
            this.Title = "Tab4";
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Debug.WriteLine("TestTab4 OnAppearing");
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            Debug.WriteLine("TestTab4 OnDisappearing");
        }
    }

    public class MainTabbedPage : TabbedPage
    {
        public MainTabbedPage()
        {
            Debug.WriteLine("MainTabbedPage Constuctor");
            this.Children.Add(new TestTab1());
            this.Children.Add(new TestTab2());
            this.Children.Add(new TestTab3());
            this.Children.Add(new TestTab4());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Debug.WriteLine("MainTabbedPage OnAppearing");
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            Debug.WriteLine("MainTabbedPage OnDisappearing");
        }
    }

    public class App : Application
    {
        public App()
        {


            var tabbedPage = new MainTabbedPage();


            //MainPage = new NavigationPage(content);
            MainPage = tabbedPage;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
