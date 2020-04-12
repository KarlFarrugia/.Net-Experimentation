using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace SortingApplication
{
    class HelperClass
    {
        private uint PseudoRandomNumber()
        {
            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
            var byteArray = new byte[4];
            provider.GetBytes(byteArray);

            //convert 4 bytes to an integer
            uint randomInteger = BitConverter.ToUInt32(byteArray, 0);
            return randomInteger;
        }

        private ArrayList _GenerateList (int numberOfItems = 10, uint min = 0, uint max = 10)
        {
            ArrayList randomIntegerArrayList = new ArrayList();
            for (int i = 0; i < numberOfItems; i++)
            {
                randomIntegerArrayList.Add(PseudoRandomNumber());
            }

            return randomIntegerArrayList;
        }

        public ArrayList GenerateList(int numberOfItems = 10, uint min = 0, uint max = 10)
        {
            return _GenerateList(numberOfItems, min, max);
        }
    }
}
