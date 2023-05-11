using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class namePlayer : MonoBehaviour
{ 
    public TMP_Text playerNameText;

    public void UpdatePlayerName()
    {
        Debug.Log(playerNameText.text);
        PlayerPrefs.SetString("UserName", playerNameText.text);
        
    }
}
