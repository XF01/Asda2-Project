﻿using System;

namespace WCell.Constants.World
{
    [Serializable]
    public enum MapId
    {
        None = -1,
        Silaris = 0,
        RainRiver = 1,
        ConquestLand = 2,
        Alpia = 3,
        NightValey = 4,
        Aquaton = 5,
        SunnyCoast = 6,
        Flamio = 7,
        QueenPalace = 8,
        CastleOfChess = 9,
        FlamioPlains = 10, // 0x0000000A
        NeptillanNode = 11, // 0x0000000B
        FlamionMoutain = 12, // 0x0000000C
        Flabis = 13, // 0x0000000D
        StagnantDesert = 14, // 0x0000000E
        DragonLair = 15, // 0x0000000F
        FirewayForest = 16, // 0x00000010
        CastleOfChaos = 17, // 0x00000011
        Inferion = 18, // 0x00000012
        BatleField = 19, // 0x00000013
        DecaronLab = 20, // 0x00000014
        FieldOfHonnor = 21, // 0x00000015
        OX = 22, // 0x00000016
        IceQuarry = 23, // 0x00000017
        BurnedoutForest = 24, // 0x00000018
        DesolateSwamp = 25, // 0x00000019
        DesolatedMarsh = 25, // 0x00000019
        FrigidWastes = 26, // 0x0000001A
        NeverFall = 27, // 0x0000001B
        Testing = 28, // 0x0000001C
        AlteracValley = 30, // 0x0000001E
        ShadowfangKeep = 33, // 0x00000021
        StormwindStockade = 34, // 0x00000022
        UnusedStormwindPrison = 35, // 0x00000023
        Deadmines = 36, // 0x00000024
        AzsharaCrater = 37, // 0x00000025
        CollinsTest = 42, // 0x0000002A
        WailingCaverns = 43, // 0x0000002B
        UnusedMonastery = 44, // 0x0000002C
        RazorfenKraul = 47, // 0x0000002F
        BlackfathomDeeps = 48, // 0x00000030
        Uldaman = 70, // 0x00000046
        Gnomeregan = 90, // 0x0000005A
        SunkenTemple = 109, // 0x0000006D
        RazorfenDowns = 129, // 0x00000081
        EmeraldDream = 169, // 0x000000A9
        ScarletMonastery = 189, // 0x000000BD
        ZulFarrak = 209, // 0x000000D1
        BlackrockSpire = 229, // 0x000000E5
        BlackrockDepths = 230, // 0x000000E6
        OnyxiasLair = 249, // 0x000000F9
        OpeningOfTheDarkPortal = 269, // 0x0000010D
        Scholomance = 289, // 0x00000121
        ZulGurub = 309, // 0x00000135
        Stratholme = 329, // 0x00000149
        Maraudon = 349, // 0x0000015D
        DeeprunTram = 369, // 0x00000171
        RagefireChasm = 389, // 0x00000185
        MoltenCore = 409, // 0x00000199
        DireMaul = 429, // 0x000001AD
        AlliancePVPBarracks = 449, // 0x000001C1
        HordePVPBarracks = 450, // 0x000001C2
        DevelopmentLand = 451, // 0x000001C3
        BlackwingLair = 469, // 0x000001D5
        WarsongGulch = 489, // 0x000001E9
        RuinsOfAhnQiraj = 509, // 0x000001FD
        ArathiBasin = 529, // 0x00000211
        Outland = 530, // 0x00000212
        AhnQirajTemple = 531, // 0x00000213
        Karazhan = 532, // 0x00000214
        Naxxramas = 533, // 0x00000215
        TheBattleForMountHyjal = 534, // 0x00000216
        HellfireCitadelTheShatteredHalls = 540, // 0x0000021C
        HellfireCitadelTheBloodFurnace = 542, // 0x0000021E
        HellfireCitadelRamparts = 543, // 0x0000021F
        MagtheridonsLair = 544, // 0x00000220
        CoilfangTheSteamvault = 545, // 0x00000221
        CoilfangTheUnderbog = 546, // 0x00000222
        CoilfangTheSlavePens = 547, // 0x00000223
        CoilfangSerpentshrineCavern = 548, // 0x00000224
        TempestKeep = 550, // 0x00000226
        TempestKeepTheArcatraz = 552, // 0x00000228
        TempestKeepTheBotanica = 553, // 0x00000229
        TempestKeepTheMechanar = 554, // 0x0000022A
        AuchindounShadowLabyrinth = 555, // 0x0000022B
        AuchindounSethekkHalls = 556, // 0x0000022C
        AuchindounManaTombs = 557, // 0x0000022D
        AuchindounAuchenaiCrypts = 558, // 0x0000022E
        NagrandArena = 559, // 0x0000022F
        TheEscapeFromDurnholde = 560, // 0x00000230
        BladesEdgeArena = 562, // 0x00000232
        BlackTemple = 564, // 0x00000234
        GruulsLair = 565, // 0x00000235
        EyeOfTheStorm = 566, // 0x00000236
        ZulAman = 568, // 0x00000238
        Northrend = 571, // 0x0000023B
        RuinsOfLordaeron = 572, // 0x0000023C
        ExteriorTest = 573, // 0x0000023D
        UtgardeKeep = 574, // 0x0000023E
        UtgardePinnacle = 575, // 0x0000023F
        TheNexus = 576, // 0x00000240
        TheOculus = 578, // 0x00000242
        TheSunwell = 580, // 0x00000244
        TransportRutTheranToAuberdine = 582, // 0x00000246
        TransportMenethilToTheramore = 584, // 0x00000248
        MagistersTerrace = 585, // 0x00000249
        TransportExodarToAuberdine = 586, // 0x0000024A
        TransportFeathermoonFerry = 587, // 0x0000024B
        TransportMenethilToAuberdine = 588, // 0x0000024C
        TransportOrgrimmarToGromGol = 589, // 0x0000024D
        TransportGromGolToUndercity = 590, // 0x0000024E
        TransportUndercityToOrgrimmar = 591, // 0x0000024F
        TransportBoreanTundraTest = 592, // 0x00000250
        TransportBootyBayToRatchet = 593, // 0x00000251
        TransportHowlingFjordSisterMercyQuest = 594, // 0x00000252
        TheCullingOfStratholme = 595, // 0x00000253
        TransportNaglfar = 596, // 0x00000254
        CraigTest = 597, // 0x00000255
        SunwellFixUnused = 598, // 0x00000256
        HallsOfStone = 599, // 0x00000257
        DrakTharonKeep = 600, // 0x00000258
        AzjolNerub = 601, // 0x00000259
        HallsOfLightning = 602, // 0x0000025A
        Ulduar = 603, // 0x0000025B
        Gundrak = 604, // 0x0000025C
        DevelopmentLandNonWeightedTextures = 605, // 0x0000025D
        QAAndDVD = 606, // 0x0000025E
        StrandOfTheAncients = 607, // 0x0000025F
        VioletHold = 608, // 0x00000260
        EbonHold = 609, // 0x00000261
        TransportTirisfalToVengeanceLanding = 610, // 0x00000262
        TransportMenethilToValgarde = 612, // 0x00000264
        TransportOrgrimmarToWarsongHold = 613, // 0x00000265
        TransportStormwindToValianceKeep = 614, // 0x00000266
        TheObsidianSanctum = 615, // 0x00000267
        TheEyeOfEternity = 616, // 0x00000268
        DalaranSewers = 617, // 0x00000269
        TheRingOfValor = 618, // 0x0000026A
        AhnKahetTheOldKingdom = 619, // 0x0000026B
        TransportMoaKiToUnuPe = 620, // 0x0000026C
        TransportMoaKiToKamagua = 621, // 0x0000026D
        TransportOrgrimsHammer = 622, // 0x0000026E
        TransportTheSkybreaker = 623, // 0x0000026F
        VaultOfArchavon = 624, // 0x00000270
        IsleOfConquest = 628, // 0x00000274
        IcecrownCitadel = 631, // 0x00000277
        TheForgeOfSouls = 632, // 0x00000278
        TransportAllianceAirshipBG = 641, // 0x00000281
        TransportHordeAirshipBG = 642, // 0x00000282
        TransportOrgrimmarToThunderBluff = 647, // 0x00000287
        TrialOfTheCrusader = 649, // 0x00000289
        TrialOfTheChampion = 650, // 0x0000028A
        PitOfSaron = 658, // 0x00000292
        HallsOfReflection = 668, // 0x0000029C
        TransportTheSkybreakerIcecrownCitadelRaid = 672, // 0x000002A0
        TransportOrgrimsHammerIcecrownCitadelRaid = 673, // 0x000002A1
        TransportTheSkybreakerICDungeon = 712, // 0x000002C8
        TransportOrgrimsHammerICDungeon = 713, // 0x000002C9
        TrasnportTheMightyWindIcecrownCitadelRaid = 718, // 0x000002CE
        Stormwind = 723, // 0x000002D3
        TheRubySanctum = 724, // 0x000002D4
        EasternKingdoms = 725, // 0x000002D5
        Kalimdor = 726, // 0x000002D6
        End = 727, // 0x000002D7
    }
}