using ECommerceAPI.Infrastructure.Operations;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Infrastructure.Services
{
    public class FileService
    {
      
        string FileRename(string path, string fileName)
        {
            string extension = Path.GetExtension(fileName);
            string oldName = Path.GetFileNameWithoutExtension(fileName);
            DateTime dateTime = DateTime.UtcNow;
            string fileDateTime = dateTime.ToString("yyyy-MM-dd-HH-mm-ss");
            string newFileName = $"{NameOperation.CharacterRegulatory(oldName)}-{fileDateTime}{extension}";

            return newFileName;
        }

    }
}
