namespace Weather_Forecaster
{
    partial class frmForecaster
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtmStartDateView = new System.Windows.Forms.DateTimePicker();
            this.dtmEndDateView = new System.Windows.Forms.DateTimePicker();
            this.lblHeader = new System.Windows.Forms.Label();
            this.dtmDateNew = new System.Windows.Forms.DateTimePicker();
            this.lblCityNew = new System.Windows.Forms.Label();
            this.lblDateNew = new System.Windows.Forms.Label();
            this.lblHumidityNew = new System.Windows.Forms.Label();
            this.lblPrecipitationNew = new System.Windows.Forms.Label();
            this.lblMaxTempNew = new System.Windows.Forms.Label();
            this.lblMinTempNew = new System.Windows.Forms.Label();
            this.txtCityNew = new System.Windows.Forms.TextBox();
            this.lblWindSpeedNew = new System.Windows.Forms.Label();
            this.txtMinTempNew = new System.Windows.Forms.TextBox();
            this.txtMaxTempNew = new System.Windows.Forms.TextBox();
            this.txtPrecipitationNew = new System.Windows.Forms.TextBox();
            this.txtHumidityNew = new System.Windows.Forms.TextBox();
            this.txtWindSpeedNew = new System.Windows.Forms.TextBox();
            this.btnSubmitNew = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addForecastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addForecast = new System.Windows.Forms.ToolStripMenuItem();
            this.viewForecasts = new System.Windows.Forms.ToolStripMenuItem();
            this.updateForecast = new System.Windows.Forms.ToolStripMenuItem();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtmDateUpdate = new System.Windows.Forms.DateTimePicker();
            this.txtCityUpdate = new System.Windows.Forms.TextBox();
            this.lblDateUpdate = new System.Windows.Forms.Label();
            this.lblCityUpdate = new System.Windows.Forms.Label();
            this.lblNew = new System.Windows.Forms.Label();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.lblView = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnPopulate = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.lblCityView = new System.Windows.Forms.Label();
            this.txtCityView = new System.Windows.Forms.TextBox();
            this.btnAddCity = new System.Windows.Forms.Button();
            this.pctNew2 = new System.Windows.Forms.PictureBox();
            this.pctNew = new System.Windows.Forms.PictureBox();
            this.pctUpdateView = new System.Windows.Forms.PictureBox();
            this.pctUpdateView2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctNew2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctUpdateView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctUpdateView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dtmStartDateView
            // 
            this.dtmStartDateView.Location = new System.Drawing.Point(787, 276);
            this.dtmStartDateView.Name = "dtmStartDateView";
            this.dtmStartDateView.Size = new System.Drawing.Size(233, 20);
            this.dtmStartDateView.TabIndex = 0;
            this.dtmStartDateView.Visible = false;
            // 
            // dtmEndDateView
            // 
            this.dtmEndDateView.Location = new System.Drawing.Point(787, 328);
            this.dtmEndDateView.Name = "dtmEndDateView";
            this.dtmEndDateView.Size = new System.Drawing.Size(233, 20);
            this.dtmEndDateView.TabIndex = 1;
            this.dtmEndDateView.Visible = false;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Moon Flower Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(336, 33);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(377, 66);
            this.lblHeader.TabIndex = 3;
            this.lblHeader.Text = "Weather Forecaster";
            // 
            // dtmDateNew
            // 
            this.dtmDateNew.Location = new System.Drawing.Point(294, 342);
            this.dtmDateNew.Name = "dtmDateNew";
            this.dtmDateNew.Size = new System.Drawing.Size(178, 20);
            this.dtmDateNew.TabIndex = 5;
            this.dtmDateNew.Visible = false;
            // 
            // lblCityNew
            // 
            this.lblCityNew.AutoSize = true;
            this.lblCityNew.Font = new System.Drawing.Font("Moon Flower Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCityNew.Location = new System.Drawing.Point(59, 264);
            this.lblCityNew.Name = "lblCityNew";
            this.lblCityNew.Size = new System.Drawing.Size(69, 39);
            this.lblCityNew.TabIndex = 6;
            this.lblCityNew.Text = "City:";
            this.lblCityNew.Visible = false;
            // 
            // lblDateNew
            // 
            this.lblDateNew.AutoSize = true;
            this.lblDateNew.Font = new System.Drawing.Font("Moon Flower Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateNew.Location = new System.Drawing.Point(60, 328);
            this.lblDateNew.Name = "lblDateNew";
            this.lblDateNew.Size = new System.Drawing.Size(72, 39);
            this.lblDateNew.TabIndex = 7;
            this.lblDateNew.Text = "Date:";
            this.lblDateNew.Visible = false;
            // 
            // lblHumidityNew
            // 
            this.lblHumidityNew.AutoSize = true;
            this.lblHumidityNew.Font = new System.Drawing.Font("Moon Flower Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHumidityNew.Location = new System.Drawing.Point(59, 565);
            this.lblHumidityNew.Name = "lblHumidityNew";
            this.lblHumidityNew.Size = new System.Drawing.Size(114, 39);
            this.lblHumidityNew.TabIndex = 8;
            this.lblHumidityNew.Text = "Humidity:";
            this.lblHumidityNew.Visible = false;
            // 
            // lblPrecipitationNew
            // 
            this.lblPrecipitationNew.AutoSize = true;
            this.lblPrecipitationNew.Font = new System.Drawing.Font("Moon Flower Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecipitationNew.Location = new System.Drawing.Point(60, 510);
            this.lblPrecipitationNew.Name = "lblPrecipitationNew";
            this.lblPrecipitationNew.Size = new System.Drawing.Size(161, 39);
            this.lblPrecipitationNew.TabIndex = 9;
            this.lblPrecipitationNew.Text = "Precipitation:";
            this.lblPrecipitationNew.Visible = false;
            // 
            // lblMaxTempNew
            // 
            this.lblMaxTempNew.AutoSize = true;
            this.lblMaxTempNew.Font = new System.Drawing.Font("Moon Flower Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxTempNew.Location = new System.Drawing.Point(60, 446);
            this.lblMaxTempNew.Name = "lblMaxTempNew";
            this.lblMaxTempNew.Size = new System.Drawing.Size(200, 39);
            this.lblMaxTempNew.TabIndex = 10;
            this.lblMaxTempNew.Text = "Max Temperature:";
            this.lblMaxTempNew.Visible = false;
            // 
            // lblMinTempNew
            // 
            this.lblMinTempNew.AutoSize = true;
            this.lblMinTempNew.Font = new System.Drawing.Font("Moon Flower Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinTempNew.Location = new System.Drawing.Point(59, 383);
            this.lblMinTempNew.Name = "lblMinTempNew";
            this.lblMinTempNew.Size = new System.Drawing.Size(192, 39);
            this.lblMinTempNew.TabIndex = 11;
            this.lblMinTempNew.Text = "Min Temperature:";
            this.lblMinTempNew.Visible = false;
            // 
            // txtCityNew
            // 
            this.txtCityNew.Location = new System.Drawing.Point(292, 281);
            this.txtCityNew.Name = "txtCityNew";
            this.txtCityNew.Size = new System.Drawing.Size(178, 20);
            this.txtCityNew.TabIndex = 12;
            this.txtCityNew.Visible = false;
            // 
            // lblWindSpeedNew
            // 
            this.lblWindSpeedNew.AutoSize = true;
            this.lblWindSpeedNew.Font = new System.Drawing.Font("Moon Flower Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWindSpeedNew.Location = new System.Drawing.Point(59, 626);
            this.lblWindSpeedNew.Name = "lblWindSpeedNew";
            this.lblWindSpeedNew.Size = new System.Drawing.Size(133, 39);
            this.lblWindSpeedNew.TabIndex = 13;
            this.lblWindSpeedNew.Text = "Wind Speed:";
            this.lblWindSpeedNew.Visible = false;
            // 
            // txtMinTempNew
            // 
            this.txtMinTempNew.Location = new System.Drawing.Point(292, 400);
            this.txtMinTempNew.Name = "txtMinTempNew";
            this.txtMinTempNew.Size = new System.Drawing.Size(178, 20);
            this.txtMinTempNew.TabIndex = 14;
            this.txtMinTempNew.Visible = false;
            // 
            // txtMaxTempNew
            // 
            this.txtMaxTempNew.Location = new System.Drawing.Point(294, 467);
            this.txtMaxTempNew.Name = "txtMaxTempNew";
            this.txtMaxTempNew.Size = new System.Drawing.Size(178, 20);
            this.txtMaxTempNew.TabIndex = 15;
            this.txtMaxTempNew.Visible = false;
            // 
            // txtPrecipitationNew
            // 
            this.txtPrecipitationNew.Location = new System.Drawing.Point(294, 527);
            this.txtPrecipitationNew.Name = "txtPrecipitationNew";
            this.txtPrecipitationNew.Size = new System.Drawing.Size(178, 20);
            this.txtPrecipitationNew.TabIndex = 16;
            this.txtPrecipitationNew.Visible = false;
            // 
            // txtHumidityNew
            // 
            this.txtHumidityNew.Location = new System.Drawing.Point(294, 582);
            this.txtHumidityNew.Name = "txtHumidityNew";
            this.txtHumidityNew.Size = new System.Drawing.Size(178, 20);
            this.txtHumidityNew.TabIndex = 17;
            this.txtHumidityNew.Visible = false;
            // 
            // txtWindSpeedNew
            // 
            this.txtWindSpeedNew.Location = new System.Drawing.Point(294, 643);
            this.txtWindSpeedNew.Name = "txtWindSpeedNew";
            this.txtWindSpeedNew.Size = new System.Drawing.Size(178, 20);
            this.txtWindSpeedNew.TabIndex = 18;
            this.txtWindSpeedNew.Visible = false;
            // 
            // btnSubmitNew
            // 
            this.btnSubmitNew.Font = new System.Drawing.Font("Moon Flower Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitNew.Location = new System.Drawing.Point(66, 701);
            this.btnSubmitNew.Name = "btnSubmitNew";
            this.btnSubmitNew.Size = new System.Drawing.Size(404, 53);
            this.btnSubmitNew.TabIndex = 19;
            this.btnSubmitNew.Text = "Submit";
            this.btnSubmitNew.UseVisualStyleBackColor = true;
            this.btnSubmitNew.Visible = false;
            this.btnSubmitNew.Click += new System.EventHandler(this.btnSubmitNew_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addForecastToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1526, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addForecastToolStripMenuItem
            // 
            this.addForecastToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addForecast,
            this.viewForecasts,
            this.updateForecast});
            this.addForecastToolStripMenuItem.Name = "addForecastToolStripMenuItem";
            this.addForecastToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.addForecastToolStripMenuItem.Text = "Option selection";
            // 
            // addForecast
            // 
            this.addForecast.Name = "addForecast";
            this.addForecast.Size = new System.Drawing.Size(157, 22);
            this.addForecast.Text = "Add forecast";
            this.addForecast.Click += new System.EventHandler(this.addForecast_Click);
            // 
            // viewForecasts
            // 
            this.viewForecasts.Name = "viewForecasts";
            this.viewForecasts.Size = new System.Drawing.Size(157, 22);
            this.viewForecasts.Text = "View forecasts";
            this.viewForecasts.Click += new System.EventHandler(this.viewForecasts_Click);
            // 
            // updateForecast
            // 
            this.updateForecast.Name = "updateForecast";
            this.updateForecast.Size = new System.Drawing.Size(157, 22);
            this.updateForecast.Text = "Update forecast";
            this.updateForecast.Click += new System.EventHandler(this.updateForecast_Click);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Moon Flower Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(610, 262);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(127, 39);
            this.lblStartDate.TabIndex = 21;
            this.lblStartDate.Text = "Start date";
            this.lblStartDate.Visible = false;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Moon Flower Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(610, 314);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(104, 39);
            this.lblEndDate.TabIndex = 22;
            this.lblEndDate.Text = "end date";
            this.lblEndDate.Visible = false;
            // 
            // dtmDateUpdate
            // 
            this.dtmDateUpdate.Location = new System.Drawing.Point(787, 579);
            this.dtmDateUpdate.Name = "dtmDateUpdate";
            this.dtmDateUpdate.Size = new System.Drawing.Size(233, 20);
            this.dtmDateUpdate.TabIndex = 23;
            this.dtmDateUpdate.Visible = false;
            // 
            // txtCityUpdate
            // 
            this.txtCityUpdate.Location = new System.Drawing.Point(787, 643);
            this.txtCityUpdate.Name = "txtCityUpdate";
            this.txtCityUpdate.Size = new System.Drawing.Size(233, 20);
            this.txtCityUpdate.TabIndex = 24;
            this.txtCityUpdate.Visible = false;
            // 
            // lblDateUpdate
            // 
            this.lblDateUpdate.AutoSize = true;
            this.lblDateUpdate.Font = new System.Drawing.Font("Moon Flower Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateUpdate.Location = new System.Drawing.Point(610, 565);
            this.lblDateUpdate.Name = "lblDateUpdate";
            this.lblDateUpdate.Size = new System.Drawing.Size(62, 39);
            this.lblDateUpdate.TabIndex = 25;
            this.lblDateUpdate.Text = "Date";
            this.lblDateUpdate.Visible = false;
            // 
            // lblCityUpdate
            // 
            this.lblCityUpdate.AutoSize = true;
            this.lblCityUpdate.Font = new System.Drawing.Font("Moon Flower Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCityUpdate.Location = new System.Drawing.Point(610, 626);
            this.lblCityUpdate.Name = "lblCityUpdate";
            this.lblCityUpdate.Size = new System.Drawing.Size(59, 39);
            this.lblCityUpdate.TabIndex = 26;
            this.lblCityUpdate.Text = "City";
            this.lblCityUpdate.Visible = false;
            // 
            // lblNew
            // 
            this.lblNew.AutoSize = true;
            this.lblNew.Font = new System.Drawing.Font("Moon Flower Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNew.Location = new System.Drawing.Point(143, 180);
            this.lblNew.Name = "lblNew";
            this.lblNew.Size = new System.Drawing.Size(197, 50);
            this.lblNew.TabIndex = 27;
            this.lblNew.Text = "NEW FORECAST";
            this.lblNew.Visible = false;
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Font = new System.Drawing.Font("Moon Flower Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdate.Location = new System.Drawing.Point(685, 497);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(235, 50);
            this.lblUpdate.TabIndex = 28;
            this.lblUpdate.Text = "UPDATE FORECAST";
            this.lblUpdate.Visible = false;
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtDisplay.Location = new System.Drawing.Point(1047, 57);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDisplay.Size = new System.Drawing.Size(385, 697);
            this.txtDisplay.TabIndex = 29;
            this.txtDisplay.WordWrap = false;
            // 
            // lblView
            // 
            this.lblView.AutoSize = true;
            this.lblView.Font = new System.Drawing.Font("Moon Flower Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblView.Location = new System.Drawing.Point(714, 180);
            this.lblView.Name = "lblView";
            this.lblView.Size = new System.Drawing.Size(219, 50);
            this.lblView.TabIndex = 30;
            this.lblView.Text = "VIEW FORECASTS";
            this.lblView.Visible = false;
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Moon Flower Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(605, 701);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(415, 53);
            this.btnView.TabIndex = 31;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Visible = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Moon Flower Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(605, 701);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(415, 53);
            this.btnUpdate.TabIndex = 32;
            this.btnUpdate.Text = "Submit";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnPopulate
            // 
            this.btnPopulate.Font = new System.Drawing.Font("Moon Flower Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPopulate.Location = new System.Drawing.Point(719, 43);
            this.btnPopulate.Name = "btnPopulate";
            this.btnPopulate.Size = new System.Drawing.Size(130, 43);
            this.btnPopulate.TabIndex = 33;
            this.btnPopulate.Text = "Populate";
            this.btnPopulate.UseVisualStyleBackColor = true;
            this.btnPopulate.Click += new System.EventHandler(this.btnPopulate_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Font = new System.Drawing.Font("Moon Flower Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.Location = new System.Drawing.Point(890, 43);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(130, 43);
            this.btnDisplay.TabIndex = 34;
            this.btnDisplay.Text = "Display all";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // lblCityView
            // 
            this.lblCityView.AutoSize = true;
            this.lblCityView.Font = new System.Drawing.Font("Moon Flower Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCityView.Location = new System.Drawing.Point(610, 366);
            this.lblCityView.Name = "lblCityView";
            this.lblCityView.Size = new System.Drawing.Size(69, 39);
            this.lblCityView.TabIndex = 35;
            this.lblCityView.Text = "City:";
            this.lblCityView.Visible = false;
            // 
            // txtCityView
            // 
            this.txtCityView.Location = new System.Drawing.Point(787, 383);
            this.txtCityView.Name = "txtCityView";
            this.txtCityView.Size = new System.Drawing.Size(233, 20);
            this.txtCityView.TabIndex = 36;
            this.txtCityView.Visible = false;
            // 
            // btnAddCity
            // 
            this.btnAddCity.Font = new System.Drawing.Font("Moon Flower Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCity.Location = new System.Drawing.Point(605, 432);
            this.btnAddCity.Name = "btnAddCity";
            this.btnAddCity.Size = new System.Drawing.Size(415, 53);
            this.btnAddCity.TabIndex = 37;
            this.btnAddCity.Text = "Add to selected cities";
            this.btnAddCity.UseVisualStyleBackColor = true;
            this.btnAddCity.Visible = false;
            this.btnAddCity.Click += new System.EventHandler(this.btnAddCity_Click);
            // 
            // pctNew2
            // 
            this.pctNew2.Image = global::Weather_Forecaster.Properties.Resources.raincloudbasic;
            this.pctNew2.Location = new System.Drawing.Point(605, 426);
            this.pctNew2.Name = "pctNew2";
            this.pctNew2.Size = new System.Drawing.Size(415, 277);
            this.pctNew2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctNew2.TabIndex = 43;
            this.pctNew2.TabStop = false;
            this.pctNew2.Visible = false;
            // 
            // pctNew
            // 
            this.pctNew.Image = global::Weather_Forecaster.Properties.Resources.suncloudrotating;
            this.pctNew.Location = new System.Drawing.Point(605, 121);
            this.pctNew.Name = "pctNew";
            this.pctNew.Size = new System.Drawing.Size(415, 299);
            this.pctNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctNew.TabIndex = 38;
            this.pctNew.TabStop = false;
            this.pctNew.Visible = false;
            // 
            // pctUpdateView
            // 
            this.pctUpdateView.Image = global::Weather_Forecaster.Properties.Resources.sun;
            this.pctUpdateView.Location = new System.Drawing.Point(55, 121);
            this.pctUpdateView.Name = "pctUpdateView";
            this.pctUpdateView.Size = new System.Drawing.Size(415, 301);
            this.pctUpdateView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctUpdateView.TabIndex = 41;
            this.pctUpdateView.TabStop = false;
            this.pctUpdateView.Visible = false;
            // 
            // pctUpdateView2
            // 
            this.pctUpdateView2.Image = global::Weather_Forecaster.Properties.Resources.raincloud;
            this.pctUpdateView2.Location = new System.Drawing.Point(57, 467);
            this.pctUpdateView2.Name = "pctUpdateView2";
            this.pctUpdateView2.Size = new System.Drawing.Size(415, 287);
            this.pctUpdateView2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctUpdateView2.TabIndex = 42;
            this.pctUpdateView2.TabStop = false;
            this.pctUpdateView2.Visible = false;
            // 
            // frmForecaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1526, 788);
            this.Controls.Add(this.pctNew2);
            this.Controls.Add(this.btnAddCity);
            this.Controls.Add(this.txtCityView);
            this.Controls.Add(this.lblCityView);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnPopulate);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.lblView);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.lblUpdate);
            this.Controls.Add(this.lblNew);
            this.Controls.Add(this.lblCityUpdate);
            this.Controls.Add(this.lblDateUpdate);
            this.Controls.Add(this.txtCityUpdate);
            this.Controls.Add(this.dtmDateUpdate);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.btnSubmitNew);
            this.Controls.Add(this.txtWindSpeedNew);
            this.Controls.Add(this.txtHumidityNew);
            this.Controls.Add(this.txtPrecipitationNew);
            this.Controls.Add(this.txtMaxTempNew);
            this.Controls.Add(this.txtMinTempNew);
            this.Controls.Add(this.lblWindSpeedNew);
            this.Controls.Add(this.txtCityNew);
            this.Controls.Add(this.lblMinTempNew);
            this.Controls.Add(this.lblMaxTempNew);
            this.Controls.Add(this.lblPrecipitationNew);
            this.Controls.Add(this.lblHumidityNew);
            this.Controls.Add(this.lblDateNew);
            this.Controls.Add(this.lblCityNew);
            this.Controls.Add(this.dtmDateNew);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.dtmEndDateView);
            this.Controls.Add(this.dtmStartDateView);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pctNew);
            this.Controls.Add(this.pctUpdateView);
            this.Controls.Add(this.pctUpdateView2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmForecaster";
            this.Text = "Weather Forecaster";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctNew2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctUpdateView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctUpdateView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.DateTimePicker dtmStartDateView;
        private System.Windows.Forms.DateTimePicker dtmEndDateView;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.DateTimePicker dtmDateNew;
        private System.Windows.Forms.Label lblCityNew;
        private System.Windows.Forms.Label lblDateNew;
        private System.Windows.Forms.Label lblHumidityNew;
        private System.Windows.Forms.Label lblPrecipitationNew;
        private System.Windows.Forms.Label lblMaxTempNew;
        private System.Windows.Forms.Label lblMinTempNew;
        private System.Windows.Forms.TextBox txtCityNew;
        private System.Windows.Forms.Label lblWindSpeedNew;
        private System.Windows.Forms.TextBox txtMinTempNew;
        private System.Windows.Forms.TextBox txtMaxTempNew;
        private System.Windows.Forms.TextBox txtPrecipitationNew;
        private System.Windows.Forms.TextBox txtHumidityNew;
        private System.Windows.Forms.TextBox txtWindSpeedNew;
        private System.Windows.Forms.Button btnSubmitNew;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addForecastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addForecast;
        private System.Windows.Forms.ToolStripMenuItem updateForecast;
        private System.Windows.Forms.ToolStripMenuItem viewForecasts;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtmDateUpdate;
        private System.Windows.Forms.TextBox txtCityUpdate;
        private System.Windows.Forms.Label lblDateUpdate;
        private System.Windows.Forms.Label lblCityUpdate;
        private System.Windows.Forms.Label lblNew;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Label lblView;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnPopulate;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Label lblCityView;
        private System.Windows.Forms.TextBox txtCityView;
        private System.Windows.Forms.Button btnAddCity;
        private System.Windows.Forms.PictureBox pctNew;
        private System.Windows.Forms.PictureBox pctUpdateView;
        private System.Windows.Forms.PictureBox pctUpdateView2;
        private System.Windows.Forms.PictureBox pctNew2;
    }
}

