namespace Santa
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.santa = new System.Windows.Forms.PictureBox();
            this.snowflake = new System.Windows.Forms.PictureBox();
            this.tree = new System.Windows.Forms.PictureBox();
            this.hut = new System.Windows.Forms.PictureBox();
            this.moon = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.santa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snowflake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            this.SuspendLayout();
            // 
            // santa
            // 
            this.santa.Image = ((System.Drawing.Image)(resources.GetObject("santa.Image")));
            this.santa.Location = new System.Drawing.Point(63, 196);
            this.santa.Name = "santa";
            this.santa.Size = new System.Drawing.Size(121, 86);
            this.santa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.santa.TabIndex = 0;
            this.santa.TabStop = false;
            this.santa.Click += new System.EventHandler(this.santa_Click);
            // 
            // snowflake
            // 
            this.snowflake.Image = ((System.Drawing.Image)(resources.GetObject("snowflake.Image")));
            this.snowflake.Location = new System.Drawing.Point(362, -1);
            this.snowflake.Name = "snowflake";
            this.snowflake.Size = new System.Drawing.Size(100, 87);
            this.snowflake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.snowflake.TabIndex = 1;
            this.snowflake.TabStop = false;
            // 
            // tree
            // 
            this.tree.Image = ((System.Drawing.Image)(resources.GetObject("tree.Image")));
            this.tree.Location = new System.Drawing.Point(468, 297);
            this.tree.Name = "tree";
            this.tree.Size = new System.Drawing.Size(100, 139);
            this.tree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tree.TabIndex = 2;
            this.tree.TabStop = false;
            // 
            // hut
            // 
            this.hut.Image = ((System.Drawing.Image)(resources.GetObject("hut.Image")));
            this.hut.Location = new System.Drawing.Point(362, 338);
            this.hut.Name = "hut";
            this.hut.Size = new System.Drawing.Size(100, 88);
            this.hut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hut.TabIndex = 3;
            this.hut.TabStop = false;
            // 
            // moon
            // 
            this.moon.Image = ((System.Drawing.Image)(resources.GetObject("moon.Image")));
            this.moon.Location = new System.Drawing.Point(-2, -1);
            this.moon.Name = "moon";
            this.moon.Size = new System.Drawing.Size(100, 72);
            this.moon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.moon.TabIndex = 4;
            this.moon.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.Location = new System.Drawing.Point(-2, 423);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(565, 74);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 5;
            this.ground.TabStop = false;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.scoreLabel.Location = new System.Drawing.Point(7, 66);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(91, 30);
            this.scoreLabel.TabIndex = 6;
            this.scoreLabel.Text = "Score: 0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.button1.Location = new System.Drawing.Point(221, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 77);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(564, 496);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.moon);
            this.Controls.Add(this.hut);
            this.Controls.Add(this.tree);
            this.Controls.Add(this.snowflake);
            this.Controls.Add(this.santa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.santa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snowflake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox santa;
        private System.Windows.Forms.PictureBox snowflake;
        private System.Windows.Forms.PictureBox tree;
        private System.Windows.Forms.PictureBox hut;
        private System.Windows.Forms.PictureBox moon;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}

