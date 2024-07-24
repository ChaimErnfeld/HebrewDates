using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.LinkLabel;


namespace HebrewDates
{
    public partial class Form1 : Form
    {
        //יצירת משתנה מסוג xmlDocument
        XmlDocument xmlDocument = new XmlDocument();
        //יצירת נתיב ראשי שיכיל את הקובץ של השאילתות
        string pathName = Directory.GetCurrentDirectory() + "\\hebrewDates.xml";
        //יצירת משתנה שיכיל את הכתיבה ההלכתית
        string result = "";
        public Form1()
        {
            InitializeComponent();

            if (File.Exists(pathName))
            {   //אם כן
                try
                {   //טען את הקובץ
                    xmlDocument.Load(pathName);
                }
                //אם לא הצלחת לטעון הצג הודעת שגיאה מתאימה
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            //אם לא קיים, צור קובץ
            else
            {
                //יצירת קובץ ראשי חדש
                XmlNode root = xmlDocument.CreateElement("Queries");

                xmlDocument.AppendChild(root);
                //שמירת הקובץ
                xmlDocument.Save(pathName);
            }
        }

        

        private void InsertData()
        {
            //נמיר את כל הערכים שקבלנו לכתיבה הלכתית ונכניס את הטקסט למשתנה
                switch (cmbDay.Text)
                {
                    case "ראשון":
                        result += "באחד בשבת ";
                        break;

                    case "שני":
                        result += "בשני בשבת ";
                        break;

                    case "שלישי":
                        result += "בשלישי בשבת ";
                        break;

                    case "רביעי":
                        result += "ברביעי בשבת ";
                        break;

                    case "חמישי":
                        result += "בחמישי בשבת ";
                        break;

                    case "שישי":
                        result += "בששי בשבת ";
                        break;
                }

                switch (cmbDayMonth.Text)
                {
                    case "1":
                        result += "יום אחד לירח ";
                        break;

                case "2":
                    result += "שני ימים לירח ";
                    break;

                case "3":
                    result += "שלשה מים לירח ";
                    break;

                case "4":
                    result += "ארבעה ימים לירח ";
                    break;

                case "5":
                    result += "חמשה ימים לירח ";
                    break;

                case "6":
                    result += "ששה ימים לירח ";
                    break;

                case "7":
                    result += "שבעה ימים לירח ";
                    break;

                case "8":
                    result += "שמנה ימים לירח ";
                    break;

                case "9":
                    result += "תשעה ימים לירח ";
                    break;

                case "10":
                    result += "עשרה ימים לירח ";
                    break;

                case "11":
                    result += "אחד עשר יום לירח ";
                    break;

                case "12":
                    result += "שנים עשרה יום לירח ";
                    break;

                case "13":
                    result += "שלשה עשר יום לירח ";
                    break;

                case "14":
                    result += "ארבעה עשר יום לירח ";
                    break;

                case "15":
                    result += "חמשה עשר יום לירח ";
                    break;

                case "16":
                    result += "ששה עשר יום לירח ";
                    break;

                case "17":
                    result += "שבעה עש יום לירח ";
                    break;

                case "18":
                    result += "שמנה עשר יום לירח ";
                    break;

                case "19":
                    result += "תשעה עשר יום לירח ";
                    break;

                case "20":
                    result += "עשרים יום לירח ";
                    break;

                case "21":
                    result += "אחד ועשרים יום לירח ";
                    break;

                case "22":
                    result += "שנים ועשרים יום לירח ";
                    break;

                case "23":
                    result += "שלשה ועשרים יום לירח ";
                    break;

                case "24":
                    result += "ארבעה ועשרים יום לירח ";
                    break;

                case "25":
                    result += "חמשה ועשרים יום לירח ";
                    break;

                case "26":
                    result += "ששה ועשרים יום לירח ";
                    break;

                case "27":
                    result += "שבעה ועשרים יום לירח ";
                    break;

                case "28":
                    result += "שמנה ועשרים יום לירח ";
                    break;

                case "29":
                    result += "תשעה ועשרים יום לירח ";
                    break;

                case "30":
                    result += "יום שלשים לחדש " + cmbMonth.Text + " " + "שהוא ראש חדש ";
                    break;

            }

                switch (cmbMonth.Text)
                {
                    case "תשרי":
                        result += "תשרי ";
                        break;

                case "חשוון":
                    result += "מרחשון ";
                    break;

                case "כסלו":
                    result += "כסלו ";
                    break;

                case "טבת":
                    result += "טבת ";
                    break;

                case "שבט":
                    result += "שבט ";
                    break;

                case "אדר":
                    result += "אדר ";
                    break;

                case "אדר א":
                    result += "אדר הראשון ";
                    break;

                case "אדר ב":
                    result += "אדר השני ";
                    break;

                case "ניסן":
                    result += "ניסן ";
                    break;

                case "אייר":
                    result += "אייר ";
                    break;

                case "סיון":
                    result += "סיון ";
                    break;

                case "תמוז":
                    result += "תמוז ";
                    break;

                case "אב":
                    result += "אב ";
                    break;

                case "אלול":
                    result += "אלול ";
                    break;


            }

                switch (cmbYear.Text)
                {
                    case "תשפ''ד":
                        result += "שנת חמשת אלפים ושבע מאות ושמנים וארבע לבריאת העולם";
                        break;

                case "תשפ''ה":
                    result += "שנת חמשת אלפים ושבע מאות ושמנים וחמש לבריאת העולם";
                    break;

                case "תשפ''ו":
                    result += "שנת חמשת אלפים ושבע מאות ושמנים ושש לבריאת העולם";
                    break;

                case "תשפ''ז":
                    result += "שנת חמשת אלפים ושבע מאות ושמנים ושבע לבריאת העולם";
                    break;

                case "תשפ''ח":
                    result += "שנת חמשת אלפים ושבע מאות ושמנים ותשע  לבריאת העולם";
                    break;

                case "תשפ''ט":
                    result += "שנת חמשת אלפים ושבע מאות ותשעים לבריאת העולם";
                    break;

                case "תש''צ":
                    result += "שנת חמשת אלפים ושבע מאות ותשעים ואחת לבריאת העולם";
                    break;

                case "תשצ''א":
                    result += "שנת חמשת אלפים ושבע מאות ותשעים ושתים לבריאת העולם";
                    break;

                case "תשצ''ב":
                    result += "שנת חמשת אלפים ושבע מאות ותשעים ושלש לבריאת העולם";
                    break;

                case "תשצ''ג":
                    result += "שנת חמשת אלפים ושבע מאות ותשעים וארבע לבריאת העולם";
                    break;


            }
            
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //נקרא לפנוקציה שמכניסה את הנתונים למשתנה
            InsertData();

            //יצירת נוד - צומת של שאילתה שנמצאת בתוך הקובץ הראשי ותכיל את כל הנתונים
            XmlNode Query = xmlDocument.CreateElement("Query");

            //הוספת נתונים לתוך הצומת של השאילתה
            Query.AppendChild(xmlDocument.CreateElement("Day")).InnerText = cmbDay.Text;
            Query.AppendChild(xmlDocument.CreateElement("DayMonth")).InnerText = cmbDayMonth.Text;
            Query.AppendChild(xmlDocument.CreateElement("Month")).InnerText = cmbMonth.Text;
            Query.AppendChild(xmlDocument.CreateElement("Year")).InnerText = cmbYear.Text;
            Query.AppendChild(xmlDocument.CreateElement("Result")).InnerText = result;

            //הגדרת השאילתה כילד ראשון של הקובץ הראשי
            xmlDocument.FirstChild.AppendChild(Query);

            //שמירת הנתונים בנתיב הראשי
            xmlDocument.Save(pathName);

            //הכנסת המשתנה שמכיל את הכתיבה ההלכתית לטקסט בוקס שיציג את התוצאה
            txtResult.Text = result;

            //הצגת הכתיבה בהודעה
            MessageBox.Show(Query.SelectSingleNode("Result").InnerText);

        }
                    
    }
}
