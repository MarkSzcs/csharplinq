using Microsoft.EntityFrameworkCore.Storage;
using System.Reflection.Metadata;
using System.Xml.Linq;

namespace Cinema
{
    //missing: only show movies in combobox that are playing today
    public partial class Form1 : Form
    {
        private readonly DateTime DAYTODAY = DateTime.Today;
        private readonly DateTime DAYTOMORROW = DateTime.Today.AddDays(1);
        private bool handle = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            string viewMode = XmlHandler.ReadElementValue("viewmode");
            if (viewMode == "admin")
            {
                AppendDateCBoxDefaultValues();
            }
            else
            {
                AppendDateCBoxDefaultValues();
                // Hide admin buttons
                //adminBtn.Visible = false;
                //adminBtn.Enabled = false;
            }
        }

        private void HandleTitleChange()
        {
            //titleCBox.SelectedItem.ToString()
            IEnumerable<XElement> schedule = XmlHandler.ReadDescendants("schedule");
            var resultOfSelection = schedule.Where
                (
                    x => 
                    x.Element("title").Value == titleCBox.SelectedItem.ToString() 
                    && 
                    x.Element("playdate").Value == dateCBox.SelectedItem.ToString()
                );

            foreach (var item in resultOfSelection)
            {
                listBox1.Items.Add(item.Element("title"));
                listBox1.Items.Add(item.Element("playdate"));
                listBox1.Items.Add(item.Element("playtime"));

            }
        }

        private void HandleDateChange()
        {

        }

        private void AppendDateCBoxDefaultValues()
        {
            dateCBox.Items.Add("Playing Today");
            dateCBox.Items.Add("Playing Tomorrow");
            dateCBox.SelectedItem = "Playing Today";


            IEnumerable<XElement> playDates = XmlHandler.ReadDescendants("playdate");
            IEnumerable<XElement> titles = XmlHandler.ReadDescendants("title");
            foreach (var item in playDates)
            {
                dateCBox.Items.Add(item.Value);
            }

            foreach (var item in titles)
            {
                titleCBox.Items.Add(item);
            }

        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void titleCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Handle();
        }
    }
}