using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    // �ǂ�����ł��A�N�Z�X�ł���悤�ɂ���
    public static ItemDatabase instance;

    private void Awake()
    {
        instance = this;
    }

    [SerializeField] ItemDatabaseEntity itemDatabaseEntity = default;

    // �A�C�e�����擾����֐�
    public Item Spawn(Item.Type type)
    {
        foreach (Item itemData in itemDatabaseEntity.items)
        {
            // �f�[�^�x�[�X�����v����A�C�e����T��
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
