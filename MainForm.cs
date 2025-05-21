using System;
using System.Windows.Forms;
using L12_OOP_12.Models;

namespace L12_OOP_12.Forms
{
    public partial class MainForm : Form
    {
        private StringClass[] stringArray;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCreateComplex_Click_1(object sender, EventArgs e)
        {
            string input = txtComplexInput.Text;
            try
            {
                ComplexNumber cn = new ComplexNumber(input);
                lblOutput.Text = cn.Display();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid complex number: " + ex.Message);
            }
        }

        private void btnReverse_Click_1(object sender, EventArgs e)
        {
            StringClass str = new StringClass(txtStringInput.Text);
            str.ReverseString();
            lblOutput.Text = str.Display();
        }

        private void btnAppend_Click_1(object sender, EventArgs e)
        {
            StringClass str = new StringClass(txtStringInput.Text);
            str.AppendString(txtAppendInput.Text);
            lblOutput.Text = str.Display();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            stringArray = new StringClass[]
            {
                new StringClass("Orange"),
                new StringClass("Apple"),
                new StringClass("Banana")
            };

            listBoxOriginal.Items.Clear();
            foreach (var item in stringArray)
                listBoxOriginal.Items.Add(item);
        }

        private void btnClone_Click(object sender, EventArgs e)
        {
            int size = 6;
            StringClass[] stringArray = new StringClass[size];

            stringArray[0] = new StringClass("Orange");
            stringArray[1] = new StringClass("Apple");
            stringArray[2] = new StringClass("Banana");

            for (int i = 0; i < size / 2; i++)
            {
                stringArray[i + size / 2] = (StringClass)stringArray[i].Clone();
                stringArray[i + size / 2] = new StringClass(stringArray[i].characters + " (clone)");
            }

            listBoxOriginal.Items.Clear();
            for (int i = 0; i < size; i++)
            {
                listBoxOriginal.Items.Add($"[{i}] {stringArray[i].characters}");
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (stringArray == null) return;

            Array.Sort(stringArray);

            listBoxSorted.Items.Clear();
            foreach (var item in stringArray)
                listBoxSorted.Items.Add(item);
        }

        private ComplexCollection complexCollection = new ComplexCollection();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text.Trim();
            ComplexNumber cn = new ComplexNumber(input);
            complexCollection.AddComplexNumber(cn);
            MessageBox.Show("Додано");
        }

        private void btnShowGeneric_Click(object sender, EventArgs e)
        {
            lstGeneric.Items.Clear();
            foreach (string s in complexCollection.TraverseGeneric())
            {
                lstGeneric.Items.Add(s);
            }
        }

        private void btnShowNonGeneric_Click(object sender, EventArgs e)
        {
            lstNonGeneric.Items.Clear();
            foreach (string s in complexCollection.TraverseNonGeneric())
            {
                lstNonGeneric.Items.Add(s);
            }
        }

        private void btnGetGenericAt_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtIndex.Text, out int index))
            {
                lblResult.Text = complexCollection.GetGenericElementAt(index);
            }
        }

        private void btnGetNonGenericAt_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtIndex.Text, out int index))
            {
                lblResult.Text = complexCollection.GetNonGenericElementAt(index);
            }
        }

    }
}
