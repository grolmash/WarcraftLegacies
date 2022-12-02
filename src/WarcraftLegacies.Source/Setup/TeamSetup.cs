using MacroTools.FactionSystem;

namespace WarcraftLegacies.Source.Setup
{
  /// <summary>
  /// Responsible for setting up and storing all <see cref="Team"/>s..
  /// </summary>
  public sealed class TeamSetup
  {
    /// <summary>
    /// Big evil dudes.
    /// </summary>
    public Team Legion { get; }
    
    /// <summary>
    /// An alliance of mortals.
    /// </summary>
    public Team Alliance { get; }
    
    /// <summary>
    /// Orcs and other misfits.
    /// </summary>
    public Team Horde { get; }
    
    /// <summary>
    /// Immortal forest dwellers.
    /// </summary>
    public Team NightElves { get; }
    
    /// <summary>
    /// Human zealots that hate undead.
    /// </summary>
    public Team ScarletCrusade { get; }
    
    /// <summary>
    /// Undead that freed themselves from the Lich King.
    /// </summary>
    public Team Forsaken { get; }
    
    /// <summary>
    /// The Lich King and followers.
    /// </summary>
    public Team Scourge { get; }
    
    /// <summary>
    /// Illidan and his followers.
    /// </summary>
    public Team Illidari { get; }
    
    /// <summary>
    /// Reality-manipulating evil gods.
    /// </summary>
    public Team OldGods { get; }
    
    /// <summary>
    /// The good guys in north Eastern Kingdoms.
    /// </summary>
    public Team NorthAlliance { get; }
    
    /// <summary>
    /// The good guys in south Eastern Kingdoms.
    /// </summary>
    public Team SouthAlliance { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="TeamSetup"/> class.
    /// </summary>
    public TeamSetup()
    {
      Alliance = new Team("Alliance")
      {
        VictoryMusic = "HeroicVictory"
      };
      FactionManager.Register(Alliance);

      Legion = new Team("Burning Legion")
      {
        VictoryMusic = "DarkVictory"
      };
      FactionManager.Register(Legion);

      Horde = new Team("Horde")
      {
        VictoryMusic = "DarkVictory"
      };
      FactionManager.Register(Horde);

      NightElves = new Team("Night Elves")
      {
        VictoryMusic = "HeroicVictory"
      };
      FactionManager.Register(NightElves);

      ScarletCrusade = new Team("Scarlet Crusade")
      {
        VictoryMusic = "DarkVictory"
      };
      FactionManager.Register(ScarletCrusade);

      Forsaken = new Team("Forsaken")
      {
        VictoryMusic = "DarkVictory"
      };
      FactionManager.Register(Forsaken);

      Scourge = new Team("Northrend")
      {
        VictoryMusic = "DarkVictory"
      };
      FactionManager.Register(Scourge);
    }
  }
}