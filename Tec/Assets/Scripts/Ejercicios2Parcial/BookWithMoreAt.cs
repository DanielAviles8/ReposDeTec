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

    private void Awake()
    {
        extrabook.Title = Random.Range(1, 6);
        extrabook.Author = Random.Range(1, 6);
        extrabook.NumberOfPages = Random.Range(50, 200);
        genre = Random.Range(1, 6);
        releaseYear = Random.Range(1999, 2020);
        bookStatus = Random.Range(1, 3);
        coverColor = Random.Range(1, 6);
    }

    public void ChangeAtributtes()
    {
        switch (extrabook.Title)
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

        switch (extrabook.Author)
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

        Debug.Log("Número de páginas: " + extrabook.NumberOfPages);

        switch (genre)
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

        Debug.Log("Año de publicación: " + releaseYear);

        switch(bookStatus)
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

        switch(coverColor)
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
