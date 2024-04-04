using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace Shipping
{
    public partial class Form1 : Form
    {
        private SqlConnection sqlConnection = null;

        private SqlDataAdapter adapterCargo = null;
        private SqlDataAdapter adapterShip = null;
        private SqlDataAdapter adapterShipment = null;

        private DataTable tableShip = null;
        private DataTable tableCargo = null;
        private DataTable tableShipment = null;
        private DataTable tableReq = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void update()
        {
            tableShip.Clear();
            tableCargo.Clear();
            tableShipment.Clear();

            adapterShip.Fill(tableShip);
            adapterCargo.Fill(tableCargo);
            adapterShipment.Fill(tableShipment);

            dataGridView1.DataSource = tableShip;
            dataGridView2.DataSource = tableCargo;
            dataGridView3.DataSource = tableShipment;
        }

        public void execute(string query, string message)
        {
            SqlCommand command = new SqlCommand(query, sqlConnection);
            try
            {
                if (command.ExecuteNonQuery() != 1)
                    MessageBox.Show("Ошибка выполнения запроса", "Ошибка");
                else
                    MessageBox.Show($"Данные {message}", "Успех");
            }
            catch
            {
                MessageBox.Show("Ошибка выполнения запроса", "Ошибка");
            }
            finally
            {
                update();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            update();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(@"Server=(localdb)\Weather;Database=Shipping;Trusted_Connection=True;");

            sqlConnection.Open();

            adapterShip = new SqlDataAdapter("SELECT * FROM Ship", sqlConnection);
            adapterCargo = new SqlDataAdapter("SELECT * FROM Cargo", sqlConnection);
            adapterShipment = new SqlDataAdapter("SELECT * FROM Shipment", sqlConnection);

            tableShip = new DataTable();
            tableCargo = new DataTable();
            tableShipment = new DataTable();
            tableReq = new DataTable();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }

            int index = dataGridView1.SelectedRows[0].Index;
            if (dataGridView1.Rows[index].Cells[0].Value == null ||
                dataGridView1.Rows[index].Cells[1].Value == null ||
                dataGridView1.Rows[index].Cells[2].Value == null ||
                dataGridView1.Rows[index].Cells[3].Value == null ||
                dataGridView1.Rows[index].Cells[4].Value == null ||
                dataGridView1.Rows[index].Cells[5].Value == null ||
                dataGridView1.Rows[index].Cells[6].Value == null
                )
            {
                MessageBox.Show("Не все поля заполнены!", "Внимание!");
                return;
            }

            string RegNumber = dataGridView1.Rows[index].Cells[0].Value.ToString();
            string Name = dataGridView1.Rows[index].Cells[1].Value.ToString();
            string Skipper = dataGridView1.Rows[index].Cells[2].Value.ToString();
            string Type = dataGridView1.Rows[index].Cells[3].Value.ToString();
            string Capacity = dataGridView1.Rows[index].Cells[4].Value.ToString();
            string Year = dataGridView1.Rows[index].Cells[5].Value.ToString();
            string DockYard = dataGridView1.Rows[index].Cells[6].Value.ToString();



            string query = $"INSERT INTO Ship VALUES({RegNumber}, '{Name}', '{Skipper}', '{Type}', {Capacity}, {Year}, '{DockYard}')";
            execute(query, "добавлены");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }

            int index = dataGridView2.SelectedRows[0].Index;
            if (dataGridView2.Rows[index].Cells[0].Value == null ||
                dataGridView2.Rows[index].Cells[1].Value == null ||
                dataGridView2.Rows[index].Cells[2].Value == null ||
                dataGridView2.Rows[index].Cells[3].Value == null ||
                dataGridView2.Rows[index].Cells[4].Value == null ||
                dataGridView2.Rows[index].Cells[5].Value == null
                )
            {
                MessageBox.Show("Не все поля заполнены!", "Внимание!");
                return;
            }

            string CustomValue = dataGridView2.Rows[index].Cells[0].Value.ToString();
            string DepartureDate = dataGridView2.Rows[index].Cells[1].Value.ToString();
            string ArriveDate = dataGridView2.Rows[index].Cells[2].Value.ToString();
            string Origin = dataGridView2.Rows[index].Cells[3].Value.ToString();
            string Destination = dataGridView2.Rows[index].Cells[4].Value.ToString();
            string ShipRegNumber = dataGridView2.Rows[index].Cells[5].Value.ToString();


            string query = $"INSERT INTO Cargo VALUES({CustomValue}, '{DepartureDate}', '{ArriveDate}', '{Origin}', '{Destination}', {ShipRegNumber})";
            execute(query, "добавлены");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }

            int index = dataGridView2.SelectedRows[0].Index;


            string CustomValue = dataGridView2.Rows[index].Cells[0].Value.ToString();



            string query = $"DELETE FROM Cargo WHERE CustomValue = {CustomValue}";
            execute(query, "удалены");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }

            int index = dataGridView2.SelectedRows[0].Index;
            if (dataGridView2.Rows[index].Cells[0].Value == null ||
                dataGridView2.Rows[index].Cells[1].Value == null ||
                dataGridView2.Rows[index].Cells[2].Value == null ||
                dataGridView2.Rows[index].Cells[3].Value == null ||
                dataGridView2.Rows[index].Cells[4].Value == null ||
                dataGridView2.Rows[index].Cells[5].Value == null
                )
            {
                MessageBox.Show("Не все поля заполнены!", "Внимание!");
                return;
            }

            string CustomValue = dataGridView2.Rows[index].Cells[0].Value.ToString();
            string DepartureDate = dataGridView2.Rows[index].Cells[1].Value.ToString();
            string ArriveDate = dataGridView2.Rows[index].Cells[2].Value.ToString();
            string Origin = dataGridView2.Rows[index].Cells[3].Value.ToString();
            string Destination = dataGridView2.Rows[index].Cells[4].Value.ToString();
            string ShipRegNumber = dataGridView2.Rows[index].Cells[5].Value.ToString();


            string query = $"UPDATE Cargo SET  DepartureDate = '{DepartureDate}', ArriveDate = '{ArriveDate}', Origin = '{Origin}', Destination = '{Destination}', ShipRegNumber = {ShipRegNumber} WHERE CustomValue = {CustomValue}";
            execute(query, "обновлены");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }

            int index = dataGridView1.SelectedRows[0].Index;
            if (dataGridView1.Rows[index].Cells[0].Value == null ||
                dataGridView1.Rows[index].Cells[1].Value == null ||
                dataGridView1.Rows[index].Cells[2].Value == null ||
                dataGridView1.Rows[index].Cells[3].Value == null ||
                dataGridView1.Rows[index].Cells[4].Value == null ||
                dataGridView1.Rows[index].Cells[5].Value == null ||
                dataGridView1.Rows[index].Cells[6].Value == null
                )
            {
                MessageBox.Show("Не все поля заполнены!", "Внимание!");
                return;
            }

            string RegNumber = dataGridView1.Rows[index].Cells[0].Value.ToString();
            string Name = dataGridView1.Rows[index].Cells[1].Value.ToString();
            string Skipper = dataGridView1.Rows[index].Cells[2].Value.ToString();
            string Type = dataGridView1.Rows[index].Cells[3].Value.ToString();
            string Capacity = dataGridView1.Rows[index].Cells[4].Value.ToString();
            string Year = dataGridView1.Rows[index].Cells[5].Value.ToString();
            string DockYard = dataGridView1.Rows[index].Cells[6].Value.ToString();



            string query = $"UPDATE Ship SET Name = '{Name}', Skipper = '{Skipper}', Type = '{Type}', Capacity = {Capacity}, Year =  {Year}, DockYard = '{DockYard}' WHERE RegNumber = {RegNumber}";
            execute(query, "обновлены");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }

            int index = dataGridView1.SelectedRows[0].Index;


            string RegNumber = dataGridView1.Rows[index].Cells[0].Value.ToString();



            string query = $"DELETE FROM SHIP WHERE RegNumber = {RegNumber}";
            execute(query, "удалены");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }

            int index = dataGridView3.SelectedRows[0].Index;
            if (dataGridView3.Rows[index].Cells[0].Value == null ||
                dataGridView3.Rows[index].Cells[1].Value == null ||
                dataGridView3.Rows[index].Cells[2].Value == null ||
                dataGridView3.Rows[index].Cells[3].Value == null ||
                dataGridView3.Rows[index].Cells[4].Value == null ||
                dataGridView3.Rows[index].Cells[5].Value == null ||
                dataGridView3.Rows[index].Cells[6].Value == null ||
                dataGridView3.Rows[index].Cells[7].Value == null ||
                dataGridView3.Rows[index].Cells[8].Value == null ||
                dataGridView3.Rows[index].Cells[9].Value == null ||
                dataGridView3.Rows[index].Cells[10].Value == null ||
                dataGridView3.Rows[index].Cells[11].Value == null ||
                dataGridView3.Rows[index].Cells[12].Value == null ||
                dataGridView3.Rows[index].Cells[13].Value == null
                )
            {
                MessageBox.Show("Не все поля заполнены!", "Внимание!");
                return;
            }

            string CustomValue = dataGridView3.Rows[index].Cells[0].Value.ToString();
            string Number = dataGridView3.Rows[index].Cells[1].Value.ToString();
            string Shipment = dataGridView3.Rows[index].Cells[2].Value.ToString();
            string DeclareValue = dataGridView3.Rows[index].Cells[3].Value.ToString();
            string Unit = dataGridView3.Rows[index].Cells[4].Value.ToString();
            string InsureValue = dataGridView3.Rows[index].Cells[5].Value.ToString();
            string Sender = dataGridView3.Rows[index].Cells[6].Value.ToString();
            string INNsender = dataGridView3.Rows[index].Cells[7].Value.ToString();
            string AddressSender = dataGridView3.Rows[index].Cells[8].Value.ToString();
            string Consignee = dataGridView3.Rows[index].Cells[9].Value.ToString();
            string INNconsignee = dataGridView3.Rows[index].Cells[10].Value.ToString();
            string BankConsignee = dataGridView3.Rows[index].Cells[11].Value.ToString();
            string AddressConsignee = dataGridView3.Rows[index].Cells[12].Value.ToString();

            string query = $"INSERT INTO Shipment VALUES({CustomValue}, '{Number}', '{Shipment}', '{DeclareValue}', '{Unit}', '{InsureValue}', '{Sender}', '{INNsender}', '{AddressSender}', '{Consignee}', '{INNconsignee}', '{BankConsignee}', '{AddressConsignee}')";
            execute(query, "добавлены");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }

            int index = dataGridView3.SelectedRows[0].Index;
            if (dataGridView3.Rows[index].Cells[0].Value == null ||
                dataGridView3.Rows[index].Cells[1].Value == null ||
                dataGridView3.Rows[index].Cells[2].Value == null ||
                dataGridView3.Rows[index].Cells[3].Value == null ||
                dataGridView3.Rows[index].Cells[4].Value == null ||
                dataGridView3.Rows[index].Cells[5].Value == null ||
                dataGridView3.Rows[index].Cells[6].Value == null ||
                dataGridView3.Rows[index].Cells[7].Value == null ||
                dataGridView3.Rows[index].Cells[8].Value == null ||
                dataGridView3.Rows[index].Cells[9].Value == null ||
                dataGridView3.Rows[index].Cells[10].Value == null ||
                dataGridView3.Rows[index].Cells[11].Value == null ||
                dataGridView3.Rows[index].Cells[12].Value == null ||
                dataGridView3.Rows[index].Cells[13].Value == null
                )
            {
                MessageBox.Show("Не все поля заполнены!", "Внимание!");
                return;
            }

            string CustomValue = dataGridView3.Rows[index].Cells[0].Value.ToString();
            string Number = dataGridView3.Rows[index].Cells[1].Value.ToString();
            string Shipment = dataGridView3.Rows[index].Cells[2].Value.ToString();
            string DeclareValue = dataGridView3.Rows[index].Cells[3].Value.ToString();
            string Unit = dataGridView3.Rows[index].Cells[4].Value.ToString();
            string InsureValue = dataGridView3.Rows[index].Cells[5].Value.ToString();
            string Sender = dataGridView3.Rows[index].Cells[6].Value.ToString();
            string INNsender = dataGridView3.Rows[index].Cells[7].Value.ToString();
            string AddressSender = dataGridView3.Rows[index].Cells[8].Value.ToString();
            string Consignee = dataGridView3.Rows[index].Cells[9].Value.ToString();
            string INNconsignee = dataGridView3.Rows[index].Cells[10].Value.ToString();
            string BankConsignee = dataGridView3.Rows[index].Cells[11].Value.ToString();
            string AddressConsignee = dataGridView3.Rows[index].Cells[12].Value.ToString();

            string query = $"UPDATE Shipment SET Number = '{Number}', Shipment = '{Shipment}', DeclareValue = '{DeclareValue}', Unit = '{Unit}', InsureValue = '{InsureValue}', Sender = '{Sender}', INNsender = '{INNsender}', AddressSender = '{AddressSender}', Consignee = '{Consignee}', INNconsignee = '{INNconsignee}', BankConsignee = '{BankConsignee}', AddressConsignee = '{AddressConsignee}' WHERE CustomValue = {CustomValue}";
            execute(query, "обновлены");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }

            int index = dataGridView3.SelectedRows[0].Index;

            string CustomValue = dataGridView3.Rows[index].Cells[0].Value.ToString();

            string query = $"DELETE FROM Shipment WHERE CustomValue = {CustomValue}";
            execute(query, "удалены");
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapterCapacityMore = new SqlDataAdapter("SELECT * FROM Ship WHERE Capacity > 250", sqlConnection);

            tableReq.Clear();
            adapterCapacityMore.Fill(tableReq);

            dataGridView4.DataSource = tableReq;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapterCapacityMore = new SqlDataAdapter("SELECT * FROM Cargo WHERE Origin = 'Origin1'", sqlConnection);

            tableReq.Clear();
            adapterCapacityMore.Fill(tableReq);

            dataGridView4.DataSource = tableReq;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapterCapacityMore = new SqlDataAdapter("SELECT * FROM Shipment WHERE DeclareValue > 600 AND DeclareValue < 900", sqlConnection);

            tableReq.Clear();
            adapterCapacityMore.Fill(tableReq);

            dataGridView4.DataSource = tableReq;
        }
    }
}