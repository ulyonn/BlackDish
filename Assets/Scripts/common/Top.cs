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

	public int idPlatillo{
		get{
			return this.idPlatillo;
		}
		set{
			this.idPlatillo = value;
		}
	}

	public string nombrePlatillo{
		get{
			return this.nombrePlatillo;
		}
		set{
			this.nombrePlatillo = value;
		}
	}

	public string descripcionPlatillo{
		get{
			return this.descripcionPlatillo;
		}
		set{
			this.descripcionPlatillo = value;
		}
	}

	public float costoPlatillo{
		get{
			return this.costoPlatillo;
		}
		set{
			this.costoPlatillo = value;
		}
	}

	public float puntuacionPlatillo{
		get{
			return this.puntuacionPlatillo;
		}
		set{
			this.puntuacionPlatillo = value;
		}
	}


}
