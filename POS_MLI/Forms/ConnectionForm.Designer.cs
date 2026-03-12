

namespace POS_MLI.Forms
{
    partial class ConnectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionForm));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.btnConnction = new DevExpress.XtraEditors.SimpleButton();
            this.txtdbDatabase = new DevExpress.XtraEditors.TextEdit();
            this.txtdbPassowrd = new DevExpress.XtraEditors.TextEdit();
            this.txtdbUsername = new DevExpress.XtraEditors.TextEdit();
            this.txtdbProt = new DevExpress.XtraEditors.TextEdit();
            this.txtdbHost = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtdbDatabase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdbPassowrd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdbUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdbProt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdbHost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.dataLayoutControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(266, 279);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.btnConnction);
            this.dataLayoutControl1.Controls.Add(this.txtdbDatabase);
            this.dataLayoutControl1.Controls.Add(this.txtdbPassowrd);
            this.dataLayoutControl1.Controls.Add(this.txtdbUsername);
            this.dataLayoutControl1.Controls.Add(this.txtdbProt);
            this.dataLayoutControl1.Controls.Add(this.txtdbHost);
            this.dataLayoutControl1.Location = new System.Drawing.Point(12, 12);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(538, 135, 650, 400);
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(242, 255);
            this.dataLayoutControl1.TabIndex = 4;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // btnConnction
            // 
            this.btnConnction.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnConnction.Appearance.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnction.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnConnction.Appearance.Options.UseBackColor = true;
            this.btnConnction.Appearance.Options.UseFont = true;
            this.btnConnction.Appearance.Options.UseForeColor = true;
            this.btnConnction.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnConnction.Location = new System.Drawing.Point(122, 182);
            this.btnConnction.Name = "btnConnction";
            this.btnConnction.Size = new System.Drawing.Size(108, 36);
            this.btnConnction.StyleController = this.dataLayoutControl1;
            this.btnConnction.TabIndex = 9;
            this.btnConnction.Text = "Connect";
            this.btnConnction.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txtdbDatabase
            // 
            this.txtdbDatabase.Location = new System.Drawing.Point(98, 148);
            this.txtdbDatabase.Name = "txtdbDatabase";
            this.txtdbDatabase.Properties.Appearance.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdbDatabase.Properties.Appearance.Options.UseFont = true;
            this.txtdbDatabase.Size = new System.Drawing.Size(132, 30);
            this.txtdbDatabase.StyleController = this.dataLayoutControl1;
            this.txtdbDatabase.TabIndex = 8;
            // 
            // txtdbPassowrd
            // 
            this.txtdbPassowrd.Location = new System.Drawing.Point(98, 114);
            this.txtdbPassowrd.Name = "txtdbPassowrd";
            this.txtdbPassowrd.Properties.Appearance.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdbPassowrd.Properties.Appearance.Options.UseFont = true;
            this.txtdbPassowrd.Properties.UseSystemPasswordChar = true;
            this.txtdbPassowrd.Size = new System.Drawing.Size(132, 30);
            this.txtdbPassowrd.StyleController = this.dataLayoutControl1;
            this.txtdbPassowrd.TabIndex = 7;
            // 
            // txtdbUsername
            // 
            this.txtdbUsername.Location = new System.Drawing.Point(98, 80);
            this.txtdbUsername.Name = "txtdbUsername";
            this.txtdbUsername.Properties.Appearance.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdbUsername.Properties.Appearance.Options.UseFont = true;
            this.txtdbUsername.Size = new System.Drawing.Size(132, 30);
            this.txtdbUsername.StyleController = this.dataLayoutControl1;
            this.txtdbUsername.TabIndex = 6;
            // 
            // txtdbProt
            // 
            this.txtdbProt.Location = new System.Drawing.Point(98, 46);
            this.txtdbProt.Name = "txtdbProt";
            this.txtdbProt.Properties.Appearance.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdbProt.Properties.Appearance.Options.UseFont = true;
            this.txtdbProt.Size = new System.Drawing.Size(132, 30);
            this.txtdbProt.StyleController = this.dataLayoutControl1;
            this.txtdbProt.TabIndex = 5;
            // 
            // txtdbHost
            // 
            this.txtdbHost.Location = new System.Drawing.Point(98, 12);
            this.txtdbHost.Name = "txtdbHost";
            this.txtdbHost.Properties.Appearance.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdbHost.Properties.Appearance.Options.UseFont = true;
            this.txtdbHost.Size = new System.Drawing.Size(132, 30);
            this.txtdbHost.StyleController = this.dataLayoutControl1;
            this.txtdbHost.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.emptySpaceItem1,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem6,
            this.layoutControlItem5,
            this.layoutControlItem7});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(242, 255);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.Control = this.txtdbHost;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(222, 34);
            this.layoutControlItem2.Text = "IP Address";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(74, 21);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 170);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(110, 65);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem3.Control = this.txtdbProt;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 34);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(222, 34);
            this.layoutControlItem3.Text = "Port";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(74, 21);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem4.Control = this.txtdbUsername;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 68);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(222, 34);
            this.layoutControlItem4.Text = "Username";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(74, 21);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem6.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem6.Control = this.txtdbDatabase;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 136);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(222, 34);
            this.layoutControlItem6.Text = "Database";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(74, 21);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem5.Control = this.txtdbPassowrd;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 102);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(222, 34);
            this.layoutControlItem5.Text = "Password";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(74, 21);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(266, 279);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dataLayoutControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(246, 259);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnConnction;
            this.layoutControlItem7.Location = new System.Drawing.Point(110, 170);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(112, 65);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // ConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 279);
            this.Controls.Add(this.layoutControl1);
            this.Name = "ConnectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConnectionForm";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtdbDatabase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdbPassowrd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdbUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdbProt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdbHost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnConnction;
        private DevExpress.XtraEditors.TextEdit txtdbDatabase;
        private DevExpress.XtraEditors.TextEdit txtdbPassowrd;
        private DevExpress.XtraEditors.TextEdit txtdbUsername;
        private DevExpress.XtraEditors.TextEdit txtdbProt;
        private DevExpress.XtraEditors.TextEdit txtdbHost;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
    }
}