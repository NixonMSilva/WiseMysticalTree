using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Effects
{
    public class TakeDamageVFX : ParticleVFX
    {
        private void OnEnable()
        {
            // OnTakeDamage += TriggerParticles
        }
        private void OnDisable()
        {
            // OnTakeDamage -= TriggerParticles
        }
        public override void TriggerParticles()
        {
            base.TriggerParticles();
            Debug.Log("Damaged");
            Destroy(_particleClone, _effectDuration);
        }
    }
}

