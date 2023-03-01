using System;
using System.Drawing;
using System.Windows.Forms;

class TraficLight : Form
{
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private System.ComponentModel.IContainer components;
    private Timer t;
    private bool lightning = false;
    private Button StopButton;

    private Label NorthRed;
    private Label NorthYellow;
    private Label NorthGreen;

    private int NorthSouthRed_t = 4; //red time count for north and south
    private int NorthSouthYellow_t = 2; //yellow time count
    private int NorthSouthGreen_t = 4; //green time count

    private Label SouthGreen;
    private Label SouthYellow;
    private Label SouthRed;

    private Label EastGreen;
    private Label EastYellow;
    private Label EastRed;

    private int EastWestRed_t = 4; // red time count for east and west
    private int EastWestGreen_t = 4;
    private int EastWestYellow_t = 2;

    private Label WestGreen;
    private Label WestYellow;
    private Label WestRed;

    // right turn labels, buttons and bools
    private Label SouthRightGreen;
    private Label NorthRightGreen;
    private Label EastRightGreen;
    private Label WestRightGreen;

    bool South_Right_turn = false;
    bool East_Right_turn = false;
    bool North_Right_turn = false;
    bool West_Right_turn = false;

    private Button West_right;
    private Button North_Right;
    private Button East_Right;
    private Button South_right;

