namespace sifreleme_algoritmasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           
                string c�mle = textBox1.Text;
                string sifreli = "";
                char[] sesli_harfler = { 'a', 'e', '�', 'i', 'o', '�', 'u', '�',
                            'A', 'E', 'I', '�', 'O', '�', 'U', '�' };

                for (int i = 0; i < c�mle.Length; i++)
                {
                    char harf = c�mle[i];
                    bool sesli_mi = false;

                    for (int j = 0; j < sesli_harfler.Length; j++)
                    {
                        if (harf == sesli_harfler[j])
                        {
                            sesli_mi = true;
                            break;
                        }
                    }

                    if (sesli_mi)
                    {
                        sifreli += "+";
                    }
                    else if ((harf >= 'a' && harf <= 'z') || (harf >= 'A' && harf <= 'Z'))
                    {
                       
                        sifreli += (char)(harf - 3);
                    }
                    else
                    {
                        sifreli += harf;
                    }
                }

                label1.Text = sifreli;
            



        }
    }
}