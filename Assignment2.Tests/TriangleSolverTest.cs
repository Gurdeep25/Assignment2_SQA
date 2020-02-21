using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace Assignment2.Tests
{
    [TestFixture]
    public class TriangleSolverTest
    {
        //Input Values for Invalid Triangle
        [TestCase]
        public void InvalidTriangle_Input000_OutputInvTri()
        {
            Assert.AreEqual("According to Input Values, It doesnt form a Valid Triangle", TriangleSolver.Analyze(0,0,0));
        }

        //Input Values for valid Triangle
        [TestCase]
        public void ValidTriangle_Input987_OutputVaTri()
        {
            Assert.AreEqual("According to Input Values, It is Scalene triangle", TriangleSolver.Analyze(9, 8, 7));
        }

        //Input Values for Scalene Triangle
        [TestCase]
        public void Scalene_Input876_OutputSca()
        {
            Assert.AreEqual("According to Input Values, It is Scalene triangle", TriangleSolver.Analyze(8,7,6));
        }

        //Input Values for Equilateral Triangle
        [TestCase]
        public void Equilateral_Input222_OutputEqui()
        {
            Assert.AreEqual("According to Input Values, It is Equilateral triangle", TriangleSolver.Analyze(2, 2, 2));
        }

        //Input Values for Isosceles Triangle
        [TestCase]
        public void Isosceles_Input454_OutputIsos()
        {
            Assert.AreEqual("According to Input Values, It is Isosceles triangle", TriangleSolver.Analyze(4,5,4));
        }

        //Negative Input Values for Invalid Triangle
        [TestCase]
        public void InvalidTriangle_InputMin1Min1Min1_OutputInvTri()
        {
            Assert.AreEqual("According to Input Values, It doesnt form a Valid Triangle", TriangleSolver.Analyze(-1, -1, -1));
        }

        //Negative Input Values for Invalid Triangle
        [TestCase]
        public void InvalidTriangle_InputMin0Min0Min0_OutputInvTri()
        {
            Assert.AreEqual("According to Input Values, It doesnt form a Valid Triangle", TriangleSolver.Analyze(-0, -0, -0));
        }

        //Negative Input Values for Invalid Triangle
        [TestCase]
        public void InvalidTriangle_InputMin9Min2Min9_OutputInvTri()
        {
            Assert.AreEqual("According to Input Values, It doesnt form a Valid Triangle", TriangleSolver.Analyze(-9, -2, -9));
        }
    }
}
