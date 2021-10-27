using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FXManager : MonoBehaviour
{
    public GameObject pop;
    public static FXManager obj;

     void Awake() {
        obj = this;
    }

    public void showPop(Vector3 pos){
        pop.gameObject.GetComponent<Pop>().show(pos);
    }
     void OnDestroy() {
        obj = null;
    }
}
