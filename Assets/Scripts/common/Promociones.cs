using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Promociones : MonoBehaviour {
    int idPromocion;
    string nombrePromocion;
    string descripcionPromocion;
    float costoPromocion;

    public int IdPromocion{
        get{
            return this.idPromocion;
        }
        set{
            this.idPromocion = value;
        }
    }

    public string NombrePromocion{
        get{
            return this.nombrePromocion;
        }
        set{
            this.nombrePromocion = value;
        }
    }

    public string DescripcionPromocion{
        get{
            return this.descripcionPromocion;
        }
        set{
            this.descripcionPromocion = value;
        }
    }

    public float CostoPromocion{
        get{
            return this.costoPromocion;
        }
        set{
            this.costoPromocion = value;
        }
    }
	
}
