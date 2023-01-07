using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelMate.Application.Constants.Languages;
using TravelMate.Domain.Entities.Languages;

namespace TravelMate.Infrastructure.Contracts.Seeds.Languages
{
    public static class LanguageResourceENSeed
    {
        public static List<LanguageResource> LanguageResourceList()
        {
            return new List<LanguageResource>()
            {
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.AddingWasSuccessful, Value="Adding was successful."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.DataDoNotMatch, Value="Data do not match."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.AlreadyAvailable, Value="Already available."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.DataNotFound, Value="Data not found."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.DeletingIsSuccessful, Value="Deleting is successful."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.TransactionSuccessful, Value="Transaction successful."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.TransactionFailed, Value="Transaction failed."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.UpdateSuccessful, Value="Update successful."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.CouldNotChangePassword, Value="Could not change password."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.ThePasswordWasChanged, Value= "The password was changed."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.EmailSuccessfulyConfirmed, Value="E-mail successfully confirmed."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.EmailVerificationFailed, Value="E-mail verification failed, please try again."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.WelcomeToDeliverist, Value="Welcome to Deliverist."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.EmailOrPassWordIncorrent, Value="E-mail or password incorrect."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.UserNotFound, Value="User not found."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.CountryNotFound, Value="Country not found."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.LanguageNotFound, Value="Language not found."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.SupplierNotFound, Value="Supplier not found."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.CategoryNotFound, Value="Category not found."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.StateNotFound, Value="State not found."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.OrderNotFound, Value="Order not found."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.StateTypeNotFound, Value="State type not found."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.UserAddressNotFound, Value="Address not found."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.ShipmentNotFound, Value="Shipment not found."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.CargoNotFound, Value="Cargo not found."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.CurrencyTypeNotFound, Value="Currency Type not found."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.ThisEmailIsAlreadyRegistered, Value="This e-mail is already registered."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.CountryCodeIsRequired, Value="Country code is required."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.CityIsRequired, Value="City is required."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.PostalCodeIsRequired, Value="City is required."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.NewPasswordIsRequired, Value="New password is required."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.PasswordIsRequired, Value="Password is required."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.PasswordMinimum8Character, Value="Password must be a minimum of 8 characters."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.PasswordIsInvalid, Value="It must contain at least eight characters, at least one uppercase letter, one lowercase letter, one number."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.FirstNameIsRequired, Value="First Name is required."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.LastNameIsRequired, Value="Last Name is required."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.EmailAddressIsRequired, Value="E-mail Address is required."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.InvalidEmailAddress, Value="Invalid e-mail address."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.PhoneNumberIsRequired, Value="Phone Number is required."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.ShippingCountryIsRequired, Value="Shipping Country is required."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.ShippingCompanyNameIsRequired, Value="Shipping company name is required."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.LanguageIsRequired, Value="Language is required."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.LanguageCodeIsRequired, Value="Language Code is required."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.ValueIsRequired, Value="Value is required."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.SupplierIsRequired, Value="Supplier is required."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.AmountIsRequired, Value="Amount is required."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.DescriptionIsRequired, Value="Description is required."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.CategoryIsRequired, Value="Category is required."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.LinkIsRequired, Value="Link is required."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.OrderIsRequired, Value= "Order is required."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.StateIsRequired, Value="State is required."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.UserIsRequired, Value="User is required."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.CountryNameIsRequired, Value="Country name is required."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.CurrencyTypeIsRequired, Value="Currency type is required."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.TemplateNameIsRequired, Value="Template name is required."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.TemplateBodyIsRequired, Value="Template body is required."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.ShipmentIsRequired, Value="Shipment is required."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.CostIsRequired, Value="Cost is required."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.StateTypeIsRequired, Value="State type is required."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.UserAddressIsRequired, Value="User address is required."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.TrackingNumberIsRequired, Value="Tracking number is required."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.UnitLoadCellNameIsRequired, Value="Unit load cell name is required."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.UnitLoadCellCodeIsRequired, Value="Unit load cell code is required."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.PaymentTransactionFailed, Value= "Payment transaction failed."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.ForgotPasswordEmailSent, Value="If the e-mail address is registered, the password reset e-mail has been sent."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.PleaseConfirmMailAddress, Value="Please confirm your e-mail address."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.RoleNotFound, Value="Role not found."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.PackageIsAlreadyShipment, Value="A shipping request has already been created for this package."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.MailNotSent, Value="Transactions completed, but an error occurred while sending the e-mail."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.MailTemplateNotFound, Value="Transactions completed, but the e-mail template was not found."},
                new  LanguageResource {LanguageCode="en-US",Name=ResponseConstants.IncorrectOperation, Value="You have made an incomplete or incorrect operation."},
                new  LanguageResource {LanguageCode = "en-US",Name = ResponseConstants.MaxShippingWeightExceeded,Value = "Maximum shipping weight exceeded."},
                new  LanguageResource {LanguageCode = "en-US",Name = ResponseConstants.OrderIsAlreadyInWarehouse, Value = "Order is already in the warehouse."}
            };
        }

    }
}
