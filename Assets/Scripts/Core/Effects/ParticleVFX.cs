using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Effects
{
    public abstract class ParticleVFX : MonoBehaviour
    {
        [SerializeField] private GameObject _particlePrefab;

        protected GameObject _particleClone;
        protected float _effectDuration;

        public virtual void TriggerParticles()
        {
            _particleClone = Instantiate(_particlePrefab, transform.position, Quaternion.identity);
            _effectDuration = _particleClone.GetComponent<ParticleSystem>().main.duration;
            Debug.Log("Base Triggered");
        }
    }

}
