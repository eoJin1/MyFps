using UnityEditor.SceneManagement;
using UnityEngine;
namespace MyFps
{
    /// <summary>
    /// 사운드 플레이 클래스
    /// </summary>
    public class SoundTest : MonoBehaviour
    {
        #region Variables
        //재생할 사운드
        public AudioClip clip;

        //참조
        public AudioSource audioSource;
        #endregion

        #region Unity Event Method
        private void Awake()
        {
            //참조
            audioSource = GetComponent<AudioSource>();
            if(audioSource == null)
            {
                audioSource = gameObject.AddComponent<AudioSource>();
            }
            //플레이
            SoundPlay();
        }
        #endregion

        #region Custom Method
        private void SoundPlay()
        {
            audioSource.clip = clip;
            audioSource.Play();
        }
        #endregion
    }
}