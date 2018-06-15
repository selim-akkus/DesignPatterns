using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Sample2
{
    class Report : Document
    {
        public override void CreatePage()
        {
            Pages.Add(new IntroductionPage());
            Pages.Add(new ResultPage());
            Pages.Add(new SummaryPage());
            Pages.Add(new BibliographyPage());
        }
    }
}
