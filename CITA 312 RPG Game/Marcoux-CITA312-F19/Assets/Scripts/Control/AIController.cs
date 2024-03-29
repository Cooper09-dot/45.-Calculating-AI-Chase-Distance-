﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Control
{
   public class AIController : MonoBehaviour
    {
        [SerializeField] float chaseDistance = 5f;

        private void Update()
        {
            
            if (DistanceToPlayer() < chaseDistance)
            {
                print(gameObject.name + "Should Chase");
            }

        }

        private float DistanceToPlayer(GameObject player)
        {
            GameObject player = GameObject.FindWithTag("Player");
            return Vector3.Distance(player.transform.position, transform.position);
        }
    }
}
