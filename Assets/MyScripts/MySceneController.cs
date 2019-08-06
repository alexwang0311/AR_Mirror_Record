using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MySceneController : MonoBehaviour {
    
    public void SwitchToReplay()
    {
        SceneManager.LoadScene("Replay");
    }

    public void SwitchToRecord()
    {
        SceneManager.LoadScene("Record");
    }
}
