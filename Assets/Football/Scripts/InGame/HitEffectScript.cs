using UnityEngine;
using System.Collections;

public class HitEffectScript : MonoBehaviour
{
    private SpriteRenderer sp;
    private int index;
    public Sprite[] sprites;

    void Start()
    {
        sp = GetComponent<SpriteRenderer>();
        index = 0;
        sp.sprite = sprites[index];

        StartCoroutine(Effect());
    }

    private IEnumerator Effect()
    {
        yield return new WaitForSeconds(0.05f);
        index++;

        if (index < sprites.Length)
        {
            sp.sprite = sprites[index];
            StartCoroutine(Effect());
        }
        else
        {
            Destroy(gameObject);
        }
    }
}