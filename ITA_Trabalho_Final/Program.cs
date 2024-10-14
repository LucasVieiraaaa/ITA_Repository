using System;
using System.Collections;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
public class User
{
    private string user;
    private string senha;
    
    public User(string u ,string s)
    {
        user = u;
        senha = s;
    }
    public string getUser()
    {
        return user;
    }
    public string getPass()
    {
        return senha;
    }
  }
public class Login
{
    public void GetLogin()
    {
        int z = 0;
        string name = "lucas", pass = "12345",x = "",y = "";
        User us = new User(name, pass);
        //Console.WriteLine("user:" + us.getUser() + "\nPassword: " + us.getPass());
        Console.WriteLine("Digite o Usuario e em Seguida a senha:");
        while (x != name && y!=pass && z != 1)
        {
            x = Console.ReadLine();
            if (x.ToLower() == name)
            {
                y = Console.ReadLine();
                if (y == pass)
                {
                    Console.Write("Carregando"); Thread.Sleep(450);
                    Console.Write("."); Thread.Sleep(450);
                    Console.Write("."); Thread.Sleep(450);
                    Console.Write("."); Thread.Sleep(500);
                    Console.Clear();
                    Console.WriteLine("Bem-vindo, " + name);
                    z++;
                }
                else
                {
                    Console.WriteLine("Senha Incorreta, tente novamente");

                }
            }
            else
            {
                Console.WriteLine("Usuário não se encontra na Base de Dados do Sistema...Digite o User novamente:");
            }
        }
    }
}
public class Books
{
    private ArrayList livros;
    private ArrayList autores;
    private ArrayList sinopse;
    private ArrayList paginas;
    private ArrayList trofeus;
    
