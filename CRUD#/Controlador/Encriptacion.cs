
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;

namespace CRUD_.Controlador {
    internal class Encriptacion {
        private readonly string claveEncriptacion = "2z\\6;!Q5<iec;;,/";

        public string Encriptar(string plainText) {
            using (Aes algoritmoAES = Aes.Create()) {
                algoritmoAES.Key = Encoding.UTF8.GetBytes(claveEncriptacion);
                algoritmoAES.IV = new byte[algoritmoAES.BlockSize / 8];

                ICryptoTransform encriptador = algoritmoAES.CreateEncryptor(algoritmoAES.Key, algoritmoAES.IV);

                using (MemoryStream msEncrypt = new MemoryStream()) {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encriptador, CryptoStreamMode.Write)) {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt)) {
                            swEncrypt.Write(plainText);
                        }
                    }
                    return Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
        }

        public string Desencriptar(string cipherText) {
            using (Aes algoritmoAES = Aes.Create()) {
                algoritmoAES.Key = Encoding.UTF8.GetBytes(claveEncriptacion);
                algoritmoAES.IV = new byte[algoritmoAES.BlockSize / 8];

                ICryptoTransform decryptor = algoritmoAES.CreateDecryptor(algoritmoAES.Key, algoritmoAES.IV);

                using (MemoryStream msDecrypt = new MemoryStream(Convert.FromBase64String(cipherText))) {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read)) {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt)) {
                            return srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
        }
    }
}
