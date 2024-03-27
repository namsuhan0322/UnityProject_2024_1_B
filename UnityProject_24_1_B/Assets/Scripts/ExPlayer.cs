using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExPlayer : MonoBehaviour
{
    public Rigidbody rigid;             // ������ �ٵ� �ҽ��� ����ϰ� �޾� �´�.
    public int Force = 100;           // int ������ ���� 100�� ���� �Ѵ�.
    public int point = 0;               // ���� ����� ���� �߰�
    public float checkTime = 0;         // �ð� ������ ���� ���� (�Ҽ���)
    public Text m_Text;                 // UI �ؽ�Ʈ ����

    void Start()
    {

    }


    void Update()
    {
        // if (Input.GetMouseButtonDown(0)) // ���콺 �Է��� ������ ��

        if (Input.GetKeyDown(KeyCode.Space))    // �����̽� �Է��� ��������
        {
            rigid.AddForce(transform.up * Force);           // transform.up(���� ����)���� ������ �ٵ� Force ����ŭ ������ ���� �ش�.
        }

        checkTime += Time.deltaTime;            // ������ ������ ���ؼ� �ð��� ����
        if (checkTime >= 1.0f)                  // ���� 1�ʰ� ������ ���
        {
            point += 1;                         // point = point + 1 ��� (1���� �����ش�.) 
            checkTime = 0.0f;                   // 1�ʰ� ������� �ʱ�ȭ (0�� -> 1�� -> 0�� -> 1��)
        }

        m_Text.text = point.ToString();         // UI  ǥ��
    }

    private void OnCollisionEnter(Collision collision)      // �浿�� ���۵Ǿ�����
    {
        if (collision != null)                              // �浹 ��ü�� ���� ���� ��� [!= �ٸ� ���]
        {
            point = 0;                                      // �浹�� �Ͼ���� ����Ʈ�� 0���� ���ش�.
            gameObject.transform.position = new Vector3(0.0f, 3.0f, 0.0f);  // �浹������ ��ġ �ʱ�ȭ
            Debug.Log(collision.gameObject.name);           // �ش� ������Ʈ�� �̸��� ����Ѵ�.
        }
    }
}
