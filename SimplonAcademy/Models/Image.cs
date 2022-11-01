using Microsoft.Extensions.Hosting;

namespace SimplonAcademy.Models
{
    public class Image
    {
        public Guid? Id { get; set; }
        public string? Name { get; set; }
        public string? FileType { get; set; }
        public string? Extension { get; set; }
        public byte[]? Data { get; set; }
    }
}
