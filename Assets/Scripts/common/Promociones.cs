using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Promociones : MonoBehaviour {
    int idPromocion;
    string nombrePromocion;
    string descripcionPromocion;
    float costoPromocion;

    public int idPromocion{
        get{
            return this.idPromocion;
        }
        set{
            this.idPromocion = value;
        }
    }

    public string nombrePromocion{
        get{
            return this.nombrePromocion;
        }
        set{
            this.nombrePromocion = value;
        }
    }

    public string descripcionPromocion{
        get{
            return this.descripcionPromocion;
        }
        set{
            this.descripcionPromocion = value;
        }
    }

    public float costoPromocion{
        get{
            return this.costoPromocion;
        }
        set{
            this.descripcionPromocion = value;
        }
    }
	
}
