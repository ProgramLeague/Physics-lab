using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class init : MonoBehaviour {

    public static List<field> allField = new List<field>();

	void Start ()
    {
        //初始化所有的场
        var f = new gravityField(9.8f, new Vector3(0, -1, 0));
        allField.Add(f);

        creatObj.creatObject(new Vector3(0, 0, 0));
	}
	
}
