using System;
using UnityEngine;

public class ArraySort : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        // array�z���錾���A����������
        int[] array = { 10, 50, 30, 15, 100 };

        // for�����g���A�z���z�񐔂����J��Ԃ��B
        for (int i = 0; i < array.Length; i++)
        {
            //�z��̊e�v�f�̒l�����Ȃ������珇�Ԃɕ��ׂ�
            Array.Sort(array);

            //�z��l��\������
            Debug.Log(array[i]);
        }

        // for�����g���A�z�����납��z�񐔂����J��Ԃ��B
        for (int i = 4; i >=0; i--)
        {
            //�z��̊e�v�f�̒l�𑽂������珇�Ԃɕ��ׂ�
            Array.Sort(array);

            //�z��l��\������
            Debug.Log(array[i]);
        }
    }
}