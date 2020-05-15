using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Memory_Game.Forms;
using Memory_Game.Processes;
using System.Windows.Forms;

namespace Memory_Game.Forms
{
    public partial class frmDashboard : Form
    {
        public Int64 count;
        public Int64 c;
        public Int64 d;
        public Int64 f;

        public Int32 a;
        public Int32 b;
       
        public int rand;

        public Int64 val0;
        public Int64 val1;
        public Int64 val2;
        public Int64 val3;
        public Int64 val4;
        public Int64 val5;
        public Int64 val6;
        public Int64 val7;
        public Int64 val8;
        public Int64 val9;

        Queue<Int64> numberValue = new Queue<Int64>();

        public frmDashboard()
        {
            InitializeComponent();
            count = 0;
            count = c;
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            SetInvisiblepnlAnswer();

            lblPlayer1.Text = frmWelcome.Player1;
            lblPlayer2.Text = frmWelcome.Player2;
            lblDifficultyLevel.Text = frmWelcome.DifficultyLevel;

            bool turn = true;

                       
        }

        private void SetInvisiblepnlAnswer()
        {
            // Setting Answer Panel Invisible
            pnlAnswer.Visible = false;
        }

        private async void btnGenerate_Click(object sender, EventArgs e)
        {
            if(frmWelcome.Easy)
            {
                d = 3;
                Console.WriteLine($"The Value of d is " + d);

                //Generating a Random Number
                RandomGenerator generator = new RandomGenerator();
                
                a = Convert.ToInt32(Math.Pow(10, (d - 1)));
                Console.WriteLine($"The Value of a is " + a);

                b = Convert.ToInt32((Math.Pow(10, d)) - 1);
                Console.WriteLine($"The Value of b is " + b);

                rand = generator.RandomNumber(a, b);
                Console.WriteLine($"Random number between " + a + " and " + b + " is " +rand);

                // Show Generated Number in TextBox
                txtBxRandomNumber.Text = $"{rand}";

                // generated number disappears after 3 seconds
                await Task.Delay(3_000);
                txtBxRandomNumber.Text = string.Empty;

                // Setting Answer Panel Visible
                pnlAnswer.Visible = true;

                this.Controls.Add(txtBxRandomNumber);
            }
            else if (frmWelcome.Medium)
            {
                d = 6;
                Console.WriteLine($"The Value of d is " + d);

                //Generating a Random Number
                RandomGenerator generator = new RandomGenerator();

                a = Convert.ToInt32(Math.Pow(10, (d - 1)));
                Console.WriteLine($"The Value of a is " + a);

                b = Convert.ToInt32((Math.Pow(10, d)) - 1);
                Console.WriteLine($"The Value of b is " + b);

                rand = generator.RandomNumber(a, b);
                Console.WriteLine($"Random number between " + a + " and " + b + " is " + rand);

                // Show Generated Number in TextBox
                txtBxRandomNumber.Text = $"{rand}";

                // generated number disappears after 4 seconds
                await Task.Delay(4_000);
                txtBxRandomNumber.Text = string.Empty;

                // Setting Answer Panel Visible
                pnlAnswer.Visible = true;

                this.Controls.Add(txtBxRandomNumber);
            }
            else if (frmWelcome.Hard)
            {
                d = 10;
                Console.WriteLine($"The Value of d is " + d);

                if (d == 9)
                {                                    
                    //Generating a Random Number
                    RandomGenerator generator = new RandomGenerator();

                    a = Convert.ToInt32(Math.Pow(10, (d - 1)));
                    Console.WriteLine($"The Value of a is " + a);

                    b = Convert.ToInt32((Math.Pow(10, d)) - 1);
                    Console.WriteLine($"The Value of b is " + b);

                    rand = generator.RandomNumber(a, b);
                    Console.WriteLine($"Random number between " + a + " and " + b + " is " + rand);

                    // Show Generated Number in TextBox
                    txtBxRandomNumber.Text = $"{rand}";
                }
                else
                {
                    
                    d = 9;
                    Console.WriteLine($"The Value of d is " + d);

                    LongRandomGenerator generator = new LongRandomGenerator();

                    f = generator.LongRandomNumber();
                    Console.WriteLine($"The Value of f is " + f);

                    // Show Generated Number in TextBox
                    txtBxRandomNumber.Text = $"{f}";
                }

                // Show Generated Number in TextBox
                //txtBxRandomNumber.Text = $"{rand}";

                // generated number disappears after 5 seconds
                await Task.Delay(5_000);
                txtBxRandomNumber.Text = string.Empty;

                // Setting Answer Panel Visible
                pnlAnswer.Visible = true;

                this.Controls.Add(txtBxRandomNumber);
            }
        }
                
