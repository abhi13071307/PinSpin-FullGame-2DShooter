using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Score : MonoBehaviour
{
    public static int PinCount;
    public TextMeshProUGUI text;
    

    void Start()
    {
        PinCount = 0;
    }

    void Update()
    {
        text.text = PinCount.ToString();
    }
}
