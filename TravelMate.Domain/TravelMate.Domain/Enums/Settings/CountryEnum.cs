using System.ComponentModel.DataAnnotations;

namespace TravelMate.Domain.Enums.Settings
{
    public static class CountryEnum
    {
        public enum Countries
        {

            [CountryInfo(Code = "AF", Name = "Afghanistan", PhoneCode = "+93")]
            Afghanistan = 1,

            [CountryInfo(Code = "AL", Name = "Albania", PhoneCode = "+355")]
            Albania,

            [CountryInfo(Code = "DZ", Name = "Algeria", PhoneCode = "+213")]
            Algeria,

            [Display(Name = "American Samoa")]
            [CountryInfo(Code = "AS", Name = "American Samoa", PhoneCode = "+1")]
            AmericanSamoa,

            [CountryInfo(Code = "AD", Name = "Andorra", PhoneCode = "+376")]
            Andorra,

            [CountryInfo(Code = "AO", Name = "Angola", PhoneCode = "+244")]
            Angola,


            [CountryInfo(Code = "AI", Name = "Anguilla", PhoneCode = "+1")]
            Anguilla,



            [CountryInfo(Code = "AQ", Name = "Antarctica", PhoneCode = "+672")]
            Antarctica,


            [CountryInfo(Code = "AG", Name = "Antigua and Barbuda", PhoneCode = "+1")]
            AntiguaandBarbuda,


            [CountryInfo(Code = "AR", Name = "Argentina", PhoneCode = "+54")]
            Argentina,

            [CountryInfo(Code = "AM", Name = "Armenia", PhoneCode = "+374")]
            Armenia,

            [CountryInfo(Code = "AW", Name = "Aruba", PhoneCode = "+297")]
            Aruba,

            [CountryInfo(Code = "AU", Name = "Australia", PhoneCode = "+61")]
            Australia,

            [CountryInfo(Code = "AT", Name = "Austria", PhoneCode = "+43")]
            Austria,

            [CountryInfo(Code = "AZ", Name = "Azerbaijan", PhoneCode = "+994")]
            Azerbaijan,


            [CountryInfo(Code = "BS", Name = "Bahamas", PhoneCode = "+1")]
            Bahamas,


            [CountryInfo(Code = "BH", Name = "Bahrain", PhoneCode = "+973")]
            Bahrain,

            [CountryInfo(Code = "BD", Name = "Bangladesh", PhoneCode = "+880")]
            Bangladesh,


            [CountryInfo(Code = "BB", Name = "Barbados", PhoneCode = "+1")]
            Barbados,

            [CountryInfo(Code = "BY", Name = "Belarus", PhoneCode = "+375")]
            Belarus,

            [CountryInfo(Code = "BE", Name = "Belgium", PhoneCode = "+32")]
            Belgium,

            [CountryInfo(Code = "BZ", Name = "Belize", PhoneCode = "+501")]
            Belize,

            [CountryInfo(Code = "BJ", Name = "Benin", PhoneCode = "+229")]
            Benin,

            [CountryInfo(Code = "BM", Name = "Bermuda", PhoneCode = "+1")]
            Bermuda,

            [CountryInfo(Code = "BT", Name = "Bhutan", PhoneCode = "+975")]
            Bhutan,

            [Display(Name = "Plurinational State Of Bolivia")]
            [CountryInfo(Code = "BO", Name = "Plurinational State Of Bolivia", PhoneCode = "+591")]
            Bolivia,

            [CountryInfo(Code = "BQ", Name = "Bonaire", PhoneCode = "+599")]
            Bonaire,

            [Display(Name = "Bosnia And Herzegovina")]
            [CountryInfo(Code = "BA", Name = "Bosnia And Herzegovina", PhoneCode = "+387")]
            BosniaHerzegovina,

            [CountryInfo(Code = "BW", Name = "Botswana", PhoneCode = "+267")]
            Botswana,

            [Display(Name = "Bouvet Island")]
            [CountryInfo(Code = "BV", Name = "Bouvet Island", PhoneCode = "+47")]
            BouvetIsland,

            [CountryInfo(Code = "BR", Name = "Brazil", PhoneCode = "+55")]
            Brazil,

            [Display(Name = "British Indian Ocean Territory")]
            [CountryInfo(Code = "IO", Name = "British Indian Ocean Territory", PhoneCode = "+246")]
            BritishIndianOceanTerritory,