    public ArrayList setBooks()
    {
        livros = new ArrayList()
        {
            "1984",
            "Orgulho e Preconceito",
            "Cem Anos de Solidão",
            "O Hobbit",
            "O Apanhador no Campo de Centeio",
            "A Culpa é das Estrelas",
            "O Senhor dos Anéis: A Sociedade do Anel",
            "O Código Da Vinci",
            "Harry Potter e a Pedra Filosofal",
            "A Revolução dos Bichos",
            "Dom Casmurro",
            "A Metamorfose",
            "O Alquimista",
            "Anna Karenina",
            "O Pequeno Príncipe",
            "A Menina que Roubava Livros",
            "Crime e Castigo",
            "Memórias Póstumas de Brás Cubas",
            "Fahrenheit 451",
            "O Sol é para Todos",
            "Dom Quixote",
            "O Retrato de Dorian Gray",
            "Lolita",
            "O Grande Gatsby",
            "Os Miseráveis",
            "O Morro dos Ventos Uivantes",
            "Admirável Mundo Novo",
            "Os Homens que Não Amavam as Mulheres",
            "O Conde de Monte Cristo",
            "A Moreninha",
        };
        return livros;
    }
    public ArrayList setAuthor()
    {
        autores = new ArrayList()
        {
            "George Orwell",
            "Jane Austen",
            "Gabriel García Márquez",
            "J.R.R. Tolkien",
            "J.D. Salinger",
            "John Green",
            "J.R.R. Tolkien",
            "Dan Brown",
            "J.K. Rowling",
            "George Orwell",
            "Machado de Assis",
            "Franz Kafka",
            "Paulo Coelho",
            "Liev Tolstói",
            "Antoine de Saint-Exupéry",
            "Markus Zusak",
            "Fiódor Dostoiévski",
            "Machado de Assis",
            "Ray Bradbury",
            "Harper Lee",
            "Miguel de Cervantes",
            "Oscar Wilde",
            "Vladimir Nabokov",
            "F. Scott Fitzgerald",
            "Victor Hugo",
            "Emily Brontë",
            "Aldous Huxley",
            "Stieg Larsson",
            "Alexandre Dumas",
            "Joaquim Manuel de Macedo"
        };
        return autores;
    }
    public ArrayList setSinopse()
    {
        sinopse = new ArrayList()
        {
            "Um futuro distópico onde a vigilância do Estado é onipresente.",
            "A história de amor entre Elizabeth Bennet e Mr. Darcy.",
            "A saga de uma família na fictícia Macondo.",
            "Uma jornada épica de um hobbit para recuperar um tesouro.",
            "A história de um adolescente em conflito com a sociedade.",
            "Uma história de amor e perda entre dois adolescentes com câncer.",
            "Uma jornada para destruir um anel maligno.",
            "Um mistério envolvendo símbolos ocultos em obras de arte.",
            "A jornada do jovem bruxo Harry Potter.",
            "Uma sátira política sobre o totalitarismo.",
            "O romance de Bentinho e Capitu, marcado pela dúvida e ciúme.",
            "A transformação de um homem em um inseto.",
            "A busca espiritual de um pastor em busca de um tesouro.",
            "O romance entre Anna e o Conde Vronsky.",
            "As aventuras de um pequeno príncipe pelo universo.",
            "A história de Liesel Meminger durante a Segunda Guerra Mundial.",
            "O crime e o castigo do ex-estudante Raskólnikov.",
            "As reflexões de um defunto sobre sua própria vida.",
            "Um futuro onde os livros são queimados.",
            "Uma criança aprende lições sobre empatia e moralidade.",
            "As aventuras do cavaleiro Dom Quixote.",
            "O retrato que envelhece enquanto seu dono permanece jovem.",
            "A obsessão de um homem por uma jovem ninfeta.",
            "Os excessos e extravagâncias da alta sociedade na década de 1920.",
            "A história de Jean Valjean e sua redenção.",
            "O amor e ódio entre Heathcliff e Catherine.",
            "Uma sociedade futurista baseada na felicidade obrigatória.",
            "O desaparecimento de uma jovem e o mistério que a rodeia.",
            "As aventuras de Edmond Dantès em busca de vingança.",
            "O romance entre Augusto e Carolina."
        };
        return sinopse;
    }
    public ArrayList setPages()
    {
        paginas = new ArrayList()
        {
            328,
            424,
            417,
            320,
            288,
            288,
            576,
            464,
            309,
            336,
            256,
            208,
            208,
            864,
            128,
            480,
            592,
            256,
            256,
            368,
            992,
            784,
            384,
            336,
            232,
            1504,
            416,
            272,
            528,
            720,
            280
        };
        return paginas;
    }
    public class Rewards
    {
        public int getPoints()
        {
            StreamReader sr = new StreamReader("c:\\temp\\points.txt");
            string s = sr.ReadToEnd();
            int x = Convert.ToInt32(s);
            sr.Close();
            Console.WriteLine(x);
            return x;
        }
        public string get_Trofeus()
        {
            StreamReader sr = new StreamReader("c:\\temp\\trofeus.txt");
            string x = sr.ReadToEnd();
            sr.Close();
            Console.WriteLine("Trofeus:\n " + x);
            return x;
        }
    }
    public ArrayList setTrofeus()
    {
        trofeus = new ArrayList()
        {
             "O Herói Sem Medo",
            "Aventuras nas Selvas de Papel",
            "O Mestre das Palavras",
            "A Busca pelo Tesouro Literário",
            "Desbravador de Terras Fantásticas",
            "O Alquimista dos Desafios",
            "O Explorador das Mil e Uma Páginas",
            "Guardião dos Livros Perdidos",
            "O Apanhador de Conquistas",
            "As Crônicas da Coragem",
            "O Peregrino da Imaginação",
            "O Caçador de Enigmas",
            "O Estrategista da Literatura",
            "O Desvendador de Mistérios",
            "O Arquiteto das Histórias",
            "O Navegador do Desconhecido",
            "O Arqueólogo das Palavras",
            "O Andarilho dos Livros",
            "O Capitão das Aventuras",
            "O Senhor das Conquistas",
            "O Mensageiro das Páginas",
            "O Cavaleiro das Proezas",
            "O Escudeiro das Jornadas",
            "O Dom Quixote das Realizações",
            "O Guardião do Conhecimento",
            "O Arquiteto do Saber",
            "O Escritor do Destino",
            "O Desafiante das Histórias",
            "O Poeta das Vitórias",
            "O Visionário Literário",
            "O Explorador dos Livros",
            "O Domador das Palavras",
            "O Forasteiro das Letras",
            "O Conquistador das Estórias",
            "O Viajante do Conhecimento",
            "O Semeador de Conquistas",
            "O Colosso das Narrativas",
            "O Estrategista das Páginas",
            "O Tesouro da Literatura",
            "O Arquiteto das Epopeias",
            "O Condutor das Aventuras",
            "O Escultor das Tramas",
            "O Sábio das Histórias",
            "O Líder das Escrituras",
            "O Explorador das Bibliotecas",
            "O Arquiteto dos Mundos",
            "O Cavaleiro Andante da Leitura",
            "O Diamante Bruto dos Livros",
            "O Pioneiro da Literatura",
            "O Conquistador dos Clássicos",
            "O Visionário da Imaginação",
            "O Guardião da Sabedoria",
            "O Explorador dos Universos Literários",
            "O Trovador das Conquistas",
            "O Sábio do Conhecimento",
            "O Detetive das Páginas",
            "O Artífice das Conquistas",
            "O Comandante das Letras",
            "O Estrategista das Narrativas",
            "O Explorador dos Mares da Imaginação",
            "O Guerreiro das Histórias",
            "O Arquiteto das Fábulas",
            "O Alquimista das Letras",
            "O Sábio das Páginas",
            "O Trovador dos Contos",
            "O Escritor das Lendas",
            "O Sultão dos Livros",
            "O Conquistador das Páginas",
            "O Visionário dos Sonhos Literários",
            "O Imperador das Conquistas",
            "O Luminar dos Livros",
            "O Trovador das Aventuras",
            "O Almirante das Palavras",
            "O Colecionador das Obras-primas",
            "O Desbravador das Histórias",
            "O Arquiteto dos Enredos",
            "O Conquistador das Epopeias",
            "O Dom Quixote das Conquistas Literárias",
            "O Cavaleiro das Palavras",
            "O Sábio dos Livros"
        };
        return trofeus;

    }

