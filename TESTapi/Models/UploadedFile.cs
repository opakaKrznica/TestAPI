namespace TESTapi.Models
{
    public class UploadedFile
    {
        public int ProductId { get; set; }
        public string FileName { get; set; }
        public byte[] FileContent { get; set; } = null!;

    }
}
