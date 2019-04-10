using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class electricField : field
{
    public float E;
    public Vector3 direction;

    public electricField(float E, Vector3 direction)
    {
        this.E = E;
        this.direction = direction;
    }

    public override void update(GameObject obj)
    {
        phyObj po = obj.GetComponent<phyObj>();
        unityFire.addItemForce(obj, po.getq() * this.E, this.direction);
    }
}
