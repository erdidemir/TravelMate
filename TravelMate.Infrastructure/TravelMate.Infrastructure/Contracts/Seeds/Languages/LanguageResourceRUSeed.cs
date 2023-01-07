using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelMate.Application.Constants.Languages;
using TravelMate.Domain.Entities.Languages;

namespace TravelMate.Infrastructure.Contracts.Seeds.Languages
{
    public static class LanguageResourceRUSeed
    {
        public static List<LanguageResource> LanguageResourceList()
        {
            return new List<LanguageResource>()
            {
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.AddingWasSuccessful, Value="Добавление прошло успешно."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.DataDoNotMatch, Value="Данные не совпадают."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.AlreadyAvailable, Value="Уже доступно."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.DataNotFound, Value="Данные не найдены."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.DeletingIsSuccessful, Value="Удаление прошло успешно."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.TransactionSuccessful, Value="Транзакция прошла успешно."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.TransactionFailed, Value="Транзакция не удалась."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.UpdateSuccessful, Value="Обновление успешно."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.CouldNotChangePassword, Value="Не удалось изменить пароль."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.ThePasswordWasChanged, Value= "Пароль был изменен"},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.EmailSuccessfulyConfirmed, Value="Электронная почта успешно подтверждена."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.EmailVerificationFailed, Value="Не удалось подтвердить адрес электронной почты, попробуйте еще раз."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.WelcomeToTravelMate, Value="Добро пожаловать в TravelMate."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.EmailOrPassWordIncorrent, Value="Электронная почта или пароль неверны."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.UserNotFound, Value="Пользователь не найден."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.CountryNotFound, Value="Страна не найдена."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.LanguageNotFound, Value="Язык не найден."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.SupplierNotFound, Value="Поставщик не найден."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.CategoryNotFound, Value="Категория не найдена."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.StateNotFound, Value="Состояние не найдено."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.OrderNotFound, Value="Заказ не найден."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.StateTypeNotFound, Value="Тип состояния не найден."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.UserAddressNotFound, Value="Адрес не найден."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.ShipmentNotFound, Value="Посылка не найдена."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.CargoNotFound, Value="Груз не найден."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.CurrencyTypeNotFound, Value="Тип валюты не найден."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.ThisEmailIsAlreadyRegistered, Value="Эта электронная почта уже зарегистрирована."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.CountryCodeIsRequired, Value="Требуется код страны."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.CityIsRequired, Value="Требуется город."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.PostalCodeIsRequired, Value="Требуется почтовый индекс."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.NewPasswordIsRequired, Value="Требуется новый пароль."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.PasswordIsRequired, Value="Требуется пароль."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.PasswordMinimum8Character, Value="Пароль должен быть не менее 8 символов."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.PasswordIsInvalid, Value="Он должен содержать не менее восьми символов, как минимум одну заглавную букву, одну строчную букву, одну цифру."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.FirstNameIsRequired, Value="Требуется имя."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.LastNameIsRequired, Value="Фамилия обязательна."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.EmailAddressIsRequired, Value="Требуется адрес электронной почты."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.InvalidEmailAddress, Value="Неверный адрес электронной почты."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.PhoneNumberIsRequired, Value="Требуется номер телефона."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.ShippingCountryIsRequired, Value="Укажите страну доставки."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.ShippingCompanyNameIsRequired, Value="Укажите название транспортной компании."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.LanguageIsRequired, Value="Требуется язык."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.LanguageCodeIsRequired, Value="Требуется код языка."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.ValueIsRequired, Value="Требуется значение."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.SupplierIsRequired, Value="Требуется поставщик."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.AmountIsRequired, Value="Требуется сумма."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.DescriptionIsRequired, Value="Требуется описание."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.CategoryIsRequired, Value="Категория обязательна."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.LinkIsRequired, Value="Ссылка обязательна."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.OrderIsRequired, Value= "Требуется порядок."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.StateIsRequired, Value="Требуется состояние."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.UserIsRequired, Value="Требуется пользователь."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.CountryNameIsRequired, Value="Необходимо название страны."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.CurrencyTypeIsRequired, Value="Укажите тип валюты."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.TemplateNameIsRequired, Value="Укажите имя шаблона."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.TemplateBodyIsRequired, Value="Требуется тело шаблона."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.ShipmentIsRequired, Value="Требуется отгрузка."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.CostIsRequired, Value="Требуется стоимость."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.StateTypeIsRequired, Value="Укажите тип состояния."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.UserAddressIsRequired, Value="Требуется адрес пользователя."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.TrackingNumberIsRequired, Value="Требуется номер отслеживания."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.UnitLoadCellNameIsRequired, Value="Укажите название ячейки веса."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.UnitLoadCellCodeIsRequired, Value="Требуется код весоизмерительной ячейки."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.PaymentTransactionFailed, Value= "Платежная транзакция не удалась."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.ForgotPasswordEmailSent, Value="Если адрес электронной почты зарегистрирован, электронное письмо для сброса пароля было отправлено."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.PleaseConfirmMailAddress, Value="Пожалуйста, подтвердите адрес вашей электронной почты."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.RoleNotFound, Value="Роль не найдена"},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.PackageIsAlreadyShipment, Value="Для этого пакета уже создан запрос на доставку."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.MailNotSent, Value="Транзакции завершены, но при отправке письма произошла ошибка."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.MailTemplateNotFound, Value="Транзакции завершены, но шаблон электронной почты не найден."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.IncorrectOperation, Value="Вы выполнили неполную или неправильную операцию."},
                new  LanguageResource {LanguageCode="ru-RU",Name=ResponseConstants.MaxShippingWeightExceeded, Value="Превышен максимальный вес отправления."},
                new  LanguageResource {LanguageCode = "ru-RU",Name =ResponseConstants.OrderIsAlreadyInWarehouse, Value = "Заказ уже на складе."}

            };
        }

    }
}
