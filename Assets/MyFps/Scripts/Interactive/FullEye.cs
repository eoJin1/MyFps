using System.Collections;
using TMPro;
using UnityEngine;
namespace MyFps
{
    public class FullEye : Interactive
    {
        #region Variables
        public GameObject leftEye;
        public GameObject rightEye;
        public GameObject doorSwitch;

        //실패 메시지
        public TextMeshProUGUI sequenceText;
        #endregion

        #region Custom method
        protected override void DoAction()
        {
            StartCoroutine(PutThePuzzlePieces());
        }

        //퍼즐 조각 맞추기
        IEnumerator PutThePuzzlePieces()
        {
            bool isLeft = PlayerStats.Instance.HavePuzzleItem(PuzzleItem.LeftEye);
            bool isRight = PlayerStats.Instance.HavePuzzleItem(PuzzleItem.RightEye);

            if(isLeft)
            {
                leftEye.SetActive(true);
            }
            if(isRight)
            {
                rightEye.SetActive(true);
            }
            //모든 퍼즐 조각을 다 맞추었는지 체크
            if(isLeft && isRight)
            {
                doorSwitch.SetActive(true);
            }
            else
            {
                sequenceText.text = "Need More Puzzle Pieces";
                yield return new WaitForSeconds(2f);
                sequenceText.text = "";

                //충돌체 복구
                collider.enabled = true;
            }
        }
        #endregion
    }
}