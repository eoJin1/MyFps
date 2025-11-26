using UnityEngine;
using System.Collections;
namespace MyFps
{
    [SerializeField]
    public class SpawnEnemy : MonoBehaviour
    {
        [Header("스폰 설정")]
        public GameObject enemy;      // 적 프리팹
        public int count = 1;         // 스폰 개수
        public float delayTime = 1f;  // 스폰 간격(초)

        private void Start()
        {
            StartCoroutine(SpawnRoutine());
        }

        IEnumerator SpawnRoutine()
        {
            for (int i = 0; i < count; i++)
            {
                Spawn();
                yield return new WaitForSeconds(delayTime);
            }
        }

        private void Spawn()
        {
            // 스폰 포인트 위치에서 프리팹 생성
            Instantiate(enemy, transform.position, transform.rotation);
        }
    }

}
