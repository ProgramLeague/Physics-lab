using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class phyObj : MonoBehaviour {

    float q=0;

    public float getq() { return this.q; }
    public void setq(float q) { this.q = q; }

	public float getm()
    {
        Rigidbody rb = this.gameObject.GetComponent<Rigidbody>();
        return rb.mass;
    }

    public void setm(float mass)
    {
        Rigidbody rb = this.gameObject.GetComponent<Rigidbody>();
        rb.mass = mass;
    }

    private void Update()
    {
        foreach(field f in init.allField)
        {
            f.update(this.gameObject);
        }
    }
}
