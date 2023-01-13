using System;
using System.Collections.Generic;
using MacroTools.Extensions;
using MacroTools.FactionSystem;
using MacroTools.ObjectiveSystem;
using MacroTools.ObjectiveSystem.Objectives;
using static War3Api.Common;

namespace MacroTools.QuestSystem
{
  /// <summary>
  /// A highly implementation of Warcraft 3 quests which supports <see cref="Objective"/>s, rewards, and penalties.
  /// </summary>
  public abstract class QuestData
  {
    private readonly List<Objective> _objectives = new();

    private QuestProgress _progress = QuestProgress.Incomplete;

    /// <summary>
    /// Initializes a new instance of the <see cref="QuestData"/> class.
    /// </summary>
    /// <param name="title">A user-friendly name for the quest.</param>
    /// <param name="desc">A user-friendly description for the quest.</param>
    /// <param name="icon">A path to an icon.</param>
    protected QuestData(string title, string desc, string icon)
    {
      Quest = CreateQuest();
      Flavour = desc;
      Title = title;
      QuestSetTitle(Quest, title);
      QuestSetIconPath(Quest, icon);
      QuestSetEnabled(Quest, false);
      Required = false;
    }

    /// <summary>
    ///   If true, the quest appears on the left hand side of the F9 menu.
    ///   If false, it appears on the right hand side.
    /// </summary>
    protected bool Required
    {
      set => QuestSetRequired(Quest, value);
    }

    /// <summary>
    /// A user-friendly name for the quest.
    /// </summary>
    public string Title { get; }

    /// <summary>
    ///   If true, completing this quest will broadcast a message to every player.
    /// </summary>
    protected bool Global { get; init; }

    /// <summary>
    ///   Describes to the player what will happen when the quest is completed.
    ///   Describes mechanics, not flavour.
    /// </summary>
    protected virtual string RewardDescription => "";

    /// <summary>
    ///   Describes to the player what will happen when the quest is failed.
    ///   Describes mechanics, not flavour.
    /// </summary>
    protected virtual string PenaltyDescription => "";

    /// <summary>
    ///   Displayed to the player when the quest is completed.
    ///   Describes flavour, not mechanics.
    /// </summary>
    protected abstract string RewardFlavour { get; }

    /// <summary>
    ///   Displayed to the player when the quest is failed.
    ///   Describes flavour, not mechanics.
    /// </summary>
    protected virtual string PenaltyFlavour => string.Empty;

    /// <summary>
    ///   Describes the background and flavour of this quest.
    ///   Describes flavour, not mechanics.
    /// </summary>
    private string Flavour { get; }

    /// <summary>
    ///   The research given to the faction when it completes its quest.
    /// </summary>
    public int ResearchId { get; protected init; }

    private quest Quest { get; }

    /// <summary>
    /// Determines the current progression level of the <see cref="QuestData"/>.
    /// </summary>
    public QuestProgress Progress
    {
      get => _progress;
      set
      {
        try
        {
          var formerProgress = _progress;
          _progress = value;
          ProgressChanged?.Invoke(this, new QuestProgressChangedEventArgs(this, formerProgress));
        }
        catch (Exception ex)
        {
          Console.WriteLine(ex);
        }
      }
    }

    private void RefreshDescription()
    {
      QuestSetDescription(Quest,
        !string.IsNullOrEmpty(PenaltyDescription)
          ? $"{Flavour}\n|cffffcc00On completion:|r {RewardDescription}\n|cffffcc00On failure:|r {PenaltyDescription}"
          : $"{Flavour}\n|cffffcc00On completion:|r {RewardDescription}");
    }

    private void Complete(Faction whichFaction)
    {
      QuestSetCompleted(Quest, true);
      QuestSetFailed(Quest, false);
      QuestSetDiscovered(Quest, true);
      DisplayCompleted(whichFaction);
      if (Global) DisplayCompletedGlobal(whichFaction.Player);
      
      if (ResearchId != 0) SetPlayerTechResearched(whichFaction.Player, ResearchId, 1);
      
      foreach (var objective in _objectives)
      {
        objective.ProgressLocked = true;
      }
      OnComplete(whichFaction);
    }

    private void Fail(Faction whichFaction)
    {
      QuestSetCompleted(Quest, false);
      QuestSetFailed(Quest, true);
      QuestSetDiscovered(Quest, true);
      DisplayFailed(whichFaction);
      foreach (var objective in _objectives) 
        objective.ProgressLocked = true;
      OnFail(whichFaction);
    }

