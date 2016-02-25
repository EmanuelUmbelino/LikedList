using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listinha
{
    public partial class Form1 : Form
    {
        Mochila m;
        public Form1()
        {
            InitializeComponent();
        }

        void PlaceinTheList(Mochila x)
        {
            if (x.Position().Equals(0))
                listBox1.Items.Clear();
            if (x.Next() != null)
            {
                if(x.Previous() != null)
                    listBox1.Items.Add(x.Position() + ": Mochila " + x.Index() + " e dentro tem a " + 
                        x.Next().Index() +
                        " e está dentro da " + x.Previous().Index());
                else
                    listBox1.Items.Add(x.Position() + ": Mochila " + x.Index() + " e dentro tem a " + 
                        x.Next().Index() + " e não está dentro de nenhuma");

                PlaceinTheList(x.Next());
            }
            else
            {
                if (x.Previous() != null)
                    listBox1.Items.Add(x.Position() + ": Mochila " + x.Index() + " e dentro tem nada e está dentro da " + x.Previous().Index());
                else
                    listBox1.Items.Add(x.Position() + ": Mochila " + x.Index() + " e dentro tem nada e não está dentro de nenhuma");
                textBox4.Text = (x.Position() + 1).ToString();
            }

        }

        void AllBackToPosition(Mochila x, int first)
        {
            if (x.Next() != null)
            {
                if (first.Equals(0))
                {
                    if (x.Previous() != null)
                    {
                        x.Previous().Next(x.Next());
                        x.Next().Previous(x.Previous());
                        x.Next().Position(x.Position());
                    }
                    else
                    {
                        m = x.Next();
                        m.Previous(null);
                        m.Position(0);
                        m.Next().Position(1);
                    }
                }
                else
                    x.Next().Position(x.Position() + 1);

                AllBackToPosition(x.Next(), first + 1);
            }
            else if (first.Equals(0))
            {
                if (x.Previous() != null)
                {
                    x.Previous().Next(null);
                }
                else
                    x = new Mochila();
            }

        }
        Mochila GetByPositon(Mochila x,float position)
        {
            if (x.Position() != position)
            {
                x = GetByPositon(x.Next(), position);
            }
            return x;

        }
        void ChangePosition(Mochila x, Mochila y)
        {
            Mochila w = new Mochila();
            w = x;
            int ew = w.Index();
            x = y;
            y = w;
            y.Index(x.Index());
            x.Index(ew);
        }
        Mochila AddEnd(Mochila x, int posicao, int tamanho)
        {
            if (x.Index() >= tamanho)
                tamanho = x.Index() + 1;
            if (x.Next() != null)
            {
                x.Next(AddEnd(x.Next(), posicao + 1, tamanho));
            }
            else
            {
                x.Next(new Mochila());
                x.Next().Previous(x);
                x.Next().Position(posicao);
                x.Next().Index(tamanho);
            }
            return x;
        }
        Mochila GoToEnd(Mochila x)
        {
            if (x.Next() != null)
            {
                x = GoToEnd(x.Next());
            }
            return x;
        }
        void GoToPosition(Mochila x, int position)
        {
            if (x.Position() != position)
            {
                ChangePosition(x, x.Previous());
                GoToPosition(x.Previous(), position);
            }
        }
        void GoToIndex(Mochila x, int index)
        {
            if (x.Previous().Index() != index)
            {
                ChangePosition(x, x.Previous());
                GoToIndex(x.Previous(), index);
            }
        }

        private void AddElement(object sender, EventArgs e)
        {
            if (m != null)
            {
                m = AddEnd(m, 1, 1);
            }
            else
            {
                m = new Mochila();
                m.Index(1);
            }
            PlaceinTheList(m);
        }

        private void AddElementToPosition(object sender, EventArgs e)
        {
            if (textBox1.Text != null && textBox1.Text != "")
            {
                try
                {
                    m = AddEnd(m, 1, 1);
                    GoToPosition(GoToEnd(m), int.Parse(textBox1.Text));
                    PlaceinTheList(m);
                }
                catch
                {
                    MessageBox.Show("Choose a Position that is on the List");
                }
            }
            else
                MessageBox.Show("Choose a Position");
        }

        private void AddElementToValue(object sender, EventArgs e)
        {
            if (textBox6.Text != null && textBox6.Text != "")
            {
                try
                {
                    m = AddEnd(m, 1, 1);
                    GoToIndex(GoToEnd(m), int.Parse(textBox6.Text));
                    PlaceinTheList(m);
                }
                catch
                {
                    MessageBox.Show("Choose a Value that is on the List");
                }
            }
            else
                MessageBox.Show("Choose a Value");
        }
        private void ChangePosition(object sender, EventArgs e)
        {
            if (textBox2.Text != null && textBox2.Text != "" && textBox3.Text != null && textBox3.Text != "")
            {
                try
                {
                    ChangePosition(GetByPositon(m, int.Parse(textBox2.Text)), GetByPositon(m, int.Parse(textBox3.Text)));
                    PlaceinTheList(m);
                }
                catch 
                {
                    MessageBox.Show("Choose the Positions to Change that is on the List");
                }
            }
            else
                MessageBox.Show("Choose the Positions to Change");
        }

        private void Remove(object sender, EventArgs e)
        {
            if (textBox5.Text != null && textBox5.Text != "")
            {
                try
                {
                    AllBackToPosition(GetByPositon(m, int.Parse(textBox5.Text)), 0);
                    PlaceinTheList(m);
                }
                catch
                {
                    MessageBox.Show("Choose a Index that is on the List");
                }
            }
            else
                MessageBox.Show("Choose a Index");
        }

        private void OnlyNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

    }
}
