using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int mp = 53; �@�@//����

    //���@�U��������Magic�֐�
    public void Magic()
    {
        //mp��5�ȏ�̏ꍇ
        if (mp >= 5)
        {
            mp -= 5;
            Debug.Log("���@�U���������B�c��MP��" + mp + "�B");
        }
        //�����łȂ��ꍇ
        else
        {
            Debug.Log("MP������Ȃ����߁A���@���g���Ȃ��B");
        }
    }
}

public class Test : MonoBehaviour
{
    void Start()
    {

        // Boss�N���X�̕ϐ���錾���ăC���X�^���X����
        Boss lastboss = new Boss();


        //���@�g�p�̊֐���10��Ăяo��
        lastboss.Magic();
        lastboss.Magic();
        lastboss.Magic();
        lastboss.Magic();
        lastboss.Magic();
        lastboss.Magic();
        lastboss.Magic();
        lastboss.Magic();
        lastboss.Magic();
        lastboss.Magic();
        lastboss.Magic();
    }

    //Update is called once per frame
    void Update()
    {

    }
}