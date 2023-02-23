using UnityEngine;
using System.Collections;

public class RateApp : MonoBehaviour
{
    void OnMouseDown()
    {
        transform.localScale = new Vector3(0.9f, 0.9f, 1);
    }

    void OnMouseUpAsButton()
    {
        transform.localScale = new Vector3(1, 1, 1);

        Rate();
    }

    public void OnClickForUI()
    {
        Rate();
    }

    public void Rate()
    {
        Application.OpenURL("market://details?id=" + Application.identifier);
    }

    void OnMouseUp()
    {
        transform.localScale = new Vector3(1, 1, 1);
    }
}