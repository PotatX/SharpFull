using Newtonsoft.Json;

namespace WinFormsAppGosiTest
{
    public partial class FormCars : Form
    {
        const string FileName = "filename.txt";
        List<Car> cars = new ();

        public FormCars()
        {
            InitializeComponent();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            var dataFromFile = File.ReadAllText(FileName);
            cars = JsonConvert.DeserializeObject<List<Car>>(dataFromFile);
            listBoxCars.Items.Clear();
            cars.ForEach(rec => listBoxCars.Items.Add(rec.ToString()));
            dataGridViewCars.DataSource = cars;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var car = new Car
            {
                Name = textBoxName.Text,
                Width = Convert.ToInt32(textBoxWidth.Text),
                Height = Convert.ToInt32(textBoxHeight.Text),
                IsBus = checkBoxIsBus.Checked,
            };

            cars.Add(car);
            saveCard();
        }

        private void buttonDeleteSus_Click(object sender, EventArgs e)
        {
            var temp = cars.Where(car => car.Height > 200).ToList();
            listBoxCars.Items.Clear();
            temp.ForEach(rec => listBoxCars.Items.Add(rec.ToString()));
        }

        private void saveCard()
        {
            File.WriteAllText(FileName, JsonConvert.SerializeObject(cars));
        }

        private void buttonDeleteName_Click(object sender, EventArgs e)
        {
            var temp = cars.GroupBy(car => car.Width).Max(car => car.Key);
            var t = cars.First(car => car.Width == temp);
            listBoxCars.Items.Clear();
            listBoxCars.Items.Add(t.ToString());
        }
    }
}