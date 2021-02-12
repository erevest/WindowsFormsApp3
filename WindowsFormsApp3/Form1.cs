using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

        private void button1_Click(object sender, EventArgs e)
        {
      button1.BackColor = System.Drawing.Color.Red;
    }

    private void button2_Click(object sender, EventArgs e)
    {
      button2.BackColor = System.Drawing.Color.Green;
    }

    private void button3_Click(object sender, EventArgs e)
    {
      button3.BackColor = System.Drawing.Color.Blue;
    }

    private void button4_Click(object sender, EventArgs e)
    {
      button4.BackColor = System.Drawing.Color.Yellow;
    }

    private void button5_Click(object sender, EventArgs e)
    {
      textBox1.Text = textBox1.Text= "******";
    }

    private void button6_Click(object sender, EventArgs e)
    {
      textBox1.Text = textBox1.Text = "";
    }



    static int x = 200;
    static int y = 200;
    private void button7_Click(object sender, EventArgs e)
    {
      // Create a new Form1 and set its Visible property to true.
      Form1 form2 = new Form1();
      form2.Visible = true;
      form2.BackColor = System.Drawing.Color.Yellow;
      textBox1.Text = textBox1.Text = "+++++";

      // Set the new form's desktop location so it  
      // appears below and to the right of the current form.
      form2.SetDesktopLocation(x, y);
      x += 30;
      y += 30;

      // Keep the current form active by calling the Activate
      // method.
      this.Activate();
      this.button7.Enabled = false;
    }
    // Updates the label text to reflect the current values of x 
    // and y, which was were incremented in the Button1 control's 
    // click event.
    private void Form1_Activated(object sender, System.EventArgs e)
    {
      label1.Text = "x: " + x + " y: " + y;
      label2.Text = "Number of forms currently open: " + count;
    }

    static int count = 0;

    private void Form1_Closed(object sender, System.EventArgs e)
    {
      count -= 1;
    }

    private void Form1_Load(object sender, System.EventArgs e)
    {
      count += 1;
      this.BackColor = System.Drawing.Color.Yellow;
    }

    private void button8_Click(object sender, EventArgs e)
    {
      button9.AutoSize = true;
      button9.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      button9.Location = new Point(
           button9.Location.X,
           button9.Location.Y);

      button9.Location = new Point(button9.Location.X + 2, button9.Location.X + 3);
    }

    private void button10_Click(object sender, EventArgs e)
    {
      button11.AutoSize = true;
      button11.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      button11.Location = new Point(
           button11.Location.X,
           button11.Location.Y);

      button11.Location = new Point(button11.Location.X + 2, button11.Location.X + 3);

    }

    private void button9_Click(object sender, EventArgs e)
    {
      button8.AutoSize = true;
      button8.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      button8.Location = new Point(
           button8.Location.X,
           button8.Location.Y);

      button8.Location = new Point(button8.Location.X + 2, button8.Location.X + 3);
    }

    private void button11_Click(object sender, EventArgs e)
    {
      button10.AutoSize = true;
      button10.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      button10.Location = new Point(
           button10.Location.X,
           button10.Location.Y);

      button10.Location = new Point(button10.Location.X + 2, button10.Location.X + 3);
    }
  }
}