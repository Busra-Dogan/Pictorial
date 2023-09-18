using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pictorial.Business.Constants
{
    public static class Messages
    {
        public static string MaintenanceTime = "Sistem bakımdadır. Daha sonra lütfen tekrar deneyiniz.";

        #region Course
        public static string CourseAdded = "Kurs eklendi.";
        public static string CoursesListed = "Kurslar listelendi."; 
        public static string CourseDeleted = "Kurs silindi.";
        public static string CourseUpdated = "Kurs güncellendi.";
        public static string CourseGetById = "Kurs detayı getirildi.";
        public static string CoursesGetByCategoryId = "İlgili kategoride kurslar getirildi.";
        public static string CoursesGetByLanguageId = "İlgili dildeki kurslar getirildi.";
        #endregion

        #region Word
        public static string WordAdded = "İlgili kursa kelime eklendi.";
        public static string WordsListed = "İlgili kursun kelimeleri listelendi.";
        public static string WordDeleted = "İlgili kursa kelime silindi.";
        public static string WordUpdated = "İlgili kursa kelime güncellendi.";
        #endregion

        #region Category
        public static string CategoryAdded = "Kategori eklendi.";
        public static string CategoryDeleted = "Kategori silindi.";
        public static string CategoriesListed = "Kategoriler listelendi.";
        public static string CategoryUpdated = "Kategori güncellendi.";
        #endregion

        #region Authority
        public static string AuthorityAdded = "Yetki tanımı yapıldı.";
        public static string AuthorityDeleted = "Yetki tanımı silindi.";
        public static string AuthoritiesListed = "Yetki tanımları listelendi.";
        public static string NoAuthority = "Kayıtlı bir yetki tanımı bulunmamaktadır.";
        #endregion

        #region Member
        public static string MemberAdded = "Üye kaydedildi.";
        public static string MemberDeleted = "Üye silindi.";
        public static string NoMember = "Kayıtlı bir üye bulunmamaktadır.";
        public static string MembersListed = "Üyeler listelendi.";
        public static string MemberUpdated = "Üye bilgisi güncellendi.";
        #endregion
    }

    public static class ErrorMessages
    {
        #region Authority
        public static string AuthorityCodeLength = "Kod uzunluğu 4 'ten uzun olamaz.";
        public static string AuthorityNotNull = "Yetki kodu alanı null olamaz.";
        #endregion

        #region Category
        public static string CategoryCanNotAdd = "Kategori eklenemedi. Tekrar deneyiniz.";        
        public static string CategoryCanNotDelete = "Kategori silinemedi. Tekrar deneyiniz.";
        public static string CategoryCanNotUpdate = "Kategori bilgileri güncellenemedi. Tekrar deneyiniz.";
        public static string NoCategory = "Kayıtlı bir kategori bulunmamaktadır.";
        public static string CategoryNotFind = "Aradığınız kategori bulunmamaktadır.";
        #endregion

        #region Course
        public static string CourseCanNotAdded = "Kategori eklenemedi. Tekrar deneyiniz.";
        public static string CourseCanNotDeleted = "Kategori silinemedi. Tekrar deneyiniz.";
        public static string NoCourse = "Kayıtlı bir kurs bulunmamaktadır.";
        public static string CourseCanNotUpdated = "Kategori bilgisi güncellenemedi. Tekrar deneyiniz.";
        public static string CourseGetNotById = "Kurs bilgisi getirilemedi. Tekrar deneyiniz.";
        #endregion

        #region Member
        public static string MemberCanNotAdded = "Üye eklenemedi. Tekrar deneyiniz.";
        public static string MemberCanNotDeleted = "Üye silinemedi. Tekrar deneyiniz.";
        public static string MemberCanNotUpdated = "Üye bilgisi güncellenemedi. Tekrar deneyiniz.";
        #endregion

        #region Word

        public static string WordCanNotAdded = "Kelime eklenemedi. Tekrar deneyiniz.";
        public static string WordCanNotUpdated = "Kelime güncellenemedi. Tekrar deneyiniz.";
        public static string WordCanNotDeleted = "Kelime silinemedi. Tekrar deneyiniz.";
        public static string NoWord = "Kayıtlı bir kelime bulunmamaktadır.";
        #endregion
    }
}
