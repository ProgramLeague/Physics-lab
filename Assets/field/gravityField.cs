using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravityField : field
{
    public float a;
    public Vector3 direction;

    public gravityField(float a, Vector3 direction)
    {
        this.a = a;
        this.direction = direction;
    }

    public override void update(GameObject obj)
    {
        phyObj po = obj.GetComponent<phyObj>();
        float m = po.getm();
        unityFire.addItemForce(obj, m * this.a, this.direction);
    }
}
