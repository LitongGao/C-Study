using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManager
{
    public interface IDocument
    {
        string Title { get; set; }
        string Content { get; set; }
    }

    public class Document : IDocument
    {
        public string Title { get; set; }
        public string Content { get; set; }
        //private string title;

        //DocumentManager<Document> documentManager = new DocumentManager<Document>();
        public Document()
        {

        }

        public Document(string title, string content)
        {
            this.Title = title;
            this.Content = content;
        }


    }
}
