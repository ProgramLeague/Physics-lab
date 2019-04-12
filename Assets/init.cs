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

        var o1=creatObj.creatObject(new Vector3(0, 0, 0), 1, 0.00002f);
        var o2=creatObj.creatObject(new Vector3(2, 2, 2), 1, 0.0002f);

        Vector3 d1 = unityFire.getItemPos(o1) - unityFire.getItemPos(o2);
        Vector3 d2 = new Vector3(0, 1, 0);
        unityFire.addItemVelocity(o1, 4, calu.normalVector(d1,d2));

        creatObj.creatObject(new Vector3(3, 3, 3), 99999999999, 0, 1, 1);
        creatObj.creatObject(new Vector3(4, 4, 4), 99999999999, 0, 1, 1);
    }
	
}
