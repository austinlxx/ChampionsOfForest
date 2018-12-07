﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TheForest.Utils;
using UnityEngine;

namespace ChampionsOfForest.Player
{
    public class HealingDome : MonoBehaviour
    {
        public static Material material;

        public float radius;
        public float healing;
        public bool GrantImmunity;


        public static void CreateHealingDome(Vector3 pos,float radius,float healing,bool grantImmunity,float duration)
        {
            if(material == null)
            {
                material = new Material(Shader.Find("Particles/Additive"));
                material.color = Color.green;
            }
            GameObject go = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            go.GetComponent<Renderer>().material = material;
           Destroy( go.GetComponent<Collider>());
            go.transform.localScale = Vector3.one * radius * 2;
            go.transform.position = pos;
            HealingDome d = go.AddComponent<HealingDome>();
            d.radius = radius;
            d.healing = healing;
            d.GrantImmunity = grantImmunity;
            Destroy(go, duration);

        }
        void Update()
        {
            if((LocalPlayer.Transform.position -transform.position).sqrMagnitude < radius * radius)
            {
                LocalPlayer.Stats.HealthTarget += healing * Time.deltaTime;
                LocalPlayer.Stats.Health += healing * Time.deltaTime;
                if (GrantImmunity)
                {
                    BuffDB.AddBuff(4, 40, 0, 0.1f);
                }
            }
        }
    }

}
