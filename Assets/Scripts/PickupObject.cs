using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObject : MonoBehaviour
{
    // �擾����A�C�e���̎�ނ�ݒ�
    public Item.Type type = default;

    // �A�C�e�����N���b�N�����Ƃ��̏���
    public void OnClickObject()
    {
        // �A�C�e���f�[�^�x�[�X����A�C�e�������擾
        Item item = ItemDatabase.instance.Spawn(type);

        // �A�C�e���{�b�N�X�ɃA�C�e����ǉ�
        if (item != null)
        {
            ItemBox.instance.SetItem(item);
        }

        // �N���b�N�����A�C�e�����\���ɂ���
        gameObject.SetActive(false);

        SetItem setitem; //�ĂԃX�N���v�g�ɂ����Ȃ���
        GameObject obj = GameObject.Find("PedestalTop"); //PedestalTop���Ă����I�u�W�F�N�g��T��
        setitem = obj.GetComponent<SetItem>(); //�t���Ă���X�N���v�g���擾
        setitem.F_set = 0;

    }
    
    //�N���b�N�����������(�擾)
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
