using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SoftwareCompanyManagementSystem.Model;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

namespace SoftwareCompanyManagementSystem
{
    public static class StaticData
    {
        public static UserModel LoggedUser { get; set; }

        public static List<Genders> GetGenders()
        {
            return new List<Genders>() {
                new Genders(){ Id = 0, Gender = "Female" },
                new Genders(){ Id = 1, Gender = "Male" }
            };
        }

        public static byte[] ConvertImageToBinary(Image image)
        {
            using (var memoryStream = new MemoryStream())
            {
                image.Save(memoryStream, ImageFormat.Jpeg);
                return memoryStream.ToArray();
            }
        }
    }

    public class Genders
    {
        public int Id { get; set; }
        public string Gender { get; set; }
    }
}
