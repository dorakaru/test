using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SetItem : MonoBehaviour
{
    [SerializeField] GameObject setItemObj1; // �ݒu����I�u�W�F�N�g
    [SerializeField] GameObject setItemObj2; // �ݒu����I�u�W�F�N�g
    public UnityEvent SetEvent; // �A�C�e���ݒu���ɔ���������C�x���g
    public int F_set = 0; //����ɃI�u�W�F�N�g���ݒu����Ă��邩�̃t���O
    int F_type; //�ݒu����I�u�W�F�N�g�̎��

    public void OnClickObj()
    {
        F_type = 0;
        if (F_set == 0)
        {// �A�C�e���uCube�v���I������Ă��邩�`�F�b�N
            if (ItemBox.instance.CheckSelectItem(Item.Type.Cube))
            {
                F_type = 1;
                // �I�𒆂̃A�C�e�����g�p����
                ItemBox.instance.UseSelectItem();
                // �A�C�e�����Z�b�g���鏈�������s
                ItemSet();
            }

            if (ItemBox.instance.CheckSelectItem(Item.Type.Key))
            {
                F_type = 2;
                // �I�𒆂̃A�C�e�����g�p����
                ItemBox.instance.UseSelectItem();
                // �A�C�e�����Z�b�g���鏈�������s
                ItemSet();
            }
        }
    }

    void ItemSet()
    {
        Debug.Log("set"); // �f�o�b�O���O���o��
        ItemSetType();
        SetEvent.Invoke(); // �ݒ肳�ꂽ�C�x���g�����s
        F_set = 1;
    }

    void ItemSetType()
    {
        if (F_type == 1) 
        {
            Debug.Log("Cube"); // �f�o�b�O���O���o��
            setItemObj1.SetActive(true); // ��\���������I�u�W�F�N�g��\��
        }

        if (F_type == 2)
        {
            Debug.Log("Key"); // �f�o�b�O���O���o��
            setItemObj2.SetActive(true); // ��\���������I�u�W�F�N�g��\��
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
