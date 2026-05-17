using System.Collections.Generic;
using System;

namespace DesignPatterns.Creational.Prototype
{
    /// <summary>
    /// Concrete prototype with cloneable state.
    /// </summary>
    public class Document : IPrototype<Document>
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public List<string> Tags { get; set; }

        public Document(string title, string content, List<string> tags)
        {
            Title = title;
            Content = content;
            Tags = tags;
        }

        public Document Clone()
        {
            // Deep copy the tag list so cloned documents are independent.
            return new Document(Title, Content, new List<string>(Tags));
        }

        public void Print()
        {
            Console.WriteLine($"Document: {Title}");
            Console.WriteLine($"Content: {Content}");
            Console.WriteLine($"Tags: {string.Join(", ", Tags)}");
        }
    }
}