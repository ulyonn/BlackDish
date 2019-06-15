using Facebook.MiniJSON;
using System;
using System.Collections.Generic;
using UnityEngine;

public class RestaurantController : MonoBehaviour {

    private void Start()
    {
        LoadRestaurant();
    }
    public void LoadRestaurant()
    {
        string Data = Webservice.GetPost("http://localhost/api-rest/controller/RestaurantController.php", "accion", "cargar");
     	Debug.Log(Data);
        Dictionary<string, object> values =
        JsonConvert.DeserializeObject<Dictionary<string, object>>(json);
        /*var json_serializer = new JavaScriptSerializer();
		var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject();
		Console.WriteLine(routes_list["test"]);
		*/
    }

}

