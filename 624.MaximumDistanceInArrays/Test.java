

public  class Test {

	public static void main(String[] args) {
		int[][] arrays={{1,2,10},{4,5,6},{7,8,9}};
		int result=maxDistance(arrays);
			System.out.println("the maxdistance is " + result);
	}
	public static int maxDistance(int[][]  arrays){
		int minValue=arrays[0][0];
		int maxValue=arrays[0][arrays[0].length-1];
		int result=Integer.MIN_VALUE;
		
		for(int i=1;i<arrays.length;i++){
			result=Math.max(Math.abs(arrays[i][0]-maxValue),result);
			System.out.println("result1__"+ result);
			result=Math.max(result,Math.abs(minValue-arrays[i][arrays[i].length-1]));
			System.out.println("result2__ "+ result);
			if (arrays[i][0]<minValue ) {
				minValue=arrays[i][0];
			}	
			System.out.println("min " + minValue);
			if (arrays[i][arrays[i].length-1]>maxValue ) {
				maxValue=arrays[i][arrays[i].length-1];
			}	
			System.out.println("max " + maxValue);
		}
		
		return result;
		
	}
}
