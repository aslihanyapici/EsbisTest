using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium.Chrome;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        public static bool IsLoaded { get; private set; }

        [TestMethod]
        public void TestMethod1()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://giris.turkiye.gov.tr/Giris/gir?oauthClientId=6934a410-21f1-11e4-8c21-0800200c9a66&continue=https%3A%2F%2Fgiris.turkiye.gov.tr%2FOAuth2AuthorizationServer%2FAuthorizationController%3Fresponse_type%3Dcode%26client_id%3D6934a410-21f1-11e4-8c21-0800200c9a66%26redirect_uri%3Dhttps%253A%252F%252Fesbis.ticaret.gov.tr%252Fedevletlogin%26scope%3DKimlik-Dogrula%253BAd-Soyad%253BTemel-Bilgileri%253BIletisim-Bilgileri%26state%3D1499d014-00a6-4d38-a7a7-0cda5184e81d");
            Assert.IsTrue(UnitTest1.IsLoaded);
        }
    }
}
