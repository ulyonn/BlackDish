using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Restaurantes : MonoBehaviour {
    int idRestaurante;
    string nombre;
    string direccion;
    string telefono;
    int idMenu;
    int idPromocion;

    public int IdRestaurante{
      get{
        return this.idRestaurante;
      }
      set{
        this.idRestaurante = value;
      }
    }

    public string Nombre{
      get{
        return this.nombre;
      }
      set{
        this.nombre = value;
      }
    }

    public string Direccion{
      get{
        return this.direccion;
      }
      set{
        this.direccion = value;
      }
    }

    public string Telefono{
      get{
        return this.telefono;
      }
      set{
        this.telefono = value;
      }
    }

    public int IdMenu{
      get{
        return this.idMenu;
      }
      set{
        this.idMenu = value;
      }
    }

    public int IdPromocion{
      get{
        return this.idPromocion;
      }
      set{
        this.idPromocion = value;
      }
    }

}
