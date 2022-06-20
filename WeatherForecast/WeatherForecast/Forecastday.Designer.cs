namespace WeatherForecast
{
    partial class FCD
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pic = new System.Windows.Forms.PictureBox();
            this.date = new System.Windows.Forms.Label();
            this.condition = new System.Windows.Forms.Label();
            this.humid = new System.Windows.Forms.Label();
            this.des = new System.Windows.Forms.Label();
            this.temp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(2, 16);
            this.pic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(38, 41);
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.BackColor = System.Drawing.Color.Transparent;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(138, 0);
            this.date.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(86, 31);
            this.date.TabIndex = 1;
            this.date.Text = "label1";
            this.date.Click += new System.EventHandler(this.label1_Click);
            // 
            // condition
            // 
            this.condition.AutoSize = true;
            this.condition.BackColor = System.Drawing.Color.Transparent;
            this.condition.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.condition.Location = new System.Drawing.Point(56, 33);
            this.condition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.condition.Name = "condition";
            this.condition.Size = new System.Drawing.Size(64, 25);
            this.condition.TabIndex = 2;
            this.condition.Text = "label2";
            // 
            // humid
            // 
            this.humid.AutoSize = true;
            this.humid.BackColor = System.Drawing.Color.Transparent;
            this.humid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humid.Location = new System.Drawing.Point(232, 33);
            this.humid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.humid.Name = "humid";
            this.humid.Size = new System.Drawing.Size(64, 25);
            this.humid.TabIndex = 3;
            this.humid.Text = "label3";
            // 
            // des
            // 
            this.des.AutoSize = true;
            this.des.BackColor = System.Drawing.Color.Transparent;
            this.des.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.des.Location = new System.Drawing.Point(56, 73);
            this.des.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.des.Name = "des";
            this.des.Size = new System.Drawing.Size(64, 25);
            this.des.TabIndex = 4;
            this.des.Text = "label4";
            // 
            // temp
            // 
            this.temp.AutoSize = true;
            this.temp.BackColor = System.Drawing.Color.Transparent;
            this.temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temp.Location = new System.Drawing.Point(232, 73);
            this.temp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.temp.Name = "temp";
            this.temp.Size = new System.Drawing.Size(64, 25);
            this.temp.TabIndex = 5;
            this.temp.Text = "label5";
            // 
            // FCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.temp);
            this.Controls.Add(this.des);
            this.Controls.Add(this.humid);
            this.Controls.Add(this.condition);
            this.Controls.Add(this.date);
            this.Controls.Add(this.pic);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FCD";
            this.Size = new System.Drawing.Size(334, 119);
            this.Load += new System.EventHandler(this.FCD_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FCD_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pic;
        public System.Windows.Forms.Label date;
        public System.Windows.Forms.Label condition;
        public System.Windows.Forms.Label humid;
        public System.Windows.Forms.Label des;
        public System.Windows.Forms.Label temp;
    }
}
