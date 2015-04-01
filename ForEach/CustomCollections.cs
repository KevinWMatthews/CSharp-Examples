using System.Collections;

namespace CustomCollections
{
    // The Splitter class must implement the IEnumerator interface to allow foreach to work!
    class Splitter : IEnumerable
    {
        private string[] elements;

        Splitter(string source, char[] delimiters)
        {
            //Parse the string into tokens
            elements = source.Split(delimiters);
        }

        static void Main()
        {
            Splitter f = new Splitter("This is a demo on creating custom collections that are enumerable.", new char[] { ' ', '-' });

            foreach (string item in f)
            {
                System.Console.WriteLine(item);
            }
        }

        #region IEnumerable Members

        public IEnumerator GetEnumerator()
        {
            return new SplitterEnumerator(this);
        }

        #endregion

        // Inner class implements IEnumerator interface
        private class SplitterEnumerator : IEnumerator
        {
            private int position = -1;
            private Splitter t;

            public SplitterEnumerator(Splitter t)
            {
                this.t = t;
            }

            #region IEnumerator Members

            public object Current
            {
                get
                {
                    return t.elements[position];
                }
            }

            public bool MoveNext()
            {
                if (position < t.elements.Length - 1)
                {
                    position++;
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public void Reset()
            {
                position = -1;
            }

            #endregion
        }
    }
}
