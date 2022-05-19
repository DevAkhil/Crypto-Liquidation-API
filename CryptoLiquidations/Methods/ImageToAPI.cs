namespace CryptoLiquidations.Methods
{
    public class ImageToAPI
    {
        public byte[]? graphToByte(string fileName, IWebHostEnvironment _environment)
        {
            string path = _environment.WebRootPath + "\\Graphs\\";
            var filePath = path + fileName + ".png";
            if (System.IO.File.Exists(filePath))
            {
                byte[] b = System.IO.File.ReadAllBytes(filePath);

                return b;
            }
            return null;

        }


    }
}