    public void ShowAll()
    {
        Rewards rewards = new Rewards();
        object result = "";
        Random r = new Random();
        ArrayList livros0 = setBooks();
        ArrayList autores0 = setAuthor();
        ArrayList sinopse0 = setSinopse();
        ArrayList paginas0 = setPages();
        ArrayList trofeus = setTrofeus();
        int escolha;

        while (!int.TryParse(Console.ReadLine(), out escolha) || escolha < 1 || escolha > 30)
        {
            if(escolha == 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, escolha um número de 1 a 30:");
            }
        }
        Console.WriteLine($"\t\tLivro: {livros0[escolha - 1]}\n");
        Console.WriteLine($"\t\tAutor: {autores0[escolha - 1]}\n");
        Console.WriteLine($"\t\tSinopse: {sinopse0[escolha - 1]}\n");
        Console.WriteLine($"\t\tNúmero de Páginas: {paginas0[escolha - 1]}\n");

        Console.WriteLine("\t\tDeseja marcar leitura do livro?\n\t\ts/n");
        string l = Console.ReadLine();
        if(l == "s")
        {
            int v = r.Next(10, 30);
            int d = r.Next(0, 79);
            int z = r.Next(1,3);

            int m = rewards.getPoints();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\t\tVocê ganhou {v} Pontos!");
            Console.ForegroundColor = ConsoleColor.White;

            m += v;
            StreamWriter sw = new StreamWriter("c:\\temp\\points.txt");
            sw.WriteLine(m);
            sw.Close();


            if(z == 2)
            {
                StreamWriter sv = new StreamWriter("c:\\temp\\trofeus.txt", true);
                result = trofeus[d];
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\t\tVocê recebeu o troféu {result}!");
                Console.ForegroundColor = ConsoleColor.White;
                sv.WriteLine(result);
                sv.Close();
            }
        }
        else if(l == "n")
        {
            Console.WriteLine("\t\tObrigado pelo feedback!");
        }
    }

}
public class Tables {

    public static void Table_InitialPage()
    {
        Console.ForegroundColor= ConsoleColor.Cyan;
        Console.WriteLine("\t\t\t _______________________________________________________________");
        Console.WriteLine("\t\t\t| \t \t\t\t\t\t\t\t|");
        Console.WriteLine("\t\t\t| \t\tDigite um número para realizar\t\t\t|");
        Console.WriteLine("\t\t\t|\t\t\to comando:\t\t\t\t|");
        Console.WriteLine("\t\t\t| \t\t\t\t\t\t\t\t|");
        Console.WriteLine("\t\t\t| \t    0-Acessar Lista de Exemplares\t\t\t|");
        Console.WriteLine("\t\t\t| \t    1-Acessar Página do Usuário\t\t\t\t|");
        Console.WriteLine("\t\t\t| \t    2-Acessar o Ranking\t\t\t\t\t|   ");
        Console.WriteLine("\t\t\t| \t    3-Desligar Sistema \t\t\t\t\t|   ");
        Console.WriteLine("\t\t\t| \t\t\t\t\t\t\t\t|");
        Console.WriteLine("\t\t\t| \t\t\t\t\t\t\t\t|");
        Console.WriteLine("\t\t\t|_______________________________________________________________|");
        Console.ForegroundColor = ConsoleColor.White;
    }
    public static void Table_BooksPage()
    {
        int i = 1;
        Console.ForegroundColor = ConsoleColor.Cyan;
        Books books = new Books();
        ArrayList l = books.setBooks();
        Console.WriteLine("\t\t\t\t\tLista de Exemplares:");
        Console.Write("\t\t\t_______________________________________________________________\n\t\t\t|\n");
        foreach (object x in l)
        {
            Console.Write($"\t\t\t|\t\t{i++}-" + x + "\n");
        }
        Console.Write("\t\t\t|______________________________________________________________\n\n");
        Console.ForegroundColor = ConsoleColor.White;
    }
    public static void Table_User(string username, int points, string [] trofeus)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\t\t\t\t\t\t   User Lobby:\n\t\t\t _______________________________________________________________");

