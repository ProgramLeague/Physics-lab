using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magneticField : field
{
    public float B;
    public Vector3 direction;

    public magneticField(float B, Vector3 direction)
    {
        this.B = B;
        this.direction = direction;
    }

    public override void update(GameObject obj)
    {
        phyObj po = obj.GetComponent<phyObj>();
        Vector3 v = unityFire.getItemVelocity(obj);
        unityFire.addItemForce(obj, B * po.getq() * v.magnitude, calu.normalVector(this.direction, v).normalized);
    }
}
