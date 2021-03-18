using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Book
{
    private int title;
    private int author;
    private int numberOfPages;

    public Book (int atitle, int aauthor, int anumberOfPages)
    {
        title = atitle;
        author = aauthor;
        numberOfPages = anumberOfPages;
    }
    public int Title
    {
        get { return title; }
        set { title = value; }
    }
    public int Author
    {
        get { return author; }
        set { author = value; }
    }
    public int NumberOfPages
    {
        get { return numberOfPages; }
        set { numberOfPages = value; }
    }
    public Book()
    {

    }
}
