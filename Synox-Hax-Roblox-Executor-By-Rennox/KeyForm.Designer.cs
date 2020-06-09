namespace Synox_Hax_Roblox_Executor_By_Rennox
{
    partial class KeyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeyForm));
            this.DRAG_PANEL = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HEAD = new System.Windows.Forms.Label();
            this.MINIMIZE_BUTTON = new System.Windows.Forms.Button();
            this.EXIT_BUTTON = new System.Windows.Forms.Button();
            this.KEY_BOX = new System.Windows.Forms.TextBox();
            this.ENTER = new System.Windows.Forms.Button();
            this.DRAG_SYS = new JDragControl.JDragControl(this.components);
            this.GET_KEY_LINK = new System.Windows.Forms.LinkLabel();
            this.DRAG_PANEL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DRAG_PANEL
            // 
            this.DRAG_PANEL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.DRAG_PANEL.Controls.Add(this.pictureBox1);
            this.DRAG_PANEL.Controls.Add(this.HEAD);
            this.DRAG_PANEL.Controls.Add(this.MINIMIZE_BUTTON);
            this.DRAG_PANEL.Controls.Add(this.EXIT_BUTTON);
            this.DRAG_PANEL.Location = new System.Drawing.Point(0, -3);
            this.DRAG_PANEL.Name = "DRAG_PANEL";
            this.DRAG_PANEL.Size = new System.Drawing.Size(329, 38);
            this.DRAG_PANEL.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Synox_Hax_Roblox_Executor_By_Rennox.Properties.Resources.TestSynoxLogoTransparent_1_1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 38);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // HEAD
            // 
            this.HEAD.AutoSize = true;
            this.HEAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.HEAD.ForeColor = System.Drawing.Color.White;
            this.HEAD.Location = new System.Drawing.Point(39, 0);
            this.HEAD.Name = "HEAD";
            this.HEAD.Size = new System.Drawing.Size(73, 37);
            this.HEAD.TabIndex = 2;
            this.HEAD.Text = "Key";
            // 
            // MINIMIZE_BUTTON
            // 
            this.MINIMIZE_BUTTON.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.MINIMIZE_BUTTON.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MINIMIZE_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MINIMIZE_BUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MINIMIZE_BUTTON.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.MINIMIZE_BUTTON.Location = new System.Drawing.Point(248, 3);
            this.MINIMIZE_BUTTON.Name = "MINIMIZE_BUTTON";
            this.MINIMIZE_BUTTON.Size = new System.Drawing.Size(36, 32);
            this.MINIMIZE_BUTTON.TabIndex = 1;
            this.MINIMIZE_BUTTON.Tag = "";
            this.MINIMIZE_BUTTON.Text = "-";
            this.MINIMIZE_BUTTON.UseVisualStyleBackColor = true;
            this.MINIMIZE_BUTTON.Click += new System.EventHandler(this.MINIMIZE_BUTTON_Click);
            // 
            // EXIT_BUTTON
            // 
            this.EXIT_BUTTON.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.EXIT_BUTTON.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.EXIT_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EXIT_BUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EXIT_BUTTON.ForeColor = System.Drawing.Color.Red;
            this.EXIT_BUTTON.Location = new System.Drawing.Point(290, 3);
            this.EXIT_BUTTON.Name = "EXIT_BUTTON";
            this.EXIT_BUTTON.Size = new System.Drawing.Size(36, 32);
            this.EXIT_BUTTON.TabIndex = 0;
            this.EXIT_BUTTON.Tag = "";
            this.EXIT_BUTTON.Text = "X";
            this.EXIT_BUTTON.UseVisualStyleBackColor = true;
            this.EXIT_BUTTON.Click += new System.EventHandler(this.EXIT_BUTTON_Click);
            // 
            // KEY_BOX
            // 
            this.KEY_BOX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.KEY_BOX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.KEY_BOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KEY_BOX.ForeColor = System.Drawing.Color.White;
            this.KEY_BOX.Location = new System.Drawing.Point(12, 57);
            this.KEY_BOX.Name = "KEY_BOX";
            this.KEY_BOX.Size = new System.Drawing.Size(301, 31);
            this.KEY_BOX.TabIndex = 1;
            // 
            // ENTER
            // 
            this.ENTER.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ENTER.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ENTER.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ENTER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ENTER.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ENTER.ForeColor = System.Drawing.Color.White;
            this.ENTER.Location = new System.Drawing.Point(109, 94);
            this.ENTER.Name = "ENTER";
            this.ENTER.Size = new System.Drawing.Size(110, 32);
            this.ENTER.TabIndex = 4;
            this.ENTER.Tag = "";
            this.ENTER.Text = "ENTER";
            this.ENTER.UseVisualStyleBackColor = false;
            this.ENTER.Click += new System.EventHandler(this.ENTER_Click);
            // 
            // DRAG_SYS
            // 
            this.DRAG_SYS.GetForm = this;
            this.DRAG_SYS.TargetControl = this.DRAG_PANEL;
            // 
            // GET_KEY_LINK
            // 
            this.GET_KEY_LINK.AutoSize = true;
            this.GET_KEY_LINK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GET_KEY_LINK.LinkColor = System.Drawing.Color.Lime;
            this.GET_KEY_LINK.Location = new System.Drawing.Point(9, 41);
            this.GET_KEY_LINK.Name = "GET_KEY_LINK";
            this.GET_KEY_LINK.Size = new System.Drawing.Size(119, 13);
            this.GET_KEY_LINK.TabIndex = 4;
            this.GET_KEY_LINK.TabStop = true;
            this.GET_KEY_LINK.Text = "GET KEY [NO ADS]";
            this.GET_KEY_LINK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GET_KEY_LINK_LinkClicked);
            // 
            // KeyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(326, 138);
            this.Controls.Add(this.GET_KEY_LINK);
            this.Controls.Add(this.ENTER);
            this.Controls.Add(this.KEY_BOX);
            this.Controls.Add(this.DRAG_PANEL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KeyForm";
            this.Text = "Key";
            this.Load += new System.EventHandler(this.KeyForm_Load);
            this.DRAG_PANEL.ResumeLayout(false);
            this.DRAG_PANEL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel DRAG_PANEL;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label HEAD;
        private System.Windows.Forms.Button MINIMIZE_BUTTON;
        private System.Windows.Forms.Button EXIT_BUTTON;
        private System.Windows.Forms.TextBox KEY_BOX;
        private System.Windows.Forms.Button ENTER;
        private JDragControl.JDragControl DRAG_SYS;
        private System.Windows.Forms.LinkLabel GET_KEY_LINK;
    }
}