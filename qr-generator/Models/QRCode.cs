namespace qr_generator.Models
{
    internal class QRCode
    {

        public string File_Path { get; set; }
        public string File_Name { get; set; }
        public string Data { get; set; }
        public string Version { get; set; }
        public string Box_Size { get; set; }
        public string Border { get; set; }
        public string Fill_Color { get; set; }
        public string Back_Color { get; set; }
        public ImageSource Image_Path { get; set; }
    }
}
