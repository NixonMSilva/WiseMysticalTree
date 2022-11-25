using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Effects
{
    public class EnvironmentVFX : ParticleVFX
    {
        private void Awake()
        {
            TriggerParticles();
        }
        public override void TriggerParticles()
        {
            base.TriggerParticles();
            Debug.Log("SmokeTrigger");
        }
    }
}

