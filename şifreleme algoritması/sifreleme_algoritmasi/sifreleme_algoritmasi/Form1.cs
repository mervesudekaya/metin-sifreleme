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

           
                string cümle = textBox1.Text;
                string sifreli = "";
                char[] sesli_harfler = { 'a', 'e', 'ý', 'i', 'o', 'ö', 'u', 'ü',
                            'A', 'E', 'I', 'Ý', 'O', 'Ö', 'U', 'Ü' };

                for (int i = 0; i < cümle.Length; i++)
                {
                    char harf = cümle[i];
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