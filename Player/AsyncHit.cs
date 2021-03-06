﻿using System.Collections;
using UnityEngine;

namespace ChampionsOfForest.Player
{
    public class AsyncHit : MonoBehaviour
    {
        public static AsyncHit instance = null;

        private void Start()
        {
            instance = this;
        }

        public static void SendPlayerHitEnemy(PlayerHitEnemy playerHitEnemy, int rep,float delay = 0)
        {
            instance.StartCoroutine(instance.SendPlayerHitEnemyCoroutine(playerHitEnemy, rep,delay));
        }

        public IEnumerator SendPlayerHitEnemyCoroutine(PlayerHitEnemy playerHitEnemy, int rep,float delay)
        {
            yield return new WaitForSeconds(delay);
            for (int i = 0; i < rep; i++)
            {
                playerHitEnemy.Send();
                yield return null;
                yield return null;
            }
        }

        public static void SendPlayerHitEnemy(Transform tr, int rep, int d)
        {
            instance.StartCoroutine(instance.SendPlayerHitEnemyCoroutine(tr, rep, d));
        }

        public IEnumerator SendPlayerHitEnemyCoroutine(Transform tr, int rep, int d)
        {
            for (int i = 0; i < rep; i++)
            {
                tr.SendMessageUpwards("Hit", d, SendMessageOptions.DontRequireReceiver);
                yield return null;
            }
        }

        public static void SendCommandDelayed(int frames, byte[] s, Network.NetworkManager.Target target)
        {
            instance.StartCoroutine(instance.SendCommandDelayedCoroutine(frames, s, target));
        }

        public IEnumerator SendCommandDelayedCoroutine(int frames, byte[] s, Network.NetworkManager.Target target)
        {
            for (int i = 0; i < frames; i++)
            {
                yield return null;
            }
            Network.NetworkManager.SendLine(s, target);
        }


      
    }
}
