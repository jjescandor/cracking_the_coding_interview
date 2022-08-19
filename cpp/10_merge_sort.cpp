include <iostream>

using namespace std;


int main(){
    int[] unsortedInt = {4, 5, 1, 2, 3, 0, 6}

}

public int[] merge(int[] arr){
    if (sizeof(arr) > 1){
        int[] left = merget(arr);
        int[] right = merge(arr);
        arr = mergeSort(left, right, arr);
    }
    return arr
}

public int[] mergeSort(int[] left, int[] right, int[] arr){
    int i, j, k;
    i = j = k = 0;
    while(i < sizeof(left) && j < sizeof(right)){
        if (left[i] <= right[j]){
            arr[k] = left[i];
            i++;
        }else{
            arr[k] = right[j];
            j++;
        }
        k++
    }
    if (i < sizeof(left)){
        arr =  left;
    }else{
        arr = right;
    }
    return arr
}