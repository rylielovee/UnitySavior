using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warlock : Enemy
{
    public string weapon = "Magic";
    private string lastWords = "Nooo.... I've been stabbed!";
    private string words = "Ha Ha Ha! You will die by my magic!";

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Talking());
    }

    public override IEnumerator Talking()
    {
        console.SetText(text);
        yield return new WaitForSeconds(2);
        console.SetText(words);
        Talking();
    }

    public override void Kill()
    {
        console.SetText(lastWords);
        Destroy(gameObject);
    }
}
