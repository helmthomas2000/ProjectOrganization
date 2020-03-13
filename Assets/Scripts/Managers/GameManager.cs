using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NW_Organization.Managers
{
    public class GameManager : MonoBehaviour
    {
        public float score;
        public float maxPlayerHealth;

        private float playerHealth;

        public float PlayerHealth
        {
            get => playerHealth;
            set
            {
                playerHealth = Mathf.Clamp(value, 0, maxPlayerHealth);
            }
        }

        public enum State
        {
            moving,
            still
        }

        public void KillPlayer()
        {
            //Destroy(player.gameObject);
            PlayerHealth = 0;
        }

        //public void EatFsh(int amount)
        //{
        //    score += amount;
        //}

        // Start is called before the first frame update
        private void Start()
        {
            
        }

        // Update is called once per frame
        private void Update()
        {
            
        }
    }
}