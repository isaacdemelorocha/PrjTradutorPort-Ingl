using System;

namespace PrjTradutorList
{
    public partial class Tradutor : MetroFramework.Forms.MetroForm
    {
        const int MAX = 3;
        String[] x = new String[MAX];
        String[] y = new String[MAX];

        public Tradutor()
        {
            InitializeComponent();
        }

        private void Tradutor_Load(object sender, EventArgs e)
        {
            y[0] = "blue";
            y[1] = "red";
            y[2] = "yellow";

            x[0] = "azul";
            x[1] = "vermelho";
            x[2] = "amarelo";

        }

        private void btn_Click(object sender, EventArgs e)
        {
            String port = txtBox1.Text;
            String ingl = txtBox2.Text;

            for (int i = 0; i < MAX; i++)
            {
                if (port == x[i])
                {
                    txtBox2.Text = y[i];
                    txtBox1.Text = "";
                }
                else if (ingl == y[i])
                {
                    txtBox1.Text = x[i];
                    txtBox2.Text = "";
                }

            }

        }
            


        }
    }

