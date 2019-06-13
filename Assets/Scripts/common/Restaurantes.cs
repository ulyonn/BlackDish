using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Restaurantes : MonoBehaviour {
    int idRestaurante;
    string nombreRestaurante;
    string direccionRestaurante;
    string telefonoRestaurante;
    int idMenu;
    int idPromocion;

    public int idRestaurante{
      get{
        return this.idRestaurante;
      }
      set{
        this.idRestaurante = value;
      }
    }

    public string nombreRestaurante{
      get{
        return this.nombreRestaurante;
      }
      set{
        this.nombreRestaurante = value;
      }
    }

    public string direccionRestaurante{
      get{
        return this.direccionRestaurante;
      }
      set{
        this.direccionRestaurante = value;
      }
    }

    public string telefonoRestaurante{
      get{
        return this.telefonoRestaurante;
      }
      set{
        this.telefonoRestaurante = value;
      }
    }

    public int idMenu{
      get{
        return this.idMenu;
      }
      set{
        this.idMenu = value;
      }
    }

    public int idPromocion{
      get{
        return this.idPromocion;
      }
      set{
        this.idPromocion = value;
      }
    }

}
