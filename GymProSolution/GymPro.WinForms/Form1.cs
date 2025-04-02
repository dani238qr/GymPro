using System;
using System.Linq;
using System.Windows.Forms;
using GymPro.Core;
using GymPro.Core.Enums;
using GymPro.Data;

namespace GymPro.WinForms
{
    public partial class Form1 : Form
    {
        private ClientRepository clientRepository = new ClientRepository();
        private string[] availableCoaches = { "John Smith - WeightTraining", "Emily Johnson - Yoga", "Michael Brown - Crossfit", "Sarah Davis - StrengthTraining" };

        public Form1()
        {
            InitializeComponent();
            InitializeDropdowns();
        }

        private void InitializeDropdowns()
        {
            cmbSubscriptionType.DataSource = Enum.GetValues(typeof(SubscriptionType));
            cmbPersonalCoach.Items.AddRange(availableCoaches);
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            // Collect input from controls
            string lastName = txtLastName.Text;
            string firstName = txtFirstName.Text;
            string cnp = txtCNP.Text;
            SubscriptionType subscriptionType = (SubscriptionType)cmbSubscriptionType.SelectedItem;
            string options = txtOptions.Text;
            decimal price = decimal.Parse(txtPrice.Text);
            int duration = int.Parse(txtDuration.Text);
            DateTime expirationDate = dtpExpirationDate.Value;
            string contact = txtContact.Text;
            string personalCoach = cmbPersonalCoach.SelectedItem?.ToString() ?? "No Coach";

            // Create subscription and client objects
            Subscription subscription = new Subscription(subscriptionType, options, price, duration);
            Client client = new Client(cnp, lastName, firstName, subscription, expirationDate, contact, personalCoach);

            // Save to repository
            clientRepository.AddClient(client);
            clientRepository.SaveClientsToFile();

            MessageBox.Show("Client successfully added!");
            LoadClients();
        }

        private void LoadClients()
        {
            lstClients.Items.Clear();
            var clients = clientRepository.GetClients();
            foreach (var client in clients)
            {
                //lstClients.Items.Add(client.ToString());
                lstClients.Items.Add($"{client.FirstName} {client.LastName} - {client.Subscription.Type} - {client.Subscription.DurationDays} days - ${client.Subscription.Price}");
            }
        }

        private void btnLoadClients_Click(object sender, EventArgs e)
        {
            LoadClients();
        }

        private void cmbSubscriptionType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
