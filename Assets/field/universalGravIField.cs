using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class universalGravIField : IField
{
    public double G;

    public universalGravIField(GameObject thisObj, double G = 0.0000000000667)
    {
        this.thisObj = thisObj;
        this.thisPo = thisObj.GetComponent<phyObj>();
        this.G = G;
    }

    protected override void realUpdate(GameObject obj)
    {
        Vector3 pos2 = obj.transform.position;
        Vector3 dir = unityFire.getItemPos(thisObj) - pos2;
        double r2 = dir.sqrMagnitude;
        phyObj po = obj.GetComponent<phyObj>();
        double F = (G * thisPo.getm() * po.getm()) / r2;

        dir.Normalize();
        unityFire.addItemForce(obj, (float)F, dir);
    }
}
