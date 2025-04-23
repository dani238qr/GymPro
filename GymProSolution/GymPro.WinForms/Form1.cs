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

            bool isValid = true;

            // Clear previous error messages
            ShowError(lblFirstNameError, "");
            ShowError(lblLastNameError, "");
            ShowError(lblCNPError, "");
            ShowError(lblPriceError, "");
            ShowError(lblDurationError, "");
            ShowError(lblContactError, "");

            // Validate First Name
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                ShowError(lblFirstNameError, "*First name is required.");
                isValid = false;
            }

            // Validate Last Name
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                ShowError(lblLastNameError, "*Last name is required.");
                isValid = false;
            }

            // Validate CNP
            if (txtCNP.Text.Length != 13 || !txtCNP.Text.All(char.IsDigit))
            {
                ShowError(lblCNPError, "*CNP must be 13 digits.");
                isValid = false;
            }

            // Validate Price
            if (!decimal.TryParse(txtPrice.Text, out decimal _price) || _price <= 0)
            {
                ShowError(lblPriceError, "*Enter a valid price.");
                isValid = false;
            }

            // Validate Duration
            if (!int.TryParse(txtDuration.Text, out int _duration) || _duration <= 0)
            {
                ShowError(lblDurationError, "*Enter a valid duration (days).");
                isValid = false;
            }

            // Validate Contact
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtContact.Text, @"^\d{10}$"))
            {
                ShowError(lblContactError, "*Phone number must be 10 digits.");
                isValid = false;
            }

            // If any validation failed, stop here
            if (!isValid)
            {
                return;
            }


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
