﻿using MacroTools;
using MacroTools.ArtifactSystem;
using WCSharp.Shared.Data;
using static War3Api.Common;

namespace WarcraftLegacies.Source.Setup
{
  /// <summary>
  /// Responsible for setting up and storing all <see cref="Artifact"/>s.
  /// </summary>
  public sealed class ArtifactSetup
  {
    private const float DummyX = 20195;
    private const float DummyY = 24177;

    /// <summary>
    /// The Crown of Stormwind.
    /// </summary>
    public Artifact CrownOfStormwind { get; }

    /// <summary>
    /// The Skull of Guldan.
    /// </summary>
    public Artifact SkullOfGuldan { get; }
    
    /// <summary>
    /// The Crown of Lordaeron.
    /// </summary>
    public Artifact CrownOfLordaeron { get; }
    
    /// <summary>
    /// The Helm of Domination worn by the Lich King.
    /// </summary>
    public Artifact HelmOfDomination { get; }
    
    /// <summary>
    /// Azshara's Scepter.
    /// </summary>
    public Artifact ScepterOfTheQueen { get; }
    
    /// <summary>
    /// Powerful tome left behind by the Guardian Medivh.
    /// </summary>
    public Artifact BookOfMedivh { get; }
    
    /// <summary>
    /// Horn that can be used to call a bunch of wisps.
    /// </summary>
    public Artifact HornOfCenarius { get; }
    
    /// <summary>
    /// A remnant of the Titan Sargeras.
    /// </summary>
    public Artifact EyeOfSargeras { get; }

    /// <summary>
    /// Destroyer of Worlds.
    /// </summary>
    public Artifact ZinRokh { get; }
    
    /// <summary>
    /// Scythe tied to the origin of the Worgen.
    /// </summary>
    public Artifact ScytheOfElune { get; }
    
    /// <summary>
    /// A fragment of Zin'rokh.
    /// </summary>
    public Artifact AzureFragment { get; }
    
    /// <summary>
    /// A fragment of Zin'rokh.
    /// </summary>
    public Artifact EmeraldFragment { get; }
    
    /// <summary>
    /// A fragment of Zin'rokh.
    /// </summary>
    public Artifact RubyFragment { get; }
    
    /// <summary>
    /// A fragment of Zin'rokh.
    /// </summary>
    public Artifact ObsidianFragment { get; }
    
    /// <summary>
    /// A fragment of Zin'rokh.
    /// </summary>
    public Artifact BronzeFragment { get; }
    
