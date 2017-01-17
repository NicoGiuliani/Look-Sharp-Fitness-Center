namespace Look_Sharp_Fitness_Center
{
  partial class frmLSFC
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLSFC));
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.radTwentyOunce = new System.Windows.Forms.RadioButton();
      this.radSixteenOunce = new System.Windows.Forms.RadioButton();
      this.radTwelveOunce = new System.Windows.Forms.RadioButton();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.chkVitaminPack = new System.Windows.Forms.CheckBox();
      this.chkEnergyBooster = new System.Windows.Forms.CheckBox();
      this.chkForTheLadies = new System.Windows.Forms.CheckBox();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.radWheatBerry = new System.Windows.Forms.RadioButton();
      this.radStrawberryBanana = new System.Windows.Forms.RadioButton();
      this.radPomegranate = new System.Windows.Forms.RadioButton();
      this.radVeggie = new System.Windows.Forms.RadioButton();
      this.radFruit = new System.Windows.Forms.RadioButton();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.txtItemPrice = new System.Windows.Forms.TextBox();
      this.btnAddToOrder = new System.Windows.Forms.Button();
      this.btnOrderComplete = new System.Windows.Forms.Button();
      this.btnSummaryReport = new System.Windows.Forms.Button();
      this.btnExit = new System.Windows.Forms.Button();
      this.txtQuantity = new System.Windows.Forms.TextBox();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.radTwentyOunce);
      this.groupBox1.Controls.Add(this.radSixteenOunce);
      this.groupBox1.Controls.Add(this.radTwelveOunce);
      this.groupBox1.Location = new System.Drawing.Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(200, 100);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Size";
      // 
      // radTwentyOunce
      // 
      this.radTwentyOunce.AutoSize = true;
      this.radTwentyOunce.Location = new System.Drawing.Point(11, 62);
      this.radTwentyOunce.Name = "radTwentyOunce";
      this.radTwentyOunce.Size = new System.Drawing.Size(96, 17);
      this.radTwentyOunce.TabIndex = 2;
      this.radTwentyOunce.Text = "20 Ounce 4.00";
      this.radTwentyOunce.UseVisualStyleBackColor = true;
      this.radTwentyOunce.CheckedChanged += new System.EventHandler(this.radTwentyOunce_CheckedChanged);
      // 
      // radSixteenOunce
      // 
      this.radSixteenOunce.AutoSize = true;
      this.radSixteenOunce.Location = new System.Drawing.Point(11, 39);
      this.radSixteenOunce.Name = "radSixteenOunce";
      this.radSixteenOunce.Size = new System.Drawing.Size(96, 17);
      this.radSixteenOunce.TabIndex = 1;
      this.radSixteenOunce.Text = "16 Ounce 3.50";
      this.radSixteenOunce.UseVisualStyleBackColor = true;
      this.radSixteenOunce.CheckedChanged += new System.EventHandler(this.radSixteenOunce_CheckedChanged);
      // 
      // radTwelveOunce
      // 
      this.radTwelveOunce.AutoSize = true;
      this.radTwelveOunce.Location = new System.Drawing.Point(11, 16);
      this.radTwelveOunce.Name = "radTwelveOunce";
      this.radTwelveOunce.Size = new System.Drawing.Size(96, 17);
      this.radTwelveOunce.TabIndex = 0;
      this.radTwelveOunce.Text = "12 Ounce 3.00";
      this.radTwelveOunce.UseVisualStyleBackColor = true;
      this.radTwelveOunce.CheckedChanged += new System.EventHandler(this.radTwelveOunce_CheckedChanged);
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.chkVitaminPack);
      this.groupBox2.Controls.Add(this.chkEnergyBooster);
      this.groupBox2.Controls.Add(this.chkForTheLadies);
      this.groupBox2.Location = new System.Drawing.Point(12, 118);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(200, 100);
      this.groupBox2.TabIndex = 0;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Extras - $0.50 each";
      // 
      // chkVitaminPack
      // 
      this.chkVitaminPack.AutoSize = true;
      this.chkVitaminPack.Enabled = false;
      this.chkVitaminPack.Location = new System.Drawing.Point(11, 19);
      this.chkVitaminPack.Name = "chkVitaminPack";
      this.chkVitaminPack.Size = new System.Drawing.Size(88, 17);
      this.chkVitaminPack.TabIndex = 3;
      this.chkVitaminPack.Text = "Vitamin Pack";
      this.chkVitaminPack.UseVisualStyleBackColor = true;
      this.chkVitaminPack.CheckedChanged += new System.EventHandler(this.chkVitaminPack_CheckedChanged);
      // 
      // chkEnergyBooster
      // 
      this.chkEnergyBooster.AutoSize = true;
      this.chkEnergyBooster.Enabled = false;
      this.chkEnergyBooster.Location = new System.Drawing.Point(11, 44);
      this.chkEnergyBooster.Name = "chkEnergyBooster";
      this.chkEnergyBooster.Size = new System.Drawing.Size(98, 17);
      this.chkEnergyBooster.TabIndex = 4;
      this.chkEnergyBooster.Text = "Energy Booster";
      this.chkEnergyBooster.UseVisualStyleBackColor = true;
      this.chkEnergyBooster.CheckedChanged += new System.EventHandler(this.chkEnergyBooster_CheckedChanged);
      // 
      // chkForTheLadies
      // 
      this.chkForTheLadies.AutoSize = true;
      this.chkForTheLadies.Enabled = false;
      this.chkForTheLadies.Location = new System.Drawing.Point(11, 68);
      this.chkForTheLadies.Name = "chkForTheLadies";
      this.chkForTheLadies.Size = new System.Drawing.Size(93, 17);
      this.chkForTheLadies.TabIndex = 5;
      this.chkForTheLadies.Text = "For the Ladies";
      this.chkForTheLadies.UseVisualStyleBackColor = true;
      this.chkForTheLadies.CheckedChanged += new System.EventHandler(this.chkForTheLadies_CheckedChanged);
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.radWheatBerry);
      this.groupBox3.Controls.Add(this.radStrawberryBanana);
      this.groupBox3.Controls.Add(this.radPomegranate);
      this.groupBox3.Controls.Add(this.radVeggie);
      this.groupBox3.Controls.Add(this.radFruit);
      this.groupBox3.Controls.Add(this.label2);
      this.groupBox3.Controls.Add(this.label1);
      this.groupBox3.Location = new System.Drawing.Point(272, 12);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(184, 179);
      this.groupBox3.TabIndex = 0;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Select the drink type";
      // 
      // radWheatBerry
      // 
      this.radWheatBerry.AutoSize = true;
      this.radWheatBerry.Location = new System.Drawing.Point(31, 150);
      this.radWheatBerry.Name = "radWheatBerry";
      this.radWheatBerry.Size = new System.Drawing.Size(81, 17);
      this.radWheatBerry.TabIndex = 7;
      this.radWheatBerry.Text = "WheatBerry";
      this.radWheatBerry.UseVisualStyleBackColor = true;
      this.radWheatBerry.CheckedChanged += new System.EventHandler(this.radWheatBerry_CheckedChanged);
      // 
      // radStrawberryBanana
      // 
      this.radStrawberryBanana.AutoSize = true;
      this.radStrawberryBanana.Location = new System.Drawing.Point(31, 127);
      this.radStrawberryBanana.Name = "radStrawberryBanana";
      this.radStrawberryBanana.Size = new System.Drawing.Size(115, 17);
      this.radStrawberryBanana.TabIndex = 6;
      this.radStrawberryBanana.Text = "Strawberry Banana";
      this.radStrawberryBanana.UseVisualStyleBackColor = true;
      this.radStrawberryBanana.CheckedChanged += new System.EventHandler(this.radStrawberryBanana_CheckedChanged);
      // 
      // radPomegranate
      // 
      this.radPomegranate.AutoSize = true;
      this.radPomegranate.Location = new System.Drawing.Point(31, 103);
      this.radPomegranate.Name = "radPomegranate";
      this.radPomegranate.Size = new System.Drawing.Size(88, 17);
      this.radPomegranate.TabIndex = 5;
      this.radPomegranate.Text = "Pomegranate";
      this.radPomegranate.UseVisualStyleBackColor = true;
      this.radPomegranate.CheckedChanged += new System.EventHandler(this.radPomegranate_CheckedChanged);
      // 
      // radVeggie
      // 
      this.radVeggie.AutoSize = true;
      this.radVeggie.Location = new System.Drawing.Point(31, 62);
      this.radVeggie.Name = "radVeggie";
      this.radVeggie.Size = new System.Drawing.Size(58, 17);
      this.radVeggie.TabIndex = 4;
      this.radVeggie.Text = "Veggie";
      this.radVeggie.UseVisualStyleBackColor = true;
      this.radVeggie.CheckedChanged += new System.EventHandler(this.radVeggie_CheckedChanged);
      // 
      // radFruit
      // 
      this.radFruit.AutoSize = true;
      this.radFruit.Location = new System.Drawing.Point(31, 39);
      this.radFruit.Name = "radFruit";
      this.radFruit.Size = new System.Drawing.Size(45, 17);
      this.radFruit.TabIndex = 3;
      this.radFruit.Text = "Fruit";
      this.radFruit.UseVisualStyleBackColor = true;
      this.radFruit.CheckedChanged += new System.EventHandler(this.radFruit_CheckedChanged);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(6, 87);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(56, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Smoothies";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(6, 20);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(37, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Juices";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(20, 246);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(46, 13);
      this.label3.TabIndex = 1;
      this.label3.Text = "Quantity";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(20, 269);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(54, 13);
      this.label4.TabIndex = 2;
      this.label4.Text = "Item Price";
      // 
      // txtItemPrice
      // 
      this.txtItemPrice.Location = new System.Drawing.Point(73, 266);
      this.txtItemPrice.Name = "txtItemPrice";
      this.txtItemPrice.ReadOnly = true;
      this.txtItemPrice.Size = new System.Drawing.Size(100, 20);
      this.txtItemPrice.TabIndex = 4;
      this.txtItemPrice.TabStop = false;
      // 
      // btnAddToOrder
      // 
      this.btnAddToOrder.Location = new System.Drawing.Point(361, 197);
      this.btnAddToOrder.Name = "btnAddToOrder";
      this.btnAddToOrder.Size = new System.Drawing.Size(95, 23);
      this.btnAddToOrder.TabIndex = 5;
      this.btnAddToOrder.Text = "Add to Order";
      this.btnAddToOrder.UseVisualStyleBackColor = true;
      this.btnAddToOrder.Click += new System.EventHandler(this.btnAddToOrder_Click);
      // 
      // btnOrderComplete
      // 
      this.btnOrderComplete.Location = new System.Drawing.Point(361, 226);
      this.btnOrderComplete.Name = "btnOrderComplete";
      this.btnOrderComplete.Size = new System.Drawing.Size(95, 23);
      this.btnOrderComplete.TabIndex = 6;
      this.btnOrderComplete.Text = "Order Complete";
      this.btnOrderComplete.UseVisualStyleBackColor = true;
      this.btnOrderComplete.Click += new System.EventHandler(this.btnOrderComplete_Click);
      // 
      // btnSummaryReport
      // 
      this.btnSummaryReport.Location = new System.Drawing.Point(361, 255);
      this.btnSummaryReport.Name = "btnSummaryReport";
      this.btnSummaryReport.Size = new System.Drawing.Size(95, 23);
      this.btnSummaryReport.TabIndex = 7;
      this.btnSummaryReport.Text = "Summary Report";
      this.btnSummaryReport.UseVisualStyleBackColor = true;
      this.btnSummaryReport.Click += new System.EventHandler(this.btnSummaryReport_Click);
      // 
      // btnExit
      // 
      this.btnExit.Location = new System.Drawing.Point(361, 284);
      this.btnExit.Name = "btnExit";
      this.btnExit.Size = new System.Drawing.Size(95, 23);
      this.btnExit.TabIndex = 8;
      this.btnExit.Text = "Exit";
      this.btnExit.UseVisualStyleBackColor = true;
      this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
      // 
      // txtQuantity
      // 
      this.txtQuantity.Enabled = false;
      this.txtQuantity.Location = new System.Drawing.Point(72, 239);
      this.txtQuantity.Name = "txtQuantity";
      this.txtQuantity.Size = new System.Drawing.Size(39, 20);
      this.txtQuantity.TabIndex = 9;
      this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
      // 
      // frmLSFC
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.Highlight;
      this.ClientSize = new System.Drawing.Size(471, 317);
      this.Controls.Add(this.txtQuantity);
      this.Controls.Add(this.btnExit);
      this.Controls.Add(this.btnSummaryReport);
      this.Controls.Add(this.btnOrderComplete);
      this.Controls.Add(this.btnAddToOrder);
      this.Controls.Add(this.txtItemPrice);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.groupBox1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "frmLSFC";
      this.Text = "Look Sharp Fitness Center";
      this.Load += new System.EventHandler(this.frmLSFC_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.RadioButton radTwentyOunce;
    private System.Windows.Forms.RadioButton radSixteenOunce;
    private System.Windows.Forms.RadioButton radTwelveOunce;
    private System.Windows.Forms.CheckBox chkVitaminPack;
    private System.Windows.Forms.CheckBox chkEnergyBooster;
    private System.Windows.Forms.CheckBox chkForTheLadies;
    private System.Windows.Forms.RadioButton radWheatBerry;
    private System.Windows.Forms.RadioButton radStrawberryBanana;
    private System.Windows.Forms.RadioButton radPomegranate;
    private System.Windows.Forms.RadioButton radVeggie;
    private System.Windows.Forms.RadioButton radFruit;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtItemPrice;
    private System.Windows.Forms.Button btnAddToOrder;
    private System.Windows.Forms.Button btnOrderComplete;
    private System.Windows.Forms.Button btnSummaryReport;
    private System.Windows.Forms.Button btnExit;
    private System.Windows.Forms.TextBox txtQuantity;
  }
}

