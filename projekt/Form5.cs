using projekt;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt
{
    public partial class compPage : Form
    {

        private QuestionsComp currentQuestion;
        string answer;
        Random random = new Random();
        public void CompReset()
        {
            answerBoxComp.Text = string.Empty;
            correctAnswerComp.Text = string.Empty;
            infoBoxComp.Text = string.Empty;
            questionComp.Text = string.Empty;
        }

        public void AnswerSubmit()
        {
            if (currentQuestion == null)
            {
                MessageBox.Show("Det finns inga frågor för tillfället");
                return;
            }

            answer = answerBoxComp.Text.ToLower();

            if (answer == currentQuestion.Answer.ToLower())
            {
                MessageBox.Show("Rätt svar!");
                infoBoxComp.Text = currentQuestion.Info;
                correctAnswerComp.Text = currentQuestion.Answer;
            }
            else
            {
                MessageBox.Show("Fel svar");
                infoBoxComp.Text = currentQuestion.Info;
                correctAnswerComp.Text = currentQuestion.Answer;
            }
        }

        public void DontKnow()
        {
            if(currentQuestion == null)
            {
                MessageBox.Show("Välj del först");
            }
            else
            {
                infoBoxComp.Text = currentQuestion.Info;
                correctAnswerComp.Text = currentQuestion.Answer;
            }
        }

        public void Reset()
        {
            infoBoxComp.Text = "----";
            correctAnswerComp.Text = "----";
            answerBoxComp.Text = null;
            questionComp.Text = "Välj del";
        }

        public compPage()
        {
            InitializeComponent();

            HistoryQuestions historyQuestions = new HistoryQuestions();
            HardwareQuestions hardwareQuestions = new HardwareQuestions();
            InternetQuestions internetQuestions = new InternetQuestions();
            OperativeQuestions operativeQuestions = new OperativeQuestions();
            MemoryQuestions memoryQuestions = new MemoryQuestions();
        }


        private void backButton_Click(object sender, EventArgs e)
        {
            allround.BackButton(this);
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            allround.MenuButton(this);
        }

        private void historyButtonComp_Click(object sender, EventArgs e)
        {
            CompReset();

            if (HistoryQuestions.historyQuestionsList.Count == 0)
            {
                MessageBox.Show("Det finns inga frågor för tillfället");
                return;
            }

            int randomQ = random.Next(0, HistoryQuestions.historyQuestionsList.Count);
            currentQuestion = HistoryQuestions.historyQuestionsList[randomQ];
            questionComp.Text = currentQuestion.Question;

        }

        private void answerSubmitComp_Click(object sender, EventArgs e)
        {
            AnswerSubmit();
        }

        private void hardButtonComp_Click(object sender, EventArgs e)
        {
            CompReset();

            if (HardwareQuestions.hardwareQuestionsList.Count == 0)
            {
                MessageBox.Show("Det finns inga frågor för tillfället");
                return;
            }

            int randomQ = random.Next(0, HardwareQuestions.hardwareQuestionsList.Count);
            currentQuestion = HardwareQuestions.hardwareQuestionsList[randomQ];
            questionComp.Text = currentQuestion.Question;

        }

        private void netButtonComp_Click(object sender, EventArgs e)
        {
            CompReset();

            if (InternetQuestions.internetQuestionsList.Count == 0)
            {
                MessageBox.Show("Det finns inga frågor för tillfället");
                return;
            }

            int randomQ = random.Next(0, InternetQuestions.internetQuestionsList.Count);
            currentQuestion = InternetQuestions.internetQuestionsList[randomQ];
            questionComp.Text = currentQuestion.Question;
        }

        private void operButtonComp_Click(object sender, EventArgs e)
        {
            CompReset();

            if (OperativeQuestions.operativeQuestionsList.Count == 0)
            {
                MessageBox.Show("Det finns inga frågor för tillfället");
                return;
            }

            int randomQ = random.Next(0, OperativeQuestions.operativeQuestionsList.Count);
            currentQuestion = OperativeQuestions.operativeQuestionsList[randomQ];
            questionComp.Text = currentQuestion.Question;

        }

        private void memoryButtonComp_Click(object sender, EventArgs e)
        {
            CompReset();

            if (MemoryQuestions.memoryQuestionsList.Count == 0)
            {
                MessageBox.Show("Det finns inga frågor för tillfället");
                return;
            }

            int randomQ = random.Next(0, MemoryQuestions.memoryQuestionsList.Count);
            currentQuestion = MemoryQuestions.memoryQuestionsList[randomQ];
            questionComp.Text = currentQuestion.Question;

        }

        private void dontKnowComp_Click(object sender, EventArgs e)
        {
            DontKnow();
        }

        private void resetButtonComp_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void answerBoxComp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                AnswerSubmit();
                e.SuppressKeyPress = true;
            }
        }
    }

    public class QuestionsComp
    {
        private string _question;
        private string _answer;
        private string _info;

        public string Question
        {
            get { return _question; }
        }

        public string Answer
        {
            get { return _answer; }
        }

        public string Info
        {
            get { return _info; }
        }

        public QuestionsComp(string question, string answer, string info)
        {
            _question = question;
            _answer = answer;
            _info = info;
        }
    }

    public class HistoryQuestions
    {
        public static List<QuestionsComp> historyQuestionsList = new List<QuestionsComp>();
        public HistoryQuestions()
        {
            historyQuestionsList.Add(new QuestionsComp("när skapades MS-DOS?", "1980", "*placeholder*"));
            historyQuestionsList.Add(new QuestionsComp("HisFråga2", "1980", "*placeholder*"));
            historyQuestionsList.Add(new QuestionsComp("HisFråga3", "1980", "*placeholder*"));

        }
    }

    public class HardwareQuestions
    {
        public static List<QuestionsComp> hardwareQuestionsList = new List<QuestionsComp>();
        public HardwareQuestions()
        {
            hardwareQuestionsList.Add(new QuestionsComp("Vad står ESD för?", "Electro Static Discharge", "Statisk elektrisitet kan totalt förstöra ens dator. Datorkomponenter klarar bara max 12 V, en elektrisk stöt kan ha effekten utav 10 000 V. Därför ta till med åtgärder när du fixar med hårdvaran i en dator."));
            hardwareQuestionsList.Add(new QuestionsComp("Vilket chipset ansvarar för höghastighetskomponenter?", "Northbridge", "Northbridge är den snabba varianten av chipset. Den hanterar komponenter såsom Processorn, minnet och grafikkortet."));
            hardwareQuestionsList.Add(new QuestionsComp("Vilket chipset ansvarar för låghastighetskomponenter?", "Southbridge", "Southbridge hanterar de komponenter som inte behöver så snabb dataöverföring som andra delar som CPUn. Istället tar det han om t.ex hårddiskar, SSD, USB-portar etc."));
            hardwareQuestionsList.Add(new QuestionsComp("Vad står ATX för?", "Advanced Technology Extended", "ATX är en formfaktor utav moderkort. ATX är vanligtvis större, har mer expansionsplatser och stöd för RAM. Är populärt i stationära datorer."));
            hardwareQuestionsList.Add(new QuestionsComp("Vad står AT för?", "Advanced Technology", "AT moderkort är en tidigare standarn och mer ovanligt i dagsläget. Används mest i äldre datorer."));
            hardwareQuestionsList.Add(new QuestionsComp("Vad står ITX för?", "Information Technology eXtended", "ITX är ett lite mindre moderkort. Gjort för mer kompakta datorer."));
            hardwareQuestionsList.Add(new QuestionsComp("Vad brukar kallas för 'Datorns hjärna'", "Processorn", "Processorn, också kallad CPU (Central Processing Unit), brukar kallas för datorns hjärna eftersom det är här alla processer och beräkningar görs. Den styr och fördelar arbetet mellan komponenter."));
            hardwareQuestionsList.Add(new QuestionsComp("Vad kallas de spår där data överförs?", "Bussar", "I datorns värld är en buss en komunikationsväg eller elektriskt spår som möjliggör överföring utav data mellan olika enheter. De används för att ansluta olika komponenter på moderkorter och mellan moderkortet och externa enheter."));
            hardwareQuestionsList.Add(new QuestionsComp("Vad kallas bussen som sammanbinder processorn och arbetsminnet?", "Front-Side Bus", "FSB, även kallad Minnesbussen eller systembussen, är den buss som binder ihop processorn med arbetsminnet, alltså RAM."));
            hardwareQuestionsList.Add(new QuestionsComp("Var är interna grafikkort placerade? På...", "Moderkortet", "Interna grafikkort är installerade direkt på moderkortet. Ansluts med hjälp utav PCIe. Används ofta till spel och grafisk design."));
            hardwareQuestionsList.Add(new QuestionsComp("Vad står GPU för?", "Graphics Processing Unit", "Det är i GPUn eller Grafikkortet som det kallas, som beräkningarna för bilder och grafik på datorn görs. Utan det, ingen bild."));
            hardwareQuestionsList.Add(new QuestionsComp("Vad står VGA för?", "Video Graphics Array", "VGA är ett äldre och analogt gränssnitt, och används för att ansluta en dator till en skärm eller bildskärm. Har ganska låg maxupplösning. Mest vanligt på äldre datorer."));
            hardwareQuestionsList.Add(new QuestionsComp("Vad står DVI för?", "Digital Visual Interface", "DVI är både analogt och digitalt gränssnitt, beroende på anslutning. Stödjer höga upplösningar upp till 2560x1600 eller högre."));
            hardwareQuestionsList.Add(new QuestionsComp("Vad står HDMI för?", "High Definition Multimedia Interface", "HDMI har ett digitalt gränssnitt och används för att föra över högupplöst ljud och video mellan enheter. HDMI stödjer extremt hög upplösning, upp till 8K-upplösningar med senare versioner. "));
            hardwareQuestionsList.Add(new QuestionsComp("Vad står ISA för?", "Industry Standard Architechture", "ISA var den första standarden för grafikbussar och användes i äldre persondatorer. Har en låg bandbredd och 16-bitars gränssnitt."));
            hardwareQuestionsList.Add(new QuestionsComp("Vad står PCI för?", "Peripheral Component Interconnect", "PCI har ett 32-bitas gränssnitt och erbjöd högre bredband än ISA grafikbussen. Bredband på 528 MB/s"));
            hardwareQuestionsList.Add(new QuestionsComp("Vad står AGP för?", "Accelerated Graphics Port", "AGP har ett specialiserat gränssnitt. Användes mest för att ansluta dedikerade grafikkort till datorer. Max 2112 MB/s."));
            hardwareQuestionsList.Add(new QuestionsComp("Vad står PCIe för?", "Peripheral Component Interconnect Express", "PCIe är den senaste standarden för expansionsbussar och används i de flesta moderna datorer. Har högt bredband och erbjuder snabb data överföring mellan moderkort och expansionskort. PCIe kan skalas och konfigureras med olika antal 'lanes' för att möta prestandakrav. 4000 MB/s."));
            hardwareQuestionsList.Add(new QuestionsComp("Vad står API för?", "Application Programming Interface", "API är en uppsättning metoder och verktyg som gör det möjligt för olika program att kommunicera med varandra. API används för att definiera hur olika delar av programvara elelr ett system kan interagera med varandra."));
            hardwareQuestionsList.Add(new QuestionsComp("Vad står ITX för?", "Information Technology eXtended", "ITX är ett lite mindre moderkort. Gjort för mer kompakta datorer."));
            hardwareQuestionsList.Add(new QuestionsComp("Vad står USB för?", "Universal Serial Bus", "USB är en seriell kommunikationsstandard som används för att ansluta nästan alla möjliga enheter till en dator eller varandra. USB 1.1 - 12 Mbit/s, USB 3.0 - 5 Gbit/s, USB kan vara max 5 meter lång."));
            hardwareQuestionsList.Add(new QuestionsComp("Vad står QPI för?", "QuickPath Interconnect", "QPI är en höghastighets datapath-interconnectteknik utvecklad utav Intel för att möjliggöra kommunikation mellan processorerna och andra komponenter i ett system. En viktig del i moderna servrar och arbetsstationssystem."));
            hardwareQuestionsList.Add(new QuestionsComp("Vad är IEEE 1394 även känt som?", "FireWire", "FireWire är en höghastighets seriell bussstandard som används för snabb dataöverföring. Var tänkt som en ersättare till USB 1.1. Behöver inte en dator och kan föra över 400 MB/s. Kan dock max vara 4,5 meter lång."));


        }
    }

    public class InternetQuestions
    {
        public static List<QuestionsComp> internetQuestionsList = new List<QuestionsComp>();
        public InternetQuestions()
        {
            internetQuestionsList.Add(new QuestionsComp("Vad står LAN för?", "Local Area Network", "Ett LAN är när man kopplar ihop datorer i ett lokalt nätverk. T.ex för en byggnad."));
            internetQuestionsList.Add(new QuestionsComp("Vad står PAN för?", "Personal Area Network", "PAN är väldigt små nätverk, exempel på PAN är bluetooth."));
            internetQuestionsList.Add(new QuestionsComp("Vad står MAN för?", "Metropolitan Area Network", "ett MAN sträcker sig över en hel stad, och kopplar samman datorer i hela staden. Vi har ett MAN i Växjö, vxo."));
            internetQuestionsList.Add(new QuestionsComp("Vad står MAC-adress för?", "Media Access Control-adress", "En MAC-adress är unik för varje dator (nätverkskort), man kan säga att det är som en dators personnummer."));
            internetQuestionsList.Add(new QuestionsComp("Vad står IP-adress för?", "Internet Protocol-adress", "IP-adresser kan man säga är som språk. Det följer vissa regler för att dela information. Man behöver tala samma språk för att ta del utav informationen. Varje dator uppkopplat till nätet tilldelas en IP-adress."));
            internetQuestionsList.Add(new QuestionsComp("Vad står UTP för?", "Unshielded Twisted Pair", "Består utav 4 par koppar kablar som snurras runt varandra, för att förbättra elektromagnetisk kompatibilitet. Används mycket i t.ex LAN"));
            internetQuestionsList.Add(new QuestionsComp("Vad står STP för?", "Shielded Twisted Pair", "Består utav 4 par koppar kablar som snurras runt varandra, för att förbättra elektromagnetisk kompatibilitet. Till skillnad från UTP har STP ett skydd runt sig mot elektromagnetiska störningar."));
            internetQuestionsList.Add(new QuestionsComp("Vilket system kan bara kommunicera åt ena hållet?", "Simplex", "Med Simplex kan man endast överföra data i en riktning. Mellan en avsändare och mottagare."));
            internetQuestionsList.Add(new QuestionsComp("Vilket system kan kommunicera åt båda hållen, men inte samtidigt?", "Halv-Duplex", "Med Halv-Duplex är tvåvägs kommunikation möjlig, bara inte samtidigt. Som en walkie talkie."));
            internetQuestionsList.Add(new QuestionsComp("Vilket system kan kommunicera åt båda hållen?", "Duplex", "Med Duplex kan man kommunicera åt båda hållen och samtidigt."));
            internetQuestionsList.Add(new QuestionsComp("Vad heter topologin där alla datorer är kopplade till samma koacialkabel?", "Bussnät", "Bussnät är den äldsta topologin, där alla datorer är kopplade till en och samma koaxialkabel. Detta gör det enkelt att koppla in nya datorer i nätverket, men minsta lilla brott och hela nätverket havererar. Behövs termineringsmotstånd."));
            internetQuestionsList.Add(new QuestionsComp("Vad är den vanligaste topologin?", "Stjärnnät", "Till skillnad från bussnät där man kopplade alla datorer till en koaxialkabel, så kopplar man med stjärnnät ihop alla datorer till ett nätverk genom en hubb eller switch. Nackdelen är att det krävs mer kabel."));
            internetQuestionsList.Add(new QuestionsComp("Vad är den stora skillnaden mellan olika kategorier utav TP kabel?", "Bredband", "Det finns flera kategorier utav TP kabel, alltså Twisted Pair kabel. Det stora som skiljer dem år är hur snabbt de överför data (bredband). T.ex Cat 5 har 100 MHz, medans cat 7 har 600 MHz."));
            internetQuestionsList.Add(new QuestionsComp("Vad är detta för version av IP-adress?: 'xxx.xxx.xxx.xxx'", "Version 4", "Även kallat IPv4, är en 32-bitars adress. Det finns nästan 4.3 miljarder unika IPv4 adresser. IPv4 adresser skrivs med 4 tal mellan 0-255 och åtskiljs med punkt."));
            internetQuestionsList.Add(new QuestionsComp("Vad kopplar man med en router?", "Ett lokalt nätverk med ett externt nätverk", "En router är som en bro mellan ens lokala nätverk och ett externt nätverk. Utan en router kan man inte komma åt den globala webben"));
            internetQuestionsList.Add(new QuestionsComp("Vad är detta för adress? '####:####:####:####:####:####:####:####'", "IP-adress version 6", "IP-adress version 6, också kallat IPv6. IPv6 använder 128 bitar långa adresser, vilket gör det teoretiskt sätt möjligt med 16^32 adresser, eller ungefär 340,3 sextiljoner stycken. Det är ungefär 48 kvadriljarder adresser per person på jorden"));
            internetQuestionsList.Add(new QuestionsComp("Vad står CSMA/CS för?", "Carrier Sense Multiple Access/Collision Detection", "CSMA/CS används i Ethernet-nätverk. Det är ett protokol för hur enheter delar data. Det fungerar som så att protokollet skickar data först för att se ifall kabeln är ledig, är den det skickas datan. Upptäcks kollision skickas datan igen efter en slumpmässig tid"));
            internetQuestionsList.Add(new QuestionsComp("Vad står CSMA/CD för?", "Carrier Sense Multiple Access/Collision Avoidance", "CSMA/CA används ofta inom trådlösa LAN eller Wi-Fi. Går ut på att enheten först skickar en RTS (Request To Send), ifall mottagaren får RTSen, skickar den en CTS (Clear To Send), och datan skickas"));
            internetQuestionsList.Add(new QuestionsComp("Vilken IPv4-adress klass är detta?: '172.16.231.16'", "Klass B", "IPv4 klass B har 1 048 576 möjliga adresser. Adresserna i klass B kan vara inom intervallet 172.16.0.0-172.31.255.255."));
            internetQuestionsList.Add(new QuestionsComp("Vilken IPv4-adress klass är detta?: '10.2.12.44'", "Klass A", "IPv4 klass A har 16 777 216 möjliga adresser. Adresserna i klass A kan vara inom intervallet 10.0.0.0-10.255.255.255."));
            internetQuestionsList.Add(new QuestionsComp("Vilken IPv4-adress klass är detta?: '192.168.1.244'", "Klass C", "IPv4 klass C har 65 536 möjliga adresser. Adresserna i klass A kan vara inom intervallet 192.168.0.0-192.168.255.255."));
            internetQuestionsList.Add(new QuestionsComp("Vad heter adressen som används för att kommunicera med andra nätverk?", "Default Gateway", "Default Gateway är den adress som routern använder för att kommunicera med andra nätverk."));
            internetQuestionsList.Add(new QuestionsComp("Vad kallas topologin där enheter är kopplade som i en cirkel?", "Ringnät", "Ringnät eller så kallat token-ring är när enheter är kopplade tillsammans i en ring. Seriekopplade. Går kabeln sönder förstörs kopplingen. För att motverka detta la man ibland till en extra ring som kompensation."));
            internetQuestionsList.Add(new QuestionsComp("Vilken sorts kabel använder ljus för att öberföra information?", "Fiber", "Fiber använder ljussignaler genom ett optiskt fiber för att skicka information mellan olika enheter/nätverk. Fiber är bra för lång distans, högt bredband och immunitet mot elektomagnetisk störning"));
            internetQuestionsList.Add(new QuestionsComp("Vilken enhet använder man för att förstärka en svag signal i låndistans nätverk?", "Repeater", "En Repeater används för att regenerera eller replikera en försvagad eller förvrängd signal över nätverk som sträcker sig längre distanser. Det förstärker signalen, så att datan kan överföras över längre distanser"));
            internetQuestionsList.Add(new QuestionsComp("Vilken enhet används för att koppla samman flera enheter?", "Hub", "En Hub används för att koppla samman flera Ethernet enheter, så att de fungerar som en enda nätverkssegment. Den sänder datapaket den tar emot till alla portar förutom den det togs emot på"));
            internetQuestionsList.Add(new QuestionsComp("Vilken enhet fungerar som en bättre Hub?", "Switch", "En switch ansluter flera enheter inom ett nätverk och använder paketväxling för att skicka data till sin destination. Till skillnad från en Hub skickas data bara till enheten som behöver det."));
            internetQuestionsList.Add(new QuestionsComp("Hur många lager består OSI modellen av?", "7", "OSI modellen är standard för all nätverkskommunikation och består utav 7 lager. Dessa är det Fysiska lagret, Datalänklagret, Nätverkslagret, Transportlagret, Sessionslagret, Presentationslagret och Applikationslagret."));
            internetQuestionsList.Add(new QuestionsComp("Vad står TCP för?", "Transmission Control Protocoll", "TCP är en utav huvud protokollen. Det säkerställer pålitlig överföring av data mellan datorer på ett nätverk, TCP använder trevägshandslag för att säkerställa att datan skickas säkert. TCP finns på Transportlagret (lager 4) i OSI modellen."));
            internetQuestionsList.Add(new QuestionsComp("Vad står UDP för?", "User Datagram Protocol", "UDP är en utav kärnprotokollen. UDP är ett kontaktlöst protokoll som är ett snabbt men opolitligt sätt att överföra data. UDP i stort sätt bara skickar data och hoppas på det bästa. Den säkerställer inte att all data skickas."));
            internetQuestionsList.Add(new QuestionsComp("Vad står POP3 för?", "Post Office Protocol", "POP3 eller Post Office Protocol version 3 är det protokoll som används för att hämta e-postmedelanden fråm en e-post server till en e-post klient, såsom Outlook. Använder normalt sätt port 110."));
            internetQuestionsList.Add(new QuestionsComp("Vad står SMTP för?", "Simple Mail Transfer Protocol", "SMTP används för att skicka e-post medelanden över nätet. Det är den standardiserade protokollen för att överföra e-post från en e-post klient eller e-post server till en annan e-post server. Använder port 25"));
            internetQuestionsList.Add(new QuestionsComp("Vad står IMAP för?", "Internet Message Access Protocol", "IMAP är vidareutvecklingen utav POP3. Det är till för att hämta e-post meddelanden. IMAP gör det möjligt för användaren att organisera, hantera och synkronisera sina e-post meddelanden över olika enheter."));
            internetQuestionsList.Add(new QuestionsComp("Vad står DNS för?", "Domain Name System", "DNS är en xetremt viktig del utav nätverksinfrastrukturen. Man kan säga att den är som en telefonkatalog. Den översätter läsbara domännamn såsom google.com till numeriska IP-adresser, som datorer och nätverk använder för att kommunicera."));
            internetQuestionsList.Add(new QuestionsComp("Vad står WLAN för?", "Wireless Local Area Network", "WLAN är en trådlös teknik för att ansluta enheter till varandra och internet, till exempel inom ett hem eller kontorsbyggnad. Till exempel är Access Point (AP), en enhet som skapar ett trådlöst nätverk, ett WLAN."));
            internetQuestionsList.Add(new QuestionsComp("Vad står DHCP för?", "Dynamic Host Configuration Protocol", "Det är DHCP det protokoll som automatiskt tilldelar enheter inom nätverket en IP-adress, vilket möjligör kommunikation."));
        }
    }

    public class OperativeQuestions
    {
        public static List<QuestionsComp> operativeQuestionsList = new List<QuestionsComp>();
        public OperativeQuestions()
        {
            operativeQuestionsList.Add(new QuestionsComp("Vad är det Operativsystemet styr i en dator", "Hårdvara och Mjukvara", "Operativsystem hanterar en stor mängd funktioner och tjänster i en dator. Man kan säga att det är som en mellanhand mellan användaren och datorns hårdvara. Operativsystemet tar till exempel hand om användargränssnitt, nätverkskommunikation, filhantering mm."));
            operativeQuestionsList.Add(new QuestionsComp("Vilken funktion gör det möjligt att ha igång flera saker samtidigt?", "Multitasking", "Multitasking är förmågan hos datorsystem elelr operativsystem att hantera flera uppgifter och processer samtidigt. Systemet kan alltså växla mellan uppgifterna och utföra dem parallellt."));
            operativeQuestionsList.Add(new QuestionsComp("Vad heter de program som körs i bakgrunden och underlättar funktioner?", "Tjänst", "Tjänst är program eller processer som körs i bakgrunden för att underlätta vissa funktioner för användaren eller andra program."));
            operativeQuestionsList.Add(new QuestionsComp("Vad används om RAM inte räcker till?", "Virtuellt Minne", "Virtuellt Minne används när mängden RAM tillgänglig inte räcker till. Då kan operativsystemet allokera plats på hårddiskar som kan fungera som RAM under tiden"));
            operativeQuestionsList.Add(new QuestionsComp("Vad står GUI för?", "Graphical User Interface", "GUI är ett grafiskt gränssnitt. Alltså funktioner och program är kopplade till speciella ikoner iställer för bakom kommandon."));
            operativeQuestionsList.Add(new QuestionsComp("Vad står IRQ för?", "Iterrupt Request", "Enheter kan med hjälp utav en IRQ signalera till processorn att de behöver omedelbar uppmärksamhet. Då avslutar processorn det den håller på med för att byta över till den delen av systemet som fixar avbrott."));
            operativeQuestionsList.Add(new QuestionsComp("Vad står DMA för?", "Direct Memory Access", "DMA gör det möjligt för enheter att kommunicera och överföra data mellan varann utan att gå igenom processorn."));
            operativeQuestionsList.Add(new QuestionsComp("Vad kan man använda för att skydda sin data?", "BitLocker", "BitLock är en funktion i Windows som kan kryptera ens filer så att ingen annan har tillgång till dem förutem om man har säkerhetsnyckeln."));
            operativeQuestionsList.Add(new QuestionsComp("Vilka 2 filsystem kan användas av Windows?", "FAT32 och NTFS", "FAT32 eller Full Allocation Table 32, kan bara hantera filer som är 4GB stora med en max på 2TB. Har begränsade säkerhetsfunktioner. NTFS kan hantera 16 exabyte stora filer och har mycket mer avancerade säkerhetsfunktioner."));
            operativeQuestionsList.Add(new QuestionsComp("Vad kallas det när datan på en disk/filsystem inte finns samlad på disken? Den är...", "Fragmenterad", "När en datan på en disk eller i ett filsystem är fragmenterad betyder det att datan inte är lagrad i en sammanhängande sekvens utav sektorer. Utan den är uppdelad lite här och var. Detta gör avläsningen utav datan mycket långsammare, eftersom skrivhuvudet måste flytta på sig samtidigt."));
            operativeQuestionsList.Add(new QuestionsComp("Vilket kommando används för att kolla diskintegritet?", "chkdsk", "'chkdsk' eller Check Disk används för att kolla integriteten hos ett filsystem samt reparerar de fel som kan ha uppståt."));
            operativeQuestionsList.Add(new QuestionsComp("Vad står BIOS för?", "Basic Input/Output System", "BIOS är ett program som är inbyggt i alla moderkort. Det är kritiskt till systemet och används för att initiera, testar och laddar de program som krävs för att starta och kommunicera med datorns hårdvara."));
            operativeQuestionsList.Add(new QuestionsComp("Kan man kolla vilken BIOS man har? (ja/nej)", "Ja", "Ett sätt att kolla vilken BIOS man själv har är att använda kortkommandot 'Windows+R' och skriva in komandot msinfo32. Så borde det stå där."));
            operativeQuestionsList.Add(new QuestionsComp("Vad står POST för?", "Power-On Self Test", "POST är diagnostik som utförs utav BIOS vid uppstart utav datorn. Det letar efter fel, kolalr hårdvara och gör stabilitetstest."));
            operativeQuestionsList.Add(new QuestionsComp("Upptäcks fel vid uppstart kan man höra, vad?", "Pipsignal", "Uppstår det något sorts fel vid uppstart finns det en funktin inbyggda i vissa moderkort att göra en ljudsignal för att indikera detta. Längd, mängds och intervall påpekar vilket sorts fel."));
            operativeQuestionsList.Add(new QuestionsComp("Vad kallas systemet som automatisks konfigurerar ny hårdvara?", "Plug and Play", "Förr i tiden kunde man inte bara koppla in ett tangentbord och förvänta sig att börja använda det direkt, utan man behövde konfigurera det. Idag har vi Plug and Play som sköter det åt oss istället."));
            operativeQuestionsList.Add(new QuestionsComp("Vad står CLI för?", "Command Line Interface", "CLI är ett gränssnitt som är textbaserat och man använder sig utav kommandon för att utföra olika funktioner och starta program."));
            operativeQuestionsList.Add(new QuestionsComp("Vilket system har börjat byta ut BIOS?", "UEFI", "UEFI, eller Unified Extensible Firmware Interface, är en vidareutveckling utav BIOS och har stöd för större hårddiskar, snabbare uppstartstider och enklare gränssnitt."));
            operativeQuestionsList.Add(new QuestionsComp("Var kan man hitta systemhändelser, varningat etc?", "I Loggen", "I operativsystemets log kan man hitta flera olika saker, såsom systemhändelser, fel och varningar, nätverksaktivitet, användaraktivitet etc."));
            operativeQuestionsList.Add(new QuestionsComp("Vad heter funktionen som tillåter att man flyttar filar/mappar etc", "Drag and Drop", "Drag and Drop är funktionen som tillåter en att flytta filer och mappar från en plats i operativsystemet till en annan med att bara dra det till den platsen."));
            operativeQuestionsList.Add(new QuestionsComp("Vilken filändelse används för textdokument?", ".txt", "filändelsen .txt används för textfiler."));
        }
    }

    public class MemoryQuestions
    {
        public static List<QuestionsComp> memoryQuestionsList = new List<QuestionsComp>();
        public MemoryQuestions()
        {
            memoryQuestionsList.Add(new QuestionsComp("Vad används primärminne till?", "Minne", "Primärminne, också bara kallat minne, är den typen utav minne som förlorar datan efter att strömmen stängts av"));
            memoryQuestionsList.Add(new QuestionsComp("Vad används sekundärminne till?", "Lagring", "Sekundärminne behåller den data som finns inom sig även efter att strömmen stängts av. Används som lagring."));
            memoryQuestionsList.Add(new QuestionsComp("Vad kallas tiden det tar för ett minne att ge svar?", "Accesstid", "Accesstid är den tiden det tar från att processorn skickar en fråga till att minnet svarar på det. Denna tid brukar anges i nanosekunder."));
            memoryQuestionsList.Add(new QuestionsComp("Vad står ROM för?", "Read Only Memory", "Read Only Memory var minne som endast var läsbart och inget annat. Användes till en början för att styra datorn."));
            memoryQuestionsList.Add(new QuestionsComp("Vad står PROM för?", "Programmable ROM", "Programmable Read Only Memory fungerar som ROM, skillnaden är att PROM kan man programera om en gång"));
            memoryQuestionsList.Add(new QuestionsComp("Vad står EPROM för?", "Erasable PROM", "Erasable Programmable Read Only Memory fungerar som PROM, fast nu kan man med hjälp utav uv ljus radera från minnet."));
            memoryQuestionsList.Add(new QuestionsComp("Vad står EEPROM för?", "Electrically EPROM", "Electrically Eresable Programmable Read Only Memory har samma funktion som EPROM, fast man använder ström för att ta bort istället för uv ljus. Det är ett flashminne."));
            memoryQuestionsList.Add(new QuestionsComp("Vad står RAM för?", "Random Access Memory", "RAM används för att temporärt lagra data och programinstruktioner som används utav processorn. RAM är ett flyktigt minne, alltså det som lagras försviner när strömmen stängs av. RAM ger snabb tillgång till data"));
            memoryQuestionsList.Add(new QuestionsComp("Vad står DRAM för?", "Dynamic RAM", "DRAM läcker data, vilket betyder att det måste återskrivas hela tiden med några millisekunders mellanrum"));
            memoryQuestionsList.Add(new QuestionsComp("Vad står SDRAM för?", "Synchronous DRAM", "SDRAM är en snabbare version utan DRAM. Mycket på grund utav att SDRAM använder sig utav en synkroniserad klocka. Så data kan överföras synkroniserat vilket gör överföring mer effektivt och minskar latensen."));
            memoryQuestionsList.Add(new QuestionsComp("Vad står SRAM för?", "Static RAM", "SRAM till skillnad från andra RAM är ett icke flyktigt minne, och behöver inte uppdateras för att behålla sin data som DRAM, utan behåller den sålänge ström finns. SRAM är ett väldigt stabilt och snabbt minne, och det är ett idealiskt cache-minne."));
            memoryQuestionsList.Add(new QuestionsComp("Vad står SIPP för?", "Single In-Line Pin Package", "SIPP har flera DRAM-minnen på ett kretskort, SIPP använde 30-pinar kontakt, vilket gjorde att de böjdes lätt vilket förstörde minnet. Användes mycket i äldre datorer"));
            memoryQuestionsList.Add(new QuestionsComp("Vad står SIMM för?", "Single In-Line Memory Module?", "SIMM minnen har 8 eller 16 minneskapslar och 30 eller 72 pinnar. Består utav flera RAM-chip som monterades på ett litet kretskort med kontakter längst ena kanten."));
            memoryQuestionsList.Add(new QuestionsComp("Vad står DIMM för?", "Dual In-Line Memory Module", "DIMM används i moderna datorer. Har separata kontakert på var sin sida av modulen för bättre prestanda. Det finns flera olika DIMM, DDR DIMM, DDR2 DIMM, DDR3 DIM, DDR4 DIM, DDR SDRAM etc."));
            memoryQuestionsList.Add(new QuestionsComp("Vilket är det vanligaste minneschipet?", "DDR SDRAM", "DDR SDRAM, eller Double Data Rate Synchronous RAM, kan överföra data två gånger per klockcykel till skillnad från vanliga SDRAM, effektivt fördubblar dataöverföringshastigheten."));
            memoryQuestionsList.Add(new QuestionsComp("Vad står ECC för?", "Error-Correction Code", "ECC är tekniken som används i datorminnen för att upptäcka och fixa de fel som kan uppstå vid dataöverföring. Detta är vanligt i servrar"));
            memoryQuestionsList.Add(new QuestionsComp("Vad kallas det minne som är innbyggt i processorn?", "Cacheminne", "Cacheminnen är snabba minnen för lagring av information som används ofta. Innbyggt i processorn för att slippa läsning utav RAM. Finns olika levlar utav cacheminnen. Lvl1 - Innuti processorn, lvl2 - För varje kärna, lvl3 - gemensamt för alla kärnor."));
            memoryQuestionsList.Add(new QuestionsComp("Vilket bredband har detta minne?: PC3200", "3200 MB/s", "Man kan räkna ut bredbandet såhär: (8 bytes * 400 MHz * 2 = 3200 MB/s), detta eftersom minnesbussen är 8 byte bred, minnesbussen har frekvensen 400 MHz, och gånger 2 eftersom det använder DDR-tekniken."));
            memoryQuestionsList.Add(new QuestionsComp("Vad står PROM för?", "Programmable ROM", "Programmable Read Only Memory fungerar som ROM, skillnaden är att PROM kan man programera om en gång"));
            memoryQuestionsList.Add(new QuestionsComp("Hur förvaras data i ett Kassettband? På ett...", "Magnetband", "Kassettband användes oftast för in- och uppslepning utav ljud, men användes även i vissa datorapplikationer"));
            memoryQuestionsList.Add(new QuestionsComp("Hur sparas data i en Diskett? På en...", "Magnetisk skiva", "Disketter var små magnetiska skivor med ett plastskydd. Från början kunde de bara spara 80kB 1971, till 1,44 MB 1984. De varierar i storlek, de finns i 8 tum, 5 och 1/4 tum, och 3,5 tum."));
            memoryQuestionsList.Add(new QuestionsComp("Vad står CD för?", "Compact Disc", "I en CD skiva lagras datan i små gropar på en skiva som sedan läses av med hjälp utav en laser."));
            memoryQuestionsList.Add(new QuestionsComp("Hur mycket kan du lagra på en Blu-ray disk?", "50GB", "En Blu-ray disk läses av med en blå laser istället för röd, och man kan lagra 25GB på singel lagrad och 50GB på dubbellagrad, upp till 128GB med Quad-Layer BD."));
            memoryQuestionsList.Add(new QuestionsComp("Vad heter tiden när huvudet flyttas i en HDD?", "Söktid", "Söktiden i en HDD beror på hur lång tid det tar för läs- och skrivhuvudet att flytta sig från ett spår till ett annat."));
            memoryQuestionsList.Add(new QuestionsComp("Vad kallas de tårtformade delarna i en HDD?", "Sektorer", "En sektor är en del utav databandet i en HDD. Den minsta enheten är 512 B"));
            memoryQuestionsList.Add(new QuestionsComp("Vad kallas en grupp Sektorer i en HDD?", "Kluster", "Kluster är en sammanslagning utav ett antal sektorer."));
            memoryQuestionsList.Add(new QuestionsComp("Vad står SSD för?", "Solid State Drive", "En SSD använder flashminnen. Den är snabbare än en traditionell hårddisk eftersom den inte har några rörliga delar, och det är inget läshuvud som behöver hitta datan på skivor, de är mycket tystare än HDDs men de drar också hela tiden ström."));
            memoryQuestionsList.Add(new QuestionsComp("Vad står IDE för?", "Integrated Drive Electronics", "IDE, även känt som ATA (Advanced Technology Attachment), är ett standardgränssnitt för att ansluta lagringsenheter som hårddiskar och optiska enheter till en dator."));
            memoryQuestionsList.Add(new QuestionsComp("Vad står SATA för?", "Serial ATA", "SATA är en modern standard för anslutning av lagringsenheter som hårddiskar och SSD till en dator, som ersatte IDE som den dominerande anslutningsstandarden. Ser ut som en bred och smal grupp sladdar."));
            memoryQuestionsList.Add(new QuestionsComp("Vad står RAID för?", "Redundant Array of Independent Disks", "RAID är ett system för att sammankoppla flera hårddiskar."));
            memoryQuestionsList.Add(new QuestionsComp("Vilken RAID nivå sprider data över alla diskar utan feltolerans?", "RAID 0", "Man kopplar ihop fler hårddiskar med varann och sprider all data över dem. Går något sönder förstörs all data."));
            memoryQuestionsList.Add(new QuestionsComp("Vilken raid nivå speglar all data som en säkerhetsåtgärd?", "RAD 1", "RAID 1 speglar all data över två diskar. Så om en disk förstörs har man en backup."));
            memoryQuestionsList.Add(new QuestionsComp("Minst hur många diskar krävs för raid 5", "3", "RAID 5 sprider datan över alla sina diskar, men använder också en checksumma för att kunna återskapa förlorade diskar."));
            memoryQuestionsList.Add(new QuestionsComp("Var är hårddiskens läs- och skrivhuvud när det inte används? På...", "Landningsbanan", "När hårddiskens läs- och skrivhuvud inte används så placeras det på en del av hårddisken som kallas för Landningsbanan."));
            memoryQuestionsList.Add(new QuestionsComp("Vad står eSATA för?", "External Serial ATA", "External Serial ATA använder Serial ATA-gränssnittet för att ansluta externa enheter såsom hårddiskar och SSD-enheter till datorer. Kan vara max 2 meter lång och överföra 3 Gbit/s."));
            memoryQuestionsList.Add(new QuestionsComp("Vad står SCSI för?", "Small Computer System Interface", "Högpresterande lagringsgränssnitt som används för att ansluta till servrar eller arbetsstationer."));
            memoryQuestionsList.Add(new QuestionsComp("Vad står SAS för??", "Serial Attached SCSI", "SAS är en seriell variant utav SCSI gränssnittet. Används för att ansluta högpresterade lagringsenheter såsom hårddiskar, SSD-enheter och bandsationer till servrar och lagringssystem."));
        }
    }
}

