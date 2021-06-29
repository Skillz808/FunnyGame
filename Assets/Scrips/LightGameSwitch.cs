using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightGameSwitch : MonoBehaviour
{

    public GameObject up;
    public GameObject on;
    public GameObject isInputEnabled;
    bool isOn;
    bool isUp;

    // Start is called before the first frame update
    void Start()
    {
        bool isUp = (Random.value > 0.35f);
        isOn = !isUp;
        on.SetActive(isOn);
        up.SetActive(isUp);
        if (isOn)
        {
            LightGameMain.Instance.SwitchChange(1);
        }
    }

    // Update is called once per frame
    private void OnMouseUp()
    {
        if (isInputEnabled.activeInHierarchy)
        {
        isUp = isOn;
        isOn = !isOn;
        on.SetActive(isOn);
        up.SetActive(isUp);
        if (isOn)
        {
            LightGameMain.Instance.SwitchChange(1);
        }
        else
        {
            LightGameMain.Instance.SwitchChange(-1);
        }
        }
    }
}
