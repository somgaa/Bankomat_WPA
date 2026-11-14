namespace Bankomat_WPA
{
    partial class LatestOperations
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Oперация = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Дата = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Час = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Сума = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblPage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMainMenu
            // 
            this.lblMainMenu.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblMainMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F);
            this.lblMainMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMainMenu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMainMenu.Location = new System.Drawing.Point(0, 0);
            this.lblMainMenu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMainMenu.Name = "lblMainMenu";
            this.lblMainMenu.Size = new System.Drawing.Size(857, 72);
            this.lblMainMenu.TabIndex = 1;
            this.lblMainMenu.Text = "Последни операции";
            this.lblMainMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Oперация,
            this.Дата,
            this.Час,
            this.Сума});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 103);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(726, 249);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Oперация
            // 
            this.Oперация.Text = "Oперация";
            this.Oперация.Width = 260;
            // 
            // Дата
            // 
            this.Дата.Text = "Дата";
            this.Дата.Width = 170;
            // 
            // Час
            // 
            this.Час.Text = "Час";
            this.Час.Width = 140;
            // 
            // Сума
            // 
            this.Сума.Text = "Сума";
            this.Сума.Width = 150;
            // 
            // btnUp
            // 
            this.btnUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUp.AutoSize = true;
            this.btnUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUp.Location = new System.Drawing.Point(757, 103);
            this.btnUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(89, 68);
            this.btnUp.TabIndex = 76;
            this.btnUp.Text = "↑";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDown.AutoSize = true;
            this.btnDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDown.Location = new System.Drawing.Point(757, 284);
            this.btnDown.Margin = new System.Windows.Forms.Padding(2);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(89, 68);
            this.btnDown.TabIndex = 77;
            this.btnDown.Text = "↓";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(11, 370);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 68);
            this.button1.TabIndex = 91;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPage
            // 
            this.lblPage.AllowDrop = true;
            this.lblPage.AutoEllipsis = true;
            this.lblPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPage.Location = new System.Drawing.Point(756, 189);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(89, 76);
            this.lblPage.TabIndex = 92;
            this.lblPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPage.Click += new System.EventHandler(this.lblPage_Click);
            // 
            // LatestOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(857, 449);
            this.Controls.Add(this.lblPage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lblMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LatestOperations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LatestOperations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMainMenu;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Oперация;
        private System.Windows.Forms.ColumnHeader Дата;
        private System.Windows.Forms.ColumnHeader Час;
        private System.Windows.Forms.ColumnHeader Сума;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblPage;
    }
}