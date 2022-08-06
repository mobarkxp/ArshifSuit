namespace Arshif.Pages
{
    partial class DepPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.bunifuTextbox1 = new Bunifu.Framework.UI.BunifuTextbox();
            this.sreachbtn = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Almarai Bold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(2136, 1280);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Location = new System.Drawing.Point(25, 533);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2087, 747);
            this.panel4.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.gridControl1);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.groupBox2.Location = new System.Drawing.Point(25, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(2039, 706);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "العرض";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(23, 59);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1862, 618);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.bunifuTextbox1);
            this.groupBox1.Controls.Add(this.sreachbtn);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.groupBox1.Location = new System.Drawing.Point(22, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(2090, 341);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "عمليات الاقسام";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 238);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2084, 100);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.simpleButton5);
            this.panel3.Controls.Add(this.simpleButton3);
            this.panel3.Controls.Add(this.simpleButton4);
            this.panel3.Controls.Add(this.simpleButton2);
            this.panel3.Controls.Add(this.simpleButton1);
            this.panel3.Location = new System.Drawing.Point(63, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1939, 94);
            this.panel3.TabIndex = 0;
            // 
            // simpleButton5
            // 
            this.simpleButton5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.simpleButton5.Appearance.Font = new System.Drawing.Font("Almarai Bold", 10.125F, System.Drawing.FontStyle.Bold);
            this.simpleButton5.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton5.Appearance.Options.UseBackColor = true;
            this.simpleButton5.Appearance.Options.UseFont = true;
            this.simpleButton5.Appearance.Options.UseForeColor = true;
            this.simpleButton5.AppearanceDisabled.ForeColor = System.Drawing.Color.White;
            this.simpleButton5.AppearanceDisabled.Options.UseForeColor = true;
            this.simpleButton5.AppearancePressed.ForeColor = System.Drawing.Color.White;
            this.simpleButton5.AppearancePressed.Options.UseForeColor = true;
            this.simpleButton5.Location = new System.Drawing.Point(330, 15);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(234, 64);
            this.simpleButton5.TabIndex = 13;
            this.simpleButton5.Text = "طباعة";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Almarai Bold", 10.125F, System.Drawing.FontStyle.Bold);
            this.simpleButton3.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton3.Appearance.Options.UseBackColor = true;
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.Appearance.Options.UseForeColor = true;
            this.simpleButton3.AppearanceDisabled.ForeColor = System.Drawing.Color.White;
            this.simpleButton3.AppearanceDisabled.Options.UseForeColor = true;
            this.simpleButton3.AppearancePressed.ForeColor = System.Drawing.Color.White;
            this.simpleButton3.AppearancePressed.Options.UseForeColor = true;
            this.simpleButton3.Location = new System.Drawing.Point(591, 15);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(234, 64);
            this.simpleButton3.TabIndex = 14;
            this.simpleButton3.Text = "حذف";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Almarai Bold", 10.125F, System.Drawing.FontStyle.Bold);
            this.simpleButton4.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton4.Appearance.Options.UseBackColor = true;
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.Appearance.Options.UseForeColor = true;
            this.simpleButton4.AppearanceDisabled.ForeColor = System.Drawing.Color.White;
            this.simpleButton4.AppearanceDisabled.Options.UseForeColor = true;
            this.simpleButton4.AppearancePressed.ForeColor = System.Drawing.Color.White;
            this.simpleButton4.AppearancePressed.Options.UseForeColor = true;
            this.simpleButton4.Location = new System.Drawing.Point(852, 15);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(234, 64);
            this.simpleButton4.TabIndex = 15;
            this.simpleButton4.Text = "تحديث";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Almarai Bold", 10.125F, System.Drawing.FontStyle.Bold);
            this.simpleButton2.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Appearance.Options.UseForeColor = true;
            this.simpleButton2.AppearanceDisabled.ForeColor = System.Drawing.Color.White;
            this.simpleButton2.AppearanceDisabled.Options.UseForeColor = true;
            this.simpleButton2.AppearancePressed.ForeColor = System.Drawing.Color.White;
            this.simpleButton2.AppearancePressed.Options.UseForeColor = true;
            this.simpleButton2.Location = new System.Drawing.Point(1113, 15);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(234, 64);
            this.simpleButton2.TabIndex = 16;
            this.simpleButton2.Text = "عرض التفاصيل";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Almarai Bold", 10.125F, System.Drawing.FontStyle.Bold);
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.AppearanceDisabled.ForeColor = System.Drawing.Color.White;
            this.simpleButton1.AppearanceDisabled.Options.UseForeColor = true;
            this.simpleButton1.AppearancePressed.ForeColor = System.Drawing.Color.White;
            this.simpleButton1.AppearancePressed.Options.UseForeColor = true;
            this.simpleButton1.Location = new System.Drawing.Point(1374, 15);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(234, 64);
            this.simpleButton1.TabIndex = 12;
            this.simpleButton1.Text = "إظافة ملف جديد";
            // 
            // bunifuTextbox1
            // 
            this.bunifuTextbox1.BackColor = System.Drawing.Color.White;
            this.bunifuTextbox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.BackgroundImage")));
            this.bunifuTextbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTextbox1.Font = new System.Drawing.Font("Almarai Bold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.bunifuTextbox1.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.Icon")));
            this.bunifuTextbox1.Location = new System.Drawing.Point(710, 50);
            this.bunifuTextbox1.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.bunifuTextbox1.Name = "bunifuTextbox1";
            this.bunifuTextbox1.Size = new System.Drawing.Size(794, 81);
            this.bunifuTextbox1.TabIndex = 3;
            this.bunifuTextbox1.text = "بحث";
            // 
            // sreachbtn
            // 
            this.sreachbtn.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.sreachbtn.Appearance.Font = new System.Drawing.Font("Almarai Bold", 10.125F, System.Drawing.FontStyle.Bold);
            this.sreachbtn.Appearance.ForeColor = System.Drawing.Color.White;
            this.sreachbtn.Appearance.Options.UseBackColor = true;
            this.sreachbtn.Appearance.Options.UseFont = true;
            this.sreachbtn.Appearance.Options.UseForeColor = true;
            this.sreachbtn.AppearanceDisabled.ForeColor = System.Drawing.Color.White;
            this.sreachbtn.AppearanceDisabled.Options.UseForeColor = true;
            this.sreachbtn.AppearancePressed.ForeColor = System.Drawing.Color.White;
            this.sreachbtn.AppearancePressed.Options.UseForeColor = true;
            this.sreachbtn.Location = new System.Drawing.Point(941, 143);
            this.sreachbtn.Name = "sreachbtn";
            this.sreachbtn.Size = new System.Drawing.Size(234, 64);
            this.sreachbtn.TabIndex = 6;
            this.sreachbtn.Text = "بحث";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Almarai Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.label1.Location = new System.Drawing.Point(1041, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 75);
            this.label1.TabIndex = 1;
            this.label1.Text = "الأقسام";
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(25, 451);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(2084, 76);
            this.panel5.TabIndex = 4;
            // 
            // DepPage
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "DepPage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(2136, 1280);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private Bunifu.Framework.UI.BunifuTextbox bunifuTextbox1;
        private DevExpress.XtraEditors.SimpleButton sreachbtn;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel5;
    }
}
