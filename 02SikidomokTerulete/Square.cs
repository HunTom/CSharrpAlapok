using System;

namespace _02SikidomokTerulete
{
    public class Square : IPlane
    {
        private int side;

        public Square(int side)
        {
            this.side = side;
        }

        public int Area()
        {
            //a this.side nem kell lehet helyett side, mert itt nem zavar be a paraméter ugyanazon neve
            return side * side;
        }
    }
}