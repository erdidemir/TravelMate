using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelMate.Application.Constants.Languages;
using TravelMate.Domain.Entities.Languages;

namespace TravelMate.Infrastructure.Contracts.Seeds.Languages
{
    public static class LanguageResourceDESeed
    {
        public static List<LanguageResource> LanguageResourceList()
        {
            return new List<LanguageResource>()
            {
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.AddingWasSuccessful, Value="Das Hinzufügen war erfolgreich."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.DataDoNotMatch, Value="Daten stimmen nicht überein."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.AlreadyAvailable, Value="Schon verfügbar."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.DataNotFound, Value="Daten nicht gefunden."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.DeletingIsSuccessful, Value="Das Löschen ist erfolgreich."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.TransactionSuccessful, Value="Transaktion Erfolgreich."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.TransactionFailed, Value="Transaktion fehlgeschlagen."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.UpdateSuccessful, Value="Aktualisierung erfolgreich."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.CouldNotChangePassword, Value="Kennwort konnte nicht geändert werden."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.ThePasswordWasChanged, Value= "Das Passwort wurde geändert."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.EmailSuccessfulyConfirmed, Value="E-Mail erfolgreich bestätigt."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.EmailVerificationFailed, Value="E-Mail-Bestätigung fehlgeschlagen, bitte."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.WelcomeToTravelMate, Value="Willkommen bei TravelMate."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.EmailOrPassWordIncorrent, Value="E-Mail oder Passwort falsch."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.UserNotFound, Value="Benutzer nicht gefunden."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.CountryNotFound, Value="Land nicht gefunden."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.LanguageNotFound, Value="Sprache nicht gefunden."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.SupplierNotFound, Value="Lieferant nicht gefunden."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.CategoryNotFound, Value="Kategorie nicht gefunden."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.StateNotFound, Value="Zustand nicht gefunden."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.OrderNotFound, Value="Bestellung nicht gefunden."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.StateTypeNotFound, Value="Zustandstyp nicht gefunden."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.UserAddressNotFound, Value="Adresse nicht gefunden."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.ShipmentNotFound, Value="Sendung nicht gefunden."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.CargoNotFound, Value="Fracht nicht gefunden."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.CurrencyTypeNotFound, Value="Währungstyp nicht gefunden."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.ThisEmailIsAlreadyRegistered, Value="Diese Email-Adresse wurde bereits registriert."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.CountryCodeIsRequired, Value="Ländercode ist erforderlich."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.CityIsRequired, Value="Stadt ist erforderlich."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.PostalCodeIsRequired, Value="Postleitzahl ist erforderlich."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.NewPasswordIsRequired, Value="Neues Passwort erforderlich."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.PasswordIsRequired, Value="Passwort wird benötigt."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.PasswordMinimum8Character, Value="Das Passwort muss mindestens 8 Zeichen lang sein."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.PasswordIsInvalid, Value="Es muss mindestens acht Zeichen enthalten, mindestens einen Großbuchstaben, einen Kleinbuchstaben, eine Zahl."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.FirstNameIsRequired, Value="Vorname ist erforderlich."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.LastNameIsRequired, Value="Nachname ist erforderlich."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.EmailAddressIsRequired, Value="E-Mailadresse wird benötigt."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.InvalidEmailAddress, Value="Ungültige E-Mail-Adresse."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.PhoneNumberIsRequired, Value="Telefonnummer ist erforderlich."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.ShippingCountryIsRequired, Value="Lieferland ist erforderlich."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.ShippingCompanyNameIsRequired, Value="Der Name des Versandunternehmens ist erforderlich."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.LanguageIsRequired, Value="Sprache ist erforderlich."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.LanguageCodeIsRequired, Value="Sprachcode ist erforderlich."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.ValueIsRequired, Value="Wert erforderlich."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.SupplierIsRequired, Value="Lieferant ist erforderlich."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.AmountIsRequired, Value="Betrag ist erforderlich."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.DescriptionIsRequired, Value="Beschreibung ist erforderlich."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.CategoryIsRequired, Value="Kategorie ist erforderlich."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.LinkIsRequired, Value="Link ist erforderlich."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.OrderIsRequired, Value= "Bestellung ist erforderlich."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.StateIsRequired, Value="Staat ist erforderlich."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.UserIsRequired, Value="Benutzer ist erforderlich."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.CountryNameIsRequired, Value="Ländername ist erforderlich."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.CurrencyTypeIsRequired, Value="Währungstyp ist erforderlich."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.TemplateNameIsRequired, Value="Vorlagenname ist erforderlich."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.TemplateBodyIsRequired, Value="Vorlagentext ist erforderlich."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.ShipmentIsRequired, Value="Versand ist erforderlich."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.CostIsRequired, Value="Kosten sind erforderlich."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.StateTypeIsRequired, Value="Zustandstyp ist erforderlich."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.UserAddressIsRequired, Value="Benutzeradresse ist erforderlich."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.TrackingNumberIsRequired, Value="Tracking-Nummer ist erforderlich."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.UnitLoadCellNameIsRequired, Value="Der Name der Wägezelle ist erforderlich."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.UnitLoadCellCodeIsRequired, Value="Einheits-Wägezellencode ist erforderlich."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.PaymentTransactionFailed, Value= "Zahlungsvorgang fehlgeschlagen."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.ForgotPasswordEmailSent, Value="Wenn die E-Mail-Adresse registriert ist, wurde die E-Mail zum Zurücksetzen des Passworts gesendet."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.PleaseConfirmMailAddress, Value="Bitte bestätigen Sie Ihre E-Mail-Adresse."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.RoleNotFound, Value="Rolle nicht gefunden."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.PackageIsAlreadyShipment, Value="Für dieses Paket wurde bereits eine Versandanfrage erstellt."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.MailNotSent, Value="Transaktionen abgeschlossen, aber beim Senden der E-Mail ist ein Fehler aufgetreten."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.MailTemplateNotFound, Value="Transaktionen abgeschlossen, aber die E-Mail-Vorlage wurde nicht gefunden."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.IncorrectOperation, Value="Sie haben eine unvollständige oder falsche Operation durchgeführt."},
                new  LanguageResource {LanguageCode="de-DE",Name=ResponseConstants.MaxShippingWeightExceeded, Value ="Maximales Versandgewicht überschritten."},
                new  LanguageResource {LanguageCode = "de-DE",Name = ResponseConstants.OrderIsAlreadyInWarehouse, Value = "Bestellung ist bereits im Lager."}
        };
        }

    }
}
