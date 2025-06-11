using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Renpy : MonoBehaviour
{
    [SerializeField] Image BG; // 배경
    [SerializeField] Image[] img_Character; // 캐릭터

    [SerializeField] TextMeshProUGUI Text_Name; // 캐릭터 이름
    [SerializeField] TextMeshProUGUI Text_NameTitle; // 캐릭터 타이틀
    [SerializeField] TextMeshProUGUI Text_Dialogue; // 대사 : 여기에 대사가 출력됩니다.

    void start()
    {

    }

    void Update()
    {
    
    }

}
