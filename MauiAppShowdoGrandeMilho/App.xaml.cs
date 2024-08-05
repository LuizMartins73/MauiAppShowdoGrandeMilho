using MauiAppShowdoGrandeMilho.Models;

namespace MauiAppShowdoGrandeMilho
{
    public partial class App : Application
    {
        List<Pergunta> perguntas_faceis = new()
        {
            new Pergunta
{
    Id=1,
    Enunciado = "Em que estado brasileiro nasceu a apresentadora Xuxa?",
    Alternativas = new()
    {
        new Alternativa { Correta = false, Descricao = "Rio de Janeiro" },
        new Alternativa { Correta = true, Descricao = "Rio Grande do Sul" },
        new Alternativa { Correta = false, Descricao = "Santa Catarina" },
        new Alternativa { Correta = false, Descricao = "Goiás" },
    }
},

new Pergunta
{
    Id=2,
    Enunciado = "Qual era o apelido da cantora Elis Regina?",
    Alternativas = new()
    {
        new Alternativa { Correta = false, Descricao = "Gauchinha" },
        new Alternativa { Correta = false, Descricao = "Paulistinha" },
        new Alternativa { Correta = true, Descricao = "Pimentinha" },
        new Alternativa { Correta = false, Descricao = "Andorinha" },
    }
},

new Pergunta
{
    Id=3,
    Enunciado = "Quem é a namorada do Mickey?",
    Alternativas = new()
    {
        new Alternativa { Correta = false, Descricao = "Margarida" },
        new Alternativa { Correta = true, Descricao = "Minnie" },
        new Alternativa { Correta = false, Descricao = "A Pequena Sereia" },
        new Alternativa { Correta = false, Descricao = "Olívia Palito" },
    }
},

new Pergunta
{
    Id=4,
    Enunciado = "Qual é o personagem do folclore brasileiro que tem uma perna só?",
    Alternativas = new()
    {
        new Alternativa { Correta = false, Descricao = "Cuca" },
        new Alternativa { Correta = false, Descricao = "Negrinho do Pastoreio" },
        new Alternativa { Correta = false, Descricao = "Boitatá" },
        new Alternativa { Correta = true, Descricao = "Saci-Pererê" },
    }
},

new Pergunta
{
    Id=5,
    Enunciado = "Fidel Castro nasceu em que país?",
    Alternativas = new()
    {
        new Alternativa { Correta = false, Descricao = "Jamaica" },
        new Alternativa { Correta = true, Descricao = "Cuba" },
        new Alternativa { Correta = false, Descricao = "El Salvador" },
        new Alternativa { Correta = false, Descricao = "México" },
    }
},

new Pergunta
{
    Id=6,
    Enunciado = "Quem proclamou a república no Brasil em 1889?",
    Alternativas = new()
    {
        new Alternativa { Correta = false, Descricao = "Duque de Caxias" },
        new Alternativa { Correta = false, Descricao = "Marechal Rondon" },
        new Alternativa { Correta = false, Descricao = "Dom Pedro II" },
        new Alternativa { Correta = true, Descricao = "Marechal Deodoro" },
    }
},

new Pergunta
{
    Id=7,
    Enunciado = "Quem é o patrono do exército brasileiro?",
    Alternativas = new()
    {
        new Alternativa { Correta = false, Descricao = "Marechal Deodoro" },
        new Alternativa { Correta = false, Descricao = "Barão de Mauá" },
        new Alternativa { Correta = true, Descricao = "Duque de Caxias" },
        new Alternativa { Correta = false, Descricao = "Marquês de Pombal" },
    }
},

new Pergunta
{
    Id=8,
    Enunciado = "Quem era o apresentador que reprovava os calouros tocando uma buzina?",
    Alternativas = new()
    {
        new Alternativa { Correta = false, Descricao = "Raul Gil" },
        new Alternativa { Correta = false, Descricao = "Bolinha" },
        new Alternativa { Correta = true, Descricao = "Flávio Cavalcanti" },
        new Alternativa { Correta = false, Descricao = "Silvio Santos" },
    }
},

new Pergunta
{
    Id=9,
    Enunciado = "Qual é o menor estado brasileiro em extensão territorial?",
    Alternativas = new()
    {
        new Alternativa { Correta = false, Descricao = "Rio de Janeiro" },
        new Alternativa { Correta = false, Descricao = "Alagoas" },
        new Alternativa { Correta = false, Descricao = "Sergipe" },
        new Alternativa { Correta = true, Descricao = "Distrito Federal" },
    }
},

new Pergunta
{
    Id=10,
    Enunciado = "Quem pintou 'Guernica'?",
    Alternativas = new()
    {
        new Alternativa { Correta = false, Descricao = "Leonardo da Vinci" },
        new Alternativa { Correta = false, Descricao = "Michelangelo" },
        new Alternativa { Correta = true, Descricao = "Pablo Picasso" },
        new Alternativa { Correta = false, Descricao = "Salvador Dalí" },
    }
},

new Pergunta
{
    Id=11,
    Enunciado = "Qual é o nome do fundador da Microsoft?",
    Alternativas = new()
    {
        new Alternativa { Correta = true, Descricao = "Bill Gates" },
        new Alternativa { Correta = false, Descricao = "Steve Jobs" },
        new Alternativa { Correta = false, Descricao = "Elon Musk" },
        new Alternativa { Correta = false, Descricao = "Larry Page" },
    }
},

new Pergunta
{
    Id=12,
    Enunciado = "Quem é o autor de 'Dom Casmurro'?",
    Alternativas = new()
    {
        new Alternativa { Correta = true, Descricao = "Machado de Assis" },
        new Alternativa { Correta = false, Descricao = "José de Alencar" },
        new Alternativa { Correta = false, Descricao = "Jorge Amado" },
        new Alternativa { Correta = false, Descricao = "Clarice Lispector" },
    }
},

new Pergunta
{
    Id=13,
    Enunciado = "Qual é a capital do estado do Amazonas?",
    Alternativas = new()
    {
        new Alternativa { Correta = true, Descricao = "Manaus" },
        new Alternativa { Correta = false, Descricao = "Belém" },
        new Alternativa { Correta = false, Descricao = "Porto Velho" },
        new Alternativa { Correta = false, Descricao = "Rio Branco" },
    }
},

new Pergunta
{
    Id=14,
    Enunciado = "Quem foi o primeiro homem a pisar na Lua?",
    Alternativas = new()
    {
        new Alternativa { Correta = false, Descricao = "Yuri Gagarin" },
        new Alternativa { Correta = false, Descricao = "Buzz Aldrin" },
        new Alternativa { Correta = true, Descricao = "Neil Armstrong" },
        new Alternativa { Correta = false, Descricao = "John Glenn" },
    }
},

new Pergunta
{
    Id=15,
    Enunciado = "Qual é o maior planeta do sistema solar?",
    Alternativas = new()
    {
        new Alternativa { Correta = true, Descricao = "Júpiter" },
        new Alternativa { Correta = false, Descricao = "Saturno" },
        new Alternativa { Correta = false, Descricao = "Terra" },
        new Alternativa { Correta = false, Descricao = "Marte" },
    }
},

new Pergunta
{
    Id=16,
    Enunciado = "Quem escreveu 'O Pequeno Príncipe'?",
    Alternativas = new()
    {
        new Alternativa { Correta = true, Descricao = "Antoine de Saint-Exupéry" },
        new Alternativa { Correta = false, Descricao = "Victor Hugo" },
        new Alternativa { Correta = false, Descricao = "Marcel Proust" },
        new Alternativa { Correta = false, Descricao = "Albert Camus" },
    }
},

new Pergunta
{
    Id=17,
    Enunciado = "Qual é o símbolo químico do ouro?",
    Alternativas = new()
    {
        new Alternativa { Correta = true, Descricao = "Au" },
        new Alternativa { Correta = false, Descricao = "Ag" },
        new Alternativa { Correta = false, Descricao = "Fe" },
        new Alternativa { Correta = false, Descricao = "Pb" },
    }
},

new Pergunta
{
    Id=18,
    Enunciado = "Quem foi o 16º presidente dos Estados Unidos?",
    Alternativas = new()
    {
        new Alternativa { Correta = true, Descricao = "Abraham Lincoln" },
        new Alternativa { Correta = false, Descricao = "George Washington" },
        new Alternativa { Correta = false, Descricao = "Theodore Roosevelt" },
        new Alternativa { Correta = false, Descricao = "Thomas Jefferson" },
    }
},

new Pergunta
{
    Id=19,
    Enunciado = "Qual é o maior oceano do mundo?",
    Alternativas = new()
    {
        new Alternativa { Correta = true, Descricao = "Oceano Pacífico" },
        new Alternativa { Correta = false, Descricao = "Oceano Atlântico" },
        new Alternativa { Correta = false, Descricao = "Oceano Índico" },
        new Alternativa { Correta = false, Descricao = "Oceano Antártico" },
    }
},

new Pergunta
{
    Id=20,
    Enunciado = "Quem pintou a Mona Lisa?",
    Alternativas = new()
    {
        new Alternativa { Correta = true, Descricao = "Leonardo da Vinci" },
        new Alternativa { Correta = false, Descricao = "Vincent van Gogh" },
        new Alternativa { Correta = false, Descricao = "Claude Monet" },
        new Alternativa { Correta = false, Descricao = "Pablo Picasso" },
    }
},
        } ;
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
