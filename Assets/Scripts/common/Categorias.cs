using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Categorias : MonoBehaviour {
    int idCategoria;
    string nombreCategoria;

    public int IdCategoria{
        get{
            return this.idCategoria;
        }
        set{
            this.idCategoria = value;
        }
    }

    public string NombreCategoria
    {
        get{
            return this.nombreCategoria;
        }
        set{
            this.nombreCategoria = value;
        }
    }
}
