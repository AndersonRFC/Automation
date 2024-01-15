//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.Support.UI;
//using SeleniumExtras.WaitHelpers;
//using System.Runtime.ExceptionServices;


//internal class Program
//{
//    public static void Main()
//    {
//        IWebDriver driver = new ChromeDriver();

//        driver.Manage().Window.Maximize();

//        driver.Navigate().GoToUrl("https://regular.escolarmanageronline.com.br/escolateste");
//        //SenhaAcesso

//        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));



//        IWebElement avancedButton = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#SenhaAcesso")));
//        avancedButton.SendKeys("1");
//        avancedButton.SendKeys(Keys.Enter);


//        IWebElement avancedButton2 = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"form0\"]/div[2]/div/div/div[3]/button[2]")));
//        avancedButton2.Click();
//        //btn btn-warning



//        //clicar
//        //*[@id="menu-modulos"]/ul/li[8]/button/i
//        IWebElement avancedButton3 = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"menu-modulos\"]/ul/li[8]/button/i")));
//        avancedButton3.Click();

//        //*[@id="lista-submodulos"]/li[1]/button/div/div[3]
//        IWebElement avancedButton4 = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"lista-submodulos\"]/li[1]/button/div/div[3]")));
//        avancedButton4.Click();

//        //*[@id="lista-submodulos"]/li[3]/button
//        IWebElement avancedButton5 = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"lista-submodulos\"]/li[3]/button")));
//        avancedButton5.Click();


//        driver.Navigate().GoToUrl("https://regular.escolarmanageronline.com.br/escolateste/CadastroPublicacaoDocumentoAvulso");

//        //string pasta = Console.ReadLine() ?? "Documentos";
//        string pasta = "Documentos";
//        string pastaAlvo;
//        bool first = true;
//        int i = 0;
//        int counter = 6;

//        IWebElement avancedButton6;
//        IWebElement avancedButton7;
//        IWebElement avancedButton8;
//        IWebElement avancedButton9;

//        while (true)
//        {
//            try
//            {

//                //*[@id="ParametrosPublicacao_Pasta.Descricao_5"]
//                avancedButton9 = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath($"//*[@id=\"ParametrosPublicacao_Pasta.Descricao_{i}\"]")));
//                pastaAlvo = avancedButton9.Text;


//                if (pastaAlvo == pasta)
//                {

//                    //botão delete
//                    //*[@id="grid-body"]/div[7]/div[9]/button[3]
//                    avancedButton6 = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath($"//*[@id=\"grid-body\"]/div[{i+1}]/div[9]/button[3]")));
//                    avancedButton6.Click();

//                    //Confirma
//                    avancedButton7 = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath($"/html/body/div[{counter}]/div/div/div[3]/button[1]")));
//                    avancedButton7.Click();
//                    counter++;

//                    if (first)
//                    {
//                        counter++;
//                        first = false;
//                    }

//                    //Voltar a lista
//                    avancedButton8 = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath($"/html/body/div[{counter}]/div/div/div[3]/button")));
//                    avancedButton8.Click();
//                    counter++;
//                    i--;
//                }

//            }
//            catch
//            {
//                break;
//            }
//            i++;
//        }

//        /*
//         * //*[@id="ParametrosPublicacao_Pasta.Descricao_0"] -> documentos
//         * //*[@id="grid-body"]/div[1]/div[9]/button[3] -> lixiera
//         * /html/body/div[6]/div/div/div[3]/button[1] -> confirma
//         * /html/body/div[8]/div/div/div[3]/button -> voltar
//         * 
//         * //*[@id="ParametrosPublicacao_Pasta.Descricao_0"] -> pasta anderson
//         * //*[@id="grid-body"]/div[1]/div[9]/button[3]
//         * 
//         * 
//         * 
//         * //*[@id="ParametrosPublicacao_Pasta.Descricao_1"] -> pasta anderson
//         * //*[@id="grid-body"]/div[2]/div[9]/button[3]
//         * 
//         * //*[@id="ParametrosPublicacao_Pasta.Descricao_2"] -> pasta documentos
//         * //*[@id="grid-body"]/div[3]/div[9]/button[3]
//         * /html/body/div[9]/div/div/div[3]/button[1]
//         * /html/body/div[10]/div/div/div[3]/button
//         * 
//         * 
//         * //*[@id="grid-body"]/div[3]/div[9]/button[3]
//         * /html/body/div[11]/div/div/div[3]/button[1]
//         * /html/body/div[12]/div/div/div[3]/button/i
//         * 
//         * 
//         * /html/body/div[13]/div/div/div[3]/button[1]
//         * /html/body/div[14]/div/div/div[3]/button
//         * 
//         * 
//         * 
//         * 
//         * 
//         */

//        Console.WriteLine("pressione enter para encerrar...");
//        Console.ReadLine();
//        driver.Quit();
//    }
//}


////pasta anderson
////*[@id="ParametrosPublicacao_Pasta.Descricao_5"]


////pasta documentos
////*[@id="ParametrosPublicacao_Pasta.Descricao_6"]



///*
//    vai olhar se a pasta é Documentos, se for vai excluir 
//    clicando na lixeirinha
// */


////*[@id="ParametrosPublicacao_Pasta.Descricao_1"]
////*[@id="grid-body"]/div[2]/div[9]/button[3]

////*[@id="ParametrosPublicacao_Pasta.Descricao_0"]
////*[@id="grid-body"]/div[1]/div[9]/button[3]


///*
//         * 1
//         * //*[@id="ParametrosPublicacao_Pasta.Descricao_0"] -> pasta do anderson
//         * //*[@id="grid-body"]/div[1]/div[9]/button[3]
//         * 2
//         * //*[@id="ParametrosPublicacao_Pasta.Descricao_1"] -> documentos
//         * //*[@id="grid-body"]/div[2]/div[9]/button[3] -> icone lixeira para deletar
//         * /html/body/div[6]/div/div/div[3]/button[1] -> confirmação sim
//         * /html/body/div[9]/div/div/div[3]/button -> voltar para lista (verde)
//         * 3 -> que agora é 2
//         * //*[@id="ParametrosPublicacao_Pasta.Descricao_1"] -> documentos
//         * //*[@id="grid-body"]/div[2]/div[9]/button[3] -> icone lixeira para deletar
//         * /html/body/div[10]/div/div/div[3]/button[1] -> confirmação sim
//         * /html/body/div[11]/div/div/div[3]/button -> voltar para a lista ( verde)
//         * 4 -> 2
//         * //*[@id="ParametrosPublicacao_Pasta.Descricao_1"] -> documentos
//         * //*[@id="grid-body"]/div[2]/div[9]/button[3] -> lixeira
//         * /html/body/div[12]/div/div/div[3]/button[1] -> confirmação sim
//         * /html/body/div[13]/div/div/div[3]/button -> voltar para a lista (verde)
//         * 
//         * 5
//         * //*[@id="ParametrosPublicacao_Pasta.Descricao_1"] -> documentos
//         * //*[@id="grid-body"]/div[2]/div[9]/button[3] -> lixeira
//         * /html/body/div[14]/div/div/div[3]/button[1] -> confimração sim
//         * /html/body/div[15]/div/div/div[3]/button -> voltar para a lista (verde)
//         */