using System;

class Program
{
    static int N = 5; // tamanho do labirinto
    static int[,] labirinto = {
        {1, 0, 0, 0, 0},
        {1, 1, 0, 1, 1},
        {0, 1, 0, 0, 1},
        {1, 1, 1, 1, 1},
        {0, 0, 0, 1, 1}
    };

    static int[,] solucao = new int[5, 5];

    static bool ResolverLabirinto(int x, int y)
    {
        // Se chegou ao destino
        if (x == N - 1 && y == N - 1 && labirinto[x, y] == 1)
        {
            solucao[x, y] = 1;
            return true;
        }

        // Verifica se posição é válida
        if (PosicaoValida(x, y))
        {
            // Marca como parte da solução
            solucao[x, y] = 1;

            // Move para baixo
            if (ResolverLabirinto(x + 1, y))
                return true;

            // Move para direita
            if (ResolverLabirinto(x, y + 1))
                return true;

            // Se não deu certo, volta atrás (backtracking)
            solucao[x, y] = 0;
            return false;
        }

        return false;
    }

    static bool PosicaoValida(int x, int y)
    {
        return (x >= 0 && x < N && y >= 0 && y < N && labirinto[x, y] == 1);
    }

    static void Main(string[] args)
    {
        if (ResolverLabirinto(0, 0))
        {
            Console.WriteLine("Caminho encontrado:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                    Console.Write(solucao[i, j] + " ");
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Não existe caminho no labirinto.");
        }
    }
}