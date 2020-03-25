using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CovidSharp;

namespace Covid_19Sharp
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
        }

        private void load_countries()
        {
            Dictionary<string, string> CountriesList = new Dictionary<string, string>();

            CountriesList.Add("AF", "Afghanistan");
            CountriesList.Add("AL", "Albania");
            CountriesList.Add("DZ", "Algeria");
            CountriesList.Add("AS", "American Samoa");
            CountriesList.Add("AD", "Andorra");
            CountriesList.Add("AO", "Angola");
            CountriesList.Add("AI", "Anguilla");
            CountriesList.Add("AQ", "Antarctica");
            CountriesList.Add("AG", "Antigua and Barbuda");
            CountriesList.Add("AR", "Argentina");
            CountriesList.Add("AM", "Armenia");
            CountriesList.Add("AW", "Aruba");
            CountriesList.Add("AU", "Australia");
            CountriesList.Add("AT", "Austria");
            CountriesList.Add("AZ", "Azerbaijan");
            CountriesList.Add("BS", "Bahamas (the)");
            CountriesList.Add("BH", "Bahrain");
            CountriesList.Add("BD", "Bangladesh");
            CountriesList.Add("BB", "Barbados");
            CountriesList.Add("BY", "Belarus");
            CountriesList.Add("BE", "Belgium");
            CountriesList.Add("BZ", "Belize");
            CountriesList.Add("BJ", "Benin");
            CountriesList.Add("BM", "Bermuda");
            CountriesList.Add("BT", "Bhutan");
            CountriesList.Add("BO", "Bolivia (Plurinational State of)");
            CountriesList.Add("BQ", "Bonaire, Sint Eustatius and Saba");
            CountriesList.Add("BA", "Bosnia and Herzegovina");
            CountriesList.Add("BW", "Botswana");
            CountriesList.Add("BV", "Bouvet Island");
            CountriesList.Add("BR", "Brazil");
            CountriesList.Add("IO", "British Indian Ocean Territory (the)");
            CountriesList.Add("BN", "Brunei Darussalam");
            CountriesList.Add("BG", "Bulgaria");
            CountriesList.Add("BF", "Burkina Faso");
            CountriesList.Add("BI", "Burundi");
            CountriesList.Add("CV", "Cabo Verde");
            CountriesList.Add("KH", "Cambodia");
            CountriesList.Add("CM", "Cameroon");
            CountriesList.Add("CA", "Canada");
            CountriesList.Add("KY", "Cayman Islands (the)");
            CountriesList.Add("CF", "Central African Republic (the)");
            CountriesList.Add("TD", "Chad");
            CountriesList.Add("CL", "Chile");
            CountriesList.Add("CN", "China");
            CountriesList.Add("CX", "Christmas Island");
            CountriesList.Add("CC", "Cocos (Keeling) Islands (the)");
            CountriesList.Add("CO", "Colombia");
            CountriesList.Add("KM", "Comoros (the)");
            CountriesList.Add("CD", "Congo (the Democratic Republic of the)");
            CountriesList.Add("CG", "Congo (the)");
            CountriesList.Add("CK", "Cook Islands (the)");
            CountriesList.Add("CR", "Costa Rica");
            CountriesList.Add("HR", "Croatia");
            CountriesList.Add("CU", "Cuba");
            CountriesList.Add("CW", "Curaçao");
            CountriesList.Add("CY", "Cyprus");
            CountriesList.Add("CZ", "Czechia");
            CountriesList.Add("CI", "Côte d'Ivoire");
            CountriesList.Add("DK", "Denmark");
            CountriesList.Add("DJ", "Djibouti");
            CountriesList.Add("DM", "Dominica");
            CountriesList.Add("DO", "Dominican Republic (the)");
            CountriesList.Add("EC", "Ecuador");
            CountriesList.Add("EG", "Egypt");
            CountriesList.Add("SV", "El Salvador");
            CountriesList.Add("GQ", "Equatorial Guinea");
            CountriesList.Add("ER", "Eritrea");
            CountriesList.Add("EE", "Estonia");
            CountriesList.Add("SZ", "Eswatini");
            CountriesList.Add("ET", "Ethiopia");
            CountriesList.Add("FK", "Falkland Islands (the) [Malvinas]");
            CountriesList.Add("FO", "Faroe Islands (the)");
            CountriesList.Add("FJ", "Fiji");
            CountriesList.Add("FI", "Finland");
            CountriesList.Add("FR", "France");
            CountriesList.Add("GF", "French Guiana");
            CountriesList.Add("PF", "French Polynesia");
            CountriesList.Add("TF", "French Southern Territories (the)");
            CountriesList.Add("GA", "Gabon");
            CountriesList.Add("GM", "Gambia (the)");
            CountriesList.Add("GE", "Georgia");
            CountriesList.Add("DE", "Germany");
            CountriesList.Add("GH", "Ghana");
            CountriesList.Add("GI", "Gibraltar");
            CountriesList.Add("GR", "Greece");
            CountriesList.Add("GL", "Greenland");
            CountriesList.Add("GD", "Grenada");
            CountriesList.Add("GP", "Guadeloupe");
            CountriesList.Add("GU", "Guam");
            CountriesList.Add("GT", "Guatemala");
            CountriesList.Add("GG", "Guernsey");
            CountriesList.Add("GN", "Guinea");
            CountriesList.Add("GW", "Guinea-Bissau");
            CountriesList.Add("GY", "Guyana");
            CountriesList.Add("HT", "Haiti");
            CountriesList.Add("HM", "Heard Island and McDonald Islands");
            CountriesList.Add("VA", "Holy See (the)");
            CountriesList.Add("HN", "Honduras");
            CountriesList.Add("HK", "Hong Kong");
            CountriesList.Add("HU", "Hungary");
            CountriesList.Add("IS", "Iceland");
            CountriesList.Add("IN", "India");
            CountriesList.Add("ID", "Indonesia");
            CountriesList.Add("IR", "Iran (Islamic Republic of)");
            CountriesList.Add("IQ", "Iraq");
            CountriesList.Add("IE", "Ireland");
            CountriesList.Add("IM", "Isle of Man");
            CountriesList.Add("IL", "Israel");
            CountriesList.Add("IT", "Italy");
            CountriesList.Add("JM", "Jamaica");
            CountriesList.Add("JP", "Japan");
            CountriesList.Add("JE", "Jersey");
            CountriesList.Add("JO", "Jordan");
            CountriesList.Add("KZ", "Kazakhstan");
            CountriesList.Add("KE", "Kenya");
            CountriesList.Add("KI", "Kiribati");
            CountriesList.Add("KP", "Korea (the Democratic People's Republic of)");
            CountriesList.Add("KR", "Korea (the Republic of)");
            CountriesList.Add("KW", "Kuwait");
            CountriesList.Add("KG", "Kyrgyzstan");
            CountriesList.Add("LA", "Lao People's Democratic Republic (the)");
            CountriesList.Add("LV", "Latvia");
            CountriesList.Add("LB", "Lebanon");
            CountriesList.Add("LS", "Lesotho");
            CountriesList.Add("LR", "Liberia");
            CountriesList.Add("LY", "Libya");
            CountriesList.Add("LI", "Liechtenstein");
            CountriesList.Add("LT", "Lithuania");
            CountriesList.Add("LU", "Luxembourg");
            CountriesList.Add("MO", "Macao");
            CountriesList.Add("MG", "Madagascar");
            CountriesList.Add("MW", "Malawi");
            CountriesList.Add("MY", "Malaysia");
            CountriesList.Add("MV", "Maldives");
            CountriesList.Add("ML", "Mali");
            CountriesList.Add("MT", "Malta");
            CountriesList.Add("MH", "Marshall Islands (the)");
            CountriesList.Add("MQ", "Martinique");
            CountriesList.Add("MR", "Mauritania");
            CountriesList.Add("MU", "Mauritius");
            CountriesList.Add("YT", "Mayotte");
            CountriesList.Add("MX", "Mexico");
            CountriesList.Add("FM", "Micronesia (Federated States of)");
            CountriesList.Add("MD", "Moldova (the Republic of)");
            CountriesList.Add("MC", "Monaco");
            CountriesList.Add("MN", "Mongolia");
            CountriesList.Add("ME", "Montenegro");
            CountriesList.Add("MS", "Montserrat");
            CountriesList.Add("MA", "Morocco");
            CountriesList.Add("MZ", "Mozambique");
            CountriesList.Add("MM", "Myanmar");
            CountriesList.Add("NA", "Namibia");
            CountriesList.Add("NR", "Nauru");
            CountriesList.Add("NP", "Nepal");
            CountriesList.Add("NL", "Netherlands (the)");
            CountriesList.Add("NC", "New Caledonia");
            CountriesList.Add("NZ", "New Zealand");
            CountriesList.Add("NI", "Nicaragua");
            CountriesList.Add("NE", "Niger (the)");
            CountriesList.Add("NG", "Nigeria");
            CountriesList.Add("NU", "Niue");
            CountriesList.Add("NF", "Norfolk Island");
            CountriesList.Add("MP", "Northern Mariana Islands (the)");
            CountriesList.Add("NO", "Norway");
            CountriesList.Add("OM", "Oman");
            CountriesList.Add("PK", "Pakistan");
            CountriesList.Add("PW", "Palau");
            CountriesList.Add("PS", "Palestine, State of");
            CountriesList.Add("PA", "Panama");
            CountriesList.Add("PG", "Papua New Guinea");
            CountriesList.Add("PY", "Paraguay");
            CountriesList.Add("PE", "Peru");
            CountriesList.Add("PH", "Philippines (the)");
            CountriesList.Add("PN", "Pitcairn");
            CountriesList.Add("PL", "Poland");
            CountriesList.Add("PT", "Portugal");
            CountriesList.Add("PR", "Puerto Rico");
            CountriesList.Add("QA", "Qatar");
            CountriesList.Add("MK", "Republic of North Macedonia");
            CountriesList.Add("RO", "Romania");
            CountriesList.Add("RU", "Russian Federation (the)");
            CountriesList.Add("RW", "Rwanda");
            CountriesList.Add("RE", "Réunion");
            CountriesList.Add("BL", "Saint Barthélemy");
            CountriesList.Add("SH", "Saint Helena, Ascension and Tristan da Cunha");
            CountriesList.Add("KN", "Saint Kitts and Nevis");
            CountriesList.Add("LC", "Saint Lucia");
            CountriesList.Add("MF", "Saint Martin (French part)");
            CountriesList.Add("PM", "Saint Pierre and Miquelon");
            CountriesList.Add("VC", "Saint Vincent and the Grenadines");
            CountriesList.Add("WS", "Samoa");
            CountriesList.Add("SM", "San Marino");
            CountriesList.Add("ST", "Sao Tome and Principe");
            CountriesList.Add("SA", "Saudi Arabia");
            CountriesList.Add("SN", "Senegal");
            CountriesList.Add("RS", "Serbia");
            CountriesList.Add("SC", "Seychelles");
            CountriesList.Add("SL", "Sierra Leone");
            CountriesList.Add("SG", "Singapore");
            CountriesList.Add("SX", "Sint Maarten (Dutch part)");
            CountriesList.Add("SK", "Slovakia");
            CountriesList.Add("SI", "Slovenia");
            CountriesList.Add("SB", "Solomon Islands");
            CountriesList.Add("SO", "Somalia");
            CountriesList.Add("ZA", "South Africa");
            CountriesList.Add("GS", "South Georgia and the South Sandwich Islands");
            CountriesList.Add("SS", "South Sudan");
            CountriesList.Add("ES", "Spain");
            CountriesList.Add("LK", "Sri Lanka");
            CountriesList.Add("SD", "Sudan (the)");
            CountriesList.Add("SR", "Suriname");
            CountriesList.Add("SJ", "Svalbard and Jan Mayen");
            CountriesList.Add("SE", "Sweden");
            CountriesList.Add("CH", "Switzerland");
            CountriesList.Add("SY", "Syrian Arab Republic");
            CountriesList.Add("TW", "Taiwan (Province of China)");
            CountriesList.Add("TJ", "Tajikistan");
            CountriesList.Add("TZ", "Tanzania, United Republic of");
            CountriesList.Add("TH", "Thailand");
            CountriesList.Add("TL", "Timor-Leste");
            CountriesList.Add("TG", "Togo");
            CountriesList.Add("TK", "Tokelau");
            CountriesList.Add("TO", "Tonga");
            CountriesList.Add("TT", "Trinidad and Tobago");
            CountriesList.Add("TN", "Tunisia");
            CountriesList.Add("TR", "Turkey");
            CountriesList.Add("TM", "Turkmenistan");
            CountriesList.Add("TC", "Turks and Caicos Islands (the)");
            CountriesList.Add("TV", "Tuvalu");
            CountriesList.Add("UG", "Uganda");
            CountriesList.Add("UA", "Ukraine");
            CountriesList.Add("AE", "United Arab Emirates (the)");
            CountriesList.Add("GB", "United Kingdom of Great Britain and Northern Ireland (the)");
            CountriesList.Add("UM", "United States Minor Outlying Islands (the)");
            CountriesList.Add("US", "United States of America (the)");
            CountriesList.Add("UY", "Uruguay");
            CountriesList.Add("UZ", "Uzbekistan");
            CountriesList.Add("VU", "Vanuatu");
            CountriesList.Add("VE", "Venezuela (Bolivarian Republic of)");
            CountriesList.Add("VN", "Viet Nam");
            CountriesList.Add("VG", "Virgin Islands (British)");
            CountriesList.Add("VI", "Virgin Islands (U.S.)");
            CountriesList.Add("WF", "Wallis and Futuna");
            CountriesList.Add("EH", "Western Sahara");
            CountriesList.Add("YE", "Yemen");
            CountriesList.Add("ZM", "Zambia");
            CountriesList.Add("ZW", "Zimbabwe");
            CountriesList.Add("AX", "Åland Islands");


            cbcountry.DataSource = new BindingSource(CountriesList, null);
            cbcountry.DisplayMember = "Value";
            cbcountry.ValueMember = "Key";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CoronavirusData data = new CoronavirusData();

            txtResults.Text = "";

            txtResults.Text += DateTime.Now.ToString();
            txtResults.Text += "\r\n";
            txtResults.Text += "\r\n";

            txtResults.Text += "Global";
            txtResults.Text += "\r\n";
            txtResults.Text += "~~~~";
            txtResults.Text += "\r\n";
            txtResults.Text += "Confirmed: ";
            txtResults.Text += data.LatestConfirmed() + "\r\n";

            txtResults.Text += "Recovered: ";
            txtResults.Text += data.LatestRecovered() + "\r\n";

            txtResults.Text += "Deaths: ";
            txtResults.Text += data.LatestDeaths() + "\r\n";
            txtResults.Text += "\r\n";

            txtResults.Text += "Country - " + cbcountry.SelectedValue.ToString();
            txtResults.Text += "\r\n";
            txtResults.Text += "~~~~~~~~~";
            txtResults.Text += "\r\n";

            txtResults.Text += cbcountry.SelectedValue.ToString();
            txtResults.Text += " Confirmed: ";
            txtResults.Text += data.FromCountryConfirmed(cbcountry.SelectedValue.ToString()) + "\r\n";

            txtResults.Text += cbcountry.SelectedValue.ToString();
            txtResults.Text += " Recovered: ";
            txtResults.Text += data.FromCountryRecovered(cbcountry.SelectedValue.ToString()) + "\r\n";

            txtResults.Text += cbcountry.SelectedValue.ToString();
            txtResults.Text += " Deaths: ";
            txtResults.Text += data.FromCountryDeaths(cbcountry.SelectedValue.ToString()) + "\r\n";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            load_countries();
            cbcountry.SelectedIndex = cbcountry.FindStringExact("Greece");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

 
}
