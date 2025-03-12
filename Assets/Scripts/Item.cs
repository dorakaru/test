using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable] // Inspector �ɕ\���ł���悤�ɂ���

public class Item
{
    // �A�C�e���̎��
    public enum Type
    {
        Key,
        Cube,
        Circle,
        Cylinder,
        // �A�C�e����ǉ�����ꍇ�͂����ɏ�������
    }

    // �A�C�e���̃^�C�v
    public Type type;

    // �A�C�e���̉摜
    public Sprite sprite;

    // �R���X�g���N�^
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
