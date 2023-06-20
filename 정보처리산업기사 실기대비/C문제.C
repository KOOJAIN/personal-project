// main() {
//   int n, sum=0;
//   printf("정수를 입력하시오 : ");
//   scanf("%d",&n);
//   for (int i=1; i<=n;i++)
//     sum=sum+i;
//   printf("%d", sum);
// }

#include <stdio.h>

main() {
  int sum=0;
  int i=0;
  for(i=0;i<=10;i++){
    if(i%2!=0)
      continue;
        sum+=i;
  }
  printf("%d",i+sum);
}