    /// <summary>
    ///   Register a <see cref="Faction" /> as being able to complete this <see cref="QuestData" />.
    /// </summary>
    internal void Add(Faction faction)
    {
      if (ResearchId != 0)
        faction.ModObjectLimit(ResearchId, 1);
      OnAdd(faction);
      foreach (var questItem in _objectives)
      {
        questItem.AddEligibleFaction(faction);
        questItem.OnAdd(faction);
      }

      RefreshDescription();
    }

    internal void ApplyFactionProgress(Faction whichFaction, QuestProgress progress, QuestProgress formerProgress)
    {
      switch (progress)
      {
        case QuestProgress.Complete:
          Complete(whichFaction);
          break;
        case QuestProgress.Failed:
          Fail(whichFaction);
          break;
        case QuestProgress.Incomplete:
        {
          if (formerProgress == QuestProgress.Undiscovered)
            DisplayDiscovered(whichFaction);

          QuestSetCompleted(Quest, false);
          QuestSetFailed(Quest, false);
          QuestSetDiscovered(Quest, true);
          break;
        }
        case QuestProgress.Undiscovered:
          QuestSetCompleted(Quest, false);
          QuestSetFailed(Quest, false);
          QuestSetDiscovered(Quest, false);
          break;
        default:
          throw new ArgumentOutOfRangeException(nameof(progress), progress, null);
      }

      //If the quest is incomplete, show its markers. Otherwise, hide them.
      if (Progress != QuestProgress.Incomplete)
        foreach (var questItem in _objectives)
        {
          if (GetLocalPlayer() == whichFaction.Player)
            questItem.HideLocal();

          questItem.HideSync();
        }
      else
        foreach (var questItem in _objectives)
        {
          if (GetLocalPlayer() == whichFaction.Player)
            questItem.ShowLocal(Progress);

          questItem.ShowSync(Progress);
        }
    }

    /// <summary>
    ///   Fired when the <see cref="QuestData" /> changes its progress.
    /// </summary>
    public event EventHandler<QuestProgressChangedEventArgs>? ProgressChanged;

    /// <summary>
    ///   Fired when the Quest is completed.
    /// </summary>
    protected virtual void OnComplete(Faction whichFaction)
    {
    }

    /// <summary>
    ///   Fired when the Quest is failed.
    /// </summary>
    protected virtual void OnFail(Faction whichFaction)
    {
    }

    /// <summary>
    ///   Fired when the <see cref="QuestData" /> is added to a <see cref="Faction" />.
    /// </summary>
    protected virtual void OnAdd(Faction whichFaction)
    {
    }

    /// <summary>
    ///   Enables the local aspects of all child QuestItems.
    /// </summary>
    internal void ShowLocal()
    {
      QuestSetEnabled(Quest, true);
      foreach (var questItem in _objectives) questItem.ShowLocal(Progress);
    }

    /// <summary>
    ///   Enables the synchronous aspects of all child QuestItems.
    /// </summary>
    internal void ShowSync()
    {
      foreach (var questItem in _objectives) questItem.ShowSync(Progress);
    }

    /// <summary>
    ///   Disables the local aspects of all child QuestItems.
    /// </summary>
    internal void HideLocal()
    {
      QuestSetEnabled(Quest, false);
      foreach (var questItem in _objectives) questItem.HideLocal();
    }

    /// <summary>
    ///   Disables the synchronous aspects of all child QuestItems.
    /// </summary>
    internal void HideSync()
    {
      foreach (var questItem in _objectives) questItem.HideSync();
    }

    /// <summary>
    ///   Displays a warning message to everyone except the player that completed the <see cref="QuestData" />.
    /// </summary>
    private void DisplayCompletedGlobal(player whichPlayer)
    {
      var soundCompleted = SoundLibrary.Completed;
      var soundFailed = SoundLibrary.Failed;
      StartSound(GetLocalPlayer().GetTeam()?.Contains(whichPlayer) == true
        ? soundCompleted
        : soundFailed);
      
      foreach (var enumPlayer in WCSharp.Shared.Util.EnumeratePlayers())
        if (enumPlayer != whichPlayer)
          DisplayTextToPlayer(enumPlayer, 0, 0,
            $"\n|cffffcc00MAJOR EVENT - {whichPlayer.GetFaction()?.PrefixCol}{Title}|r\n{RewardFlavour}\n");
    }

