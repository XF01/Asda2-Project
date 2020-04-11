﻿namespace WCell.Constants.Spells
{
  public enum SpellEffectType
  {
    None = 0,
    InstantKill = 1,
    SchoolDamage = 2,
    Dummy = 3,
    Unused_PortalTeleport = 4,
    TeleportUnits = 5,
    ApplyAura = 6,
    EnvironmentalDamage = 7,
    PowerDrain = 8,
    HealthLeech = 9,
    Heal = 10, // 0x0000000A
    Bind = 11, // 0x0000000B
    Portal = 12, // 0x0000000C
    QuestComplete = 16, // 0x00000010
    WeaponDamageNoSchool = 17, // 0x00000011
    Resurrect = 18, // 0x00000012
    AddExtraAttacks = 19, // 0x00000013
    Dodge = 20, // 0x00000014
    Evade = 21, // 0x00000015
    Parry = 22, // 0x00000016
    Block = 23, // 0x00000017
    CreateItem = 24, // 0x00000018
    Weapon = 25, // 0x00000019
    Defense = 26, // 0x0000001A
    PersistantAreaAura = 27, // 0x0000001B
    Summon = 28, // 0x0000001C
    LeapForward = 29, // 0x0000001D
    Energize = 30, // 0x0000001E
    WeaponPercentDamage = 31, // 0x0000001F
    TriggerMissile = 32, // 0x00000020
    OpenLock = 33, // 0x00000021
    TransformItem = 34, // 0x00000022
    ApplyAreaAura = 35, // 0x00000023
    LearnSpell = 36, // 0x00000024
    SpellDefense = 37, // 0x00000025
    Dispel = 38, // 0x00000026
    Language = 39, // 0x00000027
    DualWeild = 40, // 0x00000028
    TeleportUnitsFaceCaster = 41, // 0x00000029
    SkillStep = 44, // 0x0000002C
    AddHonor = 45, // 0x0000002D
    Spawn = 46, // 0x0000002E
    TradeSkill = 47, // 0x0000002F
    Stealth = 48, // 0x00000030
    Detect = 49, // 0x00000031
    SummonObject = 50, // 0x00000032
    Unused_ForceCriticalHit = 51, // 0x00000033
    Unused_GuaranteeHit = 52, // 0x00000034
    EnchantItem = 53, // 0x00000035
    EnchantItemTemporary = 54, // 0x00000036
    TameCreature = 55, // 0x00000037
    SummonPet = 56, // 0x00000038
    LearnPetSpell = 57, // 0x00000039
    WeaponDamage = 58, // 0x0000003A
    OpenLockItem = 59, // 0x0000003B
    Proficiency = 60, // 0x0000003C
    SendEvent = 61, // 0x0000003D
    PowerBurn = 62, // 0x0000003E
    Threat = 63, // 0x0000003F
    TriggerSpell = 64, // 0x00000040
    ApplyRaidAura = 65, // 0x00000041
    CreateManaGem = 66, // 0x00000042
    HealMaxHealth = 67, // 0x00000043
    InterruptCast = 68, // 0x00000044
    Distract = 69, // 0x00000045
    Pull = 70, // 0x00000046
    Pickpocket = 71, // 0x00000047
    AddFarsight = 72, // 0x00000048
    Unused_SummonPossessed = 73, // 0x00000049
    ApplyGlyph = 74, // 0x0000004A
    HealMechanical = 75, // 0x0000004B
    SummonObjectWild = 76, // 0x0000004C
    ScriptEffect = 77, // 0x0000004D
    Attack = 78, // 0x0000004E
    Sanctuary = 79, // 0x0000004F
    AddComboPoints = 80, // 0x00000050
    CreateHouse = 81, // 0x00000051
    BindSight = 82, // 0x00000052
    Duel = 83, // 0x00000053
    Stuck = 84, // 0x00000054
    SummonPlayer = 85, // 0x00000055
    ActivateObject = 86, // 0x00000056
    WMODamage = 87, // 0x00000057
    WMORepair = 88, // 0x00000058
    WMOChange = 89, // 0x00000059
    KillCreditPersonal = 90, // 0x0000005A
    Unused_ThreatAll = 91, // 0x0000005B
    EnchantHeldItem = 92, // 0x0000005C
    Unused_SummonPhantasm = 93, // 0x0000005D
    SelfResurrect = 94, // 0x0000005E
    Skinning = 95, // 0x0000005F
    Charge = 96, // 0x00000060
    SummonAllTotems = 97, // 0x00000061
    KnockBack = 98, // 0x00000062
    Disenchant = 99, // 0x00000063
    Inebriate = 100, // 0x00000064
    FeedPet = 101, // 0x00000065
    DismissPet = 102, // 0x00000066
    Reputation = 103, // 0x00000067
    SummonObjectSlot1 = 104, // 0x00000068
    SummonObjectSlot2 = 105, // 0x00000069
    SummonObjectSlot3 = 106, // 0x0000006A
    SummonObjectSlot4 = 107, // 0x0000006B
    DispelMechanic = 108, // 0x0000006C
    SummonDeadPet = 109, // 0x0000006D
    DestroyAllTotems = 110, // 0x0000006E
    DurabilityDamage = 111, // 0x0000006F
    Unused_SummonDemon = 112, // 0x00000070
    ResurrectFlat = 113, // 0x00000071
    AttackMe = 114, // 0x00000072
    DurabilityDamagePercent = 115, // 0x00000073
    SkinPlayerCorpse = 116, // 0x00000074
    SpiritHeal = 117, // 0x00000075
    Skill = 118, // 0x00000076
    ApplyPetAura = 119, // 0x00000077
    TeleportGraveyard = 120, // 0x00000078
    NormalizedWeaponDamagePlus = 121, // 0x00000079
    Unused_Effect_122 = 122, // 0x0000007A
    Video = 123, // 0x0000007B
    PlayerPull = 124, // 0x0000007C
    ReduceThreatPercent = 125, // 0x0000007D
    StealBeneficialBuff = 126, // 0x0000007E
    Prospecting = 127, // 0x0000007F
    ApplyStatAura = 128, // 0x00000080
    ApplyStatAuraPercent = 129, // 0x00000081
    RedirectThreat = 130, // 0x00000082
    Effect_131 = 131, // 0x00000083
    PlayMusic = 132, // 0x00000084
    ForgetSpecialization = 133, // 0x00000085
    Effect_134 = 134, // 0x00000086
    Effect_135 = 135, // 0x00000087
    RestoreHealthPercent = 136, // 0x00000088
    RestoreManaPercent = 137, // 0x00000089
    Effect_138 = 138, // 0x0000008A
    ClearQuest = 139, // 0x0000008B
    TriggerSpellFromTargetWithCasterAsTarget = 140, // 0x0000008C
    Effect_141 = 141, // 0x0000008D
    Effect_142 = 142, // 0x0000008E
    ApplyAuraToMaster = 143, // 0x0000008F
    Effect_144 = 144, // 0x00000090
    Effect_145 = 145, // 0x00000091
    ActivateRune = 146, // 0x00000092
    QuestFail = 147, // 0x00000093
    Unused_Effect_148 = 148, // 0x00000094
    SideLeap = 149, // 0x00000095
    Unused_Effect_150 = 150, // 0x00000096
    TriggerRitualOfSummoning = 151, // 0x00000097
    SummonReferAFriend = 152, // 0x00000098
    Effect_153 = 153, // 0x00000099
    TeachFlightPath = 154, // 0x0000009A
    Allow2HWeaponIn1HAndApplyAura = 155, // 0x0000009B
    AddPrismaticGem = 156, // 0x0000009C
    CreateItem2 = 157, // 0x0000009D
    Milling = 158, // 0x0000009E
    RenamePet = 159, // 0x0000009F
    Effect_160 = 160, // 0x000000A0
    SetNumberOfTalentGroups = 161, // 0x000000A1
    ActivateTalentGroup = 162, // 0x000000A2
    DamageFromPrcAtack = 200, // 0x000000C8
    CastAnotherSpell = 201, // 0x000000C9
    PortalTeleport = 202, // 0x000000CA
    BossSummonHelp = 203, // 0x000000CB
    End = 250 // 0x000000FA
  }
}