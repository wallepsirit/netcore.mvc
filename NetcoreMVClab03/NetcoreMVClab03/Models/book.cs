using Microsoft.AspNetCore.Mvc.Rendering;
using NetcoreMVClab03.Models;
using System.Collections.Generic;
using System.Linq;

namespace NetcoreMVClab03.Models
{
    public class book
    { public int id { get; set; }
        public string title { get; set; }
        public string genre { get; set; }
        public string author { get; set}
        public int authorid { get; set; }
        public int totalpages { get; set; }
        public float price { get; set; }
        piclic int sumary { get; set; }
    }
    public List<book> getlistbook() { }
        List<book> books = new List<book>()
    {
        new book { id = 1, title = "chi pheo", genre = "truyen ngan", author = "nam cao", authorid = 1, totalpages = 200, price = 5000 },
        { new book { id = 2, title = "lao hac", genre = "truyen ngan", author = "nam thap", authorid = 2, totalpages = 150, price = 600 }},
        { new book { id = 3, title = "conan", genre = "truyen tranh", author = "abc", authorid = 3, totalpages = 300, price = 20000 }}
    }; 

    }return books;
}
//danh sach cac cuon sach:
public List<book> getbooklist() { }
//chi tiet 1 cuon sach theo id:
public List<book> getbookyid(int id)
{
    book book = this.Listbook().firstordefault(book => book.id = id);
    return book;
}
//selectlistitem author:
public List<SelectListItem> authors { get; }= new List<SelectListItem>()
{ new SelectListItem{Value=1,Text="nam cao"}},
{ new SelectListItem { Value=2,Text"nam thap"}},
{ new SelectListItem { Value=3,Text="nguyen phu trong"}},
{ new SelectListItem { Value=4,Text="abcd"}}
};
//lisrselect genres:
public List<SelectListItem> generes { get}=new List<SelectListItem>()
{ new SelectListItem{Value=1,Text="truyen ngan"}},
{ new SelectListItem { Value=2,Text="truyen tranh"}},
{ new SelectListItem { Value=3,Text="truyen cuoi"}}
};