    /// <summary>
    /// Sets up <see cref="ArtifactSetup"/>.
    /// </summary>
    public ArtifactSetup(PreplacedUnitSystem preplacedUnitSystem)
    {
      CrownOfStormwind = new Artifact(CreateItem(FourCC("I002"), DummyX, DummyY));
      UnitAddItem(preplacedUnitSystem.GetUnit(FourCC("n021")), CrownOfStormwind.Item); //Hogger
      ArtifactManager.Register(CrownOfStormwind);

      EyeOfSargeras = new Artifact(CreateItem(Constants.ITEM_I003_EYE_OF_SARGERAS, -77.9f, 10910.4f));
      ArtifactManager.Register(EyeOfSargeras);

      HelmOfDomination = new Artifact(CreateItem(FourCC("I01Y"), DummyX, DummyY)); //Helm of Domination
      UnitAddAbility(preplacedUnitSystem.GetUnit(FourCC("u000_0649")), Artifact.ArtifactHolderAbilId); //Frozen Throne
      UnitAddItem(preplacedUnitSystem.GetUnit(FourCC("u000")), HelmOfDomination.Item);
      ArtifactManager.Register(HelmOfDomination);

      CrownOfLordaeron = new Artifact(CreateItem(FourCC("I001"), DummyX, DummyY)); //Crown of Lordaeron
      UnitAddAbility(preplacedUnitSystem.GetUnit(FourCC("nemi_0019")), Artifact.ArtifactHolderAbilId); //King Terenas
      UnitAddItem(preplacedUnitSystem.GetUnit(FourCC("nemi")), CrownOfLordaeron.Item);
      ArtifactManager.Register(CrownOfLordaeron);

      var tempArtifact = new Artifact(CreateItem(FourCC("klmm"), DummyX, DummyY)); //Killmaim
      UnitAddAbility(preplacedUnitSystem.GetUnit(FourCC("H00E_1728")),
        Artifact.ArtifactHolderAbilId); //Ramzes the Horror
      UnitAddItem(preplacedUnitSystem.GetUnit(FourCC("H00E")), tempArtifact.Item);
      ArtifactManager.Register(tempArtifact);

      ScepterOfTheQueen = new Artifact(CreateItem(FourCC("I00I"), DummyX, DummyY));
      UnitAddAbility(preplacedUnitSystem.GetUnit(FourCC("n085_2846")), Artifact.ArtifactHolderAbilId); //The Atheneum
      UnitAddItem(preplacedUnitSystem.GetUnit(FourCC("n085")), ScepterOfTheQueen.Item);
      ArtifactManager.Register(ScepterOfTheQueen);

      BookOfMedivh = new Artifact(CreateItem(Constants.ITEM_I006_BOOK_OF_MEDIVH, DummyX, DummyY));
      UnitAddAbility(preplacedUnitSystem.GetUnit(Constants.UNIT_NBSM_BOOK_OF_MEDIVH), Artifact.ArtifactHolderAbilId);
      UnitAddItem(preplacedUnitSystem.GetUnit(Constants.UNIT_NBSM_BOOK_OF_MEDIVH), BookOfMedivh.Item);
      ArtifactManager.Register(BookOfMedivh);

      SkullOfGuldan = new Artifact(CreateItem(FourCC("I007"), DummyX, DummyY)); //Skull of Guldan
      UnitAddAbility(preplacedUnitSystem.GetUnit(FourCC("n0DK")),
        Artifact.ArtifactHolderAbilId); //Skull Pedestal
      UnitAddItem(preplacedUnitSystem.GetUnit(FourCC("n0DK")), SkullOfGuldan.Item);
      ArtifactManager.Register(SkullOfGuldan);

      ZinRokh = new Artifact(CreateItem(FourCC("I016"), DummyX, DummyY))
      {
        TitanforgedAbility = Constants.ABILITY_A0VM_TITANFORGED_9_STRENGTH
      };

      BronzeFragment = new Artifact(CreateItem(Constants.ITEM_I01M_BRONZE_FRAGMENT, DummyX, DummyY));
      UnitAddAbility(preplacedUnitSystem.GetUnit(Constants.UNIT_O024_CHIEFTAN_OF_THE_SANDFURY_TRIBE_CREEP_ZUL_FARRAK),
        Artifact.ArtifactHolderAbilId);
      UnitAddItem(preplacedUnitSystem.GetUnit(Constants.UNIT_O024_CHIEFTAN_OF_THE_SANDFURY_TRIBE_CREEP_ZUL_FARRAK),
        BronzeFragment.Item);
      ArtifactManager.Register(BronzeFragment);

      ObsidianFragment = new Artifact(CreateItem(Constants.ITEM_I01L_OBSIDIAN_FRAGMENT, DummyX, DummyY));
      UnitAddItem(preplacedUnitSystem.GetUnit(Constants.UNIT_O04E_BONESEER_TROLL), ObsidianFragment.Item);
      ArtifactManager.Register(ObsidianFragment);

      RubyFragment = new Artifact(CreateItem(Constants.ITEM_I01J_RUBY_FRAGMENT, DummyX, DummyY));
      UnitAddAbility(
        preplacedUnitSystem.GetUnit(Constants.UNIT_O023_WITCH_DOCTOR_OF_THE_GURUBIAN_TRIBE_CREEP_ZUL_GURUB),
        Artifact.ArtifactHolderAbilId); //Jin)do
      UnitAddItem(preplacedUnitSystem.GetUnit(Constants.UNIT_O023_WITCH_DOCTOR_OF_THE_GURUBIAN_TRIBE_CREEP_ZUL_GURUB),
        RubyFragment.Item);
      ArtifactManager.Register(RubyFragment);

      AzureFragment = new Artifact(CreateItem(Constants.ITEM_I01I_AZURE_FRAGMENT, DummyX, DummyY));
      UnitAddAbility(preplacedUnitSystem.GetUnit(Constants.UNIT_O02C_HIGH_PROPHET_OF_AKALI_CREEP_ZUL_DRAK),
        Artifact.ArtifactHolderAbilId);
      UnitAddItem(preplacedUnitSystem.GetUnit(Constants.UNIT_O02C_HIGH_PROPHET_OF_AKALI_CREEP_ZUL_DRAK),
        AzureFragment.Item);
      ArtifactManager.Register(AzureFragment);

      EmeraldFragment = new Artifact(CreateItem(Constants.ITEM_I01K_EMERALD_FRAGMENT, DummyX, DummyY));
      UnitAddItem(preplacedUnitSystem.GetUnit(Constants.UNIT_O00O_CHIEFTAN_OF_THE_AMANI_TRIBE_CREEP_ZUL_AMAN),
        EmeraldFragment.Item);
      ArtifactManager.Register(EmeraldFragment);

      tempArtifact = new Artifact(CreateItem(FourCC("arsh"), DummyX, DummyY)); //Shroud of Nozdormuru
      UnitAddAbility(preplacedUnitSystem.GetUnit(FourCC("O025_3426")), Artifact.ArtifactHolderAbilId); //Occulus
      UnitAddItem(preplacedUnitSystem.GetUnit(FourCC("O025")), tempArtifact.Item);
      ArtifactManager.Register(tempArtifact);

      HornOfCenarius = new Artifact(CreateItem(FourCC("cnhn"), DummyX, DummyY));
      UnitAddAbility(preplacedUnitSystem.GetUnit(FourCC("nhcn_2597")),
        Artifact.ArtifactHolderAbilId); //Horn of Cenarius Pedestal
      UnitAddItem(preplacedUnitSystem.GetUnit(FourCC("nhcn")), HornOfCenarius.Item);
      ArtifactManager.Register(HornOfCenarius);

      tempArtifact = new Artifact(CreateItem(FourCC("kgal"), DummyX, DummyY)); //Keg of Thunderwater
      UnitAddItem(preplacedUnitSystem.GetUnit(FourCC("hmtm"), new Point(15109, -895)), tempArtifact.Item);
      ArtifactManager.Register(tempArtifact);

      tempArtifact = new Artifact(CreateItem(FourCC("I00K"), DummyX, DummyY)); //Essence
      UnitAddItem(preplacedUnitSystem.GetUnit(FourCC("n03T")), tempArtifact.Item); //Murmur
      ArtifactManager.Register(tempArtifact);

      ScytheOfElune = new Artifact(CreateItem(Constants.ITEM_I00R_SCYTHE_OF_ELUNE, DummyX, DummyX));
      var worgenBloodShamanHero = preplacedUnitSystem.GetUnit(Constants.UNIT_O038_WORGEN_BLOOD_SHAMAN_WORGEN_HERO,
        new Point(5410.7f, 2499.0f));
      UnitAddAbility(worgenBloodShamanHero, Artifact.ArtifactHolderAbilId);
      UnitAddItem(worgenBloodShamanHero, ScytheOfElune.Item);
      ArtifactManager.Register(ScytheOfElune);
    }
  }
}