            [Display(Name = "Brunei Darussalam")]
            [CountryInfo(Code = "BN", Name = "Brunei Darussalam", PhoneCode = "+673")]
            BruneiDarussalam,

            [CountryInfo(Code = "BG", Name = "Bulgaria", PhoneCode = "+359")]
            Bulgaria,

            [Display(Name = "Burkina Faso")]
            [CountryInfo(Code = "BF", Name = "Burkina Faso", PhoneCode = "+226")]
            BurkinaFaso,

            [CountryInfo(Code = "BI", Name = "Burundi", PhoneCode = "+257")]
            Burundi,

            [CountryInfo(Code = "KH", Name = "Cambodia", PhoneCode = "+855")]
            Cambodia,

            [CountryInfo(Code = "CM", Name = "Cameroon", PhoneCode = "+237")]
            Cameroon,

            [Display(Name = "Cayman Islands")]
            [CountryInfo(Code = "KY", Name = "Cayman Islands", PhoneCode = "+1")]
            CaymanIslands,


            [CountryInfo(Code = "CA", Name = "Canada", PhoneCode = "+1")]
            Canada,

            [Display(Name = "Cape Verde")]
            [CountryInfo(Code = "CV", Name = "Cape Verde", PhoneCode = "+238")]
            CapeVerde,

            [Display(Name = "Central African Republic")]
            [CountryInfo(Code = "CF", Name = "Central African Republic", PhoneCode = "+236")]
            CentralAfricanRepublic,

            [CountryInfo(Code = "TD", Name = "Chad", PhoneCode = "+235")]
            Chad,

            [CountryInfo(Code = "CL", Name = "Chile", PhoneCode = "+56")]
            Chile,

            [CountryInfo(Code = "CN", Name = "China", PhoneCode = "+86")]
            China,

            [Display(Name = "Christmas Island")]
            [CountryInfo(Code = "CX", Name = "Christmas Island", PhoneCode = "+61")]
            ChristmasIsland,

            [Display(Name = "Cocos (Keeling) Islands")]
            [CountryInfo(Code = "CC", Name = "Cocos (Keeling) Islands", PhoneCode = "+61")]
            CocosIslands,

            [CountryInfo(Code = "CO", Name = "Colombia", PhoneCode = "+57")]
            Colombia,

            [CountryInfo(Code = "KM", Name = "Comoros", PhoneCode = "+269")]
            Comoros,

            [CountryInfo(Code = "CG", Name = "Congo", PhoneCode = "+242")]
            Congo,

            [Display(Name = "The Democratic Republic Of The Congo")]
            [CountryInfo(Code = "CD", Name = "The Democratic Republic Of The Congo", PhoneCode = "+243")]
            DemocraticRepublicConGO,

            [Display(Name = "Cook Islands")]
            [CountryInfo(Code = "CK", Name = "Cook Islands", PhoneCode = "+682")]
            CookIslands,

            [Display(Name = "Costa Rica")]
            [CountryInfo(Code = "CR", Name = "Costa Rica", PhoneCode = "+506")]
            CostaRica,

            [CountryInfo(Code = "HR", Name = "Croatia", PhoneCode = "+385")]
            Croatia,

            [CountryInfo(Code = "CU", Name = "Cuba", PhoneCode = "+53")]
            Cuba,

            [CountryInfo(Code = "CW", Name = "Curaçao", PhoneCode = "+599")]
            Curaçao,

            [CountryInfo(Code = "CY", Name = "Cyprus", PhoneCode = "+357")]
            Cyprus,

            [Display(Name = "Czech Republic")]
            [CountryInfo(Code = "CZ", Name = "Czech Republic", PhoneCode = "+420")]
            CzechRepublic,

            [CountryInfo(Code = "DK", Name = "Denmark", PhoneCode = "+45")]
            Denmark,

            [CountryInfo(Code = "DJ", Name = "Djibouti", PhoneCode = "+253")]
            Djibouti,

            [CountryInfo(Code = "DM", Name = "Dominica", PhoneCode = "+1")]
            Dominica,

            [Display(Name = "Dominican Republic")]
            [CountryInfo(Code = "DO", Name = "Dominican Republic", PhoneCode = "+1")]
            DominicanRepublic,

            [CountryInfo(Code = "EC", Name = "Ecuador", PhoneCode = "+593")]
            Ecuador,

