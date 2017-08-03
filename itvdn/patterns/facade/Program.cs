using System;
using itvdn.patterns.facade.DocParts;

namespace Program
{
    class Program
    {
        public static void Main(string[] args )
        {
            Document doc = new Document("Contract");
            doc.Body = "Contract body";
            doc.Show();
        }
    }
}
