using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    class rectangle
    {
        public rectangle()
        {
            newLenght = 0;
            newWidht = 0;
            newHeigth = 0;
        }
        public rectangle(int length, int width, int height)
        {
            newLenght = length;
            newWidht = width;
            newHeigth = height;
        }
        public int getLenght()
        {
            return newLenght;
        }
        public int getWidth()
        {
            return newWidht;
        }
        public int getHeigth()
        {
            return newHeigth;
        }

        public void setLenght(int length)
        {
            newLenght = length;
        }
        public void setWidht(int width)
        {
            newWid = width;
        }

        public void setHeigth(int height)
        {
            newHeig = height;
        }

        public int calculatearea()
        {
            return (newLeng * newWid * newHeig);
        }
        public int newLeng;
        public int newWid;
        public int newHeig;
    }
}
