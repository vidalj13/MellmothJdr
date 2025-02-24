namespace MellmothJdr.Services.Dto;

public class PersoDto
{
    public Guid Id { get; set; }
    public string Nom { get; set; }
    public string RaceLibelle { get; set; }
    public int TailleCm { get; set; }
    public int PoidKg { get; set; }
    public int Age { get; set; }
    public string Religion { get; set; }
    public int Niveau { get; set; }
    public int PvMax { get; set; }
    public int PvEnCours { get; set; }
}