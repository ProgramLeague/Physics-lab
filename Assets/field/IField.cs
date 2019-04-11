using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IField : field
{
    protected GameObject thisObj;
    protected phyObj thisPo;

    protected abstract void realUpdate(GameObject obj);
    public override void update(GameObject obj)
    {
        if (obj != thisObj)
            realUpdate(obj);
    }
}
