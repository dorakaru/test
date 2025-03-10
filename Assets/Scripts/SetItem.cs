using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SetItem : MonoBehaviour
{
    [SerializeField] GameObject setItemObj; // 設置するオブジェクト
    public UnityEvent SetEvent; // アイテム設置時に発生させるイベント
    int F_set = 0;

    public void OnClickObj()
    {
        if (F_set == 0)
        {// アイテム「Cube」が選択されているかチェック
            if (ItemBox.instance.CheckSelectItem(Item.Type.Cube))
            {
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
        setItemObj.SetActive(true); // 非表示だったオブジェクトを表示
        SetEvent.Invoke(); // 設定されたイベントを実行
        F_set = 1;
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
