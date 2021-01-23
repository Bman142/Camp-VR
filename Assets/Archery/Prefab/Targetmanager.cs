using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Valve.VR.InteractionSystem.Sample
{
    public class Targetmanager : MonoBehaviour
    {
        public float startx = 0F;
        public float startz = 0f;
        public float y = 0f;
        public float timer = 5f;
        public float randomXLeft = 0f;
        public float randomXRight = 0f;
        public float randomZleft = 0f;
        public float randomZRight = 0f;

        [SerializeField]
        private GameObject _TargetPrefab;

        public ArcheryCountdownTimer countdownTimer;
        private bool startedSpawning;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (countdownTimer.spawn == true && startedSpawning == false)
            {
                StartCoroutine(SpawnRoutine());
                startedSpawning = true;
            }
        }
        IEnumerator SpawnRoutine()
        {
            while (countdownTimer.spawn == true)
            {
                Vector3 posTospawn = new Vector3(Random.Range(randomXLeft, randomXRight), y,Random.Range(randomZleft, randomZRight));
                Instantiate(_TargetPrefab, posTospawn, Quaternion.identity);
                yield return new WaitForSeconds(timer);
            }

        }
    }
}

