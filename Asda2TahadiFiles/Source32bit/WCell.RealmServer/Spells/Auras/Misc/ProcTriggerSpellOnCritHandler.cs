﻿using WCell.RealmServer.Misc;
using WCell.RealmServer.Spells.Auras.Handlers;

namespace WCell.RealmServer.Spells.Auras.Misc
{
  public class ProcTriggerSpellOnCritHandler : ProcTriggerSpellHandler
  {
    public override bool CanProcBeTriggeredBy(IUnitAction action)
    {
      return action.IsCritical;
    }
  }
}