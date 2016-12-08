using System;
using System.Collections.Generic;
using System.Collections;

namespace MyFirstApplication
{
    //представляет партию персонажей
    public class Party<T> : IEnumerator<T>
    {
        public List<T> partymembers = new List<T> { };
        private int index;
        
        //собственный енумератор
        void IDisposable.Dispose()
        {
            if (typeof(IDisposable).IsAssignableFrom(typeof(T)))
            {
                foreach (T m in partymembers)
                {
                    ((IDisposable)m).Dispose();
                }
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return partymembers[index];
            }
        }

        public T Current { get { return partymembers[index]; } }

        public bool MoveNext()
        {
            if (++index > partymembers.Count)
            {
                return false;
            }
            else
            {
                //   member=partymembers[index];
                return true;
            }

        }

        public void Reset()
        {
            index = -1;
        }

        
        

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T c in partymembers)
            {
                yield return c;
            }
        }

        //добавление члена партии
        public void AddMember(T character)
        {
            partymembers.Add(character);
        }
    }
}
