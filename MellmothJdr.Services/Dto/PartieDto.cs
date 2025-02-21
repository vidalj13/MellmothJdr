namespace MellmothJdr.Services.Dto;

public class PartieDto
{
    public string Nom { get; set; }
    public int NombrePerso { get; set; }
    public Guid Id { get; set; }
    public int? NombreParticipant { get; set; }
}