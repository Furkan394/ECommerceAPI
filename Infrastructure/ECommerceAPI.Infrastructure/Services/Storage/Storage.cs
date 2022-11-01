using ECommerceAPI.Infrastructure.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Infrastructure.Services.Storage
{
    public class Storage
    {
        protected string FileRename(string fileName)
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