            [CountryInfo(Code = "EG", Name = "Egypt", PhoneCode = "+20")]
            Egypt,

            [Display(Name = "El Salvador")]
            [CountryInfo(Code = "SV", Name = "El Salvador", PhoneCode = "+503")]
            ElSalvador,

            [Display(Name = "Equatorial Guinea")]
            [CountryInfo(Code = "GQ", Name = "Equatorial Guinea", PhoneCode = "+240")]
            EquatorialGuinea,

            [CountryInfo(Code = "ER", Name = "Eritrea", PhoneCode = "+291")]
            Eritrea,

            [CountryInfo(Code = "EE", Name = "Estonia", PhoneCode = "+372")]
            Estonia,

            [CountryInfo(Code = "ET", Name = "Ethiopia", PhoneCode = "+251")]
            Ethiopia,

            [Display(Name = "Falkland Islands")]
            [CountryInfo(Code = "FK", Name = "Falkland Islands", PhoneCode = "+500")]
            FalklandIslands,

            [Display(Name = "Faroe Islands")]
            [CountryInfo(Code = "FO", Name = "Faroe Islands", PhoneCode = "+298")]
            FaroeIslands,

            [CountryInfo(Code = "FJ", Name = "Fiji", PhoneCode = "+679")]
            Fiji,

            [CountryInfo(Code = "FI", Name = "Finland", PhoneCode = "+358")]
            Finland,

            [CountryInfo(Code = "FR", Name = "France", PhoneCode = "+33")]
            France,

            [Display(Name = "French Guiana")]
            [CountryInfo(Code = "GF", Name = "French Guiana", PhoneCode = "+594")]
            FrenchGuiana,

            [Display(Name = "French Southern and Antarctic Lands")]
            [CountryInfo(Code = "GF", Name = "French Southern and Antarctic Lands", PhoneCode = "+262")]
            FrenchSouthernandAntarcticLands,

            [CountryInfo(Code = "GA", Name = "Gabon", PhoneCode = "+241")]
            Gabon,

            [CountryInfo(Code = "GM", Name = "Gambia", PhoneCode = "+220")]
            Gambia,

            [CountryInfo(Code = "GE", Name = "Georgia", PhoneCode = "+995")]
            Georgia,

            [CountryInfo(Code = "DE", Name = "Germany", PhoneCode = "+49")]
            Germany,

            [CountryInfo(Code = "GH", Name = "Ghana", PhoneCode = "+233")]
            Ghana,

            [CountryInfo(Code = "GI", Name = "Gibraltar", PhoneCode = "+350")]
            Gibraltar,

            [Display(Name = "United Kingdom")]
            [CountryInfo(Code = "GB", Name = "United Kingdom", PhoneCode = "+44")]
            UnitedKingdom,

            [CountryInfo(Code = "GR", Name = "Greece", PhoneCode = "+30")]
            Greece,

            [CountryInfo(Code = "GL", Name = "Greenland", PhoneCode = "+299")]
            Greenland,

            [CountryInfo(Code = "GD", Name = "Grenada", PhoneCode = "+1")]
            Grenada,

            [CountryInfo(Code = "GP", Name = "Guadeloupe", PhoneCode = "+590")]
            Guadeloupe,

            [CountryInfo(Code = "GU", Name = "Guam", PhoneCode = "+1")]
            Guam,

            [CountryInfo(Code = "GT", Name = "Guatemala", PhoneCode = "+502")]
            Guatemala,

            [Display(Name = "Bailiwick of Guernsey")]
            [CountryInfo(Code = "GG", Name = "Bailiwick of Guernsey", PhoneCode = "+44")]
            Guernsey,

            [CountryInfo(Code = "GN", Name = "Guinea", PhoneCode = "+224")]
            Guinea,

            [Display(Name = "Gine-Bissau")]
            [CountryInfo(Code = "GW", Name = "Guinea-Bissau", PhoneCode = "+245")]
            GuineaBissau,

            [CountryInfo(Code = "GY", Name = "Guyana", PhoneCode = "+592")]
            Guyana,

            [CountryInfo(Code = "HT", Name = "Haiti", PhoneCode = "+509")]
            Haiti,

            [Display(Name = "Vatican City")]
            [CountryInfo(Code = "VA", Name = "Vatican City", PhoneCode = "+39")]
            vaticanCity,

