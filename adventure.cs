using System.IO.Pipes;
using System.Reflection.Metadata.Ecma335;
public class Sala
{
    public int num;
    public int posiçãoX;
    public int posiçãoY;
    public int saidas;
    public int[] possaidasX;
    public int[] possaidasY;
    public int altura;
    public int largura;
    public int chaveX;
    public int chaveY;
    public int altarX;
    public int altarY;
    public int caliceX;
    public int caliceY;
    public Sala(int num, int posiçãoX, int posiçãoY, int saidas, int[] possaidasX, int[] possaidasY, int altura, int largura, Boolean chave, int chaveX, int chaveY, Boolean altar, int altarX, int altarY, Boolean calice, int caliceX, int caliceY)
    {
        this.num = num;
        this.posiçãoX = posiçãoX;
        this.posiçãoY = posiçãoY;
        this.saidas = saidas;
        this.possaidasX = possaidasX;
        this.possaidasY = possaidasY;
        this.altura = altura;
        this.largura = largura;
        if (chave)
        {
            this.chaveX = chaveX;
            this.chaveY = chaveY;
        }
        if (altar)
        {
            this.altarX = altarX;
            this.altarY = altarY;
        }
        if (calice)
        {
            this.caliceX = caliceX;
            this.caliceY = caliceY;
        }
    }

}
public class Dragão
{
    public string nome;
    public int spawnX;
    public int spawnY;
    public int sala;
    public string cor;
    public Boolean vivo;

    public Dragão(string nome, int spawnX, int spawnY, int sala, string cor, Boolean vivo)
    {
        this.nome = nome;
        this.spawnX = spawnX;
        this.spawnY = spawnY;
        this.sala = sala;
        this.cor = cor;
        this.vivo = vivo;
    }

};
public class Program
{
    static void mapa(Sala sala)
    {
        for (int a = 0; a <= sala.altura; a++)
        {
            for (int l = 0; l <= sala.largura; l++)
            {
                bool ehSaida = false;

                for (int i = 0; i < sala.saidas; i++)
                {
                    if (l == sala.possaidasX[i] && a == sala.possaidasY[i])
                    {
                        ehSaida = true;
                        break;
                    }
                }

                if (ehSaida)
                {
                    Console.Write(" * ");
                }
                else if (a == 0 || a == sala.altura || l == 0 || l == sala.largura)
                {
                    Console.Write(" # ");
                }
                else
                {
                    Console.Write("   ");
                }
            }

            Console.WriteLine();
        }
    }

    public static void Main()
    {
        int A = 20;
        int L = 20;
        Dragão eddy = new Dragão("eddy", 10, 20, 1, "red", true);
        Dragão kaike = new Dragão("kaike", 15, 20, 2, "yellow", true);
        Dragão marcos = new Dragão("marcos", 20, 20, 3, "green", true);

        Sala numero1 = new Sala(1, 1, 1, 1, new[] { L / 2 }, new[] { A }, A, L, false, 0, 0, true, L / 2, A / 2, false, 0, 0);
        Sala numero2 = new Sala(2, 1, 2, 2, new[] { L / 2, L }, new[] { 0, A / 2 }, A, L, false, 0, 0, false, 0, 0, false, 0, 0);
        Sala numero3 = new Sala(3, 2, 2, 3, new[] { 0, L / 2, L }, new[] { A / 2, 0, A / 2 }, A, L, false, 0, 0, false, 0, 0, false, 0, 0);
        Sala numero4 = new Sala(4,2,1,2,new[] {L/2,L}, new[]{A,A/2},A,L,false,0,0,false,0,0,false,0,0);
        Sala numero5 = new Sala(5,3,1,1,new[] {0},new[] {A/2},L,A,true,L/2,A/2,false,0,0,false,0,0);

    }
}