using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelperFunctions.Business
{
    public class FantasyFootball
    {
        [JsonProperty("element_stats")]
        public List<ElementStats> ElementStats { get; set; }
        [JsonProperty("element_types")]
        public List<ElementTypes> ElementTypes { get; set; }
        [JsonProperty("elements")]
        public List<Elements> Elements { get; set; }
        [JsonProperty("events")]
        public List<Events> Events { get; set; }
        [JsonProperty("game_settings")]
        public GameSettings GameSettings { get; set; }
        [JsonProperty("phases")]
        public List<Phases> Phases { get; set; }
        [JsonProperty("teams")]
        public List<Teams> Teams { get; set; }
        [JsonProperty("total_players")]
        public int TotalPlayers { get; set; }
    }

    public class ElementStats
    {
        public string Label { get; set; }
        public string Name { get; set; }
    }

    public class ElementTypes
    {
        public int Id { get; set; }
        [JsonProperty("plural_name")]
        public string PluralName { get; set; }
        [JsonProperty("plural_name_short")]
        public string PluralShortName { get; set; }
        [JsonProperty("singular_name")]
        public string SingularName { get; set; }
        [JsonProperty("singular_name_short")]
        public string SingularShortName { get; set; }
        [JsonProperty("squad_max_play")]
        public int SquadMaxPlay { get; set; }
        [JsonProperty("squad_min_play")]
        public int SquadMinPlay { get; set; }
        [JsonProperty("squad_select")]
        public int SquadSelect { get; set; }
        [JsonProperty("sub_positions_locked")]
        public List<int> SubPositionsLocked { get; set; }
        [JsonProperty("ui_shirt_specific")]
        public bool UIShirtSpecific { get; set; }
    }

    public class Elements
    {
        [JsonProperty("chance_of_playing_next_round")]
        public int? ChanceOfPlayingNextRound { get; set; }
        [JsonProperty("chance_of_playing_this_round")]
        public int? ChanceOfPlayingThisRounc { get; set; }
        public int Assists { get; set; }
        public int Bonus { get; set; }
        public int Bps { get; set; }
        [JsonProperty("clean_sheets")]
        public int CleanSheets { get; set; }
        public int Code { get; set; }
        [JsonProperty("corners_and_indirect_freekicks_order")]
        public int? CornersAndIndirectFreekicksOrder { get; set; }
        [JsonProperty("corners_and_indirect_freekicks_text")]
        public string CornersAndIndirectFreekicksText { get; set; }
        [JsonProperty("cost_change_event")]
        public int CostChangeEvent { get; set; }
        [JsonProperty("cost_change_event_fall")]
        public int CostChangeEventFall { get; set; }
        [JsonProperty("cost_change_start")]
        public int CostChangeStart { get; set; }
        [JsonProperty("cost_change_start_fall")]
        public int CostChangeStartFall { get; set; }
        public decimal Creativity { get; set; }
        [JsonProperty("creativity_rank")]
        public int CreativityRank { get; set; }
        [JsonProperty("creativity_rank_type")]
        public int CreativityRankType { get; set; }
        [JsonProperty("direct_freekicks_order")]
        public int? DirectFreekicksOrder { get; set; }
        [JsonProperty("direct_freekicks_text")]
        public string DirectFreekicksText { get; set; }
        [JsonProperty("dreamteam_count")]
        public int DreamTeamCount { get; set; }
        [JsonProperty("element_type")]
        public int ElementType { get; set; }
        [JsonProperty("ep_next")]
        public decimal EpNext { get; set; }
        [JsonProperty("ep_this")]
        public decimal EpThis { get; set; }
        [JsonProperty("event_points")]
        public int EventPoints { get; set; }
        [JsonProperty("first_name")]
        public string FirstName { get; set; }
        public decimal Form { get; set; }
        [JsonProperty("goals_conceded")]
        public int GoalsConceded { get; set; }
        [JsonProperty("goals_scored")]
        public int GoalsScored { get; set; }
        [JsonProperty("ict_index")]
        public decimal ICTIndex { get; set; }
        [JsonProperty("ict_index_rank")]
        public int ICTIndexRank { get; set; }
        [JsonProperty("ict_index_rank_type")]
        public int ICTIndexRankType { get; set; }
        public int Id { get; set; }
        [JsonProperty("in_dreamteam")]
        public bool InDreamteam { get; set; }
        public decimal Influence { get; set; }
        [JsonProperty("influence_rank")]
        public int InfluenceRank { get; set; }
        [JsonProperty("influence_rank_type")]
        public int InfluenceRankType { get; set; }
        public int Minutes { get; set; }
        public string News { get; set; }
        [JsonProperty("news_added")]
        public string NewsAdded { get; set; }
        [JsonProperty("now_cost")]
        public int NowCost { get; set; }
        [JsonProperty("own_goals")]
        public int OwnGoals { get; set; }
        [JsonProperty("penalties_missed")]
        public int PenaltiesMissed { get; set; }
        [JsonProperty("penalties_order")]
        public int? PenaltiesOrder { get; set; }
        [JsonProperty("penalties_saved")]
        public int PenaltiesSaved { get; set; }
        [JsonProperty("penalties_text")]
        public string PenaltiesText { get; set; }
        public string Photo { get; set; }
        [JsonProperty("points_per_game")]
        public decimal PointsPerGame { get; set; }
        [JsonProperty("red_cards")]
        public int RedCards { get; set; }
        public int Saves { get; set; }
        [JsonProperty("second_name")]
        public string SecondName { get; set; }
        [JsonProperty("selected_by_percent")]
        public decimal SelectedByPercent { get; set; }
        public bool Special { get; set; }
        [JsonProperty("squad_number")]
        public int? SquadNumber { get; set; }
        public string Status { get; set; }
        public int Team { get; set; }
        [JsonProperty("team_code")]
        public int TeamCode { get; set; }
        public decimal Threat { get; set; }
        [JsonProperty("threat_rank")]
        public int ThreatRank { get; set; }
        [JsonProperty("threat_rank_type")]
        public int ThreatRankType { get; set; }
        [JsonProperty("total_points")]
        public int TotalPoints { get; set; }
        [JsonProperty("transfers_in")]
        public int TransfersIn { get; set; }
        [JsonProperty("transfers_in_event")]
        public int TransfersInEvent { get; set; }
        [JsonProperty("transfers_out")]
        public int TransfersOut { get; set; }
        [JsonProperty("transfers_out_event")]
        public int TransfersOutEvent { get; set; }
        [JsonProperty("value_form")]
        public decimal ValueForm { get; set; }
        [JsonProperty("value_season")]
        public decimal ValueSeason { get; set; }
        [JsonProperty("web_name")]
        public string WebName { get; set; }
        [JsonProperty("yellow_cards")]
        public int YellowCards { get; set; }
    }

    public class Events
    {
        [JsonProperty("average_entry_score")]
        public int AverageEntryScore { get; set; }
        [JsonProperty("chip_plays")]
        public List<ChipPlays> ChipPlays { get; set; }
        [JsonProperty("data_checked")]
        public bool DataChecked { get; set; }
        [JsonProperty("deadline_time")]
        public DateTimeOffset DeadlineTime { get; set; }
        [JsonProperty("deadline_time_epoch")]
        public long DeadlineTimeEpoch { get; set; }
        [JsonProperty("deadline_time_game_offset")]
        public int DeadlineTimeGameOffset { get; set; }
        public bool Finished { get; set; }
        [JsonProperty("highest_score")]
        public int? HighestScore { get; set; }
        [JsonProperty("highest_scoring_entry")]
        public int? HighestScoringEntry { get; set; }
        public int Id { get; set; }
        [JsonProperty("is_current")]
        public bool IsCurrent { get; set; }
        [JsonProperty("is_next")]
        public bool IsNext { get; set; }
        [JsonProperty("is_previous")]
        public bool IsPrevious { get; set; }
        [JsonProperty("most_captained")]
        public int? MostCaptained { get; set; }
        [JsonProperty("most_selected")]
        public int? MostSelected { get; set; }
        [JsonProperty("most_transferred_in")]
        public int? MostTransferredIn { get; set; }
        [JsonProperty("most_vice_captained")]
        public int? MostViceCaptained { get; set; }
        public string Name { get; set; }
        [JsonProperty("top_element")]
        public string TopElement { get; set; }
        [JsonProperty("top_element_info")]
        public TopElementInfo TopElementInfo { get; set; }
        [JsonProperty("transfers_made")]
        public int TransfersMade { get; set; }
    }

    public class ChipPlays
    {
        [JsonProperty("chip_name")]
        public string ChipName { get; set; }
        [JsonProperty("num_played")]
        public int NumPlayed { get; set; }
    }

    public class TopElementInfo
    {
        public int Id { get; set; }
        public int Points { get; set; }
    }

    public class GameSettings
    {
        [JsonProperty("cup_qualifying_method")]
        public string CupQualifyingMethod { get; set; }
        [JsonProperty("cup_start_event_id")]
        public int CupStartEventId { get; set; }
        [JsonProperty("cup_stop_event_id")]
        public int CupStopEventId { get; set; }
        [JsonProperty("cup_type")]
        public string CupType { get; set; }
        [JsonProperty("league_h2h_tiebreak_stats")]
        public List<string> LeagueH2HTiebreakStats { get; set; }
        [JsonProperty("league_join_private_max")]
        public int LeagueJoinPrivateMax { get; set; }
        [JsonProperty("league_join_public_max")]
        public int LeagueJoinPublicMax { get; set; }
        [JsonProperty("league_ko_first_instead_of_random")]
        public bool LeagueKOFirstInsteadOfRandom { get; set; }
        [JsonProperty("league_max_size_private_h2h")]
        public int LeagueMaxSizePrivateH2H { get; set; }
        [JsonProperty("league_max_size_public_classic")]
        public int LeagueMaxSizePublicClassic { get; set; }
        [JsonProperty("league_max_size_public_h2h")]
        public int LeagueMaxSizePublicH2h { get; set; }
        [JsonProperty("league_points_h2h_draw")]
        public int LeaguePointsH2HDraw { get; set; }
        [JsonProperty("league_points_h2h_lose")]
        public int LeaguePointsH2HLose { get; set; }
        [JsonProperty("league_points_h2h_win")]
        public int LeaguePointsH2HWin { get; set; }
        [JsonProperty("league_prefix_public")]
        public string LeaguePrefixPublic { get; set; }
        [JsonProperty("squad_squadplay")]
        public int SquadSquadplay { get; set; }
        [JsonProperty("squad_squadsize")]
        public int SquadSquadsize { get; set; }
        [JsonProperty("squad_team_limit")]
        public int SquadTeamLimit { get; set; }
        [JsonProperty("squad_total_spend")]
        public int SquadTotalSpend { get; set; }
        [JsonProperty("stats_form_days")]
        public int StatesFormDays { get; set; }
        [JsonProperty("sys_vice_captain_enabled")]
        public bool SysViceCaptainEnabled { get; set; }
        [JsonProperty("timezone")]
        public string Timezone { get; set; }
        [JsonProperty("transfers_cap")]
        public int TransfersCap { get; set; }
        [JsonProperty("transfers_sell_on_fee")]
        public decimal TransfersSellOnFee { get; set; }
        [JsonProperty("ui_currency_multiplier")]
        public int UICurrencyMultiplier { get; set; }
        [JsonProperty("ui_special_shirt_exclusions")]
        public List<string> UISpecialShirtExclusions { get; set; }
        [JsonProperty("ui_use_special_shirts")]
        public bool UIUseSpecialShirts { get; set; }
    }

    public class Phases
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonProperty("start_event")]
        public int StartEvent { get; set; }
        [JsonProperty("stop_event")]
        public int StopEvent { get; set; }
    }

    public class Teams
    {
        public int Code { get; set; }
        public int Draw { get; set; }
        public int? Form { get; set; }
        public int Id { get; set; }
        public int Loss { get; set; }
        public string Name { get; set; }
        public int Played { get; set; }
        public int Points { get; set; }
        public int Position { get; set; }
        [JsonProperty("pulse_id")]
        public int PulseId { get; set; }
        [JsonProperty("short_name")]
        public string ShortName { get; set; }
        public int Strength { get; set; }
        [JsonProperty("strength_attack_away")]
        public int StrengthAttackAway { get; set; }
        [JsonProperty("strength_attack_home")]
        public int StrengthAttackHome { get; set; }
        [JsonProperty("strength_defence_away")]
        public int StrengthDefenceAway { get; set; }
        [JsonProperty("strength_defence_home")]
        public int StrengthDefenceHome { get; set; }
        [JsonProperty("strength_overall_away")]
        public int StrengthOverallAway { get; set; }
        [JsonProperty("strength_overall_home")]
        public int StrengthOverallHome { get; set; }
        [JsonProperty("team_division")]
        public string TeamDivision { get; set; }
        public bool Unavailable { get; set; }
        public int Win { get; set; }
    }
}
