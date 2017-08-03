using System;

namespace itvdn.patterns.facade.DocParts
{
    public class Document
    {
        Title title = null;
        Body body = null;
        public Document(string title)
        {
            Initialize();
            this.title.Content = title;
        }

        public string Body
        {
            set
            {
                body.Content = value;
            }
        }

        private void Initialize()
        {
            title = new Title();
            body = new Body();
        }

        public void Show()
        {
            title.Show();
            body.Show();
        }
    }
}