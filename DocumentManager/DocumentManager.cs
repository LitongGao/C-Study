using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManager
{
    public class DocumentManager<T>
        //where T : IDocument
    {
        private readonly Queue<T> documentQueue = new Queue<T>();

        public static int x;

        public void AddDocument(T doc)
        {
            lock (this)
            {
                documentQueue.Enqueue(doc);
            }
        }

        public bool IsDocumentAvailable
        {
            get {return documentQueue.Count > 0;}
        }

        public T GetDocument()
        {
            T doc = default(T);
            lock(this)
            {
                doc = documentQueue.Dequeue();
            }
            return doc;
        }

        public void DisplayAllDocument()
        {
            foreach (T doc in documentQueue)
            {
                Console.WriteLine(((IDocument)doc).Title);
            }
        }

        public static void Swap<T>(ref T x, ref T y)
        {
            T temp;
            temp = x;
            x = y;
            y = temp;
        }
    }
}
