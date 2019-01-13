public class Main {
    public static void main(String[] args) {
        productTable();
    }

    private static void productTable() {
        for (int i = 1; i <= 9; i++) {
            for (int j = 1; j <= i; j++) {
                System.out.printf("%d*%d=%d", j, i, i * j);
                System.out.print(" ");
                if (j == i) System.out.println();
            }
        }
    }

}
