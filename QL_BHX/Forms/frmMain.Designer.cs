namespace QL_BHX
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmManager = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmManager_Staff = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmManager_Product = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmManager_Bill = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmManager_Customer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmManager_Discount = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmManager_Branch = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLookup = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLookup_Customer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLookup_Staff = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLookup_Bill = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSell = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSystem,
            this.tsmManager,
            this.tsmLookup,
            this.tsmSell});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // tsmSystem
            // 
            this.tsmSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmLogin,
            this.tsmLogout,
            this.tsmExit});
            this.tsmSystem.Name = "tsmSystem";
            resources.ApplyResources(this.tsmSystem, "tsmSystem");
            // 
            // tsmLogin
            // 
            this.tsmLogin.Name = "tsmLogin";
            resources.ApplyResources(this.tsmLogin, "tsmLogin");
            this.tsmLogin.Click += new System.EventHandler(this.tsmLogin_Click);
            // 
            // tsmLogout
            // 
            resources.ApplyResources(this.tsmLogout, "tsmLogout");
            this.tsmLogout.Name = "tsmLogout";
            this.tsmLogout.Click += new System.EventHandler(this.tsmLogout_Click);
            // 
            // tsmExit
            // 
            this.tsmExit.Name = "tsmExit";
            resources.ApplyResources(this.tsmExit, "tsmExit");
            this.tsmExit.Click += new System.EventHandler(this.tsmExit_Click);
            // 
            // tsmManager
            // 
            this.tsmManager.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmManager_Staff,
            this.tsmManager_Product,
            this.tsmManager_Bill,
            this.tsmManager_Customer,
            this.tsmManager_Discount,
            this.tsmManager_Branch});
            this.tsmManager.Name = "tsmManager";
            resources.ApplyResources(this.tsmManager, "tsmManager");
            // 
            // tsmManager_Staff
            // 
            resources.ApplyResources(this.tsmManager_Staff, "tsmManager_Staff");
            this.tsmManager_Staff.Name = "tsmManager_Staff";
            this.tsmManager_Staff.Click += new System.EventHandler(this.tsmManager_Staff_Click);
            // 
            // tsmManager_Product
            // 
            resources.ApplyResources(this.tsmManager_Product, "tsmManager_Product");
            this.tsmManager_Product.Name = "tsmManager_Product";
            this.tsmManager_Product.Click += new System.EventHandler(this.tsmManager_Product_Click);
            // 
            // tsmManager_Bill
            // 
            resources.ApplyResources(this.tsmManager_Bill, "tsmManager_Bill");
            this.tsmManager_Bill.Name = "tsmManager_Bill";
            this.tsmManager_Bill.Click += new System.EventHandler(this.tsmManager_Bill_Click);
            // 
            // tsmManager_Customer
            // 
            resources.ApplyResources(this.tsmManager_Customer, "tsmManager_Customer");
            this.tsmManager_Customer.Name = "tsmManager_Customer";
            // 
            // tsmManager_Discount
            // 
            resources.ApplyResources(this.tsmManager_Discount, "tsmManager_Discount");
            this.tsmManager_Discount.Name = "tsmManager_Discount";
            // 
            // tsmManager_Branch
            // 
            resources.ApplyResources(this.tsmManager_Branch, "tsmManager_Branch");
            this.tsmManager_Branch.Name = "tsmManager_Branch";
            // 
            // tsmLookup
            // 
            this.tsmLookup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmLookup_Customer,
            this.tsmLookup_Staff,
            this.tsmLookup_Bill});
            this.tsmLookup.Name = "tsmLookup";
            resources.ApplyResources(this.tsmLookup, "tsmLookup");
            // 
            // tsmLookup_Customer
            // 
            resources.ApplyResources(this.tsmLookup_Customer, "tsmLookup_Customer");
            this.tsmLookup_Customer.Name = "tsmLookup_Customer";
            // 
            // tsmLookup_Staff
            // 
            resources.ApplyResources(this.tsmLookup_Staff, "tsmLookup_Staff");
            this.tsmLookup_Staff.Name = "tsmLookup_Staff";
            // 
            // tsmLookup_Bill
            // 
            resources.ApplyResources(this.tsmLookup_Bill, "tsmLookup_Bill");
            this.tsmLookup_Bill.Name = "tsmLookup_Bill";
            // 
            // tsmSell
            // 
            resources.ApplyResources(this.tsmSell, "tsmSell");
            this.tsmSell.Name = "tsmSell";
            this.tsmSell.Click += new System.EventHandler(this.tsmSell_Click);
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.MdiChildActivate += new System.EventHandler(this.frmMain_MdiChildActivate);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmSystem;
        private System.Windows.Forms.ToolStripMenuItem tsmManager;
        private System.Windows.Forms.ToolStripMenuItem tsmLogin;
        private System.Windows.Forms.ToolStripMenuItem tsmLogout;
        private System.Windows.Forms.ToolStripMenuItem tsmExit;
        private System.Windows.Forms.ToolStripMenuItem tsmManager_Staff;
        private System.Windows.Forms.ToolStripMenuItem tsmManager_Product;
        private System.Windows.Forms.ToolStripMenuItem tsmManager_Bill;
        private System.Windows.Forms.ToolStripMenuItem tsmLookup;
        private System.Windows.Forms.ToolStripMenuItem tsmManager_Customer;
        private System.Windows.Forms.ToolStripMenuItem tsmManager_Discount;
        private System.Windows.Forms.ToolStripMenuItem tsmLookup_Customer;
        private System.Windows.Forms.ToolStripMenuItem tsmLookup_Staff;
        private System.Windows.Forms.ToolStripMenuItem tsmLookup_Bill;
        private System.Windows.Forms.ToolStripMenuItem tsmSell;
        private System.Windows.Forms.ToolStripMenuItem tsmManager_Branch;
    }
}

