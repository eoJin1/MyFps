using TMPro;
using UnityEngine;
namespace MyFps
{
    public class ActionUI : MonoBehaviour
    {
        #region Variables
        //인터랙티브 UI
        [Header("Interactive UI")]
        //크로스헤어
        public GameObject extraCross;

        //액션 UI
        public GameObject actionUI;
        public TextMeshProUGUI actionText;

        [SerializeField]
        protected string action = "Do Action";

        #endregion

        #region Custom Method
        protected virtual void ShowActionUI()
        {
            extraCross.SetActive(true);
            actionUI.SetActive(true);
            actionText.text = action;
        }

        protected virtual void HideActionUI()
        {
            extraCross.SetActive(false);
            actionUI.SetActive(false);
            actionText.text = "";
        }
        #endregion

        #region
        #endregion

        #region
        #endregion
    }
}