    public static void Main()
    {
        Application.EnableVisualStyles();
        Application.Run(new TraficLight());
    }
    public TraficLight()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        // all objects and they characteristics 
        this.components = new System.ComponentModel.Container();
        this.StopButton = new System.Windows.Forms.Button();
        this.label1 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.label3 = new System.Windows.Forms.Label();
        this.label4 = new System.Windows.Forms.Label();
        this.t = new System.Windows.Forms.Timer(this.components);
        this.NorthRed = new System.Windows.Forms.Label();
        this.NorthYellow = new System.Windows.Forms.Label();
        this.NorthGreen = new System.Windows.Forms.Label();
        this.SouthGreen = new System.Windows.Forms.Label();
        this.SouthYellow = new System.Windows.Forms.Label();
        this.SouthRed = new System.Windows.Forms.Label();
        this.EastGreen = new System.Windows.Forms.Label();
        this.EastYellow = new System.Windows.Forms.Label();
        this.EastRed = new System.Windows.Forms.Label();
        this.WestGreen = new System.Windows.Forms.Label();
        this.WestYellow = new System.Windows.Forms.Label();
        this.WestRed = new System.Windows.Forms.Label();
        this.South_right = new System.Windows.Forms.Button();
        this.SouthRightGreen = new System.Windows.Forms.Label();
        this.WestRightGreen = new System.Windows.Forms.Label();
        this.West_right = new System.Windows.Forms.Button();
        this.NorthRightGreen = new System.Windows.Forms.Label();
        this.North_Right = new System.Windows.Forms.Button();
        this.EastRightGreen = new System.Windows.Forms.Label();
        this.East_Right = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // StopButton
        // 
        this.StopButton.Location = new System.Drawing.Point(38, 403);
        this.StopButton.Name = "StopButton";
        this.StopButton.Size = new System.Drawing.Size(76, 45);
        this.StopButton.TabIndex = 0;
        this.StopButton.Text = "Stop";
        this.StopButton.UseVisualStyleBackColor = true;
        this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label1.Location = new System.Drawing.Point(477, 134);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(43, 20);
        this.label1.TabIndex = 13;
        this.label1.Text = "East";
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label2.Location = new System.Drawing.Point(281, 31);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(50, 20);
        this.label2.TabIndex = 13;
        this.label2.Text = "North";
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label3.Location = new System.Drawing.Point(279, 290);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(52, 20);
        this.label3.TabIndex = 14;
        this.label3.Text = "South";
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label4.Location = new System.Drawing.Point(80, 134);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(48, 20);
        this.label4.TabIndex = 15;
        this.label4.Text = "West";
        // 
        // timer t
        // 
        this.t.Enabled = true;
        this.t.Interval = 1000;
        this.t.Tick += new System.EventHandler(this.t_Tick);
        // 
        // NorthRed
        // 
        this.NorthRed.AutoSize = true;
        this.NorthRed.BackColor = System.Drawing.Color.Red;
        this.NorthRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.NorthRed.Location = new System.Drawing.Point(299, 60);
        this.NorthRed.Name = "NorthRed";
        this.NorthRed.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
        this.NorthRed.Size = new System.Drawing.Size(18, 18);
        this.NorthRed.TabIndex = 16;
        // 
        // NorthYellow
        // 
        this.NorthYellow.AutoSize = true;
        this.NorthYellow.BackColor = System.Drawing.Color.White;
        this.NorthYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.NorthYellow.Location = new System.Drawing.Point(299, 95);
        this.NorthYellow.Name = "NorthYellow";
        this.NorthYellow.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
        this.NorthYellow.Size = new System.Drawing.Size(18, 18);
        this.NorthYellow.TabIndex = 17;
        // 
        // NorthGreen
        // 
        this.NorthGreen.AutoSize = true;
        this.NorthGreen.BackColor = System.Drawing.Color.White;
        this.NorthGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.NorthGreen.Location = new System.Drawing.Point(299, 134);
        this.NorthGreen.Name = "NorthGreen";
        this.NorthGreen.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
        this.NorthGreen.Size = new System.Drawing.Size(18, 18);
        this.NorthGreen.TabIndex = 18;
        // 
        // SouthGreen
        // 
        this.SouthGreen.AutoSize = true;
        this.SouthGreen.BackColor = System.Drawing.Color.White;
        this.SouthGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.SouthGreen.Location = new System.Drawing.Point(299, 409);
        this.SouthGreen.Name = "SouthGreen";
        this.SouthGreen.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
        this.SouthGreen.Size = new System.Drawing.Size(18, 18);
        this.SouthGreen.TabIndex = 21;
        // 
        // SouthYellow
        // 
        this.SouthYellow.AutoSize = true;
        this.SouthYellow.BackColor = System.Drawing.Color.White;
        this.SouthYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.SouthYellow.Location = new System.Drawing.Point(299, 370);
        this.SouthYellow.Name = "SouthYellow";
        this.SouthYellow.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
        this.SouthYellow.Size = new System.Drawing.Size(18, 18);
        this.SouthYellow.TabIndex = 20;
        // 
        // SouthRed
        // 
        this.SouthRed.AutoSize = true;
        this.SouthRed.BackColor = System.Drawing.Color.Red;
        this.SouthRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.SouthRed.Location = new System.Drawing.Point(299, 335);
        this.SouthRed.Name = "SouthRed";
        this.SouthRed.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
        this.SouthRed.Size = new System.Drawing.Size(18, 18);
        this.SouthRed.TabIndex = 19;
        // 
        // EastGreen
        // 
        this.EastGreen.AutoSize = true;
        this.EastGreen.BackColor = System.Drawing.Color.ForestGreen;
        this.EastGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.EastGreen.Location = new System.Drawing.Point(502, 262);
        this.EastGreen.Name = "EastGreen";
        this.EastGreen.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
        this.EastGreen.Size = new System.Drawing.Size(18, 18);
        this.EastGreen.TabIndex = 24;
        // 
        // EastYellow
        // 
        this.EastYellow.AutoSize = true;
        this.EastYellow.BackColor = System.Drawing.Color.White;
        this.EastYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.EastYellow.Location = new System.Drawing.Point(502, 223);
        this.EastYellow.Name = "EastYellow";
        this.EastYellow.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
        this.EastYellow.Size = new System.Drawing.Size(18, 18);
        this.EastYellow.TabIndex = 23;
        // 
        // EastRed
        // 
        this.EastRed.AutoSize = true;
        this.EastRed.BackColor = System.Drawing.Color.White;
        this.EastRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.EastRed.Location = new System.Drawing.Point(502, 188);
        this.EastRed.Name = "EastRed";
        this.EastRed.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
        this.EastRed.Size = new System.Drawing.Size(18, 18);
        this.EastRed.TabIndex = 22;
        // 
        // WestGreen
        // 
        this.WestGreen.AutoSize = true;
        this.WestGreen.BackColor = System.Drawing.Color.ForestGreen;
        this.WestGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.WestGreen.Location = new System.Drawing.Point(96, 262);
        this.WestGreen.Name = "WestGreen";
        this.WestGreen.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
        this.WestGreen.Size = new System.Drawing.Size(18, 18);
        this.WestGreen.TabIndex = 27;
        // 
        // WestYellow
        // 
        this.WestYellow.AutoSize = true;
        this.WestYellow.BackColor = System.Drawing.Color.White;
        this.WestYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.WestYellow.Location = new System.Drawing.Point(96, 223);
        this.WestYellow.Name = "WestYellow";
        this.WestYellow.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
        this.WestYellow.Size = new System.Drawing.Size(18, 18);
        this.WestYellow.TabIndex = 26;
        // 
        // WestRed
        // 
        this.WestRed.AutoSize = true;
        this.WestRed.BackColor = System.Drawing.Color.White;
        this.WestRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.WestRed.Location = new System.Drawing.Point(96, 188);
        this.WestRed.Name = "WestRed";
        this.WestRed.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
        this.WestRed.Size = new System.Drawing.Size(18, 18);
        this.WestRed.TabIndex = 25;
        // 
        // South_right
        // 
        this.South_right.Location = new System.Drawing.Point(344, 436);
        this.South_right.Name = "South_right";
        this.South_right.Size = new System.Drawing.Size(74, 27);
        this.South_right.TabIndex = 28;
        this.South_right.Text = "Right turn";
        this.South_right.UseVisualStyleBackColor = true;
        this.South_right.Click += new System.EventHandler(this.South_right_Click);
        // 
        // SouthRightGreen
        // 
        this.SouthRightGreen.AutoSize = true;
        this.SouthRightGreen.BackColor = System.Drawing.Color.White;
        this.SouthRightGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.SouthRightGreen.Location = new System.Drawing.Point(344, 409);
        this.SouthRightGreen.Name = "SouthRightGreen";
        this.SouthRightGreen.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
        this.SouthRightGreen.Size = new System.Drawing.Size(18, 18);
        this.SouthRightGreen.TabIndex = 30;
        // 
        // WestRightGreen
        // 
        this.WestRightGreen.AutoSize = true;
        this.WestRightGreen.BackColor = System.Drawing.Color.White;
        this.WestRightGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.WestRightGreen.Location = new System.Drawing.Point(134, 263);
        this.WestRightGreen.Name = "WestRightGreen";
        this.WestRightGreen.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
        this.WestRightGreen.Size = new System.Drawing.Size(18, 18);
        this.WestRightGreen.TabIndex = 33;
        // 
        // West_right
        // 
        this.West_right.Location = new System.Drawing.Point(134, 290);
        this.West_right.Name = "West_right";
        this.West_right.Size = new System.Drawing.Size(74, 27);
        this.West_right.TabIndex = 31;
        this.West_right.Text = "Right turn";
        this.West_right.UseVisualStyleBackColor = true;
        this.West_right.Click += new System.EventHandler(this.West_right_Click);
        // 
        // NorthRightGreen
        // 
        this.NorthRightGreen.AutoSize = true;
        this.NorthRightGreen.BackColor = System.Drawing.Color.White;
        this.NorthRightGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.NorthRightGreen.Location = new System.Drawing.Point(334, 137);
        this.NorthRightGreen.Name = "NorthRightGreen";
        this.NorthRightGreen.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
        this.NorthRightGreen.Size = new System.Drawing.Size(18, 18);
        this.NorthRightGreen.TabIndex = 36;
        // 
        // North_Right
        // 
        this.North_Right.Location = new System.Drawing.Point(334, 164);
        this.North_Right.Name = "North_Right";
        this.North_Right.Size = new System.Drawing.Size(74, 27);
        this.North_Right.TabIndex = 34;
        this.North_Right.Text = "Right turn";
        this.North_Right.UseVisualStyleBackColor = true;
        this.North_Right.Click += new System.EventHandler(this.North_Right_Click);
        // 
        // EastRightGreen
        // 
        this.EastRightGreen.AutoSize = true;
        this.EastRightGreen.BackColor = System.Drawing.Color.White;
        this.EastRightGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.EastRightGreen.Location = new System.Drawing.Point(540, 263);
        this.EastRightGreen.Name = "EastRightGreen";
        this.EastRightGreen.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
        this.EastRightGreen.Size = new System.Drawing.Size(18, 18);
        this.EastRightGreen.TabIndex = 39;
        // 
        // East_Right
        // 
        this.East_Right.Location = new System.Drawing.Point(540, 290);
        this.East_Right.Name = "East_Right";
        this.East_Right.Size = new System.Drawing.Size(74, 27);
        this.East_Right.TabIndex = 37;
        this.East_Right.Text = "Right turn";
        this.East_Right.UseVisualStyleBackColor = true;
        this.East_Right.Click += new System.EventHandler(this.East_Right_Click);
        // 
        // TraficLight
        // adding objcets to form
        // 
        this.ClientSize = new System.Drawing.Size(674, 525);
        this.Controls.Add(this.EastRightGreen);
        this.Controls.Add(this.East_Right);
        this.Controls.Add(this.NorthRightGreen);
        this.Controls.Add(this.North_Right);
        this.Controls.Add(this.WestRightGreen);
        this.Controls.Add(this.West_right);
        this.Controls.Add(this.SouthRightGreen);
        this.Controls.Add(this.South_right);
        this.Controls.Add(this.WestGreen);
        this.Controls.Add(this.WestYellow);
        this.Controls.Add(this.WestRed);
        this.Controls.Add(this.EastGreen);
        this.Controls.Add(this.EastYellow);
        this.Controls.Add(this.EastRed);
        this.Controls.Add(this.SouthGreen);
        this.Controls.Add(this.SouthYellow);
        this.Controls.Add(this.SouthRed);
        this.Controls.Add(this.NorthGreen);
        this.Controls.Add(this.NorthYellow);
        this.Controls.Add(this.NorthRed);
        this.Controls.Add(this.StopButton);
        this.Controls.Add(this.label1);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.label3);
        this.Controls.Add(this.label4);
        this.Name = "TraficLight";
        this.ResumeLayout(false);
        this.PerformLayout();

    }



    private void t_Tick(object sender, EventArgs e) //on timer event every second
    {
        // ---------------- Lihtning logic -------------
        if (this.lightning) //if lightning, blink yellow
        {
            if (this.NorthRed.BackColor == Color.White)
            // set all lights depending on north Red light, since syncronized
            {
                this.NorthRed.BackColor = Color.Yellow; //blink yellow
                this.NorthYellow.BackColor = Color.Yellow;
                this.NorthGreen.BackColor = Color.Yellow;

                this.SouthRed.BackColor = Color.Yellow;
                this.SouthYellow.BackColor = Color.Yellow;
                this.SouthGreen.BackColor = Color.Yellow;

                this.EastRed.BackColor = Color.Yellow;
                this.EastYellow.BackColor = Color.Yellow;
                this.EastGreen.BackColor = Color.Yellow;

                this.WestRed.BackColor = Color.Yellow;
                this.WestYellow.BackColor = Color.Yellow;
                this.WestGreen.BackColor = Color.Yellow;
            }
            else if (this.NorthRed.BackColor == Color.Yellow)
            // set all lights depending on north Red light, since syncronized
            {
                this.NorthRed.BackColor = Color.White; // blink white
                this.NorthYellow.BackColor = Color.White;
                this.NorthGreen.BackColor = Color.White;

                this.SouthRed.BackColor = Color.White;
                this.SouthYellow.BackColor = Color.White;
                this.SouthGreen.BackColor = Color.White;

                this.EastRed.BackColor = Color.White;
                this.EastYellow.BackColor = Color.White;
                this.EastGreen.BackColor = Color.White;

                this.WestRed.BackColor = Color.White;
                this.WestYellow.BackColor = Color.White;
                this.WestGreen.BackColor = Color.White;
            }
        }

        if (!this.lightning) //if not lightning
        {
            //---------- North / South logic --------------

            // transition North/South Red -> Red + Yellow
            if (this.NorthRed.BackColor == Color.Red && this.NorthYellow.BackColor == Color.White)
            {
                if (this.NorthSouthRed_t > 0) //if time left on red timer
                {
                    this.NorthSouthRed_t -= 1; //decrease
                }
                else //if not
                {
                    if (South_Right_turn) // green signal for right turn
                    {
                        this.SouthRightGreen.BackColor = Color.ForestGreen;
                        South_Right_turn = false;
                        if (North_Right_turn) //if green signal for both right turn
                        {
                            this.NorthRightGreen.BackColor = Color.ForestGreen;
                            North_Right_turn = false;
                        }
                    }
                    else if (North_Right_turn) // green signal for right 
                    {
                        this.NorthRightGreen.BackColor = Color.ForestGreen;
                        North_Right_turn = false;
                    }
                    this.NorthYellow.BackColor = Color.Yellow; //change to yellow 
                    this.SouthYellow.BackColor = Color.Yellow;
                    this.NorthSouthYellow_t = 2; //start new timer
                }

            }
            // transition North/South Red + Yellow -> Green
            else if (this.NorthYellow.BackColor == Color.Yellow && this.NorthRed.BackColor == Color.Red) //if red and yellow, change to green
            {
                if (this.NorthSouthYellow_t > 0) { this.NorthSouthYellow_t -= 1; }
                else
                {
                    if (this.SouthRightGreen.BackColor == Color.ForestGreen) //if right turn greens on
                    {
                        this.SouthRightGreen.BackColor = Color.White; //deactivate 
                        if (this.NorthRightGreen.BackColor == Color.ForestGreen) //if BOth right turn greens on
                        {
                            this.NorthRightGreen.BackColor = Color.White; //deactivate
                        }
                    }
                    else if (this.NorthRightGreen.BackColor == Color.ForestGreen) //if right turn greens on
                    {
                        this.NorthRightGreen.BackColor = Color.White; // deactivate
                    }
                    this.NorthYellow.BackColor = Color.White; // change to green 
                    this.NorthRed.BackColor = Color.White;
                    this.NorthGreen.BackColor = Color.ForestGreen;
                    this.SouthYellow.BackColor = Color.White;
                    this.SouthRed.BackColor = Color.White;
                    this.SouthGreen.BackColor = Color.ForestGreen;
                    this.NorthSouthGreen_t = 4; // start new timer
                }

            }
            // transition North/South Green -> Yellow
            else if (this.NorthGreen.BackColor == Color.ForestGreen) //if green, change to yellow
            { //if timer left
                if (this.NorthSouthGreen_t > 0) { this.NorthSouthGreen_t -= 1; } // deacrease timer
                else //if no timer left
                {
                    this.NorthGreen.BackColor = Color.White; //change colors
                    this.NorthYellow.BackColor = Color.Yellow;
                    this.SouthGreen.BackColor = Color.White;
                    this.SouthYellow.BackColor = Color.Yellow;
                    this.NorthSouthYellow_t = 2; //set new timer
                }

            }
            // transition North/South yellow -> red
            else if (this.NorthYellow.BackColor == Color.Yellow && this.NorthRed.BackColor == Color.White) //if yellow and not red
            { // if timer left
                if (this.NorthSouthYellow_t > 0) { this.NorthSouthYellow_t -= 1; } // decrease timer
                else //if no timer left
                {
                    this.NorthYellow.BackColor = Color.White; //change colors
                    this.NorthRed.BackColor = Color.Red;
                    this.SouthYellow.BackColor = Color.White;
                    this.SouthRed.BackColor = Color.Red;
                    this.NorthSouthRed_t = 4; //start next timer
                }

            }


            // ----------- east /west logic -----------

            // transition East/West Red -> Red + Yellow
            if (this.EastRed.BackColor == Color.Red && this.EastYellow.BackColor == Color.White)
            {
                if (this.EastWestRed_t > 0) //if time left on red timer
                {
                    this.EastWestRed_t -= 1; //decrease
                }
                else //if not
                {
                    if (West_Right_turn) // green signal for right turn
                    {
                        this.WestRightGreen.BackColor = Color.ForestGreen;
                        West_Right_turn = false;
                        if (East_Right_turn) // green signal for Both right turn
                        {
                            this.EastRightGreen.BackColor = Color.ForestGreen;
                            East_Right_turn = false;
                        }
                    }
                    else if (East_Right_turn) // green signal for right turn
                    {
                        this.EastRightGreen.BackColor = Color.ForestGreen;
                        East_Right_turn = false;
                    }
                    this.EastYellow.BackColor = Color.Yellow; //change to yellow and start timer
                    this.WestYellow.BackColor = Color.Yellow;
                    this.EastWestYellow_t = 2;
                }

            }
            // transition East/West Red + Yellow -> Green
            else if (this.EastYellow.BackColor == Color.Yellow && this.EastRed.BackColor == Color.Red) //if red and yellow, change to green
            {
                if (this.EastWestYellow_t > 0) { this.EastWestYellow_t -= 1; }// if time left on timer decrease timer
                else // if timer out
                {
                    if (this.WestRightGreen.BackColor == Color.ForestGreen) //if right turn greens on
                    {
                        this.WestRightGreen.BackColor = Color.White; // deactivate
                        if (this.EastRightGreen.BackColor == Color.ForestGreen)//if Both right turn greens on
                        {
                            this.EastRightGreen.BackColor = Color.White; // deactivate
                        }
                    }
                    else if (this.EastRightGreen.BackColor == Color.ForestGreen)//if right turn greens on
                    {
                        this.EastRightGreen.BackColor = Color.White; // deactivate
                    }
                    this.EastYellow.BackColor = Color.White; // change colors
                    this.EastRed.BackColor = Color.White;
                    this.EastGreen.BackColor = Color.ForestGreen;
                    this.WestYellow.BackColor = Color.White;
                    this.WestRed.BackColor = Color.White;
                    this.WestGreen.BackColor = Color.ForestGreen;
                    this.EastWestGreen_t = 4; // start next timer
                }

            }
            //transition East/West green -> yellow
            else if (this.EastGreen.BackColor == Color.ForestGreen) //if green, change to yellow
            {
                if (this.EastWestGreen_t > 0) { this.EastWestGreen_t -= 1; } // if time left on timer decrease timer
                else // if timer out
                {
                    this.EastGreen.BackColor = Color.White; //change colors
                    this.EastYellow.BackColor = Color.Yellow;
                    this.WestGreen.BackColor = Color.White;
                    this.WestYellow.BackColor = Color.Yellow;
                    this.EastWestYellow_t = 2; // start next timer
                }

            }
            //transition East/West Yellow -> Red
            else if (this.EastYellow.BackColor == Color.Yellow && this.EastRed.BackColor == Color.White)
            {
                if (this.EastWestYellow_t > 0) { this.EastWestYellow_t -= 1; } //if time left on timer decrease timer
                else //if timer out
                {
                    this.EastYellow.BackColor = Color.White; //change colors
                    this.EastRed.BackColor = Color.Red;
                    this.WestYellow.BackColor = Color.White;
                    this.WestRed.BackColor = Color.Red;
                    this.EastWestRed_t = 4; //set new timer
                }

            }
        }


    } // ----------- Buttons -------------

    private void South_right_Click(object sender, EventArgs e)
    {
        South_Right_turn = true;
    }

    private void West_right_Click(object sender, EventArgs e)
    {
        West_Right_turn = true;
    }

    private void North_Right_Click(object sender, EventArgs e)
    {
        North_Right_turn = true;
    }

    private void East_Right_Click(object sender, EventArgs e)
    {
        East_Right_turn = true;
    }

    private void StopButton_Click(object sender, EventArgs e) // stop button
    {
        if (!this.lightning)  // if button clicked and previously not lightning
        {
            this.lightning = true; // activate lightning and start warning lights
            this.NorthRed.BackColor = Color.Yellow;
            this.NorthYellow.BackColor = Color.Yellow;
            this.NorthGreen.BackColor = Color.Yellow;

            this.SouthRed.BackColor = Color.Yellow;
            this.SouthYellow.BackColor = Color.Yellow;
            this.SouthGreen.BackColor = Color.Yellow;

            this.EastRed.BackColor = Color.Yellow;
            this.EastYellow.BackColor = Color.Yellow;
            this.EastGreen.BackColor = Color.Yellow;

            this.WestRed.BackColor = Color.Yellow;
            this.WestYellow.BackColor = Color.Yellow;
            this.WestGreen.BackColor = Color.Yellow;
        }

        //change back after lightning is done
        else if (this.lightning)  // if button clicked and previously lightning
        {
            this.lightning = false; // deactivate lightning and start traffic
            this.NorthRed.BackColor = Color.Red;
            this.NorthYellow.BackColor = Color.White;
            this.NorthGreen.BackColor = Color.White;

            this.SouthRed.BackColor = Color.Red;
            this.SouthYellow.BackColor = Color.White;
            this.SouthGreen.BackColor = Color.White;

            this.EastRed.BackColor = Color.White;
            this.EastYellow.BackColor = Color.White;
            this.EastGreen.BackColor = Color.ForestGreen;

            this.WestRed.BackColor = Color.White;
            this.WestYellow.BackColor = Color.White;
            this.WestGreen.BackColor = Color.ForestGreen;
        }
    }
}