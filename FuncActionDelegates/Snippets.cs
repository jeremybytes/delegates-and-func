/* Formatters 

        public static string Default(Person input)
        {
            return input.ToString();
        }

        public static string LastNameToUpper(Person input)
        {
            return input.LastName.ToUpper();
        }

        public static string FirstNameToLower(Person input)
        {
            return input.FirstName.ToLower();
        }

        public static string FullName(Person input)
        {
            return string.Format("{0}, {1}", input.LastName, input.FirstName);
        }

*/

/* Assign Delegate

            if (Option1Button.IsChecked.Value)
                formatPerson = Formatters.Default;
            else if (Option2Button.IsChecked.Value)
                formatPerson = Formatters.LastNameToUpper;
            else if (Option3Button.IsChecked.Value)
                formatPerson = Formatters.FirstNameToLower;
            else if (Option4Button.IsChecked.Value)
                formatPerson = Formatters.FullName;

*/

/* Assign Action

            if (OptionAButton.IsChecked.Value)
                actOnPeople += p => OutputList.Items.Add(
                    p.Average(r => r.Rating).ToString("#.#"));

            if (OptionBButton.IsChecked.Value)
                actOnPeople += p => OutputList.Items.Add(p.Min(s => s.StartDate));

            if (OptionCButton.IsChecked.Value)
                actOnPeople += p => MessageBox.Show(
                    p.OrderByDescending(r => r.Rating).First().LastName);

            if (OptionDButton.IsChecked.Value)
                actOnPeople += p =>
                    {
                        p.ForEach(c => Console.Write(c.LastName[0]));
                        Console.WriteLine();
                    };
*/