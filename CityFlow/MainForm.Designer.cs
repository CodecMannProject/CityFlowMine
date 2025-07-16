namespace CityFlow
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.dashboardTabPage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mileageTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.completeShiftButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.onRouteDriversComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.assignToRouteButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.availableBusesComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.availableDriversComboBox = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.driversOnRouteLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.busesOnRouteLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.busesTabPage = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sendToRepairButton = new System.Windows.Forms.Button();
            this.editBusButton = new System.Windows.Forms.Button();
            this.addBusButton = new System.Windows.Forms.Button();
            this.busesDataGridView = new System.Windows.Forms.DataGridView();
            this.colLicensePlate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGarageNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatusBus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMileage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driversTabPage = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fireDriverButton = new System.Windows.Forms.Button();
            this.editDriverButton = new System.Windows.Forms.Button();
            this.addDriverButton = new System.Windows.Forms.Button();
            this.driversDataGridView = new System.Windows.Forms.DataGridView();
            this.colEmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatusDriver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routesTabPage = new System.Windows.Forms.TabPage();
            this.routesDataGridView = new System.Windows.Forms.DataGridView();
            this.colRouteNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRouteName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRouteVehicleType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.monitorRouteButton = new System.Windows.Forms.Button();
            this.mainTabControl.SuspendLayout();
            this.dashboardTabPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.busesTabPage.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.busesDataGridView)).BeginInit();
            this.driversTabPage.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driversDataGridView)).BeginInit();
            this.routesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.routesDataGridView)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.dashboardTabPage);
            this.mainTabControl.Controls.Add(this.busesTabPage);
            this.mainTabControl.Controls.Add(this.driversTabPage);
            this.mainTabControl.Controls.Add(this.routesTabPage);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(984, 561);
            this.mainTabControl.TabIndex = 0;
            // 
            // dashboardTabPage
            // 
            this.dashboardTabPage.Controls.Add(this.groupBox2);
            this.dashboardTabPage.Controls.Add(this.groupBox1);
            this.dashboardTabPage.Controls.Add(this.statusStrip1);
            this.dashboardTabPage.Location = new System.Drawing.Point(4, 24);
            this.dashboardTabPage.Name = "dashboardTabPage";
            this.dashboardTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.dashboardTabPage.Size = new System.Drawing.Size(976, 533);
            this.dashboardTabPage.TabIndex = 0;
            this.dashboardTabPage.Text = "Оперативна панель";
            this.dashboardTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mileageTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.completeShiftButton);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.onRouteDriversComboBox);
            this.groupBox2.Location = new System.Drawing.Point(8, 203);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 180);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Завершення зміни";
            // 
            // mileageTextBox
            // 
            this.mileageTextBox.Location = new System.Drawing.Point(10, 97);
            this.mileageTextBox.Name = "mileageTextBox";
            this.mileageTextBox.Size = new System.Drawing.Size(430, 23);
            this.mileageTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Кінцевий пробіг:";
            // 
            // completeShiftButton
            // 
            this.completeShiftButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.completeShiftButton.Location = new System.Drawing.Point(10, 126);
            this.completeShiftButton.Name = "completeShiftButton";
            this.completeShiftButton.Size = new System.Drawing.Size(430, 40);
            this.completeShiftButton.TabIndex = 2;
            this.completeShiftButton.Text = "Прийняти зміну";
            this.completeShiftButton.UseVisualStyleBackColor = true;
            this.completeShiftButton.Click += new System.EventHandler(this.completeShiftButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Водій на зміні:";
            // 
            // onRouteDriversComboBox
            // 
            this.onRouteDriversComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.onRouteDriversComboBox.FormattingEnabled = true;
            this.onRouteDriversComboBox.Location = new System.Drawing.Point(10, 46);
            this.onRouteDriversComboBox.Name = "onRouteDriversComboBox";
            this.onRouteDriversComboBox.Size = new System.Drawing.Size(430, 23);
            this.onRouteDriversComboBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.assignToRouteButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.availableBusesComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.availableDriversComboBox);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 191);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Призначення на маршрут";
            // 
            // assignToRouteButton
            // 
            this.assignToRouteButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.assignToRouteButton.Location = new System.Drawing.Point(10, 137);
            this.assignToRouteButton.Name = "assignToRouteButton";
            this.assignToRouteButton.Size = new System.Drawing.Size(430, 40);
            this.assignToRouteButton.TabIndex = 4;
            this.assignToRouteButton.Text = "Відправити на маршрут";
            this.assignToRouteButton.UseVisualStyleBackColor = true;
            this.assignToRouteButton.Click += new System.EventHandler(this.assignToRouteButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Справний автобус:";
            // 
            // availableBusesComboBox
            // 
            this.availableBusesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.availableBusesComboBox.FormattingEnabled = true;
            this.availableBusesComboBox.Location = new System.Drawing.Point(10, 100);
            this.availableBusesComboBox.Name = "availableBusesComboBox";
            this.availableBusesComboBox.Size = new System.Drawing.Size(430, 23);
            this.availableBusesComboBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Вільний водій:";
            // 
            // availableDriversComboBox
            // 
            this.availableDriversComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.availableDriversComboBox.FormattingEnabled = true;
            this.availableDriversComboBox.Location = new System.Drawing.Point(10, 46);
            this.availableDriversComboBox.Name = "availableDriversComboBox";
            this.availableDriversComboBox.Size = new System.Drawing.Size(430, 23);
            this.availableDriversComboBox.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.driversOnRouteLabel,
            this.busesOnRouteLabel});
            this.statusStrip1.Location = new System.Drawing.Point(3, 508);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(970, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // driversOnRouteLabel
            // 
            this.driversOnRouteLabel.Name = "driversOnRouteLabel";
            this.driversOnRouteLabel.Size = new System.Drawing.Size(113, 17);
            this.driversOnRouteLabel.Text = "Водіїв на лінії: 0";
            // 
            // busesOnRouteLabel
            // 
            this.busesOnRouteLabel.Name = "busesOnRouteLabel";
            this.busesOnRouteLabel.Size = new System.Drawing.Size(130, 17);
            this.busesOnRouteLabel.Text = "Транспорту на лінії: 0";
            // 
            // busesTabPage
            // 
            this.busesTabPage.Controls.Add(this.busesDataGridView);
            this.busesTabPage.Controls.Add(this.panel1);
            this.busesTabPage.Location = new System.Drawing.Point(4, 24);
            this.busesTabPage.Name = "busesTabPage";
            this.busesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.busesTabPage.Size = new System.Drawing.Size(976, 533);
            this.busesTabPage.TabIndex = 1;
            this.busesTabPage.Text = "Транспорт";
            this.busesTabPage.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sendToRepairButton);
            this.panel1.Controls.Add(this.editBusButton);
            this.panel1.Controls.Add(this.addBusButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 480);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 50);
            this.panel1.TabIndex = 1;
            // 
            // sendToRepairButton
            // 
            this.sendToRepairButton.Location = new System.Drawing.Point(215, 10);
            this.sendToRepairButton.Name = "sendToRepairButton";
            this.sendToRepairButton.Size = new System.Drawing.Size(150, 30);
            this.sendToRepairButton.TabIndex = 2;
            this.sendToRepairButton.Text = "Відправити в ремонт...";
            this.sendToRepairButton.UseVisualStyleBackColor = true;
            // 
            // editBusButton
            // 
            this.editBusButton.Location = new System.Drawing.Point(110, 10);
            this.editBusButton.Name = "editBusButton";
            this.editBusButton.Size = new System.Drawing.Size(100, 30);
            this.editBusButton.TabIndex = 1;
            this.editBusButton.Text = "Редагувати...";
            this.editBusButton.UseVisualStyleBackColor = true;
            // 
            // addBusButton
            // 
            this.addBusButton.Location = new System.Drawing.Point(5, 10);
            this.addBusButton.Name = "addBusButton";
            this.addBusButton.Size = new System.Drawing.Size(100, 30);
            this.addBusButton.TabIndex = 0;
            this.addBusButton.Text = "Додати...";
            this.addBusButton.UseVisualStyleBackColor = true;
            this.addBusButton.Click += new System.EventHandler(this.addBusButton_Click);
            // 
            // busesDataGridView
            // 
            this.busesDataGridView.AllowUserToAddRows = false;
            this.busesDataGridView.AllowUserToDeleteRows = false;
            this.busesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.busesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.busesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLicensePlate,
            this.colGarageNumber,
            this.colModel,
            this.colYear,
            this.colStatusBus,
            this.colMileage});
            this.busesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.busesDataGridView.Location = new System.Drawing.Point(3, 3);
            this.busesDataGridView.Name = "busesDataGridView";
            this.busesDataGridView.ReadOnly = true;
            this.busesDataGridView.RowTemplate.Height = 25;
            this.busesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.busesDataGridView.Size = new System.Drawing.Size(970, 477);
            this.busesDataGridView.TabIndex = 0;
            // 
            // colLicensePlate
            // 
            this.colLicensePlate.DataPropertyName = "LicensePlate";
            this.colLicensePlate.HeaderText = "Держ. номер";
            this.colLicensePlate.Name = "colLicensePlate";
            this.colLicensePlate.ReadOnly = true;
            // 
            // colGarageNumber
            // 
            this.colGarageNumber.DataPropertyName = "GarageNumber";
            this.colGarageNumber.HeaderText = "Гаражний №";
            this.colGarageNumber.Name = "colGarageNumber";
            this.colGarageNumber.ReadOnly = true;
            // 
            // colModel
            // 
            this.colModel.DataPropertyName = "Model";
            this.colModel.HeaderText = "Модель";
            this.colModel.Name = "colModel";
            this.colModel.ReadOnly = true;
            // 
            // colYear
            // 
            this.colYear.DataPropertyName = "Year";
            this.colYear.HeaderText = "Рік";
            this.colYear.Name = "colYear";
            this.colYear.ReadOnly = true;
            // 
            // colStatusBus
            // 
            this.colStatusBus.DataPropertyName = "Status";
            this.colStatusBus.HeaderText = "Статус";
            this.colStatusBus.Name = "colStatusBus";
            this.colStatusBus.ReadOnly = true;
            // 
            // colMileage
            // 
            this.colMileage.DataPropertyName = "Mileage";
            this.colMileage.HeaderText = "Пробіг";
            this.colMileage.Name = "colMileage";
            this.colMileage.ReadOnly = true;
            // 
            // driversTabPage
            // 
            this.driversTabPage.Controls.Add(this.driversDataGridView);
            this.driversTabPage.Controls.Add(this.panel2);
            this.driversTabPage.Location = new System.Drawing.Point(4, 24);
            this.driversTabPage.Name = "driversTabPage";
            this.driversTabPage.Size = new System.Drawing.Size(976, 533);
            this.driversTabPage.TabIndex = 2;
            this.driversTabPage.Text = "Водії";
            this.driversTabPage.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.fireDriverButton);
            this.panel2.Controls.Add(this.editDriverButton);
            this.panel2.Controls.Add(this.addDriverButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 483);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(976, 50);
            this.panel2.TabIndex = 1;
            // 
            // fireDriverButton
            // 
            this.fireDriverButton.Location = new System.Drawing.Point(213, 10);
            this.fireDriverButton.Name = "fireDriverButton";
            this.fireDriverButton.Size = new System.Drawing.Size(100, 30);
            this.fireDriverButton.TabIndex = 2;
            this.fireDriverButton.Text = "Звільнити";
            this.fireDriverButton.UseVisualStyleBackColor = true;
            // 
            // editDriverButton
            // 
            this.editDriverButton.Location = new System.Drawing.Point(108, 10);
            this.editDriverButton.Name = "editDriverButton";
            this.editDriverButton.Size = new System.Drawing.Size(100, 30);
            this.editDriverButton.TabIndex = 1;
            this.editDriverButton.Text = "Редагувати...";
            this.editDriverButton.UseVisualStyleBackColor = true;
            // 
            // addDriverButton
            // 
            this.addDriverButton.Location = new System.Drawing.Point(3, 10);
            this.addDriverButton.Name = "addDriverButton";
            this.addDriverButton.Size = new System.Drawing.Size(100, 30);
            this.addDriverButton.TabIndex = 0;
            this.addDriverButton.Text = "Найняти...";
            this.addDriverButton.UseVisualStyleBackColor = true;
            // 
            // driversDataGridView
            // 
            this.driversDataGridView.AllowUserToAddRows = false;
            this.driversDataGridView.AllowUserToDeleteRows = false;
            this.driversDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.driversDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.driversDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEmployeeId,
            this.colFullName,
            this.colAge,
            this.colStatusDriver});
            this.driversDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.driversDataGridView.Location = new System.Drawing.Point(0, 0);
            this.driversDataGridView.Name = "driversDataGridView";
            this.driversDataGridView.ReadOnly = true;
            this.driversDataGridView.RowTemplate.Height = 25;
            this.driversDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.driversDataGridView.Size = new System.Drawing.Size(976, 483);
            this.driversDataGridView.TabIndex = 0;
            // 
            // colEmployeeId
            // 
            this.colEmployeeId.DataPropertyName = "EmployeeId";
            this.colEmployeeId.HeaderText = "Табельний №";
            this.colEmployeeId.Name = "colEmployeeId";
            this.colEmployeeId.ReadOnly = true;
            // 
            // colFullName
            // 
            this.colFullName.DataPropertyName = "FullName";
            this.colFullName.HeaderText = "ПІБ";
            this.colFullName.Name = "colFullName";
            this.colFullName.ReadOnly = true;
            // 
            // colAge
            // 
            this.colAge.DataPropertyName = "Age";
            this.colAge.HeaderText = "Вік";
            this.colAge.Name = "colAge";
            this.colAge.ReadOnly = true;
            // 
            // colStatusDriver
            // 
            this.colStatusDriver.DataPropertyName = "Status";
            this.colStatusDriver.HeaderText = "Статус";
            this.colStatusDriver.Name = "colStatusDriver";
            this.colStatusDriver.ReadOnly = true;
            // 
            // routesTabPage
            // 
            this.routesTabPage.Controls.Add(this.routesDataGridView);
            this.routesTabPage.Controls.Add(this.panel3);
            this.routesTabPage.Location = new System.Drawing.Point(4, 24);
            this.routesTabPage.Name = "routesTabPage";
            this.routesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.routesTabPage.Size = new System.Drawing.Size(976, 533);
            this.routesTabPage.TabIndex = 3;
            this.routesTabPage.Text = "Маршрути";
            this.routesTabPage.UseVisualStyleBackColor = true;
            // 
            // routesDataGridView
            // 
            this.routesDataGridView.AllowUserToAddRows = false;
            this.routesDataGridView.AllowUserToDeleteRows = false;
            this.routesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.routesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.routesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRouteNumber,
            this.colRouteName,
            this.colRouteVehicleType});
            this.routesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.routesDataGridView.Location = new System.Drawing.Point(3, 3);
            this.routesDataGridView.Name = "routesDataGridView";
            this.routesDataGridView.ReadOnly = true;
            this.routesDataGridView.RowTemplate.Height = 25;
            this.routesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.routesDataGridView.Size = new System.Drawing.Size(970, 477);
            this.routesDataGridView.TabIndex = 1;
            // 
            // colRouteNumber
            // 
            this.colRouteNumber.DataPropertyName = "RouteNumber";
            this.colRouteNumber.HeaderText = "Номер";
            this.colRouteNumber.Name = "colRouteNumber";
            this.colRouteNumber.ReadOnly = true;
            // 
            // colRouteName
            // 
            this.colRouteName.DataPropertyName = "Name";
            this.colRouteName.HeaderText = "Назва маршруту";
            this.colRouteName.Name = "colRouteName";
            this.colRouteName.ReadOnly = true;
            // 
            // colRouteVehicleType
            // 
            this.colRouteVehicleType.DataPropertyName = "VehicleType";
            this.colRouteVehicleType.HeaderText = "Тип транспорту";
            this.colRouteVehicleType.Name = "colRouteVehicleType";
            this.colRouteVehicleType.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.monitorRouteButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 480);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(970, 50);
            this.panel3.TabIndex = 2;
            // 
            // monitorRouteButton
            // 
            this.monitorRouteButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.monitorRouteButton.Location = new System.Drawing.Point(5, 5);
            this.monitorRouteButton.Name = "monitorRouteButton";
            this.monitorRouteButton.Size = new System.Drawing.Size(200, 40);
            this.monitorRouteButton.TabIndex = 0;
            this.monitorRouteButton.Text = "Моніторинг маршруту";
            this.monitorRouteButton.UseVisualStyleBackColor = true;
            this.monitorRouteButton.Click += new System.EventHandler(this.monitorRouteButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.mainTabControl);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "MainForm";
            this.Text = "CityFlow Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainTabControl.ResumeLayout(false);
            this.dashboardTabPage.ResumeLayout(false);
            this.dashboardTabPage.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.busesTabPage.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.busesDataGridView)).EndInit();
            this.driversTabPage.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.driversDataGridView)).EndInit();
            this.routesTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.routesDataGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage dashboardTabPage;
        private System.Windows.Forms.TabPage busesTabPage;
        private System.Windows.Forms.TabPage driversTabPage;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel driversOnRouteLabel;
        private System.Windows.Forms.ToolStripStatusLabel busesOnRouteLabel;
        private System.Windows.Forms.DataGridView busesDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button sendToRepairButton;
        private System.Windows.Forms.Button editBusButton;
        private System.Windows.Forms.Button addBusButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLicensePlate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGarageNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatusBus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMileage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button fireDriverButton;
        private System.Windows.Forms.Button editDriverButton;
        private System.Windows.Forms.Button addDriverButton;
        private System.Windows.Forms.DataGridView driversDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatusDriver;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox availableDriversComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox availableBusesComboBox;
        private System.Windows.Forms.Button assignToRouteButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox onRouteDriversComboBox;
        private System.Windows.Forms.Button completeShiftButton;
        private System.Windows.Forms.TextBox mileageTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage routesTabPage;
        private System.Windows.Forms.DataGridView routesDataGridView;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button monitorRouteButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRouteNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRouteName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRouteVehicleType;
    }
}
