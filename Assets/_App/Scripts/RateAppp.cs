using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RateAppp : MonoBehaviour
{
    public void OnClickRateUs()
    {
        Application.OpenURL("market://details?id=" + Application.identifier);
    }
    public void OnClickPrivacy()
    {
        Application.OpenURL("");
    }
}
