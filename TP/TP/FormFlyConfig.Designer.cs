namespace TP
{
    partial class FormFlyConfig
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
            this.pictureBoxAirplane = new System.Windows.Forms.PictureBox();
            this.groupBoxConfig = new System.Windows.Forms.GroupBox();
            this.labelAirplane = new System.Windows.Forms.Label();
            this.labelSturmovic = new System.Windows.Forms.Label();
            this.panelFly = new System.Windows.Forms.Panel();
            this.labelMainColor = new System.Windows.Forms.Label();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelPurple = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelNavy = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelAqua = new System.Windows.Forms.Panel();
            this.groupBoxColors = new System.Windows.Forms.GroupBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAirplane)).BeginInit();
            this.groupBoxConfig.SuspendLayout();
            this.panelFly.SuspendLayout();
            this.groupBoxColors.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxAirplane
            // 
            this.pictureBoxAirplane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxAirplane.Location = new System.Drawing.Point(20, 25);
            this.pictureBoxAirplane.Name = "pictureBoxAirplane";
            this.pictureBoxAirplane.Size = new System.Drawing.Size(219, 130);
            this.pictureBoxAirplane.TabIndex = 0;
            this.pictureBoxAirplane.TabStop = false;
            // 
            // groupBoxConfig
            // 
            this.groupBoxConfig.Controls.Add(this.labelSturmovic);
            this.groupBoxConfig.Controls.Add(this.labelAirplane);
            this.groupBoxConfig.Location = new System.Drawing.Point(27, 62);
            this.groupBoxConfig.Name = "groupBoxConfig";
            this.groupBoxConfig.Size = new System.Drawing.Size(221, 222);
            this.groupBoxConfig.TabIndex = 1;
            this.groupBoxConfig.TabStop = false;
            this.groupBoxConfig.Text = "Тип фюзеляжа";
            // 
            // labelAirplane
            // 
            this.labelAirplane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAirplane.Location = new System.Drawing.Point(24, 25);
            this.labelAirplane.Name = "labelAirplane";
            this.labelAirplane.Size = new System.Drawing.Size(122, 65);
            this.labelAirplane.TabIndex = 0;
            this.labelAirplane.Text = "Обычный самолет";
            this.labelAirplane.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelAirplane_MouseDown);
            // 
            // labelSturmovic
            // 
            this.labelSturmovic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSturmovic.Location = new System.Drawing.Point(24, 105);
            this.labelSturmovic.Name = "labelSturmovic";
            this.labelSturmovic.Size = new System.Drawing.Size(122, 72);
            this.labelSturmovic.TabIndex = 2;
            this.labelSturmovic.Text = "Штурмовик";
            this.labelSturmovic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelSturmovicr_MouseDown);
            // 
            // panelFly
            // 
            this.panelFly.AllowDrop = true;
            this.panelFly.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFly.Controls.Add(this.labelDopColor);
            this.panelFly.Controls.Add(this.labelMainColor);
            this.panelFly.Controls.Add(this.pictureBoxAirplane);
            this.panelFly.Location = new System.Drawing.Point(268, 62);
            this.panelFly.Name = "panelFly";
            this.panelFly.Size = new System.Drawing.Size(260, 303);
            this.panelFly.TabIndex = 2;
            this.panelFly.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelFly_DragDrop);
            this.panelFly.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelFly_DragEnter);
            // 
            // labelMainColor
            // 
            this.labelMainColor.AllowDrop = true;
            this.labelMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMainColor.Location = new System.Drawing.Point(14, 177);
            this.labelMainColor.Name = "labelMainColor";
            this.labelMainColor.Size = new System.Drawing.Size(209, 57);
            this.labelMainColor.TabIndex = 1;
            this.labelMainColor.Text = "Основной цвет";
            this.labelMainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragDrop);
            this.labelMainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragEnter);
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(14, 242);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(209, 57);
            this.labelDopColor.TabIndex = 2;
            this.labelDopColor.Text = "Дополнительный цвет";
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragEnter);
            // 
            // panelRed
            // 
            this.panelRed.AllowDrop = true;
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(20, 193);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(47, 46);
            this.panelRed.TabIndex = 3;
            this.panelRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelBlack
            // 
            this.panelBlack.AllowDrop = true;
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.Location = new System.Drawing.Point(101, 193);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(46, 46);
            this.panelBlack.TabIndex = 4;
            this.panelBlack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelYellow
            // 
            this.panelYellow.AllowDrop = true;
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.Location = new System.Drawing.Point(20, 23);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(47, 38);
            this.panelYellow.TabIndex = 5;
            this.panelYellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelPurple
            // 
            this.panelPurple.AllowDrop = true;
            this.panelPurple.BackColor = System.Drawing.Color.Purple;
            this.panelPurple.Location = new System.Drawing.Point(101, 23);
            this.panelPurple.Name = "panelPurple";
            this.panelPurple.Size = new System.Drawing.Size(46, 38);
            this.panelPurple.TabIndex = 6;
            this.panelPurple.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelGreen
            // 
            this.panelGreen.AllowDrop = true;
            this.panelGreen.BackColor = System.Drawing.Color.Green;
            this.panelGreen.Location = new System.Drawing.Point(20, 80);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(47, 39);
            this.panelGreen.TabIndex = 7;
            this.panelGreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelNavy
            // 
            this.panelNavy.AllowDrop = true;
            this.panelNavy.BackColor = System.Drawing.Color.Navy;
            this.panelNavy.Location = new System.Drawing.Point(101, 82);
            this.panelNavy.Name = "panelNavy";
            this.panelNavy.Size = new System.Drawing.Size(46, 37);
            this.panelNavy.TabIndex = 8;
            this.panelNavy.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelBlue
            // 
            this.panelBlue.AllowDrop = true;
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.Location = new System.Drawing.Point(20, 140);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(47, 37);
            this.panelBlue.TabIndex = 9;
            this.panelBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelAqua
            // 
            this.panelAqua.AllowDrop = true;
            this.panelAqua.BackColor = System.Drawing.Color.Aqua;
            this.panelAqua.Location = new System.Drawing.Point(101, 140);
            this.panelAqua.Name = "panelAqua";
            this.panelAqua.Size = new System.Drawing.Size(46, 37);
            this.panelAqua.TabIndex = 10;
            this.panelAqua.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // groupBoxColors
            // 
            this.groupBoxColors.Controls.Add(this.panelBlue);
            this.groupBoxColors.Controls.Add(this.panelBlack);
            this.groupBoxColors.Controls.Add(this.panelYellow);
            this.groupBoxColors.Controls.Add(this.panelRed);
            this.groupBoxColors.Controls.Add(this.panelPurple);
            this.groupBoxColors.Controls.Add(this.panelNavy);
            this.groupBoxColors.Controls.Add(this.panelAqua);
            this.groupBoxColors.Controls.Add(this.panelGreen);
            this.groupBoxColors.Location = new System.Drawing.Point(589, 62);
            this.groupBoxColors.Name = "groupBoxColors";
            this.groupBoxColors.Size = new System.Drawing.Size(166, 299);
            this.groupBoxColors.TabIndex = 11;
            this.groupBoxColors.TabStop = false;
            this.groupBoxColors.Text = "Цвета";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(51, 296);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(105, 31);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(110, 349);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(95, 29);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormFlyConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBoxColors);
            this.Controls.Add(this.panelFly);
            this.Controls.Add(this.groupBoxConfig);
            this.Name = "FormFlyConfig";
            this.Text = "FormFlyConfig";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAirplane)).EndInit();
            this.groupBoxConfig.ResumeLayout(false);
            this.panelFly.ResumeLayout(false);
            this.groupBoxColors.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAirplane;
        private System.Windows.Forms.GroupBox groupBoxConfig;
        private System.Windows.Forms.Label labelSturmovic;
        private System.Windows.Forms.Label labelAirplane;
        private System.Windows.Forms.Panel panelFly;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelMainColor;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelPurple;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelNavy;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelAqua;
        private System.Windows.Forms.GroupBox groupBoxColors;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
    }
}