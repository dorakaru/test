using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SetItem : MonoBehaviour
{
    [SerializeField] GameObject setItemObj; // �ݒu����I�u�W�F�N�g
    public UnityEvent SetEvent; // �A�C�e���ݒu���ɔ���������C�x���g
    int F_set = 0;

    public void OnClickObj()
    {
        if (F_set == 0)
        {// �A�C�e���uCube�v���I������Ă��邩�`�F�b�N
            if (ItemBox.instance.CheckSelectItem(Item.Type.Cube))
            {
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
        setItemObj.SetActive(true); // ��\���������I�u�W�F�N�g��\��
        SetEvent.Invoke(); // �ݒ肳�ꂽ�C�x���g�����s
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
