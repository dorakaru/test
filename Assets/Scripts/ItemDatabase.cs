using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    // どこからでもアクセスできるようにする
    public static ItemDatabase instance;

    private void Awake()
    {
        instance = this;
    }

    [SerializeField] ItemDatabaseEntity itemDatabaseEntity = default;

    // アイテムを取得する関数
    public Item Spawn(Item.Type type)
    {
        foreach (Item itemData in itemDatabaseEntity.items)
        {
            // データベースから一致するアイテムを探す
            if (itemData.type == type)
            {
                return new Item(itemData);
            }
        }
        return null;
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
