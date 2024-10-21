namespace RpiTestApp.Theme
{
    public class AppTheme
    {
        private static AppTheme? _instance;

        public static AppTheme Instance 
        {
            get
            {
                _instance ??= new AppTheme();
                return _instance;
            }
        }

        public string WindowWidth => "";
        public string WindowMinWidth => "";
        public string WindowHeight => "";
        public string WindowMinHeight => ""; 
    }
}