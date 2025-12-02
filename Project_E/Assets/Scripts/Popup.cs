using UnityEngine;
using TMPro;

public class Popup : MonoBehaviour
{
    public TextMeshProUGUI titleText;
    public TextMeshProUGUI contentText;

    public void SetContent(string title, string content) // void는 반환값이 없다. 즉 리턴 값이 없다. (매개 변수) - 입력값이라 한다. 
    {
        titleText.text = title;
        contentText.text = content;
    }


    public void ClosePopup()
    {
        Destroy(gameObject);
    }
}