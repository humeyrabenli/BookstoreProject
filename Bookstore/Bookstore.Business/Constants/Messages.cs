using Bookstore.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Business.Constants
{
    public static class Messages
    {
        public static string BookAdded = "Kitap Eklendi";
        public static string BooksListed = "Kitaplar Listelendi";
        public static string BookNameAlreadyExists="Bu isimde başka bir kitap var!";
        public static string AuthorizationDenied="Yetkiniz yok";
        public static string UserAlreadyExists="Böyle bir kullanıcı zaten mevcut";
        public static string UserRegistered="Kullanıcı kaydı başarılı";
        public static string SuccessfulLogin="Giriş Başarılı";
        public static string PasswordError="Parola Hatalı!";
        public static string UserNotFound="Kullanıcı bulunamadı";
        public static string AccessTokenCreated="Token Oluşturuldu";
    }
}
