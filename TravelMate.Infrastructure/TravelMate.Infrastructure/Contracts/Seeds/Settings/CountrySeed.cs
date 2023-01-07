﻿using TravelMate.Domain.Entities.Settings;

namespace TravelMate.Infrastructure.Contracts.Seeds.Settings
{
    public static class CountrySeed
    {
        public static List<Country> CountryList()
        {
            return new List<Country>()
            {
                new  Country { CountryEnumId=1  , Code = "AF", Name = "Afghanistan", PhoneCode = "+93"},
                new  Country { CountryEnumId=2  , Code = "AL", Name = "Albania", PhoneCode = "+355"},
                new  Country { CountryEnumId=3  , Code = "DZ", Name = "Algeria", PhoneCode = "+213"},
                new  Country { CountryEnumId=4  , Code = "AS", Name = "American Samoa", PhoneCode = "+1"},
                new  Country { CountryEnumId=5  , Code = "AD", Name = "Andorra", PhoneCode = "+376"},
                new  Country { CountryEnumId=6  , Code = "AO", Name = "Angola", PhoneCode = "+244"},
                new  Country { CountryEnumId=7  , Code = "AI", Name = "Anguilla", PhoneCode = "+1"},
                new  Country { CountryEnumId=8  , Code = "AQ", Name = "Antarctica", PhoneCode = "+672"},
                new  Country { CountryEnumId=9  , Code = "AG", Name = "Antigua and Barbuda", PhoneCode = "+1"},
                new  Country { CountryEnumId=10 , Code = "AR", Name = "Argentina", PhoneCode = "+54"},
                new  Country { CountryEnumId=11 , Code = "AM", Name = "Armenia",  PhoneCode = "+374"},
                new  Country { CountryEnumId=12 , Code = "AW", Name = "Aruba", PhoneCode = "+297"},
                new  Country { CountryEnumId=13 , Code = "AU", Name = "Australia", PhoneCode = "+61"},
                new  Country { CountryEnumId=14 , Code = "AT", Name = "Austria",  PhoneCode = "+43"},
                new  Country { CountryEnumId=15 , Code = "AZ", Name = "Azerbaijan", PhoneCode = "+994"},
                new  Country { CountryEnumId=16 , Code = "BS", Name = "Bahamas", PhoneCode = "+1"},
                new  Country { CountryEnumId=17 , Code = "BH", Name = "Bahrain",  PhoneCode = "+973"},
                new  Country { CountryEnumId=18 , Code = "BD", Name = "Bangladesh", PhoneCode = "+880"},
                new  Country { CountryEnumId=19 , Code = "BB", Name = "Barbados",  PhoneCode = "+1"},
                new  Country { CountryEnumId=20 , Code = "BY", Name = "Belarus", PhoneCode = "+375"},
                new  Country { CountryEnumId=21 , Code = "BE", Name = "Belgium", PhoneCode = "+32"},
                new  Country { CountryEnumId=22 , Code = "BZ", Name = "Belize", PhoneCode = "+501"},
                new  Country { CountryEnumId=23 , Code = "BJ", Name = "Benin",  PhoneCode = "+229"},
                new  Country { CountryEnumId=24 , Code = "BM", Name = "Bermuda", PhoneCode = "+1"},
                new  Country { CountryEnumId=25 , Code = "BT", Name = "Bhutan",  PhoneCode = "+975"},
                new  Country { CountryEnumId=26 , Code = "BO", Name = "Plurinational State Of Bolivia", PhoneCode = "+591"},
                new  Country { CountryEnumId=27 , Code = "BQ", Name = "Bonaire", PhoneCode = "+599"},
                new  Country { CountryEnumId=28 , Code = "BA", Name = "Bosnia And Herzegovina", PhoneCode = "+387"},
                new  Country { CountryEnumId=29 , Code = "BW", Name = "Botswana", PhoneCode = "+267"},
                new  Country { CountryEnumId=30 , Code = "BV", Name = "Bouvet Island", PhoneCode = "+47"},
                new  Country { CountryEnumId=31 , Code = "BR", Name = "Brazil", PhoneCode = "+55"},
                new  Country { CountryEnumId=32 , Code = "IO", Name = "British Indian Ocean Territory", PhoneCode = "+246"},
                new  Country { CountryEnumId=33 , Code = "BN", Name = "Brunei Darussalam", PhoneCode = "+673"},
                new  Country { CountryEnumId=34 , Code = "BG", Name = "Bulgaria", PhoneCode = "+359"},
                new  Country { CountryEnumId=35 , Code = "BF", Name = "Burkina Faso",  PhoneCode = "+226"},
                new  Country { CountryEnumId=36 , Code = "BI", Name = "Burundi", PhoneCode = "+257"},
                new  Country { CountryEnumId=37 , Code = "KH", Name = "Cambodia", PhoneCode = "+855"},
                new  Country { CountryEnumId=38 , Code = "CM", Name = "Cameroon", PhoneCode = "+237"},
                new  Country { CountryEnumId=39 , Code = "KY", Name = "Cayman Islands", PhoneCode = "+1"},
                new  Country { CountryEnumId=40 , Code = "CA", Name = "Canada",  PhoneCode = "+1"},
                new  Country { CountryEnumId=41 , Code = "CV", Name = "Cape Verde", PhoneCode = "+238"},
                new  Country { CountryEnumId=42 , Code = "CF", Name = "Central African Republic", PhoneCode = "+236"},
                new  Country { CountryEnumId=43 , Code = "TD", Name = "Chad", PhoneCode = "+235"},
                new  Country { CountryEnumId=44 , Code = "CL", Name = "Chile", PhoneCode = "+56"},
                new  Country { CountryEnumId=45 , Code = "CN", Name = "China", PhoneCode = "+86"},
                new  Country { CountryEnumId=46 , Code = "CX", Name = "Christmas Island", PhoneCode = "+61"},
                new  Country { CountryEnumId=47 , Code = "CC", Name = "Cocos (Keeling}, Islands", PhoneCode = "+61"},
                new  Country { CountryEnumId=48 , Code = "CO", Name = "Colombia", PhoneCode = "+57"},
                new  Country { CountryEnumId=49 , Code = "KM", Name = "Comoros", PhoneCode = "+269"},
                new  Country { CountryEnumId=50 , Code = "CG", Name = "Congo", PhoneCode = "+242"},
                new  Country { CountryEnumId=51 , Code = "CD", Name = "The Democratic Republic Of The Congo", PhoneCode = "+243"},
                new  Country { CountryEnumId=52 , Code = "CK", Name = "Cook Islands", PhoneCode = "+682"},
                new  Country { CountryEnumId=53 , Code = "CR", Name = "Costa Rica", PhoneCode = "+506"},
                new  Country { CountryEnumId=54 , Code = "HR", Name = "Croatia",PhoneCode = "+385"},
                new  Country { CountryEnumId=55 , Code = "CU", Name = "Cuba", PhoneCode = "+53"},
                new  Country { CountryEnumId=56 , Code = "CW", Name = "Curaçao", PhoneCode = "+599"},
                new  Country { CountryEnumId=57 , Code = "CY", Name = "Cyprus", PhoneCode = "+357"},
                new  Country { CountryEnumId=58 , Code = "CZ", Name = "Czech Republic", PhoneCode = "+420"},
                new  Country { CountryEnumId=59 , Code = "DK", Name = "Denmark",  PhoneCode = "+45"},
                new  Country { CountryEnumId=60 , Code = "DJ", Name = "Djibouti",PhoneCode = "+253"},
                new  Country { CountryEnumId=61 , Code = "DM", Name = "Dominica", PhoneCode = "+1"},
                new  Country { CountryEnumId=62 , Code = "DO", Name = "Dominican Republic", PhoneCode = "+1"},
                new  Country { CountryEnumId=63 , Code = "EC", Name = "Ecuador", PhoneCode = "+593"},
                new  Country { CountryEnumId=64 , Code = "EG", Name = "Egypt", PhoneCode = "+20"},
                new  Country { CountryEnumId=65 , Code = "SV", Name = "El Salvador", PhoneCode = "+503"},
                new  Country { CountryEnumId=66 , Code = "GQ", Name = "Equatorial Guinea", PhoneCode = "+240"},
                new  Country { CountryEnumId=67 , Code = "ER", Name = "Eritrea", PhoneCode = "+291"},
                new  Country { CountryEnumId=68 , Code = "EE", Name = "Estonia",  PhoneCode = "+372"},
                new  Country { CountryEnumId=69 , Code = "ET", Name = "Ethiopia", PhoneCode = "+251"},
                new  Country { CountryEnumId=70 , Code = "FK", Name = "Falkland Islands", PhoneCode = "+500"},
                new  Country { CountryEnumId=71 , Code = "FO", Name = "Faroe Islands",PhoneCode = "+298"},
                new  Country { CountryEnumId=72 , Code = "FJ", Name = "Fiji", PhoneCode = "+679"},
                new  Country { CountryEnumId=73 , Code = "FI", Name = "Finland", PhoneCode = "+358"},
                new  Country { CountryEnumId=74 , Code = "FR", Name = "France", PhoneCode = "+33"},
                new  Country { CountryEnumId=75 , Code = "GF", Name = "French Guiana", PhoneCode = "+594"},
                new  Country { CountryEnumId=76 , Code = "TF", Name = "French Southern and Antarctic Lands", PhoneCode = "+262"},
                new  Country { CountryEnumId=77 , Code = "GA", Name = "Gabon", PhoneCode = "+241"},
                new  Country { CountryEnumId=78 , Code = "GM", Name = "Gambia", PhoneCode = "+220"},
                new  Country { CountryEnumId=79 , Code = "GE", Name = "Georgia", PhoneCode = "+995"},
                new  Country { CountryEnumId=80 , Code = "DE", Name = "Germany",  PhoneCode = "+49"},
                new  Country { CountryEnumId=81 , Code = "GH", Name = "Ghana", PhoneCode = "+233"},
                new  Country { CountryEnumId=82 , Code = "GI", Name = "Gibraltar", PhoneCode = "+350"},
                new  Country { CountryEnumId=83 , Code = "GB", Name = "United Kingdom", PhoneCode = "+44"},
                new  Country { CountryEnumId=84 , Code = "GR", Name = "Greece", PhoneCode = "+30"},
                new  Country { CountryEnumId=85 , Code = "GL", Name = "Greenland", PhoneCode = "+299"},
                new  Country { CountryEnumId=86 , Code = "GD", Name = "Grenada", PhoneCode = "+1"},
                new  Country { CountryEnumId=87 , Code = "GP", Name = "Guadeloupe", PhoneCode = "+590"},
                new  Country { CountryEnumId=88 , Code = "GU", Name = "Guam", PhoneCode = "+1"},
                new  Country { CountryEnumId=89 , Code = "GT", Name = "Guatemala", PhoneCode = "+502"},
                new  Country { CountryEnumId=90 , Code = "GG", Name = "Bailiwick of Guernsey", PhoneCode = "+44"},
                new  Country { CountryEnumId=91 , Code = "GN", Name = "Guinea", PhoneCode = "+224"},
                new  Country { CountryEnumId=92 , Code = "GW", Name = "Guinea-Bissau", PhoneCode = "+245"},
                new  Country { CountryEnumId=93 , Code = "GY", Name = "Guyana", PhoneCode = "+592"},
                new  Country { CountryEnumId=94 , Code = "HT", Name = "Haiti", PhoneCode = "+509"},
                new  Country { CountryEnumId=95 , Code = "VA", Name = "Vatican City", PhoneCode = "+39"},
                new  Country { CountryEnumId=96 , Code = "HN", Name = "Honduras", PhoneCode = "+504"},
                new  Country { CountryEnumId=97 , Code = "HK", Name = "Hong Kong", PhoneCode = "+852"},
                new  Country { CountryEnumId=98 , Code = "HU", Name = "Hungary", PhoneCode = "+36"},
                new  Country { CountryEnumId=99 , Code = "IS", Name = "Iceland", PhoneCode = "+354"},
                new  Country { CountryEnumId=100, Code = "IN", Name = "India", PhoneCode = "+91"},
                new  Country { CountryEnumId=101, Code = "ID", Name = "Indonesia", PhoneCode = "+62"},
                new  Country { CountryEnumId=102, Code = "IR", Name = "Iran", PhoneCode = "+98"},
                new  Country { CountryEnumId=103, Code = "IQ", Name = "Iraq", PhoneCode = "+964"},
                new  Country { CountryEnumId=104, Code = "IE", Name = "Ireland", PhoneCode = "+353"},
                new  Country { CountryEnumId=105, Code = "IM", Name = "Isle of Man", PhoneCode = "+44"},
                new  Country { CountryEnumId=106, Code = "IL", Name = "Israel", PhoneCode = "+972"},
                new  Country { CountryEnumId=107, Code = "IT", Name = "Italy", PhoneCode = "+39"},
                new  Country { CountryEnumId=108, Code = "CI", Name = "Côte D'ivoire",  PhoneCode = "+225"},
                new  Country { CountryEnumId=109, Code = "JM", Name = "Jamaica", PhoneCode = "+1"},
                new  Country { CountryEnumId=110, Code = "JP", Name = "Japan",  PhoneCode = "+81"},
                new  Country { CountryEnumId=111, Code = "JE", Name = "Bailiwick of Jersey", PhoneCode = "+44"},
                new  Country { CountryEnumId=112, Code = "JO", Name = "Jordan",PhoneCode = "+962"},
                new  Country { CountryEnumId=113, Code = "KZ", Name = "Kazakhstan", PhoneCode = "+7"},
                new  Country { CountryEnumId=114, Code = "KE", Name = "Kenya", PhoneCode = "+254"},
                new  Country { CountryEnumId=115, Code = "KI", Name = "Kiribati", PhoneCode = "+686"},
                new  Country { CountryEnumId=116, Code = "KW", Name = "Kuwait",  PhoneCode = "+965"},
                new  Country { CountryEnumId=117, Code = "KG", Name = "Kyrgyzstan",  PhoneCode = "+996"},
                new  Country { CountryEnumId=118, Code = "LA", Name = "Lao People's Democratic Republic", PhoneCode = "+856"},
                new  Country { CountryEnumId=119, Code = "LV", Name = "Latvia", PhoneCode = "+371"},
                new  Country { CountryEnumId=120, Code = "LB", Name = "Lebanon",  PhoneCode = "+961"},
                new  Country { CountryEnumId=121, Code = "LS", Name = "Lesotho", PhoneCode = "+266"},
                new  Country { CountryEnumId=122, Code = "LR", Name = "Liberia", PhoneCode = "+231"},
                new  Country { CountryEnumId=123, Code = "LY", Name = "Libya", PhoneCode = "+218"},
                new  Country { CountryEnumId=124, Code = "LI", Name = "Liechtenstein", PhoneCode = "+423"},
                new  Country { CountryEnumId=125, Code = "LT", Name = "Lithuania", PhoneCode = "+370"},
                new  Country { CountryEnumId=126, Code = "LU", Name = "Luxembourg", PhoneCode = "+352"},
                new  Country { CountryEnumId=127, Code = "MO", Name = "Macao", PhoneCode = "+853"},
                new  Country { CountryEnumId=128, Code = "MK", Name = "Macedonia", PhoneCode = "+389"},
                new  Country { CountryEnumId=129, Code = "MG", Name = "Madagascar", PhoneCode = "+261"},
                new  Country { CountryEnumId=130, Code = "MW", Name = "Malawi", PhoneCode = "+265"},
                new  Country { CountryEnumId=131, Code = "MY", Name = "Malaysia", PhoneCode = "+60"},
                new  Country { CountryEnumId=132, Code = "MV", Name = "Maldives", PhoneCode = "+960"},
                new  Country { CountryEnumId=133, Code = "ML", Name = "Mali", PhoneCode = "+223"},
                new  Country { CountryEnumId=134, Code = "MT", Name = "Malta", PhoneCode = "+356"},
                new  Country { CountryEnumId=135, Code = "MH", Name = "Marshall Islands", PhoneCode = "+692"},
                new  Country { CountryEnumId=136, Code = "MQ", Name = "Martinique", PhoneCode = "+596"},
                new  Country { CountryEnumId=137, Code = "MR", Name = "Mauritania", PhoneCode = "+222"},
                new  Country { CountryEnumId=138, Code = "MU", Name = "Mauritius", PhoneCode = "+230"},
                new  Country { CountryEnumId=139, Code = "YT", Name = "Mayotte", PhoneCode = "+262"},
                new  Country { CountryEnumId=140, Code = "MX", Name = "Mexico", PhoneCode = "+52"},
                new  Country { CountryEnumId=141, Code = "FM", Name = "Federated States Of Micronesia", PhoneCode = "+691"},
                new  Country { CountryEnumId=142, Code = "MD", Name = "Moldova", PhoneCode = "+373"},
                new  Country { CountryEnumId=143, Code = "MC", Name = "Monaco", PhoneCode = "+377"},
                new  Country { CountryEnumId=144, Code = "MN", Name = "Mongolia", PhoneCode = "+976"},
                new  Country { CountryEnumId=145, Code = "ME", Name = "Montenegro", PhoneCode = "+382"},
                new  Country { CountryEnumId=146, Code = "MS", Name = "Montserrat", PhoneCode = "+1"},
                new  Country { CountryEnumId=147, Code = "MA", Name = "Morocco",PhoneCode = "+212"},
                new  Country { CountryEnumId=148, Code = "MZ", Name = "Mozambique", PhoneCode = "+258"},
                new  Country { CountryEnumId=149, Code = "MM", Name = "Myanmar", PhoneCode = "+95"},
                new  Country { CountryEnumId=150, Code = "NA", Name = "Namibia", PhoneCode = "+264"},
                new  Country { CountryEnumId=151, Code = "NR", Name = "Nauru", PhoneCode = "+674"},
                new  Country { CountryEnumId=152, Code = "NP", Name = "Nepal", PhoneCode = "+977"},
                new  Country { CountryEnumId=153, Code = "NL", Name = "Netherlands", PhoneCode = "+31"},
                new  Country { CountryEnumId=154, Code = "NC", Name = "New Caledonia",  PhoneCode = "+687"},
                new  Country { CountryEnumId=155, Code = "NZ", Name = "New Zealand", PhoneCode = "+64"},
                new  Country { CountryEnumId=156, Code = "NI", Name = "Nicaragua", PhoneCode = "+505"},
                new  Country { CountryEnumId=157, Code = "NE", Name = "Niger", PhoneCode = "+227"},
                new  Country { CountryEnumId=158, Code = "NG", Name = "Nigeria", PhoneCode = "+234"},
                new  Country { CountryEnumId=159, Code = "NU", Name = "Niue", PhoneCode = "+683"},
                new  Country { CountryEnumId=160, Code = "NF", Name = "Norfolk Island", PhoneCode = "+672"},
                new  Country { CountryEnumId=161, Code = "MP", Name = "Mariana Islands", PhoneCode = "+1"},
                new  Country { CountryEnumId=162, Code = "KP", Name = "North Korea", PhoneCode = "+850"},
                new  Country { CountryEnumId=163, Code = "NO", Name = "Norway",PhoneCode = "+47"},
                new  Country { CountryEnumId=164, Code = "OM", Name = "Oman",  PhoneCode = "+968"},
                new  Country { CountryEnumId=165, Code = "PK", Name = "Pakistan", PhoneCode = "+92"},
                new  Country { CountryEnumId=166, Code = "PW", Name = "Palau", PhoneCode = "+680"},
                new  Country { CountryEnumId=167, Code = "PS", Name = "Palestine", PhoneCode = "+970"},
                new  Country { CountryEnumId=168, Code = "PA", Name = "Panama", PhoneCode = "+507"},
                new  Country { CountryEnumId=169, Code = "PG", Name = "Papua New Guinea",PhoneCode = "+675"},
                new  Country { CountryEnumId=170, Code = "PY", Name = "Paraguay", PhoneCode = "+595"},
                new  Country { CountryEnumId=171, Code = "PE", Name = "Peru", PhoneCode = "+51"},
                new  Country { CountryEnumId=172, Code = "PH", Name = "Philippines", PhoneCode = "+63"},
                new  Country { CountryEnumId=173, Code = "PN", Name = "Pitcairn", PhoneCode = "+870"},
                new  Country { CountryEnumId=174, Code = "PL", Name = "Poland", PhoneCode = "+48"},
                new  Country { CountryEnumId=175, Code = "PF", Name = "French Polynesia", PhoneCode = "+689"},
                new  Country { CountryEnumId=176, Code = "PT", Name = "Portugal",  PhoneCode = "+351"},
                new  Country { CountryEnumId=177, Code = "PR", Name = "Puerto Rico", PhoneCode = "+1"},
                new  Country { CountryEnumId=178, Code = "QA", Name = "Qatar", PhoneCode = "+974"},
                new  Country { CountryEnumId=179, Code = "RE", Name = "Réunion", PhoneCode = "+262"},
                new  Country { CountryEnumId=180, Code = "RO", Name = "Romania", PhoneCode = "+40"},
                new  Country { CountryEnumId=181, Code = "RU", Name = "Russian Federation",  PhoneCode = "+7"},
                new  Country { CountryEnumId=182, Code = "RW", Name = "Rwanda", PhoneCode = "+250"},
                new  Country { CountryEnumId=183, Code = "BL", Name = "Saint Barthélemy", PhoneCode = "+590"},
                new  Country { CountryEnumId=184, Code = "SH", Name = "Saint Helena",PhoneCode = "+290"},
                new  Country { CountryEnumId=185, Code = "KN", Name = "Saint Kitts and Nevis", PhoneCode = "+1"},
                new  Country { CountryEnumId=186, Code = "LC", Name = "Saint Lucia", PhoneCode = "+1"},
                new  Country { CountryEnumId=187, Code = "MF", Name = "Saint Martin", PhoneCode = "+590"},
                new  Country { CountryEnumId=188, Code = "PM", Name = "Saint Pierre And Miquelon", PhoneCode = "+508"},
                new  Country { CountryEnumId=189, Code = "VC", Name = "Saint Vincent and the Grenadines", PhoneCode = "+1"},
                new  Country { CountryEnumId=190, Code = "ST", Name = "Sao Tome And Principe", PhoneCode = "+239"},
                new  Country { CountryEnumId=191, Code = "WS", Name = "Samoa", PhoneCode = "+685"},
                new  Country { CountryEnumId=192, Code = "SM", Name = "San Marino", PhoneCode = "+378"},
                new  Country { CountryEnumId=193, Code = "SA", Name = "Saudi Arabia", PhoneCode = "+966"},
                new  Country { CountryEnumId=194, Code = "SN", Name = "Senegal", PhoneCode = "+221"},
                new  Country { CountryEnumId=195, Code = "RS", Name = "Serbia", PhoneCode = "+381"},
                new  Country { CountryEnumId=196, Code = "SC", Name = "Seychelles", PhoneCode = "+248"},
                new  Country { CountryEnumId=197, Code = "SL", Name = "Sierra Leone", PhoneCode = "+232"},
                new  Country { CountryEnumId=198, Code = "SG", Name = "Singapore", PhoneCode = "+65"},
                new  Country { CountryEnumId=199, Code = "SX", Name = "Sint Maarten", PhoneCode = "+1"},
                new  Country { CountryEnumId=200, Code = "SK", Name = "Slovakia", PhoneCode = "+421"},
                new  Country { CountryEnumId=201, Code = "SI", Name = "Slovenia", PhoneCode = "+386"},
                new  Country { CountryEnumId=202, Code = "SB", Name = "Solomon Islands", PhoneCode = "+677"},
                new  Country { CountryEnumId=203, Code = "SO", Name = "Somalia",  PhoneCode = "+252"},
                new  Country { CountryEnumId=204, Code = "ZA", Name = "South Africa", PhoneCode = "+27"},
                new  Country { CountryEnumId=205, Code = "GS", Name = "South Georgia and the South Sandwich Islands", PhoneCode = "+500"},
                new  Country { CountryEnumId=206, Code = "SS", Name = "South Sudan", PhoneCode = "+211"},
                new  Country { CountryEnumId=207, Code = "KR", Name = "South Korea",  PhoneCode = "+82"},
                new  Country { CountryEnumId=208, Code = "ES", Name = "Spain", PhoneCode = "+34"},
                new  Country { CountryEnumId=209, Code = "LK", Name = "Sri Lanka", PhoneCode = "+94"},
                new  Country { CountryEnumId=210, Code = "SD", Name = "Sudan", PhoneCode = "+249"},
                new  Country { CountryEnumId=211, Code = "SR", Name = "Suriname", PhoneCode = "+597"},
                new  Country { CountryEnumId=212, Code = "SJ", Name = "Svalbard and Jan Mayen", PhoneCode = "+47"},
                new  Country { CountryEnumId=213, Code = "SZ", Name = "Swaziland", PhoneCode = "+268"},
                new  Country { CountryEnumId=214, Code = "SE", Name = "Sweden", PhoneCode = "+46"},
                new  Country { CountryEnumId=215, Code = "CH", Name = "Switzerland", PhoneCode = "+41"},
                new  Country { CountryEnumId=216, Code = "SY", Name = "Syrian Arab Republic", PhoneCode = "+963"},
                new  Country { CountryEnumId=217, Code = "TJ", Name = "Tajikistan", PhoneCode = "+992"},
                new  Country { CountryEnumId=218, Code = "TW", Name = "Taiwan, Province Of China", PhoneCode = "+886"},
                new  Country { CountryEnumId=219, Code = "TZ", Name = "United Republic Of Tanzania", PhoneCode = "+255"},
                new  Country { CountryEnumId=220, Code = "TH", Name = "Thailand", PhoneCode = "+66"},
                new  Country { CountryEnumId=221, Code = "TL", Name = "Timor-Leste", PhoneCode = "+670"},
                new  Country { CountryEnumId=222, Code = "TG", Name = "Togo", PhoneCode = "+228"},
                new  Country { CountryEnumId=223, Code = "TK", Name = "Tokelau", PhoneCode = "+690"},
                new  Country { CountryEnumId=224, Code = "TO", Name = "Tonga", PhoneCode = "+676"},
                new  Country { CountryEnumId=225, Code = "TT", Name = "Trinidad and Tobago", PhoneCode = "+1"},
                new  Country { CountryEnumId=226, Code = "TN", Name = "Tunisia", PhoneCode = "+216"},
                new  Country { CountryEnumId=227, Code = "TR", Name = "Turkey", PhoneCode = "+90"},
                new  Country { CountryEnumId=228, Code = "TM", Name = "Turkmenistan", PhoneCode = "+993"},
                new  Country { CountryEnumId=229, Code = "TV", Name = "Tuvalu",  PhoneCode = "+688"},
                new  Country { CountryEnumId=230, Code = "UG", Name = "Uganda", PhoneCode = "+256"},
                new  Country { CountryEnumId=231, Code = "UA", Name = "Ukraine",PhoneCode = "+380"},
                new  Country { CountryEnumId=232, Code = "AE", Name = "United Arab Emirates",  PhoneCode = "+971"},
                new  Country { CountryEnumId=233, Code = "US", Name = "United States", PhoneCode = "+1"},
                new  Country { CountryEnumId=234, Code = "UM", Name = " United States Minor Outlying Islands", PhoneCode = "+1"},
                new  Country { CountryEnumId=235, Code = "UY", Name = "Uruguay",  PhoneCode = "+598"},
                new  Country { CountryEnumId=236, Code = "UZ", Name = "Uzbekistan", PhoneCode = "+998"},
                new  Country { CountryEnumId=237, Code = "VU", Name = "Vanuatu", PhoneCode = "+678"},
                new  Country { CountryEnumId=238, Code = "VE", Name = "Bolivarian Republic Of Venezuela", PhoneCode = "+58"},
                new  Country { CountryEnumId=239, Code = "VN", Name = "Viet Nam", PhoneCode = "+84"},
                new  Country { CountryEnumId=240, Code = "WF", Name = "Wallis And Futuna", PhoneCode = "+681"},
                new  Country { CountryEnumId=241, Code = "EH", Name = "Western Sahara", PhoneCode = "+212"},
                new  Country { CountryEnumId=242, Code = "YE", Name = "Yemen",  PhoneCode = "+967"},
                new  Country { CountryEnumId=243, Code = "ZM", Name = "Zambia", PhoneCode = "+260"},
                new  Country { CountryEnumId=244, Code = "ZW", Name = "Zimbabwe", PhoneCode = "+263"}

            };
        }
    }
}