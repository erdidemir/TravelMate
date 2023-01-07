using TravelMate.Application.Constants.Languages;
using TravelMate.Domain.Entities.Languages;

namespace TravelMate.Infrastructure.Contracts.Seeds.Languages
{
    public static class LanguageResourceTRSeed
    {
        public static List<LanguageResource> LanguageResourceList()
        {
            return new List<LanguageResource>()
            {
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.AddingWasSuccessful, Value="Ekleme işlemi başarılı."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.DataDoNotMatch, Value="Veri eşleşmiyor."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.AlreadyAvailable, Value="Zaten mevcut."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.DataNotFound, Value="Veri bulunamadı."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.DeletingIsSuccessful, Value="Silme işlemi başarılı."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.TransactionSuccessful, Value="İşlem başarılı."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.TransactionFailed, Value="İşlem başarısız."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.UpdateSuccessful, Value="Güncelleme başarılı."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.CouldNotChangePassword, Value="Şifre değiştirilemedi."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.ThePasswordWasChanged, Value= "Şifre değiştirildi."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.EmailSuccessfulyConfirmed, Value="E-posta başarıyla onaylandı."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.EmailVerificationFailed, Value="E-posta doğrulaması başarısız oldu, lütfen tekrar deneyin."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.WelcomeToDeliverist, Value="Deliverist'e hoşgeldiniz."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.EmailOrPassWordIncorrent, Value="E-posta veya şifre yanlış."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.UserNotFound, Value="Kullanıcı bulunamadı."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.CountryNotFound, Value="Ülke bulunamadı."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.LanguageNotFound, Value="Dil bulunamadı."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.SupplierNotFound, Value="Tedarikçi bulunamadı."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.CategoryNotFound, Value="Kategori bulunamadı."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.StateNotFound, Value="Durum bulunamadı."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.OrderNotFound, Value="Sipariş bulunamadı."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.StateTypeNotFound, Value="Durum tipi bulunamadı."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.UserAddressNotFound, Value="Adres bulunamadı."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.ShipmentNotFound, Value="Gönderi bulunamadı."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.CargoNotFound, Value="Kargo firması bulunamadı."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.CurrencyTypeNotFound, Value="Para tipi bulunamadı."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.ThisEmailIsAlreadyRegistered, Value="Bu e-posta adresi zaten kayıtlı."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.CountryCodeIsRequired, Value="Ülke kodu gerekli."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.CityIsRequired, Value="Şehir gerekli."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.PostalCodeIsRequired, Value="Posta kodu gerekli."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.NewPasswordIsRequired, Value="Yeni şifre gerekli."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.PasswordIsRequired, Value="Şifre gerekli."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.PasswordMinimum8Character, Value="Şifre minimum 8 karakter olmalıdır."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.PasswordIsInvalid, Value="En az sekiz karakter, en az bir büyük harf, bir küçük harf, bir rakam içermelidir."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.FirstNameIsRequired, Value="Ad gerekli."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.LastNameIsRequired, Value="Soyad gerekli."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.EmailAddressIsRequired, Value="E-posta adresi gerekli."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.InvalidEmailAddress, Value="Geçersiz e-posta adresi."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.PhoneNumberIsRequired, Value="Telefon numarası gerekli."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.ShippingCountryIsRequired, Value="Gönderi ülkesi gerekli."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.ShippingCompanyNameIsRequired, Value="Nakliye şirketi adı gerekli."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.LanguageIsRequired, Value="Dil gerekli."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.LanguageCodeIsRequired, Value="Dil kodu gerekli."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.ValueIsRequired, Value="Değer gerekli."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.SupplierIsRequired, Value="Tedarikçi gerekli."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.AmountIsRequired, Value="Tutar gerekli."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.DescriptionIsRequired, Value="Açıklama gerekli."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.CategoryIsRequired, Value="Kategori gerekli."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.LinkIsRequired, Value="Link gerekli."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.OrderIsRequired, Value= "Sipariş gerekli."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.StateIsRequired, Value="Durum gerekli."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.UserIsRequired, Value="Kullanıcı gerekli."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.CountryNameIsRequired, Value="Ülke adı gerekli."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.CurrencyTypeIsRequired, Value="Para tipi gerekli."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.TemplateNameIsRequired, Value="Şablon adı gerekli."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.TemplateBodyIsRequired, Value="Şablon gövdesi gerekli."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.ShipmentIsRequired, Value="Gönderi gerekli."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.CostIsRequired, Value="Maliyet gerekli."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.StateTypeIsRequired, Value="Durum tipi gerekli."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.UserAddressIsRequired, Value="Adres gerekli."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.TrackingNumberIsRequired, Value="Takip numarası gerekli."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.UnitLoadCellNameIsRequired, Value="Birim yük hücresi adı gerekli."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.UnitLoadCellCodeIsRequired, Value="Birim yük hücresi kodu gerekli."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.PaymentTransactionFailed, Value= "Ödeme işlemi başarısız oldu."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.ForgotPasswordEmailSent, Value="E-posta adresi kayıtlı ise şifre sıfırlama e-postası gönderilmiştir."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.PleaseConfirmMailAddress, Value="Lütfen e-posta adresinizi doğrulayın."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.RoleNotFound, Value="Rol bulunamadı."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.PackageIsAlreadyShipment, Value="Bu paket için zaten bir gönderim talebi oluşturuldu."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.MailNotSent, Value="İşlemler tamamlandı, ancak e-posta gönderilirken bir hata oluştu."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.MailTemplateNotFound, Value="İşlemler tamamlandı, ancak e-posta şablonu bulunamadı."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.IncorrectOperation, Value="Eksik veya yanlış bir işlem yaptınız."},
                new  LanguageResource {LanguageCode="tr-TR",Name=ResponseConstants.MaxShippingWeightExceeded, Value="Maksimum nakliye ağırlığı aşıldı."},
                new  LanguageResource {LanguageCode = "tr-TR",Name = ResponseConstants.OrderIsAlreadyInWarehouse, Value = "Sipariş zaten depoda."}

            };
        }

    }
}
