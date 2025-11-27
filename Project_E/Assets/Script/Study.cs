using System.Runtime.CompilerServices;
using UnityEngine;

public class Study : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public string say = "";
    public char text = 'a';
    public int var01 = 1;
    public float var02 = 0.4f;
    public double var03 = 0.5;
    public bool var04 = true;
    //private string said = "";
    //string newsay = "Hello World";
    /* public char text; = 자료형이 char 상자를 만들어라
        ㄴ 캐릭터는 글자 1개다 A-Z
        ㄴ 으악 같은 2글자는 쓸 수 없다..? 
        ㄴ "" = string / '' = char라 ""를 사용할 수 없다
     */
    void Start()
    {
        //Debug.Log(said);
        //Debug.Log(newsay);
        //Debug.Log(this.say);
        //Debug.Log(this.text);
        Debug.Log(this.say);
        Debug.Log(this.text);

        int a = 10;
        Debug.Log(a++);
        Debug.Log(++a);
       Debug.Log(Random.Range(0, 100));
    }

    // Update is called once per frame
    void Update()
    {
    
    }
}
/*
void Start = OnBegin
this = self 랑 같아 내가 갖고있는 클레스의 변수를 뜻 (자기자신을 참조하기 위해)
추상화는 특징적인 부분만 표현한 것
인스턴스 클레스를 바탕으로 객체를 생성하는 것
상속 부모클래스 내용을 자식 클래스가 받는것 즉 monobehaviour은 클레스이다.
MonoBehaviour가 기본 클레스다. 해당 클레스를 붙이지 못하면 유니티 오브젝트에 붙이지 못한다.
유니티에 있는 스크립트 명과 클레스 명이 같아야한다.

- string 문자열 자료형
ㄴ 문자열이 무엇인지
    ㄴ 문자의 나열
int 정수를 표현하기 위해 지정해야하는 것
float
double = 2배라는 뜻
10진수는 10을 a가 대신한다. 즉 0,1,2,3,4,5,6,7,8,9,a,b,c,d,e,f,g 이렇게 간다.
10(16) = 16(10) = 10000(2) = (8)
오버플로우에 대해서 알아야한다.
int 는 2^31-1 표현된다. 음의 방향으로는 2^31 까지 가능하다.
ㄴ 여기서 1값이 더 추갇 되면 오버플로우가 된다.
ㄴ uint 는 양수만 쓰는 int 다. 

Array 란
ㄴ 동일한 자료형이여 하고, 메모리에 연속적으로 저장되어야 한다.
private 는 클레스에서 지정할때 사용한다.
ㄴ 클레스에 필드에만 붙는 애다.
*/