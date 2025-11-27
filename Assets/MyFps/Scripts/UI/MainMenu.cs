using UnityEngine;
namespace MyFps
{
    /// <summary>
    /// 메인메뉴 씬을 관리하는 클래스
    /// 메인메뉴 버튼기능, 신페이더 기능
    /// </summary>
    public class MainMenu : MonoBehaviour
    {
        #region Variables
        public SceneFader fader;
        [SerializeField]
        private string loadToScene = "PlayScene01";
        #endregion

        #region Custom Method
        //버튼 대응 함수 구현, Debug.Log("버튼 클릭")
        public void NewGame()
        {
            fader.FadeTo(loadToScene);
            Debug.Log("NewGame");
        }

        public void LoadGame()
        {
            Debug.Log("LoadGame");
        }

        public void Options()
        {
            Debug.Log("Options");
        }

        public void Credits()
        {
            Debug.Log("Credits");
        }

        public void QuitGame()
        {
            //저장된 데이터 삭제
            PlayerPrefs.DeleteAll();
            Debug.Log("Quit Game");
            //나가기
            Application.Quit();         
        }
        #endregion
    }
}