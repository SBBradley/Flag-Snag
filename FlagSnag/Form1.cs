using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*A program that generates flags of the world.
 *Date: February 2, 2022
 */
namespace FlagSnag
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        //Click event for the single button on the form.
        private void button1_Click_1(object sender, EventArgs e)
        { 
            string countryName = textBox1.Text;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            /*Switch statement that will change the png
             picture to the user input country's national flag.*/
            switch (countryName)
            {
                case "United States":
                    pictureBox1.Image = Properties.Resources.USA;
                    break;
                case "Canada":
                    pictureBox1.Image = Properties.Resources.CANADA;
                    break;
                case "Mexico":
                    pictureBox1.Image = Properties.Resources.MEXICO;
                    break;
                case "Japan":
                    pictureBox1.Image = Properties.Resources.JAPAN;
                    break;
                case "South Korea":
                    pictureBox1.Image = Properties.Resources.SOUTHKOREA;
                    break;
                case "China":
                    pictureBox1.Image = Properties.Resources.CHINA;
                    break;
                case "Germany":
                    pictureBox1.Image = Properties.Resources.GERMANY;
                    break;
                case "United Kingdom":
                    pictureBox1.Image = Properties.Resources.UNITEDKINGDOM;
                    break;
                case "France":
                    pictureBox1.Image = Properties.Resources.FRANCE;
                    break;
                case "Russia":
                    pictureBox1.Image = Properties.Resources.RUSSIA;
                    break;
                default:
                    MessageBox.Show("Error: Invalid country name entered." + "\n"
                    +" (Please capitalize the first letter.)");
                    break;
            }
        }
    }
}
