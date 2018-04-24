namespace attendanceproject
{
    partial class studentaccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(studentaccount));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnsignup = new System.Windows.Forms.Button();
            this.btnhome = new System.Windows.Forms.Button();
            this.btnview = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.comboquestion = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.studentgv = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnexit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 40);
            this.panel1.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Corbel", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.label2.Location = new System.Drawing.Point(13, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 28);
            this.label2.TabIndex = 49;
            this.label2.Text = "STUDENT ACCOUNT";
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.DimGray;
            this.btnexit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnexit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnexit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnexit.Location = new System.Drawing.Point(612, 3);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(52, 33);
            this.btnexit.TabIndex = 33;
            this.btnexit.Text = "X";
            this.btnexit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnexit.UseVisualStyleBackColor = false;
            // 
            // btnsignup
            // 
            this.btnsignup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnsignup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnsignup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnsignup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnsignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsignup.ForeColor = System.Drawing.Color.White;
            this.btnsignup.Image = ((System.Drawing.Image)(resources.GetObject("btnsignup.Image")));
            this.btnsignup.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnsignup.Location = new System.Drawing.Point(0, 39);
            this.btnsignup.Name = "btnsignup";
            this.btnsignup.Size = new System.Drawing.Size(336, 57);
            this.btnsignup.TabIndex = 51;
            this.btnsignup.Text = "Log Out";
            this.btnsignup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnsignup.UseVisualStyleBackColor = false;
            // 
            // btnhome
            // 
            this.btnhome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnhome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnhome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnhome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnhome.ForeColor = System.Drawing.Color.White;
            this.btnhome.Image = ((System.Drawing.Image)(resources.GetObject("btnhome.Image")));
            this.btnhome.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnhome.Location = new System.Drawing.Point(333, 39);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(334, 57);
            this.btnhome.TabIndex = 50;
            this.btnhome.Text = "Home";
            this.btnhome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnhome.UseVisualStyleBackColor = false;
            // 
            // btnview
            // 
            this.btnview.BackColor = System.Drawing.Color.Transparent;
            this.btnview.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnview.BackgroundImage")));
            this.btnview.ButtonText = "View";
            this.btnview.ButtonTextMarginLeft = 0;
            this.btnview.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnview.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnview.DisabledForecolor = System.Drawing.Color.White;
            this.btnview.ForeColor = System.Drawing.Color.White;
            this.btnview.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnview.IconPadding = 10;
            this.btnview.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnview.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnview.IdleBorderRadius = 1;
            this.btnview.IdleBorderThickness = 0;
            this.btnview.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnview.IdleIconLeftImage = null;
            this.btnview.IdleIconRightImage = null;
            this.btnview.Location = new System.Drawing.Point(516, 163);
            this.btnview.Name = "btnview";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnview.onHoverState = stateProperties1;
            this.btnview.Size = new System.Drawing.Size(112, 36);
            this.btnview.TabIndex = 54;
            this.btnview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboquestion
            // 
            this.comboquestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboquestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.comboquestion.ForeColor = System.Drawing.SystemColors.Menu;
            this.comboquestion.FormattingEnabled = true;
            this.comboquestion.Items.AddRange(new object[] {
            "Your first phone number?",
            "Grandfather\'s name?",
            "Birth place?"});
            this.comboquestion.Location = new System.Drawing.Point(442, 118);
            this.comboquestion.Name = "comboquestion";
            this.comboquestion.Size = new System.Drawing.Size(186, 24);
            this.comboquestion.TabIndex = 53;
            this.comboquestion.SelectedIndexChanged += new System.EventHandler(this.comboquestion_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Corbel", 15.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(305, 115);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 26);
            this.label5.TabIndex = 52;
            this.label5.Text = "SUBJECT";
            // 
            // studentgv
            // 
            this.studentgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentgv.Location = new System.Drawing.Point(31, 205);
            this.studentgv.Name = "studentgv";
            this.studentgv.Size = new System.Drawing.Size(597, 253);
            this.studentgv.TabIndex = 55;
            // 
            // studentaccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(667, 470);
            this.Controls.Add(this.studentgv);
            this.Controls.Add(this.btnview);
            this.Controls.Add(this.comboquestion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnsignup);
            this.Controls.Add(this.btnhome);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "studentaccount";
            this.Text = "studentaccount";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnsignup;
        private System.Windows.Forms.Button btnhome;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnview;
        private System.Windows.Forms.ComboBox comboquestion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView studentgv;
    }
}