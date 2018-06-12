using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase : MonoBehaviour {

    #region Singleton

    public static Chase instance;

    void Awake()
    {
        instance = this;
    }
    #endregion

    public GameObject player; // References the Player
}
