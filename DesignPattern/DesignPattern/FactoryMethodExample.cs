using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public interface IDocument
    {
        // Method to open the document
        void Open();
        // Method to save the document
        void Save();
    }

    public class WordDocument : IDocument
    {
        // Implementation of the Open method for Word documents
        public void Open()
        {
            Console.WriteLine("Opening Word document...");
        }

        // Implementation of the Save method for Word documents
        public void Save()
        {
            Console.WriteLine("Saving Word document...");
        }
    }

    public class PdfDocument : IDocument
    {
        // Implementation of the Open method for PDF documents
        public void Open()
        {
            Console.WriteLine("Opening PDF document...");
        }

        // Implementation of the Save method for PDF documents
        public void Save()
        {
            Console.WriteLine("Saving PDF document...");
        }
    }

    public class ExcelDocument : IDocument
    {
        // Implementation of the Open method for Excel documents
        public void Open()
        {
            Console.WriteLine("Opening Excel document...");
        }

        // Implementation of the Save method for Excel documents
        public void Save()
        {
            Console.WriteLine("Saving Excel document...");
        }
    }

    public abstract class DocumentCreator
    {
        // Abstract factory method to create a document
        public abstract IDocument FactoryMethod();

        // Method to open a document using the factory method
        public void OpenDocument()
        {
            var document = FactoryMethod();
            document.Open();
        }

        // Method to save a document using the factory method
        public void SaveDocument()
        {
            var document = FactoryMethod();
            document.Save();
        }
    }

    public class WordDocumentCreator : DocumentCreator
    {
        // Factory method to create a Word document
        public override IDocument FactoryMethod()
        {
            return new WordDocument();
        }
    }

    public class PdfDocumentCreator : DocumentCreator
    {
        // Factory method to create a PDF document
        public override IDocument FactoryMethod()
        {
            return new PdfDocument();
        }
    }

    public class ExcelDocumentCreator : DocumentCreator
    {
        // Factory method to create an Excel document
        public override IDocument FactoryMethod()
        {
            return new ExcelDocument();
        }
    }

    public class FactoryMethodExample
    {
        public static void Run()
        {
            DocumentCreator creator;

            // Create and use a Word document
            creator = new WordDocumentCreator();
            creator.OpenDocument();
            creator.SaveDocument();

            // Create and use a PDF document
            creator = new PdfDocumentCreator();
            creator.OpenDocument();
            creator.SaveDocument();

            // Create and use an Excel document
            creator = new ExcelDocumentCreator();
            creator.OpenDocument();
            creator.SaveDocument();
        }
    }

}