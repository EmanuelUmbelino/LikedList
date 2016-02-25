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
        Mochila element;
        public Form1()
        {
            InitializeComponent();
        }

        void PlaceinTheList(Mochila x)
        {
            if (x.Position().Equals(0))
                listBox.Items.Clear();
            if (x.Next() != null)
            {
                if(x.Previous() != null)
                    listBox.Items.Add(x.Position() + ": Mochila " + x.Index() + " e dentro tem a " + 
                        x.Next().Index() +
                        " e está dentro da " + x.Previous().Index());
                else
                    listBox.Items.Add(x.Position() + ": Mochila " + x.Index() + " e dentro tem a " + 
                        x.Next().Index() + " e não está dentro de nenhuma");

                PlaceinTheList(x.Next());
            }
            else
            {
                if (x.Previous() != null)
                    listBox.Items.Add(x.Position() + ": Mochila " + x.Index() + " e dentro tem nada e está dentro da " + x.Previous().Index());
                else
                    listBox.Items.Add(x.Position() + ": Mochila " + x.Index() + " e dentro tem nada e não está dentro de nenhuma");
                nMochilas.Text = (x.Position() + 1).ToString();
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
                        element = x.Next();
                        element.Previous(null);
                        element.Position(0);
                        element.Next().Position(1);
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
        Mochila AddEnd(Mochila x, int position, int index)
        {
            if (x.Index() >= index)
                index = x.Index() + 1;
            if (x.Next() != null)
            {
                x.Next(AddEnd(x.Next(), position + 1, index));
            }
            else
            {
                x.Next(new Mochila());
                x.Next().Previous(x);
                x.Next().Position(position);
                x.Next().Index(index);
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
            if (element != null)
            {
                element = AddEnd(element, 1, 1);
            }
            else
            {
                element = new Mochila();
                element.Index(1);
            }
            PlaceinTheList(element);
        }

        private void AddElementToPosition(object sender, EventArgs e)
        {
            if (newInPosition.Text != null && newInPosition.Text != "")
            {
                try
                {
                    element = AddEnd(element, 1, 1);
                    GoToPosition(GoToEnd(element), int.Parse(newInPosition.Text));
                    PlaceinTheList(element);
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
            if (newAfterValue.Text != null && newAfterValue.Text != "")
            {
                try
                {
                    element = AddEnd(element, 1, 1);
                    GoToIndex(GoToEnd(element), int.Parse(newAfterValue.Text));
                    PlaceinTheList(element);
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
            if (position1.Text != null && position1.Text != "" && position2.Text != null && position2.Text != "")
            {
                try
                {
                    ChangePosition(GetByPositon(element, int.Parse(position1.Text)), GetByPositon(element, int.Parse(position2.Text)));
                    PlaceinTheList(element);
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
            if (removePosition.Text != null && removePosition.Text != "")
            {
                try
                {
                    AllBackToPosition(GetByPositon(element, int.Parse(removePosition.Text)), 0);
                    PlaceinTheList(element);
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
