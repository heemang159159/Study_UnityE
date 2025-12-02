using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject popupPrefab;//스폰해줄 프리펩 변수
    public Transform canvasTransform;
    public string TitleText;
    public string ContentText;

    public void OpenNoticePopup()
    {
        GameObject newPopup = Instantiate(popupPrefab, canvasTransform);// 생성한 팝업 변수 / canvasTransform - 캔버스 위치
        Popup popupScript = newPopup.GetComponent<Popup>(); // 팝업 스크립트 변수

        popupScript.SetContent(this.TitleText, this.ContentText); // 팝업 내용 설정
    }
}