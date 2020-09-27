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
            //ƒемонстраци€ ковариантности массивов и проверок во врем€ выполнени€
            string[] strings = new string[5];
            object[] objects = strings; //<- ѕрименение ковариантного преобразовани€
            objects[0] = 1;             //<- ѕопытка сохранени€ числового значени€
        }
    }
}