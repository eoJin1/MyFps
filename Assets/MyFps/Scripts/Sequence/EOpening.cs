using TMPro;
using UnityEngine;
using System.Collections;
namespace MyFps
{
    /// <summary>
    /// 플레이 02번의 오프닝 연출
    /// 페이드인 효과, 배경음 플레이, 시퀀스 텍스트 초기화
    /// </summary>
    public class EOpening : MonoBehaviour
    {
        #region Variables
        //페이더 효과
        public SceneFader fader;

        //플레이어 오브젝트
        public GameObject thePlayer;

        //시퀀스 텍스트
        public TextMeshProUGUI sequenceText;
        #endregion

        #region Unity Event Method
        private void Start()
        {
            //시작하자마자 오프닝 연출
            StartCoroutine(SequencePlay());
        }
        #endregion

        #region Custom Method
        //오프닝 시퀀스 연출
        IEnumerator SequencePlay()
        {
            //0.플레이 캐릭터 비 활성화
            thePlayer.SetActive(false);

            //1.페이드인 연출(1초 대기후 페이드인 효과) - 2초
            fader.FadeStart(1f);

            //2. 텍스트 없어짐
            sequenceText.text = "";

            //3.배경음 재생
            AudioManager.Instance.PlayBGM("BGM01");

            yield return new WaitForSeconds(1f);

            //4.플레이 캐릭터 활성화
            thePlayer.SetActive(true);
        }
        #endregion
    }
}