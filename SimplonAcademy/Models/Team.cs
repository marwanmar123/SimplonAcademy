namespace SimplonAcademy.Models
{
    public class Team
    {
        public Guid Id { get; set; }
        public string? TitleTeam { get; set; }
        public string? NameTeam { get; set; }
        public string? RoleTeam { get; set; }
        public string? DescriptionTeam { get; set; }
        public string? FacebookTeam { get; set; }
        public string? LinkedinTeam { get; set; }
        public string? InstagramTeam { get; set; }
        public string? TwitterTeam { get; set; }
        public byte[]? ImageTeam { get; set; }
    }
}
