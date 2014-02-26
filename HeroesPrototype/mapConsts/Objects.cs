﻿using System;
using System.Drawing;

namespace HeroesPrototype.MapConsts
{
    public static class Objects
    {
        // Terrain and map objects instantiated from files
        public static readonly Bitmap TerrainDefault = new Bitmap(Bitmap.FromFile(@"..\..\sprites\mapobj\Terrain\TerrainDefault.png"));
        public static readonly Bitmap TerrainBlack = new Bitmap(Bitmap.FromFile(@"..\..\sprites\mapobj\Terrain\TerrainBlack.png"));
        public static readonly Bitmap TerrainCastle = new Bitmap(Bitmap.FromFile(@"..\..\sprites\mapobj\Terrain\TerrainCastle.png"));
        public static readonly Bitmap TerrainInferno = new Bitmap(Bitmap.FromFile(@"..\..\sprites\mapobj\Terrain\TerrainInferno.png"));
        public static readonly Bitmap TerrainMixed1 = new Bitmap(Bitmap.FromFile(@"..\..\sprites\mapobj\Terrain\TerrainMixed1.png"));
        public static readonly Bitmap TerrainMixed2 = new Bitmap(Bitmap.FromFile(@"..\..\sprites\mapobj\Terrain\TerrainMixed2.png"));
        public static readonly Bitmap CastleTopLeft = new Bitmap(Bitmap.FromFile(@"..\..\sprites\mapobj\Castle\CAS_TL.png"));
        public static readonly Bitmap CastleTopCenter = new Bitmap(Bitmap.FromFile(@"..\..\sprites\mapobj\Castle\CAS_TC.png"));
        public static readonly Bitmap CastleTopRight = new Bitmap(Bitmap.FromFile(@"..\..\sprites\mapobj\Castle\CAS_TR.png"));
        public static readonly Bitmap CastleBotLeft = new Bitmap(Bitmap.FromFile(@"..\..\sprites\mapobj\Castle\CAS_BL.png"));
        public static readonly Bitmap CastleBotCenter = new Bitmap(Bitmap.FromFile(@"..\..\sprites\mapobj\Castle\CAS_BC.png"));
        public static readonly Bitmap CastleBotRight = new Bitmap(Bitmap.FromFile(@"..\..\sprites\mapobj\Castle\CAS_BR.png"));
        public static readonly Bitmap InfernoTopLeft = new Bitmap(Bitmap.FromFile(@"..\..\sprites\mapobj\Inferno\INF_TL.png"));
        public static readonly Bitmap InfernoTopCenter = new Bitmap(Bitmap.FromFile(@"..\..\sprites\mapobj\Inferno\INF_TC.png"));
        public static readonly Bitmap InfernoTopRight = new Bitmap(Bitmap.FromFile(@"..\..\sprites\mapobj\Inferno\INF_TR.png"));
        public static readonly Bitmap InfernoBotLeft = new Bitmap(Bitmap.FromFile(@"..\..\sprites\mapobj\Inferno\INF_BL.png"));
        public static readonly Bitmap InfernoBotCenter = new Bitmap(Bitmap.FromFile(@"..\..\sprites\mapobj\Inferno\INF_BC.png"));
        public static readonly Bitmap InfernoBotRight = new Bitmap(Bitmap.FromFile(@"..\..\sprites\mapobj\Inferno\INF_BR.png"));
        public static readonly Bitmap Forest = new Bitmap(Bitmap.FromFile(@"..\..\sprites\mapobj\Terrain\Forest.png"));
        public static readonly Bitmap Mountain = new Bitmap(Bitmap.FromFile(@"..\..\sprites\mapobj\Terrain\Mountain.png"));
        // resources
        public static readonly Bitmap TreasureChest = new Bitmap(Bitmap.FromFile(@"..\..\sprites\mapobj\Resources\TreasureChest.png"));
        public static readonly Bitmap GoldPile = new Bitmap(Bitmap.FromFile(@"..\..\sprites\mapobj\Resources\Gold.png"));
        public static readonly Bitmap CampFire = new Bitmap(Bitmap.FromFile(@"..\..\sprites\mapobj\Resources\CampFire.png"));
        public static readonly Bitmap WoodPile = new Bitmap(Bitmap.FromFile(@"..\..\sprites\mapobj\Resources\WoodPile.png"));
        public static readonly Bitmap OrePile = new Bitmap(Bitmap.FromFile(@"..\..\sprites\mapobj\Resources\OrePile.png"));
        // Items
        public static readonly Bitmap Staff = new Bitmap(Bitmap.FromFile(@"..\..\sprites\items\staff.png"));
        public static readonly Bitmap Sword = new Bitmap(Bitmap.FromFile(@"..\..\sprites\items\sword.png"));
        public static readonly Bitmap HeavyArmor = new Bitmap(Bitmap.FromFile(@"..\..\sprites\items\heavyArmor.png"));
        public static readonly Bitmap Shield = new Bitmap(Bitmap.FromFile(@"..\..\sprites\items\shield.png"));
        public static readonly Bitmap Helm = new Bitmap(Bitmap.FromFile(@"..\..\sprites\items\helm.png"));
        public static readonly Bitmap Axe = new Bitmap(Bitmap.FromFile(@"..\..\sprites\items\axe.bmp"));
        //Units
        public static readonly Bitmap Imp = new Bitmap(Bitmap.FromFile(@"..\..\sprites\units\Imp.png"));
        public static readonly Bitmap Magog = new Bitmap(Bitmap.FromFile(@"..\..\sprites\units\Magog.png"));
        public static readonly Bitmap Devil = new Bitmap(Bitmap.FromFile(@"..\..\sprites\units\Devil.png"));
        public static readonly Bitmap Angel = new Bitmap(Bitmap.FromFile(@"..\..\sprites\units\Angel.png"));
        public static readonly Bitmap Marksman = new Bitmap(Bitmap.FromFile(@"..\..\sprites\units\Marksman.png"));
        public static readonly Bitmap Pikeman = new Bitmap(Bitmap.FromFile(@"..\..\sprites\units\Pikeman.png"));
    }
}