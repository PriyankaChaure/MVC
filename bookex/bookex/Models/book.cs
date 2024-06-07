using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bookex.Models
{
    public class book
    {
        public Int32 bookid { get; set; }
        public string bookname { get; set; }
        public string authorname { get; set; }
        public Int64 bookprice { get; set; }
        
        public book()
        {
            this.bookid = 1;
            this.bookname = "english";
            this.authorname = "priya";
            this.bookprice = 250;
        }
        public static List<book>getbooksinfo()
        {
            List<book> lst= new List<book>(); 
            lst.Add(new book {bookid=1,bookname="maths",authorname="pqr",bookprice=300 });
            lst.Add(new book { bookid = 1, bookname = "book", authorname = "srt", bookprice = 300 });
            lst.Add(new book { bookid = 2, bookname = "english", authorname = "sdf", bookprice = 400 });
            lst.Add(new book { bookid = 3, bookname = "marathi", authorname = "hhr", bookprice = 500 });
            lst.Add(new book { bookid = 4, bookname = "hindi", authorname = "alr", bookprice = 600 });
            lst.Add(new book { bookid = 5, bookname = "algebra", authorname = "opr", bookprice = 700 });
            lst.Add(new book { bookid = 6, bookname = "geography", authorname = "mnr", bookprice = 800 });
            lst.Add(new book { bookid = 7, bookname = "history", authorname = "pth", bookprice = 900 });
            lst.Add(new book { bookid = 8, bookname = "physics", authorname = "pzx", bookprice = 350 });
            lst.Add(new book { bookid = 9, bookname = "chemistry", authorname = "bvr", bookprice = 450 });
            lst.Add(new book { bookid = 10, bookname = "biology", authorname = "dvr", bookprice = 550 });
            return lst;

        }
    }
}