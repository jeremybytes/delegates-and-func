using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace FuncActionDelegates
{
    public partial class MainWindow : Window
    {
        //PersonFormat formatPerson;
        Func<Person, string> formatPerson;

        //public delegate void PeopleAction(List<Person> input);
        Action<List<Person>> actOnPeople;

        public MainWindow()
        {
            InitializeComponent();
            PersonListBox.ItemsSource = People.GetPeople();
        }

        public void AssignDelegate()
        {
            if (Option1Button.IsChecked.Value)
                formatPerson = p => p.ToString();
            else if (Option2Button.IsChecked.Value)
                formatPerson = p => p.LastName.ToUpper();
            else if (Option3Button.IsChecked.Value)
                formatPerson = p => p.FirstName.ToLower();
            else if (Option4Button.IsChecked.Value)
                formatPerson = p => string.Format("{0}, {1}", p.LastName, p.FirstName);
        }

        public void AssignAction()
        {
            actOnPeople = null;
            if (OptionCButton.IsChecked.Value)
                actOnPeople += p => MessageBox.Show(
                    p.OrderByDescending(r => r.Rating).First().LastName);

            if (OptionAButton.IsChecked.Value)
                actOnPeople += p => OutputList.Items.Add(
                    p.Average(r => r.Rating).ToString("#.#"));

            if (OptionBButton.IsChecked.Value)
                actOnPeople += p => OutputList.Items.Add(p.Min(s => s.StartDate));

            if (OptionDButton.IsChecked.Value)
                actOnPeople += p =>
                {
                    p.ForEach(c => Console.Write(c.LastName[0]));
                    Console.WriteLine();
                };
        }

        private void ProcessDataButton_Click(object sender, RoutedEventArgs e)
        {
            OutputList.Items.Clear();
            if (StringExpander.IsExpanded)
            {
                AssignDelegate();
                foreach (Person person in PersonListBox.Items)
                    OutputList.Items.Add(person.ToString(formatPerson));
            }
            if (ActionExpander.IsExpanded)
            {
                AssignAction();
                var people = People.GetPeople();
                if (actOnPeople != null)
                    actOnPeople(people);
            }
        }
    }
}
