using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextSave : MonoBehaviour
{
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
}