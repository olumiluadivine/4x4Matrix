static void Determinant()
{
    bool end = false;
    int[,] matrix = new int[4, 4];
    while (true)
    {
        try
        {
            for (int i = 0; i < 4; i++)
            {
                int j = 0;
                Console.Write($"Enter first element for row {i + 1} and column {j + 1}: ");
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Enter first element for row {i + 1} and column {j + 2}: ");
                matrix[i, j+1] = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Enter first element for row {i + 1} and column {j + 3}: ");
                matrix[i, j+2] = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Enter first element for row {i + 1} and column {j + 4}: ");
                matrix[i, j+3] = Convert.ToInt32(Console.ReadLine());
            }
            end = true;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            continue;
        }
        if (end)
        {
            break;
        }
    }

    double line1 = 
        matrix[0, 0] * (
        (matrix[1, 1] * (matrix[2, 2] * matrix[3, 3] - matrix[2, 3] * matrix[3, 2])) -
        (matrix[1, 2] * (matrix[2, 1] * matrix[3, 3] - matrix[2, 3] * matrix[3, 1])) +
        (matrix[1, 3] * (matrix[2, 1] * matrix[3, 2] - matrix[2, 2] * matrix[3, 1]))
        );

    double line2 =
        matrix[0, 1] * (
        (matrix[1, 0] * (matrix[2, 2] * matrix[3, 3] - matrix[2, 3] * matrix[3, 2])) -
        (matrix[1, 2] * (matrix[2, 0] * matrix[3, 3] - matrix[2, 3] * matrix[3, 0])) +
        (matrix[1, 3] * (matrix[2, 0] * matrix[3, 2] - matrix[2, 2] * matrix[3, 0]))
        );

    double line3 =
        matrix[0, 2] * (
        (matrix[1, 0] * (matrix[2, 1] * matrix[3, 3] - matrix[2, 3] * matrix[3, 2])) -
        (matrix[1, 1] * (matrix[2, 0] * matrix[3, 3] - matrix[2, 3] * matrix[3, 0])) +
        (matrix[1, 3] * (matrix[2, 0] * matrix[3, 1] - matrix[2, 1] * matrix[3, 0]))
        );

    double line4 =
        matrix[0, 3] * (
        (matrix[1, 0] * (matrix[2, 1] * matrix[3, 2] - matrix[2, 2] * matrix[3, 1])) -
        (matrix[1, 1] * (matrix[2, 0] * matrix[3, 2] - matrix[2, 2] * matrix[3, 0])) +
        (matrix[1, 2] * (matrix[2, 0] * matrix[3, 1] - matrix[2, 1] * matrix[3, 0]))
        );

    double answer = line1 - line2 + line3 - line4;
    Console.WriteLine($"The |M| of the matrix is {answer}");
}

Determinant();