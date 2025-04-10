using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OpenClosedPrinciple
{
    public class EnemyManager : MonoBehaviour
    {
        public enum E_EnemyType
        {
            Goblin,
            Orc,
        }

        public E_EnemyType EnemyType;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                HandleEnemyAttack();
            }
        }

        private void HandleEnemyAttack()
        {
            switch (EnemyType)
            {
                case E_EnemyType.Goblin:
                    Debug.Log("고블린이 공격합니다!");
                    break;

                case E_EnemyType.Orc:
                    Debug.Log("오크가 공격합니다!");
                    break;
            }
        }
    }
}