        private async void btn0_Click(object sender, EventArgs e)
        {
            count++;
            count = c;

            txtBxCounts.Text = count.ToString();
            Console.WriteLine($"  " + count);

            btn0.BackColor = Color.Red;

            val0 = 0;
            numberValue.Enqueue(0);

            
            //Button Color Changed back to default
            await Task.Delay(2_000);
            btn0.BackColor = Color.Gainsboro;

            if (c==d)
            {
                //SetEnabledAllButtons();


                //creating an Array arrValues with nº of elements = c
                Int64[] arrValues = new Int64[c];

                //copy all values of Queue numberValue to Array arrValues
                numberValue.CopyTo(arrValues, 0);

                //display elements of numberValue
                foreach (Object obj in numberValue)
                {
                    Console.Write(obj);
                    txtBxAnswer.Text = Convert.ToString(obj);
                }

                Console.WriteLine("Number of elements in the Queue: {0}", numberValue.Count);


                // Display elements of Array
                Console.Write("\n");
                for (Int64 i = 0; i < d; i++)
                {
                    Console.Write("arrValues[{0}] : {1}", i, arrValues[i]);
                    
                    //txtBxAnswer.Text = Convert.ToString(arrValues[i]);
                }
                Console.Write("\n");
            }


        }

        private async void btn1_Click(object sender, EventArgs e)
        {
            count++;
            count = c;

            txtBxCounts.Text = count.ToString();
            Console.WriteLine($"  " + count);

            btn1.BackColor = Color.Red;

            val1 = 1;
            numberValue.Enqueue(1);


            //Button Color Changed back to default
            await Task.Delay(2_000);
            btn1.BackColor = Color.Gainsboro;

            if (c == d)
            {
                //SetEnabledAllButtons();


                //creating an Array arrValues with nº of elements = c
                Int64[] arrValues = new Int64[c];

                //copy all values of Queue numberValue to Array arrValues
                numberValue.CopyTo(arrValues, 0);

                //display elements of numberValue
                foreach (Object obj in numberValue)
                {
                    Console.Write(obj);
                    //txtBxAnswer.Text = Convert.ToString(obj);
                }

                Console.WriteLine("Number of elements in the Queue: {0}", numberValue.Count);


                // Display elements of Array
                Console.Write("\n");
                for (Int64 i = 0; i < d; i++)
                {
                    Console.Write("arrValues[{0}] : {1}", i, arrValues[i]);

                    txtBxAnswer.Text = Convert.ToString(arrValues[i]);
                }
                Console.Write("\n");
            }
        }

        private async void btn2_Click(object sender, EventArgs e)
        {
            count++;
            count = c;

            txtBxCounts.Text = count.ToString();
            Console.WriteLine($"  " + count);

            btn2.BackColor = Color.Red;

            val2 = 2;
            numberValue.Enqueue(2);


            //Button Color Changed back to default
            await Task.Delay(2_000);
            btn2.BackColor = Color.Gainsboro;

            if (c == d)
            {
                //SetEnabledAllButtons();


                //creating an Array arrValues with nº of elements = c
                Int64[] arrValues = new Int64[c];

                //copy all values of Queue numberValue to Array arrValues
                numberValue.CopyTo(arrValues, 0);

                //display elements of numberValue
                foreach (Object obj in numberValue)
                {
                    Console.Write(obj);
                    //txtBxAnswer.Text = Convert.ToString(obj);
                }

                Console.WriteLine("Number of elements in the Queue: {0}", numberValue.Count);


                // Display elements of Array
                Console.Write("\n");
                for (Int64 i = 0; i < d; i++)
                {
                    Console.Write("arrValues[{0}] : {1}", i, arrValues[i]);

                    txtBxAnswer.Text = Convert.ToString(arrValues[i]);
                }
                Console.Write("\n");
            }
        }

