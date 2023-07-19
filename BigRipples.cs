using BepInEx;
using HarmonyLib;
using System;
using System.ComponentModel;
using UnityEngine;
using Utilla;

namespace BigRipples
{
    [ModdedGamemode]
    [BepInDependency("org.legoandmars.gorillatag.utilla", "1.5.0")]
    public class BigRipples : BaseUnityPlugin
    {
        bool inRoom;
        void OnEnable()
        {
            if (!inRoom)
                return;

            GorillaLocomotion.Player.Instance.waterParams.rippleEffectScale = 10f;
        }

        void OnDisable()
        {
            GorillaLocomotion.Player.Instance.waterParams.rippleEffectScale = 1f;
        }

        [ModdedGamemodeJoin]
        public void OnJoin(string gamemode)
        {
            inRoom = true;
        }

        [ModdedGamemodeLeave]
        public void OnLeave(string gamemode)
        {
            inRoom = false;
        }
    }
    }
