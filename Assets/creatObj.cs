using UnityEngine;

public class creatObj : MonoBehaviour {

    public static GameObject creatObject(Vector3 v, float m = 1, float q = 0)
    {
        GameObject obj = unityFire.addItem("Sphere", v);
        phyObj po = obj.GetComponent<phyObj>();
        po.setm(m);
        po.setq(q);
        return obj;
    }

}
