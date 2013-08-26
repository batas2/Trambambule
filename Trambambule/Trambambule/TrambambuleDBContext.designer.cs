﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1008
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Trambambule
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Trambambule")]
	public partial class TrambambuleDBContextDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertMatch(Match instance);
    partial void UpdateMatch(Match instance);
    partial void DeleteMatch(Match instance);
    partial void InsertTeamMatch(TeamMatch instance);
    partial void UpdateTeamMatch(TeamMatch instance);
    partial void DeleteTeamMatch(TeamMatch instance);
    partial void InsertPlayer(Player instance);
    partial void UpdatePlayer(Player instance);
    partial void DeletePlayer(Player instance);
    partial void InsertTeamMatchPlayer(TeamMatchPlayer instance);
    partial void UpdateTeamMatchPlayer(TeamMatchPlayer instance);
    partial void DeleteTeamMatchPlayer(TeamMatchPlayer instance);
    #endregion
		
		public TrambambuleDBContextDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["TrambambuleConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public TrambambuleDBContextDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TrambambuleDBContextDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TrambambuleDBContextDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TrambambuleDBContextDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Match> Matches
		{
			get
			{
				return this.GetTable<Match>();
			}
		}
		
		public System.Data.Linq.Table<TeamMatch> TeamMatches
		{
			get
			{
				return this.GetTable<TeamMatch>();
			}
		}
		
		public System.Data.Linq.Table<Player> Players
		{
			get
			{
				return this.GetTable<Player>();
			}
		}
		
		public System.Data.Linq.Table<TeamMatchPlayer> TeamMatchPlayers
		{
			get
			{
				return this.GetTable<TeamMatchPlayer>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Match")]
	public partial class Match : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _Id;
		
		private System.DateTime _Timestamp;
		
		private EntitySet<TeamMatch> _TeamMatches;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(System.Guid value);
    partial void OnIdChanged();
    partial void OnTimestampChanging(System.DateTime value);
    partial void OnTimestampChanged();
    #endregion
		
		public Match()
		{
			this._TeamMatches = new EntitySet<TeamMatch>(new Action<TeamMatch>(this.attach_TeamMatches), new Action<TeamMatch>(this.detach_TeamMatches));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Timestamp", DbType="DateTime NOT NULL")]
		public System.DateTime Timestamp
		{
			get
			{
				return this._Timestamp;
			}
			set
			{
				if ((this._Timestamp != value))
				{
					this.OnTimestampChanging(value);
					this.SendPropertyChanging();
					this._Timestamp = value;
					this.SendPropertyChanged("Timestamp");
					this.OnTimestampChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Match_TeamMatch", Storage="_TeamMatches", ThisKey="Id", OtherKey="MatchId")]
		public EntitySet<TeamMatch> TeamMatches
		{
			get
			{
				return this._TeamMatches;
			}
			set
			{
				this._TeamMatches.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_TeamMatches(TeamMatch entity)
		{
			this.SendPropertyChanging();
			entity.Match = this;
		}
		
		private void detach_TeamMatches(TeamMatch entity)
		{
			this.SendPropertyChanging();
			entity.Match = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TeamMatch")]
	public partial class TeamMatch : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _Id;
		
		private System.Guid _MatchId;
		
		private int _Goals;
		
		private byte _Result;
		
		private EntitySet<TeamMatchPlayer> _TeamMatchPlayers;
		
		private EntityRef<Match> _Match;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(System.Guid value);
    partial void OnIdChanged();
    partial void OnMatchIdChanging(System.Guid value);
    partial void OnMatchIdChanged();
    partial void OnGoalsChanging(int value);
    partial void OnGoalsChanged();
    partial void OnResultChanging(byte value);
    partial void OnResultChanged();
    #endregion
		
		public TeamMatch()
		{
			this._TeamMatchPlayers = new EntitySet<TeamMatchPlayer>(new Action<TeamMatchPlayer>(this.attach_TeamMatchPlayers), new Action<TeamMatchPlayer>(this.detach_TeamMatchPlayers));
			this._Match = default(EntityRef<Match>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MatchId", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid MatchId
		{
			get
			{
				return this._MatchId;
			}
			set
			{
				if ((this._MatchId != value))
				{
					if (this._Match.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMatchIdChanging(value);
					this.SendPropertyChanging();
					this._MatchId = value;
					this.SendPropertyChanged("MatchId");
					this.OnMatchIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Goals", DbType="Int NOT NULL")]
		public int Goals
		{
			get
			{
				return this._Goals;
			}
			set
			{
				if ((this._Goals != value))
				{
					this.OnGoalsChanging(value);
					this.SendPropertyChanging();
					this._Goals = value;
					this.SendPropertyChanged("Goals");
					this.OnGoalsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Result", DbType="TinyInt NOT NULL")]
		public byte Result
		{
			get
			{
				return this._Result;
			}
			set
			{
				if ((this._Result != value))
				{
					this.OnResultChanging(value);
					this.SendPropertyChanging();
					this._Result = value;
					this.SendPropertyChanged("Result");
					this.OnResultChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TeamMatch_TeamMatchPlayer", Storage="_TeamMatchPlayers", ThisKey="Id", OtherKey="TeamMatchId")]
		public EntitySet<TeamMatchPlayer> TeamMatchPlayers
		{
			get
			{
				return this._TeamMatchPlayers;
			}
			set
			{
				this._TeamMatchPlayers.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Match_TeamMatch", Storage="_Match", ThisKey="MatchId", OtherKey="Id", IsForeignKey=true)]
		public Match Match
		{
			get
			{
				return this._Match.Entity;
			}
			set
			{
				Match previousValue = this._Match.Entity;
				if (((previousValue != value) 
							|| (this._Match.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Match.Entity = null;
						previousValue.TeamMatches.Remove(this);
					}
					this._Match.Entity = value;
					if ((value != null))
					{
						value.TeamMatches.Add(this);
						this._MatchId = value.Id;
					}
					else
					{
						this._MatchId = default(System.Guid);
					}
					this.SendPropertyChanged("Match");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_TeamMatchPlayers(TeamMatchPlayer entity)
		{
			this.SendPropertyChanging();
			entity.TeamMatch = this;
		}
		
		private void detach_TeamMatchPlayers(TeamMatchPlayer entity)
		{
			this.SendPropertyChanging();
			entity.TeamMatch = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Player")]
	public partial class Player : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _FirstName;
		
		private string _LastName;
		
		private string _Nickname;
		
		private System.DateTime _Timestamp;
		
		private int _Location;
		
		private EntitySet<TeamMatchPlayer> _TeamMatchPlayers;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnNicknameChanging(string value);
    partial void OnNicknameChanged();
    partial void OnTimestampChanging(System.DateTime value);
    partial void OnTimestampChanged();
    partial void OnLocationChanging(int value);
    partial void OnLocationChanged();
    #endregion
		
		public Player()
		{
			this._TeamMatchPlayers = new EntitySet<TeamMatchPlayer>(new Action<TeamMatchPlayer>(this.attach_TeamMatchPlayers), new Action<TeamMatchPlayer>(this.detach_TeamMatchPlayers));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="VarChar(100)")]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="VarChar(100)")]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nickname", DbType="VarChar(100)")]
		public string Nickname
		{
			get
			{
				return this._Nickname;
			}
			set
			{
				if ((this._Nickname != value))
				{
					this.OnNicknameChanging(value);
					this.SendPropertyChanging();
					this._Nickname = value;
					this.SendPropertyChanged("Nickname");
					this.OnNicknameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Timestamp", DbType="DateTime NOT NULL")]
		public System.DateTime Timestamp
		{
			get
			{
				return this._Timestamp;
			}
			set
			{
				if ((this._Timestamp != value))
				{
					this.OnTimestampChanging(value);
					this.SendPropertyChanging();
					this._Timestamp = value;
					this.SendPropertyChanged("Timestamp");
					this.OnTimestampChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Location", DbType="Int NOT NULL")]
		public int Location
		{
			get
			{
				return this._Location;
			}
			set
			{
				if ((this._Location != value))
				{
					this.OnLocationChanging(value);
					this.SendPropertyChanging();
					this._Location = value;
					this.SendPropertyChanged("Location");
					this.OnLocationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Player_TeamMatchPlayer", Storage="_TeamMatchPlayers", ThisKey="Id", OtherKey="PlayerId")]
		public EntitySet<TeamMatchPlayer> TeamMatchPlayers
		{
			get
			{
				return this._TeamMatchPlayers;
			}
			set
			{
				this._TeamMatchPlayers.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_TeamMatchPlayers(TeamMatchPlayer entity)
		{
			this.SendPropertyChanging();
			entity.Player = this;
		}
		
		private void detach_TeamMatchPlayers(TeamMatchPlayer entity)
		{
			this.SendPropertyChanging();
			entity.Player = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TeamMatchPlayer")]
	public partial class TeamMatchPlayer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _TeamMatchId;
		
		private int _PlayerId;
		
		private byte _Position;
		
		private System.Nullable<double> _Rating;
		
		private System.Nullable<double> _RD;
		
		private System.DateTime _Timestamp;
		
		private EntityRef<Player> _Player;
		
		private EntityRef<TeamMatch> _TeamMatch;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTeamMatchIdChanging(System.Guid value);
    partial void OnTeamMatchIdChanged();
    partial void OnPlayerIdChanging(int value);
    partial void OnPlayerIdChanged();
    partial void OnPositionChanging(byte value);
    partial void OnPositionChanged();
    partial void OnRatingChanging(System.Nullable<double> value);
    partial void OnRatingChanged();
    partial void OnRDChanging(System.Nullable<double> value);
    partial void OnRDChanged();
    partial void OnTimestampChanging(System.DateTime value);
    partial void OnTimestampChanged();
    #endregion
		
		public TeamMatchPlayer()
		{
			this._Player = default(EntityRef<Player>);
			this._TeamMatch = default(EntityRef<TeamMatch>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TeamMatchId", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid TeamMatchId
		{
			get
			{
				return this._TeamMatchId;
			}
			set
			{
				if ((this._TeamMatchId != value))
				{
					if (this._TeamMatch.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnTeamMatchIdChanging(value);
					this.SendPropertyChanging();
					this._TeamMatchId = value;
					this.SendPropertyChanged("TeamMatchId");
					this.OnTeamMatchIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PlayerId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int PlayerId
		{
			get
			{
				return this._PlayerId;
			}
			set
			{
				if ((this._PlayerId != value))
				{
					if (this._Player.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPlayerIdChanging(value);
					this.SendPropertyChanging();
					this._PlayerId = value;
					this.SendPropertyChanged("PlayerId");
					this.OnPlayerIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Position", DbType="TinyInt NOT NULL")]
		public byte Position
		{
			get
			{
				return this._Position;
			}
			set
			{
				if ((this._Position != value))
				{
					this.OnPositionChanging(value);
					this.SendPropertyChanging();
					this._Position = value;
					this.SendPropertyChanged("Position");
					this.OnPositionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Rating", DbType="Float")]
		public System.Nullable<double> Rating
		{
			get
			{
				return this._Rating;
			}
			set
			{
				if ((this._Rating != value))
				{
					this.OnRatingChanging(value);
					this.SendPropertyChanging();
					this._Rating = value;
					this.SendPropertyChanged("Rating");
					this.OnRatingChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RD", DbType="Float")]
		public System.Nullable<double> RD
		{
			get
			{
				return this._RD;
			}
			set
			{
				if ((this._RD != value))
				{
					this.OnRDChanging(value);
					this.SendPropertyChanging();
					this._RD = value;
					this.SendPropertyChanged("RD");
					this.OnRDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Timestamp", DbType="DateTime NOT NULL")]
		public System.DateTime Timestamp
		{
			get
			{
				return this._Timestamp;
			}
			set
			{
				if ((this._Timestamp != value))
				{
					this.OnTimestampChanging(value);
					this.SendPropertyChanging();
					this._Timestamp = value;
					this.SendPropertyChanged("Timestamp");
					this.OnTimestampChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Player_TeamMatchPlayer", Storage="_Player", ThisKey="PlayerId", OtherKey="Id", IsForeignKey=true)]
		public Player Player
		{
			get
			{
				return this._Player.Entity;
			}
			set
			{
				Player previousValue = this._Player.Entity;
				if (((previousValue != value) 
							|| (this._Player.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Player.Entity = null;
						previousValue.TeamMatchPlayers.Remove(this);
					}
					this._Player.Entity = value;
					if ((value != null))
					{
						value.TeamMatchPlayers.Add(this);
						this._PlayerId = value.Id;
					}
					else
					{
						this._PlayerId = default(int);
					}
					this.SendPropertyChanged("Player");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TeamMatch_TeamMatchPlayer", Storage="_TeamMatch", ThisKey="TeamMatchId", OtherKey="Id", IsForeignKey=true)]
		public TeamMatch TeamMatch
		{
			get
			{
				return this._TeamMatch.Entity;
			}
			set
			{
				TeamMatch previousValue = this._TeamMatch.Entity;
				if (((previousValue != value) 
							|| (this._TeamMatch.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TeamMatch.Entity = null;
						previousValue.TeamMatchPlayers.Remove(this);
					}
					this._TeamMatch.Entity = value;
					if ((value != null))
					{
						value.TeamMatchPlayers.Add(this);
						this._TeamMatchId = value.Id;
					}
					else
					{
						this._TeamMatchId = default(System.Guid);
					}
					this.SendPropertyChanged("TeamMatch");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
