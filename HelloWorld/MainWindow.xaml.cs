using System.Windows;
using System.Windows.Controls;

namespace HelloWorld
{
    public partial class MainWindow : Window
    {
        private int anonymousCount = 0;
        private int namedCount = 0;

        public MainWindow()
        {
            InitializeComponent();
            ClickMeButton.Click += (s, a) => OutputList.Items.Clear();
        }

        private void NamedDelegate(object sender, RoutedEventArgs e)
        {
            OutputList.Items.Add("Named Hello");
        }

        private void AddAnonymous_Click(object sender, RoutedEventArgs e)
        {
            ClickMeButton.Click += (s, a) => OutputList.Items.Add("Anonymous Hello");
            anonymousCount++;
            AnonymousCount.Text = anonymousCount.ToString();
        }

        private void RemoveAnonymous_Click(object sender, RoutedEventArgs e)
        {
            ClickMeButton.Click -= (s, a) => OutputList.Items.Add("Anonymous Hello");
            anonymousCount--;
            AnonymousCount.Text = anonymousCount.ToString();
        }

        private void AddNamed_Click(object sender, RoutedEventArgs e)
        {
            ClickMeButton.Click += NamedDelegate;
            namedCount++;
            NamedCount.Text = namedCount.ToString();
        }

        private void RemoveNamed_Click(object sender, RoutedEventArgs e)
        {
            ClickMeButton.Click -= NamedDelegate;
            namedCount--;
            NamedCount.Text = namedCount.ToString();
        }


    }
}
