using System;

namespace Schema.Net
{
    [Serializable]
    public  class Book : CreativeWork
    {
        /*The edition of the book.*/
        public  string[] bookEdition;
        /*The format of the book.*/
        public  BookFormatType[] bookFormat;
        /*The illustrator of the book.*/
        public  Person[] illustrator;
        /*The ISBN of the book.*/
        public  string[] isbn;
        /*The string of pages in the book.*/
        public  string[] stringOfPages;
    }
}