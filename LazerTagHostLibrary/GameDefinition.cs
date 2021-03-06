﻿namespace LazerTagHostLibrary
{
	public class GameDefinition
	{
		public GameDefinition()
		{
			CountdownTimeSeconds = 30;
			ResendCountdownTimeSeconds = 10;
		}

		public GameType GameType
		{
			get { return _gameTypeInfo.Type; }
			set { _gameTypeInfo = GameTypes.GetInfo(value); }
		}

		private GameTypeInfo _gameTypeInfo;
		public GameTypeInfo GameTypeInfo
		{
			get { return _gameTypeInfo; }
		}

		public RandomId GameId { get; set; }
		public int GameTimeMinutes { get; set; }
		public int Tags { get; set; }

		private int _reloads;
		public int Reloads
		{
			get { return _reloads; }
			set
			{
				_reloads = value;
				_limitedReloads = (_reloads != 0xff);
			}
		}

		public int Shields { get; set; }

		private int _mega;
		public int Mega
		{
			get
			{
				return _mega;
			}
			set
			{
				_mega = value;
				LimitedMega = (_mega != 0xff);
			}
		}

		public bool ExtendedTagging { get; set; }

		private bool _limitedReloads;
		public bool LimitedReloads
		{
			get { return _limitedReloads; }
			set
			{
				_limitedReloads = value;
				if (value)
				{
					if (_reloads == 0xff) _reloads = 99;
				}
				else
				{
					_reloads = 0xff;
				}
			}
		}

		private bool _limitedMega;
		public bool LimitedMega
		{
			get { return _limitedMega; }
			set
			{
				_limitedMega = value;
				if (value)
				{
					if (_mega == 0xff) _mega = 99;
				}
				else
				{
					_mega = 0xff;
				}
			}
		}

		public bool TeamTags { get; set; }
		public bool MedicMode { get; set; }
		public bool SlowTags { get; set; }

		public bool IsZoneGame
		{
			get { return GameTypeInfo.Zones || GameTypeInfo.TeamZones || GameTypeInfo.ZonesRevivePlayers || GameTypeInfo.HospitalZones || GameTypeInfo.ZonesTagPlayers; }
		}

		public int TeamCount
		{
			get { return GameTypeInfo.TeamCount; }
		}

		public bool IsTeamGame
		{
			get { return (TeamCount > 1); }
		}

		public int CountdownTimeSeconds { get; set; }
		public int ResendCountdownTimeSeconds { get; set; }
	}
}
