using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExTest : MonoBehaviour
{
    public int age;         //변수 int(정수형) age 라는 이름으로 선언
    public float ageF;         //변수 float(실수형) ageF 라는 이름으로 선언

    void Start()
    {
        //age = 30;           // 변수에 30을 입력
        Debug.Log(age);
        Debug.Log(ageF);     // 변수를 Debug.Log 함수를 통해서 출력한다.
    }

    void Update()
    {

    }
}
