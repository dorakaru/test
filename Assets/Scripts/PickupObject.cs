using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObject : MonoBehaviour
{
    // 取得するアイテムの種類を設定
    public Item.Type type = default;

    // アイテムをクリックしたときの処理
    public void OnClickObject()
    {
        // アイテムデータベースからアイテム情報を取得
        Item item = ItemDatabase.instance.Spawn(type);

        // アイテムボックスにアイテムを追加
        if (item != null)
        {
            ItemBox.instance.SetItem(item);
        }

        // クリックしたアイテムを非表示にする
        gameObject.SetActive(false);

        SetItem setitem; //呼ぶスクリプトにあだなつける
        GameObject obj = GameObject.Find("PedestalTop"); //PedestalTopっていうオブジェクトを探す
        setitem = obj.GetComponent<SetItem>(); //付いているスクリプトを取得
        setitem.F_set = 0;

    }
    
    //クリックしたら消える(取得)
    /*
    public void OnClickObject()
    {
        gameObject.SetActive(false);
    }*/

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
