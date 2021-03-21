using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookWithMoreAt : Book
{
    public Book extrabook = new Book(0, 0, 0);

    private int genre;
    private int releaseYear;
    private int bookStatus;
    private int coverColor;

    public BookWithMoreAt(int agenre, int areleaseYear, int abookStatus, int acoverColor)
    {
        genre = agenre;
        releaseYear = areleaseYear;
        bookStatus = abookStatus;
        coverColor = acoverColor;
    }
    public BookWithMoreAt(int atitle, int aauthor, int aNumberOfPages, int agenre, int areleaseYear, int abookStatus, int acoverColor)
    {
        Title = atitle;
        Author = aauthor;
        NumberOfPages = aNumberOfPages;
        genre = agenre;
        releaseYear = areleaseYear;
        bookStatus = abookStatus;
        coverColor = acoverColor;
    }
    public int Genre
    {
        get { return genre; }
        set { genre = value; }
    }
    public int ReleaseYear
    {
        get { return releaseYear; }
        set { releaseYear = value; }
    }
    public int BookStatus
    {
        get { return bookStatus; }
        set { bookStatus = value; }
    }
    public int CoverColor
    {
        get { return coverColor; }
        set { coverColor = value; }
    }
    public string GetInfo()
    {
        string temporal;
        temporal = Title.ToString() + Author.ToString() + NumberOfPages.ToString() + Genre.ToString() + ReleaseYear.ToString() + BookStatus.ToString() + CoverColor.ToString();
        return temporal;
    }

}