        private async void btn3_Click(object sender, EventArgs e)
        {
            count++;
            c = count;
            txtBxCounts.Text = count.ToString();
            Console.WriteLine($"  " + count);

            btn3.BackColor = Color.Red;

            val3 = 3;
            numberValue.Enqueue(3);


            //Button Color Changed back to default
            await Task.Delay(2_000);
            btn3.BackColor = Color.Gainsboro;

            if (c == d)
            {
                //SetEnabledAllButtons();


                //creating an Array arrValues with nº of elements = c
                Int64[] arrValues = new Int64[c];

                //copy all values of Queue numberValue to Array arrValues
                numberValue.CopyTo(arrValues, 0);

                //display elements of numberValue
                foreach (Object obj in numberValue)
                {
                    Console.Write(obj);
                    //txtBxAnswer.Text = Convert.ToString(obj);
                }

                Console.WriteLine("Number of elements in the Queue: {0}", numberValue.Count);


                // Display elements of Array
                Console.Write("\n");
                for (Int64 i = 0; i < c; i++)
                {
                    Console.Write("arrValues[{0}] : {1}", i, arrValues[i]);

                    txtBxAnswer.Text = Convert.ToString(arrValues[i]);
                }
                Console.Write("\n");
            }
        }

        private async void btn4_Click(object sender, EventArgs e)
        {
            count++;
            c = count;

            txtBxCounts.Text = count.ToString();
            Console.WriteLine($"  " + count);

            btn4.BackColor = Color.Red;

            val4 = 4;
            numberValue.Enqueue(4);


            //Button Color Changed back to default
            await Task.Delay(2_000);
            btn4.BackColor = Color.Gainsboro;

            if (c == d)
            {
                //SetEnabledAllButtons();


                //creating an Array arrValues with nº of elements = c
                Int64[] arrValues = new Int64[c];

                //copy all values of Queue numberValue to Array arrValues
                numberValue.CopyTo(arrValues, 0);

                //display elements of numberValue
                foreach (Object obj in numberValue)
                {
                    Console.Write(obj);
                    //txtBxAnswer.Text = Convert.ToString(obj);
                }

                Console.WriteLine("Number of elements in the Queue: {0}", numberValue.Count);


                // Display elements of Array
                Console.Write("\n");
                for (Int64 i = 0; i < c; i++)
                {
                    Console.Write("arrValues[{0}] : {1}", i, arrValues[i]);

                    txtBxAnswer.Text = Convert.ToString(arrValues[i]);
                }
                Console.Write("\n");
            }
        }

        private async void btn5_Click(object sender, EventArgs e)
        {
            count++;
            c = count;
            txtBxCounts.Text = count.ToString();
            Console.WriteLine($"  " + count);

            btn5.BackColor = Color.Red;

            val5 = 5;
            numberValue.Enqueue(5);


            //Button Color Changed back to default
            await Task.Delay(2_000);
            btn5.BackColor = Color.Gainsboro;

            if (c == d)
            {
                //SetEnabledAllButtons();


                //creating an Array arrValues with nº of elements = c
                Int64[] arrValues = new Int64[c];

                //copy all values of Queue numberValue to Array arrValues
                numberValue.CopyTo(arrValues, 0);

                //display elements of numberValue
                foreach (Object obj in numberValue)
                {
                    Console.Write(obj);
                    //txtBxAnswer.Text = Convert.ToString(obj);
                }

                Console.WriteLine("Number of elements in the Queue: {0}", numberValue.Count);


                // Display elements of Array
                Console.Write("\n");
                for (Int64 i = 0; i < c; i++)
                {
                    Console.Write("arrValues[{0}] : {1}", i, arrValues[i]);

                    txtBxAnswer.Text = Convert.ToString(arrValues[i]);
                }
                Console.Write("\n");
            }
        }

        private async void btn6_Click(object sender, EventArgs e)
        {
            count++;
            c = count;
            txtBxCounts.Text = count.ToString();
            Console.WriteLine($"  " + count);

            btn6.BackColor = Color.Red;

            val6 = 6;
            numberValue.Enqueue(6);


            //Button Color Changed back to default
            await Task.Delay(2_000);
            btn6.BackColor = Color.Gainsboro;

            if (c == d)
            {
                //SetEnabledAllButtons();


                //creating an Array arrValues with nº of elements = c
                Int64[] arrValues = new Int64[c];

                //copy all values of Queue numberValue to Array arrValues
                numberValue.CopyTo(arrValues, 0);

                //display elements of numberValue
                foreach (Object obj in numberValue)
                {
                    Console.Write(obj);
                    //txtBxAnswer.Text = Convert.ToString(obj);
                }

                Console.WriteLine("Number of elements in the Queue: {0}", numberValue.Count);


                // Display elements of Array
                Console.Write("\n");
                for (Int64 i = 0; i < c; i++)
                {
                    Console.Write(+arrValues[i]);

                    txtBxAnswer.Text = Convert.ToString(arrValues[i]);
                }
                Console.Write("\n");
            }
        }

