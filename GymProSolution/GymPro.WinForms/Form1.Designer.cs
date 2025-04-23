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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            panel1 = new Panel();
            CoachInfo = new Button();
            Search = new Button();
            AddClients = new Button();
            HomePanel = new Panel();
            SearchPanel = new Panel();
            CoachPanel = new Panel();
            pictureBox1 = new PictureBox();
            CoachInfoPanel = new Label();
            SearchPanelLabel = new Label();
            HomePanellabel = new Label();
            panel1.SuspendLayout();
            HomePanel.SuspendLayout();
            SearchPanel.SuspendLayout();
            CoachPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(320, 91);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(200, 23);
            txtLastName.TabIndex = 0;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(320, 137);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(200, 23);
            txtFirstName.TabIndex = 1;
            // 
            // txtCNP
            // 
            txtCNP.Location = new Point(320, 187);
            txtCNP.Name = "txtCNP";
            txtCNP.Size = new Size(200, 23);
            txtCNP.TabIndex = 2;
            // 
            // txtOptions
            // 
            txtOptions.Location = new Point(320, 272);
            txtOptions.Name = "txtOptions";
            txtOptions.Size = new Size(200, 23);
            txtOptions.TabIndex = 4;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(320, 301);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(200, 23);
            txtPrice.TabIndex = 5;
            // 
            // txtDuration
            // 
            txtDuration.Location = new Point(320, 346);
            txtDuration.Name = "txtDuration";
            txtDuration.Size = new Size(200, 23);
            txtDuration.TabIndex = 6;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(320, 391);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(200, 23);
            txtContact.TabIndex = 7;
            // 
            // cmbSubscriptionType
            // 
            cmbSubscriptionType.Location = new Point(320, 235);
            cmbSubscriptionType.Name = "cmbSubscriptionType";
            cmbSubscriptionType.Size = new Size(200, 23);
            cmbSubscriptionType.TabIndex = 3;
            cmbSubscriptionType.SelectedIndexChanged += cmbSubscriptionType_SelectedIndexChanged;
            // 
            // cmbPersonalCoach
            // 
            cmbPersonalCoach.Location = new Point(320, 437);
            cmbPersonalCoach.Name = "cmbPersonalCoach";
            cmbPersonalCoach.Size = new Size(200, 23);
            cmbPersonalCoach.TabIndex = 8;
            // 
            // btnAddClient
            // 
            btnAddClient.BackColor = Color.Transparent;
            btnAddClient.FlatStyle = FlatStyle.Popup;
            btnAddClient.Location = new Point(216, 495);
            btnAddClient.Name = "btnAddClient";
            btnAddClient.Size = new Size(100, 30);
            btnAddClient.TabIndex = 10;
            btnAddClient.Text = "Add Client";
            btnAddClient.UseVisualStyleBackColor = false;
            btnAddClient.Click += btnAddClient_Click;
            // 
            // btnLoadClients
            // 
            btnLoadClients.BackColor = Color.Transparent;
            btnLoadClients.FlatStyle = FlatStyle.Flat;
            btnLoadClients.Location = new Point(447, 495);
            btnLoadClients.Name = "btnLoadClients";
            btnLoadClients.Size = new Size(100, 30);
            btnLoadClients.TabIndex = 11;
            btnLoadClients.Text = "Load Clients";
            btnLoadClients.UseVisualStyleBackColor = false;
            btnLoadClients.Click += btnLoadClients_Click;
            // 
            // lstClients
            // 
            lstClients.BackColor = SystemColors.Control;
            lstClients.ForeColor = Color.Black;
            lstClients.HorizontalScrollbar = true;
            lstClients.ItemHeight = 15;
            lstClients.Location = new Point(195, 543);
            lstClients.Name = "lstClients";
            lstClients.Size = new Size(380, 124);
            lstClients.TabIndex = 12;
            // 
            // lblLastName
            // 
            lblLastName.BackColor = Color.Transparent;
            lblLastName.ForeColor = Color.WhiteSmoke;
            lblLastName.Location = new Point(216, 94);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(100, 23);
            lblLastName.TabIndex = 13;
            lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            lblFirstName.BackColor = Color.Transparent;
            lblFirstName.ForeColor = Color.WhiteSmoke;
            lblFirstName.Location = new Point(216, 140);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(100, 23);
            lblFirstName.TabIndex = 14;
            lblFirstName.Text = "First Name";
            // 
            // lblCNP
            // 
            lblCNP.BackColor = Color.Transparent;
            lblCNP.ForeColor = Color.WhiteSmoke;
            lblCNP.Location = new Point(216, 187);
            lblCNP.Name = "lblCNP";
            lblCNP.Size = new Size(100, 23);
            lblCNP.TabIndex = 15;
            lblCNP.Text = "CNP";
            // 
            // lblSubscription
            // 
            lblSubscription.BackColor = Color.Transparent;
            lblSubscription.ForeColor = Color.WhiteSmoke;
            lblSubscription.Location = new Point(216, 238);
            lblSubscription.Name = "lblSubscription";
            lblSubscription.Size = new Size(100, 23);
            lblSubscription.TabIndex = 16;
            lblSubscription.Text = "Subscription Type";
            // 
            // lblOptions
            // 
            lblOptions.BackColor = Color.Transparent;
            lblOptions.ForeColor = Color.WhiteSmoke;
            lblOptions.Location = new Point(216, 272);
            lblOptions.Name = "lblOptions";
            lblOptions.Size = new Size(100, 23);
            lblOptions.TabIndex = 17;
            lblOptions.Text = "Options";
            // 
            // lblPrice
            // 
            lblPrice.BackColor = Color.Transparent;
            lblPrice.ForeColor = Color.WhiteSmoke;
            lblPrice.Location = new Point(216, 301);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(100, 23);
            lblPrice.TabIndex = 18;
            lblPrice.Text = "Price";
            // 
            // lblDuration
            // 
            lblDuration.BackColor = Color.Transparent;
            lblDuration.ForeColor = Color.WhiteSmoke;
            lblDuration.Location = new Point(216, 349);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(100, 23);
            lblDuration.TabIndex = 19;
            lblDuration.Text = "Duration";
            // 
            // lblContact
            // 
            lblContact.BackColor = Color.Transparent;
            lblContact.ForeColor = Color.WhiteSmoke;
            lblContact.Location = new Point(216, 391);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(100, 23);
            lblContact.TabIndex = 20;
            lblContact.Text = "Contact";
            // 
            // lblCoach
            // 
            lblCoach.BackColor = Color.Transparent;
            lblCoach.ForeColor = Color.WhiteSmoke;
            lblCoach.Location = new Point(216, 437);
            lblCoach.Name = "lblCoach";
            lblCoach.Size = new Size(100, 23);
            lblCoach.TabIndex = 21;
            lblCoach.Text = "Personal Coach";
            // 
            // dtpExpirationDate
            // 
            dtpExpirationDate.CalendarMonthBackground = Color.Transparent;
            dtpExpirationDate.CalendarTitleBackColor = Color.Transparent;
            dtpExpirationDate.CalendarTrailingForeColor = Color.Transparent;
            dtpExpirationDate.Location = new Point(320, 466);
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
            lblLastNameError.BackColor = Color.Transparent;
            lblLastNameError.ForeColor = Color.Red;
            lblLastNameError.Location = new Point(333, 119);
            lblLastNameError.Name = "lblLastNameError";
            lblLastNameError.Size = new Size(98, 15);
            lblLastNameError.TabIndex = 22;
            lblLastNameError.Text = "lblLastNameError";
            lblLastNameError.Visible = false;
            // 
            // lblFirstNameError
            // 
            lblFirstNameError.AutoSize = true;
            lblFirstNameError.BackColor = Color.Transparent;
            lblFirstNameError.ForeColor = Color.Red;
            lblFirstNameError.Location = new Point(333, 163);
            lblFirstNameError.Name = "lblFirstNameError";
            lblFirstNameError.Size = new Size(99, 15);
            lblFirstNameError.TabIndex = 23;
            lblFirstNameError.Text = "lblFirstNameError";
            lblFirstNameError.Visible = false;
            // 
            // lblCNPError
            // 
            lblCNPError.AutoSize = true;
            lblCNPError.BackColor = Color.Transparent;
            lblCNPError.ForeColor = Color.Red;
            lblCNPError.Location = new Point(333, 213);
            lblCNPError.Name = "lblCNPError";
            lblCNPError.Size = new Size(69, 15);
            lblCNPError.TabIndex = 24;
            lblCNPError.Text = "lblCNPError";
            lblCNPError.Visible = false;
            // 
            // lblPriceError
            // 
            lblPriceError.AutoSize = true;
            lblPriceError.BackColor = Color.Transparent;
            lblPriceError.ForeColor = Color.Red;
            lblPriceError.Location = new Point(333, 327);
            lblPriceError.Name = "lblPriceError";
            lblPriceError.Size = new Size(71, 15);
            lblPriceError.TabIndex = 25;
            lblPriceError.Text = "lblPriceError";
            lblPriceError.Visible = false;
            // 
            // lblDurationError
            // 
            lblDurationError.AutoSize = true;
            lblDurationError.BackColor = Color.Transparent;
            lblDurationError.ForeColor = Color.Red;
            lblDurationError.Location = new Point(333, 373);
            lblDurationError.Name = "lblDurationError";
            lblDurationError.Size = new Size(91, 15);
            lblDurationError.TabIndex = 26;
            lblDurationError.Text = "lblDurationError";
            lblDurationError.Visible = false;
            // 
            // lblContactError
            // 
            lblContactError.AutoSize = true;
            lblContactError.BackColor = Color.Transparent;
            lblContactError.ForeColor = Color.Red;
            lblContactError.Location = new Point(333, 419);
            lblContactError.Name = "lblContactError";
            lblContactError.Size = new Size(87, 15);
            lblContactError.TabIndex = 27;
            lblContactError.Text = "lblContactError";
            lblContactError.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(CoachInfo);
            panel1.Controls.Add(Search);
            panel1.Controls.Add(AddClients);
            panel1.Location = new Point(12, 91);
            panel1.Name = "panel1";
            panel1.Size = new Size(177, 576);
            panel1.TabIndex = 28;
            // 
            // CoachInfo
            // 
            CoachInfo.FlatStyle = FlatStyle.Popup;
            CoachInfo.Location = new Point(20, 163);
            CoachInfo.Name = "CoachInfo";
            CoachInfo.Size = new Size(75, 23);
            CoachInfo.TabIndex = 2;
            CoachInfo.Text = "CoachInfo";
            CoachInfo.UseVisualStyleBackColor = true;
            CoachInfo.Click += CoachInfo_Click;
            // 
            // Search
            // 
            Search.FlatStyle = FlatStyle.Popup;
            Search.Location = new Point(20, 93);
            Search.Name = "Search";
            Search.Size = new Size(75, 23);
            Search.TabIndex = 1;
            Search.Text = "Search";
            Search.UseVisualStyleBackColor = true;
            Search.Click += Search_Click;
            // 
            // AddClients
            // 
            AddClients.FlatStyle = FlatStyle.Popup;
            AddClients.Location = new Point(20, 25);
            AddClients.Name = "AddClients";
            AddClients.Size = new Size(75, 23);
            AddClients.TabIndex = 0;
            AddClients.Text = "AddClients\r\n";
            AddClients.UseVisualStyleBackColor = true;
            AddClients.Click += AddClients_Click;
            // 
            // HomePanel
            // 
            HomePanel.BackColor = SystemColors.ActiveCaptionText;
            HomePanel.Controls.Add(SearchPanel);
            HomePanel.Location = new Point(186, 91);
            HomePanel.Name = "HomePanel";
            HomePanel.Size = new Size(389, 576);
            HomePanel.TabIndex = 30;
            // 
            // SearchPanel
            // 
            SearchPanel.BackColor = Color.LightGray;
            SearchPanel.Controls.Add(CoachPanel);
            SearchPanel.Location = new Point(0, 0);
            SearchPanel.Name = "SearchPanel";
            SearchPanel.Size = new Size(389, 576);
            SearchPanel.TabIndex = 0;
            SearchPanel.Visible = false;
            // 
            // CoachPanel
            // 
            CoachPanel.BackColor = Color.OrangeRed;
            CoachPanel.Controls.Add(HomePanellabel);
            CoachPanel.Controls.Add(SearchPanelLabel);
            CoachPanel.Controls.Add(CoachInfoPanel);
            CoachPanel.Location = new Point(0, 0);
            CoachPanel.Name = "CoachPanel";
            CoachPanel.Size = new Size(389, 576);
            CoachPanel.TabIndex = 0;
            CoachPanel.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(573, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // CoachInfoPanel
            // 
            CoachInfoPanel.AutoSize = true;
            CoachInfoPanel.Location = new Point(171, 224);
            CoachInfoPanel.Name = "CoachInfoPanel";
            CoachInfoPanel.Size = new Size(91, 15);
            CoachInfoPanel.TabIndex = 0;
            CoachInfoPanel.Text = "CoachInfoPanel";
            // 
            // SearchPanelLabel
            // 
            SearchPanelLabel.AutoSize = true;
            SearchPanelLabel.Location = new Point(140, 176);
            SearchPanelLabel.Name = "SearchPanelLabel";
            SearchPanelLabel.Size = new Size(99, 15);
            SearchPanelLabel.TabIndex = 1;
            SearchPanelLabel.Text = "SearchPanelLabel";
            // 
            // HomePanellabel
            // 
            HomePanellabel.AutoSize = true;
            HomePanellabel.Location = new Point(143, 322);
            HomePanellabel.Name = "HomePanellabel";
            HomePanellabel.Size = new Size(94, 15);
            HomePanellabel.TabIndex = 2;
            HomePanellabel.Text = "HomePanellabel";
            // 
            // Form1
            // 
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(573, 636);
            Controls.Add(HomePanel);
            Controls.Add(panel1);
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
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "GymPro Client Management";
            panel1.ResumeLayout(false);
            HomePanel.ResumeLayout(false);
            SearchPanel.ResumeLayout(false);
            CoachPanel.ResumeLayout(false);
            CoachPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button CoachInfo;
        private Button Search;
        private Button AddClients;
        private Panel HomePanel;
        private Panel SearchPanel;
        private Panel CoachPanel;
        private Label HomePanellabel;
        private Label SearchPanelLabel;
        private Label CoachInfoPanel;
    }
}
