﻿using System.Collections.Generic;
using MacroTools.Wrappers;
using static War3Api.Common;

namespace MacroTools.DialogueSystem
{
  /// <summary>
  /// Can play a piece of dialogue from the Warcraft 3 campaign.
  /// </summary>
  public sealed class Dialogue : IHasPlayableDialogue
  {
    private readonly string _caption;
    private readonly string _speaker;
    
    /// <summary>
    /// The <see cref="SoundWrapper"/> played by this <see cref="Dialogue"/>.
    /// </summary>
    public SoundWrapper Sound { get; }
    
    /// <summary>
    /// Initializes a new instance of the <see cref="Dialogue"/> class.
    /// </summary>
    /// <param name="soundFile">A path to the sound file which the dialogue will play.</param>
    /// <param name="caption">Gets displayed to the user when the dialogue is played.</param>
    /// <param name="speaker">The character that is saying the dialogue.</param>
    public Dialogue(string soundFile, string caption, string speaker)
    {
      _caption = caption;
      _speaker = speaker;
      Sound = new SoundWrapper(soundFile, soundEax: SoundEax.HeroAcks);
    }

    /// <summary>
    /// Plays the <see cref="Dialogue"/> to eligible audience members.
    /// </summary>
    public void Play(List<player>? players)
    {
      if (players != null)
      {
        Sound.Play(players.Contains, true);
        foreach (var player in players) 
          DisplayTextToPlayer(player, 0, 0, $"|cffffcc00{_speaker}:|r {_caption}");
      }
      else
      {
        DisplayTextToPlayer(GetLocalPlayer(), 0, 0, $"|cffffcc00{_speaker}:|r {_caption}");
        Sound.Play(true);
      }
    }
  }
}