            [CountryInfo(Code = "HN", Name = "Honduras", PhoneCode = "+504")]
            Honduras,

            [Display(Name = "Hong Kong")]
            [CountryInfo(Code = "HK", Name = "Hong Kong", PhoneCode = "+852")]
            HongKong,

            [CountryInfo(Code = "HU", Name = "Hungary", PhoneCode = "+36")]
            Hungary,

            [CountryInfo(Code = "IS", Name = "Iceland", PhoneCode = "+354")]
            Iceland,

            [CountryInfo(Code = "IN", Name = "India", PhoneCode = "+91")]
            India,

            [CountryInfo(Code = "ID", Name = "Indonesia", PhoneCode = "+62")]
            Indonesia,

            [Display(Name = "Iran")]
            [CountryInfo(Code = "IR", Name = "Iran", PhoneCode = "+98")]
            Iran,

            [CountryInfo(Code = "IQ", Name = "Iraq", PhoneCode = "+964")]
            Iraq,

            [CountryInfo(Code = "IE", Name = "Ireland", PhoneCode = "+353")]
            Ireland,

            [Display(Name = "Isle of Man")]
            [CountryInfo(Code = "IM", Name = "Isle of Man", PhoneCode = "+44")]
            IsleofMan,

            [CountryInfo(Code = "IL", Name = "Israel", PhoneCode = "+972")]
            Israel,

            [CountryInfo(Code = "IT", Name = "Italy", PhoneCode = "+39")]
            Italy,

            [Display(Name = "Côte D'ivoire")]
            [CountryInfo(Code = "CI", Name = "Côte D'ivoire", PhoneCode = "+225")]
            CoteDivoire,


            [CountryInfo(Code = "JM", Name = "Jamaica", PhoneCode = "+1")]
            Jamaica,

            [CountryInfo(Code = "JP", Name = "Japan", PhoneCode = "+81")]
            Japan,

            [Display(Name = "Bailiwick of Jersey")]
            [CountryInfo(Code = "JE", Name = "Bailiwick of Jersey", PhoneCode = "+44")]
            Jersey,

            [CountryInfo(Code = "JO", Name = "Jordan", PhoneCode = "+962")]
            Jordan,

            [CountryInfo(Code = "KZ", Name = "Kazakhstan", PhoneCode = "+7")]
            Kazakhstan,

            [CountryInfo(Code = "KE", Name = "Kenya", PhoneCode = "+254")]
            Kenya,

            [CountryInfo(Code = "KI", Name = "Kiribati", PhoneCode = "+686")]
            Kiribati,

            [CountryInfo(Code = "KW", Name = "Kuwait", PhoneCode = "+965")]
            Kuwait,

            [CountryInfo(Code = "KG", Name = "Kyrgyzstan", PhoneCode = "+996")]
            Kyrgyzstan,

            [Display(Name = "Lao People's Democratic Republic")]
            [CountryInfo(Code = "LA", Name = "Lao People's Democratic Republic", PhoneCode = "+856")]
            LaoPeoplesDR,

            [CountryInfo(Code = "LV", Name = "Latvia", PhoneCode = "+371")]
            Latvia,

            [CountryInfo(Code = "LB", Name = "Lebanon", PhoneCode = "+961")]
            Lebanon,

            [CountryInfo(Code = "LS", Name = "Lesotho", PhoneCode = "+266")]
            Lesotho,

            [CountryInfo(Code = "LR", Name = "Liberia", PhoneCode = "+231")]
            Liberia,

            [CountryInfo(Code = "LY", Name = "Libya", PhoneCode = "+218")]
            Libya,

            [CountryInfo(Code = "LI", Name = "Liechtenstein", PhoneCode = "+423")]
            Liechtenstein,

            [CountryInfo(Code = "LT", Name = "Lithuania", PhoneCode = "+370")]
            Lithuania,

            [CountryInfo(Code = "LU", Name = "Luxembourg", PhoneCode = "+352")]
            Luxembourg,

            [CountryInfo(Code = "MO", Name = "Macao", PhoneCode = "+853")]
            Macao,

            [CountryInfo(Code = "MK", Name = "Macedonia", PhoneCode = "+389")]
            Macedonia,

            [CountryInfo(Code = "MG", Name = "Madagascar", PhoneCode = "+261")]
            Madagascar,

            [CountryInfo(Code = "MW", Name = "Malawi", PhoneCode = "+265")]
            Malawi,

