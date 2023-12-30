using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;
using TMPro;

public class Inventory
{
    private static List<string> items = new List<string>();
    
    public List<string> Items { get { return items; } }


    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddItem(string item)
    {
        items.Add(item.ToLower());
    }
    public bool ContainsItem(string item)
    {
        return items.Contains(item.ToLower());
    }
    public void ListInventory(TMP_Text console)
    {
        string output = "Your Inventory is empty!";
        if (items.Count > 0)
        {
            output = "Your inventory contains: \n";

            foreach (string item in items)
            {
                output = output + item + ", ";
            }
        }
        console.text = output;
    }
}
