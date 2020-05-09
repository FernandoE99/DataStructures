using System;

namespace DataStructures
{
    public class PairValueI <T> : IPairValue<T>
    {
        private readonly T _t1;
        private readonly T _t2;

        public PairValueI(T t1, T t2) {

            if (t1 is null)
                throw new ArgumentNullException(nameof(t1));

            if (t2 is null)
                throw new ArgumentNullException(nameof(t2));


            _t1 = t1;
            _t2 = t2;

        }

        public bool Contains(T value) //Returns true only if of the two values of the apir object is equal to the one passed as function argument
        {
            return value.Equals(_t1) || value.Equals(_t2);
        }

        public T GetFirst() //Returns the value of the read only variable
        {
            return _t1;
        }

        public T GetSecond() //Returns the value of the read only variable
        {
           return _t2;
        }

        public override bool Equals(object o) // Returns true if, passed another object, it has the same type (PairValueImplementation)
            //And its left-reght members are equal to those of the object in consideration.
        {
            if (o == null || o.GetType() != typeof(PairValueI<T>)) 
                return false;
              
            PairValueI<T> casted = (PairValueI<T>) o;
            return casted._t1.Equals(_t1) && casted._t2.Equals(_t2);
        }

        public override int GetHashCode()//Returns the sum of _t1 and _t2 hashcodes
        {
            return _t1.GetHashCode() + _t2.GetHashCode();
        }
    }
}
