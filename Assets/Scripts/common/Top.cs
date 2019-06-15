using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Top : MonoBehaviour {
	int idPlatillo;
	string nombrePlatillo;
	string descripcionPlatillo;
	float costoPlatillo;
	float puntuacionPlatillo;

	public int IdPlatillo{
		get{
			return this.idPlatillo;
		}
		set{
			this.idPlatillo = value;
		}
	}

	public string NombrePlatillo{
		get{
			return this.nombrePlatillo;
		}
		set{
			this.nombrePlatillo = value;
		}
	}

	public string DescripcionPlatillo{
		get{
			return this.descripcionPlatillo;
		}
		set{
			this.descripcionPlatillo = value;
		}
	}

	public float CostoPlatillo{
		get{
			return this.costoPlatillo;
		}
		set{
			this.costoPlatillo = value;
		}
	}

	public float PuntuacionPlatillo{
		get{
			return this.puntuacionPlatillo;
		}
		set{
			this.puntuacionPlatillo = value;
		}
	}


}
