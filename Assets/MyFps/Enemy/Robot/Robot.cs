using Unity.VisualScripting;
using UnityEngine;
namespace myfps
{
    /// <summary>
    /// 로봇을 관리하는 클래스
    /// 애니메이션, 체력, 이동
    /// </summary>
    public class Robot : MonoBehaviour
    {
        #region Varibles      
        //참조
        private Animator animator;
        [SerializeField]
        private int EnemyState;

        //이동
        private float Speed = 5f;
        private float attackspeed = 2.0f;
        #endregion

        #region          
        #endregion

        #region            
        #endregion
    }
}