using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonControl
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonGenerateButton.Text= "OK";

            int buttonWidth = 50;
            int buttonHeight = 100;
            int buttonColumnSize = 15;
            int buttonRowSize = 3;


            for (int i = 0; i < buttonColumnSize; i++)
            {
                for (int j = 0; j < buttonRowSize; j++)
                {
                    Button newButton = new Button();
                    newButton.Enabled = true;
                    newButton.Location = new Point(i * buttonWidth + buttonColumnSize, j* buttonHeight + buttonWidth);
                    newButton.Name = i.ToString()+"_"+j.ToString();
                    newButton.Text = "Button-" + (i + 1).ToString() +","+ (j + 1).ToString();
                    newButton.Size = new Size(buttonWidth, buttonHeight);
                    newButton.Tag = i.ToString() + "_" + j.ToString();
                    newButton.Click += NewButton_Click;
                    

                    this.Controls.Add(newButton);

                }

            }
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            MessageBox.Show("Button-"+button.Tag + " Clicked!!!");

        }
    }
}
