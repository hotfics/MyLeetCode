if (n < 10) {
			return 0;
		}
		int pro;
		var sum = 0;
		if (n.ToString().IndexOf('0') != -1) {
			pro = 0;
			while (n != 0) {
			
				var p = n % 10;
		 
				sum = sum + p;
				n = n / 10;
			}
		} else {
			pro = 1;
			sum = 0;
			while (n != 0) {
			
				var p = n % 10;
				pro = pro * p;
				sum = sum + p;
				n = n / 10;
			}
		}
		
		return pro - sum;