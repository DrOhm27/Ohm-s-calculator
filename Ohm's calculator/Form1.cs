using Microsoft.VisualBasic.ApplicationServices;
using System.Xml.Serialization;

namespace WinFormsApp2;

public partial class Form1 : Form
{

    bool choice1 = false;
    bool choice2 = false;
    bool choice3 = false;
    bool choice4 = false;
    double sum = 0;
    double memory = 0;

    public Form1() { InitializeComponent(); }



    private void button1_Click(object sender, EventArgs e)
    {
        string text1 = textBox1.Text;
        string text2 = textBox2.Text;
        int num1 = Int32.Parse(text1);
        int num2 = Int32.Parse(text2);

        if (choice1 == true)
        {
            sum = num1 + num2;
        }
        else if (choice2 == true)
        {
            sum = num1 - num2;
        }
        else if (choice3 == true)
        {
            sum = num1 * num2;
        }
        else if (choice4 == true)
        {
            sum = num1 / num2;
        }
        else
        {
            MessageBox.Show("Error! No operation selected!");
        }



        for (int i = 0; i <= 100; i++)
        {
            for (int j = 0; j <= 100; j++)
            {
                progressBar1.Value = j;

                if (progressBar1.Value == 100)
                {
                    string text_sum = Convert.ToString(sum);
                    MessageBox.Show(text_sum);
                    break;
                }

            }
            break;

        }
        progressBar1.Value = 0;
        choice1 = false;
        choice2 = false;
        choice3 = false;
        choice4 = false;
    }

    private void progressBar1_Click(object sender, EventArgs e)
    {
    }

    private void button2_Click(object sender, EventArgs e)
    {
        choice1 = true;
    }

    private void button3_Click(object sender, EventArgs e)
    {
        choice2 = true;
    }

    private void button4_Click(object sender, EventArgs e)
    {
        choice3 = true;
    }

    private void button5_Click(object sender, EventArgs e)
    {
        choice4 = true;
    }

    private void button6_Click(object sender, EventArgs e)
    {
        memory = sum;
    }

    private void button8_Click(object sender, EventArgs e)
    {
        string memory_text = Convert.ToString(memory);
        label1.Text = memory_text;
    }

    private void button7_Click(object sender, EventArgs e)
    {
        memory = 0;
    }



    private void checkBox2_CheckedChanged(object sender, EventArgs e)
    {
        Image backgroun2 = new Bitmap(@"C:\Users\EM\source\repos\WinFormsApp2\MyPictures\background2.jpg");
        this.BackgroundImage = backgroun2;
    }

    private void button9_Click(object sender, EventArgs e)
    {
        Image backgroun1 = new Bitmap(@"C:\Users\EM\source\repos\WinFormsApp2\MyPictures\background1.jpg");
        this.BackgroundImage = backgroun1;
    }

    private void button10_Click(object sender, EventArgs e)
    {
        Image backgroun2 = new Bitmap(@"C:\Users\EM\source\repos\WinFormsApp2\MyPictures\background2.jpg");
        this.BackgroundImage = backgroun2;
    }
}