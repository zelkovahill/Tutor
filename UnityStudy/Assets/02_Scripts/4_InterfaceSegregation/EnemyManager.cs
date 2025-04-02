using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterfaceSegregation
{
    public class EnemyManager : MonoBehaviour
    {
        void Start()
        {
            IEnemy enemy = GetComponent<MeleeEnemy>();
            enemy.Move();
            enemy.Attack();
            enemy.CastSpell();
        }
    }
}