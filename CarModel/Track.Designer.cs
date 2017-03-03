namespace CarModel
{
    partial class Track
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.handbrake = new System.Windows.Forms.Button();
            this.straightbutton = new System.Windows.Forms.Button();
            this.OffEngine = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelforpipe = new System.Windows.Forms.Label();
            this.GoButton = new System.Windows.Forms.Button();
            this.ChangeSpeed = new System.Windows.Forms.ComboBox();
            this.BrakeButton = new System.Windows.Forms.Button();
            this.ClutchButton = new System.Windows.Forms.Button();
            this.rightturn = new System.Windows.Forms.Button();
            this.leftturn = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.CarMod = new System.Windows.Forms.Button();
            this.timerForPipe = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PetrolAdd = new System.Windows.Forms.Button();
            this.numericPetrol = new System.Windows.Forms.NumericUpDown();
            this.petrollable = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.turnlabelsignal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPetrol)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.handbrake);
            this.groupBox1.Controls.Add(this.straightbutton);
            this.groupBox1.Controls.Add(this.OffEngine);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.GoButton);
            this.groupBox1.Controls.Add(this.ChangeSpeed);
            this.groupBox1.Controls.Add(this.BrakeButton);
            this.groupBox1.Controls.Add(this.ClutchButton);
            this.groupBox1.Controls.Add(this.rightturn);
            this.groupBox1.Controls.Add(this.leftturn);
            this.groupBox1.Controls.Add(this.StartButton);
            this.groupBox1.Location = new System.Drawing.Point(779, 413);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 153);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Управление";
            // 
            // handbrake
            // 
            this.handbrake.Location = new System.Drawing.Point(87, 49);
            this.handbrake.Name = "handbrake";
            this.handbrake.Size = new System.Drawing.Size(45, 71);
            this.handbrake.TabIndex = 10;
            this.handbrake.Text = "HandBrake";
            this.handbrake.UseVisualStyleBackColor = true;
            this.handbrake.Click += new System.EventHandler(this.handbrake_Click);
            // 
            // straightbutton
            // 
            this.straightbutton.Location = new System.Drawing.Point(138, 93);
            this.straightbutton.Name = "straightbutton";
            this.straightbutton.Size = new System.Drawing.Size(56, 23);
            this.straightbutton.TabIndex = 9;
            this.straightbutton.Text = "straight";
            this.straightbutton.UseVisualStyleBackColor = true;
            this.straightbutton.Click += new System.EventHandler(this.straightbutton_Click);
            // 
            // OffEngine
            // 
            this.OffEngine.Location = new System.Drawing.Point(138, 42);
            this.OffEngine.Name = "OffEngine";
            this.OffEngine.Size = new System.Drawing.Size(56, 23);
            this.OffEngine.TabIndex = 8;
            this.OffEngine.Text = "Off";
            this.OffEngine.UseVisualStyleBackColor = true;
            this.OffEngine.Click += new System.EventHandler(this.OffEngine_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelforpipe);
            this.panel1.Location = new System.Drawing.Point(7, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 20);
            this.panel1.TabIndex = 2;
            // 
            // labelforpipe
            // 
            this.labelforpipe.AutoSize = true;
            this.labelforpipe.Location = new System.Drawing.Point(3, 5);
            this.labelforpipe.Name = "labelforpipe";
            this.labelforpipe.Size = new System.Drawing.Size(0, 13);
            this.labelforpipe.TabIndex = 2;
            // 
            // GoButton
            // 
            this.GoButton.Enabled = false;
            this.GoButton.Location = new System.Drawing.Point(7, 19);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(75, 23);
            this.GoButton.TabIndex = 7;
            this.GoButton.Text = "Gas";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // ChangeSpeed
            // 
            this.ChangeSpeed.FormattingEnabled = true;
            this.ChangeSpeed.Location = new System.Drawing.Point(88, 19);
            this.ChangeSpeed.Name = "ChangeSpeed";
            this.ChangeSpeed.Size = new System.Drawing.Size(44, 21);
            this.ChangeSpeed.TabIndex = 6;
            this.ChangeSpeed.Text = "N";
            this.ChangeSpeed.SelectedIndexChanged += new System.EventHandler(this.ChangeSpeed_SelectedIndexChanged);
            // 
            // BrakeButton
            // 
            this.BrakeButton.Enabled = false;
            this.BrakeButton.Location = new System.Drawing.Point(7, 78);
            this.BrakeButton.Name = "BrakeButton";
            this.BrakeButton.Size = new System.Drawing.Size(75, 23);
            this.BrakeButton.TabIndex = 5;
            this.BrakeButton.Text = "Brake";
            this.BrakeButton.UseVisualStyleBackColor = true;
            this.BrakeButton.Click += new System.EventHandler(this.BrakeButton_Click);
            // 
            // ClutchButton
            // 
            this.ClutchButton.Location = new System.Drawing.Point(7, 49);
            this.ClutchButton.Name = "ClutchButton";
            this.ClutchButton.Size = new System.Drawing.Size(75, 23);
            this.ClutchButton.TabIndex = 4;
            this.ClutchButton.Text = "Clutch";
            this.ClutchButton.UseVisualStyleBackColor = true;
            this.ClutchButton.Click += new System.EventHandler(this.ClutchButton_Click);
            // 
            // rightturn
            // 
            this.rightturn.Location = new System.Drawing.Point(165, 71);
            this.rightturn.Name = "rightturn";
            this.rightturn.Size = new System.Drawing.Size(29, 23);
            this.rightturn.TabIndex = 3;
            this.rightturn.Text = "R";
            this.rightturn.UseVisualStyleBackColor = true;
            this.rightturn.Click += new System.EventHandler(this.rightturn_Click);
            // 
            // leftturn
            // 
            this.leftturn.Location = new System.Drawing.Point(138, 71);
            this.leftturn.Name = "leftturn";
            this.leftturn.Size = new System.Drawing.Size(29, 23);
            this.leftturn.TabIndex = 2;
            this.leftturn.Text = "L";
            this.leftturn.UseVisualStyleBackColor = true;
            this.leftturn.Click += new System.EventHandler(this.leftturn_Click);
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.DarkRed;
            this.StartButton.Location = new System.Drawing.Point(138, 17);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(56, 23);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "On";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // CarMod
            // 
            this.CarMod.Image = global::CarModel.Properties.Resources.carimage;
            this.CarMod.Location = new System.Drawing.Point(436, 299);
            this.CarMod.Name = "CarMod";
            this.CarMod.Size = new System.Drawing.Size(50, 30);
            this.CarMod.TabIndex = 1;
            this.CarMod.UseVisualStyleBackColor = true;
            // 
            // timerForPipe
            // 
            this.timerForPipe.Tick += new System.EventHandler(this.timerForRUNrUN_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.PetrolAdd);
            this.panel2.Controls.Add(this.numericPetrol);
            this.panel2.Controls.Add(this.petrollable);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.turnlabelsignal);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(779, 572);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 45);
            this.panel2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Скорость:";
            // 
            // PetrolAdd
            // 
            this.PetrolAdd.Location = new System.Drawing.Point(165, 24);
            this.PetrolAdd.Name = "PetrolAdd";
            this.PetrolAdd.Size = new System.Drawing.Size(32, 21);
            this.PetrolAdd.TabIndex = 5;
            this.PetrolAdd.Text = "Ok";
            this.PetrolAdd.UseVisualStyleBackColor = true;
            this.PetrolAdd.Click += new System.EventHandler(this.PetrolAdd_Click);
            // 
            // numericPetrol
            // 
            this.numericPetrol.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericPetrol.Location = new System.Drawing.Point(165, 4);
            this.numericPetrol.Name = "numericPetrol";
            this.numericPetrol.Size = new System.Drawing.Size(32, 20);
            this.numericPetrol.TabIndex = 4;
            this.numericPetrol.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // petrollable
            // 
            this.petrollable.AutoSize = true;
            this.petrollable.Location = new System.Drawing.Point(78, 15);
            this.petrollable.Name = "petrollable";
            this.petrollable.Size = new System.Drawing.Size(0, 13);
            this.petrollable.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Топливо:";
            // 
            // turnlabelsignal
            // 
            this.turnlabelsignal.AutoSize = true;
            this.turnlabelsignal.Location = new System.Drawing.Point(78, 4);
            this.turnlabelsignal.Name = "turnlabelsignal";
            this.turnlabelsignal.Size = new System.Drawing.Size(0, 13);
            this.turnlabelsignal.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поворотник:";
            // 
            // Track
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 629);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.CarMod);
            this.Controls.Add(this.groupBox1);
            this.Name = "Track";
            this.Text = "Track";
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPetrol)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button BrakeButton;
        private System.Windows.Forms.Button ClutchButton;
        private System.Windows.Forms.Button rightturn;
        private System.Windows.Forms.Button leftturn;
        private System.Windows.Forms.ComboBox ChangeSpeed;
        private System.Windows.Forms.Button CarMod;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.Label labelforpipe;
        private System.Windows.Forms.Timer timerForPipe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button OffEngine;
        private System.Windows.Forms.Button straightbutton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label turnlabelsignal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label petrollable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PetrolAdd;
        private System.Windows.Forms.NumericUpDown numericPetrol;
        private System.Windows.Forms.Button handbrake;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}