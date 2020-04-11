﻿using System;

namespace WCell.Constants.Misc
{
  [Serializable]
  public enum EmoteType
  {
    None = 0,
    SimpleTalk = 1,
    SimpleBow = 2,
    SimpleWave = 3,
    SimpleCheer = 4,
    SimpleExclamation = 5,
    SimpleQuestion = 6,
    SimpleEat = 7,
    StateDance = 10, // 0x0000000A
    SimpleLaugh = 11, // 0x0000000B
    StateSleep = 12, // 0x0000000C
    StateSit = 13, // 0x0000000D
    SimpleRude = 14, // 0x0000000E
    SimpleRoar = 15, // 0x0000000F
    SimpleKneel = 16, // 0x00000010
    SimpleKiss = 17, // 0x00000011
    SimpleCry = 18, // 0x00000012
    SimpleChicken = 19, // 0x00000013
    SimpleBeg = 20, // 0x00000014
    SimpleApplaud = 21, // 0x00000015
    SimpleShout = 22, // 0x00000016
    SimpleFlex = 23, // 0x00000017
    SimpleShy = 24, // 0x00000018
    SimplePoint = 25, // 0x00000019
    StateStand = 26, // 0x0000001A
    StateReadyunarmed = 27, // 0x0000001B
    StateWork = 28, // 0x0000001C
    StatePoint = 29, // 0x0000001D
    StateNone = 30, // 0x0000001E
    SimpleWound = 33, // 0x00000021
    SimpleWoundcritical = 34, // 0x00000022
    SimpleAttackunarmed = 35, // 0x00000023
    SimpleAttack1h = 36, // 0x00000024
    SimpleAttack2htight = 37, // 0x00000025
    SimpleAttack2hloose = 38, // 0x00000026
    SimpleParryunarmed = 39, // 0x00000027
    SimpleParryshield = 43, // 0x0000002B
    SimpleReadyunarmed = 44, // 0x0000002C
    SimpleReady1h = 45, // 0x0000002D
    SimpleReadybow = 48, // 0x00000030
    SimpleSpellprecast = 50, // 0x00000032
    SimpleSpellcast = 51, // 0x00000033
    SimpleBattleroar = 53, // 0x00000035
    SimpleSpecialattack1h = 54, // 0x00000036
    SimpleKick = 60, // 0x0000003C
    SimpleAttackthrown = 61, // 0x0000003D
    StateStun = 64, // 0x00000040
    StateDead = 65, // 0x00000041
    SimpleSalute = 66, // 0x00000042
    StateKneel = 68, // 0x00000044
    StateUsestanding = 69, // 0x00000045
    SimpleWaveNosheathe = 70, // 0x00000046
    SimpleCheerNosheathe = 71, // 0x00000047
    SimpleEatNosheathe = 92, // 0x0000005C
    StateStunNosheathe = 93, // 0x0000005D
    SimpleDance = 94, // 0x0000005E
    SimpleSaluteNosheath = 113, // 0x00000071
    StateUsestandingNosheathe = 133, // 0x00000085
    SimpleLaughNosheathe = 153, // 0x00000099
    StateWorkNosheathe = 173, // 0x000000AD
    StateSpellprecast = 193, // 0x000000C1
    SimpleReadyrifle = 213, // 0x000000D5
    StateReadyrifle = 214, // 0x000000D6
    StateWorkNosheatheMining = 233, // 0x000000E9
    StateWorkNosheatheChopwood = 234, // 0x000000EA
    Old_SimpleLiftoff = 253, // 0x000000FD
    SimpleLiftoff = 254, // 0x000000FE
    SimpleYes = 273, // 0x00000111
    SimpleNo = 274, // 0x00000112
    SimpleTrain = 275, // 0x00000113
    SimpleLand = 293, // 0x00000125
    StateAtEase = 313, // 0x00000139
    StateReady1h = 333, // 0x0000014D
    StateSpellkneelstart = 353, // 0x00000161
    StateSubmerged = 373, // 0x00000175
    SimpleSubmerge = 374, // 0x00000176
    StateReady2h = 375, // 0x00000177
    StateReadybow = 376, // 0x00000178
    SimpleMountspecial = 377, // 0x00000179
    StateTalk = 378, // 0x0000017A
    StateFishing = 379, // 0x0000017B
    SimpleFishing = 380, // 0x0000017C
    SimpleLoot = 381, // 0x0000017D
    StateWhirlwind = 382, // 0x0000017E
    StateDrowned = 383, // 0x0000017F
    StateHoldBow = 384, // 0x00000180
    StateHoldRifle = 385, // 0x00000181
    StateHoldThrown = 386, // 0x00000182
    SimpleDrown = 387, // 0x00000183
    SimpleStomp = 388, // 0x00000184
    SimpleAttackoff = 389, // 0x00000185
    SimpleAttackoffpierce = 390, // 0x00000186
    StateRoar = 391, // 0x00000187
    StateLaugh = 392, // 0x00000188
    SimpleCreatureSpecial = 393, // 0x00000189
    SimpleJumpandrun = 394, // 0x0000018A
    SimpleJumpend = 395, // 0x0000018B
    SimpleTalkNosheathe = 396, // 0x0000018C
    SimplePointNosheathe = 397, // 0x0000018D
    StateCannibalize = 398, // 0x0000018E
    SimpleJumpstart = 399, // 0x0000018F
    StateDancespecial = 400, // 0x00000190
    SimpleDancespecial = 401, // 0x00000191
    SimpleCustomspell01 = 402, // 0x00000192
    SimpleCustomspell02 = 403, // 0x00000193
    SimpleCustomspell03 = 404, // 0x00000194
    SimpleCustomspell04 = 405, // 0x00000195
    SimpleCustomspell05 = 406, // 0x00000196
    SimpleCustomspell06 = 407, // 0x00000197
    SimpleCustomspell07 = 408, // 0x00000198
    SimpleCustomspell08 = 409, // 0x00000199
    SimpleCustomspell09 = 410, // 0x0000019A
    SimpleCustomspell10 = 411, // 0x0000019B
    StateExclaim = 412, // 0x0000019C
    PullingString = 416 // 0x000001A0
  }
}