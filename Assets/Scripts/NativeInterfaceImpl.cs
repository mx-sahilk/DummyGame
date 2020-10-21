using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NativeInterfaceImpl : MonoBehaviour
{
    // Start is called before the first frame update
    public static string userId;
    
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        //onGameStart("123");   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onGameStart(string id){
         userId = id;
         launchGame();
    }

    public void launchGame(){
        SceneManager.LoadScene("MXGame", LoadSceneMode.Additive);
    }

    public void onGameEnd(string score){
        Debug.Log(score);
        AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject jo = jc.GetStatic<AndroidJavaObject>("currentActivity");
        jo.Call("onGameFinish",score);

        Application.Quit();
    }
}
