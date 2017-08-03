using System;

namespace itvdn.patterns.facade.DocParts
{
    class Body
    {
        string content = null;

        public string Content
        {
            private get { return content; }
            set { content = value; }
        }

        public void Show()
        {
            Console.WriteLine($"{content}");
        }
    }
}