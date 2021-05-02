using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Cognizant.Truyum.Dao
{
    class CartEmptyException : Exception
    {
        private static readonly string DefaultMessage = "Users Cart is Empty";

        public CartEmptyException() : base(DefaultMessage) { }
        public CartEmptyException(string message) : base(message)
        {

        }

    }
}