            [CountryInfo(Code = "MY", Name = "Malaysia", PhoneCode = "+60")]
            Malaysia,

            [CountryInfo(Code = "MV", Name = "Maldives", PhoneCode = "+960")]
            Maldives,

            [CountryInfo(Code = "ML", Name = "Mali", PhoneCode = "+223")]
            Mali,

            [CountryInfo(Code = "MT", Name = "Malta", PhoneCode = "+356")]
            Malta,

            [Display(Name = "Marshall Islands")]
            [CountryInfo(Code = "MH", Name = "Marshall Islands", PhoneCode = "+692")]
            MarshallIslands,

            [CountryInfo(Code = "MQ", Name = "Martinique", PhoneCode = "+596")]
            Martinique,

            [CountryInfo(Code = "MR", Name = "Mauritania", PhoneCode = "+222")]
            Mauritania,

            [CountryInfo(Code = "MU", Name = "Mauritius", PhoneCode = "+230")]
            Mauritius,

            [CountryInfo(Code = "YT", Name = "Mayotte", PhoneCode = "+262")]
            Mayotte,

            [CountryInfo(Code = "MX", Name = "Mexico", PhoneCode = "+52")]
            Mexico,

            [Display(Name = "Federated States Of Micronesia")]
            [CountryInfo(Code = "FM", Name = "Federated States Of Micronesia", PhoneCode = "+691")]
            Micronesia,

            [Display(Name = "Moldova")]
            [CountryInfo(Code = "MD", Name = "Moldova", PhoneCode = "+373")]
            Moldova,

            [CountryInfo(Code = "MC", Name = "Monaco", PhoneCode = "+377")]
            Monaco,

            [CountryInfo(Code = "MN", Name = "Mongolia", PhoneCode = "+976")]
            Mongolia,

            [CountryInfo(Code = "ME", Name = "Montenegro", PhoneCode = "+382")]
            Montenegro,

            [CountryInfo(Code = "MS", Name = "Montserrat", PhoneCode = "+1")]
            Montserrat,

            [CountryInfo(Code = "MA", Name = "Morocco", PhoneCode = "+212")]
            Morocco,

            [CountryInfo(Code = "MZ", Name = "Mozambique", PhoneCode = "+258")]
            Mozambique,

            [CountryInfo(Code = "MM", Name = "Myanmar", PhoneCode = "+95")]
            Myanmar,

            [CountryInfo(Code = "NA", Name = "Namibia", PhoneCode = "+264")]
            Namibia,

            [CountryInfo(Code = "NR", Name = "Nauru", PhoneCode = "+674")]
            Nauru,

            [CountryInfo(Code = "NP", Name = "Nepal", PhoneCode = "+977")]
            Nepal,

            [CountryInfo(Code = "NL", Name = "Netherlands", PhoneCode = "+31")]
            Netherlands,

            [Display(Name = "New Caledonia")]
            [CountryInfo(Code = "NC", Name = "New Caledonia", PhoneCode = "+687")]
            NewCaledonia,

            [Display(Name = "New Zealand")]
            [CountryInfo(Code = "NZ", Name = "New Zealand", PhoneCode = "+64")]
            NewZealand,

            [CountryInfo(Code = "NI", Name = "Nicaragua", PhoneCode = "+505")]
            Nicaragua,

            [CountryInfo(Code = "NE", Name = "Niger", PhoneCode = "+227")]
            Niger,

            [CountryInfo(Code = "NG", Name = "Nigeria", PhoneCode = "+234")]
            Nigeria,

            [CountryInfo(Code = "NU", Name = "Niue", PhoneCode = "+683")]
            Niue,

            [Display(Name = "Norfolk Island")]
            [CountryInfo(Code = "NF", Name = "Norfolk Island", PhoneCode = "+672")]
            NorfolkIsland,

            [Display(Name = "Mariana Islands")]
            [CountryInfo(Code = "MP", Name = "Mariana Islands", PhoneCode = "+1")]
            MarianaIslands,


            [Display(Name = "North Korea")]
            [CountryInfo(Code = "KP", Name = "North Korea", PhoneCode = "+850")]
            NorthKorea,

            [CountryInfo(Code = "NO", Name = "Norway", PhoneCode = "+47")]
            Norway,

            [CountryInfo(Code = "OM", Name = "Oman", PhoneCode = "+968")]
            Oman,

