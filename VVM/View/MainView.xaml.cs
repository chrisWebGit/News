namespace VVM.View
{
    public partial class MainView : System.Windows.Window
    {
        public MainView()
        {
            InitializeComponent();
            Date.SelectedDate = System.DateTime.Now;
        }
    }
}
