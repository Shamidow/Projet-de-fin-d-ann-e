using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool isFullSceens;
    public static float volumes;
    void Start()
    {
        Object.DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        isFullSceens = OptionsMenu.isFullScreenm;
        volumes = OptionsMenu.volumem;
    }
}