            [CountryInfo(Code = "PK", Name = "Pakistan", PhoneCode = "+92")]
            Pakista,

            [CountryInfo(Code = "PW", Name = "Palau", PhoneCode = "+680")]
            Palau,


            [CountryInfo(Code = "PS", Name = "Palestine", PhoneCode = "+970")]
            Palestine,


            [CountryInfo(Code = "PA", Name = "Panama", PhoneCode = "+507")]
            Panama,

            [Display(Name = "Papua New Guinea")]
            [CountryInfo(Code = "PG", Name = "Papua New Guinea", PhoneCode = "+675")]
            PapuaNewGuinea,

            [CountryInfo(Code = "PY", Name = "Paraguay", PhoneCode = "+595")]
            Paraguay,

            [CountryInfo(Code = "PE", Name = "Peru", PhoneCode = "+51")]
            Peru,

            [CountryInfo(Code = "PH", Name = "Philippines", PhoneCode = "+63")]
            Philippines,


            [CountryInfo(Code = "PN", Name = "Pitcairn", PhoneCode = "+870")]
            Pitcairn,

            [CountryInfo(Code = "PL", Name = "Poland", PhoneCode = "+48")]
            Poland,

            [Display(Name = "French Polynesia")]
            [CountryInfo(Code = "PF", Name = "French Polynesia", PhoneCode = "+689")]
            FrenchPolynesia,

            [CountryInfo(Code = "PT", Name = "Portugal", PhoneCode = "+351")]
            Portugal,

            [Display(Name = "Puerto Rico")]
            [CountryInfo(Code = "PR", Name = "Puerto Rico", PhoneCode = "+1")]
            PuertoRico,

            [CountryInfo(Code = "QA", Name = "Qatar", PhoneCode = "+974")]
            Qatar,

            [CountryInfo(Code = "RE", Name = "Réunion", PhoneCode = "+262")]
            Réunion,

            [CountryInfo(Code = "RO", Name = "Romania", PhoneCode = "+40")]
            Romania,

            [Display(Name = "Russian Federation")]
            [CountryInfo(Code = "RU", Name = "Russian Federation", PhoneCode = "+7")]
            RussianFederation,

            [CountryInfo(Code = "RW", Name = "Rwanda", PhoneCode = "+250")]
            Rwanda,

            [Display(Name = "Saint Barthélemy")]
            [CountryInfo(Code = "BL", Name = "Saint Barthélemy", PhoneCode = "+590")]
            SaintBarthélemy,

            [Display(Name = "Saint Helena")]
            [CountryInfo(Code = "SH", Name = "Saint Helena", PhoneCode = "+290")]
            SaintHelena,


            [Display(Name = "Saint Kitts and Nevis")]
            [CountryInfo(Code = "KN", Name = "Saint Kitts and Nevis", PhoneCode = "+1")]
            SaintKittsandNevis,

            [Display(Name = "Saint Lucia")]
            [CountryInfo(Code = "LC", Name = "Saint Lucia", PhoneCode = "+1")]
            SaintLucia,

            [Display(Name = "Saint Martin")]
            [CountryInfo(Code = "MF", Name = "Saint Martin", PhoneCode = "+590")]
            SaintMartin,

            [Display(Name = "Saint Pierre And Miquelon")]
            [CountryInfo(Code = "PM", Name = "Saint Pierre And Miquelon", PhoneCode = "+508")]
            SaintPierreMiquelon,


            [Display(Name = "Saint Vincent and the Grenadines")]
            [CountryInfo(Code = "VC", Name = "Saint Vincent and the Grenadines", PhoneCode = "+1")]
            SaintVincent,


            [Display(Name = "Sao Tome And Principe")]
            [CountryInfo(Code = "ST", Name = "Sao Tome And Principe", PhoneCode = "+239")]
            SaoTomeAndPrincipe,

            [CountryInfo(Code = "WS", Name = "Samoa", PhoneCode = "+685")]
            Samoa,

            [Display(Name = "San Marino")]
            [CountryInfo(Code = "SM", Name = "San Marino", PhoneCode = "+378")]
            SanMarino,

            [Display(Name = "Saudi Arabia")]
            [CountryInfo(Code = "SA", Name = "Saudi Arabia", PhoneCode = "+966")]
            SaudiArabia,

