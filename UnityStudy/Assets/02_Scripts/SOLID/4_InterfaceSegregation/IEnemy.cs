using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterfaceSegregation
{
    public interface IEnemy
    {
        void Move();
        void Attack();
        void CastSpell();
    }
}