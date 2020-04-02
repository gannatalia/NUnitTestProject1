using NUnit.Framework;

namespace NUnitTestProject1
{
    public class Tests
    {
        public class Tests
        {
            [Test]
            public void Test1_DZ1_Variables()
            {
                int Actual = Class1.Reshenie_primera(5, 10);  // ������ ������� �������� ������
                int Expected = 25; // ��������� ���������
                Assert.AreEqual(Expected, Actual); // ����������
            }

            [TestCase(2, 5, 10, ExpectedResult = 5)]
            public int Test2_DZ1_Variables()
            {
                int Actual = Class1.Naiti_X(a, b, c);
                return Actual;
            }


            [TestCase(new int[] { 1, 2, 3 }, ExpectedResult = new int[] { 3, 2, 1 }]
            public int[] Test1_DZ4_Array(int[] a)
            {
                int[] actual = Class1.revers(a);
                return actual;
            }
        }
    }
}