using MyFps;
using UnityEngine;
namespace myfps
{
    /// <summary>
    /// 플레이어의 무기를 관리하는 클래스
    /// 무기 교체...
    /// </summary>
    public class PlayerWeaponManager : MonoBehaviour
    {
        #region Variables
        public GameObject pistol;
        public GameObject healmatic;
        #endregion

        #region Unity Event Method
        private void Start()
        {
            //현재 무장 무기 세팅
            SetCurrentWeapon(PlayerStats.Instance.WeaponType);
        }
        #endregion

        #region Custom Method
        private void SetCurrentWeapon(WeaponType weaponType)
        {
            pistol.SetActive(false);
            healmatic.SetActive(false);

            if (weaponType == WeaponType.Pistol)
            {
                pistol.SetActive(true);
            }
            else if (weaponType == WeaponType.Healmatic)
            {
                healmatic.SetActive(true);
            }
        }
        #endregion
    }
}