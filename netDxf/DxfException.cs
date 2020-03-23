using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace netDxf
{
    public class DxfException : Exception
    {
        //Initializes a new instance of the Exception.
        public DxfException() : base()
        {
        }

        //Initializes a new instance of the Exception class with a specified error message.
        public DxfException(String s) : base(s)
        {
        }

        //Initializes a new instance of the Exception class with serialized data.
        public DxfException(SerializationInfo si, StreamingContext sc)
        {
        }

        //Initializes a new instance of the Exception class with a specified error message and a reference to the inner exception that is the cause of this exception.        
        public DxfException(String s, Exception e)
        {
        }

    }
}
