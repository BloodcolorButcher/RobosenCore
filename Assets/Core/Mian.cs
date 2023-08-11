using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mian : MonoBehaviour
{
    public static Mian Instance = null;

    public void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Hello()
    {
        Debug.Log("你好啊");
    }
    
}
