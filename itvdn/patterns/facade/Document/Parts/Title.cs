using System;

namespace itvdn.patterns.facade.DocParts
{
    class Title
    {
        string content;

        public string Content
        {
            private get
            {
                if (String.IsNullOrEmpty(this.content))
                    this.content = "Title is empty";
                return this.content;
            }
            set { this.content = value; }
        }

        public void Show()
        {
            Console.WriteLine($"{this.content}");
        }
    }
}