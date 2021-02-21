using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Assign1_solution;

namespace RectangleTest
{

    [TestFixture]
    public class RectangleTest
    {

        [Test]
        public void GetRectangleLength()
        {
            Rectangle Obj = new Rectangle();
            Assert.AreEqual(5, Obj.GetLength());
        }
        [Test]
        public void SetRectangleLength()
        {
            // arrange
            int l = 15;
            Rectangle Obj = new Rectangle();

            // act
            Obj.SetLength(l);

            // assert
            var newLen = Obj.GetLength();
            Assert.AreEqual(l, newLen, "Not set proper length");

        }

        [Test]
        public void GetRectangleWidth()
        {
            Rectangle Obj = new Rectangle();
            Assert.AreEqual(7, Obj.GetWidth());
        }

        [Test]
        public void SetRectangleWidth()
        {
            int w = 20;
            Rectangle Obj = new Rectangle();

            //act
            Obj.SetWidth(w);
            var newWid = Obj.GetWidth();
            Assert.AreEqual(w, newWid, "Not set proper length");
        }

        [Test]
        public void GetReactanlgePerimeter()
        {
            int setPerimeter = 10;
            Rectangle obj = new Rectangle(3, 2);
            var perimeter = obj.GetPerimeter();
            Assert.AreEqual(setPerimeter, perimeter, "Perimeter is not same");
        }


        [Test]
        public void GetReactanlgeArea()
        {
            int setArea = 6;
            Rectangle obj = new Rectangle(3, 2);
            var area = obj.GetArea();
            Assert.AreEqual(setArea, area, "Area is not same ");
        }
    }
}
