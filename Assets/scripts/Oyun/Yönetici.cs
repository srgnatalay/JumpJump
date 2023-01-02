using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Yönetici : MonoBehaviour
{
    public TextMeshProUGUI score;
    public static float scoresayısı;
    void Start()
    {
        
    }

    
    void Update()
    {
        score.text = scoresayısı.ToString();
    }
}
