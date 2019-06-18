using System;
using System.Linq;
using BinaryTreeParadigma;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestBinaryTree
{
    [TestClass]
    public class MainTest
    {
        private readonly int[] numbers = new int[] { 3, 2, 1, 6, 0, 5 };

        [TestMethod]
        public void TestRoot()
        {
            BinaryTree binaryTree = BinaryTree.GetBinaryTree;


            binaryTree = binaryTree.BuildTree(numbers);

            Assert.AreEqual(binaryTree.Root, numbers.ToList().Max());
        }

        [TestMethod]
        public void TestLeft()
        {
            BinaryTree binaryTree = BinaryTree.GetBinaryTree;

            binaryTree = binaryTree.BuildTree(numbers);

            for (int i = 0; i < binaryTree.Left.Length; i++)
            {
                if (numbers[i] == binaryTree.Root)
                    Assert.AreEqual(numbers[i], binaryTree.Root);
                else
                Assert.AreEqual(binaryTree.Left[i], numbers[i]);
            }
            
        }

        [TestMethod]
        public void TestRight()
        {
            BinaryTree binaryTree = BinaryTree.GetBinaryTree;

            binaryTree = binaryTree.BuildTree(numbers);

            int index = 0;
            for (int i = numbers.Length - 1; i > 0; i--)
            {
                if (numbers[i] == binaryTree.Root)
                    Assert.AreEqual(numbers[i], binaryTree.Root);
                else
                    Assert.AreEqual(binaryTree.Right[index], numbers[i]);

                index++;

                if (index == binaryTree.Right.Length)
                    break;
            }
        }
    }
}