            [CountryInfo(Code = "SN", Name = "Senegal", PhoneCode = "+221")]
            Senegal,

            [CountryInfo(Code = "RS", Name = "Serbia", PhoneCode = "+381")]
            Serbia,

            [CountryInfo(Code = "SC", Name = "Seychelles", PhoneCode = "+248")]
            Seychelles,

            [Display(Name = "Sierra Leone")]
            [CountryInfo(Code = "SL", Name = "Sierra Leone", PhoneCode = "+232")]
            SierraLeone,

            [CountryInfo(Code = "SG", Name = "Singapore", PhoneCode = "+65")]
            Singapore,

            [Display(Name = "Sint Maarten")]
            [CountryInfo(Code = "SX", Name = "Sint Maarten", PhoneCode = "+1")]
            SintMaarten,


            [CountryInfo(Code = "SK", Name = "Slovakia", PhoneCode = "+421")]
            Slovakia,

            [CountryInfo(Code = "SI", Name = "Slovenia", PhoneCode = "+386")]
            Slovenia,

            [Display(Name = "Solomon Islands")]
            [CountryInfo(Code = "SB", Name = "Solomon Islands", PhoneCode = "+677")]
            SolomonIslands,

            [CountryInfo(Code = "SO", Name = "Somalia", PhoneCode = "+252")]
            Somalia,

            [Display(Name = "South Africa")]
            [CountryInfo(Code = "ZA", Name = "South Africa", PhoneCode = "+27")]
            SouthAfrica,


            [Display(Name = "South Georgia and the South Sandwich Islands")]
            [CountryInfo(Code = "GS", Name = "South Georgia and the South Sandwich Islands", PhoneCode = "+500")]
            SouthGeorgiaandtheSouthSandwichIslands,

            [Display(Name = "South Sudan")]
            [CountryInfo(Code = "SS", Name = "South Sudan", PhoneCode = "+211")]
            SouthSudan,

            [Display(Name = "South Korea")]
            [CountryInfo(Code = "KR", Name = "South Korea", PhoneCode = "+82")]
            SouthKorea,

            [CountryInfo(Code = "ES", Name = "Spain", PhoneCode = "+34")]
            Spain,

            [Display(Name = "Sri Lanka")]
            [CountryInfo(Code = "LK", Name = "Sri Lanka", PhoneCode = "+94")]
            SriLanka,

            [CountryInfo(Code = "SD", Name = "Sudan", PhoneCode = "+249")]
            Sudan,

            [CountryInfo(Code = "SR", Name = "Suriname", PhoneCode = "+597")]
            Suriname,

            [Display(Name = "Svalbard and Jan Mayen")]
            [CountryInfo(Code = "SJ", Name = "Svalbard and Jan Mayen", PhoneCode = "+47")]
            SvalbardandJanMayen,

            [CountryInfo(Code = "SZ", Name = "Swaziland", PhoneCode = "+268")]
            Swaziland,

            [CountryInfo(Code = "SE", Name = "Sweden", PhoneCode = "+46")]
            Sweden,

            [CountryInfo(Code = "CH", Name = "Switzerland", PhoneCode = "+41")]
            Switzerland,

            [Display(Name = "Syrian Arab Republic")]
            [CountryInfo(Code = "SY", Name = "Syrian Arab Republic", PhoneCode = "+963")]
            SyrianArabRepublic,

            [CountryInfo(Code = "TJ", Name = "Tajikistan", PhoneCode = "+992")]
            Tajikistan,

            [Display(Name = "Taiwan, Province Of China")]
            [CountryInfo(Code = "TW", Name = "Taiwan, Province Of China", PhoneCode = "+886")]
            Taiwan,

            [Display(Name = "United Republic Of Tanzania")]
            [CountryInfo(Code = "TZ", Name = "United Republic Of Tanzania", PhoneCode = "+255")]
            Tanzania,

            [CountryInfo(Code = "TH", Name = "Thailand", PhoneCode = "+66")]
            Thailand,

            [Display(Name = "Timor-Leste")]
            [CountryInfo(Code = "TL", Name = "Timor-Leste", PhoneCode = "+670")]
            TimorLeste,


            [CountryInfo(Code = "TG", Name = "Togo", PhoneCode = "+228")]
            Togo,

            [CountryInfo(Code = "TK", Name = "Tokelau", PhoneCode = "+690")]
            Tokelau,

