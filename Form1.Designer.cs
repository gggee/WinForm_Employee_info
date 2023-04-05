namespace WindowsFormsApp3
{
  partial class Form1
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
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.txtHouse = new System.Windows.Forms.TextBox();
      this.cboxStreet = new System.Windows.Forms.ComboBox();
      this.cboxCity = new System.Windows.Forms.ComboBox();
      this.txtFIO = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.chkBonus = new System.Windows.Forms.CheckBox();
      this.mtxtSalary = new System.Windows.Forms.MaskedTextBox();
      this.cboxPosition = new System.Windows.Forms.ComboBox();
      this.label6 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.btnSave = new System.Windows.Forms.Button();
      this.btnClose = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox1.Controls.Add(this.txtHouse);
      this.groupBox1.Controls.Add(this.cboxStreet);
      this.groupBox1.Controls.Add(this.cboxCity);
      this.groupBox1.Controls.Add(this.txtFIO);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Location = new System.Drawing.Point(18, 18);
      this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.groupBox1.Size = new System.Drawing.Size(703, 223);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = " Requisites";
      // 
      // txtHouse
      // 
      this.txtHouse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtHouse.Location = new System.Drawing.Point(109, 154);
      this.txtHouse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.txtHouse.Name = "txtHouse";
      this.txtHouse.Size = new System.Drawing.Size(174, 27);
      this.txtHouse.TabIndex = 3;
      // 
      // cboxStreet
      // 
      this.cboxStreet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.cboxStreet.FormattingEnabled = true;
      this.cboxStreet.Items.AddRange(new object[] {
            "Syganak",
            "Mailina",
            "Mangilik El",
            "Pushkin",
            "Tauelsyzdyk",
            "Dostyk",
            "Kenesary",
            "Koshkarbaeva"});
      this.cboxStreet.Location = new System.Drawing.Point(109, 113);
      this.cboxStreet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.cboxStreet.Name = "cboxStreet";
      this.cboxStreet.Size = new System.Drawing.Size(571, 27);
      this.cboxStreet.TabIndex = 2;
      // 
      // cboxCity
      // 
      this.cboxCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.cboxCity.FormattingEnabled = true;
      this.cboxCity.Items.AddRange(new object[] {
            "Astana",
            "Almaty",
            "Semey",
            "Shymkent",
            "Kyzylorda",
            "Pavlodar",
            "Jambyl",
            "Akmola",
            "Aktobe",
            "Atyrau"});
      this.cboxCity.Location = new System.Drawing.Point(109, 74);
      this.cboxCity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.cboxCity.Name = "cboxCity";
      this.cboxCity.Size = new System.Drawing.Size(571, 27);
      this.cboxCity.TabIndex = 1;
      // 
      // txtFIO
      // 
      this.txtFIO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtFIO.Location = new System.Drawing.Point(109, 36);
      this.txtFIO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.txtFIO.Name = "txtFIO";
      this.txtFIO.Size = new System.Drawing.Size(571, 27);
      this.txtFIO.TabIndex = 0;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label4.Location = new System.Drawing.Point(19, 159);
      this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(76, 19);
      this.label4.TabIndex = 3;
      this.label4.Text = "№ home: ";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label3.Location = new System.Drawing.Point(33, 119);
      this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(59, 19);
      this.label3.TabIndex = 2;
      this.label3.Text = "Street: ";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label2.Location = new System.Drawing.Point(36, 77);
      this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(47, 19);
      this.label2.TabIndex = 1;
      this.label2.Text = "City: ";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(40, 39);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(44, 19);
      this.label1.TabIndex = 0;
      this.label1.Text = "FIO: ";
      // 
      // groupBox2
      // 
      this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox2.Controls.Add(this.chkBonus);
      this.groupBox2.Controls.Add(this.mtxtSalary);
      this.groupBox2.Controls.Add(this.cboxPosition);
      this.groupBox2.Controls.Add(this.label6);
      this.groupBox2.Controls.Add(this.label5);
      this.groupBox2.Location = new System.Drawing.Point(18, 265);
      this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.groupBox2.Size = new System.Drawing.Size(703, 249);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = " Job Information";
      // 
      // chkBonus
      // 
      this.chkBonus.AutoSize = true;
      this.chkBonus.Location = new System.Drawing.Point(109, 139);
      this.chkBonus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.chkBonus.Name = "chkBonus";
      this.chkBonus.Size = new System.Drawing.Size(74, 23);
      this.chkBonus.TabIndex = 2;
      this.chkBonus.Text = "Bonus";
      this.chkBonus.UseVisualStyleBackColor = true;
      // 
      // mtxtSalary
      // 
      this.mtxtSalary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.mtxtSalary.Location = new System.Drawing.Point(109, 88);
      this.mtxtSalary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.mtxtSalary.Name = "mtxtSalary";
      this.mtxtSalary.Size = new System.Drawing.Size(172, 27);
      this.mtxtSalary.TabIndex = 1;
      // 
      // cboxPosition
      // 
      this.cboxPosition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.cboxPosition.FormattingEnabled = true;
      this.cboxPosition.Items.AddRange(new object[] {
            "Director",
            "Manager",
            "Administrator",
            "Accountant",
            "Engineer",
            "Mechanic",
            "Technician",
            "Economist"});
      this.cboxPosition.Location = new System.Drawing.Point(109, 40);
      this.cboxPosition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.cboxPosition.Name = "cboxPosition";
      this.cboxPosition.Size = new System.Drawing.Size(548, 27);
      this.cboxPosition.TabIndex = 0;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label6.Location = new System.Drawing.Point(32, 95);
      this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(56, 19);
      this.label6.TabIndex = 1;
      this.label6.Text = "Salary:";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label5.Location = new System.Drawing.Point(24, 50);
      this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(70, 19);
      this.label5.TabIndex = 0;
      this.label5.Text = "Job title:";
      // 
      // btnSave
      // 
      this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnSave.Location = new System.Drawing.Point(462, 549);
      this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(112, 33);
      this.btnSave.TabIndex = 2;
      this.btnSave.Text = "&Save";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // btnClose
      // 
      this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnClose.Location = new System.Drawing.Point(609, 549);
      this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(112, 33);
      this.btnClose.TabIndex = 4;
      this.btnClose.Text = "&Close";
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(739, 600);
      this.Controls.Add(this.btnClose);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.MinimumSize = new System.Drawing.Size(741, 562);
      this.Name = "Form1";
      this.Text = "Employee information";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtHouse;
    private System.Windows.Forms.ComboBox cboxStreet;
    private System.Windows.Forms.ComboBox cboxCity;
    private System.Windows.Forms.TextBox txtFIO;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.CheckBox chkBonus;
    private System.Windows.Forms.MaskedTextBox mtxtSalary;
    private System.Windows.Forms.ComboBox cboxPosition;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Button btnClose;
  }
}

