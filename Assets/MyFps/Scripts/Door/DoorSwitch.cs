using UnityEngine;
using System.Collections;
using UnityEngine.Events;
namespace MyFps
{
    /// <summary>
    /// 등록된 문의 열기, 닫기 구현
    /// 인터랙티브액션으로 이벤트 구현, 인터랙티브 상속 받는다
    /// </summary>
    public class DoorSwitch : Interactive
    {
        #region Variables
        [Header("Interactive Action")]
        public Door door;       //문 닫기/열기 실행할 게임 오브젝트


        public Renderer renderer;
        public Material closeMaterial;  //닫을때 스위치 컬러
        private Material originMaterial;    //열때 스위치 컬러
        #endregion

        #region Unity Event Method
        private void OnEnable()
        {
            
        }
        private void OnDisable()
        {
            
        }

        protected void Start()
        {
            originMaterial = renderer.material;
        }
        #endregion

        #region Custom Method
        protected override void DoAction()
        {
            StartCoroutine(Toggle());
        }

        IEnumerator Toggle()
        {
            //문 열고 닫기
            if (door.IsActive)
            {
                DoorOpen();
            }
            else
            {
                DoorClose();
            }

            yield return new WaitForSeconds(1f);

            //충돌체 복구
            collider.enabled = true;
        }

        void DoorOpen()
        {
            door.Deactivate();
            action = "Open The Door";
            renderer.material = originMaterial;
        }

        void DoorClose()
        {
            door.Activate();
            action = "Close The Door";
            renderer.material = closeMaterial;
        }

        #endregion
    }
}