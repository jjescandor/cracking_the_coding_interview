// Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.

#include <iostream>
#include <algorithm>

using namespace std;


bool containsDuplicate(int arr []){
  int n = sizeof(arr) / sizeof(arr[0]);
  sort(arr, arr + n);
  for (int i = 0; i< sizeof(arr); i++){
    if (i > 1 && arr[i-1] == arr[i]){
      return true;
    }
  }
  return false;
}


int main(){
  int arr [] = {1,2,2,3,4,5,6,7,8};
  bool result = containsDuplicate(arr);
  if(result > 0){
    cout << "Duplicate: True" << endl;
  }else{
    cout << "Duplicate: False" << endl;
  }
}
