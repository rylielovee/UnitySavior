using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Enemy : MonoBehaviour
{
    public string text = "";
    public string item1 = "";
    public string item2 = "";
    public TMP_Text console;

    public string Item1 { get { return item1; } }
    public string Item2 { get { return item2; } }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Talking());
    }

    public virtual IEnumerator Talking()
    {
        console.SetText(text);
        yield return new WaitForSeconds(2);
        console.SetText("RAAAAAAA!");
        Talking();
    }

    public virtual void Kill()
    {
        string toConsole = "Nooooooooooo";
        console.SetText(toConsole);
        Destroy(gameObject);
    }    
}
