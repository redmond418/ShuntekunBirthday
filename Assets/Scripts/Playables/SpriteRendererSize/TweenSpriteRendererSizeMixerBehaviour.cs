using TweenPlayables;
using UnityEngine;

namespace Redmond.QuectoLines.TweenPlayablesEx
{
    public class TweenSpriteRendererSizeMixerBehaviour : TweenAnimationMixerBehaviour<SpriteRenderer, TweenSpriteRendererSizeBehaviour>
    {
        private Vector2ValueMixer sizeMixer = new Vector2ValueMixer();

        public override void Blend(SpriteRenderer binding, TweenSpriteRendererSizeBehaviour behaviour, float weight, float progress)
        {
            sizeMixer.TryBlend(behaviour.size, binding, progress, weight);
        }

        public override void Apply(SpriteRenderer binding)
        {
            sizeMixer.TryApplyAndClear(binding, (x, binding) => binding.size = x);
        }
    }
}