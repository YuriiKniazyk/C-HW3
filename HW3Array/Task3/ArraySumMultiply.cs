namespace Task3
{
    public class ArraySumMultiply
    {
        public SumMultiply GetArraySumMulti(int [] array)
        {
            int sum = 0;
            int multiply = 1;
            bool isAllPositive = true;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] <= 0)
                {
                    isAllPositive = false;
                }

                if (i < array.Length / 2 && isAllPositive)
                {
                    sum += array[i];
                    multiply = 1;
                }
                else if (i >= array.Length / 2 && !isAllPositive)
                {
                    multiply *= array[i];
                    sum = 0;
                }
            }

            return new SumMultiply
            {
                Multiply = multiply, 
                Sum = sum
            };

        }
    }
}
