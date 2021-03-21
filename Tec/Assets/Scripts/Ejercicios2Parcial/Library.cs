using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Library : MonoBehaviour
{
    public BookWithMoreAt booknew = new BookWithMoreAt(0, 0, 0, 0, 0, 0, 0);
    private int lenghtLibrary;
    [SerializeField] private GameObject buttonReplace;
    [SerializeField] private GameObject buttonAdd;
    [SerializeField] private GameObject buttonShow;
    [SerializeField] private GameObject buttonOne;
    [SerializeField] private GameObject buttonTwo;
    [SerializeField] private GameObject buttonThree;

    public int LenghtLibrary
    {
        get { return lenghtLibrary; }
        set { lenghtLibrary = value; }
    }

    List<BookWithMoreAt> books = new List<BookWithMoreAt>();

    void Awake()
    {
        lenghtLibrary = 3;
        Debug.Log("Espacios restantes en librería: " + lenghtLibrary);
        buttonReplace.SetActive(false);
        buttonOne.SetActive(false);
        buttonTwo.SetActive(false);
        buttonThree.SetActive(false);
    }
    public BookWithMoreAt GenerateBook()
    {
        if (lenghtLibrary > 0)
        {
            //books.Add(extrabook);
            booknew.Title = Random.Range(1, 6);
            booknew.Author = Random.Range(1, 6);
            booknew.NumberOfPages = Random.Range(50, 201);
            booknew.Genre = Random.Range(1, 6);
            booknew.ReleaseYear = Random.Range(1999, 2021);
            booknew.BookStatus = Random.Range(1, 3);
            booknew.CoverColor = Random.Range(1, 6);
        }
        return booknew;
    }  
    public void ButtonReplace()
    {
        buttonOne.SetActive(true);
        buttonTwo.SetActive(true);
        buttonThree.SetActive(true);
    }
    void GetInfo(int index)
    {
        BookWithMoreAt temporal = books[index];
        books.RemoveAt(index);
    }
    public void RemoveBookOne()
    {
        books.RemoveAt(1);
    }
    public void RemoveBookTwo()
    {
        books.RemoveAt(2);
    }
    public void RemoveBookThree()
    {
        books.RemoveAt(3);
    }
    public void AddBook(BookWithMoreAt bookTest)
    {
        if(books.Count < 3)
        {
            Print(bookTest);
            books.Add(bookTest);
        }
        else
        {
            buttonReplace.SetActive(true);
            Debug.Log("La librería esta llena");
        }
    }    
    public void AddBookButton()
    {
        AddBook(GenerateBook());
    }
    public void Print(BookWithMoreAt bookOne)
    {
        switch (bookOne.Title)
        {
            case 1:
                {
                    Debug.Log("Título: El oso Juancho");
                    break;
                }
            case 2:
                {
                    Debug.Log("Título: El oso Juancho 2");
                    break;
                }
            case 3:
                {
                    Debug.Log("Título: El oso Juancho 3");
                    break;
                }
            case 4:
                {
                    Debug.Log("Título: El regreso del oso Juancho");
                    break;
                }
            case 5:
                {
                    Debug.Log("Título: oso Juancho: ahora es personal");
                    break;
                }
        }

        switch (bookOne.Author)
        {
            case 1:
                {
                    Debug.Log("Autor: Panchito");
                    break;
                }
            case 2:
                {
                    Debug.Log("Autor: Jaimito");
                    break;
                }
            case 3:
                {
                    Debug.Log("Autor: Laurita");
                    break;
                }
            case 4:
                {
                    Debug.Log("Autor: Sandrita");
                    break;
                }
            case 5:
                {
                    Debug.Log("Autor: Dany");
                    break;
                }
        }
        if (bookOne.NumberOfPages > 0)
        {
            Debug.Log("Número de páginas: " + bookOne.NumberOfPages);
        }

        switch (bookOne.Genre)
        {
            case 1:
                {
                    Debug.Log("Género: Comedia");
                    break;
                }
            case 2:
                {
                    Debug.Log("Género: Terror");
                    break;
                }
            case 3:
                {
                    Debug.Log("Género: Drama");
                    break;
                }
            case 4:
                {
                    Debug.Log("Género: Acción");
                    break;
                }
            case 5:
                {
                    Debug.Log("Género: Educativo");
                    break;
                }
        }
        if (bookOne.ReleaseYear > 0)
        {
            Debug.Log("Año de publicación: " + bookOne.ReleaseYear);
        }
        switch (bookOne.BookStatus)
        {
            case 1:
                {
                    Debug.Log("Estado: Nuevo");
                    break;
                }
            case 2:
                {
                    Debug.Log("Estado: Usado");
                    break;
                }
        }

        switch (bookOne.CoverColor)
        {
            case 1:
                {
                    Debug.Log("Color de Portada: Azul");
                    break;
                }
            case 2:
                {
                    Debug.Log("Color de Portada: Rojo");
                    break;
                }
            case 3:
                {
                    Debug.Log("Color de Portada: Negro");
                    break;
                }
            case 4:
                {
                    Debug.Log("Color de Portada: Blanco");
                    break;
                }
            case 5:
                {
                    Debug.Log("Color de Portada: Amarillo");
                    break;
                }
        }

    }
}