namespace TP
{
    partial class FormAngar
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
            this.pictureBoxAngar = new System.Windows.Forms.PictureBox();
            this.groupBoxAngar = new System.Windows.Forms.GroupBox();
            this.pictureBoxTakeFly = new System.Windows.Forms.PictureBox();
            this.buttonTakeAirplane = new System.Windows.Forms.Button();
            this.maskedTextBoxAngar = new System.Windows.Forms.MaskedTextBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.buttonSetFly = new System.Windows.Forms.Button();
            this.buttonSetSturmovic = new System.Windows.Forms.Button();
            this.listBoxLevels = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAngar)).BeginInit();
            this.groupBoxAngar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeFly)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAngar
            // 
            this.pictureBoxAngar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxAngar.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxAngar.Name = "pictureBoxAngar";
            this.pictureBoxAngar.Size = new System.Drawing.Size(604, 450);
            this.pictureBoxAngar.TabIndex = 0;
            this.pictureBoxAngar.TabStop = false;
            // 
            // groupBoxAngar
            // 
            this.groupBoxAngar.Controls.Add(this.pictureBoxTakeFly);
            this.groupBoxAngar.Controls.Add(this.buttonTakeAirplane);
            this.groupBoxAngar.Controls.Add(this.maskedTextBoxAngar);
            this.groupBoxAngar.Controls.Add(this.labelPlace);
            this.groupBoxAngar.Location = new System.Drawing.Point(611, 172);
            this.groupBoxAngar.Name = "groupBoxAngar";
            this.groupBoxAngar.Size = new System.Drawing.Size(188, 277);
            this.groupBoxAngar.TabIndex = 1;
            this.groupBoxAngar.TabStop = false;
            this.groupBoxAngar.Text = "забрать самолет";
            // 
            // pictureBoxTakeFly
            // 
            this.pictureBoxTakeFly.Location = new System.Drawing.Point(10, 149);
            this.pictureBoxTakeFly.Name = "pictureBoxTakeFly";
            this.pictureBoxTakeFly.Size = new System.Drawing.Size(177, 127);
            this.pictureBoxTakeFly.TabIndex = 3;
            this.pictureBoxTakeFly.TabStop = false;
            // 
            // buttonTakeAirplane
            // 
            this.buttonTakeAirplane.Location = new System.Drawing.Point(17, 77);
            this.buttonTakeAirplane.Name = "buttonTakeAirplane";
            this.buttonTakeAirplane.Size = new System.Drawing.Size(64, 37);
            this.buttonTakeAirplane.TabIndex = 2;
            this.buttonTakeAirplane.Text = "забрать";
            this.buttonTakeAirplane.UseVisualStyleBackColor = true;
            this.buttonTakeAirplane.Click += new System.EventHandler(this.buttonTakeAirplaneClick);
            // 
            // maskedTextBoxAngar
            // 
            this.maskedTextBoxAngar.Location = new System.Drawing.Point(15, 50);
            this.maskedTextBoxAngar.Name = "maskedTextBoxAngar";
            this.maskedTextBoxAngar.Size = new System.Drawing.Size(95, 20);
            this.maskedTextBoxAngar.TabIndex = 1;
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(14, 21);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(39, 13);
            this.labelPlace.TabIndex = 0;
            this.labelPlace.Text = "Место";
            // 
            // buttonSetFly
            // 
            this.buttonSetFly.Location = new System.Drawing.Point(617, 95);
            this.buttonSetFly.Name = "buttonSetFly";
            this.buttonSetFly.Size = new System.Drawing.Size(155, 31);
            this.buttonSetFly.TabIndex = 2;
            this.buttonSetFly.Text = "загнать самолет";
            this.buttonSetFly.UseVisualStyleBackColor = true;
            this.buttonSetFly.Click += new System.EventHandler(this.buttonSetFlyClick);
            // 
            // buttonSetSturmovic
            // 
            this.buttonSetSturmovic.Location = new System.Drawing.Point(617, 132);
            this.buttonSetSturmovic.Name = "buttonSetSturmovic";
            this.buttonSetSturmovic.Size = new System.Drawing.Size(155, 34);
            this.buttonSetSturmovic.TabIndex = 3;
            this.buttonSetSturmovic.Text = "загнать штурмовик";
            this.buttonSetSturmovic.UseVisualStyleBackColor = true;
            this.buttonSetSturmovic.Click += new System.EventHandler(this.buttonSetSturmovicClick);
            // 
            // listBoxLevels
            // 
            this.listBoxLevels.FormattingEnabled = true;
            this.listBoxLevels.Location = new System.Drawing.Point(618, 3);
            this.listBoxLevels.Name = "listBoxLevels";
            this.listBoxLevels.Size = new System.Drawing.Size(153, 82);
            this.listBoxLevels.TabIndex = 4;
            this.listBoxLevels.Click += new System.EventHandler(this.listBoxLevels_SelectedIndexChanged);
            // 
            // FormAngar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxLevels);
            this.Controls.Add(this.buttonSetSturmovic);
            this.Controls.Add(this.buttonSetFly);
            this.Controls.Add(this.groupBoxAngar);
            this.Controls.Add(this.pictureBoxAngar);
            this.Name = "FormAngar";
            this.Text = "Ангар";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAngar)).EndInit();
            this.groupBoxAngar.ResumeLayout(false);
            this.groupBoxAngar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeFly)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAngar;
        private System.Windows.Forms.GroupBox groupBoxAngar;
        private System.Windows.Forms.PictureBox pictureBoxTakeFly;
        private System.Windows.Forms.Button buttonTakeAirplane;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAngar;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.Button buttonSetFly;
        private System.Windows.Forms.Button buttonSetSturmovic;
        private System.Windows.Forms.ListBox listBoxLevels;
    }
}