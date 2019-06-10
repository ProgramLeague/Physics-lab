using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class init : MonoBehaviour {

    public static List<field> allField = new List<field>();

	void Start ()
    {
        Application.targetFrameRate = 1000;
        //初始化所有的场
        /*var f = new gravityField(9.8f, new Vector3(0, -1, 0));
        allField.Add(f);*/
        var fb = new magneticField(1e4f, new Vector3(0, 0, 1));
        allField.Add(fb);
        var o1=creatObj.creatObject(new Vector3(0, -4, 0), 0.5f, -2e-4f);
        //var o2=creatObj.creatObject(new Vector3(0, 5, 0), 0.5f, 2e-5f);

        unityFire.addItemVelocity(o1, 2f, new Vector3(-1, 0, 0));
        //unityFire.addItemVelocity(o2, 2f, new Vector3(1, 0, 0));

        //creatObj.creatObject(new Vector3(3, 3, 3), 99999999999, 0, 1, 1);
        //creatObj.creatObject(new Vector3(4, 4, 4), 99999999999, 0, 1, 1);
    }
	
}
