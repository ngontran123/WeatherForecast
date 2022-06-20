namespace WeatherForecast
{
    partial class WeatherForecast
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
            this.components = new System.ComponentModel.Container();
            this.combobox1 = new System.Windows.Forms.ComboBox();
            this.cityname = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.City = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.longtitude = new System.Windows.Forms.Label();
            this.country = new System.Windows.Forms.Label();
            this.latitude = new System.Windows.Forms.Label();
            this.sunrise = new System.Windows.Forms.Label();
            this.sunset = new System.Windows.Forms.Label();
            this.condition = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.humidity = new System.Windows.Forms.Label();
            this.windpressure = new System.Windows.Forms.Label();
            this.pressure = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.degree = new System.Windows.Forms.Label();
            this.fah = new System.Windows.Forms.Label();
            this.winddeg = new System.Windows.Forms.Label();
            this.datetime = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.country1 = new System.Windows.Forms.Label();
            this.lat1 = new System.Windows.Forms.Label();
            this.lon1 = new System.Windows.Forms.Label();
            this.cond = new System.Windows.Forms.Label();
            this.des = new System.Windows.Forms.Label();
            this.humid = new System.Windows.Forms.Label();
            this.wind = new System.Windows.Forms.Label();
            this.press = new System.Windows.Forms.Label();
            this.temp_max = new System.Windows.Forms.Label();
            this.temp_min = new System.Windows.Forms.Label();
            this.sr = new System.Windows.Forms.Label();
            this.ss = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.feels = new System.Windows.Forms.Label();
            this.Forecastpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.hourlypanel = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.suns = new System.Windows.Forms.PictureBox();
            this.sunr = new System.Windows.Forms.PictureBox();
            this.images = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.images)).BeginInit();
            this.SuspendLayout();
            // 
            // combobox1
            // 
            this.combobox1.FormattingEnabled = true;
            this.combobox1.Items.AddRange(new object[] {
            "Tokyo",
            "Kyoto",
            "Washington"});
            this.combobox1.Location = new System.Drawing.Point(25, 26);
            this.combobox1.Name = "combobox1";
            this.combobox1.Size = new System.Drawing.Size(121, 24);
            this.combobox1.TabIndex = 0;
            this.combobox1.Tag = "";
            this.combobox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cityname
            // 
            this.cityname.Location = new System.Drawing.Point(153, 27);
            this.cityname.Name = "cityname";
            this.cityname.Size = new System.Drawing.Size(193, 22);
            this.cityname.TabIndex = 1;
            this.cityname.Text = "Hà Nội";
            this.cityname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cityname_KeyDown);
            this.cityname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cityname_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(364, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // City
            // 
            this.City.AutoSize = true;
            this.City.BackColor = System.Drawing.Color.Transparent;
            this.City.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.City.Location = new System.Drawing.Point(196, 93);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(271, 39);
            this.City.TabIndex = 3;
            this.City.Text = "Thành Phố HCM";
            this.City.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.City.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(0, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Thành phố:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // longtitude
            // 
            this.longtitude.AutoSize = true;
            this.longtitude.BackColor = System.Drawing.Color.Transparent;
            this.longtitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.longtitude.Location = new System.Drawing.Point(-7, 148);
            this.longtitude.Name = "longtitude";
            this.longtitude.Size = new System.Drawing.Size(187, 39);
            this.longtitude.TabIndex = 5;
            this.longtitude.Text = "Kinh tuyến:";
            this.longtitude.Click += new System.EventHandler(this.longtitude_Click);
            // 
            // country
            // 
            this.country.AutoSize = true;
            this.country.BackColor = System.Drawing.Color.Transparent;
            this.country.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.country.Location = new System.Drawing.Point(842, 93);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(162, 39);
            this.country.TabIndex = 6;
            this.country.Text = "Quốc gia:";
            this.country.Click += new System.EventHandler(this.label3_Click);
            // 
            // latitude
            // 
            this.latitude.AutoSize = true;
            this.latitude.BackColor = System.Drawing.Color.Transparent;
            this.latitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.latitude.Location = new System.Drawing.Point(853, 148);
            this.latitude.Name = "latitude";
            this.latitude.Size = new System.Drawing.Size(149, 39);
            this.latitude.TabIndex = 7;
            this.latitude.Text = "Vĩ tuyến:";
            // 
            // sunrise
            // 
            this.sunrise.AutoSize = true;
            this.sunrise.BackColor = System.Drawing.Color.Transparent;
            this.sunrise.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sunrise.Location = new System.Drawing.Point(582, 12);
            this.sunrise.Name = "sunrise";
            this.sunrise.Size = new System.Drawing.Size(124, 25);
            this.sunrise.TabIndex = 8;
            this.sunrise.Text = "Mặt trời mọc:";
            // 
            // sunset
            // 
            this.sunset.AutoSize = true;
            this.sunset.BackColor = System.Drawing.Color.Transparent;
            this.sunset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sunset.Location = new System.Drawing.Point(924, 12);
            this.sunset.Name = "sunset";
            this.sunset.Size = new System.Drawing.Size(113, 25);
            this.sunset.TabIndex = 9;
            this.sunset.Text = "Mặt trời lặn:";
            // 
            // condition
            // 
            this.condition.AutoSize = true;
            this.condition.BackColor = System.Drawing.Color.Transparent;
            this.condition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.condition.Location = new System.Drawing.Point(2, 461);
            this.condition.Name = "condition";
            this.condition.Size = new System.Drawing.Size(99, 25);
            this.condition.TabIndex = 10;
            this.condition.Text = "Điều kiện:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label8.Location = new System.Drawing.Point(12, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 29);
            this.label8.TabIndex = 11;
            // 
            // humidity
            // 
            this.humidity.AutoSize = true;
            this.humidity.BackColor = System.Drawing.Color.Transparent;
            this.humidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humidity.Location = new System.Drawing.Point(2, 577);
            this.humidity.Name = "humidity";
            this.humidity.Size = new System.Drawing.Size(75, 25);
            this.humidity.TabIndex = 12;
            this.humidity.Text = "Độ ẩm:";
            // 
            // windpressure
            // 
            this.windpressure.AutoSize = true;
            this.windpressure.BackColor = System.Drawing.Color.Transparent;
            this.windpressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windpressure.Location = new System.Drawing.Point(2, 633);
            this.windpressure.Name = "windpressure";
            this.windpressure.Size = new System.Drawing.Size(81, 25);
            this.windpressure.TabIndex = 13;
            this.windpressure.Text = "Lực gió:";
            // 
            // pressure
            // 
            this.pressure.AutoSize = true;
            this.pressure.BackColor = System.Drawing.Color.Transparent;
            this.pressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pressure.Location = new System.Drawing.Point(2, 686);
            this.pressure.Name = "pressure";
            this.pressure.Size = new System.Drawing.Size(85, 25);
            this.pressure.TabIndex = 14;
            this.pressure.Text = "Áp suất:";
            this.pressure.Click += new System.EventHandler(this.pressure_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label2.Location = new System.Drawing.Point(367, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 58);
            this.label2.TabIndex = 15;
            this.label2.Text = "°C";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(383, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 51);
            this.label3.TabIndex = 16;
            this.label3.Text = "°F";
            // 
            // degree
            // 
            this.degree.AutoSize = true;
            this.degree.BackColor = System.Drawing.Color.Transparent;
            this.degree.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.degree.Location = new System.Drawing.Point(215, 215);
            this.degree.Name = "degree";
            this.degree.Size = new System.Drawing.Size(159, 58);
            this.degree.TabIndex = 17;
            this.degree.Text = "label1";
            this.degree.Click += new System.EventHandler(this.degree_Click);
            // 
            // fah
            // 
            this.fah.AutoSize = true;
            this.fah.BackColor = System.Drawing.Color.Transparent;
            this.fah.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.fah.Location = new System.Drawing.Point(217, 292);
            this.fah.Name = "fah";
            this.fah.Size = new System.Drawing.Size(132, 48);
            this.fah.TabIndex = 18;
            this.fah.Text = "label1";
            // 
            // winddeg
            // 
            this.winddeg.AutoSize = true;
            this.winddeg.BackColor = System.Drawing.Color.Transparent;
            this.winddeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winddeg.Location = new System.Drawing.Point(309, 519);
            this.winddeg.Name = "winddeg";
            this.winddeg.Size = new System.Drawing.Size(107, 25);
            this.winddeg.TabIndex = 19;
            this.winddeg.Text = "Hướng gió:";
            this.winddeg.Click += new System.EventHandler(this.rain_Click);
            // 
            // datetime
            // 
            this.datetime.AutoSize = true;
            this.datetime.BackColor = System.Drawing.Color.Transparent;
            this.datetime.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetime.ForeColor = System.Drawing.Color.DarkRed;
            this.datetime.Location = new System.Drawing.Point(4, 379);
            this.datetime.Name = "datetime";
            this.datetime.Size = new System.Drawing.Size(390, 38);
            this.datetime.TabIndex = 20;
            this.datetime.Text = "Tuesday,21,2021 7:00AM";
            this.datetime.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 522);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "Mô tả:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(249, 577);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(170, 25);
            this.label19.TabIndex = 53;
            this.label19.Text = "Nhiệt độ cao nhất:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(249, 633);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(176, 25);
            this.label20.TabIndex = 54;
            this.label20.Text = "Nhiệt độ thấp nhất:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label21.Location = new System.Drawing.Point(7, 810);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(211, 29);
            this.label21.TabIndex = 55;
            this.label21.Text = "Nhiệt độ theo giờ:";
            // 
            // label22
            // 
            this.label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label22.Location = new System.Drawing.Point(-2, 887);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(1097, 2);
            this.label22.TabIndex = 56;
            // 
            // country1
            // 
            this.country1.AutoSize = true;
            this.country1.BackColor = System.Drawing.Color.Transparent;
            this.country1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.country1.Location = new System.Drawing.Point(1010, 93);
            this.country1.Name = "country1";
            this.country1.Size = new System.Drawing.Size(121, 38);
            this.country1.TabIndex = 92;
            this.country1.Text = "label48";
            // 
            // lat1
            // 
            this.lat1.AutoSize = true;
            this.lat1.BackColor = System.Drawing.Color.Transparent;
            this.lat1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lat1.Location = new System.Drawing.Point(1008, 148);
            this.lat1.Name = "lat1";
            this.lat1.Size = new System.Drawing.Size(121, 38);
            this.lat1.TabIndex = 93;
            this.lat1.Text = "label48";
            // 
            // lon1
            // 
            this.lon1.AutoSize = true;
            this.lon1.BackColor = System.Drawing.Color.Transparent;
            this.lon1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lon1.Location = new System.Drawing.Point(182, 148);
            this.lon1.Name = "lon1";
            this.lon1.Size = new System.Drawing.Size(121, 38);
            this.lon1.TabIndex = 94;
            this.lon1.Text = "label48";
            // 
            // cond
            // 
            this.cond.AutoSize = true;
            this.cond.BackColor = System.Drawing.Color.Transparent;
            this.cond.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cond.Location = new System.Drawing.Point(130, 461);
            this.cond.Name = "cond";
            this.cond.Size = new System.Drawing.Size(75, 25);
            this.cond.TabIndex = 95;
            this.cond.Text = "label48";
            this.cond.Click += new System.EventHandler(this.label48_Click);
            // 
            // des
            // 
            this.des.AutoSize = true;
            this.des.BackColor = System.Drawing.Color.Transparent;
            this.des.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.des.Location = new System.Drawing.Point(85, 522);
            this.des.Name = "des";
            this.des.Size = new System.Drawing.Size(75, 25);
            this.des.TabIndex = 96;
            this.des.Text = "label48";
            // 
            // humid
            // 
            this.humid.AutoSize = true;
            this.humid.BackColor = System.Drawing.Color.Transparent;
            this.humid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humid.Location = new System.Drawing.Point(100, 577);
            this.humid.Name = "humid";
            this.humid.Size = new System.Drawing.Size(75, 25);
            this.humid.TabIndex = 97;
            this.humid.Text = "label48";
            // 
            // wind
            // 
            this.wind.AutoSize = true;
            this.wind.BackColor = System.Drawing.Color.Transparent;
            this.wind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wind.Location = new System.Drawing.Point(110, 633);
            this.wind.Name = "wind";
            this.wind.Size = new System.Drawing.Size(75, 25);
            this.wind.TabIndex = 98;
            this.wind.Text = "label48";
            // 
            // press
            // 
            this.press.AutoSize = true;
            this.press.BackColor = System.Drawing.Color.Transparent;
            this.press.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.press.Location = new System.Drawing.Point(108, 686);
            this.press.Name = "press";
            this.press.Size = new System.Drawing.Size(75, 25);
            this.press.TabIndex = 99;
            this.press.Text = "label48";
            // 
            // temp_max
            // 
            this.temp_max.AutoSize = true;
            this.temp_max.BackColor = System.Drawing.Color.Transparent;
            this.temp_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temp_max.Location = new System.Drawing.Point(464, 577);
            this.temp_max.Name = "temp_max";
            this.temp_max.Size = new System.Drawing.Size(75, 25);
            this.temp_max.TabIndex = 101;
            this.temp_max.Text = "label48";
            // 
            // temp_min
            // 
            this.temp_min.AutoSize = true;
            this.temp_min.BackColor = System.Drawing.Color.Transparent;
            this.temp_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temp_min.Location = new System.Drawing.Point(464, 633);
            this.temp_min.Name = "temp_min";
            this.temp_min.Size = new System.Drawing.Size(75, 25);
            this.temp_min.TabIndex = 102;
            this.temp_min.Text = "label48";
            // 
            // sr
            // 
            this.sr.AutoSize = true;
            this.sr.BackColor = System.Drawing.Color.Transparent;
            this.sr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sr.Location = new System.Drawing.Point(712, 12);
            this.sr.Name = "sr";
            this.sr.Size = new System.Drawing.Size(71, 25);
            this.sr.TabIndex = 103;
            this.sr.Text = "labe12";
            // 
            // ss
            // 
            this.ss.AutoSize = true;
            this.ss.BackColor = System.Drawing.Color.Transparent;
            this.ss.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ss.Location = new System.Drawing.Point(1043, 12);
            this.ss.Name = "ss";
            this.ss.Size = new System.Drawing.Size(71, 25);
            this.ss.TabIndex = 104;
            this.ss.Text = "labe12";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(257, 686);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 25);
            this.label4.TabIndex = 105;
            this.label4.Text = "Cảm giác thực:";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // feels
            // 
            this.feels.AutoSize = true;
            this.feels.BackColor = System.Drawing.Color.Transparent;
            this.feels.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feels.Location = new System.Drawing.Point(464, 686);
            this.feels.Name = "feels";
            this.feels.Size = new System.Drawing.Size(75, 25);
            this.feels.TabIndex = 106;
            this.feels.Text = "label48";
            // 
            // Forecastpanel
            // 
            this.Forecastpanel.AutoScroll = true;
            this.Forecastpanel.BackColor = System.Drawing.Color.Transparent;
            this.Forecastpanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Forecastpanel.Location = new System.Drawing.Point(601, 190);
            this.Forecastpanel.Name = "Forecastpanel";
            this.Forecastpanel.Size = new System.Drawing.Size(557, 514);
            this.Forecastpanel.TabIndex = 109;
            this.Forecastpanel.WrapContents = false;
            this.Forecastpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Forecastpanel_Paint);
            // 
            // hourlypanel
            // 
            this.hourlypanel.AutoScroll = true;
            this.hourlypanel.BackColor = System.Drawing.Color.Transparent;
            this.hourlypanel.Location = new System.Drawing.Point(0, 901);
            this.hourlypanel.Name = "hourlypanel";
            this.hourlypanel.Size = new System.Drawing.Size(1081, 156);
            this.hourlypanel.TabIndex = 110;
            this.hourlypanel.WrapContents = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(469, 508);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 50);
            this.pictureBox1.TabIndex = 114;
            this.pictureBox1.TabStop = false;
            // 
            // suns
            // 
            this.suns.Location = new System.Drawing.Point(1136, 4);
            this.suns.Name = "suns";
            this.suns.Size = new System.Drawing.Size(49, 45);
            this.suns.TabIndex = 113;
            this.suns.TabStop = false;
            // 
            // sunr
            // 
            this.sunr.Location = new System.Drawing.Point(805, 3);
            this.sunr.Name = "sunr";
            this.sunr.Size = new System.Drawing.Size(53, 46);
            this.sunr.TabIndex = 112;
            this.sunr.TabStop = false;
            this.sunr.Click += new System.EventHandler(this.sunr_Click);
            // 
            // images
            // 
            this.images.Location = new System.Drawing.Point(25, 238);
            this.images.Name = "images";
            this.images.Size = new System.Drawing.Size(121, 84);
            this.images.TabIndex = 111;
            this.images.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(225, 810);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 33);
            this.button2.TabIndex = 115;
            this.button2.Text = "Biểu đồ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // WeatherForecast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1211, 1055);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.suns);
            this.Controls.Add(this.sunr);
            this.Controls.Add(this.images);
            this.Controls.Add(this.hourlypanel);
            this.Controls.Add(this.Forecastpanel);
            this.Controls.Add(this.feels);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ss);
            this.Controls.Add(this.sr);
            this.Controls.Add(this.temp_min);
            this.Controls.Add(this.temp_max);
            this.Controls.Add(this.press);
            this.Controls.Add(this.wind);
            this.Controls.Add(this.humid);
            this.Controls.Add(this.des);
            this.Controls.Add(this.cond);
            this.Controls.Add(this.lon1);
            this.Controls.Add(this.lat1);
            this.Controls.Add(this.country1);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.datetime);
            this.Controls.Add(this.winddeg);
            this.Controls.Add(this.fah);
            this.Controls.Add(this.degree);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pressure);
            this.Controls.Add(this.windpressure);
            this.Controls.Add(this.humidity);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.condition);
            this.Controls.Add(this.sunset);
            this.Controls.Add(this.sunrise);
            this.Controls.Add(this.latitude);
            this.Controls.Add(this.country);
            this.Controls.Add(this.longtitude);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.City);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cityname);
            this.Controls.Add(this.combobox1);
            this.Name = "WeatherForecast";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WeatherForecast";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.images)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combobox1;
        private System.Windows.Forms.TextBox cityname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label City;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label longtitude;
        private System.Windows.Forms.Label country;
        private System.Windows.Forms.Label latitude;
        private System.Windows.Forms.Label sunrise;
        private System.Windows.Forms.Label sunset;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label humidity;
        private System.Windows.Forms.Label windpressure;
        private System.Windows.Forms.Label pressure;
        private System.Windows.Forms.Label condition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label degree;
        private System.Windows.Forms.Label fah;
        private System.Windows.Forms.Label winddeg;
        private System.Windows.Forms.Label datetime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label country1;
        private System.Windows.Forms.Label lat1;
        private System.Windows.Forms.Label lon1;
        private System.Windows.Forms.Label cond;
        private System.Windows.Forms.Label des;
        private System.Windows.Forms.Label humid;
        private System.Windows.Forms.Label wind;
        private System.Windows.Forms.Label press;
        private System.Windows.Forms.Label temp_max;
        private System.Windows.Forms.Label temp_min;
        private System.Windows.Forms.Label sr;
        private System.Windows.Forms.Label ss;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label feels;
        private System.Windows.Forms.FlowLayoutPanel Forecastpanel;
        public System.Windows.Forms.FlowLayoutPanel hourlypanel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox images;
        private System.Windows.Forms.PictureBox sunr;
        private System.Windows.Forms.PictureBox suns;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
    }
}