    private void DisplayFailed(Faction faction)
    {
      var display = !string.IsNullOrEmpty(PenaltyFlavour)
        ? $"\n|cffffcc00QUEST FAILED - {Title}|r\n{PenaltyFlavour}\n"
        : $"\n|cffffcc00QUEST FAILED - {Title}|r\n{Flavour}\n";

      foreach (var questItem in _objectives)
        if (questItem.ShowsInQuestLog)
          display = questItem.Progress switch
          {
            QuestProgress.Complete => $"{display} - |cff808080{questItem.Description} (Completed)|r\n",
            QuestProgress.Failed => $"{display} - |cffCD5C5C{questItem.Description} (Failed)|r\n",
            _ => $"{display} - {questItem.Description}\n"
          };

      DisplayTextToPlayer(faction.Player, 0, 0, display);
      var sound = SoundLibrary.Failed;
      if (GetLocalPlayer() == faction.Player)
        StartSound(sound);
    }

    private void DisplayCompleted(Faction faction)
    {
      var display = $"\n|cffffcc00QUEST COMPLETED - {Title}|r\n{RewardFlavour}\n";
      foreach (var questItem in _objectives)
        if (questItem.ShowsInQuestLog)
          display = $"{display} - |cff808080{questItem.Description} (Completed)|r\n";
      DisplayTextToPlayer(faction.Player, 0, 0, display);
      var sound = SoundLibrary.Completed;
      if (GetLocalPlayer() == faction.Player) 
        StartSound(sound);
    }

    /// <summary>
    /// Indicates to the provided question that the quest has been discovered.
    /// </summary>
    /// <param name="faction"></param>
    public void DisplayDiscovered(Faction faction)
    {
      var display = $"\n|cffffcc00QUEST DISCOVERED - {Title}|r\n{Flavour}\n";
      foreach (var questItem in _objectives)
        if (questItem.ShowsInQuestLog)
        {
          display = questItem.Progress == QuestProgress.Complete
            ? $"{display} - |cff808080{questItem.Description} (Completed)|r\n"
            : $"{display} - {questItem.Description}\n";
        }
      DisplayTextToPlayer(faction.Player, 0, 0, display);
      var sound = SoundLibrary.Discovered;
      if (GetLocalPlayer() == faction.Player) 
        StartSound(sound);
    }

    private void OnQuestItemProgressChanged(object? sender, Objective changedObjective)
    {
      var allComplete = true;
      var anyFailed = false;
      var anyUndiscovered = false;

      foreach (var objective in _objectives)
      {
        if (objective.Progress != QuestProgress.Complete)
        {
          allComplete = false;
          if (objective.Progress == QuestProgress.Failed)
            anyFailed = true;
          else if (objective.Progress == QuestProgress.Undiscovered) anyUndiscovered = true;
        }

        switch (objective.Progress)
        {
          case QuestProgress.Undiscovered:
            break;
          case QuestProgress.Incomplete:
            if (objective.EligibleFactions.Contains(GetLocalPlayer()))
              objective.ShowLocal(Progress);
            objective.ShowSync(Progress);
            break;
          case QuestProgress.Complete:
            if (objective.EligibleFactions.Contains(GetLocalPlayer()))
              objective.HideLocal();
            objective.HideSync();
            break;
          case QuestProgress.Failed:
            break;
          default:
            throw new ArgumentOutOfRangeException(nameof(objective));
        }
      }


      //If anything is undiscovered, the quest is undiscovered
      if (anyUndiscovered && Progress != QuestProgress.Undiscovered)
        Progress = QuestProgress.Undiscovered;
      //If everything is complete, the quest is completed
      else if (allComplete && Progress != QuestProgress.Complete)
        Progress = QuestProgress.Complete;
      //If anything is failed, the quest is failed
      else if (anyFailed && Progress != QuestProgress.Failed)
        Progress = QuestProgress.Failed;
      else
        Progress = QuestProgress.Incomplete;
    }

    public void AddObjective(Objective objective)
    {
      _objectives.Add(objective);
      if (objective.ShowsInQuestLog)
      {
        objective.QuestItem = QuestCreateItem(Quest);
        QuestItemSetDescription(objective.QuestItem, objective.Description);
      }

      objective.ProgressChanged += OnQuestItemProgressChanged;
    }
  }
}