using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Sample2
{
    abstract class Document
    {
        List<Page> pages = new List<Page>();

        public List<Page> Pages
            {
                get { return pages; }
            }

        public Document()
        {
            this.CreatePage();
        }

        public abstract void CreatePage();


    }
}
