namespace GymPro.WinForms
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtCNP;
        private TextBox txtOptions;
        private TextBox txtPrice;
        private TextBox txtDuration;
        private TextBox txtContact;
        private ComboBox cmbSubscriptionType;  // Dropdown for subscription
        private ComboBox cmbPersonalCoach;  // Dropdown for coaches
        private Button btnAddClient;
        private Button btnLoadClients;
        private ListBox lstClients;
        private Label lblLastName;
        private Label lblFirstName;
        private Label lblCNP;
        private Label lblSubscription;
        private Label lblOptions;
        private Label lblPrice;
        private Label lblDuration;
        private Label lblContact;
        private Label lblCoach;
        private DateTimePicker dtpExpirationDate;

        private void InitializeComponent()
        {
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtCNP = new TextBox();
            txtOptions = new TextBox();
            txtPrice = new TextBox();
            txtDuration = new TextBox();
            txtContact = new TextBox();
            cmbSubscriptionType = new ComboBox();
            cmbPersonalCoach = new ComboBox();
            btnAddClient = new Button();
            btnLoadClients = new Button();
            lstClients = new ListBox();
            lblLastName = new Label();
            lblFirstName = new Label();
            lblCNP = new Label();
            lblSubscription = new Label();
            lblOptions = new Label();
            lblPrice = new Label();
            lblDuration = new Label();
            lblContact = new Label();
            lblCoach = new Label();
            dtpExpirationDate = new DateTimePicker();
            SuspendLayout();
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(156, 27);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(200, 23);
            txtLastName.TabIndex = 0;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(156, 57);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(200, 23);
            txtFirstName.TabIndex = 1;
            // 
            // txtCNP
            // 
            txtCNP.Location = new Point(156, 87);
            txtCNP.Name = "txtCNP";
            txtCNP.Size = new Size(200, 23);
            txtCNP.TabIndex = 2;
            // 
            // txtOptions
            // 
            txtOptions.Location = new Point(156, 150);
            txtOptions.Name = "txtOptions";
            txtOptions.Size = new Size(200, 23);
            txtOptions.TabIndex = 4;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(156, 180);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(200, 23);
            txtPrice.TabIndex = 5;
            // 
            // txtDuration
            // 
            txtDuration.Location = new Point(156, 211);
            txtDuration.Name = "txtDuration";
            txtDuration.Size = new Size(200, 23);
            txtDuration.TabIndex = 6;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(156, 240);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(200, 23);
            txtContact.TabIndex = 7;
            // 
            // cmbSubscriptionType
            // 
            cmbSubscriptionType.Location = new Point(156, 120);
            cmbSubscriptionType.Name = "cmbSubscriptionType";
            cmbSubscriptionType.Size = new Size(200, 23);
            cmbSubscriptionType.TabIndex = 3;
            cmbSubscriptionType.SelectedIndexChanged += cmbSubscriptionType_SelectedIndexChanged;
            // 
            // cmbPersonalCoach
            // 
            cmbPersonalCoach.Location = new Point(156, 267);
            cmbPersonalCoach.Name = "cmbPersonalCoach";
            cmbPersonalCoach.Size = new Size(200, 23);
            cmbPersonalCoach.TabIndex = 8;
            // 
            // btnAddClient
            // 
            btnAddClient.Location = new Point(85, 340);
            btnAddClient.Name = "btnAddClient";
            btnAddClient.Size = new Size(100, 30);
            btnAddClient.TabIndex = 10;
            btnAddClient.Text = "Add Client";
            btnAddClient.Click += btnAddClient_Click;
            // 
            // btnLoadClients
            // 
            btnLoadClients.Location = new Point(256, 340);
            btnLoadClients.Name = "btnLoadClients";
            btnLoadClients.Size = new Size(100, 30);
            btnLoadClients.TabIndex = 11;
            btnLoadClients.Text = "Load Clients";
            btnLoadClients.Click += btnLoadClients_Click;
            // 
            // lstClients
            // 
            lstClients.ItemHeight = 15;
            lstClients.Location = new Point(12, 376);
            lstClients.Name = "lstClients";
            lstClients.Size = new Size(424, 184);
            lstClients.TabIndex = 12;
            // 
            // lblLastName
            // 
            lblLastName.Location = new Point(50, 30);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(100, 23);
            lblLastName.TabIndex = 13;
            lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            lblFirstName.Location = new Point(50, 60);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(100, 23);
            lblFirstName.TabIndex = 14;
            lblFirstName.Text = "First Name";
            // 
            // lblCNP
            // 
            lblCNP.Location = new Point(50, 90);
            lblCNP.Name = "lblCNP";
            lblCNP.Size = new Size(100, 23);
            lblCNP.TabIndex = 15;
            lblCNP.Text = "CNP";
            // 
            // lblSubscription
            // 
            lblSubscription.Location = new Point(50, 120);
            lblSubscription.Name = "lblSubscription";
            lblSubscription.Size = new Size(100, 23);
            lblSubscription.TabIndex = 16;
            lblSubscription.Text = "Subscription Type";
            // 
            // lblOptions
            // 
            lblOptions.Location = new Point(50, 150);
            lblOptions.Name = "lblOptions";
            lblOptions.Size = new Size(100, 23);
            lblOptions.TabIndex = 17;
            lblOptions.Text = "Options";
            // 
            // lblPrice
            // 
            lblPrice.Location = new Point(50, 180);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(100, 23);
            lblPrice.TabIndex = 18;
            lblPrice.Text = "Price";
            // 
            // lblDuration
            // 
            lblDuration.Location = new Point(50, 210);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(100, 23);
            lblDuration.TabIndex = 19;
            lblDuration.Text = "Duration";
            // 
            // lblContact
            // 
            lblContact.Location = new Point(50, 240);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(100, 23);
            lblContact.TabIndex = 20;
            lblContact.Text = "Contact";
            // 
            // lblCoach
            // 
            lblCoach.Location = new Point(50, 270);
            lblCoach.Name = "lblCoach";
            lblCoach.Size = new Size(100, 23);
            lblCoach.TabIndex = 21;
            lblCoach.Text = "Personal Coach";
            // 
            // dtpExpirationDate
            // 
            dtpExpirationDate.Location = new Point(156, 311);
            dtpExpirationDate.Name = "dtpExpirationDate";
            dtpExpirationDate.Size = new Size(200, 23);
            dtpExpirationDate.TabIndex = 9;
            // 
            // Form1
            // 
            ClientSize = new Size(462, 600);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtCNP);
            Controls.Add(cmbSubscriptionType);
            Controls.Add(txtOptions);
            Controls.Add(txtPrice);
            Controls.Add(txtDuration);
            Controls.Add(txtContact);
            Controls.Add(cmbPersonalCoach);
            Controls.Add(dtpExpirationDate);
            Controls.Add(btnAddClient);
            Controls.Add(btnLoadClients);
            Controls.Add(lstClients);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(lblCNP);
            Controls.Add(lblSubscription);
            Controls.Add(lblOptions);
            Controls.Add(lblPrice);
            Controls.Add(lblDuration);
            Controls.Add(lblContact);
            Controls.Add(lblCoach);
            Name = "Form1";
            Text = "GymPro Client Management";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
