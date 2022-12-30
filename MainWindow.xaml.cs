using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Controls_Example
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> teachers = new List<string>()
        {
            "Will",
            "Anne",
            "Josh",
            "Dimpy",
            "Lhoucine"
        };

        public MainWindow()
        {
            InitializeComponent();
            // ( 4 ) Populating ListBox
            PopulateListBox_StandardWay();

            // ( 5 ) Populating Combo Box with Item Source ( We'll discuss in class )
            cbTeachers.ItemsSource = teachers;

            // ( 8 ) Populating List View with A list of Anonymous Types ( will discuss )
            lvTeachers.ItemsSource = PopulateListView();

        } // MainWindow()

        // (3) Button
        private void btnButtonClick_Click(object sender, RoutedEventArgs e)
        {
            // WPF have message boxes too
            MessageBox.Show("This button works");

            // (1) Gettings text from text box
            string userInput = txtInput.Text;



            // Pulling ListBox selected index
            int lbSelected = lbTeachers.SelectedIndex;

            // Pulling Combo Box selected index
            int cbSelected = cbTeachers.SelectedIndex;

            // ( 6 ) Check Boxes: Use .IsChecked.Value to get their bool
            // If you do .IsChecked you get a nullable bool. We'll discuss in class
            bool opt1Checked = ckOpt1.IsChecked.Value;
            bool opt2Checked = ckOpt2.IsChecked.Value;

            bool choice1Checked = rbChoice1.IsChecked.Value;
            bool choice2Checked = rbChoice2.IsChecked.Value;
            bool choice3Checked = rbChoice3.IsChecked.Value;

            int lvSelectedIndex = lvTeachers.SelectedIndex;

            string format = $"" +
                $"User Input: {userInput}\n\n" +
                $"List Box Selected Index: {lbSelected}\n\n" +
                $"Combo Box Selected Index: {cbSelected}\n\n" +
                $"Check Boxes\n" +
                $"Option 1: {opt1Checked}\n" +
                $"Option 2: {opt2Checked}\n" +
                $"\n\n" +
                $"Radio Buttons\n" +
                $"Choice 1: {choice1Checked}\n" +
                $"Choice 2: {choice2Checked}\n" +
                $"Choice 3: {choice3Checked}\n" +
                $"\n\n" +
                $"List View Selected: {lvSelectedIndex}" ;

            // (2) Displaying to rich text box
            rtbDisplay.Text = format;
        } // btnButtonClick_Click()

        void PopulateListBox_StandardWay()
        {
            // Adding items to list box .items list
            foreach (var item in teachers)
            {
                // ( 4 ) Adding to the items list in our listbox
                lbTeachers.Items.Add(item);
            }
        }

        List<object> PopulateListView()
        {
            List<object> temp = new List<object>();

            temp.Add(new { Name="Will", Grade=57, Program="CSI 124N"});
            temp.Add(new { Name="Josh", Grade=101, Program="CSI 124D"});
            temp.Add(new { Name="Anne", Grade=99, Program="CSI 140"});
            temp.Add(new { Name="Lhoucine", Grade=200, Program="CSI 124"});
            temp.Add(new { Name="Dimpy", Grade=100, Program="CSI 140"});

            return temp;
        }
    }
}
