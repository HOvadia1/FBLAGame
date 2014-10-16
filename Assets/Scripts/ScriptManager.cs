using UnityEngine;
using System.Collections;

public class ScriptManager : MonoBehaviour {

    PlayerMovement pm;

    void Awake()
    {
        pm = GameObject.Find("Player").GetComponent<PlayerMovement>();
        Debug.Log("ScriptManager Successfully Loaded!");
    }
}
