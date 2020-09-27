using NUnit.Framework;

namespace CovariantExample.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        { }

        [Test]
        public void Module1()
        {
            //������������ �������������� �������� � �������� �� ����� ����������
            string[] strings = new string[5];
            object[] objects = strings; //<- ���������� ������������� ��������������
            objects[0] = 1;             //<- ������� ���������� ��������� �������� ���������� �������
                                        //System.ArrayTypeMismatchException :
                                        //Attempted to access an element as a type incompatible with the array.
        }
    }
}