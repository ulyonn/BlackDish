using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Categorias : MonoBehaviour {
    int idCategoria;
    string nombreCategoria;

    public int idCategoria{
        get{
            return this.idCategoria;
        }
        set{
            this.idCategoria = value;
        }
    }

    public string nombreCategoria
    {
        get{
            return this.nombreCategoria;
        }
        set{
            this.nombreCategoria = value;
        }
    }
}
