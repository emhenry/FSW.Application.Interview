using FSW.Application.Interview.ViewModel;
using System.Windows;
using System.Windows.Threading;

namespace FSW.Application.Interview.UI
{
    /// <summary>
    ///     Interaction logic for App.xaml
    /// </summary>
    public partial class App : System.Windows.Application
    {
        public App()
        {
            Dispatcher.UnhandledException += DispatcherOnUnhandledException;
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            ComposeObjects();

            MainWindow?.Show();
        }

        private void ComposeObjects()
        {
            var fakeData = FakeData.GetFakeProductData();
            var vm = new ProductViewModel(fakeData);
            MainWindow = new MainWindow(vm);
        }

        private void DispatcherOnUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
        }
    }
}