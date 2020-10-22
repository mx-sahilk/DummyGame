using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Dummy scene component
public class NativeInterfaceImpl : MonoBehaviour
{
    
    public static string userId;
    
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        onGameStart("123");   
    }


    //For starting the game with all required data to the game
    // param id is player id
    public void onGameStart(string id){
         userId = id;
         launchGame();
    }

    public void launchGame(){
        SceneManager.LoadScene("MXGame", LoadSceneMode.Additive);
    }

    //this method is called to post score to native when game finished
    public void onGameEnd(string score){
        Debug.Log(score);
        AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject jo = jc.GetStatic<AndroidJavaObject>("currentActivity");
        jo.Call("onGameFinish",score);

        Application.Quit();
    }
}
