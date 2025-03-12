using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable] // Inspector に表示できるようにする

public class Item
{
    // アイテムの種類
    public enum Type
    {
        Key,
        Cube,
        Circle,
        Cylinder,
        // アイテムを追加する場合はここに書き足す
    }

    // アイテムのタイプ
    public Type type;

    // アイテムの画像
    public Sprite sprite;

    // コンストラクタ
    public Item(Item item)
    {
        this.type = item.type;
        this.sprite = item.sprite;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
