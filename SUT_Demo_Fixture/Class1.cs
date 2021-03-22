using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SUT_Demo;
using fit;
using fit.Fixtures;

namespace SUT_Demo_Fixture
{
    public class Class1 : ColumnFixture
    {
        public int x;
        public int y;
        public SUT_Demo.Program sut = new SUT_Demo.Program();

        public int Add()
        {
            return sut.Add(x, y);
        }
    }
}
