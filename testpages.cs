namespace tetpages.HomePage
{
public class HomePage
{
By emailid = By.id('email');

        public void EnterEmail()
        {

            driver.findelement(emailid).SendKeys("maddyd@gmail.com");
        }


}

}
