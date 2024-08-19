using MauiAppShowdoGrandeMilho.Models;

namespace MauiAppShowdoGrandeMilho
{
    public partial class App : Application
    {
        static List<Pergunta> perguntas_faceis = new()
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

        static List<Pergunta> perguntas_medias = new()
        {
            new Pergunta
{
    Id=21,
    Enunciado = "Qual é a maior floresta tropical do mundo?",
    Alternativas = new()
    {
        new Alternativa { Correta = true, Descricao = "Amazônia" },
        new Alternativa { Correta = false, Descricao = "Floresta Negra" },
        new Alternativa { Correta = false, Descricao = "Floresta do Congo" },
        new Alternativa { Correta = false, Descricao = "Floresta de Sherwood" },
    }
},

new Pergunta
{
    Id=22,
    Enunciado = "Qual é o nome do escritor de 'Dom Quixote'?",
    Alternativas = new()
    {
        new Alternativa { Correta = true, Descricao = "Miguel de Cervantes" },
        new Alternativa { Correta = false, Descricao = "Gabriel García Márquez" },
        new Alternativa { Correta = false, Descricao = "Jorge Luis Borges" },
        new Alternativa { Correta = false, Descricao = "Mario Vargas Llosa" },
    }
},

new Pergunta
{
    Id=23,
    Enunciado = "Qual é o nome científico do ser humano?",
    Alternativas = new()
    {
        new Alternativa { Correta = true, Descricao = "Homo sapiens" },
        new Alternativa { Correta = false, Descricao = "Homo erectus" },
        new Alternativa { Correta = false, Descricao = "Homo habilis" },
        new Alternativa { Correta = false, Descricao = "Homo neanderthalensis" },
    }
},

new Pergunta
{
    Id=24,
    Enunciado = "Quem foi o primeiro homem a circunavegar o globo?",
    Alternativas = new()
    {
        new Alternativa { Correta = true, Descricao = "Fernão de Magalhães" },
        new Alternativa { Correta = false, Descricao = "Cristóvão Colombo" },
        new Alternativa { Correta = false, Descricao = "Vasco da Gama" },
        new Alternativa { Correta = false, Descricao = "Américo Vespúcio" },
    }
},

new Pergunta
{
    Id=25,
    Enunciado = "Qual é a moeda oficial do Japão?",
    Alternativas = new()
    {
        new Alternativa { Correta = true, Descricao = "Iene" },
        new Alternativa { Correta = false, Descricao = "Won" },
        new Alternativa { Correta = false, Descricao = "Yuan" },
        new Alternativa { Correta = false, Descricao = "Rupia" },
    }
},

new Pergunta
{
    Id=26,
    Enunciado = "Qual é o país mais populoso do mundo?",
    Alternativas = new()
    {
        new Alternativa { Correta = true, Descricao = "China" },
        new Alternativa { Correta = false, Descricao = "Índia" },
        new Alternativa { Correta = false, Descricao = "Estados Unidos" },
        new Alternativa { Correta = false, Descricao = "Indonésia" },
    }
},

new Pergunta
{
    Id=27,
    Enunciado = "Qual é o símbolo químico da prata?",
    Alternativas = new()
    {
        new Alternativa { Correta = true, Descricao = "Ag" },
        new Alternativa { Correta = false, Descricao = "Au" },
        new Alternativa { Correta = false, Descricao = "Pb" },
        new Alternativa { Correta = false, Descricao = "Fe" },
    }
},

new Pergunta
{
    Id=28,
    Enunciado = "Qual é o maior planeta do Sistema Solar?",
    Alternativas = new()
    {
        new Alternativa { Correta = true, Descricao = "Júpiter" },
        new Alternativa { Correta = false, Descricao = "Saturno" },
        new Alternativa { Correta = false, Descricao = "Urano" },
        new Alternativa { Correta = false, Descricao = "Netuno" },
    }
},

new Pergunta
{
    Id=29,
    Enunciado = "Qual é a principal língua falada na Austrália?",
    Alternativas = new()
    {
        new Alternativa { Correta = true, Descricao = "Inglês" },
        new Alternativa { Correta = false, Descricao = "Francês" },
        new Alternativa { Correta = false, Descricao = "Alemão" },
        new Alternativa { Correta = false, Descricao = "Mandarim" },
    }
},

new Pergunta
{
    Id=30,
    Enunciado = "Qual foi a primeira mulher a ganhar o Prêmio Nobel?",
    Alternativas = new()
    {
        new Alternativa { Correta = true, Descricao = "Marie Curie" },
        new Alternativa { Correta = false, Descricao = "Rosalind Franklin" },
        new Alternativa { Correta = false, Descricao = "Irène Joliot-Curie" },
        new Alternativa { Correta = false, Descricao = "Ada Lovelace" },
    }
},

new Pergunta
{
    Id=31,
    Enunciado = "Em que país se localiza Machu Picchu?",
    Alternativas = new()
    {
        new Alternativa { Correta = true, Descricao = "Peru" },
        new Alternativa { Correta = false, Descricao = "Bolívia" },
        new Alternativa { Correta = false, Descricao = "Equador" },
        new Alternativa { Correta = false, Descricao = "Chile" },
    }
},

new Pergunta
{
    Id=32,
    Enunciado = "Quem escreveu 'O Morro dos Ventos Uivantes'?",
    Alternativas = new()
    {
        new Alternativa { Correta = true, Descricao = "Emily Brontë" },
        new Alternativa { Correta = false, Descricao = "Charlotte Brontë" },
        new Alternativa { Correta = false, Descricao = "Jane Austen" },
        new Alternativa { Correta = false, Descricao = "Mary Shelley" },
    }
},

new Pergunta
{
    Id=33,
    Enunciado = "Em que país está localizada a Torre Eiffel?",
    Alternativas = new()
    {
        new Alternativa { Correta = true, Descricao = "França" },
        new Alternativa { Correta = false, Descricao = "Itália" },
        new Alternativa { Correta = false, Descricao = "Espanha" },
        new Alternativa { Correta = false, Descricao = "Alemanha" },
    }
},

new Pergunta
{
    Id=34,
    Enunciado = "Qual é a capital da Austrália?",
    Alternativas = new()
    {
        new Alternativa { Correta = true, Descricao = "Camberra" },
        new Alternativa { Correta = false, Descricao = "Sydney" },
        new Alternativa { Correta = false, Descricao = "Melbourne" },
        new Alternativa { Correta = false, Descricao = "Brisbane" },
    }
},

new Pergunta
{
    Id=35,
    Enunciado = "Qual é o nome do processo de conversão de água em vapor?",
    Alternativas = new()
    {
        new Alternativa { Correta = true, Descricao = "Evaporação" },
        new Alternativa { Correta = false, Descricao = "Condensação" },
        new Alternativa { Correta = false, Descricao = "Precipitação" },
        new Alternativa { Correta = false, Descricao = "Sublimação" },
    }
},

new Pergunta
{
    Id=36,
    Enunciado = "Qual é a montanha mais alta da África?",
    Alternativas = new()
    {
        new Alternativa { Correta = true, Descricao = "Kilimanjaro" },
        new Alternativa { Correta = false, Descricao = "Monte Quênia" },
        new Alternativa { Correta = false, Descricao = "Monte Meru" },
        new Alternativa { Correta = false, Descricao = "Monte Elgon" },
    }
},

new Pergunta
{
    Id=37,
    Enunciado = "Em que país está localizado o Monte Everest?",
    Alternativas = new()
    {
        new Alternativa { Correta = true, Descricao = "Nepal" },
        new Alternativa { Correta = false, Descricao = "China" },
        new Alternativa { Correta = false, Descricao = "Índia" },
        new Alternativa { Correta = false, Descricao = "Butão" },
    }
},

new Pergunta
{
    Id=38,
    Enunciado = "Qual é o elemento químico mais abundante no universo?",
    Alternativas = new()
    {
        new Alternativa { Correta = true, Descricao = "Hidrogênio" },
        new Alternativa { Correta = false, Descricao = "Oxigênio" },
        new Alternativa { Correta = false, Descricao = "Carbono" },
        new Alternativa { Correta = false, Descricao = "Hélio" },
    }
},

new Pergunta
{
    Id=39,
    Enunciado = "Em que continente fica a Antártida?",
    Alternativas = new()
    {
        new Alternativa { Correta = true, Descricao = "Antártida" },
        new Alternativa { Correta = false, Descricao = "África" },
        new Alternativa { Correta = false, Descricao = "América do Sul" },
        new Alternativa { Correta = false, Descricao = "Ásia" },
    }
},

new Pergunta
{
    Id=40,
    Enunciado = "Qual é o metal cujo símbolo químico é 'Fe'?",
    Alternativas = new()
    {
        new Alternativa { Correta = true, Descricao = "Ferro" },
        new Alternativa { Correta = false, Descricao = "Cobre" },
        new Alternativa { Correta = false, Descricao = "Prata" },
        new Alternativa { Correta = false, Descricao = "Ouro" },
    }
},


        };

