using Microsoft.EntityFrameworkCore.Storage;
using System.Reflection.Metadata;
using System.Xml.Linq;

namespace Cinema
{
    //missing: only show movies in combobox that are playing in the selected day
    public partial class Form1 : Form
    {
        private readonly DateTime DAYTODAY = DateTime.Today;
        private readonly DateTime DAYTOMORROW = DateTime.Today.AddDays(1);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            string viewMode = XmlHandler.ReadElementValue("viewmode");
            if (viewMode == "admin")
            {
                //
            }
            else
            {

                // Hide admin buttons
                //adminBtn.Visible = false;
                //adminBtn.Enabled = false;
            }
            AppendDefaultValuesToCBoxes();
        }

        private void HandleTitleChange()
        {
            listBox1.Items.Clear();

            IEnumerable<XElement> schedule = XmlHandler.ReadDescendants("schedule").Descendants();
            string selectedTitle = titleCBox.SelectedItem.ToString();

            if (selectedTitle != null)
            {
                string searchString = $"<title>{selectedTitle}</title>";
                foreach (XElement xe in schedule.Descendants())
                {
                    if (xe.ToString().Contains(searchString))
                    {
                        foreach (XElement elem in xe.Parent.Descendants())
                        {
                            if (elem.Name != "id")
                            {
                                listBox1.Items.Add($"{elem.Name} : {elem.Value}");
                            }
                        }
                    }
                }
            }
        }

        private void HandleDateChange()
        {
            listBox1.Items.Clear();

            IEnumerable<XElement> schedule = XmlHandler.ReadDescendants("schedule").Descendants();
            string selectedDate = dateCBox.SelectedItem.ToString(); // Assuming dateCBox is the ComboBox containing selected date

            if (selectedDate != null)
            {
                string searchString = $"<playdate>{selectedDate}</playdate>";
                foreach (XElement xe in schedule.Descendants())
                {
                    if (xe.ToString().Contains(searchString))
                    {
                        foreach (XElement elem in xe.Parent.Descendants())
                        {
                            if (elem.Name != "id")
                            {
                                listBox1.Items.Add($"{elem.Name} : {elem.Value}");
                            }
                        }
                    }
                }
            }
        }

        private void AppendDefaultValuesToCBoxes()
        {

            IEnumerable<XElement> playDates = XmlHandler.ReadDescendants("playdate");
            IEnumerable<XElement> playTimes = XmlHandler.ReadDescendants("playtime");
            IEnumerable<XElement> titles = XmlHandler.ReadDescendants("title");
            foreach (var item in playDates)
            {
                dateCBox.Items.Add(item.Value);
            }
            foreach (var item in titles)
            {
                titleCBox.Items.Add(item.Value);
            }
            foreach (var item in playTimes)
            {
                timeCBox.Items.Add(item.Value);
            }

        }

        private void titleCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            HandleTitleChange();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void dateCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            HandleDateChange();
        }
    }
}