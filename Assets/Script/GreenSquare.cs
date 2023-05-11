using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GreenSquare : MonoBehaviour
{
    public TMP_Text playerName;
    float speed = 0.02f;
    private void Start()
    {
        playerName.text = PlayerPrefs.GetString("UserName");
    }
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        Debug.Log(x);
        if(x < 0f)
        {
            transform.Translate(Vector3.left*speed);
        }
        if(x>0f)
        {
            transform.Translate(Vector3.right*speed);
        }
    }

}
