using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    [SerializeField] Slot[] slots = default; // ���ׂẴX���b�g���擾
    public static ItemBox instance; // ���̃X�N���v�g����A�N�Z�X�ł���悤�ɂ���
    Slot selectSlot; // �I�𒆂̃X���b�g

    private void Awake()
    {
        instance = this; // �V���O���g���p�^�[����K�p
    }

    // �A�C�e�����X���b�g�ɒǉ�
    public void SetItem(Item item)
    {
        for (int i = 0; i < slots.Length; i++)
        {
            Slot slot = slots[i];
            if (slot.IsEmpty()) // ��̃X���b�g��T��
            {
                slot.Set(item);
                break;
            }
        }
    }

    // �X���b�g���N���b�N������I����Ԃɂ���
    public void OnSlotClick(int position)
    {
        if (slots[position].IsEmpty()) return; // ��̃X���b�g�Ȃ牽�����Ȃ�

        // ���ׂẴX���b�g�̑I��g���\���ɂ���
        for (int i = 0; i < slots.Length; i++)
        {
            slots[i].HideBackPanel();
        }

        // �N���b�N�����X���b�g�̘g��\��
        slots[position].OnSelect();
        selectSlot = slots[position]; // �I����ԂƂ��ĕۑ�
    }

    // �I�𒆂̃A�C�e��������̃^�C�v���ǂ�������
    public bool CheckSelectItem(Item.Type useItemType)
    {
        if (selectSlot == null) return false;
        return selectSlot.GetItem().type == useItemType;
    }

    // �I�𒆂̃A�C�e�����g�p���č폜
    public void UseSelectItem()
    {
        selectSlot.RemoveItem();
        selectSlot = null;
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
