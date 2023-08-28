using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChromeDriverService driverService = ChromeDriverService.CreateDefaultService();

            ChromeOptions chromeOptions = new ChromeOptions();

            // 전체 화면
            chromeOptions.AddArgument("--start-maximized");

            // 브라우저 창 크기 설정
            //chromeOptions.AddArgument("--window-size=500,768");

            // 안전하지 않은 페이지 경고를 무시
            chromeOptions.AddArgument("ignore-certificate-errors");

            // GPU 가속을 비활성화
            chromeOptions.AddArgument("--disable-gpu");

            // 쿠키 사용 비활성화
            chromeOptions.AddArgument("--disable-cookies");

            // SSL 인증서 오류 무시
            chromeOptions.AddArgument("--ignore-certificate-errors");

            // 크롬 브라우져 실행
            IWebDriver driver = new ChromeDriver(driverService, chromeOptions);

            // 주소 이동
            INavigation navigation = driver.Navigate();
            navigation.GoToUrl("https://kjun.kr");

            Console.WriteLine("아무 키나 누르면 브라우져가 종료됩니다.");

            Console.ReadKey(false);

            driver.Quit();
        }
    }
}