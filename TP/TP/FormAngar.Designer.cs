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
            this.listBoxLevels = new System.Windows.Forms.ListBox();
            this.buttonAddFly = new System.Windows.Forms.Button();
            this.menuStripAngar = new System.Windows.Forms.MenuStrip();
            this.menuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialogAngar = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogAngar = new System.Windows.Forms.SaveFileDialog();
            this.buttonSort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAngar)).BeginInit();
            this.groupBoxAngar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeFly)).BeginInit();
            this.menuStripAngar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxAngar
            // 
            this.pictureBoxAngar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxAngar.Location = new System.Drawing.Point(0, 24);
            this.pictureBoxAngar.Name = "pictureBoxAngar";
            this.pictureBoxAngar.Size = new System.Drawing.Size(605, 426);
            this.pictureBoxAngar.TabIndex = 0;
            this.pictureBoxAngar.TabStop = false;
            // 
            // groupBoxAngar
            // 
            this.groupBoxAngar.Controls.Add(this.pictureBoxTakeFly);
            this.groupBoxAngar.Controls.Add(this.buttonTakeAirplane);
            this.groupBoxAngar.Controls.Add(this.maskedTextBoxAngar);
            this.groupBoxAngar.Controls.Add(this.labelPlace);
            this.groupBoxAngar.Location = new System.Drawing.Point(611, 187);
            this.groupBoxAngar.Name = "groupBoxAngar";
            this.groupBoxAngar.Size = new System.Drawing.Size(188, 262);
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
            // listBoxLevels
            // 
            this.listBoxLevels.FormattingEnabled = true;
            this.listBoxLevels.Location = new System.Drawing.Point(617, 12);
            this.listBoxLevels.Name = "listBoxLevels";
            this.listBoxLevels.Size = new System.Drawing.Size(153, 82);
            this.listBoxLevels.TabIndex = 4;
            this.listBoxLevels.Click += new System.EventHandler(this.listBoxLevels_SelectedIndexChanged);
            // 
            // buttonAddFly
            // 
            this.buttonAddFly.Location = new System.Drawing.Point(621, 100);
            this.buttonAddFly.Name = "buttonAddFly";
            this.buttonAddFly.Size = new System.Drawing.Size(111, 31);
            this.buttonAddFly.TabIndex = 5;
            this.buttonAddFly.Text = "Заказать";
            this.buttonAddFly.UseVisualStyleBackColor = true;
            this.buttonAddFly.Click += new System.EventHandler(this.buttonSetFly_Click);
            // 
            // menuStripAngar
            // 
            this.menuStripAngar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStrip});
            this.menuStripAngar.Location = new System.Drawing.Point(0, 0);
            this.menuStripAngar.Name = "menuStripAngar";
            this.menuStripAngar.Size = new System.Drawing.Size(800, 24);
            this.menuStripAngar.TabIndex = 6;
            this.menuStripAngar.Text = "Файл";
            // 
            // menuStrip
            // 
            this.menuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(48, 20);
            this.menuStrip.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // openFileDialogAngar
            // 
            this.openFileDialogAngar.FileName = "openFileDialog";
            this.openFileDialogAngar.Filter = "txt file | *.txt";
            // 
            // saveFileDialogAngar
            // 
            this.saveFileDialogAngar.Filter = "txt file | *.txt";
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(625, 144);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(106, 28);
            this.buttonSort.TabIndex = 7;
            this.buttonSort.Text = "Сортировать";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // FormAngar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.buttonAddFly);
            this.Controls.Add(this.listBoxLevels);
            this.Controls.Add(this.groupBoxAngar);
            this.Controls.Add(this.pictureBoxAngar);
            this.Controls.Add(this.menuStripAngar);
            this.MainMenuStrip = this.menuStripAngar;
            this.Name = "FormAngar";
            this.Text = "Ангар";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAngar)).EndInit();
            this.groupBoxAngar.ResumeLayout(false);
            this.groupBoxAngar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeFly)).EndInit();
            this.menuStripAngar.ResumeLayout(false);
            this.menuStripAngar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAngar;
        private System.Windows.Forms.GroupBox groupBoxAngar;
        private System.Windows.Forms.PictureBox pictureBoxTakeFly;
        private System.Windows.Forms.Button buttonTakeAirplane;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAngar;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.ListBox listBoxLevels;
        private System.Windows.Forms.Button buttonAddFly;
        private System.Windows.Forms.MenuStrip menuStripAngar;
        private System.Windows.Forms.ToolStripMenuItem menuStrip;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialogAngar;
        private System.Windows.Forms.SaveFileDialog saveFileDialogAngar;
        private System.Windows.Forms.Button buttonSort;
    }
}