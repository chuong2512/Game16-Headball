using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class OpenLevel : MonoBehaviour
{
    public string levelName;
    public GameObject purchase;

    void OnMouseUpAsButton()
    {
        if (purchase.activeSelf)
        {
            return;
        }

        transform.localScale = new Vector3(1, 1, 1);

        AssetManager.Use.PlaySound(7);

        SceneManager.LoadScene(levelName);
    }

    void OnMouseDown()
    {
        transform.localScale = new Vector3(0.9f, 0.9f, 1);
    }

    void OnMouseUp()
    {
        transform.localScale = new Vector3(1, 1, 1);
    }
}