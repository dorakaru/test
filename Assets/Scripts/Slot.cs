using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    [SerializeField] GameObject backPanel = default; // 選択枠
    [SerializeField] Image image = default; // アイテム画像
    Item item = null; // アイテム情報

    private void Start()
    {
        // 初期状態では枠を非表示
        backPanel.SetActive(false);
    }

    // アイテムをスロットにセット
    public void Set(Item item)
    {
        this.item = item;
        image.sprite = item.sprite; // アイテムの画像を設定
    }

    // アイテムをスロットから削除
    public void RemoveItem()
    {
        item = null;
        image.sprite = null;
        HideBackPanel(); // 枠も非表示にする
    }

    // アイテム情報を取得
    public Item GetItem()
    {
        return item;
    }

    // スロットが空かどうか判定
    public bool IsEmpty()
    {
        return item == null;
    }

    // アイテムを選択したときに枠を表示
    public void OnSelect()
    {
        backPanel.SetActive(true);
    }

    // 選択を解除（枠を非表示）
    public void HideBackPanel()
    {
        backPanel.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
