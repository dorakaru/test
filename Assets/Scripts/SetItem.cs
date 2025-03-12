using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SetItem : MonoBehaviour
{
    [SerializeField] GameObject setItemObj1; // 設置するオブジェクト
    [SerializeField] GameObject setItemObj2; // 設置するオブジェクト
    public UnityEvent SetEvent; // アイテム設置時に発生させるイベント
    public int F_set = 0; //台座にオブジェクトが設置されているかのフラグ
    int F_type; //設置するオブジェクトの種類

    public void OnClickObj()
    {
        F_type = 0;
        if (F_set == 0)
        {// アイテム「Cube」が選択されているかチェック
            if (ItemBox.instance.CheckSelectItem(Item.Type.Cube))
            {
                F_type = 1;
                // 選択中のアイテムを使用する
                ItemBox.instance.UseSelectItem();
                // アイテムをセットする処理を実行
                ItemSet();
            }

            if (ItemBox.instance.CheckSelectItem(Item.Type.Key))
            {
                F_type = 2;
                // 選択中のアイテムを使用する
                ItemBox.instance.UseSelectItem();
                // アイテムをセットする処理を実行
                ItemSet();
            }
        }
    }

    void ItemSet()
    {
        Debug.Log("set"); // デバッグログを出力
        ItemSetType();
        SetEvent.Invoke(); // 設定されたイベントを実行
        F_set = 1;
    }

    void ItemSetType()
    {
        if (F_type == 1) 
        {
            Debug.Log("Cube"); // デバッグログを出力
            setItemObj1.SetActive(true); // 非表示だったオブジェクトを表示
        }

        if (F_type == 2)
        {
            Debug.Log("Key"); // デバッグログを出力
            setItemObj2.SetActive(true); // 非表示だったオブジェクトを表示
        }
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
