namespace Clicker
{
    partial class Clicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clicker));
            this.clickMeButton = new System.Windows.Forms.Button();
            this.numClickLabel = new System.Windows.Forms.Label();
            this.upgradeButton = new System.Windows.Forms.Button();
            this.currentLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.autoClickButton = new System.Windows.Forms.Button();
            this.perClickLabel = new System.Windows.Forms.Label();
            this.upgradeClickLabel = new System.Windows.Forms.Label();
            this.currentAutoClick = new System.Windows.Forms.Label();
            this.upgradeCostAuto = new System.Windows.Forms.Label();
            this.clickerTimer = new System.Windows.Forms.Timer(this.components);
            this.autoClickButton2 = new System.Windows.Forms.Button();
            this.autoClick2Current = new System.Windows.Forms.Label();
            this.autoClick2Cost = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.dummyButton = new System.Windows.Forms.Button();
            this.Auto3Cost = new System.Windows.Forms.Label();
            this.Auto3Current = new System.Windows.Forms.Label();
            this.Auto3Button = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clickMeButton
            // 
            this.clickMeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clickMeButton.Location = new System.Drawing.Point(12, 49);
            this.clickMeButton.Name = "clickMeButton";
            this.clickMeButton.Size = new System.Drawing.Size(315, 61);
            this.clickMeButton.TabIndex = 0;
            this.clickMeButton.TabStop = false;
            this.clickMeButton.Text = "Click Me";
            this.clickMeButton.UseVisualStyleBackColor = true;
            this.clickMeButton.Click += new System.EventHandler(this.clickMeButton_Click);
            // 
            // numClickLabel
            // 
            this.numClickLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numClickLabel.Location = new System.Drawing.Point(12, 9);
            this.numClickLabel.Name = "numClickLabel";
            this.numClickLabel.Size = new System.Drawing.Size(315, 37);
            this.numClickLabel.TabIndex = 1;
            this.numClickLabel.Text = "0";
            this.numClickLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // upgradeButton
            // 
            this.upgradeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.upgradeButton.Location = new System.Drawing.Point(12, 137);
            this.upgradeButton.Name = "upgradeButton";
            this.upgradeButton.Size = new System.Drawing.Size(125, 49);
            this.upgradeButton.TabIndex = 2;
            this.upgradeButton.TabStop = false;
            this.upgradeButton.Text = "Upgrade Click Amount";
            this.upgradeButton.UseVisualStyleBackColor = true;
            this.upgradeButton.Click += new System.EventHandler(this.upgradeButton_Click);
            // 
            // currentLabel
            // 
            this.currentLabel.AutoSize = true;
            this.currentLabel.Location = new System.Drawing.Point(167, 121);
            this.currentLabel.Name = "currentLabel";
            this.currentLabel.Size = new System.Drawing.Size(41, 13);
            this.currentLabel.TabIndex = 3;
            this.currentLabel.Text = "Current";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(251, 121);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(28, 13);
            this.costLabel.TabIndex = 4;
            this.costLabel.Text = "Cost";
            // 
            // autoClickButton
            // 
            this.autoClickButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.autoClickButton.Location = new System.Drawing.Point(12, 192);
            this.autoClickButton.Name = "autoClickButton";
            this.autoClickButton.Size = new System.Drawing.Size(125, 49);
            this.autoClickButton.TabIndex = 5;
            this.autoClickButton.TabStop = false;
            this.autoClickButton.Text = "Buy AutoClick 1";
            this.autoClickButton.UseVisualStyleBackColor = true;
            this.autoClickButton.Click += new System.EventHandler(this.autoClickButton_Click);
            // 
            // perClickLabel
            // 
            this.perClickLabel.AutoSize = true;
            this.perClickLabel.Location = new System.Drawing.Point(179, 155);
            this.perClickLabel.Name = "perClickLabel";
            this.perClickLabel.Size = new System.Drawing.Size(13, 13);
            this.perClickLabel.TabIndex = 7;
            this.perClickLabel.Text = "1";
            this.perClickLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // upgradeClickLabel
            // 
            this.upgradeClickLabel.AutoSize = true;
            this.upgradeClickLabel.Location = new System.Drawing.Point(251, 155);
            this.upgradeClickLabel.Name = "upgradeClickLabel";
            this.upgradeClickLabel.Size = new System.Drawing.Size(19, 13);
            this.upgradeClickLabel.TabIndex = 8;
            this.upgradeClickLabel.Text = "20";
            this.upgradeClickLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentAutoClick
            // 
            this.currentAutoClick.AutoSize = true;
            this.currentAutoClick.Location = new System.Drawing.Point(179, 210);
            this.currentAutoClick.Name = "currentAutoClick";
            this.currentAutoClick.Size = new System.Drawing.Size(13, 13);
            this.currentAutoClick.TabIndex = 9;
            this.currentAutoClick.Text = "0";
            this.currentAutoClick.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // upgradeCostAuto
            // 
            this.upgradeCostAuto.AutoSize = true;
            this.upgradeCostAuto.Location = new System.Drawing.Point(251, 210);
            this.upgradeCostAuto.Name = "upgradeCostAuto";
            this.upgradeCostAuto.Size = new System.Drawing.Size(25, 13);
            this.upgradeCostAuto.TabIndex = 10;
            this.upgradeCostAuto.Text = "100";
            this.upgradeCostAuto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clickerTimer
            // 
            this.clickerTimer.Enabled = true;
            this.clickerTimer.Tick += new System.EventHandler(this.clickerTimer_Tick);
            // 
            // autoClickButton2
            // 
            this.autoClickButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.autoClickButton2.Location = new System.Drawing.Point(12, 247);
            this.autoClickButton2.Name = "autoClickButton2";
            this.autoClickButton2.Size = new System.Drawing.Size(125, 49);
            this.autoClickButton2.TabIndex = 11;
            this.autoClickButton2.TabStop = false;
            this.autoClickButton2.Text = "Buy AutoClick 100";
            this.autoClickButton2.UseVisualStyleBackColor = true;
            this.autoClickButton2.Click += new System.EventHandler(this.autoClickButton2_Click);
            // 
            // autoClick2Current
            // 
            this.autoClick2Current.AutoSize = true;
            this.autoClick2Current.Location = new System.Drawing.Point(179, 265);
            this.autoClick2Current.Name = "autoClick2Current";
            this.autoClick2Current.Size = new System.Drawing.Size(13, 13);
            this.autoClick2Current.TabIndex = 12;
            this.autoClick2Current.Text = "0";
            this.autoClick2Current.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // autoClick2Cost
            // 
            this.autoClick2Cost.AutoSize = true;
            this.autoClick2Cost.Location = new System.Drawing.Point(251, 265);
            this.autoClick2Cost.Name = "autoClick2Cost";
            this.autoClick2Cost.Size = new System.Drawing.Size(37, 13);
            this.autoClick2Cost.TabIndex = 13;
            this.autoClick2Cost.Text = "10000";
            this.autoClick2Cost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saveButton
            // 
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.Location = new System.Drawing.Point(12, 363);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 14;
            this.saveButton.TabStop = false;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadButton.Location = new System.Drawing.Point(133, 363);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 15;
            this.loadButton.TabStop = false;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // dummyButton
            // 
            this.dummyButton.Location = new System.Drawing.Point(197, 204);
            this.dummyButton.Name = "dummyButton";
            this.dummyButton.Size = new System.Drawing.Size(0, 0);
            this.dummyButton.TabIndex = 16;
            this.dummyButton.UseVisualStyleBackColor = true;
            // 
            // Auto3Cost
            // 
            this.Auto3Cost.AutoSize = true;
            this.Auto3Cost.Location = new System.Drawing.Point(251, 320);
            this.Auto3Cost.Name = "Auto3Cost";
            this.Auto3Cost.Size = new System.Drawing.Size(55, 13);
            this.Auto3Cost.TabIndex = 19;
            this.Auto3Cost.Text = "10000000";
            this.Auto3Cost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Auto3Current
            // 
            this.Auto3Current.AutoSize = true;
            this.Auto3Current.Location = new System.Drawing.Point(179, 320);
            this.Auto3Current.Name = "Auto3Current";
            this.Auto3Current.Size = new System.Drawing.Size(13, 13);
            this.Auto3Current.TabIndex = 18;
            this.Auto3Current.Text = "0";
            this.Auto3Current.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Auto3Button
            // 
            this.Auto3Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Auto3Button.Location = new System.Drawing.Point(12, 302);
            this.Auto3Button.Name = "Auto3Button";
            this.Auto3Button.Size = new System.Drawing.Size(125, 49);
            this.Auto3Button.TabIndex = 17;
            this.Auto3Button.TabStop = false;
            this.Auto3Button.Text = "Buy AutoClick 10000";
            this.Auto3Button.UseVisualStyleBackColor = true;
            this.Auto3Button.Click += new System.EventHandler(this.Auto3Button_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(252, 363);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 20;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // Clicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 398);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.Auto3Cost);
            this.Controls.Add(this.Auto3Current);
            this.Controls.Add(this.Auto3Button);
            this.Controls.Add(this.dummyButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.autoClick2Cost);
            this.Controls.Add(this.autoClick2Current);
            this.Controls.Add(this.autoClickButton2);
            this.Controls.Add(this.upgradeCostAuto);
            this.Controls.Add(this.currentAutoClick);
            this.Controls.Add(this.upgradeClickLabel);
            this.Controls.Add(this.perClickLabel);
            this.Controls.Add(this.autoClickButton);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.currentLabel);
            this.Controls.Add(this.upgradeButton);
            this.Controls.Add(this.numClickLabel);
            this.Controls.Add(this.clickMeButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(355, 436);
            this.MinimumSize = new System.Drawing.Size(355, 436);
            this.Name = "Clicker";
            this.Text = " Click Me";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clickMeButton;
        private System.Windows.Forms.Label numClickLabel;
        private System.Windows.Forms.Button upgradeButton;
        private System.Windows.Forms.Label currentLabel;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Button autoClickButton;
        private System.Windows.Forms.Label upgradeClickLabel;
        private System.Windows.Forms.Label currentAutoClick;
        private System.Windows.Forms.Label upgradeCostAuto;
        private System.Windows.Forms.Label perClickLabel;
        private System.Windows.Forms.Timer clickerTimer;
        private System.Windows.Forms.Button autoClickButton2;
        private System.Windows.Forms.Label autoClick2Current;
        private System.Windows.Forms.Label autoClick2Cost;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button dummyButton;
        private System.Windows.Forms.Label Auto3Cost;
        private System.Windows.Forms.Label Auto3Current;
        private System.Windows.Forms.Button Auto3Button;
        private System.Windows.Forms.Button resetButton;
    }
}

