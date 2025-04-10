using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LiskovSubstitution
{
    public class Bird
    {
        public virtual void Fly()
        {
            Debug.Log("새가 날아욬ㅋㅋㅋ");
        }
    }

    public class Eagle : Bird
    {
        public override void Fly()
        {
            Debug.Log("독수리가 날아욬ㅋㅋㅋ");
        }
    }

    public class Duck : Bird
    {
        public override void Fly()
        {
            Debug.Log("날라오라 저 하늘 멋진 달이 될래요!");
        }
    }

    public class BirdManager : MonoBehaviour
    {
        private void Start()
        {
            List<Bird> birds = new List<Bird>
            {
                new Eagle(),
                new Duck()
            };

            foreach (Bird bird in birds)
            {
                bird.Fly();
            }
        }
    }
}
