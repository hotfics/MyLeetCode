  public static bool ValidMountainArray(int[] A)
        {
			//too many edge condition..
            int l = A.Length;
            if (l < 3)
            {
                return false;
            }
            int i = 0, j = l - 1;
            while ((i + 1 < l) && (A[i] - A[i + 1] < 0))
            {
                i++;
            }
            if (i + 1 < l)
            {
                if (A[i] - A[i + 1] == 0) return false;
            }
            while ((j - 1 > 0) && (A[j] - A[j - 1] < 0))
            {
                j--;
            }
            if ((i + 1 == l) && (i != j))
            { return false; }

            if ((j - 1 == 0) && (i != j))
            {
                return false;
            }
            if (A[j] - A[j - 1] == 0) return false;
            if ((i == j) && (i != 0) && (j != l - 1))
            {
                return true;
            }
            return false;



        }
