using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterfaceSegregation
{
    public class MeleeEnemy : MonoBehaviour, IEnemy
    {
        public void Move()
        {
            Debug.Log("움직여욬ㅋㅋㅋ");
        }

        public void Attack()
        {
            Debug.Log("공격해욬ㅋㅋㅋㅋ");
        }

        public void CastSpell()
        {
            Debug.Log("어 나 마법 못쓰는데?");
        }
    }
}