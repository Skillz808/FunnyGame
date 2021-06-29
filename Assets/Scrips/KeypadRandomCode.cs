using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeypadRandomCode : MonoBehaviour
{

    float CardCode;
    [SerializeField] Text RandomText;

    public void Start()
    {
        CardCode = (Random.Range (100000f, 1000000f));
        CardCode = (Mathf.Round(CardCode));
        print(CardCode);
        RandomText.text = CardCode.ToString();
    }

}
