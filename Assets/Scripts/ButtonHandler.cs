using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    public void onFinish(){
       Debug.Log(NativeInterfaceImpl.userId);
       NativeInterfaceImpl scene1 = GameObject.Find("GameManager").GetComponent<NativeInterfaceImpl>();
         scene1.onGameEnd("55");
    }
}