        for(int i = 0; i< 3; i++) 
            Console.WriteLine($"\t\t\t|\t\t\t\t\t\t\t\t|");
        
        Console.WriteLine($"\t\t\t|\t /  \\\t     Username: {username}\t\t\t\t|");
        Console.WriteLine($"\t\t\t|       |    |\t     \t\t\t\t\t\t|");
        Console.WriteLine($"\t\t\t|\t \\__/\t     Points:   {points}\t\t\t\t|");
        Console.WriteLine($"\t\t\t|       ______\t\t\t\t\t\t\t|");
        Console.WriteLine($"\t\t\t|      /______\\\t     Rank:     {847}\t\t\t\t|");

        for (int i = 0; i < 3; i++)
            Console.WriteLine($"\t\t\t|\t\t\t\t\t\t\t\t|");

        Console.WriteLine($"\t\t\t|_______________________________________________________________|");
        Console.ForegroundColor= ConsoleColor.Yellow;
        Console.WriteLine($"\n\t\t\t\t\t\t  Seus Trofeus:\n");
        int g = 1;
        foreach(object x in trofeus)
        {
            
            Console.WriteLine($"\t\t\t\t\t    {g}-{x}");
            g++;
        }
        Console.ForegroundColor = ConsoleColor.White;
    }
}
public class Rank
{
    private ArrayList al;
    public void Pessoas()
    {
        int x = 1, y = 15030;
        al = new ArrayList()
        {
            "User123",
            "Leonard",
            "GamerGirl42",
            "CoolCoder",
            "NinjaMaster",
            "AwesomeDude",
            "GeekyGamer",
            "SneakyNinja",
            "CodingWizard",
            "TechGuru"

    };

        Console.WriteLine("\t\t\t\t\t\t-Top 10 Leitores:\n");
        for(int i = 0;i < 10; i++)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\t\t\t\t\t" + (x++)+ $"-{al[i]}\t\tPontos:{y}\n\n");
            y -= 317;
        }
        Console.ForegroundColor = ConsoleColor.White;
    }
}

public class UserProfile :  Books.Rewards
{
    public string Username()
    {
        return "lucas";
    }
    public void PrintTable()
    {
        string trofeus = get_Trofeus();
        string[] values = trofeus.Split('\n');
        string username = Username();
        int points = getPoints();
        Tables.Table_User(username,points,values);
    }
}

public class ITA
{
    public static void Commands()
    {
        try
        {
            Rank r = new Rank();
            Books b = new Books();  
            while (true)
            {
                string s = Console.ReadLine();
                if (s == "0")
                {
                    Tables.Table_BooksPage();
                    Console.WriteLine("\t\tDeseja ver as informações de algum exemplar digite o número do livro que quer ver\n\t\tcaso contrario digite 0:");
                    b.ShowAll();
                    Tables.Table_InitialPage();
                }
                else if (s == "1")
                {
                    UserProfile user = new UserProfile();
                    user.PrintTable();
                    Console.WriteLine("\n\t\t\tPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    Tables.Table_InitialPage();
                }
                else if (s == "2")
                {
                    r.Pessoas();
                    Tables.Table_InitialPage();
                }
                else if (s == "3")
                {
                    Console.WriteLine("\t\tAté a proxima leitura :)!");
                    Thread.Sleep(500);
                    break;
                }
                else
                {
                    Console.WriteLine($"{s} não é um número válido");
                }
            }
        }
        catch
        {
            //Console.WriteLine("Erro em Commands()");
        }
    }
    public static void Main()
    {
            StreamWriter s = new StreamWriter("c:\\temp\\points.txt",true);
            StreamWriter w = new StreamWriter("c:\\temp\\trofeus.txt",true);
            s.Close();
            w.Close();
           // Login login = new Login();
           //login.GetLogin();
            Tables.Table_InitialPage();
            Commands();
    }
}