using UnityEngine;

public class creatObj : MonoBehaviour {

    public static GameObject creatObject(Vector3 v, float m = 1, float q = 0, float e = 1, float size = 0)
    {
        GameObject obj = unityFire.addItem("Sphere", v);
        unityFire.setItemScale(obj, size, size, size);
        phyObj po = obj.GetComponent<phyObj>();
        po.setm(m);
        po.setq(q);
        if (e > 1 || e < 0)
        {
            //碰撞系数在0-1之间，应判断一下
        }
        po.sete(e);
        return obj;
    }

}
