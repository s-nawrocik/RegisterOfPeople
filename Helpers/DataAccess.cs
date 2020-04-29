using RegisterOfPeopleApp.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RegisterOfPeopleApp.Helpers
{
    public class DataAccess
    {
        private static readonly string registerPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\RegisterOfPeople";
        private static readonly string registerName = "Register";
        public Register GetRegister()
        {
            if (CheckIfRegisterDirExists())
            {
                var file = GetRegisterFile();

                if (file != null)
                {
                    return GetRegisterFromFileInfo(file);
                }
                else
                {
                    return new Register();
                }
            }
            else
            {
                return new Register();
            }
        }        
        public void SaveRegister(Register register)
        {
            CheckIfRegisterDirExists();

            var serializer = GetSerializer();
            using (var stream = new FileStream($"{registerPath}/{registerName}.xml", FileMode.Create))
            {
                serializer.Serialize(stream, register);
            }
        }
        private FileInfo GetRegisterFile()
        {
            DirectoryInfo dirInfo = new DirectoryInfo(registerPath);
            var files = dirInfo.GetFiles("*.xml", SearchOption.AllDirectories);
            return files.FirstOrDefault(f => f.Name == $"{registerName}.xml");
        }
        private bool CheckIfRegisterDirExists()
        {
            if (Directory.Exists(registerPath))
            {
                return true;
            }
            else
            {
                Directory.CreateDirectory(registerPath);
                return false;
            }
        }
        private Register GetRegisterFromFileInfo(FileInfo file)
        {
            var serializer = GetSerializer();
            var fileStream = file.OpenRead();
            var register = (Register)serializer.Deserialize(fileStream);
            return register;
        }
        private XmlSerializer GetSerializer()
        {
            return new XmlSerializer(typeof(Register));
        }
    }
}
