using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeParadigma
{
    public class BinaryTree
    {
        public int Root { get; private set; }

        public int[] Left { get; private set; }

        public int[] Right { get; private set; }

        private static BinaryTree binaryTree;

        public static BinaryTree GetBinaryTree
        {
            get
            {
                if (binaryTree == null)
                    binaryTree = new BinaryTree();

                return binaryTree;
            }
        }        

        /// <summary>
        /// Método responsável por construir a árvore de acordo com array informado
        /// </summary>
        /// <param name="numbers">Array de inteiros para aplicação da organização</param>
        /// <returns>Retorna a raiz e as sub-árvores de acordo com a organização</returns>
        public BinaryTree BuildTree(int[] numbers)
        {
            // Definir a raiz da árvore
            Root = numbers.Max();

            // Vamos definir os números da esquerda
            Left = GetNumberOfLeft(numbers);

            // Vamos definir os números da direita
            Right = GetNumberOfRight(numbers);

            // Retorna a árvore ordenada
            return this;
                   
        }

        /// <summary>
        /// Método responsável por identificar e ordernar os números da direita
        /// </summary>
        /// <param name="numbers">Array de inteiros para identificação dos números da direita</param>
        /// <returns>Retorna os números da direita em relação ao número raiz</returns>
        private int[] GetNumberOfRight(int[] numbers)
        {
            // Lista para auxílio da ordenação
            List<int> lsRight = new List<int>();

            // Vamor percorrer o array e verificar se os números não são iguais ao da lista da esquerda e também não é igual ao número raiz.
            numbers.ToList().ForEach(fr =>
            {
                if (fr != Root && Left.Where(whr => whr == fr).Count() == 0)
                {
                    lsRight.Add(fr);
                }
            });

            // Retorna o array de inteiros que foram identificados ao lado direito do número raiz
            return lsRight.OrderByDescending(ord => ord).ToArray(); ;
        }

        /// <summary>
        /// Método responsável por identificar e ordernar os números da esquerda
        /// </summary>
        /// <param name="numbers">Array de inteiros para identificação dos números da esquerda</param>
        /// <returns>Retorna os números da esquerda em relação ao número raiz</returns>
        private int[] GetNumberOfLeft(int[] numbers)
        {
            // Lista para auxílio da ordenação
            List<int> lsLeft = new List<int>();

            // Atributo responsável por identificar a hora de parar a atribuição para lista de números da esquerda
            bool stopAdd = false;

            // Vamos percorrer o array de números e verificar: quando for diferente do número raiz continuar adicionando, quando for igual ao número raiz quer
            // dizer que encontrou os números da esquerda e assim definir o atributo stopAdd para true afim de finalizar o loop
            numbers.ToList().ForEach(fr =>
            {
                if (fr == Root)
                    stopAdd = true;
                else if (!stopAdd)
                    lsLeft.Add(fr);
            });

            // Retorna o array de inteiros que foram identificados ao lado esquerdo do número raiz
            return lsLeft.OrderByDescending(ord => ord).ToArray();
        }
    }
}
