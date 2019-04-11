using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class init : MonoBehaviour {

    public static List<field> allField = new List<field>();

	void Start ()
    {
        //初始化所有的场
        /*var f = new gravityField(9.8f, new Vector3(0, -1, 0));
        allField.Add(f);*/

        var o1=creatObj.creatObject(new Vector3(0, 0, 0),1,0.00002f);
        unityFire.addItemVelocity(o1,1,new Vector3(-0.5f, 0.5f, -0.5f));
        creatObj.creatObject(new Vector3(2, 2, 2), 1, 0.0002f);
        creatObj.creatObject(new Vector3(3, 3, 3), 99999999999);
        creatObj.creatObject(new Vector3(4, 4, 4), 99999999999);
    }
	
}
