namespace Odaberi_trougao_sa_liste
{
    public partial class Form1 : Form
    {
        private List<Trougao> listaTrouglova = new List<Trougao>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Trougao t1 = new Trougao(4, 5, 3); listaTrouglova.Add(t1);
            Trougao t2 = new Trougao(12, 5, 13); listaTrouglova.Add(t2);
            Trougao t3 = new Trougao(4, 6, 3); listaTrouglova.Add(t3);
            Trougao t4 = new Trougao(4, 4, 3); listaTrouglova.Add(t4);
            Trougao t5 = new Trougao(10, 10, 10); listaTrouglova.Add(t5);
            Trougao t6 = new Trougao(11, 10, 9); listaTrouglova.Add(t6);

            foreach (Trougao t in listaTrouglova)
            {
                listBox1.Items.Add(t.ToString());
            }
        }

        private void btnOdaberi_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            int index = listBox1.SelectedIndex;
            Trougao odabraniTrougao = listaTrouglova[index];
            listBox2.Items.Add("Podaci za odabrani trougao");
            listBox2.Items.Add(odabraniTrougao.Vrsta());
            listBox2.Items.Add("Obim = " + odabraniTrougao.Obim());
            listBox2.Items.Add("Povrsina = " + odabraniTrougao.Povrsina());

            //azuriranje slike
            if (odabraniTrougao.Vrsta() == "Trougao je pravougli")
            {
                pictureBox1.Image = new Bitmap("t90.png");
            }
            else if (odabraniTrougao.Vrsta() == "Trougao je tupougli")
            {
                pictureBox1.Image = new Bitmap("t91.png");
            }
            else if (odabraniTrougao.Vrsta() == "Trougao je ostrougli")
            {
                pictureBox1.Image = new Bitmap("t89.png");
            }

            if (odabraniTrougao.TemeMax() == 'A')
            {
                lblTemeC.Text = "A";
                lblTemeB.Text = "B";
                lblTemeA.Text = "C";
                lblStranicaC.Text = "a";
                lblStranicaB.Text = "b";
                lblStranicaA.Text = "c";
            }
            else if (odabraniTrougao.TemeMax() == 'B')
            {
                lblTemeC.Text = "B";
                lblTemeB.Text = "A";
                lblTemeA.Text = "C";
                lblStranicaC.Text = "b";
                lblStranicaB.Text = "a";
                lblStranicaA.Text = "c";
            }
            else
            {
                lblTemeC.Text = "C";
                lblTemeB.Text = "B";
                lblTemeA.Text = "A";
                lblStranicaC.Text = "c";
                lblStranicaB.Text = "b";
                lblStranicaA.Text = "a";
            }
        }
    }
}