﻿using System;
using System.Collections.Generic;
using WCell.Constants.Updates;
using WCell.RealmServer.Entities;
using WCell.Util.Commands;

namespace WCell.RealmServer.Commands
{
  public class ClearAreaCommand : RealmServerCommand
  {
    public static int DefaultRadius = 10;

    protected ClearAreaCommand()
    {
    }

    protected override void Initialize()
    {
      Init("ClearArea");
      EnglishParamInfo = "[<radius>]";
      EnglishDescription =
        "Clears all Objects, Corpses and NPCs around yourself in the given or default radius (" +
        DefaultRadius + "), up to a max of 100 yards.";
    }

    public override void Process(CmdTrigger<RealmServerCmdArgs> trigger)
    {
      int num = Math.Min(100, Math.Max(1, trigger.Text.NextInt(DefaultRadius)));
      IList<WorldObject> objectsInRadius =
        trigger.Args.Target.GetObjectsInRadius(num, ObjectTypes.All, false, 0);
      foreach(WorldObject worldObject in objectsInRadius)
      {
        if(!(worldObject is Character))
          worldObject.Delete();
      }

      trigger.Reply("Removed {0} Objects and NPCs within {1} yards.", (object) objectsInRadius.Count,
        (object) num);
    }

    public override ObjectTypeCustom TargetTypes
    {
      get { return ObjectTypeCustom.All; }
    }
  }
}