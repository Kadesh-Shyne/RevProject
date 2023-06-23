namespace ReventTechnologyAPI.DTOs
{
    public class RevApiDto
    {
        public record CreateRevApiDto(int Id, string Name, string Description);
        public record ViewRevApiDto(int Id, string Name, string Description);
       
    }
}
