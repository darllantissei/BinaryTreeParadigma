using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryTreeParadigma
{
    public partial class frmTestParadigma : Form
    {
        public frmTestParadigma()
        {
            InitializeComponent();            
        }        

        private void ShowBinaryTree()
        {
            BinaryTree binaryTree = BinaryTree.GetBinaryTree;

            int[] numbers = new int[] { 3, 2, 1, 6, 0, 5 };           

            txtResultBinaryTree.Text = $"Números informados: {string.Join(", ", numbers)}{Environment.NewLine}";

            binaryTree = binaryTree.BuildTree(numbers);

            txtResultBinaryTree.Text += string.Concat("Raiz: ", binaryTree.Root, Environment.NewLine,
                "Esquerda: ", string.Join(", ", binaryTree.Left), Environment.NewLine,
                "Direita: ", string.Join(", ", binaryTree.Right));
        }

        private void frmTestParadigma_Shown(object sender, EventArgs e)
        {
            ShowBinaryTree();


        }
    }
}
