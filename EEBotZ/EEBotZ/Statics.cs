using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EEBotZ
{
    /// <summary>
    /// A class containing the ID numbers for all blocks.
    /// </summary>
    public static class Blocks
    {
        /// <summary>
        /// = 0
        /// </summary>
        public const int Nothing = 0;

        /// <summary>
        /// = 0
        /// </summary>
        public const int Empty = 0;

        /// <summary>
        /// = 0
        /// </summary>
        public const int Erase = 0;

        /// <summary>
        /// = 5
        /// </summary>
        public const int Crown = 5;

        /// <summary>
        /// = 121
        /// </summary>
        public const int Win = 121;

        /// <summary>
        /// = 241
        /// </summary>
        public const int Diamond = 241;

        /// <summary>
        /// = 242
        /// </summary>
        public const int Portal = 242;

        /// <summary>
        /// = 255
        /// </summary>
        public const int Spawn = 255;

        /// <summary>
        /// = 337
        /// </summary>
        public const int Cake = 337;

        /// <summary>
        /// 
        /// </summary>
        public static class Gravity
        {
            /// <summary>
            /// = 0
            /// </summary>
            public const int Down = 0;

            /// <summary>
            /// = 1
            /// </summary>
            public const int Left = 1;

            /// <summary>
            /// = 2
            /// </summary>
            public const int Up = 2;

            /// <summary>
            /// = 3
            /// </summary>
            public const int Right = 3;

            /// <summary>
            /// = 4
            /// </summary>
            public const int Dot = 4;
        }

        /// <summary>
        /// 
        /// </summary>
        public static class Keys
        {
            /// <summary>
            /// = 6
            /// </summary>
            public const int Red = 6;

            /// <summary>
            /// = 7
            /// </summary>
            public const int Green = 7;

            /// <summary>
            /// = 8
            /// </summary>
            public const int Blue = 8;

            /// <summary>
            /// = 113
            /// </summary>
            public const int Purple = 113;
        }

        /// <summary>
        /// 
        /// </summary>
        public static class Doors
        {
            /// <summary>
            /// = 23
            /// </summary>
            public const int Red = 23;

            /// <summary>
            /// = 24
            /// </summary>
            public const int Green = 24;

            /// <summary>
            /// = 25
            /// </summary>
            public const int Blue = 25;

            /// <summary>
            /// = 43
            /// </summary>
            public const int Coin = 43;

            /// <summary>
            /// = 156
            /// </summary>
            public const int Timed = 156;

            /// <summary>
            /// = 184
            /// </summary>
            public const int Purple = 184;
        }

        /// <summary>
        /// 
        /// </summary>
        public static class Gates
        {
            /// <summary>
            /// = 26
            /// </summary>
            public const int Red = 26;

            /// <summary>
            /// = 27
            /// </summary>
            public const int Green = 27;

            /// <summary>
            /// = 28
            /// </summary>
            public const int Blue = 28;

            /// <summary>
            /// = 165
            /// </summary>
            public const int Coin = 165;

            /// <summary>
            /// = 157
            /// </summary>
            public const int Timed = 157;

            /// <summary>
            /// = 185
            /// </summary>
            public const int Purple = 185;
        }

        /// <summary>
        /// 
        /// </summary>
        public static class Timed
        {
            /// <summary>
            /// = 156
            /// </summary>
            public const int Door = 156;

            /// <summary>
            /// = 157
            /// </summary>
            public const int Gate = 157;
        }

        /// <summary>
        /// 
        /// </summary>
        public static class Basic
        {
            /// <summary>
            /// 
            /// </summary>
            public static class Block
            {
                /// <summary>
                /// = 9
                /// </summary>
                public const int Gray = 9;

                /// <summary>
                /// = 10
                /// </summary>
                public const int Blue = 10;

                /// <summary>
                /// = 11
                /// </summary>
                public const int Magenta = 11;

                /// <summary>
                /// = 12
                /// </summary>
                public const int Red = 12;

                /// <summary>
                /// = 13
                /// </summary>
                public const int Yellow = 13;

                /// <summary>
                /// = 14
                /// </summary>
                public const int Green = 14;

                /// <summary>
                /// = 15
                /// </summary>
                public const int Cyan = 15;

                /// <summary>
                /// = 182
                /// </summary>
                public const int Black = 182;
            }

            /// <summary>
            /// 
            /// </summary>
            public static class BG
            {
                /// <summary>
                /// = 500
                /// </summary>
                public const int Gray = 500;

                /// <summary>
                /// = 501
                /// </summary>
                public const int Blue = 501;

                /// <summary>
                /// = 502
                /// </summary>
                public const int Magenta = 502;

                /// <summary>
                /// = 503
                /// </summary>
                public const int Red = 503;

                /// <summary>
                /// = 504
                /// </summary>
                public const int Yellow = 504;

                /// <summary>
                /// = 505
                /// </summary>
                public const int Green = 505;

                /// <summary>
                /// = 506
                /// </summary>
                public const int Cyan = 506;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static class Brick
        {
            /// <summary>
            /// 
            /// </summary>
            public static class Block
            {
                /// <summary>
                /// = 16
                /// </summary>
                public const int Orange = 16;

                /// <summary>
                /// = 17
                /// </summary>
                public const int Teal = 17;

                /// <summary>
                /// = 18
                /// </summary>
                public const int Purple = 18;

                /// <summary>
                /// = 19
                /// </summary>
                public const int Green = 19;

                /// <summary>
                /// = 20
                /// </summary>
                public const int Red = 20;

                /// <summary>
                /// = 21
                /// </summary>
                public const int Brown = 21;
            }

            /// <summary>
            /// 
            /// </summary>
            public static class BG
            {
                /// <summary>
                /// = 507
                /// </summary>
                public const int Orange = 507;

                /// <summary>
                /// = 508
                /// </summary>
                public const int Teal = 508;

                /// <summary>
                /// = 509
                /// </summary>
                public const int Purple = 509;

                /// <summary>
                /// = 510
                /// </summary>
                public const int Green = 510;

                /// <summary>
                /// = 511
                /// </summary>
                public const int Red = 511;

                /// <summary>
                /// = 512
                /// </summary>
                public const int Brown = 512;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static class Special
        {
            /// <summary>
            /// = 33
            /// </summary>
            public const int Black = 33;

            /// <summary>
            /// = 44
            /// </summary>
            public const int FullyBlack = 44;

            /// <summary>
            /// = 22
            /// </summary>
            public const int Hazard = 22;

            /// <summary>
            /// = 32
            /// </summary>
            public const int Smiley = 32;
        }

        /// <summary>
        /// 
        /// </summary>
        public static class Metal
        {
            /// <summary>
            /// = 31
            /// </summary>
            public const int Gold = 31;

            /// <summary>
            /// = 29
            /// </summary>
            public const int Silver = 29;

            /// <summary>
            /// = 30
            /// </summary>
            public const int Bronze = 30;
        }

        /// <summary>
        /// 
        /// </summary>
        public static class Grass
        {
            /// <summary>
            /// = 34
            /// </summary>
            public const int _1 = 34;

            /// <summary>
            /// = 35
            /// </summary>
            public const int _2 = 35;

            /// <summary>
            /// = 36
            /// </summary>
            public const int _3 = 36;
        }

        /// <summary>
        /// 
        /// </summary>
        public static class Beta
        {
            /// <summary>
            /// = 37
            /// </summary>
            public const int Purple = 37;

            /// <summary>
            /// = 38
            /// </summary>
            public const int Green = 38;

            /// <summary>
            /// = 39
            /// </summary>
            public const int Blue = 39;

            /// <summary>
            /// = 40
            /// </summary>
            public const int Red = 40;

            /// <summary>
            /// = 41
            /// </summary>
            public const int Yellow = 41;

            /// <summary>
            /// = 42
            /// </summary>
            public const int Gray = 42;
        }

        /// <summary>
        /// 
        /// </summary>
        public static class Factory
        {
            /// <summary>
            /// = 45
            /// </summary>
            public const int DullCrate = 45;

            /// <summary>
            /// = 46
            /// </summary>
            public const int Wall = 46;

            /// <summary>
            /// = 47
            /// </summary>
            public const int Wood = 47;

            /// <summary>
            /// = 48
            /// </summary>
            public const int Crate = 48;

            /// <summary>
            /// = 49
            /// </summary>
            public const int Scales = 49;
        }

        /// <summary>
        /// 
        /// </summary>
        public static class Secret
        {
            /// <summary>
            /// = 50
            /// </summary>
            public const int _1 = 50;

            /// <summary>
            /// = 243
            /// </summary>
            public const int _2 = 243;
        }

        /// <summary>
        /// 
        /// </summary>
        public static class Glass
        {
            /// <summary>
            /// = 51
            /// </summary>
            public const int Red = 51;

            /// <summary>
            /// = 52
            /// </summary>
            public const int Violet = 52;

            /// <summary>
            /// = 53
            /// </summary>
            public const int Purple = 53;

            /// <summary>
            /// = 54
            /// </summary>
            public const int Blue = 54;

            /// <summary>
            /// = 55
            /// </summary>
            public const int Cyan = 55;

            /// <summary>
            /// = 56
            /// </summary>
            public const int Green = 56;

            /// <summary>
            /// = 57
            /// </summary>
            public const int Yellow = 57;

            /// <summary>
            /// = 58
            /// </summary>
            public const int Orange = 58;
        }

        /// <summary>
        /// 
        /// </summary>
        public static class Spring2011
        {
            /// <summary>
            /// = 233
            /// </summary>
            public const int ShortGrassLeft = 233;

            /// <summary>
            /// = 234
            /// </summary>
            public const int ShortGrassMiddle = 234;

            /// <summary>
            /// = 235
            /// </summary>
            public const int ShortGrassRight = 235;

            /// <summary>
            /// = 236
            /// </summary>
            public const int TallGrassLeft = 236;

            /// <summary>
            /// = 237
            /// </summary>
            public const int TallGrassMiddle = 237;

            /// <summary>
            /// = 238
            /// </summary>
            public const int TallGrassRight = 238;

            /// <summary>
            /// = 239
            /// </summary>
            public const int Flower = 239;

            /// <summary>
            /// = 240
            /// </summary>
            public const int Bush = 240;
        }

        /// <summary>
        /// 
        /// </summary>
        public static class Summer2011
        {
            /// <summary>
            /// = 59
            /// </summary>
            public const int Sand = 59;

            /// <summary>
            /// = 228
            /// </summary>
            public const int Parasol = 228;

            /// <summary>
            /// = 229
            /// </summary>
            public const int SandPileLeft = 229;

            /// <summary>
            /// = 230
            /// </summary>
            public const int SandPileRight = 230;

            /// <summary>
            /// = 231
            /// </summary>
            public const int Pebble = 231;

            /// <summary>
            /// = 232
            /// </summary>
            public const int DriedBush = 232;
        }

        /// <summary>
        /// 
        /// </summary>
        public static class Summer2012
        {
            /// <summary>
            /// = 307
            /// </summary>
            public const int Ball = 307;

            /// <summary>
            /// = 308
            /// </summary>
            public const int Pail = 308;

            /// <summary>
            /// = 309
            /// </summary>
            public const int Shovel = 309;

            /// <summary>
            /// = 310
            /// </summary>
            public const int Drink = 310;
        }

        /// <summary>
        /// 
        /// </summary>
        public static class Candy
        {
            /// <summary>
            /// 
            /// </summary>
            public static class Block
            {
                /// <summary>
                /// = 60
                /// </summary>
                public const int Bubblegum = 60;

                /// <summary>
                /// = 61
                /// </summary>
                public const int MagentaBean = 61;

                /// <summary>
                /// = 62
                /// </summary>
                public const int RedBean = 62;

                /// <summary>
                /// = 63
                /// </summary>
                public const int CyanBean = 63;

                /// <summary>
                /// = 64
                /// </summary>
                public const int GreenBean = 64;

                /// <summary>
                /// = 65
                /// </summary>
                public const int Peppermint = 65;

                /// <summary>
                /// = 66
                /// </summary>
                public const int Tricolor = 66;

                /// <summary>
                /// = 67
                /// </summary>
                public const int Chocolate = 67;
            }

            /// <summary>
            /// 
            /// </summary>
            public static class Decor
            {
                /// <summary>
                /// = 227
                /// </summary>
                public const int WhippedCream = 227;
            }

            /// <summary>
            /// 
            /// </summary>
            public static class BG
            {
                /// <summary>
                /// = 539
                /// </summary>
                public const int Pink = 539;

                /// <summary>
                /// = 540
                /// </summary>
                public const int Blue = 540;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static class Halloween2011
        {
            /// <summary>
            /// 
            /// </summary>
            public static class Block
            {
                /// <summary>
                /// = 68
                /// </summary>
                public const int BloodyWall = 68;

                /// <summary>
                /// = 69
                /// </summary>
                public const int Wall = 69;
            }

            /// <summary>
            /// 
            /// </summary>
            public static class Decor
            {
                /// <summary>
                /// = 224
                /// </summary>
                public const int HeadStone = 224;

                /// <summary>
                /// = 225
                /// </summary>
                public const int WebLeft = 225;

                /// <summary>
                /// = 226
                /// </summary>
                public const int WebRight = 226;
            }

            /// <summary>
            /// 
            /// </summary>
            public static class BG
            {
                /// <summary>
                /// = 541
                /// </summary>
                public const int Fog = 541;

                /// <summary>
                /// = 542
                /// </summary>
                public const int Wall = 542;

                /// <summary>
                /// = 543
                /// </summary>
                public const int WallRight = 543;

                /// <summary>
                /// = 544
                /// </summary>
                public const int WallLeft = 544;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static class Mineral
        {
            /// <summary>
            /// = 70
            /// </summary>
            public const int Red = 70;

            /// <summary>
            /// = 71
            /// </summary>
            public const int Magenta = 71;

            /// <summary>
            /// = 72
            /// </summary>
            public const int Blue = 72;

            /// <summary>
            /// = 73
            /// </summary>
            public const int Cyan = 73;

            /// <summary>
            /// = 74
            /// </summary>
            public const int Green = 74;

            /// <summary>
            /// = 75
            /// </summary>
            public const int Yellow = 75;

            /// <summary>
            /// = 76
            /// </summary>
            public const int Orange = 76;
        }

        /// <summary>
        /// 
        /// </summary>
        public static class Music
        {
            /// <summary>
            /// = 77
            /// </summary>
            public const int Piano = 77;

            /// <summary>
            /// = 83
            /// </summary>
            public const int Drum = 83;
        }

        /// <summary>
        /// 
        /// </summary>
        public static class Christmas2010
        {
            /// <summary>
            /// = 249
            /// </summary>
            public const int SnowpileLeft = 249;

            /// <summary>
            /// = 250
            /// </summary>
            public const int SnowpileRight = 250;

            /// <summary>
            /// = 251
            /// </summary>
            public const int Tree = 251;

            /// <summary>
            /// = 252
            /// </summary>
            public const int TreeFrost = 252;

            /// <summary>
            /// = 253
            /// </summary>
            public const int FenceFrost = 253;

            /// <summary>
            /// = 254
            /// </summary>
            public const int Fence = 254;
        }

        /// <summary>
        /// 
        /// </summary>
        public static class Christmas2011
        {
            /// <summary>
            /// 
            /// </summary>
            public static class Block
            {
                /// <summary>
                /// = 78
                /// </summary>
                public const int YellowGift = 78;

                /// <summary>
                /// = 79
                /// </summary>
                public const int WhiteGift = 79;

                /// <summary>
                /// = 80
                /// </summary>
                public const int RedGift = 80;

                /// <summary>
                /// = 81
                /// </summary>
                public const int BlueGift = 81;

                /// <summary>
                /// = 82
                /// </summary>
                public const int GreenGift = 82;
            }

            /// <summary>
            /// 
            /// </summary>
            public static class Decor
            {
                /// <summary>
                /// = 218
                /// </summary>
                public const int RedOrnament = 218;

                /// <summary>
                /// = 219
                /// </summary>
                public const int GreenOrnament = 219;

                /// <summary>
                /// = 220
                /// </summary>
                public const int BlueOrnament = 220;

                /// <summary>
                /// = 221
                /// </summary>
                public const int Wreath = 221;

                /// <summary>
                /// = 222
                /// </summary>
                public const int Star = 222;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static class NewYears2010
        {
            /// <summary>
            /// = 244
            /// </summary>
            public const int Purple = 244;

            /// <summary>
            /// = 245
            /// </summary>
            public const int Yellow = 245;

            /// <summary>
            /// = 246
            /// </summary>
            public const int Blue = 246;

            /// <summary>
            /// = 247
            /// </summary>
            public const int Red = 247;

            /// <summary>
            /// = 248
            /// </summary>
            public const int Green = 248;
        }

        /// <summary>
        /// 
        /// </summary>
        public static class Easter2012
        {
            /// <summary>
            /// = 256
            /// </summary>
            public const int Blue = 256;

            /// <summary>
            /// = 257
            /// </summary>
            public const int Purple = 257;

            /// <summary>
            /// = 258
            /// </summary>
            public const int Yellow = 258;

            /// <summary>
            /// = 259
            /// </summary>
            public const int Red = 259;

            /// <summary>
            /// = 260
            /// </summary>
            public const int Green = 260;
        }

        /// <summary>
        /// 
        /// </summary>
        public static class Scifi
        {
            /// <summary>
            /// = 84
            /// </summary>
            public const int Red = 84;

            /// <summary>
            /// = 85
            /// </summary>
            public const int Blue = 85;

            /// <summary>
            /// = 86
            /// </summary>
            public const int Gray = 86;

            /// <summary>
            /// = 87
            /// </summary>
            public const int White = 87;

            /// <summary>
            /// = 88
            /// </summary>
            public const int Brown = 88;

            /// <summary>
            /// = 89
            /// </summary>
            public const int RedPlatform = 89;

            /// <summary>
            /// = 90
            /// </summary>
            public const int BluePlatform = 90;

            /// <summary>
            /// = 91
            /// </summary>
            public const int GreenPlatform = 91;
        }

        /// <summary>
        /// 
        /// </summary>
        public static class Prison
        {
            /// <summary>
            /// 
            /// </summary>
            public static class Block
            {
                /// <summary>
                /// = 92
                /// </summary>
                public const int Wall = 92;
            }

            /// <summary>
            /// 
            /// </summary>
            public static class Decor
            {
                /// <summary>
                /// = 261
                /// </summary>
                public const int Bars = 261;
            }

            /// <summary>
            /// 
            /// </summary>
            public static class BG
            {
                /// <summary>
                /// = 550
                /// </summary>
                public const int Wall = 550;

                /// <summary>
                /// = 551
                /// </summary>
                public const int Painting = 551;

                /// <summary>
                /// = 552
                /// </summary>
                public const int BarsLight = 552;

                /// <summary>
                /// = 553
                /// </summary>
                public const int BarsDark = 553;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static class Pirate
        {
            /// <summary>
            /// 
            /// </summary>
            public static class Block
            {
                /// <summary>
                /// = 93
                /// </summary>
                public const int Wood = 93;

                /// <summary>
                /// = 94
                /// </summary>
                public const int Chest = 94;
            }

            /// <summary>
            /// 
            /// </summary>
            public static class Decor
            {
                /// <summary>
                /// = 271
                /// </summary>
                public const int Shelf = 271;

                /// <summary>
                /// = 272
                /// </summary>
                public const int Skull = 272;
            }

            /// <summary>
            /// 
            /// </summary>
            public static class BG
            {
                /// <summary>
                /// = 554
                /// </summary>
                public const int PlanksDark = 554;

                /// <summary>
                /// = 555
                /// </summary>
                public const int PlanksLight = 555;

                /// <summary>
                /// = 556
                /// </summary>
                public const int PlanksNailed = 556;

                /// <summary>
                /// = 557
                /// </summary>
                public const int LifeRing = 557;

                /// <summary>
                /// = 558
                /// </summary>
                public const int Window = 558;

                /// <summary>
                /// = 559
                /// </summary>
                public const int Cannon = 559;

                /// <summary>
                /// = 560
                /// </summary>
                public const int JollyRoger = 560;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static class Vikings
        {
            /// <summary>
            /// 
            /// </summary>
            public static class Block
            {
                /// <summary>
                /// = 95
                /// </summary>
                public const int Wall = 95;
            }

            /// <summary>
            /// 
            /// </summary>
            public static class Decor
            {
                /// <summary>
                /// = 273
                /// </summary>
                public const int RedShield = 273;

                /// <summary>
                /// = 274
                /// </summary>
                public const int BlueShield = 274;

                /// <summary>
                /// = 275
                /// </summary>
                public const int Axe = 275;
            }

            /// <summary>
            /// 
            /// </summary>
            public static class BG
            {
                /// <summary>
                /// = 561
                /// </summary>
                public const int Wall = 561;

                /// <summary>
                /// = 562
                /// </summary>
                public const int WallShifted = 562;

                /// <summary>
                /// = 563
                /// </summary>
                public const int Flag = 563;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static class Ninja
        {
            /// <summary>
            /// 
            /// </summary>
            public static class Block
            {
                /// <summary>
                /// = 96
                /// </summary>
                public const int White = 96;

                /// <summary>
                /// = 97
                /// </summary>
                public const int Black = 97;
            }

            /// <summary>
            /// 
            /// </summary>
            public static class Action
            {
                /// <summary>
                /// = 120
                /// </summary>
                public const int Ladder = 120;
            }

            /// <summary>
            /// 
            /// </summary>
            public static class Decor
            {
                /// <summary>
                /// = 276
                /// </summary>
                public const int HornLightLeft = 276;

                /// <summary>
                /// = 277
                /// </summary>
                public const int HornLightRight = 277;

                /// <summary>
                /// = 278
                /// </summary>
                public const int WindowLight = 278;

                /// <summary>
                /// = 279
                /// </summary>
                public const int HornDarkLeft = 279;

                /// <summary>
                /// = 280
                /// </summary>
                public const int HornDarkRight = 280;

                /// <summary>
                /// = 281
                /// </summary>
                public const int WindowDark = 281;

                /// <summary>
                /// = 282
                /// </summary>
                public const int SymbolSun = 282;

                /// <summary>
                /// = 283
                /// </summary>
                public const int SymbolOrigin = 283;

                /// <summary>
                /// = 284
                /// </summary>
                public const int YinYang = 284;
            }

            /// <summary>
            /// 
            /// </summary>
            public static class BG
            {
                /// <summary>
                /// = 564
                /// </summary>
                public const int White = 564;

                /// <summary>
                /// = 565
                /// </summary>
                public const int Gray = 565;

                /// <summary>
                /// = 566
                /// </summary>
                public const int RoofLight = 566;

                /// <summary>
                /// = 567
                /// </summary>
                public const int RoofDark = 567;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static class Cowboy
        {
            /// <summary>
            /// 
            /// </summary>
            public static class Block
            {
                /// <summary>
                /// = 122
                /// </summary>
                public const int Brown = 122;

                /// <summary>
                /// = 123
                /// </summary>
                public const int Red = 123;

                /// <summary>
                /// = 124
                /// </summary>
                public const int Blue = 124;

                /// <summary>
                /// = 125
                /// </summary>
                public const int DarkBrown = 125;

                /// <summary>
                /// = 126
                /// </summary>
                public const int DarkRed = 126;

                /// <summary>
                /// = 127
                /// </summary>
                public const int DarkBlue = 127;
            }

            /// <summary>
            /// 
            /// </summary>
            public static class Decor
            {
                /// <summary>
                /// = 285
                /// </summary>
                public const int Post = 285;

                /// <summary>
                /// = 286
                /// </summary>
                public const int DarkPost = 286;

                /// <summary>
                /// = 287
                /// </summary>
                public const int BrownDoorLeft = 287;

                /// <summary>
                /// = 288
                /// </summary>
                public const int BrownDoorRight = 288;

                /// <summary>
                /// = 289
                /// </summary>
                public const int RedDoorLeft = 289;

                /// <summary>
                /// = 290
                /// </summary>
                public const int RedDoorRight = 290;

                /// <summary>
                /// = 291
                /// </summary>
                public const int BlueDoorLeft = 291;

                /// <summary>
                /// = 292
                /// </summary>
                public const int BlueDoorRight = 292;

                /// <summary>
                /// = 293
                /// </summary>
                public const int CurtainWindow = 293;

                /// <summary>
                /// = 294
                /// </summary>
                public const int BrownRail = 294;

                /// <summary>
                /// = 295
                /// </summary>
                public const int DarkBrownRail = 295;

                /// <summary>
                /// = 296
                /// </summary>
                public const int RedRail = 296;

                /// <summary>
                /// = 297
                /// </summary>
                public const int DarkRedRail = 297;

                /// <summary>
                /// = 298
                /// </summary>
                public const int BlueRail = 298;

                /// <summary>
                /// = 299
                /// </summary>
                public const int DarkBlueRail = 299;
            }

            /// <summary>
            /// 
            /// </summary>
            public static class BG
            {
                /// <summary>
                /// = 568
                /// </summary>
                public const int Brown = 568;

                /// <summary>
                /// = 569
                /// </summary>
                public const int DarkBrown = 569;

                /// <summary>
                /// = 570
                /// </summary>
                public const int Red = 570;

                /// <summary>
                /// = 571
                /// </summary>
                public const int DarkRed = 571;

                /// <summary>
                /// = 572
                /// </summary>
                public const int Blue = 572;

                /// <summary>
                /// = 573
                /// </summary>
                public const int DarkBlue = 573;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static class Water
        {
            /// <summary>
            /// 
            /// </summary>
            public static class Action
            {
                /// <summary>
                /// = 119
                /// </summary>
                public const int Water = 119;
            }

            /// <summary>
            /// 
            /// </summary>
            public static class Decor
            {
                /// <summary>
                /// = 300
                /// </summary>
                public const int Waves = 300;
            }

            /// <summary>
            /// 
            /// </summary>
            public static class BG
            {
                /// <summary>
                /// = 574
                /// </summary>
                public const int Water = 574;

                /// <summary>
                /// = 575
                /// </summary>
                public const int Octopus = 575;

                /// <summary>
                /// = =576
                /// </summary>
                public const int Fish = 576;

                /// <summary>
                /// = 577
                /// </summary>
                public const int SeaHorse = 577;

                /// <summary>
                /// = 578
                /// </summary>
                public const int Seaweed = 578;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static class Plastic
        {
            /// <summary>
            /// = 128
            /// </summary>
            public const int LightGreen = 128;

            /// <summary>
            /// = 129
            /// </summary>
            public const int Red = 129;

            /// <summary>
            /// = 130
            /// </summary>
            public const int Yellow = 130;

            /// <summary>
            /// = 131
            /// </summary>
            public const int Cyan = 131;

            /// <summary>
            /// = 132
            /// </summary>
            public const int Blue = 132;

            /// <summary>
            /// = 133
            /// </summary>
            public const int Magenta = 133;

            /// <summary>
            /// = 134
            /// </summary>
            public const int Green = 134;

            /// <summary>
            /// = 135
            /// </summary>
            public const int Orange = 135;
        }

        /// <summary>
        /// 
        /// </summary>
        public static class Sand
        {
            /// <summary>
            /// 
            /// </summary>
            public static class Block
            {
                /// <summary>
                /// = 137
                /// </summary>
                public const int White = 137;

                /// <summary>
                /// = 138
                /// </summary>
                public const int Gray = 138;

                /// <summary>
                /// = 139
                /// </summary>
                public const int Yellow = 139;

                /// <summary>
                /// = 140
                /// </summary>
                public const int Orange = 140;

                /// <summary>
                /// = 141
                /// </summary>
                public const int Tan = 141;

                /// <summary>
                /// = 142
                /// </summary>
                public const int Brown = 142;
            }

            /// <summary>
            /// 
            /// </summary>
            public static class Decor
            {
                /// <summary>
                /// = 301
                /// </summary>
                public const int White = 301;

                /// <summary>
                /// = 302
                /// </summary>
                public const int Gray = 302;

                /// <summary>
                /// = 303
                /// </summary>
                public const int Yellow = 303;

                /// <summary>
                /// = 304
                /// </summary>
                public const int Orange = 304;

                /// <summary>
                /// = 305
                /// </summary>
                public const int Tan = 305;

                /// <summary>
                /// = 306
                /// </summary>
                public const int Brown = 306;
            }

            /// <summary>
            /// 
            /// </summary>
            public static class BG
            {
                /// <summary>
                /// = 579
                /// </summary>
                public const int White = 579;

                /// <summary>
                /// = 580
                /// </summary>
                public const int Gray = 580;

                /// <summary>
                /// = 581
                /// </summary>
                public const int Yellow = 581;

                /// <summary>
                /// = 582
                /// </summary>
                public const int Orange = 582;

                /// <summary>
                /// = 583
                /// </summary>
                public const int Tan = 583;

                /// <summary>
                /// = 584
                /// </summary>
                public const int Brown = 584;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static class Cloud
        {
            /// <summary>
            /// 
            /// </summary>
            public static class Block
            {
                /// <summary>
                /// = 143
                /// </summary>
                public const int White = 143;
            }

            /// <summary>
            /// 
            /// </summary>
            public static class Decor
            {
                /// <summary>
                /// = 311
                /// </summary>
                public const int Down = 311;

                /// <summary>
                /// = 312
                /// </summary>
                public const int Up = 312;

                /// <summary>
                /// = 313
                /// </summary>
                public const int Left = 313;

                /// <summary>
                /// = 314
                /// </summary>
                public const int Right = 314;

                /// <summary>
                /// = 315
                /// </summary>
                public const int UpLeft = 315;

                /// <summary>
                /// = 316
                /// </summary>
                public const int UpRight = 316;

                /// <summary>
                /// = 317
                /// </summary>
                public const int DownLeft = 317;

                /// <summary>
                /// = 318
                /// </summary>
                public const int DownRight = 318;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static class Signs
        {
            /// <summary>
            /// = 319
            /// </summary>
            public const int Flammable = 319;

            /// <summary>
            /// = 320
            /// </summary>
            public const int Toxic = 320;

            /// <summary>
            /// = 321
            /// </summary>
            public const int HighVoltage = 321;

            /// <summary>
            /// = 322
            /// </summary>
            public const int Warning = 322;

            /// <summary>
            /// = 323
            /// </summary>
            public const int PoleHorizontal = 323;

            /// <summary>
            /// = 324
            /// </summary>
            public const int PoleVertical = 324;
        }

        /// <summary>
        /// 
        /// </summary>
        public static class PlateIron
        {
            /// <summary>
            /// 
            /// </summary>
            public static class Block
            {
                /// <summary>
                /// = 144
                /// </summary>
                public const int Wall = 144;

                /// <summary>
                /// = 145
                /// </summary>
                public const int Wires = 145;
            }

            /// <summary>
            /// 
            /// </summary>
            public static class BG
            {
                /// <summary>
                /// = 585
                /// </summary>
                public const int Plate = 585;

                /// <summary>
                /// = 586
                /// </summary>
                public const int Gray = 586;

                /// <summary>
                /// = 587
                /// </summary>
                public const int Blue = 587;

                /// <summary>
                /// = 588
                /// </summary>
                public const int Green = 588;

                /// <summary>
                /// = 589
                /// </summary>
                public const int Yellow = 589;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static class Industrial
        {
            /// <summary>
            /// = 146
            /// </summary>
            public const int Platform = 146;

            /// <summary>
            /// = 147
            /// </summary>
            public const int Brace = 147;

            /// <summary>
            /// = 148
            /// </summary>
            public const int Piston = 148;

            /// <summary>
            /// = 149
            /// </summary>
            public const int Cylinder = 149;

            /// <summary>
            /// = 150
            /// </summary>
            public const int ConveyerLeftEnd = 150;

            /// <summary>
            /// = 151
            /// </summary>
            public const int ConveyerBrace = 151;

            /// <summary>
            /// = 152
            /// </summary>
            public const int ConveyerCenter = 152;

            /// <summary>
            /// = 153
            /// </summary>
            public const int ConveyerRightEnd = 153;
        }

        /// <summary>
        /// 
        /// </summary>
        public static class Timbered
        {
            /// <summary>
            /// 
            /// </summary>
            public static class Block
            {
                /// <summary>
                /// = 154
                /// </summary>
                public const int Platform = 154;
            }

            /// <summary>
            /// 
            /// </summary>
            public static class BG
            {
                /// <summary>
                /// = 590
                /// </summary>
                public const int Straw = 590;

                /// <summary>
                /// = 591
                /// </summary>
                public const int ShinglesRed = 591;

                /// <summary>
                /// = 592
                /// </summary>
                public const int ShinglesGreen = 592;

                /// <summary>
                /// = 593
                /// </summary>
                public const int WallV = 593;

                /// <summary>
                /// = 594
                /// </summary>
                public const int WallWallBackSlash = 594;

                /// <summary>
                /// = 595
                /// </summary>
                public const int WallForwardSlash = 595;

                /// <summary>
                /// = 596
                /// </summary>
                public const int WallPlain = 596;

                /// <summary>
                /// = 597
                /// </summary>
                public const int WallVertical = 597;

                /// <summary>
                /// = 598
                /// </summary>
                public const int Window = 598;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static class Castle
        {
            /// <summary>
            /// 
            /// </summary>
            public static class Block
            {
                /// <summary>
                /// = 158
                /// </summary>
                public const int Platform = 158;

                /// <summary>
                /// = 159
                /// </summary>
                public const int Wall = 159;

                /// <summary>
                /// = 160
                /// </summary>
                public const int Window = 160;
            }

            /// <summary>
            /// 
            /// </summary>
            public static class Action
            {
                /// <summary>
                /// = 118
                /// </summary>
                public const int Chain = 118;
            }

            /// <summary>
            /// 
            /// </summary>
            public static class Decor
            {
                /// <summary>
                /// = 325
                /// </summary>
                public const int Corbel = 325;

                /// <summary>
                /// = 326
                /// </summary>
                public const int Battlement = 326;
            }

            /// <summary>
            /// 
            /// </summary>
            public static class BG
            {
                /// <summary>
                /// = 599
                /// </summary>
                public const int Wall = 599;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static class Medieval
        {
            /// <summary>
            /// 
            /// </summary>
            public static class Block
            {
                /// <summary>
                /// = 162
                /// </summary>
                public const int Anvil = 162;

                /// <summary>
                /// = 163
                /// </summary>
                public const int Barrel = 163;
            }

            /// <summary>
            /// 
            /// </summary>
            public static class Decor
            {
                /// <summary>
                /// = 327
                /// </summary>
                public const int BlueDrapes = 327;

                /// <summary>
                /// = 328
                /// </summary>
                public const int RedDrapes = 328;

                /// <summary>
                /// = 329
                /// </summary>
                public const int Sword = 329;

                /// <summary>
                /// = 330
                /// </summary>
                public const int Shield = 330;

                /// <summary>
                /// = 331
                /// </summary>
                public const int Rock = 331;
            }

            /// <summary>
            /// 
            /// </summary>
            public static class BG
            {
                /// <summary>
                /// = 600
                /// </summary>
                public const int Wood = 600;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static class Pipes
        {
            /// <summary>
            /// = 166
            /// </summary>
            public const int OpenLeft = 166;

            /// <summary>
            /// = 167
            /// </summary>
            public const int Horizontal = 167;

            /// <summary>
            /// = 168
            /// </summary>
            public const int OpenRight = 168;

            /// <summary>
            /// = 169
            /// </summary>
            public const int OpenUp = 169;

            /// <summary>
            /// = 170
            /// </summary>
            public const int Vertical = 170;

            /// <summary>
            /// = 171
            /// </summary>
            public const int OpenDown = 171;
        }

        /// <summary>
        /// 
        /// </summary>
        public static class Rocket
        {
            /// <summary>
            /// 
            /// </summary>
            public static class Block
            {
                /// <summary>
                /// = 172
                /// </summary>
                public const int White = 172;

                /// <summary>
                /// = 173
                /// </summary>
                public const int Blue = 173;

                /// <summary>
                /// = 174
                /// </summary>
                public const int Green = 174;

                /// <summary>
                /// = 175
                /// </summary>
                public const int Red = 175;
            }

            /// <summary>
            /// 
            /// </summary>
            public static class Decor
            {
                /// <summary>
                /// = 332
                /// </summary>
                public const int GreenScreen = 332;

                /// <summary>
                /// = 333
                /// </summary>
                public const int RedButton = 333;

                /// <summary>
                /// = 334
                /// </summary>
                public const int BlueButton = 334;

                /// <summary>
                /// = 335
                /// </summary>
                public const int Panel = 335;
            }

            /// <summary>
            /// 
            /// </summary>
            public static class BG
            {
                /// <summary>
                /// = 601
                /// </summary>
                public const int White = 601;

                /// <summary>
                /// = 602
                /// </summary>
                public const int Blue = 602;

                /// <summary>
                /// = 603
                /// </summary>
                public const int Green = 603;

                /// <summary>
                /// = 604
                /// </summary>
                public const int Red = 604;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static class Mars
        {
            /// <summary>
            /// 
            /// </summary>
            public static class Block
            {
                /// <summary>
                /// = 176
                /// </summary>
                public const int Sand = 176;

                /// <summary>
                /// = 177
                /// </summary>
                public const int Canal_1 = 177;

                /// <summary>
                /// = 178
                /// </summary>
                public const int Canal_2 = 178;

                /// <summary>
                /// = 179
                /// </summary>
                public const int Cracks = 179;

                /// <summary>
                /// = 180
                /// </summary>
                public const int UnevenPillar = 180;

                /// <summary>
                /// = 181
                /// </summary>
                public const int Pillar = 181;
            }

            /// <summary>
            /// 
            /// </summary>
            public static class Decor
            {
                /// <summary>
                /// = 336
                /// </summary>
                public const int Rock = 336;
            }

            /// <summary>
            /// 
            /// </summary>
            public static class BG
            {
                /// <summary>
                /// = 601
                /// </summary>
                public const int Sky = 601;

                /// <summary>
                /// = 602
                /// </summary>
                public const int SmallStar = 602;

                /// <summary>
                /// = 603
                /// </summary>
                public const int LargeStar = 603;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static class Boost
        {
            /// <summary>
            /// = 114
            /// </summary>
            public const int Left = 114;

            /// <summary>
            /// = 115
            /// </summary>
            public const int Right = 115;

            /// <summary>
            /// = 116
            /// </summary>
            public const int Up = 116;

            /// <summary>
            /// = 117
            /// </summary>
            public const int Down = 117;
        }

        /// <summary>
        /// 
        /// </summary>
        public static class Coin
        {
            /// <summary>
            /// = 100
            /// </summary>
            public const int Gold = 100;

            /// <summary>
            /// = 101
            /// </summary>
            public const int Blue = 101;

            /// <summary>
            /// = 43
            /// </summary>
            public const int Door = 43;

            /// <summary>
            /// = 165
            /// </summary>
            public const int Gate = 165;
        }

        /// <summary>
        /// 
        /// </summary>
        public static class Ladders
        {
            /// <summary>
            /// = 120
            /// </summary>
            public const int Ninja = 120;

            /// <summary>
            /// = 118
            /// </summary>
            public const int Chain = 118;

            /// <summary>
            /// = 120
            /// </summary>
            public const int Ladder = 120;

            /// <summary>
            /// = 118
            /// </summary>
            public const int Castle = 118;
        }

        /// <summary>
        /// 
        /// </summary>
        public static class Windows
        {
            /// <summary>
            /// = 262
            /// </summary>
            public const int Clear = 262;

            /// <summary>
            /// = 263
            /// </summary>
            public const int Green = 263;

            /// <summary>
            /// = 264
            /// </summary>
            public const int Cyan = 264;

            /// <summary>
            /// = 265
            /// </summary>
            public const int Blue = 265;

            /// <summary>
            /// = 266
            /// </summary>
            public const int Purple = 266;

            /// <summary>
            /// = 267
            /// </summary>
            public const int Magenta = 267;

            /// <summary>
            /// = 268
            /// </summary>
            public const int Red = 268;

            /// <summary>
            /// = 269
            /// </summary>
            public const int Orange = 269;

            /// <summary>
            /// = 270
            /// </summary>
            public const int Yellow = 270;
        }

        /// <summary>
        /// 
        /// </summary>
        public static class Monster
        {
            /// <summary>
            /// 
            /// </summary>
            public static class Decor
            {
                /// <summary>
                /// = 338
                /// </summary>
                public const int Tooth = 338;

                /// <summary>
                /// = 339
                /// </summary>
                public const int TeethBottom = 339;

                /// <summary>
                /// = 340
                /// </summary>
                public const int TeethTop = 340;

                /// <summary>
                /// = 341
                /// </summary>
                public const int EyeYellow = 341;

                /// <summary>
                /// = 342
                /// </summary>
                public const int EyeBlue = 342;
            }

            /// <summary>
            /// 
            /// </summary>
            public static class BG
            {
                /// <summary>
                /// = 608
                /// </summary>
                public const int LightGreen = 608;

                /// <summary>
                /// = 609
                /// </summary>
                public const int DarkGreen = 609;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static class Fog
        {
            /// <summary>
            /// = 343
            /// </summary>
            public const int Center = 343;

            /// <summary>
            /// = 344
            /// </summary>
            public const int Down = 344;

            /// <summary>
            /// = 345
            /// </summary>
            public const int Up = 345;

            /// <summary>
            /// = 346
            /// </summary>
            public const int Left = 346;

            /// <summary>
            /// = 347
            /// </summary>
            public const int Right = 347;

            /// <summary>
            /// = 348
            /// </summary>
            public const int UpLeft = 348;

            /// <summary>
            /// = 349
            /// </summary>
            public const int UpRight = 349;

            /// <summary>
            /// = 350
            /// </summary>
            public const int DownLeft = 350;

            /// <summary>
            /// = 351
            /// </summary>
            public const int DownRight = 351;
        }

        /// <summary>
        /// 
        /// </summary>
        public static class Halloween2012
        {
            /// <summary>
            /// = 352
            /// </summary>
            public const int BrainDrainer = 352;

            /// <summary>
            /// = 353
            /// </summary>
            public const int TeslaCoil = 353;

            /// <summary>
            /// = 354
            /// </summary>
            public const int VerticalWire = 354;

            /// <summary>
            /// = 355
            /// </summary>
            public const int HorizontalWire = 355;

            /// <summary>
            /// = 356
            /// </summary>
            public const int Lightning = 356;
        }

        /// <summary>
        /// BG
        /// </summary>
        public static class Checker
        {
            /// <summary>
            /// = 513
            /// </summary>
            public const int Gray = 513;

            /// <summary>
            /// = 514
            /// </summary>
            public const int Blue = 514;

            /// <summary>
            /// = 515
            /// </summary>
            public const int Magenta = 515;

            /// <summary>
            /// = 516
            /// </summary>
            public const int Red = 516;

            /// <summary>
            /// = 517
            /// </summary>
            public const int Yellow = 517;

            /// <summary>
            /// = 518
            /// </summary>
            public const int Green = 518;

            /// <summary>
            /// = 519
            /// </summary>
            public const int Cyan = 519;
        }

        /// <summary>
        /// BG
        /// </summary>
        public static class Dark
        {
            /// <summary>
            /// = 520
            /// </summary>
            public const int Gray = 520;

            /// <summary>
            /// = 521
            /// </summary>
            public const int Blue = 521;

            /// <summary>
            /// = 522
            /// </summary>
            public const int Magenta = 522;

            /// <summary>
            /// = 523
            /// </summary>
            public const int Red = 523;

            /// <summary>
            /// = 524
            /// </summary>
            public const int Yellow = 524;

            /// <summary>
            /// = 525
            /// </summary>
            public const int Green = 525;

            /// <summary>
            /// = 526
            /// </summary>
            public const int Cyan = 526;
        }

        /// <summary>
        /// BG
        /// </summary>
        public static class Pastel
        {
            /// <summary>
            /// = 527
            /// </summary>
            public const int Yellow = 527;

            /// <summary>
            /// = 528
            /// </summary>
            public const int Green = 528;

            /// <summary>
            /// = 529
            /// </summary>
            public const int LightGreen = 529;

            /// <summary>
            /// = 530
            /// </summary>
            public const int Cyan = 530;

            /// <summary>
            /// = 531
            /// </summary>
            public const int Blue = 531;

            /// <summary>
            /// = 532
            /// </summary>
            public const int Red = 532;
        }

        /// <summary>
        /// BG
        /// </summary>
        public static class Canvas
        {
            /// <summary>
            /// = 533
            /// </summary>
            public const int Red = 533;

            /// <summary>
            /// = 534
            /// </summary>
            public const int Brown = 534;

            /// <summary>
            /// = 535
            /// </summary>
            public const int Yellow = 535;

            /// <summary>
            /// = 536
            /// </summary>
            public const int Green = 536;

            /// <summary>
            /// = 537
            /// </summary>
            public const int Blue = 537;

            /// <summary>
            /// = 538
            /// </summary>
            public const int Gray = 538;
        }

        /// <summary>
        /// BG
        /// </summary>
        public static class Carnival
        {
            /// <summary>
            /// = 545
            /// </summary>
            public const int RedYellowStripes = 545;

            /// <summary>
            /// = 546
            /// </summary>
            public const int PurpleBlueStripes = 546;

            /// <summary>
            /// = 547
            /// </summary>
            public const int Pink = 547;

            /// <summary>
            /// = 548
            /// </summary>
            public const int Checkered = 548;

            /// <summary>
            /// = 549
            /// </summary>
            public const int Green = 549;
        }

        /// <summary>
        /// BG
        /// </summary>
        public static class Normal
        {
            /// <summary>
            /// = 610
            /// </summary>
            public const int Gray = 610;

            /// <summary>
            /// = 611
            /// </summary>
            public const int Blue = 611;

            /// <summary>
            /// = 612
            /// </summary>
            public const int Magenta = 612;

            /// <summary>
            /// = 613
            /// </summary>
            public const int Red = 613;

            /// <summary>
            /// = 614
            /// </summary>
            public const int Yellow = 614;

            /// <summary>
            /// = 615
            /// </summary>
            public const int Green = 615;

            /// <summary>
            /// = 616
            /// </summary>
            public const int Cyan = 616;
        }

        /// <summary>
        /// Returns the layer of the block.
        /// Returns 0 for foreground.
        /// Returns 1 for background.
        /// Note: if BlockID = 0, this function will return 0.
        /// </summary>
        /// <param name="BlockID">The ID number of the block.</param>
        /// <returns>The layer of the block.</returns>
        public static int Layer(int BlockID)
        {
            return (BlockID < 500) ? 0 : 1;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public static class PortalRotation
    {
        /// <summary>
        /// = 1
        /// </summary>
        public const int Left = 1;

        /// <summary>
        /// = 3
        /// </summary>
        public const int Right = 3;

        /// <summary>
        /// = 2
        /// </summary>
        public const int Up = 2;

        /// <summary>
        /// = 0
        /// </summary>
        public const int Down = 0;
    }

    /// <summary>
    /// 
    /// </summary>
    public static class PianoNotes
    {
        /// <summary>
        /// = 0
        /// </summary>
        public const int C3 = 0;

        /// <summary>
        /// = 1
        /// </summary>
        public const int Db3 = 1;

        /// <summary>
        /// = 2
        /// </summary>
        public const int D3 = 2;

        /// <summary>
        /// = 3
        /// </summary>
        public const int Eb3 = 3;

        /// <summary>
        /// = 4
        /// </summary>
        public const int E3 = 4;

        /// <summary>
        /// = 5
        /// </summary>
        public const int F3 = 5;

        /// <summary>
        /// = 6
        /// </summary>
        public const int Gb3 = 6;

        /// <summary>
        /// = 7
        /// </summary>
        public const int G3 = 7;

        /// <summary>
        /// = 8
        /// </summary>
        public const int Ab3 = 8;

        /// <summary>
        /// = 9
        /// </summary>
        public const int A3 = 9;

        /// <summary>
        /// = 10
        /// </summary>
        public const int Bb3 = 10;

        /// <summary>
        /// = 11
        /// </summary>
        public const int B3 = 11;

        /// <summary>
        /// = 12
        /// </summary>
        public const int C4 = 12;

        /// <summary>
        /// = 13
        /// </summary>
        public const int Db4 = 13;

        /// <summary>
        /// = 14
        /// </summary>
        public const int D4 = 14;

        /// <summary>
        /// = 15
        /// </summary>
        public const int Eb4 = 15;

        /// <summary>
        /// = 16
        /// </summary>
        public const int E4 = 16;

        /// <summary>
        /// = 17
        /// </summary>
        public const int F4 = 17;

        /// <summary>
        /// = 18
        /// </summary>
        public const int Gb4 = 18;

        /// <summary>
        /// = 19
        /// </summary>
        public const int G4 = 19;

        /// <summary>
        /// = 20
        /// </summary>
        public const int Ab4 = 20;

        /// <summary>
        /// = 21
        /// </summary>
        public const int A4 = 21;

        /// <summary>
        /// = 22
        /// </summary>
        public const int Bb4 = 22;

        /// <summary>
        /// = 23
        /// </summary>
        public const int B4 = 23;

        /// <summary>
        /// = 24
        /// </summary>
        public const int C5 = 24;
    }

    /// <summary>
    /// 
    /// </summary>
    public static class DrumHits
    {
        /// <summary>
        /// = 0
        /// </summary>
        public const int BassHit = 0;

        /// <summary>
        /// = 1
        /// </summary>
        public const int BassHitCymbalSoft = 1;

        /// <summary>
        /// = 2
        /// </summary>
        public const int SnareHitHard = 2;

        /// <summary>
        /// = 3
        /// </summary>
        public const int SnareHitSoft = 3;

        /// <summary>
        /// = 4
        /// </summary>
        public const int HiHatCymbalSoft = 4;

        /// <summary>
        /// = 5
        /// </summary>
        public const int HiHatCymbalHard = 5;

        /// <summary>
        /// = 6
        /// </summary>
        public const int HiHatCymbalRing = 6;

        /// <summary>
        /// = 7
        /// </summary>
        public const int Clap = 7;

        /// <summary>
        /// = 8
        /// </summary>
        public const int CrashCymbal = 8;

        /// <summary>
        /// = 9
        /// </summary>
        public const int Maraca = 9;
    }

    /// <summary>
    /// A class containing the ID numbers for all smilies.
    /// </summary>
    public static class Smileys
    {
        /// <summary>
        /// = 0
        /// </summary>
        public const int Smiley = 0;

        /// <summary>
        /// = 1
        /// </summary>
        public const int Grin = 1;

        /// <summary>
        /// = 2
        /// </summary>
        public const int Tongue = 2;

        /// <summary>
        /// = 3
        /// </summary>
        public const int Happy = 3;

        /// <summary>
        /// = 4
        /// </summary>
        public const int Annoyed = 4;

        /// <summary>
        /// = 5
        /// </summary>
        public const int Sad = 5;

        /// <summary>
        /// = 6
        /// </summary>
        public const int Crying = 6;

        /// <summary>
        /// = 7
        /// </summary>
        public const int Wink = 7;

        /// <summary>
        /// = 8
        /// </summary>
        public const int Frustrated = 8;

        /// <summary>
        /// = 9
        /// </summary>
        public const int Shades = 9;

        /// <summary>
        /// = 10
        /// </summary>
        public const int Devil = 10;

        /// <summary>
        /// = 11
        /// </summary>
        public const int Inquisitive = 11;

        /// <summary>
        /// = 12
        /// </summary>
        public const int Ninja = 12;

        /// <summary>
        /// = 13
        /// </summary>
        public const int Santa = 13;

        /// <summary>
        /// = 14
        /// </summary>
        public const int Worker = 14;

        /// <summary>
        /// = 15
        /// </summary>
        public const int BigSpender = 15;

        /// <summary>
        /// = 16
        /// </summary>
        public const int Superman = 16;

        /// <summary>
        /// = 17
        /// </summary>
        public const int Surprise = 17;

        /// <summary>
        /// = 18
        /// </summary>
        public const int Indifferent = 18;

        /// <summary>
        /// = 19
        /// </summary>
        public const int Girl = 19;

        /// <summary>
        /// = 20
        /// </summary>
        public const int NewYear2010 = 20;

        /// <summary>
        /// = 21
        /// </summary>
        public const int Coy = 21;

        /// <summary>
        /// = 22
        /// </summary>
        public const int Wizard = 22;

        /// <summary>
        /// = 23
        /// </summary>
        public const int FanBoy = 23;

        /// <summary>
        /// = 24
        /// </summary>
        public const int Terminator = 24;

        /// <summary>
        /// = 25
        /// </summary>
        public const int ExtraGrin = 25;

        /// <summary>
        /// = 26
        /// </summary>
        public const int Bully = 26;

        /// <summary>
        /// = 27
        /// </summary>
        public const int Commando = 27;

        /// <summary>
        /// = 28
        /// </summary>
        public const int Kissing = 28;

        /// <summary>
        /// = 29
        /// </summary>
        public const int Bird = 29;

        /// <summary>
        /// = 30
        /// </summary>
        public const int Bunny = 30;

        /// <summary>
        /// = 31
        /// </summary>
        public const int Diamond = 31;

        /// <summary>
        /// = 32
        /// </summary>
        public const int FireWizard = 32;

        /// <summary>
        /// = 33
        /// </summary>
        public const int ExtraTongue = 33;

        /// <summary>
        /// = 34
        /// </summary>
        public const int Postman = 34;

        /// <summary>
        /// = 35
        /// </summary>
        public const int Templar = 35;

        /// <summary>
        /// = 36
        /// </summary>
        public const int Angel = 36;

        /// <summary>
        /// = 36
        /// </summary>
        public const int Nurse = 37;

        /// <summary>
        /// = 37
        /// </summary>
        public const int Vampire = 38;

        /// <summary>
        /// = 38
        /// </summary>
        public const int Ghost = 39;

        /// <summary>
        /// = 39
        /// </summary>
        public const int Frankenstein = 40;

        /// <summary>
        /// = 41
        /// </summary>
        public const int Witch = 41;

        /// <summary>
        /// = 42
        /// </summary>
        public const int Indian = 42;

        /// <summary>
        /// = 43
        /// </summary>
        public const int Pilgrim = 43;

        /// <summary>
        /// = 44
        /// </summary>
        public const int Pumpkin = 44;

        /// <summary>
        /// = 45
        /// </summary>
        public const int LitPumpkin = 45;

        /// <summary>
        /// = 46
        /// </summary>
        public const int Snowman = 46;

        /// <summary>
        /// = 47
        /// </summary>
        public const int Reindeer = 47;

        /// <summary>
        /// = 48
        /// </summary>
        public const int Grinch = 48;

        /// <summary>
        /// = 49
        /// </summary>
        public const int Maestro = 49;

        /// <summary>
        /// = 50
        /// </summary>
        public const int DJ = 50;

        /// <summary>
        /// = 51
        /// </summary>
        public const int Sigh = 51;

        /// <summary>
        /// = 52
        /// </summary>
        public const int Robber = 52;

        /// <summary>
        /// = 53
        /// </summary>
        public const int Police = 53;

        /// <summary>
        /// = 54
        /// </summary>
        public const int UpsideDown = 54;

        /// <summary>
        /// = 54
        /// </summary>
        public const int RedNinja = 54;

        /// <summary>
        /// = 54
        /// </summary>
        public const int PacManGhost = 54;

        /// <summary>
        /// = 55
        /// </summary>
        public const int Pirate = 55;

        /// <summary>
        /// = 56
        /// </summary>
        public const int Viking = 56;

        /// <summary>
        /// = 57
        /// </summary>
        public const int Karate = 57;

        /// <summary>
        /// = 58
        /// </summary>
        public const int Cowboy = 58;

        /// <summary>
        /// = 59
        /// </summary>
        public const int Diver = 59;

        /// <summary>
        /// = 60
        /// </summary>
        public const int Tanned = 60;

        /// <summary>
        /// = 61
        /// </summary>
        public const int Propleller = 61;

        /// <summary>
        /// = 62
        /// </summary>
        public const int HardHat = 62;

        /// <summary>
        /// = 63
        /// </summary>
        public const int Gasmask = 63;

        /// <summary>
        /// = 64
        /// </summary>
        public const int Robot = 64;

        /// <summary>
        /// = 65
        /// </summary>
        public const int Peasant = 65;

        /// <summary>
        /// = 66
        /// </summary>
        public const int Soldier = 66;

        /// <summary>
        /// = 67
        /// </summary>
        public const int Blacksmith = 67;

        /// <summary>
        /// = 68
        /// </summary>
        public const int Lol = 68;

        /// <summary>
        /// = 69
        /// </summary>
        public const int Laika = 69;

        /// <summary>
        /// = 70
        /// </summary>
        public const int Alien = 70;

        /// <summary>
        /// = 71
        /// </summary>
        public const int Astronaut = 71;

        /// <summary>
        /// = 72
        /// </summary>
        public const int PartyHappy = 72;

        /// <summary>
        /// = 73
        /// </summary>
        public const int PartySmiley = 73;

        /// <summary>
        /// = 74
        /// </summary>
        public const int PartyGrin = 74;

        /// <summary>
        /// = 75
        /// </summary>
        public const int PartyTongue = 75;

        /// <summary>
        /// = 76
        /// </summary>
        public const int Cannonball = 76;

        /// <summary>
        /// = 77
        /// </summary>
        public const int Monster = 77;

        /// <summary>
        /// = 78
        /// </summary>
        public const int Skeleton = 78;

        /// <summary>
        /// = 79
        /// </summary>
        public const int MadScientist = 79;
    }

    /// <summary>
    /// A class containing the ID numbers for quick-chat.
    /// </summary>
    public static class QuickChats
    {
        /// <summary>
        /// = 1
        /// </summary>
        public const int Hi = 1;

        /// <summary>
        /// = 2
        /// </summary>
        public const int Bye = 2;

        /// <summary>
        /// = 3
        /// </summary>
        public const int Help = 3;

        /// <summary>
        /// = 4
        /// </summary>
        public const int Thanks = 4;

        /// <summary>
        /// = 5
        /// </summary>
        public const int Come = 5;

        /// <summary>
        /// = 6
        /// </summary>
        public const int Stop = 6;

        /// <summary>
        /// = 7
        /// </summary>
        public const int Yes = 7;

        /// <summary>
        /// = 8
        /// </summary>
        public const int No = 8;

        /// <summary>
        /// = 9
        /// </summary>
        public const int Right = 9;

        /// <summary>
        /// = 0
        /// </summary>
        public const int Left = 0;
    }

    /// <summary>
    /// A class containing the ID numbers for potions.
    /// </summary>
    public static class Potions
    {
        /// <summary>
        /// = 1
        /// </summary>
        public const int Blue = 1;

        /// <summary>
        /// = 2
        /// </summary>
        public const int Yellow = 2;

        /// <summary>
        /// = 3
        /// </summary>
        public const int Red = 3;

        /// <summary>
        /// = 4
        /// </summary>
        public const int Jump = 4;
    }
}
