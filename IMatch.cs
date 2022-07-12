using System;
namespace Interfaces
{
    public enum Outcome
    {
        Loss = 0,
        Win = 1,
        Draw = 2
    }
    public enum Map
    {
        //2cp
        Hanamura, 
        Anubis, 
        Volskaya,
        //Escort
        Dorado,
        Havana,
        Junkertown,
        Rialto,
        Route66,
        Gibraltar,
        CircuitRoyale,
        //Hybrid
        BlizzardWorld,
        Eichenwalde,
        Hollywood,
        KingsRow,
        Midtown,
        Numbani,
        Busan,
        //Control
        Ilios,
        Lijiang,
        Nepal,
        Oasis,
        //Push
        Colosseo,
        NewQueenStreet
    }
    public enum StartSide
    {
        Defense,
        Attack,
        NA
    }
    public enum Hero
    {
        //Tank
        DVa,
        Doomfist,
        Orisa,
        Reinhardt,
        Roadhog,
        Sigma,
        Winston,
        WreckingBall,
        Zarya,
        //Damage
        Ashe,
        Bastion,
        Cassidy,
        Echo,
        Genji,
        Hanzo,
        Junkrat,
        Mei,
        Pharah,
        Reaper,
        Sojourn,
        Soldier76,
        Sombra,
        Symmetra,
        Torbjorn,
        Tracer,
        Widowmaker,
        //Support
        Ana,
        Baptiste,
        Brigitte,
        Lucio,
        Mercy,
        Moira,
        Zenyatta
    }
	public interface IMatch
	{
        #region Properties
        Outcome Outcome { get; set; }
        DateTime Date { get; set; }
        Map Map { get; set; }
        Hero Hero { get; set; }
        StartSide StartSide { get; set;}
        #endregion
    }
}