        static List<Pergunta> perguntas_dificeis = new()
        {
            new Pergunta
{
    Id=41,
    Enunciado = "Qual é o elemento químico mais pesado da tabela periódica?",
    Alternativas = new()
    {
        new Alternativa { Correta = true, Descricao = "Urânio" },
        new Alternativa { Correta = false, Descricao = "Chumbo" },
        new Alternativa { Correta = false, Descricao = "Ouro" },
        new Alternativa { Correta = false, Descricao = "Osmium" },
    }
},

new Pergunta
{
    Id=42,
    Enunciado = "Qual é o nome do autor da obra 'Em Busca do Tempo Perdido'?",
    Alternativas = new()
    {
        new Alternativa { Correta = true, Descricao = "Marcel Proust" },
        new Alternativa { Correta = false, Descricao = "James Joyce" },
        new Alternativa { Correta = false, Descricao = "Thomas Mann" },
        new Alternativa { Correta = false, Descricao = "Franz Kafka" },
    }
},

new Pergunta
{
    Id=43,
    Enunciado = "Qual civilização construiu Machu Picchu?",
    Alternativas = new()
    {
        new Alternativa { Correta = true, Descricao = "Incas" },
        new Alternativa { Correta = false, Descricao = "Maias" },
        new Alternativa { Correta = false, Descricao = "Astecas" },
        new Alternativa { Correta = false, Descricao = "Olmecas" },
    }
},

new Pergunta
{
    Id=44,
    Enunciado = "Em que ano ocorreu a Revolução Francesa?",
    Alternativas = new()
    {
        new Alternativa { Correta = true, Descricao = "1789" },
        new Alternativa { Correta = false, Descricao = "1776" },
        new Alternativa { Correta = false, Descricao = "1815" },
        new Alternativa { Correta = false, Descricao = "1830" },
    }
},

new Pergunta
{
    Id=45,
    Enunciado = "Qual é a capital da Mongólia?",
    Alternativas = new()
    {
        new Alternativa { Correta = true, Descricao = "Ulaanbaatar" },
        new Alternativa { Correta = false, Descricao = "Astana" },
        new Alternativa { Correta = false, Descricao = "Bishkek" },
        new Alternativa { Correta = false, Descricao = "Tashkent" },
    }
},

new Pergunta
{
    Id=46,
    Enunciado = "Quem escreveu a obra 'Crime e Castigo'?",
    Alternativas = new()
    {
        new Alternativa { Correta = true, Descricao = "Fiódor Dostoiévski" },
        new Alternativa { Correta = false, Descricao = "Liev Tolstói" },
        new Alternativa { Correta = false, Descricao = "Nikolai Gógol" },
        new Alternativa { Correta = false, Descricao = "Anton Tchékhov" },
    }
},

new Pergunta
{
    Id=47,
    Enunciado = "Qual é a unidade de medida da resistência elétrica?",
    Alternativas = new()
    {
        new Alternativa { Correta = true, Descricao = "Ohm" },
        new Alternativa { Correta = false, Descricao = "Volt" },
        new Alternativa { Correta = false, Descricao = "Watt" },
        new Alternativa { Correta = false, Descricao = "Ampère" },
    }
},

new Pergunta
{
    Id=48,
    Enunciado = "Em que país se originou o Renascimento?",
    Alternativas = new()
    {
        new Alternativa { Correta = true, Descricao = "Itália" },
        new Alternativa { Correta = false, Descricao = "França" },
        new Alternativa { Correta = false, Descricao = "Inglaterra" },
        new Alternativa { Correta = false, Descricao = "Alemanha" },
    }
},

new Pergunta
{
    Id=49,
    Enunciado = "Qual é o maior deserto quente do mundo?",
    Alternativas = new()
    {
        new Alternativa { Correta = true, Descricao = "Saara" },
        new Alternativa { Correta = false, Descricao = "Deserto de Gobi" },
        new Alternativa { Correta = false, Descricao = "Deserto de Atacama" },
        new Alternativa { Correta = false, Descricao = "Deserto da Arábia" },
    }
},

new Pergunta
{
    Id=50,
    Enunciado = "Qual é o país mais antigo do mundo?",
    Alternativas = new()
    {
        new Alternativa { Correta = true, Descricao = "Egito" },
        new Alternativa { Correta = false, Descricao = "China" },
        new Alternativa { Correta = false, Descricao = "Grécia" },
        new Alternativa { Correta = false, Descricao = "Irã" },
    }
},

new Pergunta
{
    Id=51,
    Enunciado = "Quem pintou o teto da Capela Sistina?",
    Alternativas = new()
    {
        new Alternativa { Correta = true, Descricao = "Michelangelo" },
        new Alternativa { Correta = false, Descricao = "Leonardo da Vinci" },
        new Alternativa { Correta = false, Descricao = "Raphael" },
        new Alternativa { Correta = false, Descricao = "Donatello" },
    }
},

new Pergunta
{
    Id=52,
    Enunciado = "Qual é o nome do maior satélite natural de Saturno?",
    Alternativas = new()
    {
        new Alternativa { Correta = true, Descricao = "Titã" },
        new Alternativa { Correta = false, Descricao = "Europa" },
        new Alternativa { Correta = false, Descricao = "Io" },
        new Alternativa { Correta = false, Descricao = "Ganímedes" },
    }
},

new Pergunta
{
    Id=53,
    Enunciado = "Qual foi o imperador responsável pela construção do Coliseu em Roma?",
    Alternativas = new()
    {
        new Alternativa { Correta = true, Descricao = "Vespasiano" },
        new Alternativa { Correta = false, Descricao = "Nero" },
        new Alternativa { Correta = false, Descricao = "Augusto" },
        new Alternativa { Correta = false, Descricao = "Trajano" },
    }
},

new Pergunta
{
    Id=54,
    Enunciado = "Em que ano começou a Primeira Guerra Mundial?",
    Alternativas = new()
    {
        new Alternativa { Correta = true, Descricao = "1914" },
        new Alternativa { Correta = false, Descricao = "1912" },
        new Alternativa { Correta = false, Descricao = "1916" },
        new Alternativa { Correta = false, Descricao = "1918" },
    }
},

new Pergunta
{
    Id=55,
    Enunciado = "Qual é o oceano mais profundo do mundo?",
    Alternativas = new()
    {
        new Alternativa { Correta = true, Descricao = "Oceano Pacífico" },
        new Alternativa { Correta = false, Descricao = "Oceano Atlântico" },
        new Alternativa { Correta = false, Descricao = "Oceano Índico" },
        new Alternativa { Correta = false, Descricao = "Oceano Ártico" },
    }
},

new Pergunta
{
    Id=56,
    Enunciado = "Qual é o maior osso do corpo humano?",
    Alternativas = new()
    {
        new Alternativa { Correta = true, Descricao = "Fêmur" },
        new Alternativa { Correta = false, Descricao = "Tíbia" },
        new Alternativa { Correta = false, Descricao = "Úmero" },
        new Alternativa { Correta = false, Descricao = "Rádio" },
    }
},

new Pergunta
{
    Id=57,
    Enunciado = "Quem foi o primeiro ministro da unificação italiana?",
    Alternativas = new()
    {
        new Alternativa { Correta = true, Descricao = "Camillo Benso, Conde de Cavour" },
        new Alternativa { Correta = false, Descricao = "Giuseppe Garibaldi" },
        new Alternativa { Correta = false, Descricao = "Victor Emmanuel II" },
        new Alternativa { Correta = false, Descricao = "Giuseppe Mazzini" },
    }
},

new Pergunta
{
    Id=58,
    Enunciado = "Em que país ocorreu a Revolução de Outubro de 1917?",
    Alternativas = new()
    {
        new Alternativa { Correta = true, Descricao = "Rússia" },
        new Alternativa { Correta = false, Descricao = "França" },
        new Alternativa { Correta = false, Descricao = "China" },
        new Alternativa { Correta = false, Descricao = "Cuba" },
    }
},

new Pergunta
{
    Id=59,
    Enunciado = "Qual é a fórmula química da água pesada?",
    Alternativas = new()
    {
        new Alternativa { Correta = true, Descricao = "D2O" },
        new Alternativa { Correta = false, Descricao = "H2O" },
        new Alternativa { Correta = false, Descricao = "H3O" },
        new Alternativa { Correta = false, Descricao = "HO2" },
    }
},

new Pergunta
{
    Id=60,
    Enunciado = "Qual é o nome da doutrina que defende a ideia de que a alma humana é imortal e reencarna sucessivamente?",
    Alternativas = new()
    {
        new Alternativa { Correta = true, Descricao = "Reencarnacionismo" },
        new Alternativa { Correta = false, Descricao = "Fatalismo" },
        new Alternativa { Correta = false, Descricao = "Animismo" },
        new Alternativa { Correta = false, Descricao = "Transcendentalismo" },
    }
},
        };


    //Sorteador de perguntas:

        public static Pergunta getRandomPerguntaFacil()
        {
            Random r = new Random();

            int sorteado = r.Next(1, 20);

            return perguntas_faceis[sorteado];
        }

        public static Pergunta getRandomPerguntaMedia()
        {
            Random r = new Random();

            int sorteado = r.Next(21, 40);

            return perguntas_medias[sorteado];
        }

        public static Pergunta getRandomPerguntaDificil()
        {
            Random r = new Random();

            int sorteado = r.Next(41, 60);

            return perguntas_dificeis[sorteado];
        }
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
