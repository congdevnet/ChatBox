namespace DXHtmlMessengerSample.Services {
    sealed class AppSettigns : ISettingsService {
        public static void Register() {
            
            DevExpress.Mvvm.ServiceContainer.Default.RegisterService(new AppSettigns());
        }
        public string CurrentUser {
            get { return Chat_Box.Properties.Settings.Default.CurrentUser; }
        }
        public string Theme {
            get { return Chat_Box.Properties.Settings.Default.Theme; }
        }
    }
}