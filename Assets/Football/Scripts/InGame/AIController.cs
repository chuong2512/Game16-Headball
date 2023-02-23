using UnityEngine;
using System.Collections;

public class AIController : MonoBehaviour
{
    public float[] forceDistances;
    public PlayerScripts player;

    void Start()
    {
        GetComponent<CircleCollider2D>().radius = forceDistances[PlayerPrefs.GetInt(VariablesName.AILevel, 1)];
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.name == "Ball")
        {
            player.Action();
        }
    }
}