#include <stdio.h>
#include <iostream>
#include <stdlib.h>
#include <time.h>

using namespace std;

int main(int argc, char const *argv[])
{
	unsigned seed = (unsigned)time(NULL);
	srand(seed);

	int opt;
	
	printf("input Dice Num\n");

	while(scanf("%d", &opt) == 1){
		if(opt == 1){
    		printf("output = %d\n", rand() % 6 + 1);
	 	}else if(opt == 2){
			printf("output = %d, %d\n", rand() % 6 + 1, rand() % 6 + 1);
		}else{
			printf("input error\n");
		}
		printf("input Dice Num\n");
	}
	return 0;
}