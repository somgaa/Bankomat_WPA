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
            this.lblMainMenu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnChangePIN = new System.Windows.Forms.Button();
            this.btnLatestOperations = new System.Windows.Forms.Button();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.btnCheckBalance = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMainMenu
            // 
            this.lblMainMenu.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblMainMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMainMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMainMenu.Location = new System.Drawing.Point(0, 0);
            this.lblMainMenu.Name = "lblMainMenu";
            this.lblMainMenu.Size = new System.Drawing.Size(1112, 57);
            this.lblMainMenu.TabIndex = 0;
            this.lblMainMenu.Text = "Главно Меню";
            this.lblMainMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(0, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1112, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Моля, изберете опция";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.AutoSize = true;
            this.btnWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnWithdraw.Location = new System.Drawing.Point(12, 120);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(293, 101);
            this.btnWithdraw.TabIndex = 2;
            this.btnWithdraw.Text = "Теглене на пари";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            // 
            // btnDeposit
            // 
            this.btnDeposit.AutoSize = true;
            this.btnDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeposit.Location = new System.Drawing.Point(12, 308);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(293, 101);
            this.btnDeposit.TabIndex = 3;
            this.btnDeposit.Text = "Внасяне на пари";
            this.btnDeposit.UseVisualStyleBackColor = true;
            // 
            // btnChangePIN
            // 
            this.btnChangePIN.AutoSize = true;
            this.btnChangePIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChangePIN.Location = new System.Drawing.Point(12, 512);
            this.btnChangePIN.Name = "btnChangePIN";
            this.btnChangePIN.Size = new System.Drawing.Size(293, 101);
            this.btnChangePIN.TabIndex = 4;
            this.btnChangePIN.Text = "Смяна на ПИН";
            this.btnChangePIN.UseVisualStyleBackColor = true;
            // 
            // btnLatestOperations
            // 
            this.btnLatestOperations.AutoSize = true;
            this.btnLatestOperations.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLatestOperations.Location = new System.Drawing.Point(732, 512);
            this.btnLatestOperations.Name = "btnLatestOperations";
            this.btnLatestOperations.Size = new System.Drawing.Size(367, 101);
            this.btnLatestOperations.TabIndex = 7;
            this.btnLatestOperations.Text = "Последни операции";
            this.btnLatestOperations.UseVisualStyleBackColor = true;
            // 
            // btnTransaction
            // 
            this.btnTransaction.AutoSize = true;
            this.btnTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTransaction.Location = new System.Drawing.Point(732, 308);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(367, 101);
            this.btnTransaction.TabIndex = 6;
            this.btnTransaction.Text = "Преводи на следства";
            this.btnTransaction.UseVisualStyleBackColor = true;
            // 
            // btnCheckBalance
            // 
            this.btnCheckBalance.AutoSize = true;
            this.btnCheckBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCheckBalance.Location = new System.Drawing.Point(732, 120);
            this.btnCheckBalance.Name = "btnCheckBalance";
            this.btnCheckBalance.Size = new System.Drawing.Size(367, 101);
            this.btnCheckBalance.TabIndex = 5;
            this.btnCheckBalance.Text = "Провери баланс";
            this.btnCheckBalance.UseVisualStyleBackColor = true;
            // 
            // StartATM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1112, 637);
            this.Controls.Add(this.btnLatestOperations);
            this.Controls.Add(this.btnTransaction);
            this.Controls.Add(this.btnCheckBalance);
            this.Controls.Add(this.btnChangePIN);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMainMenu);
            this.Name = "StartATM";
            this.Text = "StartATM";
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
    }
}