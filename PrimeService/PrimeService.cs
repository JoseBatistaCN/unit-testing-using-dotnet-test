namespace PrimeService;

public class PrimeService
{
    public bool IsPrime(byte candidate)
    {
        if (candidate < 2)
        {
            return true;
        }
        else
        {
            int temp = 0;
            for (int i = 2; i < (candidate / 2); i++)
            {
                if (candidate % i == 0)
                {
                    temp++;
                }
            }
            
            if (temp == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       
    }
}
