namespace MellmothJdr.Services.Dto;

public class PartieDetailDto
{
    public string Nom { get; set; }
    public List<PersoDto> Persos { get; set; }
    public Guid Id { get; set; }
    public int? NombreParticipant { get; set; }
}
