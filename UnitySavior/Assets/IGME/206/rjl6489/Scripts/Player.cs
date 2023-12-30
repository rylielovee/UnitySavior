using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class Character : MonoBehaviour
{
    // Start is called before the first frame update
    public string characterName = "";
  
    private string killButton = "Kill";
    private string moveButton = "Move";
    private string inventoryButton = "Inventory";

    public Inventory inventory;
    public TMP_Text console;

    public TMP_Text KillText;
    public TMP_Text MoveText;
    public TMP_Text InventoryText;

    Level level = null;
    Enemy enemy = null;

    void Start()
    {
        console.SetText(characterName);
        KillText.SetText(killButton);
        MoveText.SetText(moveButton);
        InventoryText.SetText(inventoryButton);

        inventory = new Inventory();
        var enemies = FindObjectsOfType<Enemy>();
        if(enemies.Length > 0)
            enemy = enemies[0];
        var levels = FindObjectsOfType<Level>();
        if (levels.Length > 0)
            level = levels[0];

    }
    public void ButtonKill()
    {
        //console.SetText(killButton);
        KillEnemy();
    }
    public void ButtonMove1()
    {
        //console.SetText("Move");
        MoveToNextRoom1();
    }
    public void ButtonMove2()
    {
        //console.SetText("Move");
        MoveToNextRoom2();
    }
    public void ButtonInventory()
    {
        //console.SetText("Inventory");
        ListInventory();
    }

    public void KillEnemy()
    {
        if(enemy != null)
        {;
            enemy.Kill();
            console.SetText("You found " + enemy.Item1 + ", " + enemy.Item2);
            AddItem(enemy.Item1);
            AddItem(enemy.Item2);
            enemy = null;
        }
    }
    public void AddItem(string name)
    {
        inventory.AddItem(name);
    }
   
    public void MoveToNextRoom1()
    {
        if(level != null)
        {
            bool hasKey = level.HasRightKey1(inventory.Items);
            if(hasKey)
            {
                console.SetText("You may move to the next room.");
                StartCoroutine(level.GoToNextLevel1());
            }
            else
            {
                console.SetText("You don't have the right key!");
            }
        }
    }

    public void MoveToNextRoom2()
    {
        if (level != null)
        {
            bool hasKey = level.HasRightKey2(inventory.Items);
            if (hasKey)
            {
                console.SetText("You may move to the next room.");
                StartCoroutine(level.GoToNextLevel2());
            }
            else
            {
                console.SetText("You don't have the right key!");
            }
        }
    }


    public void ListInventory()
    {
        inventory.ListInventory(console);
    }
}
