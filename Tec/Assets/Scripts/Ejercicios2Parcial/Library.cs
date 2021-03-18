using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Library : MonoBehaviour
{
    public Book extrabook = new Book(0, 0, 0);
    public BookWithMoreAt  booknew = new BookWithMoreAt(0, 0, 0, 0);
    private void AddBook()
    {
        ChangeAtributtes();
    }
    private void Update()
    {
        extrabook.Title = Random.Range(1, 6);
        extrabook.Author = Random.Range(1, 6);
        extrabook.NumberOfPages = Random.Range(50, 201);
        booknew.Genre = Random.Range(1, 6);
        booknew.ReleaseYear = Random.Range(1999, 2021);
        booknew.BookStatus = Random.Range(1, 3);
        booknew.CoverColor = Random.Range(1, 6);
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
        if (extrabook.NumberOfPages > 0)
        {
            Debug.Log("Número de páginas: " + extrabook.NumberOfPages);
        }

        switch (booknew.Genre)
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
        if(booknew.ReleaseYear > 0)
        {
            Debug.Log("Año de publicación: " + booknew.ReleaseYear);
        }
        switch (booknew.BookStatus)
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

        switch (booknew.CoverColor)
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
