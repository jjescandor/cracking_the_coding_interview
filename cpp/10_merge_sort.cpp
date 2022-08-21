#include <iostream>
using namespace std;


void printArray(int A[], int size){
    for(auto i = 0; i < size; i++)
        cout << A[i] << " ";
}

int main(){
    int arr[] = {4, 5, 1, 2, 3, 0, 6};
    int arr_size = sizeof(arr) / sizeof(arr[0]);
    cout << "Give array is \n";
    printArray(arr, arr_size);
}