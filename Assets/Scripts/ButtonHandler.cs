using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    public void onFinish(){
       NativeInterfaceImpl scene1 = GameObject.Find("GameManager").GetComponent<NativeInterfaceImpl>();
         scene1.onGameEnd("55");
    }
}
