using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstScript : MonoBehaviour
{
    public Text myText;
    void Start()
    {
        myText.text = "Hello World!";
    }
}
