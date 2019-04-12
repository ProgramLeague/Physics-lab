using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class phyObj : MonoBehaviour {

    float q = 0;//电荷量
    float e = 1;//碰撞因数（碰撞系数）

    public float getq() { return this.q; }
    public float gete() { return this.e; }

    public void setq(float q) { this.q = q; }
    public void sete(float e) { this.e = e; }
    
    
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

    private void OnCollisionEnter(Collision collision)//只针对了对心碰撞？
    {
        var gameobj1 = this.gameObject;
        var phyobj1 = GetComponent<phyObj>();
        var gameobj2 = collision.gameObject;
        var phyobj2 = GetComponent<phyObj>();
        var m1 = phyobj1.getm();
        var v1 = unityFire.getItemVelocity(gameobj1);
        var m2 = phyobj2.getm();
        var v2 = unityFire.getItemVelocity(gameobj2);
        var e = phyobj1.gete() > phyobj2.gete() ? phyobj1.gete() : phyobj2.gete();
        var newv1 = (m1 * v1 + m2 * v2 - e * m2 * (v1 - v2)) / (m1 + m2);
        var newv2 = (m1 * v1 + m2 * v2 - e * m1 * (v2 - v1)) / (m1 + m2);
        unityFire.setItemVelocity(gameobj1, 1, newv1);
        unityFire.setItemVelocity(gameobj2, 1, newv2);
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
