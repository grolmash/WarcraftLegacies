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
    internal class DestructableLoader
    {
        protected virtual Destructable LoadAshenvaleTreeWall(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.AshenvaleTreeWall, db);
            destructable.TextName = "Ashenvale Tree Wall";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "A";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 0;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 1;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "tree";
            destructable.StatsHitPoints = 50f;
            destructable.ArtOcclusionHeight = 230f;
            destructable.ArtFlyOverHeight = 170f;
            destructable.ArtElevationSampleRadius = 0f;
            destructable.ArtFogRadius = 0f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 54;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 1;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadBarrensTreeWall(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.BarrensTreeWall, db);
            destructable.TextName = "Barrens Tree Wall";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "B";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 0;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 1;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "tree";
            destructable.StatsHitPoints = 50f;
            destructable.ArtOcclusionHeight = 230f;
            destructable.ArtFlyOverHeight = 170f;
            destructable.ArtElevationSampleRadius = 0f;
            destructable.ArtFogRadius = 0f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 155;
            destructable.ArtMinimapColor2Green = 110;
            destructable.ArtMinimapColor3Blue = 30;
            destructable.ArtMinimapUseCustomColorRaw = 1;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadFelwoodTreeWall(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.FelwoodTreeWall, db);
            destructable.TextName = "Felwood Tree Wall";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "C";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 0;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 1;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "tree";
            destructable.StatsHitPoints = 50f;
            destructable.ArtOcclusionHeight = 230f;
            destructable.ArtFlyOverHeight = 170f;
            destructable.ArtElevationSampleRadius = 0f;
            destructable.ArtFogRadius = 0f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 45;
            destructable.ArtMinimapColor2Green = 54;
            destructable.ArtMinimapColor3Blue = 20;
            destructable.ArtMinimapUseCustomColorRaw = 1;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadFallTreeWall(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.FallTreeWall, db);
            destructable.TextName = "Fall Tree Wall";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "F,Q";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 0;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 1;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "tree";
            destructable.StatsHitPoints = 50f;
            destructable.ArtOcclusionHeight = 230f;
            destructable.ArtFlyOverHeight = 170f;
            destructable.ArtElevationSampleRadius = 0f;
            destructable.ArtFogRadius = 0f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 110;
            destructable.ArtMinimapColor2Green = 60;
            destructable.ArtMinimapColor3Blue = 10;
            destructable.ArtMinimapUseCustomColorRaw = 1;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadCage(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.Cage, db);
            destructable.TextName = "Cage";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 0;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 50f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 0f;
            destructable.ArtFogRadius = 0f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadBarricade(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.Barricade, db);
            destructable.TextName = "Barricade";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 50f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 0f;
            destructable.ArtFogRadius = 0f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadCrates(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.Crates, db);
            destructable.TextName = "Crates";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 20f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 0f;
            destructable.ArtFogRadius = 0f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadBarrel_LTbr(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.Barrel_LTbr, db);
            destructable.TextName = "Barrel";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 20f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 0f;
            destructable.ArtFogRadius = 0f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadBarrel_LTbx(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.Barrel_LTbx, db);
            destructable.TextName = "Barrel";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 20f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 0f;
            destructable.ArtFogRadius = 0f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadBarrel_LTbs(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.Barrel_LTbs, db);
            destructable.TextName = "Barrel";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 20f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 0f;
            destructable.ArtFogRadius = 0f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadBarrelOfExplosives(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.BarrelOfExplosives, db);
            destructable.TextName = "Barrel of Explosives";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 20f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 0f;
            destructable.ArtFogRadius = 0f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadGate_LTg1(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.Gate_LTg1, db);
            destructable.TextName = "Gate";
            destructable.TextEditorSuffix = "(Horizontal)";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "L,F,W,B,A,C,Y,X,V,Q,D,G";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 400f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\Gate1Path.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\Gate1PathDeath.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadGate_LTg2(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.Gate_LTg2, db);
            destructable.TextName = "Gate";
            destructable.TextEditorSuffix = "(Diagonal 1)";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "L,F,W,B,A,C,Y,X,V,Q,D,G";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 400f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\Gate2Path.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\Gate2PathDeath.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadGate_LTg3(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.Gate_LTg3, db);
            destructable.TextName = "Gate";
            destructable.TextEditorSuffix = "(Vertical)";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "L,F,W,B,A,C,Y,X,V,Q,D,G";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 400f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\Gate1Path.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\Gate1PathDeath.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadGate_LTg4(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.Gate_LTg4, db);
            destructable.TextName = "Gate";
            destructable.TextEditorSuffix = "(Diagonal 2)";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "L,F,W,B,A,C,Y,X,V,Q,D,G";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 400f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\Gate2Path.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\Gate2PathDeath.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadElvenGate_LTe1(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.ElvenGate_LTe1, db);
            destructable.TextName = "Elven Gate";
            destructable.TextEditorSuffix = "(Horizontal)";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "L,F,W,B,A,C,Y,X,V,Q,D,G";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 400f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\Gate1Path.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\Gate1PathDeath.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadElvenGate_LTe2(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.ElvenGate_LTe2, db);
            destructable.TextName = "Elven Gate";
            destructable.TextEditorSuffix = "(Diagonal 1)";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "L,F,W,B,A,C,Y,X,V,Q,D,G";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 400f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\Gate2Path.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\Gate2PathDeath.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadElvenGate_LTe3(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.ElvenGate_LTe3, db);
            destructable.TextName = "Elven Gate";
            destructable.TextEditorSuffix = "(Vertical)";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "L,F,W,B,A,C,Y,X,V,Q,D,G";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 400f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\Gate1Path.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\Gate1PathDeath.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadElvenGate_LTe4(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.ElvenGate_LTe4, db);
            destructable.TextName = "Elven Gate";
            destructable.TextEditorSuffix = "(Diagonal 2)";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "L,F,W,B,A,C,Y,X,V,Q,D,G";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 400f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\Gate2Path.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\Gate2PathDeath.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadDemonicGate_ATg1(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.DemonicGate_ATg1, db);
            destructable.TextName = "Demonic Gate";
            destructable.TextEditorSuffix = "(Horizontal)";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "L,F,W,B,A,C,Y,X,V,Q,D,G";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 400f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\Gate1Path.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\Gate1PathDeath.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadDemonicGate_ATg2(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.DemonicGate_ATg2, db);
            destructable.TextName = "Demonic Gate";
            destructable.TextEditorSuffix = "(Diagonal 1)";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "L,F,W,B,A,C,Y,X,V,Q,D,G";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 400f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\Gate2Path.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\Gate2PathDeath.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadDemonicGate_ATg3(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.DemonicGate_ATg3, db);
            destructable.TextName = "Demonic Gate";
            destructable.TextEditorSuffix = "(Vertical)";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "L,F,W,B,A,C,Y,X,V,Q,D,G";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 400f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\Gate1Path.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\Gate1PathDeath.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadDemonicGate_ATg4(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.DemonicGate_ATg4, db);
            destructable.TextName = "Demonic Gate";
            destructable.TextEditorSuffix = "(Diagonal 2)";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "L,F,W,B,A,C,Y,X,V,Q,D,G";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 400f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\Gate2Path.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\Gate2PathDeath.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadIronGate_DTg5(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.IronGate_DTg5, db);
            destructable.TextName = "Iron Gate";
            destructable.TextEditorSuffix = "(Horizontal)";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "L,F,W,B,A,C,Y,X,V,Q,D,G";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 400f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\Gate1Path.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\Gate1PathDeath.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadIronGate_DTg6(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.IronGate_DTg6, db);
            destructable.TextName = "Iron Gate";
            destructable.TextEditorSuffix = "(Diagonal 1)";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "L,F,W,B,A,C,Y,X,V,Q,D,G";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 400f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\Gate2Path.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\Gate2PathDeath.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadIronGate_DTg7(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.IronGate_DTg7, db);
            destructable.TextName = "Iron Gate";
            destructable.TextEditorSuffix = "(Vertical)";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "L,F,W,B,A,C,Y,X,V,Q,D,G";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 400f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\Gate1Path.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\Gate1PathDeath.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadIronGate_DTg8(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.IronGate_DTg8, db);
            destructable.TextName = "Iron Gate";
            destructable.TextEditorSuffix = "(Diagonal 2)";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "L,F,W,B,A,C,Y,X,V,Q,D,G";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 400f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\Gate2Path.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\Gate2PathDeath.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadDungeonGate_DTg1(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.DungeonGate_DTg1, db);
            destructable.TextName = "Dungeon Gate";
            destructable.TextEditorSuffix = "(Horizontal)";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "D,G,Y,X";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 100f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\Gate1Path.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\Gate1PathDeath.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadDungeonGate_DTg2(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.DungeonGate_DTg2, db);
            destructable.TextName = "Dungeon Gate";
            destructable.TextEditorSuffix = "(Diagonal 1)";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "D,G,Y,X";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 100f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\Gate2Path.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\Gate2PathDeath.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadDungeonGate_DTg3(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.DungeonGate_DTg3, db);
            destructable.TextName = "Dungeon Gate";
            destructable.TextEditorSuffix = "(Vertical)";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "D,G,Y,X";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 100f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\Gate1Path.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\Gate1PathDeath.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadDungeonGate_DTg4(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.DungeonGate_DTg4, db);
            destructable.TextName = "Dungeon Gate";
            destructable.TextEditorSuffix = "(Diagonal 2)";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "D,G,Y,X";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 100f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\Gate2Path.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\Gate2PathDeath.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadSummerTreeWall(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.SummerTreeWall, db);
            destructable.TextName = "Summer Tree Wall";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "L";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 0;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 1;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "tree";
            destructable.StatsHitPoints = 50f;
            destructable.ArtOcclusionHeight = 230f;
            destructable.ArtFlyOverHeight = 170f;
            destructable.ArtElevationSampleRadius = 0f;
            destructable.ArtFogRadius = 0f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 32;
            destructable.ArtMinimapColor2Green = 90;
            destructable.ArtMinimapColor3Blue = 32;
            destructable.ArtMinimapUseCustomColorRaw = 1;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadNorthrendTreeWall(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.NorthrendTreeWall, db);
            destructable.TextName = "Northrend Tree Wall";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "N";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 0;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 1;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "tree";
            destructable.StatsHitPoints = 50f;
            destructable.ArtOcclusionHeight = 230f;
            destructable.ArtFlyOverHeight = 170f;
            destructable.ArtElevationSampleRadius = 0f;
            destructable.ArtFogRadius = 0f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 32;
            destructable.ArtMinimapColor2Green = 48;
            destructable.ArtMinimapColor3Blue = 32;
            destructable.ArtMinimapUseCustomColorRaw = 1;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadWinterTreeWall(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.WinterTreeWall, db);
            destructable.TextName = "Winter Tree Wall";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "W";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 0;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 1;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "tree";
            destructable.StatsHitPoints = 50f;
            destructable.ArtOcclusionHeight = 230f;
            destructable.ArtFlyOverHeight = 170f;
            destructable.ArtElevationSampleRadius = 0f;
            destructable.ArtFogRadius = 0f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 80;
            destructable.ArtMinimapColor2Green = 160;
            destructable.ArtMinimapColor3Blue = 185;
            destructable.ArtMinimapUseCustomColorRaw = 1;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadSnowyTreeWall(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.SnowyTreeWall, db);
            destructable.TextName = "Snowy Tree Wall";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "W,N";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 0;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 1;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "tree";
            destructable.StatsHitPoints = 50f;
            destructable.ArtOcclusionHeight = 230f;
            destructable.ArtFlyOverHeight = 170f;
            destructable.ArtElevationSampleRadius = 0f;
            destructable.ArtFogRadius = 0f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 110;
            destructable.ArtMinimapColor2Green = 170;
            destructable.ArtMinimapColor3Blue = 180;
            destructable.ArtMinimapUseCustomColorRaw = 1;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadCityscapeSummerTreeWall(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.CityscapeSummerTreeWall, db);
            destructable.TextName = "Cityscape Summer Tree Wall";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "Y,X";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 0;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 1;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "tree";
            destructable.StatsHitPoints = 50f;
            destructable.ArtOcclusionHeight = 300f;
            destructable.ArtFlyOverHeight = 170f;
            destructable.ArtElevationSampleRadius = 0f;
            destructable.ArtFogRadius = 0f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 32;
            destructable.ArtMinimapColor2Green = 90;
            destructable.ArtMinimapColor3Blue = 32;
            destructable.ArtMinimapUseCustomColorRaw = 1;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadCityscapeWinterTreeWall(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.CityscapeWinterTreeWall, db);
            destructable.TextName = "Cityscape Winter Tree Wall";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "Y,X";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 0;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 1;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "tree";
            destructable.StatsHitPoints = 50f;
            destructable.ArtOcclusionHeight = 300f;
            destructable.ArtFlyOverHeight = 170f;
            destructable.ArtElevationSampleRadius = 0f;
            destructable.ArtFogRadius = 0f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 80;
            destructable.ArtMinimapColor2Green = 160;
            destructable.ArtMinimapColor3Blue = 185;
            destructable.ArtMinimapUseCustomColorRaw = 1;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadCityscapeSnowyTreeWall(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.CityscapeSnowyTreeWall, db);
            destructable.TextName = "Cityscape Snowy Tree Wall";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "Y,X";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 0;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 1;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "tree";
            destructable.StatsHitPoints = 50f;
            destructable.ArtOcclusionHeight = 300f;
            destructable.ArtFlyOverHeight = 170f;
            destructable.ArtElevationSampleRadius = 0f;
            destructable.ArtFogRadius = 0f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 110;
            destructable.ArtMinimapColor2Green = 170;
            destructable.ArtMinimapColor3Blue = 180;
            destructable.ArtMinimapUseCustomColorRaw = 1;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadCityscapeFallTreeWall(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.CityscapeFallTreeWall, db);
            destructable.TextName = "Cityscape Fall Tree Wall";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "Y,X";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 0;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 1;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "tree";
            destructable.StatsHitPoints = 50f;
            destructable.ArtOcclusionHeight = 300f;
            destructable.ArtFlyOverHeight = 170f;
            destructable.ArtElevationSampleRadius = 0f;
            destructable.ArtFogRadius = 0f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 75;
            destructable.ArtMinimapColor2Green = 50;
            destructable.ArtMinimapColor3Blue = 30;
            destructable.ArtMinimapUseCustomColorRaw = 1;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadVillageTreeWall(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.VillageTreeWall, db);
            destructable.TextName = "Village Tree Wall";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "V";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 0;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 1;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "tree";
            destructable.StatsHitPoints = 50f;
            destructable.ArtOcclusionHeight = 230f;
            destructable.ArtFlyOverHeight = 170f;
            destructable.ArtElevationSampleRadius = 0f;
            destructable.ArtFogRadius = 0f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 32;
            destructable.ArtMinimapColor2Green = 90;
            destructable.ArtMinimapColor3Blue = 32;
            destructable.ArtMinimapUseCustomColorRaw = 1;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadStoneWall_LTw0(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.StoneWall_LTw0, db);
            destructable.TextName = "Stone Wall";
            destructable.TextEditorSuffix = "(Horizontal)";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "L,F,W,Y,X";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "wall";
            destructable.StatsHitPoints = 200f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\StoneWall1Path.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadStoneWall_LTw1(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.StoneWall_LTw1, db);
            destructable.TextName = "Stone Wall";
            destructable.TextEditorSuffix = "(Diagonal 2)";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "L,F,W,Y,X";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "wall";
            destructable.StatsHitPoints = 200f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\StoneWall2Path.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadStoneWall_LTw2(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.StoneWall_LTw2, db);
            destructable.TextName = "Stone Wall";
            destructable.TextEditorSuffix = "(Vertical)";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "L,F,W,Y,X";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "wall";
            destructable.StatsHitPoints = 200f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\StoneWall3Path.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadStoneWall_LTw3(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.StoneWall_LTw3, db);
            destructable.TextName = "Stone Wall";
            destructable.TextEditorSuffix = "(Diagonal 1)";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "L,F,W,Y,X";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "wall";
            destructable.StatsHitPoints = 200f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\StoneWall4Path.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadShortNaturalBridge_YT00(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.ShortNaturalBridge_YT00, db);
            destructable.TextName = "Short Natural Bridge";
            destructable.TextEditorSuffix = "(Vertical)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 100f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeSmall0.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeSmall0Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadShortNaturalBridge_YT01(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.ShortNaturalBridge_YT01, db);
            destructable.TextName = "Short Natural Bridge";
            destructable.TextEditorSuffix = "(Diagonal 1)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 100f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeSmall45.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeSmall45Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadShortNaturalBridge_YT02(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.ShortNaturalBridge_YT02, db);
            destructable.TextName = "Short Natural Bridge";
            destructable.TextEditorSuffix = "(Horizontal)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 100f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeSmall0.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeSmall0Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadShortNaturalBridge_YT03(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.ShortNaturalBridge_YT03, db);
            destructable.TextName = "Short Natural Bridge";
            destructable.TextEditorSuffix = "(Diagonal 2)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 100f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeSmall45.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeSmall45Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadLongNaturalBridge_YT04(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.LongNaturalBridge_YT04, db);
            destructable.TextName = "Long Natural Bridge";
            destructable.TextEditorSuffix = "(Vertical)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeLarge0.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeLarge0Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadLongNaturalBridge_YT05(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.LongNaturalBridge_YT05, db);
            destructable.TextName = "Long Natural Bridge";
            destructable.TextEditorSuffix = "(Diagonal 1)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeLarge45.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeLarge45Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadLongNaturalBridge_YT06(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.LongNaturalBridge_YT06, db);
            destructable.TextName = "Long Natural Bridge";
            destructable.TextEditorSuffix = "(Horizontal)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeLarge0.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeLarge0Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadLongNaturalBridge_YT07(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.LongNaturalBridge_YT07, db);
            destructable.TextName = "Long Natural Bridge";
            destructable.TextEditorSuffix = "(Diagonal 2)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeLarge45.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeLarge45Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadWideNaturalBridge_YT08(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.WideNaturalBridge_YT08, db);
            destructable.TextName = "Wide Natural Bridge";
            destructable.TextEditorSuffix = "(Vertical)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeExtraLarge0.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeExtraLarge0Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadWideNaturalBridge_YT09(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.WideNaturalBridge_YT09, db);
            destructable.TextName = "Wide Natural Bridge";
            destructable.TextEditorSuffix = "(Diagonal 1)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeExtraLarge45.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeExtraLarge45Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadWideNaturalBridge_YT10(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.WideNaturalBridge_YT10, db);
            destructable.TextName = "Wide Natural Bridge";
            destructable.TextEditorSuffix = "(Horizontal)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeExtraLarge0.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeExtraLarge0Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadWideNaturalBridge_YT11(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.WideNaturalBridge_YT11, db);
            destructable.TextName = "Wide Natural Bridge";
            destructable.TextEditorSuffix = "(Diagonal 2)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeExtraLarge45.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeExtraLarge45Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadShortStoneBridge_YT12(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.ShortStoneBridge_YT12, db);
            destructable.TextName = "Short Stone Bridge";
            destructable.TextEditorSuffix = "(Vertical)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 100f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeSmall0.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeSmall0Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadShortStoneBridge_YT13(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.ShortStoneBridge_YT13, db);
            destructable.TextName = "Short Stone Bridge";
            destructable.TextEditorSuffix = "(Diagonal 1)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 100f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeSmall45.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeSmall45Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadShortStoneBridge_YT14(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.ShortStoneBridge_YT14, db);
            destructable.TextName = "Short Stone Bridge";
            destructable.TextEditorSuffix = "(Horizontal)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 100f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeSmall90.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeSmall90Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadShortStoneBridge_YT15(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.ShortStoneBridge_YT15, db);
            destructable.TextName = "Short Stone Bridge";
            destructable.TextEditorSuffix = "(Diagonal 2)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 100f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeSmall135.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeSmall135Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadLongStoneBridge_YT16(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.LongStoneBridge_YT16, db);
            destructable.TextName = "Long Stone Bridge";
            destructable.TextEditorSuffix = "(Vertical)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeLarge0.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeLarge0Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadLongStoneBridge_YT17(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.LongStoneBridge_YT17, db);
            destructable.TextName = "Long Stone Bridge";
            destructable.TextEditorSuffix = "(Diagonal 1)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeLarge45.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeLarge45Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadLongStoneBridge_YT18(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.LongStoneBridge_YT18, db);
            destructable.TextName = "Long Stone Bridge";
            destructable.TextEditorSuffix = "(Horizontal)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeLarge90.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeLarge90Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadLongStoneBridge_YT19(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.LongStoneBridge_YT19, db);
            destructable.TextName = "Long Stone Bridge";
            destructable.TextEditorSuffix = "(Diagonal 2)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeLarge135.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeLarge135Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadWideStoneBridge_YT20(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.WideStoneBridge_YT20, db);
            destructable.TextName = "Wide Stone Bridge";
            destructable.TextEditorSuffix = "(Vertical)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeExtraLarge0.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeExtraLarge0Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadWideStoneBridge_YT21(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.WideStoneBridge_YT21, db);
            destructable.TextName = "Wide Stone Bridge";
            destructable.TextEditorSuffix = "(Diagonal 1)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeExtraLarge45.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeExtraLarge45Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadWideStoneBridge_YT22(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.WideStoneBridge_YT22, db);
            destructable.TextName = "Wide Stone Bridge";
            destructable.TextEditorSuffix = "(Horizontal)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeExtraLarge90.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeExtraLarge90Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadWideStoneBridge_YT23(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.WideStoneBridge_YT23, db);
            destructable.TextName = "Wide Stone Bridge";
            destructable.TextEditorSuffix = "(Diagonal 2)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeExtraLarge135.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeExtraLarge135Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadShortWoodenBridge_LT00(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.ShortWoodenBridge_LT00, db);
            destructable.TextName = "Short Wooden Bridge";
            destructable.TextEditorSuffix = "(Vertical)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "A,B,Y,X,J,D,C,I,F,L,W,N,Z,G,V,Q";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 100f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeSmall0.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeSmall0Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadShortWoodenBridge_LT01(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.ShortWoodenBridge_LT01, db);
            destructable.TextName = "Short Wooden Bridge";
            destructable.TextEditorSuffix = "(Diagonal 1)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "A,B,Y,X,J,D,C,I,F,L,W,N,Z,G,V,Q";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 100f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeSmall45.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeSmall45Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadShortWoodenBridge_LT02(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.ShortWoodenBridge_LT02, db);
            destructable.TextName = "Short Wooden Bridge";
            destructable.TextEditorSuffix = "(Horizontal)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "A,B,Y,X,J,D,C,I,F,L,W,N,Z,G,V,Q";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 100f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeSmall0.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeSmall0Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadShortWoodenBridge_LT03(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.ShortWoodenBridge_LT03, db);
            destructable.TextName = "Short Wooden Bridge";
            destructable.TextEditorSuffix = "(Diagonal 2)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "A,B,Y,X,J,D,C,I,F,L,W,N,Z,G,V,Q";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 100f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeSmall45.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeSmall45Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadLongWoodenBridge_LT04(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.LongWoodenBridge_LT04, db);
            destructable.TextName = "Long Wooden Bridge";
            destructable.TextEditorSuffix = "(Vertical)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "A,B,Y,X,J,D,C,I,F,L,W,N,Z,G,V,Q";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeLarge0.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeLarge0Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadLongWoodenBridge_LT05(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.LongWoodenBridge_LT05, db);
            destructable.TextName = "Long Wooden Bridge";
            destructable.TextEditorSuffix = "(Diagonal 1)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "A,B,Y,X,J,D,C,I,F,L,W,N,Z,G,V,Q";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeLarge45.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeLarge45Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadLongWoodenBridge_LT06(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.LongWoodenBridge_LT06, db);
            destructable.TextName = "Long Wooden Bridge";
            destructable.TextEditorSuffix = "(Horizontal)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "A,B,Y,X,J,D,C,I,F,L,W,N,Z,G,V,Q";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeLarge0.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeLarge0Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadLongWoodenBridge_LT07(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.LongWoodenBridge_LT07, db);
            destructable.TextName = "Long Wooden Bridge";
            destructable.TextEditorSuffix = "(Diagonal 2)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "A,B,Y,X,J,D,C,I,F,L,W,N,Z,G,V,Q";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeLarge45.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeLarge45Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadWideWoodenBridge_LT08(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.WideWoodenBridge_LT08, db);
            destructable.TextName = "Wide Wooden Bridge";
            destructable.TextEditorSuffix = "(Vertical)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "A,B,Y,X,J,D,C,I,F,L,W,N,Z,G,V,Q";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeExtraLarge0.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeExtraLarge0Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadWideWoodenBridge_LT09(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.WideWoodenBridge_LT09, db);
            destructable.TextName = "Wide Wooden Bridge";
            destructable.TextEditorSuffix = "(Diagonal 1)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "A,B,Y,X,J,D,C,I,F,L,W,N,Z,G,V,Q";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeExtraLarge45.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeExtraLarge45Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadWideWoodenBridge_LT10(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.WideWoodenBridge_LT10, db);
            destructable.TextName = "Wide Wooden Bridge";
            destructable.TextEditorSuffix = "(Horizontal)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "A,B,Y,X,J,D,C,I,F,L,W,N,Z,G,V,Q";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeExtraLarge0.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeExtraLarge0Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadWideWoodenBridge_LT11(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.WideWoodenBridge_LT11, db);
            destructable.TextName = "Wide Wooden Bridge";
            destructable.TextEditorSuffix = "(Diagonal 2)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "A,B,Y,X,J,D,C,I,F,L,W,N,Z,G,V,Q";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeExtraLarge45.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeExtraLarge45Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadDalaranBuilding(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.DalaranBuilding, db);
            destructable.TextName = "Dalaran Building";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "X";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 0;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 0f;
            destructable.ArtFogRadius = 0f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\8x8Unflyable.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadDalaranVioletCitadel(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.DalaranVioletCitadel, db);
            destructable.TextName = "Dalaran Violet Citadel";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "X";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 0;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 100f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\12x12Unflyable.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadStoneRamp_LTr1(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.StoneRamp_LTr1, db);
            destructable.TextName = "Stone Ramp";
            destructable.TextEditorSuffix = "(Bottom Left)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 30f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\StoneCliffRamp45.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\StoneCliffRamp45Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadStoneRamp_LTr2(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.StoneRamp_LTr2, db);
            destructable.TextName = "Stone Ramp";
            destructable.TextEditorSuffix = "(Top Left)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 30f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\StoneCliffRamp135.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\StoneCliffRamp135Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadStoneRamp_LTr3(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.StoneRamp_LTr3, db);
            destructable.TextName = "Stone Ramp";
            destructable.TextEditorSuffix = "(Top Right)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 30f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\StoneCliffRamp45.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\StoneCliffRamp45Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadStoneRamp_LTr4(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.StoneRamp_LTr4, db);
            destructable.TextName = "Stone Ramp";
            destructable.TextEditorSuffix = "(Bottom Right)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 30f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\StoneCliffRamp135.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\StoneCliffRamp135Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadStoneRamp_LTr5(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.StoneRamp_LTr5, db);
            destructable.TextName = "Stone Ramp";
            destructable.TextEditorSuffix = "(Bottom Left 2)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 30f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\StoneCliffRamp45.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\StoneCliffRamp45Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadStoneRamp_LTr6(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.StoneRamp_LTr6, db);
            destructable.TextName = "Stone Ramp";
            destructable.TextEditorSuffix = "(Top Left 2)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 30f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\StoneCliffRamp135.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\StoneCliffRamp135Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadStoneRamp_LTr7(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.StoneRamp_LTr7, db);
            destructable.TextName = "Stone Ramp";
            destructable.TextEditorSuffix = "(Top Right 2)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 30f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\StoneCliffRamp45.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\StoneCliffRamp45Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadStoneRamp_LTr8(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.StoneRamp_LTr8, db);
            destructable.TextName = "Stone Ramp";
            destructable.TextEditorSuffix = "(Bottom Right 2)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 30f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\StoneCliffRamp135.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\StoneCliffRamp135Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadShip(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.Ship, db);
            destructable.TextName = "Ship";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "N";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 0;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 1;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 200f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 100f;
            destructable.ArtElevationSampleRadius = 0f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\8x8Default.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadEggSack(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.EggSack, db);
            destructable.TextName = "Egg Sack";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "D,G";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 0;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 15f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 0f;
            destructable.ArtFogRadius = 0f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadDungeonTreeWall(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.DungeonTreeWall, db);
            destructable.TextName = "Dungeon Tree Wall";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "D";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 0;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 1;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "tree";
            destructable.StatsHitPoints = 50f;
            destructable.ArtOcclusionHeight = 230f;
            destructable.ArtFlyOverHeight = 170f;
            destructable.ArtElevationSampleRadius = 0f;
            destructable.ArtFogRadius = 0f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 155;
            destructable.ArtMinimapColor2Green = 70;
            destructable.ArtMinimapColor3Blue = 60;
            destructable.ArtMinimapUseCustomColorRaw = 1;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadBridgeDestroyed_YSdb(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.BridgeDestroyed_YSdb, db);
            destructable.TextName = "Bridge Destroyed";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "Y";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CitybridgeDestroyed.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CitybridgeDestroyed.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadBridgeDestroyed_YSdc(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.BridgeDestroyed_YSdc, db);
            destructable.TextName = "Bridge Destroyed";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "Y";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CitybridgeDestroyed.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CitybridgeDestroyed.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadKingSThrone(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.KingSThrone, db);
            destructable.TextName = "King's Throne";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "X,Y";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "decoration";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 0f;
            destructable.ArtFogRadius = 0f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\throne.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadKingSThroneDiagonal1_XOk1(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.KingSThroneDiagonal1_XOk1, db);
            destructable.TextName = "King's Throne (Diagonal 1)";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "X";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "decoration";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 0f;
            destructable.ArtFogRadius = 0f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\throne135.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadKingSThroneDiagonal1_XOk2(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.KingSThroneDiagonal1_XOk2, db);
            destructable.TextName = "King's Throne (Diagonal 1)";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "X";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "decoration";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 0f;
            destructable.ArtFogRadius = 0f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\throne45.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadCliffCaveGate_DTc1(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.CliffCaveGate_DTc1, db);
            destructable.TextName = "Cliff Cave Gate";
            destructable.TextEditorSuffix = "(1)";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "D,G";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CaveGate1Path.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CaveGate1PathDeath.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadCliffCaveGate_DTc2(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.CliffCaveGate_DTc2, db);
            destructable.TextName = "Cliff Cave Gate";
            destructable.TextEditorSuffix = "(2)";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "D,G";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CaveGate2Path.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CaveGate2PathDeath.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadDungeonSpikes(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.DungeonSpikes, db);
            destructable.TextName = "Dungeon Spikes";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "D,G";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 1;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 200f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 0f;
            destructable.ArtFogRadius = 0f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\4x4Unbuildable.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadRockChunks_DTrc(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.RockChunks_DTrc, db);
            destructable.TextName = "Rock Chunks";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "D,G";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 250f;
            destructable.ArtOcclusionHeight = 230f;
            destructable.ArtFlyOverHeight = 100f;
            destructable.ArtElevationSampleRadius = 0f;
            destructable.ArtFogRadius = 0f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadForceBridge_DTs0(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.ForceBridge_DTs0, db);
            destructable.TextName = "Force Bridge";
            destructable.TextEditorSuffix = "(Vertical)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "D,G";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeLarge0.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeLarge0Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadForceBridge_DTs1(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.ForceBridge_DTs1, db);
            destructable.TextName = "Force Bridge";
            destructable.TextEditorSuffix = "(Diagonal 1)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "D,G";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeLarge45.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeLarge45Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadForceBridge_DTs2(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.ForceBridge_DTs2, db);
            destructable.TextName = "Force Bridge";
            destructable.TextEditorSuffix = "(Horizontal)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "D,G";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeLarge0.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeLarge0Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadForceBridge_DTs3(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.ForceBridge_DTs3, db);
            destructable.TextName = "Force Bridge";
            destructable.TextEditorSuffix = "(Diagonal 2)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "D,G";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeLarge45.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeLarge45Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadForceWall_Dofw(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.ForceWall_Dofw, db);
            destructable.TextName = "ForceWall";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "D,G";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 1;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "decoration";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\ForceWall.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadForceWall_Dofv(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.ForceWall_Dofv, db);
            destructable.TextName = "ForceWall";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "D,G";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 1;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "decoration";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\ForceWall45.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadShortNaturalBridge_YT24(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.ShortNaturalBridge_YT24, db);
            destructable.TextName = "Short Natural Bridge";
            destructable.TextEditorSuffix = "(Vertical)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 100f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeSmall0.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeSmall0Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadShortNaturalBridge_YT25(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.ShortNaturalBridge_YT25, db);
            destructable.TextName = "Short Natural Bridge";
            destructable.TextEditorSuffix = "(Diagonal 1)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 100f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeSmall45.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeSmall45Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadShortNaturalBridge_YT26(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.ShortNaturalBridge_YT26, db);
            destructable.TextName = "Short Natural Bridge";
            destructable.TextEditorSuffix = "(Horizontal)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 100f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeSmall0.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeSmall0Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadShortNaturalBridge_YT27(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.ShortNaturalBridge_YT27, db);
            destructable.TextName = "Short Natural Bridge";
            destructable.TextEditorSuffix = "(Diagonal 2)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 100f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeSmall45.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeSmall45Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadLongNaturalBridge_YT28(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.LongNaturalBridge_YT28, db);
            destructable.TextName = "Long Natural Bridge";
            destructable.TextEditorSuffix = "(Vertical)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeLarge0.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeLarge0Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadLongNaturalBridge_YT29(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.LongNaturalBridge_YT29, db);
            destructable.TextName = "Long Natural Bridge";
            destructable.TextEditorSuffix = "(Diagonal 1)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeLarge45.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeLarge45Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadLongNaturalBridge_YT30(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.LongNaturalBridge_YT30, db);
            destructable.TextName = "Long Natural Bridge";
            destructable.TextEditorSuffix = "(Horizontal)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeLarge0.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeLarge0Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadLongNaturalBridge_YT31(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.LongNaturalBridge_YT31, db);
            destructable.TextName = "Long Natural Bridge";
            destructable.TextEditorSuffix = "(Diagonal 2)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeLarge45.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeLarge45Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadWideNaturalBridge_YT32(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.WideNaturalBridge_YT32, db);
            destructable.TextName = "Wide Natural Bridge";
            destructable.TextEditorSuffix = "(Vertical)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeExtraLarge0.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeExtraLarge0Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadWideNaturalBridge_YT33(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.WideNaturalBridge_YT33, db);
            destructable.TextName = "Wide Natural Bridge";
            destructable.TextEditorSuffix = "(Diagonal 1)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeExtraLarge45.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeExtraLarge45Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadWideNaturalBridge_YT34(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.WideNaturalBridge_YT34, db);
            destructable.TextName = "Wide Natural Bridge";
            destructable.TextEditorSuffix = "(Horizontal)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeExtraLarge0.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeExtraLarge0Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadWideNaturalBridge_YT35(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.WideNaturalBridge_YT35, db);
            destructable.TextName = "Wide Natural Bridge";
            destructable.TextEditorSuffix = "(Diagonal 2)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeExtraLarge45.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeExtraLarge45Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadShortStoneBridge_YT36(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.ShortStoneBridge_YT36, db);
            destructable.TextName = "Short Stone Bridge";
            destructable.TextEditorSuffix = "(Vertical)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 100f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeSmall0.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeSmall0Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadShortStoneBridge_YT37(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.ShortStoneBridge_YT37, db);
            destructable.TextName = "Short Stone Bridge";
            destructable.TextEditorSuffix = "(Diagonal 1)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 100f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeSmall45.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeSmall45Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadShortStoneBridge_YT38(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.ShortStoneBridge_YT38, db);
            destructable.TextName = "Short Stone Bridge";
            destructable.TextEditorSuffix = "(Horizontal)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 100f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeSmall90.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeSmall90Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadShortStoneBridge_YT39(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.ShortStoneBridge_YT39, db);
            destructable.TextName = "Short Stone Bridge";
            destructable.TextEditorSuffix = "(Diagonal 2)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 100f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeSmall135.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeSmall135Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadLongStoneBridge_YT40(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.LongStoneBridge_YT40, db);
            destructable.TextName = "Long Stone Bridge";
            destructable.TextEditorSuffix = "(Vertical)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeLarge0.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeLarge0Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadLongStoneBridge_YT41(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.LongStoneBridge_YT41, db);
            destructable.TextName = "Long Stone Bridge";
            destructable.TextEditorSuffix = "(Diagonal 1)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeLarge45.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeLarge45Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadLongStoneBridge_YT42(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.LongStoneBridge_YT42, db);
            destructable.TextName = "Long Stone Bridge";
            destructable.TextEditorSuffix = "(Horizontal)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeLarge90.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeLarge90Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadLongStoneBridge_YT43(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.LongStoneBridge_YT43, db);
            destructable.TextName = "Long Stone Bridge";
            destructable.TextEditorSuffix = "(Diagonal 2)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeLarge135.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeLarge135Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadWideStoneBridge_YT44(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.WideStoneBridge_YT44, db);
            destructable.TextName = "Wide Stone Bridge";
            destructable.TextEditorSuffix = "(Vertical)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeExtraLarge0.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeExtraLarge0Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadWideStoneBridge_YT45(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.WideStoneBridge_YT45, db);
            destructable.TextName = "Wide Stone Bridge";
            destructable.TextEditorSuffix = "(Diagonal 1)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeExtraLarge45.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeExtraLarge45Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadWideStoneBridge_YT46(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.WideStoneBridge_YT46, db);
            destructable.TextName = "Wide Stone Bridge";
            destructable.TextEditorSuffix = "(Horizontal)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeExtraLarge90.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeExtraLarge90Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadWideStoneBridge_YT47(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.WideStoneBridge_YT47, db);
            destructable.TextName = "Wide Stone Bridge";
            destructable.TextEditorSuffix = "(Diagonal 2)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeExtraLarge135.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeExtraLarge135Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadRampNagaSmallLeft(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.RampNagaSmallLeft, db);
            destructable.TextName = "Ramp Naga Small (Left)";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "Z";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 1;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\NagaStairsSmall0.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\NagaStairsSmall0.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadRampNagaSmallTop(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.RampNagaSmallTop, db);
            destructable.TextName = "Ramp Naga Small (Top)";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "Z";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 1;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\NagaStairsSmall90.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\NagaStairsSmall90.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadRampNagaSmallRight(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.RampNagaSmallRight, db);
            destructable.TextName = "Ramp Naga Small (Right)";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "Z";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 1;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\NagaStairsSmall180.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\NagaStairsSmall180.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadRampNagaSmallBottom(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.RampNagaSmallBottom, db);
            destructable.TextName = "Ramp Naga Small (Bottom)";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "Z";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 1;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\NagaStairsSmall270.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\NagaStairsSmall270.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadRuinsTreeWall(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.RuinsTreeWall, db);
            destructable.TextName = "Ruins Tree Wall";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "Z";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 0;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 1;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "tree";
            destructable.StatsHitPoints = 50f;
            destructable.ArtOcclusionHeight = 230f;
            destructable.ArtFlyOverHeight = 170f;
            destructable.ArtElevationSampleRadius = 0f;
            destructable.ArtFogRadius = 0f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 88;
            destructable.ArtMinimapColor2Green = 124;
            destructable.ArtMinimapColor3Blue = 36;
            destructable.ArtMinimapUseCustomColorRaw = 1;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadStoneWall_ZTw0(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.StoneWall_ZTw0, db);
            destructable.TextName = "Stone Wall";
            destructable.TextEditorSuffix = "(Horizontal)";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "Z";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "wall";
            destructable.StatsHitPoints = 200f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\StoneWall1Path.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadStoneWall_ZTw1(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.StoneWall_ZTw1, db);
            destructable.TextName = "Stone Wall";
            destructable.TextEditorSuffix = "(Diagonal 2)";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "Z";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "wall";
            destructable.StatsHitPoints = 200f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\StoneWall2Path.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadStoneWall_ZTw2(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.StoneWall_ZTw2, db);
            destructable.TextName = "Stone Wall";
            destructable.TextEditorSuffix = "(Vertical)";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "Z";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "wall";
            destructable.StatsHitPoints = 200f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\StoneWall3Path.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadStoneWall_ZTw3(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.StoneWall_ZTw3, db);
            destructable.TextName = "Stone Wall";
            destructable.TextEditorSuffix = "(Diagonal 1)";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "Z";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "wall";
            destructable.StatsHitPoints = 200f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\StoneWall4Path.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadRuinedGate_ZTg1(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.RuinedGate_ZTg1, db);
            destructable.TextName = "Ruined Gate";
            destructable.TextEditorSuffix = "(Horizontal)";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "Z";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 400f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\Gate1Path.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\Gate1PathDeath.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadRuinedGate_ZTg2(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.RuinedGate_ZTg2, db);
            destructable.TextName = "Ruined Gate";
            destructable.TextEditorSuffix = "(Diagonal 1)";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "Z";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 400f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\Gate2Path.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\Gate2PathDeath.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadRuinedGate_ZTg3(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.RuinedGate_ZTg3, db);
            destructable.TextName = "Ruined Gate";
            destructable.TextEditorSuffix = "(Vertical)";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "Z";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 400f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\Gate1Path.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\Gate1PathDeath.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadRuinedGate_ZTg4(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.RuinedGate_ZTg4, db);
            destructable.TextName = "Ruined Gate";
            destructable.TextEditorSuffix = "(Diagonal 2)";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "Z";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 400f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\Gate2Path.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\Gate2PathDeath.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadIcecrownTreeWall(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.IcecrownTreeWall, db);
            destructable.TextName = "Icecrown Tree Wall";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "I";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 0;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 1;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "tree";
            destructable.StatsHitPoints = 50f;
            destructable.ArtOcclusionHeight = 230f;
            destructable.ArtFlyOverHeight = 170f;
            destructable.ArtElevationSampleRadius = 0f;
            destructable.ArtFogRadius = 0f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 42;
            destructable.ArtMinimapColor2Green = 85;
            destructable.ArtMinimapColor3Blue = 112;
            destructable.ArtMinimapUseCustomColorRaw = 1;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadRollingStoneDoor_ZTd1(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.RollingStoneDoor_ZTd1, db);
            destructable.TextName = "Rolling Stone Door";
            destructable.TextEditorSuffix = "(Horizontal 1)";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "Z";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 400f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\RoundDoor2Path.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\RoundDoor2PathDeath.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadRollingStoneDoor_ZTd2(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.RollingStoneDoor_ZTd2, db);
            destructable.TextName = "Rolling Stone Door";
            destructable.TextEditorSuffix = "(Vertical 1)";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "Z";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 400f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\RoundDoor1Path.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\RoundDoor1PathDeath.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadRollingStoneDoor_ZTd3(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.RollingStoneDoor_ZTd3, db);
            destructable.TextName = "Rolling Stone Door";
            destructable.TextEditorSuffix = "(Horizontal 2)";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "Z";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 400f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\RoundDoor2Path.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\RoundDoor2PathDeath.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadRollingStoneDoor_ZTd4(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.RollingStoneDoor_ZTd4, db);
            destructable.TextName = "Rolling Stone Door";
            destructable.TextEditorSuffix = "(Vertical 2)";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "Z";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 400f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\RoundDoor2Path.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\RoundDoor2PathDeath.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadRollingStoneDoor_ZTd5(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.RollingStoneDoor_ZTd5, db);
            destructable.TextName = "Rolling Stone Door";
            destructable.TextEditorSuffix = "(Horizontal 3)";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "Z";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 400f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\RoundDoor2Path.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\RoundDoor2PathDeath.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadRollingStoneDoor_ZTd6(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.RollingStoneDoor_ZTd6, db);
            destructable.TextName = "Rolling Stone Door";
            destructable.TextEditorSuffix = "(Vertical 3)";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "Z";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 400f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\RoundDoor1Path.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\RoundDoor1PathDeath.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadRollingStoneDoor_ZTd7(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.RollingStoneDoor_ZTd7, db);
            destructable.TextName = "Rolling Stone Door";
            destructable.TextEditorSuffix = "(Horizontal 4)";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "Z";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 400f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\RoundDoor2Path.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\RoundDoor2PathDeath.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadRollingStoneDoor_ZTd8(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.RollingStoneDoor_ZTd8, db);
            destructable.TextName = "Rolling Stone Door";
            destructable.TextEditorSuffix = "(Vertical 4)";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "Z";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 400f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\RoundDoor2Path.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\RoundDoor2PathDeath.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadIceBridge_ITib(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.IceBridge_ITib, db);
            destructable.TextName = "Ice Bridge";
            destructable.TextEditorSuffix = "(Vertical)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "I,N";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 1;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeLarge0.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeLarge0Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadIceBridge_ITi2(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.IceBridge_ITi2, db);
            destructable.TextName = "Ice Bridge";
            destructable.TextEditorSuffix = "(Diagonal 1)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "I,N";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 1;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeLarge45.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeLarge45Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadIceBridge_ITi3(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.IceBridge_ITi3, db);
            destructable.TextName = "Ice Bridge";
            destructable.TextEditorSuffix = "(Horizontal)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "I,N";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 1;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeLarge0.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeLarge0Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadIceBridge_ITi4(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.IceBridge_ITi4, db);
            destructable.TextName = "Ice Bridge";
            destructable.TextEditorSuffix = "(Diagonal 2)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "I,N";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 1;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeLarge45.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeLarge45Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadIcyGate_ITg1(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.IcyGate_ITg1, db);
            destructable.TextName = "Icy Gate";
            destructable.TextEditorSuffix = "(Horizontal)";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "I";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 400f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\Gate1Path.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\Gate1PathDeath.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadIcyGate_ITg2(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.IcyGate_ITg2, db);
            destructable.TextName = "Icy Gate";
            destructable.TextEditorSuffix = "(Diagonal 1)";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "I";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 400f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\Gate2Path.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\Gate2PathDeath.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadIcyGate_ITg3(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.IcyGate_ITg3, db);
            destructable.TextName = "Icy Gate";
            destructable.TextEditorSuffix = "(Vertical)";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "I";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 400f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\Gate1Path.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\Gate1PathDeath.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadIcyGate_ITg4(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.IcyGate_ITg4, db);
            destructable.TextName = "Icy Gate";
            destructable.TextEditorSuffix = "(Diagonal 2)";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "I";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 400f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\Gate2Path.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\Gate2PathDeath.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadStoneWall_ITw0(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.StoneWall_ITw0, db);
            destructable.TextName = "Stone Wall";
            destructable.TextEditorSuffix = "(Horizontal)";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "I";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "wall";
            destructable.StatsHitPoints = 200f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\StoneWall1Path.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadStoneWall_ITw1(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.StoneWall_ITw1, db);
            destructable.TextName = "Stone Wall";
            destructable.TextEditorSuffix = "(Diagonal 2)";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "I";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "wall";
            destructable.StatsHitPoints = 200f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\StoneWall2Path.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadStoneWall_ITw2(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.StoneWall_ITw2, db);
            destructable.TextName = "Stone Wall";
            destructable.TextEditorSuffix = "(Vertical)";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "I";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "wall";
            destructable.StatsHitPoints = 200f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\StoneWall3Path.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadStoneWall_ITw3(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.StoneWall_ITw3, db);
            destructable.TextName = "Stone Wall";
            destructable.TextEditorSuffix = "(Diagonal 1)";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "I";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "wall";
            destructable.StatsHitPoints = 200f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\StoneWall4Path.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadTreeBridge_LTt0(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.TreeBridge_LTt0, db);
            destructable.TextName = "Tree Bridge";
            destructable.TextEditorSuffix = "(Vertical)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "L";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 1;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 250f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\TreeBridge0Death.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\TreeBridge0.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadTreeBridge_LTt1(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.TreeBridge_LTt1, db);
            destructable.TextName = "Tree Bridge";
            destructable.TextEditorSuffix = "(Horizontal)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "L";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 1;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 250f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\TreeBridge0Death.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\TreeBridge0.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadTreeBridge_LTt2(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.TreeBridge_LTt2, db);
            destructable.TextName = "Tree Bridge";
            destructable.TextEditorSuffix = "(Vertical)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "F,Q";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 1;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 250f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\TreeBridge0Death.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\TreeBridge0.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadTreeBridge_LTt3(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.TreeBridge_LTt3, db);
            destructable.TextName = "Tree Bridge";
            destructable.TextEditorSuffix = "(Horizontal)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "F,Q";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 1;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 250f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\TreeBridge0Death.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\TreeBridge0.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadTreeBridge_LTt4(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.TreeBridge_LTt4, db);
            destructable.TextName = "Tree Bridge";
            destructable.TextEditorSuffix = "(Vertical)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "W,N,I";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 1;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 250f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\TreeBridge0Death.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\TreeBridge0.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadTreeBridge_ATt0(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.TreeBridge_ATt0, db);
            destructable.TextName = "Tree Bridge";
            destructable.TextEditorSuffix = "(Horizontal)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "W,N,I";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 1;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 250f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\TreeBridge0Death.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\TreeBridge0.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadTreeBridge_ATt1(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.TreeBridge_ATt1, db);
            destructable.TextName = "Tree Bridge";
            destructable.TextEditorSuffix = "(Vertical)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "A";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 1;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 250f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\TreeBridge0Death.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\TreeBridge0.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadTreeBridge_LTt5(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.TreeBridge_LTt5, db);
            destructable.TextName = "Tree Bridge";
            destructable.TextEditorSuffix = "(Horizontal)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "A";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 1;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 250f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\TreeBridge0Death.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\TreeBridge0.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadRuinsNagaCircle(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.RuinsNagaCircle, db);
            destructable.TextName = "Ruins Naga Circle";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "Z";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "decoration";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\4x4Unbuildable.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadIceFloe_ITf1(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.IceFloe_ITf1, db);
            destructable.TextName = "Ice Floe";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "I,N";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\4x4Unbuildable.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadIceFloe_ITf2(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.IceFloe_ITf2, db);
            destructable.TextName = "Ice Floe";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "I,N";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\4x4Unbuildable.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadIceFloe_ITf3(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.IceFloe_ITf3, db);
            destructable.TextName = "Ice Floe";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "I,N";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\4x4Unbuildable.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadIceFloe_ITf4(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.IceFloe_ITf4, db);
            destructable.TextName = "Ice Floe";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "I,N";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\4x4Unbuildable.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadIceRockGate_ITx1(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.IceRockGate_ITx1, db);
            destructable.TextName = "Ice Rock Gate";
            destructable.TextEditorSuffix = "(Horizontal)";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "I,N";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 400f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\Gate1Path.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\Gate1PathDeath.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadIceRockGate_ITx2(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.IceRockGate_ITx2, db);
            destructable.TextName = "Ice Rock Gate";
            destructable.TextEditorSuffix = "(Diagonal 1)";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "I,N";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 400f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\Gate2Path.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\Gate2PathDeath.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadIceRockGate_ITx3(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.IceRockGate_ITx3, db);
            destructable.TextName = "Ice Rock Gate";
            destructable.TextEditorSuffix = "(Vertical)";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "I,N";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 400f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\Gate1Path.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\Gate1PathDeath.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadIceRockGate_ITx4(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.IceRockGate_ITx4, db);
            destructable.TextName = "Ice Rock Gate";
            destructable.TextEditorSuffix = "(Diagonal 2)";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "I,N";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 400f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\Gate2Path.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\Gate2PathDeath.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadAshenvaleCanopyTree(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.AshenvaleCanopyTree, db);
            destructable.TextName = "Ashenvale Canopy Tree";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "A";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 0;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 1;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "tree";
            destructable.StatsHitPoints = 50f;
            destructable.ArtOcclusionHeight = 300f;
            destructable.ArtFlyOverHeight = 435f;
            destructable.ArtElevationSampleRadius = 0f;
            destructable.ArtFogRadius = 0f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 30;
            destructable.ArtMinimapColor2Green = 94;
            destructable.ArtMinimapColor3Blue = 70;
            destructable.ArtMinimapUseCustomColorRaw = 1;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadOutlandTreeWall(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.OutlandTreeWall, db);
            destructable.TextName = "Outland Tree Wall";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "O";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 0;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 1;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "tree";
            destructable.StatsHitPoints = 50f;
            destructable.ArtOcclusionHeight = 230f;
            destructable.ArtFlyOverHeight = 170f;
            destructable.ArtElevationSampleRadius = 0f;
            destructable.ArtFogRadius = 0f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 170;
            destructable.ArtMinimapColor2Green = 92;
            destructable.ArtMinimapColor3Blue = 90;
            destructable.ArtMinimapUseCustomColorRaw = 1;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadBlackCitadelTreeWall(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.BlackCitadelTreeWall, db);
            destructable.TextName = "Black Citadel Tree Wall";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "K";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 0;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 1;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "tree";
            destructable.StatsHitPoints = 50f;
            destructable.ArtOcclusionHeight = 230f;
            destructable.ArtFlyOverHeight = 170f;
            destructable.ArtElevationSampleRadius = 0f;
            destructable.ArtFogRadius = 0f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 135;
            destructable.ArtMinimapColor2Green = 75;
            destructable.ArtMinimapColor3Blue = 70;
            destructable.ArtMinimapUseCustomColorRaw = 1;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadIgloo(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.Igloo, db);
            destructable.TextName = "Igloo";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "I,N";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 250f;
            destructable.ArtOcclusionHeight = 230f;
            destructable.ArtFlyOverHeight = 100f;
            destructable.ArtElevationSampleRadius = 0f;
            destructable.ArtFogRadius = 0f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadElevator_DTrf(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.Elevator_DTrf, db);
            destructable.TextName = "Elevator";
            destructable.TextEditorSuffix = "(1)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 1;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 1;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "decoration";
            destructable.StatsHitPoints = 50f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 0f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\8x8Unbuildable.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\8x8Unbuildable.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadElevator_DTrx(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.Elevator_DTrx, db);
            destructable.TextName = "Elevator";
            destructable.TextEditorSuffix = "(2)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 1;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 1;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "decoration";
            destructable.StatsHitPoints = 50f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 0f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\8x8Unbuildable.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\8x8Unbuildable.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadMagicalPen_XTmp(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.MagicalPen_XTmp, db);
            destructable.TextName = "Magical Pen";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "X";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 1;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 250f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\8x8PenPath.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 0;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadMagicalPen_XTm5(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.MagicalPen_XTm5, db);
            destructable.TextName = "Magical Pen";
            destructable.TextEditorSuffix = "(Angled)";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "X";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 1;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 250f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\12x10Pen45Path.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 0;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadMagicalPenWall_XTmx(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.MagicalPenWall_XTmx, db);
            destructable.TextName = "Magical Pen Wall";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "X";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 1;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 250f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\8x2Default.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 0;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadMagicalPenWall_XTx5(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.MagicalPenWall_XTx5, db);
            destructable.TextName = "Magical Pen Wall";
            destructable.TextEditorSuffix = "(Angled)";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "X";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 1;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 250f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\Fence45.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 0;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadIceyRock(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.IceyRock, db);
            destructable.TextName = "Icey Rock";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "I";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 1;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 230f;
            destructable.ArtFlyOverHeight = 100f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\8x8Default.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadElevatorWall(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.ElevatorWall, db);
            destructable.TextName = "Elevator Wall";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 1;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 1;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "decoration";
            destructable.StatsHitPoints = 9999f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 0f;
            destructable.ArtFogRadius = 0f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\16x4ElevatorBlockPath.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\16x4ElevatorBlockPathDeath.tga";
            destructable.ArtMinimapShowRaw = 0;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadWharf(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.Wharf, db);
            destructable.TextName = "Wharf";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "A";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 1;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "_";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadPathingBlockerBoth(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.PathingBlockerBoth, db);
            destructable.TextName = "Pathing Blocker (Both)";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "P";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 1;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 1;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "decoration";
            destructable.StatsHitPoints = 9999f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 0f;
            destructable.ArtFogRadius = 0f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\2x2Unflyable.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 0;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadPathingBlockerBothLarge(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.PathingBlockerBothLarge, db);
            destructable.TextName = "Pathing Blocker (Both) (Large)";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "P";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 1;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 1;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "decoration";
            destructable.StatsHitPoints = 9999f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 0f;
            destructable.ArtFogRadius = 0f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\4x4Unflyable.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 0;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadLineOfSightBlocker(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.LineOfSightBlocker, db);
            destructable.TextName = "Line of Sight Blocker";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "P";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 1;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 1;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "decoration";
            destructable.StatsHitPoints = 9999f;
            destructable.ArtOcclusionHeight = 230f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 0f;
            destructable.ArtFogRadius = 0f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 0;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadLineOfSightBlockerLarge(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.LineOfSightBlockerLarge, db);
            destructable.TextName = "Line of Sight Blocker (Large)";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "P";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 1;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 1;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "decoration";
            destructable.StatsHitPoints = 9999f;
            destructable.ArtOcclusionHeight = 230f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 0f;
            destructable.ArtFogRadius = 0f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 0;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadPathingBlockerGround(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.PathingBlockerGround, db);
            destructable.TextName = "Pathing Blocker (Ground)";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "P";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 1;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 1;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "decoration";
            destructable.StatsHitPoints = 9999f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 0f;
            destructable.ArtFogRadius = 0f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 0;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadPathingBlockerGroundLarge(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.PathingBlockerGroundLarge, db);
            destructable.TextName = "Pathing Blocker (Ground) (Large)";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "P";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 1;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 1;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "decoration";
            destructable.StatsHitPoints = 9999f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 0f;
            destructable.ArtFogRadius = 0f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 0;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadPathingBlockerAir(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.PathingBlockerAir, db);
            destructable.TextName = "Pathing Blocker (Air)";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "P";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 1;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 1;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "decoration";
            destructable.StatsHitPoints = 9999f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 0f;
            destructable.ArtFogRadius = 0f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\2x2Cyan.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 0;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadPathingBlockerAirLarge(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.PathingBlockerAirLarge, db);
            destructable.TextName = "Pathing Blocker (Air) (Large)";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "P";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 1;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 1;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "decoration";
            destructable.StatsHitPoints = 9999f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 0f;
            destructable.ArtFogRadius = 0f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\4x4Cyan.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 0;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadMassiveRuinedGate_ZTsg(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.MassiveRuinedGate_ZTsg, db);
            destructable.TextName = "Massive Ruined Gate";
            destructable.TextEditorSuffix = "(Vertical)";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "Z";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 1;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 400f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\GateLarge1Path.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\GateLarge1PathDeath.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadMassiveRuinedGate_ZTsx(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.MassiveRuinedGate_ZTsx, db);
            destructable.TextName = "Massive Ruined Gate";
            destructable.TextEditorSuffix = "(Horizontal)";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "Z";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 1;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 400f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\GateLarge1Path.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\GateLarge1PathDeath.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadFootSwitch_DTfp(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.FootSwitch_DTfp, db);
            destructable.TextName = "Foot Switch";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 1;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "decoration";
            destructable.StatsHitPoints = 50f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 100f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\4x4Unbuildable.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\4x4Unbuildable.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadFootSwitch_DTfx(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.FootSwitch_DTfx, db);
            destructable.TextName = "Foot Switch";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 1;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "decoration";
            destructable.StatsHitPoints = 50f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 100f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\4x4Unbuildable.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\4x4Unbuildable.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadLever(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.Lever, db);
            destructable.TextName = "Lever";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "D,G";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 1;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 5f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\2x2Default.tga";
            destructable.ArtMinimapShowRaw = 0;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadCityEntrance_YTce(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.CityEntrance_YTce, db);
            destructable.TextName = "City Entrance";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "Y,X";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 1;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 400f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\GateLarge1Path.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\GateLarge1PathDeath.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadCityEntrance_YTcx(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.CityEntrance_YTcx, db);
            destructable.TextName = "City Entrance";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "Y,X";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 1;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 400f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\GateLarge1Path.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\GateLarge1PathDeath.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadLastHopeBridge_LTtc(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.LastHopeBridge_LTtc, db);
            destructable.TextName = "Last Hope Bridge";
            destructable.TextEditorSuffix = "(Vertical)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "Q";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeLarge0.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeLarge0Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadLastHopeBridge_LTtx(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.LastHopeBridge_LTtx, db);
            destructable.TextName = "Last Hope Bridge";
            destructable.TextEditorSuffix = "(Horizontal)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "Q";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeLarge0.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeLarge0Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadCityscapeRuinedTreeWall(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.CityscapeRuinedTreeWall, db);
            destructable.TextName = "Cityscape Ruined Tree Wall";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "J";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 0;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 1;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "tree";
            destructable.StatsHitPoints = 50f;
            destructable.ArtOcclusionHeight = 300f;
            destructable.ArtFlyOverHeight = 170f;
            destructable.ArtElevationSampleRadius = 0f;
            destructable.ArtFogRadius = 0f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 32;
            destructable.ArtMinimapColor2Green = 90;
            destructable.ArtMinimapColor3Blue = 32;
            destructable.ArtMinimapUseCustomColorRaw = 1;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadDalaranRuinsTreeWall(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.DalaranRuinsTreeWall, db);
            destructable.TextName = "Dalaran Ruins Tree Wall";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "J";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 0;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 1;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "tree";
            destructable.StatsHitPoints = 50f;
            destructable.ArtOcclusionHeight = 230f;
            destructable.ArtFlyOverHeight = 170f;
            destructable.ArtElevationSampleRadius = 0f;
            destructable.ArtFogRadius = 0f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 32;
            destructable.ArtMinimapColor2Green = 90;
            destructable.ArtMinimapColor3Blue = 32;
            destructable.ArtMinimapUseCustomColorRaw = 1;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadFrozenThroneGate(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.FrozenThroneGate, db);
            destructable.TextName = "Frozen Throne Gate";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "I";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 1;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 400f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\GateLarge1Path.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\GateLarge1PathDeath.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadUndergroundTreeWall(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.UndergroundTreeWall, db);
            destructable.TextName = "Underground Tree Wall";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "G";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 0;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 1;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "tree";
            destructable.StatsHitPoints = 50f;
            destructable.ArtOcclusionHeight = 230f;
            destructable.ArtFlyOverHeight = 170f;
            destructable.ArtElevationSampleRadius = 0f;
            destructable.ArtFogRadius = 0f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 60;
            destructable.ArtMinimapColor2Green = 124;
            destructable.ArtMinimapColor3Blue = 150;
            destructable.ArtMinimapUseCustomColorRaw = 1;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadResurrectionStone_BTrs(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.ResurrectionStone_BTrs, db);
            destructable.TextName = "Resurrection Stone";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "B";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "wall";
            destructable.StatsHitPoints = 50f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 0;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadResurrectionStone_BTrx(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.ResurrectionStone_BTrx, db);
            destructable.TextName = "Resurrection Stone";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "B";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "wall";
            destructable.StatsHitPoints = 50f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 0;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadShimmeringPortal(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.ShimmeringPortal, db);
            destructable.TextName = "Shimmering Portal";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "decoration";
            destructable.StatsHitPoints = 50f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 0f;
            destructable.ArtFogRadius = 0f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "_";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 0;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadInvisiblePlatform(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.InvisiblePlatform, db);
            destructable.TextName = "Invisible Platform";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 1;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "decoration";
            destructable.StatsHitPoints = 50f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 0f;
            destructable.ArtFogRadius = 0f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\4x4Unbuildable.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 0;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadInvisiblePlatformSmall(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.InvisiblePlatformSmall, db);
            destructable.TextName = "Invisible Platform (small)";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 1;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "decoration";
            destructable.StatsHitPoints = 50f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 0f;
            destructable.ArtFogRadius = 0f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\2x2Unbuildable.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 0;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadBarrensCanopyTree(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.BarrensCanopyTree, db);
            destructable.TextName = "Barrens Canopy Tree";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "B";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 0;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 1;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "tree";
            destructable.StatsHitPoints = 50f;
            destructable.ArtOcclusionHeight = 300f;
            destructable.ArtFlyOverHeight = 435f;
            destructable.ArtElevationSampleRadius = 0f;
            destructable.ArtFogRadius = 0f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 155;
            destructable.ArtMinimapColor2Green = 110;
            destructable.ArtMinimapColor3Blue = 30;
            destructable.ArtMinimapUseCustomColorRaw = 1;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadFelwoodCanopyTree(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.FelwoodCanopyTree, db);
            destructable.TextName = "Felwood Canopy Tree";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "C";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 0;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 1;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "tree";
            destructable.StatsHitPoints = 50f;
            destructable.ArtOcclusionHeight = 300f;
            destructable.ArtFlyOverHeight = 435f;
            destructable.ArtElevationSampleRadius = 0f;
            destructable.ArtFogRadius = 0f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 75;
            destructable.ArtMinimapColor2Green = 78;
            destructable.ArtMinimapColor3Blue = 26;
            destructable.ArtMinimapUseCustomColorRaw = 1;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadNorthrendCanopyTree(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.NorthrendCanopyTree, db);
            destructable.TextName = "Northrend Canopy Tree";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "I";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 0;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 1;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "tree";
            destructable.StatsHitPoints = 50f;
            destructable.ArtOcclusionHeight = 300f;
            destructable.ArtFlyOverHeight = 435f;
            destructable.ArtElevationSampleRadius = 0f;
            destructable.ArtFogRadius = 0f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 54;
            destructable.ArtMinimapColor2Green = 54;
            destructable.ArtMinimapColor3Blue = 54;
            destructable.ArtMinimapUseCustomColorRaw = 1;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadRuinsCanopyTree(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.RuinsCanopyTree, db);
            destructable.TextName = "Ruins Canopy Tree";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "Z";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 0;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 1;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "tree";
            destructable.StatsHitPoints = 50f;
            destructable.ArtOcclusionHeight = 300f;
            destructable.ArtFlyOverHeight = 435f;
            destructable.ArtElevationSampleRadius = 0f;
            destructable.ArtFogRadius = 0f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 135;
            destructable.ArtMinimapColor2Green = 116;
            destructable.ArtMinimapColor3Blue = 32;
            destructable.ArtMinimapUseCustomColorRaw = 1;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadIcecrownCanopyTree(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.IcecrownCanopyTree, db);
            destructable.TextName = "Icecrown Canopy Tree";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "I";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 0;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 1;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "tree";
            destructable.StatsHitPoints = 50f;
            destructable.ArtOcclusionHeight = 300f;
            destructable.ArtFlyOverHeight = 435f;
            destructable.ArtElevationSampleRadius = 0f;
            destructable.ArtFogRadius = 0f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 157;
            destructable.ArtMinimapColor2Green = 163;
            destructable.ArtMinimapColor3Blue = 172;
            destructable.ArtMinimapUseCustomColorRaw = 1;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadIcecrownThrone(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.IcecrownThrone, db);
            destructable.TextName = "Icecrown Throne";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "I";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "decoration";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 0f;
            destructable.ArtFogRadius = 0f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\throne.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadIcecrownThroneDiagonal1_IOt1(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.IcecrownThroneDiagonal1_IOt1, db);
            destructable.TextName = "Icecrown Throne (Diagonal 1)";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "I";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "decoration";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 0f;
            destructable.ArtFogRadius = 0f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\throne135.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadIcecrownThroneDiagonal1_IOt2(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.IcecrownThroneDiagonal1_IOt2, db);
            destructable.TextName = "Icecrown Throne (Diagonal 1)";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "I";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "decoration";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 0f;
            destructable.ArtFogRadius = 0f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\throne45.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadRockChunks_LTrc(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.RockChunks_LTrc, db);
            destructable.TextName = "Rock Chunks";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "L,W,F,V,Q,X,Y,J";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 250f;
            destructable.ArtOcclusionHeight = 230f;
            destructable.ArtFlyOverHeight = 100f;
            destructable.ArtElevationSampleRadius = 0f;
            destructable.ArtFogRadius = 0f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadRockChunks_LTrt(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.RockChunks_LTrt, db);
            destructable.TextName = "Rock Chunks";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "L,W,F,V,Q,X,Y,J";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 250f;
            destructable.ArtOcclusionHeight = 230f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 0f;
            destructable.ArtFogRadius = 0f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadExtraWideNaturalBridge_YT48(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.ExtraWideNaturalBridge_YT48, db);
            destructable.TextName = "Extra Wide Natural Bridge";
            destructable.TextEditorSuffix = "(Vertical)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeExtraExtraLarge0.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeExtraExtraLarge0Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadExtraWideNaturalBridge_YT49(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.ExtraWideNaturalBridge_YT49, db);
            destructable.TextName = "Extra Wide Natural Bridge";
            destructable.TextEditorSuffix = "(Diagonal 1)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeExtraExtraLarge45.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeExtraExtraLarge45Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadExtraWideNaturalBridge_YT50(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.ExtraWideNaturalBridge_YT50, db);
            destructable.TextName = "Extra Wide Natural Bridge";
            destructable.TextEditorSuffix = "(Horizontal)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeExtraExtraLarge0.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeExtraExtraLarge0Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadExtraWideNaturalBridge_YT51(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.ExtraWideNaturalBridge_YT51, db);
            destructable.TextName = "Extra Wide Natural Bridge";
            destructable.TextEditorSuffix = "(Diagonal 2)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeExtraExtraLarge45.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeExtraExtraLarge45Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadDemonStorm(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.DemonStorm, db);
            destructable.TextName = "Demon Storm";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 1;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "decoration";
            destructable.StatsHitPoints = 50f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 0f;
            destructable.ArtFogRadius = 0f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "_";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 0;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadRockinArthas(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.RockinArthas, db);
            destructable.TextName = "Rockin Arthas";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "I";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "decoration";
            destructable.StatsHitPoints = 50f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 0f;
            destructable.ArtFogRadius = 0f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "_";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 0;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadSupportColumn(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.SupportColumn, db);
            destructable.TextName = "Support Column";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "wall";
            destructable.StatsHitPoints = 50f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\2x2Default.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadStoneRamp_LTs1(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.StoneRamp_LTs1, db);
            destructable.TextName = "Stone Ramp";
            destructable.TextEditorSuffix = "(Bottom Left)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 30f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\CliffRampStraight90.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CliffRampStraight90Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadStoneRamp_LTs2(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.StoneRamp_LTs2, db);
            destructable.TextName = "Stone Ramp";
            destructable.TextEditorSuffix = "(Top Left)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 30f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\CliffRampStraight180.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CliffRampStraight180Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadStoneRamp_LTs3(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.StoneRamp_LTs3, db);
            destructable.TextName = "Stone Ramp";
            destructable.TextEditorSuffix = "(Top Right)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 30f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\CliffRampStraight270.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CliffRampStraight270Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadStoneRamp_LTs4(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.StoneRamp_LTs4, db);
            destructable.TextName = "Stone Ramp";
            destructable.TextEditorSuffix = "(Bottom Right)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 30f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\CliffRampStraight0.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CliffRampStraight0Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadStoneRamp_LTs5(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.StoneRamp_LTs5, db);
            destructable.TextName = "Stone Ramp";
            destructable.TextEditorSuffix = "(Bottom Left 2)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 30f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\CliffRampStraight90.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CliffRampStraight90Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadStoneRamp_LTs6(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.StoneRamp_LTs6, db);
            destructable.TextName = "Stone Ramp";
            destructable.TextEditorSuffix = "(Top Left 2)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 30f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\CliffRampStraight180.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CliffRampStraight180Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadStoneRamp_LTs7(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.StoneRamp_LTs7, db);
            destructable.TextName = "Stone Ramp";
            destructable.TextEditorSuffix = "(Top Right 2)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 30f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\CliffRampStraight270.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CliffRampStraight270Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadStoneRamp_LTs8(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.StoneRamp_LTs8, db);
            destructable.TextName = "Stone Ramp";
            destructable.TextEditorSuffix = "(Bottom Right 2)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 30f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\CliffRampStraight0.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CliffRampStraight0Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadVolcano(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.Volcano, db);
            destructable.TextName = "Volcano";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 0;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "decoration";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 100f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "_";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 0;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadSilvermoonTree(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.SilvermoonTree, db);
            destructable.TextName = "Silvermoon Tree";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "Y";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 0;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 1;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "tree";
            destructable.StatsHitPoints = 50f;
            destructable.ArtOcclusionHeight = 300f;
            destructable.ArtFlyOverHeight = 256f;
            destructable.ArtElevationSampleRadius = 0f;
            destructable.ArtFogRadius = 0f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 125;
            destructable.ArtMinimapColor2Green = 108;
            destructable.ArtMinimapColor3Blue = 18;
            destructable.ArtMinimapUseCustomColorRaw = 1;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadIcecrownCitadelEntrance(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.IcecrownCitadelEntrance, db);
            destructable.TextName = "Icecrown Citadel Entrance";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "I";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 1;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 1;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 400f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = null;
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadLordaeronCityMainGate(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.LordaeronCityMainGate, db);
            destructable.TextName = "Lordaeron City Main Gate";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "F";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 1;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 1;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 400f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = null;
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadLordaeronCityMainGateColumn(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.LordaeronCityMainGateColumn, db);
            destructable.TextName = "Lordaeron City Main Gate Column";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "F";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 1;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "wall";
            destructable.StatsHitPoints = 50f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\8x8Default.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\8x8Default.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadLordaeronCityMainGateDestroyed(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.LordaeronCityMainGateDestroyed, db);
            destructable.TextName = "Lordaeron City Main Gate Destroyed";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "F";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 1;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 1;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 400f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = null;
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadLordaeronCityMainGateColumnDestroyed(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.LordaeronCityMainGateColumnDestroyed, db);
            destructable.TextName = "Lordaeron City Main Gate Column Destroyed";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "F";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 1;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "wall";
            destructable.StatsHitPoints = 50f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\8x8Default.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\8x8Default.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadLionStatue(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.LionStatue, db);
            destructable.TextName = "Lion Statue";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "F";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 1;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "wall";
            destructable.StatsHitPoints = 50f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\8x8Default.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\8x8Default.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadLionStatueDestroyed(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.LionStatueDestroyed, db);
            destructable.TextName = "Lion Statue Destroyed";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "F";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 1;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "wall";
            destructable.StatsHitPoints = 50f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\8x8Default.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\8x8Default.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadLordaeronCitySpire(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.LordaeronCitySpire, db);
            destructable.TextName = "Lordaeron City Spire";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "F";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 1;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "wall";
            destructable.StatsHitPoints = 50f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\8x8Default.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\8x8Default.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadLordaeronCitySpireDestroyed(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.LordaeronCitySpireDestroyed, db);
            destructable.TextName = "Lordaeron City Spire Destroyed";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "F";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 1;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "wall";
            destructable.StatsHitPoints = 50f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\8x8Default.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\8x8Default.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadLordaeronCityDome(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.LordaeronCityDome, db);
            destructable.TextName = "Lordaeron City Dome";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "F";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 1;
            destructable.EditorPlaceableOnCliffsRaw = 0;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 100f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = null;
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadLordaeronCityDomeDestroyed(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.LordaeronCityDomeDestroyed, db);
            destructable.TextName = "Lordaeron City Dome Destroyed";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "F";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 1;
            destructable.EditorPlaceableOnCliffsRaw = 0;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 100f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = null;
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadLordaeronCityMainBuilding(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.LordaeronCityMainBuilding, db);
            destructable.TextName = "Lordaeron City Main Building";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "F";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 1;
            destructable.EditorPlaceableOnCliffsRaw = 0;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 100f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = null;
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadLordaeronCityMainBuildingDestroyed(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.LordaeronCityMainBuildingDestroyed, db);
            destructable.TextName = "Lordaeron City Main Building Destroyed";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "F";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 1;
            destructable.EditorPlaceableOnCliffsRaw = 0;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 100f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = null;
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadOrgrimmarWallSegmentUnderConstruction(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.OrgrimmarWallSegmentUnderConstruction, db);
            destructable.TextName = "Orgrimmar Wall Segment Under Construction";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "B";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 1;
            destructable.EditorPlaceableOnCliffsRaw = 0;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 100f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\12x12Unflyable.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadOrgrimmarWallSegmentCompleted(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.OrgrimmarWallSegmentCompleted, db);
            destructable.TextName = "Orgrimmar Wall Segment Completed";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "B";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 1;
            destructable.EditorPlaceableOnCliffsRaw = 0;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 100f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\12x12Unflyable.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadOrgrimmarTowerUnderConstruction(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.OrgrimmarTowerUnderConstruction, db);
            destructable.TextName = "Orgrimmar Tower Under Construction";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "B";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 1;
            destructable.EditorPlaceableOnCliffsRaw = 0;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 100f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = null;
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadOrgrimmarTowerCompleted(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.OrgrimmarTowerCompleted, db);
            destructable.TextName = "Orgrimmar Tower Completed";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "B";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 1;
            destructable.EditorPlaceableOnCliffsRaw = 0;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 100f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = null;
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadOrgrimmarGate(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.OrgrimmarGate, db);
            destructable.TextName = "Orgrimmar Gate";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "B";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 1;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 1;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 400f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = null;
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadSpecialIceBridge(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.SpecialIceBridge, db);
            destructable.TextName = "Special Ice Bridge";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "Y";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 1;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeExtraLarge0.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeExtraLarge0Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadElvenBridge(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.ElvenBridge, db);
            destructable.TextName = "Elven Bridge";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "Y";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 1;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeExtraLarge0.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeExtraLarge0Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadShortStratholmeBridge_YY12(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.ShortStratholmeBridge_YY12, db);
            destructable.TextName = "Short Stratholme Bridge";
            destructable.TextEditorSuffix = "(Vertical)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 100f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeSmall0.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeSmall0Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadShortStratholmeBridge_YY13(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.ShortStratholmeBridge_YY13, db);
            destructable.TextName = "Short Stratholme Bridge";
            destructable.TextEditorSuffix = "(Diagonal 1)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 100f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeSmall45.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeSmall45Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadShortStratholmeBridge_YY14(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.ShortStratholmeBridge_YY14, db);
            destructable.TextName = "Short Stratholme Bridge";
            destructable.TextEditorSuffix = "(Horizontal)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 100f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeSmall90.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeSmall90Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadShortStratholmeBridge_YY15(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.ShortStratholmeBridge_YY15, db);
            destructable.TextName = "Short Stratholme Bridge";
            destructable.TextEditorSuffix = "(Diagonal 2)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 100f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeSmall135.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeSmall135Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadLongStratholmeBridge_YY16(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.LongStratholmeBridge_YY16, db);
            destructable.TextName = "Long Stratholme Bridge";
            destructable.TextEditorSuffix = "(Vertical)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeLarge0.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeLarge0Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadLongStratholmeBridge_YY17(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.LongStratholmeBridge_YY17, db);
            destructable.TextName = "Long Stratholme Bridge";
            destructable.TextEditorSuffix = "(Diagonal 1)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeLarge45.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeLarge45Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadLongStratholmeBridge_YY18(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.LongStratholmeBridge_YY18, db);
            destructable.TextName = "Long Stratholme Bridge";
            destructable.TextEditorSuffix = "(Horizontal)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeLarge90.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeLarge90Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadLongStratholmeBridge_YY19(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.LongStratholmeBridge_YY19, db);
            destructable.TextName = "Long Stratholme Bridge";
            destructable.TextEditorSuffix = "(Diagonal 2)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeLarge135.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeLarge135Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadWideStratholmeBridge_YY20(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.WideStratholmeBridge_YY20, db);
            destructable.TextName = "Wide Stratholme Bridge";
            destructable.TextEditorSuffix = "(Vertical)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeExtraLarge0.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeExtraLarge0Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadWideStratholmeBridge_YY21(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.WideStratholmeBridge_YY21, db);
            destructable.TextName = "Wide Stratholme Bridge";
            destructable.TextEditorSuffix = "(Diagonal 1)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeExtraLarge45.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeExtraLarge45Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadWideStratholmeBridge_YY22(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.WideStratholmeBridge_YY22, db);
            destructable.TextName = "Wide Stratholme Bridge";
            destructable.TextEditorSuffix = "(Horizontal)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeExtraLarge90.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeExtraLarge90Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadWideStratholmeBridge_YY23(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.WideStratholmeBridge_YY23, db);
            destructable.TextName = "Wide Stratholme Bridge";
            destructable.TextEditorSuffix = "(Diagonal 2)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeExtraLarge135.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeExtraLarge135Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadShortOvergrownBridge_OG00(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.ShortOvergrownBridge_OG00, db);
            destructable.TextName = "Short Overgrown Bridge";
            destructable.TextEditorSuffix = "(Vertical)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 100f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeSmall0.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeSmall0Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadShortOvergrownBridge_OG01(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.ShortOvergrownBridge_OG01, db);
            destructable.TextName = "Short Overgrown Bridge";
            destructable.TextEditorSuffix = "(Diagonal 1)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 100f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeSmall45.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeSmall45Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadShortOvergrownBridge_OG02(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.ShortOvergrownBridge_OG02, db);
            destructable.TextName = "Short Overgrown Bridge";
            destructable.TextEditorSuffix = "(Horizontal)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 100f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeSmall0.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeSmall0Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadShortOvergrownBridge_OG03(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.ShortOvergrownBridge_OG03, db);
            destructable.TextName = "Short Overgrown Bridge";
            destructable.TextEditorSuffix = "(Diagonal 2)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 100f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeSmall45.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeSmall45Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadLongOvergrownBridge_OG04(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.LongOvergrownBridge_OG04, db);
            destructable.TextName = "Long Overgrown Bridge";
            destructable.TextEditorSuffix = "(Vertical)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeLarge0.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeLarge0Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadLongOvergrownBridge_OG05(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.LongOvergrownBridge_OG05, db);
            destructable.TextName = "Long Overgrown Bridge";
            destructable.TextEditorSuffix = "(Diagonal 1)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeLarge45.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeLarge45Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadLongOvergrownBridge_OG06(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.LongOvergrownBridge_OG06, db);
            destructable.TextName = "Long Overgrown Bridge";
            destructable.TextEditorSuffix = "(Horizontal)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeLarge0.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeLarge0Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadLongOvergrownBridge_OG07(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.LongOvergrownBridge_OG07, db);
            destructable.TextName = "Long Overgrown Bridge";
            destructable.TextEditorSuffix = "(Diagonal 2)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeLarge45.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeLarge45Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadWideOvergrownBridge_OG08(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.WideOvergrownBridge_OG08, db);
            destructable.TextName = "Wide Overgrown Bridge";
            destructable.TextEditorSuffix = "(Vertical)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeExtraLarge0.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeExtraLarge0Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadWideOvergrownBridge_OG09(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.WideOvergrownBridge_OG09, db);
            destructable.TextName = "Wide Overgrown Bridge";
            destructable.TextEditorSuffix = "(Diagonal 1)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeExtraLarge45.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeExtraLarge45Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadWideOvergrownBridge_OG10(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.WideOvergrownBridge_OG10, db);
            destructable.TextName = "Wide Overgrown Bridge";
            destructable.TextEditorSuffix = "(Horizontal)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeExtraLarge0.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeExtraLarge0Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadWideOvergrownBridge_OG11(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.WideOvergrownBridge_OG11, db);
            destructable.TextName = "Wide Overgrown Bridge";
            destructable.TextEditorSuffix = "(Diagonal 2)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeExtraLarge45.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeExtraLarge45Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadShortRicketyWoodenBridge_RW00(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.ShortRicketyWoodenBridge_RW00, db);
            destructable.TextName = "Short Rickety Wooden Bridge";
            destructable.TextEditorSuffix = "(Vertical)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 100f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeSmall0.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeSmall0Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadShortRicketyWoodenBridge_RW01(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.ShortRicketyWoodenBridge_RW01, db);
            destructable.TextName = "Short Rickety Wooden Bridge";
            destructable.TextEditorSuffix = "(Diagonal 1)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 100f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeSmall45.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeSmall45Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadShortRicketyWoodenBridge_RW02(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.ShortRicketyWoodenBridge_RW02, db);
            destructable.TextName = "Short Rickety Wooden Bridge";
            destructable.TextEditorSuffix = "(Horizontal)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 100f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeSmall0.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeSmall0Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadShortRicketyWoodenBridge_RW03(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.ShortRicketyWoodenBridge_RW03, db);
            destructable.TextName = "Short Rickety Wooden Bridge";
            destructable.TextEditorSuffix = "(Diagonal 2)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 100f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeSmall45.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeSmall45Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadLongRicketyWoodenBridge_RW04(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.LongRicketyWoodenBridge_RW04, db);
            destructable.TextName = "Long Rickety Wooden Bridge";
            destructable.TextEditorSuffix = "(Vertical)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeLarge0.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeLarge0Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadLongRicketyWoodenBridge_RW05(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.LongRicketyWoodenBridge_RW05, db);
            destructable.TextName = "Long Rickety Wooden Bridge";
            destructable.TextEditorSuffix = "(Diagonal 1)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeLarge45.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeLarge45Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadLongRicketyWoodenBridge_RW06(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.LongRicketyWoodenBridge_RW06, db);
            destructable.TextName = "Long Rickety Wooden Bridge";
            destructable.TextEditorSuffix = "(Horizontal)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeLarge0.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeLarge0Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadLongRicketyWoodenBridge_RW07(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.LongRicketyWoodenBridge_RW07, db);
            destructable.TextName = "Long Rickety Wooden Bridge";
            destructable.TextEditorSuffix = "(Diagonal 2)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeLarge45.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeLarge45Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadWideRicketyWoodenBridge_RW08(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.WideRicketyWoodenBridge_RW08, db);
            destructable.TextName = "Wide Rickety Wooden Bridge";
            destructable.TextEditorSuffix = "(Vertical)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeExtraLarge0.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeExtraLarge0Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadWideRicketyWoodenBridge_RW09(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.WideRicketyWoodenBridge_RW09, db);
            destructable.TextName = "Wide Rickety Wooden Bridge";
            destructable.TextEditorSuffix = "(Diagonal 1)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeExtraLarge45.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeExtraLarge45Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadWideRicketyWoodenBridge_RW10(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.WideRicketyWoodenBridge_RW10, db);
            destructable.TextName = "Wide Rickety Wooden Bridge";
            destructable.TextEditorSuffix = "(Horizontal)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeExtraLarge0.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeExtraLarge0Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadWideRicketyWoodenBridge_RW11(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.WideRicketyWoodenBridge_RW11, db);
            destructable.TextName = "Wide Rickety Wooden Bridge";
            destructable.TextEditorSuffix = "(Diagonal 2)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeExtraLarge45.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeExtraLarge45Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadShortElvenBridge_EB00(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.ShortElvenBridge_EB00, db);
            destructable.TextName = "Short Elven Bridge";
            destructable.TextEditorSuffix = "(Vertical)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 100f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeSmall0.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeSmall0Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadShortElvenBridge_EB01(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.ShortElvenBridge_EB01, db);
            destructable.TextName = "Short Elven Bridge";
            destructable.TextEditorSuffix = "(Diagonal 1)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 100f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeSmall45.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeSmall45Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadShortElvenBridge_EB02(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.ShortElvenBridge_EB02, db);
            destructable.TextName = "Short Elven Bridge";
            destructable.TextEditorSuffix = "(Horizontal)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 100f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeSmall0.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeSmall0Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadShortElvenBridge_EB03(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.ShortElvenBridge_EB03, db);
            destructable.TextName = "Short Elven Bridge";
            destructable.TextEditorSuffix = "(Diagonal 2)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 100f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeSmall45.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeSmall45Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadLongElvenBridge_EB04(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.LongElvenBridge_EB04, db);
            destructable.TextName = "Long Elven Bridge";
            destructable.TextEditorSuffix = "(Vertical)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeLarge0.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeLarge0Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadLongElvenBridge_EB05(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.LongElvenBridge_EB05, db);
            destructable.TextName = "Long Elven Bridge";
            destructable.TextEditorSuffix = "(Diagonal 1)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeLarge45.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeLarge45Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadLongElvenBridge_EB06(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.LongElvenBridge_EB06, db);
            destructable.TextName = "Long Elven Bridge";
            destructable.TextEditorSuffix = "(Horizontal)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeLarge0.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeLarge0Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadLongElvenBridge_EB07(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.LongElvenBridge_EB07, db);
            destructable.TextName = "Long Elven Bridge";
            destructable.TextEditorSuffix = "(Diagonal 2)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeLarge45.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeLarge45Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadWideElvenBridge_EB08(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.WideElvenBridge_EB08, db);
            destructable.TextName = "Wide Elven Bridge";
            destructable.TextEditorSuffix = "(Vertical)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeExtraLarge0.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeExtraLarge0Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadWideElvenBridge_EB09(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.WideElvenBridge_EB09, db);
            destructable.TextName = "Wide Elven Bridge";
            destructable.TextEditorSuffix = "(Diagonal 1)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeExtraLarge45.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeExtraLarge45Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadWideElvenBridge_EB10(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.WideElvenBridge_EB10, db);
            destructable.TextName = "Wide Elven Bridge";
            destructable.TextEditorSuffix = "(Horizontal)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeExtraLarge0.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeExtraLarge0Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadWideElvenBridge_EB11(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.WideElvenBridge_EB11, db);
            destructable.TextName = "Wide Elven Bridge";
            destructable.TextEditorSuffix = "(Diagonal 2)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeExtraLarge45.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeExtraLarge45Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadShortNightElvenWoodenBridge_NB00(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.ShortNightElvenWoodenBridge_NB00, db);
            destructable.TextName = "Short Night Elven Wooden Bridge";
            destructable.TextEditorSuffix = "(Vertical)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 100f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeSmall0.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeSmall0Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadShortNightElvenWoodenBridge_NB01(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.ShortNightElvenWoodenBridge_NB01, db);
            destructable.TextName = "Short Night Elven Wooden Bridge";
            destructable.TextEditorSuffix = "(Diagonal 1)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 100f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeSmall45.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeSmall45Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadShortNightElvenWoodenBridge_NB02(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.ShortNightElvenWoodenBridge_NB02, db);
            destructable.TextName = "Short Night Elven Wooden Bridge";
            destructable.TextEditorSuffix = "(Horizontal)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 100f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeSmall0.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeSmall0Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadShortNightElvenWoodenBridge_NB03(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.ShortNightElvenWoodenBridge_NB03, db);
            destructable.TextName = "Short Night Elven Wooden Bridge";
            destructable.TextEditorSuffix = "(Diagonal 2)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 100f;
            destructable.ArtFogRadius = 100f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeSmall45.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeSmall45Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadLongNightElvenWoodenBridge_NB04(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.LongNightElvenWoodenBridge_NB04, db);
            destructable.TextName = "Long Night Elven Wooden Bridge";
            destructable.TextEditorSuffix = "(Vertical)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeLarge0.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeLarge0Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadLongNightElvenWoodenBridge_NB05(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.LongNightElvenWoodenBridge_NB05, db);
            destructable.TextName = "Long Night Elven Wooden Bridge";
            destructable.TextEditorSuffix = "(Diagonal 1)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeLarge45.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeLarge45Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadLongNightElvenWoodenBridge_NB06(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.LongNightElvenWoodenBridge_NB06, db);
            destructable.TextName = "Long Night Elven Wooden Bridge";
            destructable.TextEditorSuffix = "(Horizontal)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeLarge0.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeLarge0Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadLongNightElvenWoodenBridge_NB07(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.LongNightElvenWoodenBridge_NB07, db);
            destructable.TextName = "Long Night Elven Wooden Bridge";
            destructable.TextEditorSuffix = "(Diagonal 2)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeLarge45.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeLarge45Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadWideNightElvenWoodenBridge_NB08(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.WideNightElvenWoodenBridge_NB08, db);
            destructable.TextName = "Wide Night Elven Wooden Bridge";
            destructable.TextEditorSuffix = "(Vertical)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeExtraLarge0.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeExtraLarge0Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadWideNightElvenWoodenBridge_NB09(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.WideNightElvenWoodenBridge_NB09, db);
            destructable.TextName = "Wide Night Elven Wooden Bridge";
            destructable.TextEditorSuffix = "(Diagonal 1)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeExtraLarge45.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeExtraLarge45Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadWideNightElvenWoodenBridge_NB10(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.WideNightElvenWoodenBridge_NB10, db);
            destructable.TextName = "Wide Night Elven Wooden Bridge";
            destructable.TextEditorSuffix = "(Horizontal)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeExtraLarge0.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeExtraLarge0Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadWideNightElvenWoodenBridge_NB11(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.WideNightElvenWoodenBridge_NB11, db);
            destructable.TextName = "Wide Night Elven Wooden Bridge";
            destructable.TextEditorSuffix = "(Diagonal 2)";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 1;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 2;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 2500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 200f;
            destructable.ArtFogRadius = 200f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\CityBridgeExtraLarge45.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\CityBridgeExtraLarge45Death.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadScorchedTreeWall(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.ScorchedTreeWall, db);
            destructable.TextName = "Scorched Tree Wall";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "Y,X";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 0;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 1;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "tree";
            destructable.StatsHitPoints = 50f;
            destructable.ArtOcclusionHeight = 300f;
            destructable.ArtFlyOverHeight = 170f;
            destructable.ArtElevationSampleRadius = 0f;
            destructable.ArtFogRadius = 0f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 30;
            destructable.ArtMinimapColor2Green = 32;
            destructable.ArtMinimapColor3Blue = 30;
            destructable.ArtMinimapUseCustomColorRaw = 1;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadRollingStoneDoor_ITd1(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.RollingStoneDoor_ITd1, db);
            destructable.TextName = "Rolling Stone Door";
            destructable.TextEditorSuffix = "(Horizontal 1)";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "Z";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 400f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\RoundDoor2Path.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\RoundDoor2PathDeath.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadRollingStoneDoor_ITd2(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.RollingStoneDoor_ITd2, db);
            destructable.TextName = "Rolling Stone Door";
            destructable.TextEditorSuffix = "(Vertical 1)";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "Z";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 400f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\RoundDoor1Path.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\RoundDoor1PathDeath.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadRollingStoneDoor_ITd3(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.RollingStoneDoor_ITd3, db);
            destructable.TextName = "Rolling Stone Door";
            destructable.TextEditorSuffix = "(Horizontal 2)";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "Z";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 400f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\RoundDoor2Path.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\RoundDoor2PathDeath.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadRollingStoneDoor_ITd4(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.RollingStoneDoor_ITd4, db);
            destructable.TextName = "Rolling Stone Door";
            destructable.TextEditorSuffix = "(Vertical 2)";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "Z";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "debris";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 400f;
            destructable.ArtFlyOverHeight = 0f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 1;
            destructable.PathingPathingTextureRaw = "PathTextures\\RoundDoor2Path.tga";
            destructable.PathingPathingTextureDeadRaw = "PathTextures\\RoundDoor2PathDeath.tga";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 1;
            return destructable;
        }

        protected virtual Destructable LoadWaygateRamp(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.WaygateRamp, db);
            destructable.TextName = "Waygate Ramp";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "B";
            destructable.EditorTilesetsRaw = "*";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 1;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 0;
            destructable.PathingIsWalkableRaw = 1;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "bridge";
            destructable.StatsHitPoints = 500f;
            destructable.ArtOcclusionHeight = 0f;
            destructable.ArtFlyOverHeight = 30f;
            destructable.ArtElevationSampleRadius = 50f;
            destructable.ArtFogRadius = 50f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "_";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 0;
            destructable.ArtMinimapColor2Green = 0;
            destructable.ArtMinimapColor3Blue = 0;
            destructable.ArtMinimapUseCustomColorRaw = 0;
            destructable.StatsBuildTime = 120;
            destructable.StatsRepairTime = 120;
            destructable.StatsRepairGoldCost = 200;
            destructable.StatsRepairLumberCost = 100;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        protected virtual Destructable LoadNorthrendIcyTreeWall(ObjectDatabaseBase db)
        {
            var destructable = new Destructable(DestructableType.NorthrendIcyTreeWall, db);
            destructable.TextName = "Northrend Icy Tree Wall";
            destructable.TextEditorSuffix = "_";
            destructable.EditorCategoryRaw = "D";
            destructable.EditorTilesetsRaw = "N";
            destructable.EditorHasTilesetSpecificDataRaw = 0;
            destructable.ArtFatLineOfSightRaw = 0;
            destructable.EditorShowHelperObjectForSelectionRaw = 0;
            destructable.EditorPlaceableOnCliffsRaw = 0;
            destructable.EditorPlaceableOnWaterRaw = 1;
            destructable.EditorShowDeadVersionInPaletteRaw = 1;
            destructable.PathingIsWalkableRaw = 0;
            destructable.PathingCliffHeight = 0;
            destructable.CombatTargetedAsRaw = "tree";
            destructable.StatsHitPoints = 50f;
            destructable.ArtOcclusionHeight = 230f;
            destructable.ArtFlyOverHeight = 170f;
            destructable.ArtElevationSampleRadius = 0f;
            destructable.ArtFogRadius = 0f;
            destructable.ArtFogVisibilityRaw = 0;
            destructable.PathingPathingTextureRaw = "PathTextures\\4x4Default.tga";
            destructable.PathingPathingTextureDeadRaw = "_";
            destructable.ArtMinimapShowRaw = 1;
            destructable.ArtMinimapColor1Red = 166;
            destructable.ArtMinimapColor2Green = 187;
            destructable.ArtMinimapColor3Blue = 196;
            destructable.ArtMinimapUseCustomColorRaw = 1;
            destructable.StatsBuildTime = 0;
            destructable.StatsRepairTime = 0;
            destructable.StatsRepairGoldCost = 0;
            destructable.StatsRepairLumberCost = 0;
            destructable.EditorOnUserSpecifiedListRaw = 0;
            destructable.ArtSelectableInGameRaw = 0;
            return destructable;
        }

        public Destructable Load(DestructableType destructableType, ObjectDatabaseBase db)
        {
            return destructableType switch
            {
            DestructableType.AshenvaleTreeWall => LoadAshenvaleTreeWall(db), DestructableType.BarrensTreeWall => LoadBarrensTreeWall(db), DestructableType.FelwoodTreeWall => LoadFelwoodTreeWall(db), DestructableType.FallTreeWall => LoadFallTreeWall(db), DestructableType.Cage => LoadCage(db), DestructableType.Barricade => LoadBarricade(db), DestructableType.Crates => LoadCrates(db), DestructableType.Barrel_LTbr => LoadBarrel_LTbr(db), DestructableType.Barrel_LTbx => LoadBarrel_LTbx(db), DestructableType.Barrel_LTbs => LoadBarrel_LTbs(db), DestructableType.BarrelOfExplosives => LoadBarrelOfExplosives(db), DestructableType.Gate_LTg1 => LoadGate_LTg1(db), DestructableType.Gate_LTg2 => LoadGate_LTg2(db), DestructableType.Gate_LTg3 => LoadGate_LTg3(db), DestructableType.Gate_LTg4 => LoadGate_LTg4(db), DestructableType.ElvenGate_LTe1 => LoadElvenGate_LTe1(db), DestructableType.ElvenGate_LTe2 => LoadElvenGate_LTe2(db), DestructableType.ElvenGate_LTe3 => LoadElvenGate_LTe3(db), DestructableType.ElvenGate_LTe4 => LoadElvenGate_LTe4(db), DestructableType.DemonicGate_ATg1 => LoadDemonicGate_ATg1(db), DestructableType.DemonicGate_ATg2 => LoadDemonicGate_ATg2(db), DestructableType.DemonicGate_ATg3 => LoadDemonicGate_ATg3(db), DestructableType.DemonicGate_ATg4 => LoadDemonicGate_ATg4(db), DestructableType.IronGate_DTg5 => LoadIronGate_DTg5(db), DestructableType.IronGate_DTg6 => LoadIronGate_DTg6(db), DestructableType.IronGate_DTg7 => LoadIronGate_DTg7(db), DestructableType.IronGate_DTg8 => LoadIronGate_DTg8(db), DestructableType.DungeonGate_DTg1 => LoadDungeonGate_DTg1(db), DestructableType.DungeonGate_DTg2 => LoadDungeonGate_DTg2(db), DestructableType.DungeonGate_DTg3 => LoadDungeonGate_DTg3(db), DestructableType.DungeonGate_DTg4 => LoadDungeonGate_DTg4(db), DestructableType.SummerTreeWall => LoadSummerTreeWall(db), DestructableType.NorthrendTreeWall => LoadNorthrendTreeWall(db), DestructableType.WinterTreeWall => LoadWinterTreeWall(db), DestructableType.SnowyTreeWall => LoadSnowyTreeWall(db), DestructableType.CityscapeSummerTreeWall => LoadCityscapeSummerTreeWall(db), DestructableType.CityscapeWinterTreeWall => LoadCityscapeWinterTreeWall(db), DestructableType.CityscapeSnowyTreeWall => LoadCityscapeSnowyTreeWall(db), DestructableType.CityscapeFallTreeWall => LoadCityscapeFallTreeWall(db), DestructableType.VillageTreeWall => LoadVillageTreeWall(db), DestructableType.StoneWall_LTw0 => LoadStoneWall_LTw0(db), DestructableType.StoneWall_LTw1 => LoadStoneWall_LTw1(db), DestructableType.StoneWall_LTw2 => LoadStoneWall_LTw2(db), DestructableType.StoneWall_LTw3 => LoadStoneWall_LTw3(db), DestructableType.ShortNaturalBridge_YT00 => LoadShortNaturalBridge_YT00(db), DestructableType.ShortNaturalBridge_YT01 => LoadShortNaturalBridge_YT01(db), DestructableType.ShortNaturalBridge_YT02 => LoadShortNaturalBridge_YT02(db), DestructableType.ShortNaturalBridge_YT03 => LoadShortNaturalBridge_YT03(db), DestructableType.LongNaturalBridge_YT04 => LoadLongNaturalBridge_YT04(db), DestructableType.LongNaturalBridge_YT05 => LoadLongNaturalBridge_YT05(db), DestructableType.LongNaturalBridge_YT06 => LoadLongNaturalBridge_YT06(db), DestructableType.LongNaturalBridge_YT07 => LoadLongNaturalBridge_YT07(db), DestructableType.WideNaturalBridge_YT08 => LoadWideNaturalBridge_YT08(db), DestructableType.WideNaturalBridge_YT09 => LoadWideNaturalBridge_YT09(db), DestructableType.WideNaturalBridge_YT10 => LoadWideNaturalBridge_YT10(db), DestructableType.WideNaturalBridge_YT11 => LoadWideNaturalBridge_YT11(db), DestructableType.ShortStoneBridge_YT12 => LoadShortStoneBridge_YT12(db), DestructableType.ShortStoneBridge_YT13 => LoadShortStoneBridge_YT13(db), DestructableType.ShortStoneBridge_YT14 => LoadShortStoneBridge_YT14(db), DestructableType.ShortStoneBridge_YT15 => LoadShortStoneBridge_YT15(db), DestructableType.LongStoneBridge_YT16 => LoadLongStoneBridge_YT16(db), DestructableType.LongStoneBridge_YT17 => LoadLongStoneBridge_YT17(db), DestructableType.LongStoneBridge_YT18 => LoadLongStoneBridge_YT18(db), DestructableType.LongStoneBridge_YT19 => LoadLongStoneBridge_YT19(db), DestructableType.WideStoneBridge_YT20 => LoadWideStoneBridge_YT20(db), DestructableType.WideStoneBridge_YT21 => LoadWideStoneBridge_YT21(db), DestructableType.WideStoneBridge_YT22 => LoadWideStoneBridge_YT22(db), DestructableType.WideStoneBridge_YT23 => LoadWideStoneBridge_YT23(db), DestructableType.ShortWoodenBridge_LT00 => LoadShortWoodenBridge_LT00(db), DestructableType.ShortWoodenBridge_LT01 => LoadShortWoodenBridge_LT01(db), DestructableType.ShortWoodenBridge_LT02 => LoadShortWoodenBridge_LT02(db), DestructableType.ShortWoodenBridge_LT03 => LoadShortWoodenBridge_LT03(db), DestructableType.LongWoodenBridge_LT04 => LoadLongWoodenBridge_LT04(db), DestructableType.LongWoodenBridge_LT05 => LoadLongWoodenBridge_LT05(db), DestructableType.LongWoodenBridge_LT06 => LoadLongWoodenBridge_LT06(db), DestructableType.LongWoodenBridge_LT07 => LoadLongWoodenBridge_LT07(db), DestructableType.WideWoodenBridge_LT08 => LoadWideWoodenBridge_LT08(db), DestructableType.WideWoodenBridge_LT09 => LoadWideWoodenBridge_LT09(db), DestructableType.WideWoodenBridge_LT10 => LoadWideWoodenBridge_LT10(db), DestructableType.WideWoodenBridge_LT11 => LoadWideWoodenBridge_LT11(db), DestructableType.DalaranBuilding => LoadDalaranBuilding(db), DestructableType.DalaranVioletCitadel => LoadDalaranVioletCitadel(db), DestructableType.StoneRamp_LTr1 => LoadStoneRamp_LTr1(db), DestructableType.StoneRamp_LTr2 => LoadStoneRamp_LTr2(db), DestructableType.StoneRamp_LTr3 => LoadStoneRamp_LTr3(db), DestructableType.StoneRamp_LTr4 => LoadStoneRamp_LTr4(db), DestructableType.StoneRamp_LTr5 => LoadStoneRamp_LTr5(db), DestructableType.StoneRamp_LTr6 => LoadStoneRamp_LTr6(db), DestructableType.StoneRamp_LTr7 => LoadStoneRamp_LTr7(db), DestructableType.StoneRamp_LTr8 => LoadStoneRamp_LTr8(db), DestructableType.Ship => LoadShip(db), DestructableType.EggSack => LoadEggSack(db), DestructableType.DungeonTreeWall => LoadDungeonTreeWall(db), DestructableType.BridgeDestroyed_YSdb => LoadBridgeDestroyed_YSdb(db), DestructableType.BridgeDestroyed_YSdc => LoadBridgeDestroyed_YSdc(db), DestructableType.KingSThrone => LoadKingSThrone(db), DestructableType.KingSThroneDiagonal1_XOk1 => LoadKingSThroneDiagonal1_XOk1(db), DestructableType.KingSThroneDiagonal1_XOk2 => LoadKingSThroneDiagonal1_XOk2(db), DestructableType.CliffCaveGate_DTc1 => LoadCliffCaveGate_DTc1(db), DestructableType.CliffCaveGate_DTc2 => LoadCliffCaveGate_DTc2(db), DestructableType.DungeonSpikes => LoadDungeonSpikes(db), DestructableType.RockChunks_DTrc => LoadRockChunks_DTrc(db), DestructableType.ForceBridge_DTs0 => LoadForceBridge_DTs0(db), DestructableType.ForceBridge_DTs1 => LoadForceBridge_DTs1(db), DestructableType.ForceBridge_DTs2 => LoadForceBridge_DTs2(db), DestructableType.ForceBridge_DTs3 => LoadForceBridge_DTs3(db), DestructableType.ForceWall_Dofw => LoadForceWall_Dofw(db), DestructableType.ForceWall_Dofv => LoadForceWall_Dofv(db), DestructableType.ShortNaturalBridge_YT24 => LoadShortNaturalBridge_YT24(db), DestructableType.ShortNaturalBridge_YT25 => LoadShortNaturalBridge_YT25(db), DestructableType.ShortNaturalBridge_YT26 => LoadShortNaturalBridge_YT26(db), DestructableType.ShortNaturalBridge_YT27 => LoadShortNaturalBridge_YT27(db), DestructableType.LongNaturalBridge_YT28 => LoadLongNaturalBridge_YT28(db), DestructableType.LongNaturalBridge_YT29 => LoadLongNaturalBridge_YT29(db), DestructableType.LongNaturalBridge_YT30 => LoadLongNaturalBridge_YT30(db), DestructableType.LongNaturalBridge_YT31 => LoadLongNaturalBridge_YT31(db), DestructableType.WideNaturalBridge_YT32 => LoadWideNaturalBridge_YT32(db), DestructableType.WideNaturalBridge_YT33 => LoadWideNaturalBridge_YT33(db), DestructableType.WideNaturalBridge_YT34 => LoadWideNaturalBridge_YT34(db), DestructableType.WideNaturalBridge_YT35 => LoadWideNaturalBridge_YT35(db), DestructableType.ShortStoneBridge_YT36 => LoadShortStoneBridge_YT36(db), DestructableType.ShortStoneBridge_YT37 => LoadShortStoneBridge_YT37(db), DestructableType.ShortStoneBridge_YT38 => LoadShortStoneBridge_YT38(db), DestructableType.ShortStoneBridge_YT39 => LoadShortStoneBridge_YT39(db), DestructableType.LongStoneBridge_YT40 => LoadLongStoneBridge_YT40(db), DestructableType.LongStoneBridge_YT41 => LoadLongStoneBridge_YT41(db), DestructableType.LongStoneBridge_YT42 => LoadLongStoneBridge_YT42(db), DestructableType.LongStoneBridge_YT43 => LoadLongStoneBridge_YT43(db), DestructableType.WideStoneBridge_YT44 => LoadWideStoneBridge_YT44(db), DestructableType.WideStoneBridge_YT45 => LoadWideStoneBridge_YT45(db), DestructableType.WideStoneBridge_YT46 => LoadWideStoneBridge_YT46(db), DestructableType.WideStoneBridge_YT47 => LoadWideStoneBridge_YT47(db), DestructableType.RampNagaSmallLeft => LoadRampNagaSmallLeft(db), DestructableType.RampNagaSmallTop => LoadRampNagaSmallTop(db), DestructableType.RampNagaSmallRight => LoadRampNagaSmallRight(db), DestructableType.RampNagaSmallBottom => LoadRampNagaSmallBottom(db), DestructableType.RuinsTreeWall => LoadRuinsTreeWall(db), DestructableType.StoneWall_ZTw0 => LoadStoneWall_ZTw0(db), DestructableType.StoneWall_ZTw1 => LoadStoneWall_ZTw1(db), DestructableType.StoneWall_ZTw2 => LoadStoneWall_ZTw2(db), DestructableType.StoneWall_ZTw3 => LoadStoneWall_ZTw3(db), DestructableType.RuinedGate_ZTg1 => LoadRuinedGate_ZTg1(db), DestructableType.RuinedGate_ZTg2 => LoadRuinedGate_ZTg2(db), DestructableType.RuinedGate_ZTg3 => LoadRuinedGate_ZTg3(db), DestructableType.RuinedGate_ZTg4 => LoadRuinedGate_ZTg4(db), DestructableType.IcecrownTreeWall => LoadIcecrownTreeWall(db), DestructableType.RollingStoneDoor_ZTd1 => LoadRollingStoneDoor_ZTd1(db), DestructableType.RollingStoneDoor_ZTd2 => LoadRollingStoneDoor_ZTd2(db), DestructableType.RollingStoneDoor_ZTd3 => LoadRollingStoneDoor_ZTd3(db), DestructableType.RollingStoneDoor_ZTd4 => LoadRollingStoneDoor_ZTd4(db), DestructableType.RollingStoneDoor_ZTd5 => LoadRollingStoneDoor_ZTd5(db), DestructableType.RollingStoneDoor_ZTd6 => LoadRollingStoneDoor_ZTd6(db), DestructableType.RollingStoneDoor_ZTd7 => LoadRollingStoneDoor_ZTd7(db), DestructableType.RollingStoneDoor_ZTd8 => LoadRollingStoneDoor_ZTd8(db), DestructableType.IceBridge_ITib => LoadIceBridge_ITib(db), DestructableType.IceBridge_ITi2 => LoadIceBridge_ITi2(db), DestructableType.IceBridge_ITi3 => LoadIceBridge_ITi3(db), DestructableType.IceBridge_ITi4 => LoadIceBridge_ITi4(db), DestructableType.IcyGate_ITg1 => LoadIcyGate_ITg1(db), DestructableType.IcyGate_ITg2 => LoadIcyGate_ITg2(db), DestructableType.IcyGate_ITg3 => LoadIcyGate_ITg3(db), DestructableType.IcyGate_ITg4 => LoadIcyGate_ITg4(db), DestructableType.StoneWall_ITw0 => LoadStoneWall_ITw0(db), DestructableType.StoneWall_ITw1 => LoadStoneWall_ITw1(db), DestructableType.StoneWall_ITw2 => LoadStoneWall_ITw2(db), DestructableType.StoneWall_ITw3 => LoadStoneWall_ITw3(db), DestructableType.TreeBridge_LTt0 => LoadTreeBridge_LTt0(db), DestructableType.TreeBridge_LTt1 => LoadTreeBridge_LTt1(db), DestructableType.TreeBridge_LTt2 => LoadTreeBridge_LTt2(db), DestructableType.TreeBridge_LTt3 => LoadTreeBridge_LTt3(db), DestructableType.TreeBridge_LTt4 => LoadTreeBridge_LTt4(db), DestructableType.TreeBridge_ATt0 => LoadTreeBridge_ATt0(db), DestructableType.TreeBridge_ATt1 => LoadTreeBridge_ATt1(db), DestructableType.TreeBridge_LTt5 => LoadTreeBridge_LTt5(db), DestructableType.RuinsNagaCircle => LoadRuinsNagaCircle(db), DestructableType.IceFloe_ITf1 => LoadIceFloe_ITf1(db), DestructableType.IceFloe_ITf2 => LoadIceFloe_ITf2(db), DestructableType.IceFloe_ITf3 => LoadIceFloe_ITf3(db), DestructableType.IceFloe_ITf4 => LoadIceFloe_ITf4(db), DestructableType.IceRockGate_ITx1 => LoadIceRockGate_ITx1(db), DestructableType.IceRockGate_ITx2 => LoadIceRockGate_ITx2(db), DestructableType.IceRockGate_ITx3 => LoadIceRockGate_ITx3(db), DestructableType.IceRockGate_ITx4 => LoadIceRockGate_ITx4(db), DestructableType.AshenvaleCanopyTree => LoadAshenvaleCanopyTree(db), DestructableType.OutlandTreeWall => LoadOutlandTreeWall(db), DestructableType.BlackCitadelTreeWall => LoadBlackCitadelTreeWall(db), DestructableType.Igloo => LoadIgloo(db), DestructableType.Elevator_DTrf => LoadElevator_DTrf(db), DestructableType.Elevator_DTrx => LoadElevator_DTrx(db), DestructableType.MagicalPen_XTmp => LoadMagicalPen_XTmp(db), DestructableType.MagicalPen_XTm5 => LoadMagicalPen_XTm5(db), DestructableType.MagicalPenWall_XTmx => LoadMagicalPenWall_XTmx(db), DestructableType.MagicalPenWall_XTx5 => LoadMagicalPenWall_XTx5(db), DestructableType.IceyRock => LoadIceyRock(db), DestructableType.ElevatorWall => LoadElevatorWall(db), DestructableType.Wharf => LoadWharf(db), DestructableType.PathingBlockerBoth => LoadPathingBlockerBoth(db), DestructableType.PathingBlockerBothLarge => LoadPathingBlockerBothLarge(db), DestructableType.LineOfSightBlocker => LoadLineOfSightBlocker(db), DestructableType.LineOfSightBlockerLarge => LoadLineOfSightBlockerLarge(db), DestructableType.PathingBlockerGround => LoadPathingBlockerGround(db), DestructableType.PathingBlockerGroundLarge => LoadPathingBlockerGroundLarge(db), DestructableType.PathingBlockerAir => LoadPathingBlockerAir(db), DestructableType.PathingBlockerAirLarge => LoadPathingBlockerAirLarge(db), DestructableType.MassiveRuinedGate_ZTsg => LoadMassiveRuinedGate_ZTsg(db), DestructableType.MassiveRuinedGate_ZTsx => LoadMassiveRuinedGate_ZTsx(db), DestructableType.FootSwitch_DTfp => LoadFootSwitch_DTfp(db), DestructableType.FootSwitch_DTfx => LoadFootSwitch_DTfx(db), DestructableType.Lever => LoadLever(db), DestructableType.CityEntrance_YTce => LoadCityEntrance_YTce(db), DestructableType.CityEntrance_YTcx => LoadCityEntrance_YTcx(db), DestructableType.LastHopeBridge_LTtc => LoadLastHopeBridge_LTtc(db), DestructableType.LastHopeBridge_LTtx => LoadLastHopeBridge_LTtx(db), DestructableType.CityscapeRuinedTreeWall => LoadCityscapeRuinedTreeWall(db), DestructableType.DalaranRuinsTreeWall => LoadDalaranRuinsTreeWall(db), DestructableType.FrozenThroneGate => LoadFrozenThroneGate(db), DestructableType.UndergroundTreeWall => LoadUndergroundTreeWall(db), DestructableType.ResurrectionStone_BTrs => LoadResurrectionStone_BTrs(db), DestructableType.ResurrectionStone_BTrx => LoadResurrectionStone_BTrx(db), DestructableType.ShimmeringPortal => LoadShimmeringPortal(db), DestructableType.InvisiblePlatform => LoadInvisiblePlatform(db), DestructableType.InvisiblePlatformSmall => LoadInvisiblePlatformSmall(db), DestructableType.BarrensCanopyTree => LoadBarrensCanopyTree(db), DestructableType.FelwoodCanopyTree => LoadFelwoodCanopyTree(db), DestructableType.NorthrendCanopyTree => LoadNorthrendCanopyTree(db), DestructableType.RuinsCanopyTree => LoadRuinsCanopyTree(db), DestructableType.IcecrownCanopyTree => LoadIcecrownCanopyTree(db), DestructableType.IcecrownThrone => LoadIcecrownThrone(db), DestructableType.IcecrownThroneDiagonal1_IOt1 => LoadIcecrownThroneDiagonal1_IOt1(db), DestructableType.IcecrownThroneDiagonal1_IOt2 => LoadIcecrownThroneDiagonal1_IOt2(db), DestructableType.RockChunks_LTrc => LoadRockChunks_LTrc(db), DestructableType.RockChunks_LTrt => LoadRockChunks_LTrt(db), DestructableType.ExtraWideNaturalBridge_YT48 => LoadExtraWideNaturalBridge_YT48(db), DestructableType.ExtraWideNaturalBridge_YT49 => LoadExtraWideNaturalBridge_YT49(db), DestructableType.ExtraWideNaturalBridge_YT50 => LoadExtraWideNaturalBridge_YT50(db), DestructableType.ExtraWideNaturalBridge_YT51 => LoadExtraWideNaturalBridge_YT51(db), DestructableType.DemonStorm => LoadDemonStorm(db), DestructableType.RockinArthas => LoadRockinArthas(db), DestructableType.SupportColumn => LoadSupportColumn(db), DestructableType.StoneRamp_LTs1 => LoadStoneRamp_LTs1(db), DestructableType.StoneRamp_LTs2 => LoadStoneRamp_LTs2(db), DestructableType.StoneRamp_LTs3 => LoadStoneRamp_LTs3(db), DestructableType.StoneRamp_LTs4 => LoadStoneRamp_LTs4(db), DestructableType.StoneRamp_LTs5 => LoadStoneRamp_LTs5(db), DestructableType.StoneRamp_LTs6 => LoadStoneRamp_LTs6(db), DestructableType.StoneRamp_LTs7 => LoadStoneRamp_LTs7(db), DestructableType.StoneRamp_LTs8 => LoadStoneRamp_LTs8(db), DestructableType.Volcano => LoadVolcano(db), DestructableType.SilvermoonTree => LoadSilvermoonTree(db), DestructableType.IcecrownCitadelEntrance => LoadIcecrownCitadelEntrance(db), DestructableType.LordaeronCityMainGate => LoadLordaeronCityMainGate(db), DestructableType.LordaeronCityMainGateColumn => LoadLordaeronCityMainGateColumn(db), DestructableType.LordaeronCityMainGateDestroyed => LoadLordaeronCityMainGateDestroyed(db), DestructableType.LordaeronCityMainGateColumnDestroyed => LoadLordaeronCityMainGateColumnDestroyed(db), DestructableType.LionStatue => LoadLionStatue(db), DestructableType.LionStatueDestroyed => LoadLionStatueDestroyed(db), DestructableType.LordaeronCitySpire => LoadLordaeronCitySpire(db), DestructableType.LordaeronCitySpireDestroyed => LoadLordaeronCitySpireDestroyed(db), DestructableType.LordaeronCityDome => LoadLordaeronCityDome(db), DestructableType.LordaeronCityDomeDestroyed => LoadLordaeronCityDomeDestroyed(db), DestructableType.LordaeronCityMainBuilding => LoadLordaeronCityMainBuilding(db), DestructableType.LordaeronCityMainBuildingDestroyed => LoadLordaeronCityMainBuildingDestroyed(db), DestructableType.OrgrimmarWallSegmentUnderConstruction => LoadOrgrimmarWallSegmentUnderConstruction(db), DestructableType.OrgrimmarWallSegmentCompleted => LoadOrgrimmarWallSegmentCompleted(db), DestructableType.OrgrimmarTowerUnderConstruction => LoadOrgrimmarTowerUnderConstruction(db), DestructableType.OrgrimmarTowerCompleted => LoadOrgrimmarTowerCompleted(db), DestructableType.OrgrimmarGate => LoadOrgrimmarGate(db), DestructableType.SpecialIceBridge => LoadSpecialIceBridge(db), DestructableType.ElvenBridge => LoadElvenBridge(db), DestructableType.ShortStratholmeBridge_YY12 => LoadShortStratholmeBridge_YY12(db), DestructableType.ShortStratholmeBridge_YY13 => LoadShortStratholmeBridge_YY13(db), DestructableType.ShortStratholmeBridge_YY14 => LoadShortStratholmeBridge_YY14(db), DestructableType.ShortStratholmeBridge_YY15 => LoadShortStratholmeBridge_YY15(db), DestructableType.LongStratholmeBridge_YY16 => LoadLongStratholmeBridge_YY16(db), DestructableType.LongStratholmeBridge_YY17 => LoadLongStratholmeBridge_YY17(db), DestructableType.LongStratholmeBridge_YY18 => LoadLongStratholmeBridge_YY18(db), DestructableType.LongStratholmeBridge_YY19 => LoadLongStratholmeBridge_YY19(db), DestructableType.WideStratholmeBridge_YY20 => LoadWideStratholmeBridge_YY20(db), DestructableType.WideStratholmeBridge_YY21 => LoadWideStratholmeBridge_YY21(db), DestructableType.WideStratholmeBridge_YY22 => LoadWideStratholmeBridge_YY22(db), DestructableType.WideStratholmeBridge_YY23 => LoadWideStratholmeBridge_YY23(db), DestructableType.ShortOvergrownBridge_OG00 => LoadShortOvergrownBridge_OG00(db), DestructableType.ShortOvergrownBridge_OG01 => LoadShortOvergrownBridge_OG01(db), DestructableType.ShortOvergrownBridge_OG02 => LoadShortOvergrownBridge_OG02(db), DestructableType.ShortOvergrownBridge_OG03 => LoadShortOvergrownBridge_OG03(db), DestructableType.LongOvergrownBridge_OG04 => LoadLongOvergrownBridge_OG04(db), DestructableType.LongOvergrownBridge_OG05 => LoadLongOvergrownBridge_OG05(db), DestructableType.LongOvergrownBridge_OG06 => LoadLongOvergrownBridge_OG06(db), DestructableType.LongOvergrownBridge_OG07 => LoadLongOvergrownBridge_OG07(db), DestructableType.WideOvergrownBridge_OG08 => LoadWideOvergrownBridge_OG08(db), DestructableType.WideOvergrownBridge_OG09 => LoadWideOvergrownBridge_OG09(db), DestructableType.WideOvergrownBridge_OG10 => LoadWideOvergrownBridge_OG10(db), DestructableType.WideOvergrownBridge_OG11 => LoadWideOvergrownBridge_OG11(db), DestructableType.ShortRicketyWoodenBridge_RW00 => LoadShortRicketyWoodenBridge_RW00(db), DestructableType.ShortRicketyWoodenBridge_RW01 => LoadShortRicketyWoodenBridge_RW01(db), DestructableType.ShortRicketyWoodenBridge_RW02 => LoadShortRicketyWoodenBridge_RW02(db), DestructableType.ShortRicketyWoodenBridge_RW03 => LoadShortRicketyWoodenBridge_RW03(db), DestructableType.LongRicketyWoodenBridge_RW04 => LoadLongRicketyWoodenBridge_RW04(db), DestructableType.LongRicketyWoodenBridge_RW05 => LoadLongRicketyWoodenBridge_RW05(db), DestructableType.LongRicketyWoodenBridge_RW06 => LoadLongRicketyWoodenBridge_RW06(db), DestructableType.LongRicketyWoodenBridge_RW07 => LoadLongRicketyWoodenBridge_RW07(db), DestructableType.WideRicketyWoodenBridge_RW08 => LoadWideRicketyWoodenBridge_RW08(db), DestructableType.WideRicketyWoodenBridge_RW09 => LoadWideRicketyWoodenBridge_RW09(db), DestructableType.WideRicketyWoodenBridge_RW10 => LoadWideRicketyWoodenBridge_RW10(db), DestructableType.WideRicketyWoodenBridge_RW11 => LoadWideRicketyWoodenBridge_RW11(db), DestructableType.ShortElvenBridge_EB00 => LoadShortElvenBridge_EB00(db), DestructableType.ShortElvenBridge_EB01 => LoadShortElvenBridge_EB01(db), DestructableType.ShortElvenBridge_EB02 => LoadShortElvenBridge_EB02(db), DestructableType.ShortElvenBridge_EB03 => LoadShortElvenBridge_EB03(db), DestructableType.LongElvenBridge_EB04 => LoadLongElvenBridge_EB04(db), DestructableType.LongElvenBridge_EB05 => LoadLongElvenBridge_EB05(db), DestructableType.LongElvenBridge_EB06 => LoadLongElvenBridge_EB06(db), DestructableType.LongElvenBridge_EB07 => LoadLongElvenBridge_EB07(db), DestructableType.WideElvenBridge_EB08 => LoadWideElvenBridge_EB08(db), DestructableType.WideElvenBridge_EB09 => LoadWideElvenBridge_EB09(db), DestructableType.WideElvenBridge_EB10 => LoadWideElvenBridge_EB10(db), DestructableType.WideElvenBridge_EB11 => LoadWideElvenBridge_EB11(db), DestructableType.ShortNightElvenWoodenBridge_NB00 => LoadShortNightElvenWoodenBridge_NB00(db), DestructableType.ShortNightElvenWoodenBridge_NB01 => LoadShortNightElvenWoodenBridge_NB01(db), DestructableType.ShortNightElvenWoodenBridge_NB02 => LoadShortNightElvenWoodenBridge_NB02(db), DestructableType.ShortNightElvenWoodenBridge_NB03 => LoadShortNightElvenWoodenBridge_NB03(db), DestructableType.LongNightElvenWoodenBridge_NB04 => LoadLongNightElvenWoodenBridge_NB04(db), DestructableType.LongNightElvenWoodenBridge_NB05 => LoadLongNightElvenWoodenBridge_NB05(db), DestructableType.LongNightElvenWoodenBridge_NB06 => LoadLongNightElvenWoodenBridge_NB06(db), DestructableType.LongNightElvenWoodenBridge_NB07 => LoadLongNightElvenWoodenBridge_NB07(db), DestructableType.WideNightElvenWoodenBridge_NB08 => LoadWideNightElvenWoodenBridge_NB08(db), DestructableType.WideNightElvenWoodenBridge_NB09 => LoadWideNightElvenWoodenBridge_NB09(db), DestructableType.WideNightElvenWoodenBridge_NB10 => LoadWideNightElvenWoodenBridge_NB10(db), DestructableType.WideNightElvenWoodenBridge_NB11 => LoadWideNightElvenWoodenBridge_NB11(db), DestructableType.ScorchedTreeWall => LoadScorchedTreeWall(db), DestructableType.RollingStoneDoor_ITd1 => LoadRollingStoneDoor_ITd1(db), DestructableType.RollingStoneDoor_ITd2 => LoadRollingStoneDoor_ITd2(db), DestructableType.RollingStoneDoor_ITd3 => LoadRollingStoneDoor_ITd3(db), DestructableType.RollingStoneDoor_ITd4 => LoadRollingStoneDoor_ITd4(db), DestructableType.WaygateRamp => LoadWaygateRamp(db), DestructableType.NorthrendIcyTreeWall => LoadNorthrendIcyTreeWall(db), _ => throw new System.ComponentModel.InvalidEnumArgumentException(nameof(destructableType), (int)destructableType, typeof(DestructableType))}

            ;
        }
    }
}