using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp3 {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
    }

    private void btnSave_Click(object sender, EventArgs e) {
      using (StreamWriter sw = File.CreateText(Application.StartupPath + @"\" + "Employee.txt")) {
        sw.WriteLine("FIO: " + txtFIO.Text);
        sw.WriteLine("City: " + cboxCity.Text);
        sw.WriteLine("Street: " + cboxStreet.Text);
        sw.WriteLine("House: " + txtHouse.Text);
        sw.WriteLine("Position: " + cboxPosition.Text);
        sw.WriteLine("Salary: " + mtxtSalary.Text);
        sw.WriteLine("Bonus: " + chkBonus.Checked);

      }
    }
    private void btnClose_Click(object sender, EventArgs e) {
      this.Close();
    }
  }
}//ns
