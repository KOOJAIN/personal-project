
#include <iostream>


int main(void)
{
	//printf("Hello World");



	// �Ǽ��� ������

	/*
	float f = 46.5;
	printf("%.2f\n", f);
	double d = 4.428;
	printf("%.2lf\n", d);
	return 0;*/

	
	// ��� = ������ ���� ������ �ʰ� �������� ��?
	/*
	const int YEAR = 2000;		//const�� �Է������ν� ������ �ƴϰ� ������� ������ �ִ°���
	printf("�¾ �⵵ : %d\n", YEAR);
	YEAR = 2001			// const �������� ����� ���� �����ν� ������ �� ���Ե�.
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
	printf("���� �Է��ϼ��� : ");
	scanf_s("%d ", &input);	//"%d " : � �������¸� �ްڴ�. ���? &input �̶�� ������
	printf("�Է°� : %d\n", input);
	return 0;
	*/

	/*
	int ��, ��, ��;		// ���� int
	printf("3���� ������ �Է��ϼ��� : ");
	scanf_s("%d %d %d", &��, &��, &��);
	printf("ù��° �� : %d\n", ��);
	printf("�ι�° �� : %d\n", ��);
	printf("����° �� : %d\n", ��);

	return 0;
	*/


	// ����(�ѱ���) �ַ� char, ���ڿ�(�ѱ��� �̻��� ���� ����
	//char c = 'A';
	//printf("%c\n", c);
	//
	//char str[256];							//<----�迭 : char c�� �����ϱ����� ���� 256�� ����� ���Դϴ�.
	//scanf_s("%s", str, sizeof(str));					// %s : �迭�� �Է¹����� 
	//printf("%s\n", str);

	//return 0;


	// ������Ʈ
	// �������� �������� ������ �Լ� ( ���� �ۼ�)
	// �̸�? ����? ������? Ű? ���˸�?
	char name[256];
	printf("�̸��̹�����?");
	scanf_s("%s", name, sizeof(name));

	int age;
	printf("����̿���? ");
	scanf_s("%d", &age);

	float weight;
	printf("�����Դ� �� kg �̿���??");
	scanf_s("%f", &weight);

	double height;
	printf("Ű�� ���̿���?");
	scanf_s("%lf", &height);

	char what[256];
	printf("���� ����?");
	scanf_s("%s", what, sizeof(what));

	// ����  ���� ���
	printf("\n\n--- ������ ���� ---\n\n");
	print(" �̸�         : %s\n", name);
	print(" ����         : %d\n", age);
	print(" ������       : %.2f\n", weight);
	print(" Ű           : %.2lf\n", height);
	print(" ����         : %s\n", what);


	return 0;

}