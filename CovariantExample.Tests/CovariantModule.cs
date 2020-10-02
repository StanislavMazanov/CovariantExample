using System.Collections.Generic;
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
            objects[0] = 1; //<- ѕопытка сохранени€ числового значени€ закончитс€ ошибкой
            //System.ArrayTypeMismatchException :
            //Attempted to access an element as a type incompatible with the array.
        }

        [Test]
        public void Module2()
        {
            //ƒемонстраци€ ковариантности, контрвариантности

             object animal = "cat"; //ѕрименение ковариантного преобразовани€, можем записать конкретный
            //тип string "cat" в более универсальный тип object.
            //“ут проходит без предупреждени€ со стороны компил€тора

            string cat = animal; //ѕопытка применени€ контрвариантного преобразовани€ не увенчаетс€ успехом,
            //компил€тор нам подсказывает, что неудаетс€ не€вно преобразовать тип "object" в "string".
            //ƒл€ типа string требуетс€ €вное преобразование типов- такое поведение называетс€ инвариантностью.

            List<object> animalList = new List<string>(); //<-  омпил€тор будет ругатьс€
            object[] animalObject = new string[5]; //<- а так нет
            object[] animalObject2 = new int[5]; //<- а так будет
        }
    }
}