            [CountryInfo(Code = "TO", Name = "Tonga", PhoneCode = "+676")]
            Tonga,


            [Display(Name = "Trinidad and Tobago")]
            [CountryInfo(Code = "TT", Name = "Trinidad and Tobago", PhoneCode = "+1")]
            TrinidadandTobago,

            [CountryInfo(Code = "TN", Name = "Tunisia", PhoneCode = "+216")]
            Tunisia,

            [CountryInfo(Code = "TR", Name = "Turkey", PhoneCode = "+90")]
            Turkey,

            [CountryInfo(Code = "TM", Name = "Turkmenistan", PhoneCode = "+993")]
            Turkmenistan,

            [CountryInfo(Code = "TV", Name = "Tuvalu", PhoneCode = "+688")]
            Tuvalu,

            [CountryInfo(Code = "UG", Name = "Uganda", PhoneCode = "+256")]
            Uganda,

            [CountryInfo(Code = "UA", Name = "Ukraine", PhoneCode = "+380")]
            Ukraine,

            [Display(Name = "United Arab Emirates")]
            [CountryInfo(Code = "AE", Name = "United Arab Emirates", PhoneCode = "+971")]
            UnitedArabEmirates,

            [Display(Name = "United States")]
            [CountryInfo(Code = "US", Name = "United States", PhoneCode = "+1")]
            UnitedStates,


            [Display(Name = " United States Minor Outlying Islands")]
            [CountryInfo(Code = "UM", Name = " United States Minor Outlying Islands", PhoneCode = "+1")]
            USMinorOutlyingIslands,

            [CountryInfo(Code = "UY", Name = "Uruguay", PhoneCode = "+598")]
            Uruguay,

            [CountryInfo(Code = "UZ", Name = "Uzbekistan", PhoneCode = "+998")]
            Uzbekistan,

            [CountryInfo(Code = "VU", Name = "Vanuatu", PhoneCode = "+678")]
            Vanuatu,

            [Display(Name = "Bolivarian Republic Of Venezuela")]
            [CountryInfo(Code = "VE", Name = "Bolivarian Republic Of Venezuela", PhoneCode = "+58")]
            Venezuela,

            [Display(Name = "Viet Nam")]
            [CountryInfo(Code = "VN", Name = "Viet Nam", PhoneCode = "+84")]
            VietNam,

            [Display(Name = "Wallis And Futuna")]
            [CountryInfo(Code = "WF", Name = "Wallis And Futuna", PhoneCode = "+681")]
            WallisFutuna,

            [Display(Name = "Western Sahara")]
            [CountryInfo(Code = "EH", Name = "Western Sahara", PhoneCode = "+212")]
            WesternSahara,

            [CountryInfo(Code = "YE", Name = "Yemen", PhoneCode = "+967")]
            Yemen,

            [CountryInfo(Code = "ZM", Name = "Zambia", PhoneCode = "+260")]
            Zambia,

            [CountryInfo(Code = "ZW", Name = "Zimbabwe", PhoneCode = "+263")]
            Zimbabwe
        }

        public static string GetCountryName(this Enum value)
        {
            CountryInfoAttribute[] attriburte = value.GetType().GetField(value.ToString()).GetCustomAttributes(typeof(CountryInfoAttribute), false) as CountryInfoAttribute[];
            return attriburte[0].Name;
        }

        public static string GetCountryCode(this Enum value)
        {
            CountryInfoAttribute[] attriburte = value.GetType().GetField(value.ToString()).GetCustomAttributes(typeof(CountryInfoAttribute), false) as CountryInfoAttribute[];
            return attriburte[0].Code.ToUpper();
        }

        public static string GetPhoneCode(this Enum value)
        {
            CountryInfoAttribute[] attriburte = value.GetType().GetField(value.ToString()).GetCustomAttributes(typeof(CountryInfoAttribute), false) as CountryInfoAttribute[];
            return attriburte[0].PhoneCode;
        }

        public static Countries GetEnum(string searchField)
        {
            return Countries.GetValues(typeof(Countries)).Cast<Countries>().SingleOrDefault(
                v => v.GetCountryCode().ToUpper() == searchField.ToUpper() || v.GetCountryName().ToLower() == searchField.ToLower()
            );
        }

    }

    internal class CountryInfoAttribute : Attribute
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string PhoneCode { get; set; }
    }
    public class CountryListModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
