using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExTest : MonoBehaviour
{
    public int age;         //���� int(������) age ��� �̸����� ����
    public float ageF;         //���� float(�Ǽ���) ageF ��� �̸����� ����

    void Start()
    {
        //age = 30;           // ������ 30�� �Է�
        Debug.Log(age);
        Debug.Log(ageF);     // ������ Debug.Log �Լ��� ���ؼ� ����Ѵ�.
    }

    void Update()
    {

    }
}
