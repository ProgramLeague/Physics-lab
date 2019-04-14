using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class electrostaticIField : IField
{
    public double k;

    public electrostaticIField(GameObject thisObj, double k = 9000000000)
    {
        this.thisObj = thisObj;
        this.thisPo = thisObj.GetComponent<phyObj>();
        this.k = k;
    }

    protected override void realUpdate(GameObject obj)
    {
        Vector3 pos2 = obj.transform.position;
        Vector3 dir = unityFire.getItemPos(thisObj) - pos2;
        double r2 = dir.sqrMagnitude;
        phyObj po = obj.GetComponent<phyObj>();
        double F = (k * thisPo.getq() * po.getq()) / r2;

        if(F < 0)
        {
            F = -F;
            dir = -dir;
        }
        unityFire.addItemForce(obj, (float)F, dir.normalized);
    }
}
