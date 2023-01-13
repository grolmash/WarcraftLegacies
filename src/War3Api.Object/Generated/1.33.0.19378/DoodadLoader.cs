using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using War3Api.Object.Abilities;
using War3Api.Object.Enums;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object
{
    internal class DoodadLoader
    {
        protected virtual Doodad LoadMushrooms_APms(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Mushrooms_APms, db);
            doodad.TextName = "Mushrooms";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "A,G";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadHollowStump_AOhs(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.HollowStump_AOhs, db);
            doodad.TextName = "Stump Hollow";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "A";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadThornyVines_APtv(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.ThornyVines_APtv, db);
            doodad.TextName = "Vines Thorny";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "C";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadCattail_APct(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Cattail_APct, db);
            doodad.TextName = "Cattail";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "A,L,F,W,Y,X,V,Q,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 0;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadBirds(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Birds, db);
            doodad.TextName = "Birds";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 1;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 0;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadSkullBrazier(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.SkullBrazier, db);
            doodad.TextName = "Brazier Skull";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "C,D,G";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadFish(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Fish, db);
            doodad.TextName = "Fish";
            doodad.EditorCategoryRaw = "W";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 0;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadGuardianStatueOfAszune(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.GuardianStatueOfAszune, db);
            doodad.TextName = "Statue Guardian of Aszune";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "A";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\8x8Cross.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadKeeperStatue(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.KeeperStatue, db);
            doodad.TextName = "Statue Keeper";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "A";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\8x8Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadStraightLog_AOlg(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.StraightLog_AOlg, db);
            doodad.TextName = "Log Straight";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "A";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\12x6Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadAngledLog_AOla(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.AngledLog_AOla, db);
            doodad.TextName = "Log Angled";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "A";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\Log45.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadGlowingObelisk(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.GlowingObelisk, db);
            doodad.TextName = "Obelisk Glowing";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "C,O,K";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadObelisk_AOsk(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Obelisk_AOsk, db);
            doodad.TextName = "Obelisk";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "A";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadBrokenObelisk_AObo(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.BrokenObelisk_AObo, db);
            doodad.TextName = "Obelisk Broken";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "A";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadScorchedRemains(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.ScorchedRemains, db);
            doodad.TextName = "Remains Scorched";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 1;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadBush_APbs(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Bush_APbs, db);
            doodad.TextName = "Bush";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "A";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadLilyPads(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.LilyPads, db);
            doodad.TextName = "Lily Pads";
            doodad.EditorCategoryRaw = "W";
            doodad.EditorTilesetsRaw = "A";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 1;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadFloatingLilyPads_AWfl(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.FloatingLilyPads_AWfl, db);
            doodad.TextName = "Lily Pads Floating";
            doodad.EditorCategoryRaw = "W";
            doodad.EditorTilesetsRaw = "A";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 1;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRocks_ARrk(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Rocks_ARrk, db);
            doodad.TextName = "Rocks";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "A";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadBrokenColumn_ASbc(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.BrokenColumn_ASbc, db);
            doodad.TextName = "Broken Column";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "A";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadBlackRuinedRubble_ASbr(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.BlackRuinedRubble_ASbr, db);
            doodad.TextName = "Rubble";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "A";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRuinedBlocks_ASHB(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RuinedBlocks_ASHB, db);
            doodad.TextName = "Blocks Ruined";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "A";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\6x6Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadArchway_ASra(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Archway_ASra, db);
            doodad.TextName = "Rock Archway";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "A";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityArch.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadArchway_ASr1(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Archway_ASr1, db);
            doodad.TextName = "Rock Archway Diagonal";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "A";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityArch45.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadWorldTree(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.WorldTree, db);
            doodad.TextName = "World Tree";
            doodad.EditorCategoryRaw = "Z";
            doodad.EditorTilesetsRaw = "A";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 0;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\24x24Unflyable.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadCactus(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Cactus, db);
            doodad.TextName = "Cactus";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "B";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadBones_BObo(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Bones_BObo, db);
            doodad.TextName = "Bones";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "B,O,K";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Unbuildable.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadTotem_BOct(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Totem_BOct, db);
            doodad.TextName = "Totem Centaur";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "B";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadThrone_BOth(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Throne_BOth, db);
            doodad.TextName = "Throne";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "B";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 1;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadTotem_BOtt(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Totem_BOtt, db);
            doodad.TextName = "Totem Tauren";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "B";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadCrater(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Crater, db);
            doodad.TextName = "Crater";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "B";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\12x12Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadFissure_BRfs(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Fissure_BRfs, db);
            doodad.TextName = "Fissure";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "B";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\8x8Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRocks_BRrk(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Rocks_BRrk, db);
            doodad.TextName = "Rocks";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "B";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadPillarOfRock(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.PillarOfRock, db);
            doodad.TextName = "Rock Pillar";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "B";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRockSpires_BRrs(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RockSpires_BRrs, db);
            doodad.TextName = "Rock Spires";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "B";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\LargeRockSpire.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRockSpiresCinematic(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RockSpiresCinematic, db);
            doodad.TextName = "Rock Spires (Cinematic)";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "B";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\LargeRockSpire.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadSmallRockSpires_BRsp(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.SmallRockSpires_BRsp, db);
            doodad.TextName = "Rock Spires Small";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "B";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadGeyser(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Geyser, db);
            doodad.TextName = "Geyser";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "B";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRuinedArch(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RuinedArch, db);
            doodad.TextName = "Ruined Arch";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "B";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadArchway_BSra(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Archway_BSra, db);
            doodad.TextName = "Rock Archway";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "B";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityArch.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadArchway_BSr1(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Archway_BSr1, db);
            doodad.TextName = "Rock Archway Diagonal";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "B";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityArch45.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRuinedChunk(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RuinedChunk, db);
            doodad.TextName = "Ruined Chunk";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "B";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRuinedCurvedWall(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RuinedCurvedWall, db);
            doodad.TextName = "Ruined Curved Wall";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "B";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x8Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRuinedWall(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RuinedWall, db);
            doodad.TextName = "Ruined Wall";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "B";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadBlightedMist(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.BlightedMist, db);
            doodad.TextName = "Blighted Mist";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "C";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 1;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 0;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadHollowStump_COhs(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.HollowStump_COhs, db);
            doodad.TextName = "Stump Hollow";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "C";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadStraightLog_COlg(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.StraightLog_COlg, db);
            doodad.TextName = "Log Straight";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "C";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\12x6Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadAngledLog_COla(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.AngledLog_COla, db);
            doodad.TextName = "Log Angled";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "C";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\12x6Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadObelisk_COob(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Obelisk_COob, db);
            doodad.TextName = "Obelisk";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "C";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadBrokenObelisk_CObo(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.BrokenObelisk_CObo, db);
            doodad.TextName = "Obelisk Broken";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "C";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadBush_CPbs(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Bush_CPbs, db);
            doodad.TextName = "Bush";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "C";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadCattail_CPct(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Cattail_CPct, db);
            doodad.TextName = "Cattail";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "C";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadMushrooms_CPms(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Mushrooms_CPms, db);
            doodad.TextName = "Mushrooms";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "C";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadLilyPad(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.LilyPad, db);
            doodad.TextName = "Lily Pad";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "C";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 1;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadFissure_CRfs(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Fissure_CRfs, db);
            doodad.TextName = "Fissure";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "C";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\8x8Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRockSpires_CRrs(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RockSpires_CRrs, db);
            doodad.TextName = "Rock Spires";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "C";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\LargeRockSpire.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadBrokenColumn_CSbc(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.BrokenColumn_CSbc, db);
            doodad.TextName = "Broken Column";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "C";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadBlackRuinedRubble_CSbr(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.BlackRuinedRubble_CSbr, db);
            doodad.TextName = "Rubble";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "C";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRuinedBlocks_CSbl(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RuinedBlocks_CSbl, db);
            doodad.TextName = "Blocks Ruined";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "C";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\6x6Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadArchway_CSra(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Archway_CSra, db);
            doodad.TextName = "Archway";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "C";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityArch.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadAngledArchway_CSr1(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.AngledArchway_CSr1, db);
            doodad.TextName = "Archway Angled";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "C";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityArch45.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadCorn(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Corn, db);
            doodad.TextName = "Corn";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "L,F,W,V,Q";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadFloatingLilyPads_LPfp(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.FloatingLilyPads_LPfp, db);
            doodad.TextName = "Lily Pads Floating";
            doodad.EditorCategoryRaw = "W";
            doodad.EditorTilesetsRaw = "L,F,W,V,Q";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 1;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadLillyPad(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.LillyPad, db);
            doodad.TextName = "Lily Pad";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "L,F,W,V,Q";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 1;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRiverRushes(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RiverRushes, db);
            doodad.TextName = "River Rushes";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "L,F,W,V,Q";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadWheatBunch(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.WheatBunch, db);
            doodad.TextName = "Wheat Bunch";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "L,F,W,V,Q";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadWheat(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Wheat, db);
            doodad.TextName = "Wheat";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "L,F,W,V,Q";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadScorchedGrain(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.ScorchedGrain, db);
            doodad.TextName = "Grain Scorched";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "L,F,W,V,Q";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadArcheryTarget(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.ArcheryTarget, db);
            doodad.TextName = "Archery Target";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "L,F,W,V,Q";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadArmorRack(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.ArmorRack, db);
            doodad.TextName = "Rack Armor";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadHumanBanner(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.HumanBanner, db);
            doodad.TextName = "Banner Human";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "L,F,W,V,Q";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadOrcBanner(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.OrcBanner, db);
            doodad.TextName = "Banner Orc";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "L,F,W,V,Q";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadTutorialOrcBanner(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.TutorialOrcBanner, db);
            doodad.TextName = "Banner Tutorial Orc";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "L,F,W,V,Q";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadBrazier(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Brazier, db);
            doodad.TextName = "Brazier";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadGlowingBrazier(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.GlowingBrazier, db);
            doodad.TextName = "Brazier Glowing";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadEmptyCage_LOce(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.EmptyCage_LOce, db);
            doodad.TextName = "Cage Empty";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadCauldronWithHeads(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.CauldronWithHeads, db);
            doodad.TextName = "Cauldron with heads";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadEmptyCage_LOct(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.EmptyCage_LOct, db);
            doodad.TextName = "Cage Trashed";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadFlies(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Flies, db);
            doodad.TextName = "Flies";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 1;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 0;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadGrave_LOgr(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Grave_LOgr, db);
            doodad.TextName = "Grave";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadHay(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Hay, db);
            doodad.TextName = "Hay";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "L,F,W,V,Q";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadHayCart(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.HayCart, db);
            doodad.TextName = "Hay Cart";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "L,F,W,V,Q";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x2Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadBrokenHayCart(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.BrokenHayCart, db);
            doodad.TextName = "Hay Cart Broken";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "L,F,W,V,Q";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadHayCartInfected(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.HayCartInfected, db);
            doodad.TextName = "Hay Cart (Infected)";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "L,F,W,V,Q";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x2Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadBrokenHayCartInfected(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.BrokenHayCartInfected, db);
            doodad.TextName = "Hay Cart Broken (Infected)";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "L,F,W,V,Q";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadHayClump(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.HayClump, db);
            doodad.TextName = "Hay Clump";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "L,F,W,V,Q";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadHeadOnSpear(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.HeadOnSpear, db);
            doodad.TextName = "Head on Spear";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadHitchingPost(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.HitchingPost, db);
            doodad.TextName = "Post Hitching";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadImpaledCorpse(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.ImpaledCorpse, db);
            doodad.TextName = "Corpse Impaled";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadLanternPost_LOlp(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.LanternPost_LOlp, db);
            doodad.TextName = "Post Lantern";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "L,F,W,V,Q";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadPeasantGrave(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.PeasantGrave, db);
            doodad.TextName = "Grave Peasant";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRibBones(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RibBones, db);
            doodad.TextName = "Bones Rib";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "L,F,W,V,Q";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadHayInfected(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.HayInfected, db);
            doodad.TextName = "Hay (Infected)";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "L,F,W,V,Q";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadSignPost(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.SignPost, db);
            doodad.TextName = "Post Sign";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadSittingCorpse(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.SittingCorpse, db);
            doodad.TextName = "Corpse Sitting";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadSkullsOnStick(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.SkullsOnStick, db);
            doodad.TextName = "Skulls on Sticks";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadSkullPile(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.SkullPile, db);
            doodad.TextName = "Skull Pile";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadSmokeSmudge(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.SmokeSmudge, db);
            doodad.TextName = "Smoke Smudge";
            doodad.EditorCategoryRaw = "Z";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 0;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadStoneWall(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.StoneWall, db);
            doodad.TextName = "Wall Stone";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "L,F,W,V,Q";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadTorch(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Torch, db);
            doodad.TextName = "Torch";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadGlowingTorch(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.GlowingTorch, db);
            doodad.TextName = "Torch Glowing";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadTrash_LOt1(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Trash_LOt1, db);
            doodad.TextName = "Trash";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadTrough(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Trough, db);
            doodad.TextName = "Trough";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x2Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadWheelbarrel(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Wheelbarrel, db);
            doodad.TextName = "Wheelbarrow";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x2Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadBrokenWheelbarrel(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.BrokenWheelbarrel, db);
            doodad.TextName = "Wheelbarrow Broken";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadWeaponRack(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.WeaponRack, db);
            doodad.TextName = "Rack Weapon";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRocks_LRrk(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Rocks_LRrk, db);
            doodad.TextName = "Rocks";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "L,F,W,Y,X,V,Q,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadBarn(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Barn, db);
            doodad.TextName = "Barn";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "L,F,W,V,Q";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityBuilding0-2.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadElvenBuilding(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.ElvenBuilding, db);
            doodad.TextName = "Elven Building";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "L,F,W,V,Q";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 0;
            doodad.EditorPlaceableOnWaterRaw = 0;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\6x6Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadScorchedBarn(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.ScorchedBarn, db);
            doodad.TextName = "Barn Scorched";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "L,F,W,V,Q";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityBuilding0-2.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadScorchedFarm(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.ScorchedFarm, db);
            doodad.TextName = "Farm Scorched";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "L,F,W,V,Q";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\6x6Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadGranary(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Granary, db);
            doodad.TextName = "Granary";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "L,F,W,V,Q";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\8x6Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadScorchedGranary(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.ScorchedGranary, db);
            doodad.TextName = "Granary Scorched";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "L,F,W,V,Q";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\8x6Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadInn(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Inn, db);
            doodad.TextName = "Inn";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "L,F,W,V,Q";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityBuilding0-2.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRockArchway_LSra(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RockArchway_LSra, db);
            doodad.TextName = "Rock Archway";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "L,F,W,Y,X,V,Q,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityArch.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadAngledRockArchway_LSr1(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.AngledRockArchway_LSr1, db);
            doodad.TextName = "Rock Archway Diagonal";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "L,F,W,Y,X,V,Q,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityArch45.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadScorchedInn(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.ScorchedInn, db);
            doodad.TextName = "Inn Scorched";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "L,F,W,V,Q";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityBuilding0-2.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadScorchedTower(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.ScorchedTower, db);
            doodad.TextName = "Tower Scorched";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "L,F,W,V,Q";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x6Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadWell(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Well, db);
            doodad.TextName = "Well";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "L,F,W,V,Q";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadBurnedWindMill(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.BurnedWindMill, db);
            doodad.TextName = "Windmill Burned";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "L,F,W,V,Q";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\6x8Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadWindMill(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.WindMill, db);
            doodad.TextName = "Windmill";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "L,F,W,V,Q";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 1;
            doodad.PathingPathingTextureRaw = "PathTextures\\6x8Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadBrokenColumn_NObc(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.BrokenColumn_NObc, db);
            doodad.TextName = "Column Broken";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "N";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadBrokenObelisk_NObk(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.BrokenObelisk_NObk, db);
            doodad.TextName = "Obelisk Broken";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "N";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 0;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadBones_NObo(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Bones_NObo, db);
            doodad.TextName = "Bones";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "N,I";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Unbuildable.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadFence(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Fence, db);
            doodad.TextName = "Fence";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "N,I";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\8x2Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadAngledFence(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.AngledFence, db);
            doodad.TextName = "Fence Angled";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "N,I";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\Fence45.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadStoneGrave(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.StoneGrave, db);
            doodad.TextName = "Grave Stone";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "N";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 0;
            doodad.EditorPlaceableOnWaterRaw = 0;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadObelisk_NOok(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Obelisk_NOok, db);
            doodad.TextName = "Obelisk";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "N";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 0;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadTombstone(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Tombstone, db);
            doodad.TextName = "Tombstone";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "N";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 0;
            doodad.EditorPlaceableOnWaterRaw = 0;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadFloatingBox(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.FloatingBox, db);
            doodad.TextName = "Floating Box";
            doodad.EditorCategoryRaw = "W";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 1;
            doodad.ArtShowInFogRaw = 0;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadFloatingPlank(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.FloatingPlank, db);
            doodad.TextName = "Floating Plank";
            doodad.EditorCategoryRaw = "W";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 1;
            doodad.ArtShowInFogRaw = 0;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadIceFloe_NWf1(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.IceFloe_NWf1, db);
            doodad.TextName = "Ice Floe";
            doodad.EditorCategoryRaw = "W";
            doodad.EditorTilesetsRaw = "N,I";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 1;
            doodad.EditorPlaceableOnCliffsRaw = 0;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 1;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\8x8Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadIceFloe_NWf2(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.IceFloe_NWf2, db);
            doodad.TextName = "Ice Floe";
            doodad.EditorCategoryRaw = "W";
            doodad.EditorTilesetsRaw = "N,I";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 1;
            doodad.EditorPlaceableOnCliffsRaw = 0;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 1;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\8x8Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadIceFloe_NWf3(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.IceFloe_NWf3, db);
            doodad.TextName = "Ice Floe";
            doodad.EditorCategoryRaw = "W";
            doodad.EditorTilesetsRaw = "N,I";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 1;
            doodad.EditorPlaceableOnCliffsRaw = 0;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 1;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\8x8Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadIceFloe_NWf4(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.IceFloe_NWf4, db);
            doodad.TextName = "Ice Floe";
            doodad.EditorCategoryRaw = "W";
            doodad.EditorTilesetsRaw = "N,I";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 1;
            doodad.EditorPlaceableOnCliffsRaw = 0;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 1;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadIceberg_NWi1(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Iceberg_NWi1, db);
            doodad.TextName = "Iceberg";
            doodad.EditorCategoryRaw = "W";
            doodad.EditorTilesetsRaw = "N,I";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 1;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\8x8Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadIceberg_NWi2(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Iceberg_NWi2, db);
            doodad.TextName = "Iceberg";
            doodad.EditorCategoryRaw = "W";
            doodad.EditorTilesetsRaw = "N,I";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 1;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\8x8Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadIceberg_NWi3(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Iceberg_NWi3, db);
            doodad.TextName = "Iceberg";
            doodad.EditorCategoryRaw = "W";
            doodad.EditorTilesetsRaw = "N,I";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 1;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadIceberg_NWi4(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Iceberg_NWi4, db);
            doodad.TextName = "Iceberg";
            doodad.EditorCategoryRaw = "W";
            doodad.EditorTilesetsRaw = "N,I";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 1;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadFloatingPanel(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.FloatingPanel, db);
            doodad.TextName = "Floating Panel";
            doodad.EditorCategoryRaw = "W";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 1;
            doodad.ArtShowInFogRaw = 0;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadFirePit(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.FirePit, db);
            doodad.TextName = "Fire Pit";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadFirePitWPig(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.FirePitWPig, db);
            doodad.TextName = "Fire Pit with Pig";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadTrashedFirePit(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.TrashedFirePit, db);
            doodad.TextName = "Fire Pit Trashed";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadBats(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Bats, db);
            doodad.TextName = "Bats";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 1;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 0;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRowboat(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Rowboat, db);
            doodad.TextName = "Rowboat";
            doodad.EditorCategoryRaw = "W";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 1;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x8Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadDestroyedRowboat(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.DestroyedRowboat, db);
            doodad.TextName = "Rowboat Destroyed";
            doodad.EditorCategoryRaw = "W";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x8Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadShip(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Ship, db);
            doodad.TextName = "Ship";
            doodad.EditorCategoryRaw = "W";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 1;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\8x8Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadDestroyedShip(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.DestroyedShip, db);
            doodad.TextName = "Ship Destroyed";
            doodad.EditorCategoryRaw = "W";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\8x8Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadWhale(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Whale, db);
            doodad.TextName = "Whale";
            doodad.EditorCategoryRaw = "W";
            doodad.EditorTilesetsRaw = "L,F,W,N";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 1;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 0;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 0;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadThornyVines_NPth(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.ThornyVines_NPth, db);
            doodad.TextName = "Vines Thorny";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "N";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadFissure_NRfs(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Fissure_NRfs, db);
            doodad.TextName = "Fissure";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "N";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\8x8Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadIceClaws(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.IceClaws, db);
            doodad.TextName = "Ice Claws";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "N";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRocks_NRrk(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Rocks_NRrk, db);
            doodad.TextName = "Rocks";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "N";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadWebbedRocks(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.WebbedRocks, db);
            doodad.TextName = "Rocks Webbed";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "N,G";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\8x8Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadCrypt(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Crypt, db);
            doodad.TextName = "Crypt";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "N";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 0;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\8x8Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadArchway_NSra(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Archway_NSra, db);
            doodad.TextName = "Archway";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "N";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityArch.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadAngledArchway_NSr1(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.AngledArchway_NSr1, db);
            doodad.TextName = "Archway Angled";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "N";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityArch45.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRubble_NSrb(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Rubble_NSrb, db);
            doodad.TextName = "Rubble";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "N";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 0;
            doodad.EditorPlaceableOnWaterRaw = 0;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadLongFence(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.LongFence, db);
            doodad.TextName = "Fence Long";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "V,Q,L,F,W,Y,X,D,G,Z,I,O,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\8x2Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadAngledLongFence(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.AngledLongFence, db);
            doodad.TextName = "Fence Angled Long";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "V,Q,L,F,W,Y,X,D,G,Z,I,O,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\Fence135.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadShortFence(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.ShortFence, db);
            doodad.TextName = "Fence Short";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "V,Q,L,F,W,Y,X,D,G,Z,I,O,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x2Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadAngledShortFence(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.AngledShortFence, db);
            doodad.TextName = "Fence Angled Short";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "V,Q,L,F,W,Y,X,D,G,Z,I,O,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\ShortFence135.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadBuilding(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Building, db);
            doodad.TextName = "Building";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "V,Q,L,F,W,X,Y,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadLongBlueBanner(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.LongBlueBanner, db);
            doodad.TextName = "Banner Long Blue";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "Y";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 0;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadLongWhiteBanner(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.LongWhiteBanner, db);
            doodad.TextName = "Banner Long White";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "Y";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 0;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadStoneBench(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.StoneBench, db);
            doodad.TextName = "Bench Stone";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "Y,X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadAngledStoneBench(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.AngledStoneBench, db);
            doodad.TextName = "Bench Angled Stone";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "Y,X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadAlonsusChapel_YOsb(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.AlonsusChapel_YOsb, db);
            doodad.TextName = "Alonsus Chapel";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadAlonsusChapel_YOmb(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.AlonsusChapel_YOmb, db);
            doodad.TextName = "City Tower";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadClockTower(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.ClockTower, db);
            doodad.TextName = "Market Stall (Large)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadMarketStallSmall(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.MarketStallSmall, db);
            doodad.TextName = "Market Stall (Small)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadMarketItemBaubles(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.MarketItemBaubles, db);
            doodad.TextName = "Market Item Baubles";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadMarketItemBaublesAlt(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.MarketItemBaublesAlt, db);
            doodad.TextName = "Market Item Baubles (Alt)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadMarketItemProduce(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.MarketItemProduce, db);
            doodad.TextName = "Market Item Produce";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadMarketItemProduceAlt(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.MarketItemProduceAlt, db);
            doodad.TextName = "Market Item Produce (Alt)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadMarketItemTextiles(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.MarketItemTextiles, db);
            doodad.TextName = "Market Item Textiles";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadMarketItemTextilesAlt(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.MarketItemTextilesAlt, db);
            doodad.TextName = "Market Item Textiles (Alt)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadWoodBench(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.WoodBench, db);
            doodad.TextName = "Bench Wood";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "Y,X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadAngledWoodBench(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.AngledWoodBench, db);
            doodad.TextName = "Bench Angled Wood";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "Y,X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadFountain(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Fountain, db);
            doodad.TextName = "Fountain";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "Y,X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\8x8Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadGrave_YOgr(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Grave_YOgr, db);
            doodad.TextName = "Grave (Cityscape)";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "Y,X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 0;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadObelisk_YOob(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Obelisk_YOob, db);
            doodad.TextName = "Obelisk";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "Y,X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadLanternPost_YOlp(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.LanternPost_YOlp, db);
            doodad.TextName = "Post Lantern";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "Y,X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadStatue(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Statue, db);
            doodad.TextName = "Statue";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "Y,X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\8x8Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadShieldlessStatue(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.ShieldlessStatue, db);
            doodad.TextName = "Statue Shieldless";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "Y,X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\8x8Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadPowerGenerator(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.PowerGenerator, db);
            doodad.TextName = "Power Generator";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadMagicalLantern(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.MagicalLantern, db);
            doodad.TextName = "Magical Lantern";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadMagicalRunes(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.MagicalRunes, db);
            doodad.TextName = "Magical Runes";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\2x2Unbuildable.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadTavernSign(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.TavernSign, db);
            doodad.TextName = "Sign Tavern";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "Y,X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 0;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadBobSGunsSign(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.BobSGunsSign, db);
            doodad.TextName = "Sign Bob's Guns";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "Y,X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 0;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadTraceySArmorySign(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.TraceySArmorySign, db);
            doodad.TextName = "Sign Tracey's Armory";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "Y,X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 0;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadEmptyCrates(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.EmptyCrates, db);
            doodad.TextName = "Crates Empty";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadThrone_YOth(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Throne_YOth, db);
            doodad.TextName = "Throne";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "Y,X,D,G,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadWhaleStatue(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.WhaleStatue, db);
            doodad.TextName = "Statue White";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "Y,X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadKingTerenasStatue(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.KingTerenasStatue, db);
            doodad.TextName = "King Terenas Statue";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "Y,X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadIronGateA(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.IronGateA, db);
            doodad.TextName = "Iron Gate";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "Y,X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadIronGateB(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.IronGateB, db);
            doodad.TextName = "Iron Gate";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "Y,X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadBush_YPbs(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Bush_YPbs, db);
            doodad.TextName = "Bush";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "Y,X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadTreePlanter(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.TreePlanter, db);
            doodad.TextName = "Tree Planter";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "Y,X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadStraightFlowerBed(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.StraightFlowerBed, db);
            doodad.TextName = "Flower Bed Straight";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "Y,X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 0;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x2Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadAngledFlowerBed(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.AngledFlowerBed, db);
            doodad.TextName = "Flower Bed Angled";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "Y,X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 0;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\ShortFence135.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadPottedPlant(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.PottedPlant, db);
            doodad.TextName = "Potted Plant";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "Y,X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 0;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadArchway_YSaw(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Archway_YSaw, db);
            doodad.TextName = "Archway";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityArch.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadAngledArchway_YSa1(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.AngledArchway_YSa1, db);
            doodad.TextName = "Archway Angled";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityArch45.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadArchwayEntrance(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.ArchwayEntrance, db);
            doodad.TextName = "Archway Entrance";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityArch.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadAngledArchwayEntrance(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.AngledArchwayEntrance, db);
            doodad.TextName = "Archway Entrance (Angled)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityArch45.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadCathedral(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Cathedral, db);
            doodad.TextName = "Cathedral";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,V,Q,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\Cathedral.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadSingleColumn(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.SingleColumn, db);
            doodad.TextName = "Column Single";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadDoubleColumn(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.DoubleColumn, db);
            doodad.TextName = "Column Double";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\22x4DoubleColumn.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadDoubleColumn45(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.DoubleColumn45, db);
            doodad.TextName = "Column Angled Double";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\DoubleColumn45.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadColumnSemiCircle(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.ColumnSemiCircle, db);
            doodad.TextName = "Column Semi Circle";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\ColumnSemiCircle3.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadColumnSemiCircle2(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.ColumnSemiCircle2, db);
            doodad.TextName = "Column Semi Circle";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\ColumnSemiCircle3.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadColumnSemiCircle3(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.ColumnSemiCircle3, db);
            doodad.TextName = "Column Semi Circle";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\ColumnSemiCircle3.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadColumnSemiCircle4(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.ColumnSemiCircle4, db);
            doodad.TextName = "Column Semi Circle";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\ColumnSemiCircle3.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadShortWallEnd(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.ShortWallEnd, db);
            doodad.TextName = "Wall End Short";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadLowWall_YSw0(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.LowWall_YSw0, db);
            doodad.TextName = "Wall Low (Horizontal)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\2x4Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadLowWall_YSw1(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.LowWall_YSw1, db);
            doodad.TextName = "Wall Low (Diagonal 1)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4diag0.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadLowWall_YSw2(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.LowWall_YSw2, db);
            doodad.TextName = "Wall Low (Vertical)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x2Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadLowWall_YSw3(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.LowWall_YSw3, db);
            doodad.TextName = "Wall Low (Diagonal 2)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Diag1.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadWallCorner_YSw4(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.WallCorner_YSw4, db);
            doodad.TextName = "Wall Corner";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "_";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadWallEndcap_YSw5(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.WallEndcap_YSw5, db);
            doodad.TextName = "Wall Endcap";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "_";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadWallStaright(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.WallStaright, db);
            doodad.TextName = "Wall Straight";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "_";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadWallCorner_YSw7(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.WallCorner_YSw7, db);
            doodad.TextName = "Wall Corner (Alt)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "_";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadWallStraightLong_YSw8(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.WallStraightLong_YSw8, db);
            doodad.TextName = "Wall Straight (Long)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "_";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadWallStraightShort_YSw9(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.WallStraightShort_YSw9, db);
            doodad.TextName = "Wall Straight (Short)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "_";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadWallStraightTee(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.WallStraightTee, db);
            doodad.TextName = "Wall Straight (Tee)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "_";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadWallStraightTeeAlt(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.WallStraightTeeAlt, db);
            doodad.TextName = "Wall Straight (Tee Alt)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "_";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadWallEntrance(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.WallEntrance, db);
            doodad.TextName = "Wall Endcap (Entrance)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "_";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadWallDoor(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.WallDoor, db);
            doodad.TextName = "Wall Door";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "_";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadWallDoorShort(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.WallDoorShort, db);
            doodad.TextName = "Wall Door (Short)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "_";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadTallWallEnd(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.TallWallEnd, db);
            doodad.TextName = "Wall End Tall";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadLanternWallEnd(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.LanternWallEnd, db);
            doodad.TextName = "Wall End Lantern";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadTavern(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Tavern, db);
            doodad.TextName = "Tavern";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,V,Q,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\6x8Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadDeadFish(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.DeadFish, db);
            doodad.TextName = "Fish Dead";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "C,D,G";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 0;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 1;
            doodad.ArtShowInFogRaw = 0;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "_";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRocks_CRrk(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Rocks_CRrk, db);
            doodad.TextName = "Rocks";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "C";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRocks_DRrk(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Rocks_DRrk, db);
            doodad.TextName = "Rocks";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "D";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadLightningBolt(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.LightningBolt, db);
            doodad.TextName = "Lightning Bolt";
            doodad.EditorCategoryRaw = "Z";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 0;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "_";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadFire(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Fire, db);
            doodad.TextName = "Fire";
            doodad.EditorCategoryRaw = "Z";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 1;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 0;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "_";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadBlueFire(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.BlueFire, db);
            doodad.TextName = "Fire Blue";
            doodad.EditorCategoryRaw = "Z";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 1;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 0;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "_";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadSmallFire(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.SmallFire, db);
            doodad.TextName = "Fire Small";
            doodad.EditorCategoryRaw = "Z";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 1;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 0;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "_";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadSideFireTrap(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.SideFireTrap, db);
            doodad.TextName = "Trap Side Fire";
            doodad.EditorCategoryRaw = "Z";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 1;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 0;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "_";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadFireTrap(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.FireTrap, db);
            doodad.TextName = "Trap Fire";
            doodad.EditorCategoryRaw = "Z";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 1;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 0;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "_";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadFireGust(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.FireGust, db);
            doodad.TextName = "Fire Gust";
            doodad.EditorCategoryRaw = "Z";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 1;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 0;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "_";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadSideFrostTrap(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.SideFrostTrap, db);
            doodad.TextName = "Trap Side Frost";
            doodad.EditorCategoryRaw = "Z";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 1;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 0;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "_";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadFrostTrap(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.FrostTrap, db);
            doodad.TextName = "Trap Frost";
            doodad.EditorCategoryRaw = "Z";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 1;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 0;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "_";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadArchway_DSar(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Archway_DSar, db);
            doodad.TextName = "Archway";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "D";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityArch.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadAngledArchway_DSa1(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.AngledArchway_DSa1, db);
            doodad.TextName = "Archway Angled";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "D";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityArch45.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadStoneArchway_DSah(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.StoneArchway_DSah, db);
            doodad.TextName = "Archway Stone";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "D";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityArch.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadStoneArchway_DSa2(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.StoneArchway_DSa2, db);
            doodad.TextName = "Archway Angled Stone";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "D";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityArch45.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadPileOfTreasure(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.PileOfTreasure, db);
            doodad.TextName = "Pile of Treasure";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadPileOfJunk(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.PileOfJunk, db);
            doodad.TextName = "Pile of Junk";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadChains(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Chains, db);
            doodad.TextName = "Chains";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "D,G";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 0;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 0;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "_";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadChainPost(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.ChainPost, db);
            doodad.TextName = "Chain Post";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "D,G";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 0;
            doodad.EditorPlaceableOnWaterRaw = 0;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadFieryCrater_DRfc(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.FieryCrater_DRfc, db);
            doodad.TextName = "Crater Fiery";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "D";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 0;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\6x6Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadStalagmite_DRst(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Stalagmite_DRst, db);
            doodad.TextName = "Stalagmite";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "D";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadLavaCracks_DOlc(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.LavaCracks_DOlc, db);
            doodad.TextName = "Lava Cracks";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "D,G";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 0;
            doodad.EditorPlaceableOnWaterRaw = 0;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "_";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadChair_DOcr(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Chair_DOcr, db);
            doodad.TextName = "Chair";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "D,G";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 0;
            doodad.EditorPlaceableOnWaterRaw = 0;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadBench(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Bench, db);
            doodad.TextName = "Bench";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "D,G";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 0;
            doodad.EditorPlaceableOnWaterRaw = 0;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadBookshelf(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Bookshelf, db);
            doodad.TextName = "Bookshelf";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "D,G";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 0;
            doodad.EditorPlaceableOnWaterRaw = 0;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadLargeBookshelf(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.LargeBookshelf, db);
            doodad.TextName = "Bookshelf Large";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "D,G";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 0;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadLongBookshelf(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.LongBookshelf, db);
            doodad.TextName = "Bookshelf Long";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "D,G";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 0;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x2Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadAngledBookshelf(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.AngledBookshelf, db);
            doodad.TextName = "Bookshelf Angled";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "D,G";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 0;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Diag1.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadObelisk_DOob(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Obelisk_DOob, db);
            doodad.TextName = "Obelisk";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "D";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadTable(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Table, db);
            doodad.TextName = "Table";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "D,G";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 0;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadTableAndChair(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.TableAndChair, db);
            doodad.TextName = "Table and Chair";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "D,G";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 0;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadIronMaiden(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.IronMaiden, db);
            doodad.TextName = "Iron Maiden";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "D,G";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 0;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadTortureTable(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.TortureTable, db);
            doodad.TextName = "Table Torture";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "D,G";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 0;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadMineCart(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.MineCart, db);
            doodad.TextName = "Mine Cart";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "D,G";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadEmptyMineCart(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.EmptyMineCart, db);
            doodad.TextName = "Mine Cart Empty";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "D,G";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadBarredWall_DSp0(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.BarredWall_DSp0, db);
            doodad.TextName = "Wall Barred Small";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "D";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\8x2Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadBarredWall_DSp9(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.BarredWall_DSp9, db);
            doodad.TextName = "Wall Barred Large";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "D";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\Fence135.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadBlueMushroom(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.BlueMushroom, db);
            doodad.TextName = "Mushroom Blue";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "G";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRocks_GRrk(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Rocks_GRrk, db);
            doodad.TextName = "Rocks";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "G";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadFieryCrater_GRfc(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.FieryCrater_GRfc, db);
            doodad.TextName = "Crater Fiery";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "G";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 0;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\6x6Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadStalagmite_GRst(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Stalagmite_GRst, db);
            doodad.TextName = "Stalagmite";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "G";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadObelisk_GOob(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Obelisk_GOob, db);
            doodad.TextName = "Obelisk";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "G";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadStoneArchway_GSah(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.StoneArchway_GSah, db);
            doodad.TextName = "Archway Stone";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "G";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityArch.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadStoneArchway_GSa2(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.StoneArchway_GSa2, db);
            doodad.TextName = "Archway Angled Stone";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "G";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityArch45.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadArchway_GSar(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Archway_GSar, db);
            doodad.TextName = "Archway";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "G";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityArch.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadArchway_GSa1(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Archway_GSa1, db);
            doodad.TextName = "Archway Angled";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "G";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityArch45.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadBarredWall_GSp0(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.BarredWall_GSp0, db);
            doodad.TextName = "Wall Barred Small";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "G";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\8x2Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadBarredWall_GSp9(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.BarredWall_GSp9, db);
            doodad.TextName = "Wall Barred Large";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "G";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\Fence135.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadLavaCracks_GOlc(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.LavaCracks_GOlc, db);
            doodad.TextName = "Lava Cracks";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "G";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 0;
            doodad.EditorPlaceableOnWaterRaw = 0;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 0;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "_";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadWaterfallEffect(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.WaterfallEffect, db);
            doodad.TextName = "Waterfall";
            doodad.EditorCategoryRaw = "W";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 1;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 1;
            doodad.PathingPathingTextureRaw = "_";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadCave0(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Cave0, db);
            doodad.TextName = "Cliff Cave";
            doodad.EditorCategoryRaw = "C";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 1;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\Cave0base.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadCave2(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Cave2, db);
            doodad.TextName = "Cliff Cave 2";
            doodad.EditorCategoryRaw = "C";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 1;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\Cave2base.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadSunWell(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.SunWell, db);
            doodad.TextName = "Sun Well";
            doodad.EditorCategoryRaw = "Z";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\8x8Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadCameraProp(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.CameraProp, db);
            doodad.TextName = "Camera Prop";
            doodad.EditorCategoryRaw = "Z";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadCityBuilding_YS00(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.CityBuilding_YS00, db);
            doodad.TextName = "City Building (Diagonal 1, Red)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,V,Q,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityBuilding0-2.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadCityBuilding_YS01(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.CityBuilding_YS01, db);
            doodad.TextName = "City Building (Diagonal 1, Green)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,V,Q,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityBuilding0-2.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadCityBuilding_YS02(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.CityBuilding_YS02, db);
            doodad.TextName = "City Building (Diagonal 1, Purple)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,V,Q,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityBuilding0-2.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadCityBuilding_YS03(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.CityBuilding_YS03, db);
            doodad.TextName = "City Building (Horizontal, Blue)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,V,Q,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityBuilding3-5.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadCityBuilding_YS04(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.CityBuilding_YS04, db);
            doodad.TextName = "City Building (Horizontal, Green)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,V,Q,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityBuilding3-5.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadCityBuilding_YS05(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.CityBuilding_YS05, db);
            doodad.TextName = "City Building (Horizontal, Red)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,V,Q,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityBuilding3-5.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadCityBuilding_YS06(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.CityBuilding_YS06, db);
            doodad.TextName = "City Building (Diagonal 2, Purple)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,V,Q,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityBuilding6-8.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadCityBuilding_YS07(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.CityBuilding_YS07, db);
            doodad.TextName = "City Building (Diagonal 2, Green)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,V,Q,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityBuilding6-8.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadCityBuilding_YS08(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.CityBuilding_YS08, db);
            doodad.TextName = "City Building (Diagonal 2, Blue)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,V,Q,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityBuilding6-8.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadCityBuilding_YS09(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.CityBuilding_YS09, db);
            doodad.TextName = "City Building (Vertical, Green)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,V,Q,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityBuilding9-11.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadCityBuilding_YS10(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.CityBuilding_YS10, db);
            doodad.TextName = "City Building (Vertical, Red)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,V,Q,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityBuilding9-11.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadCityBuilding_YS11(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.CityBuilding_YS11, db);
            doodad.TextName = "City Building (Vertical, Blue)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,V,Q,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityBuilding9-11.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadLargeCityBuilding_YS12(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.LargeCityBuilding_YS12, db);
            doodad.TextName = "City Building Large (Vertical, Purple)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,V,Q,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityBuildingLarge_0.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadLargeCityBuilding_YS13(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.LargeCityBuilding_YS13, db);
            doodad.TextName = "City Building Large (Diagonal 1, Red)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,V,Q,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityBuildingLarge_135.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadLargeCityBuilding_YS14(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.LargeCityBuilding_YS14, db);
            doodad.TextName = "City Building Large (Horizontal, Green)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,V,Q,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityBuildingLarge_90.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadLargeCityBuilding_YS15(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.LargeCityBuilding_YS15, db);
            doodad.TextName = "City Building Large (Diagonal 2, Blue)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,V,Q,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityBuildingLarge_45.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadEnergyField(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.EnergyField, db);
            doodad.TextName = "Energy Field";
            doodad.EditorCategoryRaw = "Z";
            doodad.EditorTilesetsRaw = "X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 1;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 0;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadThrallSHut(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.ThrallSHut, db);
            doodad.TextName = "Thrall's Hut";
            doodad.EditorCategoryRaw = "Z";
            doodad.EditorTilesetsRaw = "L";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\12x12Simple.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRuinsBrazier(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RuinsBrazier, db);
            doodad.TextName = "Ruins Brazier";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "Z";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRuinsStatue(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RuinsStatue, db);
            doodad.TextName = "Ruins Statue";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "Z";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRuinsBrokenStatue(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RuinsBrokenStatue, db);
            doodad.TextName = "Ruins Broken Statue";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "Z";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRuinsStones(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RuinsStones, db);
            doodad.TextName = "Ruins Stones";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "Z";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadArchway_ZSar(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Archway_ZSar, db);
            doodad.TextName = "Archway Natural";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Z";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityArch.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadArchway_ZSa1(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Archway_ZSa1, db);
            doodad.TextName = "Archway Angled Natural";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Z";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityArch45.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadArchway_ZSas(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Archway_ZSas, db);
            doodad.TextName = "Archway";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Z";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityArch.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadArchway_ZSs1(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Archway_ZSs1, db);
            doodad.TextName = "Archway Angled";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Z";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityArch45.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRuinedArchway_ZSab(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RuinedArchway_ZSab, db);
            doodad.TextName = "Archway";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Z";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityArch.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRuinedArchway_ZSb1(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RuinedArchway_ZSb1, db);
            doodad.TextName = "Archway Angled";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Z";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityArch45.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadGreenFish(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.GreenFish, db);
            doodad.TextName = "Fish Green";
            doodad.EditorCategoryRaw = "W";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 0;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadSchoolOfFish(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.SchoolOfFish, db);
            doodad.TextName = "Fish School";
            doodad.EditorCategoryRaw = "W";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 0;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRuins(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Ruins, db);
            doodad.TextName = "Ruins";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Z";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\6x8Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRuinsFountain(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RuinsFountain, db);
            doodad.TextName = "Ruins Fountain";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "Z";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\8x8Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRuinsObelisk(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RuinsObelisk, db);
            doodad.TextName = "Ruins Obelisk";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "Z";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRuinsThrone(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RuinsThrone, db);
            doodad.TextName = "Ruins Throne";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "Z";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRocks_IRrk(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Rocks_IRrk, db);
            doodad.TextName = "Rocks";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "I";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRuinsPillar(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RuinsPillar, db);
            doodad.TextName = "Ruins Pillars";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "Z";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadShells(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Shells, db);
            doodad.TextName = "Shells";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "Z";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadCityCliffCave1(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.CityCliffCave1, db);
            doodad.TextName = "Cave City Cliff (North Right)";
            doodad.EditorCategoryRaw = "C";
            doodad.EditorTilesetsRaw = "Y,X,D,G,Z,I,O,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 1;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CaveCityCliff1base.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadCityCliffCave2(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.CityCliffCave2, db);
            doodad.TextName = "Cave City Cliff (North Left)";
            doodad.EditorCategoryRaw = "C";
            doodad.EditorTilesetsRaw = "Y,X,D,G,Z,I,O,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 1;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CaveCityCliff2base.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadCityCliffCave3(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.CityCliffCave3, db);
            doodad.TextName = "Cave City Cliff (West)";
            doodad.EditorCategoryRaw = "C";
            doodad.EditorTilesetsRaw = "Y,X,D,G,Z,I,O,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 1;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CaveCityCliff3base.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadCityCliffCave4(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.CityCliffCave4, db);
            doodad.TextName = "Cave City Cliff (East)";
            doodad.EditorCategoryRaw = "C";
            doodad.EditorTilesetsRaw = "Y,X,D,G,Z,I,O,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 1;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CaveCityCliff4base.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadCityCliffCollapse1(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.CityCliffCollapse1, db);
            doodad.TextName = "Ruined City Cliff (North)";
            doodad.EditorCategoryRaw = "C";
            doodad.EditorTilesetsRaw = "Y,X,D,G,Z,I,O,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 1;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CliffCollapse0Path.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadCityCliffCollapse2(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.CityCliffCollapse2, db);
            doodad.TextName = "Ruined City Cliff (East)";
            doodad.EditorCategoryRaw = "C";
            doodad.EditorTilesetsRaw = "Y,X,D,G,Z,I,O,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 1;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CliffCollapse1Path.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadCityCliffCollapse3(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.CityCliffCollapse3, db);
            doodad.TextName = "Ruined City Cliff (South)";
            doodad.EditorCategoryRaw = "C";
            doodad.EditorTilesetsRaw = "Y,X,D,G,Z,I,O,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 1;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CliffCollapse2Path.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadCityCliffCollapse4(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.CityCliffCollapse4, db);
            doodad.TextName = "Ruined City Cliff (West)";
            doodad.EditorCategoryRaw = "C";
            doodad.EditorTilesetsRaw = "Y,X,D,G,Z,I,O,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 1;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CliffCollapse3Path.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRuinedCrystalTower(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RuinedCrystalTower, db);
            doodad.TextName = "Ruined Crystal Tower";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\8x8Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRuinedTower_ZOdt(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RuinedTower_ZOdt, db);
            doodad.TextName = "Ruined Tower";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\8x8Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRuinedTower_ZOd2(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RuinedTower_ZOd2, db);
            doodad.TextName = "Ruined Tower";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRuinedTowerBase(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RuinedTowerBase, db);
            doodad.TextName = "Ruined Tower Base";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\8x8Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRuinedDoubleBase_ZOtb(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RuinedDoubleBase_ZOtb, db);
            doodad.TextName = "Ruined Double Base";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\8x8Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRuinedDoubleBase_ZOt2(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RuinedDoubleBase_ZOt2, db);
            doodad.TextName = "Ruined Double Base";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\8x8Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRuinedVioletCitadel(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RuinedVioletCitadel, db);
            doodad.TextName = "Dalaran Violet Citadel Ruined";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\12x12Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRuinsFirepot(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RuinsFirepot, db);
            doodad.TextName = "Ruins Firepot";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "Z";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRocks_ZRrk(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Rocks_ZRrk, db);
            doodad.TextName = "Rocks";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "Z";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadCliffsideVines_ZCv1(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.CliffsideVines_ZCv1, db);
            doodad.TextName = "Vines Cliffside";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "Z";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadCliffsideVines_ZCv2(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.CliffsideVines_ZCv2, db);
            doodad.TextName = "Vines Cliffside";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "Z";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadSeaweed(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Seaweed, db);
            doodad.TextName = "Seaweed";
            doodad.EditorCategoryRaw = "W";
            doodad.EditorTilesetsRaw = "A,B,L,F,W,Y,X,V,Q,N,Z,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 1;
            doodad.ArtShowInFogRaw = 0;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadBubbles(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Bubbles, db);
            doodad.TextName = "Bubbles";
            doodad.EditorCategoryRaw = "W";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 1;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 1;
            doodad.ArtShowInFogRaw = 0;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadSteamBubbles(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.SteamBubbles, db);
            doodad.TextName = "Bubbles Steam";
            doodad.EditorCategoryRaw = "W";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 1;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 1;
            doodad.ArtShowInFogRaw = 0;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadFloatingIce(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.FloatingIce, db);
            doodad.TextName = "Ice Floating";
            doodad.EditorCategoryRaw = "W";
            doodad.EditorTilesetsRaw = "I,N";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 1;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadIcyWaterfallEffect(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.IcyWaterfallEffect, db);
            doodad.TextName = "Icy Waterfall";
            doodad.EditorCategoryRaw = "W";
            doodad.EditorTilesetsRaw = "I";
            doodad.EditorHasTilesetSpecificDataRaw = 1;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 1;
            doodad.PathingPathingTextureRaw = "_";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadFlowers_ZPfw(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Flowers_ZPfw, db);
            doodad.TextName = "Flowers";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "Z,L,F,A,C,X,J,Y,V,Q";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadShrub(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Shrub, db);
            doodad.TextName = "Shrub";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "Z,L,F,A,C,X,J,Y,V,Q";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadLilypad(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Lilypad, db);
            doodad.TextName = "Lily Pad";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "Z";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 1;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadCatTail(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.CatTail, db);
            doodad.TextName = "Cattail";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "Z";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadCoral(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Coral, db);
            doodad.TextName = "Coral";
            doodad.EditorCategoryRaw = "W";
            doodad.EditorTilesetsRaw = "Z";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\8x6Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadCoralArch(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.CoralArch, db);
            doodad.TextName = "Coral Arch";
            doodad.EditorCategoryRaw = "W";
            doodad.EditorTilesetsRaw = "Z";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\18x12Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadDemonicFootprints(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.DemonicFootprints, db);
            doodad.TextName = "Footprints Demonic";
            doodad.EditorCategoryRaw = "Z";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 1;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 0;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadSkullTorch(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.SkullTorch, db);
            doodad.TextName = "Skull Torch";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "I";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadIceArchway_ISar(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.IceArchway_ISar, db);
            doodad.TextName = "Archway Icy";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "I";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityArch.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadIceArchway_ISa1(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.IceArchway_ISa1, db);
            doodad.TextName = "Archway Angled Icy";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "I";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityArch45.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadObelisk_IOob(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Obelisk_IOob, db);
            doodad.TextName = "Obelisk";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "I";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadPillar(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Pillar, db);
            doodad.TextName = "Pillar";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "I";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadIceBlock(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.IceBlock, db);
            doodad.TextName = "Ice Block";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "I,N";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadStatueOfAzshara_DOas(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.StatueOfAzshara_DOas, db);
            doodad.TextName = "Statue of Azshara";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "D";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\8x8Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadSnowman(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Snowman, db);
            doodad.TextName = "Snowman";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "I";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRockSpires_ZRrs(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RockSpires_ZRrs, db);
            doodad.TextName = "Rock Spires";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "Z";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\LargeRockSpire.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadSmallRockSpires_ZRsp(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.SmallRockSpires_ZRsp, db);
            doodad.TextName = "Rock Spires Small";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "Z";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRocks_ORrk(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Rocks_ORrk, db);
            doodad.TextName = "Rocks";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "O,K";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRockSpires_ORrs(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RockSpires_ORrs, db);
            doodad.TextName = "Rock Spires";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "O,K";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\LargeRockSpire.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadIceSpiderOnPedestal(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.IceSpiderOnPedestal, db);
            doodad.TextName = "Ice Spider on Pedestal";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "I";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadIceSpiderStatue(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.IceSpiderStatue, db);
            doodad.TextName = "Statue Ice Spider";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "I";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\Log45.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRuinedShip(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RuinedShip, db);
            doodad.TextName = "Ruined Ship";
            doodad.EditorCategoryRaw = "W";
            doodad.EditorTilesetsRaw = "A,C";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\8x8Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadPlants(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Plants, db);
            doodad.TextName = "Outland Plants";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "O,K";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadGlacier(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Glacier, db);
            doodad.TextName = "Glacier";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "I";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\LargeRockSpire.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadMagmaRock(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.MagmaRock, db);
            doodad.TextName = "Rock Magma";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "O,K";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\8x8Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRuinedFloor2x2_YCx1(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RuinedFloor2x2_YCx1, db);
            doodad.TextName = "Ruined Ground (2x2)";
            doodad.EditorCategoryRaw = "C";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 1;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\8x8UnbuildableHeightA.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRuinedFloor2x2_YCx2(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RuinedFloor2x2_YCx2, db);
            doodad.TextName = "Ruined Ground (2x2)";
            doodad.EditorCategoryRaw = "C";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 1;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\8x8UnbuildableHeightA.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRuinedFloor2x2_YCx3(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RuinedFloor2x2_YCx3, db);
            doodad.TextName = "Ruined Ground (2x2)";
            doodad.EditorCategoryRaw = "C";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 1;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\8x8UnbuildableHeightA.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRuinedFloor2x2_YCx4(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RuinedFloor2x2_YCx4, db);
            doodad.TextName = "Ruined Ground (2x2)";
            doodad.EditorCategoryRaw = "C";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 1;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\8x8UnbuildableHeightA.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRuinedFloor4x4_YCx5(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RuinedFloor4x4_YCx5, db);
            doodad.TextName = "Ruined Ground (4x4)";
            doodad.EditorCategoryRaw = "C";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 1;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\16x16UnbuildableHeightA.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRuinedFloor4x4_YCx6(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RuinedFloor4x4_YCx6, db);
            doodad.TextName = "Ruined Ground (4x4)";
            doodad.EditorCategoryRaw = "C";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 1;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\16x16UnbuildableHeightA.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRuinedFloor4x2_YCx7(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RuinedFloor4x2_YCx7, db);
            doodad.TextName = "Ruined Ground (4x2)";
            doodad.EditorCategoryRaw = "C";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 1;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\16x8UnbuildableHeightA.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRuinedFloor4x2_YCx8(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RuinedFloor4x2_YCx8, db);
            doodad.TextName = "Ruined Ground (4x2)";
            doodad.EditorCategoryRaw = "C";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 1;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\16x8UnbuildableHeightA.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRoughCliffCave1(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RoughCliffCave1, db);
            doodad.TextName = "Cave Natural Cliff (North Right)";
            doodad.EditorCategoryRaw = "C";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 1;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CaveCityCliff1base.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRoughCliffCave2(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RoughCliffCave2, db);
            doodad.TextName = "Cave Natural Cliff (North Left)";
            doodad.EditorCategoryRaw = "C";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 1;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CaveCityCliff2base.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRoughCliffCave3(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RoughCliffCave3, db);
            doodad.TextName = "Cave Natural Cliff (West)";
            doodad.EditorCategoryRaw = "C";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 1;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CaveCityCliff3base.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRoughCliffCave4(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RoughCliffCave4, db);
            doodad.TextName = "Cave Natural Cliff (East)";
            doodad.EditorCategoryRaw = "C";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 1;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CaveCityCliff4base.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRoughCliffCollapse1(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RoughCliffCollapse1, db);
            doodad.TextName = "Ruined Natural Cliff (North)";
            doodad.EditorCategoryRaw = "C";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 1;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CliffCollapse0Path.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRoughCliffCollapse2(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RoughCliffCollapse2, db);
            doodad.TextName = "Ruined Natural Cliff (East)";
            doodad.EditorCategoryRaw = "C";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 1;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CliffCollapse1Path.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRoughCliffCollapse3(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RoughCliffCollapse3, db);
            doodad.TextName = "Ruined Natural Cliff (South)";
            doodad.EditorCategoryRaw = "C";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 1;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CliffCollapse2Path.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRoughCliffCollapse4(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RoughCliffCollapse4, db);
            doodad.TextName = "Ruined Natural Cliff (West)";
            doodad.EditorCategoryRaw = "C";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 1;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CliffCollapse3Path.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadCityCliffSlide1(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.CityCliffSlide1, db);
            doodad.TextName = "Slide City Cliff (North)";
            doodad.EditorCategoryRaw = "C";
            doodad.EditorTilesetsRaw = "Y,X,D,G,Z,I,O,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 1;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CliffCollapse0Path.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadCityCliffSlide2(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.CityCliffSlide2, db);
            doodad.TextName = "Slide City Cliff (East)";
            doodad.EditorCategoryRaw = "C";
            doodad.EditorTilesetsRaw = "Y,X,D,G,Z,I,O,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 1;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CliffCollapse1Path.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadCityCliffSlide3(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.CityCliffSlide3, db);
            doodad.TextName = "Slide City Cliff (South)";
            doodad.EditorCategoryRaw = "C";
            doodad.EditorTilesetsRaw = "Y,X,D,G,Z,I,O,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 1;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CliffCollapse2Path.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadCityCliffSlide4(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.CityCliffSlide4, db);
            doodad.TextName = "Slide City Cliff (West)";
            doodad.EditorCategoryRaw = "C";
            doodad.EditorTilesetsRaw = "Y,X,D,G,Z,I,O,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 1;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CliffCollapse3Path.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadCityCliffCollapseShort1(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.CityCliffCollapseShort1, db);
            doodad.TextName = "Ruined City Cliff Short (North)";
            doodad.EditorCategoryRaw = "C";
            doodad.EditorTilesetsRaw = "Y,X,D,G,Z,I,O,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 1;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CliffCollapse0ShortPath.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadCityCliffCollapseShort2(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.CityCliffCollapseShort2, db);
            doodad.TextName = "Ruined City Cliff Short (East)";
            doodad.EditorCategoryRaw = "C";
            doodad.EditorTilesetsRaw = "Y,X,D,G,Z,I,O,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 1;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CliffCollapse1ShortPath.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadCityCliffCollapseShort3(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.CityCliffCollapseShort3, db);
            doodad.TextName = "Ruined City Cliff Short (South)";
            doodad.EditorCategoryRaw = "C";
            doodad.EditorTilesetsRaw = "Y,X,D,G,Z,I,O,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 1;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CliffCollapse2ShortPath.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadCityCliffCollapseShort4(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.CityCliffCollapseShort4, db);
            doodad.TextName = "Ruined City Cliff Short (West)";
            doodad.EditorCategoryRaw = "C";
            doodad.EditorTilesetsRaw = "Y,X,D,G,Z,I,O,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 1;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CliffCollapse3ShortPath.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadCityCliffSlideShort1(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.CityCliffSlideShort1, db);
            doodad.TextName = "Slide City Cliff Short (North)";
            doodad.EditorCategoryRaw = "C";
            doodad.EditorTilesetsRaw = "Y,X,D,G,Z,I,O,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 1;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CliffCollapse0ShortPath.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadCityCliffSlideShort2(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.CityCliffSlideShort2, db);
            doodad.TextName = "Slide City Cliff Short (East)";
            doodad.EditorCategoryRaw = "C";
            doodad.EditorTilesetsRaw = "Y,X,D,G,Z,I,O,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 1;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CliffCollapse1ShortPath.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadCityCliffSlideShort3(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.CityCliffSlideShort3, db);
            doodad.TextName = "Slide City Cliff Short (South)";
            doodad.EditorCategoryRaw = "C";
            doodad.EditorTilesetsRaw = "Y,X,D,G,Z,I,O,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 1;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CliffCollapse2ShortPath.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadCityCliffSlideShort4(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.CityCliffSlideShort4, db);
            doodad.TextName = "Slide City Cliff Short (West)";
            doodad.EditorCategoryRaw = "C";
            doodad.EditorTilesetsRaw = "Y,X,D,G,Z,I,O,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 1;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CliffCollapse3ShortPath.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRoughCliffSlide1(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RoughCliffSlide1, db);
            doodad.TextName = "Slide Natural Cliff (North)";
            doodad.EditorCategoryRaw = "C";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 1;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CliffCollapse0Path.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRoughCliffSlide2(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RoughCliffSlide2, db);
            doodad.TextName = "Slide Natural Cliff (East)";
            doodad.EditorCategoryRaw = "C";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 1;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CliffCollapse1Path.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRoughCliffSlide3(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RoughCliffSlide3, db);
            doodad.TextName = "Slide Natural Cliff (South)";
            doodad.EditorCategoryRaw = "C";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 1;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CliffCollapse2Path.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRoughCliffSlide4(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RoughCliffSlide4, db);
            doodad.TextName = "Slide Natural Cliff (West)";
            doodad.EditorCategoryRaw = "C";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 1;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CliffCollapse3Path.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRoughCliffSlideShort1(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RoughCliffSlideShort1, db);
            doodad.TextName = "Slide Natural Cliff Short (North)";
            doodad.EditorCategoryRaw = "C";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 1;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CliffCollapse0ShortPath.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRoughCliffSlideShort2(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RoughCliffSlideShort2, db);
            doodad.TextName = "Slide Natural Cliff Short (East)";
            doodad.EditorCategoryRaw = "C";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 1;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CliffCollapse1ShortPath.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRoughCliffSlideShort3(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RoughCliffSlideShort3, db);
            doodad.TextName = "Slide Natural Cliff Short (South)";
            doodad.EditorCategoryRaw = "C";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 1;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CliffCollapse2ShortPath.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRoughCliffSlideShort4(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RoughCliffSlideShort4, db);
            doodad.TextName = "Slide Natural Cliff Short (West)";
            doodad.EditorCategoryRaw = "C";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 1;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CliffCollapse3ShortPath.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRoughCliffCollapseShort1(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RoughCliffCollapseShort1, db);
            doodad.TextName = "Ruined Natural Cliff Short (North)";
            doodad.EditorCategoryRaw = "C";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 1;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CliffCollapse0ShortPath.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRoughCliffCollapseShort2(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RoughCliffCollapseShort2, db);
            doodad.TextName = "Ruined Natural Cliff Short (East)";
            doodad.EditorCategoryRaw = "C";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 1;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CliffCollapse1ShortPath.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRoughCliffCollapseShort3(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RoughCliffCollapseShort3, db);
            doodad.TextName = "Ruined Natural Cliff Short (South)";
            doodad.EditorCategoryRaw = "C";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 1;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CliffCollapse2ShortPath.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRoughCliffCollapseShort4(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RoughCliffCollapseShort4, db);
            doodad.TextName = "Ruined Natural Cliff Short (West)";
            doodad.EditorCategoryRaw = "C";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 1;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CliffCollapse3ShortPath.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadSmallRubble(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.SmallRubble, db);
            doodad.TextName = "Rubble Small";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "Z";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadLargeRubble(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.LargeRubble, db);
            doodad.TextName = "Rubble Large";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "Z";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\12x4Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadFloatingRock(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.FloatingRock, db);
            doodad.TextName = "Rocks Floating";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "O,K";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 1;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\8x8Unflyable.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadFloatingRockCluster(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.FloatingRockCluster, db);
            doodad.TextName = "Rocks Cluster Floating";
            doodad.EditorCategoryRaw = "Z";
            doodad.EditorTilesetsRaw = "O,K";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 1;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadPier(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Pier, db);
            doodad.TextName = "Pier, Pier";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "A,C";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRuinedPier(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RuinedPier, db);
            doodad.TextName = "Pier Ruined";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "A,C";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadMushrooms_ZPms(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Mushrooms_ZPms, db);
            doodad.TextName = "Mushrooms";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "Z";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadVinyPlant(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.VinyPlant, db);
            doodad.TextName = "Viny Plant";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "Z";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadLibraryShelf(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.LibraryShelf, db);
            doodad.TextName = "Ruins Library Shelf";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "Z";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x2Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRuinedCathedral(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RuinedCathedral, db);
            doodad.TextName = "Cathedral Ruined";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,V,Q,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\Cathedral.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRuinedFountain(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RuinedFountain, db);
            doodad.TextName = "Fountain Ruined";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "Y,X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\8x8Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadGulDanSRunes(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.GulDanSRunes, db);
            doodad.TextName = "Gul'dan's Runes";
            doodad.EditorCategoryRaw = "Z";
            doodad.EditorTilesetsRaw = "Z";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadInvulnerabilityField(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.InvulnerabilityField, db);
            doodad.TextName = "Invulnerability Field";
            doodad.EditorCategoryRaw = "Z";
            doodad.EditorTilesetsRaw = "J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 1;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 0;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadCityBuilding_YSr0(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.CityBuilding_YSr0, db);
            doodad.TextName = "City Building Ruined (Diagonal 1, Red)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,V,Q,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityBuilding0-2.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadCityBuilding_YSr1(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.CityBuilding_YSr1, db);
            doodad.TextName = "City Building Ruined (Diagonal 1, Green)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,V,Q,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityBuilding0-2.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadCityBuilding_YSr2(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.CityBuilding_YSr2, db);
            doodad.TextName = "City Building Ruined (Diagonal 1, Purple)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,V,Q,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityBuilding0-2.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadCityBuilding_YSr3(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.CityBuilding_YSr3, db);
            doodad.TextName = "City Building Ruined (Horizontal, Blue)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,V,Q,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityBuilding3-5.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadCityBuilding_YSr4(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.CityBuilding_YSr4, db);
            doodad.TextName = "City Building Ruined (Horizontal, Green)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,V,Q,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityBuilding3-5.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadCityBuilding_YSr5(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.CityBuilding_YSr5, db);
            doodad.TextName = "City Building Ruined (Horizontal, Red)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,V,Q,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityBuilding3-5.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadCityBuilding_YSr6(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.CityBuilding_YSr6, db);
            doodad.TextName = "City Building Ruined (Diagonal 2, Purple)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,V,Q,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityBuilding6-8.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadCityBuilding_YSr7(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.CityBuilding_YSr7, db);
            doodad.TextName = "City Building Ruined (Diagonal 2, Green)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,V,Q,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityBuilding6-8.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadCityBuilding_YSr8(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.CityBuilding_YSr8, db);
            doodad.TextName = "City Building Ruined (Diagonal 2, Blue)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,V,Q,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityBuilding6-8.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadCityBuilding_YSr9(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.CityBuilding_YSr9, db);
            doodad.TextName = "City Building Ruined (Vertical, Green)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,V,Q,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityBuilding9-11.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadCityBuilding_YSra(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.CityBuilding_YSra, db);
            doodad.TextName = "City Building Ruined (Vertical, Red)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,V,Q,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityBuilding9-11.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadCityBuilding_YSrb(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.CityBuilding_YSrb, db);
            doodad.TextName = "City Building Ruined (Vertical, Blue)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,V,Q,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityBuilding9-11.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadLargeCityBuilding_YSrc(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.LargeCityBuilding_YSrc, db);
            doodad.TextName = "City Building Large Ruined (Vertical, Purple)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,V,Q,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityBuildingLarge_0.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadLargeCityBuilding_YSrd(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.LargeCityBuilding_YSrd, db);
            doodad.TextName = "City Building Large Ruined (Diagonal 1, Red)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,V,Q,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityBuildingLarge_135.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadLargeCityBuilding_YSre(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.LargeCityBuilding_YSre, db);
            doodad.TextName = "City Building Large Ruined (Horizontal, Green)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,V,Q,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityBuildingLarge_90.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadLargeCityBuilding_YSrf(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.LargeCityBuilding_YSrf, db);
            doodad.TextName = "City Building Large Ruined (Diagonal 2, Blue)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,V,Q,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityBuildingLarge_45.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadCityBuildingRow_YSbr(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.CityBuildingRow_YSbr, db);
            doodad.TextName = "City Building Row (Group 1)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,V,Q,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadCityBuildingRow_YSb1(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.CityBuildingRow_YSb1, db);
            doodad.TextName = "City Building Row (Group 2)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,V,Q,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadCityBuildingRow_YSb2(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.CityBuildingRow_YSb2, db);
            doodad.TextName = "City Building Row (Group 3)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,V,Q,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadEyeOfSargeras(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.EyeOfSargeras, db);
            doodad.TextName = "Eye of Sargeras";
            doodad.EditorCategoryRaw = "Z";
            doodad.EditorTilesetsRaw = "Z";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadColumnSemiCircleRuined(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.ColumnSemiCircleRuined, db);
            doodad.TextName = "Column Semi Circle Ruined";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\ColumnSemiCircle3.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadColumnSemiCircle2Ruined(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.ColumnSemiCircle2Ruined, db);
            doodad.TextName = "Column Semi Circle Ruined";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\ColumnSemiCircle.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadColumnSemiCircle3Ruined(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.ColumnSemiCircle3Ruined, db);
            doodad.TextName = "Column Semi Circle Ruined";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\ColumnSemiCircle3.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadColumnSemiCircle4Ruined(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.ColumnSemiCircle4Ruined, db);
            doodad.TextName = "Column Semi Circle Ruined";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\ColumnSemiCircle.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadSingleColumnRuined_JSco(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.SingleColumnRuined_JSco, db);
            doodad.TextName = "Column Ruined";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadSingleColumnRuined_JScx(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.SingleColumnRuined_JScx, db);
            doodad.TextName = "Column Ruined with Cap";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadLargeCityBuildingRuinedBase(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.LargeCityBuildingRuinedBase, db);
            doodad.TextName = "City Building Large Base Ruined";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 1;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadCityBuildingRuinedBase(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.CityBuildingRuinedBase, db);
            doodad.TextName = "City Building Base Ruined";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 1;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadArchwayRuined_JSar(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.ArchwayRuined_JSar, db);
            doodad.TextName = "Archway Ruined";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityArch.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadArchwayRuined_JSax(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.ArchwayRuined_JSax, db);
            doodad.TextName = "Archway Ruined";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityArch.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadDust(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Dust, db);
            doodad.TextName = "Dust";
            doodad.EditorCategoryRaw = "Z";
            doodad.EditorTilesetsRaw = "Z,D,G";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 1;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 0;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRuinedGoblinShipyard(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RuinedGoblinShipyard, db);
            doodad.TextName = "Ruined Goblin Shipyard";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "L,W,F,Z";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\8x8Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadTotemLantern(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.TotemLantern, db);
            doodad.TextName = "Totem Lantern";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "A,C";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadSewerVent(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.SewerVent, db);
            doodad.TextName = "Sewer Vents";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "D,G";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadSewerWallpipes(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.SewerWallpipes, db);
            doodad.TextName = "Sewer Wallpipes";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "D,G";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadWallFountain(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.WallFountain, db);
            doodad.TextName = "Wall Fountain";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\12x12WallFountain.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRunes(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Runes, db);
            doodad.TextName = "Runes";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "K";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadShimmeringPortal(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.ShimmeringPortal, db);
            doodad.TextName = "Shimmering Portal";
            doodad.EditorCategoryRaw = "Z";
            doodad.EditorTilesetsRaw = "O,K";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 0;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadElvenFishingVillage_ASv0(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.ElvenFishingVillage_ASv0, db);
            doodad.TextName = "Night Elf Fishing Village";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "A,C";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\8x8Round.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadElvenFishingVillage_ASv1(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.ElvenFishingVillage_ASv1, db);
            doodad.TextName = "Night Elf Fishing Village";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "A,C";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\8x8Round.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadElvenFishingVillage_ASv2(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.ElvenFishingVillage_ASv2, db);
            doodad.TextName = "Night Elf Fishing Village";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "A,C";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadElvenFishingVillage_ASv3(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.ElvenFishingVillage_ASv3, db);
            doodad.TextName = "Night Elf Fishing Village";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "A,C";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\8x8Round.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadElvenFishingVillage_ASv4(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.ElvenFishingVillage_ASv4, db);
            doodad.TextName = "Night Elf Fishing Village";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "A,C";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\8x8Round.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRuinedElvenFishingVillage_ASx0(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RuinedElvenFishingVillage_ASx0, db);
            doodad.TextName = "Night Elf Fishing Village Ruined";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "A,C";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\8x8Round.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRuinedElvenFishingVillage_ASx1(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RuinedElvenFishingVillage_ASx1, db);
            doodad.TextName = "Night Elf Fishing Village Ruined";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "A,C";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\8x8Round.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRuinedElvenFishingVillage_ASx2(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RuinedElvenFishingVillage_ASx2, db);
            doodad.TextName = "Night Elf Fishing Village Ruined";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "A,C";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadTrash_ZOtr(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Trash_ZOtr, db);
            doodad.TextName = "Ruins Trash";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "Z";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadBloodyAltar(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.BloodyAltar, db);
            doodad.TextName = "Ruins Bloody Altar";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "Z";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRisingWater(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RisingWater, db);
            doodad.TextName = "Rising Water";
            doodad.EditorCategoryRaw = "Z";
            doodad.EditorTilesetsRaw = "I";
            doodad.EditorHasTilesetSpecificDataRaw = 1;
            doodad.EditorUseClickHelperRaw = 1;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 0;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadBlackCitadelStatue(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.BlackCitadelStatue, db);
            doodad.TextName = "Statue Black Citadel";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "K";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\8x8Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadTheFrozenThrone(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.TheFrozenThrone, db);
            doodad.TextName = "The Frozen Throne";
            doodad.EditorCategoryRaw = "Z";
            doodad.EditorTilesetsRaw = "I";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 0;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadIceyChair(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.IceyChair, db);
            doodad.TextName = "Chair Icey";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "I";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadCrystal(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Crystal, db);
            doodad.TextName = "Crystal";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "I";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\8x8Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadStoneArchway_ISsr(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.StoneArchway_ISsr, db);
            doodad.TextName = "Archway Icecrown Stone";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "I";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityArch.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadAngledStoneArchway(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.AngledStoneArchway, db);
            doodad.TextName = "Archway Angled Icecrown Stone";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "I";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityArchAngle.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadChair_IOch(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Chair_IOch, db);
            doodad.TextName = "Chair";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "I";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadAltar(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Altar, db);
            doodad.TextName = "Altar";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "O,K";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadFlameGrate(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.FlameGrate, db);
            doodad.TextName = "Flame Grate";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "O,K";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadObstacle(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Obstacle, db);
            doodad.TextName = "Obstacle";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "O,K";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadSkull(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Skull, db);
            doodad.TextName = "Skull";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "O,K";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadStake(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Stake, db);
            doodad.TextName = "Stake";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "O,K";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRubble_ORrr(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Rubble_ORrr, db);
            doodad.TextName = "Rubble";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "O,K";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadUndergroundDome(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.UndergroundDome, db);
            doodad.TextName = "Underground Dome";
            doodad.EditorCategoryRaw = "Z";
            doodad.EditorTilesetsRaw = "*";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 1;
            doodad.EditorIgnoreModelClicksRaw = 1;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 0;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadStandard(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Standard, db);
            doodad.TextName = "Standard";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "O,K";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadSnowyRocks(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.SnowyRocks, db);
            doodad.TextName = "Snowy Rock";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "I,N";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRubble_ISrb(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Rubble_ISrb, db);
            doodad.TextName = "Rubble";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "I";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 0;
            doodad.EditorPlaceableOnWaterRaw = 0;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadGlowingRunes(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.GlowingRunes, db);
            doodad.TextName = "Glowing Runes";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\2x2Unbuildable.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadBarrensTree(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.BarrensTree, db);
            doodad.TextName = "Barrens Tree (Indestructible)";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "B";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadSunkenRuinsTree(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.SunkenRuinsTree, db);
            doodad.TextName = "Sunken Ruins Tree (Indestructible)";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "Z";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRisingWaterWide(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RisingWaterWide, db);
            doodad.TextName = "Rising Water Wide";
            doodad.EditorCategoryRaw = "Z";
            doodad.EditorTilesetsRaw = "I";
            doodad.EditorHasTilesetSpecificDataRaw = 1;
            doodad.EditorUseClickHelperRaw = 1;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 0;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadNoLanternWallEnd(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.NoLanternWallEnd, db);
            doodad.TextName = "Wall End Lantern No Light";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y,X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRockArchway_OSar(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RockArchway_OSar, db);
            doodad.TextName = "Archway Outland";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "O,K";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityArch.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadAngledRockArchway_OSa1(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.AngledRockArchway_OSa1, db);
            doodad.TextName = "Archway Angled Outland";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "O,K";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityArch45.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadStrahnbradClockTower(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.StrahnbradClockTower, db);
            doodad.TextName = "Strahnbrad Clock Tower";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "F";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\8x8Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadStrahnbradLargeTree(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.StrahnbradLargeTree, db);
            doodad.TextName = "Strahnbrad Large Tree";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "F";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\16x16Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadBrillClockTower(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.BrillClockTower, db);
            doodad.TextName = "Brill Clock Tower";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "F";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\8x8Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadAndrohalClockTower(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.AndrohalClockTower, db);
            doodad.TextName = "Androhal Clock Tower";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "F";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\8x8Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadAndrohalClockTowerDestroyed(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.AndrohalClockTowerDestroyed, db);
            doodad.TextName = "Androhal Clock Tower (Destroyed)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "F";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 1;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 0;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\8x8Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadHearthglenAbbey(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.HearthglenAbbey, db);
            doodad.TextName = "Hearthglen Abbey";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "F";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\24x32Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadPyrewoodVillageClockTowerDestroyed(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.PyrewoodVillageClockTowerDestroyed, db);
            doodad.TextName = "Pyrewood Village Clock Tower (Destroyed)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "F";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 0;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\8x8Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadHighElfCrestStandingBanners(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.HighElfCrestStandingBanners, db);
            doodad.TextName = "High Elf Crest Standing Banners";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "Y";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadHighElfCrestHangingBanners(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.HighElfCrestHangingBanners, db);
            doodad.TextName = "High Elf Crest Hanging Banners";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "Y";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadSilvermoonResidentialBuildingsDiagonal1(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.SilvermoonResidentialBuildingsDiagonal1, db);
            doodad.TextName = "Silvermoon Buildings (Diagonal 1)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\6x10Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadSilvermoonResidentialBuildingsDiagonal2(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.SilvermoonResidentialBuildingsDiagonal2, db);
            doodad.TextName = "Silvermoon Buildings (Diagonal 2)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\6x10Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadSilvermoonResidentialBuildingsVertical(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.SilvermoonResidentialBuildingsVertical, db);
            doodad.TextName = "Silvermoon Buildings (Vertical)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\6x10Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadSilvermoonResidentialBuildingsHorizontal(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.SilvermoonResidentialBuildingsHorizontal, db);
            doodad.TextName = "Silvermoon Buildings (Horizontal)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\6x10Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadSunfurySpireMainTower(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.SunfurySpireMainTower, db);
            doodad.TextName = "Sunfury Spire Main Tower";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\20x20Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadSunfurySpireSideTower(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.SunfurySpireSideTower, db);
            doodad.TextName = "Sunfury Spire Side Tower";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 1;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\8x8Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadSilvermoonTowerDoodadsLarge(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.SilvermoonTowerDoodadsLarge, db);
            doodad.TextName = "Silvermoon Tower (Large)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\12x12Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadSilvermoonTowerDoodadsMedium(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.SilvermoonTowerDoodadsMedium, db);
            doodad.TextName = "Silvermoon Tower (Medium)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 1;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\8x8Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadSilvermoonTowerDoodadsSmall(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.SilvermoonTowerDoodadsSmall, db);
            doodad.TextName = "Silvermoon Tower (Small)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 1;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadSilvermoonWallStraightShort(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.SilvermoonWallStraightShort, db);
            doodad.TextName = "Silvermoon Wall (Short)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\22x8Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadSilvermoonWallStraight(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.SilvermoonWallStraight, db);
            doodad.TextName = "Silvermoon Wall ";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\16x8Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadSilvermoonWallStraightLong(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.SilvermoonWallStraightLong, db);
            doodad.TextName = "Silvermoon Wall (Long)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x8Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadSilvermoonWallT(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.SilvermoonWallT, db);
            doodad.TextName = "Silvermoon Wall_T";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\16x12Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadSilvermoonWallStraightDoor(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.SilvermoonWallStraightDoor, db);
            doodad.TextName = "Silvermoon Wall Door";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\16x8Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadSilvermoonWallStraightDoorShort(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.SilvermoonWallStraightDoorShort, db);
            doodad.TextName = "Silvermoon Wall Door (Short)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\8x8Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadSilvermoonWallCorner(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.SilvermoonWallCorner, db);
            doodad.TextName = "Silvermoon Wall Corner";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\16x16Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadSilvermoonWallEndcap(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.SilvermoonWallEndcap, db);
            doodad.TextName = "Silvermoon Wall Endcap";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\8x8Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadSilvermoonArchwayEntrance(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.SilvermoonArchwayEntrance, db);
            doodad.TextName = "Silvermoon Archway Entrance";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityArch.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadSilvermoonArchwayEntrance45(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.SilvermoonArchwayEntrance45, db);
            doodad.TextName = "Silvermoon Archway Entrance (45)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityArch45.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadSilvermoonArchway(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.SilvermoonArchway, db);
            doodad.TextName = "Silvermoon Archway";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityArch.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadSilvermoonArchway45(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.SilvermoonArchway45, db);
            doodad.TextName = "Silvermoon Archway (45)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\CityArch45.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadLargeSilvermoonTower(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.LargeSilvermoonTower, db);
            doodad.TextName = "Silvermoon Tower (X-Large)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Y";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\12x12Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadExteriorMainTower(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.ExteriorMainTower, db);
            doodad.TextName = "Exterior Main Tower";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Z";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\24x24Unflyable.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadExteriorTower(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.ExteriorTower, db);
            doodad.TextName = "Exterior Tower";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Z";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadExteriorWall(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.ExteriorWall, db);
            doodad.TextName = "Exterior Wall";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Z";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadExteriorGate(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.ExteriorGate, db);
            doodad.TextName = "Exterior Gate";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Z";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadArchwayStandardDimension(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.ArchwayStandardDimension, db);
            doodad.TextName = "Archway (Standard Dimension)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "Z";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\28x6Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadStatueOfAzshara_SA02(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.StatueOfAzshara_SA02, db);
            doodad.TextName = "Statue of Azshara";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "Z";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\12x12Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadCorpseOfGul2Dan(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.CorpseOfGul2Dan, db);
            doodad.TextName = "Corpse of Gul’Dan";
            doodad.EditorCategoryRaw = "O";
            doodad.EditorTilesetsRaw = "Z";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadVioletHoldMainStructure(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.VioletHoldMainStructure, db);
            doodad.TextName = "VioletHoldMainStructure";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\16x16Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadVioletHoldSpire(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.VioletHoldSpire, db);
            doodad.TextName = "Violet Hold Spire";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\12x12Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadVioletHoldSpireSmall(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.VioletHoldSpireSmall, db);
            doodad.TextName = "Violet Hold Spire (Small)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\8x8Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadVioletHoldArchwayEndpiece(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.VioletHoldArchwayEndpiece, db);
            doodad.TextName = "Violet Hold Archway Endpiece";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 0;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\48x16Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadMagusTurret(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.MagusTurret, db);
            doodad.TextName = "Magus Turret";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\12x12Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadMagusHighrise(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.MagusHighrise, db);
            doodad.TextName = "Magus Highrise";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\8x16Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadMagusConservatory(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.MagusConservatory, db);
            doodad.TextName = "Magus Conservatory";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\8x8Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadSunreaverArchway(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.SunreaverArchway, db);
            doodad.TextName = "Sunreaver Archway";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\28x6Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadSunreaverDome(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.SunreaverDome, db);
            doodad.TextName = "Sunreaver Dome";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\16x16Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadSunreaverDomeSmall(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.SunreaverDomeSmall, db);
            doodad.TextName = "Sunreaver Dome (Small)";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\12x12Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadSunreaverSpire(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.SunreaverSpire, db);
            doodad.TextName = "Sunreaver Spire";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\8x8Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadEnclaveMainStructure(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.EnclaveMainStructure, db);
            doodad.TextName = "Enclave Main Structure";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\24x24Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadEnclaveSpire(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.EnclaveSpire, db);
            doodad.TextName = "Enclave Spire";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 1;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\8x8Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadEnclaveHouse(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.EnclaveHouse, db);
            doodad.TextName = "Enclave House";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\12x8Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadEnclaveHouseB(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.EnclaveHouseB, db);
            doodad.TextName = "Enclave House B";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\12x8Default.tga";
            doodad.ArtMinimapShowRaw = 1;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadEnclaveTurret(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.EnclaveTurret, db);
            doodad.TextName = "Enclave Turret";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\8x8Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadRuneweaverSquareFountain(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.RuneweaverSquareFountain, db);
            doodad.TextName = "Runeweaver Square Fountain";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\8x8Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadBuildingA(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.BuildingA, db);
            doodad.TextName = "Building A";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\24x12Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadBuildingB(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.BuildingB, db);
            doodad.TextName = "Building B";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\24x16Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadBuildingC(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.BuildingC, db);
            doodad.TextName = "Building C";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\24x16Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadWallStraightShort_WSs0(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.WallStraightShort_WSs0, db);
            doodad.TextName = "Wall Straight Short";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\4x8Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadWallStraight(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.WallStraight, db);
            doodad.TextName = "Wall Straight";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 1;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\16x8Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadWallStraightLong_WSl0(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.WallStraightLong_WSl0, db);
            doodad.TextName = "Wall Straight Long";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 1;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\22x8Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadWallT(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.WallT, db);
            doodad.TextName = "Wall T";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\16x12Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadWallTAlt(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.WallTAlt, db);
            doodad.TextName = "Wall T Alt";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\16x12Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadWallSpire(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.WallSpire, db);
            doodad.TextName = "Wall Spire";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\16x8Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadWallSpireAlt(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.WallSpireAlt, db);
            doodad.TextName = "Wall Spire Alt";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\8x8Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadWall90Degree(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Wall90Degree, db);
            doodad.TextName = "Wall 90 Degree";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\16x16Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadWallEndcap_WE00(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.WallEndcap_WE00, db);
            doodad.TextName = "Wall Endcap";
            doodad.EditorCategoryRaw = "S";
            doodad.EditorTilesetsRaw = "X,J";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "PathTextures\\8x8Default.tga";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        protected virtual Doodad LoadFlowers_ZPf0(ObjectDatabaseBase db)
        {
            var doodad = new Doodad(DoodadType.Flowers_ZPf0, db);
            doodad.TextName = "Tulips";
            doodad.EditorCategoryRaw = "E";
            doodad.EditorTilesetsRaw = "Z,L,F,A,C,X,J,Y,V,Q";
            doodad.EditorHasTilesetSpecificDataRaw = 0;
            doodad.EditorUseClickHelperRaw = 0;
            doodad.EditorIgnoreModelClicksRaw = 0;
            doodad.PathingWalkableRaw = 0;
            doodad.EditorPlaceableOnCliffsRaw = 1;
            doodad.EditorPlaceableOnWaterRaw = 1;
            doodad.ArtFloatsRaw = 0;
            doodad.ArtShowInFogRaw = 1;
            doodad.ArtAnimateInFogRaw = 0;
            doodad.PathingPathingTextureRaw = "none";
            doodad.ArtMinimapShowRaw = 0;
            doodad.ArtMinimapUseCustomColorRaw = 0;
            doodad.ArtMinimapColor1Red = 0;
            doodad.ArtMinimapColor2Green = 0;
            doodad.ArtMinimapColor3Blue = 0;
            doodad.EditorOnUserSpecifiedListRaw = 0;
            return doodad;
        }

        public Doodad Load(DoodadType doodadType, ObjectDatabaseBase db)
        {
            return doodadType switch
            {
            DoodadType.Mushrooms_APms => LoadMushrooms_APms(db), DoodadType.HollowStump_AOhs => LoadHollowStump_AOhs(db), DoodadType.ThornyVines_APtv => LoadThornyVines_APtv(db), DoodadType.Cattail_APct => LoadCattail_APct(db), DoodadType.Birds => LoadBirds(db), DoodadType.SkullBrazier => LoadSkullBrazier(db), DoodadType.Fish => LoadFish(db), DoodadType.GuardianStatueOfAszune => LoadGuardianStatueOfAszune(db), DoodadType.KeeperStatue => LoadKeeperStatue(db), DoodadType.StraightLog_AOlg => LoadStraightLog_AOlg(db), DoodadType.AngledLog_AOla => LoadAngledLog_AOla(db), DoodadType.GlowingObelisk => LoadGlowingObelisk(db), DoodadType.Obelisk_AOsk => LoadObelisk_AOsk(db), DoodadType.BrokenObelisk_AObo => LoadBrokenObelisk_AObo(db), DoodadType.ScorchedRemains => LoadScorchedRemains(db), DoodadType.Bush_APbs => LoadBush_APbs(db), DoodadType.LilyPads => LoadLilyPads(db), DoodadType.FloatingLilyPads_AWfl => LoadFloatingLilyPads_AWfl(db), DoodadType.Rocks_ARrk => LoadRocks_ARrk(db), DoodadType.BrokenColumn_ASbc => LoadBrokenColumn_ASbc(db), DoodadType.BlackRuinedRubble_ASbr => LoadBlackRuinedRubble_ASbr(db), DoodadType.RuinedBlocks_ASHB => LoadRuinedBlocks_ASHB(db), DoodadType.Archway_ASra => LoadArchway_ASra(db), DoodadType.Archway_ASr1 => LoadArchway_ASr1(db), DoodadType.WorldTree => LoadWorldTree(db), DoodadType.Cactus => LoadCactus(db), DoodadType.Bones_BObo => LoadBones_BObo(db), DoodadType.Totem_BOct => LoadTotem_BOct(db), DoodadType.Throne_BOth => LoadThrone_BOth(db), DoodadType.Totem_BOtt => LoadTotem_BOtt(db), DoodadType.Crater => LoadCrater(db), DoodadType.Fissure_BRfs => LoadFissure_BRfs(db), DoodadType.Rocks_BRrk => LoadRocks_BRrk(db), DoodadType.PillarOfRock => LoadPillarOfRock(db), DoodadType.RockSpires_BRrs => LoadRockSpires_BRrs(db), DoodadType.RockSpiresCinematic => LoadRockSpiresCinematic(db), DoodadType.SmallRockSpires_BRsp => LoadSmallRockSpires_BRsp(db), DoodadType.Geyser => LoadGeyser(db), DoodadType.RuinedArch => LoadRuinedArch(db), DoodadType.Archway_BSra => LoadArchway_BSra(db), DoodadType.Archway_BSr1 => LoadArchway_BSr1(db), DoodadType.RuinedChunk => LoadRuinedChunk(db), DoodadType.RuinedCurvedWall => LoadRuinedCurvedWall(db), DoodadType.RuinedWall => LoadRuinedWall(db), DoodadType.BlightedMist => LoadBlightedMist(db), DoodadType.HollowStump_COhs => LoadHollowStump_COhs(db), DoodadType.StraightLog_COlg => LoadStraightLog_COlg(db), DoodadType.AngledLog_COla => LoadAngledLog_COla(db), DoodadType.Obelisk_COob => LoadObelisk_COob(db), DoodadType.BrokenObelisk_CObo => LoadBrokenObelisk_CObo(db), DoodadType.Bush_CPbs => LoadBush_CPbs(db), DoodadType.Cattail_CPct => LoadCattail_CPct(db), DoodadType.Mushrooms_CPms => LoadMushrooms_CPms(db), DoodadType.LilyPad => LoadLilyPad(db), DoodadType.Fissure_CRfs => LoadFissure_CRfs(db), DoodadType.RockSpires_CRrs => LoadRockSpires_CRrs(db), DoodadType.BrokenColumn_CSbc => LoadBrokenColumn_CSbc(db), DoodadType.BlackRuinedRubble_CSbr => LoadBlackRuinedRubble_CSbr(db), DoodadType.RuinedBlocks_CSbl => LoadRuinedBlocks_CSbl(db), DoodadType.Archway_CSra => LoadArchway_CSra(db), DoodadType.AngledArchway_CSr1 => LoadAngledArchway_CSr1(db), DoodadType.Corn => LoadCorn(db), DoodadType.FloatingLilyPads_LPfp => LoadFloatingLilyPads_LPfp(db), DoodadType.LillyPad => LoadLillyPad(db), DoodadType.RiverRushes => LoadRiverRushes(db), DoodadType.WheatBunch => LoadWheatBunch(db), DoodadType.Wheat => LoadWheat(db), DoodadType.ScorchedGrain => LoadScorchedGrain(db), DoodadType.ArcheryTarget => LoadArcheryTarget(db), DoodadType.ArmorRack => LoadArmorRack(db), DoodadType.HumanBanner => LoadHumanBanner(db), DoodadType.OrcBanner => LoadOrcBanner(db), DoodadType.TutorialOrcBanner => LoadTutorialOrcBanner(db), DoodadType.Brazier => LoadBrazier(db), DoodadType.GlowingBrazier => LoadGlowingBrazier(db), DoodadType.EmptyCage_LOce => LoadEmptyCage_LOce(db), DoodadType.CauldronWithHeads => LoadCauldronWithHeads(db), DoodadType.EmptyCage_LOct => LoadEmptyCage_LOct(db), DoodadType.Flies => LoadFlies(db), DoodadType.Grave_LOgr => LoadGrave_LOgr(db), DoodadType.Hay => LoadHay(db), DoodadType.HayCart => LoadHayCart(db), DoodadType.BrokenHayCart => LoadBrokenHayCart(db), DoodadType.HayCartInfected => LoadHayCartInfected(db), DoodadType.BrokenHayCartInfected => LoadBrokenHayCartInfected(db), DoodadType.HayClump => LoadHayClump(db), DoodadType.HeadOnSpear => LoadHeadOnSpear(db), DoodadType.HitchingPost => LoadHitchingPost(db), DoodadType.ImpaledCorpse => LoadImpaledCorpse(db), DoodadType.LanternPost_LOlp => LoadLanternPost_LOlp(db), DoodadType.PeasantGrave => LoadPeasantGrave(db), DoodadType.RibBones => LoadRibBones(db), DoodadType.HayInfected => LoadHayInfected(db), DoodadType.SignPost => LoadSignPost(db), DoodadType.SittingCorpse => LoadSittingCorpse(db), DoodadType.SkullsOnStick => LoadSkullsOnStick(db), DoodadType.SkullPile => LoadSkullPile(db), DoodadType.SmokeSmudge => LoadSmokeSmudge(db), DoodadType.StoneWall => LoadStoneWall(db), DoodadType.Torch => LoadTorch(db), DoodadType.GlowingTorch => LoadGlowingTorch(db), DoodadType.Trash_LOt1 => LoadTrash_LOt1(db), DoodadType.Trough => LoadTrough(db), DoodadType.Wheelbarrel => LoadWheelbarrel(db), DoodadType.BrokenWheelbarrel => LoadBrokenWheelbarrel(db), DoodadType.WeaponRack => LoadWeaponRack(db), DoodadType.Rocks_LRrk => LoadRocks_LRrk(db), DoodadType.Barn => LoadBarn(db), DoodadType.ElvenBuilding => LoadElvenBuilding(db), DoodadType.ScorchedBarn => LoadScorchedBarn(db), DoodadType.ScorchedFarm => LoadScorchedFarm(db), DoodadType.Granary => LoadGranary(db), DoodadType.ScorchedGranary => LoadScorchedGranary(db), DoodadType.Inn => LoadInn(db), DoodadType.RockArchway_LSra => LoadRockArchway_LSra(db), DoodadType.AngledRockArchway_LSr1 => LoadAngledRockArchway_LSr1(db), DoodadType.ScorchedInn => LoadScorchedInn(db), DoodadType.ScorchedTower => LoadScorchedTower(db), DoodadType.Well => LoadWell(db), DoodadType.BurnedWindMill => LoadBurnedWindMill(db), DoodadType.WindMill => LoadWindMill(db), DoodadType.BrokenColumn_NObc => LoadBrokenColumn_NObc(db), DoodadType.BrokenObelisk_NObk => LoadBrokenObelisk_NObk(db), DoodadType.Bones_NObo => LoadBones_NObo(db), DoodadType.Fence => LoadFence(db), DoodadType.AngledFence => LoadAngledFence(db), DoodadType.StoneGrave => LoadStoneGrave(db), DoodadType.Obelisk_NOok => LoadObelisk_NOok(db), DoodadType.Tombstone => LoadTombstone(db), DoodadType.FloatingBox => LoadFloatingBox(db), DoodadType.FloatingPlank => LoadFloatingPlank(db), DoodadType.IceFloe_NWf1 => LoadIceFloe_NWf1(db), DoodadType.IceFloe_NWf2 => LoadIceFloe_NWf2(db), DoodadType.IceFloe_NWf3 => LoadIceFloe_NWf3(db), DoodadType.IceFloe_NWf4 => LoadIceFloe_NWf4(db), DoodadType.Iceberg_NWi1 => LoadIceberg_NWi1(db), DoodadType.Iceberg_NWi2 => LoadIceberg_NWi2(db), DoodadType.Iceberg_NWi3 => LoadIceberg_NWi3(db), DoodadType.Iceberg_NWi4 => LoadIceberg_NWi4(db), DoodadType.FloatingPanel => LoadFloatingPanel(db), DoodadType.FirePit => LoadFirePit(db), DoodadType.FirePitWPig => LoadFirePitWPig(db), DoodadType.TrashedFirePit => LoadTrashedFirePit(db), DoodadType.Bats => LoadBats(db), DoodadType.Rowboat => LoadRowboat(db), DoodadType.DestroyedRowboat => LoadDestroyedRowboat(db), DoodadType.Ship => LoadShip(db), DoodadType.DestroyedShip => LoadDestroyedShip(db), DoodadType.Whale => LoadWhale(db), DoodadType.ThornyVines_NPth => LoadThornyVines_NPth(db), DoodadType.Fissure_NRfs => LoadFissure_NRfs(db), DoodadType.IceClaws => LoadIceClaws(db), DoodadType.Rocks_NRrk => LoadRocks_NRrk(db), DoodadType.WebbedRocks => LoadWebbedRocks(db), DoodadType.Crypt => LoadCrypt(db), DoodadType.Archway_NSra => LoadArchway_NSra(db), DoodadType.AngledArchway_NSr1 => LoadAngledArchway_NSr1(db), DoodadType.Rubble_NSrb => LoadRubble_NSrb(db), DoodadType.LongFence => LoadLongFence(db), DoodadType.AngledLongFence => LoadAngledLongFence(db), DoodadType.ShortFence => LoadShortFence(db), DoodadType.AngledShortFence => LoadAngledShortFence(db), DoodadType.Building => LoadBuilding(db), DoodadType.LongBlueBanner => LoadLongBlueBanner(db), DoodadType.LongWhiteBanner => LoadLongWhiteBanner(db), DoodadType.StoneBench => LoadStoneBench(db), DoodadType.AngledStoneBench => LoadAngledStoneBench(db), DoodadType.AlonsusChapel_YOsb => LoadAlonsusChapel_YOsb(db), DoodadType.AlonsusChapel_YOmb => LoadAlonsusChapel_YOmb(db), DoodadType.ClockTower => LoadClockTower(db), DoodadType.MarketStallSmall => LoadMarketStallSmall(db), DoodadType.MarketItemBaubles => LoadMarketItemBaubles(db), DoodadType.MarketItemBaublesAlt => LoadMarketItemBaublesAlt(db), DoodadType.MarketItemProduce => LoadMarketItemProduce(db), DoodadType.MarketItemProduceAlt => LoadMarketItemProduceAlt(db), DoodadType.MarketItemTextiles => LoadMarketItemTextiles(db), DoodadType.MarketItemTextilesAlt => LoadMarketItemTextilesAlt(db), DoodadType.WoodBench => LoadWoodBench(db), DoodadType.AngledWoodBench => LoadAngledWoodBench(db), DoodadType.Fountain => LoadFountain(db), DoodadType.Grave_YOgr => LoadGrave_YOgr(db), DoodadType.Obelisk_YOob => LoadObelisk_YOob(db), DoodadType.LanternPost_YOlp => LoadLanternPost_YOlp(db), DoodadType.Statue => LoadStatue(db), DoodadType.ShieldlessStatue => LoadShieldlessStatue(db), DoodadType.PowerGenerator => LoadPowerGenerator(db), DoodadType.MagicalLantern => LoadMagicalLantern(db), DoodadType.MagicalRunes => LoadMagicalRunes(db), DoodadType.TavernSign => LoadTavernSign(db), DoodadType.BobSGunsSign => LoadBobSGunsSign(db), DoodadType.TraceySArmorySign => LoadTraceySArmorySign(db), DoodadType.EmptyCrates => LoadEmptyCrates(db), DoodadType.Throne_YOth => LoadThrone_YOth(db), DoodadType.WhaleStatue => LoadWhaleStatue(db), DoodadType.KingTerenasStatue => LoadKingTerenasStatue(db), DoodadType.IronGateA => LoadIronGateA(db), DoodadType.IronGateB => LoadIronGateB(db), DoodadType.Bush_YPbs => LoadBush_YPbs(db), DoodadType.TreePlanter => LoadTreePlanter(db), DoodadType.StraightFlowerBed => LoadStraightFlowerBed(db), DoodadType.AngledFlowerBed => LoadAngledFlowerBed(db), DoodadType.PottedPlant => LoadPottedPlant(db), DoodadType.Archway_YSaw => LoadArchway_YSaw(db), DoodadType.AngledArchway_YSa1 => LoadAngledArchway_YSa1(db), DoodadType.ArchwayEntrance => LoadArchwayEntrance(db), DoodadType.AngledArchwayEntrance => LoadAngledArchwayEntrance(db), DoodadType.Cathedral => LoadCathedral(db), DoodadType.SingleColumn => LoadSingleColumn(db), DoodadType.DoubleColumn => LoadDoubleColumn(db), DoodadType.DoubleColumn45 => LoadDoubleColumn45(db), DoodadType.ColumnSemiCircle => LoadColumnSemiCircle(db), DoodadType.ColumnSemiCircle2 => LoadColumnSemiCircle2(db), DoodadType.ColumnSemiCircle3 => LoadColumnSemiCircle3(db), DoodadType.ColumnSemiCircle4 => LoadColumnSemiCircle4(db), DoodadType.ShortWallEnd => LoadShortWallEnd(db), DoodadType.LowWall_YSw0 => LoadLowWall_YSw0(db), DoodadType.LowWall_YSw1 => LoadLowWall_YSw1(db), DoodadType.LowWall_YSw2 => LoadLowWall_YSw2(db), DoodadType.LowWall_YSw3 => LoadLowWall_YSw3(db), DoodadType.WallCorner_YSw4 => LoadWallCorner_YSw4(db), DoodadType.WallEndcap_YSw5 => LoadWallEndcap_YSw5(db), DoodadType.WallStaright => LoadWallStaright(db), DoodadType.WallCorner_YSw7 => LoadWallCorner_YSw7(db), DoodadType.WallStraightLong_YSw8 => LoadWallStraightLong_YSw8(db), DoodadType.WallStraightShort_YSw9 => LoadWallStraightShort_YSw9(db), DoodadType.WallStraightTee => LoadWallStraightTee(db), DoodadType.WallStraightTeeAlt => LoadWallStraightTeeAlt(db), DoodadType.WallEntrance => LoadWallEntrance(db), DoodadType.WallDoor => LoadWallDoor(db), DoodadType.WallDoorShort => LoadWallDoorShort(db), DoodadType.TallWallEnd => LoadTallWallEnd(db), DoodadType.LanternWallEnd => LoadLanternWallEnd(db), DoodadType.Tavern => LoadTavern(db), DoodadType.DeadFish => LoadDeadFish(db), DoodadType.Rocks_CRrk => LoadRocks_CRrk(db), DoodadType.Rocks_DRrk => LoadRocks_DRrk(db), DoodadType.LightningBolt => LoadLightningBolt(db), DoodadType.Fire => LoadFire(db), DoodadType.BlueFire => LoadBlueFire(db), DoodadType.SmallFire => LoadSmallFire(db), DoodadType.SideFireTrap => LoadSideFireTrap(db), DoodadType.FireTrap => LoadFireTrap(db), DoodadType.FireGust => LoadFireGust(db), DoodadType.SideFrostTrap => LoadSideFrostTrap(db), DoodadType.FrostTrap => LoadFrostTrap(db), DoodadType.Archway_DSar => LoadArchway_DSar(db), DoodadType.AngledArchway_DSa1 => LoadAngledArchway_DSa1(db), DoodadType.StoneArchway_DSah => LoadStoneArchway_DSah(db), DoodadType.StoneArchway_DSa2 => LoadStoneArchway_DSa2(db), DoodadType.PileOfTreasure => LoadPileOfTreasure(db), DoodadType.PileOfJunk => LoadPileOfJunk(db), DoodadType.Chains => LoadChains(db), DoodadType.ChainPost => LoadChainPost(db), DoodadType.FieryCrater_DRfc => LoadFieryCrater_DRfc(db), DoodadType.Stalagmite_DRst => LoadStalagmite_DRst(db), DoodadType.LavaCracks_DOlc => LoadLavaCracks_DOlc(db), DoodadType.Chair_DOcr => LoadChair_DOcr(db), DoodadType.Bench => LoadBench(db), DoodadType.Bookshelf => LoadBookshelf(db), DoodadType.LargeBookshelf => LoadLargeBookshelf(db), DoodadType.LongBookshelf => LoadLongBookshelf(db), DoodadType.AngledBookshelf => LoadAngledBookshelf(db), DoodadType.Obelisk_DOob => LoadObelisk_DOob(db), DoodadType.Table => LoadTable(db), DoodadType.TableAndChair => LoadTableAndChair(db), DoodadType.IronMaiden => LoadIronMaiden(db), DoodadType.TortureTable => LoadTortureTable(db), DoodadType.MineCart => LoadMineCart(db), DoodadType.EmptyMineCart => LoadEmptyMineCart(db), DoodadType.BarredWall_DSp0 => LoadBarredWall_DSp0(db), DoodadType.BarredWall_DSp9 => LoadBarredWall_DSp9(db), DoodadType.BlueMushroom => LoadBlueMushroom(db), DoodadType.Rocks_GRrk => LoadRocks_GRrk(db), DoodadType.FieryCrater_GRfc => LoadFieryCrater_GRfc(db), DoodadType.Stalagmite_GRst => LoadStalagmite_GRst(db), DoodadType.Obelisk_GOob => LoadObelisk_GOob(db), DoodadType.StoneArchway_GSah => LoadStoneArchway_GSah(db), DoodadType.StoneArchway_GSa2 => LoadStoneArchway_GSa2(db), DoodadType.Archway_GSar => LoadArchway_GSar(db), DoodadType.Archway_GSa1 => LoadArchway_GSa1(db), DoodadType.BarredWall_GSp0 => LoadBarredWall_GSp0(db), DoodadType.BarredWall_GSp9 => LoadBarredWall_GSp9(db), DoodadType.LavaCracks_GOlc => LoadLavaCracks_GOlc(db), DoodadType.WaterfallEffect => LoadWaterfallEffect(db), DoodadType.Cave0 => LoadCave0(db), DoodadType.Cave2 => LoadCave2(db), DoodadType.SunWell => LoadSunWell(db), DoodadType.CameraProp => LoadCameraProp(db), DoodadType.CityBuilding_YS00 => LoadCityBuilding_YS00(db), DoodadType.CityBuilding_YS01 => LoadCityBuilding_YS01(db), DoodadType.CityBuilding_YS02 => LoadCityBuilding_YS02(db), DoodadType.CityBuilding_YS03 => LoadCityBuilding_YS03(db), DoodadType.CityBuilding_YS04 => LoadCityBuilding_YS04(db), DoodadType.CityBuilding_YS05 => LoadCityBuilding_YS05(db), DoodadType.CityBuilding_YS06 => LoadCityBuilding_YS06(db), DoodadType.CityBuilding_YS07 => LoadCityBuilding_YS07(db), DoodadType.CityBuilding_YS08 => LoadCityBuilding_YS08(db), DoodadType.CityBuilding_YS09 => LoadCityBuilding_YS09(db), DoodadType.CityBuilding_YS10 => LoadCityBuilding_YS10(db), DoodadType.CityBuilding_YS11 => LoadCityBuilding_YS11(db), DoodadType.LargeCityBuilding_YS12 => LoadLargeCityBuilding_YS12(db), DoodadType.LargeCityBuilding_YS13 => LoadLargeCityBuilding_YS13(db), DoodadType.LargeCityBuilding_YS14 => LoadLargeCityBuilding_YS14(db), DoodadType.LargeCityBuilding_YS15 => LoadLargeCityBuilding_YS15(db), DoodadType.EnergyField => LoadEnergyField(db), DoodadType.ThrallSHut => LoadThrallSHut(db), DoodadType.RuinsBrazier => LoadRuinsBrazier(db), DoodadType.RuinsStatue => LoadRuinsStatue(db), DoodadType.RuinsBrokenStatue => LoadRuinsBrokenStatue(db), DoodadType.RuinsStones => LoadRuinsStones(db), DoodadType.Archway_ZSar => LoadArchway_ZSar(db), DoodadType.Archway_ZSa1 => LoadArchway_ZSa1(db), DoodadType.Archway_ZSas => LoadArchway_ZSas(db), DoodadType.Archway_ZSs1 => LoadArchway_ZSs1(db), DoodadType.RuinedArchway_ZSab => LoadRuinedArchway_ZSab(db), DoodadType.RuinedArchway_ZSb1 => LoadRuinedArchway_ZSb1(db), DoodadType.GreenFish => LoadGreenFish(db), DoodadType.SchoolOfFish => LoadSchoolOfFish(db), DoodadType.Ruins => LoadRuins(db), DoodadType.RuinsFountain => LoadRuinsFountain(db), DoodadType.RuinsObelisk => LoadRuinsObelisk(db), DoodadType.RuinsThrone => LoadRuinsThrone(db), DoodadType.Rocks_IRrk => LoadRocks_IRrk(db), DoodadType.RuinsPillar => LoadRuinsPillar(db), DoodadType.Shells => LoadShells(db), DoodadType.CityCliffCave1 => LoadCityCliffCave1(db), DoodadType.CityCliffCave2 => LoadCityCliffCave2(db), DoodadType.CityCliffCave3 => LoadCityCliffCave3(db), DoodadType.CityCliffCave4 => LoadCityCliffCave4(db), DoodadType.CityCliffCollapse1 => LoadCityCliffCollapse1(db), DoodadType.CityCliffCollapse2 => LoadCityCliffCollapse2(db), DoodadType.CityCliffCollapse3 => LoadCityCliffCollapse3(db), DoodadType.CityCliffCollapse4 => LoadCityCliffCollapse4(db), DoodadType.RuinedCrystalTower => LoadRuinedCrystalTower(db), DoodadType.RuinedTower_ZOdt => LoadRuinedTower_ZOdt(db), DoodadType.RuinedTower_ZOd2 => LoadRuinedTower_ZOd2(db), DoodadType.RuinedTowerBase => LoadRuinedTowerBase(db), DoodadType.RuinedDoubleBase_ZOtb => LoadRuinedDoubleBase_ZOtb(db), DoodadType.RuinedDoubleBase_ZOt2 => LoadRuinedDoubleBase_ZOt2(db), DoodadType.RuinedVioletCitadel => LoadRuinedVioletCitadel(db), DoodadType.RuinsFirepot => LoadRuinsFirepot(db), DoodadType.Rocks_ZRrk => LoadRocks_ZRrk(db), DoodadType.CliffsideVines_ZCv1 => LoadCliffsideVines_ZCv1(db), DoodadType.CliffsideVines_ZCv2 => LoadCliffsideVines_ZCv2(db), DoodadType.Seaweed => LoadSeaweed(db), DoodadType.Bubbles => LoadBubbles(db), DoodadType.SteamBubbles => LoadSteamBubbles(db), DoodadType.FloatingIce => LoadFloatingIce(db), DoodadType.IcyWaterfallEffect => LoadIcyWaterfallEffect(db), DoodadType.Flowers_ZPfw => LoadFlowers_ZPfw(db), DoodadType.Shrub => LoadShrub(db), DoodadType.Lilypad => LoadLilypad(db), DoodadType.CatTail => LoadCatTail(db), DoodadType.Coral => LoadCoral(db), DoodadType.CoralArch => LoadCoralArch(db), DoodadType.DemonicFootprints => LoadDemonicFootprints(db), DoodadType.SkullTorch => LoadSkullTorch(db), DoodadType.IceArchway_ISar => LoadIceArchway_ISar(db), DoodadType.IceArchway_ISa1 => LoadIceArchway_ISa1(db), DoodadType.Obelisk_IOob => LoadObelisk_IOob(db), DoodadType.Pillar => LoadPillar(db), DoodadType.IceBlock => LoadIceBlock(db), DoodadType.StatueOfAzshara_DOas => LoadStatueOfAzshara_DOas(db), DoodadType.Snowman => LoadSnowman(db), DoodadType.RockSpires_ZRrs => LoadRockSpires_ZRrs(db), DoodadType.SmallRockSpires_ZRsp => LoadSmallRockSpires_ZRsp(db), DoodadType.Rocks_ORrk => LoadRocks_ORrk(db), DoodadType.RockSpires_ORrs => LoadRockSpires_ORrs(db), DoodadType.IceSpiderOnPedestal => LoadIceSpiderOnPedestal(db), DoodadType.IceSpiderStatue => LoadIceSpiderStatue(db), DoodadType.RuinedShip => LoadRuinedShip(db), DoodadType.Plants => LoadPlants(db), DoodadType.Glacier => LoadGlacier(db), DoodadType.MagmaRock => LoadMagmaRock(db), DoodadType.RuinedFloor2x2_YCx1 => LoadRuinedFloor2x2_YCx1(db), DoodadType.RuinedFloor2x2_YCx2 => LoadRuinedFloor2x2_YCx2(db), DoodadType.RuinedFloor2x2_YCx3 => LoadRuinedFloor2x2_YCx3(db), DoodadType.RuinedFloor2x2_YCx4 => LoadRuinedFloor2x2_YCx4(db), DoodadType.RuinedFloor4x4_YCx5 => LoadRuinedFloor4x4_YCx5(db), DoodadType.RuinedFloor4x4_YCx6 => LoadRuinedFloor4x4_YCx6(db), DoodadType.RuinedFloor4x2_YCx7 => LoadRuinedFloor4x2_YCx7(db), DoodadType.RuinedFloor4x2_YCx8 => LoadRuinedFloor4x2_YCx8(db), DoodadType.RoughCliffCave1 => LoadRoughCliffCave1(db), DoodadType.RoughCliffCave2 => LoadRoughCliffCave2(db), DoodadType.RoughCliffCave3 => LoadRoughCliffCave3(db), DoodadType.RoughCliffCave4 => LoadRoughCliffCave4(db), DoodadType.RoughCliffCollapse1 => LoadRoughCliffCollapse1(db), DoodadType.RoughCliffCollapse2 => LoadRoughCliffCollapse2(db), DoodadType.RoughCliffCollapse3 => LoadRoughCliffCollapse3(db), DoodadType.RoughCliffCollapse4 => LoadRoughCliffCollapse4(db), DoodadType.CityCliffSlide1 => LoadCityCliffSlide1(db), DoodadType.CityCliffSlide2 => LoadCityCliffSlide2(db), DoodadType.CityCliffSlide3 => LoadCityCliffSlide3(db), DoodadType.CityCliffSlide4 => LoadCityCliffSlide4(db), DoodadType.CityCliffCollapseShort1 => LoadCityCliffCollapseShort1(db), DoodadType.CityCliffCollapseShort2 => LoadCityCliffCollapseShort2(db), DoodadType.CityCliffCollapseShort3 => LoadCityCliffCollapseShort3(db), DoodadType.CityCliffCollapseShort4 => LoadCityCliffCollapseShort4(db), DoodadType.CityCliffSlideShort1 => LoadCityCliffSlideShort1(db), DoodadType.CityCliffSlideShort2 => LoadCityCliffSlideShort2(db), DoodadType.CityCliffSlideShort3 => LoadCityCliffSlideShort3(db), DoodadType.CityCliffSlideShort4 => LoadCityCliffSlideShort4(db), DoodadType.RoughCliffSlide1 => LoadRoughCliffSlide1(db), DoodadType.RoughCliffSlide2 => LoadRoughCliffSlide2(db), DoodadType.RoughCliffSlide3 => LoadRoughCliffSlide3(db), DoodadType.RoughCliffSlide4 => LoadRoughCliffSlide4(db), DoodadType.RoughCliffSlideShort1 => LoadRoughCliffSlideShort1(db), DoodadType.RoughCliffSlideShort2 => LoadRoughCliffSlideShort2(db), DoodadType.RoughCliffSlideShort3 => LoadRoughCliffSlideShort3(db), DoodadType.RoughCliffSlideShort4 => LoadRoughCliffSlideShort4(db), DoodadType.RoughCliffCollapseShort1 => LoadRoughCliffCollapseShort1(db), DoodadType.RoughCliffCollapseShort2 => LoadRoughCliffCollapseShort2(db), DoodadType.RoughCliffCollapseShort3 => LoadRoughCliffCollapseShort3(db), DoodadType.RoughCliffCollapseShort4 => LoadRoughCliffCollapseShort4(db), DoodadType.SmallRubble => LoadSmallRubble(db), DoodadType.LargeRubble => LoadLargeRubble(db), DoodadType.FloatingRock => LoadFloatingRock(db), DoodadType.FloatingRockCluster => LoadFloatingRockCluster(db), DoodadType.Pier => LoadPier(db), DoodadType.RuinedPier => LoadRuinedPier(db), DoodadType.Mushrooms_ZPms => LoadMushrooms_ZPms(db), DoodadType.VinyPlant => LoadVinyPlant(db), DoodadType.LibraryShelf => LoadLibraryShelf(db), DoodadType.RuinedCathedral => LoadRuinedCathedral(db), DoodadType.RuinedFountain => LoadRuinedFountain(db), DoodadType.GulDanSRunes => LoadGulDanSRunes(db), DoodadType.InvulnerabilityField => LoadInvulnerabilityField(db), DoodadType.CityBuilding_YSr0 => LoadCityBuilding_YSr0(db), DoodadType.CityBuilding_YSr1 => LoadCityBuilding_YSr1(db), DoodadType.CityBuilding_YSr2 => LoadCityBuilding_YSr2(db), DoodadType.CityBuilding_YSr3 => LoadCityBuilding_YSr3(db), DoodadType.CityBuilding_YSr4 => LoadCityBuilding_YSr4(db), DoodadType.CityBuilding_YSr5 => LoadCityBuilding_YSr5(db), DoodadType.CityBuilding_YSr6 => LoadCityBuilding_YSr6(db), DoodadType.CityBuilding_YSr7 => LoadCityBuilding_YSr7(db), DoodadType.CityBuilding_YSr8 => LoadCityBuilding_YSr8(db), DoodadType.CityBuilding_YSr9 => LoadCityBuilding_YSr9(db), DoodadType.CityBuilding_YSra => LoadCityBuilding_YSra(db), DoodadType.CityBuilding_YSrb => LoadCityBuilding_YSrb(db), DoodadType.LargeCityBuilding_YSrc => LoadLargeCityBuilding_YSrc(db), DoodadType.LargeCityBuilding_YSrd => LoadLargeCityBuilding_YSrd(db), DoodadType.LargeCityBuilding_YSre => LoadLargeCityBuilding_YSre(db), DoodadType.LargeCityBuilding_YSrf => LoadLargeCityBuilding_YSrf(db), DoodadType.CityBuildingRow_YSbr => LoadCityBuildingRow_YSbr(db), DoodadType.CityBuildingRow_YSb1 => LoadCityBuildingRow_YSb1(db), DoodadType.CityBuildingRow_YSb2 => LoadCityBuildingRow_YSb2(db), DoodadType.EyeOfSargeras => LoadEyeOfSargeras(db), DoodadType.ColumnSemiCircleRuined => LoadColumnSemiCircleRuined(db), DoodadType.ColumnSemiCircle2Ruined => LoadColumnSemiCircle2Ruined(db), DoodadType.ColumnSemiCircle3Ruined => LoadColumnSemiCircle3Ruined(db), DoodadType.ColumnSemiCircle4Ruined => LoadColumnSemiCircle4Ruined(db), DoodadType.SingleColumnRuined_JSco => LoadSingleColumnRuined_JSco(db), DoodadType.SingleColumnRuined_JScx => LoadSingleColumnRuined_JScx(db), DoodadType.LargeCityBuildingRuinedBase => LoadLargeCityBuildingRuinedBase(db), DoodadType.CityBuildingRuinedBase => LoadCityBuildingRuinedBase(db), DoodadType.ArchwayRuined_JSar => LoadArchwayRuined_JSar(db), DoodadType.ArchwayRuined_JSax => LoadArchwayRuined_JSax(db), DoodadType.Dust => LoadDust(db), DoodadType.RuinedGoblinShipyard => LoadRuinedGoblinShipyard(db), DoodadType.TotemLantern => LoadTotemLantern(db), DoodadType.SewerVent => LoadSewerVent(db), DoodadType.SewerWallpipes => LoadSewerWallpipes(db), DoodadType.WallFountain => LoadWallFountain(db), DoodadType.Runes => LoadRunes(db), DoodadType.ShimmeringPortal => LoadShimmeringPortal(db), DoodadType.ElvenFishingVillage_ASv0 => LoadElvenFishingVillage_ASv0(db), DoodadType.ElvenFishingVillage_ASv1 => LoadElvenFishingVillage_ASv1(db), DoodadType.ElvenFishingVillage_ASv2 => LoadElvenFishingVillage_ASv2(db), DoodadType.ElvenFishingVillage_ASv3 => LoadElvenFishingVillage_ASv3(db), DoodadType.ElvenFishingVillage_ASv4 => LoadElvenFishingVillage_ASv4(db), DoodadType.RuinedElvenFishingVillage_ASx0 => LoadRuinedElvenFishingVillage_ASx0(db), DoodadType.RuinedElvenFishingVillage_ASx1 => LoadRuinedElvenFishingVillage_ASx1(db), DoodadType.RuinedElvenFishingVillage_ASx2 => LoadRuinedElvenFishingVillage_ASx2(db), DoodadType.Trash_ZOtr => LoadTrash_ZOtr(db), DoodadType.BloodyAltar => LoadBloodyAltar(db), DoodadType.RisingWater => LoadRisingWater(db), DoodadType.BlackCitadelStatue => LoadBlackCitadelStatue(db), DoodadType.TheFrozenThrone => LoadTheFrozenThrone(db), DoodadType.IceyChair => LoadIceyChair(db), DoodadType.Crystal => LoadCrystal(db), DoodadType.StoneArchway_ISsr => LoadStoneArchway_ISsr(db), DoodadType.AngledStoneArchway => LoadAngledStoneArchway(db), DoodadType.Chair_IOch => LoadChair_IOch(db), DoodadType.Altar => LoadAltar(db), DoodadType.FlameGrate => LoadFlameGrate(db), DoodadType.Obstacle => LoadObstacle(db), DoodadType.Skull => LoadSkull(db), DoodadType.Stake => LoadStake(db), DoodadType.Rubble_ORrr => LoadRubble_ORrr(db), DoodadType.UndergroundDome => LoadUndergroundDome(db), DoodadType.Standard => LoadStandard(db), DoodadType.SnowyRocks => LoadSnowyRocks(db), DoodadType.Rubble_ISrb => LoadRubble_ISrb(db), DoodadType.GlowingRunes => LoadGlowingRunes(db), DoodadType.BarrensTree => LoadBarrensTree(db), DoodadType.SunkenRuinsTree => LoadSunkenRuinsTree(db), DoodadType.RisingWaterWide => LoadRisingWaterWide(db), DoodadType.NoLanternWallEnd => LoadNoLanternWallEnd(db), DoodadType.RockArchway_OSar => LoadRockArchway_OSar(db), DoodadType.AngledRockArchway_OSa1 => LoadAngledRockArchway_OSa1(db), DoodadType.StrahnbradClockTower => LoadStrahnbradClockTower(db), DoodadType.StrahnbradLargeTree => LoadStrahnbradLargeTree(db), DoodadType.BrillClockTower => LoadBrillClockTower(db), DoodadType.AndrohalClockTower => LoadAndrohalClockTower(db), DoodadType.AndrohalClockTowerDestroyed => LoadAndrohalClockTowerDestroyed(db), DoodadType.HearthglenAbbey => LoadHearthglenAbbey(db), DoodadType.PyrewoodVillageClockTowerDestroyed => LoadPyrewoodVillageClockTowerDestroyed(db), DoodadType.HighElfCrestStandingBanners => LoadHighElfCrestStandingBanners(db), DoodadType.HighElfCrestHangingBanners => LoadHighElfCrestHangingBanners(db), DoodadType.SilvermoonResidentialBuildingsDiagonal1 => LoadSilvermoonResidentialBuildingsDiagonal1(db), DoodadType.SilvermoonResidentialBuildingsDiagonal2 => LoadSilvermoonResidentialBuildingsDiagonal2(db), DoodadType.SilvermoonResidentialBuildingsVertical => LoadSilvermoonResidentialBuildingsVertical(db), DoodadType.SilvermoonResidentialBuildingsHorizontal => LoadSilvermoonResidentialBuildingsHorizontal(db), DoodadType.SunfurySpireMainTower => LoadSunfurySpireMainTower(db), DoodadType.SunfurySpireSideTower => LoadSunfurySpireSideTower(db), DoodadType.SilvermoonTowerDoodadsLarge => LoadSilvermoonTowerDoodadsLarge(db), DoodadType.SilvermoonTowerDoodadsMedium => LoadSilvermoonTowerDoodadsMedium(db), DoodadType.SilvermoonTowerDoodadsSmall => LoadSilvermoonTowerDoodadsSmall(db), DoodadType.SilvermoonWallStraightShort => LoadSilvermoonWallStraightShort(db), DoodadType.SilvermoonWallStraight => LoadSilvermoonWallStraight(db), DoodadType.SilvermoonWallStraightLong => LoadSilvermoonWallStraightLong(db), DoodadType.SilvermoonWallT => LoadSilvermoonWallT(db), DoodadType.SilvermoonWallStraightDoor => LoadSilvermoonWallStraightDoor(db), DoodadType.SilvermoonWallStraightDoorShort => LoadSilvermoonWallStraightDoorShort(db), DoodadType.SilvermoonWallCorner => LoadSilvermoonWallCorner(db), DoodadType.SilvermoonWallEndcap => LoadSilvermoonWallEndcap(db), DoodadType.SilvermoonArchwayEntrance => LoadSilvermoonArchwayEntrance(db), DoodadType.SilvermoonArchwayEntrance45 => LoadSilvermoonArchwayEntrance45(db), DoodadType.SilvermoonArchway => LoadSilvermoonArchway(db), DoodadType.SilvermoonArchway45 => LoadSilvermoonArchway45(db), DoodadType.LargeSilvermoonTower => LoadLargeSilvermoonTower(db), DoodadType.ExteriorMainTower => LoadExteriorMainTower(db), DoodadType.ExteriorTower => LoadExteriorTower(db), DoodadType.ExteriorWall => LoadExteriorWall(db), DoodadType.ExteriorGate => LoadExteriorGate(db), DoodadType.ArchwayStandardDimension => LoadArchwayStandardDimension(db), DoodadType.StatueOfAzshara_SA02 => LoadStatueOfAzshara_SA02(db), DoodadType.CorpseOfGul2Dan => LoadCorpseOfGul2Dan(db), DoodadType.VioletHoldMainStructure => LoadVioletHoldMainStructure(db), DoodadType.VioletHoldSpire => LoadVioletHoldSpire(db), DoodadType.VioletHoldSpireSmall => LoadVioletHoldSpireSmall(db), DoodadType.VioletHoldArchwayEndpiece => LoadVioletHoldArchwayEndpiece(db), DoodadType.MagusTurret => LoadMagusTurret(db), DoodadType.MagusHighrise => LoadMagusHighrise(db), DoodadType.MagusConservatory => LoadMagusConservatory(db), DoodadType.SunreaverArchway => LoadSunreaverArchway(db), DoodadType.SunreaverDome => LoadSunreaverDome(db), DoodadType.SunreaverDomeSmall => LoadSunreaverDomeSmall(db), DoodadType.SunreaverSpire => LoadSunreaverSpire(db), DoodadType.EnclaveMainStructure => LoadEnclaveMainStructure(db), DoodadType.EnclaveSpire => LoadEnclaveSpire(db), DoodadType.EnclaveHouse => LoadEnclaveHouse(db), DoodadType.EnclaveHouseB => LoadEnclaveHouseB(db), DoodadType.EnclaveTurret => LoadEnclaveTurret(db), DoodadType.RuneweaverSquareFountain => LoadRuneweaverSquareFountain(db), DoodadType.BuildingA => LoadBuildingA(db), DoodadType.BuildingB => LoadBuildingB(db), DoodadType.BuildingC => LoadBuildingC(db), DoodadType.WallStraightShort_WSs0 => LoadWallStraightShort_WSs0(db), DoodadType.WallStraight => LoadWallStraight(db), DoodadType.WallStraightLong_WSl0 => LoadWallStraightLong_WSl0(db), DoodadType.WallT => LoadWallT(db), DoodadType.WallTAlt => LoadWallTAlt(db), DoodadType.WallSpire => LoadWallSpire(db), DoodadType.WallSpireAlt => LoadWallSpireAlt(db), DoodadType.Wall90Degree => LoadWall90Degree(db), DoodadType.WallEndcap_WE00 => LoadWallEndcap_WE00(db), DoodadType.Flowers_ZPf0 => LoadFlowers_ZPf0(db), _ => throw new System.ComponentModel.InvalidEnumArgumentException(nameof(doodadType), (int)doodadType, typeof(DoodadType))}

            ;
        }
    }
}