// 15. 다음 JAVA로 구현된 프로그램을 분석하여 그 실행결과를 쓰시오.(2022.3회)
class Main {  
    public static void main(String args[]) { 
      int a[][]=new int [3][3];
      init(a);
      data(a);
      prnt(a);
    } 
  
    static void init(int a[][]){
      for(int i=0; i<3;i++)
        for(int j=0; j<3;j++)
          a[i][j]=0;
    }
  
      static void data(int a[][]){
        int v=1;
      for(int i=0; i<3;i++)
        for(int j=i; j<3;j++)
          a[i][j]=v++;
    }
  
      static void prnt (int a[][]){
      for(int i=0; i<3;i++){
        for(int j=0; j<3;j++){
          if(a[i][j]==0)
            System.out.printf(" ");
        else
            System.out.printf("%d", a[i][j]);
       }
        System.out.println();
      } 
    }
  }