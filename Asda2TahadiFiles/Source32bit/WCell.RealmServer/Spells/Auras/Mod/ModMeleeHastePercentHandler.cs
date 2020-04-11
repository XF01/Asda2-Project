﻿using WCell.Constants;
using WCell.RealmServer.Modifiers;

namespace WCell.RealmServer.Spells.Auras.Handlers
{
  /// <summary>Haste for melee, ranged and spells in %</summary>
  public class ModMeleeHastePercentHandler : AuraEffectHandler
  {
    private float val;

    protected override void Apply()
    {
      m_aura.Auras.Owner.ChangeModifier(StatModifierFloat.MeleeAttackTime,
        val = -EffectValue / 100f);
    }

    protected override void Remove(bool cancelled)
    {
      m_aura.Auras.Owner.ChangeModifier(StatModifierFloat.MeleeAttackTime, -val);
    }
  }
}