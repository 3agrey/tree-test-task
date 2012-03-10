using System;
using System.Collections;
namespace treetesttask
{
    public class Node
    {
        private int _value = -1;
        private ArrayList _childNodes = new ArrayList();
        
        public int Value {
            get { return _value; }
            set { _value = value; }
        }
        
        public ArrayList ChildNodes {
            get { return _childNodes; }
        }
        
        public int Sum {
            get 
            {
                int result = Value;
                
                foreach (Node child in ChildNodes)
                {
                    result += child.Sum;
                }
                
                return result;
            }
        }
    }
}

