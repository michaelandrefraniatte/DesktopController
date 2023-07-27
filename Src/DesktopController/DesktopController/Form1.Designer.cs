namespace DesktopController
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tb1st = new System.Windows.Forms.TextBox();
            this.tblast = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btscan = new System.Windows.Forms.Button();
            this.btscreen1 = new System.Windows.Forms.Button();
            this.btcontrol1 = new System.Windows.Forms.Button();
            this.btupdate1 = new System.Windows.Forms.Button();
            this.btplay1 = new System.Windows.Forms.Button();
            this.btlisten1 = new System.Windows.Forms.Button();
            this.btlisten2 = new System.Windows.Forms.Button();
            this.btplay2 = new System.Windows.Forms.Button();
            this.btupdate2 = new System.Windows.Forms.Button();
            this.btcontrol2 = new System.Windows.Forms.Button();
            this.btscreen2 = new System.Windows.Forms.Button();
            this.btlisten3 = new System.Windows.Forms.Button();
            this.btplay3 = new System.Windows.Forms.Button();
            this.btupdate3 = new System.Windows.Forms.Button();
            this.btcontrol3 = new System.Windows.Forms.Button();
            this.btscreen3 = new System.Windows.Forms.Button();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rtscan = new System.Windows.Forms.RichTextBox();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.cb2 = new System.Windows.Forms.CheckBox();
            this.cb3 = new System.Windows.Forms.CheckBox();
            this.btstart = new System.Windows.Forms.Button();
            this.cbmanager = new System.Windows.Forms.CheckBox();
            this.cbmanaged = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb1st
            // 
            this.tb1st.Location = new System.Drawing.Point(86, 53);
            this.tb1st.Name = "tb1st";
            this.tb1st.Size = new System.Drawing.Size(93, 20);
            this.tb1st.TabIndex = 0;
            this.tb1st.Text = "192.168.1.2";
            // 
            // tblast
            // 
            this.tblast.Location = new System.Drawing.Point(87, 88);
            this.tblast.Name = "tblast";
            this.tblast.Size = new System.Drawing.Size(92, 20);
            this.tblast.TabIndex = 1;
            this.tblast.Text = "192.168.1.255";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "First IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last IP";
            // 
            // btscan
            // 
            this.btscan.Location = new System.Drawing.Point(241, 70);
            this.btscan.Name = "btscan";
            this.btscan.Size = new System.Drawing.Size(75, 23);
            this.btscan.TabIndex = 10;
            this.btscan.Text = "Scan IP";
            this.btscan.UseVisualStyleBackColor = true;
            this.btscan.Click += new System.EventHandler(this.btscan_Click);
            // 
            // btscreen1
            // 
            this.btscreen1.Location = new System.Drawing.Point(382, 211);
            this.btscreen1.Name = "btscreen1";
            this.btscreen1.Size = new System.Drawing.Size(75, 23);
            this.btscreen1.TabIndex = 11;
            this.btscreen1.Text = "Screen";
            this.btscreen1.UseVisualStyleBackColor = true;
            // 
            // btcontrol1
            // 
            this.btcontrol1.Location = new System.Drawing.Point(382, 171);
            this.btcontrol1.Name = "btcontrol1";
            this.btcontrol1.Size = new System.Drawing.Size(75, 23);
            this.btcontrol1.TabIndex = 12;
            this.btcontrol1.Text = "Control";
            this.btcontrol1.UseVisualStyleBackColor = true;
            // 
            // btupdate1
            // 
            this.btupdate1.Location = new System.Drawing.Point(711, 188);
            this.btupdate1.Name = "btupdate1";
            this.btupdate1.Size = new System.Drawing.Size(75, 23);
            this.btupdate1.TabIndex = 13;
            this.btupdate1.Text = "Update";
            this.btupdate1.UseVisualStyleBackColor = true;
            // 
            // btplay1
            // 
            this.btplay1.Location = new System.Drawing.Point(241, 171);
            this.btplay1.Name = "btplay1";
            this.btplay1.Size = new System.Drawing.Size(75, 23);
            this.btplay1.TabIndex = 14;
            this.btplay1.Text = "Play";
            this.btplay1.UseVisualStyleBackColor = true;
            this.btplay1.Click += new System.EventHandler(this.btplay1_Click);
            // 
            // btlisten1
            // 
            this.btlisten1.Location = new System.Drawing.Point(241, 211);
            this.btlisten1.Name = "btlisten1";
            this.btlisten1.Size = new System.Drawing.Size(75, 23);
            this.btlisten1.TabIndex = 15;
            this.btlisten1.Text = "Listen";
            this.btlisten1.UseVisualStyleBackColor = true;
            this.btlisten1.Click += new System.EventHandler(this.btlisten1_Click);
            // 
            // btlisten2
            // 
            this.btlisten2.Location = new System.Drawing.Point(241, 338);
            this.btlisten2.Name = "btlisten2";
            this.btlisten2.Size = new System.Drawing.Size(75, 23);
            this.btlisten2.TabIndex = 20;
            this.btlisten2.Text = "Listen";
            this.btlisten2.UseVisualStyleBackColor = true;
            this.btlisten2.Click += new System.EventHandler(this.btlisten2_Click);
            // 
            // btplay2
            // 
            this.btplay2.Location = new System.Drawing.Point(241, 298);
            this.btplay2.Name = "btplay2";
            this.btplay2.Size = new System.Drawing.Size(75, 23);
            this.btplay2.TabIndex = 19;
            this.btplay2.Text = "Play";
            this.btplay2.UseVisualStyleBackColor = true;
            this.btplay2.Click += new System.EventHandler(this.btplay2_Click);
            // 
            // btupdate2
            // 
            this.btupdate2.Location = new System.Drawing.Point(711, 315);
            this.btupdate2.Name = "btupdate2";
            this.btupdate2.Size = new System.Drawing.Size(75, 23);
            this.btupdate2.TabIndex = 18;
            this.btupdate2.Text = "Update";
            this.btupdate2.UseVisualStyleBackColor = true;
            // 
            // btcontrol2
            // 
            this.btcontrol2.Location = new System.Drawing.Point(382, 298);
            this.btcontrol2.Name = "btcontrol2";
            this.btcontrol2.Size = new System.Drawing.Size(75, 23);
            this.btcontrol2.TabIndex = 17;
            this.btcontrol2.Text = "Control";
            this.btcontrol2.UseVisualStyleBackColor = true;
            // 
            // btscreen2
            // 
            this.btscreen2.Location = new System.Drawing.Point(382, 338);
            this.btscreen2.Name = "btscreen2";
            this.btscreen2.Size = new System.Drawing.Size(75, 23);
            this.btscreen2.TabIndex = 16;
            this.btscreen2.Text = "Screen";
            this.btscreen2.UseVisualStyleBackColor = true;
            // 
            // btlisten3
            // 
            this.btlisten3.Location = new System.Drawing.Point(241, 465);
            this.btlisten3.Name = "btlisten3";
            this.btlisten3.Size = new System.Drawing.Size(75, 23);
            this.btlisten3.TabIndex = 25;
            this.btlisten3.Text = "Listen";
            this.btlisten3.UseVisualStyleBackColor = true;
            this.btlisten3.Click += new System.EventHandler(this.btlisten3_Click);
            // 
            // btplay3
            // 
            this.btplay3.Location = new System.Drawing.Point(241, 425);
            this.btplay3.Name = "btplay3";
            this.btplay3.Size = new System.Drawing.Size(75, 23);
            this.btplay3.TabIndex = 24;
            this.btplay3.Text = "Play";
            this.btplay3.UseVisualStyleBackColor = true;
            this.btplay3.Click += new System.EventHandler(this.btplay3_Click);
            // 
            // btupdate3
            // 
            this.btupdate3.Location = new System.Drawing.Point(711, 442);
            this.btupdate3.Name = "btupdate3";
            this.btupdate3.Size = new System.Drawing.Size(75, 23);
            this.btupdate3.TabIndex = 23;
            this.btupdate3.Text = "Update";
            this.btupdate3.UseVisualStyleBackColor = true;
            // 
            // btcontrol3
            // 
            this.btcontrol3.Location = new System.Drawing.Point(382, 425);
            this.btcontrol3.Name = "btcontrol3";
            this.btcontrol3.Size = new System.Drawing.Size(75, 23);
            this.btcontrol3.TabIndex = 22;
            this.btcontrol3.Text = "Control";
            this.btcontrol3.UseVisualStyleBackColor = true;
            // 
            // btscreen3
            // 
            this.btscreen3.Location = new System.Drawing.Point(382, 465);
            this.btscreen3.Name = "btscreen3";
            this.btscreen3.Size = new System.Drawing.Size(75, 23);
            this.btscreen3.TabIndex = 21;
            this.btscreen3.Text = "Screen";
            this.btscreen3.UseVisualStyleBackColor = true;
            // 
            // pb3
            // 
            this.pb3.BackgroundImage = global::DesktopController.Properties.Resources.screen3;
            this.pb3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb3.Location = new System.Drawing.Point(529, 413);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(136, 83);
            this.pb3.TabIndex = 9;
            this.pb3.TabStop = false;
            // 
            // pb2
            // 
            this.pb2.BackgroundImage = global::DesktopController.Properties.Resources.screen2;
            this.pb2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb2.Location = new System.Drawing.Point(529, 288);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(136, 83);
            this.pb2.TabIndex = 8;
            this.pb2.TabStop = false;
            // 
            // pb1
            // 
            this.pb1.BackgroundImage = global::DesktopController.Properties.Resources.screen1;
            this.pb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb1.Location = new System.Drawing.Point(529, 161);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(136, 83);
            this.pb1.TabIndex = 7;
            this.pb1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(347, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Result";
            // 
            // rtscan
            // 
            this.rtscan.Location = new System.Drawing.Point(390, 39);
            this.rtscan.Name = "rtscan";
            this.rtscan.Size = new System.Drawing.Size(396, 86);
            this.rtscan.TabIndex = 27;
            this.rtscan.Text = "";
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(86, 191);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(92, 20);
            this.tb1.TabIndex = 28;
            this.tb1.Text = "192.168.1.10";
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(87, 319);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(92, 20);
            this.tb2.TabIndex = 29;
            this.tb2.Text = "192.168.1.13";
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(86, 446);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(92, 20);
            this.tb3.TabIndex = 30;
            this.tb3.Text = "192.168.1.16";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "IP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "IP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 449);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "IP";
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Location = new System.Drawing.Point(42, 194);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(15, 14);
            this.cb1.TabIndex = 34;
            this.cb1.UseVisualStyleBackColor = true;
            // 
            // cb2
            // 
            this.cb2.AutoSize = true;
            this.cb2.Location = new System.Drawing.Point(42, 321);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(15, 14);
            this.cb2.TabIndex = 35;
            this.cb2.UseVisualStyleBackColor = true;
            // 
            // cb3
            // 
            this.cb3.AutoSize = true;
            this.cb3.Location = new System.Drawing.Point(42, 449);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(15, 14);
            this.cb3.TabIndex = 36;
            this.cb3.UseVisualStyleBackColor = true;
            // 
            // btstart
            // 
            this.btstart.Location = new System.Drawing.Point(359, 539);
            this.btstart.Name = "btstart";
            this.btstart.Size = new System.Drawing.Size(118, 23);
            this.btstart.TabIndex = 37;
            this.btstart.Text = "Start";
            this.btstart.UseVisualStyleBackColor = true;
            this.btstart.Click += new System.EventHandler(this.btstart_Click);
            // 
            // cbmanager
            // 
            this.cbmanager.AutoSize = true;
            this.cbmanager.Location = new System.Drawing.Point(241, 543);
            this.cbmanager.Name = "cbmanager";
            this.cbmanager.Size = new System.Drawing.Size(68, 17);
            this.cbmanager.TabIndex = 38;
            this.cbmanager.Text = "Manager";
            this.cbmanager.UseVisualStyleBackColor = true;
            this.cbmanager.CheckStateChanged += new System.EventHandler(this.cbmanager_CheckStateChanged);
            // 
            // cbmanaged
            // 
            this.cbmanaged.AutoSize = true;
            this.cbmanaged.Location = new System.Drawing.Point(529, 543);
            this.cbmanaged.Name = "cbmanaged";
            this.cbmanaged.Size = new System.Drawing.Size(71, 17);
            this.cbmanaged.TabIndex = 39;
            this.cbmanaged.Text = "Managed";
            this.cbmanaged.UseVisualStyleBackColor = true;
            this.cbmanaged.CheckStateChanged += new System.EventHandler(this.cbmanaged_CheckStateChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(836, 593);
            this.Controls.Add(this.cbmanaged);
            this.Controls.Add(this.cbmanager);
            this.Controls.Add(this.btstart);
            this.Controls.Add(this.cb3);
            this.Controls.Add(this.cb2);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb3);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.rtscan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btlisten3);
            this.Controls.Add(this.btplay3);
            this.Controls.Add(this.btupdate3);
            this.Controls.Add(this.btcontrol3);
            this.Controls.Add(this.btscreen3);
            this.Controls.Add(this.btlisten2);
            this.Controls.Add(this.btplay2);
            this.Controls.Add(this.btupdate2);
            this.Controls.Add(this.btcontrol2);
            this.Controls.Add(this.btscreen2);
            this.Controls.Add(this.btlisten1);
            this.Controls.Add(this.btplay1);
            this.Controls.Add(this.btupdate1);
            this.Controls.Add(this.btcontrol1);
            this.Controls.Add(this.btscreen1);
            this.Controls.Add(this.btscan);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tblast);
            this.Controls.Add(this.tb1st);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DesktopController";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb1st;
        private System.Windows.Forms.TextBox tblast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.Button btscan;
        private System.Windows.Forms.Button btscreen1;
        private System.Windows.Forms.Button btcontrol1;
        private System.Windows.Forms.Button btupdate1;
        private System.Windows.Forms.Button btplay1;
        private System.Windows.Forms.Button btlisten1;
        private System.Windows.Forms.Button btlisten2;
        private System.Windows.Forms.Button btplay2;
        private System.Windows.Forms.Button btupdate2;
        private System.Windows.Forms.Button btcontrol2;
        private System.Windows.Forms.Button btscreen2;
        private System.Windows.Forms.Button btlisten3;
        private System.Windows.Forms.Button btplay3;
        private System.Windows.Forms.Button btupdate3;
        private System.Windows.Forms.Button btcontrol3;
        private System.Windows.Forms.Button btscreen3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtscan;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cb1;
        private System.Windows.Forms.CheckBox cb2;
        private System.Windows.Forms.CheckBox cb3;
        private System.Windows.Forms.Button btstart;
        private System.Windows.Forms.CheckBox cbmanager;
        private System.Windows.Forms.CheckBox cbmanaged;
    }
}