        private async void btn7_Click(object sender, EventArgs e)
        {
            count++;
            c = count;
            txtBxCounts.Text = count.ToString();
            Console.WriteLine($"  " + count);

            btn7.BackColor = Color.Red;

            val7 = 7;
            numberValue.Enqueue(7);


            //Button Color Changed back to default
            await Task.Delay(2_000);
            btn7.BackColor = Color.Gainsboro;

            if (c == d)
            {
                //SetEnabledAllButtons();


                //creating an Array arrValues with nº of elements = c
                Int64[] arrValues = new Int64[c];

                //copy all values of Queue numberValue to Array arrValues
                numberValue.CopyTo(arrValues, 0);

                //display elements of numberValue
                foreach (Object obj in numberValue)
                {
                    Console.Write(obj);
                    //txtBxAnswer.Text = Convert.ToString(obj);
                }

                Console.WriteLine("Number of elements in the Queue: {0}", numberValue.Count);


                // Display elements of Array
                Console.Write("\n");
                for (Int64 i = 0; i < c; i++)
                {
                    Console.Write("arrValues[{0}] : {1}", i, arrValues[i]);

                    txtBxAnswer.Text = Convert.ToString(arrValues[i]);
                }
                Console.Write("\n");
            }
        }

        private async void btn8_Click(object sender, EventArgs e)
        {

            count++;
            c = count;
            txtBxCounts.Text = count.ToString();
            Console.WriteLine($"  " + count);

            btn0.BackColor = Color.Red;

            val8 = 8;
            numberValue.Enqueue(8);


            //Button Color Changed back to default
            await Task.Delay(2_000);
            btn8.BackColor = Color.Gainsboro;

            if (c == d)
            {
                //SetEnabledAllButtons();


                //creating an Array arrValues with nº of elements = c
                Int64[] arrValues = new Int64[c];

                //copy all values of Queue numberValue to Array arrValues
                numberValue.CopyTo(arrValues, 0);

                //display elements of numberValue
                foreach (Object obj in numberValue)
                {
                    Console.Write(obj);
                    //txtBxAnswer.Text = Convert.ToString(obj);
                }

                Console.WriteLine("Number of elements in the Queue: {0}", numberValue.Count);


                // Display elements of Array
                Console.Write("\n");
                for (Int64 i = 0; i < c; i++)
                {
                    Console.Write("arrValues[{0}] : {1}", i, arrValues[i]);

                    txtBxAnswer.Text = Convert.ToString(arrValues[i]);
                }
                Console.Write("\n");
            }
        }

        private async void btn9_Click(object sender, EventArgs e)
        {
            count++;
            c = count;
            txtBxCounts.Text = count.ToString();
            Console.WriteLine($"  " + count);

            btn0.BackColor = Color.Red;

            val9 = 9;
            numberValue.Enqueue(9);


            //Button Color Changed back to default
            await Task.Delay(2_000);
            btn9.BackColor = Color.Gainsboro;

            if (c == d)
            {
                //SetEnabledAllButtons();


                //creating an Array arrValues with nº of elements = c
                Int64[] arrValues = new Int64[c];

                //copy all values of Queue numberValue to Array arrValues
                numberValue.CopyTo(arrValues, 0);

                //display elements of numberValue
                foreach (Object obj in numberValue)
                {
                    Console.Write(obj);
                    //txtBxAnswer.Text = Convert.ToString(obj);
                }

                Console.WriteLine("Number of elements in the Queue: {0}", numberValue.Count);


                // Display elements of Array
                Console.Write("\n");
                for (Int64 i = 0; i < c; i++)
                {
                    Console.Write("arrValues[{0}] : {1}", i, arrValues[i]);

                    txtBxAnswer.Text = Convert.ToString(arrValues[i]);
                }
                Console.Write("\n");
            }
        }

        private void pnlAnswer_Paint(object sender, PaintEventArgs e)
        {
               
        }
    }


}
