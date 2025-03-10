using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    [SerializeField] GameObject backPanel = default; // �I��g
    [SerializeField] Image image = default; // �A�C�e���摜
    Item item = null; // �A�C�e�����

    private void Start()
    {
        // ������Ԃł͘g���\��
        backPanel.SetActive(false);
    }

    // �A�C�e�����X���b�g�ɃZ�b�g
    public void Set(Item item)
    {
        this.item = item;
        image.sprite = item.sprite; // �A�C�e���̉摜��ݒ�
    }

    // �A�C�e�����X���b�g����폜
    public void RemoveItem()
    {
        item = null;
        image.sprite = null;
        HideBackPanel(); // �g����\���ɂ���
    }

    // �A�C�e�������擾
    public Item GetItem()
    {
        return item;
    }

    // �X���b�g���󂩂ǂ�������
    public bool IsEmpty()
    {
        return item == null;
    }

    // �A�C�e����I�������Ƃ��ɘg��\��
    public void OnSelect()
    {
        backPanel.SetActive(true);
    }

    // �I���������i�g���\���j
    public void HideBackPanel()
    {
        backPanel.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
