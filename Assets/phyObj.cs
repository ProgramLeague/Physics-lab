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

    universalGravIField ugF;
    electrostaticIField eF;
    private void Start()
    {
        this.ugF = new universalGravIField(this.gameObject);
        this.eF = new electrostaticIField(this.gameObject);
        init.allField.Add(this.ugF);
        init.allField.Add(this.eF);
    }

    private void Update()
    {
        //计算所有力场作用
        foreach(field f in init.allField)
        {
            f.update(this.gameObject);
        }
    }

    ~phyObj()
    {
        init.allField.Remove(ugF);
        init.allField.Remove(eF);
    }
}
