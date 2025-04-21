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
            components = new System.ComponentModel.Container();
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
            contextMenuStrip1 = new ContextMenuStrip(components);
            lblLastNameError = new Label();
            lblFirstNameError = new Label();
            lblCNPError = new Label();
            lblPriceError = new Label();
            lblDurationError = new Label();
            lblContactError = new Label();
            SuspendLayout();
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(320, 12);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(200, 23);
            txtLastName.TabIndex = 0;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(320, 58);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(200, 23);
            txtFirstName.TabIndex = 1;
            // 
            // txtCNP
            // 
            txtCNP.Location = new Point(320, 108);
            txtCNP.Name = "txtCNP";
            txtCNP.Size = new Size(200, 23);
            txtCNP.TabIndex = 2;
            // 
            // txtOptions
            // 
            txtOptions.Location = new Point(320, 193);
            txtOptions.Name = "txtOptions";
            txtOptions.Size = new Size(200, 23);
            txtOptions.TabIndex = 4;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(320, 222);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(200, 23);
            txtPrice.TabIndex = 5;
            // 
            // txtDuration
            // 
            txtDuration.Location = new Point(320, 267);
            txtDuration.Name = "txtDuration";
            txtDuration.Size = new Size(200, 23);
            txtDuration.TabIndex = 6;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(320, 312);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(200, 23);
            txtContact.TabIndex = 7;
            // 
            // cmbSubscriptionType
            // 
            cmbSubscriptionType.Location = new Point(320, 156);
            cmbSubscriptionType.Name = "cmbSubscriptionType";
            cmbSubscriptionType.Size = new Size(200, 23);
            cmbSubscriptionType.TabIndex = 3;
            cmbSubscriptionType.SelectedIndexChanged += cmbSubscriptionType_SelectedIndexChanged;
            // 
            // cmbPersonalCoach
            // 
            cmbPersonalCoach.Location = new Point(320, 358);
            cmbPersonalCoach.Name = "cmbPersonalCoach";
            cmbPersonalCoach.Size = new Size(200, 23);
            cmbPersonalCoach.TabIndex = 8;
            // 
            // btnAddClient
            // 
            btnAddClient.Location = new Point(216, 416);
            btnAddClient.Name = "btnAddClient";
            btnAddClient.Size = new Size(100, 30);
            btnAddClient.TabIndex = 10;
            btnAddClient.Text = "Add Client";
            btnAddClient.Click += btnAddClient_Click;
            // 
            // btnLoadClients
            // 
            btnLoadClients.Location = new Point(447, 416);
            btnLoadClients.Name = "btnLoadClients";
            btnLoadClients.Size = new Size(100, 30);
            btnLoadClients.TabIndex = 11;
            btnLoadClients.Text = "Load Clients";
            btnLoadClients.Click += btnLoadClients_Click;
            // 
            // lstClients
            // 
            lstClients.ItemHeight = 15;
            lstClients.Location = new Point(195, 464);
            lstClients.Name = "lstClients";
            lstClients.Size = new Size(380, 124);
            lstClients.TabIndex = 12;
            // 
            // lblLastName
            // 
            lblLastName.Location = new Point(227, 15);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(100, 23);
            lblLastName.TabIndex = 13;
            lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            lblFirstName.Location = new Point(227, 61);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(100, 23);
            lblFirstName.TabIndex = 14;
            lblFirstName.Text = "First Name";
            // 
            // lblCNP
            // 
            lblCNP.Location = new Point(227, 108);
            lblCNP.Name = "lblCNP";
            lblCNP.Size = new Size(100, 23);
            lblCNP.TabIndex = 15;
            lblCNP.Text = "CNP";
            // 
            // lblSubscription
            // 
            lblSubscription.Location = new Point(214, 159);
            lblSubscription.Name = "lblSubscription";
            lblSubscription.Size = new Size(100, 23);
            lblSubscription.TabIndex = 16;
            lblSubscription.Text = "Subscription Type";
            // 
            // lblOptions
            // 
            lblOptions.Location = new Point(227, 193);
            lblOptions.Name = "lblOptions";
            lblOptions.Size = new Size(100, 23);
            lblOptions.TabIndex = 17;
            lblOptions.Text = "Options";
            // 
            // lblPrice
            // 
            lblPrice.Location = new Point(227, 222);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(100, 23);
            lblPrice.TabIndex = 18;
            lblPrice.Text = "Price";
            // 
            // lblDuration
            // 
            lblDuration.Location = new Point(227, 270);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(100, 23);
            lblDuration.TabIndex = 19;
            lblDuration.Text = "Duration";
            // 
            // lblContact
            // 
            lblContact.Location = new Point(227, 312);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(100, 23);
            lblContact.TabIndex = 20;
            lblContact.Text = "Contact";
            // 
            // lblCoach
            // 
            lblCoach.Location = new Point(214, 358);
            lblCoach.Name = "lblCoach";
            lblCoach.Size = new Size(100, 23);
            lblCoach.TabIndex = 21;
            lblCoach.Text = "Personal Coach";
            // 
            // dtpExpirationDate
            // 
            dtpExpirationDate.Location = new Point(320, 387);
            dtpExpirationDate.Name = "dtpExpirationDate";
            dtpExpirationDate.Size = new Size(200, 23);
            dtpExpirationDate.TabIndex = 9;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // lblLastNameError
            // 
            lblLastNameError.AutoSize = true;
            lblLastNameError.ForeColor = Color.Red;
            lblLastNameError.Location = new Point(333, 40);
            lblLastNameError.Name = "lblLastNameError";
            lblLastNameError.Size = new Size(98, 15);
            lblLastNameError.TabIndex = 22;
            lblLastNameError.Text = "lblLastNameError";
            lblLastNameError.Visible = false;
            // 
            // lblFirstNameError
            // 
            lblFirstNameError.AutoSize = true;
            lblFirstNameError.ForeColor = Color.Red;
            lblFirstNameError.Location = new Point(333, 84);
            lblFirstNameError.Name = "lblFirstNameError";
            lblFirstNameError.Size = new Size(99, 15);
            lblFirstNameError.TabIndex = 23;
            lblFirstNameError.Text = "lblFirstNameError";
            lblFirstNameError.Visible = false;
            // 
            // lblCNPError
            // 
            lblCNPError.AutoSize = true;
            lblCNPError.ForeColor = Color.Red;
            lblCNPError.Location = new Point(333, 134);
            lblCNPError.Name = "lblCNPError";
            lblCNPError.Size = new Size(69, 15);
            lblCNPError.TabIndex = 24;
            lblCNPError.Text = "lblCNPError";
            lblCNPError.Visible = false;
            // 
            // lblPriceError
            // 
            lblPriceError.AutoSize = true;
            lblPriceError.ForeColor = Color.Red;
            lblPriceError.Location = new Point(333, 248);
            lblPriceError.Name = "lblPriceError";
            lblPriceError.Size = new Size(71, 15);
            lblPriceError.TabIndex = 25;
            lblPriceError.Text = "lblPriceError";
            lblPriceError.Visible = false;
            // 
            // lblDurationError
            // 
            lblDurationError.AutoSize = true;
            lblDurationError.ForeColor = Color.Red;
            lblDurationError.Location = new Point(333, 294);
            lblDurationError.Name = "lblDurationError";
            lblDurationError.Size = new Size(91, 15);
            lblDurationError.TabIndex = 26;
            lblDurationError.Text = "lblDurationError";
            lblDurationError.Visible = false;
            // 
            // lblContactError
            // 
            lblContactError.AutoSize = true;
            lblContactError.ForeColor = Color.Red;
            lblContactError.Location = new Point(333, 340);
            lblContactError.Name = "lblContactError";
            lblContactError.Size = new Size(87, 15);
            lblContactError.TabIndex = 27;
            lblContactError.Text = "lblContactError";
            lblContactError.Visible = false;
            // 
            // Form1
            // 
            ClientSize = new Size(616, 600);
            Controls.Add(lblContactError);
            Controls.Add(lblDurationError);
            Controls.Add(lblPriceError);
            Controls.Add(lblCNPError);
            Controls.Add(lblFirstNameError);
            Controls.Add(lblLastNameError);
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
        private ContextMenuStrip contextMenuStrip1;


        private void ShowError(Label label, string message)
        {
            label.Visible = !string.IsNullOrEmpty(message);

            label.Text = message;
        }
        private Label lblLastNameError;
        private Label lblFirstNameError;
        private Label lblCNPError;
        private Label lblPriceError;
        private Label lblDurationError;
        private Label lblContactError;
    }
}
