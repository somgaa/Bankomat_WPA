namespace Bankomat_WPA
{
    partial class StartATM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartATM));
            this.lblMainMenu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnChangePIN = new System.Windows.Forms.Button();
            this.btnLatestOperations = new System.Windows.Forms.Button();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.btnCheckBalance = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMainMenu
            // 
            this.lblMainMenu.BackColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.lblMainMenu, "lblMainMenu");
            this.lblMainMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMainMenu.Name = "lblMainMenu";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Name = "label1";
            // 
            // btnWithdraw
            // 
            resources.ApplyResources(this.btnWithdraw, "btnWithdraw");
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnDeposit
            // 
            resources.ApplyResources(this.btnDeposit, "btnDeposit");
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnChangePIN
            // 
            resources.ApplyResources(this.btnChangePIN, "btnChangePIN");
            this.btnChangePIN.Name = "btnChangePIN";
            this.btnChangePIN.UseVisualStyleBackColor = true;
            this.btnChangePIN.Click += new System.EventHandler(this.btnChangePIN_Click);
            // 
            // btnLatestOperations
            // 
            resources.ApplyResources(this.btnLatestOperations, "btnLatestOperations");
            this.btnLatestOperations.Name = "btnLatestOperations";
            this.btnLatestOperations.UseVisualStyleBackColor = true;
            this.btnLatestOperations.Click += new System.EventHandler(this.btnLatestOperations_Click);
            // 
            // btnTransaction
            // 
            resources.ApplyResources(this.btnTransaction, "btnTransaction");
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.UseVisualStyleBackColor = true;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // btnCheckBalance
            // 
            resources.ApplyResources(this.btnCheckBalance, "btnCheckBalance");
            this.btnCheckBalance.Name = "btnCheckBalance";
            this.btnCheckBalance.UseVisualStyleBackColor = true;
            this.btnCheckBalance.Click += new System.EventHandler(this.btnCheckBalance_Click);
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // StartATM
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLatestOperations);
            this.Controls.Add(this.btnTransaction);
            this.Controls.Add(this.btnCheckBalance);
            this.Controls.Add(this.btnChangePIN);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StartATM";
            this.Load += new System.EventHandler(this.StartATM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMainMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnChangePIN;
        private System.Windows.Forms.Button btnLatestOperations;
        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.Button btnCheckBalance;
        private System.Windows.Forms.Button btnExit;
    }
}