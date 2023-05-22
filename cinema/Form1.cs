using Microsoft.EntityFrameworkCore.Storage;
using System.Reflection.Metadata;
using System.Xml.Linq;

namespace Cinema
{
    public partial class Form1 : Form
    {
        private readonly DateTime DAYTODAY = DateTime.Today;
        private readonly DateTime DAYTOMORROW = DateTime.Today.AddDays(1);
        private readonly bool ISADMIN = XmlHandler.IsViewModeAdmin();
        private readonly string DEFAULTADMINCBOXTEXT = "ADD AS NEW";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!ISADMIN)
            {
                adminPlaytimeTBox.Enabled = false;
                adminRoomTBox.Enabled = false;
                admonPlaydateTBox.Enabled = false;
                adminLengthTBox.Enabled = false;
                adminDirectorTBox.Enabled = false;
                adminTitleTBox.Enabled = false;
                adminAddMovieButton.Enabled = false;
                adminModyfyCBox.Enabled = false;
                label11.ForeColor = Color.Red;
            }
            else
            {
                adminModyfyCBox.Items.Add(DEFAULTADMINCBOXTEXT);
                adminModyfyCBox.SelectedItem = DEFAULTADMINCBOXTEXT;
            }
            AppendDefaultValuesToCBoxes();
            ToggleAllCheckboxes(false);
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
                            if (!ISADMIN)
                            {
                                if (elem.Name != "id")
                                {
                                    listBox1.Items.Add($"{elem.Name} : {elem.Value}");
                                }
                            }
                            else
                            {
                                listBox1.Items.Add($"{elem.Name} : {elem.Value}");
                            }
                        }
                    }
                }
            }
            ToggleAllCheckboxes(false);
        }

        private void HandleDateChange()
        {
            listBox1.Items.Clear();

            IEnumerable<XElement> schedule = XmlHandler.ReadDescendants("schedule").Descendants();
            string selectedDate = dateCBox.SelectedItem.ToString();

            if (selectedDate != null)
            {
                string searchString = $"<playdate>{selectedDate}</playdate>";
                foreach (XElement xe in schedule.Descendants())
                {
                    if (xe.ToString().Contains(searchString))
                    {
                        foreach (XElement elem in xe.Parent.Descendants())
                        {
                            if (!ISADMIN)
                            {
                                if (elem.Name != "id")
                                {
                                    listBox1.Items.Add($"{elem.Name} : {elem.Value}");
                                }
                            }
                            else
                            {
                                listBox1.Items.Add($"{elem.Name} : {elem.Value}");
                            }
                        }
                    }
                }
            }
            ToggleAllCheckboxes(false);
        }

        private void AppendDefaultValuesToCBoxes()
        {
            titleCBox.Items.Clear();
            dateCBox.Items.Clear();
            timeCBox.Items.Clear();
            listBox1.Items.Clear();
            IEnumerable<XElement> playDates = XmlHandler.ReadDescendants("playdate");
            IEnumerable<XElement> playTimes = XmlHandler.ReadDescendants("playtime");
            IEnumerable<XElement> titles = XmlHandler.ReadDescendants("title");
            foreach (var item in playDates)
            {
                if (!dateCBox.Items.Contains(item.Value))
                {
                    dateCBox.Items.Add(item.Value);
                }
            }
            foreach (var item in titles)
            {
                if (!titleCBox.Items.Contains(item.Value))
                {
                    titleCBox.Items.Add(item.Value);
                }
            }
            foreach (var item in playTimes)
            {
                if (!timeCBox.Items.Contains(item.Value))
                {
                    timeCBox.Items.Add(item.Value);
                }
            }
            if (ISADMIN)
            {
                IEnumerable<XElement> scheduled = XmlHandler.ReadDescendants("screening");
                foreach (var item in scheduled)
                {
                    if (!adminModyfyCBox.Items.Contains(item.ToString()))
                    {
                        adminModyfyCBox.Items.Add(item.ToString());
                    }
                    //else
                    //{
                    //    throw new Exception("Duplicate data (id) in schedule!");
                    //}
                }
            }
        }

        private void titleCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            HandleTitleChange();
        }
        private void dateCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            HandleDateChange();
        }

        private void adminModyfyCBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void adminAddMovieButton_Click(object sender, EventArgs e)
        {
            if (adminModyfyCBox.SelectedItem.ToString() == DEFAULTADMINCBOXTEXT)
            {
                AddNewMovie();
            }
            else
            {
                XElement movieToReplace = XElement.Parse(adminModyfyCBox.SelectedItem.ToString());
                if (movieToReplace != null)
                {
                    ModifyMovie(movieToReplace);
                }
                else
                {
                    throw new Exception("Parsing wont work!");
                }
            }
        }

        private void ModifyMovie(XElement movieToReplace)
        {
            if (adminModyfyCBox.SelectedItem.ToString() != DEFAULTADMINCBOXTEXT)
            {
                string selectedId = adminModyfyCBox.SelectedItem.ToString().Split("<id>")[1].Split("</id>")[0];
                string selectedTitle = adminTitleTBox.Text;
                string selectedDirector = adminDirectorTBox.Text;
                string selectedLength = adminLengthTBox.Text;
                string selectedPlaydate = admonPlaydateTBox.Text;
                string selectedPlaytime = adminPlaytimeTBox.Text;
                string oldActors = adminModyfyCBox.SelectedItem.ToString().Split("<actors>")[1].Split("</actors")[0];
                string selectedRoom = adminRoomTBox.Text;

                if
                (
                    selectedTitle != null
                    &&
                    selectedDirector != null
                    &&
                    selectedLength != null
                    &&
                    selectedPlaydate != null
                    &&
                    selectedPlaytime != null
                    &&
                    selectedRoom != null
                )
                {
                    string newMovie = $"<screening><id>{selectedId}</id><title>{selectedTitle}</title><director>{selectedDirector}</director><actors>{oldActors}</actors><length>{selectedLength}</length><playdate>{selectedPlaydate}</playdate><playtime>{selectedPlaytime}</playtime><room>{selectedRoom}</room></screening>";
                    XElement movie = XElement.Parse(newMovie);
                    XmlHandler.ModifyElement(int.Parse(selectedId), movie);
                    MessageBox.Show("Movie modified!");
                    AppendDefaultValuesToCBoxes();
                }
                else
                {
                    MessageBox.Show("Please fill out all fields!");
                }
            }
            else
            {
                MessageBox.Show("Please select a movie to modify!");
            }
        }

        private void AddNewMovie()
        {
            string selectedTitle = adminTitleTBox.Text;
            string selectedDirector = adminDirectorTBox.Text;
            string selectedLength = adminLengthTBox.Text;
            string selectedPlaydate = admonPlaydateTBox.Text;
            string selectedPlaytime = adminPlaytimeTBox.Text;
            string selectedActors = "";
            string selectedRoom = adminRoomTBox.Text;

            if
            (
                selectedTitle != null
                &&
                selectedDirector != null
                &&
                selectedLength != null
                &&
                selectedPlaydate != null
                &&
                selectedPlaytime != null
                &&
                selectedActors != null
                &&
                selectedRoom != null
            )
            {
                string newMovie = $"<screening><id>{XmlHandler.GetNextScreeningId()}</id><title>{selectedTitle}</title><director>{selectedDirector}</director><actors>{selectedActors}</actors><length>{selectedLength}</length><playdate>{selectedPlaydate}</playdate><playtime>{selectedPlaytime}</playtime><room>{selectedRoom}</room></screening>";
                XElement movie = XElement.Parse(newMovie);
                XmlHandler.AddNewScreening(movie);
                MessageBox.Show("Movie added!");
                AppendDefaultValuesToCBoxes();
            }
            else
            {
                MessageBox.Show("Please fill out all fields!");
            }
        }

        private int[] GetIndexOfCheckbox(string nameOfCheckbox) 
        {
            string[] parts = nameOfCheckbox.Split('_');
            return new int[] { int.Parse(parts[^2]), int.Parse(parts[^1]) };
           
        }

        private IEnumerable<CheckBox> GetCheckBoxes()
        {
            return Controls.OfType<CheckBox>();
        }

        private void ToggleAllCheckboxes(bool value)
        {
            IEnumerable<CheckBox> checkBoxes = GetCheckBoxes();
            foreach (var item in checkBoxes)
            {
                item.Checked = false;
                item.Enabled = value;
            }
        }

        private string ConstructCheckboxName(int row, int seat)
        {
            return $"box_{row}_{seat}";
        }

        private XElement GetScreeningByTitleAndDateAndTime(string title, string date, string time)
        {
            IEnumerable<XElement> screenings = XmlHandler.ReadDescendants("screening");
            foreach (var item in screenings)
            {
                if (item.Element("title").Value == title && item.Element("playdate").Value == date && item.Element("playtime").Value == time)
                {
                    return item;
                }
            }
            return null;
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            //check the seats that are selected and not disabled and modify the order xml accordingly, show a message box with success or failure
            string title = titleCBox.SelectedItem.ToString();
            string date = dateCBox.SelectedItem.ToString();
            string time = timeCBox.SelectedItem.ToString();
            XElement screening = GetScreeningByTitleAndDateAndTime(title, date, time);
            if (screening != null)
            {
                int screeningId = int.Parse(screening.Element("id").Value);
                int newOrderId = XmlHandler.GetNextOrderId();
                string seatsString = $"<seats>";
                IEnumerable<XElement> orders = XmlHandler.ReadDescendants("order");
                IEnumerable<CheckBox> intendedOrders = GetCheckBoxes().Where(x => x.Checked == true && x.Enabled == true);
                if (intendedOrders.Count() > 0)
                {
                    foreach (var order in intendedOrders)
                    {
                        int[] indexes = GetIndexOfCheckbox(order.Name);
                        string intendedSeatString = $"<seat><row>{indexes[0]}</row><col>{indexes[1]}</col></seat>";
                        seatsString += intendedSeatString;
                    }
                    seatsString += "</seats>";
                    MessageBox.Show("Order successful!");
                    string newOrder = $"<order><id>{newOrderId}</id><movieid>{screeningId}</movieid>{seatsString}</order>";
                    MessageBox.Show(newOrder);
                    XmlHandler.AddNewOrder(XElement.Parse(newOrder));
                    ToggleAllCheckboxes(false);
                }
                else
                {
                    MessageBox.Show("Please select at least one seat!");
                }
            }
            else
            {
                MessageBox.Show("Please select a screening!");
                ToggleAllCheckboxes(false);
            }
        }

        private void checkSeatsButton_Click(object sender, EventArgs e)
        {
            ToggleAllCheckboxes(true);
            string title = titleCBox.SelectedItem.ToString();
            string date = dateCBox.SelectedItem.ToString();
            string time = timeCBox.SelectedItem.ToString();
            XElement screening = GetScreeningByTitleAndDateAndTime(title, date, time);
            //MessageBox.Show(screening.ToString());
            if (screening != null)
            {
                IEnumerable<XElement> orders = XmlHandler.ReadDescendants("order");
                foreach (XElement item in orders)
                {
                    if (item.Element("movieid").Value == screening.Element("id").Value)
                    {
                        //MessageBox.Show(item.ToString());
                        IEnumerable<XElement> itemAsSeats = item.Descendants("seat");
                        foreach (var seat in itemAsSeats)
                        {
                            //MessageBox.Show(seat.ToString());
                            int row = int.Parse(seat.Element("row").Value);
                            int col = int.Parse(seat.Element("col").Value);
                            string checkboxName = ConstructCheckboxName(row, col);
                            CheckBox checkbox = Controls.Find(checkboxName, true).FirstOrDefault() as CheckBox;
                            checkbox.Checked = true;
                            checkbox.Enabled = false;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No screening found!");
                ToggleAllCheckboxes(false);
            }
        }
    }
}