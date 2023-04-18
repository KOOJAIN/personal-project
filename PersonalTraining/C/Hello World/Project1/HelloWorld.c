
#include <iostream>


int main(void)
{
	//printf("Hello World");



	// 실수형 변수형

	/*
	float f = 46.5;
	printf("%.2f\n", f);
	double d = 4.428;
	printf("%.2lf\n", d);
	return 0;*/

	
	// 상수 = 변수와 같이 변하지 않고 고정적인 값?
	/*
	const int YEAR = 2000;		//const를 입력함으로써 변수아 아니고 상수임을 선언해 주는거임
	printf("태어난 년도 : %d\n", YEAR);
	YEAR = 2001			// const 선언으로 상수로 선언 함으로써 변경할 수 없게됨.
	return 0;
	*/

	/*
	// printf
	int add = 3 + 7; // 10
	printf("3 + 7 = %d\n", add);
	printf("%d + %d = %d\n", 5, 6, 5 + 6);

	return 0;
	*/

	/*
	int input;
	printf("값을 입력하세요 : ");
	scanf_s("%d ", &input);	//"%d " : 어떤 정수형태를 받겠다. 어디에? &input 이라는 변수에
	printf("입력값 : %d\n", input);
	return 0;
	*/

	/*
	int 일, 이, 삼;		// 숫자 int
	printf("3개의 정수를 입력하세요 : ");
	scanf_s("%d %d %d", &일, &이, &삼);
	printf("첫번째 값 : %d\n", 일);
	printf("두번째 값 : %d\n", 이);
	printf("세번째 값 : %d\n", 삼);

	return 0;
	*/


	// 문자(한글자) 주로 char, 문자열(한글자 이상의 여러 글자
	//char c = 'A';
	//printf("%c\n", c);
	//
	//char str[256];							//<----배열 : char c를 저장하기위한 공간 256을 만드는 것입니다.
	//scanf_s("%s", str, sizeof(str));					// %s : 배열을 입력받은때 
	//printf("%s\n", str);

	//return 0;


	// 프로젝트
	// 경찰관이 범죄자의 정보를 입수 ( 조서 작성)
	// 이름? 나이? 몸무게? 키? 범죄명?
	char name[256];
	printf("이름이뭐예요?");
	scanf_s("%s", name, sizeof(name));

	int age;
	printf("몇상이예요? ");
	scanf_s("%d", &age);

	float weight;
	printf("몸무게는 몇 kg 이예요??");
	scanf_s("%f", &weight);

	double height;
	printf("키는 몇이에요?");
	scanf_s("%lf", &height);

	char what[256];
	printf("무슨 범죄?");
	scanf_s("%s", what, sizeof(what));

	// 조서  내용 출력
	printf("\n\n--- 범죄자 정보 ---\n\n");
	print(" 이름         : %s\n", name);
	print(" 나이         : %d\n", age);
	print(" 몸무게       : %.2f\n", weight);
	print(" 키           : %.2lf\n", height);
	print(" 범죄         : %s\n", what);


	return 0;

}