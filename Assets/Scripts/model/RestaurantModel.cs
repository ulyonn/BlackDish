using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RestaurantModel : MonoBehaviour {
    List<Restaurantes> lista;
    //Metodo de carga de datos inicial, este metodo carga la lista de restaurants activos en base de datos.
    public List<Restaurantes> CargarRestaurantes() {
        try {

        }
        catch(Exception x) {
            Console.WriteLine("The trace is"+x.StackTrace);
        }
        return lista;
    }
    
}
