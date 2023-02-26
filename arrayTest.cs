using Dotnet.Array;
using System;

namespace UnitTests
{
    public class ArrayTest
    {
        [[Fact]
        public void Reverse_Array()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };
        
            var reverseArray = ArrayDS.ReserveArray(array);
        
            reverseArray.Should().BeInDescendingOrder();
        }]
    }
}