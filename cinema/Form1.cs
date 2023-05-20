using Microsoft.EntityFrameworkCore.Storage;
using System.Xml.Linq;

namespace Cinema
{
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

        private void AppendDateCBoxDefaultValues()
        {
            dateCBox.Items.Add("Playing Today");
            dateCBox.Items.Add("Playing Tomorrow");
            dateCBox.SelectedItem = "Playing Today";


            IEnumerable<XElement> playDates = XmlHandler.ReadDescendants("playdate");
            foreach (var item in playDates)
            {
                dateCBox.Items.Add(item.Value);
            }



        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}