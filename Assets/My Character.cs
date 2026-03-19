using UnityEngine;

public class MyCharacter : MonoBehaviour
{
    public int Health = 100;      //체력을 선언 한다. (변수 정수 표현).
    public float Timer = 1.0f;     //타이머 설정을 한다. (변수 실수 표현.)

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Health = Health + 100;      //첫 시작할때 100의 체력을 준다.
    }

    // Update is called once per frame
    void Update()
    {
        Timer = Timer - Time.deltaTime;         //시간 실수를 매 프레임마다 감소 시킨다.

        if (Timer <=0)
        {
            Timer = 1.0f;
            Health = Health - 20;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Health = Health + 2;
        }

        if (Health <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
